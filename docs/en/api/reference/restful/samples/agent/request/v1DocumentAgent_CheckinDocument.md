```http!
POST /api/v1/Agents/Document/CheckinDocument
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 910,
  "AllowedReturnTypes": [
    "optio",
    "error"
  ],
  "VersionDescription": "Down-sized mission-critical groupware",
  "VersionExtraFields": [
    "ex",
    "hic"
  ]
}
```