---
uid: version_10.3.5.599_changes
date: 4/30/2024
---

Changes from v10.3.4.448 and v10.3.5.599

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### Modified Types

#### SuperOffice.CRM.Services.FieldInfoBase is Modified

* New items
  * Property `IsDisplayField`

#### SuperOffice.CRM.Services.ITicketAgent is Modified

* New items
  * Method `CreateDefaultForTicketType(Int32)`
  * Method `GetDefaultMessageContentWithOptions(Int32, MessageActionType, Int32, Int32, Boolean)`

#### SuperOffice.CRM.Services.IWorkflowAgent is Modified

* New items
  * Method `UpdateFormSubmissions(Int32)`

#### SuperOffice.CRM.Services.PreviewDash is Modified

* New items
  * Property `DashboardId`

#### SuperOffice.CRM.Services.TicketAgent is Modified

* New items
  * Method `CreateDefaultForTicketType(Int32)`
  * Method `GetDefaultMessageContentWithOptions(Int32, MessageActionType, Int32, Int32, Boolean)`

#### SuperOffice.CRM.Services.TicketType is Modified

* New items
  * Property `VisibleForGroups`

#### SuperOffice.CRM.Services.TicketTypeEntity is Modified

* New items
  * Property `VisibleForGroups`

#### SuperOffice.CRM.Services.WorkflowAgent is Modified

* New items
  * Method `UpdateFormSubmissions(Int32)`

#### SuperOffice.CRM.Services.WorkflowStepCreateSale is Modified

* New items
  * Property `Source`

#### SuperOffice.CRM.Services.WorkflowStepNotifyByEmail is Modified

* New items
  * Property `SpecificEmailAddresses`
  * Property `Subject`
  * Property `Text`
  * Property `To`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### New Types

* `SuperOffice.Data.WorkflowNotifyEmailType`
* `SuperOffice.IO.JsonSerializerOptionsFor`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.Constants is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.Constants.ExtraFieldAttrib is Modified

* New items
  * Field `.ExtraFieldAttribIcon`


##### SuperOffice.CRM.ArchiveLists.Constants.IconHints is Modified

* New items
  * Field `.IconHintsFlowContent`


#### SuperOffice.Data.ShipmentLinkType is Modified

* New items
  * Field `Consent`
  * Field `Unsubscribe`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_CONTEXT_MENU_DELETE`
  * Field `SR_CONTEXT_MENU_EDIT`
  * Field `SR_CONTEXT_MENU_HELP`
  * Field `SR_CONTEXT_MENU_NEW`
  * Field `SR_CONTEXT_MENU_OPEN`
  * Field `SR_CUSTOM_OBJECTS_CONFIRM_DELETE`
  * Field `SR_CUSTOM_OBJECTS_PREVIEW`
  * Field `SR_FLOW_SPECIFIC_ADDRESS`
  * Field `SR_FLOW_SPECIFIC_CONTACT`
  * Field `SR_FLOW_SPLIT_INFO`
  * Field `SR_WORKFLOWS_FLOWS_FLOWCONTENTS_CREATE_EMAIL`
  * Field `SR_WORKFLOWS_FLOWS_FLOWCONTENTS_EMAILS`
  * Field `SR_WORKFLOWS_FLOWS_FLOWCONTENTS_OTHER_CONTENT`

#### SuperOffice.IO.TextGenerator is Modified

* Modified items
  * Method `ParseLine(String)`
  * Method `ParseTag(String)`


### Assembly: SoDatabase

### New Types

* `SuperOffice.CRM.ArchiveLists.FormFieldsExtender`
* `SuperOffice.CRM.CustomObject.CustomObjectHelper`
* `SuperOffice.CRM.Data.FormFieldValueTableInfo`
* `SuperOffice.CRM.Entities.FormValueCalculator`
* `SuperOffice.CRM.Lists.CustomObjectRelationProvider`
* `SuperOffice.CRM.Rows.FormFieldValueRecordData`
* `SuperOffice.CRM.Rows.FormFieldValueRecordDataExtensions`
* `SuperOffice.CRM.Rows.FormFieldValueRow`
* `SuperOffice.CRM.Rows.FormFieldValueRows`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateFormFieldValueRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateFormFieldValueRowsFactory`
* `SuperOffice.CRM.Workflow.NotifyByEmailSettings`
* `SuperOffice.CRM.Workflow.WorkflowStepNotifyByEmail`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationAggregatorExtender is Modified

* New items
  * Method `IsSystemUserAssignment(SoDataReader)`

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationExtenderBase is Modified

* Deleted items
  * Field `IsSystemUserColumnName`
* New items
  * Field `IsSystemUserAssignmentColumnName`

#### SuperOffice.CRM.ArchiveLists.Archive.ContactPersonSelectionDynamicProviderV2 is Modified

* New items
  * Method `ContactPersonSelectionDynamicProviderV2(String)`

#### SuperOffice.CRM.ArchiveLists.Archive.DummySelectionContactProvider is Modified

* Deleted items
  * Method `DummySelectionContactProvider(Features)`
* New items
  * Method `DummySelectionContactProvider(Features, String)`
  * Method `DummySelectionContactProvider(String)`

#### SuperOffice.CRM.ArchiveLists.Archive.DynamicSelectionMultiCriteriaGroupBase is Modified

* New items
  * Method `DynamicSelectionMultiCriteriaGroupBase(String, String)`

#### SuperOffice.CRM.ArchiveLists.Archive.SelectionCombinedPersonExtenderBase is Modified

* New items
  * Method `SelectionCombinedPersonExtenderBase(Features, String)`

#### SuperOffice.CRM.ArchiveLists.Archive.SubContactPersonSelectionDynamicProviderSingleCriteriaGroup is Modified

* Deleted items
  * Method `SubContactPersonSelectionDynamicProviderSingleCriteriaGroup(Features)`
* New items
  * Method `SubContactPersonSelectionDynamicProviderSingleCriteriaGroup(Features, String)`
  * Method `SubContactPersonSelectionDynamicProviderSingleCriteriaGroup(String)`

#### SuperOffice.CRM.ArchiveLists.Archive.SubPersonContactSelectionDynamicProviderSingleCriteriaGroup is Modified

* Deleted items
  * Method `SubPersonContactSelectionDynamicProviderSingleCriteriaGroup(Features)`
* New items
  * Method `SubPersonContactSelectionDynamicProviderSingleCriteriaGroup(Features, String)`
  * Method `SubPersonContactSelectionDynamicProviderSingleCriteriaGroup(String)`

#### SuperOffice.CRM.ArchiveLists.CombinedPersonExtenderBase is Modified

* Deleted items
  * Method `CombinedPersonExtenderBase(Features)`
* New items
  * Method `CombinedPersonExtenderBase(Features, String)`
  * Method `CombinedPersonExtenderBase(String)`

#### SuperOffice.CRM.ArchiveLists.ContactPersonAsEntityExtenderBase is Modified

* Deleted items
  * Method `ContactPersonAsEntityExtenderBase(Features)`
* New items
  * Method `ContactPersonAsEntityExtenderBase(Features, String)`

#### SuperOffice.CRM.ArchiveLists.ContactWithPersonExtenderBase<PersonExtenderClass> is Modified

* New items
  * Method `ContactWithPersonExtenderBase(Features, String)`

#### SuperOffice.CRM.ArchiveLists.EmailFlowContentProvider is Modified

* New items
  * Field `ColContentType`
  * Field `ColRegisteredBy`
  * Field `ColRegisteredDate`

#### SuperOffice.CRM.ArchiveLists.ExtraFieldExtenderBase is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.ExtraFieldExtenderBase.RecursionInfo is Modified

* New items
  * Property `.RecursionInfoIcon`


#### SuperOffice.CRM.ArchiveLists.FormSubmissionExtenderBase is Modified

* Deleted items
  * Method `FormSubmissionExtenderBase(Features)`
* Modified items

##### SuperOffice.CRM.ArchiveLists.FormSubmissionExtenderBase.Features is Modified

* New items
  * Field `.FeaturesFormFields`

* New items
  * Method `FormSubmissionExtenderBase(Features, String)`
  * Method `GetFormTable()`

#### SuperOffice.CRM.ArchiveLists.MultiQueryProviderBaseWithRestrictionGroups is Modified

* New items
  * Method `MultiQueryProviderBaseWithRestrictionGroups(String, String)`

#### SuperOffice.CRM.ArchiveLists.PersonExtenderBase is Modified

* Deleted items
  * Method `Initialize(Features)`
* New items
  * Method `PersonExtenderBase(Features, String)`
  * Method `Initialize(Features, String)`

#### SuperOffice.CRM.ArchiveLists.PersonFormSubmissionExtender is Modified

* New items
  * Method `PersonFormSubmissionExtender(String)`

#### SuperOffice.CRM.ArchiveLists.SelectionCombinedContactPersonExtenderBase is Modified

* New items
  * Method `SelectionCombinedContactPersonExtenderBase(Features, String)`

#### SuperOffice.CRM.ArchiveLists.SelectionContactPersonExtender is Modified

* New items
  * Method `SelectionContactPersonExtender(String)`

#### SuperOffice.CRM.ArchiveLists.SelectionDynamicContactExtender is Modified

* New items
  * Method `SelectionDynamicContactExtender(Features, String)`

#### SuperOffice.CRM.Cache.ExtraFieldsCache is Modified

* Modified items
  * Method `GetDisplayField(Int32)`
  * Method `GetDisplayField(String)`

#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* New items
  * Property `LeftOuterJoin_FormFieldValue_RegisteredAssociateId`
  * Property `LeftOuterJoin_FormFieldValue_UpdatedAssociateId`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.TicketTypeFields is Modified

* New items
  * Field `.TicketTypeFieldsVisibleForGroups`

* New items
  * Field `FormFieldValue`

##### SuperOffice.CRM.Data.DBC.FormFieldValueFields is New

#### SuperOffice.CRM.Data.FormSubmissionTableInfo is Modified

* New items
  * Property `LeftOuterJoin_FormFieldValue_FormSubmissionId`

#### SuperOffice.CRM.Data.TicketTypeTableInfo is Modified

* New items
  * Property `VisibleForGroups`

#### SuperOffice.CRM.Entities.EntityExtraFieldsHelper is Modified

* New items
  * Method `GetExtraInfo(String, TableInfo, Object)`

#### SuperOffice.CRM.Lists.SoLists is Modified


#### SuperOffice.CRM.Lists.TicketTypeProvider is Modified

* New items
  * Field `Admin`
  * Field `InfoKey_OnlyForMenu`

#### SuperOffice.CRM.Lists.VisibleForAssociateMDOProvider is Modified

* New items
  * Method `FillList()`

#### SuperOffice.CRM.ListsHelper is Modified

* New items
  * Method `FilterDuplicateId(List<ISoListItem>)`

##### SuperOffice.CRM.ListsHelper.SoListItemDistinctIdComparer is New

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(WorkflowNotifyEmailType&, FieldInfo)`

#### SuperOffice.CRM.Rows.TicketTypeRecordData is Modified

* New items
  * Field `VisibleForGroups`

#### SuperOffice.CRM.Rows.TicketTypeRow is Modified

* New items
  * Property `VisibleForGroups`

#### SuperOffice.CRM.Rows.TicketTypeRows is Modified

* New items
  * Method `GetFromIdxVisibleForGroups(Int32[])`

##### SuperOffice.CRM.Rows.TicketTypeRows.IdxVisibleForGroups is New

#### SuperOffice.CRM.Ticket.TicketHelper is Modified

* Deleted items
  * Method `GetTicketSecurityLevelBasedOnPreferences()`
* New items
  * Method `GetTicketSecurityLevel(Int32)`

#### SuperOffice.CRM.Workflow.CreateSaleSettings is Modified

* New items
  * Property `Source`

#### SuperOffice.Data.SoDatabase is Modified

* Deleted items
  * Property `LogOutInProgress`

#### SuperOffice.Data.TablesInfo is Modified

* New items
  * Method `GetFormFieldValueTableInfo()`

#### SuperOffice.Util.AsyncListProviderWrapper is Modified


#### SuperOffice.Util.NSWinListProviderHelper is Modified



## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.Database.WorkflowNotifyEmailType`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_55_TicketTypeUserGroups`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep21_FormFields`
* `SuperOffice.CD.DSL.Database.T_FormFieldValue`

### Modified Types

#### SuperOffice.CD.Database.ShipmentLinkType is Modified

* New items
  * Field `Consent`
  * Field `Unsubscribe`

#### SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep16_WorkflowFunctionalRights is Modified

* Deleted items
  * Method `ImpFileNames()`

#### SuperOffice.CD.DSL.Database.T_TicketType is Modified

* New items
  * Field `VisibleForGroups`



