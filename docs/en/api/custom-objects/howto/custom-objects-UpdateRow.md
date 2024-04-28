---
uid: custom-objects
title: custom-objects
description: "How to use the DatabaseTable Agent UpdateRow"
author: Eivind Fasting
so.date: 04.28.2024
keywords: custom objects, get
so.topic: howto
---

# How to use the DatabaseTable Agent UpdateRow

## Reference

The API Reference for UpdateRow can be found [here][1]

### [RESTful AGENT](#tab/DatabaseTableAgent)

With the DatabaseTable Agent you pass in the TableName, Id and Values in the body

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

With the TableRecord you pass inn the TableName and rowId in the querysttring, and the values to update in the body

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

### Response

```http_
HTTP/1.1 204 No Content
```

<!-- Referenced links -->
[1]: ../../../api/reference/restful/agent/DatabaseTable_Agent/v1DatabaseTableAgent_UpdateRow.md
