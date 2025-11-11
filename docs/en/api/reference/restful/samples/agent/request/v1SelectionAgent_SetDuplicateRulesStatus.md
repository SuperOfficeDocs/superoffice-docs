```http!
POST /api/v1/Agents/Selection/SetDuplicateRulesStatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Rules": [
    {
      "Name": "Schimmel, Wisoky and Beier",
      "DisplayName": "Turner LLC",
      "DisplayTooltip": "ut",
      "IsActive": true
    },
    {
      "Name": "Schimmel, Wisoky and Beier",
      "DisplayName": "Turner LLC",
      "DisplayTooltip": "ut",
      "IsActive": true
    }
  ]
}
```