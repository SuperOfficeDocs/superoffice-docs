```http!
POST /api/v1/List/TicketStatus/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketStatusId": 270,
  "Name": "Conn-Hand",
  "Status": "Active",
  "TimeCounter": "Externally",
  "NoEmailReopen": true,
  "IsDefault": false,
  "UsedInQueue": false
}
```