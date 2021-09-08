#
# Module manifest for module 'Microsoft.Graph.Sites'
#
# Generated by: Microsoft Corporation
#
# Generated on: 2021-09-08
#

@{

# Script module or binary module file associated with this manifest.
RootModule = './Microsoft.Graph.Sites.psm1'

# Version number of this module.
ModuleVersion = '1.7.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'e763a0a3-6ca7-4fa3-a97f-9e8b23202d55'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Graph PowerShell Cmdlets'

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
RequiredModules = @(@{ModuleName = 'Microsoft.Graph.Authentication'; ModuleVersion = '1.6.0'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = './bin/Microsoft.Graph.Sites.private.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = './Microsoft.Graph.Sites.format.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = 'Add-MgSiteContentTypeBaseTypeCopy', 'Add-MgSiteContentTypeCopy', 
               'Add-MgSiteListContentTypeBaseTypeCopy', 
               'Add-MgSiteListContentTypeCopy', 
               'Copy-MgSiteContentTypeBaseToDefaultContentLocation', 
               'Copy-MgSiteContentTypeToDefaultContentLocation', 
               'Copy-MgSiteListContentTypeBaseToDefaultContentLocation', 
               'Copy-MgSiteListContentTypeToDefaultContentLocation', 
               'Copy-MgSiteOnenoteNotebook', 'Copy-MgSiteOnenotePageToSection', 
               'Copy-MgSiteOnenoteSectionToNotebook', 
               'Copy-MgSiteOnenoteSectionToSectionGroup', 'Get-MgGroupSite', 
               'Get-MgSite', 'Get-MgSiteActivityByInterval', 'Get-MgSiteAnalytic', 
               'Get-MgSiteAnalyticByRef', 'Get-MgSiteApplicableContentType', 
               'Get-MgSiteByPath', 'Get-MgSiteColumn', 
               'Get-MgSiteColumnSourceColumn', 'Get-MgSiteColumnSourceColumnByRef', 
               'Get-MgSiteContentType', 'Get-MgSiteContentTypeBase', 
               'Get-MgSiteContentTypeBaseByRef', 'Get-MgSiteContentTypeBaseType', 
               'Get-MgSiteContentTypeBaseTypeByRef', 'Get-MgSiteContentTypeColumn', 
               'Get-MgSiteContentTypeColumnLink', 
               'Get-MgSiteContentTypeColumnPosition', 
               'Get-MgSiteContentTypeColumnPositionByRef', 
               'Get-MgSiteContentTypeColumnSourceColumn', 
               'Get-MgSiteContentTypeColumnSourceColumnByRef', 'Get-MgSiteDelta', 
               'Get-MgSiteDrive', 'Get-MgSiteExternalColumn', 
               'Get-MgSiteExternalColumnByRef', 'Get-MgSiteList', 
               'Get-MgSiteListActivity', 'Get-MgSiteListColumn', 
               'Get-MgSiteListColumnSourceColumn', 
               'Get-MgSiteListColumnSourceColumnByRef', 
               'Get-MgSiteListContentType', 'Get-MgSiteListContentTypeBase', 
               'Get-MgSiteListContentTypeBaseByRef', 
               'Get-MgSiteListContentTypeBaseType', 
               'Get-MgSiteListContentTypeBaseTypeByRef', 
               'Get-MgSiteListContentTypeColumn', 
               'Get-MgSiteListContentTypeColumnLink', 
               'Get-MgSiteListContentTypeColumnPosition', 
               'Get-MgSiteListContentTypeColumnPositionByRef', 
               'Get-MgSiteListContentTypeColumnSourceColumn', 
               'Get-MgSiteListContentTypeColumnSourceColumnByRef', 
               'Get-MgSiteListDrive', 'Get-MgSiteListItem', 
               'Get-MgSiteListItemActivityByInterval', 
               'Get-MgSiteListItemAnalytic', 'Get-MgSiteListItemAnalyticByRef', 
               'Get-MgSiteListItemDriveItem', 'Get-MgSiteListItemDriveItemContent', 
               'Get-MgSiteListItemField', 'Get-MgSiteListItemVersion', 
               'Get-MgSiteListItemVersionField', 'Get-MgSiteListSubscription', 
               'Get-MgSiteOnenoteNotebookFromWebUrl', 'Get-MgSitePage', 
               'Get-MgSitePermission', 'Get-MgSiteRecentNotebook', 'Get-MgSubSite', 
               'Get-MgUserFollowedSite', 'Get-MgUserFollowedSiteByRef', 
               'Grant-MgSitePermission', 'Invoke-MgPreviewSiteOnenotePage', 
               'Join-MgSiteContentType', 'Join-MgSiteContentTypeBase', 
               'Join-MgSiteListContentType', 'Join-MgSiteListContentTypeBase', 
               'New-MgGroupSite', 'New-MgSite', 'New-MgSiteColumn', 
               'New-MgSiteContentType', 'New-MgSiteContentTypeBaseTypeByRef', 
               'New-MgSiteContentTypeColumn', 'New-MgSiteContentTypeColumnLink', 
               'New-MgSiteContentTypeColumnPositionByRef', 'New-MgSiteDrive', 
               'New-MgSiteExternalColumnByRef', 'New-MgSiteList', 
               'New-MgSiteListColumn', 'New-MgSiteListContentType', 
               'New-MgSiteListContentTypeBaseTypeByRef', 
               'New-MgSiteListContentTypeColumn', 
               'New-MgSiteListContentTypeColumnLink', 
               'New-MgSiteListContentTypeColumnPositionByRef', 
               'New-MgSiteListItem', 'New-MgSiteListItemLink', 
               'New-MgSiteListItemVersion', 'New-MgSiteListSubscription', 
               'New-MgSitePage', 'New-MgSitePermission', 'New-MgSubSite', 
               'New-MgUserFollowedSiteByRef', 'Publish-MgSiteContentType', 
               'Publish-MgSiteContentTypeBase', 'Publish-MgSiteListContentType', 
               'Publish-MgSiteListContentTypeBase', 'Publish-MgSitePage', 
               'Remove-MgGroupSite', 'Remove-MgSiteAnalyticByRef', 
               'Remove-MgSiteColumn', 'Remove-MgSiteColumnSourceColumnByRef', 
               'Remove-MgSiteContentType', 'Remove-MgSiteContentTypeBaseByRef', 
               'Remove-MgSiteContentTypeColumn', 
               'Remove-MgSiteContentTypeColumnLink', 
               'Remove-MgSiteContentTypeColumnSourceColumnByRef', 
               'Remove-MgSiteDrive', 'Remove-MgSiteList', 'Remove-MgSiteListColumn', 
               'Remove-MgSiteListColumnSourceColumnByRef', 
               'Remove-MgSiteListContentType', 
               'Remove-MgSiteListContentTypeBaseByRef', 
               'Remove-MgSiteListContentTypeColumn', 
               'Remove-MgSiteListContentTypeColumnLink', 
               'Remove-MgSiteListContentTypeColumnSourceColumnByRef', 
               'Remove-MgSiteListDrive', 'Remove-MgSiteListItem', 
               'Remove-MgSiteListItemAnalyticByRef', 
               'Remove-MgSiteListItemDriveItem', 'Remove-MgSiteListItemField', 
               'Remove-MgSiteListItemVersion', 'Remove-MgSiteListItemVersionField', 
               'Remove-MgSiteListSubscription', 'Remove-MgSitePage', 
               'Remove-MgSitePermission', 'Restore-MgSiteListItemVersion', 
               'Revoke-MgSitePermissionGrant', 'Set-MgSiteAnalyticByRef', 
               'Set-MgSiteColumnSourceColumnByRef', 
               'Set-MgSiteContentTypeBaseByRef', 
               'Set-MgSiteContentTypeColumnSourceColumnByRef', 
               'Set-MgSiteListColumnSourceColumnByRef', 
               'Set-MgSiteListContentTypeBaseByRef', 
               'Set-MgSiteListContentTypeColumnSourceColumnByRef', 
               'Set-MgSiteListItemAnalyticByRef', 
               'Set-MgSiteListItemDriveItemContent', 
               'Test-MgSiteContentTypeBasePublished', 
               'Test-MgSiteContentTypePublished', 
               'Test-MgSiteListContentTypeBasePublished', 
               'Test-MgSiteListContentTypePublished', 
               'Unpublish-MgSiteContentType', 'Unpublish-MgSiteContentTypeBase', 
               'Unpublish-MgSiteListContentType', 
               'Unpublish-MgSiteListContentTypeBase', 'Update-MgGroupSite', 
               'Update-MgSite', 'Update-MgSiteColumn', 'Update-MgSiteContentType', 
               'Update-MgSiteContentTypeColumn', 
               'Update-MgSiteContentTypeColumnLink', 'Update-MgSiteDrive', 
               'Update-MgSiteList', 'Update-MgSiteListColumn', 
               'Update-MgSiteListContentType', 
               'Update-MgSiteListContentTypeColumn', 
               'Update-MgSiteListContentTypeColumnLink', 'Update-MgSiteListDrive', 
               'Update-MgSiteListItem', 'Update-MgSiteListItemDriveItem', 
               'Update-MgSiteListItemField', 'Update-MgSiteListItemVersion', 
               'Update-MgSiteListItemVersionField', 
               'Update-MgSiteListSubscription', 'Update-MgSiteOnenotePageContent', 
               'Update-MgSitePage', 'Update-MgSitePermission', 'Update-MgSubSite'

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = '*'

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    #Profiles of this module
    Profiles =  @('v1.0','v1.0-beta')

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Microsoft','Office365','Graph','PowerShell'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/devservicesagreement'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/microsoftgraph/msgraph-sdk-powershell'

        # A URL to an icon representing this module.
        IconUri = 'https://raw.githubusercontent.com/microsoftgraph/msgraph-sdk-powershell/master/documentation/images/graph_color256.png'

        # ReleaseNotes of this module
        ReleaseNotes = 'See https://aka.ms/GraphPowerShell-Release.'

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

