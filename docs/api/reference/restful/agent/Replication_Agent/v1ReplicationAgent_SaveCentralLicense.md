---
title: POST Agents/Replication/SaveCentralLicense
id: v1ReplicationAgent_SaveCentralLicense
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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "License": [
    {
      "Name": "Okuneva Inc and Sons",
      "Description": "Balanced hybrid Graphical User Interface",
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
      "Name": "Okuneva Inc and Sons",
      "Description": "Balanced hybrid Graphical User Interface",
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
    "Name": "Denesik LLC",
    "Description": "Customizable upward-trending superstructure",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 907,
        "Tooltip": "necessitatibus",
        "CanAssign": false,
        "Free": 89,
        "InUse": 805,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 75,
        "Name": "Gutkowski-Douglas",
        "Description": "Face to face radical neural-net",
        "PrerequisiteModuleName": "Bogisich-Schumm",
        "SortOrder": 622,
        "ExtraFlags": 491,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 547
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 292,
        "Tooltip": "voluptas",
        "CanAssign": false,
        "Free": 184,
        "InUse": 179,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 427,
        "Name": "Hartmann Inc and Sons",
        "Description": "Progressive object-oriented model",
        "PrerequisiteModuleName": "Keebler-Bernhard",
        "SortOrder": 372,
        "ExtraFlags": 971,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 503
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
        "FieldLength": 522
      }
    }
  },
  {
    "Name": "Denesik LLC",
    "Description": "Customizable upward-trending superstructure",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 907,
        "Tooltip": "necessitatibus",
        "CanAssign": false,
        "Free": 89,
        "InUse": 805,
        "IsHidden": true,
        "Assigned": true,
        "ModuleLicenseId": 75,
        "Name": "Gutkowski-Douglas",
        "Description": "Face to face radical neural-net",
        "PrerequisiteModuleName": "Bogisich-Schumm",
        "SortOrder": 622,
        "ExtraFlags": 491,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 547
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 292,
        "Tooltip": "voluptas",
        "CanAssign": false,
        "Free": 184,
        "InUse": 179,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 427,
        "Name": "Hartmann Inc and Sons",
        "Description": "Progressive object-oriented model",
        "PrerequisiteModuleName": "Keebler-Bernhard",
        "SortOrder": 372,
        "ExtraFlags": 971,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 503
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
        "FieldLength": 522
      }
    }
  }
]
```