---
uid: version_10.2.3.544_changes
date: 3/10/2023
generated: 1
---

# Changes from v10.2.2.706 and v10.2.3.544

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.EmailFlow`
* `SuperOffice.CRM.Services.IWorkflowAgent`
* `SuperOffice.CRM.Services.Workflow`
* `SuperOffice.CRM.Services.WorkflowAgent`
* `SuperOffice.CRM.Services.WorkflowStep`

### Modified Types

#### SuperOffice.CRM.Services.AppointmentAgent is Modified

* New items
  * Method `CleanUpBookingDeletedWithUpdateMode(Int32[], RecurrenceUpdateMode)`

#### SuperOffice.CRM.Services.IAppointmentAgent is Modified

* New items
  * Method `CleanUpBookingDeletedWithUpdateMode(Int32[], RecurrenceUpdateMode)`

#### SuperOffice.CRM.Services.ITicketAgent is Modified

* New items
  * Method `ClearNotify(Int32[])`
  * Method `CopyFromCRMDocument(Int32)`
  * Method `GetNextInQueue()`

#### SuperOffice.CRM.Services.TicketAgent is Modified

* New items
  * Method `ClearNotify(Int32[])`
  * Method `CopyFromCRMDocument(Int32)`
  * Method `GetNextInQueue()`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Deleted Types

* `SuperOffice.Util.ZipEntry`
* `SuperOffice.Util.ZipFile`

### New Types

* `SuperOffice.Data.WorkflowDefinitionStatus`
* `SuperOffice.Data.WorkflowGoalType`
* `SuperOffice.Data.WorkflowInstanceStatus`
* `SuperOffice.Data.WorkflowStepType`
* `SuperOffice.Data.WorkflowTriggerType`

### Modified Types

#### StreamExtensions is Modified

* New items
  * Method `GenerateStreamFromString(String)`

#### StringExtensions is Modified

* New items
  * Method `MakePassword(String, Int32, String)`

#### SuperOffice.Configuration.ConfigFile is Modified

* Modified items

##### SuperOffice.Configuration.ConfigFile.Cloud is Modified

* New items
  * Property `.CloudStoreAttachmentsInAzure`


##### SuperOffice.Configuration.ConfigFile.CloudSection is Modified

* New items
  * Property `.CloudSectionStoreAttachmentsInAzure`


#### SuperOffice.CRM.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.CRM.UserPreferenceStrings.Notification is Modified

* New items
  * Field `.NotificationNotifyAppointmentCancel`
  * Field `.NotificationNotifyAppointmentChange`
  * Field `.NotificationNotifyAppointmentDecline`
  * Field `.NotificationNotifyAppointmentInvitation`
  * Field `.NotificationNotifyCustomMessage`
  * Field `.NotificationNotifyFavouriteRequest`
  * Field `.NotificationNotifyNewMessage`
  * Field `.NotificationNotifyNewRequest`
  * Field `.NotificationNotifyRequestActivated`
  * Field `.NotificationNotifyRequestAssignedAway`
  * Field `.NotificationNotifyRequestEscalated`


#### SuperOffice.Data.CSRegistryEntry is Modified

* New items
  * Field `TicketLogSystem`

#### SuperOffice.Data.Domain is Modified

* New items
  * Field `EmailFlows`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_BULKUPDATE_ACTIVATION_DATE_INVALID`
  * Field `SR_BULKUPDATE_ACTIVATION_DATE_NOT_POSTPONED`
  * Field `SR_BULKUPDATE_FIELDVALUE_TICKET_STATUS_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_ASSIGNED_BY_NAME`
  * Field `SR_FIELD_APPOINTMENT_ASSIGNED_BY_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_ASSOCIATE_ID_NAME`
  * Field `SR_FIELD_APPOINTMENT_ASSOCIATE_ID_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_PRIORITY_IDX_NAME`
  * Field `SR_FIELD_APPOINTMENT_PRIORITY_IDX_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_REGISTERED_ASSOCIATE_ID_NAME`
  * Field `SR_FIELD_APPOINTMENT_REGISTERED_ASSOCIATE_ID_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_TASK_IDX_NAME`
  * Field `SR_FIELD_APPOINTMENT_TASK_IDX_TOOLTIP`
  * Field `SR_FIELD_APPOINTMENT_UPDATED_ASSOCIATE_ID_NAME`
  * Field `SR_FIELD_APPOINTMENT_UPDATED_ASSOCIATE_ID_TOOLTIP`
  * Field `SR_FIELD_PERSON_BUSINESS_IDX_NAME`
  * Field `SR_FIELD_PERSON_CATEGORY_IDX_NAME`
  * Field `SR_FIELD_PERSON_POSITION_IDX_NAME`
  * Field `SR_FIELD_PERSON_UPDATED_ASSOCIATE_ID_NAME`
  * Field `SR_FIELD_PROJECT_ASSOCIATE_ID_NAME`
  * Field `SR_FIELD_PROJECT_REGISTERED_ASSOCIATE_ID_NAME`
  * Field `SR_FIELD_PROJECT_STATUS_IDX_NAME`
  * Field `SR_FIELD_PROJECT_TYPE_IDX_NAME`
  * Field `SR_FIELD_PROJECT_UPDATED_ASSOCIATE_ID_NAME`
  * Field `SR_FIELD_SALE_ASSOCIATE_ID_NAME`
  * Field `SR_FIELD_SALE_COMPTR_ID_NAME`
  * Field `SR_FIELD_SALE_CREDITED_ID_NAME`
  * Field `SR_FIELD_SALE_CURRENCY_ID_NAME`
  * Field `SR_FIELD_SALE_PROBABILITY_IDX_NAME`
  * Field `SR_FIELD_SALE_REASON_ID_NAME`
  * Field `SR_FIELD_SALE_REASON_SOLD_ID_NAME`
  * Field `SR_FIELD_SALE_REASON_STALLED_ID_NAME`
  * Field `SR_FIELD_SALE_REGISTERED_ASSOCIATE_ID_NAME`
  * Field `SR_FIELD_SALE_SALE_TYPE_CAT_ID_NAME`
  * Field `SR_FIELD_SALE_SALE_TYPE_ID_NAME`
  * Field `SR_FIELD_SALE_SOURCE_ID_NAME`
  * Field `SR_FIELD_SALE_UPDATED_ASSOCIATE_ID_NAME`
  * Field `SR_FIELD_TICKET_PROJECT_ID_NAME`
  * Field `SR_FIELD_TICKET_SALE_ID_NAME`
  * Field `SR_NOTIFY_TICKET_ACTIVATED`
  * Field `SR_NOTIFY_TICKET_FAVOURITE_ESCALATED`
  * Field `SR_NOTIFY_TICKET_FAVOURITE_UPDATED`
  * Field `SR_NOTIFY_TICKET_NEW_MESSAGE`
  * Field `SR_NOTIFY_TICKET_TRANSFERRED`
  * Field `SR_TICKET_NEXT_IN_QUEUE`
  * Field `SR_WORKFLOWSTEPTYPE_ADD_TO_LIST`
  * Field `SR_WORKFLOWSTEPTYPE_CREATE_FOLLOWUP`
  * Field `SR_WORKFLOWSTEPTYPE_CREATE_REQUEST`
  * Field `SR_WORKFLOWSTEPTYPE_CREATE_SALE`
  * Field `SR_WORKFLOWSTEPTYPE_NOTIFY_BY_EMAIL`
  * Field `SR_WORKFLOWSTEPTYPE_NOTIFY_BY_SMS`
  * Field `SR_WORKFLOWSTEPTYPE_REMOVE_FROM_LIST`
  * Field `SR_WORKFLOWSTEPTYPE_RUN_SCRIPT`
  * Field `SR_WORKFLOWSTEPTYPE_SEND_EMAIL`
  * Field `SR_WORKFLOWSTEPTYPE_SEND_SMS`
  * Field `SR_WORKFLOWSTEPTYPE_SPLIT`
  * Field `SR_WORKFLOWSTEPTYPE_UPDATE_CONTACT`
  * Field `SR_WORKFLOWSTEPTYPE_WAIT_FOR_ACTION`
  * Field `SR_WORKFLOWSTEPTYPE_WAIT_FOR_TIME`

#### SuperOffice.Util.Zip is Modified

* Deleted items
  * Method `Zip(Byte[], ZipType)`
  * Method `Zip(String, ZipType)`
* Modified items
  * Property `ZipType`


### Assembly: SoDatabase

### Deleted Types

* `SuperOffice.CRM.ArchiveLists.TicketNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.TicketNotificationSubProvider`
* `SuperOffice.CRM.AttachmentHelper`
* `SuperOffice.CRM.AttachmentPluginAttribute`
* `SuperOffice.CRM.IAttachmentPlugin`
* `SuperOffice.CRM.TicketMessage.AttachmentFilesystemPlugin`

### New Types

* `SuperOffice.CRM.ArchiveLists.AppointmentNotificationAggregatorProvider`
* `SuperOffice.CRM.ArchiveLists.ConfigurableArchiveAppointmentProvider`
* `SuperOffice.CRM.ArchiveLists.Dynamic_specializations.DynamicAppointmentExtender`
* `SuperOffice.CRM.ArchiveLists.Dynamic_specializations.DynamicDocumentExtender`
* `SuperOffice.CRM.ArchiveLists.Dynamic_specializations.DynamicProjectExtender`
* `SuperOffice.CRM.ArchiveLists.Dynamic_specializations.DynamicSaleExtender`
* `SuperOffice.CRM.ArchiveLists.RequestNotificationProvider`
* `SuperOffice.CRM.ArchiveLists.TicketActivatedNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.TicketActivatedNotificationSubProvider`
* `SuperOffice.CRM.ArchiveLists.TicketCustomMessageNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.TicketCustomMessageNotificationSubProvider`
* `SuperOffice.CRM.ArchiveLists.TicketEscalatedNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.TicketEscalatedNotificationSubProvider`
* `SuperOffice.CRM.ArchiveLists.TicketFavouriteUpdatedNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.TicketFavouriteUpdatedNotificationSubProvider`
* `SuperOffice.CRM.ArchiveLists.TicketNewNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.TicketNewNotificationSubProvider`
* `SuperOffice.CRM.ArchiveLists.TicketNotificationExtenderBase`
* `SuperOffice.CRM.ArchiveLists.TicketTransferredNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.TicketTransferredNotificationSubProvider`
* `SuperOffice.CRM.ArchiveLists.TicketUpdatedNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.TicketUpdatedNotificationSubProvider`
* `SuperOffice.CRM.Attachment.AttachmentFilesystemPlugin`
* `SuperOffice.CRM.Attachment.AttachmentHelper`
* `SuperOffice.CRM.Attachment.AttachmentPluginAttribute`
* `SuperOffice.CRM.Attachment.AttachmentPluginFactory`
* `SuperOffice.CRM.Attachment.IAttachmentPlugin`
* `SuperOffice.CRM.Data.EmailFlowTableInfo`
* `SuperOffice.CRM.Data.WorkflowGoalTableInfo`
* `SuperOffice.CRM.Data.WorkflowInstanceTableInfo`
* `SuperOffice.CRM.Data.WorkflowStepTableInfo`
* `SuperOffice.CRM.Data.WorkflowTableInfo`
* `SuperOffice.CRM.Data.WorkflowTriggerTableInfo`
* `SuperOffice.CRM.Lists.WorkflowStepTypeProvider`
* `SuperOffice.CRM.Rows.EmailFlowRecordData`
* `SuperOffice.CRM.Rows.EmailFlowRecordDataExtensions`
* `SuperOffice.CRM.Rows.EmailFlowRow`
* `SuperOffice.CRM.Rows.EmailFlowRows`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateEmailFlowRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateEmailFlowRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateWorkflowGoalRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateWorkflowGoalRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateWorkflowInstanceRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateWorkflowInstanceRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateWorkflowRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateWorkflowRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateWorkflowStepRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateWorkflowStepRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateWorkflowTriggerRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateWorkflowTriggerRowsFactory`
* `SuperOffice.CRM.Rows.WorkflowGoalRecordData`
* `SuperOffice.CRM.Rows.WorkflowGoalRecordDataExtensions`
* `SuperOffice.CRM.Rows.WorkflowGoalRow`
* `SuperOffice.CRM.Rows.WorkflowGoalRows`
* `SuperOffice.CRM.Rows.WorkflowInstanceRecordData`
* `SuperOffice.CRM.Rows.WorkflowInstanceRecordDataExtensions`
* `SuperOffice.CRM.Rows.WorkflowInstanceRow`
* `SuperOffice.CRM.Rows.WorkflowInstanceRows`
* `SuperOffice.CRM.Rows.WorkflowRecordData`
* `SuperOffice.CRM.Rows.WorkflowRecordDataExtensions`
* `SuperOffice.CRM.Rows.WorkflowRow`
* `SuperOffice.CRM.Rows.WorkflowRows`
* `SuperOffice.CRM.Rows.WorkflowStepRecordData`
* `SuperOffice.CRM.Rows.WorkflowStepRecordDataExtensions`
* `SuperOffice.CRM.Rows.WorkflowStepRow`
* `SuperOffice.CRM.Rows.WorkflowStepRows`
* `SuperOffice.CRM.Rows.WorkflowTriggerRecordData`
* `SuperOffice.CRM.Rows.WorkflowTriggerRecordDataExtensions`
* `SuperOffice.CRM.Rows.WorkflowTriggerRow`
* `SuperOffice.CRM.Rows.WorkflowTriggerRows`
* `SuperOffice.Data.Private.TicketLogging.LogDetail`
* `SuperOffice.Data.Sql.SqlCommandExtraInfo`
* `SuperOffice.Data.SQL.WorkflowDefinitionStatusFieldInfo`
* `SuperOffice.Data.SQL.WorkflowGoalTypeFieldInfo`
* `SuperOffice.Data.SQL.WorkflowInstanceStatusFieldInfo`
* `SuperOffice.Data.SQL.WorkflowStepTypeFieldInfo`
* `SuperOffice.Data.SQL.WorkflowTriggerTypeFieldInfo`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.AppointmentAcceptedNotificationExtender is Modified

* Deleted items
  * Property `MappedAssociateField`
  * Property `MappedEmailIdField`
  * Property `MappedOriginatorField`
  * Property `MappedReceiverField`
* New items
  * Property `IsBookingOwner`

#### SuperOffice.CRM.ArchiveLists.AppointmentCancelledNotificationExtender is Modified

* Deleted items
  * Property `MappedAssociateField`
  * Property `MappedEmailIdField`
  * Property `MappedOriginatorField`
  * Property `MappedReceiverField`
* New items
  * Property `IsBookingOwner`

#### SuperOffice.CRM.ArchiveLists.AppointmentNewNotificationExtender is Modified

* Deleted items
  * Property `MappedAssociateField`
  * Property `MappedEmailIdField`
  * Property `MappedOriginatorField`
  * Property `MappedReceiverField`
* New items
  * Property `IsBookingOwner`

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationExtenderBase is Modified

* Deleted items
  * Property `MappedOriginatorField`
  * Property `MappedReceiverField`
* Modified items
  * Property `MappedAssociateField`
  * Property `MappedEmailIdField`
* New items
  * Field `EndDateColumnName`
  * Field `IsRecurringColumnName`
  * Field `RecurringEndDateColumnName`
  * Field `RecurringStartDateColumnName`
  * Field `StartDateColumnName`
  * Property `IsBookingOwner`
  * Method `AddOriginatorFullName(SoDataReader, ArchiveRow)`
  * Method `AddReceiverFullName(SoDataReader, ArchiveRow)`

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationProvider is Modified

* Deleted items
  * Method `InnerPopulateRow(ArchiveRow)`
* New items
  * Property `BaseClassShouldFilterColumns`
  * Property `BaseClassShouldFilterEntities`
  * Property `BaseClassShouldPage`
  * Property `BaseClassShouldSort`
  * Method `Close()`
  * Method `FilterRecurringRows(List<ArchiveRow>)`
  * Method `GetAvailableColumns()`
  * Method `GetAvailableEntities()`
  * Method `GetResultData()`
  * Method `SetDesiredColumns(String[])`
  * Method `SetDesiredEntities(String[])`
  * Method `SetOrderBy(ArchiveOrderByInfo[])`
  * Method `SetPagingInfo(Int32, Int32)`
  * Method `SetRestriction(ArchiveRestrictionInfo[])`

#### SuperOffice.CRM.ArchiveLists.AppointmentRejectedNotificationExtender is Modified

* Deleted items
  * Property `MappedAssociateField`
  * Property `MappedEmailIdField`
  * Property `MappedOriginatorField`
  * Property `MappedReceiverField`
* New items
  * Property `IsBookingOwner`

#### SuperOffice.CRM.ArchiveLists.AppointmentUpdatedNotificationExtender is Modified

* Deleted items
  * Property `MappedAssociateField`
  * Property `MappedEmailIdField`
  * Property `MappedOriginatorField`
  * Property `MappedReceiverField`
* New items
  * Property `IsBookingOwner`

#### SuperOffice.CRM.ArchiveLists.ExtensibleColumnsBase is Modified

* Deleted items
  * Method `AddUpdatedDate(SoDataReader, ArchiveRow, ArchiveColumnInfo, FieldInfo, FieldInfo)`
* New items
  * Method `AddUpdatedDate(SoDataReader, ArchiveRow, ArchiveColumnInfo, FieldInfo, FieldInfo, Boolean)`

#### SuperOffice.CRM.ArchiveLists.NotificationNotificationExtender&lt;Info&gt; is Modified

* Deleted items
* New items
  * Field `NotifyDateTimeColumnName`

#### SuperOffice.CRM.BulkUpdate.BulkUpdateSystem is Modified

* Modified items

##### SuperOffice.CRM.BulkUpdate.BulkUpdateSystem.TicketFieldValueKeys is Modified

* New items
  * Field `.TicketFieldValueKeysStatus`


#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* New items
  * Property `LeftOuterJoin_EmailFlow_RegisteredAssociateId`
  * Property `LeftOuterJoin_EmailFlow_UpdatedAssociateId`
  * Property `LeftOuterJoin_Workflow_AssociateId`
  * Property `LeftOuterJoin_Workflow_RegisteredAssociateId`
  * Property `LeftOuterJoin_Workflow_UpdatedAssociateId`
  * Property `LeftOuterJoin_WorkflowGoal_RegisteredAssociateId`
  * Property `LeftOuterJoin_WorkflowGoal_UpdatedAssociateId`
  * Property `LeftOuterJoin_WorkflowInstance_RegisteredAssociateId`
  * Property `LeftOuterJoin_WorkflowInstance_UpdatedAssociateId`
  * Property `LeftOuterJoin_WorkflowStep_RegisteredAssociateId`
  * Property `LeftOuterJoin_WorkflowStep_UpdatedAssociateId`
  * Property `LeftOuterJoin_WorkflowTrigger_RegisteredAssociateId`
  * Property `LeftOuterJoin_WorkflowTrigger_UpdatedAssociateId`

#### SuperOffice.CRM.Data.ContactTableInfo is Modified

* New items
  * Property `LeftOuterJoin_WorkflowInstance_ContactId`

#### SuperOffice.CRM.Data.DBC is Modified

* New items
  * Field `EmailFlow`
  * Field `Workflow`
  * Field `WorkflowGoal`
  * Field `WorkflowInstance`
  * Field `WorkflowStep`
  * Field `WorkflowTrigger`

##### SuperOffice.CRM.Data.DBC.EmailFlowFields is New

##### SuperOffice.CRM.Data.DBC.WorkflowFields is New

##### SuperOffice.CRM.Data.DBC.WorkflowGoalFields is New

##### SuperOffice.CRM.Data.DBC.WorkflowInstanceFields is New

##### SuperOffice.CRM.Data.DBC.WorkflowStepFields is New

##### SuperOffice.CRM.Data.DBC.WorkflowTriggerFields is New

#### SuperOffice.CRM.Data.HierarchyTableInfo is Modified

* New items
  * Property `LeftOuterJoin_EmailFlow_HierarchyId`

#### SuperOffice.CRM.Data.PersonTableInfo is Modified

* New items
  * Property `LeftOuterJoin_WorkflowInstance_PersonId`

#### SuperOffice.CRM.Data.ShipmentTypeTableInfo is Modified

* New items
  * Property `LeftOuterJoin_EmailFlow_ShipmentTypeId`

#### SuperOffice.CRM.Data.UserGroupTableInfo is Modified

* New items
  * Property `LeftOuterJoin_Workflow_GroupId`

#### SuperOffice.CRM.Documents.HtmlToPdf is Modified

* Deleted items
  * Method `GenerateStreamFromString(String)`

#### SuperOffice.CRM.Documents.PhysicalDocument is Modified

* Deleted items
  * Method `SaveDocumentTemplateStream(Int32, Stream, String, Int32)`
* New items
  * Method `SaveDocumentTemplateStream(Int32, Stream, String, Int32, String)`

#### SuperOffice.CRM.Mail.MailParser is Modified

* Deleted items
  * Method `GetMailItem(String, String)`

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(WorkflowDefinitionStatus&, FieldInfo)`
  * Method `ValidateField(WorkflowGoalType&, FieldInfo)`
  * Method `ValidateField(WorkflowInstanceStatus&, FieldInfo)`
  * Method `ValidateField(WorkflowStepType&, FieldInfo)`
  * Method `ValidateField(WorkflowTriggerType&, FieldInfo)`

#### SuperOffice.CRM.Ticket.TicketHelper is Modified

* New items
  * Method `GetTicketBaseStatus(Int32)`

#### SuperOffice.Data.Dictionary.SoField is Modified

* New items
  * Method `GetEffectiveTextLength()`

#### SuperOffice.Data.Private.TicketLogging.ITicketLoggingLogic is Modified


#### SuperOffice.Data.Private.TicketLogging.TicketLoggingLogic is Modified

* New items
  * Method `GetRegistryRow(Enum)`

#### SuperOffice.Data.SQL.PrivateSave is Modified

* New items
  * Method `SetTicketLogAction(TicketLogAction, String)`

#### SuperOffice.Data.TablesInfo is Modified

* New items
  * Method `GetEmailFlowTableInfo()`
  * Method `GetWorkflowGoalTableInfo()`
  * Method `GetWorkflowInstanceTableInfo()`
  * Method `GetWorkflowStepTableInfo()`
  * Method `GetWorkflowTableInfo()`
  * Method `GetWorkflowTriggerTableInfo()`

#### SuperOffice.Util.AccessGateway is Modified

* Deleted items
  * Method `GenerateStreamFromString(String)`


## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.Database.WorkflowDefinitionStatus`
* `SuperOffice.CD.Database.WorkflowGoalType`
* `SuperOffice.CD.Database.WorkflowInstanceStatus`
* `SuperOffice.CD.Database.WorkflowStepType`
* `SuperOffice.CD.Database.WorkflowTriggerType`
* `SuperOffice.CD.DSL.Database.Steps_Targets.WorkflowStep01_Initial`
* `SuperOffice.CD.DSL.Database.Steps_Targets.WorkflowStep02_Rank`
* `SuperOffice.CD.DSL.Database.Steps_Targets.WorkflowStep03_Hierarchy`
* `SuperOffice.CD.DSL.Database.T_EmailFlow`
* `SuperOffice.CD.DSL.Database.T_Workflow`
* `SuperOffice.CD.DSL.Database.T_WorkflowGoal`
* `SuperOffice.CD.DSL.Database.T_WorkflowInstance`
* `SuperOffice.CD.DSL.Database.T_WorkflowStep`
* `SuperOffice.CD.DSL.Database.T_WorkflowTrigger`

### Modified Types

#### SuperOffice.CD.DSL.Database.Domain is Modified

* New items
  * Field `EmailFlows`



