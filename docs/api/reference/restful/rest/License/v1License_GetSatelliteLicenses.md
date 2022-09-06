---
title: GET License/Site/{id}
uid: v1License_GetSatelliteLicenses
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

## Response: array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | The name of the license owner |
| Description | string |  |
| RestrictedModuleLicenses | array |  |
| UnrestrictedModuleLicenses | array | The unrestricted module licenses that this license owner |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/License/Site/{satelliteId}
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
    "Name": "Krajcik LLC",
    "Description": "Face to face upward-trending productivity",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 453,
        "Tooltip": "magni",
        "CanAssign": false,
        "Free": 435,
        "InUse": 616,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 659,
        "Name": "Schimmel LLC",
        "Description": "Managed systematic info-mediaries",
        "PrerequisiteModuleName": "Barrows, Mitchell and Kuhn",
        "SortOrder": 669,
        "ExtraFlags": 784,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 579
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 486,
        "Tooltip": "soluta",
        "CanAssign": false,
        "Free": 408,
        "InUse": 564,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 562,
        "Name": "DuBuque-Kautzer",
        "Description": "Optimized 24/7 local area network",
        "PrerequisiteModuleName": "Konopelski, Rolfson and Emard",
        "SortOrder": 593,
        "ExtraFlags": 199,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 788
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 157
      }
    }
  },
  {
    "Name": "Krajcik LLC",
    "Description": "Face to face upward-trending productivity",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 453,
        "Tooltip": "magni",
        "CanAssign": false,
        "Free": 435,
        "InUse": 616,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 659,
        "Name": "Schimmel LLC",
        "Description": "Managed systematic info-mediaries",
        "PrerequisiteModuleName": "Barrows, Mitchell and Kuhn",
        "SortOrder": 669,
        "ExtraFlags": 784,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 579
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 486,
        "Tooltip": "soluta",
        "CanAssign": false,
        "Free": 408,
        "InUse": 564,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 562,
        "Name": "DuBuque-Kautzer",
        "Description": "Optimized 24/7 local area network",
        "PrerequisiteModuleName": "Konopelski, Rolfson and Emard",
        "SortOrder": 593,
        "ExtraFlags": 199,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 788
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 157
      }
    }
  }
]
```
