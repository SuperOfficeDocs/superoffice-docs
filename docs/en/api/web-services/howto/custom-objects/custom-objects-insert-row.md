---
uid: api-custom-objects-insert-row
title: Custom Objects InsertRow
description: How to use the DatabaseTable Agent InsertRow
author: Eivind Fasting
so.date: 04.28.2024
keywords: custom objects, InsertRow
so.topic: howto
---

# How to use the DatabaseTable Agent InsertRow

## Reference

See the [InsertRow][1] API Reference for more details.

<!-- markdownlint-disable MD051 -->
### [RESTful AGENT](#tab/DatabaseTableAgent)

Using the DatabaseTable Agent, specify the TableName and Values as body parameters to insert a new row.

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

### [RESTful REST](#tab/TableRecord)

Using the TableRecord endpoint, specify the TableName in the url and the values in the body to insert a new row.

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

***
<!-- markdownlint-restore -->

### Response

The Response returns the recordId of the new row.

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
2
```

<!-- Referenced links -->
[1]: ../../../api/reference/restful/agent/DatabaseTable_Agent/v1DatabaseTableAgent_InsertRow.md