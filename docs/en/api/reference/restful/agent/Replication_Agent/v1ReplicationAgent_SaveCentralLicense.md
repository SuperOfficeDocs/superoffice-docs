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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "License": [
    {
      "Name": "Graham, Schulist and Streich",
      "Description": "Streamlined high-level infrastructure",
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
      "Name": "Graham, Schulist and Streich",
      "Description": "Streamlined high-level infrastructure",
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
    "Name": "Schmeler, Mueller and Gerhold",
    "Description": "Devolved scalable utilisation",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 326,
        "Tooltip": "earum",
        "CanAssign": false,
        "Free": 858,
        "InUse": 146,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 421,
        "Name": "Prosacco, Kub and Boehm",
        "Description": "Polarised dynamic task-force",
        "PrerequisiteModuleName": "Leannon-Bins",
        "SortOrder": 176,
        "ExtraFlags": 215,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 899
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 922,
        "Tooltip": "minima",
        "CanAssign": false,
        "Free": 700,
        "InUse": 613,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 912,
        "Name": "Rosenbaum, Schaden and Wunsch",
        "Description": "Customer-focused didactic open system",
        "PrerequisiteModuleName": "Witting-Swaniawski",
        "SortOrder": 676,
        "ExtraFlags": 600,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 649
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 485
      }
    }
  },
  {
    "Name": "Schmeler, Mueller and Gerhold",
    "Description": "Devolved scalable utilisation",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 326,
        "Tooltip": "earum",
        "CanAssign": false,
        "Free": 858,
        "InUse": 146,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 421,
        "Name": "Prosacco, Kub and Boehm",
        "Description": "Polarised dynamic task-force",
        "PrerequisiteModuleName": "Leannon-Bins",
        "SortOrder": 176,
        "ExtraFlags": 215,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 899
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 922,
        "Tooltip": "minima",
        "CanAssign": false,
        "Free": 700,
        "InUse": 613,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 912,
        "Name": "Rosenbaum, Schaden and Wunsch",
        "Description": "Customer-focused didactic open system",
        "PrerequisiteModuleName": "Witting-Swaniawski",
        "SortOrder": 676,
        "ExtraFlags": 600,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 649
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 485
      }
    }
  }
]
```