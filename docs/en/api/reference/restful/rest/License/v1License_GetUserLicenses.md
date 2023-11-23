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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Weimann LLC",
    "Description": "Pre-emptive 6th generation initiative",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 78,
        "Tooltip": "nihil",
        "CanAssign": false,
        "Free": 488,
        "InUse": 313,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 133,
        "Name": "Romaguera-Hodkiewicz",
        "Description": "Synchronised 4th generation model",
        "PrerequisiteModuleName": "Cormier Inc and Sons",
        "SortOrder": 54,
        "ExtraFlags": 903,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 60
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 166,
        "Tooltip": "non",
        "CanAssign": true,
        "Free": 944,
        "InUse": 338,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 721,
        "Name": "Fadel Inc and Sons",
        "Description": "Decentralized hybrid portal",
        "PrerequisiteModuleName": "Wolf, Cremin and Leffler",
        "SortOrder": 213,
        "ExtraFlags": 631,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 314
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 360
      }
    }
  },
  {
    "Name": "Weimann LLC",
    "Description": "Pre-emptive 6th generation initiative",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 78,
        "Tooltip": "nihil",
        "CanAssign": false,
        "Free": 488,
        "InUse": 313,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 133,
        "Name": "Romaguera-Hodkiewicz",
        "Description": "Synchronised 4th generation model",
        "PrerequisiteModuleName": "Cormier Inc and Sons",
        "SortOrder": 54,
        "ExtraFlags": 903,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 60
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 166,
        "Tooltip": "non",
        "CanAssign": true,
        "Free": 944,
        "InUse": 338,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 721,
        "Name": "Fadel Inc and Sons",
        "Description": "Decentralized hybrid portal",
        "PrerequisiteModuleName": "Wolf, Cremin and Leffler",
        "SortOrder": 213,
        "ExtraFlags": 631,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 314
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 360
      }
    }
  }
]
```