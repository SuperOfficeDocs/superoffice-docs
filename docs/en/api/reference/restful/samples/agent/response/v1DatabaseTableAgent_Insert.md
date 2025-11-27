```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Success": true,
  "Message": "Successfully inserted 2 rows into contact table",
  "Inserts": 2,
  "Updates": 0,
  "Deletes": 0,
  "RowStatus": [
    {
      "PrimaryKey": 125,
      "Action": "Inserted",
      "RowKeys": [
        "contact_id=125",
        "name=GlobalCorp Industries"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 500
        }
      }
    },
    {
      "PrimaryKey": 126,
      "Action": "Inserted",
      "RowKeys": [
        "contact_id=126",
        "name=Nordic Solutions AS"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 500
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 459
    }
  }
}
```
