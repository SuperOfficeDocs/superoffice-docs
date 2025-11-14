```http!
POST /api/v1/Agents/Ticket/UpdateTicketsReadStatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketIds": [
    1001,
    645
  ],
  "NewStatus": "Green"
}
```