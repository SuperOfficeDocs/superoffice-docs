```http!
POST /api/v1/Agents/Ticket/SendTicketMessageSms
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketMessageEntityId": 521,
  "ReplyTemplateId": 961,
  "Sms": [
    "ut",
    "est"
  ]
}
```