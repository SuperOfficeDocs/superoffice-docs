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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 809
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Huels-O'Conner",
    "Description": "Seamless fresh-thinking structure",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 413,
        "Tooltip": "repudiandae",
        "CanAssign": true,
        "Free": 80,
        "InUse": 382,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 372,
        "Name": "Johns LLC",
        "Description": "Synergized real-time parallelism",
        "PrerequisiteModuleName": "Leuschke-Kling",
        "SortOrder": 678,
        "ExtraFlags": 548,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 644
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 851,
        "Tooltip": "consequatur",
        "CanAssign": true,
        "Free": 54,
        "InUse": 44,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 887,
        "Name": "Cruickshank-Moore",
        "Description": "Object-based global monitoring",
        "PrerequisiteModuleName": "Ruecker, Rice and Wuckert",
        "SortOrder": 232,
        "ExtraFlags": 977,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 823
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
        "FieldLength": 13
      }
    }
  },
  {
    "Name": "Huels-O'Conner",
    "Description": "Seamless fresh-thinking structure",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 413,
        "Tooltip": "repudiandae",
        "CanAssign": true,
        "Free": 80,
        "InUse": 382,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 372,
        "Name": "Johns LLC",
        "Description": "Synergized real-time parallelism",
        "PrerequisiteModuleName": "Leuschke-Kling",
        "SortOrder": 678,
        "ExtraFlags": 548,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 644
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 851,
        "Tooltip": "consequatur",
        "CanAssign": true,
        "Free": 54,
        "InUse": 44,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 887,
        "Name": "Cruickshank-Moore",
        "Description": "Object-based global monitoring",
        "PrerequisiteModuleName": "Ruecker, Rice and Wuckert",
        "SortOrder": 232,
        "ExtraFlags": 977,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 823
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
        "FieldLength": 13
      }
    }
  }
]
```