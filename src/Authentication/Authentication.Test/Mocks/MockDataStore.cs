﻿namespace Microsoft.Graph.Authentication.Test.Mocks
{
    using Microsoft.Graph.PowerShell.Authentication;
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;

    public class MockDataStore : IDataStore
    {
        private const string FolderName = "Folder";
        private Dictionary<string, bool> writeLocks = new Dictionary<string, bool>(StringComparer.InvariantCultureIgnoreCase);
        private Dictionary<string, uint> readLocks = new Dictionary<string, uint>(StringComparer.InvariantCultureIgnoreCase);

        public IDictionary<string, string> VirtualStore = new ConcurrentDictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);

        public void CopyFile(string oldPath, string newPath)
        {
            if (VirtualStore.ContainsKey(oldPath))
            {
                VirtualStore[newPath] = VirtualStore[oldPath];
            }
            else
            {
                throw new IOException("File not found: " + oldPath);
            }
        }

        public void CreateDirectory(string path)
        {
            VirtualStore[path] = FolderName;
        }

        public void DeleteDirectory(string dir)
        {
            foreach (var key in VirtualStore.Keys.ToArray())
            {
                if (key.StartsWith(dir))
                {
                    VirtualStore.Remove(key);
                }
            }
        }

        public void DeleteFile(string path)
        {
            if (VirtualStore.ContainsKey(path))
            {
                VirtualStore.Remove(path);
            }
            else
            {
                throw new IOException("File not found: " + path);
            }
        }

        public bool DirectoryExists(string path)
        {
            foreach (var key in VirtualStore.Keys.ToArray())
            {
                if (key.StartsWith(path))
                {
                    return true;
                }
            }
            return false;
        }

        public void EmptyDirectory(string dirPath)
        {
            foreach (var key in VirtualStore.Keys.ToArray())
            {
                if (key.StartsWith(dirPath))
                {
                    VirtualStore.Remove(key);
                }
            }
        }

        public bool FileExists(string path)
        {
            return VirtualStore.ContainsKey(path);
        }

        public string[] GetDirectories(string sourceDirName)
        {
            HashSet<string> dirs = new HashSet<string>();
            foreach (var key in VirtualStore.Keys.ToArray())
            {
                if (key.StartsWith(sourceDirName))
                {
                    var directoryName = Path.GetDirectoryName(key);
                    if (!dirs.Contains(directoryName))
                    {
                        dirs.Add(directoryName);
                    }
                }
            }
            return dirs.ToArray();
        }

        public string[] GetDirectories(string startDirectory, string filePattern, SearchOption options)
        {
            HashSet<string> dirs = new HashSet<string>();
            foreach (var key in VirtualStore.Keys.ToArray())
            {
                if (key.StartsWith(startDirectory) && Regex.IsMatch(key, WildcardToRegex(filePattern), RegexOptions.IgnoreCase))
                {
                    var directoryName = Path.GetDirectoryName(key);
                    if (!dirs.Contains(directoryName))
                    {
                        dirs.Add(directoryName);
                    }
                }
            }
            return dirs.ToArray();
        }

        public FileAttributes GetFileAttributes(string path)
        {
            if (VirtualStore[path] == FolderName)
            {
                return FileAttributes.Directory;
            }
            if (VirtualStore.ContainsKey(path))
            {
                return FileAttributes.Normal;
            }
            else
            {
                foreach (var key in VirtualStore.Keys.ToArray())
                {
                    if (key.StartsWith(path))
                    {
                        return FileAttributes.Directory;
                    }
                }
                throw new IOException("File not found: " + path);
            }
        }

        public string[] GetFiles(string sourceDirName)
        {
            HashSet<string> files = new HashSet<string>();
            foreach (var key in VirtualStore.Keys.ToArray())
            {
                if (key.StartsWith(sourceDirName) && VirtualStore[key] != FolderName)
                {
                    if (!files.Contains(key))
                    {
                        files.Add(key);
                    }
                }
            }
            return files.ToArray();
        }

        public string[] GetFiles(string startDirectory, string filePattern, SearchOption options)
        {
            HashSet<string> files = new HashSet<string>();
            foreach (var key in VirtualStore.Keys.ToArray())
            {
                if (key.StartsWith(startDirectory) && VirtualStore[key] != FolderName && Regex.IsMatch(key, WildcardToRegex(filePattern), RegexOptions.IgnoreCase))
                {
                    if (!files.Contains(key))
                    {
                        files.Add(key);
                    }
                }
            }
            return files.ToArray();
        }

        public Stream OpenForExclusiveWrite(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException(nameof(path));
            }

            if (writeLocks.ContainsKey(path) && writeLocks[path])
            {
                throw new IOException($"File {path} is open for writing");
            }
            else if (readLocks.ContainsKey(path) && readLocks[path] > 0)
            {
                throw new IOException($"File {path} is open for reading");
            }
            else
            {
                writeLocks[path] = true;
            }

            if (!FileExists(path))
            {
                VirtualStore[path] = string.Empty;
            }
            byte[] buffer = new byte[16384];
            var copyBytes = Encoding.UTF8.GetBytes(VirtualStore[path]);
            for (int i = 0; i < copyBytes.Length && i < buffer.Length; ++i) buffer[i] = copyBytes[i];
            return new LockingMemoryStream(buffer, true,
                () =>
                {
                    writeLocks[path] = false;
                    VirtualStore[path] = Encoding.UTF8.GetString(buffer);
                }
             );
        }

        public Stream OpenForSharedRead(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException(nameof(path));
            }

            if (writeLocks.ContainsKey(path) && writeLocks[path])
            {
                throw new IOException($"File {path} is open for writing");
            }
            else if (readLocks.ContainsKey(path))
            {
                readLocks[path]++;
            }
            else
            {
                readLocks[path] = 1;
            }

            if (!FileExists(path))
            {
                VirtualStore[path] = string.Empty;
            }

            return new LockingMemoryStream(Encoding.UTF8.GetBytes(VirtualStore[path]), false, () => readLocks[path]--);
        }

        public byte[] ReadFileAsBytes(string path)
        {
            if (VirtualStore.ContainsKey(path))
            {
                return Encoding.Default.GetBytes(VirtualStore[path]);
            }
            else
            {
                throw new IOException("File not found: " + path);
            }
        }

        public Stream ReadFileAsStream(string path)
        {
            if (VirtualStore.ContainsKey(path))
            {
                MemoryStream stream = new MemoryStream();
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(VirtualStore[path]);
                writer.Flush();
                stream.Position = 0;
                return stream;
            }
            else
            {
                throw new IOException("File not found: " + path);
            }
        }

        public string ReadFileAsText(string path)
        {
            if (VirtualStore.ContainsKey(path))
            {
                return VirtualStore[path];
            }
            else
            {
                throw new IOException("File not found: " + path);
            }
        }

        public void RenameFile(string oldPath, string newPath)
        {
            if (VirtualStore.ContainsKey(oldPath))
            {
                VirtualStore[newPath] = VirtualStore[oldPath];
                VirtualStore.Remove(oldPath);
            }
            else
            {
                throw new IOException("File not found: " + oldPath);
            }
        }

        public void WriteFile(string path, string contents)
        {
            VirtualStore[path] = contents;
        }

        public void WriteFile(string path, string contents, Encoding encoding)
        {
            WriteFile(path, contents);
        }

        public void WriteFile(string path, byte[] contents)
        {
            VirtualStore[path] = Encoding.Default.GetString(contents);
        }

        /// <summary>
        /// Converts unix asterisk based file pattern to regex.
        /// </summary>
        /// <param name="wildcard">Asterisk based pattern.</param>
        /// <returns>Regular expression of null is empt.y</returns>
        private static string WildcardToRegex(string wildcard)
        {
            if (wildcard == null || wildcard == "") return wildcard;

            StringBuilder sb = new StringBuilder();

            char[] chars = wildcard.ToCharArray();
            for (int i = 0; i < chars.Length; ++i)
            {
                if (chars[i] == '*')
                    sb.Append(".*");
                else if (chars[i] == '?')
                    sb.Append(".");
                else if ("+()^$.{}|\\".IndexOf(chars[i]) != -1)
                    sb.Append('\\').Append(chars[i]); // prefix all meta-characters with backslash.
                else
                    sb.Append(chars[i]);
            }
            return sb.ToString().ToLowerInvariant();
        }

        private class LockingMemoryStream : MemoryStream
        {
            Action _unlock;
            int _closed = 0;
            public LockingMemoryStream(byte[] data, bool writable, Action unlockAction) : base(data, writable)
            {
                _unlock = unlockAction;
            }

            public override void Close()
            {
                if (Interlocked.Exchange(ref _closed, 1) == 0)
                {
                    _unlock();
                }

                base.Close();
            }
        }
    }
}
