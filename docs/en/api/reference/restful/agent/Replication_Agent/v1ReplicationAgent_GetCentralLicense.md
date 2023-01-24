---
title: POST Agents/Replication/GetCentralLicense
uid: v1ReplicationAgent_GetCentralLicense
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Replication/GetCentralLicense
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Bartell, Brakus and Brown",
    "Description": "Progressive system-worthy pricing structure",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 405,
        "Tooltip": "et",
        "CanAssign": true,
        "Free": 487,
        "InUse": 876,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 110,
        "Name": "Weber-McGlynn",
        "Description": "Upgradable multi-tasking utilisation",
        "PrerequisiteModuleName": "Koepp LLC",
        "SortOrder": 976,
        "ExtraFlags": 768,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 140
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 362,
        "Tooltip": "voluptates",
        "CanAssign": false,
        "Free": 481,
        "InUse": 561,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 364,
        "Name": "Aufderhar Inc and Sons",
        "Description": "Reverse-engineered motivating model",
        "PrerequisiteModuleName": "Raynor Inc and Sons",
        "SortOrder": 205,
        "ExtraFlags": 825,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 370
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 692
      }
    }
  },
  {
    "Name": "Bartell, Brakus and Brown",
    "Description": "Progressive system-worthy pricing structure",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 405,
        "Tooltip": "et",
        "CanAssign": true,
        "Free": 487,
        "InUse": 876,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 110,
        "Name": "Weber-McGlynn",
        "Description": "Upgradable multi-tasking utilisation",
        "PrerequisiteModuleName": "Koepp LLC",
        "SortOrder": 976,
        "ExtraFlags": 768,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 140
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 362,
        "Tooltip": "voluptates",
        "CanAssign": false,
        "Free": 481,
        "InUse": 561,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 364,
        "Name": "Aufderhar Inc and Sons",
        "Description": "Reverse-engineered motivating model",
        "PrerequisiteModuleName": "Raynor Inc and Sons",
        "SortOrder": 205,
        "ExtraFlags": 825,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 370
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 692
      }
    }
  }
]
```