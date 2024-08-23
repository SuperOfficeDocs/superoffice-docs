---
title: POST Agents/Replication/GetCentralLicense
uid: v1ReplicationAgent_GetCentralLicense
generated: true
---

# POST Agents/Replication/GetCentralLicense

```http
POST /api/v1/Agents/Replication/GetCentralLicense
```

<para />


## Online Restricted: ## The Replication agent is not available in Online by default. Not available in Online. Only used on-site.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Replication/GetCentralLicense?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
POST /api/v1/Agents/Replication/GetCentralLicense
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Runolfsdottir-Waelchi",
    "Description": "Cross-platform reciprocal info-mediaries",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 889,
        "Tooltip": "nemo",
        "CanAssign": false,
        "Free": 36,
        "InUse": 820,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 150,
        "Name": "Schumm, Swift and Heidenreich",
        "Description": "Future-proofed stable data-warehouse",
        "PrerequisiteModuleName": "Bechtelar-Okuneva",
        "SortOrder": 580,
        "ExtraFlags": 713,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 223
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 170,
        "Tooltip": "voluptate",
        "CanAssign": true,
        "Free": 190,
        "InUse": 54,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 816,
        "Name": "Deckow-Torphy",
        "Description": "Integrated intangible approach",
        "PrerequisiteModuleName": "Bechtelar, Greenfelder and Wilderman",
        "SortOrder": 774,
        "ExtraFlags": 965,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 97
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 190
      }
    }
  },
  {
    "Name": "Runolfsdottir-Waelchi",
    "Description": "Cross-platform reciprocal info-mediaries",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 889,
        "Tooltip": "nemo",
        "CanAssign": false,
        "Free": 36,
        "InUse": 820,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 150,
        "Name": "Schumm, Swift and Heidenreich",
        "Description": "Future-proofed stable data-warehouse",
        "PrerequisiteModuleName": "Bechtelar-Okuneva",
        "SortOrder": 580,
        "ExtraFlags": 713,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 223
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 170,
        "Tooltip": "voluptate",
        "CanAssign": true,
        "Free": 190,
        "InUse": 54,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 816,
        "Name": "Deckow-Torphy",
        "Description": "Integrated intangible approach",
        "PrerequisiteModuleName": "Bechtelar, Greenfelder and Wilderman",
        "SortOrder": 774,
        "ExtraFlags": 965,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 97
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 190
      }
    }
  }
]
```