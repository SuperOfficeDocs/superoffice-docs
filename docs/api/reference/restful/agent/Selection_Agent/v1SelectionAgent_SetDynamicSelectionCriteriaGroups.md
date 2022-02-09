---
title: POST Agents/Selection/SetDynamicSelectionCriteriaGroups
id: v1SelectionAgent_SetDynamicSelectionCriteriaGroups
---

# POST Agents/Selection/SetDynamicSelectionCriteriaGroups

```http
POST /api/v1/Agents/Selection/SetDynamicSelectionCriteriaGroups
```

Update the criteria for this dynamic selection.

Replaces existing criteria with the new values. This call supports multiple criteria groups.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/SetDynamicSelectionCriteriaGroups?$select=name,department,category/id
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
| Description | string |  |
| Rank | int32 |  |
| Restrictions | array |  |

## Sample Request

```http!
POST /api/v1/Agents/Selection/SetDynamicSelectionCriteriaGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 887,
  "Criteria": [
    {
      "Name": "Maggio, Bernhard and Sanford",
      "Description": "Re-engineered empowering infrastructure",
      "Rank": 17,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Maggio, Bernhard and Sanford",
      "Description": "Re-engineered empowering infrastructure",
      "Rank": 17,
      "Restrictions": [
        {},
        {}
      ]
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Lubowitz, Runte and Corwin",
    "Description": "Networked background methodology",
    "Rank": 550,
    "Restrictions": [
      {
        "Name": "Thompson, Kshlerin and Ritchie",
        "Operator": "quod",
        "Values": [
          "est",
          "ratione"
        ],
        "DisplayValues": [
          "commodi",
          "aut"
        ],
        "ColumnInfo": {},
        "IsActive": true,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 739,
        "InterOperator": "And",
        "UniqueHash": 719
      }
    ]
  },
  {
    "Name": "Lubowitz, Runte and Corwin",
    "Description": "Networked background methodology",
    "Rank": 550,
    "Restrictions": [
      {
        "Name": "Thompson, Kshlerin and Ritchie",
        "Operator": "quod",
        "Values": [
          "est",
          "ratione"
        ],
        "DisplayValues": [
          "commodi",
          "aut"
        ],
        "ColumnInfo": {},
        "IsActive": true,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 739,
        "InterOperator": "And",
        "UniqueHash": 719
      }
    ]
  }
]
```