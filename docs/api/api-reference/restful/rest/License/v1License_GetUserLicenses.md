---
title: GET License/User/{id}
id: v1License_GetUserLicenses
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
GET /api/v1/License/User/{associateId}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Watsica LLC",
    "Description": "Up-sized global contingency",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 273,
        "Tooltip": "cumque",
        "CanAssign": true,
        "Free": 429,
        "InUse": 802,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 332,
        "Name": "Cronin-Harris",
        "Description": "Devolved zero tolerance circuit",
        "PrerequisiteModuleName": "White-Mertz",
        "SortOrder": 426,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 709
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 480,
        "Tooltip": "expedita",
        "CanAssign": false,
        "Free": 742,
        "InUse": 963,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 824,
        "Name": "Ferry, Konopelski and O'Keefe",
        "Description": "Reactive optimizing artificial intelligence",
        "PrerequisiteModuleName": "Becker, Halvorson and Gaylord",
        "SortOrder": 787,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 83
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
        "FieldType": "System.String",
        "FieldLength": 467
      }
    }
  },
  {
    "Name": "Watsica LLC",
    "Description": "Up-sized global contingency",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 273,
        "Tooltip": "cumque",
        "CanAssign": true,
        "Free": 429,
        "InUse": 802,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 332,
        "Name": "Cronin-Harris",
        "Description": "Devolved zero tolerance circuit",
        "PrerequisiteModuleName": "White-Mertz",
        "SortOrder": 426,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 709
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 480,
        "Tooltip": "expedita",
        "CanAssign": false,
        "Free": 742,
        "InUse": 963,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 824,
        "Name": "Ferry, Konopelski and O'Keefe",
        "Description": "Reactive optimizing artificial intelligence",
        "PrerequisiteModuleName": "Becker, Halvorson and Gaylord",
        "SortOrder": 787,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 83
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
        "FieldType": "System.String",
        "FieldLength": 467
      }
    }
  }
]
```