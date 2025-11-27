---
uid: version_11.7.727.0_changes
date: 27.11.2025
---

Changes from v11.6.943.0 and v11.7.727.0

### Assembly: SuperOffice.WebApi

### Deleted Types

* `SuperOffice.WebApi.Data.List_DeleteTaskMenuRequest`
* `SuperOffice.WebApi.Data.List_SaveTaskMenuRequest`
* `SuperOffice.WebApi.Data.List_SaveWebPanelEntityRequest`

### New Types

* `SuperOffice.WebApi.Data.AI_GetFormDesignFromImageRequest`
* `SuperOffice.WebApi.Data.AI_GetFormDesignFromUrlRequest`
* `SuperOffice.WebApi.Data.AutomatedCategoryUpdate`
* `SuperOffice.WebApi.Data.CategoryUpdateTrigger`
* `SuperOffice.WebApi.Data.CopilotDataSourceEntity`
* `SuperOffice.WebApi.Data.CopilotDataSourceSetting`
* `SuperOffice.WebApi.Data.CopilotDataSourceType`
* `SuperOffice.WebApi.Data.CopilotEntity`
* `SuperOffice.WebApi.Data.FormDesignCarrier`
* `SuperOffice.WebApi.Data.List_GetAllAutomatedCategoryUpdatesRequest`
* `SuperOffice.WebApi.Data.List_GetNeedCategoryUpdateForPersonRequest`
* `SuperOffice.WebApi.Data.List_GetNeedCategoryUpdateForSaleRequest`
* `SuperOffice.WebApi.Data.List_SaveAllAutomatedCategoryUpdatesRequest`

### Modified Types

#### SuperOffice.WebApi.Agents.AIAgent is Modified

* New items
  * Method `CreateDefaultCopilotDataSourceEntityAsync(RequestOptions)`
  * Method `CreateDefaultCopilotEntityAsync(RequestOptions)`
  * Method `DeleteCopilotDataSourceEntityAsync(Int32, RequestOptions)`
  * Method `DeleteCopilotEntityAsync(Int32, RequestOptions)`
  * Method `GetCopilotDataSourceEntityAsync(Int32, RequestOptions)`
  * Method `GetCopilotEntityAsync(Int32, RequestOptions)`
  * Method `GetFormDesignFromImageAsync(Byte[], RequestOptions)`
  * Method `GetFormDesignFromUrlAsync(String, RequestOptions)`
  * Method `SaveCopilotDataSourceEntityAsync(CopilotDataSourceEntity, RequestOptions)`
  * Method `SaveCopilotEntityAsync(CopilotEntity, RequestOptions)`

#### SuperOffice.WebApi.Agents.IAIAgent is Modified

* New items
  * Method `CreateDefaultCopilotDataSourceEntityAsync(RequestOptions)`
  * Method `CreateDefaultCopilotEntityAsync(RequestOptions)`
  * Method `DeleteCopilotDataSourceEntityAsync(Int32, RequestOptions)`
  * Method `DeleteCopilotEntityAsync(Int32, RequestOptions)`
  * Method `GetCopilotDataSourceEntityAsync(Int32, RequestOptions)`
  * Method `GetCopilotEntityAsync(Int32, RequestOptions)`
  * Method `GetFormDesignFromImageAsync(Byte[], RequestOptions)`
  * Method `GetFormDesignFromUrlAsync(String, RequestOptions)`
  * Method `SaveCopilotDataSourceEntityAsync(CopilotDataSourceEntity, RequestOptions)`
  * Method `SaveCopilotEntityAsync(CopilotEntity, RequestOptions)`

#### SuperOffice.WebApi.Agents.IListAgent is Modified

* New items
  * Method `GetAllAutomatedCategoryUpdatesAsync(RequestOptions)`
  * Method `GetNeedCategoryUpdateForPersonAsync(Int32, Int32, Int32, Int32, RequestOptions)`
  * Method `GetNeedCategoryUpdateForSaleAsync(SaleStatus, Int32, Int32, Int32, RequestOptions)`
  * Method `SaveAllAutomatedCategoryUpdatesAsync(AutomatedCategoryUpdate[], RequestOptions)`

#### SuperOffice.WebApi.Agents.ListAgent is Modified

* New items
  * Method `GetAllAutomatedCategoryUpdatesAsync(RequestOptions)`
  * Method `GetNeedCategoryUpdateForPersonAsync(Int32, Int32, Int32, Int32, RequestOptions)`
  * Method `GetNeedCategoryUpdateForSaleAsync(SaleStatus, Int32, Int32, Int32, RequestOptions)`
  * Method `SaveAllAutomatedCategoryUpdatesAsync(AutomatedCategoryUpdate[], RequestOptions)`

#### SuperOffice.WebApi.Data.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.WebApi.Data.UserPreferenceStrings.DataCollection is Modified

* New items
  * Field `.DataCollectionTimeKeeping`
