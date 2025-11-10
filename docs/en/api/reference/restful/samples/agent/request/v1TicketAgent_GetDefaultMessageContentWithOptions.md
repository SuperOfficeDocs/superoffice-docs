```http!
POST /api/v1/Agents/Ticket/GetDefaultMessageContentWithOptions
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 646,
  "MessageActionType": "Forward",
  "TicketMessageId": 26,
  "TicketTypeId": 124,
  "ExcludeSignature": false
}
```