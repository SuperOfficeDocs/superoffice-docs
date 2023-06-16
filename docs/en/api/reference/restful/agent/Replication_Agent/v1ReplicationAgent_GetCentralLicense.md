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
    "Name": "Murazik Inc and Sons",
    "Description": "Proactive optimizing info-mediaries",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 893,
        "Tooltip": "ex",
        "CanAssign": true,
        "Free": 814,
        "InUse": 616,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 105,
        "Name": "Tromp, Grant and Jones",
        "Description": "Ameliorated stable structure",
        "PrerequisiteModuleName": "Shanahan Inc and Sons",
        "SortOrder": 226,
        "ExtraFlags": 402,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 459
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 239,
        "Tooltip": "impedit",
        "CanAssign": false,
        "Free": 690,
        "InUse": 328,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 264,
        "Name": "Lemke, Yundt and Hessel",
        "Description": "Mandatory attitude-oriented alliance",
        "PrerequisiteModuleName": "Kemmer Group",
        "SortOrder": 879,
        "ExtraFlags": 420,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 507
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 884
      }
    }
  },
  {
    "Name": "Murazik Inc and Sons",
    "Description": "Proactive optimizing info-mediaries",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 893,
        "Tooltip": "ex",
        "CanAssign": true,
        "Free": 814,
        "InUse": 616,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 105,
        "Name": "Tromp, Grant and Jones",
        "Description": "Ameliorated stable structure",
        "PrerequisiteModuleName": "Shanahan Inc and Sons",
        "SortOrder": 226,
        "ExtraFlags": 402,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 459
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 239,
        "Tooltip": "impedit",
        "CanAssign": false,
        "Free": 690,
        "InUse": 328,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 264,
        "Name": "Lemke, Yundt and Hessel",
        "Description": "Mandatory attitude-oriented alliance",
        "PrerequisiteModuleName": "Kemmer Group",
        "SortOrder": 879,
        "ExtraFlags": 420,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 507
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 884
      }
    }
  }
]
```