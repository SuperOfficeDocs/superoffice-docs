```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Success": true,
  "Message": "Successfully deleted 2 rows from contact table",
  "Inserts": 0,
  "Updates": 0,
  "Deletes": 2,
  "RowStatus": [
    {
      "PrimaryKey": 123,
      "Action": "Deleted",
      "RowKeys": [
        "contact_id=123",
        "name=Acme Corporation"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 560
        }
      }
    },
    {
      "PrimaryKey": 124,
      "Action": "Deleted",
      "RowKeys": [
        "contact_id=124",
        "name=TechCorp Solutions"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 560
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 109
    }
  }
}
```
