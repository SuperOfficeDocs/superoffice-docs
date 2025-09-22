---
uid: version_11.4.1157.0_changes
date: 19.09.2025
---

Changes from v11.3.1349 and v11.4.1157.0

### Assembly: SuperOffice.WebApi

### Deleted Types

* `SuperOffice.WebApi.Data.InitalUtmParameters`

### New Types

* `SuperOffice.WebApi.Data.Appointment_GetVideoMeetingConnectedStateRequest`
* `SuperOffice.WebApi.Data.Diagnostics_PerformTasksAfterCustomObjectTableCreatedRequest`
* `SuperOffice.WebApi.Data.Person_SetUtmCreatedPersonContactForFormSubmissionRequest`
* `SuperOffice.WebApi.Data.SavedUtmParameters`
* `SuperOffice.WebApi.Data.Selection_SaveBoardViewSettingsForSelectionAndAssociateRequest`
* `SuperOffice.WebApi.Data.Ticket_AcceptTicketsRequest`
* `SuperOffice.WebApi.Data.User_GetAllDataRightsRequest`
* `SuperOffice.WebApi.Data.UserConnectedState`

### Modified Types

#### SuperOffice.WebApi.Agents.AppointmentAgent is Modified

* New items
  * Method `GetVideoMeetingConnectedStateAsync(RequestOptions)`

#### SuperOffice.WebApi.Agents.DiagnosticsAgent is Modified

* New items
  * Method `PerformTasksAfterCustomObjectTableCreatedAsync(String, RequestOptions)`

#### SuperOffice.WebApi.Agents.IAppointmentAgent is Modified

* New items
  * Method `GetVideoMeetingConnectedStateAsync(RequestOptions)`

#### SuperOffice.WebApi.Agents.IDiagnosticsAgent is Modified

* New items
  * Method `PerformTasksAfterCustomObjectTableCreatedAsync(String, RequestOptions)`

#### SuperOffice.WebApi.Agents.IPersonAgent is Modified

* New items
  * Method `SetUtmCreatedPersonContactForFormSubmissionAsync(Int32, Int32, Int32, RequestOptions)`

#### SuperOffice.WebApi.Agents.ISelectionAgent is Modified

* New items
  * Method `SaveBoardViewSettingsForSelectionAndAssociateAsync(BoardViewSettingsBase, Int32, Int32, RequestOptions)`

#### SuperOffice.WebApi.Agents.ITicketAgent is Modified

* New items
  * Method `AcceptTicketsAsync(Int32[], RequestOptions)`

#### SuperOffice.WebApi.Agents.IUserAgent is Modified

* New items
  * Method `GetAllDataRightsAsync(Int32, RoleRelationToOwner, RequestOptions)`

#### SuperOffice.WebApi.Agents.PersonAgent is Modified

* New items
  * Method `SetUtmCreatedPersonContactForFormSubmissionAsync(Int32, Int32, Int32, RequestOptions)`

#### SuperOffice.WebApi.Agents.SelectionAgent is Modified

* New items
  * Method `SaveBoardViewSettingsForSelectionAndAssociateAsync(BoardViewSettingsBase, Int32, Int32, RequestOptions)`

#### SuperOffice.WebApi.Agents.TicketAgent is Modified

* New items
  * Method `AcceptTicketsAsync(Int32[], RequestOptions)`

#### SuperOffice.WebApi.Agents.UserAgent is Modified

* New items
  * Method `GetAllDataRightsAsync(Int32, RoleRelationToOwner, RequestOptions)`

#### SuperOffice.WebApi.Data.ContactEntity is Modified

* Deleted items
  * Property `InitialUtmParameters`
* New items
  * Property `UtmParameters`

#### SuperOffice.WebApi.Data.PersonEntity is Modified

* Deleted items
  * Property `InitialUtmParameters`
* New items
  * Property `LeadstatusId`
  * Property `UtmParameters`

#### SuperOffice.WebApi.Data.ProjectMember is Modified

* New items
  * Property `Registered`
  * Property `Updated`

#### SuperOffice.WebApi.Data.UserPreferenceStrings is Modified

* Modified items

##### SuperOffice.WebApi.Data.UserPreferenceStrings.DiaryView is Modified

* Deleted items
  * Field `.DiaryViewSecretaryMode`


##### SuperOffice.WebApi.Data.UserPreferenceStrings.SalesNotification is Modified

* Deleted items
  * Field `.SalesNotificationNotifyCompanyAssignment`
* New items
  * Field `.SalesNotificationNotifyContactOwnership`




