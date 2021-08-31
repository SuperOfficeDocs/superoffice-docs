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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "O'Kon-Bayer",
    "Operator": "eveniet",
    "Values": [
      "fuga",
      "ratione"
    ],
    "DisplayValues": [
      "voluptatem",
      "qui"
    ],
    "ColumnInfo": {
      "DisplayName": "Hoeger-Watsica",
      "DisplayTooltip": "doloremque",
      "DisplayType": "debitis",
      "CanOrderBy": false,
      "Name": "Wehner Group",
      "CanRestrictBy": true,
      "RestrictionType": "dolorum",
      "RestrictionListName": "Wehner Inc and Sons",
      "IsVisible": true,
      "ExtraInfo": "dolor",
      "Width": "et",
      "IconHint": "rerum",
      "HeadingIconHint": "voluptatum"
    },
    "IsActive": false,
    "SubRestrictions": [
      {
        "Name": "Carroll, Homenick and Nader",
        "Operator": "officia",
        "Values": [
          "quod",
          "ex"
        ],
        "DisplayValues": [
          "laboriosam",
          "fugit"
        ],
        "ColumnInfo": {},
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 173,
        "InterOperator": "And",
        "UniqueHash": 173
      }
    ],
    "InterParenthesis": 282,
    "InterOperator": "And",
    "UniqueHash": 716
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Zboncak Inc and Sons",
    "Operator": "vel",
    "Values": [
      "qui",
      "voluptates"
    ],
    "DisplayValues": [
      "rerum",
      "commodi"
    ],
    "ColumnInfo": {
      "DisplayName": "Osinski LLC",
      "DisplayTooltip": "placeat",
      "DisplayType": "maiores",
      "CanOrderBy": false,
      "Name": "Tromp-Pfannerstill",
      "CanRestrictBy": true,
      "RestrictionType": "tenetur",
      "RestrictionListName": "Hintz-Sipes",
      "IsVisible": true,
      "ExtraInfo": "odit",
      "Width": "sequi",
      "IconHint": "officia",
      "HeadingIconHint": "aut"
    },
    "IsActive": true,
    "SubRestrictions": [
      {
        "Name": "Littel, Erdman and Funk",
        "Operator": "placeat",
        "Values": [
          "vitae",
          "cumque"
        ],
        "DisplayValues": [
          "et",
          "cumque"
        ],
        "ColumnInfo": {},
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 573,
        "InterOperator": "And",
        "UniqueHash": 513
      }
    ],
    "InterParenthesis": 701,
    "InterOperator": "And",
    "UniqueHash": 226
  }
]
```