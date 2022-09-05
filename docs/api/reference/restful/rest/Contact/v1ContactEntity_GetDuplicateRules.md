---
title: GET Contact/DuplicateRules
uid: v1ContactEntity_GetDuplicateRules
---

# GET Contact/DuplicateRules

```http
GET /api/v1/Contact/DuplicateRules
```

Retrieve all available duplicate rules for contact








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

OK

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

## Sample request

```http!
GET /api/v1/Contact/DuplicateRules
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Sanford Group",
    "DisplayName": "Schinner, Marquardt and Kozey",
    "DisplayTooltip": "nisi",
    "IsActive": false,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 988
      }
    }
  },
  {
    "Name": "Sanford Group",
    "DisplayName": "Schinner, Marquardt and Kozey",
    "DisplayTooltip": "nisi",
    "IsActive": false,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 988
      }
    }
  }
]
```