import-module ..\bin\Unofficial.Microsoft.Graph.psd1
Connect-MgGraph -Scopes SecurityEvents.Read.All,SecurityActions.ReadWrite.All
$param = New-Object -TypeName Microsoft.Graph.PowerShell.Security.Models.MicrosoftGraphKeyValuePair
$param.Name = "IP"
$param.Value = "1.2.3.4"
$obj = New-Object -TypeName Microsoft.Graph.PowerShell.Security.Models.MgAction
$obj.Parameters = @($param)
$obj.Name = "Test"
$obj.ActionReason = "Testing"
$obj.VendorInformation.Provider = "Windows Defender ATP"
$obj.VendorInformation.Vendor = "Microsoft"
New-MgSecurityAction -InputObject $obj