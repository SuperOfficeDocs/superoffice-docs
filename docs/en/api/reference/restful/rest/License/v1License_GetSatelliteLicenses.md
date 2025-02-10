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
    "Name": "Cormier LLC",
    "Description": "Streamlined non-volatile functionalities",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 192,
        "Tooltip": "dolores",
        "CanAssign": true,
        "Free": 84,
        "InUse": 502,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 925,
        "Name": "Runolfsdottir LLC",
        "Description": "Inverse directional migration",
        "PrerequisiteModuleName": "Lang-Volkman",
        "SortOrder": 58,
        "ExtraFlags": 932,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 268
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 42,
        "Tooltip": "esse",
        "CanAssign": true,
        "Free": 140,
        "InUse": 773,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 470,
        "Name": "Medhurst Group",
        "Description": "Visionary encompassing challenge",
        "PrerequisiteModuleName": "Kautzer, Quigley and Mante",
        "SortOrder": 452,
        "ExtraFlags": 750,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 868
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 269
      }
    }
  },
  {
    "Name": "Cormier LLC",
    "Description": "Streamlined non-volatile functionalities",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 192,
        "Tooltip": "dolores",
        "CanAssign": true,
        "Free": 84,
        "InUse": 502,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 925,
        "Name": "Runolfsdottir LLC",
        "Description": "Inverse directional migration",
        "PrerequisiteModuleName": "Lang-Volkman",
        "SortOrder": 58,
        "ExtraFlags": 932,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 268
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 42,
        "Tooltip": "esse",
        "CanAssign": true,
        "Free": 140,
        "InUse": 773,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 470,
        "Name": "Medhurst Group",
        "Description": "Visionary encompassing challenge",
        "PrerequisiteModuleName": "Kautzer, Quigley and Mante",
        "SortOrder": 452,
        "ExtraFlags": 750,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 868
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 269
      }
    }
  }
]
```