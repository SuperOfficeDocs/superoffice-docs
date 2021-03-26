---
title: GET ChatSession/{id}/Messages
id: v1ChatSessionEntity_GetChatMessages
---

# GET ChatSession/{id}/Messages

```http
GET /api/v1/ChatSession/{chatSessionId}/Messages
```

Get all or some of the messages in a chat session






| Path Part | Type | Description |
|-----------|------|-------------|
| chatSessionId | int32 | id of the chat session to reset **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| after | int32 |  Return messages after this message id |

```http
GET /api/v1/ChatSession/{chatSessionId}/Messages?after=823
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


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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

## Sample Request

```http!
GET /api/v1/ChatSession/{chatSessionId}/Messages
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ChatMessageId": 41,
    "ChatSessionId": 512,
    "Type": "Invalid",
    "Message": "ut",
    "Author": "vel",
    "ReadByCustomer": 181,
    "SpecialType": "Block",
    "SpecialParam": "nobis",
    "WhenPosted": "2006-03-18T09:40:58.8293433+01:00"
  }
]
```