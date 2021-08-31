---
title: PopulateRestrictionValues
id: v1FindAgent_PopulateRestrictionValues
---

# PopulateRestrictionValues

```http
POST /api/v1/Agents/Find/PopulateRestrictionValues
```

Take an incoming set of Restrictions (name + operator + any user-entered values), and populate/expand all values as specified by the operator's ValueHints, taking into account any values already there.

Used for dynamic date periods; perhaps others in the future





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/PopulateRestrictionValues?$select=name,department,category/id
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

Restrictions 

| Property Name | Type |  Description |
|----------------|------|--------------|
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
POST /api/v1/Agents/Find/PopulateRestrictionValues
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Restrictions": [
    {
      "Name": "Anderson, Terry and Yost",
      "Operator": "voluptatem",
      "Values": [
        "itaque",
        "maxime"
      ],
      "DisplayValues": [
        "impedit",
        "facere"
      ],
      "ColumnInfo": {},
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 103,
      "InterOperator": "And",
      "UniqueHash": 980
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Luettgen Inc and Sons",
    "Operator": "optio",
    "Values": [
      "quae",
      "eveniet"
    ],
    "DisplayValues": [
      "animi",
      "fugit"
    ],
    "ColumnInfo": {
      "DisplayName": "Stark-Lebsack",
      "DisplayTooltip": "assumenda",
      "DisplayType": "aut",
      "CanOrderBy": true,
      "Name": "Mante-Sanford",
      "CanRestrictBy": false,
      "RestrictionType": "ipsam",
      "RestrictionListName": "Botsford, Dooley and Hamill",
      "IsVisible": false,
      "ExtraInfo": "beatae",
      "Width": "est",
      "IconHint": "corrupti",
      "HeadingIconHint": "explicabo"
    },
    "IsActive": false,
    "SubRestrictions": [
      {
        "Name": "Zemlak, Stamm and Schaefer",
        "Operator": "ipsa",
        "Values": [
          "non",
          "et"
        ],
        "DisplayValues": [
          "in",
          "sit"
        ],
        "ColumnInfo": {},
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 992,
        "InterOperator": "And",
        "UniqueHash": 19
      }
    ],
    "InterParenthesis": 793,
    "InterOperator": "And",
    "UniqueHash": 299
  }
]
```