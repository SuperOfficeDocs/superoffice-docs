---
uid: version_11.13.921_changes
date: 29.04.2026
---

Changes from v11.12.675 and v11.13.921

## Web API

The following represent changes to the core Web API assembly.

### Assembly: SuperOffice.WebApi

### New Types

* `SuperOffice.WebApi.Data.AI_AnswerUsingContextRequest`
* `SuperOffice.WebApi.Data.Contact_UpdateInterestsRequest`
* `SuperOffice.WebApi.Data.Diagnostics_RegisterClosedTicketsUsageRequest`
* `SuperOffice.WebApi.Data.Person_UpdateInterestsRequest`
* `SuperOffice.WebApi.Data.Preference_GetXsrfValueRequest`
* `SuperOffice.WebApi.Data.Preference_SetXsrfValueRequest`
* `SuperOffice.WebApi.Data.RagContextIds`
* `SuperOffice.WebApi.Data.Ticket_SetSpamStatusByIdsRequest`
* `SuperOffice.WebApi.Data.Ticket_SetSpamStatusByProviderRequest`
* `SuperOffice.WebApi.Data.TicketUsage`
* `SuperOffice.WebApi.Data.User_ExchangeCodeAndSaveTokensRequest`
* `SuperOffice.WebApi.Data.XsrfValue`

### Modified Types

#### SuperOffice.License.SoLicenseNames is Modified

* Deleted items
  * Field `ErpConnect`
  * Field `Mailchimp`
  * Field `Map4You`
  * Field `MsTeamsChat`
* New items
  * Field `ActivityFolders`
  * Field `AiAgent`
  * Field `AiBgRemover`
  * Field `AiFormCopilot`
  * Field `AiMcp`
  * Field `AiText`
  * Field `ConnectErpProfessional`
  * Field `ConnectErpStandard`
  * Field `Map4YouPro`

#### SuperOffice.WebApi.Agents.AIAgent is Modified

* New items
  * Method `AnswerUsingContextAsync(String, String, RagContextIds, RagType, Int32, RequestOptions)`

#### SuperOffice.WebApi.Agents.ContactAgent is Modified

* New items
  * Method `UpdateInterestsAsync(Int32, Int32[], Int32[], RequestOptions)`

#### SuperOffice.WebApi.Agents.DiagnosticsAgent is Modified

* New items
  * Method `RegisterClosedTicketsUsageAsync(Int32[], RequestOptions)`

#### SuperOffice.WebApi.Agents.IAIAgent is Modified

* New items
  * Method `AnswerUsingContextAsync(String, String, RagContextIds, RagType, Int32, RequestOptions)`

#### SuperOffice.WebApi.Agents.IContactAgent is Modified

* New items
  * Method `UpdateInterestsAsync(Int32, Int32[], Int32[], RequestOptions)`

#### SuperOffice.WebApi.Agents.IDiagnosticsAgent is Modified

* New items
  * Method `RegisterClosedTicketsUsageAsync(Int32[], RequestOptions)`

#### SuperOffice.WebApi.Agents.IPersonAgent is Modified

* New items
  * Method `UpdateInterestsAsync(Int32, Int32[], Int32[], RequestOptions)`

#### SuperOffice.WebApi.Agents.IPreferenceAgent is Modified

* New items
  * Method `GetXsrfValueAsync(RequestOptions)`
  * Method `SetXsrfValueAsync(String, RequestOptions)`

#### SuperOffice.WebApi.Agents.ITicketAgent is Modified

* New items
  * Method `SetSpamStatusByIdsAsync(Int32[], RequestOptions)`
  * Method `SetSpamStatusByProviderAsync(String, ArchiveRestrictionInfo[], RequestOptions)`

#### SuperOffice.WebApi.Agents.IUserAgent is Modified

* New items
  * Method `ExchangeCodeAndSaveTokensAsync(String, String, String, String, String, RequestOptions)`

#### SuperOffice.WebApi.Agents.PersonAgent is Modified

* New items
  * Method `UpdateInterestsAsync(Int32, Int32[], Int32[], RequestOptions)`

#### SuperOffice.WebApi.Agents.PreferenceAgent is Modified

* New items
  * Method `GetXsrfValueAsync(RequestOptions)`
  * Method `SetXsrfValueAsync(String, RequestOptions)`

#### SuperOffice.WebApi.Agents.TicketAgent is Modified

* New items
  * Method `SetSpamStatusByIdsAsync(Int32[], RequestOptions)`
  * Method `SetSpamStatusByProviderAsync(String, ArchiveRestrictionInfo[], RequestOptions)`

#### SuperOffice.WebApi.Agents.UserAgent is Modified

* New items
  * Method `ExchangeCodeAndSaveTokensAsync(String, String, String, String, String, RequestOptions)`

#### SuperOffice.WebApi.Data.FunctionRightStrings is Modified

* New items
  * Field `CSMarkAsSpam`

#### SuperOffice.WebApi.Data.TicketBaseStatus is Modified

* New items
  * Field `Spam`

#### SuperOffice.WebApi.Data.TokenManagementInfo is Modified

* New items
  * Property `Claims`


## Web API Authorization

The following represent changes to Web API authorization assemblies.


