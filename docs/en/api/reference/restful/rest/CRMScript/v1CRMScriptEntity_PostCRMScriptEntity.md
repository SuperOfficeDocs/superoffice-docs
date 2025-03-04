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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 533,
  "UniqueIdentifier": "blanditiis",
  "Name": "Mills Group",
  "Description": "Horizontal systemic database",
  "IncludeId": "voluptates",
  "AccessKey": "non",
  "HierarchyId": 24,
  "Source": "aliquid",
  "SourceCode": "laboriosam",
  "ScriptType": "CRMScript",
  "HtmlOutput": 406,
  "Includes": [
    632,
    988
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 913,
      "LineNumberTo": 225,
      "Delta": 612,
      "IncludeId": "et",
      "IncludedFrom": [
        "quidem",
        "tenetur"
      ]
    },
    {
      "LineNumberFrom": 913,
      "LineNumberTo": 225,
      "Delta": 612,
      "IncludeId": "et",
      "IncludedFrom": [
        "quidem",
        "tenetur"
      ]
    }
  ],
  "ValidationResult": null,
  "Registered": "2006-10-05T14:13:48.7430769+02:00",
  "RegisteredAssociateId": 679,
  "Updated": "2013-01-15T14:13:48.7430769+01:00",
  "UpdatedAssociateId": 333
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 473,
  "UniqueIdentifier": "ex",
  "Name": "Collins-Streich",
  "Description": "Programmable system-worthy application",
  "IncludeId": "eligendi",
  "AccessKey": "ea",
  "HierarchyId": 244,
  "Source": "id",
  "SourceCode": "aliquid",
  "ScriptType": "CRMScript",
  "HtmlOutput": 631,
  "Includes": [
    501,
    627
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 720,
      "LineNumberTo": 994,
      "Delta": 35,
      "IncludeId": "dolore",
      "IncludedFrom": [
        "dolores",
        "assumenda"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 243
        }
      }
    }
  ],
  "ValidationResult": null,
  "Registered": "2007-05-25T14:13:48.7430769+02:00",
  "RegisteredAssociateId": 547,
  "Updated": "2012-04-07T14:13:48.7430769+02:00",
  "UpdatedAssociateId": 473,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 547
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```