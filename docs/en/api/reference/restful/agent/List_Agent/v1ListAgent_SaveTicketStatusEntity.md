---
title: POST Agents/List/SaveTicketStatusEntity
uid: v1ListAgent_SaveTicketStatusEntity
generated: true
---

# POST Agents/List/SaveTicketStatusEntity

```http
POST /api/v1/Agents/List/SaveTicketStatusEntity
```

Updates the existing TicketStatusEntity or creates a new TicketStatusEntity if the id parameter is empty








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

The TicketStatusEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketStatusId | Integer | The primary key (auto-incremented) |
| Name | String | Name of user defined ticket status |
| Status | String | The &amp;apos;classic&amp;apos; ticket status. I.e. active/closed/postponed/deleted |
| TimeCounter | String | Which field in ticket we count time spent on (queue, internal, external) |
| NoEmailReopen | Boolean | Whether inbound emails can reopen requests with this status or not |
| IsDefault | Boolean | Indicates if status is default one as there might be more than one status with same internal status |
| UsedInQueue | Boolean | If set, status is used in GetNext calculations |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TicketStatusEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketStatusId | int32 | The primary key (auto-incremented) |
| Name | string | Name of user defined ticket status |
| Status | string | The &amp;apos;classic&amp;apos; ticket status. I.e. active/closed/postponed/deleted |
| TimeCounter | string | Which field in ticket we count time spent on (queue, internal, external) |
| NoEmailReopen | bool | Whether inbound emails can reopen requests with this status or not |
| IsDefault | bool | Indicates if status is default one as there might be more than one status with same internal status |
| UsedInQueue | bool | If set, status is used in GetNext calculations |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/List/SaveTicketStatusEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketStatusId": 890,
  "Name": "Senger-Smitham",
  "Status": "Active",
  "TimeCounter": "Externally",
  "NoEmailReopen": false,
  "IsDefault": false,
  "UsedInQueue": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketStatusId": 129,
  "Name": "Denesik, Bode and Runolfsdottir",
  "Status": "Active",
  "TimeCounter": "Externally",
  "NoEmailReopen": false,
  "IsDefault": true,
  "UsedInQueue": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 269
    }
  }
}
```