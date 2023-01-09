---
title: POST Agents/Chat/SaveChatTopicEntity
uid: v1ChatAgent_SaveChatTopicEntity
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Chat/SaveChatTopicEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 618,
  "Name": "Schulist, Blanda and Hettinger",
  "Description": "Extended stable access",
  "WelcomeMessage": "illum",
  "Language": null,
  "LastAccept": "2010-09-25T17:37:16.976242+02:00",
  "SecondsPrAccept": 815,
  "AlertRecipient": "aut",
  "AlertTemplate": null,
  "CollectConsent": true,
  "BadgeHeader": "consequatur",
  "CustomQueueTextEnabled": false,
  "CustomQueueText": "sequi",
  "WarnNewChatMinutes": 615,
  "WarnManagerNewChatMinutes": 591,
  "TicketEnabled": false,
  "TicketCategory": null,
  "TicketPriority": null,
  "OpeningHoursEnabled": true,
  "OpeningHours": null,
  "Widget": null,
  "BotEnabled": false,
  "BotSettings": null,
  "OfflineCollectConsent": false,
  "WarnChatMessageMinutes": 823,
  "WarnManagerChatMessageMinutes": 126,
  "UseQueueOfflineForm": false,
  "OfflineFormTimeLimit": 373,
  "OfflineFormQueueLength": 243,
  "WidgetEnableRating": false,
  "WidgetRatingText": "rerum"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 104,
  "Name": "Hilll, Renner and Rath",
  "Description": "Extended dedicated hardware",
  "WelcomeMessage": "eos",
  "Language": null,
  "LastAccept": "2021-11-12T17:37:16.9792408+01:00",
  "SecondsPrAccept": 683,
  "AlertRecipient": "rerum",
  "AlertTemplate": null,
  "CollectConsent": true,
  "BadgeHeader": "repudiandae",
  "CustomQueueTextEnabled": true,
  "CustomQueueText": "nobis",
  "WarnNewChatMinutes": 512,
  "WarnManagerNewChatMinutes": 491,
  "TicketEnabled": false,
  "TicketCategory": null,
  "TicketPriority": null,
  "OpeningHoursEnabled": false,
  "OpeningHours": null,
  "Widget": null,
  "BotEnabled": false,
  "BotSettings": null,
  "OfflineCollectConsent": true,
  "WarnChatMessageMinutes": 658,
  "WarnManagerChatMessageMinutes": 871,
  "UseQueueOfflineForm": true,
  "OfflineFormTimeLimit": 816,
  "OfflineFormQueueLength": 157,
  "WidgetEnableRating": false,
  "WidgetRatingText": "aut",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 932
    }
  }
}
```