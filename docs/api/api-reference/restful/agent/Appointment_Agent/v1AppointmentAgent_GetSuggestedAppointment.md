---
title: POST Agents/Appointment/GetSuggestedAppointment
id: v1AppointmentAgent_GetSuggestedAppointment
---

# POST Agents/Appointment/GetSuggestedAppointment

```http
POST /api/v1/Agents/Appointment/GetSuggestedAppointment
```

Gets a SuggestedAppointment object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| suggestedAppointmentId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/GetSuggestedAppointment?suggestedAppointmentId=280
POST /api/v1/Agents/Appointment/GetSuggestedAppointment?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

Carrier object for SuggestedAppointment.
Services for the SuggestedAppointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| AutoSuggest | int32 | Should this appointment be auto-suggested |
| Deleted | int32 | 0 -&gt; record is active 1 -&gt; record is 'deleted' and should not be shown in lists |
| DaysFuture | int32 | How many days into the future the appointment should be scheduled |
| Tooltip | string | Tooltip / description |
| Text | string | The suggested text of the new appointment |
| TaskId | int32 | Type of the suggested appointment |
| SuggestedAppointmentId | int32 | Primary key |
| SaleTypeStageLinkId | int32 | Link to saleTypeStageLink, the anchor for sale guide items. Either this OR projectAnchorId should be set, not both at the same time. |
| RegisteredAssociateId | int32 | Registered by whom |
| Rank | int32 | Rank, controls rank of non-instantiated items in Guide |
| ProjectTypeStatusLinkId | int32 | Link to projectTypeStatusLink, the anchor for project guide items. Either this OR saleAnchorId should be set, not both at the same time. |
| Name | string | Item name, visible in Guide |
| Duration | int32 | Duration in minutes of suggested appointment |
| Associate |  | The owner of the suggested activity. Always the same as the sales owner. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Appointment/GetSuggestedAppointment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AutoSuggest": 343,
  "Deleted": 884,
  "DaysFuture": 753,
  "Tooltip": "occaecati",
  "Text": "doloribus",
  "TaskId": 327,
  "SuggestedAppointmentId": 449,
  "SaleTypeStageLinkId": 808,
  "RegisteredAssociateId": 517,
  "Rank": 973,
  "ProjectTypeStatusLinkId": 250,
  "Name": "Parker, Simonis and Walker",
  "Duration": 292,
  "Associate": {
    "AssociateId": 948,
    "Name": "Hills-Brekke",
    "PersonId": 216,
    "Rank": 706,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 199,
    "FullName": "Kassandra Medhurst",
    "FormalName": "Bauch Inc and Sons",
    "Deleted": false,
    "EjUserId": 987,
    "UserName": "Lockman Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 575
      }
    }
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 732
    }
  }
}
```