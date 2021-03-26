---
title: POST Agents/Replication/GetCentralLicense
id: v1ReplicationAgent_GetCentralLicense
---

# POST Agents/Replication/GetCentralLicense

```http
POST /api/v1/Agents/Replication/GetCentralLicense
```

<para />

## Online Restricted: ## The Replication agent is not available in Online by default. Not available in Online. Only used on-site.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Replication/GetCentralLicense?$select=name,department,category/id
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
POST /api/v1/Agents/Replication/GetCentralLicense
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Leuschke Group",
    "Description": "Cloned uniform initiative",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 671,
        "Tooltip": "eligendi",
        "CanAssign": true,
        "Free": 539,
        "InUse": 756,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 965,
        "Name": "Kiehn, Toy and Walter",
        "Description": "Distributed asynchronous knowledge base",
        "PrerequisiteModuleName": "Boyle LLC",
        "SortOrder": 758,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 785
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 774,
        "Tooltip": "expedita",
        "CanAssign": false,
        "Free": 504,
        "InUse": 250,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 928,
        "Name": "Upton Inc and Sons",
        "Description": "Networked zero tolerance archive",
        "PrerequisiteModuleName": "Konopelski-Leffler",
        "SortOrder": 389,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 500
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
        "FieldLength": 736
      }
    }
  },
  {
    "Name": "Leuschke Group",
    "Description": "Cloned uniform initiative",
    "RestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 671,
        "Tooltip": "eligendi",
        "CanAssign": true,
        "Free": 539,
        "InUse": 756,
        "IsHidden": true,
        "Assigned": false,
        "ModuleLicenseId": 965,
        "Name": "Kiehn, Toy and Walter",
        "Description": "Distributed asynchronous knowledge base",
        "PrerequisiteModuleName": "Boyle LLC",
        "SortOrder": 758,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 785
          }
        }
      }
    ],
    "UnrestrictedModuleLicenses": [
      {
        "Unrestricted": false,
        "Total": 774,
        "Tooltip": "expedita",
        "CanAssign": false,
        "Free": 504,
        "InUse": 250,
        "IsHidden": false,
        "Assigned": false,
        "ModuleLicenseId": 928,
        "Name": "Upton Inc and Sons",
        "Description": "Networked zero tolerance archive",
        "PrerequisiteModuleName": "Konopelski-Leffler",
        "SortOrder": 389,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 500
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
        "FieldLength": 736
      }
    }
  }
]
```