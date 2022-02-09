---
title: PUT Selection/{id}/Criteria
id: v1SelectionEntity_SetDynamicSelectionCriteria3
---

# PUT Selection/{id}/Criteria

```http
PUT /api/v1/Selection/{selectionId}/Criteria
```

Update the criteria for this dynamic selection.

Use criteria as either restriction objects or OData string format. Criteria are parsed from the OData filter form: ''name startswith 'foo' and category in (1,2,3)''




| Path Part | Type | Description |
|-----------|------|-------------|
| selectionId | int32 | The id of the selection to add members **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $filter | string |  Criteria defining the selection result in OData filter form: `category in (1,2,3) and name = 'foo'`. Pass NULL or empty string '' if using the criteria objects. |

```http
PUT /api/v1/Selection/{selectionId}/Criteria?$filter=name begins 'S'
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

## Request Body: criteria  

Criteria defining the selection result. Pass NULL if using the filter string instead. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string |  |
| Operator | string |  |
| Values | array |  |
| DisplayValues | array |  |
| ColumnInfo |  |  |
| IsActive | bool |  |
| SubRestrictions | array |  |
| InterParenthesis | int32 |  |
| InterOperator | string |  |
| UniqueHash | int32 |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string |  |
| Operator | string |  |
| Values | array |  |
| DisplayValues | array |  |
| ColumnInfo |  |  |
| IsActive | bool |  |
| SubRestrictions | array |  |
| InterParenthesis | int32 |  |
| InterOperator | string |  |
| UniqueHash | int32 |  |

## Sample Request

```http!
PUT /api/v1/Selection/{selectionId}/Criteria
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Schamberger LLC",
    "Operator": "vero",
    "Values": [
      "repudiandae",
      "suscipit"
    ],
    "DisplayValues": [
      "eum",
      "ut"
    ],
    "ColumnInfo": {
      "DisplayName": "Funk-Stoltenberg",
      "DisplayTooltip": "numquam",
      "DisplayType": "pariatur",
      "CanOrderBy": true,
      "Name": "Lebsack-Mitchell",
      "CanRestrictBy": false,
      "RestrictionType": "porro",
      "RestrictionListName": "VonRueden LLC",
      "IsVisible": true,
      "ExtraInfo": "et",
      "Width": "quidem",
      "IconHint": "modi",
      "HeadingIconHint": "aut"
    },
    "IsActive": false,
    "SubRestrictions": [
      {
        "Name": "Schmeler, Stehr and Ebert",
        "Operator": "exercitationem",
        "Values": [
          "ratione",
          "provident"
        ],
        "DisplayValues": [
          "illum",
          "dolore"
        ],
        "ColumnInfo": {},
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 781,
        "InterOperator": "And",
        "UniqueHash": 966
      }
    ],
    "InterParenthesis": 746,
    "InterOperator": "And",
    "UniqueHash": 155
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Mueller-Jacobson",
    "Operator": "nulla",
    "Values": [
      "excepturi",
      "dicta"
    ],
    "DisplayValues": [
      "exercitationem",
      "id"
    ],
    "ColumnInfo": {
      "DisplayName": "Runolfsdottir-Swift",
      "DisplayTooltip": "magni",
      "DisplayType": "in",
      "CanOrderBy": false,
      "Name": "Hirthe LLC",
      "CanRestrictBy": false,
      "RestrictionType": "dolor",
      "RestrictionListName": "Windler LLC",
      "IsVisible": false,
      "ExtraInfo": "quae",
      "Width": "excepturi",
      "IconHint": "corporis",
      "HeadingIconHint": "reprehenderit"
    },
    "IsActive": true,
    "SubRestrictions": [
      {
        "Name": "Kemmer, Beatty and Yundt",
        "Operator": "amet",
        "Values": [
          "quia",
          "sapiente"
        ],
        "DisplayValues": [
          "blanditiis",
          "perspiciatis"
        ],
        "ColumnInfo": {},
        "IsActive": true,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 259,
        "InterOperator": "And",
        "UniqueHash": 774
      }
    ],
    "InterParenthesis": 36,
    "InterOperator": "And",
    "UniqueHash": 708
  }
]
```