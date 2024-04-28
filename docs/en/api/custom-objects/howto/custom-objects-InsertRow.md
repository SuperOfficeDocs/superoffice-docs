---
uid: custom-objects
title: custom-objects
description: "How to use the DatabaseTable Agent InsertRow"
author: Eivind Fasting
so.date: 04.28.2024
keywords: custom objects, get
so.topic: howto
---

# How to use the DatabaseTable Agent InsertRow

## Reference

The API Reference for InsertRow can be found [here][1]

### [RESTful AGENT](#tab/DatabaseTableAgent)

With the DatabaseTable Agent you pass in the TableName and Values in the body

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

With the TableRecord you pass inn the TableName and values in the body

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

### Response

The reponse is the returned recordId of the new row

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

2
```

<!-- Referenced links -->
[1]: ../../../api/reference/restful/agent/DatabaseTable_Agent/v1DatabaseTableAgent_InsertRow.md
