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
    "Name": "Blanda, Emmerich and McClure",
    "Description": "Down-sized radical neural-net",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 1000,
        "Tooltip": "sed",
        "CanAssign": false,
        "Free": 189,
        "InUse": 872,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 156,
        "Name": "Berge Group",
        "Description": "Virtual even-keeled focus group",
        "PrerequisiteModuleName": "Little-Treutel",
        "SortOrder": 521,
        "ExtraFlags": 182,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 819
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 844,
        "Tooltip": "voluptas",
        "CanAssign": false,
        "Free": 866,
        "InUse": 96,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 529,
        "Name": "Carroll-Koelpin",
        "Description": "Fully-configurable client-driven open architecture",
        "PrerequisiteModuleName": "Wisoky-Altenwerth",
        "SortOrder": 255,
        "ExtraFlags": 613,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 892
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 372
      }
    }
  },
  {
    "Name": "Blanda, Emmerich and McClure",
    "Description": "Down-sized radical neural-net",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 1000,
        "Tooltip": "sed",
        "CanAssign": false,
        "Free": 189,
        "InUse": 872,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 156,
        "Name": "Berge Group",
        "Description": "Virtual even-keeled focus group",
        "PrerequisiteModuleName": "Little-Treutel",
        "SortOrder": 521,
        "ExtraFlags": 182,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 819
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 844,
        "Tooltip": "voluptas",
        "CanAssign": false,
        "Free": 866,
        "InUse": 96,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 529,
        "Name": "Carroll-Koelpin",
        "Description": "Fully-configurable client-driven open architecture",
        "PrerequisiteModuleName": "Wisoky-Altenwerth",
        "SortOrder": 255,
        "ExtraFlags": 613,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 892
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 372
      }
    }
  }
]
```