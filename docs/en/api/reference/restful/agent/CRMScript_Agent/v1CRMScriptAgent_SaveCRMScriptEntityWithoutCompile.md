---
title: POST Agents/CRMScript/SaveCRMScriptEntityWithoutCompile
uid: v1CRMScriptAgent_SaveCRMScriptEntityWithoutCompile
generated: true
content_type: reference
---

# POST Agents/CRMScript/SaveCRMScriptEntityWithoutCompile

```http
POST /api/v1/Agents/CRMScript/SaveCRMScriptEntityWithoutCompile
```

Save the script directly without compiling TypeScript


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CRMScript/SaveCRMScriptEntityWithoutCompile?$select=name,department,category/id
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

CrmScriptEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| CrmScriptEntity | CRMScriptEntity | CRM Scripts - stored in the ejScript table, including source code. <para /> Carrier object for CRMScriptEntity. Services for the CRMScriptEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ICRMScriptAgent">CRMScript Agent</see>. |

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
POST /api/v1/Agents/CRMScript/SaveCRMScriptEntityWithoutCompile
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "CrmScriptEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 287,
  "UniqueIdentifier": "eaque",
  "Name": "Mills-Toy",
  "Description": "Exclusive client-server product",
  "IncludeId": "nulla",
  "AccessKey": "est",
  "HierarchyId": 110,
  "Source": "officiis",
  "SourceCode": "natus",
  "ScriptType": "CRMScript",
  "HtmlOutput": 349,
  "Includes": [
    432,
    464
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 401,
      "LineNumberTo": 529,
      "Delta": 625,
      "IncludeId": "quis",
      "IncludedFrom": [
        "et",
        "nam"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 492
        }
      }
    }
  ],
  "ValidationResult": null,
  "Registered": "2024-04-28T11:24:47.8439178+02:00",
  "RegisteredAssociateId": 477,
  "Updated": "2018-11-08T11:24:47.8439178+01:00",
  "UpdatedAssociateId": 249,
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