---
title: POST ChatSession
uid: v1ChatSessionEntity_PostChatSessionEntity
generated: true
---

# POST ChatSession

```http
POST /api/v1/ChatSession
```

Creates a new ChatSessionEntity


Calls the Chat agent service SaveChatSessionEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/ChatSession?$select=name,department,category/id
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

## Request Body: newEntity 

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

### Response body: ChatSessionEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
POST /api/v1/ChatSession
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 758,
  "TopicId": 182,
  "User": null,
  "Person": null,
  "CustomerAlias": "et",
  "CustomerHost": "dolores",
  "CustomerName": "Hauck Inc and Sons",
  "CustomerEmail": "sylvester@hilpertkunze.info",
  "CustomerPhone": "873-482-1178 x3252",
  "CustomerConsented": true,
  "CustomerCompanyName": "O'Conner, Ratke and Hammes",
  "Status": "Closed",
  "FirstMessage": "nisi",
  "LastMessage": "cum",
  "WhenRequested": "2023-07-14T11:06:41.4259883+02:00",
  "WhenStarted": "2008-10-10T11:06:41.4259883+02:00",
  "WhenEnded": "2011-12-25T11:06:41.4259883+01:00",
  "WhenIdle": "2023-06-24T11:06:41.4259883+02:00",
  "WhenFetched": "2013-04-18T11:06:41.4259883+02:00",
  "SessionKey": "iure",
  "InitialQueuePos": 95,
  "AlertLevel": 551,
  "Rank": 662,
  "Flags": "CustomerIsTyping",
  "Contact": null,
  "Project": null,
  "Sale": null,
  "Ticket": null,
  "TransferTo": null,
  "ChatbotIsActive": false,
  "Rating": 724
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 424,
  "TopicId": 955,
  "User": null,
  "Person": null,
  "CustomerAlias": "qui",
  "CustomerHost": "et",
  "CustomerName": "Cremin-O'Reilly",
  "CustomerEmail": "carlie@wiegand.ca",
  "CustomerPhone": "493.180.7802",
  "CustomerConsented": true,
  "CustomerCompanyName": "Parisian Group",
  "Status": "Closed",
  "FirstMessage": "laudantium",
  "LastMessage": "sint",
  "WhenRequested": "2019-01-16T11:06:41.4416171+01:00",
  "WhenStarted": "2007-07-20T11:06:41.4416171+02:00",
  "WhenEnded": "2022-07-06T11:06:41.4416171+02:00",
  "WhenIdle": "2023-01-04T11:06:41.4416171+01:00",
  "WhenFetched": "1997-05-02T11:06:41.4416171+02:00",
  "SessionKey": "ut",
  "InitialQueuePos": 466,
  "AlertLevel": 305,
  "Rank": 975,
  "Flags": "CustomerIsTyping",
  "Contact": null,
  "Project": null,
  "Sale": null,
  "Ticket": null,
  "TransferTo": null,
  "ChatbotIsActive": true,
  "Rating": 598,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 908
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```