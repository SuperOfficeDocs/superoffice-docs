---
title: POST Agents/Find/PopulateRestrictions
id: v1FindAgent_PopulateRestrictions
---

# POST Agents/Find/PopulateRestrictions

```http
POST /api/v1/Agents/Find/PopulateRestrictions
```

Take an incoming set of minimally populated restrictions (name + operator is required), and populate all the other parts of the ArchiveRestrictionInfo structure.

This includes column information, display values (including list value lookup), and calculated/default values where the value hints specify read-only (R).





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/PopulateRestrictions?$select=name,department,category/id
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

ProviderName, Restrictions 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProviderName | string |  |
| Restrictions | array |  |


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
POST /api/v1/Agents/Find/PopulateRestrictions
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProviderName": "Fay, Runolfsson and Durgan",
  "Restrictions": [
    {
      "Name": "Volkman-Ferry",
      "Operator": "voluptatibus",
      "Values": [
        "iusto",
        "a"
      ],
      "DisplayValues": [
        "voluptas",
        "quaerat"
      ],
      "ColumnInfo": {},
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 251,
      "InterOperator": "And",
      "UniqueHash": 616
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Schmidt LLC",
    "Operator": "adipisci",
    "Values": [
      "sit",
      "iusto"
    ],
    "DisplayValues": [
      "voluptas",
      "in"
    ],
    "ColumnInfo": {
      "DisplayName": "Weissnat LLC",
      "DisplayTooltip": "dignissimos",
      "DisplayType": "voluptatem",
      "CanOrderBy": false,
      "Name": "Lockman-Littel",
      "CanRestrictBy": false,
      "RestrictionType": "eos",
      "RestrictionListName": "Kuphal-Halvorson",
      "IsVisible": true,
      "ExtraInfo": "dicta",
      "Width": "autem",
      "IconHint": "error",
      "HeadingIconHint": "iusto"
    },
    "IsActive": true,
    "SubRestrictions": [
      {
        "Name": "Hammes Inc and Sons",
        "Operator": "quo",
        "Values": [
          "libero",
          "iure"
        ],
        "DisplayValues": [
          "quia",
          "blanditiis"
        ],
        "ColumnInfo": {},
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 581,
        "InterOperator": "And",
        "UniqueHash": 252
      }
    ],
    "InterParenthesis": 53,
    "InterOperator": "And",
    "UniqueHash": 657
  }
]
```