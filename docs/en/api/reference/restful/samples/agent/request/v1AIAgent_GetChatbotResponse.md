```http!
POST /api/v1/Agents/AI/GetChatbotResponse
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ChatId": "iusto",
  "IsoLangCode": "et",
  "UserPrompt": "quam",
  "DisplayValue": "porro",
  "PreviousTurns": [
    {
      "Timestamp": "2015-05-06T10:10:58.2880006+02:00",
      "UserPrompt": "aut",
      "UserDisplayText": "voluptatibus",
      "BotResponse": "numquam",
      "BotActions": {
        "BotActions1": "distinctio",
        "BotActions2": "dolore"
      },
      "Attachments": [
        "distinctio",
        "quisquam"
      ]
    },
    {
      "Timestamp": "2015-05-06T10:10:58.2880006+02:00",
      "UserPrompt": "aut",
      "UserDisplayText": "voluptatibus",
      "BotResponse": "numquam",
      "BotActions": {
        "BotActions1": "distinctio",
        "BotActions2": "dolore"
      },
      "Attachments": [
        "distinctio",
        "quisquam"
      ]
    }
  ],
  "ApiUrl": "http://www.example.com/"
}
```