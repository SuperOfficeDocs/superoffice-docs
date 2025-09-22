---
title: POST Agents/License/GetUserLicenses
uid: v1LicenseAgent_GetUserLicenses
generated: true
content_type: reference
---

# POST Agents/License/GetUserLicenses

```http
POST /api/v1/Agents/License/GetUserLicenses
```

Obtain information about associate module licenses







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/License/GetUserLicenses?$select=name,department,category/id
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

AssociateId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | Integer |  |

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
POST /api/v1/Agents/License/GetUserLicenses
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 462
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Pacocha Inc and Sons",
    "Description": "Multi-channelled encompassing collaboration",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 402,
        "Tooltip": "dicta",
        "CanAssign": false,
        "Free": 36,
        "InUse": 882,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 905,
        "Name": "Gleason LLC",
        "Description": "Compatible optimizing hierarchy",
        "PrerequisiteModuleName": "Stokes-Beier",
        "SortOrder": 357,
        "ExtraFlags": 813,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 519
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 834,
        "Tooltip": "accusamus",
        "CanAssign": false,
        "Free": 808,
        "InUse": 969,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 961,
        "Name": "Kling LLC",
        "Description": "Optimized motivating project",
        "PrerequisiteModuleName": "Kirlin-Daniel",
        "SortOrder": 437,
        "ExtraFlags": 925,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 70
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 136
      }
    }
  },
  {
    "Name": "Pacocha Inc and Sons",
    "Description": "Multi-channelled encompassing collaboration",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 402,
        "Tooltip": "dicta",
        "CanAssign": false,
        "Free": 36,
        "InUse": 882,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 905,
        "Name": "Gleason LLC",
        "Description": "Compatible optimizing hierarchy",
        "PrerequisiteModuleName": "Stokes-Beier",
        "SortOrder": 357,
        "ExtraFlags": 813,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 519
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 834,
        "Tooltip": "accusamus",
        "CanAssign": false,
        "Free": 808,
        "InUse": 969,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 961,
        "Name": "Kling LLC",
        "Description": "Optimized motivating project",
        "PrerequisiteModuleName": "Kirlin-Daniel",
        "SortOrder": 437,
        "ExtraFlags": 925,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 70
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 136
      }
    }
  }
]
```