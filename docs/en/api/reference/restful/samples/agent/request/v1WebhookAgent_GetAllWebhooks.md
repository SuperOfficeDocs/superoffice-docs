```http!
POST /api/v1/Agents/Webhook/GetAllWebhooks
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "NameFilter": "Johns Inc and Sons",
  "EventFilter": "qui",
  "StatusFilter": "Active"
}
```