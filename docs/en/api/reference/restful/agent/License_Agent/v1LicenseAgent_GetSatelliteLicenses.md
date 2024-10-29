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
  "SatelliteId": 853
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Becker LLC",
    "Description": "Cross-platform modular info-mediaries",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 294,
        "Tooltip": "aspernatur",
        "CanAssign": false,
        "Free": 827,
        "InUse": 906,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 973,
        "Name": "Harris LLC",
        "Description": "Innovative 24 hour moratorium",
        "PrerequisiteModuleName": "Runte, Becker and Bashirian",
        "SortOrder": 995,
        "ExtraFlags": 781,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 520
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 455,
        "Tooltip": "ut",
        "CanAssign": true,
        "Free": 602,
        "InUse": 80,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 902,
        "Name": "Harber LLC",
        "Description": "Multi-layered discrete initiative",
        "PrerequisiteModuleName": "Carroll Inc and Sons",
        "SortOrder": 928,
        "ExtraFlags": 380,
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
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 993
      }
    }
  },
  {
    "Name": "Becker LLC",
    "Description": "Cross-platform modular info-mediaries",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 294,
        "Tooltip": "aspernatur",
        "CanAssign": false,
        "Free": 827,
        "InUse": 906,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 973,
        "Name": "Harris LLC",
        "Description": "Innovative 24 hour moratorium",
        "PrerequisiteModuleName": "Runte, Becker and Bashirian",
        "SortOrder": 995,
        "ExtraFlags": 781,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 520
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 455,
        "Tooltip": "ut",
        "CanAssign": true,
        "Free": 602,
        "InUse": 80,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 902,
        "Name": "Harber LLC",
        "Description": "Multi-layered discrete initiative",
        "PrerequisiteModuleName": "Carroll Inc and Sons",
        "SortOrder": 928,
        "ExtraFlags": 380,
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
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 993
      }
    }
  }
]
```