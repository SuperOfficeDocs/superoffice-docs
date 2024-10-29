---
title: POST Agents/CRMScript/CreateDefaultCRMScriptEntity
uid: v1CRMScriptAgent_CreateDefaultCRMScriptEntity
generated: true
---

# POST Agents/CRMScript/CreateDefaultCRMScriptEntity

```http
POST /api/v1/Agents/CRMScript/CreateDefaultCRMScriptEntity
```

Set default values into a new CRMScriptEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.







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
POST /api/v1/Agents/CRMScript/CreateDefaultCRMScriptEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 471,
  "UniqueIdentifier": "quia",
  "Name": "Parker-Vandervort",
  "Description": "Reverse-engineered bandwidth-monitored local area network",
  "IncludeId": "neque",
  "AccessKey": "voluptatem",
  "HierarchyId": 39,
  "Source": "aut",
  "SourceCode": "accusantium",
  "ScriptType": "CRMScript",
  "HtmlOutput": 538,
  "Includes": [
    117,
    572
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 109,
      "LineNumberTo": 38,
      "Delta": 256,
      "IncludeId": "quas",
      "IncludedFrom": [
        "nam",
        "omnis"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 8
        }
      }
    }
  ],
  "ValidationResult": null,
  "Registered": "2006-03-14T13:14:05.710145+01:00",
  "RegisteredAssociateId": 928,
  "Updated": "2006-04-23T13:14:05.710145+02:00",
  "UpdatedAssociateId": 944,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 418
    }
  }
}
```