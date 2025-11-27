```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ScreenChooserId": 983,
  "Name": "Sale Stage Change Notification",
  "ScreenType": "ChatAfterSaveNewMessage",
  "Enabled": true,
  "UniqueIdentifier": "sale-stage-change-notify",
  "Source": "#setLanguageLevel 3;\nSale sale = getActiveSale();\nString oldStage = getVariable(\"oldStage\");\nString newStage = sale.getValue(\"stage\");\nnotifySalesTeam(sale, oldStage, newStage);",
  "Registered": "2024-07-20T11:00:00+01:00",
  "RegisteredAssociateId": 108,
  "Updated": "2024-11-26T16:30:00+01:00",
  "UpdatedAssociateId": 105,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 618
    }
  }
}
```
