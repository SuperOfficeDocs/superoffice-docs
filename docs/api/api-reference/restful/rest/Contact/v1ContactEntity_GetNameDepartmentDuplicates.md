---
title: GET Contact/Duplicates/{name}
id: v1ContactEntity_GetNameDepartmentDuplicates
---

# GET Contact/Duplicates/{name}

```http
GET /api/v1/Contact/Duplicates/{name}
```

Get duplicates based on the contact name and department






| Path Part | Type | Description |
|-----------|------|-------------|
| name | string | Name used for lookup **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| department | string |  Department used for lookup (if any) |

```http
GET /api/v1/Contact/Duplicates/{name}?department=asperiores
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
| RuleName | string | Identifying name for rule |
| SoPrimaryKey | int32 | Identity of an entry in the SuperOffice database. Should be 0 for matches from external systems. |
| EntryName | string | Name of duplicate entry |
| EntryIdentifier | string | String identifier for entry. Typically used to identify an entry in an external system. |
| RuleDisplayName | string | Short name of rule to display to user |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/Contact/Duplicates/{name}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "RuleName": "Zulauf-Howell",
    "SoPrimaryKey": 669,
    "EntryName": "Swaniawski Inc and Sons",
    "EntryIdentifier": "molestiae",
    "RuleDisplayName": "Douglas, Rogahn and Rogahn",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 14
      }
    }
  }
]
```