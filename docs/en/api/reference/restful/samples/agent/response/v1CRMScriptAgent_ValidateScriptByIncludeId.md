```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Valid": false,
  "ErrorMessage": "Undefined variable 'customerEmail' on line 5",
  "LineNumber": 5,
  "ErrorInformation": null,
  "Transpiled": "",
  "Includes": [
    42,
    87
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 1,
      "LineNumberTo": 5,
      "Delta": 0,
      "IncludeId": "email-utils",
      "IncludedFrom": [
        "customer-handler",
        "notification-system"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 390
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 22
    }
  }
}
```
