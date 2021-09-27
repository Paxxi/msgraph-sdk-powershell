# Microsoft Graph AutoRest Configuration

> Common

```yaml
azure: false
powershell: true
version: latest
use: "file:///c:/code/autorest/packages/extensions/powershell/"
metadata:
  authors: Microsoft Corporation
  owners: Microsoft Corporation
  companyName: Microsoft Corporation
  description: "Microsoft Graph PowerShell Cmdlets"
  copyright: &copy; Microsoft Corporation. All rights reserved.
  tags: Microsoft Office365 Graph PowerShell
  requireLicenseAcceptance: true
  licenseUri: https://aka.ms/devservicesagreement
  projectUri: https://github.com/microsoftgraph/msgraph-sdk-powershell
  iconUri: https://raw.githubusercontent.com/microsoftgraph/g-raph/master/g-raph.png
```

> Names

```yaml
prefix: Mg
module-name: Microsoft.Graph.$(service-name)
subject-prefix: $(service-name)
namespace: Microsoft.Graph.PowerShell.$(service-name)
sanitize-names: false
```

> Folders

```yaml
clear-output-folder: true
output-folder: .
```

> Profiles

```yaml
tag: all-api-versions
profile:
  - v1.0-beta
```

> Custom Directives

```yaml
declare-directive:
  where-operation-byRegex: >-
    (() => {
      return { from: "openapi-document", where: `$..paths.*[?(/${$}/gmi.exec(@.operationId))]` };
    })()
  remove-path-by-operation: >-
    [{
      from: 'openapi-document',
      "where-operation-byRegex": $,
      transform: '$ = undefined'
    }]
```

> Directives

```yaml
directive:
  - no-inline:
      - microsoft.graph.sharepointIds
      - microsoft.graph.identitySet
      - microsoft.graph.itemReference
      - microsoft.graph.directoryObject
      - microsoft.graph.user
      - microsoft.graph.drive
      - microsoft.graph.listItem
      - microsoft.graph.post
      - microsoft.graph.sectionGroup
      - microsoft.graph.team
      - microsoft.graph.recipient
      - microsoft.graph.groupPolicyCategory
      - microsoft.graph.printer
      - microsoft.graph.printerShare
      - microsoft.graph.governanceResource
      - microsoft.graph.governanceRoleAssignment
      - microsoft.graph.governanceRoleDefinition
      - microsoft.graph.workbookOperationError
      - microsoft.graph.parentLabelDetails
      - microsoft.graph.ediscovery.tag
      - microsoft.graph.ediscovery.sourceCollection
      - microsoft.graph.contentType
      - microsoft.graph.columnDefinition
      - MgSectionGroup
      - MgContentType
      - MgColumnDefinition
      - MgWorkbookOperationError
      - MgTeam
      - MgPost
      - MgParentLabelDetails
      - MgUser
      - MgDrive
      - MgListItem
      - MgSectionGroup
      - MgContentType
      - MgColumnDefinition
      - MgWorkbookOperationError
      - MgTeam
      - MgPost
      - MgParentLabelDetails
      - MgUser
      - MgDrive
      - MgListItem

  # Set parameter alias
  - where:
      parameter-name: OrderBy
    set:
      parameter-name: Sort
      alias: OrderBy
  - where:
      parameter-name: Top
    set:
      alias:
        - Limit
  - where:
      parameter-name: Select
    set:
      parameter-name: Property
      alias: Select
  - where:
      parameter-name: Expand
    set:
      parameter-name: ExpandProperty
      alias: Expand
  # Format cmdlet response.
  - where:
      model-name: ^MicrosoftGraphUser\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - Mail
          - UserPrincipalName
          - UserType
  - where:
      model-name: ^MicrosoftGraphPerson\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - MailboxType
          - PersonType
          - IsFavorite
  - where:
      model-name: ^MicrosoftGraphContact\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - EmailAddresses
          - Phones
          - CreatedDateTime
  - where:
      model-name: ^MicrosoftGraphCalendar\d*$
    set:
      format-table:
        properties:
          - Id
          - Name
          - OwnerName
          - OwnerAddress
  - where:
      model-name: ^MicrosoftGraphEvent\d*$
    set:
      format-table:
        properties:
          - Id
          - Subject
          - StartDateTime
          - StartTimeZone
          - EndDateTime
          - EndTimeZone
  - where:
      model-name: ^MicrosoftGraphDrive\d*$
    set:
      format-table:
        properties:
          - Id
          - Name
          - DriveType
          - CreatedDateTime
  - where:
      model-name: ^MicrosoftGraphDriveItem\d*$
    set:
      format-table:
        properties:
          - Id
          - Name
          - WebUrl
          - FolderChildCount
          - Size
          - CreatedDateTime
  - where:
      model-name: ^MicrosoftGraphList\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - Name
          - WebUrl
          - CreatedDateTime
  - where:
      model-name: ^MicrosoftGraphSite\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - Name
          - SiteCollectionHostname
          - WebUrl
  - where:
      model-name: ^MicrosoftGraphGroup\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - Description
          - GroupTypes
          - AccessType
  - where:
      model-name: ^MicrosoftGraphTeam\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - Description
          - IsArchived
  - where:
      model-name: ^MicrosoftGraphMessage\d*$
    set:
      format-table:
        properties:
          - Id
          - Subject
          - FromEmailAddressAddress
          - ReceivedDateTime
          - BodyContentType
          - hasAttachments
  - where:
      model-name: ^MicrosoftGraphNotebook\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - CreatedDateTime
          - IsShared
          - IsDefault
  - where:
      model-name: ^MicrosoftGraphSectionGroup\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - CreatedDateTime
          - ParentNotebookDisplayName
          - IsDefault
  - where:
      model-name: ^MicrosoftGraphConversation\d*$
    set:
      format-table:
        properties:
          - Id
          - Topic
          - UniqueSenders
          - HasAttachments
          - Threads
          - LastDeliveredDateTime
  - where:
      model-name: ^MicrosoftGraphConversationThread\d*$
    set:
      format-table:
        properties:
          - Id
          - Topic
          - UniqueSenders
          - HasAttachments
          - Posts
          - LastDeliveredDateTime
  - where:
      model-name: ^MicrosoftGraphPost\d*$
    set:
      format-table:
        properties:
          - Id
          - SenderEmailAddressAddress
          - BodyContentType
          - HasAttachments
          - ReceivedDateTime
  - where:
      model-name: ^MicrosoftGraphDirectoryObject\d*$
    set:
      format-table:
        properties:
          - Id
          - DeletedDateTime
  - where:
      model-name: ^MicrosoftGraphPlace\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - AddressCity
          - Phone
  - where:
      model-name: ^MicrosoftGraphPlannerTask\d*$
    set:
      format-table:
        properties:
          - Id
          - PlanId
          - BucketId
          - Title
          - Priority
          - StartDateTime
          - CompletedDateTime
          - PercentComplete
  - where:
      model-name: ^MicrosoftGraphPlannerPlan\d*$
    set:
      format-table:
        properties:
          - Id
          - Title
          - Owner
          - CreatedDateTime
  - where:
      model-name: ^MicrosoftGraphPlannerPlanDetails\d*$
    set:
      format-table:
        properties:
          - Id
          - CategoryDescriptions
          - SharedWith
          - ContextDetails
  - where:
      model-name: ^MicrosoftGraphSchemaExtension\d*$
    set:
      format-table:
        properties:
          - Id
          - Description
          - Properties
          - TargetTypes
          - Status
          - Owner
  - where:
      model-name: ^MicrosoftGraphContact\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - emailAddresses
  - where:
      model-name: ^MicrosoftGraphApplication\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - AppId
          - SignInAudience
          - PublisherDomain
  - where:
      model-name: ^MicrosoftGraphServicePrincipal\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - AppId
          - SignInAudience
          - PublisherName
  - where:
      model-name: ^MicrosoftGraphTodoTaskList\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - IsOwner
          - IsShared
          - WellknownListName
  - where:
      model-name: ^MicrosoftGraphTodoTask\d*$
    set:
      format-table:
        properties:
          - Id
          - Title
          - Status
          - Body
          - DueDateTime
          - Importance
  # Rename cmdlets
  - where:
      verb: Invoke
      subject: (^Delta)(.*)
    set:
      verb: Get
      subject: $2$1
  - where:
      verb: Test
      variant: ^(Check|Verify)(.*)
    set:
      verb: Confirm
  # Rename all /$ref cmdlets to *ByRef e.g. New-MgGroupOwnerByRef
  - where:
      subject: ^(\w*[a-z])Ref([A-Z]\w*)$
    set:
      subject: $1$2ByRef
  # Remove *ByRef commands
  - where:
      verb: Get|Remove|New
      subject: ^UserPlanner(FavoritePlanByRef|RecentPlanByRef|RosterPlanByRef)$
    remove: true
  # Rename *ByRef commands
  - where:
      verb: Get|New
      subject: ^GroupMemberByRef$
      variant: ^List$|^Create$|^CreateExpanded$|^CreateViaIdentity$|^CreateViaIdentityExpanded$|^List3$|^Create3$|^CreateExpanded3$|^CreateViaIdentity3$|^CreateViaIdentityExpanded3$
    set:
      subject: GroupMemberOfByRef
  - where:
      verb: Get|New
      subject: ^GroupMemberByRef$
      variant: ^List2$|^Create2$|^CreateExpanded2$|^CreateViaIdentity2$|^CreateViaIdentityExpanded2$|^List5$|^Create5$|^CreateExpanded5$|^CreateViaIdentity5$|^CreateViaIdentityExpanded5$
    set:
      subject: GroupMemberWithLicenseErrorByRef
  - where:
      verb: Get
      subject: ^GroupTransitiveMemberByRef$
      variant: ^List$|^List2$
    set:
      subject: GroupTransitiveMemberOfByRef
  # Alias then rename cmdlets to avoid breaking change.
  - where:
      subject: ^(User|ServicePrincipal|Contact|Device)(Member|TransitiveMember)ByRef$
    set:
      alias: ${verb}-Mg${subject}
  - where:
      subject: ^(User|ServicePrincipal|Contact|Device)(Member|TransitiveMember)ByRef$
    set:
      subject: $1$2OfByRef
  - where:
      subject: ^(Application|Group)(CreatedOnBehalf)ByRef$
    set:
      alias: ${verb}-Mg${subject}
  - where:
      subject: ^(Application|Group)(CreatedOnBehalf)ByRef$
    set:
      subject: $1$2OfByRef
  # Modify generated .cs file download cmdlets.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%2Fcmdlets%2FGet\w*\d*.cs/gm))
      {
        return $;
      } else {
        let outFileParameterRegex = /(^\s*)public\s*global::System\.String\s*OutFile\s*/gmi
        let streamResponseRegex = /global::System\.Threading\.Tasks\.Task<global::System\.IO\.Stream>\s*response/gmi
        if($.match(outFileParameterRegex) && $.match(streamResponseRegex)) {
          // Handle file download.
          let overrideOnOkCallRegex = /(^\s*)(overrideOnOk\(\s*responseMessage\s*,\s*response\s*,\s*ref\s*_returnNow\s*\);)/gmi
          $ = $.replace(overrideOnOkCallRegex, '$1$2\n$1using(var stream = await response){ this.WriteToFile(responseMessage, stream, this.GetProviderPath(OutFile, false), _cancellationTokenSource.Token); _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(true);}\n$1');
        }
        return $;
      }

  # Modify generated .cs file upload cmdlets.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%2Fcmdlets%2FSet\w*\d*.cs/gm))
      {
        return $;
      } else {
        let streamBodyParameterRegex = /(^\s*)public\s*global::System.IO.Stream\s*BodyParameter\s*/gmi
        if($.match(streamBodyParameterRegex)) {
          // Replace base class with FileUploadCmdlet.
          let psBaseClassImplementationRegex = /(\s*:\s*)(global::System.Management.Automation.PSCmdlet)/gmi
          $ = $.replace(psBaseClassImplementationRegex, '$1Microsoft.Graph.PowerShell.Cmdlets.Custom.FileUploadCmdlet');

          // Set bodyParameter to required to false.
          let streamBodyParameterAnnotation = /(global::System\.IO\.Stream _bodyParameter;\s*\[global::System\.Management\.Automation\.Parameter\(Mandatory\s*=\s*)(true)/gmi
          $ = $.replace(streamBodyParameterAnnotation, '$1false');

          // Handle file upload.
          let processRecordCallRegex = /(^\s*)(asyncCommandRuntime\.Wait\(\s*ProcessRecordAsync\s*\(\))/gmi
          $ = $.replace(processRecordCallRegex, '$1if (!MyInvocation.BoundParameters.ContainsKey(nameof(BodyParameter))){BodyParameter = GetFileAsStream() ?? BodyParameter;}\n$1$2');
        }
        return $;
      }

  # Serialize all $count parameter to lowercase true or false.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%5Capi%5C\w*.cs/gm))
      {
        return $;
      } else {
        // Add '.ToLower()' at the end of all 'Count.ToString()'
        let countRegex = /(Count\.ToString\(\))/gmi
        $ = $.replace(countRegex, '$1.ToLower()');
        return $;
      }
```
