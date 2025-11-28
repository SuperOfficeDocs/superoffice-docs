```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 1,
  "Name": "Contact Created Notification",
  "Events": [
    "contact.created",
    "contact.changed"
  ],
  "TargetUrl": "https://api.example.com/webhooks/superoffice/contacts",
  "Secret": "sk_live_1a2b3c4d5e6f7g8h9i0j",
  "State": "Active",
  "Type": "webhook",
  "Headers": {
    "X-Custom-Header": "ContactIntegration",
    "Authorization": "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2024-01-15T09:00:00+01:00",
  "RegisteredAssociate": null,
  "Updated": "2024-11-28T10:30:00+01:00",
  "UpdatedAssociate": null,
  "ErrorsEmail": "admin@example.com"
}
```
