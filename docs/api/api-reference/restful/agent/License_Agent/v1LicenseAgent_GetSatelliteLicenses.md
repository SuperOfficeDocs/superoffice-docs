---
title: POST Agents/License/GetSatelliteLicenses
id: v1LicenseAgent_GetSatelliteLicenses
---

# POST Agents/License/GetSatelliteLicenses

```http
POST /api/v1/Agents/License/GetSatelliteLicenses
```

Obtain information about satellite module licenses







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/License/GetSatelliteLicenses?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

SatelliteId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SatelliteId | int32 |  |


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
POST /api/v1/Agents/License/GetSatelliteLicenses
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SatelliteId": 539
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Rodriguez Group",
    "Description": "Stand-alone user-facing middleware",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 835,
        "Tooltip": "et",
        "CanAssign": true,
        "Free": 251,
        "InUse": 25,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 665,
        "Name": "Quitzon-Hettinger",
        "Description": "Synergistic global algorithm",
        "PrerequisiteModuleName": "Ankunding Inc and Sons",
        "SortOrder": 45,
        "ExtraFlags": 486,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 627
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 40,
        "Tooltip": "voluptatem",
        "CanAssign": false,
        "Free": 341,
        "InUse": 364,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 952,
        "Name": "Grady-Rohan",
        "Description": "Versatile asynchronous knowledge base",
        "PrerequisiteModuleName": "Funk, Schneider and O'Connell",
        "SortOrder": 516,
        "ExtraFlags": 993,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 593
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
          "Reason": "cultivate scalable platforms"
        },
        "FieldType": "System.Int32",
        "FieldLength": 424
      }
    }
  },
  {
    "Name": "Rodriguez Group",
    "Description": "Stand-alone user-facing middleware",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 835,
        "Tooltip": "et",
        "CanAssign": true,
        "Free": 251,
        "InUse": 25,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 665,
        "Name": "Quitzon-Hettinger",
        "Description": "Synergistic global algorithm",
        "PrerequisiteModuleName": "Ankunding Inc and Sons",
        "SortOrder": 45,
        "ExtraFlags": 486,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 627
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 40,
        "Tooltip": "voluptatem",
        "CanAssign": false,
        "Free": 341,
        "InUse": 364,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 952,
        "Name": "Grady-Rohan",
        "Description": "Versatile asynchronous knowledge base",
        "PrerequisiteModuleName": "Funk, Schneider and O'Connell",
        "SortOrder": 516,
        "ExtraFlags": 993,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 593
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
          "Reason": "cultivate scalable platforms"
        },
        "FieldType": "System.Int32",
        "FieldLength": 424
      }
    }
  }
]
```