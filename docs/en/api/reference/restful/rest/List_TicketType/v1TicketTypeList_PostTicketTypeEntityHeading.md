---
title: POST List/TicketType/Headings
uid: v1TicketTypeList_PostTicketTypeEntityHeading
generated: true
---

# POST List/TicketType/Headings

```http
POST /api/v1/List/TicketType/Headings
```

Saves a new heading for the TicketTypeEntity list.


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
POST /api/v1/List/TicketType/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "HeadingId": 471,
  "Name": "O'Hara Inc and Sons",
  "Tooltip": "quis",
  "Deleted": false,
  "Rank": 985,
  "UdListDefinitionId": 763
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HeadingId": 179,
  "Name": "Schoen, Little and Rogahn",
  "Tooltip": "dolore",
  "Deleted": true,
  "Rank": 470,
  "UdListDefinitionId": 289,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 724
    }
  }
}
```