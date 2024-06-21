---
uid: version_10.3.6.552_changes
date: 5/22/2024
---

Changes from v10.3.5.599 and v10.3.6.552

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### Modified Types

#### SuperOffice.CRM.Services.AppointmentInfo is Modified

* New items
  * Property `ContactName`
  * Property `TaskName`

#### SuperOffice.CRM.Services.WorkflowStepNotifyBySMS is Modified

* New items
  * Property `SpecificPhoneNumbers`
  * Property `Text`
  * Property `To`

#### SuperOffice.CRM.Services.WorkflowStepRunScript is Modified

* New items
  * Property `ScriptId`

## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Deleted Types

* `SuperOffice.IO.IFastSerializationTypeSurrogate`
* `SuperOffice.IO.IOwnedDataSerializable`
* `SuperOffice.IO.IOwnedDataSerializableAndRecreatable`
* `SuperOffice.IO.OptimizationException`
* `SuperOffice.IO.SerializationReader`
* `SuperOffice.IO.SerializationWriter`

### New Types

* `SuperOffice.Data.WorkflowNotifySMSType`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.Constants is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.Constants.ExtraFieldAttrib is Modified

* New items
  * Field `.ExtraFieldAttribDynamic`
  * Field `.ExtraFieldAttribHideDisplay`

##### SuperOffice.CRM.ArchiveLists.Constants.IconHints is Modified

* New items
  * Field `.IconHintsResource_Available`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_ADMIN_TICKETTYPE_SHOW_IN_NEW_TOOLTIP`
  * Field `SR_ARCHIVE_CREATED_BY_FORM`
  * Field `SR_ARCHIVE_ISLOCATION`
  * Field `SR_ARCHIVE_UPDATED_BY_FLOW`
  * Field `SR_CREATED_BY_WORKFLOW`
  * Field `SR_CREATED_BY_WORKFLOW_TOOLTIP`
  * Field `SR_EDITOR_TOGGLE_RECIPIENTS`
  * Field `SR_FLOW_ADD_CRITERIA`
  * Field `SR_MENU_CUSTOMOBJECTS`
  * Field `SR_PREVIEW_NO_CONTACTS`
  * Field `SR_PREVIEW_NO_CUSTOM_OBJECTS`
  * Field `SR_PREVIEW_NO_PERSONS`
  * Field `SR_SELECTION_CUSTOMOBJECT_CONDITION_DELETE`
  * Field `SR_SELECTION_CUSTOMOBJECT_NEW`
  * Field `SR_SELECTION_DELETE_ALL`
  * Field `SR_WORKFLOW_ERROR_NOSCRIPTID`
  * Field `SR_WORKFLOWSTEP_INVALID_INV_CRITERION`
  * Field `SR_WORKFLOWSTEP_INVALID_MISSING_CONTENT`
  * Field `SR_WORKFLOWSTEP_INVALID_MISSING_LINK`
  * Field `SR_WORKFLOWSTEP_INVALID_MISSING_LINKORFORM`
  * Field `SR_WORKFLOWSTEP_INVALID_MISSING_PROJECT`
  * Field `SR_WORKFLOWSTEP_INVALID_MISSING_PROJECT_OR_SELECTION`
  * Field `SR_WORKFLOWSTEP_INVALID_MISSING_SELECTION`
  * Field `SR_WORKFLOWSTEP_INVALID_MISSING_SUBJECT`
  * Field `SR_WORKFLOWSTEP_INVALID_MISSINGFORM`
  * Field `SR_WORKFLOWSTEP_INVALID_NO_ACTION`
  * Field `SR_WORKFLOWSTEP_INVALID_NO_FIELDS_SELECTED`
  * Field `SR_WORKFLOWSTEP_INVALID_NO_TRIGGER`

### Assembly: SoDatabase

### Deleted Types

* `SuperOffice.CRM.Lists.EMailRecipientProvider`

### New Types

* `.ExtraFieldsAppointmentExtender`
* `.ExtraFieldsContactExtender`
* `.ExtraFieldsPersonExtender`
* `.ExtraFieldsProjectExtender`
* `.ExtraFieldsSaleExtender`
* `.ExtraFieldsTicketExtender`
* `SuperOffice.CRM.ArchiveLists.RecursionInfo`
* `SuperOffice.CRM.Lists.Country2Provider`
* `SuperOffice.CRM.Security.HierarchySentry`
* `SuperOffice.CRM.Security.HierarchySentryQueryInfo`
* `SuperOffice.CRM.Workflow.NotifyBySMSSettings`
* `SuperOffice.CRM.Workflow.RunScriptSettings`
* `SuperOffice.CRM.Workflow.WorkflowStepNotifyBySMS`
* `SuperOffice.CRM.Workflow.WorkflowStepRunScript`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.AppointmentExtenderBase is Modified

* Deleted items
  * Method `AppointmentExtenderBase(Features)`
* New items
  * Method `AppointmentExtenderBase(Features, String)`

#### SuperOffice.CRM.ArchiveLists.AssociateExtenderBase is Modified

* New items
  * Field `ColumnIsLocation`

#### SuperOffice.CRM.ArchiveLists.ContactExtenderBase is Modified

* Deleted items
  * Method `ContactExtenderBase(Features)`
  * Method `Initialize(Features)`
* New items
  * Method `ContactExtenderBase(Features, String)`
  * Method `Initialize(Features, String)`

#### SuperOffice.CRM.ArchiveLists.ExtraFieldExtenderBase is Modified

* Deleted items
  * Method `ExtraFieldExtenderBase(RecursionInfo)`

##### SuperOffice.CRM.ArchiveLists.ExtraFieldExtenderBase.RecursionInfo is Deleted

* New items
  * Method `ExtraFieldExtenderBase(RecursionInfo)`

#### SuperOffice.CRM.ArchiveLists.ExtraFieldsExtraTableExtender is Modified

* Deleted items
  * Method `ExtraFieldsExtraTableExtender(SoField, String, RecursionInfo)`
  * Method `ExtraFieldsExtraTableExtender(SoField, String, RecursionInfo, Boolean)`
* New items
  * Method `ExtraFieldsExtraTableExtender(SoField, String, RecursionInfo)`
  * Method `ExtraFieldsExtraTableExtender(SoField, String, RecursionInfo, Boolean)`

#### SuperOffice.CRM.ArchiveLists.ExtraTableProvider is Modified

* Modified items
  * Method `ExtraTableProvider(String)`

#### SuperOffice.CRM.ArchiveLists.FormFieldsExtender is Modified

* New items
  * Method `InnerPopulateRowFromReader(SoDataReader, ArchiveRow)`

#### SuperOffice.CRM.ArchiveLists.Joiners.AppointmentExtraFieldExtender is Modified

* New items
  * Method `AppointmentExtraFieldExtender(String, RecursionInfo)`

#### SuperOffice.CRM.ArchiveLists.Joiners.ContactExtraFieldExtender is Modified

* New items
  * Method `ContactExtraFieldExtender(String, RecursionInfo)`

#### SuperOffice.CRM.ArchiveLists.Joiners.ProjectExtraFieldExtender is Modified

* New items
  * Method `ProjectExtraFieldExtender(String, RecursionInfo)`

#### SuperOffice.CRM.ArchiveLists.Joiners.SaleExtraFieldExtender is Modified

* New items
  * Method `SaleExtraFieldExtender(String, RecursionInfo)`

#### SuperOffice.CRM.ArchiveLists.Joiners.TicketExtraFieldExtender is Modified

* New items
  * Method `TicketExtraFieldExtender(String, RecursionInfo)`

#### SuperOffice.CRM.ArchiveLists.PersonExtenderBase is Modified

* Deleted items
  * Method `PersonExtenderBase(Features, String)`
  * Method `Initialize(Features, String)`
* New items
  * Method `PersonExtenderBase(Features, String, String)`
  * Method `Initialize(Features, String, String)`

#### SuperOffice.CRM.ArchiveLists.PersonExtraFieldExtender is Modified

* New items
  * Method `PersonExtraFieldExtender(String, RecursionInfo)`

#### SuperOffice.CRM.ArchiveLists.ProjectExtenderBase is Modified

* Deleted items
  * Method `ProjectExtenderBase(Features)`
* New items
  * Method `ProjectExtenderBase(Features, String)`

#### SuperOffice.CRM.ArchiveLists.SaleExtenderBase is Modified

* Deleted items
  * Method `SaleExtenderBase(Features)`
* New items
  * Method `SaleExtenderBase(Features, String)`

#### SuperOffice.CRM.ArchiveLists.TicketExtenderBase is Modified

* Deleted items
  * Method `TicketExtenderBase(Features)`
* New items
  * Method `TicketExtenderBase(Features, String)`

#### SuperOffice.CRM.CustomObject.CustomObjectHelper is Modified

* Deleted items
  * Method `ResolveIcon(ExtraTablesRecordData)`
* New items
  * Method `ForwardOrReverseJoin(ArchiveSelect, TableInfo, TableInfo, SoField)`
  * Method `ResolveDisplayFieldName(SoField)`
  * Method `ResolveIcon(String)`

#### SuperOffice.CRM.Data.AppointmentTableInfo is Modified

* New items
  * Property `CreatedByWorkflowId`
  * Property `CreatedByWorkflowId_InnerJoin_Workflow`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.AppointmentFields is Modified

* New items
  * Field `.AppointmentFieldsCreatedByWorkflowId`

##### SuperOffice.CRM.Data.DBC.PersonFields is Modified

* New items
  * Field `.PersonFieldsCreatedByFormId`
  * Field `.PersonFieldsModifiedByWorkflowId`
  * Field `.PersonFieldsModifiedByWorkflowWhen`

##### SuperOffice.CRM.Data.DBC.SaleFields is Modified

* New items
  * Field `.SaleFieldsCreatedByWorkflowId`

##### SuperOffice.CRM.Data.DBC.SLinkFields is Modified

* New items
  * Field `.SLinkFieldsLocalLink`

##### SuperOffice.CRM.Data.DBC.TicketFields is Modified

* New items
  * Field `.TicketFieldsCreatedByWorkflowId`

#### SuperOffice.CRM.Data.FormTableInfo is Modified

* New items
  * Property `LeftOuterJoin_Person_CreatedByFormId`

#### SuperOffice.CRM.Data.PersonTableInfo is Modified

* New items
  * Property `CreatedByFormId`
  * Property `CreatedByFormId_InnerJoin_Form`
  * Property `ModifiedByWorkflowId`
  * Property `ModifiedByWorkflowId_InnerJoin_Workflow`
  * Property `ModifiedByWorkflowWhen`

#### SuperOffice.CRM.Data.SaleTableInfo is Modified

* New items
  * Property `CreatedByWorkflowId`
  * Property `CreatedByWorkflowId_InnerJoin_Workflow`

#### SuperOffice.CRM.Data.SLinkTableInfo is Modified

* New items
  * Property `LocalLink`
  * Property `LocalLink_InnerJoin_SMessage`

#### SuperOffice.CRM.Data.SMessageTableInfo is Modified

* New items
  * Property `LeftOuterJoin_SLink_LocalLink`

#### SuperOffice.CRM.Data.TicketTableInfo is Modified

* New items
  * Property `CreatedByWorkflowId`
  * Property `CreatedByWorkflowId_InnerJoin_Workflow`

#### SuperOffice.CRM.Data.WorkflowTableInfo is Modified

* New items
  * Property `LeftOuterJoin_Appointment_CreatedByWorkflowId`
  * Property `LeftOuterJoin_Person_ModifiedByWorkflowId`
  * Property `LeftOuterJoin_Sale_CreatedByWorkflowId`
  * Property `LeftOuterJoin_Ticket_CreatedByWorkflowId`

#### SuperOffice.CRM.Lists.ArchiveColumnsProviderBase is Modified

* New items
  * Field `HeadingIdStart`

#### SuperOffice.CRM.Lists.EmailPhoneProvider is Modified

#### SuperOffice.CRM.Lists.TaskProvider is Modified

* New items
  * Method `GetHeadingIconHint(ListTableRow)`
  * Method `GetItemIconHint(ListTableRow)`

#### SuperOffice.CRM.Lists.UserGroupProvider is Modified

#### SuperOffice.CRM.Mail.MailCache is Modified

* Deleted items
  * Method `DeleteCachedEnvelopes(Int32, String, SoMailCredentials, Int32[])`
  * Method `SetCachedEnvelopesRead(Int32, String, SoMailCredentials, Int32[], Boolean)`
  * Method `SetCachedFolderList(Int32, String, String, String[])`
  * Method `UpdateMailCacheForAssociate(Int32, SoMailCredentials, String, MailEnvelope[])`

#### SuperOffice.CRM.Rows.AppointmentRecordData is Modified

* New items
  * Field `CreatedByWorkflowId`

#### SuperOffice.CRM.Rows.AppointmentRow is Modified

* New items
  * Property `CreatedByWorkflowId`
  * Event `OnCreatedByWorkflowIdChange`

#### SuperOffice.CRM.Rows.AppointmentRows is Modified

* New items
  * Method `GetFromIdxCreatedByWorkflowId(Int32)`

##### SuperOffice.CRM.Rows.AppointmentRows.IdxCreatedByWorkflowId is New

#### SuperOffice.CRM.Rows.PersonRecordData is Modified

* New items
  * Field `CreatedByFormId`
  * Field `ModifiedByWorkflowId`
  * Field `ModifiedByWorkflowWhen`

#### SuperOffice.CRM.Rows.PersonRow is Modified

* New items
  * Property `CreatedByFormId`
  * Property `ModifiedByWorkflowId`
  * Property `ModifiedByWorkflowWhen`
  * Event `OnCreatedByFormIdChange`
  * Event `OnModifiedByWorkflowIdChange`
  * Event `OnModifiedByWorkflowWhenChange`

#### SuperOffice.CRM.Rows.PersonRows is Modified

* New items
  * Method `GetFromIdxCreatedByFormId(Int32)`
  * Method `GetFromIdxModifiedByWorkflowId(Int32)`

##### SuperOffice.CRM.Rows.PersonRows.IdxCreatedByFormId is New

##### SuperOffice.CRM.Rows.PersonRows.IdxModifiedByWorkflowId is New

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(WorkflowNotifySMSType&, FieldInfo)`

#### SuperOffice.CRM.Rows.SaleRecordData is Modified

* New items
  * Field `CreatedByWorkflowId`

#### SuperOffice.CRM.Rows.SaleRow is Modified

* New items
  * Property `CreatedByWorkflowId`
  * Event `OnCreatedByWorkflowIdChange`

#### SuperOffice.CRM.Rows.SaleRows is Modified

* New items
  * Method `GetFromIdxCreatedByWorkflowId(Int32)`

##### SuperOffice.CRM.Rows.SaleRows.IdxCreatedByWorkflowId is New

#### SuperOffice.CRM.Rows.SLinkRecordData is Modified

* New items
  * Field `LocalLink`

#### SuperOffice.CRM.Rows.SLinkRow is Modified

* New items
  * Property `LocalLink`

#### SuperOffice.CRM.Rows.TicketRecordData is Modified

* New items
  * Field `CreatedByWorkflowId`

#### SuperOffice.CRM.Rows.TicketRow is Modified

* New items
  * Property `CreatedByWorkflowId`

#### SuperOffice.CRM.Rows.TicketRows is Modified

* New items
  * Method `GetFromIdxCreatedByWorkflowId(Int32)`

##### SuperOffice.CRM.Rows.TicketRows.IdxCreatedByWorkflowId is New

#### SuperOffice.CRM.Workflow.WorkflowUtil is Modified

* New items
  * Method `GetValueFromCriteria(Int32, Int32, String)`

#### SuperOffice.Data.SoPreference is Modified

* Deleted items
  * Method `SetPreference(String, String, String, Int32)`


### Assembly: SoLicense

## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.Database.WorkflowNotifySMSType`
* `SuperOffice.CD.DSL.Database.Steps_Mailing.Mailing_12_LocalLinks`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep22_FlowReferences`

### Modified Types

#### SuperOffice.CD.DSL.Database.T_Appointment is Modified

* New items
  * Field `CreatedByWorkflowId`

#### SuperOffice.CD.DSL.Database.T_Person is Modified

* New items
  * Field `CreatedByFormId`
  * Field `ModifiedByWorkflowId`
  * Field `ModifiedByWorkflowWhen`

#### SuperOffice.CD.DSL.Database.T_Sale is Modified

* New items
  * Field `CreatedByWorkflowId`

#### SuperOffice.CD.DSL.Database.T_SLink is Modified

* New items
  * Field `LocalLink`

#### SuperOffice.CD.DSL.Database.T_Ticket is Modified

* New items
  * Field `CreatedByWorkflowId`
