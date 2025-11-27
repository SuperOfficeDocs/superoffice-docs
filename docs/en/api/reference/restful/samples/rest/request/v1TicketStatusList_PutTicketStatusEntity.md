```http!
PUT /api/v1/List/TicketStatus/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketStatusId": 408,
  "Name": "Goyette-Dooley",
  "Status": "Active",
  "TimeCounter": "Externally",
  "NoEmailReopen": true,
  "IsDefault": true,
  "UsedInQueue": false
}
```