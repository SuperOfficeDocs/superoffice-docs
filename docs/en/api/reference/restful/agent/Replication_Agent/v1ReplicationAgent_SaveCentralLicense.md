---
title: POST Agents/Replication/SaveCentralLicense
uid: v1ReplicationAgent_SaveCentralLicense
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "License": [
    {
      "Name": "Schoen LLC",
      "Description": "Phased content-based artificial intelligence",
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
      "Name": "Schoen LLC",
      "Description": "Phased content-based artificial intelligence",
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
    "Name": "Kuphal, Morissette and Hickle",
    "Description": "Future-proofed even-keeled secured line",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 799,
        "Tooltip": "repudiandae",
        "CanAssign": true,
        "Free": 390,
        "InUse": 95,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 883,
        "Name": "Hansen-Botsford",
        "Description": "Decentralized secondary moratorium",
        "PrerequisiteModuleName": "Haley Group",
        "SortOrder": 184,
        "ExtraFlags": 814,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 874
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 296,
        "Tooltip": "enim",
        "CanAssign": true,
        "Free": 54,
        "InUse": 956,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 844,
        "Name": "Casper, Armstrong and Langworth",
        "Description": "Secured eco-centric parallelism",
        "PrerequisiteModuleName": "Lemke, Haag and Littel",
        "SortOrder": 150,
        "ExtraFlags": 1000,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 9
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 39
      }
    }
  },
  {
    "Name": "Kuphal, Morissette and Hickle",
    "Description": "Future-proofed even-keeled secured line",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 799,
        "Tooltip": "repudiandae",
        "CanAssign": true,
        "Free": 390,
        "InUse": 95,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 883,
        "Name": "Hansen-Botsford",
        "Description": "Decentralized secondary moratorium",
        "PrerequisiteModuleName": "Haley Group",
        "SortOrder": 184,
        "ExtraFlags": 814,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 874
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 296,
        "Tooltip": "enim",
        "CanAssign": true,
        "Free": 54,
        "InUse": 956,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 844,
        "Name": "Casper, Armstrong and Langworth",
        "Description": "Secured eco-centric parallelism",
        "PrerequisiteModuleName": "Lemke, Haag and Littel",
        "SortOrder": 150,
        "ExtraFlags": 1000,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 9
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 39
      }
    }
  }
]
```