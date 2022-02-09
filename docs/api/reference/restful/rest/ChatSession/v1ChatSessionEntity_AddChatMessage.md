---
title: POST ChatSession/{id}/Messages
id: v1ChatSessionEntity_AddChatMessage
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
| ChatMessageId | int32 | The primary key (auto-incremented) |
| ChatSessionId | int32 | The reference to the associated chat session. |
| Type | string | The type of the message. |
| Message | string | The message. |
| Author | string | The author of the message. |
| ReadByCustomer | int32 | Whether the message has been read by the customer or not. |
| SpecialType | string | Enum indicating if it is a special message, such as an URL redirection, etc. |
| SpecialParam | string | Special parameter for the special_type. |
| WhenPosted | date-time | When the message was posted (UTC timestamp). |


## Response: object

A message in a chat session



Carrier object for ChatMessage.
Services for the ChatMessage Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IChatAgent">Chat Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
POST /api/v1/ChatSession/{chatSessionId}/Messages
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ChatMessageId": 508,
  "ChatSessionId": 543,
  "Type": "Invalid",
  "Message": "deleniti",
  "Author": "rem",
  "ReadByCustomer": 677,
  "SpecialType": "Block",
  "SpecialParam": "aut",
  "WhenPosted": "2017-08-13T18:25:50.1555956+02:00"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatMessageId": 658,
  "ChatSessionId": 11,
  "Type": "Invalid",
  "Message": "velit",
  "Author": "ea",
  "ReadByCustomer": 294,
  "SpecialType": "Block",
  "SpecialParam": "repellendus",
  "WhenPosted": "2017-11-09T18:25:50.1565945+01:00"
}
```