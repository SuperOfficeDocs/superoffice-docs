---
uid: version_10.2.5.1175_changes
date: 5/26/2023
---

# Changes from v10.2.4.796 and v10.2.5.1175

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.EntityCounts`
* `SuperOffice.CRM.Services.TicketFormSubmission`

### Modified Types

#### SuperOffice.CRM.Services.AppointmentAgent is Modified

* Modified items
  * Method `CleanUpBookingDeletedWithUpdateMode(Int32[], RecurrenceUpdateMode)`
    * Changed response type to No Content.

#### SuperOffice.CRM.Services.IAppointmentAgent is Modified

* Modified items
  * Method `CleanUpBookingDeletedWithUpdateMode(Int32[], RecurrenceUpdateMode)`

#### SuperOffice.CRM.Services.Ticket is Modified

* New items
  * Property `FormSubmissionId`

#### SuperOffice.CRM.Services.TicketEntity is Modified

* New items
  * Property `FormSubmission`

#### SuperOffice.CRM.Services.TicketMessage is Modified

* New items
  * Property `Badge`

#### SuperOffice.CRM.Services.TicketMessageEntity is Modified

* New items
  * Property `Badge`

#### SuperOffice.CRM.Services.WorkflowGoal is Modified

* New items
  * Property `WorkflowId`

#### SuperOffice.CRM.Services.WorkflowTrigger is Modified

* New items
  * Property `WorkflowId`

## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Deleted Types

* `SuperOffice.Factory.SessionInstanceContainer`

### New Types

* `SuperOffice.Data.BadgeType`

### Modified Types

#### SuperOffice.Configuration.ConfigFile is Modified

* Deleted items
  * Method `GetEffectiveConfig()`
  * Method `SaveEffectiveConfig(String)`
* Modified items

##### SuperOffice.Configuration.ConfigFile.Downloads is Modified

* Deleted items
  * Property `.DownloadsDownloadFolder`
  * Property `.DownloadsDownloadFolderImpersonate`
  * Property `.DownloadsNewTrayAppUrl`
  * Property `.DownloadsWebSiteEndPoint`

##### SuperOffice.Configuration.ConfigFile.DownloadsSection is Modified

* Deleted items
  * Property `.DownloadsSectionDownloadFolder`
  * Property `.DownloadsSectionDownloadFolderImpersonate`
  * Property `.DownloadsSectionNewTrayAppUrl`
  * Property `.DownloadsSectionWebSiteEndPoint`

#### SuperOffice.Configuration.File.ConfigFileFacade is Modified

* Deleted items
  * Method `GetEffectiveConfig()`

#### SuperOffice.CRM.ArchiveLists.Constants is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.Constants.IconHints is Modified

* New items
  * Field `.IconHintsFolder_Grey`
  * Field `.IconHintsPreferenceInapp`

#### SuperOffice.Exceptions.SoConsentException is Modified

* Deleted items
  * Method `SoConsentException(String)`
* New items
  * Method `SoConsentException(String, Boolean)`

#### SuperOffice.Exceptions.SoIllegalOperationException is Modified

* Deleted items
  * Method `SoIllegalOperationException(String)`
* New items
  * Method `SoIllegalOperationException(String, Boolean)`

#### SuperOffice.Exceptions.SoInvalidArgumentException is Modified

* Deleted items
  * Method `SoInvalidArgumentException(String, Type, Object)`
* New items
  * Method `SoInvalidArgumentException(String, Type, Object, Boolean)`

#### SuperOffice.Factory.InstanceContainers is Modified

* Deleted items
  * Field `Session`

#### SuperOffice.Globalization.RC is Modified

* Deleted items
  * Field `SR_PD_salesnotification_DESC`
  * Field `SR_PD_salesnotification_NAME`
  * Field `SR_PD_salesnotification_notifyAppointmentCancel_DESC`
  * Field `SR_PD_salesnotification_notifyAppointmentCancel_NAME`
  * Field `SR_PD_salesnotification_notifyAppointmentChange_DESC`
  * Field `SR_PD_salesnotification_notifyAppointmentChange_NAME`
  * Field `SR_PD_salesnotification_notifyAppointmentDecline_DESC`
  * Field `SR_PD_salesnotification_notifyAppointmentDecline_NAME`
  * Field `SR_PD_salesnotification_notifyAppointmentInvitation_DESC`
  * Field `SR_PD_salesnotification_notifyAppointmentInvitation_NAME`
* New items
  * Field `SR_ARCHIVE_EXTDOC_DESCRIPTION`
  * Field `SR_ARCHIVE_EXTDOC_DESCRIPTION_TOOLTIP`
  * Field `SR_ARCHIVE_EXTDOC_FOLDERS`
  * Field `SR_ARCHIVE_EXTDOC_ITEMS`
  * Field `SR_ARCHIVE_EXTDOC_TITLE`
  * Field `SR_ARCHIVE_EXTDOC_TITLE_TOOLTIP`
  * Field `SR_COMMON_MUST_BE_CHECKED`
  * Field `SR_FAQ_PREVIEW`
  * Field `SR_FAVOURITE_TICKETS_ONLY`
  * Field `SR_FLOW_FLOWSETTINGS_CAPTION`
  * Field `SR_FLOW_FLOWSETTINGS_DESCRIPTION`
  * Field `SR_FLOW_FLOWSETTINGS_FOLDER`
  * Field `SR_FLOW_FLOWSETTINGS_OWNER`
  * Field `SR_FLOW_FLOWSETTINGS_REMOVE_ENROLLED`
  * Field `SR_FLOW_FLOWSETTINGS_STARTSPECIFIC`
  * Field `SR_FLOW_FLOWSETTINGS_STOPSPECIFIC`
  * Field `SR_FLOW_FLOWSETTINGS_TIMEZONE_SETTINGS`
  * Field `SR_FLOW_FLOWSETTINGS_VISIBLEFOR`
  * Field `SR_FROALA_EXIT_CODE_VIEW`
  * Field `SR_NOTIFY_TICKET_NEW_MESSAGE_NO_SENDER`
  * Field `SR_PD_DataCollection_InAppUserflow_DESC`
  * Field `SR_PD_DataCollection_InAppUserflow_NAME`
  * Field `SR_PD_salesNotification_DESC`
  * Field `SR_PD_salesNotification_NAME`
  * Field `SR_PD_salesNotification_notifyAppointmentCancel_DESC`
  * Field `SR_PD_salesNotification_notifyAppointmentCancel_NAME`
  * Field `SR_PD_salesNotification_notifyAppointmentChange_DESC`
  * Field `SR_PD_salesNotification_notifyAppointmentChange_NAME`
  * Field `SR_PD_salesNotification_notifyAppointmentDecline_DESC`
  * Field `SR_PD_salesNotification_notifyAppointmentDecline_NAME`
  * Field `SR_PD_salesNotification_notifyAppointmentInvitation_DESC`
  * Field `SR_PD_salesNotification_notifyAppointmentInvitation_NAME`
  * Field `SR_REPLYTEMPLATE_PREVIEW`
  * Field `SR_TICKET_CONDITION_AT_LEAST_ONE`
  * Field `SR_TICKET_CONNECTED_TO_FORM_SUBMISSION_NO_EMAIL`
  * Field `SR_TICKET_CONNECTED_TO_FORM_SUBMISSION_WITH_EMAIL`
  * Field `SR_TICKET_FINDREQUEST_PLACEHOLDER`
  * Field `SR_TICKET_MESSAGE_OUTGOING`
  * Field `SR_WORKFLOWS_ADDFOLDER`
  * Field `SR_WORKFLOWS_AND`
  * Field `SR_WORKFLOWS_BETWEEN`
  * Field `SR_WORKFLOWS_EMAIL_NOTCOMPLETE`
  * Field `SR_WORKFLOWS_EMAILNOTVALID`
  * Field `SR_WORKFLOWS_EMAILSETTINGS`
  * Field `SR_WORKFLOWS_MISSINGSPF`
  * Field `SR_WORKFLOWS_NEEDEMAIL`
  * Field `SR_WORKFLOWS_NEWFLOW`
  * Field `SR_WORKFLOWS_NOSHIPMENTTYPE`
  * Field `SR_WORKFLOWS_RUNFLOW`
  * Field `SR_WORKFLOWS_SPFINFO`
  * Field `SR_WORKFLOWS_SPFINFOLABEL`
  * Field `SR_WORKFLOWS_WEEKDAYS`
  * Field `SR_WORKFLOWS_WITHOUTDOMAIN`
  * Field `SR_WORKFLOWS_WORKDAYS`

#### SuperOffice.Util.DateUtility is Modified

* New items
  * Method `ToMinutes(Double)`
  * Method `ToMinutes(TimeSpan)`

### Assembly: SoDatabase

### New types

* `SuperOffice.CallHome.EntityCountsImport`
* `SuperOffice.CRM.ArchiveLists.AppointmentNotificationAggregatorExtender`
* `SuperOffice.CRM.ArchiveLists.AppointmentNotificationSubAggregatorProvider`
* `SuperOffice.CRM.ArchiveLists.AppointmentNotificationSubExtenderBase`
* `SuperOffice.CRM.ArchiveLists.AttachmentExtenderBase`
* `SuperOffice.CRM.ArchiveLists.EmailFlowFolderEmailFlowFolderExtender`
* `SuperOffice.CRM.ArchiveLists.EmailFlowFolderProvider`
* `SuperOffice.CRM.ArchiveLists.EmailFlowsAndFoldersProvider`
* `SuperOffice.CRM.ArchiveLists.ExternalDocumentAttachmentExtender`
* `SuperOffice.CRM.ArchiveLists.ExternalDocumentExtender`
* `SuperOffice.CRM.ArchiveLists.ExternalDocumentExtenderBase`
* `SuperOffice.CRM.ArchiveLists.ExternalDocumentFolderProvider`
* `SuperOffice.CRM.ArchiveLists.ExternalDocumentHierarchyExtender`
* `SuperOffice.CRM.ArchiveLists.ExternalDocumentHierarchyRootExtender`
* `SuperOffice.CRM.ArchiveLists.ExternalDocumentItemsProvider`
* `SuperOffice.CRM.ArchiveLists.ExternalDocumentsProvider`
* `SuperOffice.CRM.Cache.TicketStatusCache`
* `SuperOffice.CRM.Ticket.LiveUiStatisticsHelper`
* `SuperOffice.Data.SQL.BadgeTypeFieldInfo`

### Modified types

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationAggregatorProvider is Modified

* Deleted items
  * Method `InnerPopulateRow(ArchiveRow)`
* New items
  * Method `PostProcessRow(SoDataReader, ArchiveRow)`

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationExtenderBase is Modified

* Deleted items
  * Property `IsBookingOwner`
  * Property `MappedAssociateField`
  * Property `MotherAppointmentTable`
  * Method `AddOriginatorFullName(SoDataReader, ArchiveRow)`
  * Method `InnerModifyQuery()`
  * Method `InnerPopulateRowFromReader(SoDataReader, ArchiveRow)`
  * Method `SetJoin()`
* Modified items
  * Method `AppointmentNotificationExtenderBase()`
* New items
  * Field `RecurrencePatternColumnName`

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationProvider is Modified

* New items
  * Field `C_APPOINTMENT_ACCEPTED_ENTITY_NAME`
  * Field `C_APPOINTMENT_CANCELLED_ENTITY_NAME`
  * Field `C_APPOINTMENT_NEW_ENTITY_NAME`
  * Field `C_APPOINTMENT_REJECTED_ENTITY_NAME`
  * Field `C_APPOINTMENT_UPDATED_ENTITY_NAME`
  * Method `CreateRowHistory(ArchiveRow)`

##### SuperOffice.CRM.ArchiveLists.AppointmentNotificationProvider.RowHistory is New

#### SuperOffice.CRM.ArchiveLists.EmailFlowExtenderBase is Modified

* New items
  * Field `ColumnEmailFlowHierarchyId`
  * Method `InnerPopulateRowFromReader(SoDataReader, ArchiveRow)`

#### SuperOffice.CRM.ArchiveLists.ExtensibleColumnsBase is Modified

* Modified items
  * Method `AddColumnNameOverride(String, String)`
* New items
  * Method `GetNameOrOverrideName(String)`

#### SuperOffice.CRM.ArchiveLists.HierarchyExtenderBase is Modified

* New items
  * Field `ColumnHierarchyName`
  * Field `ColumnHierarchyParentId`

#### SuperOffice.CRM.ArchiveLists.NotificationNotificationExtender<Info> is Modified

* New items
  * Field `UpdateTypeColumnName`
  * Method `HasAssociateRestriction(ArchiveRestrictionInfo[])`

#### SuperOffice.CRM.ArchiveLists.TicketNewMessageNotificationExtender is Modified

* Deleted items
  * Property `MappedOriginatorField`
  * Method `AddOriginatorFullName(SoDataReader, ArchiveRow)`
  * Method `SetJoin()`

#### SuperOffice.CRM.ArchiveLists.TicketTicketExtender is Modified

* New items
  * Method `InnerModifyQuery()`

#### SuperOffice.CRM.ArchiveLists.TicketTransferredNotificationExtender is Modified

* New items
  * Method `AddOriginatorFullName(SoDataReader, ArchiveRow)`

#### SuperOffice.CRM.ArchiveLists.WorkflowExtenderBase is Modified

* New items
  * Field `ColWorkflowName`

#### SuperOffice.CRM.Data.AppointmentTableInfo is Modified

* New items
  * Method `IdxAssociateIdStatus(Int32, AppointmentStatus)`
  * Method `IdxAssociateIdStatusDoBy(Int32, AppointmentStatus, DateTime)`

#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* New items
  * Property `LeftOuterJoin_Notify_RegisteredAssociateId`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.EjMessageFields is Modified

* New items
  * Field `.EjMessageFieldsBadge`

##### SuperOffice.CRM.Data.DBC.NotifyFields is Modified

* New items
  * Field `.NotifyFieldsRegistered`
  * Field `.NotifyFieldsRegisteredAssociateId`

#### SuperOffice.CRM.Data.EjMessageTableInfo is Modified

* New items
  * Property `Badge`

#### SuperOffice.CRM.Data.NotifyTableInfo is Modified

* New items
  * Property `Registered`
  * Property `RegisteredAssociateId`
  * Property `RegisteredAssociateId_InnerJoin_Associate`

#### SuperOffice.CRM.Entities.AppointmentMatrix is Modified

* New items
  * Method `DeleteCancelled(Int32, RecurrenceUpdateMode)`

#### SuperOffice.CRM.Lists.EmailAddressProvider is Modified

#### SuperOffice.CRM.Lists.ServiceAssociateMDOProvider is Modified

* Deleted items
  * Field `ShouldIncludeDefaultItems`
* New items
  * Field `AddNotPresentStatus`
  * Field `IncludeDefaultItems`
  * Method `GenerateCommonQuery(CustomSearch, ListInfo)`
  * Method `GetHistoryCollection()`
  * Method `GetItemName(ListTableRow)`

#### SuperOffice.CRM.Rows.AppointmentRows is Modified

* New items
  * Method `GetFromIdxAssociateIdStatus(Int32, AppointmentStatus)`
  * Method `GetFromIdxAssociateIdStatusDoBy(Int32, AppointmentStatus, DateTime)`
  * Method `GetFromIdxAssociateIdStatusDoByEndDate(Int32, AppointmentStatus, DateTime, DateTime)`

##### SuperOffice.CRM.Rows.AppointmentRows.IdxAssociateIdStatus is New

##### SuperOffice.CRM.Rows.AppointmentRows.IdxAssociateIdStatusDoBy is New

##### SuperOffice.CRM.Rows.AppointmentRows.IdxAssociateIdStatusDoByEndDate is New

#### SuperOffice.CRM.Rows.EjMessageRecordData is Modified

* New items
  * Field `Badge`

#### SuperOffice.CRM.Rows.EjMessageRow is Modified

* New items
  * Property `Badge`

#### SuperOffice.CRM.Rows.Implementation.TicketRowImplementation is Modified

* New items
  * Method `CalculateReadStatus(Boolean, Boolean)`
  * Method `OnSaved(Boolean)`
  * Method `SetReadByOwner(TicketReadStatus)`

#### SuperOffice.CRM.Rows.NotifyRecordData is Modified

* New items
  * Field `Registered`
  * Field `RegisteredAssociateId`

#### SuperOffice.CRM.Rows.NotifyRow is Modified

* New items
  * Property `Registered`
  * Property `RegisteredAssociateId`

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(BadgeType&, FieldInfo)`

#### SuperOffice.CRM.Ticket.TicketAlertHelper is Modified

* Deleted items
  * Method `StopEscalation(TicketRow, TicketPriorityRecordData)`
* New items
  * Method `StopEscalation(TicketRow)`

#### SuperOffice.CRM.Ticket.TicketHelper is Modified

* New items
  * Method `DemandAdminPermissions()`
  * Method `GetTicketCustomers(Int32, Int32)`
  * Method `GetTicketStatusRecordData(Int16)`

#### SuperOffice.CRM.Ticket.TicketPriorityResolver is Modified

* New items
  * Method `GetPriority(Int32)`

#### SuperOffice.License.LicenseManager is Modified

* Deleted items
  * Method `GetLicenseFromLicenseServerWithAssignments(String, Boolean)`
  * Method `IsOnlineConfig()`
* New items
  * Method `GetLicenseFromLicenseServerWithAssignments(String, Boolean, String)`

### Assembly: SoLicense

### Modified Types

#### SuperOffice.License.LicenseService is Modified

* Modified items
  * Method `GetLicenseUrl(String)`
* New items
  * Method `SetLicenseUrlOverride(String)`
  * Method `SetTimeout(Int32)`

## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.DSL.Database.BadgeType`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_35_EjMessageBadge`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_36_NotifyRegistered`
* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_101_Conflict_detector_appointment_index`
* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_99_PersonAssocId`
* `SuperOffice.CD.DSL.Database.SuperOffice_100_SOCompany`

### Modified Types

#### SuperOffice.CD.DSL.Database.T_EjMessage is Modified

* New items
  * Field `Badge`

#### SuperOffice.CD.DSL.Database.T_Notify is Modified

* New items
  * Field `Registered`
  * Field `RegisteredAssociateId`
