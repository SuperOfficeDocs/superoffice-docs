---
title: POST List/TicketStatus/Headings
uid: v1TicketStatusList_PostTicketStatusEntityHeading
generated: true
---

# POST List/TicketStatus/Headings

```http
POST /api/v1/List/TicketStatus/Headings
```

Saves a new heading for the TicketStatusEntity list.


Calls the List agent service SaveHeadingFromListDefinition.







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

## Request Body: newEntity 

The heading to be added. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| HeadingId | Integer | Primary key |
| Name | String | The visible heading |
| Tooltip | String | Tooltip or other description |
| Deleted | Boolean | True if the heading is marked as deleted |
| Rank | Integer | Rank order |
| UdListDefinitionId | Integer | The id of the list which this heading belongs to |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: HeadingEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| HeadingId | int32 | Primary key |
| Name | string | The visible heading |
| Tooltip | string | Tooltip or other description |
| Deleted | bool | True if the heading is marked as deleted |
| Rank | int32 | Rank order |
| UdListDefinitionId | int32 | The id of the list which this heading belongs to |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/List/TicketStatus/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "HeadingId": 574,
  "Name": "Marquardt-Kuvalis",
  "Tooltip": "eos",
  "Deleted": false,
  "Rank": 180,
  "UdListDefinitionId": 514
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HeadingId": 341,
  "Name": "Hermiston, Hoppe and Hegmann",
  "Tooltip": "in",
  "Deleted": false,
  "Rank": 436,
  "UdListDefinitionId": 372,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 659
    }
  }
}
```