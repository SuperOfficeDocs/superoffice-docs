---
title: POST Agents/AI/GetSummarizeContactPrompt
uid: v1AIAgent_GetSummarizeContactPrompt
generated: true
---

# POST Agents/AI/GetSummarizeContactPrompt

```http
POST /api/v1/Agents/AI/GetSummarizeContactPrompt
```

Return the prompt used to get a short summary of the activities on a contact.


Does not call the chatbot for a response. Used for transfering a summary to a chat session.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/AI/GetSummarizeContactPrompt?$select=name,department,category/id
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

ContactId, NumSentences, Summary, IsoLangCode 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |
| NumSentences | Integer |  |
| Summary | String |  |
| IsoLangCode | String |  |

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
POST /api/v1/Agents/AI/GetSummarizeContactPrompt
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 564,
  "NumSentences": 751,
  "Summary": "alias",
  "IsoLangCode": "mollitia"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Timestamp": "2018-11-26T13:38:12.8271613+01:00",
  "UserPrompt": "in",
  "UserDisplayText": "corporis",
  "BotResponse": "rerum",
  "BotActions": {
    "BotActions1": "vero",
    "BotActions2": "inventore"
  },
  "Attachments": [
    "dolores",
    "vero"
  ]
}
```