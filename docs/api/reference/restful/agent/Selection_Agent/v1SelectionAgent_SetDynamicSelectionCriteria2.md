---
title: POST Agents/Selection/SetDynamicSelectionCriteria2
id: v1SelectionAgent_SetDynamicSelectionCriteria2
---

# POST Agents/Selection/SetDynamicSelectionCriteria2

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 601,
  "Filter": "et"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Champlin LLC",
    "Operator": "sint",
    "Values": [
      "debitis",
      "dolores"
    ],
    "DisplayValues": [
      "excepturi",
      "enim"
    ],
    "ColumnInfo": {
      "DisplayName": "Bogan-Rowe",
      "DisplayTooltip": "distinctio",
      "DisplayType": "voluptas",
      "CanOrderBy": false,
      "Name": "Walsh Inc and Sons",
      "CanRestrictBy": true,
      "RestrictionType": "nisi",
      "RestrictionListName": "Roberts Group",
      "IsVisible": false,
      "ExtraInfo": "quo",
      "Width": "sunt",
      "IconHint": "ex",
      "HeadingIconHint": "necessitatibus"
    },
    "IsActive": true,
    "SubRestrictions": [
      {
        "Name": "Leuschke Inc and Sons",
        "Operator": "aut",
        "Values": [
          "et",
          "quo"
        ],
        "DisplayValues": [
          "voluptas",
          "in"
        ],
        "ColumnInfo": {},
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 295,
        "InterOperator": "And",
        "UniqueHash": 204
      }
    ],
    "InterParenthesis": 597,
    "InterOperator": "And",
    "UniqueHash": 824
  }
]
```