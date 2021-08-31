---
title: GetUserLicenses
id: v1LicenseAgent_GetUserLicenses
---

# GetUserLicenses

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
| AssociateId | int32 |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | The name of the license owner |
| Description | string |  |
| RestrictedModuleLicenses | array |  |
| UnrestrictedModuleLicenses | array | The unrestricted module licenses that this license owner |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/License/GetUserLicenses
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 457
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "McLaughlin-Thompson",
    "Description": "Optional executive solution",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 876,
        "Tooltip": "quia",
        "CanAssign": true,
        "Free": 771,
        "InUse": 964,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 268,
        "Name": "Mann, Murphy and Barrows",
        "Description": "Sharable directional data-warehouse",
        "PrerequisiteModuleName": "White-Spencer",
        "SortOrder": 251,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 891
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 760,
        "Tooltip": "fugiat",
        "CanAssign": true,
        "Free": 708,
        "InUse": 340,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 249,
        "Name": "Hegmann, Corkery and Rice",
        "Description": "Up-sized multi-tasking implementation",
        "PrerequisiteModuleName": "Willms Inc and Sons",
        "SortOrder": 758,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 204
          }
        }
      }
    ],
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 359
      }
    }
  },
  {
    "Name": "McLaughlin-Thompson",
    "Description": "Optional executive solution",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 876,
        "Tooltip": "quia",
        "CanAssign": true,
        "Free": 771,
        "InUse": 964,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 268,
        "Name": "Mann, Murphy and Barrows",
        "Description": "Sharable directional data-warehouse",
        "PrerequisiteModuleName": "White-Spencer",
        "SortOrder": 251,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 891
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 760,
        "Tooltip": "fugiat",
        "CanAssign": true,
        "Free": 708,
        "InUse": 340,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 249,
        "Name": "Hegmann, Corkery and Rice",
        "Description": "Up-sized multi-tasking implementation",
        "PrerequisiteModuleName": "Willms Inc and Sons",
        "SortOrder": 758,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 204
          }
        }
      }
    ],
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 359
      }
    }
  }
]
```