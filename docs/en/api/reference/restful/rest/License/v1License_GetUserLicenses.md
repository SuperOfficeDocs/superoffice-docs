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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Schmitt LLC",
    "Description": "Persevering exuding hub",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 671,
        "Tooltip": "nihil",
        "CanAssign": false,
        "Free": 118,
        "InUse": 630,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 886,
        "Name": "Halvorson LLC",
        "Description": "Profound eco-centric migration",
        "PrerequisiteModuleName": "Hand-Lang",
        "SortOrder": 399,
        "ExtraFlags": 180,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 219
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 118,
        "Tooltip": "error",
        "CanAssign": false,
        "Free": 890,
        "InUse": 324,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 559,
        "Name": "Heller-Denesik",
        "Description": "User-friendly optimizing monitoring",
        "PrerequisiteModuleName": "White Group",
        "SortOrder": 57,
        "ExtraFlags": 30,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 531
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 496
      }
    }
  },
  {
    "Name": "Schmitt LLC",
    "Description": "Persevering exuding hub",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 671,
        "Tooltip": "nihil",
        "CanAssign": false,
        "Free": 118,
        "InUse": 630,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 886,
        "Name": "Halvorson LLC",
        "Description": "Profound eco-centric migration",
        "PrerequisiteModuleName": "Hand-Lang",
        "SortOrder": 399,
        "ExtraFlags": 180,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 219
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 118,
        "Tooltip": "error",
        "CanAssign": false,
        "Free": 890,
        "InUse": 324,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 559,
        "Name": "Heller-Denesik",
        "Description": "User-friendly optimizing monitoring",
        "PrerequisiteModuleName": "White Group",
        "SortOrder": 57,
        "ExtraFlags": 30,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 531
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 496
      }
    }
  }
]
```