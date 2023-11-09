---
uid: version_10.2.9.778_changes
so.date: 11/7/2023
---

Changes from v10.2.8.655 and v10.2.9.778

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### Deleted Types

* `SuperOffice.CRM.Services.WorkflowStepUpdateContact`

### New Types

* `SuperOffice.CRM.Services.ChatbotTurn`
* `SuperOffice.CRM.Services.CRMScriptTraceRun`
* `SuperOffice.CRM.Services.Summarizer`
* `SuperOffice.CRM.Services.TextServices`
* `SuperOffice.CRM.Services.WorkflowStepUpdateParticipant`

### Modified Types

#### SuperOffice.CRM.Services.AIAgent is Modified

* New items
  * Method `ExpandText(String, Int32, String)`
  * Method `GetChatbotPromptSuggestions(String, String, Int32, Int32, Int32)`
  * Method `GetChatbotResponse(String, String, String, ChatbotTurn[])`
  * Method `GetSummarizeContactPrompt(Int32, Int32, String, String)`
  * Method `GetSummarizeSalePrompt(Int32, Int32, String, String)`
  * Method `GetSummarizeTicketPrompt(Int32, Int32, String, String)`
  * Method `RephraseText(String, AiTextStyle, String)`
  * Method `SummarizeContact(Int32, Int32, String)`
  * Method `SummarizeSale(Int32, Int32, String)`
  * Method `SummarizeText(String, Int32, String)`
  * Method `SummarizeTicket(Int32, Int32, String)`

#### SuperOffice.CRM.Services.CRMScriptRunResult is Modified

* Deleted items
  * Property `Trace`
* New items
  * Property `TraceRun`

#### SuperOffice.CRM.Services.EmailFlow is Modified

* New items
  * Property `CreatedBy`
  * Property `CreatedDate`
  * Property `UpdatedBy`
  * Property `UpdatedDate`

#### SuperOffice.CRM.Services.IAIAgent is Modified

* New items
  * Method `ExpandText(String, Int32, String)`
  * Method `GetChatbotPromptSuggestions(String, String, Int32, Int32, Int32)`
  * Method `GetChatbotResponse(String, String, String, ChatbotTurn[])`
  * Method `GetSummarizeContactPrompt(Int32, Int32, String, String)`
  * Method `GetSummarizeSalePrompt(Int32, Int32, String, String)`
  * Method `GetSummarizeTicketPrompt(Int32, Int32, String, String)`
  * Method `RephraseText(String, AiTextStyle, String)`
  * Method `SummarizeContact(Int32, Int32, String)`
  * Method `SummarizeSale(Int32, Int32, String)`
  * Method `SummarizeText(String, Int32, String)`
  * Method `SummarizeTicket(Int32, Int32, String)`

#### SuperOffice.CRM.Services.ITicketAgent is Modified

* New items
  * Method `GetTicketMessageEntities(Int32, Int32[])`

#### SuperOffice.CRM.Services.TicketAgent is Modified

* New items
  * Method `GetTicketMessageEntities(Int32, Int32[])`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### New Types

* `SuperOffice.CRM.Services.IRequestArgumentsInfo`
* `SuperOffice.CRM.Services.RequestArgumentsInfo`
* `SuperOffice.Data.AiTextStyle`

### Modified Types

#### SuperOffice.Configuration.ConfigFile is Modified

* Modified items

##### SuperOffice.Configuration.ConfigFile.Documents is Modified

* Deleted items
  * Property `.DocumentsArchiveFileShareUri`
* New items
  * Property `.DocumentsAzureBlobStorageContainerPrimaryUri`


##### SuperOffice.Configuration.ConfigFile.DocumentsSection is Modified

* Deleted items
  * Property `.DocumentsSectionArchiveFileShareUri`
* New items
  * Property `.DocumentsSectionAzureBlobStorageContainerPrimaryUri`


#### SuperOffice.Data.TicketLogFieldChange is Modified

* New items
  * Field `Message_Author`
  * Field `Message_Body`
  * Field `Message_BodyHtml`
  * Field `Message_CreatedAt`
  * Field `Message_CreatedBy`
  * Field `Message_CustomerId`
  * Field `Message_DebugInfo`
  * Field `Message_EmailHeader`
  * Field `Message_ExtraField`
  * Field `Message_MailSorter`
  * Field `Message_MessageCategory`
  * Field `Message_MessageId`
  * Field `Message_SLevel`
  * Field `Message_TicketId`
  * Field `Message_TimeSpent`
  * Field `Message_Type`
  * Field `ProjectId`
  * Field `SaleId`
  * Field `TicketType`

#### SuperOffice.Data.WorkflowEventType is Modified

* Deleted items
  * Field `Click`
* New items
  * Field `AddedMessage`
  * Field `AddedToProject`
  * Field `AddedToSelection`
  * Field `CreatedRequest`
  * Field `FormSubmitted`
  * Field `LinkClicked`
  * Field `OrderPlaced`
  * Field `PersonCreated`
  * Field `PersonUpdated`
  * Field `SaleCreated`
  * Field `SaleLost`
  * Field `SaleSold`
  * Field `StartedChat`

#### SuperOffice.Data.WorkflowGoalType is Modified

* Deleted items
  * Field `ContactUpdated`
  * Field `SaleCreatedOnContact`
* New items
  * Field `PersonUpdated`
  * Field `SaleCreatedOnPerson`

#### SuperOffice.Data.WorkflowStepType is Modified

* Deleted items
  * Field `UpdateContact`
* New items
  * Field `UpdateParticipant`

#### SuperOffice.Data.WorkflowTriggerType is Modified

* Deleted items
  * Field `ContactCreated`
  * Field `ContactUpdated`
* New items
  * Field `PersonCreated`
  * Field `PersonUpdated`

#### SuperOffice.Factory.ClassFactory is Modified

* New items
  * Method `CreateRequired(Type)`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_APPOINTMENT_ATTENDEE_STATISTICS_CONFLICTS`
  * Field `SR_COMPANY_ADD_NEW_PERSON`
  * Field `SR_FIXED_COLUMN_WIDTHS`
  * Field `SR_FLOW_ADDFILTER`
  * Field `SR_FLOW_FLOWGOALS_CAPTION`
  * Field `SR_FLOW_FLOWSTEPS_CAPTION`
  * Field `SR_NO_SELECTION_COPY_HEL`
  * Field `SR_NO_SELECTION_COPY_HEL2`
  * Field `SR_NO_SELECTION_COPY_HEL3`
  * Field `SR_WORKFLOW_ERROR_NOMATCHINGSUBSCRIPTIONFORPERSON`

#### SuperOffice.IO.Files.DiskFileAccess is Modified

* Deleted items
  * Method `CreateDirectory(String)`
  * Method `DirectoryExists(String)`
  * Method `FileDelete(String)`
  * Method `FileDeleteIfExists(String)`
  * Method `FileMove(String, String)`
  * Method `GetExtension(String)`
  * Method `GetInvalidFileNameChars()`

#### SuperOffice.IO.Files.IFileAccess is Modified

* Deleted items
  * Method `CreateDirectory(String)`
  * Method `DirectoryExists(String)`
  * Method `FileDelete(String)`
  * Method `FileDeleteIfExists(String)`
  * Method `FileMove(String, String)`
  * Method `GetExtension(String)`
  * Method `GetInvalidFileNameChars()`

#### SuperOffice.IO.Files.SoArcConfiguration is Modified

* Deleted items
  * Property `UseAzureFiles`
* New items
  * Property `UseAzureBlobStorage`

#### SuperOffice.Util.HttpHelper is Modified

* Deleted items
  * Method `GetResponseWithContent(String, HttpServiceJwtConfig, RequestType, HttpContent, String)`
* New items
  * Method `GetResponseWithContent(String, HttpServiceJwtConfig, RequestType, HttpContent, String, String)`


### Assembly: SoDatabase

### Deleted Types

* `SuperOffice.CRM.WorkFlow.WorkflowEventType`
* `SuperOffice.Data.Cache.OnlineFlushCacheAndBroadcastPlugin`

### New Types

* `SuperOffice.CRM.ArchiveLists.PersonShipmentLinkClickExtender`
* `SuperOffice.CRM.ArchiveLists.ShipmentLinkClickExtenderBase`
* `SuperOffice.CRM.EventHandlerHelper`
* `SuperOffice.CRM.Lists.ShipmentLinksListProvider`
* `SuperOffice.CRM.Lists.SpecifiedMailingsListProvider`
* `SuperOffice.CRM.Lists.TimeZoneIANAProvider`
* `SuperOffice.CRM.Lists.WorkflowTimeWaitAlgorithmProvider`
* `SuperOffice.CRM.Lists.WorkflowTimeWaitIntervalTypeProvider`
* `SuperOffice.CRM.Tooltips.WorkflowTooltipPlugin`
* `SuperOffice.Data.Cache.FlushCacheAndBroadcastPluginAttribute`
* `SuperOffice.Util.TimeZoneUtility`

### Modified Types

#### Microsoft.Extensions.DependencyInjection.NetServerLocalOptions is Modified

* New items
  * Property `ExcludeSoArc2DocumentPlugin`
  * Property `FlushCacheAndBroadcastPluginType`

#### Microsoft.Extensions.DependencyInjection.NetServerLocalOptionsBuilder is Modified

* New items
  * Property `ExcludeSoArc2DocumentPlugin`
  * Method `UseFlushCacheAndBroadcastPluginType<TType>()`

#### SuperOffice.Configuration.Configuration is Modified

* Deleted items
  * Method `Configuration()`
* New items
  * Method `Configuration(ConfigFileFacade)`

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationAggregatorExtender is Modified

* New items
  * Method `IsBookingExternalInvitation(SoDataReader)`
  * Method `IsBookingOwnerNotAssociate(SoDataReader)`

#### SuperOffice.CRM.ArchiveLists.ParticipantsProvider is Modified

* New items
  * Field `EndTimeUtcInformation`
  * Field `StartTimeUtcInformation`

#### SuperOffice.CRM.ArchiveLists.PersonExtenderBase is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.PersonExtenderBase.Features is Modified

* New items
  * Field `.FeaturesShipmentLinkClickedInfo`


#### SuperOffice.CRM.BulkUpdate.BulkUpdateSystem is Modified

* Modified items

##### SuperOffice.CRM.BulkUpdate.BulkUpdateSystem.TicketFieldValueKeys is Modified

* New items
  * Field `.TicketFieldValueKeysTicketType`


#### SuperOffice.CRM.Documents.SoArc2 is Modified

* Deleted items
  * Method `SoArc2(IFileAccess)`

#### SuperOffice.CRM.Lists.SoListProviderFactory is Modified

* New items
  * Field `FlagIncludeAll`

#### SuperOffice.CRM.Lists.TicketPriorityListProvider is Modified


#### SuperOffice.CRM.Lists.TicketTicketStatusProvider is Modified


#### SuperOffice.CRM.Lists.TimeZoneProvider is Modified

* Modified items
  * Method `GetCountryHeader(String, SoListItem, SoListHeading&)`
* New items
  * Method `IsSameCountry(SoListItem, SoListItem)`
  * Method `OnBaseTimeItemCreated(SoListItem)`

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(AiTextStyle&, FieldInfo)`

#### SuperOffice.CRM.Ticket.TicketHelper is Modified

* Deleted items
  * Method `GetUserDisplayValue(String, Int32)`

#### SuperOffice.CRM.WorkFlow.WorkflowEngine is Modified

* New items
  * Method `DoContactEvent(WorkflowEvent, WorkflowTriggerType)`
  * Method `DoLinkClickedEvent(WorkflowEvent)`
  * Method `DoSaleEvent(WorkflowEvent, WorkflowTriggerType)`
  * Method `FilterOk(Int32, Int32[])`
  * Method `TryAddPersonsToWorkFlow(Int32, Int32[])`

#### SuperOffice.CRM.WorkFlow.WorkflowEvent is Modified

* Modified items
  * Field `EventType`

#### SuperOffice.CRM.WorkFlow.WorkflowEventResult is Modified

* Modified items
  * Field `EventType`

#### SuperOffice.CRM.Workflow.WorkflowStepSendEmail is Modified

* Deleted items
  * Method `HasEmailConsentAndSubscription(Int32, Int32)`
* New items
  * Method `HasEmailConsentAndSubscription(Int32, Int32, String&)`

#### SuperOffice.CRM.Workflow.WorkflowUtil is Modified

* New items
  * Field `CSParserOldStylePrefix`
  * Field `CSParserOldStyleSuffix`
  * Field `CSParserPrefix`
  * Field `CSParserSuffix`
  * Field `CSSpmLinkNameLink`

##### SuperOffice.CRM.Workflow.WorkflowUtil.CSFolderType is New

##### SuperOffice.CRM.Workflow.WorkflowUtil.ShipmentConfiguration is New

#### SuperOffice.Data.Cache.OnsiteFlushCacheAndBroadcastPlugin is Modified


#### SuperOffice.Data.Private.FreetextRebuilder is Modified

* Deleted items
  * Method `Rebuild()`
  * Method `SetProgressCallback(ProgressCallback)`
* New items
  * Method `Rebuild(ProgressCallback)`

#### SuperOffice.Data.Private.TicketLogging.LogDetail is Modified

* Deleted items
  * Property `MessageId`
* Modified items
  * Method `LogDetail(Int32, TicketLogFieldChange, String, String, Int32)`
* New items
  * Property `EntityId`

#### SuperOffice.Data.Private.TicketLogging.TicketLoggerProcessor is Modified

* Modified items

##### SuperOffice.Data.Private.TicketLogging.TicketLoggerProcessor.OldAndNew is Modified

* New items
  * Field `.OldAndNewFieldDataType`


##### SuperOffice.Data.Private.TicketLogging.TicketLoggerProcessor.QueryData is Modified

* New items
  * Field `.QueryDataIsMessageLog`
  * Field `.QueryDataMessageId`
  * Property `.QueryDataPrimaryId`


#### SuperOffice.Security.Principal.ExpiredCredentialCleaner is Modified

* Modified items
  * Field `BlockCleanupDuringTestRuns`


## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.Database.AiTextStyle`

### Modified Types

#### SuperOffice.CD.Database.TicketLogFieldChange is Modified

* New items
  * Field `Message_Author`
  * Field `Message_Body`
  * Field `Message_BodyHtml`
  * Field `Message_CreatedAt`
  * Field `Message_CreatedBy`
  * Field `Message_CustomerId`
  * Field `Message_DebugInfo`
  * Field `Message_EmailHeader`
  * Field `Message_ExtraField`
  * Field `Message_MailSorter`
  * Field `Message_MessageCategory`
  * Field `Message_MessageId`
  * Field `Message_SLevel`
  * Field `Message_TicketId`
  * Field `Message_TimeSpent`
  * Field `Message_Type`
  * Field `ProjectId`
  * Field `SaleId`
  * Field `TicketType`

#### SuperOffice.CD.Database.WorkflowEventType is Modified

* Deleted items
  * Field `Click`
* New items
  * Field `AddedMessage`
  * Field `AddedToProject`
  * Field `AddedToSelection`
  * Field `CreatedRequest`
  * Field `FormSubmitted`
  * Field `LinkClicked`
  * Field `OrderPlaced`
  * Field `PersonCreated`
  * Field `PersonUpdated`
  * Field `SaleCreated`
  * Field `SaleLost`
  * Field `SaleSold`
  * Field `StartedChat`

#### SuperOffice.CD.Database.WorkflowGoalType is Modified

* Deleted items
  * Field `ContactUpdated`
  * Field `SaleCreatedOnContact`
* New items
  * Field `PersonUpdated`
  * Field `SaleCreatedOnPerson`

#### SuperOffice.CD.Database.WorkflowStepType is Modified

* Deleted items
  * Field `UpdateContact`
* New items
  * Field `UpdateParticipant`

#### SuperOffice.CD.Database.WorkflowTriggerType is Modified

* Deleted items
  * Field `ContactCreated`
  * Field `ContactUpdated`
* New items
  * Field `PersonCreated`
  * Field `PersonUpdated`



