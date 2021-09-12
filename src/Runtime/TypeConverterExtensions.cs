/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace Microsoft.Graph.PowerShell.Runtime.PowerShell
{
    public static class TypeConverterExtensions
    {
        public static T[] SelectToArray<T>(object source, System.Func<object, object> converter)
        {
            // null begets null
            if (source == null)
            {
                return null;
            }

            // single values and strings are just encapsulated in the array.
            if (source is string || !(source is System.Collections.IEnumerable))
            {
                try
                {
                    return new T[] { (T)converter(source) };
                }
#if DEBUG
                catch (System.Exception E)
                {
                    System.Console.Error.WriteLine($"{E.GetType().Name}/{E.Message}/{E.StackTrace}");
                }
#else
                catch 
                {
                    // silent conversion fail
                }            
#endif
                return new T[0]; // empty result if couldn't convert.
            }

            var result = new System.Collections.Generic.List<T>();
            foreach (var each in (System.Collections.IEnumerable)source)
            {
                try
                {
                    result.Add((T)converter(each));
                }
#if DEBUG
                catch (System.Exception E)
                {
                    System.Console.Error.WriteLine($"{E.GetType().Name}/{E.Message}/{E.StackTrace}");
                }
#else
                catch 
                {
                    // silent conversion fail
                }            
#endif
            }
            return result.ToArray();
        }

        public static System.Collections.Generic.IEnumerable<object> GetPropertyKeys<K, V>(this System.Collections.Generic.IDictionary<K, V> dictionary)
        {
            if (null != dictionary)
            {
                foreach (var each in dictionary.Keys)
                {
                    yield return each;
                }
            }
        }
        public static System.Collections.Generic.IEnumerable<object> GetPropertyKeys(this System.Collections.IDictionary dictionary)
        {
            if (null != dictionary)
            {
                foreach (var each in dictionary.Keys)
                {
                    yield return each;
                }
            }
        }
        public static System.Collections.Generic.IEnumerable<object> GetPropertyKeys(this System.Management.Automation.PSObject instance)
        {
            if (null != instance)
            {
                foreach (var each in instance.Properties)
                {
                    yield return each;
                }
            }
        }

        public static System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K, V>> GetFilteredProperties<K, V>(this System.Collections.Generic.IDictionary<K, V> instance, System.Collections.Generic.HashSet<string> exclusions = null, System.Collections.Generic.HashSet<string> inclusions = null)
        {
            return (null == instance || instance.Count == 0) ?
                 Enumerable.Empty<System.Collections.Generic.KeyValuePair<K, V>>() :
                 instance.Keys
                    .Where(key =>
                       !(true == exclusions?.Contains(key?.ToString(), System.StringComparer.OrdinalIgnoreCase))
                       && (false != inclusions?.Contains(key?.ToString(), System.StringComparer.OrdinalIgnoreCase)))
                    .Select(key => new System.Collections.Generic.KeyValuePair<K, V>(key, instance[key]));
        }

        public static System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> GetFilteredProperties(this System.Collections.IDictionary instance, System.Collections.Generic.HashSet<string> exclusions = null, System.Collections.Generic.HashSet<string> inclusions = null)
        {
            return (null == instance || instance.Count == 0) ?
                 Enumerable.Empty<System.Collections.Generic.KeyValuePair<object, object>>() :
                 instance.Keys.OfType<object>()
                    .Where(key =>
                       !(true == exclusions?.Contains(key?.ToString(), System.StringComparer.OrdinalIgnoreCase))
                       && (false != inclusions?.Contains(key?.ToString(), System.StringComparer.OrdinalIgnoreCase)))
                    .Select(key => new System.Collections.Generic.KeyValuePair<object, object>(key, instance[key]));
        }

        public static System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> GetFilteredProperties(this System.Management.Automation.PSObject instance, System.Collections.Generic.HashSet<string> exclusions = null, System.Collections.Generic.HashSet<string> inclusions = null)
        {
            // new global::System.Collections.Generic.HashSet<string>(System.StringComparer.InvariantCultureIgnoreCase)
            return (null == instance || !instance.Properties.Any()) ?
                 Enumerable.Empty<System.Collections.Generic.KeyValuePair<object, object>>() :
                 instance.Properties
                    .Where(property =>
                       !(true == exclusions?.Contains(property.Name, System.StringComparer.OrdinalIgnoreCase))
                       && (false != inclusions?.Contains(property.Name, System.StringComparer.OrdinalIgnoreCase)))
                    .Select(property => new System.Collections.Generic.KeyValuePair<object, object>(property.Name, property.Value));
        }


        public static T GetValueForProperty<T, K, V>(this System.Collections.Generic.IDictionary<K, V> dictionary, string propertyName, T defaultValue, System.Func<object, T> converter)
        {
            try
            {
                var key = Enumerable.FirstOrDefault(dictionary.Keys, each => string.Equals(each.ToString(), propertyName, System.StringComparison.CurrentCultureIgnoreCase));
                return key == null ? defaultValue : (T)converter(dictionary[key]);
            }
#if DEBUG
            catch (System.Exception E)
            {
                System.Console.Error.WriteLine($"{E.GetType().Name}/{E.Message}/{E.StackTrace}");
            }
#else
            catch 
            {
            }            
#endif
            return defaultValue;
        }
        public static T GetValueForProperty<T>(this System.Collections.IDictionary dictionary, string propertyName, T defaultValue, System.Func<object, T> converter)
        {
            try
            {
                var key = Enumerable.FirstOrDefault(dictionary.Keys.OfType<object>(), each => string.Equals(each.ToString(), propertyName, System.StringComparison.CurrentCultureIgnoreCase));
                return key == null ? defaultValue : (T)converter(dictionary[key]);
            }
#if DEBUG
            catch (System.Exception E)
            {
                System.Console.Error.WriteLine($"{E.GetType().Name}/{E.Message}/{E.StackTrace}");
            }
#else
            catch 
            {
            }            
#endif
            return defaultValue;
        }

        public static T GetValueForProperty<T>(this System.Management.Automation.PSObject psObject, string propertyName, T defaultValue, System.Func<object, T> converter)
        {
            try
            {
                var property = Enumerable.FirstOrDefault(psObject.Properties, each => string.Equals(each.Name.ToString(), propertyName, System.StringComparison.CurrentCultureIgnoreCase));
                return property == null ? defaultValue : (T)converter(property.Value);
            }
#if DEBUG
            catch (System.Exception E)
            {
                System.Console.Error.WriteLine($"{E.GetType().Name}/{E.Message}/{E.StackTrace}");
            }
#else
            catch 
            {
            }            
#endif
            return defaultValue;
        }
    }
}
