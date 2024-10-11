---
title: GET License/User/{id}
uid: v1License_GetUserLicenses
generated: true
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/License/User/{associateId}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Hamill LLC",
    "Description": "Team-oriented demand-driven core",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 248,
        "Tooltip": "nostrum",
        "CanAssign": true,
        "Free": 279,
        "InUse": 408,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 490,
        "Name": "Gerhold-Nitzsche",
        "Description": "Secured executive instruction set",
        "PrerequisiteModuleName": "Schinner, Grady and Stroman",
        "SortOrder": 22,
        "ExtraFlags": 933,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 552
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 398,
        "Tooltip": "soluta",
        "CanAssign": true,
        "Free": 811,
        "InUse": 709,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 886,
        "Name": "Tromp, Kuphal and Mills",
        "Description": "Customer-focused heuristic productivity",
        "PrerequisiteModuleName": "Leffler Inc and Sons",
        "SortOrder": 87,
        "ExtraFlags": 154,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 160
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 527
      }
    }
  },
  {
    "Name": "Hamill LLC",
    "Description": "Team-oriented demand-driven core",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 248,
        "Tooltip": "nostrum",
        "CanAssign": true,
        "Free": 279,
        "InUse": 408,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 490,
        "Name": "Gerhold-Nitzsche",
        "Description": "Secured executive instruction set",
        "PrerequisiteModuleName": "Schinner, Grady and Stroman",
        "SortOrder": 22,
        "ExtraFlags": 933,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 552
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 398,
        "Tooltip": "soluta",
        "CanAssign": true,
        "Free": 811,
        "InUse": 709,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 886,
        "Name": "Tromp, Kuphal and Mills",
        "Description": "Customer-focused heuristic productivity",
        "PrerequisiteModuleName": "Leffler Inc and Sons",
        "SortOrder": 87,
        "ExtraFlags": 154,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 160
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 527
      }
    }
  }
]
```