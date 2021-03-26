---
title: POST ChatSession/{id}/Transcript
id: v1ChatSessionEntity_GetChatTranscript
---

# POST ChatSession/{id}/Transcript

```http
POST /api/v1/ChatSession/{chatSessionId}/Transcript
```

Get the chat transcript, formatted as plain text or html






| Path Part | Type | Description |
|-----------|------|-------------|
| chatSessionId | int32 | id of the chat session to get the transcript for **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| html | bool |  Get transcript as HTML |

```http
POST /api/v1/ChatSession/{chatSessionId}/Transcript?html=True
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: string



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: string


## Sample Request

```http!
POST /api/v1/ChatSession/{chatSessionId}/Transcript
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

"at"
```