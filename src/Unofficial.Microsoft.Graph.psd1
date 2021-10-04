#
# Module manifest for module 'Unofficial.Microsoft.Graph'
#
#

@{

# Script module or binary module file associated with this manifest.
RootModule = 'Unofficial.Microsoft.Graph.dll'

# Version number of this module.
ModuleVersion = '1.7.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = '5074a162-d39f-4902-bf4e-bf31a934e77d'

# Author of this module
Author = 'Pär Björklund'

# Company or vendor of this module
CompanyName = 'Pär Björklund'

# Copyright statement for this module
Copyright = 'Pär Björklund per.bjorklund@gmail.com'

# Description of the functionality provided by this module
Description = 'Unofficial PowerShell Cmdlets for Microsoft Graph'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# ClrVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
#RequiredModules = @(@{ModuleName = '../../Authentication/Authentication/Microsoft.Graph.Authentication.psd1'; ModuleVersion = '1.7.0'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = 'Unofficial.Microsoft.Graph.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = 'Unofficial.Microsoft.Graph.format.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
#FunctionsToExport = @()



# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = 'Connect-MgGraph', 'Disconnect-MgGraph', 'Get-MgContext',
               'Get-MgProfile', 'Select-MgProfile', 'Invoke-MgGraphRequest',
               'Add-MgEnvironment', 'Get-MgEnvironment', 'Remove-MgEnvironment',
               'Set-MgEnvironment', 'Get-MgSecurityAction', 'Get-MgSecurityAlert',
               'New-MgSecurityAction', 'Get-MgSecuritySecureScore', 'Get-MgUser',
               'Get-MgUserCreatedObject', 'Get-MgUserLicenseDetail', 'Get-MgUserSetting'

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = 'Connect-Graph', 'Disconnect-Graph', 'Invoke-GraphRequest'

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    #Profiles of this module
    Profiles =  @('v1.0-beta')

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Microsoft','Office365','Graph','PowerShell'

        # A URL to the license for this module.
        LicenseUri = 'https://github.com/Paxxi/msgraph-sdk-powershell'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Paxxi/msgraph-sdk-powershell'

        # A URL to an icon representing this module.
        IconUri = 'https://raw.githubusercontent.com/microsoftgraph/msgraph-sdk-powershell/master/documentation/images/graph_color256.png'

        # ReleaseNotes of this module
        ReleaseNotes = 'See https://github.com/Paxxi/msgraph-sdk-powershell.'

        # Prerelease string of this module
        Prerelease = 'preview1'

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

} # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

