---
title: PUT CRMScript/{id}
uid: v1CRMScriptEntity_PutCRMScriptEntity
generated: true
content_type: reference
---

# PUT CRMScript/{id}

```http
PUT /api/v1/CRMScript/{id}
```

Updates the existing CRMScriptEntity


NsApiSlow threshold: 5000 ms.


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
| BlockedVerbs | String | The verbs that are blocked when calling a ejscript over HTTP |

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
| BlockedVerbs | string | The verbs that are blocked when calling a ejscript over HTTP |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/CRMScript/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 794,
  "UniqueIdentifier": "perspiciatis",
  "Name": "Russel Inc and Sons",
  "Description": "Cloned multi-state standardization",
  "IncludeId": "dolorem",
  "AccessKey": "cum",
  "HierarchyId": 701,
  "Source": "soluta",
  "SourceCode": "impedit",
  "ScriptType": "CRMScript",
  "HtmlOutput": 184,
  "Includes": [
    483,
    395
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 693,
      "LineNumberTo": 304,
      "Delta": 82,
      "IncludeId": "ipsa",
      "IncludedFrom": [
        "veniam",
        "necessitatibus"
      ]
    },
    {
      "LineNumberFrom": 693,
      "LineNumberTo": 304,
      "Delta": 82,
      "IncludeId": "ipsa",
      "IncludedFrom": [
        "veniam",
        "necessitatibus"
      ]
    }
  ],
  "ValidationResult": null,
  "Registered": "2013-02-02T02:30:52.522416+01:00",
  "RegisteredAssociateId": 630,
  "Updated": "2002-06-01T02:30:52.522416+02:00",
  "UpdatedAssociateId": 987,
  "BlockedVerbs": "BlockAll"
}
```

## Sample response

```http_
HTTP/1.1 200 CRMScriptEntity updated.
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 372,
  "UniqueIdentifier": "impedit",
  "Name": "Wuckert, Hodkiewicz and Monahan",
  "Description": "Managed system-worthy time-frame",
  "IncludeId": "amet",
  "AccessKey": "ad",
  "HierarchyId": 694,
  "Source": "ad",
  "SourceCode": "asperiores",
  "ScriptType": "CRMScript",
  "HtmlOutput": 439,
  "Includes": [
    302,
    586
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 472,
      "LineNumberTo": 409,
      "Delta": 212,
      "IncludeId": "voluptas",
      "IncludedFrom": [
        "iure",
        "voluptas"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 864
        }
      }
    }
  ],
  "ValidationResult": null,
  "Registered": "2009-06-27T02:30:52.522416+02:00",
  "RegisteredAssociateId": 942,
  "Updated": "2011-07-28T02:30:52.522416+02:00",
  "UpdatedAssociateId": 937,
  "BlockedVerbs": "BlockAll",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 544
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```