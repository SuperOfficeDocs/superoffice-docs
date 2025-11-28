```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ScreenChooserId": 835,
  "Name": "New Ticket Auto-Assignment",
  "ScreenType": "ChatAfterSaveNewMessage",
  "Enabled": true,
  "UniqueIdentifier": "new-ticket-auto-assign",
  "Source": "#setLanguageLevel 3;\nTicket ticket = getActiveTicket();\nInteger categoryId = ticket.getValue(\"categoryId\").toInteger();\nticket.setValue(\"ownerId\", findOwnerByCategory(categoryId).toString());",
  "Registered": "2024-01-15T09:30:00+01:00",
  "RegisteredAssociateId": 105,
  "Updated": "2024-11-20T14:45:00+01:00",
  "UpdatedAssociateId": 105,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 98
    }
  }
}
```
