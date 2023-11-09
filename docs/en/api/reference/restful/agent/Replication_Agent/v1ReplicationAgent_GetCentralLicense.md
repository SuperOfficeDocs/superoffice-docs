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
    "Name": "Jacobs Group",
    "Description": "Focused transitional framework",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 659,
        "Tooltip": "autem",
        "CanAssign": false,
        "Free": 3,
        "InUse": 237,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 150,
        "Name": "Dare, Boehm and Miller",
        "Description": "Sharable disintermediate portal",
        "PrerequisiteModuleName": "Funk-Bogisich",
        "SortOrder": 165,
        "ExtraFlags": 550,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 878
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 279,
        "Tooltip": "debitis",
        "CanAssign": false,
        "Free": 189,
        "InUse": 358,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 527,
        "Name": "O'Hara-Jast",
        "Description": "Monitored impactful complexity",
        "PrerequisiteModuleName": "Macejkovic, Mitchell and Halvorson",
        "SortOrder": 213,
        "ExtraFlags": 84,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 623
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 211
      }
    }
  },
  {
    "Name": "Jacobs Group",
    "Description": "Focused transitional framework",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 659,
        "Tooltip": "autem",
        "CanAssign": false,
        "Free": 3,
        "InUse": 237,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 150,
        "Name": "Dare, Boehm and Miller",
        "Description": "Sharable disintermediate portal",
        "PrerequisiteModuleName": "Funk-Bogisich",
        "SortOrder": 165,
        "ExtraFlags": 550,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 878
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 279,
        "Tooltip": "debitis",
        "CanAssign": false,
        "Free": 189,
        "InUse": 358,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 527,
        "Name": "O'Hara-Jast",
        "Description": "Monitored impactful complexity",
        "PrerequisiteModuleName": "Macejkovic, Mitchell and Halvorson",
        "SortOrder": 213,
        "ExtraFlags": 84,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 623
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 211
      }
    }
  }
]
```