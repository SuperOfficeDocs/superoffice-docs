---
uid: version_11.8.788.0_changes
date: 22.01.2026
---

Changes from v11.7.727 and v11.8.788.0

### Assembly: SuperOffice.WebApi

### New Types

* `SuperOffice.WebApi.Data.AnalyticsData`
* `SuperOffice.WebApi.Data.Diagnostics_GetAnalyticsDataRequest`
* `SuperOffice.WebApi.Data.Diagnostics_TrackEventRequest`
* `SuperOffice.WebApi.Data.Diagnostics_TrackUserRequest`
* `SuperOffice.WebApi.Data.List_PerformNeededCategoryUpdateRequest`
* `SuperOffice.WebApi.Data.List_SetTicketRelationDefinitionSortOrderRequest`
* `SuperOffice.WebApi.Data.TicketRelationDefinitionEntity`
* `SuperOffice.WebApi.Data.TicketRelationEntity`
* `SuperOffice.WebApi.Data.TicketRelationType`

### Modified Types

#### SuperOffice.WebApi.Agents.DiagnosticsAgent is Modified

* New items
  * Method `GetAnalyticsDataAsync(RequestOptions)`
  * Method `TrackEventAsync(String, StringDictionary, RequestOptions)`
  * Method `TrackUserAsync(StringDictionary, RequestOptions)`

#### SuperOffice.WebApi.Agents.IDiagnosticsAgent is Modified

* New items
  * Method `GetAnalyticsDataAsync(RequestOptions)`
  * Method `TrackEventAsync(String, StringDictionary, RequestOptions)`
  * Method `TrackUserAsync(StringDictionary, RequestOptions)`

#### SuperOffice.WebApi.Agents.IListAgent is Modified

* New items
  * Method `CreateDefaultTicketRelationDefinitionEntityAsync(RequestOptions)`
  * Method `DeleteTicketRelationDefinitionEntityAsync(Int32, RequestOptions)`
  * Method `GetTicketRelationDefinitionEntityAsync(Int32, RequestOptions)`
  * Method `PerformNeededCategoryUpdateAsync(Int32, Int32, Int32, AutomatedCategoryUpdate, RequestOptions)`
  * Method `SaveTicketRelationDefinitionEntityAsync(TicketRelationDefinitionEntity, RequestOptions)`
  * Method `SetTicketRelationDefinitionSortOrderAsync(Int32, Int32, RequestOptions)`

#### SuperOffice.WebApi.Agents.ITicketAgent is Modified

* New items
  * Method `CreateDefaultTicketRelationEntityAsync(RequestOptions)`
  * Method `DeleteTicketRelationEntityAsync(Int32, RequestOptions)`
  * Method `SaveTicketRelationEntityAsync(TicketRelationEntity, RequestOptions)`

#### SuperOffice.WebApi.Agents.ListAgent is Modified

* New items
  * Method `CreateDefaultTicketRelationDefinitionEntityAsync(RequestOptions)`
  * Method `DeleteTicketRelationDefinitionEntityAsync(Int32, RequestOptions)`
  * Method `GetTicketRelationDefinitionEntityAsync(Int32, RequestOptions)`
  * Method `PerformNeededCategoryUpdateAsync(Int32, Int32, Int32, AutomatedCategoryUpdate, RequestOptions)`
  * Method `SaveTicketRelationDefinitionEntityAsync(TicketRelationDefinitionEntity, RequestOptions)`
  * Method `SetTicketRelationDefinitionSortOrderAsync(Int32, Int32, RequestOptions)`

#### SuperOffice.WebApi.Agents.TicketAgent is Modified

* New items
  * Method `CreateDefaultTicketRelationEntityAsync(RequestOptions)`
  * Method `DeleteTicketRelationEntityAsync(Int32, RequestOptions)`
  * Method `SaveTicketRelationEntityAsync(TicketRelationEntity, RequestOptions)`

#### SuperOffice.WebApi.Data.Appointment is Modified

* New items
  * Property `TaskId`

#### SuperOffice.WebApi.Data.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.WebApi.Data.UserPreferenceStrings.Copilot is Modified

* New items
  * Field `.CopilotServiceProcedure`
  * Field `.CopilotServiceSystemPrompt`




