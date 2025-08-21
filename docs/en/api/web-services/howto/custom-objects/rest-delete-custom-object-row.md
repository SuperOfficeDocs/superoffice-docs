---
uid: api-rest-custom-objects-delete-row
title: How to update a row in a custom object
description: How to update a row in a custom object via the REST APIs.
keywords: custom object, DeleteRow, DatabaseTable, TableRecord, extra table
author: Eivind Fasting
date: 04.28.2024
version: 10
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from:
  - /en/api/custom-objects/howto/custom-objects-delete-row
  - /en/api/netserver/web-services/howto/custom-objects/rest-delete-custom-object-row
---

<!-- markdownlint-disable-file MD051 -->

# How to update a row in a custom object

## Request

### [HTTP RPC Agent](#tab/DatabaseTableAgent)

To delete a row using the `DatabaseTable` agent, specify the `TableName` and `Id` as body parameters.

```http!
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/DatabaseTable/DeleteRow HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json
{
    "TableName": "y_equipment",
    "Id": "2"
}
```

For details, see the [DatabaseTable agent reference][1].

### [RESTful REST](#tab/TableRecord)

To delete a record using the `TableRecord` endpoint, specify the table name and row ID as query string parameters.

```http!
DELETE  https://{{env}}.superoffice.com/{{tenant}}/api/v1/Table/y_equipment/3 HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json
```

For details, see the [Table REST endpoint reference][2].

***

### Response

```http_
HTTP/1.1 204 No Content
```

<!-- Referenced links -->
[1]: ../../../reference/restful/agent/DatabaseTable_Agent/v1DatabaseTableAgent_DeleteRow.md
[2]: ../../../reference/restful/rest/TableRecord/v1TableRecord_DeleteRow.md
