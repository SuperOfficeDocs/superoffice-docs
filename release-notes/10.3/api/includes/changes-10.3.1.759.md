---
uid: version_10.3.1.759_changes
date: 1/20/2024
---

Changes from v10.2.11.1228 and v10.3.1.759

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.WorkflowActionInfo`
* `SuperOffice.CRM.Services.WorkflowWaitForAction`
* `SuperOffice.CRM.Services.WorkflowWaitForActionInfo`

### Modified Types

#### SuperOffice.CRM.Services.AIAgent is Modified

* Deleted items
  * Method `GetChatbotPromptSuggestions(String, String, Int32, Int32, Int32)`
  * Method `GetChatbotResponse(String, String, String, ChatbotTurn[])`
* New items
  * Method `ClearChatbotTurns(String)`
  * Method `GetChatbotPromptSuggestions(String, String, Int32)`
  * Method `GetChatbotResponse(String, String, String, String, ChatbotTurn[], String)`
  * Method `GetChatbotTurns(String)`

#### SuperOffice.CRM.Services.EmailFlow is Modified

* New items
  * Property `ExitFlowId`
  * Property `ExitSuccessFlowId`

#### SuperOffice.CRM.Services.EventData is Modified

* New items
  * Property `Headers`

#### SuperOffice.CRM.Services.IAIAgent is Modified

* Deleted items
  * Method `GetChatbotPromptSuggestions(String, String, Int32, Int32, Int32)`
  * Method `GetChatbotResponse(String, String, String, ChatbotTurn[])`
* New items
  * Method `ClearChatbotTurns(String)`
  * Method `GetChatbotPromptSuggestions(String, String, Int32)`
  * Method `GetChatbotResponse(String, String, String, String, ChatbotTurn[], String)`
  * Method `GetChatbotTurns(String)`

#### SuperOffice.CRM.Services.IListAgent is Modified

* Deleted items
  * Method `GetAllTicketTypeEntities()`
  * Method `GetTicketType(Int32)`
* Modified items
  * Method `GetTicketTypeList(Int32[])`
  * Method `GetTicketTypes()`
* New items
  * Method `SetTicketTypeSortOrder(Int32, Int32)`

#### SuperOffice.CRM.Services.IMarketingAgent is Modified

* New items
  * Method `DeleteMessageAndShipment(Int32)`
  * Method `RenameMailingByMessageId(Int32, String)`

#### SuperOffice.CRM.Services.IWorkflowAgent is Modified

* New items
  * Method `CreateDefaultWorkflowWaitForAction()`
  * Method `DeleteWorkflowWaitForAction(Int32)`
  * Method `GetWorkflowWaitForAction(Int32)`
  * Method `SaveWorkflowWaitForAction(WorkflowWaitForAction)`

#### SuperOffice.CRM.Services.ListAgent is Modified

* Deleted items
  * Method `GetAllTicketTypeEntities()`
  * Method `GetTicketType(Int32)`
* Modified items
  * Method `GetTicketTypeList(Int32[])`
  * Method `GetTicketTypes()`
* New items
  * Method `SetTicketTypeSortOrder(Int32, Int32)`

#### SuperOffice.CRM.Services.MarketingAgent is Modified

* New items
  * Method `DeleteMessageAndShipment(Int32)`
  * Method `RenameMailingByMessageId(Int32, String)`

#### SuperOffice.CRM.Services.PreviewMailing is Modified

* New items
  * Property `Configuration`

#### SuperOffice.CRM.Services.PreviewMailingHeader is Modified

* New items
  * Property `Configuration`

#### SuperOffice.CRM.Services.Ticket is Modified

* New items
  * Property `TicketTypeId`
  * Property `TicketTypeName`

#### SuperOffice.CRM.Services.TicketEntity is Modified

* Modified items
  * Property `TicketType`
* New items
  * Property `ActiveStatusMonitorId`

#### SuperOffice.CRM.Services.TicketType is Modified

* Deleted items
  * Property `Id`
  * Property `Tooltip`
  * Property `Value`
* New items
  * Property `DefaultTicketPriority`
  * Property `DefaultTicketStatus`
  * Property `Icon`
  * Property `IsDefault`
  * Property `Name`
  * Property `TicketTypeId`

#### SuperOffice.CRM.Services.WebPanelEntity is Modified

* New items
  * Property `NeverReloadOnCurrentChange`

#### SuperOffice.CRM.Services.WorkflowAgent is Modified

* New items
  * Method `CreateDefaultWorkflowWaitForAction()`
  * Method `DeleteWorkflowWaitForAction(Int32)`
  * Method `GetWorkflowWaitForAction(Int32)`
  * Method `SaveWorkflowWaitForAction(WorkflowWaitForAction)`

#### SuperOffice.CRM.Services.WorkflowStepCreateRequest is Modified

* New items
  * Property `Date`

#### SuperOffice.CRM.Services.WorkflowStepCreateSale is Modified

* Deleted items
  * Property `SaleDateType`
* New items
  * Property `ActionTime`
  * Property `ActionTimeUnit`
  * Property `ActionType`

#### SuperOffice.CRM.Services.WorkflowStepSplit is Modified

* New items
  * Property `ExitToFlowId`
  * Property `ExitToSelectionId`

#### SuperOffice.CRM.Services.WorkflowStepUpdateParticipant is Modified

* Deleted items
  * Property `FieldValues`
* New items
  * Property `FieldValuesCompany`
  * Property `FieldValuesPerson`

#### SuperOffice.CRM.Services.WorkflowStepWaitForAction is Modified

* New items
  * Property `Actions`
  * Property `ActionTimeout`
  * Property `ExitFlow`
  * Property `ExitToFlowId`
  * Property `ExitToSelectionId`
  * Property `TimeoutIntervalType`
  * Property `WaitForTimeout`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Deleted Types

* `SuperOffice.Data.CSRegistryEntry`
* `SuperOffice.Data.WorkflowSaleDateType`

### New Types

* `SuperOffice.Data.WorkflowWaitForActionType`

### Modified Types

#### SuperOffice.Configuration.ConfigFile is Modified

* New items

##### SuperOffice.Configuration.ConfigFile.CRMScript2 is New

##### SuperOffice.Configuration.ConfigFile.CRMScript2Section is New

#### SuperOffice.CRM.ArchiveLists.Constants is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.Constants.IconHints is Modified

* New items
  * Field `.IconHintsFolder`


#### SuperOffice.CRM.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.CRM.UserPreferenceStrings.SalesNotification is Modified

* New items
  * Field `.SalesNotificationNotifyAppointmentAssociateRejected`


##### SuperOffice.CRM.UserPreferenceStrings.System is Modified

* New items
  * Field `.SystemOfferWebToolsInstall`
  * Field `.SystemOfferWebToolsUpgrade`


#### SuperOffice.Data.DeltaType is Modified

* New items
  * Field `CustomObjectArchivePanel`

#### SuperOffice.Data.ExtraFieldFlags is Modified

* New items
  * Field `ShowRelationInArchives`
  * Field `ShowWithProperties`

#### SuperOffice.Data.WorkflowActionType is Modified

* New items
  * Field `Estimated`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_ADMIN_LIST_NEVER_RELOAD_WEBPANEL`
  * Field `SR_ADMIN_LIST_NEVER_TOOLTIP_WEBPANEL`
  * Field `SR_ADMIN_TICKETTYPE_NAME_ALREADY_EXIST`
  * Field `SR_APPOINTMENT_VIDEO_MEETING_CAPTION`
  * Field `SR_DASH_REQUESTS`
  * Field `SR_DASHTILE_REQ_AVERAGE__CLOSING_TIME_USER`
  * Field `SR_DASHTILE_REQ_AVERAGE_CLOSING_TIME`
  * Field `SR_DASHTILE_REQ_AVERAGE_CLOSING_TIME_CATEGORY`
  * Field `SR_DASHTILE_REQ_AVERAGE_RESPONSE_TIME`
  * Field `SR_DASHTILE_REQ_AVERAGE_RESPONSE_TIME_CATEGORY`
  * Field `SR_DASHTILE_REQ_AVERAGE_RESPONSE_TIME_USER`
  * Field `SR_DASHTILE_REQ_MOST_OPEN_REQUEST`
  * Field `SR_DASHTILE_REQ_REQUESTS_BY_OWNER`
  * Field `SR_DASHTILE_REQ_REQUESTS_BY_PRIO`
  * Field `SR_DLG_MAXIMIZE`
  * Field `SR_DLG_RESTORE`
  * Field `SR_FLOW_ADDSUCCESSCRITERIA`
  * Field `SR_FLOW_ALL`
  * Field `SR_FLOW_CREATENEW`
  * Field `SR_FLOW_END_ENROLLMENT`
  * Field `SR_FLOW_FORM_NOTSUBMITTED`
  * Field `SR_FLOW_FORM_SUBMITTED`
  * Field `SR_FLOW_FORMSUBMITTED_YESNO`
  * Field `SR_FLOW_GOAL_DESC`
  * Field `SR_FLOW_GOAL_REMOVE`
  * Field `SR_FLOW_JUMPONSUCCESS`
  * Field `SR_FLOW_RECENT`
  * Field `SR_FLOW_RUNNING`
  * Field `SR_FLOW_SPLIT_ADDTOFLOW`
  * Field `SR_FLOW_SPLIT_ADDTOSELECTION`
  * Field `SR_FLOW_START`
  * Field `SR_FLOW_SUCCESS_FOR_PARTICIPANTS`
  * Field `SR_FLOW_SUCCESSCRITERIA_CAPTION`
  * Field `SR_FLOW_TRIGGER_ADD_ALTERNATIVE_TRIGGER`
  * Field `SR_FLOW_TRIGGER_ALLPERSONCREATED`
  * Field `SR_FLOW_TRIGGER_ALLSALECREATED`
  * Field `SR_FLOW_TRIGGER_ALLSALELOST`
  * Field `SR_FLOW_TRIGGER_ALLSALESOLD`
  * Field `SR_FLOW_TRIGGER_CAPTION`
  * Field `SR_FLOW_WAITFORACTION_ADD_ACTION`
  * Field `SR_FLOW_WAITFORACTION_ADD_ALTERNATIVE_ACTION`
  * Field `SR_FLOWS_ADDTOFLOW_COPY_FAILED`
  * Field `SR_FLOWS_ADDTOFLOW_COPY_SUCCESSFUL`
  * Field `SR_LABEL_FLOW`
  * Field `SR_NOTIFY_SETTINGS_notifyAppointmentAssociateRejected`
  * Field `SR_WORKFLOW_COPY_TO_OTHER`
  * Field `SR_WORKFLOW_ERROR_DUPLICATE_EMAIL`
  * Field `SR_WORKFLOW_ERROR_DUPLICATE_PHONE`
  * Field `SR_WORKFLOW_ERROR_MISSINGMOBILEPHONE`
  * Field `SR_WORKFLOW_EXIT_AFTER_MAX_WAITING_TIME`
  * Field `SR_WORKFLOW_EXIT_AFTER_SPLIT`
  * Field `SR_WORKFLOW_RENAME_EMAIL_CAPTION`
  * Field `SR_WORKFLOW_RENAME_EMAIL_TO`
  * Field `SR_WORKFLOWDEFINITION_STATUS_DESC_PAUSED`
  * Field `SR_WORKFLOWDEFINITION_STATUS_DESC_RUNNING`
  * Field `SR_WORKFLOWDEFINITION_STATUS_DESC_STOPPED`
  * Field `SR_WORKFLOWS_COPY_MAILING_CAPTION`
  * Field `SR_WORKFLOWS_COPY_MAILING_DESCRIPTION`
  * Field `SR_WORKFLOWS_COPY_MAILING_HEADER`
  * Field `SR_WORKFLOWS_DELETE_EMAIL`
  * Field `SR_WORKFLOWS_DELETE_PAUSED_FLOW`
  * Field `SR_WORKFLOWS_LICENCE_REQUIRED`
  * Field `SR_WORKFLOWS_MISSING_SMSPLUGIN`
  * Field `SR_WORKFLOWS_REMOVE_ACTION`
  * Field `SR_WORKFLOWS_WAITFORACTION_MAX_WAIT_EXIT`
  * Field `SR_WORKFLOWS_WAITFORACTION_MAX_WAITING`

#### SuperOffice.IO.Files.DiskFileAccess is Modified

* New items
  * Method `DirectoryExists(String)`
  * Method `PathGetExtension(String)`
  * Method `PathGetFileName(String)`
  * Method `PathGetInvalidFileNameChars()`

#### SuperOffice.IO.Files.IFileAccess is Modified

* New items
  * Method `DirectoryExists(String)`
  * Method `PathGetExtension(String)`
  * Method `PathGetFileName(String)`
  * Method `PathGetInvalidFileNameChars()`

#### SuperOffice.License.SoLicenseNames is Modified

* New items
  * Field `MarketingT2`

#### SuperOffice.Security.Principal.SoPrincipal is Modified

* Modified items
  * Method `GetAccessToken(String, Boolean)`

#### SuperOffice.ServiceConstants is Modified

* New items
  * Field `ExtraFieldMessageTableDomain`
  * Field `ExtraFieldTicketTableDomain`

#### SuperOffice.Util.DomainHelper is Modified

* New items
  * Field `EmailValidationRegex`

#### SuperOffice.Util.HttpHelper is Modified

* New items
  * Method `GetObjectFromHttpSyncWithContent<T>(String, RequestType, HttpContent)`


### Assembly: SoDatabase

### New Types

* `SuperOffice.CRM.ArchiveLists.ExtraTableProvider`
* `SuperOffice.CRM.ArchiveLists.Joiners.ExtraTableExtraFieldExtender`
* `SuperOffice.CRM.ArchiveLists.ShipmentEmailFlowExtender`
* `SuperOffice.CRM.Data.AiChatTurnTableInfo`
* `SuperOffice.CRM.Data.WorkflowWaitForActionTableInfo`
* `SuperOffice.CRM.Rows.AiChatTurnRecordData`
* `SuperOffice.CRM.Rows.AiChatTurnRecordDataExtensions`
* `SuperOffice.CRM.Rows.AiChatTurnRow`
* `SuperOffice.CRM.Rows.AiChatTurnRows`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateAiChatTurnRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateAiChatTurnRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateWorkflowWaitForActionRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateWorkflowWaitForActionRowsFactory`
* `SuperOffice.CRM.Rows.WorkflowWaitForActionRecordData`
* `SuperOffice.CRM.Rows.WorkflowWaitForActionRecordDataExtensions`
* `SuperOffice.CRM.Rows.WorkflowWaitForActionRow`
* `SuperOffice.CRM.Rows.WorkflowWaitForActionRows`
* `SuperOffice.CRM.Workflow.WaitForActionSettings`
* `SuperOffice.CRM.Workflow.WorkflowStepWaitForAction`
* `SuperOffice.Data.SQL.WorkflowWaitForActionTypeFieldInfo`
* `SuperOffice.Util.WebAppUsageRecorder`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationAggregatorExtender is Modified

* Deleted items
  * Method `GetRowTypeForAppointmentStatus(AppointmentStatus)`
* New items
  * Method `GetRowTypeForAppointmentStatus(SoDataReader, AppointmentStatus)`

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationProvider is Modified

* New items
  * Field `C_APPOINTMENT_REJECTED_BY_ASSOCIATE_ENTITY_NAME`

#### SuperOffice.CRM.ArchiveLists.EmailFlowExtenderBase is Modified

* Deleted items

#### SuperOffice.CRM.ArchiveLists.FormSubmissionExtenderBase is Modified

* New items
  * Method `FormSubmissionExtenderBase(Features)`

##### SuperOffice.CRM.ArchiveLists.FormSubmissionExtenderBase.Features is New

#### SuperOffice.CRM.ArchiveLists.HtmlTextExtenderBase is Modified

* Deleted items
  * Method `IsHtmlTextGhostFieldOrEmpty(SoDataReader)`

#### SuperOffice.CRM.ArchiveLists.MailingsAddrExtenderBase is Modified


#### SuperOffice.CRM.ArchiveLists.TicketExtenderBase is Modified


#### SuperOffice.CRM.ArchiveLists.WorkflowExtenderBase is Modified

* New items

##### SuperOffice.CRM.ArchiveLists.WorkflowExtenderBase.WFStats is New

#### SuperOffice.CRM.Cache.AssociateCache is Modified

* New items
  * Method `GetAllAssociateFullNames(Boolean)`
  * Method `IsCacheInvalidated(String, Int32, PrivateSave)`

#### SuperOffice.CRM.Cache.BusinessCache is Modified

* New items
  * Method `GetAllBusinesses(Boolean)`

#### SuperOffice.CRM.Cache.CategoryCache is Modified

* New items
  * Method `GetAllCategories(Boolean)`

#### SuperOffice.CRM.Cache.MDOListTableCacheTypedBase<T> is Modified

* New items
  * Method `GetAllItems(Boolean)`

#### SuperOffice.CRM.Cache.MDOPreferenceCache is Modified

* New items
  * Method `IsCacheInvalidated(String, Int32, PrivateSave)`

#### SuperOffice.CRM.Cache.StatusMonitorCache is Modified

* New items
  * Method `IsCacheInvalidated(String, Int32, PrivateSave)`

#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* New items
  * Property `LeftOuterJoin_AiChatTurn_AssociateId`
  * Property `LeftOuterJoin_WorkflowWaitForAction_RegisteredAssociateId`
  * Property `LeftOuterJoin_WorkflowWaitForAction_UpdatedAssociateId`

#### SuperOffice.CRM.Data.CacheInvalidationTableInfo is Modified

* New items
  * Property `FirstChange`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.CacheInvalidationFields is Modified

* New items
  * Field `.CacheInvalidationFieldsFirstChange`


##### SuperOffice.CRM.Data.DBC.WorkflowFields is Modified

* New items
  * Field `.WorkflowFieldsExitFlowId`
  * Field `.WorkflowFieldsExitSuccessFlowId`

* New items
  * Field `AiChatTurn`
  * Field `WorkflowWaitForAction`

##### SuperOffice.CRM.Data.DBC.AiChatTurnFields is New

##### SuperOffice.CRM.Data.DBC.WorkflowWaitForActionFields is New

#### SuperOffice.CRM.Data.WorkflowStepTableInfo is Modified

* New items
  * Property `LeftOuterJoin_WorkflowWaitForAction_WorkflowStepId`

#### SuperOffice.CRM.Data.WorkflowTableInfo is Modified

* New items
  * Property `ExitFlowId`
  * Property `ExitFlowId_InnerJoin_Workflow`
  * Property `ExitSuccessFlowId`
  * Property `ExitSuccessFlowId_InnerJoin_Workflow`
  * Property `LeftOuterJoin_WorkflowWaitForAction_WorkflowId`

#### SuperOffice.CRM.Entities.EntityRankOrderer is Modified

* Deleted items
  * Method `SetItemPosition(Int32FieldInfo, Int32, Int32)`
* New items
  * Method `SetItemPosition(FieldInfo, Int32, Int32)`

#### SuperOffice.CRM.Entities.Providers.AppointmentInfoProvider is Modified

* New items
  * Method `GetRecurringTooltip(RecurrencePattern, DateTime, DateTime)`
  * Method `GetRepeatingPatternText()`

#### SuperOffice.CRM.Entities.RecurrenceManager is Modified

* New items
  * Method `ConvertWeekdayToInteger(Weekday)`
  * Method `OnAgendaHTMLTextChange(Appointment, String, String, String)`
  * Method `OnAgendaTextChange(Appointment, String, String, String)`

#### SuperOffice.CRM.Lists.EmailFlowListProvider is Modified

* Deleted items
  * Method `OnPreGetRootItems(List<ISoListItem>)`
* New items
  * Method `OnPostGetRootItems(List<ISoListItem>)`

#### SuperOffice.CRM.Lists.EmailPhoneProvider is Modified

* New items
  * Method `ExecuteQuery(Select, List<ISoListItem>)`

#### SuperOffice.CRM.Rows.CacheInvalidationRecordData is Modified

* New items
  * Field `FirstChange`

#### SuperOffice.CRM.Rows.CacheInvalidationRow is Modified

* New items
  * Property `FirstChange`

#### SuperOffice.CRM.Rows.RowValidator is Modified

* Deleted items
  * Method `ValidateField(WorkflowSaleDateType&, FieldInfo)`
* New items
  * Method `ValidateField(WorkflowWaitForActionType&, FieldInfo)`

#### SuperOffice.CRM.Rows.WorkflowRecordData is Modified

* New items
  * Field `ExitFlowId`
  * Field `ExitSuccessFlowId`

#### SuperOffice.CRM.Rows.WorkflowRow is Modified

* New items
  * Property `ExitFlowId`
  * Property `ExitSuccessFlowId`

#### SuperOffice.CRM.Script.CRMScriptServiceBase is Modified

* Deleted items
  * Method `ExecuteScript(Scriptwithcontext)`
  * Method `ExecuteScriptAsync(Scriptwithcontext, String, CancellationToken)`
* New items
  * Method `ExecuteScript(Scriptwithcontext, Int32)`
  * Method `ExecuteScriptAsync(Scriptwithcontext, String, Int32, CancellationToken)`
  * Method `GetExecutionTimeout()`

#### SuperOffice.CRM.Script.ICRMScriptService is Modified

* Deleted items
  * Method `ExecuteScript(Scriptwithcontext)`
* New items
  * Method `ExecuteScript(Scriptwithcontext, Int32)`

#### SuperOffice.CRM.Security.RefCountsPermissionCache is Modified

* New items
  * Method `IsCacheInvalidated(String, Int32, PrivateSave)`

#### SuperOffice.CRM.Workflow.CreateRequestSettings is Modified

* New items
  * Property `RequestDate`

#### SuperOffice.CRM.Workflow.CreateSaleSettings is Modified

* Deleted items
  * Property `SaleDateType`
* New items
  * Property `ActionTime`
  * Property `ActionTimeUnit`
  * Property `ActionType`

#### SuperOffice.CRM.Workflow.SendSMSSettings is Modified

* New items
  * Property `ShipmentId`

#### SuperOffice.CRM.Workflow.SplitSettings is Modified

* New items
  * Property `ExitToFlowId`
  * Property `ExitToSeletionId`

#### SuperOffice.CRM.Workflow.UpdateParticipantSettings is Modified

* Deleted items
  * Field `FieldValues`
* New items
  * Field `FieldValuesCompany`
  * Field `FieldValuesPerson`

#### SuperOffice.CRM.WorkFlow.WorkflowEngine is Modified

* New items
  * Method `ActivateWorkflowInstancesForActions(WorkflowWaitForActionType, Int32, Int32[])`

#### SuperOffice.CRM.WorkFlow.WorkflowInstanceVariables is Modified

* New items
  * Property `WaitingUntil`

#### SuperOffice.CRM.Workflow.WorkflowStepSendEmail is Modified

* Deleted items
  * Method `HasEmailConsentAndSubscription(Int32, Int32, String&)`

#### SuperOffice.CRM.Workflow.WorkflowStepUpdateParticipant is Modified

* New items
  * Field `RowResultItems`

#### SuperOffice.CRM.Workflow.WorkflowUtil is Modified

* New items
  * Method `HasEmarketingConsentAndSubscription(Int32, Int32, String&)`
  * Method `IsAddressUsedByOtherParticipant(Int32, Int32, String)`
  * Method `TryAddToSelection(Int32, Int32, Int32)`
  * Method `VerifySmtpSetup(Int32)`

##### SuperOffice.CRM.Workflow.WorkflowUtil.ShipmentAddrType is New

#### SuperOffice.Data.Dictionary.SoTable is Modified

* New items
  * Property `Block`

##### SuperOffice.Data.Dictionary.SoTable.BlockKind is New

#### SuperOffice.Data.Private.FreetextIndexerLogic is Modified

* New items
  * Method `FreetextIndexerLogic(IndexingMode, String[])`

#### SuperOffice.Data.Private.FreetextRebuilder is Modified

* New items
  * Method `RebuildTables(SoTable[], ProgressCallback)`

#### SuperOffice.Data.QueryExectionExtensions is Modified

* New items
  * Method `GetFieldPropertyRead(QueryExecutionHelper, FieldInfo)`

#### SuperOffice.Data.TablesInfo is Modified

* New items
  * Method `GetAiChatTurnTableInfo()`
  * Method `GetWorkflowWaitForActionTableInfo()`

#### SuperOffice.Data.UdefHelper is Modified

* Deleted items
  * Method `FindAvailableFieldWithIndex(UDefType, UDefFieldType)`
  * Method `FindAvailableFieldWithoutIndex(UDefType, UDefFieldType)`

#### SuperOffice.Util.iCalendarUtility is Modified

* Deleted items
  * Method `CreateInvitation(AppointmentRow, Nullable<DateTime>, Nullable<DateTime>, String, AppointmentRow[])`
* New items
  * Method `CreateInvitation(AppointmentRow, Int32, Nullable<DateTime>, Nullable<DateTime>, String, AppointmentRow[])`


### Assembly: SuperOffice.Plugins

### Modified Types

#### SuperOffice.CRM.CRMQuoteConnectorCapabilities is Modified

* New items
  * Field `quote_status_assortment_error`
  * Field `quote_status_assortment_ok`
  * Field `quote_status_assortment_warning`
  * Field `quote_status_below_cost_error`
  * Field `quote_status_below_cost_ok`
  * Field `quote_status_below_cost_warning`
  * Field `quote_status_expired_error`
  * Field `quote_status_expired_ok`
  * Field `quote_status_expired_warning`
  * Field `quote_status_negative_error`
  * Field `quote_status_negative_ok`
  * Field `quote_status_negative_warning`
  * Field `quote_status_zero_error`
  * Field `quote_status_zero_ok`
  * Field `quote_status_zero_warning`


### Assembly: SoLicense

### Modified Types

#### SuperOffice.License.LicenseService is Modified



## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### Deleted Types

* `SuperOffice.CD.Database.WorkflowSaleDateType`

### New Types

* `SuperOffice.CD.Database.WorkflowWaitForActionType`
* `SuperOffice.CD.DSL.Database.AiStep1`
* `SuperOffice.CD.DSL.Database.Steps_ConfigurableScreen.ConfigurableScreen_09_TicketTabPanesIdUpdate`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_51_CreatedBy_AssocToEjUser`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep15_FlowExitSettings`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep16_WorkflowWaitForAction`
* `SuperOffice.CD.DSL.Database.T_AiChatTurn`
* `SuperOffice.CD.DSL.Database.T_WorkflowWaitForAction`

### Modified Types

#### SuperOffice.CD.Database.DeltaType is Modified

* New items
  * Field `CustomObjectArchivePanel`

#### SuperOffice.CD.Database.ExtraFieldFlags is Modified

* New items
  * Field `ShowRelationInArchives`
  * Field `ShowWithProperties`

#### SuperOffice.CD.Database.WorkflowActionType is Modified

* New items
  * Field `Estimated`

#### SuperOffice.CD.DSL.Database.DbModelConstants is Modified

* New items
  * Field `BlockAnyAP`
  * Field `BlockDotSyntaxAP`
  * Field `BlockKey`

#### SuperOffice.CD.DSL.Database.T_CacheInvalidation is Modified

* New items
  * Field `FirstChange`

#### SuperOffice.CD.DSL.Database.T_Workflow is Modified

* New items
  * Field `ExitFlowId`
  * Field `ExitSuccessFlowId`



