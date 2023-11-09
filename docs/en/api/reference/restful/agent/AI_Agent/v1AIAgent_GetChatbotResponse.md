---
title: POST Agents/AI/GetChatbotResponse
uid: v1AIAgent_GetChatbotResponse
generated: true
---

# POST Agents/AI/GetChatbotResponse

```http
POST /api/v1/Agents/AI/GetChatbotResponse
```

Return a chatbot response given prompt and previous turns







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

IsoLangCode, UserPrompt, DisplayValue, PreviousTurns 

| Property Name | Type |  Description |
|----------------|------|--------------|
| IsoLangCode | String |  |
| UserPrompt | String |  |
| DisplayValue | String |  |
| PreviousTurns | Array |  |

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "IsoLangCode": "rem",
  "UserPrompt": "sed",
  "DisplayValue": "et",
  "PreviousTurns": [
    {
      "Timestamp": "2013-07-15T11:06:33.4132283+02:00",
      "UserPrompt": "consectetur",
      "UserDisplayText": "ut",
      "BotResponse": "consequatur",
      "BotActions": {
        "BotActions1": "ab",
        "BotActions2": "et"
      },
      "Attachments": [
        "praesentium",
        "quibusdam"
      ]
    },
    {
      "Timestamp": "2013-07-15T11:06:33.4132283+02:00",
      "UserPrompt": "consectetur",
      "UserDisplayText": "ut",
      "BotResponse": "consequatur",
      "BotActions": {
        "BotActions1": "ab",
        "BotActions2": "et"
      },
      "Attachments": [
        "praesentium",
        "quibusdam"
      ]
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Timestamp": "2001-10-23T11:06:33.4132283+02:00",
  "UserPrompt": "assumenda",
  "UserDisplayText": "et",
  "BotResponse": "consequatur",
  "BotActions": {
    "BotActions1": "nihil",
    "BotActions2": "culpa"
  },
  "Attachments": [
    "consectetur",
    "id"
  ]
}
```