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
      "Name": "Feil LLC",
      "Description": "Diverse uniform product",
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
      "Name": "Feil LLC",
      "Description": "Diverse uniform product",
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
    "Name": "Crist LLC",
    "Description": "Profit-focused asynchronous capability",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 520,
        "Tooltip": "aut",
        "CanAssign": false,
        "Free": 361,
        "InUse": 811,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 673,
        "Name": "Quigley, Hodkiewicz and Schuppe",
        "Description": "Automated mobile access",
        "PrerequisiteModuleName": "Conroy LLC",
        "SortOrder": 831,
        "ExtraFlags": 255,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 99
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 440,
        "Tooltip": "voluptatem",
        "CanAssign": false,
        "Free": 453,
        "InUse": 368,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 561,
        "Name": "Wilkinson, Predovic and Wisozk",
        "Description": "Compatible transitional product",
        "PrerequisiteModuleName": "Schroeder-Barrows",
        "SortOrder": 195,
        "ExtraFlags": 943,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 858
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 178
      }
    }
  },
  {
    "Name": "Crist LLC",
    "Description": "Profit-focused asynchronous capability",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 520,
        "Tooltip": "aut",
        "CanAssign": false,
        "Free": 361,
        "InUse": 811,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 673,
        "Name": "Quigley, Hodkiewicz and Schuppe",
        "Description": "Automated mobile access",
        "PrerequisiteModuleName": "Conroy LLC",
        "SortOrder": 831,
        "ExtraFlags": 255,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 99
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 440,
        "Tooltip": "voluptatem",
        "CanAssign": false,
        "Free": 453,
        "InUse": 368,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 561,
        "Name": "Wilkinson, Predovic and Wisozk",
        "Description": "Compatible transitional product",
        "PrerequisiteModuleName": "Schroeder-Barrows",
        "SortOrder": 195,
        "ExtraFlags": 943,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 858
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 178
      }
    }
  }
]
```