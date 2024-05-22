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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Gusikowski-Walsh",
    "Description": "Managed discrete forecast",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 405,
        "Tooltip": "rerum",
        "CanAssign": true,
        "Free": 364,
        "InUse": 481,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 617,
        "Name": "Grady, Walter and Orn",
        "Description": "Sharable non-volatile attitude",
        "PrerequisiteModuleName": "Heaney Inc and Sons",
        "SortOrder": 383,
        "ExtraFlags": 648,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 833
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 624,
        "Tooltip": "et",
        "CanAssign": true,
        "Free": 140,
        "InUse": 870,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 288,
        "Name": "Berge LLC",
        "Description": "Phased actuating neural-net",
        "PrerequisiteModuleName": "Barrows Group",
        "SortOrder": 554,
        "ExtraFlags": 44,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 316
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 502
      }
    }
  },
  {
    "Name": "Gusikowski-Walsh",
    "Description": "Managed discrete forecast",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 405,
        "Tooltip": "rerum",
        "CanAssign": true,
        "Free": 364,
        "InUse": 481,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 617,
        "Name": "Grady, Walter and Orn",
        "Description": "Sharable non-volatile attitude",
        "PrerequisiteModuleName": "Heaney Inc and Sons",
        "SortOrder": 383,
        "ExtraFlags": 648,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 833
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 624,
        "Tooltip": "et",
        "CanAssign": true,
        "Free": 140,
        "InUse": 870,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 288,
        "Name": "Berge LLC",
        "Description": "Phased actuating neural-net",
        "PrerequisiteModuleName": "Barrows Group",
        "SortOrder": 554,
        "ExtraFlags": 44,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 316
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 502
      }
    }
  }
]
```