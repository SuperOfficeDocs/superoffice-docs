---
uid: version_10.2.8.655_changes
date: 9/25/2023
---

Changes from v10.2.6.1248 and v10.2.8.655

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### Deleted Types

* `SuperOffice.CRM.Services.WorkflowStep`

### New Types

* `SuperOffice.CRM.Services.CRMScriptErrorInfo`
* `SuperOffice.CRM.Services.CRMScriptRunResult`
* `SuperOffice.CRM.Services.TicketType`
* `SuperOffice.CRM.Services.TicketTypeEntity`
* `SuperOffice.CRM.Services.WorkflowEvent`
* `SuperOffice.CRM.Services.WorkflowEventResult`

### Modified Types

#### SuperOffice.CRM.Services.AppointmentAgent is Modified

* New items
  * Method `CreateAppointmentEntityFromExisting(Int32, Int32)`

#### SuperOffice.CRM.Services.CRMScriptAgent is Modified

* New items
  * Method `ExecuteScriptByString(String, StringDictionary, EventData)`
  * Method `ValidateScriptByString(String)`

#### SuperOffice.CRM.Services.CRMScriptResult is Modified

* New items
  * Property `ErrorInformation`
  * Property `LineNumber`

#### SuperOffice.CRM.Services.DocumentAgent is Modified

* New items
  * Method `CopyDocumentToCsAttachment(Int32)`

#### SuperOffice.CRM.Services.EMailAttachment is Modified

* New items
  * Property `IsSafeFileExtension`

#### SuperOffice.CRM.Services.EmailFlow is Modified

* Modified items
  * Property `EnrollmentEnd`
  * Property `TimeframeEnd`
  * Property `TimeframeStart`
  * Property `WorkflowStart`

#### SuperOffice.CRM.Services.EventData is Modified

* New items
  * Property `ParserValues`

#### SuperOffice.CRM.Services.IAppointmentAgent is Modified

* New items
  * Method `CreateAppointmentEntityFromExisting(Int32, Int32)`

#### SuperOffice.CRM.Services.ICRMScriptAgent is Modified

* New items
  * Method `ExecuteScriptByString(String, StringDictionary, EventData)`
  * Method `ValidateScriptByString(String)`

#### SuperOffice.CRM.Services.IDocumentAgent is Modified

* New items
  * Method `CopyDocumentToCsAttachment(Int32)`

#### SuperOffice.CRM.Services.IListAgent is Modified

* New items
  * Method `CreateDefaultTicketTypeEntity()`
  * Method `DeleteTicketTypeEntity(Int32)`
  * Method `GetAllTicketTypeEntities()`
  * Method `GetTicketType(Int32)`
  * Method `GetTicketTypeEntity(Int32)`
  * Method `GetTicketTypeList(Int32[])`
  * Method `GetTicketTypes()`
  * Method `SaveTicketTypeEntity(TicketTypeEntity)`

#### SuperOffice.CRM.Services.ITicketAgent is Modified

* Deleted items
  * Method `SplitTicket(Int32, Int32[], TicketEntity)`
* New items
  * Method `SplitTicket(Int32, Int32, DateTime, Int32[], TicketEntity)`

#### SuperOffice.CRM.Services.IWorkflowAgent is Modified

* Deleted items
  * Method `CreateEmailFlowContent(String)`
* New items
  * Method `CopyEmailFlowContent(Int32, Int32)`
  * Method `CreateDefaultWorkflowEvent()`
  * Method `CreateDefaultWorkflowEventResult()`
  * Method `CreateEmailFlowContent(Int32, String)`
  * Method `RemoveParticipantsFromEmailFlow(Int32, Int32[])`
  * Method `Run()`
  * Method `SendEvent(WorkflowEvent)`

#### SuperOffice.CRM.Services.ListAgent is Modified

* New items
  * Method `CreateDefaultTicketTypeEntity()`
  * Method `DeleteTicketTypeEntity(Int32)`
  * Method `GetAllTicketTypeEntities()`
  * Method `GetTicketType(Int32)`
  * Method `GetTicketTypeEntity(Int32)`
  * Method `GetTicketTypeList(Int32[])`
  * Method `GetTicketTypes()`
  * Method `SaveTicketTypeEntity(TicketTypeEntity)`

#### SuperOffice.CRM.Services.Ticket is Modified

* New items
  * Property `TimeSpent`

#### SuperOffice.CRM.Services.TicketAgent is Modified

* Deleted items
  * Method `SplitTicket(Int32, Int32[], TicketEntity)`
* New items
  * Method `SplitTicket(Int32, Int32, DateTime, Int32[], TicketEntity)`

#### SuperOffice.CRM.Services.TicketEntity is Modified

* New items
  * Property `TicketType`
  * Property `TimeSpent`

#### SuperOffice.CRM.Services.Webhook is Modified

* New items
  * Property `ErrorsEmail`

#### SuperOffice.CRM.Services.WorkflowAgent is Modified

* Deleted items
  * Method `CreateEmailFlowContent(String)`
* New items
  * Method `CopyEmailFlowContent(Int32, Int32)`
  * Method `CreateDefaultWorkflowEvent()`
  * Method `CreateDefaultWorkflowEventResult()`
  * Method `CreateEmailFlowContent(Int32, String)`
  * Method `RemoveParticipantsFromEmailFlow(Int32, Int32[])`
  * Method `Run()`
  * Method `SendEvent(WorkflowEvent)`

#### SuperOffice.CRM.Services.WorkflowStepAddToList is Modified

* New items
  * Property `Project`
  * Property `Selection`

#### SuperOffice.CRM.Services.WorkflowStepCreateFollowUp is Modified

* New items
  * Property `Agenda`
  * Property `AssignTo`
  * Property `Availability`
  * Property `Completed`
  * Property `Duration`
  * Property `FollowUpType`
  * Property `Project`
  * Property `Title`
  * Property `WorkflowActionTime`
  * Property `WorkflowActionTimeUnit`
  * Property `WorkflowActionType`
  * Property `WorkflowOwnerType`

#### SuperOffice.CRM.Services.WorkflowStepCreateRequest is Modified

* New items
  * Property `Category`
  * Property `Message`
  * Property `Owner`
  * Property `Priority`
  * Property `RequestType`
  * Property `Status`
  * Property `Title`

#### SuperOffice.CRM.Services.WorkflowStepRemoveFromList is Modified

* New items
  * Property `Project`
  * Property `Selection`

#### SuperOffice.CRM.Services.WorkflowStepSendEmail is Modified

* Deleted items
  * Property `EmailMessageId`

#### SuperOffice.CRM.Services.WorkflowStepWaitForTime is Modified

* Modified items
  * Property `Until`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Deleted Types

* `SuperOffice.Diagnostics.SoLoggerEnvironmentInfoContext`
* `SuperOffice.Diagnostics.SoLoggerEnvironmentInfoContextPlugin`
* `SuperOffice.Factory.ThreadInstanceContainer`
* `SuperOffice.Util.AssemblyHelper`

### New Types

* `SuperOffice.Data.CcTemplateType`
* `SuperOffice.Data.ScriptType`
* `SuperOffice.Data.ShipmentFlags`
* `SuperOffice.Data.WorkflowActionType`
* `SuperOffice.Data.WorkflowEventType`
* `SuperOffice.Data.WorkflowOwnerType`
* `SuperOffice.Exceptions.SoFileNotFoundException`
* `SuperOffice.IO.Files.DiskFileAccess`
* `SuperOffice.IO.Files.IFileAccess`
* `SuperOffice.IO.Files.SoArcConfiguration`
* `SuperOffice.License.UserLicenseAttribute`
* `SuperOffice.Util.FileExtensionValidator`
* `SuperOffice.Util.Wrapper<T>`

### Modified Types

#### Microsoft.Extensions.DependencyInjection.NetServerCoreOptionsBuilder is Modified

* New items
  * Method `UseFileAccess<T>()`

#### SuperOffice.Configuration.ConfigFile is Modified

* Modified items

##### SuperOffice.Configuration.ConfigFile.Documents is Modified

* New items
  * Property `.DocumentsArchiveFileShareUri`
  * Property `.DocumentsArchiveRelativePath`
  * Property `.DocumentsTemplateRelativePath`
  * Property `.DocumentsTemporaryRelativePath`


##### SuperOffice.Configuration.ConfigFile.DocumentsSection is Modified

* New items
  * Property `.DocumentsSectionArchiveFileShareUri`
  * Property `.DocumentsSectionArchiveRelativePath`
  * Property `.DocumentsSectionTemplateRelativePath`
  * Property `.DocumentsSectionTemporaryRelativePath`


#### SuperOffice.CRM.ArchiveLists.Constants is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.Constants.DisplayTypes is Modified

* New items
  * Field `.DisplayTypesImageUrl`


##### SuperOffice.CRM.ArchiveLists.Constants.IconHints is Modified

* New items
  * Field `.IconHintsResource_Conflict`


##### SuperOffice.CRM.ArchiveLists.Constants.RestrictionTypes is Modified

* New items
  * Field `.RestrictionTypesEjCategory`


#### SuperOffice.CRM.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.CRM.UserPreferenceStrings.Functions is Modified

* New items
  * Field `.FunctionsShowWeekNumbersInCalendars`


##### SuperOffice.CRM.UserPreferenceStrings.Mail is Modified

* New items
  * Field `.MailEnableEmailInvitationPreview`
  * Field `.MailNotifyAttendeesByMail`


##### SuperOffice.CRM.UserPreferenceStrings.System is Modified

* New items
  * Field `.SystemUnsafeFileTypes`

* New items

##### SuperOffice.CRM.UserPreferenceStrings.SystemNotification is New

#### SuperOffice.Data.Registry is Modified

* New items
  * Field `CustomerCenterTemplatesMovedToDB`
  * Field `DisableImportMailInlineSupport`
  * Field `SearchEngineCallback`

#### SuperOffice.Data.ScreenChooserType is Modified

* Modified items
  * Field `value__`

#### SuperOffice.Data.WorkflowInstanceStatus is Modified

* Deleted items
  * Field `Faulted`
  * Field `Running`
  * Field `Suspended`
* New items
  * Field `Active`
  * Field `DropOut`
  * Field `FinishedWithSuccess`

#### SuperOffice.Data.WorkflowTriggerType is Modified

* Deleted items
  * Field `AddToList`
  * Field `CreateFollowUp`
  * Field `CreateRequest`
  * Field `CreateSale`
  * Field `NotifyByEmail`
  * Field `NotifyBySMS`
  * Field `RemoveFromList`
  * Field `SendEmail`
  * Field `SendSMS`
  * Field `Split`
  * Field `UpdateContact`
  * Field `WaitForAction`
  * Field `WaitForTime`
* New items
  * Field `AddedMessage`
  * Field `AddedToProject`
  * Field `AddedToSelection`
  * Field `ContactCreated`
  * Field `ContactUpdated`
  * Field `CreatedRequest`
  * Field `FormSubmitted`
  * Field `LinkClicked`
  * Field `OrderPlaced`
  * Field `SaleCreated`
  * Field `SaleLost`
  * Field `SaleSold`
  * Field `StartedChat`

#### SuperOffice.Factory.InstanceContainerManager is Modified

* New items
  * Method `HasContainer(String)`

#### SuperOffice.Factory.InstanceContainers is Modified

* Deleted items
  * Field `Thread`

#### SuperOffice.Globalization.RC is Modified

* Deleted items
  * Field `SR_APPOINTMENT_EMAIL_INTERNALS`
  * Field `SR_WORKFLOWS_NOSHIPMENTTYPE`
* New items
  * Field `SR_ADMIN_LIST_ACTIVITY`
  * Field `SR_APPOINTMENT_CANCEL`
  * Field `SR_APPOINTMENT_CANNOT_DELETE_OWNER`
  * Field `SR_APPOINTMENT_CONFIRM_UPDATE_EMAIL`
  * Field `SR_APPOINTMENT_CREATE_FROM_EXISTING`
  * Field `SR_APPOINTMENT_CREATE_VIDEO`
  * Field `SR_APPOINTMENT_CUSTOM_NOT_SUPPORTED`
  * Field `SR_APPOINTMENT_DELETE_VIDEO`
  * Field `SR_APPOINTMENT_DO_NOT_REPEAT`
  * Field `SR_APPOINTMENT_EMAIL_ATTENDEES`
  * Field `SR_APPOINTMENT_ENABLE_EMAIL_PREVIEW`
  * Field `SR_APPOINTMENT_JOIN_VIDEO`
  * Field `SR_APPOINTMENT_NO_PERSONS`
  * Field `SR_APPOINTMENT_NO_PROJECT_MEMBERS`
  * Field `SR_APPOINTMENT_ONLY_CONFLICTS`
  * Field `SR_APPOINTMENT_PATTERN_DAILY`
  * Field `SR_APPOINTMENT_PATTERN_MONTHLY`
  * Field `SR_APPOINTMENT_PATTERN_WEEKLY`
  * Field `SR_APPOINTMENT_PATTERN_WORKDAY`
  * Field `SR_APPOINTMENT_PATTERN_YEARLY`
  * Field `SR_APPOINTMENT_PREV_DAY`
  * Field `SR_APPOINTMENT_REC_ANNUALLY`
  * Field `SR_APPOINTMENT_REC_ANNUALLY_UNTIL`
  * Field `SR_APPOINTMENT_REC_ANNUALLY_WEEKMONTH_1`
  * Field `SR_APPOINTMENT_REC_ANNUALLY_WEEKMONTH_1_UNTIL`
  * Field `SR_APPOINTMENT_REC_ANNUALLY_WEEKMONTH_2`
  * Field `SR_APPOINTMENT_REC_ANNUALLY_WEEKMONTH_2_UNTIL`
  * Field `SR_APPOINTMENT_REC_ANNUALLY_WEEKMONTH_3`
  * Field `SR_APPOINTMENT_REC_ANNUALLY_WEEKMONTH_3_UNTIL`
  * Field `SR_APPOINTMENT_REC_ANNUALLY_WEEKMONTH_4`
  * Field `SR_APPOINTMENT_REC_ANNUALLY_WEEKMONTH_4_UNTIL`
  * Field `SR_APPOINTMENT_REC_ANNUALLY_WEEKMONTH_5`
  * Field `SR_APPOINTMENT_REC_ANNUALLY_WEEKMONTH_5_UNTIL`
  * Field `SR_APPOINTMENT_REC_EVERY_DAY_UNTIL`
  * Field `SR_APPOINTMENT_REC_EVERY_WEEKDAY_UNTIL`
  * Field `SR_APPOINTMENT_REC_EVERY_WORKDAY`
  * Field `SR_APPOINTMENT_REC_EVERY_WORKDAY_UNTIL`
  * Field `SR_APPOINTMENT_REC_MONTHLY_DAY`
  * Field `SR_APPOINTMENT_REC_MONTHLY_DAY_UNTIL`
  * Field `SR_APPOINTMENT_REC_MONTHLY_NTH`
  * Field `SR_APPOINTMENT_REC_MONTHLY_NTH_UNTIL`
  * Field `SR_APPOINTMENT_REC_MONTHLY_NTH_WEEKMONTH_1`
  * Field `SR_APPOINTMENT_REC_MONTHLY_NTH_WEEKMONTH_1_UNTIL`
  * Field `SR_APPOINTMENT_REC_MONTHLY_NTH_WEEKMONTH_2`
  * Field `SR_APPOINTMENT_REC_MONTHLY_NTH_WEEKMONTH_2_UNTIL`
  * Field `SR_APPOINTMENT_REC_MONTHLY_NTH_WEEKMONTH_3`
  * Field `SR_APPOINTMENT_REC_MONTHLY_NTH_WEEKMONTH_3_UNTIL`
  * Field `SR_APPOINTMENT_REC_MONTHLY_NTH_WEEKMONTH_4`
  * Field `SR_APPOINTMENT_REC_MONTHLY_NTH_WEEKMONTH_4_UNTIL`
  * Field `SR_APPOINTMENT_REC_MONTHLY_NTH_WEEKMONTH_5`
  * Field `SR_APPOINTMENT_REC_MONTHLY_NTH_WEEKMONTH_5_UNTIL`
  * Field `SR_APPOINTMENT_REC_MONTHLY_WEEKMONTH_1`
  * Field `SR_APPOINTMENT_REC_MONTHLY_WEEKMONTH_1_UNTIL`
  * Field `SR_APPOINTMENT_REC_MONTHLY_WEEKMONTH_2`
  * Field `SR_APPOINTMENT_REC_MONTHLY_WEEKMONTH_2_UNTIL`
  * Field `SR_APPOINTMENT_REC_MONTHLY_WEEKMONTH_3`
  * Field `SR_APPOINTMENT_REC_MONTHLY_WEEKMONTH_3_UNTIL`
  * Field `SR_APPOINTMENT_REC_MONTHLY_WEEKMONTH_4`
  * Field `SR_APPOINTMENT_REC_MONTHLY_WEEKMONTH_4_UNTIL`
  * Field `SR_APPOINTMENT_REC_MONTHLY_WEEKMONTH_5`
  * Field `SR_APPOINTMENT_REC_MONTHLY_WEEKMONTH_5_UNTIL`
  * Field `SR_APPOINTMENT_REC_NO_RECURRENCE`
  * Field `SR_APPOINTMENT_REC_NTH_DAY`
  * Field `SR_APPOINTMENT_REC_NTH_DAY_UNTIL`
  * Field `SR_APPOINTMENT_REC_NTH_WEEK`
  * Field `SR_APPOINTMENT_REC_NTH_WEEK_UNTIL`
  * Field `SR_APPOINTMENT_REC_WEEKLY`
  * Field `SR_APPOINTMENT_REC_WEEKLY_UNTIL`
  * Field `SR_APPOINTMENT_RECURRENCE_COUNT`
  * Field `SR_APPOINTMENT_RECURRENCE_TYPE`
  * Field `SR_APPOINTMENT_REPEAT_LABEL`
  * Field `SR_APPOINTMENT_SCHEDULING_ASSISTANT`
  * Field `SR_APPOINTMENT_SEND_EMAIL_CONFIRMATION`
  * Field `SR_APPOINTMENT_SET_VIDEO`
  * Field `SR_APPOINTMENT_SET_VIDEO_DESC`
  * Field `SR_APPOINTMENT_VIDEO_LINK`
  * Field `SR_APPOINTMENT_VIDEO_NOT_CONFIGURED`
  * Field `SR_ARCHIVE_EMAILFLOW_INSTANCE_CURRENTSTEPDESCRIPTION`
  * Field `SR_ARCHIVE_EMAILFLOW_INSTANCE_CURRENTSTEPDESCRIPTION_TOOLTIP`
  * Field `SR_ARCHIVE_EMAILFLOW_INSTANCE_DROPOUTREASON`
  * Field `SR_ARCHIVE_EMAILFLOW_INSTANCE_DROPOUTREASON_TOOLTIP`
  * Field `SR_ARCHIVE_EMAILFLOW_INSTANCE_LASTCOMMUNICATIONBOUNCEINFO`
  * Field `SR_ARCHIVE_EMAILFLOW_INSTANCE_LASTCOMMUNICATIONBOUNCEINFO_TOOLTIP`
  * Field `SR_ARCHIVE_EMAILFLOW_INSTANCE_LASTCOMMUNICATIONSTEPDESCRIPTION`
  * Field `SR_ARCHIVE_EMAILFLOW_INSTANCE_LASTCOMMUNICATIONSTEPDESCRIPTION_TOOLTIP`
  * Field `SR_ARCHIVE_EMAILFLOW_INSTANCE_LASTCOMMUNICATIONTIME`
  * Field `SR_ARCHIVE_EMAILFLOW_INSTANCE_LASTCOMMUNICATIONTIME_TOOLTIP`
  * Field `SR_ARCHIVE_EMAILFLOW_INSTANCE_STEPSTARTED`
  * Field `SR_ARCHIVE_EMAILFLOW_INSTANCE_STEPSTARTED_TOOLTIP`
  * Field `SR_ARCHIVE_EMAILFLOW_INSTANCE_WAITUNTIL`
  * Field `SR_ARCHIVE_EMAILFLOW_INSTANCE_WAITUNTIL_TOOLTIP`
  * Field `SR_CONFIGSCREEN_NOBORDER`
  * Field `SR_CONFIRMATION_DELETE_FOLLOWUP`
  * Field `SR_CONFIRMATION_RECURRING_NEW`
  * Field `SR_CONFIRMATION_RECURRING_PROMPT`
  * Field `SR_CRITERION_CATEGORIES_OWNED_BY_ME`
  * Field `SR_CRITERION_MY_CATEGORIES`
  * Field `SR_FLOW_TRIGGER_ADD_TRIGGER`
  * Field `SR_FLOW_TRIGGER_ADDEDTOPROJECT`
  * Field `SR_FLOW_TRIGGER_BLOCK_LIST`
  * Field `SR_FLOW_TRIGGER_CHATENABLED`
  * Field `SR_FLOW_TRIGGER_CONTACTCREATED`
  * Field `SR_FLOW_TRIGGER_FILTER_MATCH`
  * Field `SR_FLOW_TRIGGER_FLOW_START`
  * Field `SR_FLOW_TRIGGER_FORMSUBMITTED`
  * Field `SR_FLOW_TRIGGER_LINKCLICKED`
  * Field `SR_FLOW_TRIGGER_ORDERPLACED`
  * Field `SR_FLOW_TRIGGER_REQUESTCREATED`
  * Field `SR_FLOW_TRIGGER_SALECREATED`
  * Field `SR_FLOW_TRIGGER_SALELOST`
  * Field `SR_FLOW_TRIGGER_SALESOLD`
  * Field `SR_FLOW_TRIGGER_START_ONCE`
  * Field `SR_INBOX_ARCHIVE_UNSAFE_WARNING`
  * Field `SR_INBOX_UNSAFE_ATTACHMENT_TOOLTIP`
  * Field `SR_LIST_ITEM_MULTIPLE_SELECTED_TOOLTIP`
  * Field `SR_NOTIFY_ASSIGNMENT_DECLINED`
  * Field `SR_NOTIFY_ASSIGNMENT_FROM`
  * Field `SR_NOTIFY_BLOCKED_DESC`
  * Field `SR_NOTIFY_DECLINED`
  * Field `SR_NOTIFY_SETTINGS_notifySystemAppointment`
  * Field `SR_NOTIFY_SETTINGS_notifySystemChat`
  * Field `SR_NOTIFY_SETTINGS_notifySystemEmail`
  * Field `SR_NOTIFY_SETTINGS_SYSTEM_HEADING`
  * Field `SR_NOTIFY_TURN_ON`
  * Field `SR_NOTIFY_TURN_ON_TEXT`
  * Field `SR_NOTIFY_TURN_ON_TITLE`
  * Field `SR_PD_Functions_ShowWeekNumbersInCalendars_DESC`
  * Field `SR_PD_Functions_ShowWeekNumbersInCalendars_NAME`
  * Field `SR_PD_Mail_EnableEmailInvitationPreview_DESC`
  * Field `SR_PD_Mail_EnableEmailInvitationPreview_NAME`
  * Field `SR_PD_Mail_NotifyAttendeesByMail_DESC`
  * Field `SR_PD_Mail_NotifyAttendeesByMail_NAME`
  * Field `SR_PD_notificationEmail_notifyEmailOpenRequestsNotRead_DESC`
  * Field `SR_PD_notificationEmail_notifyEmailOpenRequestsNotRead_NAME`
  * Field `SR_PD_System_UnsafeFileTypes_DESC`
  * Field `SR_PD_System_UnsafeFileTypes_NAME`
  * Field `SR_PD_systemNotification_NAME`
  * Field `SR_PD_systemNotification_notifySystemAppointment_DESC`
  * Field `SR_PD_systemNotification_notifySystemAppointment_NAME`
  * Field `SR_PD_systemNotification_notifySystemChat_DESC`
  * Field `SR_PD_systemNotification_notifySystemChat_NAME`
  * Field `SR_PD_systemNotification_notifySystemEmail_DESC`
  * Field `SR_PD_systemNotification_notifySystemEmail_NAME`
  * Field `SR_REQUESTTYPE_PRIORITY_ERROR`
  * Field `SR_REQUESTTYPE_STATUS_ERROR`
  * Field `SR_SAVE_FIRST`
  * Field `SR_TICKET_POSTPONE_PAST_ERROR`
  * Field `SR_TICKETARCHIVE_TICKET_TYPE`
  * Field `SR_TICKETARCHIVE_TICKET_TYPE_TOOLTIP`
  * Field `SR_TICKETARCHIVE_TIME_SPENT`
  * Field `SR_TICKETSPLIT_NEW_REQUEST_PROPERTIES`
  * Field `SR_TICKETSPLIT_ORIGINAL_REQUEST_PROPERTIES`
  * Field `SR_UPLOAD_ERROR_UNSAFE_FILE`
  * Field `SR_WORKFLOW_ERROR_ADDEDTOBLOCKLIST`
  * Field `SR_WORKFLOW_ERROR_FORMEREMPLOYEE`
  * Field `SR_WORKFLOW_ERROR_NOCATEGORY`
  * Field `SR_WORKFLOW_ERROR_NOCONSENTFORPERSON`
  * Field `SR_WORKFLOW_ERROR_NOEMAILFORPERSON`
  * Field `SR_WORKFLOW_ERROR_NOSHIPMENTID`
  * Field `SR_WORKFLOW_ERROR_NOTITLE`
  * Field `SR_WORKFLOW_ERROR_PARTICIPANTIDNOTVALID`
  * Field `SR_WORKFLOW_ERROR_PERSONNOTFOUND`
  * Field `SR_WORKFLOW_ERROR_SENDINGUNSUSUCCESSFUL`
  * Field `SR_WORKFLOW_ERROR_STEPNOTFOUND`
  * Field `SR_WORKFLOW_ERROR_TOOMANYBOUNCES`
  * Field `SR_WORKFLOW_ERROR_UNKNOWNTIMEALGORITHM`
  * Field `SR_WORKFLOW_INSTANCE_STATUS_ACTIVE`
  * Field `SR_WORKFLOW_INSTANCE_STATUS_DROPOUT`
  * Field `SR_WORKFLOW_INSTANCE_STATUS_FINISHEDWITHSUCCESS`
  * Field `SR_WORKFLOWS_ADDSTEP_ADDTOPROJECT`
  * Field `SR_WORKFLOWS_ADDSTEP_ADDTOSELECTION`
  * Field `SR_WORKFLOWS_ADDTOSELECTIONANDPROJECT`
  * Field `SR_WORKFLOWS_AFTER_PREVIOUS`
  * Field `SR_WORKFLOWS_ARCHIVE_FOLDERNOTEMPTY`
  * Field `SR_WORKFLOWS_CONFIRMDELETEPARTICIPANTS`
  * Field `SR_WORKFLOWS_DELETE_RUNNING_FLOW`
  * Field `SR_WORKFLOWS_END_FLOW_QUESTION`
  * Field `SR_WORKFLOWS_FIRST_AVAILABLE`
  * Field `SR_WORKFLOWS_FIRST_AVAILABLE_AFTER`
  * Field `SR_WORKFLOWS_NOCONTENTAVAILABLE`
  * Field `SR_WORKFLOWS_NOSUBSCRIPTIONTYPE`
  * Field `SR_WORKFLOWS_REMOVEFROMPROJECT`
  * Field `SR_WORKFLOWS_REMOVEFROMSELECTION`
  * Field `SR_WORKFLOWS_REMOVEFROMSELECTIONANDPROJECT`
  * Field `SR_WORKFLOWS_REMOVESTEP_PROJECT`
  * Field `SR_WORKFLOWS_REMOVESTEP_SELECTION`
  * Field `SR_WORKFLOWS_REMPART_FLOWRUNNING`
  * Field `SR_WORKFLOWS_SENDMAIL_DESC`
  * Field `SR_WORKFLOWS_SUMMARY_UNTIL`
  * Field `SR_WORKFLOWSTEP_FINISH_ADD_NO_SUCCESS`
  * Field `SR_WORKFLOWSTEP_FINISH_ADDSUCCESS`

#### SuperOffice.License.SoLicenseNames is Modified

* Modified items
  * Field `AdminAnonymousUser`
  * Field `AdminExternUser`
  * Field `AdminSystemUser`
  * Field `AnonymousUserCal`
  * Field `ChatCal`
  * Field `DashCal`
  * Field `EJournalClient`
  * Field `EJournalReadonlyClient`
  * Field `EJournalSimClient`
  * Field `EJournalSimReadonlyClient`
  * Field `EJournalSpmCal`
  * Field `ExternUserCal`
  * Field `FormsCal`
  * Field `GuideCal`
  * Field `MailMergeCal`
  * Field `MarketingAutomationCal`
  * Field `OutlookSynchronizer`
  * Field `PocketCrmCal`
  * Field `ProjectCal`
  * Field `Publish`
  * Field `QuoteCal`
  * Field `RelationCal`
  * Field `RemoteTravel`
  * Field `ReportCal`
  * Field `ReporterStudioUser`
  * Field `SaintCal`
  * Field `SaleCal`
  * Field `SelectionCal`
  * Field `SelectionCombinedCal`
  * Field `StakeholderCal`
  * Field `SuperLicenseAssistant`
  * Field `SuperLicenseComplete`
  * Field `SuperLicenseContactManager`
  * Field `SuperLicenseMarketingPro`
  * Field `SuperLicenseNoSelection`
  * Field `SuperLicenseSalesPro`
  * Field `SuperLicenseServicePro`
  * Field `SynchronizerCal`
  * Field `SystemUserCal`
  * Field `TargetCal`
  * Field `TenMarketing`
  * Field `TenSales`
  * Field `TenSalesMarketing`
  * Field `TenSalesService`
  * Field `TenSalesServiceMarketing`
  * Field `TenService`
  * Field `TenServiceMarketing`
  * Field `Travel`
  * Field `User`
  * Field `VisibleFor`
  * Field `Web`
  * Field `Windows`
* New items
  * Field `PremiumSupport`

#### SuperOffice.SoDatabaseContext is Modified

* New items
  * Method `TryGetCurrentContextIdentifier()`

#### SuperOffice.UserPreferenceDefaults is Modified

* New items
  * Field `DefaultAlarmTime`
  * Field `NotifyAttendeesByMail`
  * Field `ShowWeekNumbersInCalendars`
  * Field `UnsafeFileTypes`

#### SuperOffice.Util.HttpHelper is Modified

* Modified items

##### SuperOffice.Util.HttpHelper.HttpServiceJwtConfig is Modified

* Modified items
  * Property `.HttpServiceJwtConfigHugoAI`
  * Property `.HttpServiceJwtConfigVideoMeetings`
  * Property `.HttpServiceJwtConfigZFD`



### Assembly: SoDatabase

### Deleted Types

* `SuperOffice.CRM.ArchiveLists.ExactKeyMatchCalculator`
* `SuperOffice.CRM.Data.TicketRelationActionTableInfo`
* `SuperOffice.CRM.Data.TicketRelationTableInfo`
* `SuperOffice.CRM.Data.TicketRelationTypeTableInfo`
* `SuperOffice.CRM.Documents.DocumentBase`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketRelationActionRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketRelationActionRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketRelationRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketRelationRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketRelationTypeRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketRelationTypeRowsFactory`
* `SuperOffice.CRM.Rows.TicketRelationActionRecordData`
* `SuperOffice.CRM.Rows.TicketRelationActionRecordDataExtensions`
* `SuperOffice.CRM.Rows.TicketRelationActionRow`
* `SuperOffice.CRM.Rows.TicketRelationActionRows`
* `SuperOffice.CRM.Rows.TicketRelationRecordData`
* `SuperOffice.CRM.Rows.TicketRelationRecordDataExtensions`
* `SuperOffice.CRM.Rows.TicketRelationRow`
* `SuperOffice.CRM.Rows.TicketRelationRows`
* `SuperOffice.CRM.Rows.TicketRelationTypeRecordData`
* `SuperOffice.CRM.Rows.TicketRelationTypeRecordDataExtensions`
* `SuperOffice.CRM.Rows.TicketRelationTypeRow`
* `SuperOffice.CRM.Rows.TicketRelationTypeRows`
* `SuperOffice.Data.SQL.ScreenChooserTypeFieldInfo`

### New Types

* `SuperOffice.CRM.Data.CcTemplateTableInfo`
* `SuperOffice.CRM.Data.Obsolete1TableInfo`
* `SuperOffice.CRM.Data.Obsolete2TableInfo`
* `SuperOffice.CRM.Data.Obsolete3TableInfo`
* `SuperOffice.CRM.Data.Obsolete4TableInfo`
* `SuperOffice.CRM.Data.TempDbLockTableInfo`
* `SuperOffice.CRM.Data.TicketTypePriorityTableInfo`
* `SuperOffice.CRM.Data.TicketTypeStatusTableInfo`
* `SuperOffice.CRM.Documents.DocumentEntityHelper`
* `SuperOffice.CRM.Lists.AppointmentResource`
* `SuperOffice.CRM.Lists.TicketTypeProvider`
* `SuperOffice.CRM.Mail.SendMailHelper`
* `SuperOffice.CRM.Rows.CcTemplateRecordData`
* `SuperOffice.CRM.Rows.CcTemplateRecordDataExtensions`
* `SuperOffice.CRM.Rows.CcTemplateRow`
* `SuperOffice.CRM.Rows.CcTemplateRows`
* `SuperOffice.CRM.Rows.Obsolete1RecordData`
* `SuperOffice.CRM.Rows.Obsolete1RecordDataExtensions`
* `SuperOffice.CRM.Rows.Obsolete1Row`
* `SuperOffice.CRM.Rows.Obsolete1Rows`
* `SuperOffice.CRM.Rows.Obsolete2RecordData`
* `SuperOffice.CRM.Rows.Obsolete2RecordDataExtensions`
* `SuperOffice.CRM.Rows.Obsolete2Row`
* `SuperOffice.CRM.Rows.Obsolete2Rows`
* `SuperOffice.CRM.Rows.Obsolete3RecordData`
* `SuperOffice.CRM.Rows.Obsolete3RecordDataExtensions`
* `SuperOffice.CRM.Rows.Obsolete3Row`
* `SuperOffice.CRM.Rows.Obsolete3Rows`
* `SuperOffice.CRM.Rows.Obsolete4RecordData`
* `SuperOffice.CRM.Rows.Obsolete4RecordDataExtensions`
* `SuperOffice.CRM.Rows.Obsolete4Row`
* `SuperOffice.CRM.Rows.Obsolete4Rows`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateCcTemplateRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateCcTemplateRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateObsolete1RowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateObsolete1RowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateObsolete2RowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateObsolete2RowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateObsolete3RowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateObsolete3RowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateObsolete4RowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateObsolete4RowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTempDbLockRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTempDbLockRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketTypePriorityRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketTypePriorityRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketTypeStatusRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTicketTypeStatusRowsFactory`
* `SuperOffice.CRM.Rows.TempDbLockRecordData`
* `SuperOffice.CRM.Rows.TempDbLockRecordDataExtensions`
* `SuperOffice.CRM.Rows.TempDbLockRow`
* `SuperOffice.CRM.Rows.TempDbLockRows`
* `SuperOffice.CRM.Rows.TicketTypePriorityRecordData`
* `SuperOffice.CRM.Rows.TicketTypePriorityRecordDataExtensions`
* `SuperOffice.CRM.Rows.TicketTypePriorityRow`
* `SuperOffice.CRM.Rows.TicketTypePriorityRows`
* `SuperOffice.CRM.Rows.TicketTypeStatusRecordData`
* `SuperOffice.CRM.Rows.TicketTypeStatusRecordDataExtensions`
* `SuperOffice.CRM.Rows.TicketTypeStatusRow`
* `SuperOffice.CRM.Rows.TicketTypeStatusRows`
* `SuperOffice.CRM.Script.CRMScriptServiceBase`
* `SuperOffice.CRM.Script.ICRMScriptService`
* `SuperOffice.CRM.TemporaryDbLock`
* `SuperOffice.CRM.Ticket.TicketData`
* `SuperOffice.CRM.Workflow.AddToListSettings`
* `SuperOffice.CRM.Workflow.CreateFollowUpSettings`
* `SuperOffice.CRM.Workflow.CreateRequestSettings`
* `SuperOffice.CRM.Workflow.RemoveFromListSettings`
* `SuperOffice.CRM.Workflow.SendEmailSettings`
* `SuperOffice.CRM.Workflow.SplitSettings`
* `SuperOffice.CRM.Workflow.StepSettings`
* `SuperOffice.CRM.Workflow.WaitForTimeSettings`
* `SuperOffice.CRM.WorkFlow.WorkflowEngine`
* `SuperOffice.CRM.WorkFlow.WorkflowEvent`
* `SuperOffice.CRM.WorkFlow.WorkflowEventResult`
* `SuperOffice.CRM.WorkFlow.WorkflowEventType`
* `SuperOffice.CRM.WorkFlow.WorkflowInstanceVariables`
* `SuperOffice.CRM.Workflow.WorkflowStepAddToList`
* `SuperOffice.CRM.Workflow.WorkflowStepBase`
* `SuperOffice.CRM.Workflow.WorkflowStepCreateFollowUp`
* `SuperOffice.CRM.Workflow.WorkflowStepCreateRequest`
* `SuperOffice.CRM.Workflow.WorkflowStepRemoveFromList`
* `SuperOffice.CRM.Workflow.WorkflowStepSendEmail`
* `SuperOffice.CRM.Workflow.WorkflowStepSplit`
* `SuperOffice.CRM.Workflow.WorkflowStepWaitForTime`
* `SuperOffice.CRM.Workflow.WorkflowUtil`
* `SuperOffice.Data.SQL.CcTemplateTypeFieldInfo`
* `SuperOffice.Data.SQL.ScriptTypeFieldInfo`

### Modified Types

#### Microsoft.Extensions.DependencyInjection.NetServerLocalOptions is Modified

* New items
  * Property `TempFileProviderType`

#### Microsoft.Extensions.DependencyInjection.NetServerLocalOptionsBuilder is Modified

* New items
  * Method `UseTempFileProvider<T>()`

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationAggregatorExtender is Modified

* Deleted items
  * Method `GetAppointmentStatusForRowType(String)`
  * Method `IsCurrentRowOwner(SoDataReader)`
* New items
  * Method `GetAppointmentStatusForOwner()`
  * Method `GetAppointmentStatusForParticipant()`
  * Method `IsAssignedRow(SoDataReader)`
  * Method `IsAssignmentStatus(SoDataReader)`
  * Method `IsBookingRowOwner(SoDataReader)`

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationAggregatorProvider is Modified

* New items
  * Method `AcceptRow(SoDataReader)`

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationExtenderBase is Modified

* New items
  * Field `IsAssignmentColumnName`

#### SuperOffice.CRM.ArchiveLists.EmailFlowInstanceExtenderBase is Modified

* Deleted items
* New items
  * Method `InnerPopulateRowFromReader(SoDataReader, ArchiveRow)`

#### SuperOffice.CRM.ArchiveLists.FavouritePersonExtender is Modified

* New items
  * Field `ColFavouritePersonAssociateId`

#### SuperOffice.CRM.ArchiveLists.NotificationNotificationExtender<Info> is Modified

* New items
  * Field `OriginatorFullNameColumnName`

#### SuperOffice.CRM.ArchiveLists.ParticipantsSubProviderBase is Modified

* New items
  * Field `ColumnRejectReason`

#### SuperOffice.CRM.ArchiveLists.SaleHistoryProvider is Modified

* New items
  * Method `PostProcessQuery()`

#### SuperOffice.CRM.ArchiveLists.TicketExtenderBase is Modified

* New items
  * Field `ColumnTicketType`
  * Method `GetAvailableColumns()`

#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* Deleted items
  * Property `LeftOuterJoin_TicketRelation_RegisteredAssociateId`
  * Property `LeftOuterJoin_TicketRelation_UpdatedAssociateId`
  * Property `LeftOuterJoin_TicketRelationAction_RegisteredAssociateId`
  * Property `LeftOuterJoin_TicketRelationAction_UpdatedAssociateId`
  * Property `LeftOuterJoin_TicketRelationType_RegisteredAssociateId`
  * Property `LeftOuterJoin_TicketRelationType_UpdatedAssociateId`
* New items
  * Property `LeftOuterJoin_CcTemplate_RegisteredAssociateId`
  * Property `LeftOuterJoin_CcTemplate_UpdatedAssociateId`
  * Property `LeftOuterJoin_TempDbLock_RegisteredAssociateId`
  * Property `LeftOuterJoin_TempDbLock_UpdatedAssociateId`
  * Property `LeftOuterJoin_TicketTypePriority_RegisteredAssociateId`
  * Property `LeftOuterJoin_TicketTypePriority_UpdatedAssociateId`
  * Property `LeftOuterJoin_TicketTypeStatus_RegisteredAssociateId`
  * Property `LeftOuterJoin_TicketTypeStatus_UpdatedAssociateId`

#### SuperOffice.CRM.Data.DBC is Modified

* Deleted items
  * Field `TicketRelation`
  * Field `TicketRelationAction`
  * Field `TicketRelationType`

##### SuperOffice.CRM.Data.DBC.TicketRelationActionFields is Deleted

##### SuperOffice.CRM.Data.DBC.TicketRelationFields is Deleted

##### SuperOffice.CRM.Data.DBC.TicketRelationTypeFields is Deleted
* Modified items

##### SuperOffice.CRM.Data.DBC.EjscriptFields is Modified

* New items
  * Field `.EjscriptFieldsType`


##### SuperOffice.CRM.Data.DBC.ScriptTraceRunFields is Modified

* New items
  * Field `.ScriptTraceRunFieldsFrames`


##### SuperOffice.CRM.Data.DBC.SShipmentAddrFields is Modified

* New items
  * Field `.SShipmentAddrFieldsWorkflowInstanceId`
  * Field `.SShipmentAddrFieldsWorkflowStepId`


##### SuperOffice.CRM.Data.DBC.TicketFields is Modified

* New items
  * Field `.TicketFieldsTimeSpent`


##### SuperOffice.CRM.Data.DBC.TicketTypeFields is Modified

* Deleted items
  * Field `.TicketTypeFieldsDescription`
  * Field `.TicketTypeFieldsFlags`
  * Field `.TicketTypeFieldsIconUrl`
  * Field `.TicketTypeFieldsNamePlural`
  * Field `.TicketTypeFieldsShowInNavigator`
* New items
  * Field `.TicketTypeFieldsDefaultPriority`
  * Field `.TicketTypeFieldsDefaultStatus`
  * Field `.TicketTypeFieldsIcon`
  * Field `.TicketTypeFieldsIsDefault`
  * Field `.TicketTypeFieldsIsExternal`
  * Field `.TicketTypeFieldsReplyTemplate`
  * Field `.TicketTypeFieldsTooltip`


##### SuperOffice.CRM.Data.DBC.WebhookFields is Modified

* New items
  * Field `.WebhookFieldsErrorsEmail`


##### SuperOffice.CRM.Data.DBC.WorkflowInstanceFields is Modified

* Deleted items
  * Field `.WorkflowInstanceFieldsNextStep`
* New items
  * Field `.WorkflowInstanceFieldsCurrentStep`
  * Field `.WorkflowInstanceFieldsDropoutReason`
  * Field `.WorkflowInstanceFieldsLastCommunicationStep`
  * Field `.WorkflowInstanceFieldsStepLevel`
  * Field `.WorkflowInstanceFieldsStepStarted`

* New items
  * Field `CcTemplate`
  * Field `Obsolete1`
  * Field `Obsolete2`
  * Field `Obsolete3`
  * Field `Obsolete4`
  * Field `TempDbLock`
  * Field `TicketTypePriority`
  * Field `TicketTypeStatus`

##### SuperOffice.CRM.Data.DBC.CcTemplateFields is New

##### SuperOffice.CRM.Data.DBC.Obsolete1Fields is New

##### SuperOffice.CRM.Data.DBC.Obsolete2Fields is New

##### SuperOffice.CRM.Data.DBC.Obsolete3Fields is New

##### SuperOffice.CRM.Data.DBC.Obsolete4Fields is New

##### SuperOffice.CRM.Data.DBC.TempDbLockFields is New

##### SuperOffice.CRM.Data.DBC.TicketTypePriorityFields is New

##### SuperOffice.CRM.Data.DBC.TicketTypeStatusFields is New

#### SuperOffice.CRM.Data.EjscriptTableInfo is Modified

* Deleted items
  * Property `LeftOuterJoin_TicketRelationAction_Action`
* New items
  * Property `Type`

#### SuperOffice.CRM.Data.ReplyTemplateTableInfo is Modified

* New items
  * Property `LeftOuterJoin_TicketType_ReplyTemplate`

#### SuperOffice.CRM.Data.ScriptTraceRunTableInfo is Modified

* New items
  * Property `Frames`

#### SuperOffice.CRM.Data.SShipmentAddrTableInfo is Modified

* New items
  * Property `WorkflowInstanceId`
  * Property `WorkflowInstanceId_InnerJoin_WorkflowInstance`
  * Property `WorkflowStepId`
  * Property `WorkflowStepId_InnerJoin_WorkflowStep`

#### SuperOffice.CRM.Data.TicketPriorityTableInfo is Modified

* New items
  * Property `LeftOuterJoin_TicketType_DefaultPriority`
  * Property `LeftOuterJoin_TicketTypePriority_TicketPriorityId`

#### SuperOffice.CRM.Data.TicketStatusTableInfo is Modified

* New items
  * Property `LeftOuterJoin_TicketType_DefaultStatus`
  * Property `LeftOuterJoin_TicketTypeStatus_TicketStatusId`

#### SuperOffice.CRM.Data.TicketTableInfo is Modified

* Deleted items
  * Property `LeftOuterJoin_TicketRelation_Source`
  * Property `LeftOuterJoin_TicketRelation_Target`
* New items
  * Property `TimeSpent`

#### SuperOffice.CRM.Data.TicketTypeTableInfo is Modified

* Deleted items
  * Property `Description`
  * Property `Flags`
  * Property `IconUrl`
  * Property `LeftOuterJoin_TicketRelationType_SourceType`
  * Property `LeftOuterJoin_TicketRelationType_TargetType`
  * Property `NamePlural`
  * Property `ShowInNavigator`
* New items
  * Property `DefaultPriority`
  * Property `DefaultPriority_InnerJoin_TicketPriority`
  * Property `DefaultStatus`
  * Property `DefaultStatus_InnerJoin_TicketStatus`
  * Property `Icon`
  * Property `IsDefault`
  * Property `IsExternal`
  * Property `LeftOuterJoin_TicketTypePriority_TicketTypeId`
  * Property `LeftOuterJoin_TicketTypeStatus_TicketTypeId`
  * Property `ReplyTemplate`
  * Property `ReplyTemplate_InnerJoin_ReplyTemplate`
  * Property `Tooltip`

#### SuperOffice.CRM.Data.WebhookTableInfo is Modified

* New items
  * Property `ErrorsEmail`

#### SuperOffice.CRM.Data.WorkflowInstanceTableInfo is Modified

* Deleted items
  * Property `NextStep`
  * Property `NextStep_InnerJoin_WorkflowStep`
* New items
  * Property `CurrentStep`
  * Property `CurrentStep_InnerJoin_WorkflowStep`
  * Property `DropoutReason`
  * Property `LastCommunicationStep`
  * Property `LastCommunicationStep_InnerJoin_WorkflowStep`
  * Property `LeftOuterJoin_SShipmentAddr_WorkflowInstanceId`
  * Property `StepLevel`
  * Property `StepStarted`

#### SuperOffice.CRM.Data.WorkflowStepTableInfo is Modified

* Deleted items
  * Property `LeftOuterJoin_WorkflowInstance_NextStep`
* New items
  * Property `LeftOuterJoin_SShipmentAddr_WorkflowStepId`
  * Property `LeftOuterJoin_WorkflowInstance_CurrentStep`
  * Property `LeftOuterJoin_WorkflowInstance_LastCommunicationStep`

#### SuperOffice.CRM.Documents.PhysicalDocumentTemplate is Modified

* Modified items
  * Method `Load()`
  * Method `Save(Stream)`

#### SuperOffice.CRM.Documents.SoArc2 is Modified

* New items
  * Method `SoArc2(IFileAccess)`

#### SuperOffice.CRM.Entities.ConflictDetector is Modified

* Modified items

##### SuperOffice.CRM.Entities.ConflictDetector.ConflictTime is Modified

* New items
  * Method `.ConflictTimeToShortDateTimeString()`

* New items
  * Method `GetConflictTimes(Int32, Int32, Int32[], ConflictTime[])`
  * Method `GetConflictTimes(Int32, Int32, Int32[], TimeSpan, TimeSpan, DateTime[])`

#### SuperOffice.CRM.Lists.ExportTemplateProvider is Modified

* Deleted items
  * Method `ExportTemplateProvider()`
* New items
  * Method `ExportTemplateProvider(IFileAccess)`

#### SuperOffice.CRM.Lists.VisibleForAssociateMDOProvider is Modified

* New items
  * Field `ContactNameAdditionalInfo`
  * Method `Construct(String, String, Int32[], Boolean, String, Boolean)`
  * Method `GenerateCommonQuery(CustomSearch, ListInfo)`
  * Method `GetItemExtraInfo(ListTableRow)`
  * Method `GetItemName(ListTableRow)`

#### SuperOffice.CRM.ListsHelper is Modified

* New items
  * Field `ContactWithoutPersonsRootItemType`
  * Field `OrphanRootItemType`

#### SuperOffice.CRM.Mail.EMailHelper is Modified

* New items
  * Method `GetFileExtensionValidator()`

#### SuperOffice.CRM.Mail.MessageStoreSession is Modified

* Deleted items
  * Method `GetEMailStream(Int32, Boolean)`
* New items
  * Method `GetEMailStream(Int32, Boolean, Boolean)`

#### SuperOffice.CRM.Rows.EjscriptRecordData is Modified

* New items
  * Field `Type`

#### SuperOffice.CRM.Rows.EjscriptRow is Modified

* New items
  * Property `Type`

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(CcTemplateType&, FieldInfo)`
  * Method `ValidateField(ScriptType&, FieldInfo)`
  * Method `ValidateField(ShipmentFlags&, FieldInfo)`
  * Method `ValidateField(WorkflowActionType&, FieldInfo)`
  * Method `ValidateField(WorkflowEventType&, FieldInfo)`
  * Method `ValidateField(WorkflowOwnerType&, FieldInfo)`

#### SuperOffice.CRM.Rows.ScriptTraceRunRecordData is Modified

* New items
  * Field `Frames`

#### SuperOffice.CRM.Rows.ScriptTraceRunRow is Modified

* New items
  * Property `Frames`

#### SuperOffice.CRM.Rows.SShipmentAddrRecordData is Modified

* New items
  * Field `WorkflowInstanceId`
  * Field `WorkflowStepId`

#### SuperOffice.CRM.Rows.SShipmentAddrRow is Modified

* New items
  * Property `WorkflowInstanceId`
  * Property `WorkflowStepId`

#### SuperOffice.CRM.Rows.SShipmentAddrRows is Modified

* New items
  * Method `GetFromIdxWorkflowInstanceId(Int32)`
  * Method `GetFromIdxWorkflowStepId(Int32)`

##### SuperOffice.CRM.Rows.SShipmentAddrRows.IdxWorkflowInstanceId is New

##### SuperOffice.CRM.Rows.SShipmentAddrRows.IdxWorkflowStepId is New

#### SuperOffice.CRM.Rows.TicketRecordData is Modified

* New items
  * Field `TimeSpent`

#### SuperOffice.CRM.Rows.TicketRow is Modified

* New items
  * Property `TimeSpent`

#### SuperOffice.CRM.Rows.TicketTypeRecordData is Modified

* Deleted items
  * Field `Description`
  * Field `Flags`
  * Field `IconUrl`
  * Field `NamePlural`
  * Field `ShowInNavigator`
* New items
  * Field `DefaultPriority`
  * Field `DefaultStatus`
  * Field `Icon`
  * Field `IsDefault`
  * Field `IsExternal`
  * Field `ReplyTemplate`
  * Field `Tooltip`

#### SuperOffice.CRM.Rows.TicketTypeRow is Modified

* Deleted items
  * Property `Description`
  * Property `Flags`
  * Property `IconUrl`
  * Property `NamePlural`
  * Property `ShowInNavigator`
* New items
  * Property `DefaultPriority`
  * Property `DefaultStatus`
  * Property `Icon`
  * Property `IsDefault`
  * Property `IsExternal`
  * Property `ReplyTemplate`
  * Property `Tooltip`
  * Method `GetFromIdxName(String)`

##### SuperOffice.CRM.Rows.TicketTypeRow.IdxName is New

#### SuperOffice.CRM.Rows.TicketTypeRows is Modified

* New items
  * Method `GetFromIdxDefaultPriority(Int32)`
  * Method `GetFromIdxDefaultStatus(Int32)`
  * Method `GetFromIdxReplyTemplate(Int32)`

##### SuperOffice.CRM.Rows.TicketTypeRows.IdxDefaultPriority is New

##### SuperOffice.CRM.Rows.TicketTypeRows.IdxDefaultStatus is New

##### SuperOffice.CRM.Rows.TicketTypeRows.IdxReplyTemplate is New

#### SuperOffice.CRM.Rows.UDefFieldCacheBase is Modified

* New items
  * Method `LoadOnDemand()`

#### SuperOffice.CRM.Rows.WebhookRecordData is Modified

* New items
  * Field `ErrorsEmail`

#### SuperOffice.CRM.Rows.WebhookRow is Modified

* New items
  * Property `ErrorsEmail`

#### SuperOffice.CRM.Rows.WorkflowInstanceRecordData is Modified

* Deleted items
  * Field `NextStep`
* New items
  * Field `CurrentStep`
  * Field `DropoutReason`
  * Field `LastCommunicationStep`
  * Field `StepLevel`
  * Field `StepStarted`

#### SuperOffice.CRM.Rows.WorkflowInstanceRow is Modified

* Deleted items
  * Property `NextStep`
* New items
  * Property `CurrentStep`
  * Property `DropoutReason`
  * Property `LastCommunicationStep`
  * Property `StepLevel`
  * Property `StepStarted`

#### SuperOffice.CRM.Security.EjCategoryCache is Modified

* New items
  * Method `GetCategoriesUserIsMasterOf(Int32)`
  * Method `GetCategoriesUserIsMemberOrMasterOf(Int32)`

#### SuperOffice.CRM.Security.FunctionRightCache is Modified

* New items
  * Method `ShouldReporterBeHidden()`

#### SuperOffice.CRM.Ticket.TicketChangeNotificator is Modified

* New items
  * Method `DeleteTicketNotifyEntries(Int32, Int32)`

#### SuperOffice.CRM.Ticket.TicketHelper is Modified

* Deleted items
  * Method `HasUpdateRight(Int32, Int32, Int32, DateTime, Int32)`
  * Method `UpdateMessagesAndRepliesCount(Int32)`
* Modified items
  * Method `GetTicketData(Int32)`
* New items
  * Method `HasUpdateRight(TicketData)`
  * Method `UpdateTicketStatisticsFromMessages(Int32)`

#### SuperOffice.CRM.TicketMessage.TicketMessageHelper is Modified

* Deleted items
  * Method `GetDefaultMessageContent(Int32, MessageActionType, Int32)`
* New items
  * Method `GetDefaultMessageContent(Int32, MessageActionType, Int32, Boolean)`

#### SuperOffice.CRM.Webhooks.Webhook is Modified

* New items
  * Property `ErrorsEmail`

#### SuperOffice.Data.Dialect.DatabaseOperations is Modified

* Deleted items
  * Method `TruncateTable(SoTable, TruncateOptions)`
* New items
  * Method `TruncateTable(SoTable, TruncateOptions, Boolean)`

#### SuperOffice.Data.Private.FreetextIndexer is Modified


#### SuperOffice.Data.Private.RegisteredUpdater is Modified

* Modified items
  * Method `DisableAutoUpdate()`

##### SuperOffice.Data.Private.RegisteredUpdater.DisableUpdate is Modified



#### SuperOffice.Data.Private.SimpleQueryUpdaterBase is Modified


#### SuperOffice.Data.S is Modified

* Deleted items
  * Method `DeleteFromSelect<TI>(TargetedSelect<TI>)`
* New items
  * Method `DeleteFromSelect<TI>(TargetedSelect<TI>, BatchSave)`

#### SuperOffice.Data.SoDatabase is Modified

* New items
  * Method `LoadSettingsFromUserPreference()`

#### SuperOffice.Data.SQL.BatchSave is Modified

* New items
  * Method `BatchSave(IEnumerable<PrivateSave>)`

#### SuperOffice.Data.TablesInfo is Modified

* Deleted items
  * Method `GetTicketRelationActionTableInfo()`
  * Method `GetTicketRelationTableInfo()`
  * Method `GetTicketRelationTypeTableInfo()`
* New items
  * Method `GetCcTemplateTableInfo()`
  * Method `GetObsolete1TableInfo()`
  * Method `GetObsolete2TableInfo()`
  * Method `GetObsolete3TableInfo()`
  * Method `GetObsolete4TableInfo()`
  * Method `GetTempDbLockTableInfo()`
  * Method `GetTicketTypePriorityTableInfo()`
  * Method `GetTicketTypeStatusTableInfo()`


### Assembly: SuperOffice.Plugins

### Modified Types

#### SuperOffice.Factory.AssemblyHelper is Modified

* New items
  * Method `IsSystemAssembly(String)`


### Assembly: SoLicense

## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### Deleted Types

* `SuperOffice.CD.DSL.Database.T_TicketRelation`
* `SuperOffice.CD.DSL.Database.T_TicketRelationAction`
* `SuperOffice.CD.DSL.Database.T_TicketRelationType`

### New Types

* `SuperOffice.CD.Database.ShipmentFlags`
* `SuperOffice.CD.Database.WorkflowActionType`
* `SuperOffice.CD.Database.WorkflowEventType`
* `SuperOffice.CD.Database.WorkflowOwnerType`
* `SuperOffice.CD.DSL.Database.CcTemplateType`
* `SuperOffice.CD.DSL.Database.CRMScriptStep08_ScriptType`
* `SuperOffice.CD.DSL.Database.CRMScriptStep09_ScriptTraceRunFrames`
* `SuperOffice.CD.DSL.Database.CS_40_ListClean_RequestTypes`
* `SuperOffice.CD.DSL.Database.CS_41_Reorg_RequestTypes`
* `SuperOffice.CD.DSL.Database.CS_42_Recreate_TicketType`
* `SuperOffice.CD.DSL.Database.CS_43_Adjust_TicketType`
* `SuperOffice.CD.DSL.Database.CS_45_TicketType_Mirroring`
* `SuperOffice.CD.DSL.Database.NotifyType`
* `SuperOffice.CD.DSL.Database.ScriptType`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_38_TicketTimeSpent`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_39_RequestType`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_44_TicketTimeSpan`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_46_TicketTypeIsDefault`
* `SuperOffice.CD.DSL.Database.Steps_Webhooks.Webhooks_04_Add_ErrorEmail`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep10_Locking`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep11_ParticipantFields`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep12_SShipmentAddrForeignKeysToFlow`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep13_SShipmentAddrForeignKeyIndexing`
* `SuperOffice.CD.DSL.Database.SuperOffice_104_Freetext_SequenceIds`
* `SuperOffice.CD.DSL.Database.T_CcTemplate`
* `SuperOffice.CD.DSL.Database.T_Obsolete1`
* `SuperOffice.CD.DSL.Database.T_Obsolete2`
* `SuperOffice.CD.DSL.Database.T_Obsolete3`
* `SuperOffice.CD.DSL.Database.T_Obsolete4`
* `SuperOffice.CD.DSL.Database.T_TempDbLock`
* `SuperOffice.CD.DSL.Database.T_TicketTypePriority`
* `SuperOffice.CD.DSL.Database.T_TicketTypeStatus`

### Modified Types

#### SuperOffice.CD.Database.Registry is Modified

* New items
  * Field `CustomerCenterTemplatesMovedToDB`
  * Field `DisableImportMailInlineSupport`
  * Field `SearchEngineCallback`

#### SuperOffice.CD.Database.WorkflowInstanceStatus is Modified

* Deleted items
  * Field `Faulted`
  * Field `Running`
  * Field `Suspended`
* New items
  * Field `Active`
  * Field `DropOut`
  * Field `FinishedWithSuccess`

#### SuperOffice.CD.Database.WorkflowTriggerType is Modified

* Deleted items
  * Field `AddToList`
  * Field `CreateFollowUp`
  * Field `CreateRequest`
  * Field `CreateSale`
  * Field `NotifyByEmail`
  * Field `NotifyBySMS`
  * Field `RemoveFromList`
  * Field `SendEmail`
  * Field `SendSMS`
  * Field `Split`
  * Field `UpdateContact`
  * Field `WaitForAction`
  * Field `WaitForTime`
* New items
  * Field `AddedMessage`
  * Field `AddedToProject`
  * Field `AddedToSelection`
  * Field `ContactCreated`
  * Field `ContactUpdated`
  * Field `CreatedRequest`
  * Field `FormSubmitted`
  * Field `LinkClicked`
  * Field `OrderPlaced`
  * Field `SaleCreated`
  * Field `SaleLost`
  * Field `SaleSold`
  * Field `StartedChat`

#### SuperOffice.CD.DSL.Database.T_Ejscript is Modified

* New items
  * Field `Type`

#### SuperOffice.CD.DSL.Database.T_ScriptTraceRun is Modified

* New items
  * Field `Frames`

#### SuperOffice.CD.DSL.Database.T_SShipmentAddr is Modified

* New items
  * Field `WorkflowInstanceId`
  * Field `WorkflowStepId`

#### SuperOffice.CD.DSL.Database.T_Ticket is Modified

* New items
  * Field `TimeSpent`

#### SuperOffice.CD.DSL.Database.T_TicketType is Modified

* Deleted items
  * Field `Description`
  * Field `Flags`
  * Field `IconUrl`
  * Field `NamePlural`
  * Field `ShowInNavigator`
* New items
  * Field `DefaultPriority`
  * Field `DefaultStatus`
  * Field `Icon`
  * Field `IsDefault`
  * Field `IsExternal`
  * Field `ReplyTemplate`
  * Field `Tooltip`

#### SuperOffice.CD.DSL.Database.T_Webhook is Modified

* New items
  * Field `ErrorsEmail`

#### SuperOffice.CD.DSL.Database.T_WorkflowInstance is Modified

* Deleted items
  * Field `NextStep`
* New items
  * Field `CurrentStep`
  * Field `DropoutReason`
  * Field `LastCommunicationStep`
  * Field `StepLevel`
  * Field `StepStarted`
