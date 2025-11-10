```http!
POST /api/v1/Agents/Document/GetDocumentCommands
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 44,
  "AllowedReturnTypes": [
    "ab",
    "in"
  ]
}
```