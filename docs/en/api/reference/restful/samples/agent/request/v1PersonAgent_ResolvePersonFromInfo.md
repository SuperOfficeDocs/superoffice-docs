```http!
POST /api/v1/Agents/Person/ResolvePersonFromInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 474,
  "PersonName": "Wolf LLC",
  "PhoneNumbers": [
    "307104",
    "1460305"
  ],
  "Emails": [
    "loraine.hodkiewicz@miller.biz",
    "marcelo.hammes@kassulkerohan.name"
  ]
}
```