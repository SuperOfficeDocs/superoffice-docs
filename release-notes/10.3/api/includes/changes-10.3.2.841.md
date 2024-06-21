---
uid: version_10.3.2.841_changes
date: 2/26/2024
---

Changes from v10.3.1.759 and v10.3.2.841

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.WorkflowStepOptionFormData`

### Modified Types

#### SuperOffice.CRM.Services.AttachmentEntity is Modified

* New items
  * Property `IsSafeFileExtension`

#### SuperOffice.CRM.Services.SelectableMDOListItem is Modified

* New items
  * Method `GetFlattenedListFull(ICollection<SelectableMDOListItem>)`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### New Types

* `SuperOffice.CRM.Lists.ISelectableListItemDeep`
* `SuperOffice.CRM.Lists.SelectableListItemDeep`

### Modified Types

#### .IEnumerableExtensions is Modified

* New items
  * Method `IsNullOrEmpty<T>(IEnumerable<T>)`

#### SuperOffice.Configuration.ConfigFile is Modified

* Deleted items

##### SuperOffice.Configuration.ConfigFile.CRMScript2 is Deleted

##### SuperOffice.Configuration.ConfigFile.CRMScript2Section is Deleted
* New items

##### SuperOffice.Configuration.ConfigFile.SoJavaScript is New

##### SuperOffice.Configuration.ConfigFile.SoJavaScriptSection is New

#### SuperOffice.CRM.ArchiveLists.Constants is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.Constants.IconHints is Modified

* New items
  * Field `.IconHintsExtratable`
  * Field `.IconHintsFlows`
  * Field `.IconHintsMain`


##### SuperOffice.CRM.ArchiveLists.Constants.RestrictionTypes is Modified

* New items
  * Field `.RestrictionTypesStringOrPkListAny`


#### SuperOffice.Data.WorkflowSplitOptionType is Modified

* New items
  * Field `FormData`

#### SuperOffice.Factory.DatabaseInstanceContainer is Modified

* Deleted items
  * Field `TheLock`

#### SuperOffice.Factory.ServiceProviderFactory is Modified

* Deleted items
  * Method `ServiceProviderFactory(IServiceProvider)`
* New items
  * Method `ServiceProviderFactory(IServiceProvider, ILogger<ServiceProviderFactory>)`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_APPOINTMENT_ATTENDEES_LABEL`
  * Field `SR_APPOINTMENT_DELETE_FOLLOW_UPS`
  * Field `SR_APPOINTMENT_JOIN_VIDEO_BUTTON`
  * Field `SR_APPOINTMENT_NO_ATTENDEES_ACCEPTED`
  * Field `SR_APPOINTMENT_SEND_EMAIL_TO_ACCEPTED`
  * Field `SR_ARCHIVE_UNSAFEFILE_WARNING`
  * Field `SR_DASHBOARD_COPY_TILE_MESSAGE`
  * Field `SR_DASHTILE_REQ_CREATED_THIS_MONTH`
  * Field `SR_DASHTILE_REQ_REQUESTS_BY_CATEGORY`
  * Field `SR_DOWNLOAD_UNSAFEFILE_WARNING`
  * Field `SR_FLOW_EMAIL_CONTENT`
  * Field `SR_FLOW_SPLIT_EVERYONEELSE_NOTSUBMITTED`
  * Field `SR_FLOW_SPLIT_FORMDATA`
  * Field `SR_FLOW_TRIGGER_ALLREQUESTCREATED`
  * Field `SR_FORMS_ACTIONS_DEFINE_IN_FLOW`
  * Field `SR_INVALID_PHONE_LINK_FORMAT`
  * Field `SR_NOTIFY_SHOW_DECLINED`
  * Field `SR_TICKETARCHIVE_LANGUAGE`
  * Field `SR_TICKETARCHIVE_LANGUAGE_TOOLTIP`
  * Field `SR_TICKETARCHIVE_SENTIMENT`
  * Field `SR_TICKETARCHIVE_SENTIMENT_TOOLTIP`
  * Field `SR_TICKETARCHIVE_SUGGESTED_CATEGORY`
  * Field `SR_TICKETARCHIVE_SUGGESTED_CATEGORY_TOOLTIP`
  * Field `SR_TYPE_A_MESSAGE`
  * Field `SR_WORKFLOWS_BRANCH_NOTEMPTY`
  * Field `SR_WORKFLOWS_DROP_HERE`
  * Field `SR_WORKFLOWS_EXPAND_FLOW`
  * Field `SR_WORKFLOWS_USE_THIS_EMAIL`


### Assembly: SoDatabase

### Deleted Types

* `SuperOffice.CRM.ArchiveLists.EmailFlowInstanceContactExtender`
* `SuperOffice.CRM.ArchiveLists.EmailFlowInstanceEmailFlowExtender`
* `SuperOffice.CRM.ArchiveLists.EmailFlowInstanceExtenderBase`
* `SuperOffice.CRM.ArchiveLists.EmailFlowInstancePersonExtender`

### New Types

* `SuperOffice.CRM.ArchiveLists.ContactProvider`
* `SuperOffice.CRM.ArchiveLists.DynamicTicketExtender`
* `SuperOffice.CRM.ArchiveLists.PersonWorkflowInstanceExtender`
* `SuperOffice.CRM.ArchiveLists.WorkflowInstanceContactExtender`
* `SuperOffice.CRM.ArchiveLists.WorkflowInstanceEmailFlowExtender`
* `SuperOffice.CRM.ArchiveLists.WorkflowInstanceExtenderBase`
* `SuperOffice.CRM.ArchiveLists.WorkflowInstancePersonExtender`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationExtenderBase is Modified

* New items
  * Field `IsFreeColumnName`

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationProvider is Modified

* New items
  * Field `C_APPOINTMENT_HIDDEN_ENTITY_NAME`

#### SuperOffice.CRM.ArchiveLists.EmailFlowExtenderBase is Modified

* New items
  * Method `EmailFlowExtenderBase(Features)`

##### SuperOffice.CRM.ArchiveLists.EmailFlowExtenderBase.Features is New

#### SuperOffice.CRM.ArchiveLists.EmailFlowWorkflowExtender is Modified

* New items
  * Method `EmailFlowWorkflowExtender(Features)`

#### SuperOffice.CRM.ArchiveLists.ExtraFieldExtenderBase is Modified

* Deleted items
  * Method `ExtraFieldExtenderBase(HashSet<String>)`
* New items
  * Method `ExtraFieldExtenderBase(RecursionInfo)`

##### SuperOffice.CRM.ArchiveLists.ExtraFieldExtenderBase.RecursionInfo is New

#### SuperOffice.CRM.ArchiveLists.ExtraFieldsExtraTableExtender is Modified

* Deleted items
  * Method `ExtraFieldsExtraTableExtender(SoField, String, HashSet<String>, Boolean)`
* New items
  * Method `ExtraFieldsExtraTableExtender(SoField, String, RecursionInfo)`
  * Method `ExtraFieldsExtraTableExtender(SoField, String, RecursionInfo, Boolean)`

#### SuperOffice.CRM.ArchiveLists.ExtraTableProvider is Modified

* New items
  * Method `GetEntityName(SoDataReader)`

#### SuperOffice.CRM.ArchiveLists.Joiners.ExtraTableExtraFieldExtender is Modified

* Deleted items
  * Method `ExtraTableExtraFieldExtender(String, HashSet<String>)`
* New items
  * Method `ExtraTableExtraFieldExtender(String)`

#### SuperOffice.CRM.ArchiveLists.RestrictionOperations is Modified

* New items
  * Field `PkIsNotOneOf`
  * Field `PkIsOneOf`

#### SuperOffice.CRM.ArchiveLists.TicketExtenderBase is Modified

* Deleted items
  * Method `GetAvailableColumns()`
* New items
  * Property `CategoryFullName`
  * Property `Origin`
  * Property `PriorityName`
  * Property `ReadStatus`
  * Property `SLevel`
  * Property `TicketStatus`
  * Property `TicketStatusName`
  * Property `TicketType`

#### SuperOffice.CRM.ArchiveLists.WorkflowExtenderBase is Modified

* Modified items
  * Method `WorkflowExtenderBase()`
* New items
  * Method `WorkflowExtenderBase(Features)`

##### SuperOffice.CRM.ArchiveLists.WorkflowExtenderBase.Features is New

#### SuperOffice.CRM.Cache.ExtraFieldsCache is Modified

* New items
  * Method `GetDisplayField(Int32)`

#### SuperOffice.CRM.Data.FreeTextIndexTableInfo is Modified

* New items
  * Method `IdxOwnerrecordId(Int32)`
  * Method `IdxOwnerrecordIdOwnertableId(Int32, Int16)`

#### SuperOffice.CRM.Lists.ArchiveColumnsProviderBase is Modified


#### SuperOffice.CRM.Lists.ExtraTableDropdownProvider is Modified


#### SuperOffice.CRM.Lists.MergeTagsProvider is Modified


#### SuperOffice.CRM.Rows.FreeTextIndexRows is Modified

* New items
  * Method `GetFromIdxOwnerrecordId(Int32)`
  * Method `GetFromIdxOwnerrecordIdOwnertableId(Int32, Int16)`
  * Method `GetFromIdxOwnerrecordIdOwnertableIdFreetextwordsId(Int32, Int16, Int32)`

##### SuperOffice.CRM.Rows.FreeTextIndexRows.IdxOwnerrecordId is New

##### SuperOffice.CRM.Rows.FreeTextIndexRows.IdxOwnerrecordIdOwnertableId is New

##### SuperOffice.CRM.Rows.FreeTextIndexRows.IdxOwnerrecordIdOwnertableIdFreetextwordsId is New

#### SuperOffice.Data.Dictionary.SoField is Modified

* New items
  * Property `ViewInSearch`

#### SuperOffice.Data.SoDatabase is Modified

* Modified items
  * Method `SoDatabase()`


## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.DSL.Database.Steps_FollowUpDialog.FollowUpDialog_04_Add_Sentry_To_Html_Text`
* `SuperOffice.CD.DSL.Database.Steps_Workflows.WorkflowStep16_WorkflowFunctionalRights`

### Modified Types

#### SuperOffice.CD.Database.WorkflowSplitOptionType is Modified

* New items
  * Field `FormData`



