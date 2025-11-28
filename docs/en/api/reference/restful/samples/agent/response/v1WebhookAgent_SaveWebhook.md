```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 2,
  "Name": "Sale Won Notification",
  "Events": [
    "sale.sold",
    "sale.lost"
  ],
  "TargetUrl": "https://crm.example.com/api/webhooks/sales",
  "Secret": "sk_live_9z8y7x6w5v4u3t2s1r0q",
  "State": "Active",
  "Type": "webhook",
  "Headers": {
    "X-API-Key": "prod_api_key_12345",
    "Content-Type": "application/json"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2024-03-20T14:15:00+01:00",
  "RegisteredAssociate": null,
  "Updated": "2024-11-28T11:00:00+01:00",
  "UpdatedAssociate": null,
  "ErrorsEmail": "sales-team@example.com"
}
```
