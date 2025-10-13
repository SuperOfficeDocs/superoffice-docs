---
uid: version_11.5.755.0_changes
date: 13.10.2025
---

Changes from v11.4.1157 and v11.5.755.0

### Assembly: SuperOffice.WebApi

### New Types

* `SuperOffice.WebApi.Agents.IAgentBase`
* `SuperOffice.WebApi.Data.BoardViewBadgeType`
* `SuperOffice.WebApi.Data.Dash_GetDashQuickFiltersRequest`
* `SuperOffice.WebApi.Data.Dash_GetPossibleDashQuickFiltersRequest`
* `SuperOffice.WebApi.Data.Dash_SaveDashQuickFiltersRequest`
* `SuperOffice.WebApi.Data.QuickFilterInfo`

### Modified Types

#### SuperOffice.WebApi.Agents.AgentBase is Modified

* Modified items
  * Property `Configuration`
  * Property `HasRunningRequest`
  * Property `ProgressListener`
  * Property `UploadProgressListener`
  * Method `CancelRequest()`

#### SuperOffice.WebApi.Agents.DashAgent is Modified

* New items
  * Method `GetDashQuickFiltersAsync(Int32, RequestOptions)`
  * Method `GetPossibleDashQuickFiltersAsync(Int32, RequestOptions)`
  * Method `SaveDashQuickFiltersAsync(Int32, QuickFilterInfo[], RequestOptions)`

#### SuperOffice.WebApi.Agents.IDashAgent is Modified

* New items
  * Method `GetDashQuickFiltersAsync(Int32, RequestOptions)`
  * Method `GetPossibleDashQuickFiltersAsync(Int32, RequestOptions)`
  * Method `SaveDashQuickFiltersAsync(Int32, QuickFilterInfo[], RequestOptions)`

#### SuperOffice.WebApi.Data.SaleBoardViewSettings is Modified

* New items
  * Property `BadgeType`
  * Property `BadgeType_String`
