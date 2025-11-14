```http!
POST /api/v1/Agents/Selection/AddContactSelectionMembers
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 694,
  "ContactPersonIds": [
    {
      "PersonId": 486,
      "ContactId": 808
    },
    {
      "PersonId": 486,
      "ContactId": 808
    }
  ]
}
```