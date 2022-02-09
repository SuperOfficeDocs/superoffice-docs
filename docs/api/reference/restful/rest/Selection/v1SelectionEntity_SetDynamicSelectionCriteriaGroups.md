---
title: PUT Selection/{id}/CriteriaGroups
id: v1SelectionEntity_SetDynamicSelectionCriteriaGroups
---

# PUT Selection/{id}/CriteriaGroups

```http
PUT /api/v1/Selection/{selectionId}/CriteriaGroups
```

Update the criteria for this dynamic selection.

Replaces existing criteria with the new values. This call supports multiple criteria groups.




| Path Part | Type | Description |
|-----------|------|-------------|
| selectionId | int32 | The id of the selection to add members **Required** |



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

Criteria groups defining the selection result. Empty array is legal, simply means no criteria have been set 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string |  |
| Description | string |  |
| Rank | int32 |  |
| Restrictions | array |  |


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
PUT /api/v1/Selection/{selectionId}/CriteriaGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Walker, Ferry and Feil",
    "Description": "Profit-focused empowering knowledge user",
    "Rank": 236,
    "Restrictions": [
      {
        "Name": "Thompson Group",
        "Operator": "qui",
        "Values": [
          "ipsa",
          "et"
        ],
        "DisplayValues": [
          "esse",
          "praesentium"
        ],
        "ColumnInfo": {},
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 292,
        "InterOperator": "And",
        "UniqueHash": 478
      }
    ]
  },
  {
    "Name": "Walker, Ferry and Feil",
    "Description": "Profit-focused empowering knowledge user",
    "Rank": 236,
    "Restrictions": [
      {
        "Name": "Thompson Group",
        "Operator": "qui",
        "Values": [
          "ipsa",
          "et"
        ],
        "DisplayValues": [
          "esse",
          "praesentium"
        ],
        "ColumnInfo": {},
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 292,
        "InterOperator": "And",
        "UniqueHash": 478
      }
    ]
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Torphy, Hammes and Watsica",
    "Description": "Re-contextualized 24 hour migration",
    "Rank": 276,
    "Restrictions": [
      {
        "Name": "Renner, Fay and Watsica",
        "Operator": "sunt",
        "Values": [
          "dicta",
          "expedita"
        ],
        "DisplayValues": [
          "et",
          "aut"
        ],
        "ColumnInfo": {},
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 359,
        "InterOperator": "And",
        "UniqueHash": 83
      }
    ]
  },
  {
    "Name": "Torphy, Hammes and Watsica",
    "Description": "Re-contextualized 24 hour migration",
    "Rank": 276,
    "Restrictions": [
      {
        "Name": "Renner, Fay and Watsica",
        "Operator": "sunt",
        "Values": [
          "dicta",
          "expedita"
        ],
        "DisplayValues": [
          "et",
          "aut"
        ],
        "ColumnInfo": {},
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 359,
        "InterOperator": "And",
        "UniqueHash": 83
      }
    ]
  }
]
```