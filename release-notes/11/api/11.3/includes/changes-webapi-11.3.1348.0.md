<!-- markdownlint-disable-file MD041 MD033 MD024 MD012 MD013-->
Changes from v11.2.487.0 and v11.3.1348.0

### Assembly: SuperOffice.WebApi

### Deleted Types

* `SuperOffice.WebApi.Agents.ForNetserverUntilVersion11.DashboardAgent`
* `SuperOffice.WebApi.Agents.ForNetserverUntilVersion11.IDashboardAgent`
* `SuperOffice.WebApi.Data.ForNetserverUntilVersion11.Dashboard`
* `SuperOffice.WebApi.Data.ForNetserverUntilVersion11.Dashboard_CreateNewFromTemplateRequest`
* `SuperOffice.WebApi.Data.ForNetserverUntilVersion11.Dashboard_GetDashboardsRequest`
* `SuperOffice.WebApi.Data.ForNetserverUntilVersion11.Dashboard_GetDashboardTilesRequest`
* `SuperOffice.WebApi.Data.ForNetserverUntilVersion11.Dashboard_GetDataRequest`
* `SuperOffice.WebApi.Data.ForNetserverUntilVersion11.Dashboard_GetDataWithSelectionRequest`
* `SuperOffice.WebApi.Data.ForNetserverUntilVersion11.Dashboard_GetStandardDashboardTileFromChartIdRequest`
* `SuperOffice.WebApi.Data.ForNetserverUntilVersion11.Dashboard_SetTileRequest`
* `SuperOffice.WebApi.Data.ForNetserverUntilVersion11.DashboardLayout`
* `SuperOffice.WebApi.Data.ForNetserverUntilVersion11.DashboardTile`
* `SuperOffice.WebApi.Data.ForNetserverUntilVersion11.DashboardTileEntityType`
* `SuperOffice.WebApi.Data.ForNetserverUntilVersion11.DashboardTileOption`
* `SuperOffice.WebApi.Data.ForNetserverUntilVersion11.DashboardTileOptionType`
* `SuperOffice.WebApi.Data.ForNetserverUntilVersion11.DashboardTileType`
* `SuperOffice.WebApi.Data.ForNetserverUntilVersion11.TileData`

### New Types

* `SuperOffice.WebApi.Agents.DashboardAgent`
* `SuperOffice.WebApi.Agents.IDashboardAgent`
* `SuperOffice.WebApi.Data.AI_AnalyzeBizCardImageRequest`
* `SuperOffice.WebApi.Data.AI_AnalyzeBizCardTextRequest`
* `SuperOffice.WebApi.Data.BizCard`
* `SuperOffice.WebApi.Data.BoardViewEntityType`
* `SuperOffice.WebApi.Data.BoardViewSettingsBase`
* `SuperOffice.WebApi.Data.CategoryEntity`
* `SuperOffice.WebApi.Data.CategoryGroup`
* `SuperOffice.WebApi.Data.Dashboard`
* `SuperOffice.WebApi.Data.Dashboard_CreateNewFromTemplateRequest`
* `SuperOffice.WebApi.Data.Dashboard_GetDashboardsRequest`
* `SuperOffice.WebApi.Data.Dashboard_GetDashboardTilesRequest`
* `SuperOffice.WebApi.Data.Dashboard_GetDataRequest`
* `SuperOffice.WebApi.Data.Dashboard_GetDataWithSelectionRequest`
* `SuperOffice.WebApi.Data.Dashboard_GetStandardDashboardTileFromChartIdRequest`
* `SuperOffice.WebApi.Data.Dashboard_SetTileRequest`
* `SuperOffice.WebApi.Data.DashboardLayout`
* `SuperOffice.WebApi.Data.DashboardTile`
* `SuperOffice.WebApi.Data.DashboardTileEntityType`
* `SuperOffice.WebApi.Data.DashboardTileOption`
* `SuperOffice.WebApi.Data.DashboardTileOptionType`
* `SuperOffice.WebApi.Data.DashboardTileType`
* `SuperOffice.WebApi.Data.EjScriptVerb`
* `SuperOffice.WebApi.Data.InitalUtmParameters`
* `SuperOffice.WebApi.Data.Person_GetUtmParametersRequest`
* `SuperOffice.WebApi.Data.Project_SetCompletedRequest`
* `SuperOffice.WebApi.Data.ProjectBoardViewSettings`
* `SuperOffice.WebApi.Data.SaleBoardViewSettings`
* `SuperOffice.WebApi.Data.Selection_CreateDefaultBoardViewSettingsFromEntityTypeRequest`
* `SuperOffice.WebApi.Data.Selection_DeleteBoardViewSettingsRequest`
* `SuperOffice.WebApi.Data.Selection_GetBoardViewSettingsForSelectionRequest`
* `SuperOffice.WebApi.Data.Selection_GetBoardViewSettingsRequest`
* `SuperOffice.WebApi.Data.Selection_SaveBoardViewSettingsRequest`
* `SuperOffice.WebApi.Data.TileData`
* `SuperOffice.WebApi.Data.UtmParameters`

### Modified Types

#### SuperOffice.License.SoLicenseNames is Modified

* New items
  * Field `UtmSaving`

#### SuperOffice.WebApi.Agents.AIAgent is Modified

* New items
  * Method `AnalyzeBizCardImageAsync(Byte[], Boolean, RequestOptions)`
  * Method `AnalyzeBizCardTextAsync(String, Boolean, RequestOptions)`

#### SuperOffice.WebApi.Agents.IAIAgent is Modified

* New items
  * Method `AnalyzeBizCardImageAsync(Byte[], Boolean, RequestOptions)`
  * Method `AnalyzeBizCardTextAsync(String, Boolean, RequestOptions)`

#### SuperOffice.WebApi.Agents.IListAgent is Modified

* New items
  * Method `CreateDefaultCategoryEntityAsync(RequestOptions)`
  * Method `GetCategoryEntityAsync(Int32, RequestOptions)`
  * Method `SaveCategoryEntityAsync(CategoryEntity, RequestOptions)`

#### SuperOffice.WebApi.Agents.IPersonAgent is Modified

* New items
  * Method `GetUtmParametersAsync(Int32, RequestOptions)`

#### SuperOffice.WebApi.Agents.IProjectAgent is Modified

* New items
  * Method `SetCompletedAsync(Int32, Boolean, RequestOptions)`

#### SuperOffice.WebApi.Agents.ISelectionAgent is Modified

* New items
  * Method `CreateDefaultBoardViewSettingsFromEntityTypeAsync(BoardViewEntityType, RequestOptions)`
  * Method `DeleteBoardViewSettingsAsync(Int32, RequestOptions)`
  * Method `GetBoardViewSettingsAsync(Int32, RequestOptions)`
  * Method `GetBoardViewSettingsForSelectionAsync(Int32, Int32, RequestOptions)`
  * Method `SaveBoardViewSettingsAsync(BoardViewSettingsBase, RequestOptions)`

#### SuperOffice.WebApi.Agents.ListAgent is Modified

* New items
  * Method `CreateDefaultCategoryEntityAsync(RequestOptions)`
  * Method `GetCategoryEntityAsync(Int32, RequestOptions)`
  * Method `SaveCategoryEntityAsync(CategoryEntity, RequestOptions)`

#### SuperOffice.WebApi.Agents.PersonAgent is Modified

* New items
  * Method `GetUtmParametersAsync(Int32, RequestOptions)`

#### SuperOffice.WebApi.Agents.ProjectAgent is Modified

* New items
  * Method `SetCompletedAsync(Int32, Boolean, RequestOptions)`

#### SuperOffice.WebApi.Agents.SelectionAgent is Modified

* New items
  * Method `CreateDefaultBoardViewSettingsFromEntityTypeAsync(BoardViewEntityType, RequestOptions)`
  * Method `DeleteBoardViewSettingsAsync(Int32, RequestOptions)`
  * Method `GetBoardViewSettingsAsync(Int32, RequestOptions)`
  * Method `GetBoardViewSettingsForSelectionAsync(Int32, Int32, RequestOptions)`
  * Method `SaveBoardViewSettingsAsync(BoardViewSettingsBase, RequestOptions)`

#### SuperOffice.WebApi.Data.Appointment is Modified

* New items
  * Property `MotherAssociateId`

#### SuperOffice.WebApi.Data.AppointmentInfo is Modified

* New items
  * Property `MotherAssociateId`
  * Property `OwnedExternally`
  * Property `OwnedExternally_String`

#### SuperOffice.WebApi.Data.Associate is Modified

* New items
  * Property `CustomFields`
  * Property `ExtraFields`

#### SuperOffice.WebApi.Data.ContactEntity is Modified

* New items
  * Property `InitialUtmParameters`

#### SuperOffice.WebApi.Data.CRMScriptEntity is Modified

* New items
  * Property `BlockedVerbs`
  * Property `BlockedVerbs_String`

#### SuperOffice.WebApi.Data.DashTileType is Modified

* New items
  * Field `Funnel`

#### SuperOffice.WebApi.Data.EventHandlerType is Modified

* New items
  * Field `SalesLoadTicket`
  * Field `SalesLoadTicketMessage`

#### SuperOffice.WebApi.Data.NotifyType is Modified

* Deleted items
  * Field `UndefinedValue2048`
* New items
  * Field `ContactAssignment`
  * Field `UndefinedValue4096`

#### SuperOffice.WebApi.Data.PersonEntity is Modified

* New items
  * Property `InitialUtmParameters`

#### SuperOffice.WebApi.Data.RoleRelationToOwner is Modified

* New items
  * Field `CustomObjects`

#### SuperOffice.WebApi.Data.Script is Modified

* New items
  * Property `BlockedVerbs`
  * Property `BlockedVerbs_String`

#### SuperOffice.WebApi.Data.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.WebApi.Data.UserPreferenceStrings.SalesNotification is Modified

* New items
  * Field `.SalesNotificationNotifyCompanyAssignment`

* New items

##### SuperOffice.WebApi.Data.UserPreferenceStrings.Mailing is New
