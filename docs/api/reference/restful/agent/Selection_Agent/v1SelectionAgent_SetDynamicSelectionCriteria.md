---
title: POST Agents/Selection/SetDynamicSelectionCriteria
id: v1SelectionAgent_SetDynamicSelectionCriteria
---

# POST Agents/Selection/SetDynamicSelectionCriteria

```http
POST /api/v1/Agents/Selection/SetDynamicSelectionCriteria
```

Update the criteria for this dynamic selection.

Replaces existing criteria with the new values.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/SetDynamicSelectionCriteria?$select=name,department,category/id
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

## Request Body: request  

SelectionId, Criteria 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SelectionId | int32 |  |
| Criteria | array |  |


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
POST /api/v1/Agents/Selection/SetDynamicSelectionCriteria
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 858,
  "Criteria": [
    {
      "Name": "Koepp Group",
      "Operator": "ut",
      "Values": [
        "similique",
        "laudantium"
      ],
      "DisplayValues": [
        "qui",
        "numquam"
      ],
      "ColumnInfo": {},
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 324,
      "InterOperator": "And",
      "UniqueHash": 610
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Greenholt Group",
    "Operator": "iste",
    "Values": [
      "autem",
      "consectetur"
    ],
    "DisplayValues": [
      "minus",
      "nam"
    ],
    "ColumnInfo": {
      "DisplayName": "Rosenbaum, Legros and Ullrich",
      "DisplayTooltip": "aut",
      "DisplayType": "sit",
      "CanOrderBy": false,
      "Name": "Wuckert-Greenholt",
      "CanRestrictBy": false,
      "RestrictionType": "est",
      "RestrictionListName": "Ankunding-Pfannerstill",
      "IsVisible": false,
      "ExtraInfo": "qui",
      "Width": "impedit",
      "IconHint": "error",
      "HeadingIconHint": "possimus"
    },
    "IsActive": true,
    "SubRestrictions": [
      {
        "Name": "Wiza, Purdy and Bergnaum",
        "Operator": "rerum",
        "Values": [
          "et",
          "perspiciatis"
        ],
        "DisplayValues": [
          "atque",
          "dolores"
        ],
        "ColumnInfo": {},
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 885,
        "InterOperator": "And",
        "UniqueHash": 127
      }
    ],
    "InterParenthesis": 692,
    "InterOperator": "And",
    "UniqueHash": 688
  }
]
```