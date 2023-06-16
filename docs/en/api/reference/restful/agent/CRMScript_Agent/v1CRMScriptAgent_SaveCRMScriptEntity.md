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
| HierarchyId | Integer | The script is inside this hierarchy folder |
| Source | String | The script |
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
| HierarchyId | int32 | The script is inside this hierarchy folder |
| Source | string | The script |
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 721,
  "UniqueIdentifier": "eum",
  "Name": "Gusikowski, Terry and Spinka",
  "Description": "Object-based intermediate complexity",
  "IncludeId": "nisi",
  "HierarchyId": 278,
  "Source": "blanditiis",
  "Registered": "1996-12-07T16:00:40.4768796+01:00",
  "RegisteredAssociateId": 527,
  "Updated": "2003-12-24T16:00:40.4768796+01:00",
  "UpdatedAssociateId": 38
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 842,
  "UniqueIdentifier": "dolor",
  "Name": "Will LLC",
  "Description": "Synergized directional moratorium",
  "IncludeId": "aut",
  "HierarchyId": 183,
  "Source": "omnis",
  "Registered": "2010-10-16T16:00:40.4768796+02:00",
  "RegisteredAssociateId": 55,
  "Updated": "2010-04-10T16:00:40.4768796+02:00",
  "UpdatedAssociateId": 70,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 132
    }
  }
}
```