---
uid: version_10.2.10.1344_changes
so.date: 11/20/2023
---

# Changes from v10.2.9.778 and v10.2.10.1344

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.NextAvailableTime`
* `SuperOffice.CRM.Services.TicketMessageContent`
* `SuperOffice.CRM.Services.WorkflowStepOptionBase`
* `SuperOffice.CRM.Services.WorkflowStepOptionFormSubmission`
* `SuperOffice.CRM.Services.WorkflowStepOptionLinkClicked`
* `SuperOffice.CRM.Services.WorkflowStepOptionPersonData`
* `SuperOffice.CRM.Services.WorkflowStepOptionProjectMembership`
* `SuperOffice.CRM.Services.WorkflowStepOptionSelectionMembership`

### Modified Types

#### SuperOffice.CRM.Services.Appointment is Modified

* New items
  * Property `PreferredTZLocation`

#### SuperOffice.CRM.Services.AppointmentAgent is Modified

* New items
  * Method `GetNextAvailableTime(Int32[], DateTime, DateTime, Int32, Boolean)`

#### SuperOffice.CRM.Services.AppointmentEntity is Modified

* New items
  * Property `PreferredTZLocationData`

#### SuperOffice.CRM.Services.ContactAgent is Modified

* New items
  * Method `GetDomainDuplicates(String)`

#### SuperOffice.CRM.Services.EventData is Modified

* New items
  * Property `CgiContent`
  * Property `CgiVariables`

#### SuperOffice.CRM.Services.IAppointmentAgent is Modified

* New items
  * Method `GetNextAvailableTime(Int32[], DateTime, DateTime, Int32, Boolean)`

#### SuperOffice.CRM.Services.IContactAgent is Modified

* New items
  * Method `GetDomainDuplicates(String)`

#### SuperOffice.CRM.Services.IListAgent is Modified

* New items
  * Method `GlobalChangeTicketType(Int32, Int32)`

#### SuperOffice.CRM.Services.IPersonAgent is Modified

* New items
  * Method `SendEmailWithEventName(String, String, String, String, String, Int32[], String)`

#### SuperOffice.CRM.Services.ITicketAgent is Modified

* New items
  * Method `GetDefaultMessageContentFull(Int32, MessageActionType, Int32, Int32)`

#### SuperOffice.CRM.Services.IWorkflowAgent is Modified

* Deleted items
  * Method `CreateDefaultWorkflowStepOption()`
  * Method `DeleteWorkflowStepOption(Int32)`
  * Method `SaveWorkflowStepOption(WorkflowStepOption)`
* Modified items
  * Method `GetWorkflowStepOption(Int32)`
* New items
  * Method `CreateDefaultWorkflowStepOptionFromType(WorkflowSplitOptionType)`

#### SuperOffice.CRM.Services.ListAgent is Modified

* New items
  * Method `GlobalChangeTicketType(Int32, Int32)`

#### SuperOffice.CRM.Services.PersonAgent is Modified

* New items
  * Method `SendEmailWithEventName(String, String, String, String, String, Int32[], String)`

#### SuperOffice.CRM.Services.TicketAgent is Modified

* New items
  * Method `GetDefaultMessageContentFull(Int32, MessageActionType, Int32, Int32)`

#### SuperOffice.CRM.Services.WorkflowAgent is Modified

* Deleted items
  * Method `CreateDefaultWorkflowStepOption()`
  * Method `DeleteWorkflowStepOption(Int32)`
  * Method `SaveWorkflowStepOption(WorkflowStepOption)`
* Modified items
  * Method `GetWorkflowStepOption(Int32)`
* New items
  * Method `CreateDefaultWorkflowStepOptionFromType(WorkflowSplitOptionType)`

#### SuperOffice.CRM.Services.WorkflowStepCreateFollowUp is Modified

* Deleted items
  * Property `AssignTo`
  * Property `WorkflowActionTime`
  * Property `WorkflowActionTimeUnit`
  * Property `WorkflowActionType`
  * Property `WorkflowOwnerType`
* New items
  * Property `ActionTime`
  * Property `ActionTimeUnit`
  * Property `ActionType`
  * Property `Owner`
  * Property `OwnerType`

#### SuperOffice.CRM.Services.WorkflowStepCreateSale is Modified

* New items
  * Property `Amount`
  * Property `Currency`
  * Property `Date`
  * Property `Description`
  * Property `Owner`
  * Property `Project`
  * Property `SaleDateType`
  * Property `SaleType`
  * Property `Stage`
  * Property `Title`

#### SuperOffice.CRM.Services.WorkflowStepSplit is Modified

* Modified items
  * Property `Options`
* New items
  * Property `SplitOptionType`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### New Types

* `SuperOffice.Data.WorkflowSaleDateType`
* `SuperOffice.Data.WorkflowSplitOptionType`
* `SuperOffice.Security.Principal.ISoTimeZone`
* `SuperOffice.Security.Principal.SoTimeZone`

### Modified Types

#### SuperOffice.CRM.Services.ParticipantInfo is Modified

* New items
  * Property `Description`
  * Property `EmailAddress`
  * Method `ParticipantInfo(Int32, Int32, Int32, Int32, Boolean, InvitationStatus, String, String)`
  * Method `IsEmailParticipant()`

#### SuperOffice.Data.RecipientType is Modified

* New items
  * Field `Sms`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_ADMIN_TICKET_TICKETTYPES`
  * Field `SR_ADMIN_TICKETPRIORITY_CANT_DELETE_DEFAULT_PRIORITY_FOR_TICKET_TYPE_ERROR`
  * Field `SR_ADMIN_TICKETPRIORITY_DELETE_WARNING_REGARDING_TICKET_TYPES`
  * Field `SR_ADMIN_TICKETSTATUS_CANT_DELETE_DEFAULT_STATUS_FOR_TICKET_TYPE_ERROR`
  * Field `SR_ADMIN_TICKETSTATUS_DELETE_WARNING_REGARDING_TICKET_TYPES`
  * Field `SR_ADMIN_TICKETTYPE_AVAILABLE_PRIORITIES`
  * Field `SR_ADMIN_TICKETTYPE_AVAILABLE_STATUSES`
  * Field `SR_ADMIN_TICKETTYPE_CONFIRM_DELETE`
  * Field `SR_ADMIN_TICKETTYPE_DEFAULT_PRIORITY`
  * Field `SR_ADMIN_TICKETTYPE_DEFAULT_STATUS`
  * Field `SR_ADMIN_TICKETTYPE_DELETE`
  * Field `SR_ADMIN_TICKETTYPE_DESCRIPTION`
  * Field `SR_ADMIN_TICKETTYPE_EXTERNAL`
  * Field `SR_ADMIN_TICKETTYPE_HASMAILBOXES`
  * Field `SR_ADMIN_TICKETTYPE_HASMAILFILTERS`
  * Field `SR_ADMIN_TICKETTYPE_ICON`
  * Field `SR_ADMIN_TICKETTYPE_ISDEFAULT`
  * Field `SR_ADMIN_TICKETTYPE_PRIORITY_ERROR`
  * Field `SR_ADMIN_TICKETTYPE_PRIORITY_PLACEHOLDER`
  * Field `SR_ADMIN_TICKETTYPE_REPLY_TEMPLATE`
  * Field `SR_ADMIN_TICKETTYPE_STATUS_ERROR`
  * Field `SR_ADMIN_TICKETTYPE_STATUS_PLACEHOLDER`
  * Field `SR_ADMIN_TICKETTYPE_TRANSFERTO`
  * Field `SR_APPOINTMENT_EDIT_ATTENDEES`
  * Field `SR_APPOINTMENT_EDIT_RESOURCES`
  * Field `SR_APPOINTMENT_EMAIL_ATTENDEES_HEADER`
  * Field `SR_APPOINTMENT_EXTERNAL_ATTENDEES`
  * Field `SR_APPOINTMENT_FIRST_AVAILABLE`
  * Field `SR_APPOINTMENT_FIRST_AVAILABLE_TOOLTIP`
  * Field `SR_APPOINTMENT_INTERNAL_ATTENDEES`
  * Field `SR_APPOINTMENT_ONLY_WORKING_HOURS`
  * Field `SR_APPOINTMENT_PERSON_DLG_TEXT`
  * Field `SR_APPOINTMENT_PERSON_DLG_TITLE`
  * Field `SR_APPOINTMENT_SELECTED_DATE`
  * Field `SR_APPOINTMENT_SHOW_LESS`
  * Field `SR_APPOINTMENT_SHOW_MORE`
  * Field `SR_COMMON_ENTER_DOMAIN`
  * Field `SR_COMMON_TEXTAREA_PLACEHOLDER`
  * Field `SR_CONTACT_WITH_DOMAIN_ALREADY_EXISTS`
  * Field `SR_DOCUMENT_UNSAFE_TOOLTIP`
  * Field `SR_DUPLICATE_CONTACT_DOMAIN`
  * Field `SR_DUPLICATE_CONTACT_DOMAIN_TOOLTIP`
  * Field `SR_FLOW_SPLIT_FORMSUBMISSION`
  * Field `SR_FLOW_SPLIT_PERSONDATA`
  * Field `SR_FLOW_SPLIT_PROJECTMEMBER`
  * Field `SR_FLOW_SPLIT_SELECTIONMEMBER`
  * Field `SR_FORMSUBMISSIONARCHIVE_FORMID`
  * Field `SR_FORMSUBMISSIONARCHIVE_FORMID_TOOLTIP`
  * Field `SR_MENU_CONTACT_DOMAIN_MANAGE`
  * Field `SR_SELECTITEM_MORE_CHARACTERS`
  * Field `SR_SELECTITEM_NO_RESULTS`
  * Field `SR_SUMMARIZE`
  * Field `SR_WORKFLOW_CREATED_BY_FLOW`
  * Field `SR_WORKFLOW_ERROR_PROJECT_NOT_FOUND`
  * Field `SR_WORKFLOW_ERROR_SELECTION_NOT_FOUND`
  * Field `SR_WORKFLOW_ERROR_SELECTION_TYPE_ERROR`
  * Field `SR_WORKFLOW_ERROR_STEP_FAILED`
  * Field `SR_WORKFLOW_INVALID_SPLIT_NO_DEFAULT_BRANCH_STEPS`
  * Field `SR_WORKFLOW_INVALID_SPLIT_OPTION_TYPE`
  * Field `SR_WORKFLOW_NO_STEP_OPTIONS_DEFINED`
  * Field `SR_WORKFLOWS_ADDTOLIST_DESC`
  * Field `SR_WORKFLOWS_CREATEFOLLOWUP_DESC`
  * Field `SR_WORKFLOWS_CREATEREQUEST_DESC`
  * Field `SR_WORKFLOWS_CREATESALE_DESC`
  * Field `SR_WORKFLOWS_ESTIMATED_BY_SALE_TYPE`
  * Field `SR_WORKFLOWS_FINISH_DESC`
  * Field `SR_WORKFLOWS_LINKCLICKED_EMAIL`
  * Field `SR_WORKFLOWS_LINKCLICKED_LINK`
  * Field `SR_WORKFLOWS_NOTIFYBYEMAIL_DESC`
  * Field `SR_WORKFLOWS_NOTIFYBYSMS_DESC`
  * Field `SR_WORKFLOWS_REMOVE_SPLIT`
  * Field `SR_WORKFLOWS_REMOVE_TRIGGER`
  * Field `SR_WORKFLOWS_REMOVEFROMLIST_DESC`
  * Field `SR_WORKFLOWS_RUNSCRIPT_DESC`
  * Field `SR_WORKFLOWS_SENDSMS_DESC`
  * Field `SR_WORKFLOWS_SPLIT_BASEDON`
  * Field `SR_WORKFLOWS_SPLIT_DESC`
  * Field `SR_WORKFLOWS_SPLIT_NAME`
  * Field `SR_WORKFLOWS_SPLIT_PATH`
  * Field `SR_WORKFLOWS_SPLITNAME_CAPTION`
  * Field `SR_WORKFLOWS_UPDATECONTACT_DESC`
  * Field `SR_WORKFLOWS_WAITFORACTION_DESC`
  * Field `SR_WORKFLOWS_WAITTIME_DESC`

#### SuperOffice.Threading.ThreadManager is Modified

* Modified items
  * Method `BeginIgnoreRowSentry()`
  * Method `BeginIgnoreSentry()`
  * Method `BeginPreventParallelism()`
  * Method `IgnoreRowSentry()`
  * Method `IgnoreSentry()`

##### SuperOffice.Threading.ThreadManager.ForceSingleThreadHelper is Modified




### Assembly: SoDatabase

### New Types

* `SuperOffice.CRM.ArchiveLists.Archive___Participants.BookingParticipantsEmailOnlyProvider`
* `SuperOffice.CRM.ArchiveLists.Archive___Participants.ParticipantsEmailOnlyProvider`
* `SuperOffice.CRM.ArchiveLists.HtmlTextExtenderBase`
* `SuperOffice.CRM.ArchiveLists.Joiners.AppointmentAgendaTextExtender`
* `SuperOffice.CRM.ArchiveLists.Joiners.AppointmentEmailExtender`
* `SuperOffice.CRM.ArchiveLists.Joiners.AppointmentInternalNotesTextExtender`
* `SuperOffice.CRM.ArchiveLists.Joiners.AppointmentTitleTextExtender`
* `SuperOffice.CRM.ArchiveLists.PersonFormSubmissionExtender`
* `SuperOffice.CRM.Data.Util.Duplicates.ContactDomainDuplicateRule`
* `SuperOffice.CRM.Data.Util.NextAvailableTimeHelper`
* `SuperOffice.CRM.Data.Util.NextAvailableTimeInfo`
* `SuperOffice.CRM.Lists.EmailPhoneProvider`
* `SuperOffice.CRM.Lists.WorkflowSplitOptionTypeProvider`
* `SuperOffice.CRM.TicketMessage.AttachmentEntity`
* `SuperOffice.CRM.TicketMessage.TicketMessageContent`
* `SuperOffice.CRM.Tooltips.TicketTypeTooltipPlugin`
* `SuperOffice.CRM.Workflow.CreateSaleSettings`
* `SuperOffice.CRM.Workflow.WorkflowStepCreateSale`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.EmailExtenderBase is Modified

* New items
  * Field `EmailAddressColumnName`
  * Field `EmailDescriptionColumnName`

#### SuperOffice.CRM.ArchiveLists.FormSubmissionExtenderBase is Modified

* New items
  * Field `ColumnFormSubmissionFormId`

#### SuperOffice.CRM.ArchiveLists.ParticipantsProvider is Modified

* New items
  * Field `EmailParticipantEntity`

#### SuperOffice.CRM.ArchiveLists.PersonExtenderBase is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.PersonExtenderBase.Features is Modified

* Deleted items
  * Field `.FeaturesShipmentLinkClickedInfo`
* New items
  * Field `.FeaturesWorkflowConnectedInfo`

* New items
  * Field `ColFullName`

#### SuperOffice.CRM.ArchiveLists.TimeZonesProvider is Modified

* New items
  * Method `ProcessOrderBy()`

#### SuperOffice.CRM.Data.AppointmentTableInfo is Modified

* New items
  * Property `SendEmail`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.AppointmentFields is Modified

* New items
  * Field `.AppointmentFieldsSendEmail`


##### SuperOffice.CRM.Data.DBC.MailInFilterFields is Modified

* New items
  * Field `.MailInFilterFieldsTicketType`


##### SuperOffice.CRM.Data.DBC.MsFilterFields is Modified

* New items
  * Field `.MsFilterFieldsNewTicketType`


##### SuperOffice.CRM.Data.DBC.WorkflowStepOptionFields is Modified

* Deleted items
  * Field `.WorkflowStepOptionFieldsKey`
* New items
  * Field `.WorkflowStepOptionFieldsKeyId`


#### SuperOffice.CRM.Data.MailInFilterTableInfo is Modified

* New items
  * Property `TicketType`
  * Property `TicketType_InnerJoin_TicketType`

#### SuperOffice.CRM.Data.MsFilterTableInfo is Modified

* New items
  * Property `NewTicketType`
  * Property `NewTicketType_InnerJoin_TicketType`

#### SuperOffice.CRM.Data.TicketTypeTableInfo is Modified

* New items
  * Property `LeftOuterJoin_MailInFilter_TicketType`
  * Property `LeftOuterJoin_MsFilter_NewTicketType`

#### SuperOffice.CRM.Data.WorkflowStepOptionTableInfo is Modified

* Deleted items
  * Property `Key`
* New items
  * Property `KeyId`

#### SuperOffice.CRM.Entities.AppointmentMatrix is Modified

* Deleted items
  * Method `GetParticipant(Int32, Int32, Int32, Int32, AppointmentStatus)`
* New items
  * Method `GetParticipant(Int32, Int32, Int32, Int32, AppointmentStatus, Boolean)`

#### SuperOffice.CRM.Entities.BookingManager is Modified

* New items
  * Method `IsEmailParticipant(AppointmentRow)`

#### SuperOffice.CRM.Globalization.PhoneFormatter is Modified

* New items
  * Field `PhoneNumberMatcher`

#### SuperOffice.CRM.Import.UdefImportHelper is Modified

* New items
  * Method `ConvertStringToDbTypeDate(UDefFieldRow, Object)`
  * Method `ConvertStringToDbTypeUnlimitedDate(UDefFieldRow, Object)`

#### SuperOffice.CRM.Lists.AppointmentResource is Modified

* New items
  * Field `ConflictIsUtc`

#### SuperOffice.CRM.Lists.ShipmentLinksListProvider is Modified


#### SuperOffice.CRM.Lists.TicketTicketStatusProvider is Modified

* New items
  * Field `InfoKey_OnlyNormal`
  * Field `InfoKey_OnlyNormalWithPostponed`

#### SuperOffice.CRM.Rows.AppointmentRecordData is Modified

* New items
  * Field `SendEmail`

#### SuperOffice.CRM.Rows.AppointmentRow is Modified

* New items
  * Property `SendEmail`
  * Event `OnSendEmailChange`

#### SuperOffice.CRM.Rows.Implementation.TicketRowImplementation is Modified

* New items
  * Method `HandlePostponedStatuses(TicketBaseStatus)`

#### SuperOffice.CRM.Rows.MailInFilterRecordData is Modified

* New items
  * Field `TicketType`

#### SuperOffice.CRM.Rows.MailInFilterRow is Modified

* New items
  * Property `TicketType`

#### SuperOffice.CRM.Rows.MsFilterRecordData is Modified

* New items
  * Field `NewTicketType`

#### SuperOffice.CRM.Rows.MsFilterRow is Modified

* New items
  * Property `NewTicketType`

#### SuperOffice.CRM.Rows.RowDefaulter is Modified

* New items
  * Method `SetDefaults(TicketTypeRow)`
  * Method `SetDefaults(TicketTypeRow, DefaulterStrategy)`

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(WorkflowSaleDateType&, FieldInfo)`
  * Method `ValidateField(WorkflowSplitOptionType&, FieldInfo)`

#### SuperOffice.CRM.Rows.WorkflowStepOptionRecordData is Modified

* Deleted items
  * Field `Key`
* New items
  * Field `KeyId`

#### SuperOffice.CRM.Rows.WorkflowStepOptionRow is Modified

* Deleted items
  * Property `Key`
* New items
  * Property `KeyId`

#### SuperOffice.CRM.Rows.WorkflowStepOptionRows is Modified

* New items
  * Method `GetFromIdxKeyId(Int32)`

##### SuperOffice.CRM.Rows.WorkflowStepOptionRows.IdxKeyId is New

#### SuperOffice.CRM.Security.Sentry is Modified

* New items
  * Method `BeginIgnoreRowSentry()`
  * Method `BeginIgnoreSentry()`
  * Method `IgnoreRowSentry()`

#### SuperOffice.CRM.Security.SentryPreferenceCache is Modified

* New items
  * Method `IsCacheInvalidated(String, Int32, PrivateSave)`

#### SuperOffice.CRM.Ticket.TicketData is Modified

* New items
  * Property `TicketTypeId`

#### SuperOffice.CRM.Ticket.TicketHelper is Modified

* Deleted items
  * Method `GetIconHint(TicketBaseStatus, DateTime)`
* New items
  * Method `GetIconHint(String, TicketBaseStatus, DateTime)`
  * Method `GetTicketChangeData(Int32)`

#### SuperOffice.CRM.TicketMessage.TicketMessageHelper is Modified

* Deleted items
  * Method `GetDefaultMessageContent(Int32, MessageActionType, Int32, Boolean)`
* New items
  * Method `GetDefaultMessageContent(Int32, MessageActionType, Int32, Int32, Boolean)`

#### SuperOffice.CRM.Workflow.CreateFollowUpSettings is Modified

* Deleted items
  * Property `AssignTo`
  * Property `WorkflowActionTime`
  * Property `WorkflowActionTimeUnit`
  * Property `WorkflowActionType`
  * Property `WorkflowOwnerType`
* New items
  * Property `ActionTime`
  * Property `ActionTimeUnit`
  * Property `ActionType`
  * Property `Owner`
  * Property `OwnerType`

#### SuperOffice.CRM.Workflow.CreateRequestSettings is Modified

* Modified items
  * Property `Status`
* New items
  * Property `TicketStatus`

#### SuperOffice.CRM.Workflow.SplitSettings is Modified

* New items
  * Property `SplitOptionType`

#### SuperOffice.CRM.WorkFlow.WorkflowEngine is Modified

* New items
  * Method `DoAddToProjectEvent(WorkflowEvent)`
  * Method `DoFormSubmissionEvent(WorkflowEvent)`

#### SuperOffice.CRM.Workflow.WorkflowStepSplit is Modified

* New items
  * Method `GetSettings(String)`

#### SuperOffice.CRM.Workflow.WorkflowUtil is Modified

* New items
  * Method `GetCreatedByWorkflowName(Int32)`

#### SuperOffice.Data.Cache.CacheBaseV2 is Modified

* Deleted items
  * Method `IsCacheInvalidated(String, Int32)`
* New items
  * Method `IsCacheInvalidated(String, Int32, PrivateSave)`


## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.Database.WorkflowSaleDateType`
* `SuperOffice.CD.Database.WorkflowSplitOptionType`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_47_TicketType_MailboxAndFilter`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_48_TicketTypeIcon`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_49_TicketTypeIcon`
* `SuperOffice.CD.DSL.Database.Steps_FollowUpDialog.FollowUpDialog_02_AppointmentTable_SendEmail_Field`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep14_WorkflowStepOptionKeyToInt`

### Modified Types

#### SuperOffice.CD.Database.RecipientType is Modified

* New items
  * Field `Sms`

#### SuperOffice.CD.DSL.Database.T_Appointment is Modified

* New items
  * Field `SendEmail`

#### SuperOffice.CD.DSL.Database.T_MailInFilter is Modified

* New items
  * Field `TicketType`

#### SuperOffice.CD.DSL.Database.T_MsFilter is Modified

* New items
  * Field `NewTicketType`

#### SuperOffice.CD.DSL.Database.T_WorkflowStepOption is Modified

* Deleted items
  * Field `Key`
* New items
  * Field `KeyId`
