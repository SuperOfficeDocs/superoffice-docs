```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Valid": true,
  "ErrorMessage": "",
  "LineNumber": 0,
  "ErrorInformation": null,
  "Transpiled": "var recipientEmail = getVariable('recipientEmail');\nvar email = new Email();\nemail.send(recipientEmail, 'New Ticket', 'A new ticket has been created');",
  "Includes": [
    42,
    87
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 1,
      "LineNumberTo": 3,
      "Delta": 0,
      "IncludeId": "email-utils",
      "IncludedFrom": [
        "common-includes",
        "notification-system"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 90
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 104
    }
  }
}
```
