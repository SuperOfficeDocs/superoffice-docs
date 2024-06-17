---
uid: api-custom-objects-read-row
title: Custom Objects ReadRow
description: How to use the DatabaseTable Agent ReadRow
author: Eivind Fasting
so.date: 04.28.2024
keywords: custom objects, ReadRow
so.topic: howto
---

# How to use the DatabaseTable Agent ReadRow

## Reference

See the [ReadRow][1] API Reference for more details.

<!-- markdownlint-disable MD051 -->
### [RESTful AGENT](#tab/DatabaseTableAgent)

Using the DatabaseTable Agent, specify the TableName and Id as body parameters to return the row.

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

Using the TableRecord endpoint, specify the TableName and Id as part of the query string to return the row.

```http!
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Table/y_equipment/1 HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json
```

***
<!-- markdownlint-restore -->
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