---
uid: version_10.2.6.1248_changes
date: 6/16/2023
---

# Changes from v10.2.5.1175 and v10.2.6.1248

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.MetricPair`

### Modified Types

#### SuperOffice.CRM.Services.Appointment is Modified

* New items
  * Property `Agenda`
  * Property `InternalNotes`
  * Property `Title`

#### SuperOffice.CRM.Services.AppointmentEntity is Modified

* New items
  * Property `Agenda`
  * Property `InternalNotes`
  * Property `Title`

#### SuperOffice.CRM.Services.AssociateAgent is Modified

* New items
  * Method `GetEncryptionKey()`

#### SuperOffice.CRM.Services.EmailFlow is Modified

* Deleted items
  * Property `VisibleForAll`
  * Property `VisibleForAssociates`
  * Property `VisibleForGroups`
* New items
  * Property `VisibleFor`

#### SuperOffice.CRM.Services.IAssociateAgent is Modified

* New items
  * Method `GetEncryptionKey()`

#### SuperOffice.CRM.Services.ITicketAgent is Modified

* New items
  * Method `CopyToTempFile(String, Int32)`

#### SuperOffice.CRM.Services.IViewStateAgent is Modified

* Deleted items
  * Method `PublishAndRetrieveUiEvents(Int32, UiEvent[])`
* New items
  * Method `PublishAndRetrieveUiEvents(Int32, UiEvent[], MetricPair[])`

#### SuperOffice.CRM.Services.IWorkflowAgent is Modified

* New items
  * Method `ConnectEmailFlowContent(Int32, Int32)`
  * Method `CreateEmailFlowContent(String)`

#### SuperOffice.CRM.Services.TicketAgent is Modified

* New items
  * Method `CopyToTempFile(String, Int32)`

#### SuperOffice.CRM.Services.ViewStateAgent is Modified

* Deleted items
  * Method `PublishAndRetrieveUiEvents(Int32, UiEvent[])`
* New items
  * Method `PublishAndRetrieveUiEvents(Int32, UiEvent[], MetricPair[])`

#### SuperOffice.CRM.Services.WorkflowAgent is Modified

* New items
  * Method `ConnectEmailFlowContent(Int32, Int32)`
  * Method `CreateEmailFlowContent(String)`

#### SuperOffice.CRM.Services.WorkflowStepSendEmail is Modified

* New items
  * Property `ShipmentId`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Deleted Types

* `SuperOffice.IO.FileSystem`
* `SuperOffice.IO.IFileSystem`
* `SuperOffice.UI.ComboBox`
* `SuperOffice.UI.TextBox`
* `SuperOffice.UI.UserInterfaceElement`
* `SuperOffice.UI.UserInterfaceElementResult`
* `SuperOffice.UI.UserInterfaceUnits`

### New Types

* `SuperOffice.Globalization.IResourceManager`
* `SuperOffice.IO.ITempFileProvider`

### Modified Types

#### SuperOffice.Configuration.ConfigFile is Modified

* Modified items

##### SuperOffice.Configuration.ConfigFile.CustomerService is Modified

* New items
  * Property `.CustomerServiceMailDomain`


##### SuperOffice.Configuration.ConfigFile.CustomerServiceSection is Modified

* New items
  * Property `.CustomerServiceSectionMailDomain`


#### SuperOffice.CRM.ArchiveLists.Constants is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.Constants.IconHints is Modified

* New items
  * Field `.IconHintsPreferenceSalesNotification`


##### SuperOffice.CRM.ArchiveLists.Constants.Options is Modified

* New items
  * Field `.OptionsExistenceCheck`


#### SuperOffice.CRM.FunctionRightStrings is Modified

* New items
  * Field `AdminEmailFlow`
  * Field `AdminEmailFlowAssets`

#### SuperOffice.CRM.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.CRM.UserPreferenceStrings.DiaryView is Modified

* New items
  * Field `.DiaryViewAlarmOnFollowUp`


#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_ADMIN_MENU_CHANGE_SERVICE_STATUS`
  * Field `SR_APPOINTMENT_ADD_RESOURCE`
  * Field `SR_APPOINTMENT_AGENDA`
  * Field `SR_APPOINTMENT_ATTENDEE_STATISTICS`
  * Field `SR_APPOINTMENT_ATTENDEES`
  * Field `SR_APPOINTMENT_EMAIL_INTERNALS`
  * Field `SR_APPOINTMENT_INTERNAL_NOTES`
  * Field `SR_APPOINTMENT_INTERNAL_NOTES_DESC`
  * Field `SR_APPOINTMENT_INVITE`
  * Field `SR_APPOINTMENT_NO_ALARM`
  * Field `SR_ARCHIVE_ATTACHMENT_CONTENTTYPE`
  * Field `SR_ARCHIVE_ATTACHMENT_NAME`
  * Field `SR_ARCHIVE_ATTACHMENT_SIZE`
  * Field `SR_ARCHIVE_EXTDOC_NODETYPE`
  * Field `SR_ARCHIVE_HIERARCHY_FULLPATHIDS`
  * Field `SR_ARCHIVE_HIERARCHY_FULLPATHIDS_TOOLTIP`
  * Field `SR_COMMON_FOLLOWUPTYPE`
  * Field `SR_DURATION_HOUR_LONG_POSTFIX`
  * Field `SR_FLOW_FLOWSETTINGSDIALOG_CAPTION`
  * Field `SR_MARKETING_LISTIMAGES_ALL`
  * Field `SR_MARKETING_LISTIMAGES_MYIMAGES`
  * Field `SR_MARKETING_LISTIMAGES_RECENTIMAGES`
  * Field `SR_MARKETING_LISTMAILINGS_ALL`
  * Field `SR_MARKETING_LISTMAILINGS_RECENT`
  * Field `SR_MENU_FILE_NEW_MEETING`
  * Field `SR_MENU_FILE_NEW_TODO_NEW`
  * Field `SR_MENU_YOUR_SERVICE_STATUS`
  * Field `SR_PD_DiaryView_AlarmOnFollowUp_DESC`
  * Field `SR_PD_DiaryView_AlarmOnFollowUp_NAME`
  * Field `SR_PD_request_closeTabOnRequestStatusClosed_DESC`
  * Field `SR_PD_request_closeTabOnRequestStatusClosed_NAME`
  * Field `SR_REPLYTEMPLATE_CHATLOG`
  * Field `SR_REPLYTEMPLATE_CHATLOG_DESCRIPTION`
  * Field `SR_REPLYTEMPLATE_CHATLOG_NAME`
  * Field `SR_REPLYTEMPLATE_CHATLOG_SUBJECT`
  * Field `SR_REPLYTEMPLATE_NEWLINK`
  * Field `SR_REPLYTEMPLATE_NEWLINK_DESCRIPTION`
  * Field `SR_REPLYTEMPLATE_NEWLINK_NAME`
  * Field `SR_REPLYTEMPLATE_NEWLINK_SUBJECT`
  * Field `SR_SAVE_AND_SEND`
  * Field `SR_TICKET_CLOSEALLREQUESTTABS`
  * Field `SR_TICKET_CLOSEALLSELECTIONTABS`
  * Field `SR_TICKET_CLOSEALLTABS`
  * Field `SR_TICKET_CLOSEALLTABSBUTTHIS`
  * Field `SR_USER_PRESENCESTATUS_CAPTION`
  * Field `SR_WORKFLOW_DELETE_FLOW`
  * Field `SR_WORKFLOW_DELETE_FLOWS`
  * Field `SR_WORKFLOW_SELECT_FLOWS`
  * Field `SR_WORKFLOWS_ADD_TO_OTHER_FLOW`
  * Field `SR_WORKFLOWS_DELETE_FLOW`
  * Field `SR_WORKFLOWS_END_FLOW`
  * Field `SR_WORKFLOWS_FLOW_IS_RUNNING`
  * Field `SR_WORKFLOWS_FLOWS_HEADER`
  * Field `SR_WORKFLOWS_REMOVE_FROM_THIS`
  * Field `SR_WORKFLOWSTEP_WAIT_DESCRIPTION`
  * Field `SR_WORKFLOWSTEP_WAIT_LISTITEM_AFTER_PREV`
  * Field `SR_WORKFLOWSTEP_WAIT_LISTITEM_DATEFIELD`
  * Field `SR_WORKFLOWSTEP_WAIT_LISTITEM_DATETIME`
  * Field `SR_WORKFLOWSTEP_WAIT_LISTITEM_DAYS`
  * Field `SR_WORKFLOWSTEP_WAIT_LISTITEM_HOURS`
  * Field `SR_WORKFLOWSTEP_WAIT_LISTITEM_MINUNTES`
  * Field `SR_WORKFLOWSTEP_WAIT_LISTITEM_NUMINTERVALS`
  * Field `SR_WORKFLOWSTEP_WAIT_LISTITEM_WEEKS`
  * Field `SR_WORKFLOWSTEP_WAIT_LISTITEM_WORKINGDAYS`
  * Field `SR_WORKFLOWSTEP_WAIT_WAIT`
  * Field `SR_WORKFLOWSTEP_WAIT_WAIT_FOR`

#### SuperOffice.Security.Principal.ISoContextProvider is Modified

* Deleted items
  * Method `GetCurrenContext()`
  * Method `SetCurrentContext(SoContextContainer)`
* New items
  * Method `GetCurrentPrincipal()`
  * Method `SetCurrentPrincipal(IPrincipal)`

#### SuperOffice.ServiceConstants is Modified

* New items
  * Field `EmptyValue`
  * Field `MaxMessageBodySize`

#### SuperOffice.Threading.ThreadManager is Modified

* Modified items
  * Method `AbortAllThreads()`

#### SuperOffice.Util.CollectionOps is Modified

* New items
  * Method `HasName(String, String, Boolean)`

#### SuperOffice.Util.XmlObjectHelper is Modified

* Deleted items
  * Method `XmlObjectHelper()`
* Modified items
  * Method `GetBoolValue(XElement, String)`
  * Method `GetIntValue(XElement, String)`
  * Method `GetObject(XElement, String)`
  * Method `GetStringValue(XElement, String)`
* New items
  * Method `GetStringValue2(XElement, String)`


### Assembly: SoDatabase

### Deleted Types

* `SuperOffice.CRM.ArchiveLists.AliasProviderBase<AliasedType>`

### New Types

* `SuperOffice.CRM.ArchiveLists.EmailFlowContentEmailFlowContentExtender`
* `SuperOffice.CRM.ArchiveLists.EmailFlowContentProvider`
* `SuperOffice.CRM.ArchiveLists.PartialMatches`
* `SuperOffice.CRM.ArchiveLists.ShipmentMessageEmailFlowExtender`
* `SuperOffice.CRM.ArchiveLists.ShipmentMessageExtenderBase`
* `SuperOffice.CRM.ArchiveLists.ShipmentMessageShipmentExtender`
* `SuperOffice.CRM.Cache.HierarchyTreeCache`
* `SuperOffice.CRM.Data.EmailFlowContentLinkTableInfo`
* `SuperOffice.CRM.Rows.EmailFlowContentLinkRecordData`
* `SuperOffice.CRM.Rows.EmailFlowContentLinkRecordDataExtensions`
* `SuperOffice.CRM.Rows.EmailFlowContentLinkRow`
* `SuperOffice.CRM.Rows.EmailFlowContentLinkRows`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateEmailFlowContentLinkRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateEmailFlowContentLinkRowsFactory`
* `SuperOffice.CRM.Security.SentryQueryEmailFlowTableUpdater`
* `SuperOffice.CRM.Security.SentryQueryWorkflowTableUpdater`
* `SuperOffice.CRM.Security.WorkflowSentry`
* `SuperOffice.CRM.Security.WorkflowSentryQueryInfo`
* `SuperOffice.Data.Sql.WaitFor`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationAggregatorExtender is Modified

* New items
  * Method `GetLinkhintId(SoDataReader)`

#### SuperOffice.CRM.ArchiveLists.AttachmentExtenderBase is Modified

* New items
  * Method `InnerPopulateRowFromReader(SoDataReader, ArchiveRow)`
  * Method `IsQueryNeeded()`

#### SuperOffice.CRM.ArchiveLists.ExternalDocumentExtender is Modified

* Deleted items
  * Method `SetJoin()`

#### SuperOffice.CRM.ArchiveLists.ExternalDocumentExtenderBase is Modified

* New items
  * Field `ColIsHistoryItem`
  * Method `SetJoin()`

#### SuperOffice.CRM.ArchiveLists.ExternalDocumentItemsProvider is Modified

* Deleted items
  * Method `PostProcessQuery()`

#### SuperOffice.CRM.ArchiveLists.ExternalDocumentsProvider is Modified

* New items
  * Field `ColNodeType`
  * Method `InnerPopulateRow(ArchiveRow)`

#### SuperOffice.CRM.ArchiveLists.FreetextMatchCalculator is Modified

* Deleted items
  * Method `CalculateMatches(String[], String[], Nullable<Int32>, Nullable<Int32>, Boolean, Boolean)`
* New items
  * Method `CalculateMatches(String[], String[], Nullable<Int32>, Nullable<Int32>, Boolean, List<PartialMatches>)`

#### SuperOffice.CRM.ArchiveLists.HierarchyExtenderBase is Modified

* New items
  * Field `ColumnHierarchyFullpathIds`
  * Method `InnerPopulateRowFromReader(SoDataReader, ArchiveRow)`

#### SuperOffice.CRM.ArchiveLists.RequestNotificationProvider is Modified

* Deleted items
  * Method `AcceptRow(ArchiveRow)`
* New items
  * Method `GetRows(String)`

#### SuperOffice.CRM.ArchiveLists.TicketFavouriteUpdatedNotificationExtender is Modified

* Deleted items
  * Property `MappedAssociateIdField`

#### SuperOffice.CRM.Data.AppointmentTableInfo is Modified

* New items
  * Property `AgendaTextId`
  * Property `AgendaTextId_InnerJoin_Text`
  * Property `InternalNotesTextId`
  * Property `InternalNotesTextId_InnerJoin_Text`
  * Method `IdxType(AppointmentType)`

#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* New items
  * Property `LeftOuterJoin_EmailFlowContentLink_RegisteredAssociateId`
  * Property `LeftOuterJoin_EmailFlowContentLink_UpdatedAssociateId`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.AppointmentFields is Modified

* New items
  * Field `.AppointmentFieldsAgendaTextId`
  * Field `.AppointmentFieldsInternalNotesTextId`


##### SuperOffice.CRM.Data.DBC.TextFields is Modified

* New items
  * Field `.TextFieldsHtmlText`

* New items
  * Field `EmailFlowContentLink`

##### SuperOffice.CRM.Data.DBC.EmailFlowContentLinkFields is New

#### SuperOffice.CRM.Data.EmailFlowTableInfo is Modified

* New items
  * Property `LeftOuterJoin_EmailFlowContentLink_EmailFlowId`

#### SuperOffice.CRM.Data.SMessageTableInfo is Modified

* New items
  * Property `LeftOuterJoin_EmailFlowContentLink_SMessageId`

#### SuperOffice.CRM.Data.TextTableInfo is Modified

* New items
  * Property `HtmlText`
  * Property `LeftOuterJoin_Appointment_AgendaTextId`
  * Property `LeftOuterJoin_Appointment_InternalNotesTextId`

#### SuperOffice.CRM.Documents.ArchiveTempFileProvider is Modified

* Deleted items
  * Method `GetLength(String)`
* Modified items
  * Method `EnsureDirectoryExists(DirectoryInfo)`

#### SuperOffice.CRM.Documents.PhysicalDocument is Modified

* Deleted items
  * Method `GoTravel(Int32, String, ProgressEstimateCallback, ProgressStepCallback)`
  * Method `HomeComing(Int32, String, ProgressEstimateCallback, ProgressStepCallback)`
  * Method `MailMergeDocumentToFile(Int32, Int32, Int32)`

#### SuperOffice.CRM.Documents.SoArc2 is Modified

* Deleted items
  * Method `GoTravel(Int32, String, ProgressEstimateCallback, ProgressStepCallback)`
  * Method `HomeComing(Int32, String, ProgressEstimateCallback, ProgressStepCallback)`

#### SuperOffice.CRM.Documents.TempFileProviderFactory is Modified

* Modified items
  * Method `Create()`
* New items
  * Method `TempFileProviderFactory()`

#### SuperOffice.CRM.Entities.Appointment is Modified

* Modified items

##### SuperOffice.CRM.Entities.Appointment.AppointmentIdxBase is Modified

* New items
  * Property `.AppointmentIdxBaseAgendaRelationTableInfo`
  * Property `.AppointmentIdxBaseInternalNotesRelationTableInfo`

* New items
  * Property `Agenda`
  * Property `InternalNotes`
  * Property `Title`

#### SuperOffice.CRM.Entities.AppointmentMatrix is Modified

* New items
  * Property `Agenda`
  * Property `InternalNotes`
  * Property `Title`

#### SuperOffice.CRM.Lists.MailingDomainsProvider is Modified

* New items
  * Method `OnPreGetRootItems(List<ISoListItem>)`

#### SuperOffice.CRM.RegistryExtensions is Modified

* Deleted items
  * Method `GetRegistryRow(Enum)`
* New items
  * Method `GetRegistryRow(Enum, String)`

#### SuperOffice.CRM.Rows.AppointmentRecordData is Modified

* New items
  * Field `AgendaTextId`
  * Field `InternalNotesTextId`

#### SuperOffice.CRM.Rows.AppointmentRow is Modified

* New items
  * Property `AgendaTextId`
  * Property `InternalNotesTextId`
  * Event `OnAgendaTextIdChange`
  * Event `OnInternalNotesTextIdChange`

#### SuperOffice.CRM.Rows.AppointmentRows is Modified

* New items
  * Method `GetFromIdxType(AppointmentType)`
  * Method `GetFromIdxTypeActiveDate(AppointmentType, DateTime)`

##### SuperOffice.CRM.Rows.AppointmentRows.IdxType is New

##### SuperOffice.CRM.Rows.AppointmentRows.IdxTypeActiveDate is New

#### SuperOffice.CRM.Rows.Implementation.EjMessageRowImplementation is Modified

* New items
  * Method `OnSaved(Boolean)`

#### SuperOffice.CRM.Rows.TextRecordData is Modified

* New items
  * Field `HtmlText`

#### SuperOffice.CRM.Rows.TextRow is Modified

* New items
  * Property `HtmlText`
  * Event `OnHtmlTextChange`

#### SuperOffice.CRM.Ticket.TicketChangeNotificator is Modified

* Deleted items
  * Method `SendStandardTicketNotifications(Boolean, TicketChangeData, TicketChangeData)`
* New items
  * Method `SendStandardTicketNotifications(TicketChangeData, TicketChangeData)`

#### SuperOffice.CRM.Ticket.TicketHelper is Modified

* New items
  * Method `GetMailInFilterAddress(Int32)`
  * Method `UpdateEjMessageSearchTitle(Int32, String)`
  * Method `UpdateLastChanged(TicketRow, Boolean)`
  * Method `UpdateMessagesAndRepliesCount(Int32)`
  * Method `UpdateRepliedAt(TicketRow, DateTime)`

#### SuperOffice.CRM.Ticket.WeekSchedule is Modified

* Deleted items
  * Method `CalculateAlertTimeout(Int32, Int32)`
* New items
  * Method `AddTimeSpan(DateTime, TimeSpan)`

#### SuperOffice.Data.Dialect.OracleCommon is Modified

* New items
  * Method `ToSql(WaitFor)`

#### SuperOffice.Data.Dialect.SqlServerCommon is Modified

* New items
  * Method `ToSql(WaitFor)`

#### SuperOffice.Data.Dictionary.SoField is Modified

* New items
  * Property `IsRegisteredEjUser`
  * Property `IsUpdatedEjUser`

#### SuperOffice.Data.Private.FreetextIndexerLogic is Modified

* New items
  * Method `IndexSpecificRowsInTable(String, Int32[], ProgressCallback, Boolean)`

#### SuperOffice.Data.TablesInfo is Modified

* New items
  * Method `GetEmailFlowContentLinkTableInfo()`


### Assembly: SuperOffice.Plugins

### Deleted Types

* `SuperOffice.CRM.Documents.IDocumentPluginTravel`
* `SuperOffice.CRM.Documents.ITempFileProvider`
* `SuperOffice.CRM.Documents.TempFileProviderAttribute`

## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.DSL.Database.Steps_FollowUpDialog.FollowUpDialog_01_Text_Table_Modifications_And_New_Fields`
* `SuperOffice.CD.DSL.Database.Steps_Notifications.Notifications_02_AppointmentIndex`
* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_102_Udef_Freetext`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep08_EmailFlowContent`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep09_NoConversionUtcDateAndTime`
* `SuperOffice.CD.DSL.Database.T_EmailFlowContentLink`

### Modified Types

#### SuperOffice.CD.DSL.Database.T_Appointment is Modified

* New items
  * Field `AgendaTextId`
  * Field `InternalNotesTextId`

#### SuperOffice.CD.DSL.Database.T_Text is Modified

* New items
  * Field `HtmlText`



