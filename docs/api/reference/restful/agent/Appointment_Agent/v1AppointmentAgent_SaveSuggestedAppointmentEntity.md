---
title: POST Agents/Appointment/SaveSuggestedAppointmentEntity
uid: v1AppointmentAgent_SaveSuggestedAppointmentEntity
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
| ProjectTypeStatusLink |  | Project type and project status link info |
| SaleTypeStageLink |  | Sale type and stage link info |
| Type |  | Type of the suggested appointment |

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

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
| ProjectTypeStatusLink |  | Project type and project status link info |
| SaleTypeStageLink |  | Sale type and stage link info |
| Type |  | Type of the suggested appointment |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Appointment/SaveSuggestedAppointmentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SuggestedAppointmentId": 930,
  "Name": "Daniel-Goldner",
  "Tooltip": "expedita",
  "Rank": 195,
  "Deleted": false,
  "DaysFuture": 888,
  "Duration": "eos",
  "AutoSuggest": false,
  "IsMilestone": false,
  "AssignToMember": true,
  "Text": "eius",
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
  "SuggestedAppointmentId": 724,
  "Name": "Oberbrunner-Yundt",
  "Tooltip": "qui",
  "Rank": 781,
  "Deleted": false,
  "DaysFuture": 349,
  "Duration": "corporis",
  "AutoSuggest": false,
  "IsMilestone": false,
  "AssignToMember": false,
  "Text": "quam",
  "ProjectTypeStatusLink": null,
  "SaleTypeStageLink": null,
  "Type": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 779
    }
  }
}
```
