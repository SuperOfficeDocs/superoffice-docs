---
title: POST Agents/CRMScript/SaveCRMScriptEntity
uid: v1CRMScriptAgent_SaveCRMScriptEntity
generated: true
content_type: reference
---

# POST Agents/CRMScript/SaveCRMScriptEntity

```http
POST /api/v1/Agents/CRMScript/SaveCRMScriptEntity
```

Updates the existing CRMScriptEntity or creates a new CRMScriptEntity if the id parameter is 0.


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

## Request Body: cRMScriptEntity 

The CRMScriptEntity that is saved 

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
| BlockedVerbs | string | The verbs that are blocked when calling a ejscript over HTTP |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/CRMScript/SaveCRMScriptEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 451,
  "UniqueIdentifier": "est",
  "Name": "Zboncak-Kris",
  "Description": "Focused local customer loyalty",
  "IncludeId": "ut",
  "AccessKey": "dignissimos",
  "HierarchyId": 948,
  "Source": "architecto",
  "SourceCode": "ut",
  "ScriptType": "CRMScript",
  "HtmlOutput": 623,
  "Includes": [
    55,
    364
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 155,
      "LineNumberTo": 619,
      "Delta": 728,
      "IncludeId": "rerum",
      "IncludedFrom": [
        "tempore",
        "dolor"
      ]
    },
    {
      "LineNumberFrom": 155,
      "LineNumberTo": 619,
      "Delta": 728,
      "IncludeId": "rerum",
      "IncludedFrom": [
        "tempore",
        "dolor"
      ]
    }
  ],
  "ValidationResult": null,
  "Registered": "2005-10-31T03:46:54.5663888+01:00",
  "RegisteredAssociateId": 747,
  "Updated": "2004-09-24T03:46:54.5663888+02:00",
  "UpdatedAssociateId": 361,
  "BlockedVerbs": "BlockAll"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 357,
  "UniqueIdentifier": "tenetur",
  "Name": "Grant-Kunde",
  "Description": "Vision-oriented holistic array",
  "IncludeId": "quidem",
  "AccessKey": "atque",
  "HierarchyId": 842,
  "Source": "maiores",
  "SourceCode": "sit",
  "ScriptType": "CRMScript",
  "HtmlOutput": 585,
  "Includes": [
    414,
    438
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 495,
      "LineNumberTo": 26,
      "Delta": 733,
      "IncludeId": "deserunt",
      "IncludedFrom": [
        "laboriosam",
        "aut"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 360
        }
      }
    }
  ],
  "ValidationResult": null,
  "Registered": "2023-12-25T03:46:54.5663888+01:00",
  "RegisteredAssociateId": 841,
  "Updated": "2004-12-01T03:46:54.5663888+01:00",
  "UpdatedAssociateId": 725,
  "BlockedVerbs": "BlockAll",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 839
    }
  }
}
```