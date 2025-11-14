```http!
POST /api/v1/Agents/Ticket/RemoveMessageAttachments
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketMessageEntityId": 568,
  "AttachmentIds": [
    234,
    7
  ]
}
```