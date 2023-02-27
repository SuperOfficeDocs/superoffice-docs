---
title: POST Agents/License/GetUserLicenses
uid: v1LicenseAgent_GetUserLicenses
---

# POST Agents/License/GetUserLicenses

```http
POST /api/v1/Agents/License/GetUserLicenses
```

Obtain information about associate module licenses







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/License/GetUserLicenses?$select=name,department,category/id
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

AssociateId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | Integer |  |

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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/License/GetUserLicenses
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 700
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Kub Group",
    "Description": "Devolved intangible Graphic Interface",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 179,
        "Tooltip": "exercitationem",
        "CanAssign": true,
        "Free": 955,
        "InUse": 99,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 227,
        "Name": "Orn Inc and Sons",
        "Description": "Compatible bi-directional extranet",
        "PrerequisiteModuleName": "Oberbrunner Group",
        "SortOrder": 321,
        "ExtraFlags": 337,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 989
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 402,
        "Tooltip": "debitis",
        "CanAssign": false,
        "Free": 853,
        "InUse": 53,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 290,
        "Name": "Reilly, Wiza and Senger",
        "Description": "Cloned stable firmware",
        "PrerequisiteModuleName": "Runolfsdottir, Padberg and Terry",
        "SortOrder": 912,
        "ExtraFlags": 112,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 270
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 357
      }
    }
  },
  {
    "Name": "Kub Group",
    "Description": "Devolved intangible Graphic Interface",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 179,
        "Tooltip": "exercitationem",
        "CanAssign": true,
        "Free": 955,
        "InUse": 99,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 227,
        "Name": "Orn Inc and Sons",
        "Description": "Compatible bi-directional extranet",
        "PrerequisiteModuleName": "Oberbrunner Group",
        "SortOrder": 321,
        "ExtraFlags": 337,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 989
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 402,
        "Tooltip": "debitis",
        "CanAssign": false,
        "Free": 853,
        "InUse": 53,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 290,
        "Name": "Reilly, Wiza and Senger",
        "Description": "Cloned stable firmware",
        "PrerequisiteModuleName": "Runolfsdottir, Padberg and Terry",
        "SortOrder": 912,
        "ExtraFlags": 112,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 270
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 357
      }
    }
  }
]
```