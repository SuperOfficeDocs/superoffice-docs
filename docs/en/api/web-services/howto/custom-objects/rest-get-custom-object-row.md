---
uid: api-rest-custom-object-get-row
title: How to get a row from a custom object
description: How to get (read) a row from a custom object via the REST APIs.
author: Eivind Fasting
date: 04.28.2024
version: 10
keywords: custom object, ReadRow, DatabaseTable, TableRecord, extra table
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from:
  - /en/api/custom-objects/howto/custom-objects-read-row
  - /en/api/netserver/web-services/howto/custom-objects/rest-get-custom-object-row
---

<!-- markdownlint-disable-file MD051 -->

# How to get (read) a row from a custom object

## Request

### [HTTP RPC Agent](#tab/DatabaseTableAgent)

To get a row using the `DatabaseTable` agent, specify the `TableName` and `Id` as body parameters.

```http!
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/DatabaseTable/ReadRow HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json
{
    "TableName": "y_equipment",
    "Id": 1
}
```

For details, see the [DatabaseTable agent reference][1].

### [RESTful REST](#tab/TableRecord)

To get a row using the `TableRecord` endpoint, specify the table name and row ID as query string parameters.

```http!
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Table/y_equipment/1 HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json
```

For details, see the [Table REST endpoint reference][2].

***

### Response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
{
  "Values": {
    "id": "[I:1]",
    "last_changed": "[DT:04/28/2024 20:28:37.0000000]",
    "dbi_agent_id": "[I:-1]",
    "dbi_key": "",
    "dbi_last_syncronized": "[DT:01/01/0001 00:00:00.0000000]",
    "dbi_last_modified": "[DT:04/28/2024 20:28:37.0000000]",
    "x_name": "computer",
    "x_company": "[I:1]",
    "x_company:DisplayText": "SuperOffice Software Limited"
  },
  "TableRight": null,
  "FieldProperties": {}
}
```

<!-- Referenced links -->
[1]: ../../../reference/restful/agent/DatabaseTable_Agent/v1DatabaseTableAgent_ReadRow.md
[2]: ../../../reference/restful/rest/TableRecord/v1TableRecord_ReadRow.md
