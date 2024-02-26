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
    "Name": "Kertzmann, Osinski and Pacocha",
    "Description": "Cross-group zero tolerance superstructure",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 320,
        "Tooltip": "animi",
        "CanAssign": false,
        "Free": 31,
        "InUse": 198,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 293,
        "Name": "Mann-Bergstrom",
        "Description": "Customer-focused systemic focus group",
        "PrerequisiteModuleName": "Lubowitz, Bednar and Murray",
        "SortOrder": 16,
        "ExtraFlags": 918,
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
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 319,
        "Tooltip": "modi",
        "CanAssign": false,
        "Free": 843,
        "InUse": 207,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 679,
        "Name": "Klocko, Lynch and Heathcote",
        "Description": "Ameliorated 24 hour customer loyalty",
        "PrerequisiteModuleName": "Prosacco, Kertzmann and Braun",
        "SortOrder": 948,
        "ExtraFlags": 644,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 497
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 551
      }
    }
  },
  {
    "Name": "Kertzmann, Osinski and Pacocha",
    "Description": "Cross-group zero tolerance superstructure",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 320,
        "Tooltip": "animi",
        "CanAssign": false,
        "Free": 31,
        "InUse": 198,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 293,
        "Name": "Mann-Bergstrom",
        "Description": "Customer-focused systemic focus group",
        "PrerequisiteModuleName": "Lubowitz, Bednar and Murray",
        "SortOrder": 16,
        "ExtraFlags": 918,
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
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 319,
        "Tooltip": "modi",
        "CanAssign": false,
        "Free": 843,
        "InUse": 207,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 679,
        "Name": "Klocko, Lynch and Heathcote",
        "Description": "Ameliorated 24 hour customer loyalty",
        "PrerequisiteModuleName": "Prosacco, Kertzmann and Braun",
        "SortOrder": 948,
        "ExtraFlags": 644,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 497
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 551
      }
    }
  }
]
```