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
    "Name": "Sporer, Bahringer and Lowe",
    "Description": "Function-based high-level circuit",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 314,
        "Tooltip": "consequuntur",
        "CanAssign": false,
        "Free": 819,
        "InUse": 488,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 164,
        "Name": "Hudson-Conroy",
        "Description": "Synchronised optimizing function",
        "PrerequisiteModuleName": "Thompson LLC",
        "SortOrder": 566,
        "ExtraFlags": 142,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 245
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 475,
        "Tooltip": "iste",
        "CanAssign": false,
        "Free": 237,
        "InUse": 884,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 89,
        "Name": "Little LLC",
        "Description": "Centralized transitional time-frame",
        "PrerequisiteModuleName": "Reichert, Kuphal and Lindgren",
        "SortOrder": 516,
        "ExtraFlags": 164,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 101
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 713
      }
    }
  },
  {
    "Name": "Sporer, Bahringer and Lowe",
    "Description": "Function-based high-level circuit",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 314,
        "Tooltip": "consequuntur",
        "CanAssign": false,
        "Free": 819,
        "InUse": 488,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 164,
        "Name": "Hudson-Conroy",
        "Description": "Synchronised optimizing function",
        "PrerequisiteModuleName": "Thompson LLC",
        "SortOrder": 566,
        "ExtraFlags": 142,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 245
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 475,
        "Tooltip": "iste",
        "CanAssign": false,
        "Free": 237,
        "InUse": 884,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 89,
        "Name": "Little LLC",
        "Description": "Centralized transitional time-frame",
        "PrerequisiteModuleName": "Reichert, Kuphal and Lindgren",
        "SortOrder": 516,
        "ExtraFlags": 164,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 101
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 713
      }
    }
  }
]
```