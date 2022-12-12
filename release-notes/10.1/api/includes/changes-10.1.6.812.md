<!-- markdownlint-disable-file MD041 MD024-->
## Changes from v10.1.5.2031 to v10.1.6.812

### Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

#### Assembly: SuperOffice.Services

#### Modified Types

##### SuperOffice.CRM.Services.ITargetsAgent is Modified

* New items
  * Method `CreateDefaultTargetAssignmentForCompanyWithDimension(Int32)`
  * Method `CreateDefaultTargetAssignmentForUserGroupWithDimension(Int32, Int32)`
  * Method `GetTargetAssignmentForYearAndDimension(Int32, TargetEntityType, TargetLevel, Int32, Int32)`
  * Method `GetTargetGroupForYearAndDimension(Int32, Int32)`

##### SuperOffice.CRM.Services.TargetDimension is Modified

* Deleted items
  * Property `DimensionList`
* New items
  * Property `DimensionListField`
  * Property `DimensionListId`
  * Property `DimensionListLabel`

##### SuperOffice.CRM.Services.TargetsAgent is Modified

* New items
  * Method `CreateDefaultTargetAssignmentForCompanyWithDimension(Int32)`
  * Method `CreateDefaultTargetAssignmentForUserGroupWithDimension(Int32, Int32)`
  * Method `GetTargetAssignmentForYearAndDimension(Int32, TargetEntityType, TargetLevel, Int32, Int32)`
  * Method `GetTargetGroupForYearAndDimension(Int32, Int32)`

### NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

#### Assembly: SoCore

#### Modified Types

##### SuperOffice.CRM.FunctionRightStrings is Modified

* New items
  * Field `TargetsAdminstrator`

##### SuperOffice.CRM.Security.FieldProperty is Modified

* Deleted items
  * Method `FieldProperty(FieldRight, Type, Int32)`
* New items
  * Method `FieldProperty(FieldRight, Type, Int32, String)`

##### SuperOffice.Globalization.RC is Modified

* New items
  * Field `CS_BOOL_FALSE`
  * Field `SR_CONFIGSCREEN_CLICKTOSELECT`
  * Field `SR_CONFIGSCREEN_NEED_APPLYLAYOUT`
  * Field `SR_EDITOR_ONLY_SINGLE_IMAGE`
  * Field `SR_INBOX_DRAFT_COUNT`
  * Field `SR_INBOX_UNREAD_COUNT`
  * Field `SR_PD_DataMirroring_BatchSize_DESC`
  * Field `SR_PD_DataMirroring_BatchSize_NAME`
  * Field `SR_PD_DataMirroring_DESC`
  * Field `SR_PD_DataMirroring_ExcludeTables_DESC`
  * Field `SR_PD_DataMirroring_ExcludeTables_NAME`
  * Field `SR_PD_DataMirroring_NAME`
  * Field `SR_SALE_STAGE_WORKFLOW`
  * Field `SR_TABS_SCROLL_LEFT`
  * Field `SR_TABS_SCROLL_RIGHT`
  * Field `SR_TABS_VIEW_ALL_TABS`
  * Field `SR_TARGET_GET_LICENSE`
  * Field `SR_TARGET_UNLIMITED_LICENSE_TEXT`
  * Field `SR_TARGETS_ACTIVE_FILTERS`
  * Field `SR_TARGETS_ALL_SALES`
  * Field `SR_TARGETS_ALL_SALES_GROUP_TITLE`
  * Field `SR_TARGETS_CONFIGURE_TARGET`
  * Field `SR_TARGETS_COPY_PREVIOUS_YEAR`
  * Field `SR_TARGETS_COPY_PREVIOUS_YEAR_NO_DATA`
  * Field `SR_TARGETS_COPY_PREVIOUS_YEAR_TITLE`
  * Field `SR_TARGETS_DIM_SALE_TYPE`
  * Field `SR_TARGETS_EXCLUDE_ASSCOCIATE`
  * Field `SR_TARGETS_INCREASE_BY`
  * Field `SR_TARGETS_MEASUREMENT`
  * Field `SR_TARGETS_MEASUREMENT_AMOUNT`
  * Field `SR_TARGETS_MEASUREMENT_COUNT`
  * Field `SR_TARGETS_MEASUREMENT_NONE`
  * Field `SR_TARGETS_MEASUREMENT_PROFIT`
  * Field `SR_TARGETS_NO_ADJUSTMENT`
  * Field `SR_TARGETS_NO_RIGHTS`
  * Field `SR_TARGETS_SEPARATE_TARGETS`
  * Field `SR_TARGETS_SEPARATE_TARGETS_DESCRIPTION`
  * Field `SR_TARGETS_SET_FILTERS`
  * Field `SR_TARGETS_SUM_ROW_TITLE`
  * Field `SR_TARGETS_TYPE`
  * Field `SR_TARGETS_TYPE_ADD`
  * Field `SR_TARGETS_TYPE_DESCRIPTION`
  * Field `SR_TARGETS_TYPE_EDIT`
  * Field `SR_TARGETS_TYPE_HEADING`

##### SuperOffice.License.SoLicenseNames is Modified

* New items
  * Field `AI`
  * Field `ChatFree`
  * Field `FormsFree`
  * Field `HugoAI`
  * Field `MarketingT1`
  * Field `SaintCal`
  * Field `SalesT1`
  * Field `SalesT2`
  * Field `ServiceT1`
  * Field `ServiceT2`

##### SuperOffice.SoDatabaseContext is Modified

* New items
  * Method `RemoveDatabaseContext(String, Boolean)`

#### Assembly: SoDatabase

#### New Types

* `SuperOffice.Data.Cache.BaseFlushCacheAndBroadcastPlugin`
* `SuperOffice.Data.Cache.CacheFlusher`
* `SuperOffice.Data.Cache.ICacheFlusher`
* `SuperOffice.Data.Cache.IFlushCacheAndBroadcastPlugin`
* `SuperOffice.Data.Cache.OnlineFlushCacheAndBroadcastPlugin`
* `SuperOffice.Data.Cache.OnsiteFlushCacheAndBroadcastPlugin`

#### Modified Types

##### SuperOffice.CRM.ArchiveLists.FreetextMatchCalculator is Modified

* Deleted items
  * Method `CalculateMatches(String[], String[], Nullable<Int32>, Nullable<Int32>, Boolean)`
* New items
  * Method `CalculateMatches(String[], String[], Nullable<Int32>, Nullable<Int32>, Boolean, Boolean)`

##### SuperOffice.CRM.ArchiveLists.SaleExtenderBase is Modified

##### SuperOffice.CRM.ArchiveLists.TargetValueExtenderBase is Modified

##### SuperOffice.CRM.Data.DBC is Modified

* Modified items

###### SuperOffice.CRM.Data.DBC.TargetDimensionFields is Modified

* Deleted items
  * Field `.TargetDimensionFieldsDimensionList`
* New items
  * Field `.TargetDimensionFieldsDimensionListField`

##### SuperOffice.CRM.Data.TargetDimensionTableInfo is Modified

* Deleted items
  * Property `DimensionList`
* New items
  * Property `DimensionListField`

##### SuperOffice.CRM.Lists.TargetTypeProvider is Modified

* New items
  * Method `FieldNameToProviderColName(String)`
  * Method `ProviderColNameToDbColName(String)`

##### SuperOffice.CRM.Lists.TicketListProvider is Modified

* New items
  * Method `BuildSearchFromSubSearches(String)`

##### SuperOffice.CRM.Rows.TargetDimensionRecordData is Modified

* Deleted items
  * Field `DimensionList`
* New items
  * Field `DimensionListField`

##### SuperOffice.CRM.Rows.TargetDimensionRow is Modified

* Deleted items
  * Property `DimensionList`
* New items
  * Property `DimensionListField`

### Continuous Database

The following represent changes to SuperOffice database schema.

#### Assembly: SuperOffice.CD.DSL.Database

#### New Types

* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_88_TargetsAdministrator_FunctionalRight`
* `SuperOffice.CD.DSL.Database.Steps_Targets.TargetsStep08_ListField`

#### Modified Types

##### SuperOffice.CD.DSL.Database.T_TargetDimension is Modified

* Deleted items
  * Field `DimensionList`
* New items
  * Field `DimensionListField`
