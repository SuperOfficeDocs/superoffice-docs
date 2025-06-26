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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Rogahn-Breitenberg",
    "Description": "Pre-emptive foreground initiative",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 865,
        "Tooltip": "ut",
        "CanAssign": false,
        "Free": 162,
        "InUse": 467,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 746,
        "Name": "Marvin, Emard and Goodwin",
        "Description": "Ergonomic stable moratorium",
        "PrerequisiteModuleName": "Monahan, Legros and Fay",
        "SortOrder": 945,
        "ExtraFlags": 346,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 622
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 331,
        "Tooltip": "quos",
        "CanAssign": true,
        "Free": 992,
        "InUse": 704,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 159,
        "Name": "Crist, Sawayn and Medhurst",
        "Description": "Focused secondary software",
        "PrerequisiteModuleName": "Nitzsche, Barton and Marvin",
        "SortOrder": 802,
        "ExtraFlags": 383,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 600
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 297
      }
    }
  },
  {
    "Name": "Rogahn-Breitenberg",
    "Description": "Pre-emptive foreground initiative",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 865,
        "Tooltip": "ut",
        "CanAssign": false,
        "Free": 162,
        "InUse": 467,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 746,
        "Name": "Marvin, Emard and Goodwin",
        "Description": "Ergonomic stable moratorium",
        "PrerequisiteModuleName": "Monahan, Legros and Fay",
        "SortOrder": 945,
        "ExtraFlags": 346,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 622
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 331,
        "Tooltip": "quos",
        "CanAssign": true,
        "Free": 992,
        "InUse": 704,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 159,
        "Name": "Crist, Sawayn and Medhurst",
        "Description": "Focused secondary software",
        "PrerequisiteModuleName": "Nitzsche, Barton and Marvin",
        "SortOrder": 802,
        "ExtraFlags": 383,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 600
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 297
      }
    }
  }
]
```