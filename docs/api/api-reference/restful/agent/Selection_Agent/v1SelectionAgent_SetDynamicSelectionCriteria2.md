---
title: SetDynamicSelectionCriteria2
id: v1SelectionAgent_SetDynamicSelectionCriteria2
---

# SetDynamicSelectionCriteria2

```http
POST /api/v1/Agents/Selection/SetDynamicSelectionCriteria2
```

Update the criteria for this dynamic selection using string.

Criteria are parsed from the OData filter form: ''name startswith 'foo' and category in (1,2,3)''





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/SetDynamicSelectionCriteria2?$select=name,department,category/id
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

SelectionId, Filter 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SelectionId | int32 |  |
| Filter | string |  |


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
POST /api/v1/Agents/Selection/SetDynamicSelectionCriteria2
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 231,
  "Filter": "ea"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Runolfsson, Lindgren and Huel",
    "Operator": "quo",
    "Values": [
      "rerum",
      "nihil"
    ],
    "DisplayValues": [
      "delectus",
      "suscipit"
    ],
    "ColumnInfo": {
      "DisplayName": "Hodkiewicz-Pacocha",
      "DisplayTooltip": "quidem",
      "DisplayType": "itaque",
      "CanOrderBy": false,
      "Name": "Pollich LLC",
      "CanRestrictBy": false,
      "RestrictionType": "atque",
      "RestrictionListName": "Hermiston, Flatley and Boehm",
      "IsVisible": false,
      "ExtraInfo": "accusamus",
      "Width": "dolore",
      "IconHint": "explicabo",
      "HeadingIconHint": "aliquid"
    },
    "IsActive": true,
    "SubRestrictions": [
      {
        "Name": "Kilback, Thompson and Wolf",
        "Operator": "aut",
        "Values": [
          "in",
          "illum"
        ],
        "DisplayValues": [
          "velit",
          "ut"
        ],
        "ColumnInfo": {},
        "IsActive": true,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 854,
        "InterOperator": "And",
        "UniqueHash": 532
      }
    ],
    "InterParenthesis": 685,
    "InterOperator": "And",
    "UniqueHash": 142
  }
]
```