---
uid: api-custom-objects-delete-row
title: Custom Objects DeleteRow
description: How to use the DatabaseTable Agent DeleteRow
author: Eivind Fasting
so.date: 04.28.2024
keywords: custom objects, DeleteRow
so.topic: howto
---

# How to use the DatabaseTable Agent DeleteRow

## Reference

See the [DeleteRow][1] API Reference for more details.

### [RESTful AGENT](#tab/DatabaseTableAgent)

Using the DatabaseTable Agent, specify the TableName and Id to delete the row.

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

### [RESTful REST](#tab/TableRecord)

Using the TableRecord endpoint specify the TableName and rowId as query string parameters to delete the record.

```http!
DELETE  https://{{env}}.superoffice.com/{{tenant}}/api/v1/Table/y_equipment/3 HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json
```

***

### Response

```http_
HTTP/1.1 204 No Content
```

<!-- Referenced links -->
[1]: ../../../api/reference/restful/agent/DatabaseTable_Agent/v1DatabaseTableAgent_DeleteRow.md
