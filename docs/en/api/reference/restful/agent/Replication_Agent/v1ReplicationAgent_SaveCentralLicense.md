---
title: POST Agents/Replication/SaveCentralLicense
uid: v1ReplicationAgent_SaveCentralLicense
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

OK

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

## Sample request

```http!
POST /api/v1/Agents/Replication/SaveCentralLicense
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "License": [
    {
      "Name": "Volkman, Osinski and Koelpin",
      "Description": "Ergonomic modular monitoring",
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
      "Name": "Volkman, Osinski and Koelpin",
      "Description": "Ergonomic modular monitoring",
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
    "Name": "Legros, Bechtelar and Leuschke",
    "Description": "Distributed upward-trending product",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 528,
        "Tooltip": "quas",
        "CanAssign": false,
        "Free": 538,
        "InUse": 225,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 715,
        "Name": "Roberts-Toy",
        "Description": "Down-sized client-driven task-force",
        "PrerequisiteModuleName": "Stehr-Roob",
        "SortOrder": 513,
        "ExtraFlags": 701,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 227
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 990,
        "Tooltip": "et",
        "CanAssign": true,
        "Free": 436,
        "InUse": 265,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 911,
        "Name": "Koelpin, Rath and Little",
        "Description": "Reverse-engineered actuating benchmark",
        "PrerequisiteModuleName": "Labadie Inc and Sons",
        "SortOrder": 910,
        "ExtraFlags": 907,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 834
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 591
      }
    }
  },
  {
    "Name": "Legros, Bechtelar and Leuschke",
    "Description": "Distributed upward-trending product",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 528,
        "Tooltip": "quas",
        "CanAssign": false,
        "Free": 538,
        "InUse": 225,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 715,
        "Name": "Roberts-Toy",
        "Description": "Down-sized client-driven task-force",
        "PrerequisiteModuleName": "Stehr-Roob",
        "SortOrder": 513,
        "ExtraFlags": 701,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 227
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 990,
        "Tooltip": "et",
        "CanAssign": true,
        "Free": 436,
        "InUse": 265,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 911,
        "Name": "Koelpin, Rath and Little",
        "Description": "Reverse-engineered actuating benchmark",
        "PrerequisiteModuleName": "Labadie Inc and Sons",
        "SortOrder": 910,
        "ExtraFlags": 907,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 834
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 591
      }
    }
  }
]
```