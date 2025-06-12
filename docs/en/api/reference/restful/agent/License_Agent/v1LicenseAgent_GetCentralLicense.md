---
title: POST Agents/License/GetCentralLicense
uid: v1LicenseAgent_GetCentralLicense
generated: true
---

# POST Agents/License/GetCentralLicense

```http
POST /api/v1/Agents/License/GetCentralLicense
```









## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/License/GetCentralLicense?$select=name,department,category/id
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
POST /api/v1/Agents/License/GetCentralLicense
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
    "Name": "Murphy, West and Swaniawski",
    "Description": "Reverse-engineered system-worthy structure",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 525,
        "Tooltip": "corrupti",
        "CanAssign": false,
        "Free": 457,
        "InUse": 448,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 165,
        "Name": "Ortiz, Waters and Heathcote",
        "Description": "Exclusive neutral process improvement",
        "PrerequisiteModuleName": "Weber Inc and Sons",
        "SortOrder": 875,
        "ExtraFlags": 978,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 912
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 463,
        "Tooltip": "inventore",
        "CanAssign": true,
        "Free": 719,
        "InUse": 128,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 642,
        "Name": "Schuster, Hackett and Kunde",
        "Description": "Face to face 6th generation flexibility",
        "PrerequisiteModuleName": "Mosciski-Lind",
        "SortOrder": 202,
        "ExtraFlags": 35,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 733
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 166
      }
    }
  },
  {
    "Name": "Murphy, West and Swaniawski",
    "Description": "Reverse-engineered system-worthy structure",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 525,
        "Tooltip": "corrupti",
        "CanAssign": false,
        "Free": 457,
        "InUse": 448,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 165,
        "Name": "Ortiz, Waters and Heathcote",
        "Description": "Exclusive neutral process improvement",
        "PrerequisiteModuleName": "Weber Inc and Sons",
        "SortOrder": 875,
        "ExtraFlags": 978,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 912
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 463,
        "Tooltip": "inventore",
        "CanAssign": true,
        "Free": 719,
        "InUse": 128,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 642,
        "Name": "Schuster, Hackett and Kunde",
        "Description": "Face to face 6th generation flexibility",
        "PrerequisiteModuleName": "Mosciski-Lind",
        "SortOrder": 202,
        "ExtraFlags": 35,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 733
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 166
      }
    }
  }
]
```