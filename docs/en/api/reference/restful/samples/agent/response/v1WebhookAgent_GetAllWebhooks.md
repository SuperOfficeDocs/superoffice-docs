```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "WebhookId": 3,
    "Name": "Ticket System Integration",
    "Events": [
      "ticket.created",
      "ticket.changed"
    ],
    "TargetUrl": "https://support.example.com/api/webhooks/tickets",
    "Secret": "sk_live_a1b2c3d4e5f6g7h8i9j0",
    "State": "Active",
    "Type": "webhook",
    "Headers": {
      "X-Service-Key": "support_integration_v2",
      "X-Webhook-Version": "1.0"
    },
    "Properties": {
      "fieldName": {}
    },
    "Registered": "2024-06-10T08:30:00+02:00",
    "RegisteredAssociate": null,
    "Updated": "2024-11-28T09:45:00+01:00",
    "UpdatedAssociate": null,
    "ErrorsEmail": "support-admin@example.com"
  }
]
```
