```http!
POST /api/v1/Agents/Selection/RemoveContactSelectionMembers
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 825,
  "ContactPersonIds": [
    {
      "PersonId": 724,
      "ContactId": 218
    },
    {
      "PersonId": 724,
      "ContactId": 218
    }
  ]
}
```