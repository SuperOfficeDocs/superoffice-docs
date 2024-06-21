---
uid: version_10.3.4.448_changes
date: 4/2/2024
---

Changes from v10.3.3.610 and v10.3.4.448

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.AttachmentPreview`

### Modified Types

#### SuperOffice.CRM.Services.ITicketAgent is Modified

* New items
  * Method `GetAttachmentPreview(Int32)`
  * Method `GetRfcAttachmentStream(Int32, Int32)`
  * Method `SanitizeMailContentWithOptions(String, HtmlSanitizerOptions)`

#### SuperOffice.CRM.Services.TicketAgent is Modified

* New items
  * Method `GetAttachmentPreview(Int32)`
  * Method `GetRfcAttachmentStream(Int32, Int32)`
  * Method `SanitizeMailContentWithOptions(String, HtmlSanitizerOptions)`

#### SuperOffice.CRM.Services.TicketType is Modified

* New items
  * Property `ExcludeEmailRecipients`
  * Property `ExcludeSignature`
  * Property `ExternalAsDefault`
  * Property `ShowInNew`

#### SuperOffice.CRM.Services.TicketTypeEntity is Modified

* New items
  * Property `ExcludeEmailRecipients`
  * Property `ExcludeSignature`
  * Property `ExternalAsDefault`
  * Property `ShowInNew`

#### SuperOffice.CRM.Services.WorkflowStepUpdateParticipant is Modified

* New items
  * Property `Description`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### New Types

* `SuperOffice.Data.HtmlSanitizerOptions`
* `SuperOffice.Util.JsonPairSerializer<T1, T2>`

### Modified Types

#### .IEnumerableExtensions is Modified

* Modified items
  * Method `PermissiveToDictionary<T, K, V>(IEnumerable<T>, Func<T, K>, Func<T, V>)`
  * Method `PermissiveToDictionary<T, K, V>(IEnumerable<T>, Func<T, K>, Func<T, V>, IEqualityComparer<K>)`
* New items
  * Method `ToDictionaryPermissive<TSource, TKey>(ICollection<TSource>, Func<TSource, TKey>)`
  * Method `ToDictionaryPermissive<TSource, TKey>(ICollection<TSource>, Func<TSource, TKey>, IEqualityComparer<TKey>)`
  * Method `ToDictionaryPermissive<TSource, TKey, TElement>(ICollection<TSource>, Func<TSource, TKey>, Func<TSource, TElement>)`
  * Method `ToDictionaryPermissive<TSource, TKey, TElement>(ICollection<TSource>, Func<TSource, TKey>, Func<TSource, TElement>, IEqualityComparer<TKey>)`
  * Method `ToDictionaryPermissive<TSource, TKey>(IEnumerable<TSource>, Func<TSource, TKey>)`
  * Method `ToDictionaryPermissive<TSource, TKey>(IEnumerable<TSource>, Func<TSource, TKey>, IEqualityComparer<TKey>)`
  * Method `ToDictionaryPermissive<TSource, TKey, TElement>(IEnumerable<TSource>, Func<TSource, TKey>, Func<TSource, TElement>)`
  * Method `ToDictionaryPermissive<TSource, TKey, TElement>(IEnumerable<TSource>, Func<TSource, TKey>, Func<TSource, TElement>, IEqualityComparer<TKey>)`
  * Method `ToDictionaryPermissive<TSource, TKey>(TSource[], Func<TSource, TKey>)`
  * Method `ToDictionaryPermissive<TSource, TKey>(TSource[], Func<TSource, TKey>, IEqualityComparer<TKey>)`
  * Method `ToDictionaryPermissive<TSource, TKey, TElement>(TSource[], Func<TSource, TKey>, Func<TSource, TElement>)`
  * Method `ToDictionaryPermissive<TSource, TKey, TElement>(TSource[], Func<TSource, TKey>, Func<TSource, TElement>, IEqualityComparer<TKey>)`

#### SuperOffice.CRM.ArchiveLists.Constants is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.Constants.IconHints is Modified

* New items
  * Field `.IconHintsFlowsparticipants`


#### SuperOffice.Data.BlobLinkType is Modified

* New items
  * Field `ExtraTableIcon`

#### SuperOffice.Globalization.RC is Modified

* Deleted items
  * Field `SR_NO_SELECTION_COPY_HEL`
  * Field `SR_NO_SELECTION_COPY_HEL2`
  * Field `SR_NO_SELECTION_COPY_HEL3`
* New items
  * Field `SR_ADMIN_TICKETTYPE_NEW_REQUEST_SETTINGS`
  * Field `SR_ADMIN_TICKETTYPE_NEW_REQUEST_SETTINGS_EXCLUDE_EMAIL_RECIPIENTS`
  * Field `SR_ADMIN_TICKETTYPE_NEW_REQUEST_SETTINGS_EXCLUDE_SIGNATURE`
  * Field `SR_ADMIN_TICKETTYPE_NEW_REQUEST_SETTINGS_EXTERNAL_DEFAULT`
  * Field `SR_ADMIN_TICKETTYPE_NEW_REQUEST_SETTINGS_RB_NO`
  * Field `SR_ADMIN_TICKETTYPE_NEW_REQUEST_SETTINGS_RB_YES`
  * Field `SR_ADMIN_TICKETTYPE_SHOW_IN_NEW`
  * Field `SR_EMAIL_NOT_CONFIGURED_MESSAGE`
  * Field `SR_FLOW_REMOVE_STEP`
  * Field `SR_FORMS_FIELD_DATETIME`
  * Field `SR_WORKFLOWS_LINK_IS_ASSET_WARNING`
  * Field `SR_WORKFLOWSTEPTYPE_FINISH`

#### SuperOffice.Util.CollectionOps is Modified

* Modified items
  * Method `AtLeastOne<T>(IEnumerable<T>)`
  * Method `ConvertArray<SourceType, ReturnType>(SourceType[], ConvertType<SourceType, ReturnType>, Predicate<SourceType>)`
  * Method `ConvertArray<SourceType, ReturnType>(ICollection<SourceType>, ConvertType<SourceType, ReturnType>, Predicate<SourceType>)`
  * Method `ConvertToStringArray<SourceType>(SourceType[])`
  * Method `ConvertToStringArray<SourceType>(ICollection<SourceType>)`
  * Method `CreateDictionaryFromArray<KeyType, ValueType>(ValueType[], GetKeyFromValueItem<KeyType, ValueType>)`
  * Method `CreateDictionaryFromArray<KeyType, ValueType>(ValueType[], GetKeyFromValueItem<KeyType, ValueType>, IEqualityComparer<KeyType>)`
  * Method `CreateDictionaryFromArray<KeyType, ValueType>(ValueType[], GetKeyFromValueItem<KeyType, ValueType>, IEqualityComparer<KeyType>, Predicate<ValueType>)`
  * Method `CreateDictionaryFromArray<KeyType, ValueType>(ValueType[], GetKeyFromValueItem<KeyType, ValueType>, Predicate<ValueType>)`
  * Method `CreateDictionaryFromCollection<KeyType, ValueType>(ICollection<ValueType>, GetKeyFromValueItem<KeyType, ValueType>)`
  * Method `CreateDictionaryFromCollection<KeyType, ValueType>(ICollection<ValueType>, GetKeyFromValueItem<KeyType, ValueType>, IEqualityComparer<KeyType>)`
  * Method `CreateDictionaryFromCollection<KeyType, ValueType>(ICollection<ValueType>, GetKeyFromValueItem<KeyType, ValueType>, IEqualityComparer<KeyType>, Predicate<ValueType>)`
  * Method `CreateDictionaryFromCollection<KeyType, ValueType>(ICollection<ValueType>, GetKeyFromValueItem<KeyType, ValueType>, Predicate<ValueType>)`
  * Method `CreateDictionaryFromEnumerable<KeyType, ValueType>(IEnumerable<ValueType>, GetKeyFromValueItem<KeyType, ValueType>)`
  * Method `CreateDictionaryFromEnumerable<KeyType, ValueType>(IEnumerable<ValueType>, GetKeyFromValueItem<KeyType, ValueType>, IEqualityComparer<KeyType>)`
  * Method `CreateDictionaryFromEnumerable<KeyType, ValueType>(IEnumerable<ValueType>, GetKeyFromValueItem<KeyType, ValueType>, IEqualityComparer<KeyType>, Predicate<ValueType>)`
  * Method `CreateDictionaryFromEnumerable<KeyType, ValueType>(IEnumerable<ValueType>, GetKeyFromValueItem<KeyType, ValueType>, Predicate<ValueType>)`

##### SuperOffice.Util.CollectionOps.GetKeyFromValueItem<KeyType, ValueType> is Modified




### Assembly: SoDatabase

### New Types

* `SuperOffice.CRM.ArchiveLists.Archive.ExtraTableSelectionCombinedProviderV2`
* `SuperOffice.CRM.ArchiveLists.Archive.ExtraTableSelectionDynamicProviderSingleCriteriaGroup`
* `SuperOffice.CRM.ArchiveLists.Archive.ExtraTableSelectionDynamicProviderV2`
* `SuperOffice.CRM.ArchiveLists.Archive.ExtraTableSelectionProviderBaseV2`
* `SuperOffice.CRM.ArchiveLists.Archive.ExtraTableSelectionProviderV2`
* `SuperOffice.CRM.ArchiveLists.Archive.ExtraTableSelectionStaticProviderV2`
* `SuperOffice.CRM.ArchiveLists.ExtraTableProviderBase`
* `SuperOffice.CRM.ArchiveLists.PersonChatSessionExtender`
* `SuperOffice.CRM.ArchiveLists.PersonSaleExtender`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.AppointmentNotificationExtenderBase is Modified

* New items
  * Field `IsSystemUserColumnName`

#### SuperOffice.CRM.ArchiveLists.Archive.ContactPersonSelectionDynamicProviderSingleCriteriaGroup is Modified

* New items
  * Property `ForcePersonMode`

#### SuperOffice.CRM.ArchiveLists.Archive.ContactPersonSelectionDynamicProviderV2 is Modified

* New items
  * Method `ForcePersonMode(Boolean)`

#### SuperOffice.CRM.ArchiveLists.Archive.DynamicSelectionMultiCriteriaGroupBase is Modified

* Modified items
  * Method `DynamicSelectionMultiCriteriaGroupBase()`
* New items
  * Method `DynamicSelectionMultiCriteriaGroupBase(String)`

#### SuperOffice.CRM.ArchiveLists.ChatSessionExtenderBase is Modified

* New items
  * Method `ChatSessionExtenderBase(Features)`

##### SuperOffice.CRM.ArchiveLists.ChatSessionExtenderBase.Features is New

#### SuperOffice.CRM.ArchiveLists.EmailFlowContentProvider is Modified

* New items
  * Field `ColIcon`
  * Method `InnerPopulateRow(ArchiveRow)`

#### SuperOffice.CRM.ArchiveLists.ExtraTableProvider is Modified

* Deleted items
  * Property `PrimaryTable`
  * Property `Query`
  * Property `RootExtenders`
  * Method `GetEntityName(SoDataReader)`
  * Method `InnerPopulateRowFromReader(SoDataReader, ArchiveRow)`
  * Method `SetRestriction(ArchiveRestrictionInfo[])`

#### SuperOffice.CRM.ArchiveLists.MultiQueryProviderBaseWithRestrictionGroups is Modified

* New items
  * Method `MultiQueryProviderBaseWithRestrictionGroups(String)`

#### SuperOffice.CRM.Cache.ExtraFieldsCache is Modified

* New items
  * Method `GetDisplayField(String)`

#### SuperOffice.CRM.Data.BinaryObjectTableInfo is Modified

* New items
  * Property `LeftOuterJoin_ExtraTables_IconId`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.ExtraTablesFields is Modified

* New items
  * Field `.ExtraTablesFieldsIconId`


##### SuperOffice.CRM.Data.DBC.TicketTypeFields is Modified

* New items
  * Field `.TicketTypeFieldsExcludeEmailRecipients`
  * Field `.TicketTypeFieldsExcludeSignature`
  * Field `.TicketTypeFieldsExternalAsDefault`
  * Field `.TicketTypeFieldsShowInNew`


#### SuperOffice.CRM.Data.ExtraTablesTableInfo is Modified

* New items
  * Property `IconId`
  * Property `IconId_InnerJoin_BinaryObject`

#### SuperOffice.CRM.Data.TicketTypeTableInfo is Modified

* New items
  * Property `ExcludeEmailRecipients`
  * Property `ExcludeSignature`
  * Property `ExternalAsDefault`
  * Property `ShowInNew`

#### SuperOffice.CRM.Entities.Appointment is Modified

* New items
  * Method `VerifyToDoDates(TaskType)`

#### SuperOffice.CRM.Entities.RecurrenceManager is Modified

* New items
  * Method `ConvertDayOfWeekToWeekday(DayOfWeek)`

#### SuperOffice.CRM.Rows.ExtraTablesRecordData is Modified

* New items
  * Field `IconId`

#### SuperOffice.CRM.Rows.ExtraTablesRow is Modified

* New items
  * Property `IconId`

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(HtmlSanitizerOptions&, FieldInfo)`

#### SuperOffice.CRM.Rows.TicketTypeRecordData is Modified

* New items
  * Field `ExcludeEmailRecipients`
  * Field `ExcludeSignature`
  * Field `ExternalAsDefault`
  * Field `ShowInNew`

#### SuperOffice.CRM.Rows.TicketTypeRow is Modified

* New items
  * Property `ExcludeEmailRecipients`
  * Property `ExcludeSignature`
  * Property `ExternalAsDefault`
  * Property `ShowInNew`

#### SuperOffice.CRM.Workflow.UpdateParticipantSettings is Modified

* New items
  * Field `Description`

#### SuperOffice.CRM.WorkFlow.WorkflowEngine is Modified

* Deleted items
  * Method `BlockListApproved(Int32[], Int32[])`
  * Method `FilterOk(Int32, Int32[])`
  * Method `GoalReached(WorkflowInstanceRow)`
  * Method `TryAddPersonsToWorkFlow(Int32, Int32[])`

#### SuperOffice.CRM.Workflow.WorkflowStepBase is Modified

* Deleted items
  * Method `NextStepId(Int32, Int32)`

#### SuperOffice.CRM.Workflow.WorkflowUtil is Modified

* New items
  * Method `BlockListApproved(Int32[], Int32[])`
  * Method `FilterOk(Int32, Int32[])`
  * Method `GoalReached(Int32, Int32, Int32)`
  * Method `NextStepId(Int32, Int32)`
  * Method `TryAddPersonsToWorkFlow(Int32, Int32[])`

#### SuperOffice.Data.SQL.TargetedSelect<MainTableInfo> is Modified

* New items
  * Method `Count()`


## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.Database.HtmlSanitizerOptions`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_53_ExtraTablesIconId`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_54_TicketTypeNewColumns`

### Modified Types

#### SuperOffice.CD.Database.BlobLinkType is Modified

* New items
  * Field `ExtraTableIcon`

#### SuperOffice.CD.DSL.Database.T_ExtraTables is Modified

* New items
  * Field `IconId`

#### SuperOffice.CD.DSL.Database.T_TicketType is Modified

* New items
  * Field `ExcludeEmailRecipients`
  * Field `ExcludeSignature`
  * Field `ExternalAsDefault`
  * Field `ShowInNew`
