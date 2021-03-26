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
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Schuppe, Schmeler and Braun",
    "Description": "Diverse multimedia knowledge base",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 369,
        "Tooltip": "rerum",
        "CanAssign": true,
        "Free": 175,
        "InUse": 797,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 855,
        "Name": "Funk-Orn",
        "Description": "User-friendly local architecture",
        "PrerequisiteModuleName": "Carter LLC",
        "SortOrder": 900,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 49
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 873,
        "Tooltip": "fugiat",
        "CanAssign": false,
        "Free": 972,
        "InUse": 879,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 977,
        "Name": "Vandervort Group",
        "Description": "Horizontal homogeneous encoding",
        "PrerequisiteModuleName": "Murray, Prosacco and Littel",
        "SortOrder": 396,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "transform dynamic mindshare"
            },
            "FieldType": "System.String",
            "FieldLength": 986
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
        "FieldLength": 665
      }
    }
  },
  {
    "Name": "Schuppe, Schmeler and Braun",
    "Description": "Diverse multimedia knowledge base",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 369,
        "Tooltip": "rerum",
        "CanAssign": true,
        "Free": 175,
        "InUse": 797,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 855,
        "Name": "Funk-Orn",
        "Description": "User-friendly local architecture",
        "PrerequisiteModuleName": "Carter LLC",
        "SortOrder": 900,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 49
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 873,
        "Tooltip": "fugiat",
        "CanAssign": false,
        "Free": 972,
        "InUse": 879,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 977,
        "Name": "Vandervort Group",
        "Description": "Horizontal homogeneous encoding",
        "PrerequisiteModuleName": "Murray, Prosacco and Littel",
        "SortOrder": 396,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "transform dynamic mindshare"
            },
            "FieldType": "System.String",
            "FieldLength": 986
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
        "FieldLength": 665
      }
    }
  }
]
```