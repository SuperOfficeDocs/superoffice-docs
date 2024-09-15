---
title: POST Agents/License/GetSatelliteLicenses
uid: v1LicenseAgent_GetSatelliteLicenses
generated: true
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
| SatelliteId | Integer |  |

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
POST /api/v1/Agents/License/GetSatelliteLicenses
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SatelliteId": 567
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Ritchie Group",
    "Description": "Diverse well-modulated budgetary management",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 364,
        "Tooltip": "suscipit",
        "CanAssign": true,
        "Free": 814,
        "InUse": 170,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 366,
        "Name": "Waelchi, Hills and Hilll",
        "Description": "Switchable disintermediate secured line",
        "PrerequisiteModuleName": "Schulist LLC",
        "SortOrder": 580,
        "ExtraFlags": 514,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 123
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 362,
        "Tooltip": "praesentium",
        "CanAssign": true,
        "Free": 459,
        "InUse": 588,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 795,
        "Name": "Lynch Inc and Sons",
        "Description": "Enhanced methodical challenge",
        "PrerequisiteModuleName": "Hirthe-Schoen",
        "SortOrder": 577,
        "ExtraFlags": 430,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 14
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 608
      }
    }
  },
  {
    "Name": "Ritchie Group",
    "Description": "Diverse well-modulated budgetary management",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 364,
        "Tooltip": "suscipit",
        "CanAssign": true,
        "Free": 814,
        "InUse": 170,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 366,
        "Name": "Waelchi, Hills and Hilll",
        "Description": "Switchable disintermediate secured line",
        "PrerequisiteModuleName": "Schulist LLC",
        "SortOrder": 580,
        "ExtraFlags": 514,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 123
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 362,
        "Tooltip": "praesentium",
        "CanAssign": true,
        "Free": 459,
        "InUse": 588,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 795,
        "Name": "Lynch Inc and Sons",
        "Description": "Enhanced methodical challenge",
        "PrerequisiteModuleName": "Hirthe-Schoen",
        "SortOrder": 577,
        "ExtraFlags": 430,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 14
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 608
      }
    }
  }
]
```