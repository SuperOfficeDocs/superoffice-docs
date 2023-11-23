---
title: POST Agents/Appointment/SaveSuggestedAppointmentEntity
uid: v1AppointmentAgent_SaveSuggestedAppointmentEntity
generated: true
---

# POST Agents/Appointment/SaveSuggestedAppointmentEntity

```http
POST /api/v1/Agents/Appointment/SaveSuggestedAppointmentEntity
```

Updates the existing SuggestedAppointmentEntity or creates a new SuggestedAppointmentEntity if the id parameter is empty








## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity 

The SuggestedAppointmentEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SuggestedAppointmentId | Integer | Primary key |
| Name | String | Item name, visible in Guide |
| Tooltip | String | Tooltip / description |
| Rank | Integer | Rank, controls rank of non-instantiated items in Guide |
| Deleted | Boolean | 0 -&gt; record is active 1 -&gt; record is 'deleted' and should not be shown in lists |
| DaysFuture | Integer | How many days into the future the appointment should be scheduled |
| Duration | String | Duration in minutes of suggested appointment |
| AutoSuggest | Boolean | Should this appointment be auto-suggested |
| IsMilestone | Boolean | Is this a milestone activity |
| AssignToMember | Boolean | Should this appointment be assigned to project member |
| Text | String | The suggested text of the new appointment |
| ProjectTypeStatusLink | ProjectTypeStatusLink | Project type and project status link info |
| SaleTypeStageLink | SaleTypeStageLink | Sale type and stage link info |
| Type | Task | Type of the suggested appointment |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: SuggestedAppointmentEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| SuggestedAppointmentId | int32 | Primary key |
| Name | string | Item name, visible in Guide |
| Tooltip | string | Tooltip / description |
| Rank | int32 | Rank, controls rank of non-instantiated items in Guide |
| Deleted | bool | 0 -&gt; record is active 1 -&gt; record is 'deleted' and should not be shown in lists |
| DaysFuture | int32 | How many days into the future the appointment should be scheduled |
| Duration | string | Duration in minutes of suggested appointment |
| AutoSuggest | bool | Should this appointment be auto-suggested |
| IsMilestone | bool | Is this a milestone activity |
| AssignToMember | bool | Should this appointment be assigned to project member |
| Text | string | The suggested text of the new appointment |
| ProjectTypeStatusLink | ProjectTypeStatusLink | Project type and project status link info |
| SaleTypeStageLink | SaleTypeStageLink | Sale type and stage link info |
| Type | Task | Type of the suggested appointment |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Appointment/SaveSuggestedAppointmentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SuggestedAppointmentId": 13,
  "Name": "Hickle LLC",
  "Tooltip": "molestiae",
  "Rank": 751,
  "Deleted": false,
  "DaysFuture": 25,
  "Duration": "ut",
  "AutoSuggest": false,
  "IsMilestone": false,
  "AssignToMember": true,
  "Text": "id",
  "ProjectTypeStatusLink": null,
  "SaleTypeStageLink": null,
  "Type": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SuggestedAppointmentId": 666,
  "Name": "Gleason, Prosacco and Trantow",
  "Tooltip": "exercitationem",
  "Rank": 25,
  "Deleted": true,
  "DaysFuture": 134,
  "Duration": "et",
  "AutoSuggest": true,
  "IsMilestone": true,
  "AssignToMember": false,
  "Text": "et",
  "ProjectTypeStatusLink": null,
  "SaleTypeStageLink": null,
  "Type": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 702
    }
  }
}
```