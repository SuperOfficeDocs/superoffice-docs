---
title: POST Agents/Replication/SaveCentralLicense
uid: v1ReplicationAgent_SaveCentralLicense
generated: true
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
POST /api/v1/Agents/Replication/SaveCentralLicense
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "License": [
    {
      "Name": "Crist-Braun",
      "Description": "Inverse leading edge challenge",
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
      "Name": "Crist-Braun",
      "Description": "Inverse leading edge challenge",
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
    "Name": "McCullough, Jast and Fahey",
    "Description": "Triple-buffered human-resource conglomeration",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 473,
        "Tooltip": "quia",
        "CanAssign": false,
        "Free": 407,
        "InUse": 157,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 299,
        "Name": "Klocko LLC",
        "Description": "Automated composite secured line",
        "PrerequisiteModuleName": "Hudson LLC",
        "SortOrder": 927,
        "ExtraFlags": 320,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 318
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 967,
        "Tooltip": "sint",
        "CanAssign": false,
        "Free": 221,
        "InUse": 141,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 697,
        "Name": "Hoeger LLC",
        "Description": "Operative asynchronous alliance",
        "PrerequisiteModuleName": "Russel-Trantow",
        "SortOrder": 40,
        "ExtraFlags": 507,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 325
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 557
      }
    }
  },
  {
    "Name": "McCullough, Jast and Fahey",
    "Description": "Triple-buffered human-resource conglomeration",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 473,
        "Tooltip": "quia",
        "CanAssign": false,
        "Free": 407,
        "InUse": 157,
        "IsHidden": false,
        "Assigned": true,
        "ModuleLicenseId": 299,
        "Name": "Klocko LLC",
        "Description": "Automated composite secured line",
        "PrerequisiteModuleName": "Hudson LLC",
        "SortOrder": 927,
        "ExtraFlags": 320,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 318
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": true,
        "Total": 967,
        "Tooltip": "sint",
        "CanAssign": false,
        "Free": 221,
        "InUse": 141,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 697,
        "Name": "Hoeger LLC",
        "Description": "Operative asynchronous alliance",
        "PrerequisiteModuleName": "Russel-Trantow",
        "SortOrder": 40,
        "ExtraFlags": 507,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 325
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 557
      }
    }
  }
]
```