---
title: POST Agents/AI/GetChatbotPromptSuggestions
uid: v1AIAgent_GetChatbotPromptSuggestions
generated: true
---

# POST Agents/AI/GetChatbotPromptSuggestions

```http
POST /api/v1/Agents/AI/GetChatbotPromptSuggestions
```

Return one or more suggested prompts as actions to display in an empty chat window







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/AI/GetChatbotPromptSuggestions?$select=name,department,category/id
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

IsoLangCode, SoProtocol, CurrentContactId, CurrentPersonId, CurrentProjectId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| IsoLangCode | String |  |
| SoProtocol | String |  |
| CurrentContactId | Integer |  |
| CurrentPersonId | Integer |  |
| CurrentProjectId | Integer |  |

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
POST /api/v1/Agents/AI/GetChatbotPromptSuggestions
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "IsoLangCode": "quis",
  "SoProtocol": "voluptatem",
  "CurrentContactId": 157,
  "CurrentPersonId": 92,
  "CurrentProjectId": 882
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Timestamp": "2007-05-13T13:38:12.8271613+02:00",
  "UserPrompt": "aliquam",
  "UserDisplayText": "laboriosam",
  "BotResponse": "quos",
  "BotActions": {
    "BotActions1": "inventore",
    "BotActions2": "et"
  },
  "Attachments": [
    "unde",
    "quidem"
  ]
}
```