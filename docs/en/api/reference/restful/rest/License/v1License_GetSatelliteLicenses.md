---
title: GET License/Site/{id}
uid: v1License_GetSatelliteLicenses
generated: true
---

# GET License/Site/{id}

```http
GET /api/v1/License/Site/{satelliteId}
```

Obtain information about satellite module licenses






| Path Part | Type | Description |
|-----------|------|-------------|
| satelliteId | int32 | Satellite id to check for satellite module licenses **Required** |



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
GET /api/v1/License/Site/{satelliteId}
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
    "Name": "Morar Group",
    "Description": "Fundamental even-keeled access",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 867,
        "Tooltip": "est",
        "CanAssign": false,
        "Free": 963,
        "InUse": 944,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 17,
        "Name": "Mitchell-Waters",
        "Description": "User-friendly foreground hub",
        "PrerequisiteModuleName": "Mitchell, Hessel and Dickens",
        "SortOrder": 81,
        "ExtraFlags": 321,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 785
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 395,
        "Tooltip": "quis",
        "CanAssign": false,
        "Free": 30,
        "InUse": 97,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 967,
        "Name": "Larkin Inc and Sons",
        "Description": "Open-architected intangible productivity",
        "PrerequisiteModuleName": "Hayes, Marvin and Leuschke",
        "SortOrder": 150,
        "ExtraFlags": 219,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 250
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 518
      }
    }
  },
  {
    "Name": "Morar Group",
    "Description": "Fundamental even-keeled access",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 867,
        "Tooltip": "est",
        "CanAssign": false,
        "Free": 963,
        "InUse": 944,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 17,
        "Name": "Mitchell-Waters",
        "Description": "User-friendly foreground hub",
        "PrerequisiteModuleName": "Mitchell, Hessel and Dickens",
        "SortOrder": 81,
        "ExtraFlags": 321,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 785
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 395,
        "Tooltip": "quis",
        "CanAssign": false,
        "Free": 30,
        "InUse": 97,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 967,
        "Name": "Larkin Inc and Sons",
        "Description": "Open-architected intangible productivity",
        "PrerequisiteModuleName": "Hayes, Marvin and Leuschke",
        "SortOrder": 150,
        "ExtraFlags": 219,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 250
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 518
      }
    }
  }
]
```