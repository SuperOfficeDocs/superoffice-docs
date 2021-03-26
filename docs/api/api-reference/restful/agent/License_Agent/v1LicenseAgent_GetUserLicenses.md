---
title: POST Agents/License/GetUserLicenses
id: v1LicenseAgent_GetUserLicenses
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 346
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Gusikowski-Corwin",
    "Description": "Organic high-level success",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 130,
        "Tooltip": "qui",
        "CanAssign": false,
        "Free": 600,
        "InUse": 537,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 712,
        "Name": "Yost-Rice",
        "Description": "Horizontal next generation process improvement",
        "PrerequisiteModuleName": "Rohan-Purdy",
        "SortOrder": 679,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 593
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 881,
        "Tooltip": "in",
        "CanAssign": true,
        "Free": 236,
        "InUse": 501,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 476,
        "Name": "Johns-Daugherty",
        "Description": "Future-proofed radical capability",
        "PrerequisiteModuleName": "Hirthe, Waters and Tromp",
        "SortOrder": 24,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 320
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
        "FieldLength": 198
      }
    }
  },
  {
    "Name": "Gusikowski-Corwin",
    "Description": "Organic high-level success",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 130,
        "Tooltip": "qui",
        "CanAssign": false,
        "Free": 600,
        "InUse": 537,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 712,
        "Name": "Yost-Rice",
        "Description": "Horizontal next generation process improvement",
        "PrerequisiteModuleName": "Rohan-Purdy",
        "SortOrder": 679,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 593
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 881,
        "Tooltip": "in",
        "CanAssign": true,
        "Free": 236,
        "InUse": 501,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 476,
        "Name": "Johns-Daugherty",
        "Description": "Future-proofed radical capability",
        "PrerequisiteModuleName": "Hirthe, Waters and Tromp",
        "SortOrder": 24,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 320
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
        "FieldLength": 198
      }
    }
  }
]
```