```http!
POST /api/v1/Agents/Contact/SetDuplicateRulesStatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Rules": [
    {
      "Name": "Goodwin, Fritsch and Kovacek",
      "DisplayName": "Kassulke, Hayes and Romaguera",
      "DisplayTooltip": "qui",
      "IsActive": false
    },
    {
      "Name": "Goodwin, Fritsch and Kovacek",
      "DisplayName": "Kassulke, Hayes and Romaguera",
      "DisplayTooltip": "qui",
      "IsActive": false
    }
  ]
}
```