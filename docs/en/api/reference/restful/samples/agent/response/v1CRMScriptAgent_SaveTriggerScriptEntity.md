```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ScreenChooserId": 87,
  "Name": "Contact Update Notification",
  "ScreenType": "ChatAfterSaveNewMessage",
  "Enabled": true,
  "UniqueIdentifier": "contact-update-notify",
  "Source": "#setLanguageLevel 3;\nContact contact = getActiveContact();\nString changes = getContactChanges(contact);\nnotifyAssignedUsers(contact, changes);",
  "Registered": "2024-06-12T09:00:00+02:00",
  "RegisteredAssociateId": 105,
  "Updated": "2024-11-26T15:45:00+01:00",
  "UpdatedAssociateId": 108,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 688
    }
  }
}
```
