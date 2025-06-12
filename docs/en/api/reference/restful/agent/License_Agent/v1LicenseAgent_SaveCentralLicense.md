---
title: POST Agents/License/SaveCentralLicense
uid: v1LicenseAgent_SaveCentralLicense
generated: true
---

# POST Agents/License/SaveCentralLicense

```http
POST /api/v1/Agents/License/SaveCentralLicense
```









## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/License/SaveCentralLicense?$select=name,department,category/id
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

License 

| Property Name | Type |  Description |
|----------------|------|--------------|
| License | Array |  |

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
POST /api/v1/Agents/License/SaveCentralLicense
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "License": [
    {
      "Name": "Wilderman Inc and Sons",
      "Description": "Universal regional framework",
      "RestrictedModuleLicenses": [
        {},
        {}
      ],
      "UnrestrictedModuleLicenses": [
        {},
        {}
      ]
    },
    {
      "Name": "Wilderman Inc and Sons",
      "Description": "Universal regional framework",
      "RestrictedModuleLicenses": [
        {},
        {}
      ],
      "UnrestrictedModuleLicenses": [
        {},
        {}
      ]
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Mante-Bednar",
    "Description": "Networked 4th generation definition",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 611,
        "Tooltip": "totam",
        "CanAssign": false,
        "Free": 577,
        "InUse": 869,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 331,
        "Name": "Hauck-Runolfsdottir",
        "Description": "Upgradable disintermediate complexity",
        "PrerequisiteModuleName": "Aufderhar-Dibbert",
        "SortOrder": 934,
        "ExtraFlags": 292,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 604
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 937,
        "Tooltip": "rem",
        "CanAssign": true,
        "Free": 96,
        "InUse": 121,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 466,
        "Name": "Nolan-Wisoky",
        "Description": "Assimilated local flexibility",
        "PrerequisiteModuleName": "Olson Inc and Sons",
        "SortOrder": 331,
        "ExtraFlags": 730,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 409
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 723
      }
    }
  },
  {
    "Name": "Mante-Bednar",
    "Description": "Networked 4th generation definition",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 611,
        "Tooltip": "totam",
        "CanAssign": false,
        "Free": 577,
        "InUse": 869,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 331,
        "Name": "Hauck-Runolfsdottir",
        "Description": "Upgradable disintermediate complexity",
        "PrerequisiteModuleName": "Aufderhar-Dibbert",
        "SortOrder": 934,
        "ExtraFlags": 292,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 604
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 937,
        "Tooltip": "rem",
        "CanAssign": true,
        "Free": 96,
        "InUse": 121,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 466,
        "Name": "Nolan-Wisoky",
        "Description": "Assimilated local flexibility",
        "PrerequisiteModuleName": "Olson Inc and Sons",
        "SortOrder": 331,
        "ExtraFlags": 730,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 409
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 723
      }
    }
  }
]
```