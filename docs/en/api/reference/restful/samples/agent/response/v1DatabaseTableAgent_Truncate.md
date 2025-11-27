```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Success": true,
  "Message": "Successfully truncated table, removed 152 rows",
  "Inserts": 0,
  "Updates": 0,
  "Deletes": 152,
  "RowStatus": [
    {
      "PrimaryKey": 0,
      "Action": "Truncated",
      "RowKeys": [
        "table=temp_contacts",
        "rows=152"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 166
        }
      }
    },
    {
      "PrimaryKey": 0,
      "Action": "Truncated",
      "RowKeys": [
        "operation=truncate",
        "timestamp=2024-01-15T10:30:00Z"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 166
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 148
    }
  }
}
```
