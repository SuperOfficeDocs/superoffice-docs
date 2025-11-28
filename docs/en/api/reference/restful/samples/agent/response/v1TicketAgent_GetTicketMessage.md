```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketMessageId": 5678,
  "CreatedAt": "2024-11-15T11:30:00+01:00",
  "Slevel": "External",
  "Important": false,
  "Author": "support@company.com",
  "PersonId": 10,
  "PersonFullName": "Sarah Johnson",
  "ContactId": 123,
  "ContactName": "Acme Corporation",
  "ContactDepartment": "Support",
  "NumAttachments": 1,
  "EmailHeader": "support@company.com",
  "MessageHeaders": [
    {
      "Id": 101,
      "Name": "Subject",
      "Value": "Re: Cannot access customer portal - Login button not working",
      "StdItem": "CustomerReadFAQ",
      "StdItemCol": "Name",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 931
        }
      }
    }
  ],
  "Language": "en",
  "Sentiment": 85,
  "SentimentConfidence": 92,
  "CreatedBy": 10,
  "ChangedAt": "2024-11-15T11:30:00+01:00",
  "Badge": "Reply",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 718
    }
  }
}
```
