---
uid: version_12.0.342.0_changes
date: 05.06.2026
---

Changes from v11.13.921.0 and v12.0.342.0

## Web API

The following represent changes to the core Web API assembly.

### Assembly: SuperOffice.WebApi

### New Types

* `SuperOffice.WebApi.Data.Configuration_GetLandingPageRequest`
* `SuperOffice.WebApi.Data.Configuration_SetLandingPagePinForAssociateRequest`
* `SuperOffice.WebApi.Data.Dash_GetDashboardFencingInfoRequest`
* `SuperOffice.WebApi.Data.EMail_DeleteFromServerIdentifierRequest`
* `SuperOffice.WebApi.Data.EMail_GetAttachmentFromServerIdentifierRequest`
* `SuperOffice.WebApi.Data.EMail_GetEMailAsStreamFromServerIdentifierRequest`
* `SuperOffice.WebApi.Data.EMail_GetEMailEnvelopesFromServerIdsRequest`
* `SuperOffice.WebApi.Data.EMail_GetEMailFromServerIdentifierRequest`
* `SuperOffice.WebApi.Data.EMail_MarkAsReadFromServerIdentifiersRequest`
* `SuperOffice.WebApi.Data.EMail_MoveToFolderFromServerIdentifierRequest`
* `SuperOffice.WebApi.Data.FencingInfo`
* `SuperOffice.WebApi.Data.LandingPageEntity`
* `SuperOffice.WebApi.Data.License_GetFencingInfoRequest`
* `SuperOffice.WebApi.Data.List_ValidateTicketRelationDefinitionRequest`
* `SuperOffice.WebApi.Data.Project_GetProjectFencingInfoRequest`
* `SuperOffice.WebApi.Data.Ticket_CreateTicketRelationsRequest`
* `SuperOffice.WebApi.Data.Ticket_GetTicketParentIdRequest`
* `SuperOffice.WebApi.Data.Ticket_GetTicketRelationActionsRequest`
* `SuperOffice.WebApi.Data.Ticket_GetTicketRelationsRequest`
* `SuperOffice.WebApi.Data.Ticket_SetTicketParentRequest`
* `SuperOffice.WebApi.Data.Ticket_ValidateTicketRelationsRequest`
* `SuperOffice.WebApi.Data.TicketRelationAction`
* `SuperOffice.WebApi.Data.TicketRelationDefinitionResult`
* `SuperOffice.WebApi.Data.TicketRelationError`
* `SuperOffice.WebApi.Data.TicketRelationItem`
* `SuperOffice.WebApi.Data.TicketRelationResult`
* `SuperOffice.WebApi.Data.WebhookNotifyVia`
* `SuperOffice.WebApi.Data.WebhookNotifyWhen`
* `SuperOffice.WebApi.Data.Workflow_GetWorkflowFencingInfoRequest`

### Modified Types

#### SuperOffice.WebApi.Agents.ConfigurationAgent is Modified

* New items
  * Method `CreateDefaultLandingPageEntityAsync(RequestOptions)`
  * Method `DeleteLandingPageEntityAsync(Int32, RequestOptions)`
  * Method `GetLandingPageAsync(Int32, String, RequestOptions)`
  * Method `GetLandingPageEntityAsync(Int32, RequestOptions)`
  * Method `SaveLandingPageEntityAsync(LandingPageEntity, RequestOptions)`
  * Method `SetLandingPagePinForAssociateAsync(Boolean, Int32, String, String, Int32, RequestOptions)`

#### SuperOffice.WebApi.Agents.DashAgent is Modified

* New items
  * Method `GetDashboardFencingInfoAsync(RequestOptions)`

#### SuperOffice.WebApi.Agents.EMailAgent is Modified

* New items
  * Method `DeleteFromServerIdentifierAsync(EMailConnectionInfo, String[], String, RequestOptions)`
  * Method `GetAttachmentFromServerIdentifierAsync(EMailConnectionInfo, String, String, RequestOptions)`
  * Method `GetEMailAsStreamFromServerIdentifierAsync(EMailConnectionInfo, String, Boolean, String, RequestOptions)`
  * Method `GetEMailEnvelopesFromServerIdsAsync(EMailConnectionInfo, String[], RequestOptions)`
  * Method `GetEMailFromServerIdentifierAsync(EMailConnectionInfo, String, Boolean, EMailFlags, Boolean, RequestOptions)`
  * Method `MarkAsReadFromServerIdentifiersAsync(EMailConnectionInfo, String[], Boolean, RequestOptions)`
  * Method `MoveToFolderFromServerIdentifierAsync(EMailConnectionInfo, String[], String, RequestOptions)`

#### SuperOffice.WebApi.Agents.IConfigurationAgent is Modified

* New items
  * Method `CreateDefaultLandingPageEntityAsync(RequestOptions)`
  * Method `DeleteLandingPageEntityAsync(Int32, RequestOptions)`
  * Method `GetLandingPageAsync(Int32, String, RequestOptions)`
  * Method `GetLandingPageEntityAsync(Int32, RequestOptions)`
  * Method `SaveLandingPageEntityAsync(LandingPageEntity, RequestOptions)`
  * Method `SetLandingPagePinForAssociateAsync(Boolean, Int32, String, String, Int32, RequestOptions)`

#### SuperOffice.WebApi.Agents.IDashAgent is Modified

* New items
  * Method `GetDashboardFencingInfoAsync(RequestOptions)`

#### SuperOffice.WebApi.Agents.IEMailAgent is Modified

* New items
  * Method `DeleteFromServerIdentifierAsync(EMailConnectionInfo, String[], String, RequestOptions)`
  * Method `GetAttachmentFromServerIdentifierAsync(EMailConnectionInfo, String, String, RequestOptions)`
  * Method `GetEMailAsStreamFromServerIdentifierAsync(EMailConnectionInfo, String, Boolean, String, RequestOptions)`
  * Method `GetEMailEnvelopesFromServerIdsAsync(EMailConnectionInfo, String[], RequestOptions)`
  * Method `GetEMailFromServerIdentifierAsync(EMailConnectionInfo, String, Boolean, EMailFlags, Boolean, RequestOptions)`
  * Method `MarkAsReadFromServerIdentifiersAsync(EMailConnectionInfo, String[], Boolean, RequestOptions)`
  * Method `MoveToFolderFromServerIdentifierAsync(EMailConnectionInfo, String[], String, RequestOptions)`

#### SuperOffice.WebApi.Agents.ILicenseAgent is Modified

* New items
  * Method `GetFencingInfoAsync(RequestOptions)`

#### SuperOffice.WebApi.Agents.IListAgent is Modified

* New items
  * Method `ValidateTicketRelationDefinitionAsync(Int32, Int32[], Int32[], TicketRelationType, RequestOptions)`

#### SuperOffice.WebApi.Agents.IProjectAgent is Modified

* New items
  * Method `GetProjectFencingInfoAsync(RequestOptions)`

#### SuperOffice.WebApi.Agents.ITicketAgent is Modified

* New items
  * Method `CreateTicketRelationsAsync(Int32[], Int32, TicketRelationType, String, RequestOptions)`
  * Method `GetTicketParentIdAsync(Int32, RequestOptions)`
  * Method `GetTicketRelationActionsAsync(Int32, Int32, Int32, RequestOptions)`
  * Method `GetTicketRelationsAsync(Int32, RequestOptions)`
  * Method `SetTicketParentAsync(Int32, Int32, String, RequestOptions)`
  * Method `ValidateTicketRelationsAsync(Int32[], Int32, TicketRelationType, RequestOptions)`

#### SuperOffice.WebApi.Agents.IWorkflowAgent is Modified

* New items
  * Method `GetWorkflowFencingInfoAsync(RequestOptions)`

#### SuperOffice.WebApi.Agents.LicenseAgent is Modified

* New items
  * Method `GetFencingInfoAsync(RequestOptions)`

#### SuperOffice.WebApi.Agents.ListAgent is Modified

* New items
  * Method `ValidateTicketRelationDefinitionAsync(Int32, Int32[], Int32[], TicketRelationType, RequestOptions)`

#### SuperOffice.WebApi.Agents.ProjectAgent is Modified

* New items
  * Method `GetProjectFencingInfoAsync(RequestOptions)`

#### SuperOffice.WebApi.Agents.TicketAgent is Modified

* New items
  * Method `CreateTicketRelationsAsync(Int32[], Int32, TicketRelationType, String, RequestOptions)`
  * Method `GetTicketParentIdAsync(Int32, RequestOptions)`
  * Method `GetTicketRelationActionsAsync(Int32, Int32, Int32, RequestOptions)`
  * Method `GetTicketRelationsAsync(Int32, RequestOptions)`
  * Method `SetTicketParentAsync(Int32, Int32, String, RequestOptions)`
  * Method `ValidateTicketRelationsAsync(Int32[], Int32, TicketRelationType, RequestOptions)`

#### SuperOffice.WebApi.Agents.WorkflowAgent is Modified

* New items
  * Method `GetWorkflowFencingInfoAsync(RequestOptions)`

#### SuperOffice.WebApi.Data.EMailAccount is Modified

* New items
  * Property `UseGraphApi`

#### SuperOffice.WebApi.Data.EMailConnectionInfo is Modified

* New items
  * Property `UseGraphApi`

#### SuperOffice.WebApi.Data.EMailConnectionInfoExtended is Modified

* New items
  * Property `UseGraphApi`

#### SuperOffice.WebApi.Data.EMailEntity is Modified

* New items
  * Property `ServerIdentifier`

#### SuperOffice.WebApi.Data.EMailEnvelope is Modified

* New items
  * Property `ServerIdentifier`

#### SuperOffice.WebApi.Data.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.WebApi.Data.UserPreferenceStrings.Mail is Modified

* Deleted items
  * Field `.MailSaveSentInSentItems`


#### SuperOffice.WebApi.Data.Webhook is Modified

* New items
  * Property `ConsecutiveErrors`
  * Property `Description`
  * Property `ErrorAssociates`
  * Property `ErrorEmails`
  * Property `LastError`
  * Property `NotifyVia`
  * Property `NotifyVia_String`
  * Property `NotifyWhen`
  * Property `NotifyWhen_String`
  * Property `TotalCalls`
  * Property `TotalErrors`


## Web API Authorization

The following represent changes to Web API authorization assemblies.


