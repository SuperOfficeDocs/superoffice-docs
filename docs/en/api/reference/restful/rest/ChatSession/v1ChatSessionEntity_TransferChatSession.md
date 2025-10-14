---
title: POST ChatSession/{id}/TransferTo/{toAssociate}
uid: v1ChatSessionEntity_TransferChatSession
generated: true
content_type: reference
---

# POST ChatSession/{id}/TransferTo/{toAssociate}

```http
POST /api/v1/ChatSession/{chatSessionId}/TransferTo/{toAssociate}
```

Request to send the session to another user.


If the session does not belong to the user, nothing happens.





| Path Part | Type | Description |
|-----------|------|-------------|
| chatSessionId | int32 | id of the chat session to send **Required** |
| toAssociate | string | Associate username or associate id to send session to. **Required** |



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
POST /api/v1/ChatSession/{chatSessionId}/TransferTo/{toAssociate}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 614,
  "TopicId": 588,
  "User": null,
  "Person": null,
  "CustomerAlias": "et",
  "CustomerHost": "voluptate",
  "CustomerName": "Ortiz LLC",
  "CustomerEmail": "collin_williamson@ullrichkub.co.uk",
  "CustomerPhone": "1-495-156-0932 x498",
  "CustomerConsented": false,
  "CustomerCompanyName": "Harber, Rogahn and Erdman",
  "Status": "Closed",
  "FirstMessage": "soluta",
  "LastMessage": "quidem",
  "WhenRequested": "2012-02-14T03:40:55.3505585+01:00",
  "WhenStarted": "2016-01-04T03:40:55.3505585+01:00",
  "WhenEnded": "2017-03-21T03:40:55.3505585+01:00",
  "WhenIdle": "2018-03-15T03:40:55.3505585+01:00",
  "WhenFetched": "2015-03-02T03:40:55.3505585+01:00",
  "SessionKey": "molestias",
  "InitialQueuePos": 638,
  "AlertLevel": 120,
  "Rank": 499,
  "Flags": "CustomerIsTyping",
  "Contact": null,
  "Project": null,
  "Sale": null,
  "Ticket": null,
  "TransferTo": null,
  "ChatbotIsActive": true,
  "Rating": 59,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 291
    }
  }
}
```