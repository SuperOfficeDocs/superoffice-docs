---
title: POST ChatTopic
id: v1ChatTopicEntity_PostChatTopicEntity
---

# POST ChatTopic

```http
POST /api/v1/ChatTopic
```

Creates a new ChatTopicEntity

Calls the Chat agent service SaveChatTopicEntity.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/ChatTopic?$select=name,department,category/id
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

The ChatTopicEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatTopicId | int32 | The primary key (auto-incremented) |
| Name | string | The name of this chat topic |
| Description | string | The descriptiong for this topic. |
| WelcomeMessage | string | The welcome message sent to the customer when the chat session starts. |
| Language |  | Customer language used in this topic. Optional. |
| LastAccept | date-time | The last time a session was accepted from the inside for this topic. |
| SecondsPrAccept | int32 | The average number of seconds per accept for this topic. |
| AlertRecipient | string | The recipient(s) for the alert template |
| AlertTemplate |  | Template to use for alerts. |
| CollectConsent | bool | Collect consent to store from user |
| BadgeHeader | string | The badge header of the chat topic |
| CustomQueueTextEnabled | bool | Use the custom queue message text |
| CustomQueueText | string | A text to be used in the queue message in the chat widget. Usage is controlled by the flags field, bit number 3 |
| WarnNewChatMinutes | int32 | Contains the user notify time in minutes |
| WarnManagerNewChatMinutes | int32 | Contains the manager notify time in minutes |
| TicketEnabled | bool | Enable ticket submission in offline mode |
| TicketCategory |  | Category on ticket created from off-line request |
| TicketPriority |  | Priority on ticket created from off-line request |
| OpeningHoursEnabled | bool | Whether to use opening hours or not. |
| OpeningHours |  | Opening hours settings |
| Widget |  | Settings for the chat widget |
| BotEnabled | bool | Enable chatbot on this topic. Run the trigger scripts on bot events. |
| BotSettings |  | Settings for chatbot: trigger script ids to run on bot events |
| OfflineCollectConsent | bool | Collect offline consent to store from user |
| WarnChatMessageMinutes | int32 | Contains the user notify time in minutes for new chat messages |
| WarnManagerChatMessageMinutes | int32 | Contains the manager notify time in minutes for new chat messages |
| UseQueueOfflineForm | bool | Use offline form capability from chat queue |
| OfflineFormTimeLimit | int32 | The number of minutes in the queue before the offline form is available |
| OfflineFormQueueLength | int32 | The number of customers in the queue before the offline form is available |


## Response: object

Chat topics define who is assigned, when the channel is open for business, and look of the chat widget.



ChatTopicEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatTopicId | int32 | The primary key (auto-incremented) |
| Name | string | The name of this chat topic |
| Description | string | The descriptiong for this topic. |
| WelcomeMessage | string | The welcome message sent to the customer when the chat session starts. |
| Language |  | Customer language used in this topic. Optional. |
| LastAccept | date-time | The last time a session was accepted from the inside for this topic. |
| SecondsPrAccept | int32 | The average number of seconds per accept for this topic. |
| AlertRecipient | string | The recipient(s) for the alert template |
| AlertTemplate |  | Template to use for alerts. |
| CollectConsent | bool | Collect consent to store from user |
| BadgeHeader | string | The badge header of the chat topic |
| CustomQueueTextEnabled | bool | Use the custom queue message text |
| CustomQueueText | string | A text to be used in the queue message in the chat widget. Usage is controlled by the flags field, bit number 3 |
| WarnNewChatMinutes | int32 | Contains the user notify time in minutes |
| WarnManagerNewChatMinutes | int32 | Contains the manager notify time in minutes |
| TicketEnabled | bool | Enable ticket submission in offline mode |
| TicketCategory |  | Category on ticket created from off-line request |
| TicketPriority |  | Priority on ticket created from off-line request |
| OpeningHoursEnabled | bool | Whether to use opening hours or not. |
| OpeningHours |  | Opening hours settings |
| Widget |  | Settings for the chat widget |
| BotEnabled | bool | Enable chatbot on this topic. Run the trigger scripts on bot events. |
| BotSettings |  | Settings for chatbot: trigger script ids to run on bot events |
| OfflineCollectConsent | bool | Collect offline consent to store from user |
| WarnChatMessageMinutes | int32 | Contains the user notify time in minutes for new chat messages |
| WarnManagerChatMessageMinutes | int32 | Contains the manager notify time in minutes for new chat messages |
| UseQueueOfflineForm | bool | Use offline form capability from chat queue |
| OfflineFormTimeLimit | int32 | The number of minutes in the queue before the offline form is available |
| OfflineFormQueueLength | int32 | The number of customers in the queue before the offline form is available |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/ChatTopic
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 137,
  "Name": "Lesch LLC",
  "Description": "Customizable incremental forecast",
  "WelcomeMessage": "et",
  "Language": {
    "Id": 615,
    "Value": "assumenda",
    "Tooltip": "iure"
  },
  "LastAccept": "2010-04-10T18:25:50.1596194+02:00",
  "SecondsPrAccept": 423,
  "AlertRecipient": "quas",
  "AlertTemplate": {
    "ReplyTemplateId": 174,
    "Name": "Jast, Bayer and Crist",
    "Description": "Advanced background archive",
    "FolderId": 612
  },
  "CollectConsent": true,
  "BadgeHeader": "odit",
  "CustomQueueTextEnabled": false,
  "CustomQueueText": "doloribus",
  "WarnNewChatMinutes": 611,
  "WarnManagerNewChatMinutes": 494,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 16,
    "Value": "sunt",
    "Tooltip": "sequi"
  },
  "TicketPriority": {
    "Id": 705,
    "Value": "totam",
    "Tooltip": "earum"
  },
  "OpeningHoursEnabled": false,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": true,
    "MonStart": "non",
    "MonStop": "culpa",
    "TueEnabled": false,
    "TueStart": "soluta",
    "TueStop": "et",
    "WedEnabled": false,
    "WedStart": "illo",
    "WedStop": "ut",
    "ThuEnabled": true,
    "ThuStart": "debitis",
    "ThuStop": "dolor",
    "FriEnabled": false,
    "FriStart": "quod",
    "FriStop": "ipsam",
    "SatEnabled": false,
    "SatStart": "qui",
    "SatStop": "dolor",
    "SunEnabled": false,
    "SunStart": "dolor",
    "SunStop": "non",
    "UseLunchHours": true,
    "LunchStart": "occaecati",
    "LunchStop": "voluptate"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": false,
    "PreFormMessage": "dolorum",
    "RequiredFields": "Company",
    "PostFormEnabled": false,
    "PostFormHeader": "nisi",
    "PostFormMessage": "ducimus",
    "PostTranscriptEnabled": false,
    "LanguageIsoCode": "et",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "ullam",
    "Font": "enim",
    "LogoEnabled": false,
    "LogoBlobId": 696,
    "LogoName": "Witting Inc and Sons",
    "ShowAgentPhoto": true,
    "WelcomeTitle": "et",
    "WelcomeMessage": "iure",
    "OfflineHeader": "illum",
    "OfflineMessage": "quisquam",
    "OfflineFields": "Company",
    "UseAgentFirstname": false
  },
  "BotEnabled": false,
  "BotSettings": {
    "BotName": "Cartwright-Volkman",
    "BotRegisterScriptId": 559,
    "BotSessionCreatedScriptId": 421,
    "BotSessionChangedScriptId": 575,
    "BotMessageReceivedScriptId": 478
  },
  "OfflineCollectConsent": true,
  "WarnChatMessageMinutes": 70,
  "WarnManagerChatMessageMinutes": 95,
  "UseQueueOfflineForm": false,
  "OfflineFormTimeLimit": 19,
  "OfflineFormQueueLength": 323
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 950,
  "Name": "Heller Group",
  "Description": "Secured secondary pricing structure",
  "WelcomeMessage": "dolor",
  "Language": {
    "Id": 606,
    "Value": "ut",
    "Tooltip": "doloremque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 609
      }
    }
  },
  "LastAccept": "2011-07-28T18:25:50.1616191+02:00",
  "SecondsPrAccept": 512,
  "AlertRecipient": "aperiam",
  "AlertTemplate": {
    "ReplyTemplateId": 475,
    "Name": "Ruecker Inc and Sons",
    "Description": "Monitored multi-state instruction set",
    "FolderId": 802
  },
  "CollectConsent": true,
  "BadgeHeader": "qui",
  "CustomQueueTextEnabled": false,
  "CustomQueueText": "id",
  "WarnNewChatMinutes": 185,
  "WarnManagerNewChatMinutes": 796,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 700,
    "Value": "itaque",
    "Tooltip": "iusto",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 269
      }
    }
  },
  "TicketPriority": {
    "Id": 911,
    "Value": "facere",
    "Tooltip": "expedita",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 722
      }
    }
  },
  "OpeningHoursEnabled": true,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": true,
    "MonStart": "quis",
    "MonStop": "sit",
    "TueEnabled": true,
    "TueStart": "recusandae",
    "TueStop": "exercitationem",
    "WedEnabled": true,
    "WedStart": "inventore",
    "WedStop": "perferendis",
    "ThuEnabled": false,
    "ThuStart": "voluptates",
    "ThuStop": "eaque",
    "FriEnabled": false,
    "FriStart": "et",
    "FriStop": "placeat",
    "SatEnabled": false,
    "SatStart": "enim",
    "SatStop": "et",
    "SunEnabled": true,
    "SunStart": "aut",
    "SunStop": "est",
    "UseLunchHours": true,
    "LunchStart": "sed",
    "LunchStop": "cupiditate"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": false,
    "PreFormMessage": "dolores",
    "RequiredFields": "Company",
    "PostFormEnabled": true,
    "PostFormHeader": "sapiente",
    "PostFormMessage": "reiciendis",
    "PostTranscriptEnabled": true,
    "LanguageIsoCode": "dolor",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "quidem",
    "Font": "nisi",
    "LogoEnabled": true,
    "LogoBlobId": 330,
    "LogoName": "Funk LLC",
    "ShowAgentPhoto": true,
    "WelcomeTitle": "aut",
    "WelcomeMessage": "sit",
    "OfflineHeader": "aliquid",
    "OfflineMessage": "sequi",
    "OfflineFields": "Company",
    "UseAgentFirstname": false
  },
  "BotEnabled": true,
  "BotSettings": {
    "BotName": "Renner-Green",
    "BotRegisterScriptId": 530,
    "BotSessionCreatedScriptId": 107,
    "BotSessionChangedScriptId": 91,
    "BotMessageReceivedScriptId": 351
  },
  "OfflineCollectConsent": false,
  "WarnChatMessageMinutes": 417,
  "WarnManagerChatMessageMinutes": 714,
  "UseQueueOfflineForm": false,
  "OfflineFormTimeLimit": 200,
  "OfflineFormQueueLength": 498,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 196
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```