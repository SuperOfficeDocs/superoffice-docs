---
title: POST Agents/Selection/SetDynamicSelectionCriteriaGroups
uid: v1SelectionAgent_SetDynamicSelectionCriteriaGroups
generated: true
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
| SelectionId | Integer |  |
| Criteria | Array |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | Name of the group |
| Description | string | Description of the group |
| Rank | int32 | Rank of group among groups |
| Restrictions | array |  |

## Sample request

```http!
POST /api/v1/Agents/Selection/SetDynamicSelectionCriteriaGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 875,
  "Criteria": [
    {
      "Name": "Gutkowski-Heaney",
      "Description": "Multi-tiered composite local area network",
      "Rank": 107,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Gutkowski-Heaney",
      "Description": "Multi-tiered composite local area network",
      "Rank": 107,
      "Restrictions": [
        {},
        {}
      ]
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Beahan, Glover and Reilly",
    "Description": "Exclusive multi-tasking approach",
    "Rank": 455,
    "Restrictions": [
      {
        "Name": "Lubowitz, Wiza and White",
        "Operator": "quisquam",
        "Values": [
          "sed",
          "atque"
        ],
        "DisplayValues": [
          "exercitationem",
          "voluptate"
        ],
        "ColumnInfo": null,
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 845,
        "InterOperator": "And",
        "UniqueHash": 995
      }
    ]
  },
  {
    "Name": "Beahan, Glover and Reilly",
    "Description": "Exclusive multi-tasking approach",
    "Rank": 455,
    "Restrictions": [
      {
        "Name": "Lubowitz, Wiza and White",
        "Operator": "quisquam",
        "Values": [
          "sed",
          "atque"
        ],
        "DisplayValues": [
          "exercitationem",
          "voluptate"
        ],
        "ColumnInfo": null,
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 845,
        "InterOperator": "And",
        "UniqueHash": 995
      }
    ]
  }
]
```