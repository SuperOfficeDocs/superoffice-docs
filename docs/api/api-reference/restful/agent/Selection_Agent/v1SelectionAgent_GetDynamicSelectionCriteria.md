---
title: GetDynamicSelectionCriteria
id: v1SelectionAgent_GetDynamicSelectionCriteria
---

# GetDynamicSelectionCriteria

```http
POST /api/v1/Agents/Selection/GetDynamicSelectionCriteria
```

Get the criteria for this dynamic selection.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/GetDynamicSelectionCriteria?$select=name,department,category/id
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

SelectionId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SelectionId | int32 |  |


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
POST /api/v1/Agents/Selection/GetDynamicSelectionCriteria
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 865
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Torp, Will and O'Keefe",
    "Operator": "perferendis",
    "Values": [
      "est",
      "eum"
    ],
    "DisplayValues": [
      "corporis",
      "ea"
    ],
    "ColumnInfo": {
      "DisplayName": "Bradtke Group",
      "DisplayTooltip": "et",
      "DisplayType": "ad",
      "CanOrderBy": true,
      "Name": "Glover Inc and Sons",
      "CanRestrictBy": true,
      "RestrictionType": "soluta",
      "RestrictionListName": "Hilpert LLC",
      "IsVisible": true,
      "ExtraInfo": "neque",
      "Width": "quidem",
      "IconHint": "alias",
      "HeadingIconHint": "magnam"
    },
    "IsActive": false,
    "SubRestrictions": [
      {
        "Name": "Schimmel, Tremblay and Hansen",
        "Operator": "tempora",
        "Values": [
          "blanditiis",
          "vero"
        ],
        "DisplayValues": [
          "tempora",
          "perspiciatis"
        ],
        "ColumnInfo": {},
        "IsActive": true,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 743,
        "InterOperator": "And",
        "UniqueHash": 591
      }
    ],
    "InterParenthesis": 503,
    "InterOperator": "And",
    "UniqueHash": 77
  }
]
```