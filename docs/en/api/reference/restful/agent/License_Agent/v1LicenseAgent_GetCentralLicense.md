---
title: POST Agents/License/GetCentralLicense
uid: v1LicenseAgent_GetCentralLicense
generated: true
content_type: reference
---

# POST Agents/License/GetCentralLicense

```http
POST /api/v1/Agents/License/GetCentralLicense
```

NsApiSlow threshold: 5000 ms.







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
    "Name": "Hessel-Davis",
    "Description": "Intuitive didactic time-frame",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 435,
        "Tooltip": "temporibus",
        "CanAssign": true,
        "Free": 890,
        "InUse": 465,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 68,
        "Name": "Abshire, Bogisich and Leffler",
        "Description": "Robust transitional encryption",
        "PrerequisiteModuleName": "Jakubowski-Jenkins",
        "SortOrder": 675,
        "ExtraFlags": 966,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 701
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 14,
        "Tooltip": "et",
        "CanAssign": false,
        "Free": 802,
        "InUse": 338,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 885,
        "Name": "Marks-McKenzie",
        "Description": "Programmable even-keeled open system",
        "PrerequisiteModuleName": "Metz-Reinger",
        "SortOrder": 180,
        "ExtraFlags": 900,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 805
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 519
      }
    }
  },
  {
    "Name": "Hessel-Davis",
    "Description": "Intuitive didactic time-frame",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 435,
        "Tooltip": "temporibus",
        "CanAssign": true,
        "Free": 890,
        "InUse": 465,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 68,
        "Name": "Abshire, Bogisich and Leffler",
        "Description": "Robust transitional encryption",
        "PrerequisiteModuleName": "Jakubowski-Jenkins",
        "SortOrder": 675,
        "ExtraFlags": 966,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 701
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 14,
        "Tooltip": "et",
        "CanAssign": false,
        "Free": 802,
        "InUse": 338,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 885,
        "Name": "Marks-McKenzie",
        "Description": "Programmable even-keeled open system",
        "PrerequisiteModuleName": "Metz-Reinger",
        "SortOrder": 180,
        "ExtraFlags": 900,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 805
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 519
      }
    }
  }
]
```