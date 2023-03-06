---
title: GET License/User/{id}
uid: v1License_GetUserLicenses
---

# GET License/User/{id}

```http
GET /api/v1/License/User/{associateId}
```

Obtain information about associate module licenses






| Path Part | Type | Description |
|-----------|------|-------------|
| associateId | int32 | Associate id to check for associate module licenses **Required** |



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


## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | The name of the license owner |
| Description | string |  |
| RestrictedModuleLicenses | array |  |
| UnrestrictedModuleLicenses | array | The unrestricted module licenses that this license owner |
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/License/User/{associateId}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Mayert Inc and Sons",
    "Description": "Persevering grid-enabled knowledge user",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 250,
        "Tooltip": "dolorem",
        "CanAssign": false,
        "Free": 590,
        "InUse": 58,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 307,
        "Name": "Nitzsche-Hickle",
        "Description": "Virtual mission-critical paradigm",
        "PrerequisiteModuleName": "Schumm-Schoen",
        "SortOrder": 519,
        "ExtraFlags": 721,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 11
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 838,
        "Tooltip": "quo",
        "CanAssign": false,
        "Free": 762,
        "InUse": 668,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 820,
        "Name": "Marks Group",
        "Description": "Seamless exuding moderator",
        "PrerequisiteModuleName": "Williamson-Jaskolski",
        "SortOrder": 530,
        "ExtraFlags": 615,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 615
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 865
      }
    }
  },
  {
    "Name": "Mayert Inc and Sons",
    "Description": "Persevering grid-enabled knowledge user",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 250,
        "Tooltip": "dolorem",
        "CanAssign": false,
        "Free": 590,
        "InUse": 58,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 307,
        "Name": "Nitzsche-Hickle",
        "Description": "Virtual mission-critical paradigm",
        "PrerequisiteModuleName": "Schumm-Schoen",
        "SortOrder": 519,
        "ExtraFlags": 721,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 11
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 838,
        "Tooltip": "quo",
        "CanAssign": false,
        "Free": 762,
        "InUse": 668,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 820,
        "Name": "Marks Group",
        "Description": "Seamless exuding moderator",
        "PrerequisiteModuleName": "Williamson-Jaskolski",
        "SortOrder": 530,
        "ExtraFlags": 615,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 615
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 865
      }
    }
  }
]
```