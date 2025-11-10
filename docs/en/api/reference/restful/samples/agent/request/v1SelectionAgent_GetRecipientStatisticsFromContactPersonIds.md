```http!
POST /api/v1/Agents/Selection/GetRecipientStatisticsFromContactPersonIds
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactPersonIds": [
    {
      "PersonId": 412,
      "ContactId": 392
    },
    {
      "PersonId": 412,
      "ContactId": 392
    }
  ]
}
```