---
title: POST Agents/Chat/SaveChatSessionEntity
uid: v1ChatAgent_SaveChatSessionEntity
generated: true
---

# POST Agents/Chat/SaveChatSessionEntity

```http
POST /api/v1/Agents/Chat/SaveChatSessionEntity
```

Updates the existing ChatSessionEntity or creates a new ChatSessionEntity if the id parameter is empty








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

## Request Body: entity 

The ChatSessionEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatSessionId | Integer | The primary key (auto-incremented) |
| TopicId | Integer | The reference to the associated chat topic. |
| User | Associate | User agent handling this session |
| Person | Person | Customer person in this session - could be empty if we don't know exactly. |
| CustomerAlias | String | The alias for the customer. |
| CustomerHost | String | The hostname or IP address for the customer. |
| CustomerName | String | The name of customer, if provided |
| CustomerEmail | String | The email address of the customer, if provided |
| CustomerPhone | String | The phone number of the customer, if provided |
| CustomerConsented | Boolean | The customer consented when starting the session |
| CustomerCompanyName | String | The name of the customers company, if provided |
| Status | String | Enum indicating the status for the session (pending, active, closed, etc). |
| FirstMessage | String | A copy of the first message in the chat session |
| LastMessage | String | A copy of the last message in the chat session |
| WhenRequested | String | When the session was requested by the customer. |
| WhenStarted | String | When the session was accepted by a user. |
| WhenEnded | String | When the session was ended. |
| WhenIdle | String | The last time anyone sent a message for this session. |
| WhenFetched | String | The last time the customer&amp;apos;s client refetched the data. Used to detect &amp;apos;dead&amp;apos; session. |
| SessionKey | String | Key used to authenticate the session. |
| InitialQueuePos | Integer | The initial queue pos (i.e. the number of pending sessions + 1) when the session was requested. |
| AlertLevel | Integer | The alert level for this chat session. |
| Rank | Integer | Lowest possible unique number for active sessions for user. User for color index. Starting at 1. |
| Flags | String | Various flags for the chat session |
| Contact | Contact | Contact this session is connected to - could be empty if we don't know exactly. |
| Project | Project | Project the session is connectedto - could be empty if we don't know exactly. |
| Sale | Sale | Sale the session is connected to - could be empty if we don't know exactly. |
| Ticket | Ticket | Ticket the session is connected to - could be empty if we don't know exactly. |
| TransferTo | Associate | User agent that has a pending transfer of the chat session |
| ChatbotIsActive | Boolean | Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user. |
| Rating | Integer | Rating of this chat conversation given by the customer |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ChatSessionEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatSessionId | int32 | The primary key (auto-incremented) |
| TopicId | int32 | The reference to the associated chat topic. |
| User | Associate | User agent handling this session |
| Person | Person | Customer person in this session - could be empty if we don't know exactly. |
| CustomerAlias | string | The alias for the customer. |
| CustomerHost | string | The hostname or IP address for the customer. |
| CustomerName | string | The name of customer, if provided |
| CustomerEmail | string | The email address of the customer, if provided |
| CustomerPhone | string | The phone number of the customer, if provided |
| CustomerConsented | bool | The customer consented when starting the session |
| CustomerCompanyName | string | The name of the customers company, if provided |
| Status | string | Enum indicating the status for the session (pending, active, closed, etc). |
| FirstMessage | string | A copy of the first message in the chat session |
| LastMessage | string | A copy of the last message in the chat session |
| WhenRequested | date-time | When the session was requested by the customer. |
| WhenStarted | date-time | When the session was accepted by a user. |
| WhenEnded | date-time | When the session was ended. |
| WhenIdle | date-time | The last time anyone sent a message for this session. |
| WhenFetched | date-time | The last time the customer&amp;apos;s client refetched the data. Used to detect &amp;apos;dead&amp;apos; session. |
| SessionKey | string | Key used to authenticate the session. |
| InitialQueuePos | int32 | The initial queue pos (i.e. the number of pending sessions + 1) when the session was requested. |
| AlertLevel | int32 | The alert level for this chat session. |
| Rank | int32 | Lowest possible unique number for active sessions for user. User for color index. Starting at 1. |
| Flags | string | Various flags for the chat session |
| Contact | Contact | Contact this session is connected to - could be empty if we don't know exactly. |
| Project | Project | Project the session is connectedto - could be empty if we don't know exactly. |
| Sale | Sale | Sale the session is connected to - could be empty if we don't know exactly. |
| Ticket | Ticket | Ticket the session is connected to - could be empty if we don't know exactly. |
| TransferTo | Associate | User agent that has a pending transfer of the chat session |
| ChatbotIsActive | bool | Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user. |
| Rating | int32 | Rating of this chat conversation given by the customer |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Chat/SaveChatSessionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 415,
  "TopicId": 399,
  "User": null,
  "Person": null,
  "CustomerAlias": "eius",
  "CustomerHost": "sunt",
  "CustomerName": "Hermiston, Cruickshank and Effertz",
  "CustomerEmail": "ramon@wolf.name",
  "CustomerPhone": "667-358-9383 x733",
  "CustomerConsented": false,
  "CustomerCompanyName": "O'Kon-Schultz",
  "Status": "Closed",
  "FirstMessage": "dolor",
  "LastMessage": "maiores",
  "WhenRequested": "2003-03-01T12:01:27.3690022+01:00",
  "WhenStarted": "2004-10-25T12:01:27.3690022+02:00",
  "WhenEnded": "2011-09-25T12:01:27.3690022+02:00",
  "WhenIdle": "2022-04-24T12:01:27.3690022+02:00",
  "WhenFetched": "2001-05-16T12:01:27.3690022+02:00",
  "SessionKey": "assumenda",
  "InitialQueuePos": 661,
  "AlertLevel": 489,
  "Rank": 383,
  "Flags": "CustomerIsTyping",
  "Contact": null,
  "Project": null,
  "Sale": null,
  "Ticket": null,
  "TransferTo": null,
  "ChatbotIsActive": false,
  "Rating": 139
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 942,
  "TopicId": 500,
  "User": null,
  "Person": null,
  "CustomerAlias": "inventore",
  "CustomerHost": "delectus",
  "CustomerName": "Crona, Wehner and Kautzer",
  "CustomerEmail": "quinn.auer@bartoletti.com",
  "CustomerPhone": "(000)279-0521 x87146",
  "CustomerConsented": true,
  "CustomerCompanyName": "Hauck-Beatty",
  "Status": "Closed",
  "FirstMessage": "voluptates",
  "LastMessage": "aut",
  "WhenRequested": "1999-08-03T12:01:27.3846286+02:00",
  "WhenStarted": "2017-03-19T12:01:27.3846286+01:00",
  "WhenEnded": "2009-04-19T12:01:27.3846286+02:00",
  "WhenIdle": "2001-02-18T12:01:27.3846286+01:00",
  "WhenFetched": "2005-04-10T12:01:27.3846286+02:00",
  "SessionKey": "aliquid",
  "InitialQueuePos": 26,
  "AlertLevel": 995,
  "Rank": 635,
  "Flags": "CustomerIsTyping",
  "Contact": null,
  "Project": null,
  "Sale": null,
  "Ticket": null,
  "TransferTo": null,
  "ChatbotIsActive": true,
  "Rating": 119,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 128
    }
  }
}
```