```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Valid": true,
  "ErrorMessage": "",
  "LineNumber": 0,
  "ErrorInformation": null,
  "Transpiled": "var sale = getActiveSale();\nvar amount = sale.getValue('amount').toInteger();\nif (amount > 100000) { notifyManagement(sale); }",
  "Includes": [
    42,
    87
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 1,
      "LineNumberTo": 3,
      "Delta": 0,
      "IncludeId": "notification-utils",
      "IncludedFrom": [
        "high-value-deal-alert",
        "management-notifications"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 844
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 945
    }
  }
}
```
