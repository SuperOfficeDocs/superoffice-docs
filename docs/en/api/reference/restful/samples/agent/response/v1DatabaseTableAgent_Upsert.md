```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Success": true,
  "Message": "Successfully processed 2 rows: 1 inserted, 1 updated",
  "Inserts": 1,
  "Updates": 1,
  "Deletes": 0,
  "RowStatus": [
    {
      "PrimaryKey": 127,
      "Action": "Inserted",
      "RowKeys": [
        "contact_id=127",
        "name=Pacific Enterprises"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 72
        }
      }
    },
    {
      "PrimaryKey": 123,
      "Action": "Updated",
      "RowKeys": [
        "contact_id=123",
        "name=Acme Corporation"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 72
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 303
    }
  }
}
```
