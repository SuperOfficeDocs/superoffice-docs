```http!
POST /api/v1/Agents/EMail/MoveEmailsToFolder
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "FolderId": 753,
  "EmailItemIds": [
    676,
    573
  ]
}
```