---
uid: version_11.9.1204.0_changes
date: 18.02.2026
---

Changes from v11.8.788 and v11.9.1204.0

### Assembly: SuperOffice.WebApi

### New Types

* `SuperOffice.WebApi.Data.AI_CancelIndexingRequest`
* `SuperOffice.WebApi.Data.AI_GetIndexingStatusRequest`
* `SuperOffice.WebApi.Data.AI_ParseQueryIntoRestrictionsRequest`
* `SuperOffice.WebApi.Data.AI_RemovePhotoBackgroundRequest`
* `SuperOffice.WebApi.Data.AvailableFont`
* `SuperOffice.WebApi.Data.CreatePhotoBackground`
* `SuperOffice.WebApi.Data.ExternallyOwnedStatus`
* `SuperOffice.WebApi.Data.ExternallyOwnedType`
* `SuperOffice.WebApi.Data.Marketing_CreateDefaultAvailableFontRequest`
* `SuperOffice.WebApi.Data.Marketing_DeleteAvailableFontRequest`
* `SuperOffice.WebApi.Data.Marketing_GetAvailableFontRequest`
* `SuperOffice.WebApi.Data.Marketing_SaveAvailableFontRequest`
* `SuperOffice.WebApi.Data.Marketing_SetFontRankRequest`
* `SuperOffice.WebApi.Data.NaturalLanguageSearch`
* `SuperOffice.WebApi.Data.RagStatus`
* `SuperOffice.WebApi.Data.RagStatusChunks`

### Modified Types

#### SuperOffice.License.SoLicenseNames is Modified

* New items
  * Field `Suite1Starter`
  * Field `Suite2Core`
  * Field `Suite3Growth`
  * Field `Suite4Plus`
  * Field `Suite5Super`
  * Field `SuiteMarker`
  * Field `SuiteUser`

#### SuperOffice.WebApi.Agents.AIAgent is Modified

* New items
  * Method `CancelIndexingAsync(String, RequestOptions)`
  * Method `GetIndexingStatusAsync(String, RequestOptions)`
  * Method `ParseQueryIntoRestrictionsAsync(String, String, NaturalLanguageSearch, RequestOptions)`
  * Method `RemovePhotoBackgroundAsync(Byte[], String, RequestOptions)`

#### SuperOffice.WebApi.Agents.IAIAgent is Modified

* New items
  * Method `CancelIndexingAsync(String, RequestOptions)`
  * Method `GetIndexingStatusAsync(String, RequestOptions)`
  * Method `ParseQueryIntoRestrictionsAsync(String, String, NaturalLanguageSearch, RequestOptions)`
  * Method `RemovePhotoBackgroundAsync(Byte[], String, RequestOptions)`

#### SuperOffice.WebApi.Agents.IMarketingAgent is Modified

* New items
  * Method `CreateDefaultAvailableFontAsync(RequestOptions)`
  * Method `DeleteAvailableFontAsync(Int32, RequestOptions)`
  * Method `GetAvailableFontAsync(Int32, RequestOptions)`
  * Method `SaveAvailableFontAsync(AvailableFont, RequestOptions)`
  * Method `SetFontRankAsync(Int32, Int32, RequestOptions)`

#### SuperOffice.WebApi.Agents.MarketingAgent is Modified

* New items
  * Method `CreateDefaultAvailableFontAsync(RequestOptions)`
  * Method `DeleteAvailableFontAsync(Int32, RequestOptions)`
  * Method `GetAvailableFontAsync(Int32, RequestOptions)`
  * Method `SaveAvailableFontAsync(AvailableFont, RequestOptions)`
  * Method `SetFontRankAsync(Int32, Int32, RequestOptions)`

#### SuperOffice.WebApi.Data.AnalyticsData is Modified

* Deleted items
  * Property `AmplitudeApiKey`
  * Property `UserflowToken`

#### SuperOffice.WebApi.Data.Category is Modified

* New items
  * Property `CategoryGroup`
  * Property `CategoryGroup_String`
  * Property `Deleted`
  * Property `EnableLeadStatus`
  * Property `Rank`

#### SuperOffice.WebApi.Data.Navigation is Modified

* New items
  * Field `CustomObjectArchive`
  * Field `CustomObjectCard`

#### SuperOffice.WebApi.Data.ParticipantInfo is Modified

* New items
  * Property `ExternallyOwnedStatus`
  * Property `ExternallyOwnedStatus_String`
  * Property `ExternallyOwnedType`
  * Property `ExternallyOwnedType_String`

#### SuperOffice.WebApi.Data.PersonEntity is Modified

* New items
  * Property `Leadstatus`

#### SuperOffice.WebApi.Data.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.WebApi.Data.UserPreferenceStrings.Associates is Modified

* New items
  * Field `.AssociatesFirstLoginSession`


##### SuperOffice.WebApi.Data.UserPreferenceStrings.NetServices is Modified

* New items
  * Field `.NetServicesTemplatesUrl`

* New items

##### SuperOffice.WebApi.Data.UserPreferenceStrings.EmailNotification is New

#### SuperOffice.WebApi.Data.WebPanelEntity is Modified

* New items
  * Property `CustomObjectEntity`



