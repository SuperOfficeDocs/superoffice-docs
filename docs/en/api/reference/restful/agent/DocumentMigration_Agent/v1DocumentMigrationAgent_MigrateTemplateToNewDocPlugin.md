---
title: POST Agents/DocumentMigration/MigrateTemplateToNewDocPlugin
uid: v1DocumentMigrationAgent_MigrateTemplateToNewDocPlugin
generated: true
---

# POST Agents/DocumentMigration/MigrateTemplateToNewDocPlugin

```http
POST /api/v1/Agents/DocumentMigration/MigrateTemplateToNewDocPlugin
```

Migrates the template with the provided id to the specified document-plugin.


## Online Restricted: ## The DocumentMigration agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for SuperOffice-internal apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/DocumentMigration/MigrateTemplateToNewDocPlugin?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

DocumentTemplateId, TargetDocumentPluginId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentTemplateId | Integer |  |
| TargetDocumentPluginId | Integer |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/DocumentMigration/MigrateTemplateToNewDocPlugin
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentTemplateId": 435,
  "TargetDocumentPluginId": 40
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```