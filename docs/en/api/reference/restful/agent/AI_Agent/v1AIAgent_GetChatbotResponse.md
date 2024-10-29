---
title: POST Agents/AI/GetChatbotResponse
uid: v1AIAgent_GetChatbotResponse
generated: true
---

# POST Agents/AI/GetChatbotResponse

```http
POST /api/v1/Agents/AI/GetChatbotResponse
```

Return a chatbot response given prompt and previous turns.


Stores the new turn in the history for the chatId






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/AI/GetChatbotResponse?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

ChatId, IsoLangCode, UserPrompt, DisplayValue, PreviousTurns, ApiUrl 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatId | String |  |
| IsoLangCode | String |  |
| UserPrompt | String |  |
| DisplayValue | String |  |
| PreviousTurns | Array |  |
| ApiUrl | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ChatbotTurn

| Property Name | Type |  Description |
|----------------|------|--------------|
| Timestamp | date-time | UTC timestamp for turn - when response was generated |
| UserPrompt | string | Text from the user |
| UserDisplayText | string | Optional display value to use instead of the the UserPrompt |
| BotResponse | string | Text from the chatbot |
| BotActions | object | optional dictionary of action buttons. Key = Display text, Value = Prompt text |
| Attachments | array | optional array of attachments - can be URL or Base64 encoded data |

## Sample request

```http!
POST /api/v1/Agents/AI/GetChatbotResponse
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ChatId": "mollitia",
  "IsoLangCode": "autem",
  "UserPrompt": "et",
  "DisplayValue": "adipisci",
  "PreviousTurns": [
    {
      "Timestamp": "2004-06-20T13:14:05.1944888+02:00",
      "UserPrompt": "consequuntur",
      "UserDisplayText": "enim",
      "BotResponse": "voluptatibus",
      "BotActions": {
        "BotActions1": "ullam",
        "BotActions2": "amet"
      },
      "Attachments": [
        "explicabo",
        "fugit"
      ]
    },
    {
      "Timestamp": "2004-06-20T13:14:05.1944888+02:00",
      "UserPrompt": "consequuntur",
      "UserDisplayText": "enim",
      "BotResponse": "voluptatibus",
      "BotActions": {
        "BotActions1": "ullam",
        "BotActions2": "amet"
      },
      "Attachments": [
        "explicabo",
        "fugit"
      ]
    }
  ],
  "ApiUrl": "http://www.example.com/"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Timestamp": "2006-03-30T13:14:05.1944888+02:00",
  "UserPrompt": "deserunt",
  "UserDisplayText": "et",
  "BotResponse": "et",
  "BotActions": {
    "BotActions1": "dolores",
    "BotActions2": "blanditiis"
  },
  "Attachments": [
    "sit",
    "sunt"
  ]
}
```