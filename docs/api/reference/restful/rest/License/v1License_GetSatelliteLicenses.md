---
title: GET License/Site/{id}
id: v1License_GetSatelliteLicenses
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

## Sample Request

```http!
GET /api/v1/License/Site/{satelliteId}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Fadel, Sporer and Jacobs",
    "Description": "Configurable mobile array",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 905,
        "Tooltip": "in",
        "CanAssign": true,
        "Free": 448,
        "InUse": 257,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 658,
        "Name": "Gulgowski LLC",
        "Description": "De-engineered dedicated middleware",
        "PrerequisiteModuleName": "Wolff Inc and Sons",
        "SortOrder": 291,
        "ExtraFlags": 366,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 199
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 247,
        "Tooltip": "hic",
        "CanAssign": false,
        "Free": 725,
        "InUse": 180,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 688,
        "Name": "Lehner, Hamill and Leffler",
        "Description": "Cross-platform encompassing moratorium",
        "PrerequisiteModuleName": "Gerlach, Roberts and Hackett",
        "SortOrder": 699,
        "ExtraFlags": 889,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 427
          }
        }
      }
    ],
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 286
      }
    }
  },
  {
    "Name": "Fadel, Sporer and Jacobs",
    "Description": "Configurable mobile array",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 905,
        "Tooltip": "in",
        "CanAssign": true,
        "Free": 448,
        "InUse": 257,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 658,
        "Name": "Gulgowski LLC",
        "Description": "De-engineered dedicated middleware",
        "PrerequisiteModuleName": "Wolff Inc and Sons",
        "SortOrder": 291,
        "ExtraFlags": 366,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 199
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 247,
        "Tooltip": "hic",
        "CanAssign": false,
        "Free": 725,
        "InUse": 180,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 688,
        "Name": "Lehner, Hamill and Leffler",
        "Description": "Cross-platform encompassing moratorium",
        "PrerequisiteModuleName": "Gerlach, Roberts and Hackett",
        "SortOrder": 699,
        "ExtraFlags": 889,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 427
          }
        }
      }
    ],
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 286
      }
    }
  }
]
```