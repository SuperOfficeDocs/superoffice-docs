---
title: POST Agents/Appointment/CreateDefaultSuggestedAppointmentEntity
uid: v1AppointmentAgent_CreateDefaultSuggestedAppointmentEntity
generated: true
content_type: reference
---

# POST Agents/Appointment/CreateDefaultSuggestedAppointmentEntity

```http
POST /api/v1/Agents/Appointment/CreateDefaultSuggestedAppointmentEntity
```

Loading default values into a new SuggestedAppointmentEntity.








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
| Type | SoTask | Type of the suggested appointment |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Appointment/CreateDefaultSuggestedAppointmentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SuggestedAppointmentId": 89,
  "Name": "Brakus, Spinka and Conn",
  "Tooltip": "amet",
  "Rank": 533,
  "Deleted": false,
  "DaysFuture": 620,
  "Duration": "est",
  "AutoSuggest": false,
  "IsMilestone": false,
  "AssignToMember": false,
  "Text": "culpa",
  "ProjectTypeStatusLink": null,
  "SaleTypeStageLink": null,
  "Type": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 700
    }
  }
}
```