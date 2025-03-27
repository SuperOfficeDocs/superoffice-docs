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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Schroeder Inc and Sons",
    "Description": "Inverse foreground function",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 821,
        "Tooltip": "incidunt",
        "CanAssign": true,
        "Free": 490,
        "InUse": 542,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 441,
        "Name": "Jerde-Pacocha",
        "Description": "Multi-tiered client-server superstructure",
        "PrerequisiteModuleName": "Osinski-Dibbert",
        "SortOrder": 438,
        "ExtraFlags": 916,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 444
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 542,
        "Tooltip": "optio",
        "CanAssign": true,
        "Free": 801,
        "InUse": 721,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 578,
        "Name": "Schmitt, Schultz and Vandervort",
        "Description": "Stand-alone discrete extranet",
        "PrerequisiteModuleName": "Rath, Haley and Hammes",
        "SortOrder": 945,
        "ExtraFlags": 520,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 576
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 994
      }
    }
  },
  {
    "Name": "Schroeder Inc and Sons",
    "Description": "Inverse foreground function",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 821,
        "Tooltip": "incidunt",
        "CanAssign": true,
        "Free": 490,
        "InUse": 542,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 441,
        "Name": "Jerde-Pacocha",
        "Description": "Multi-tiered client-server superstructure",
        "PrerequisiteModuleName": "Osinski-Dibbert",
        "SortOrder": 438,
        "ExtraFlags": 916,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 444
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 542,
        "Tooltip": "optio",
        "CanAssign": true,
        "Free": 801,
        "InUse": 721,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 578,
        "Name": "Schmitt, Schultz and Vandervort",
        "Description": "Stand-alone discrete extranet",
        "PrerequisiteModuleName": "Rath, Haley and Hammes",
        "SortOrder": 945,
        "ExtraFlags": 520,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 576
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 994
      }
    }
  }
]
```