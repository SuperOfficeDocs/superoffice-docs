---
uid: api-custom-objects-update-row
title: Custom Objects UpdateRow
description: How to use the DatabaseTable Agent UpdateRow
author: Eivind Fasting
so.date: 04.28.2024
keywords: custom objects, UpdateRow
so.topic: howto
---

# How to use the DatabaseTable Agent UpdateRow

## Reference

See the [UpdateRow][1] API Reference for more details.

<!-- markdownlint-disable MD051 -->
### [RESTful AGENT](#tab/DatabaseTableAgent)

Using the DatabaseTable Agent, specify the TableName, Id and Values body parameters to update the row.

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

### [RESTful REST](#tab/TableRecord)

Using the TableRecord endpoint, specify the TableName and record Id as query string parameters, and the values to update in the body of the request.

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

***
<!-- markdownlint-restore -->

### Response

```http_
HTTP/1.1 204 No Content
```

<!-- Referenced links -->
[1]: ../../../api/reference/restful/agent/DatabaseTable_Agent/v1DatabaseTableAgent_UpdateRow.md
