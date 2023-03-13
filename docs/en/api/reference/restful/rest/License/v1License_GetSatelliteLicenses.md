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
GET /api/v1/License/Site/{satelliteId}
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
    "Name": "Sporer, Spinka and Hammes",
    "Description": "Public-key uniform monitoring",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 326,
        "Tooltip": "voluptates",
        "CanAssign": false,
        "Free": 10,
        "InUse": 958,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 155,
        "Name": "Johns Group",
        "Description": "Fundamental zero defect help-desk",
        "PrerequisiteModuleName": "Reichel Group",
        "SortOrder": 796,
        "ExtraFlags": 645,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 799
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 540,
        "Tooltip": "voluptas",
        "CanAssign": false,
        "Free": 685,
        "InUse": 515,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 76,
        "Name": "Stark Group",
        "Description": "Universal value-added middleware",
        "PrerequisiteModuleName": "Pacocha LLC",
        "SortOrder": 835,
        "ExtraFlags": 852,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 394
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 152
      }
    }
  },
  {
    "Name": "Sporer, Spinka and Hammes",
    "Description": "Public-key uniform monitoring",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 326,
        "Tooltip": "voluptates",
        "CanAssign": false,
        "Free": 10,
        "InUse": 958,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 155,
        "Name": "Johns Group",
        "Description": "Fundamental zero defect help-desk",
        "PrerequisiteModuleName": "Reichel Group",
        "SortOrder": 796,
        "ExtraFlags": 645,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 799
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 540,
        "Tooltip": "voluptas",
        "CanAssign": false,
        "Free": 685,
        "InUse": 515,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 76,
        "Name": "Stark Group",
        "Description": "Universal value-added middleware",
        "PrerequisiteModuleName": "Pacocha LLC",
        "SortOrder": 835,
        "ExtraFlags": 852,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 394
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 152
      }
    }
  }
]
```