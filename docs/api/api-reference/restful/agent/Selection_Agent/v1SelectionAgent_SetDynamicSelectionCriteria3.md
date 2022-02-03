---
title: POST Agents/Selection/SetDynamicSelectionCriteria3
id: v1SelectionAgent_SetDynamicSelectionCriteria3
---

# POST Agents/Selection/SetDynamicSelectionCriteria3

```http
POST /api/v1/Agents/Selection/SetDynamicSelectionCriteria3
```

Update the criteria for this dynamic selection.

Use criteria as either restriction objects or OData string format. Criteria are parsed from the OData filter form: ''name startswith 'foo' and category in (1,2,3)''





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/SetDynamicSelectionCriteria3?$select=name,department,category/id
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

SelectionId, Criteria, Filter 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SelectionId | int32 |  |
| Criteria | array |  |
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
POST /api/v1/Agents/Selection/SetDynamicSelectionCriteria3
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 459,
  "Criteria": [
    {
      "Name": "Littel-McCullough",
      "Operator": "dolorem",
      "Values": [
        "reiciendis",
        "architecto"
      ],
      "DisplayValues": [
        "ea",
        "ut"
      ],
      "ColumnInfo": {},
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 74,
      "InterOperator": "And",
      "UniqueHash": 407
    }
  ],
  "Filter": "minima"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Kirlin, Sporer and Satterfield",
    "Operator": "aut",
    "Values": [
      "quas",
      "et"
    ],
    "DisplayValues": [
      "est",
      "delectus"
    ],
    "ColumnInfo": {
      "DisplayName": "Lubowitz-Kozey",
      "DisplayTooltip": "autem",
      "DisplayType": "non",
      "CanOrderBy": true,
      "Name": "Quigley, Conroy and Armstrong",
      "CanRestrictBy": true,
      "RestrictionType": "necessitatibus",
      "RestrictionListName": "Jacobson, Erdman and D'Amore",
      "IsVisible": true,
      "ExtraInfo": "hic",
      "Width": "velit",
      "IconHint": "aliquam",
      "HeadingIconHint": "saepe"
    },
    "IsActive": false,
    "SubRestrictions": [
      {
        "Name": "Farrell-Hudson",
        "Operator": "id",
        "Values": [
          "illo",
          "ut"
        ],
        "DisplayValues": [
          "tempore",
          "qui"
        ],
        "ColumnInfo": {},
        "IsActive": true,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 137,
        "InterOperator": "And",
        "UniqueHash": 492
      }
    ],
    "InterParenthesis": 920,
    "InterOperator": "And",
    "UniqueHash": 615
  }
]
```