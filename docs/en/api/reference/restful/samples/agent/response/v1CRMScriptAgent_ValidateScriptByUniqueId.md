```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Valid": false,
  "ErrorMessage": "Method 'calculateScore' is not defined",
  "LineNumber": 7,
  "ErrorInformation": null,
  "Transpiled": "",
  "Includes": [
    42,
    87
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 1,
      "LineNumberTo": 7,
      "Delta": 0,
      "IncludeId": "scoring-utils",
      "IncludedFrom": [
        "opportunity-scorer",
        "sales-automation"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 717
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 170
    }
  }
}
```
