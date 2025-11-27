```http!
POST /api/v1/Agents/Ticket/DoEscalating
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 999,
  "Action": "ActionChangedOwner"
}
```