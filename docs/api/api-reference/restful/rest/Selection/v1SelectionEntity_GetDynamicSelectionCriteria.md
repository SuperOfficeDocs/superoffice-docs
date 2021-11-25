---
title: GET Selection/{id}/Criteria
id: v1SelectionEntity_GetDynamicSelectionCriteria
---

# GET Selection/{id}/Criteria

```http
GET /api/v1/Selection/{selectionId}/Criteria
```

Get the criteria for this dynamic selection.






| Path Part | Type | Description |
|-----------|------|-------------|
| selectionId | int32 | The id of the selection to add members **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
GET /api/v1/Selection/{selectionId}/Criteria
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Beahan, Hirthe and Doyle",
    "Operator": "cumque",
    "Values": [
      "libero",
      "omnis"
    ],
    "DisplayValues": [
      "iusto",
      "facere"
    ],
    "ColumnInfo": {
      "DisplayName": "Rowe Inc and Sons",
      "DisplayTooltip": "veniam",
      "DisplayType": "iure",
      "CanOrderBy": true,
      "Name": "Jewess-D'Amore",
      "CanRestrictBy": false,
      "RestrictionType": "velit",
      "RestrictionListName": "Lindgren-Durgan",
      "IsVisible": false,
      "ExtraInfo": "atque",
      "Width": "enim",
      "IconHint": "molestiae",
      "HeadingIconHint": "porro"
    },
    "IsActive": false,
    "SubRestrictions": [
      {
        "Name": "Zboncak, Schamberger and Turner",
        "Operator": "officia",
        "Values": [
          "quisquam",
          "sit"
        ],
        "DisplayValues": [
          "et",
          "voluptas"
        ],
        "ColumnInfo": {},
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 395,
        "InterOperator": "And",
        "UniqueHash": 32
      }
    ],
    "InterParenthesis": 170,
    "InterOperator": "And",
    "UniqueHash": 139
  }
]
```