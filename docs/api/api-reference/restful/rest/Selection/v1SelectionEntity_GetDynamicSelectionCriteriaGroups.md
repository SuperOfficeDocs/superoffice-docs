---
title: GET Selection/{id}/CriteriaGroups
id: v1SelectionEntity_GetDynamicSelectionCriteriaGroups
---

# GET Selection/{id}/CriteriaGroups

```http
GET /api/v1/Selection/{selectionId}/CriteriaGroups
```

Get the criteria for this dynamic selection.

This call supports multiple criteria groups.




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
| Description | string |  |
| Rank | int32 |  |
| Restrictions | array |  |

## Sample Request

```http!
GET /api/v1/Selection/{selectionId}/CriteriaGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Kuphal-Bartoletti",
    "Description": "Exclusive exuding internet solution",
    "Rank": 238,
    "Restrictions": [
      {
        "Name": "Hoppe, Howell and Torp",
        "Operator": "sed",
        "Values": [
          "fugiat",
          "eos"
        ],
        "DisplayValues": [
          "iure",
          "porro"
        ],
        "ColumnInfo": {},
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 739,
        "InterOperator": "And",
        "UniqueHash": 184
      }
    ]
  },
  {
    "Name": "Kuphal-Bartoletti",
    "Description": "Exclusive exuding internet solution",
    "Rank": 238,
    "Restrictions": [
      {
        "Name": "Hoppe, Howell and Torp",
        "Operator": "sed",
        "Values": [
          "fugiat",
          "eos"
        ],
        "DisplayValues": [
          "iure",
          "porro"
        ],
        "ColumnInfo": {},
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 739,
        "InterOperator": "And",
        "UniqueHash": 184
      }
    ]
  }
]
```