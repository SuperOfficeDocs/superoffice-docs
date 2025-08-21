---
uid: api-rest-custom-object-update-row
title: How to update a row in a custom object
description: How to update a row in a custom object via the REST APIs.
author: Eivind Fasting
date: 04.28.2024
version: 10
keywords: custom object, UpdateRow, DatabaseTable, TableRecord, extra table
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from:
  - /en/api/custom-objects/howto/custom-objects-update-row
  - /en/api/netserver/web-services/howto/custom-objects/rest-update-custom-object-row
---

<!-- markdownlint-disable-file MD051 -->

# How to update a row in a custom object

## Request

### [HTTP RPC Agent](#tab/DatabaseTableAgent)

To update a row using the `DatabaseTable` agent, specify the `TableName`, `Id`, and `Values` as body parameters.

```http!
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/DatabaseTable/UpdateRow HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json
{
  "TableName": "y_equipment",
  "Id": "2",
  "Values": {
    "x_company": 1,
    "x_name": "printer"
  }
}
```

For details, see the [DatabaseTable agent reference][1].

### [RESTful REST](#tab/TableRecord)

To update a row using the `TableRecord` endpoint, specify the table name and row ID as query string parameters, and the values to update in the body.

```http!
PUT https://{{env}}.superoffice.com/{{tenant}}/api/v1/Table/y_equipment/2 HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json
{
    "x_company": 1,
    "x_name": "Desk"
}
```

For details, see the [Table REST endpoint reference][2].

***

### Response

```http_
HTTP/1.1 204 No Content
```

<!-- Referenced links -->
[1]: ../../../reference/restful/agent/DatabaseTable_Agent/v1DatabaseTableAgent_UpdateRow.md
[2]: ../../../reference/restful/rest/TableRecord/v1TableRecord_UpdateRow.md
