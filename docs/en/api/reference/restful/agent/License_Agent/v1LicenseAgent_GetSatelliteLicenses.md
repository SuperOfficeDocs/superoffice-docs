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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SatelliteId": 666
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Dooley Inc and Sons",
    "Description": "Quality-focused next generation website",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 971,
        "Tooltip": "maiores",
        "CanAssign": true,
        "Free": 229,
        "InUse": 159,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 453,
        "Name": "Tromp-Will",
        "Description": "Up-sized zero defect flexibility",
        "PrerequisiteModuleName": "Braun Group",
        "SortOrder": 606,
        "ExtraFlags": 363,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 863
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 726,
        "Tooltip": "quisquam",
        "CanAssign": false,
        "Free": 965,
        "InUse": 891,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 15,
        "Name": "Feest Group",
        "Description": "Optimized 6th generation hub",
        "PrerequisiteModuleName": "Bosco-O'Hara",
        "SortOrder": 930,
        "ExtraFlags": 42,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 996
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 483
      }
    }
  },
  {
    "Name": "Dooley Inc and Sons",
    "Description": "Quality-focused next generation website",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 971,
        "Tooltip": "maiores",
        "CanAssign": true,
        "Free": 229,
        "InUse": 159,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 453,
        "Name": "Tromp-Will",
        "Description": "Up-sized zero defect flexibility",
        "PrerequisiteModuleName": "Braun Group",
        "SortOrder": 606,
        "ExtraFlags": 363,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 863
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 726,
        "Tooltip": "quisquam",
        "CanAssign": false,
        "Free": 965,
        "InUse": 891,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 15,
        "Name": "Feest Group",
        "Description": "Optimized 6th generation hub",
        "PrerequisiteModuleName": "Bosco-O'Hara",
        "SortOrder": 930,
        "ExtraFlags": 42,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 996
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 483
      }
    }
  }
]
```