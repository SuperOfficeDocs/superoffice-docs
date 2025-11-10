```http!
POST /api/v1/Agents/Ticket/GetHotlistEjUsers
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 276,
  "SkipAssociateIds": [
    454,
    65
  ],
  "NotifyType": "ActiveTickets",
  "Channel": "Email"
}
```