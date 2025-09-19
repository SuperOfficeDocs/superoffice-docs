---
title: POST Agents/License/SaveCentralLicense
uid: v1LicenseAgent_SaveCentralLicense
generated: true
content_type: reference
---

# POST Agents/License/SaveCentralLicense

```http
POST /api/v1/Agents/License/SaveCentralLicense
```









## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/License/SaveCentralLicense?$select=name,department,category/id
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
POST /api/v1/Agents/License/SaveCentralLicense
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "License": [
    {
      "Name": "Ritchie, Carroll and Wiza",
      "Description": "Visionary directional policy",
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
      "Name": "Ritchie, Carroll and Wiza",
      "Description": "Visionary directional policy",
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
    "Name": "Baumbach-Corwin",
    "Description": "Assimilated national matrix",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 584,
        "Tooltip": "ipsum",
        "CanAssign": false,
        "Free": 72,
        "InUse": 485,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 207,
        "Name": "Zemlak, Connelly and Kreiger",
        "Description": "Networked solution-oriented intranet",
        "PrerequisiteModuleName": "Bashirian Group",
        "SortOrder": 75,
        "ExtraFlags": 201,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 440
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 628,
        "Tooltip": "animi",
        "CanAssign": false,
        "Free": 988,
        "InUse": 638,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 565,
        "Name": "Brakus-Streich",
        "Description": "Ameliorated methodical standardization",
        "PrerequisiteModuleName": "Gislason, Runte and Medhurst",
        "SortOrder": 685,
        "ExtraFlags": 517,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 466
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 7
      }
    }
  },
  {
    "Name": "Baumbach-Corwin",
    "Description": "Assimilated national matrix",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 584,
        "Tooltip": "ipsum",
        "CanAssign": false,
        "Free": 72,
        "InUse": 485,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 207,
        "Name": "Zemlak, Connelly and Kreiger",
        "Description": "Networked solution-oriented intranet",
        "PrerequisiteModuleName": "Bashirian Group",
        "SortOrder": 75,
        "ExtraFlags": 201,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 440
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 628,
        "Tooltip": "animi",
        "CanAssign": false,
        "Free": 988,
        "InUse": 638,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 565,
        "Name": "Brakus-Streich",
        "Description": "Ameliorated methodical standardization",
        "PrerequisiteModuleName": "Gislason, Runte and Medhurst",
        "SortOrder": 685,
        "ExtraFlags": 517,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 466
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 7
      }
    }
  }
]
```