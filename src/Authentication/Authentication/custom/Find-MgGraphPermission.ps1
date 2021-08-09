# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------

Set-StrictMode -Version 6.0

. "$psscriptroot/common/Permissions.ps1"

<#
.SYNOPSIS
Find permissions for authorization against Microsoft Graph
#>
function Find-MgGraphPermission {
    [cmdletbinding()]
    param (
        [string] $SearchString,
        [switch] $Online
    )

    $permissionsData = Permissions_GetPermissionsData $online

    $Permissions_GetOauthData = Permissions_GetOauthData $permissionsData
    $Permissions_GetAppRolesData = Permissions_GetAppRolesData $permissionsData
 

    # Creating a table specifically for Oauth2permissions data 
    $oauthData = @()
    $oauthData += $Permissions_GetOauthData | Where-Object Name -like *$SearchString*
    # $oauthData += Permissions_GetOauthData | Where-Object Description -like *$search* 
    $oauthData | Sort-Object -Property Name

    # Creating a table specifically for appRoles data 
    $appRolesData = @()
    $appRolesData += $Permissions_GetAppRolesData | Where-Object Name -like *$SearchString*
    # $appRolesData += Permissions_GetAppRolesData | Where-Object Description -like *$search*
    $appRolesData | Sort-Object -Property Name

}
