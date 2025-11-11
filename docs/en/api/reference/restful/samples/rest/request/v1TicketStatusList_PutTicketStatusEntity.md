```http!
PUT /api/v1/List/TicketStatus/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketStatusId": 98,
  "Name": "Sporer-Ryan",
  "Status": "Active",
  "TimeCounter": "Externally",
  "NoEmailReopen": false,
  "IsDefault": false,
  "UsedInQueue": true
}
```