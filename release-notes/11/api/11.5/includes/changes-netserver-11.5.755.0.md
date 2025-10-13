---
uid: version_11.5.755.0_changes
date: 13.10.2025
---

Changes from v11.4.1157 and v11.5.755.0

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.QuickFilterInfo`

### Modified Types

#### SuperOffice.CRM.Services.IBLOBAgent is Modified

* New items
  * Method `GetChatImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetContactImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetContactImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetPersonImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetPersonImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetProductImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetProductThumbnailAsStreamAsync(Int32, CancellationToken)`
  * Method `GetProjectImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetProjectImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetQuoteLineImageAsStreamAsync(Int32, CancellationToken)`
  * Method `SaveImageStreamFromStreamAsync(BlobLinkType, Stream, String, CancellationToken)`
  * Method `SaveProjectImageFromStreamAsync(String, Stream, CancellationToken)`
  * Method `SetContactImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetPersonImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetProductImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetProductThumbnailFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetProjectImageFromStreamAsync(Int32, Stream, CancellationToken)`

#### SuperOffice.CRM.Services.IDashAgent is Modified

* New items
  * Method `GetDashQuickFiltersAsync(Int32, CancellationToken)`
  * Method `GetPossibleDashQuickFiltersAsync(Int32, CancellationToken)`
  * Method `SaveDashQuickFiltersAsync(Int32, QuickFilterInfo[], CancellationToken)`

#### SuperOffice.CRM.Services.SaleBoardViewSettings is Modified

* New items
  * Property `BadgeType`

### Assembly: SuperOffice.Services.Implementation

### Modified Types

#### SuperOffice.CRM.Services.BLOBAgent is Modified

* New items
  * Method `GetChatImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetContactImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetContactImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetPersonImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetPersonImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetProductImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetProductThumbnailAsStreamAsync(Int32, CancellationToken)`
  * Method `GetProjectImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetProjectImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetQuoteLineImageAsStreamAsync(Int32, CancellationToken)`
  * Method `SaveImageStreamFromStreamAsync(BlobLinkType, Stream, String, CancellationToken)`
  * Method `SaveProjectImageFromStreamAsync(String, Stream, CancellationToken)`
  * Method `SetContactImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetPersonImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetProductImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetProductThumbnailFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetProjectImageFromStreamAsync(Int32, Stream, CancellationToken)`

#### SuperOffice.CRM.Services.DashAgent is Modified

* New items
  * Method `GetDashQuickFiltersAsync(Int32, CancellationToken)`
  * Method `GetPossibleDashQuickFiltersAsync(Int32, CancellationToken)`
  * Method `SaveDashQuickFiltersAsync(Int32, QuickFilterInfo[], CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IBlobEntityImplementation is Modified

* New items
  * Method `GetChatImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetContactImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetContactImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetPersonImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetPersonImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetProductImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetProductThumbnailAsStreamAsync(Int32, CancellationToken)`
  * Method `GetProjectImageAsStreamAsync(Int32, CancellationToken)`
  * Method `GetProjectImageWithSizeAsStreamAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `GetQuoteLineImageAsStreamAsync(Int32, CancellationToken)`
  * Method `SaveImageStreamFromStreamAsync(BlobLinkType, Stream, String, CancellationToken)`
  * Method `SaveProjectImageFromStreamAsync(String, Stream, CancellationToken)`
  * Method `SetContactImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetPersonImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetProductImageFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetProductThumbnailFromStreamAsync(Int32, Stream, CancellationToken)`
  * Method `SetProjectImageFromStreamAsync(Int32, Stream, CancellationToken)`

#### SuperOffice.CRM.Services.Implementation.BL.Contracts.IDashImplementation is Modified

* New items
  * Method `GetDashQuickFiltersAsync(Int32, CancellationToken)`
  * Method `GetPossibleDashQuickFiltersAsync(Int32, CancellationToken)`
  * Method `SaveDashQuickFiltersAsync(Int32, QuickFilterInfo[], CancellationToken)`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### New Types

* `SuperOffice.Data.BoardViewBadgeType`
* `SuperOffice.Data.TimeKeepingType`
* `SuperOffice.Util.ImageStreamUtils`

### Modified Types

#### SuperOffice.Data.RagType is Modified

* Deleted items
  * Field `Website`

#### SuperOffice.Globalization.RC is Modified

* Deleted items
  * Field `SR_PD_Mail_PreferredEmailConnection_DESC`
  * Field `SR_PD_Mail_PreferredEmailConnection_NAME`
  * Field `SR_PDL_Mail_PreferredEmailConnection_1`
  * Field `SR_PDL_Mail_PreferredEmailConnection_2`
* New items
  * Field `SR_ARCHIVE_SALE_DAYS_IN_STAGE`
  * Field `SR_ARCHIVE_SALE_DAYS_IN_STAGE_TOOLTIP`
  * Field `SR_BOARD_BADGE_REGISTERED`
  * Field `SR_BOARD_FILTER_PERSON`
  * Field `SR_BOARD_PERSON_SETTINGS`
  * Field `SR_BOARD_SALE_DATE_BADGE`
  * Field `SR_BOARD_SALE_DATE_BADGE_STAGE`
  * Field `SR_BULKUPDATE_TICKET_TYPE_WARNING`
  * Field `SR_DASHBOARD_ACTIVE_QUICK_FILTER_TOOLTIP`
  * Field `SR_DASHBOARD_EDIT_FUNNEL_LABEL_INSIDE`
  * Field `SR_DASHBOARD_EDIT_FUNNEL_LABEL_OUTSIDE`
  * Field `SR_DASHBOARD_EDIT_FUNNEL_WIDTH`
  * Field `SR_DASHBOARD_ISONEOF`
  * Field `SR_DASHBOARD_QUICK_FILTER_DESCRIPTION`
  * Field `SR_DASHTILE_LEAD_BY_CREATION_CAMPAIGN_YTD`
  * Field `SR_DASHTILE_LEAD_BY_CREATION_SOURCE_YTD`
  * Field `SR_DASHTILE_LEAD_BY_FIRST_SOURCE_YTD`
  * Field `SR_DASHTILE_LEAD_QUALIFICATION_FUNNEL`
  * Field `SR_DASHTILE_LEAD_TOP_PERFORMING_FORMS_YTD`
  * Field `SR_DASHTILE_LEAD_TOP_REFERRING_SITES_YTD`
  * Field `SR_DASHTILE_PRO_ACTIVE_PROJECTS_FOR_MY_TEAM_FUNNEL`
  * Field `SR_DASHTILE_SAL_MY_FORECAST_THIS_QUARTER`
  * Field `SR_FORMS_ADD_UTM_TRACKING`
  * Field `SR_FORMS_ADD_UTM_TRACKING_DESC`
  * Field `SR_FORMS_BUTTON_STYLE`
  * Field `SR_FORMS_MAILING_DATA`
  * Field `SR_FORMS_PRE_POPULATE`
  * Field `SR_FORMS_SELECT_PRE_FIELDS`
  * Field `SR_FORMS_UTM_CAMPAIGN_HELP`
  * Field `SR_FORMS_UTM_CONTENT_HELP`
  * Field `SR_FORMS_UTM_MEDIUM_HELP`
  * Field `SR_FORMS_UTM_SOURCE_HELP`
  * Field `SR_FORMS_UTM_TERM_HELP`
  * Field `SR_PD_Mail_ShowMyEmails_DESC`
  * Field `SR_PD_Mail_ShowMyEmails_NAME`

### Assembly: SoDatabase

### New Types

* `SuperOffice.CRM.Data.QuickFilterInfoTableInfo`
* `SuperOffice.CRM.Data.TimeKeepingTableInfo`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateQuickFilterInfoRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateQuickFilterInfoRowsFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTimeKeepingRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateTimeKeepingRowsFactory`
* `SuperOffice.CRM.Rows.QuickFilterInfoRecordData`
* `SuperOffice.CRM.Rows.QuickFilterInfoRecordDataExtensions`
* `SuperOffice.CRM.Rows.QuickFilterInfoRow`
* `SuperOffice.CRM.Rows.QuickFilterInfoRows`
* `SuperOffice.CRM.Rows.TimeKeepingRecordData`
* `SuperOffice.CRM.Rows.TimeKeepingRecordDataExtensions`
* `SuperOffice.CRM.Rows.TimeKeepingRow`
* `SuperOffice.CRM.Rows.TimeKeepingRows`
* `SuperOffice.CRM.Sale.SaleHelper`
* `SuperOffice.Data.SQL.TimeKeepingTypeFieldInfo`

### Modified Types

#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* New items
  * Property `LeftOuterJoin_QuickFilterInfo_RegisteredAssociateId`
  * Property `LeftOuterJoin_QuickFilterInfo_UpdatedAssociateId`
  * Property `LeftOuterJoin_TimeKeeping_RegisteredAssociateId`
  * Property `LeftOuterJoin_TimeKeeping_UpdatedAssociateId`

#### SuperOffice.CRM.Data.DashboardTableInfo is Modified

* New items
  * Property `LeftOuterJoin_QuickFilterInfo_DashboardId`

#### SuperOffice.CRM.Data.DBC is Modified

* New items
  * Field `QuickFilterInfo`
  * Field `TimeKeeping`

##### SuperOffice.CRM.Data.DBC.QuickFilterInfoFields is New

##### SuperOffice.CRM.Data.DBC.TimeKeepingFields is New

#### SuperOffice.CRM.Data.Util.ExtraFieldHelper is Modified

* Deleted items
  * Method `ConvertDbExtraFieldToString(Object, FieldDataType, Boolean)`
* New items
  * Method `ConvertDbExtraFieldToString(Object, FieldInfo, Boolean)`

#### SuperOffice.CRM.Entities.Person is Modified

* New items
  * Method `GetUtmParametersAsync(CancellationToken)`

#### SuperOffice.CRM.Rows.EmailAccountRow is Modified

* Deleted items
  * Method `GetFromIdxEmailAddressAsync(String, CancellationToken)`

##### SuperOffice.CRM.Rows.EmailAccountRow.IdxEmailAddress is Deleted

#### SuperOffice.CRM.Rows.EmailAccountRows is Modified

* New items
  * Method `GetFromIdxEmailAddressAsync(String, CancellationToken)`

##### SuperOffice.CRM.Rows.EmailAccountRows.IdxEmailAddress is New

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(BoardViewBadgeType&, FieldInfo)`
  * Method `ValidateField(TimeKeepingType&, FieldInfo)`

#### SuperOffice.CRM.Rows.TargetRevisionHistoryRow is Modified

* Deleted items
  * Method `GetFromIdxTargetGroupIdAsync(Int32, CancellationToken)`

##### SuperOffice.CRM.Rows.TargetRevisionHistoryRow.IdxTargetGroupId is Deleted

#### SuperOffice.CRM.Rows.TargetRevisionHistoryRows is Modified

* New items
  * Method `GetFromIdxTargetGroupIdAsync(Int32, CancellationToken)`

##### SuperOffice.CRM.Rows.TargetRevisionHistoryRows.IdxTargetGroupId is New

#### SuperOffice.CRM.Ticket.TicketHelper is Modified

* Deleted items
  * Method `DemandAdminPermissionsAsync(CancellationToken)`
* New items
  * Method `DemandAdminPermissions()`
  * Method `DemandServiceT2AndAdminPermissions()`

#### SuperOffice.Data.Dialect.Dialect is Modified

* New items
  * Method `LockReader<T>(SoDataReader, Func<T>)`

#### SuperOffice.Data.SQL.TargetedLeftOuterJoin<TargetTableInfo> is Modified

* New items
  * Method `TargetedLeftOuterJoin(Equal, Restriction)`

#### SuperOffice.Data.TablesInfo is Modified

* New items
  * Method `GetQuickFilterInfoTableInfo()`
  * Method `GetTimeKeepingTableInfo()`


### Assembly: SoDatabase.BusinessLogic

### New Types

* `SuperOffice.CRM.Webhooks.WebhookSlowDispatcher`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.ContactExtenderBase is Modified

#### SuperOffice.CRM.ArchiveLists.PersonExtenderBase is Modified

#### SuperOffice.CRM.ArchiveLists.RequestNotificationProvider is Modified

* New items
  * Method `AcceptRow(ArchiveRow)`

#### SuperOffice.CRM.ArchiveLists.SaleExtenderBase is Modified

#### SuperOffice.CRM.BulkUpdate.BulkUpdateSystem is Modified

* New items

##### SuperOffice.CRM.BulkUpdate.BulkUpdateSystem.UTMParametersFieldValueKeys is New

#### SuperOffice.CRM.CustomObject.CustomObjectHelper is Modified

* New items
  * Method `ConvertFromLegacyColumnName(String)`

#### SuperOffice.CRM.Webhooks.WebhookManager is Modified

* Deleted items
  * Method `WebhookManager(IAsyncQueue<WebhookTaskInfo>, IAsyncQueue<DelayedItem<RetryWebhook>>, ISoRequestItemsAccessor, IServiceScopeFactory)`
* Modified items
  * Method `NotifyWebhooksAsync(IEnumerable<Webhook>, WebhookPayload, CancellationToken)`
* New items
  * Method `WebhookManager(IAsyncQueue<WebhookTaskInfo>, IAsyncQueue<DelayedItem<RetryWebhook>>, IAsyncQueue<ValueTuple<ICustomWebhookPlugin, Webhook, WebhookPayload>>, ISoRequestItemsAccessor, IServiceScopeFactory)`

#### SuperOffice.Data.Dialect.PostgreSqlDialect is Modified

* New items
  * Method `LockReader<T>(SoDataReader, Func<T>)`

#### SuperOffice.Util.BizCardResult is Modified

* New items
  * Property `CompanyPhone`

#### SuperOffice.Util.RagAIHelper is Modified

## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### Deleted Types

* `SuperOffice.CD.DSL.Database.Steps_UserPreferences.UserPreference_01_Num_Expanded_Messages`

### New Types

* `SuperOffice.CD.Database.BoardViewBadgeType`
* `SuperOffice.CD.Database.TimeKeepingType`
* `SuperOffice.CD.DSL.Database.FlagsMigrationHelper`
* `SuperOffice.CD.DSL.Database.Steps_Dashboard.DashboardStep22_QuickFilterInfo`
* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_128_FixIncorrectUniqueIndexes`
* `SuperOffice.CD.DSL.Database.Steps_UserPreference.UserPreference_01_Num_Expanded_Messages`
* `SuperOffice.CD.DSL.Database.Steps_UserPreference.UserPreference_02_EjUser_Simple_Fields_Migration`
* `SuperOffice.CD.DSL.Database.Steps_UserPreference.UserPreference_03_Flags_Migration`
* `SuperOffice.CD.DSL.Database.T_QuickFilterInfo`
* `SuperOffice.CD.DSL.Database.T_TimeKeeping`


