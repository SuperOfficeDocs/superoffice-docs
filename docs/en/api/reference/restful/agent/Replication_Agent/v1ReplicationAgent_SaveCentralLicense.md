---
title: POST Agents/Replication/SaveCentralLicense
uid: v1ReplicationAgent_SaveCentralLicense
generated: true
---

# POST Agents/Replication/SaveCentralLicense

```http
POST /api/v1/Agents/Replication/SaveCentralLicense
```

<para />


## Online Restricted: ## The Replication agent is not available in Online by default. Not available in Online. Only used on-site.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Replication/SaveCentralLicense?$select=name,department,category/id
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
POST /api/v1/Agents/Replication/SaveCentralLicense
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "License": [
    {
      "Name": "Powlowski LLC",
      "Description": "Adaptive web-enabled local area network",
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
      "Name": "Powlowski LLC",
      "Description": "Adaptive web-enabled local area network",
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
    "Name": "Miller, Reinger and Feeney",
    "Description": "Cross-platform stable budgetary management",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 751,
        "Tooltip": "vel",
        "CanAssign": false,
        "Free": 129,
        "InUse": 447,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 966,
        "Name": "Legros Group",
        "Description": "Focused full-range installation",
        "PrerequisiteModuleName": "Jones-D'Amore",
        "SortOrder": 951,
        "ExtraFlags": 118,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 758
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 539,
        "Tooltip": "rerum",
        "CanAssign": false,
        "Free": 529,
        "InUse": 653,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 648,
        "Name": "Upton-Rice",
        "Description": "Business-focused didactic circuit",
        "PrerequisiteModuleName": "Dietrich, Hermann and Ernser",
        "SortOrder": 408,
        "ExtraFlags": 886,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 583
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 488
      }
    }
  },
  {
    "Name": "Miller, Reinger and Feeney",
    "Description": "Cross-platform stable budgetary management",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 751,
        "Tooltip": "vel",
        "CanAssign": false,
        "Free": 129,
        "InUse": 447,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 966,
        "Name": "Legros Group",
        "Description": "Focused full-range installation",
        "PrerequisiteModuleName": "Jones-D'Amore",
        "SortOrder": 951,
        "ExtraFlags": 118,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 758
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 539,
        "Tooltip": "rerum",
        "CanAssign": false,
        "Free": 529,
        "InUse": 653,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 648,
        "Name": "Upton-Rice",
        "Description": "Business-focused didactic circuit",
        "PrerequisiteModuleName": "Dietrich, Hermann and Ernser",
        "SortOrder": 408,
        "ExtraFlags": 886,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 583
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 488
      }
    }
  }
]
```