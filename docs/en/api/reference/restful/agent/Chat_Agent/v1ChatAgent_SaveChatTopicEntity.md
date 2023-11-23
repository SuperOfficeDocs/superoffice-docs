---
title: POST Agents/Chat/SaveChatTopicEntity
uid: v1ChatAgent_SaveChatTopicEntity
generated: true
---

# POST Agents/Chat/SaveChatTopicEntity

```http
POST /api/v1/Agents/Chat/SaveChatTopicEntity
```

Updates the existing ChatTopicEntity or creates a new ChatTopicEntity if the id parameter is empty








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

The ChatTopicEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatTopicId | Integer | The primary key (auto-incremented) |
| Name | String | The name of this chat topic |
| Description | String | The descriptiong for this topic. |
| WelcomeMessage | String | The welcome message sent to the customer when the chat session starts. |
| Language | CustomerLanguage | Customer language used in this topic. Optional. |
| LastAccept | String | The last time a session was accepted from the inside for this topic. |
| SecondsPrAccept | Integer | The average number of seconds per accept for this topic. |
| AlertRecipient | String | The recipient(s) for the alert template |
| AlertTemplate | ReplyTemplate | Template to use for alerts. |
| CollectConsent | Boolean | Collect consent to store from user |
| BadgeHeader | String | The badge header of the chat topic |
| CustomQueueTextEnabled | Boolean | Use the custom queue message text |
| CustomQueueText | String | A text to be used in the queue message in the chat widget. Usage is controlled by the flags field, bit number 3 |
| WarnNewChatMinutes | Integer | Contains the user notify time in minutes |
| WarnManagerNewChatMinutes | Integer | Contains the manager notify time in minutes |
| TicketEnabled | Boolean | Enable ticket submission in offline mode |
| TicketCategory | TicketCategory | Category on ticket created from off-line request |
| TicketPriority | TicketPriority | Priority on ticket created from off-line request |
| OpeningHoursEnabled | Boolean | Whether to use opening hours or not. |
| OpeningHours | ChatOpeningHours | Opening hours settings |
| Widget | ChatWidgetSettings | Settings for the chat widget |
| BotEnabled | Boolean | Enable chatbot on this topic. Run the trigger scripts on bot events. |
| BotSettings | ChatBotSettings | Settings for chatbot: trigger script ids to run on bot events |
| OfflineCollectConsent | Boolean | Collect offline consent to store from user |
| WarnChatMessageMinutes | Integer | Contains the user notify time in minutes for new chat messages |
| WarnManagerChatMessageMinutes | Integer | Contains the manager notify time in minutes for new chat messages |
| UseQueueOfflineForm | Boolean | Use offline form capability from chat queue |
| OfflineFormTimeLimit | Integer | The number of minutes in the queue before the offline form is available |
| OfflineFormQueueLength | Integer | The number of customers in the queue before the offline form is available |
| WidgetEnableRating | Boolean | Enable rating functionality in the chat widgte |
| WidgetRatingText | String | The text to be displayed in the widget next to the rating stars |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ChatTopicEntity

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Chat/SaveChatTopicEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 754,
  "Name": "Pfeffer-Zulauf",
  "Description": "Pre-emptive foreground complexity",
  "WelcomeMessage": "cumque",
  "Language": null,
  "LastAccept": "2019-04-15T13:38:13.1240408+02:00",
  "SecondsPrAccept": 621,
  "AlertRecipient": "fuga",
  "AlertTemplate": null,
  "CollectConsent": true,
  "BadgeHeader": "sint",
  "CustomQueueTextEnabled": true,
  "CustomQueueText": "non",
  "WarnNewChatMinutes": 62,
  "WarnManagerNewChatMinutes": 180,
  "TicketEnabled": false,
  "TicketCategory": null,
  "TicketPriority": null,
  "OpeningHoursEnabled": false,
  "OpeningHours": null,
  "Widget": null,
  "BotEnabled": true,
  "BotSettings": null,
  "OfflineCollectConsent": true,
  "WarnChatMessageMinutes": 68,
  "WarnManagerChatMessageMinutes": 750,
  "UseQueueOfflineForm": false,
  "OfflineFormTimeLimit": 841,
  "OfflineFormQueueLength": 98,
  "WidgetEnableRating": false,
  "WidgetRatingText": "nihil"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 742,
  "Name": "Nolan, Stracke and Sanford",
  "Description": "Stand-alone actuating definition",
  "WelcomeMessage": "voluptates",
  "Language": null,
  "LastAccept": "2015-08-12T13:38:13.1240408+02:00",
  "SecondsPrAccept": 567,
  "AlertRecipient": "voluptatum",
  "AlertTemplate": null,
  "CollectConsent": false,
  "BadgeHeader": "aliquam",
  "CustomQueueTextEnabled": false,
  "CustomQueueText": "ad",
  "WarnNewChatMinutes": 969,
  "WarnManagerNewChatMinutes": 54,
  "TicketEnabled": false,
  "TicketCategory": null,
  "TicketPriority": null,
  "OpeningHoursEnabled": false,
  "OpeningHours": null,
  "Widget": null,
  "BotEnabled": true,
  "BotSettings": null,
  "OfflineCollectConsent": false,
  "WarnChatMessageMinutes": 547,
  "WarnManagerChatMessageMinutes": 657,
  "UseQueueOfflineForm": true,
  "OfflineFormTimeLimit": 487,
  "OfflineFormQueueLength": 7,
  "WidgetEnableRating": false,
  "WidgetRatingText": "esse",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 860
    }
  }
}
```