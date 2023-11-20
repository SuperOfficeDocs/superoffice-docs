---
title: POST ChatSession/{id}/Messages
uid: v1ChatSessionEntity_AddChatMessage
generated: true
---

# POST ChatSession/{id}/Messages

```http
POST /api/v1/ChatSession/{chatSessionId}/Messages
```

Add a new message to a chat session






| Path Part | Type | Description |
|-----------|------|-------------|
| chatSessionId | int32 | id of the chat session to add message to **Required** |



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

## Request Body: message 

Message to add 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatMessageId | Integer | The primary key (auto-incremented) |
| ChatSessionId | Integer | The reference to the associated chat session. |
| Type | String | The type of the message. |
| Message | String | The message. |
| Author | String | The author of the message. |
| ReadByCustomer | Integer | Whether the message has been read by the customer or not. |
| SpecialType | String | Enum indicating if it is a special message, such as an URL redirection, etc. |
| SpecialParam | String | Special parameter for the special_type. |
| WhenPosted | String | When the message was posted (UTC timestamp). |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ChatMessage

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatMessageId | int32 | The primary key (auto-incremented) |
| ChatSessionId | int32 | The reference to the associated chat session. |
| Type | string | The type of the message. |
| Message | string | The message. |
| Author | string | The author of the message. |
| ReadByCustomer | int32 | Whether the message has been read by the customer or not. |
| SpecialType | string | Enum indicating if it is a special message, such as an URL redirection, etc. |
| SpecialParam | string | Special parameter for the special_type. |
| WhenPosted | date-time | When the message was posted (UTC timestamp). |

## Sample request

```http!
POST /api/v1/ChatSession/{chatSessionId}/Messages
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ChatMessageId": 989,
  "ChatSessionId": 532,
  "Type": "Invalid",
  "Message": "occaecati",
  "Author": "sed",
  "ReadByCustomer": 158,
  "SpecialType": "Block",
  "SpecialParam": "eos",
  "WhenPosted": "1997-11-02T13:38:17.1868579+01:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatMessageId": 754,
  "ChatSessionId": 572,
  "Type": "Invalid",
  "Message": "aspernatur",
  "Author": "officia",
  "ReadByCustomer": 522,
  "SpecialType": "Block",
  "SpecialParam": "omnis",
  "WhenPosted": "2018-02-10T13:38:17.1868579+01:00"
}
```