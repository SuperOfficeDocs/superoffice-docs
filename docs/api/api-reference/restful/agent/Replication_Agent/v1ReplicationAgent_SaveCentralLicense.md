---
title: SaveCentralLicense
id: v1ReplicationAgent_SaveCentralLicense
---

# SaveCentralLicense

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
| License | array |  |


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
POST /api/v1/Agents/Replication/SaveCentralLicense
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "License": [
    {
      "Name": "Jacobi, Bednar and Mohr",
      "Description": "Reduced exuding analyzer",
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
      "Name": "Jacobi, Bednar and Mohr",
      "Description": "Reduced exuding analyzer",
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

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Rogahn, Swaniawski and Barton",
    "Description": "Pre-emptive systematic application",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 320,
        "Tooltip": "illo",
        "CanAssign": false,
        "Free": 808,
        "InUse": 114,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 203,
        "Name": "White, Beahan and Bogisich",
        "Description": "Balanced demand-driven info-mediaries",
        "PrerequisiteModuleName": "Dickens-Schaden",
        "SortOrder": 175,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 56
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 132,
        "Tooltip": "dolor",
        "CanAssign": true,
        "Free": 207,
        "InUse": 687,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 863,
        "Name": "Beier-Thiel",
        "Description": "Switchable 3rd generation groupware",
        "PrerequisiteModuleName": "Anderson-King",
        "SortOrder": 214,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 784
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
        "FieldType": "System.Int32",
        "FieldLength": 889
      }
    }
  },
  {
    "Name": "Rogahn, Swaniawski and Barton",
    "Description": "Pre-emptive systematic application",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 320,
        "Tooltip": "illo",
        "CanAssign": false,
        "Free": 808,
        "InUse": 114,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 203,
        "Name": "White, Beahan and Bogisich",
        "Description": "Balanced demand-driven info-mediaries",
        "PrerequisiteModuleName": "Dickens-Schaden",
        "SortOrder": 175,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 56
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 132,
        "Tooltip": "dolor",
        "CanAssign": true,
        "Free": 207,
        "InUse": 687,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 863,
        "Name": "Beier-Thiel",
        "Description": "Switchable 3rd generation groupware",
        "PrerequisiteModuleName": "Anderson-King",
        "SortOrder": 214,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 784
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
        "FieldType": "System.Int32",
        "FieldLength": 889
      }
    }
  }
]
```