---
title: POST CRMScript
uid: v1CRMScriptEntity_PostCRMScriptEntity
generated: true
content_type: reference
---

# POST CRMScript

```http
POST /api/v1/CRMScript
```

Creates a new CRMScriptEntity


Calls the CRMScript agent service SaveCRMScriptEntity.


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/CRMScript?$select=name,department,category/id
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

## Request Body: newEntity 

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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

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
POST /api/v1/CRMScript
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 1002,
  "UniqueIdentifier": "corrupti",
  "Name": "Huels, Stark and Dach",
  "Description": "Business-focused 3rd generation model",
  "IncludeId": "aliquam",
  "AccessKey": "quia",
  "HierarchyId": 660,
  "Source": "quos",
  "SourceCode": "qui",
  "ScriptType": "CRMScript",
  "HtmlOutput": 92,
  "Includes": [
    371,
    948
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 668,
      "LineNumberTo": 704,
      "Delta": 678,
      "IncludeId": "rerum",
      "IncludedFrom": [
        "quo",
        "velit"
      ]
    },
    {
      "LineNumberFrom": 668,
      "LineNumberTo": 704,
      "Delta": 678,
      "IncludeId": "rerum",
      "IncludedFrom": [
        "quo",
        "velit"
      ]
    }
  ],
  "ValidationResult": null,
  "Registered": "2013-06-19T03:41:58.6367691+02:00",
  "RegisteredAssociateId": 201,
  "Updated": "2003-07-18T03:41:58.6367691+02:00",
  "UpdatedAssociateId": 388,
  "BlockedVerbs": "BlockAll"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 412,
  "UniqueIdentifier": "ipsum",
  "Name": "Moen Group",
  "Description": "Reverse-engineered client-driven internet solution",
  "IncludeId": "voluptas",
  "AccessKey": "enim",
  "HierarchyId": 21,
  "Source": "veniam",
  "SourceCode": "soluta",
  "ScriptType": "CRMScript",
  "HtmlOutput": 196,
  "Includes": [
    382,
    128
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 146,
      "LineNumberTo": 979,
      "Delta": 283,
      "IncludeId": "corporis",
      "IncludedFrom": [
        "et",
        "omnis"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 341
        }
      }
    }
  ],
  "ValidationResult": null,
  "Registered": "2022-06-07T03:41:58.6367691+02:00",
  "RegisteredAssociateId": 302,
  "Updated": "2012-11-27T03:41:58.6367691+01:00",
  "UpdatedAssociateId": 170,
  "BlockedVerbs": "BlockAll",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 303
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```