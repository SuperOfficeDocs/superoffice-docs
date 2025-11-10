```http!
POST /api/v1/Agents/Selection/CreateTemporaryContactSelectionFromContactPersonIds
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactPersonIds": [
    {
      "PersonId": 674,
      "ContactId": 647
    },
    {
      "PersonId": 674,
      "ContactId": 647
    }
  ]
}
```