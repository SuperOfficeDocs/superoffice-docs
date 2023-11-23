---
title: POST Agents/DocumentMigration/CreateDefaultDocumentTemplateMigrationList
uid: v1DocumentMigrationAgent_CreateDefaultDocumentTemplateMigrationList
generated: true
---

# POST Agents/DocumentMigration/CreateDefaultDocumentTemplateMigrationList

```http
POST /api/v1/Agents/DocumentMigration/CreateDefaultDocumentTemplateMigrationList
```

Set default values into a new DocumentTemplateMigrationList.


NetServer calculates default values on the entity, which is required when creating/storing a new instance


## Online Restricted: ## The DocumentMigration agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for SuperOffice-internal apps.







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

### Response body: DocumentTemplateMigrationList

| Property Name | Type |  Description |
|----------------|------|--------------|
| NumTemplatesOmitted | int32 | Total amount of templates which has been omitted from the migration. |
| NumTemplatesAlreadyMigrated | int32 | Total amount of templates already migrated to the requested documentplugin. |
| TemplateIds | array | List of IDs for templates to be migrated. |

## Sample request

```http!
POST /api/v1/Agents/DocumentMigration/CreateDefaultDocumentTemplateMigrationList
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "NumTemplatesOmitted": 709,
  "NumTemplatesAlreadyMigrated": 171,
  "TemplateIds": [
    343,
    22
  ]
}
```