---
uid: version_11.11.589.0_changes
date: 13.03.2026
---

Changes from v11.10.705 and v11.11.589.0

### Assembly: SuperOffice.WebApi

### New Types

* `SuperOffice.WebApi.Data.AI_GetFirstFormDesignCssFromImageRequest`
* `SuperOffice.WebApi.Data.AI_GetFirstFormDesignCssFromUrlRequest`
* `SuperOffice.WebApi.Data.AI_GetNextFormDesignCssRequest`
* `SuperOffice.WebApi.Data.Configuration_GetCsCgiUrlRequest`
* `SuperOffice.WebApi.Data.FormDesignCss`
* `SuperOffice.WebApi.Data.FormFieldRestriction`
* `SuperOffice.WebApi.Data.FormFieldRestrictionType`
* `SuperOffice.WebApi.Data.Marketing_SetAllFormFieldRestrictionsRequest`
* `SuperOffice.WebApi.Data.Project_GetProjectEntityWithoutMembersRequest`
* `SuperOffice.WebApi.Data.Project_SaveProjectEntityWithoutMembersRequest`

### Modified Types

#### SuperOffice.License.SoLicenseNames is Modified

* New items
  * Field `ActivityBoard`
  * Field `ContractManager`
  * Field `Map4You`

#### SuperOffice.WebApi.Agents.AIAgent is Modified

* New items
  * Method `GetFirstFormDesignCssFromImageAsync(Byte[], String, RequestOptions)`
  * Method `GetFirstFormDesignCssFromUrlAsync(String, String, RequestOptions)`
  * Method `GetNextFormDesignCssAsync(String, String, RequestOptions)`

#### SuperOffice.WebApi.Agents.ConfigurationAgent is Modified

* New items
  * Method `GetCsCgiUrlAsync(RequestOptions)`

#### SuperOffice.WebApi.Agents.IAIAgent is Modified

* New items
  * Method `GetFirstFormDesignCssFromImageAsync(Byte[], String, RequestOptions)`
  * Method `GetFirstFormDesignCssFromUrlAsync(String, String, RequestOptions)`
  * Method `GetNextFormDesignCssAsync(String, String, RequestOptions)`

#### SuperOffice.WebApi.Agents.IConfigurationAgent is Modified

* New items
  * Method `GetCsCgiUrlAsync(RequestOptions)`

#### SuperOffice.WebApi.Agents.IMarketingAgent is Modified

* New items
  * Method `SetAllFormFieldRestrictionsAsync(FormFieldRestriction[], RequestOptions)`

#### SuperOffice.WebApi.Agents.IProjectAgent is Modified

* New items
  * Method `GetProjectEntityWithoutMembersAsync(Int32, RequestOptions)`
  * Method `SaveProjectEntityWithoutMembersAsync(ProjectEntity, RequestOptions)`

#### SuperOffice.WebApi.Agents.MarketingAgent is Modified

* New items
  * Method `SetAllFormFieldRestrictionsAsync(FormFieldRestriction[], RequestOptions)`

#### SuperOffice.WebApi.Agents.ProjectAgent is Modified

* New items
  * Method `GetProjectEntityWithoutMembersAsync(Int32, RequestOptions)`
  * Method `SaveProjectEntityWithoutMembersAsync(ProjectEntity, RequestOptions)`

#### SuperOffice.WebApi.Data.TicketOrigin is Modified

* New items
  * Field `API`
  * Field `Flow`



