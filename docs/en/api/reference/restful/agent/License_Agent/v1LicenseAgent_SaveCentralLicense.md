---
title: POST Agents/License/SaveCentralLicense
uid: v1LicenseAgent_SaveCentralLicense
generated: true
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "License": [
    {
      "Name": "Funk, Reilly and Smitham",
      "Description": "Fundamental reciprocal info-mediaries",
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
      "Name": "Funk, Reilly and Smitham",
      "Description": "Fundamental reciprocal info-mediaries",
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
    "Name": "Schmidt, Gleichner and Kerluke",
    "Description": "Advanced bottom-line software",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 644,
        "Tooltip": "ad",
        "CanAssign": false,
        "Free": 40,
        "InUse": 415,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 8,
        "Name": "Turcotte-Dickinson",
        "Description": "Front-line asynchronous secured line",
        "PrerequisiteModuleName": "Crist-Bogisich",
        "SortOrder": 131,
        "ExtraFlags": 875,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 641
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 305,
        "Tooltip": "ducimus",
        "CanAssign": false,
        "Free": 948,
        "InUse": 134,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 101,
        "Name": "Quitzon-Corkery",
        "Description": "Multi-lateral zero tolerance knowledge base",
        "PrerequisiteModuleName": "Abshire, Hintz and Bartell",
        "SortOrder": 641,
        "ExtraFlags": 624,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 855
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 316
      }
    }
  },
  {
    "Name": "Schmidt, Gleichner and Kerluke",
    "Description": "Advanced bottom-line software",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 644,
        "Tooltip": "ad",
        "CanAssign": false,
        "Free": 40,
        "InUse": 415,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 8,
        "Name": "Turcotte-Dickinson",
        "Description": "Front-line asynchronous secured line",
        "PrerequisiteModuleName": "Crist-Bogisich",
        "SortOrder": 131,
        "ExtraFlags": 875,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 641
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 305,
        "Tooltip": "ducimus",
        "CanAssign": false,
        "Free": 948,
        "InUse": 134,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 101,
        "Name": "Quitzon-Corkery",
        "Description": "Multi-lateral zero tolerance knowledge base",
        "PrerequisiteModuleName": "Abshire, Hintz and Bartell",
        "SortOrder": 641,
        "ExtraFlags": 624,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 855
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 316
      }
    }
  }
]
```