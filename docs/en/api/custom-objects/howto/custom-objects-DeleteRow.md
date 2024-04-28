---
uid: custom-objects
title: custom-objects
description: "How to use the DatabaseTable Agent DeleteRow"
author: Eivind Fasting
so.date: 04.28.2024
keywords: custom objects, get
so.topic: howto
---

# How to use the DatabaseTable Agent DeleteRow

## Reference

The API Reference for DeleteRow can be found [here][1]

### [RESTful AGENT](#tab/DatabaseTableAgent)

With the DatabaseTable Agent you pass in the TableName and rowId

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

With the TableRecord you pass inn the TableName and rowId in the querysttring, and the values to update in the body

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
