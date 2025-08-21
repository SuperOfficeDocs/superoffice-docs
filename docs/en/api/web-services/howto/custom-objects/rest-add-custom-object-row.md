---
uid: api-rest-custom-object-add-row
title: How to add a row to a custom object
description: How to add a row to a custom object via the REST APIs.
author: Eivind Fasting
date: 04.28.2024
version: 10
keywords: custom object, InsertRow, DatabaseTable, TableRecord, extra table
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from:
  - /en/api/custom-objects/howto/custom-objects-insert-row
  - /en/api/netserver/web-services/howto/custom-objects/rest-add-custom-object-row
---

<!-- markdownlint-disable-file MD051 -->

# How to add a row to a custom object

## Request

### [HTTP RPC Agent](#tab/DatabaseTableAgent)

To insert a new row using the `DatabaseTable` agent, specify the `TableName` and `Values` as body parameters.

```http!
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/DatabaseTable/InsertRow HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json
{
    "TableName": "y_equipment",
    "Values: {
        "x_company": 1,
        "x_name": "printer"
    }
}
```

For details, see the [DatabaseTable agent reference][1].

### [RESTful REST](#tab/TableRecord)

To insert a new row using the `TableRecord` endpoint, specify the table name in the URL and the values in the body.

```http!
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Table/y_equipment HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json
{
    "x_company": 1,
    "x_name": "printer"
}
```

For details, see the [Table REST endpoint reference][2].

***

### Response

The Response returns the recordId of the new row.

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
2
```

<!-- Referenced links -->
[1]: ../../../reference/restful/agent/DatabaseTable_Agent/v1DatabaseTableAgent_InsertRow.md
[2]: ../../../reference/restful/rest/TableRecord/v1TableRecord_InsertRow.md
