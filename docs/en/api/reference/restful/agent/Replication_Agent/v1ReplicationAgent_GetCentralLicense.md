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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Murray, Bahringer and Schultz",
    "Description": "Universal zero administration attitude",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 468,
        "Tooltip": "sit",
        "CanAssign": false,
        "Free": 533,
        "InUse": 230,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 598,
        "Name": "Kirlin, Kuphal and O'Kon",
        "Description": "Automated interactive structure",
        "PrerequisiteModuleName": "Schaefer LLC",
        "SortOrder": 683,
        "ExtraFlags": 632,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 541
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 773,
        "Tooltip": "a",
        "CanAssign": false,
        "Free": 621,
        "InUse": 175,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 24,
        "Name": "Fisher, Lemke and Dare",
        "Description": "Customizable systemic help-desk",
        "PrerequisiteModuleName": "Ritchie, Becker and Raynor",
        "SortOrder": 68,
        "ExtraFlags": 787,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 809
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 170
      }
    }
  },
  {
    "Name": "Murray, Bahringer and Schultz",
    "Description": "Universal zero administration attitude",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 468,
        "Tooltip": "sit",
        "CanAssign": false,
        "Free": 533,
        "InUse": 230,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 598,
        "Name": "Kirlin, Kuphal and O'Kon",
        "Description": "Automated interactive structure",
        "PrerequisiteModuleName": "Schaefer LLC",
        "SortOrder": 683,
        "ExtraFlags": 632,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 541
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 773,
        "Tooltip": "a",
        "CanAssign": false,
        "Free": 621,
        "InUse": 175,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 24,
        "Name": "Fisher, Lemke and Dare",
        "Description": "Customizable systemic help-desk",
        "PrerequisiteModuleName": "Ritchie, Becker and Raynor",
        "SortOrder": 68,
        "ExtraFlags": 787,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 809
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 170
      }
    }
  }
]
```