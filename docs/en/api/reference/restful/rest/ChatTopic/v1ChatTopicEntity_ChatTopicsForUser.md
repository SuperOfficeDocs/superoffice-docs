---
title: GET ChatTopic/ForCurrentUser
uid: v1ChatTopicEntity_ChatTopicsForUser
---

# GET ChatTopic/ForCurrentUser

```http
GET /api/v1/ChatTopic/ForCurrentUser
```

Get all chat topics which this user is a member of.


Members means that you have at least one of: Can Respond, Notifications, Listen or Manager







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


## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatTopicId | int32 | The primary key (auto-incremented) |
| Name | string | The name of this chat topic |
| Description | string | The descriptiong for this topic. |
| WelcomeMessage | string | The welcome message sent to the customer when the chat session starts. |
| Language | CustomerLanguage | Customer language used in this topic. Optional. |
| LastAccept | date-time | The last time a session was accepted from the inside for this topic. |
| SecondsPrAccept | int32 | The average number of seconds per accept for this topic. |
| AlertRecipient | string | The recipient(s) for the alert template |
| AlertTemplate | ReplyTemplate | Template to use for alerts. |
| CollectConsent | bool | Collect consent to store from user |
| BadgeHeader | string | The badge header of the chat topic |
| CustomQueueTextEnabled | bool | Use the custom queue message text |
| CustomQueueText | string | A text to be used in the queue message in the chat widget. Usage is controlled by the flags field, bit number 3 |
| WarnNewChatMinutes | int32 | Contains the user notify time in minutes |
| WarnManagerNewChatMinutes | int32 | Contains the manager notify time in minutes |
| TicketEnabled | bool | Enable ticket submission in offline mode |
| TicketCategory | TicketCategory | Category on ticket created from off-line request |
| TicketPriority | TicketPriority | Priority on ticket created from off-line request |
| OpeningHoursEnabled | bool | Whether to use opening hours or not. |
| OpeningHours | ChatOpeningHours | Opening hours settings |
| Widget | ChatWidgetSettings | Settings for the chat widget |
| BotEnabled | bool | Enable chatbot on this topic. Run the trigger scripts on bot events. |
| BotSettings | ChatBotSettings | Settings for chatbot: trigger script ids to run on bot events |
| OfflineCollectConsent | bool | Collect offline consent to store from user |
| WarnChatMessageMinutes | int32 | Contains the user notify time in minutes for new chat messages |
| WarnManagerChatMessageMinutes | int32 | Contains the manager notify time in minutes for new chat messages |
| UseQueueOfflineForm | bool | Use offline form capability from chat queue |
| OfflineFormTimeLimit | int32 | The number of minutes in the queue before the offline form is available |
| OfflineFormQueueLength | int32 | The number of customers in the queue before the offline form is available |
| WidgetEnableRating | bool | Enable rating functionality in the chat widgte |
| WidgetRatingText | string | The text to be displayed in the widget next to the rating stars |
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/ChatTopic/ForCurrentUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ChatTopicId": 41,
    "Name": "Klocko, Heaney and Corkery",
    "Description": "Team-oriented fault-tolerant database",
    "WelcomeMessage": "numquam",
    "Language": null,
    "LastAccept": "2012-01-28T17:37:38.3108627+01:00",
    "SecondsPrAccept": 948,
    "AlertRecipient": "voluptas",
    "AlertTemplate": null,
    "CollectConsent": false,
    "BadgeHeader": "illo",
    "CustomQueueTextEnabled": false,
    "CustomQueueText": "nihil",
    "WarnNewChatMinutes": 510,
    "WarnManagerNewChatMinutes": 490,
    "TicketEnabled": false,
    "TicketCategory": null,
    "TicketPriority": null,
    "OpeningHoursEnabled": true,
    "OpeningHours": null,
    "Widget": null,
    "BotEnabled": false,
    "BotSettings": null,
    "OfflineCollectConsent": false,
    "WarnChatMessageMinutes": 575,
    "WarnManagerChatMessageMinutes": 151,
    "UseQueueOfflineForm": true,
    "OfflineFormTimeLimit": 22,
    "OfflineFormQueueLength": 632,
    "WidgetEnableRating": false,
    "WidgetRatingText": "illo",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 203
      }
    }
  }
]
```