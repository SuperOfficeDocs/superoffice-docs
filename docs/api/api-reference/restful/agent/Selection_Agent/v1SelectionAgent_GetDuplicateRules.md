---
title: POST Agents/Selection/GetDuplicateRules
id: v1SelectionAgent_GetDuplicateRules
---

# POST Agents/Selection/GetDuplicateRules

```http
POST /api/v1/Agents/Selection/GetDuplicateRules
```

Retrieve all available duplicate rules for selection







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/GetDuplicateRules?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | Identifying name for rule |
| DisplayName | string | Short name of rule to display to user |
| DisplayTooltip | string | Description of the rule |
| IsActive | bool | Indicating if a rule is current active, and should included in the duplicate detection |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Selection/GetDuplicateRules
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Tillman-Collier",
    "DisplayName": "Murray, Walter and Kreiger",
    "DisplayTooltip": "a",
    "IsActive": true,
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "engage e-business e-markets"
        },
        "FieldType": "System.String",
        "FieldLength": 203
      }
    }
  },
  {
    "Name": "Tillman-Collier",
    "DisplayName": "Murray, Walter and Kreiger",
    "DisplayTooltip": "a",
    "IsActive": true,
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "engage e-business e-markets"
        },
        "FieldType": "System.String",
        "FieldLength": 203
      }
    }
  }
]
```