---
title: PUT List/SelectionCategory/Items
id: v1SelectionCategoryList_PutAllSelectionCategory
---

# PUT List/SelectionCategory/Items

```http
PUT /api/v1/List/SelectionCategory/Items
```

Update the SelectionCategory list








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

## Request Body: listItems  

All the updated SelectionCategory. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 | The identity of the list item |
| Name | string | The name of the list item |
| Tooltip | string | The tooltip of the list item |
| Deleted | bool | True if the list item is marked as deleted |
| UdListDefinitionId | int32 | The id of the list which this list item belongs to |
| Rank | int32 | The rank of the list item |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 | The identity of the list item |
| Name | string | The name of the list item |
| Tooltip | string | The tooltip of the list item |
| Deleted | bool | True if the list item is marked as deleted |
| UdListDefinitionId | int32 | The id of the list which this list item belongs to |
| Rank | int32 | The rank of the list item |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
PUT /api/v1/List/SelectionCategory/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 972,
    "Name": "McKenzie-Willms",
    "Tooltip": "architecto",
    "Deleted": false,
    "UdListDefinitionId": 505,
    "Rank": 250
  },
  {
    "Id": 972,
    "Name": "McKenzie-Willms",
    "Tooltip": "architecto",
    "Deleted": false,
    "UdListDefinitionId": 505,
    "Rank": 250
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 866,
    "Name": "Lueilwitz, O'Reilly and Prohaska",
    "Tooltip": "voluptas",
    "Deleted": false,
    "UdListDefinitionId": 526,
    "Rank": 902,
    "TableRight": {
      "Mask": "Delete",
      "Reason": "transition granular solutions"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 783
      }
    }
  }
]
```