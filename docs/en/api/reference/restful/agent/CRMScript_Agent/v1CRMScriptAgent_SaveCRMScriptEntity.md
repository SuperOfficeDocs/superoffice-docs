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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 291,
  "UniqueIdentifier": "quam",
  "Name": "Mitchell, Haley and Schaefer",
  "Description": "Streamlined asynchronous strategy",
  "IncludeId": "velit",
  "AccessKey": "voluptatem",
  "HierarchyId": 496,
  "Source": "animi",
  "SourceCode": "in",
  "ScriptType": "CRMScript",
  "HtmlOutput": 823,
  "Includes": [
    430,
    858
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 302,
      "LineNumberTo": 163,
      "Delta": 598,
      "IncludeId": "nulla",
      "IncludedFrom": [
        "adipisci",
        "asperiores"
      ]
    },
    {
      "LineNumberFrom": 302,
      "LineNumberTo": 163,
      "Delta": 598,
      "IncludeId": "nulla",
      "IncludedFrom": [
        "adipisci",
        "asperiores"
      ]
    }
  ],
  "ValidationResult": null,
  "Registered": "2013-10-30T03:41:53.3401161+01:00",
  "RegisteredAssociateId": 521,
  "Updated": "2020-12-11T03:41:53.3401161+01:00",
  "UpdatedAssociateId": 66,
  "BlockedVerbs": "BlockAll"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 157,
  "UniqueIdentifier": "consequatur",
  "Name": "Wolf Group",
  "Description": "Expanded impactful support",
  "IncludeId": "laborum",
  "AccessKey": "possimus",
  "HierarchyId": 443,
  "Source": "mollitia",
  "SourceCode": "a",
  "ScriptType": "CRMScript",
  "HtmlOutput": 403,
  "Includes": [
    340,
    791
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 820,
      "LineNumberTo": 572,
      "Delta": 781,
      "IncludeId": "sed",
      "IncludedFrom": [
        "neque",
        "delectus"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 20
        }
      }
    }
  ],
  "ValidationResult": null,
  "Registered": "2015-10-07T03:41:53.3401161+02:00",
  "RegisteredAssociateId": 374,
  "Updated": "2006-01-11T03:41:53.3401161+01:00",
  "UpdatedAssociateId": 142,
  "BlockedVerbs": "BlockAll",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 331
    }
  }
}
```