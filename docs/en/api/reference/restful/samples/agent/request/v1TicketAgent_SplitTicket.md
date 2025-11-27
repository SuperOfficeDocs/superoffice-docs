```http!
POST /api/v1/Agents/Ticket/SplitTicket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SourceTicketEntityId": 20,
  "SourceTicketEntityStatusId": 26,
  "SourceTicketEntityActivate": "2012-11-03T10:11:01.4904622+01:00",
  "TransferMessageIds": [
    885,
    209
  ],
  "NewTicketEntity": null
}
```