```http!
POST /api/v1/Agents/Quote/SaveQuoteLineConfigurations
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "QuoteLineConfigurations": [
    {
      "QuoteLineConfigurationId": 23,
      "FieldName": "Mosciski, Cremin and Ondricka",
      "Label": "esse",
      "Tooltip": "quaerat",
      "Editable": false,
      "InUse": false,
      "Mandatory": false,
      "Rank": 503,
      "RestrictEdit": false
    }
  ]
}
```