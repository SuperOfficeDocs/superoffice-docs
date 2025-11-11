```http!
POST /api/v1/Agents/Project/SetDuplicateRulesStatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Rules": [
    {
      "Name": "Heidenreich, Cassin and Wiegand",
      "DisplayName": "Sanford-Gaylord",
      "DisplayTooltip": "est",
      "IsActive": true
    },
    {
      "Name": "Heidenreich, Cassin and Wiegand",
      "DisplayName": "Sanford-Gaylord",
      "DisplayTooltip": "est",
      "IsActive": true
    }
  ]
}
```