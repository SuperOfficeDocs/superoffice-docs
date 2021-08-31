---
title: GetSatelliteLicenses
id: v1LicenseAgent_GetSatelliteLicenses
---

# GetSatelliteLicenses

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
  "SatelliteId": 930
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Luettgen, Glover and O'Hara",
    "Description": "Public-key grid-enabled success",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 696,
        "Tooltip": "in",
        "CanAssign": true,
        "Free": 539,
        "InUse": 821,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 792,
        "Name": "Harvey, Schultz and Kutch",
        "Description": "Horizontal static matrix",
        "PrerequisiteModuleName": "Hane Group",
        "SortOrder": 801,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 932
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 285,
        "Tooltip": "voluptas",
        "CanAssign": true,
        "Free": 217,
        "InUse": 716,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 997,
        "Name": "Armstrong-Brown",
        "Description": "Multi-layered secondary ability",
        "PrerequisiteModuleName": "Hermiston LLC",
        "SortOrder": 363,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 508
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
        "FieldLength": 93
      }
    }
  },
  {
    "Name": "Luettgen, Glover and O'Hara",
    "Description": "Public-key grid-enabled success",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 696,
        "Tooltip": "in",
        "CanAssign": true,
        "Free": 539,
        "InUse": 821,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 792,
        "Name": "Harvey, Schultz and Kutch",
        "Description": "Horizontal static matrix",
        "PrerequisiteModuleName": "Hane Group",
        "SortOrder": 801,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 932
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 285,
        "Tooltip": "voluptas",
        "CanAssign": true,
        "Free": 217,
        "InUse": 716,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 997,
        "Name": "Armstrong-Brown",
        "Description": "Multi-layered secondary ability",
        "PrerequisiteModuleName": "Hermiston LLC",
        "SortOrder": 363,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 508
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
        "FieldLength": 93
      }
    }
  }
]
```