```http!
POST /api/v1/Agents/Ticket/BatchForward
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketIds": [
    789,
    111
  ],
  "To": [
    "ullam",
    "corporis"
  ],
  "Cc": [
    "sapiente",
    "reprehenderit"
  ],
  "Bcc": [
    "praesentium",
    "fugit"
  ],
  "Comment": "dolores",
  "CloseTicket": false
}
```