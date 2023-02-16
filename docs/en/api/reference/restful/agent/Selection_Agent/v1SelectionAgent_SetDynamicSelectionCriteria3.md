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
  "SelectionId": 149,
  "Criteria": [
    {
      "Name": "Doyle LLC",
      "Operator": "doloremque",
      "Values": [
        "eum",
        "rerum"
      ],
      "DisplayValues": [
        "qui",
        "eos"
      ],
      "ColumnInfo": null,
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 456,
      "InterOperator": "And",
      "UniqueHash": 906
    }
  ],
  "Filter": "consectetur"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Runte-Stracke",
    "Operator": "quia",
    "Values": [
      "ut",
      "tempore"
    ],
    "DisplayValues": [
      "ut",
      "labore"
    ],
    "ColumnInfo": null,
    "IsActive": false,
    "SubRestrictions": [
      {
        "Name": "Ruecker, Stanton and Ritchie",
        "Operator": "rerum",
        "Values": [
          "maiores",
          "illo"
        ],
        "DisplayValues": [
          "aut",
          "reprehenderit"
        ],
        "ColumnInfo": null,
        "IsActive": true,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 984,
        "InterOperator": "And",
        "UniqueHash": 26
      }
    ],
    "InterParenthesis": 28,
    "InterOperator": "And",
    "UniqueHash": 1000
  }
]
```