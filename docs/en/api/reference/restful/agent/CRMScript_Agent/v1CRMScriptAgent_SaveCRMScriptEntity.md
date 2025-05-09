---
title: POST Agents/CRMScript/SaveCRMScriptEntity
uid: v1CRMScriptAgent_SaveCRMScriptEntity
generated: true
---

# POST Agents/CRMScript/SaveCRMScriptEntity

```http
POST /api/v1/Agents/CRMScript/SaveCRMScriptEntity
```

Updates the existing CRMScriptEntity or creates a new CRMScriptEntity if the id parameter is empty


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.







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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: CRMScriptEntity

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

## Sample request

```http!
POST /api/v1/Agents/CRMScript/SaveCRMScriptEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 695,
  "UniqueIdentifier": "maxime",
  "Name": "Hills Group",
  "Description": "Up-sized zero tolerance conglomeration",
  "IncludeId": "voluptate",
  "AccessKey": "repellendus",
  "HierarchyId": 66,
  "Source": "iure",
  "SourceCode": "ut",
  "ScriptType": "CRMScript",
  "HtmlOutput": 818,
  "Includes": [
    195,
    482
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 684,
      "LineNumberTo": 286,
      "Delta": 656,
      "IncludeId": "dolorum",
      "IncludedFrom": [
        "maiores",
        "necessitatibus"
      ]
    },
    {
      "LineNumberFrom": 684,
      "LineNumberTo": 286,
      "Delta": 656,
      "IncludeId": "dolorum",
      "IncludedFrom": [
        "maiores",
        "necessitatibus"
      ]
    }
  ],
  "ValidationResult": null,
  "Registered": "2001-12-25T16:32:38.5552758+01:00",
  "RegisteredAssociateId": 495,
  "Updated": "2024-10-12T16:32:38.5552758+02:00",
  "UpdatedAssociateId": 899
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 496,
  "UniqueIdentifier": "voluptatem",
  "Name": "Hoppe Group",
  "Description": "Enhanced stable solution",
  "IncludeId": "quia",
  "AccessKey": "aut",
  "HierarchyId": 249,
  "Source": "sapiente",
  "SourceCode": "ut",
  "ScriptType": "CRMScript",
  "HtmlOutput": 333,
  "Includes": [
    846,
    260
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 835,
      "LineNumberTo": 652,
      "Delta": 203,
      "IncludeId": "eveniet",
      "IncludedFrom": [
        "aut",
        "unde"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 903
        }
      }
    }
  ],
  "ValidationResult": null,
  "Registered": "2008-05-06T16:32:38.5552758+02:00",
  "RegisteredAssociateId": 904,
  "Updated": "2005-04-12T16:32:38.5552758+02:00",
  "UpdatedAssociateId": 32,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 290
    }
  }
}
```