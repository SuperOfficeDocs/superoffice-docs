---
title: POST List/Credited/Items
uid: v1CreditedList_PostCredited
generated: true
---

# POST List/Credited/Items

```http
POST /api/v1/List/Credited/Items
```

Add a new Credited to the list.








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

The Credited to be added to the list. 

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/List/Credited/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Id": 811,
  "Name": "Luettgen, Kautzer and Kiehn",
  "Tooltip": "ipsam",
  "Deleted": true,
  "UdListDefinitionId": 382,
  "Rank": 624
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Id": 174,
  "Name": "Lockman LLC",
  "Tooltip": "velit",
  "Deleted": false,
  "UdListDefinitionId": 16,
  "Rank": 637,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 319
    }
  }
}
```