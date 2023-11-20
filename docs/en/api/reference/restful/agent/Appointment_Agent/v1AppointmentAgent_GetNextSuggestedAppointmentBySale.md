---
title: POST Agents/Appointment/GetNextSuggestedAppointmentBySale
uid: v1AppointmentAgent_GetNextSuggestedAppointmentBySale
generated: true
---

# POST Agents/Appointment/GetNextSuggestedAppointmentBySale

```http
POST /api/v1/Agents/Appointment/GetNextSuggestedAppointmentBySale
```

Gets the next suggested appointment for a given sale (or rather a given sale's guide).







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/GetNextSuggestedAppointmentBySale?$select=name,department,category/id
```


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

## Request Body: request 

SaleId, CurrentAppointmentId, SkipCompleteCheck 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SaleId | Integer |  |
| CurrentAppointmentId | Integer |  |
| SkipCompleteCheck | Boolean |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: SuggestedAppointment

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
| Associate | Associate | The owner of the suggested activity. Always the same as the sales owner. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Appointment/GetNextSuggestedAppointmentBySale
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SaleId": 180,
  "CurrentAppointmentId": 370,
  "SkipCompleteCheck": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AutoSuggest": 503,
  "Deleted": 533,
  "DaysFuture": 930,
  "Tooltip": "quo",
  "Text": "velit",
  "TaskId": 828,
  "SuggestedAppointmentId": 238,
  "SaleTypeStageLinkId": 603,
  "RegisteredAssociateId": 552,
  "Rank": 270,
  "ProjectTypeStatusLinkId": 532,
  "Name": "Keebler, Kuhic and Hessel",
  "Duration": 420,
  "Associate": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 407
    }
  }
}
```