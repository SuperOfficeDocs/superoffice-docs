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
      "Name": "Lesch Group",
      "Description": "Cross-platform 3rd generation focus group",
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
      "Name": "Lesch Group",
      "Description": "Cross-platform 3rd generation focus group",
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
    "Name": "Ebert-Lang",
    "Description": "Polarised needs-based algorithm",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 714,
        "Tooltip": "ut",
        "CanAssign": false,
        "Free": 965,
        "InUse": 314,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 969,
        "Name": "Graham-Bosco",
        "Description": "Implemented modular productivity",
        "PrerequisiteModuleName": "Dare, Bernhard and O'Conner",
        "SortOrder": 290,
        "ExtraFlags": 556,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 139
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 841,
        "Tooltip": "commodi",
        "CanAssign": false,
        "Free": 283,
        "InUse": 225,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 759,
        "Name": "Harris, Gerhold and Corkery",
        "Description": "Realigned national solution",
        "PrerequisiteModuleName": "Brown, Bechtelar and McKenzie",
        "SortOrder": 505,
        "ExtraFlags": 718,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 661
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 643
      }
    }
  },
  {
    "Name": "Ebert-Lang",
    "Description": "Polarised needs-based algorithm",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 714,
        "Tooltip": "ut",
        "CanAssign": false,
        "Free": 965,
        "InUse": 314,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 969,
        "Name": "Graham-Bosco",
        "Description": "Implemented modular productivity",
        "PrerequisiteModuleName": "Dare, Bernhard and O'Conner",
        "SortOrder": 290,
        "ExtraFlags": 556,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 139
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 841,
        "Tooltip": "commodi",
        "CanAssign": false,
        "Free": 283,
        "InUse": 225,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 759,
        "Name": "Harris, Gerhold and Corkery",
        "Description": "Realigned national solution",
        "PrerequisiteModuleName": "Brown, Bechtelar and McKenzie",
        "SortOrder": 505,
        "ExtraFlags": 718,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 661
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 643
      }
    }
  }
]
```