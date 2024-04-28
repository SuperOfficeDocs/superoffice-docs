---
uid: custom-objects
title: custom-objects
description: "How to use the DatabaseTable Agent ReadRow"
author: Eivind Fasting
so.date: 04.28.2024
keywords: custom objects, get
so.topic: howto
---

# How to use the DatabaseTable Agent ReadRow

## Reference

The API Reference for ReadRow can be found [here][1]

### [RESTful AGENT](#tab/DatabaseTableAgent)

With the DatabaseTable Agent you pass in the TableName and Id of the row

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

### [RESTful REST](#tab/TableRecord)

With the TableRecord you pass inn the TableName and Id as part of the querystring

```http!
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Table/y_equipment/1 HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json
```

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
[1]: ../../../api/reference/restful/agent/DatabaseTable_Agent/v1DatabaseTableAgent_ReadRow.md
