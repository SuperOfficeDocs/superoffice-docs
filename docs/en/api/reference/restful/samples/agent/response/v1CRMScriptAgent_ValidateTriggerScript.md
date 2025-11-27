```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Valid": true,
  "ErrorMessage": "",
  "LineNumber": 0,
  "ErrorInformation": null,
  "Transpiled": "var ticket = getActiveTicket();\nvar categoryId = ticket.getValue('categoryId').toInteger();\nticket.setValue('ownerId', findOwnerByCategory(categoryId).toString());",
  "Includes": [
    42,
    87
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 1,
      "LineNumberTo": 3,
      "Delta": 0,
      "IncludeId": "ticket-utils",
      "IncludedFrom": [
        "trigger-scripts",
        "auto-assignment"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 101
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 59
    }
  }
}
```
