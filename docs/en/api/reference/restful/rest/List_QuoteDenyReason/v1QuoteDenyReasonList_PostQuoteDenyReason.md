---
title: POST List/QuoteDenyReason/Items
uid: v1QuoteDenyReasonList_PostQuoteDenyReason
---

# POST List/QuoteDenyReason/Items

```http
POST /api/v1/List/QuoteDenyReason/Items
```

Add a new QuoteDenyReason to the list.








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

## Request Body: newListItem 

The QuoteDenyReason to be added to the list. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | Integer | The identity of the list item |
| Name | String | The name of the list item |
| Tooltip | String | The tooltip of the list item |
| Deleted | Boolean | True if the list item is marked as deleted |
| UdListDefinitionId | Integer | The id of the list which this list item belongs to |
| Rank | Integer | The rank of the list item |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ListItemEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 | The identity of the list item |
| Name | string | The name of the list item |
| Tooltip | string | The tooltip of the list item |
| Deleted | bool | True if the list item is marked as deleted |
| UdListDefinitionId | int32 | The id of the list which this list item belongs to |
| Rank | int32 | The rank of the list item |
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/List/QuoteDenyReason/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Id": 1000,
  "Name": "Abshire, Rice and Kris",
  "Tooltip": "ipsum",
  "Deleted": false,
  "UdListDefinitionId": 335,
  "Rank": 523
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Id": 488,
  "Name": "Vandervort-Mitchell",
  "Tooltip": "vero",
  "Deleted": true,
  "UdListDefinitionId": 615,
  "Rank": 487,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 772
    }
  }
}
```