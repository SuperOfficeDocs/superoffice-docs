```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ScreenChooserId": 975,
  "Name": "High Value Deal Alert",
  "ScreenType": "ChatAfterSaveNewMessage",
  "Enabled": true,
  "UniqueIdentifier": "high-value-deal-alert",
  "Source": "#setLanguageLevel 3;\nSale sale = getActiveSale();\nInteger amount = sale.getValue(\"amount\").toInteger();\nif (amount > 100000) { notifyManagement(sale); }",
  "Registered": "2024-08-05T13:20:00+02:00",
  "RegisteredAssociateId": 105,
  "Updated": "2024-11-27T09:10:00+01:00",
  "UpdatedAssociateId": 108,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 160
    }
  }
}
```
