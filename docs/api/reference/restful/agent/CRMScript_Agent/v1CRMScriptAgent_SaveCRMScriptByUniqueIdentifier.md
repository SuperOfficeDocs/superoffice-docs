---
title: POST Agents/CRMScript/SaveCRMScriptByUniqueIdentifier
id: v1CRMScriptAgent_SaveCRMScriptByUniqueIdentifier
---

# POST Agents/CRMScript/SaveCRMScriptByUniqueIdentifier

```http
POST /api/v1/Agents/CRMScript/SaveCRMScriptByUniqueIdentifier
```

Create or Update the CRMScript information

## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CRMScript/SaveCRMScriptByUniqueIdentifier?$select=name,department,category/id
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

UniqueIdentifier, CRMScript

| Property Name | Type |  Description |
|----------------|------|--------------|
| UniqueIdentifier | string |  |
| CRMScript |  | The Script Service. The service implements all services working with the CRMScript object without reference to primary keys. Primarily used by VSCode integration. <br /> Carrier object for Script. Services for the Script Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ICRMScriptAgent">CRMScript Agent</see>. |

## Response: object

The Script Service. The service implements all services working with the CRMScript object without reference to primary keys. Primarily used by VSCode integration.

Carrier object for Script.
Services for the Script Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ICRMScriptAgent">CRMScript Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| UniqueIdentifier | string | Global unique identifier, accross customers/tenants |
| Name | string | A description of this script |
| Description | string | Optional description of what this script is used for. |
| IncludeId | string | A unique name used for including this script in another |
| Source | string | The script |
| Registered | date-time | Registered when  in UTC. |
| RegisteredBy | string | Who created this script |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedBy | string | Who updated this script |
| Path | string | Path to script in the hierarchy. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/CRMScript/SaveCRMScriptByUniqueIdentifier
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "UniqueIdentifier": "et",
  "Crmscript": {
    "UniqueIdentifier": "blanditiis",
    "Name": "Rolfson-Bailey",
    "Description": "Cross-group executive infrastructure",
    "IncludeId": "et",
    "Source": "velit",
    "Registered": "2019-03-28T18:28:48.6319279+01:00",
    "RegisteredBy": "ut",
    "Updated": "2021-11-15T18:28:48.6319279+01:00",
    "UpdatedBy": "iusto",
    "Path": "et"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "UniqueIdentifier": "nobis",
  "Name": "Swaniawski LLC",
  "Description": "Customer-focused hybrid concept",
  "IncludeId": "occaecati",
  "Source": "eum",
  "Registered": "2008-11-22T18:28:48.6329579+01:00",
  "RegisteredBy": "incidunt",
  "Updated": "2006-06-08T18:28:48.6329579+02:00",
  "UpdatedBy": "excepturi",
  "Path": "suscipit",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 369
    }
  }
}
```
