---
title: PUT List/ProductType/Headings
uid: v1ProductTypeList_PutProductTypeHeadings
generated: true
---

# PUT List/ProductType/Headings

```http
PUT /api/v1/List/ProductType/Headings
```

Saves headings for the ProductType list.


Calls the List agent service SaveHeadingsFromListDefinition.







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

## Request Body: entities 

The headings to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| HeadingId | Integer | Primary key |
| Name | String | The visible heading |
| Tooltip | String | Tooltip or other description |
| Deleted | Boolean | True if the heading is marked as deleted |
| Rank | Integer | Rank order |
| UdListDefinitionId | Integer | The id of the list which this heading belongs to |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
PUT /api/v1/List/ProductType/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "HeadingId": 779,
    "Name": "Hessel, Wilderman and McCullough",
    "Tooltip": "laborum",
    "Deleted": false,
    "Rank": 183,
    "UdListDefinitionId": 398
  },
  {
    "HeadingId": 779,
    "Name": "Hessel, Wilderman and McCullough",
    "Tooltip": "laborum",
    "Deleted": false,
    "Rank": 183,
    "UdListDefinitionId": 398
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "HeadingId": 745,
    "Name": "Franecki Inc and Sons",
    "Tooltip": "aut",
    "Deleted": true,
    "Rank": 763,
    "UdListDefinitionId": 189,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 162
      }
    }
  }
]
```