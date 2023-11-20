---
title: POST Agents/DocumentMigration/GetForTemplates
uid: v1DocumentMigrationAgent_GetForTemplates
generated: true
---

# POST Agents/DocumentMigration/GetForTemplates

```http
POST /api/v1/Agents/DocumentMigration/GetForTemplates
```

Gets a migration summary for all templates stored in CRM.


## Online Restricted: ## The DocumentMigration agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for SuperOffice-internal apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/DocumentMigration/GetForTemplates?$select=name,department,category/id
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

TargetDocumentPluginId, IncludeEmails 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TargetDocumentPluginId | Integer |  |
| IncludeEmails | Boolean |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: DocumentTemplateMigrationList

| Property Name | Type |  Description |
|----------------|------|--------------|
| NumTemplatesOmitted | int32 | Total amount of templates which has been omitted from the migration. |
| NumTemplatesAlreadyMigrated | int32 | Total amount of templates already migrated to the requested documentplugin. |
| TemplateIds | array | List of IDs for templates to be migrated. |

## Sample request

```http!
POST /api/v1/Agents/DocumentMigration/GetForTemplates
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TargetDocumentPluginId": 617,
  "IncludeEmails": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "NumTemplatesOmitted": 418,
  "NumTemplatesAlreadyMigrated": 146,
  "TemplateIds": [
    988,
    660
  ]
}
```