---
title: PUT CRMScript/{id}
uid: v1CRMScriptEntity_PutCRMScriptEntity
generated: true
---

# PUT CRMScript/{id}

```http
PUT /api/v1/CRMScript/{id}
```

Updates the existing CRMScriptEntity


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The CRMScriptEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/CRMScript/{id}?$select=name,department,category/id
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

## Request Body: entity 

The CRMScriptEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EjscriptId | Integer | Primary key |
| UniqueIdentifier | String | Global unique identifier, accross customers/tenants |
| Name | String | A description of this script |
| Description | String | Optional description of what this script is used for. |
| IncludeId | String | A unique name used for including this script in another |
| AccessKey | String | Access key used to run this script on the customer pages |
| HierarchyId | Integer | The script is inside this hierarchy folder |
| Source | String | The script |
| SourceCode | String | Contains the source code of the script |
| ScriptType | String | The type/language of this script |
| HtmlOutput | Integer | True if this script will return HTML output |
| Includes | Array | The unique ids of all depencies of this script (all resolved includes) |
| SourceMaps | Array | The source maps for this script |
| ValidationResult | CRMScriptResult | The result of a validation of a TypeScript when saving |
| Registered | String | Registered when  in UTC. |
| RegisteredAssociateId | Integer | Registered by whom |
| Updated | String | Last updated when  in UTC. |
| UpdatedAssociateId | Integer | Last updated by whom |

## Response:

CRMScriptEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | CRMScriptEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: CRMScriptEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| EjscriptId | int32 | Primary key |
| UniqueIdentifier | string | Global unique identifier, accross customers/tenants |
| Name | string | A description of this script |
| Description | string | Optional description of what this script is used for. |
| IncludeId | string | A unique name used for including this script in another |
| AccessKey | string | Access key used to run this script on the customer pages |
| HierarchyId | int32 | The script is inside this hierarchy folder |
| Source | string | The script |
| SourceCode | string | Contains the source code of the script |
| ScriptType | string | The type/language of this script |
| HtmlOutput | int32 | True if this script will return HTML output |
| Includes | array | The unique ids of all depencies of this script (all resolved includes) |
| SourceMaps | array | The source maps for this script |
| ValidationResult | CRMScriptResult | The result of a validation of a TypeScript when saving |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/CRMScript/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 338,
  "UniqueIdentifier": "est",
  "Name": "Fritsch, Bernier and Kuhn",
  "Description": "Devolved multi-state application",
  "IncludeId": "dolor",
  "AccessKey": "voluptatem",
  "HierarchyId": 738,
  "Source": "dolore",
  "SourceCode": "dignissimos",
  "ScriptType": "CRMScript",
  "HtmlOutput": 467,
  "Includes": [
    921,
    799
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 831,
      "LineNumberTo": 985,
      "Delta": 425,
      "IncludeId": "minima",
      "IncludedFrom": [
        "ut",
        "deleniti"
      ]
    },
    {
      "LineNumberFrom": 831,
      "LineNumberTo": 985,
      "Delta": 425,
      "IncludeId": "minima",
      "IncludedFrom": [
        "ut",
        "deleniti"
      ]
    }
  ],
  "ValidationResult": null,
  "Registered": "2023-10-03T12:01:32.8394314+02:00",
  "RegisteredAssociateId": 411,
  "Updated": "2011-11-08T12:01:32.8394314+01:00",
  "UpdatedAssociateId": 296
}
```

## Sample response

```http_
HTTP/1.1 200 CRMScriptEntity updated.
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 921,
  "UniqueIdentifier": "neque",
  "Name": "Legros, Harvey and Jaskolski",
  "Description": "Customer-focused methodical emulation",
  "IncludeId": "corporis",
  "AccessKey": "blanditiis",
  "HierarchyId": 985,
  "Source": "beatae",
  "SourceCode": "reiciendis",
  "ScriptType": "CRMScript",
  "HtmlOutput": 191,
  "Includes": [
    720,
    850
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 216,
      "LineNumberTo": 638,
      "Delta": 361,
      "IncludeId": "amet",
      "IncludedFrom": [
        "harum",
        "ut"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 808
        }
      }
    }
  ],
  "ValidationResult": null,
  "Registered": "2022-05-06T12:01:32.8394314+02:00",
  "RegisteredAssociateId": 489,
  "Updated": "1999-09-16T12:01:32.8394314+02:00",
  "UpdatedAssociateId": 976,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 744
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```