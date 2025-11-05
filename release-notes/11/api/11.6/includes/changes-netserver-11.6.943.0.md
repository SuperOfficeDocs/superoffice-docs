---
uid: version_11.6.943.0_changes
date: 05.11.2025
---

Changes from v11.5.755 and v11.6.943.0

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.ContactPersonBoardViewSettings`

### Modified Types

#### SuperOffice.CRM.Services.IBLOBAgent is Modified

* New items
  * Method `GetRawPersonImageAsync(Int32, CancellationToken)`


### Assembly: SuperOffice.Services.Implementation

### Modified Types

#### SuperOffice.CRM.Services.BLOBAgent is Modified

* New items
  * Method `GetRawPersonImageAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IBlobEntityImplementation is Modified

* New items
  * Method `GetRawPersonImageAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.CustomObjectMetadata is Modified

* New items
  * Property `FlagHidden`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### New Types

* `SuperOffice.Data.ContactPersonBoardEntity`
* `SuperOffice.Data.ExternalOwner`

### Modified Types

#### SuperOffice.Configuration.VersionPropertyNames is Modified

* New items
  * Field `CollectSoConnectionParamsForRequest`

#### SuperOffice.Data.BoardViewEntityType is Modified

* New items
  * Field `ContactPerson`

#### SuperOffice.Data.RagType is Modified

* New items
  * Field `Website`

#### SuperOffice.Diagnostics.ServiceCallsDiagnosticSnapshot is Modified

* Modified items
  * Method `FormatArgument(Object)`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_ADMIN_LC_ASKFOR_CONFIRMATION`
  * Field `SR_ADMIN_LC_INFO`
  * Field `SR_ADMIN_LC_INFO_HEADER`
  * Field `SR_ADMIN_LC_LABEL`
  * Field `SR_ADMIN_LC_SET_CATEGORY_TO`
  * Field `SR_ADMIN_LC_UPDATE_COMPANY_SALE`
  * Field `SR_ADMIN_LC_UPDATE_LEADSTATUS`
  * Field `SR_ADMIN_LC_UPDATE_SALE_LOST`
  * Field `SR_ADMIN_LC_UPDATE_SALE_SOLD`
  * Field `SR_ARCHIVE_SALE_STAGE_WHEN_CLOSED_TOOLTIP`
  * Field `SR_BOARD_CANNOT_MOVE_PERSON`
  * Field `SR_BOARD_CONTACT_VIEW_ENTITY`
  * Field `SR_BOARD_INVALID_CONTACT_BUSINESS`
  * Field `SR_BOARD_INVALID_LEAD_STATUS`
  * Field `SR_BOARD_LANE_NO_BUSINESS_LINK`
  * Field `SR_BOARD_LANE_NO_CATEGORY_LINK`
  * Field `SR_BOARD_LANE_NO_LEADSTATUS_LINK`
  * Field `SR_CO_FINDCO_TOOLTIP`
  * Field `SR_DASHBOARD_FILTER_NEXT_MONTH`
  * Field `SR_DASHBOARD_FILTER_NEXT_QUARTER`
  * Field `SR_DASHBOARD_FILTER_NEXT_WEEK`
  * Field `SR_DASHBOARD_FILTER_NEXT_YEAR`
  * Field `SR_DASHBOARD_FILTER_PREV_MONTH`
  * Field `SR_DASHBOARD_FILTER_PREV_QUARTER`
  * Field `SR_DASHBOARD_FILTER_PREV_WEEK`
  * Field `SR_DASHBOARD_FILTER_PREV_YEAR`
  * Field `SR_DASHBOARD_FILTER_THIS_QUARTER`
  * Field `SR_DASHBOARD_FILTER_THIS_YEAR`
  * Field `SR_DASHBOARD_FILTER_YEAR_TO_DATE`
  * Field `SR_DASHBOARD_FILTER_YESTERDAY`
  * Field `SR_SEL_DELETE_ALL_RECORDS_YES_NO`
  * Field `SR_SELECTION_QUESTION_DELETE_NUMBEROF_RECORDS`
  * Field `SR_SELECTION_WARNING_PERMANENT_DELETE_RECORDS`


### Assembly: SoDatabase

### Deleted Types

* `SuperOffice.CRM.Security.SentryQueryBinaryObjectableUpdater`
* `SuperOffice.CRM.Webhooks.CrmScriptWebhookPlugin`

### New Types

* `SuperOffice.CRM.Data.ExternalOwnerTableInfo`
* `SuperOffice.CRM.Rows.ExternalOwnerRecordData`
* `SuperOffice.CRM.Rows.ExternalOwnerRecordDataExtensions`
* `SuperOffice.CRM.Rows.ExternalOwnerRow`
* `SuperOffice.CRM.Rows.ExternalOwnerRows`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateExternalOwnerRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateExternalOwnerRowsFactory`
* `SuperOffice.CRM.Security.DashboardTileDefinitionSentry`
* `SuperOffice.CRM.Security.DashboardTileDefinitionSentryQueryInfo`
* `SuperOffice.CRM.Security.SentryQueryDashboardTileDefinitionTableUpdater`
* `SuperOffice.Data.SQL.ExternalOwnerFieldInfo`

### Modified Types

#### SuperOffice.CRM.Administration.SoUser is Modified

* New items
  * Method `SaveAsync()`

#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* New items
  * Property `LeftOuterJoin_ExternalOwner_RegisteredAssociateId`
  * Property `LeftOuterJoin_ExternalOwner_UpdatedAssociateId`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.SaleFields is Modified

* New items
  * Field `.SaleFieldsStageWhenClosedId`


##### SuperOffice.CRM.Data.DBC.SaleHistFields is Modified

* New items
  * Field `.SaleHistFieldsStageWhenClosedId`

* New items
  * Field `ExternalOwner`

##### SuperOffice.CRM.Data.DBC.ExternalOwnerFields is New

#### SuperOffice.CRM.Data.ProbTableInfo is Modified

* New items
  * Property `LeftOuterJoin_Sale_StageWhenClosedId`
  * Property `LeftOuterJoin_SaleHist_StageWhenClosedId`

#### SuperOffice.CRM.Data.SaleHistTableInfo is Modified

* New items
  * Property `StageWhenClosedId`
  * Property `StageWhenClosedId_InnerJoin_Prob`

#### SuperOffice.CRM.Data.SaleTableInfo is Modified

* New items
  * Property `StageWhenClosedId`
  * Property `StageWhenClosedId_InnerJoin_Prob`

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(ContactPersonBoardEntity&, FieldInfo)`
  * Method `ValidateField(ExternalOwner&, FieldInfo)`

#### SuperOffice.CRM.Rows.SaleHistRecordData is Modified

* New items
  * Field `StageWhenClosedId`

#### SuperOffice.CRM.Rows.SaleHistRow is Modified

* New items
  * Property `StageWhenClosedId`

#### SuperOffice.CRM.Rows.SaleRecordData is Modified

* New items
  * Field `StageWhenClosedId`

#### SuperOffice.CRM.Rows.SaleRow is Modified

* New items
  * Property `StageWhenClosedId`
  * Event `OnStageWhenClosedIdChange`

#### SuperOffice.CRM.Security.DashboardSentry is Modified

* New items
  * Property `IsAdmin`
  * Method `GetRecordOwnershipIndex()`

#### SuperOffice.CRM.Security.DashboardTileSentry is Modified

* Deleted items
  * Property `IsDefaultTile`
  * Method `DashboardTileSentry(BinaryObjectTableInfo)`
  * Method `DashboardTileSentry(BinaryObjectTableInfo, ISoDataLookup)`
* Modified items
  * Property `MainTable`
* New items
  * Method `DashboardTileSentry(DashboardTileTableInfo)`
  * Method `DashboardTileSentry(DashboardTileTableInfo, ISoDataLookup)`

#### SuperOffice.CRM.Security.DashboardTileSentryQueryInfo is Modified

* Deleted items
  * Property `MemberTableInfo`
  * Property `PublishTableInfo`
  * Method `DashboardTileSentryQueryInfo(BinaryObjectTableInfo)`
* New items
  * Method `DashboardTileSentryQueryInfo(DashboardTileTableInfo)`

#### SuperOffice.CRM.Webhooks.IWebhookManager is Modified

* New items
  * Method `RecordResult(Webhook, WebhookResponse, CancellationToken)`

#### SuperOffice.Data.Dialect.Dialect is Modified

* Deleted items
  * Method `ToSqlFrom()`
* New items
  * Method `TableOptions(TableInfo, SqlType)`
  * Method `ToSqlFrom(SqlType)`

#### SuperOffice.Data.SQL.TableInfo is Modified

* New items
  * Property `UseNolockIfPossible`

#### SuperOffice.Data.TablesInfo is Modified

* New items
  * Method `GetExternalOwnerTableInfo()`

#### SuperOffice.License.ILicenseManager is Modified

* Deleted items
  * Method `LoadNewLicenseFromServerIfNeededAsync(CancellationToken)`
* New items
  * Method `LoadNewLicenseFromServerIfNeededAsync(String, CancellationToken)`

#### SuperOffice.License.LicenseManager is Modified

* Deleted items
  * Method `LoadNewLicenseFromServerIfNeededAsync(CancellationToken)`
* New items
  * Method `LoadNewLicenseFromServerIfNeededAsync(String, CancellationToken)`

#### SuperOffice.Security.Principal.SoCredentialsIdentityResolver is Modified

* Deleted items
  * Method `RenewSoCredentialsAsync(Int32, String, DateTime, CancellationToken)`
* New items
  * Method `RenewSoCredentialsAsync(Int32, String, DateTime, SoConnection, CancellationToken)`


### Assembly: SoDatabase.BusinessLogic

### New Types

* `SuperOffice.CRM.Webhooks.CrmScriptWebhookPlugin`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.ContactExtenderBase is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.ContactExtenderBase.Features is Modified

* New items
  * Field `.FeaturesUtmParameters`


#### SuperOffice.CRM.ArchiveLists.PersonExtenderBase is Modified


#### SuperOffice.CRM.ArchiveLists.SaleHistorySaleHistoryExtender is Modified


#### SuperOffice.CRM.BulkUpdate.BulkUpdateSystem is Modified

* Modified items

##### SuperOffice.CRM.BulkUpdate.BulkUpdateSystem.PersonFieldValueKeys is Modified

* New items
  * Field `.PersonFieldValueKeysLeadStatus`


#### SuperOffice.CRM.Lists.DashboardProvider is Modified


#### SuperOffice.CRM.Lists.ServiceAssociateMDOProvider is Modified

* Modified items
  * Method `GetHistoryCollectionAsync(CancellationToken)`

#### SuperOffice.CRM.Webhooks.WebhookManager is Modified

* Deleted items
  * Method `WebhookManager(IAsyncQueue<WebhookTaskInfo>, IAsyncQueue<DelayedItem<RetryWebhook>>, IAsyncQueue<ValueTuple<ICustomWebhookPlugin, Webhook, WebhookPayload>>, ISoRequestItemsAccessor, IServiceScopeFactory)`
* New items
  * Method `WebhookManager(IAsyncQueue<WebhookTaskInfo>, IAsyncQueue<DelayedItem<RetryWebhook>>, IAsyncQueue<ValueTuple<ICustomWebhookPlugin, Webhook, WebhookPayload>>, ISoRequestItemsAccessor, IServiceScopeFactory, IServiceProvider)`
  * Method `GetSlowQueueLength()`
  * Method `RecordResult(Webhook, WebhookResponse, CancellationToken)`

#### SuperOffice.CRM.Webhooks.WebhookSlowDispatcher is Modified

* New items
  * Method `WaitForAllToComplete(CancellationToken)`

#### SuperOffice.Data.Dialect.SqlServerCommon is Modified

* New items
  * Method `TableOptions(TableInfo, SqlType)`

#### SuperOffice.Security.Principal.OidcSoIdentityResolver is Modified

* New items
  * Method `UpdateAssociateNameAndLastUsed(SoConnection, Int32, String)`

#### SuperOffice.Util.RagAIHelper is Modified



## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.Database.ContactPersonBoardEntity`
* `SuperOffice.CD.Database.ExternalOwner`
* `SuperOffice.CD.DSL.Database.ExternalOwnerStep1`
* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_129_ClearServiceAssociateHistory`
* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_130_Sale_StageWhenClosed`
* `SuperOffice.CD.DSL.Database.Steps_UserPreference.UserPreference_04_NotifyFields_Migration`
* `SuperOffice.CD.DSL.Database.T_ExternalOwner`

### Modified Types

#### SuperOffice.CD.Database.BoardViewEntityType is Modified

* New items
  * Field `ContactPerson`

#### SuperOffice.CD.Database.RagType is Modified

* New items
  * Field `Website`

#### SuperOffice.CD.DSL.Database.T_Sale is Modified

* New items
  * Field `StageWhenClosedId`

#### SuperOffice.CD.DSL.Database.T_SaleHist is Modified

* New items
  * Field `StageWhenClosedId`



