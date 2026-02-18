---
uid: version_11.10.705.0_changes
date: 18.02.2026
---

Changes from v11.9.1204.0 and v11.10.705.0

### Assembly: SuperOffice.WebApi

### New Types

* `SuperOffice.WebApi.Data.AI_GetFormDesignCssFromImageRequest`
* `SuperOffice.WebApi.Data.AI_GetFormDesignCssFromUrlRequest`
* `SuperOffice.WebApi.Data.FunctionRightStrings`
* `SuperOffice.WebApi.Data.ProjectMemberEventParticipantStatus`

### Modified Types

#### SuperOffice.License.SoLicenseNames is Modified

* New items
  * Field `AdminRole`
  * Field `AiCopilot`
  * Field `AiNLQ`
  * Field `AiServiceCopilot`
  * Field `AiSummarize`
  * Field `AiTranslate`
  * Field `BizCard`
  * Field `BookMyCalendar`
  * Field `CrmScript`
  * Field `DatabridgePro`
  * Field `EnrichCont`
  * Field `ErpConnect`
  * Field `FreeConfigScreens`
  * Field `FreeCustomObjects`
  * Field `FreeReplicationServer`
  * Field `FreeScim`
  * Field `GuideProject`
  * Field `GuideSale`
  * Field `LabelSubst`
  * Field `LeadMgt`
  * Field `Mailchimp`
  * Field `MobileRequest`
  * Field `MsTeams`
  * Field `MsTeamsChat`
  * Field `QuoteApproval`
  * Field `SmartFilter`
  * Field `Synchronizer`
  * Field `TicketLog`
  * Field `TicketType`
  * Field `UniSearch`

#### SuperOffice.WebApi.Agents.AIAgent is Modified

* New items
  * Method `GetFormDesignCssFromImageAsync(Byte[], String[], RequestOptions)`
  * Method `GetFormDesignCssFromUrlAsync(String, String[], RequestOptions)`

#### SuperOffice.WebApi.Agents.IAIAgent is Modified

* New items
  * Method `GetFormDesignCssFromImageAsync(Byte[], String[], RequestOptions)`
  * Method `GetFormDesignCssFromUrlAsync(String, String[], RequestOptions)`

#### SuperOffice.WebApi.Agents.ITicketAgent is Modified

* New items
  * Method `GetTicketRelationEntityAsync(Int32, RequestOptions)`

#### SuperOffice.WebApi.Agents.TicketAgent is Modified

* New items
  * Method `GetTicketRelationEntityAsync(Int32, RequestOptions)`

#### SuperOffice.WebApi.Data.ConfigType is Modified

* New items
  * Field `SubscriptionsOptions`
  * Field `SubscriptionsStyle`

#### SuperOffice.WebApi.Data.FormDesignCarrier is Modified

* New items
  * Property `Confidence`
  * Property `CssStyles`
  * Property `Notes`

#### SuperOffice.WebApi.Data.LicenseStatus is Modified

* New items
  * Field `NewLicenseActivated`

#### SuperOffice.WebApi.Data.Project is Modified

* New items
  * Property `EventId`
  * Property `StartDate`

#### SuperOffice.WebApi.Data.ProjectEntity is Modified

* New items
  * Property `EventId`
  * Property `StartDate`

#### SuperOffice.WebApi.Data.ProjectMember is Modified

* New items
  * Property `EventParticipantStatus`
  * Property `EventParticipantStatus_String`

#### SuperOffice.WebApi.Data.RagStatus is Modified

* Deleted items
  * Property `StatusWebsite`



