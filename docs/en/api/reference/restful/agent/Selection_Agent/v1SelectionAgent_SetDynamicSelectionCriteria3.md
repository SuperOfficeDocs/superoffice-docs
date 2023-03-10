---
title: POST Agents/Selection/SetDynamicSelectionCriteria3
uid: v1SelectionAgent_SetDynamicSelectionCriteria3
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
| SelectionId | Integer |  |
| Criteria | Array |  |
| Filter | String |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string |  |
| Operator | string |  |
| Values | array |  |
| DisplayValues | array |  |
| ColumnInfo | TableRight |  |
| IsActive | bool |  |
| SubRestrictions | array |  |
| InterParenthesis | int32 |  |
| InterOperator | string |  |
| UniqueHash | int32 |  |

## Sample request

```http!
POST /api/v1/Agents/Selection/SetDynamicSelectionCriteria3
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 25,
  "Criteria": [
    {
      "Name": "Dicki, Graham and Daniel",
      "Operator": "ut",
      "Values": [
        "dicta",
        "eligendi"
      ],
      "DisplayValues": [
        "quia",
        "impedit"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 281,
      "InterOperator": "And",
      "UniqueHash": 416
    }
  ],
  "Filter": "et"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Davis, Sauer and Gorczany",
    "Operator": "aut",
    "Values": [
      "ab",
      "sed"
    ],
    "DisplayValues": [
      "aliquid",
      "autem"
    ],
    "ColumnInfo": null,
    "IsActive": true,
    "SubRestrictions": [
      {
        "Name": "Cummings, D'Amore and Doyle",
        "Operator": "molestiae",
        "Values": [
          "est",
          "quisquam"
        ],
        "DisplayValues": [
          "omnis",
          "et"
        ],
        "ColumnInfo": null,
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 987,
        "InterOperator": "And",
        "UniqueHash": 164
      }
    ],
    "InterParenthesis": 876,
    "InterOperator": "And",
    "UniqueHash": 361
  }
]
```