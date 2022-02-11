---
title: POST Agents/Find/SaveRestrictionGroups
id: v1FindAgent_SaveRestrictionGroups
---

# POST Agents/Find/SaveRestrictionGroups

```http
POST /api/v1/Agents/Find/SaveRestrictionGroups
```

Save and rerank an array of restriction groups, returning the possibly modified array.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/SaveRestrictionGroups?$select=name,department,category/id
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

StorageType, ProviderName, StorageKey, RestrictionGroups, Context 

| Property Name | Type |  Description |
|----------------|------|--------------|
| StorageType | string |  |
| ProviderName | string |  |
| StorageKey | string |  |
| RestrictionGroups | array |  |
| Context | string |  |


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
POST /api/v1/Agents/Find/SaveRestrictionGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "StorageType": "blanditiis",
  "ProviderName": "Jones-Erdman",
  "StorageKey": "voluptatem",
  "RestrictionGroups": [
    {
      "Name": "Adams-Willms",
      "Description": "Fully-configurable discrete ability",
      "Rank": 31,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Adams-Willms",
      "Description": "Fully-configurable discrete ability",
      "Rank": 31,
      "Restrictions": [
        {},
        {}
      ]
    }
  ],
  "Context": "ut"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Johnson, Hahn and Koepp",
    "Description": "Upgradable methodical Graphical User Interface",
    "Rank": 444,
    "Restrictions": [
      {
        "Name": "Roberts Group",
        "Operator": "ex",
        "Values": [
          "nisi",
          "perferendis"
        ],
        "DisplayValues": [
          "eveniet",
          "quas"
        ],
        "ColumnInfo": {},
        "IsActive": true,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 93,
        "InterOperator": "And",
        "UniqueHash": 375
      }
    ]
  },
  {
    "Name": "Johnson, Hahn and Koepp",
    "Description": "Upgradable methodical Graphical User Interface",
    "Rank": 444,
    "Restrictions": [
      {
        "Name": "Roberts Group",
        "Operator": "ex",
        "Values": [
          "nisi",
          "perferendis"
        ],
        "DisplayValues": [
          "eveniet",
          "quas"
        ],
        "ColumnInfo": {},
        "IsActive": true,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 93,
        "InterOperator": "And",
        "UniqueHash": 375
      }
    ]
  }
]
```