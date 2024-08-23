---
title: POST CRMScript
uid: v1CRMScriptEntity_PostCRMScriptEntity
generated: true
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/CRMScript
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 189,
  "UniqueIdentifier": "tenetur",
  "Name": "Schmitt-Spinka",
  "Description": "Pre-emptive upward-trending support",
  "IncludeId": "et",
  "AccessKey": "aut",
  "HierarchyId": 31,
  "Source": "nesciunt",
  "SourceCode": "maiores",
  "ScriptType": "CRMScript",
  "HtmlOutput": 631,
  "Includes": [
    246,
    635
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 555,
      "LineNumberTo": 67,
      "Delta": 60,
      "IncludeId": "nesciunt",
      "IncludedFrom": [
        "fugiat",
        "pariatur"
      ]
    },
    {
      "LineNumberFrom": 555,
      "LineNumberTo": 67,
      "Delta": 60,
      "IncludeId": "nesciunt",
      "IncludedFrom": [
        "fugiat",
        "pariatur"
      ]
    }
  ],
  "ValidationResult": null,
  "Registered": "2015-01-24T13:28:31.53865+01:00",
  "RegisteredAssociateId": 11,
  "Updated": "2016-01-01T13:28:31.53865+01:00",
  "UpdatedAssociateId": 215
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 176,
  "UniqueIdentifier": "debitis",
  "Name": "Kemmer LLC",
  "Description": "Exclusive multi-state contingency",
  "IncludeId": "dolorum",
  "AccessKey": "ipsum",
  "HierarchyId": 140,
  "Source": "tempora",
  "SourceCode": "est",
  "ScriptType": "CRMScript",
  "HtmlOutput": 712,
  "Includes": [
    653,
    294
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 61,
      "LineNumberTo": 682,
      "Delta": 954,
      "IncludeId": "non",
      "IncludedFrom": [
        "consequatur",
        "accusamus"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 348
        }
      }
    }
  ],
  "ValidationResult": null,
  "Registered": "2013-07-13T13:28:31.53865+02:00",
  "RegisteredAssociateId": 90,
  "Updated": "1999-01-14T13:28:31.53865+01:00",
  "UpdatedAssociateId": 619,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 727
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```