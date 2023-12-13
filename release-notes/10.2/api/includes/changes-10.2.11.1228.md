---
uid: version_10.2.11.1228_changes
so.date: 12/13/2023
---

Changes from v10.2.10.1344 and v10.2.11.1228

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.AppointmentInfo`
* `SuperOffice.CRM.Services.AppointmentSaveData`
* `SuperOffice.CRM.Services.FieldValue`

### Modified Types

#### SuperOffice.CRM.Services.AppointmentAgent is Modified

* New items
  * Method `GetAppointmentEmailInvitation(AppointmentEntity, String, String)`
  * Method `GetAssociatesDiaryInfo(Int32[], DateTime, DateTime)`
  * Method `SaveWithCustomInvitation(AppointmentEntity, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo, String, String, String)`

#### SuperOffice.CRM.Services.CRMScriptTraceRun is Modified

* New items
  * Property `ForceSaveTrace`

#### SuperOffice.CRM.Services.DiagnosticsAgent is Modified

* New items
  * Method `GetEntityCountsForAllUsers()`

#### SuperOffice.CRM.Services.IAppointmentAgent is Modified

* New items
  * Method `GetAppointmentEmailInvitation(AppointmentEntity, String, String)`
  * Method `GetAssociatesDiaryInfo(Int32[], DateTime, DateTime)`
  * Method `SaveWithCustomInvitation(AppointmentEntity, RecurrenceUpdateMode, Boolean, EMailConnectionInfo, EMailConnectionInfo, String, String, String)`

#### SuperOffice.CRM.Services.IDiagnosticsAgent is Modified

* New items
  * Method `GetEntityCountsForAllUsers()`

#### SuperOffice.CRM.Services.WorkflowStepSendSMS is Modified

* New items
  * Property `Exit`
  * Property `From`
  * Property `Text`

#### SuperOffice.CRM.Services.WorkflowStepSplit is Modified

* New items
  * Property `ExitFlow`
  * Property `ShipmentId`
  * Property `SplitName`

#### SuperOffice.CRM.Services.WorkflowStepUpdateParticipant is Modified

* New items
  * Property `FieldValues`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### New Types

* `SuperOffice.CRM.Services.StringBoolDictionary`
* `SuperOffice.CRM.Services.stringBoolDictionaryExt`
* `SuperOffice.IO.Files.SoFileInfo`

### Modified Types

#### SuperOffice.CRM.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.CRM.UserPreferenceStrings.System is Modified

* New items
  * Field `.SystemWebToolsDetectionTimeout`


#### SuperOffice.Globalization.RC is Modified

* Deleted items
  * Field `SR_APPOINTMENT_ATTENDEE_STATISTICS`
  * Field `SR_APPOINTMENT_ATTENDEE_STATISTICS_CONFLICTS`
  * Field `SR_FLOW_SPLIT_PROJECTMEMBER`
  * Field `SR_FLOW_SPLIT_SELECTIONMEMBER`
* New items
  * Field `SR_APPOINTMENT_ALARM_AT_START`
  * Field `SR_APPOINTMENT_ALARM_MINUTES`
  * Field `SR_APPOINTMENT_CUSTOM_ALARM`
  * Field `SR_APPOINTMENT_CUSTOM_ALARM_TEXT`
  * Field `SR_APPOINTMENT_DESIGNER_WARNING`
  * Field `SR_APPOINTMENT_LOCATION`
  * Field `SR_APPOINTMENT_PREVIEW_EMAIL`
  * Field `SR_APPOINTMENT_PREVIEW_WARNING`
  * Field `SR_APPOINTMENT_RECURRENCE_PATTERN`
  * Field `SR_APPOINTMENT_REPLY_ALL`
  * Field `SR_APPOINTMENT_REPLY_THIS`
  * Field `SR_APPOINTMENT_STATS_ATTENDEES`
  * Field `SR_APPOINTMENT_STATS_CONFLICTS`
  * Field `SR_APPOINTMENT_TOGGLE_EMAIL_ERROR`
  * Field `SR_CONFIRMATION_NEVERSHOWTHISAGAIN`
  * Field `SR_DOCEDIT_MAILLINK_INFORMATION`
  * Field `SR_DOCEDIT_MAILLINK_INSTALL`
  * Field `SR_DOCEDIT_MANUAL_UPLOAD`
  * Field `SR_DOCEDIT_WEBTOOLS`
  * Field `SR_DOCEDIT_WEBTOOLS_INFORMATION`
  * Field `SR_DOCEDIT_WEBTOOLS_INSTALL`
  * Field `SR_FLOW_CREATEEMAIL`
  * Field `SR_FLOW_EMAILNAME_MANDATORY`
  * Field `SR_FLOW_EXISTINGEMAIL`
  * Field `SR_FLOW_HEADERSTEPS`
  * Field `SR_FLOW_SPLIT_ADDBRANCH`
  * Field `SR_FLOW_SPLIT_BRANCH`
  * Field `SR_FLOW_SPLIT_BRANCHNAME`
  * Field `SR_FLOW_SPLIT_DESC`
  * Field `SR_FLOW_SPLIT_EVERYONEELSE`
  * Field `SR_FLOW_SPLIT_EXIT`
  * Field `SR_FLOW_SPLIT_EXITFLOW`
  * Field `SR_FLOW_SPLIT_LINKCLICKED`
  * Field `SR_FLOW_SPLIT_PROJECTMEMBERSHIP`
  * Field `SR_FLOW_SPLIT_SELECTIONMEMBERSHIP`
  * Field `SR_LABEL_SHARE`
  * Field `SR_PD_System_WebToolsDetectionTimeout_DESC`
  * Field `SR_PD_System_WebToolsDetectionTimeout_NAME`
  * Field `SR_SETUP_DOCUMENT_EDITING`
  * Field `SR_SHIPMENT_ADDR_ANY_EMAIL`
  * Field `SR_TICKET_FIND_TICKET_TOOLTIP`
  * Field `SR_TICKET_FINDREQUEST_TOOLTIP`
  * Field `SR_WORKFLOWS_END_FLOW_ERROR_DESC`
  * Field `SR_WORKFLOWSTEP_EXIT_FLOW`
  * Field `SR_WORKFLOWSTEP_SMS_COUNT`

#### SuperOffice.IO.Files.DiskFileAccess is Modified

* New items
  * Method `CreateForWrite(String)`
  * Method `DirectoryGetFileInfos(String)`
  * Method `FileDelete(String)`

#### SuperOffice.IO.Files.IFileAccess is Modified

* New items
  * Method `CreateForWrite(String)`
  * Method `DirectoryGetFileInfos(String)`
  * Method `FileDelete(String)`


### Assembly: SoDatabase

### New Types

* `SuperOffice.CRM.ArchiveLists.Joiners.AppointmentTextConversionExtender`
* `SuperOffice.CRM.Entities.PersonPhoneSyncHelper`
* `SuperOffice.CRM.Lists.InvitationTemplateLanguageProvider`
* `SuperOffice.CRM.Workflow.SendSMSSettings`
* `SuperOffice.CRM.Workflow.UpdateParticipantSettings`
* `SuperOffice.CRM.Workflow.WorkflowStepSendSMS`
* `SuperOffice.CRM.Workflow.WorkflowStepUpdateParticipant`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.HtmlTextExtenderBase is Modified

* New items
  * Method `IsHtmlTextGhostFieldOrEmpty(SoDataReader)`

#### SuperOffice.CRM.BulkUpdate.BulkUpdateSystem is Modified

* Deleted items
  * Method `GetAvailableContactFields()`
  * Method `GetAvailableFields(String)`
  * Method `GetAvailablePersonFields()`
* New items
  * Method `GetAvailableContactFields(Boolean)`
  * Method `GetAvailableFields(String, String)`
  * Method `GetAvailablePersonFields(Boolean)`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.InvitationFields is Modified

* New items
  * Field `.InvitationFieldsTemplateLanguage`


##### SuperOffice.CRM.Data.DBC.ScriptTraceFields is Modified

* New items
  * Field `.ScriptTraceFieldsExceptionOnly`
  * Field `.ScriptTraceFieldsNotificationEmail`
  * Field `.ScriptTraceFieldsNotify`
  * Field `.ScriptTraceFieldsNumNotifications`
  * Field `.ScriptTraceFieldsSumRuns`
  * Field `.ScriptTraceFieldsSumSize`


#### SuperOffice.CRM.Data.InvitationTableInfo is Modified

* New items
  * Property `TemplateLanguage`

#### SuperOffice.CRM.Data.ScriptTraceTableInfo is Modified

* New items
  * Property `ExceptionOnly`
  * Property `NotificationEmail`
  * Property `Notify`
  * Property `NumNotifications`
  * Property `SumRuns`
  * Property `SumSize`

#### SuperOffice.CRM.Entities.AppointmentMatrix is Modified

* New items
  * Method `EmailWasQueued()`
  * Method `SetInvitationMailBody(String, String, String)`

#### SuperOffice.CRM.Entities.Providers.AppointmentInfoProvider is Modified

* New items
  * Method `AddEmailParticipantToInviteText(String, String)`
  * Method `AddPersonParticipantToInviteText(Person, String)`
  * Method `GetEmailAddressDictionary(AppointmentCollection)`
  * Method `GetEmailAddressDictionary(AppointmentRow[])`

#### SuperOffice.CRM.Lists.LocationListProvider is Modified

* New items
  * Field `ProviderName`

#### SuperOffice.CRM.Lists.TimeZoneIANAProvider is Modified

* New items
  * Method `BaseQuery()`

#### SuperOffice.CRM.Lists.TimeZoneProvider is Modified

* Modified items
  * Method `BaseQuery()`

#### SuperOffice.CRM.Rows.AppointmentRows is Modified

* New items
  * Method `GetFromIdxAgendaTextId(Int32)`

##### SuperOffice.CRM.Rows.AppointmentRows.IdxAgendaTextId is New

#### SuperOffice.CRM.Rows.InvitationRecordData is Modified

* New items
  * Field `TemplateLanguage`

#### SuperOffice.CRM.Rows.InvitationRow is Modified

* New items
  * Property `TemplateLanguage`

#### SuperOffice.CRM.Rows.ScriptTraceRecordData is Modified

* New items
  * Field `ExceptionOnly`
  * Field `NotificationEmail`
  * Field `Notify`
  * Field `NumNotifications`
  * Field `SumRuns`
  * Field `SumSize`

#### SuperOffice.CRM.Rows.ScriptTraceRow is Modified

* New items
  * Property `ExceptionOnly`
  * Property `NotificationEmail`
  * Property `Notify`
  * Property `NumNotifications`
  * Property `SumRuns`
  * Property `SumSize`

#### SuperOffice.CRM.Security.AppointmentSentryQueryInfo is Modified

* New items
  * Property `InternalNotesTableInfos`

#### SuperOffice.CRM.Workflow.SplitSettings is Modified

* New items
  * Property `ExitFlow`
  * Property `ShipmentId`
  * Property `SplitName`

#### SuperOffice.Util.AppointmentUtility is Modified

* Deleted items
  * Method `GetOrCreateUidOfAppointment(Int32, String, DateTime, Nullable<DateTime>, Nullable<DateTime>, Int32&)`
* New items
  * Method `CleanSynchronizerValuesFromDescription(String)`
  * Method `GetAgenda(String, Boolean)`
  * Method `GetAgendaHtml(String, Boolean)`
  * Method `GetDescription(String, String)`
  * Method `GetOrCreateUidOfAppointment(Int32, String, DateTime, Nullable<DateTime>, Nullable<DateTime>, String, Int32&)`
  * Method `GetRecurringSeriesForInvitedEmailAttendee(Int32, Int32)`
  * Method `GetTemplateLanguage(Int32)`
  * Method `GetTitle(String, Boolean)`
  * Method `HaveChanged(String, String)`

#### SuperOffice.Util.iCalendarUtility is Modified

* Deleted items
  * Method `CreateInvitation(AppointmentRow, Nullable<DateTime>, Nullable<DateTime>, AppointmentRow[])`
  * Method `CreateThisAndForwardInvitationEvent(AppointmentRow, DateTime, DateTime, DateTime, AppointmentRow[])`
  * Method `GetSummaryAndDescription(Int32, String)`
* New items
  * Method `CreateInvitation(AppointmentRow, Nullable<DateTime>, Nullable<DateTime>, String, AppointmentRow[])`
  * Method `CreateThisAndForwardInvitationEvent(AppointmentRow, DateTime, DateTime, DateTime, AppointmentRow[], String)`
  * Method `GetSummaryAndDescription(AppointmentRow, String)`


## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.DSL.Database.CRMScriptStep10_ScriptTraceEmail`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_50_TicketTypeTooltip`
* `SuperOffice.CD.DSL.Database.Steps_FollowUpDialog.FollowUpDialog_03_AddIndexOnAppointmentAgenda`

### Modified Types

#### SuperOffice.CD.DSL.Database.T_Invitation is Modified

* New items
  * Field `TemplateLanguage`

#### SuperOffice.CD.DSL.Database.T_ScriptTrace is Modified

* New items
  * Field `ExceptionOnly`
  * Field `NotificationEmail`
  * Field `Notify`
  * Field `NumNotifications`
  * Field `SumRuns`
  * Field `SumSize`



