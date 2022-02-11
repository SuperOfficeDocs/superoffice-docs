---
title: POST Agents/Chat/SaveChatTopicEntity
id: v1ChatAgent_SaveChatTopicEntity
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



Carrier object for ChatTopicEntity.
Services for the ChatTopicEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IChatAgent">Chat Agent</see>.

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

## Sample Request

```http!
POST /api/v1/Agents/Chat/SaveChatTopicEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 345,
  "Name": "Gulgowski LLC",
  "Description": "Switchable impactful conglomeration",
  "WelcomeMessage": "ut",
  "Language": {
    "Id": 146,
    "Value": "corporis",
    "Tooltip": "beatae"
  },
  "LastAccept": "1995-04-24T18:28:48.2412953+02:00",
  "SecondsPrAccept": 523,
  "AlertRecipient": "et",
  "AlertTemplate": {
    "ReplyTemplateId": 46,
    "Name": "Goodwin LLC",
    "Description": "Self-enabling composite artificial intelligence",
    "FolderId": 737
  },
  "CollectConsent": false,
  "BadgeHeader": "quod",
  "CustomQueueTextEnabled": false,
  "CustomQueueText": "quos",
  "WarnNewChatMinutes": 721,
  "WarnManagerNewChatMinutes": 840,
  "TicketEnabled": true,
  "TicketCategory": {
    "Id": 851,
    "Value": "atque",
    "Tooltip": "aut"
  },
  "TicketPriority": {
    "Id": 13,
    "Value": "nisi",
    "Tooltip": "dolore"
  },
  "OpeningHoursEnabled": false,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": false,
    "MonStart": "molestiae",
    "MonStop": "qui",
    "TueEnabled": true,
    "TueStart": "totam",
    "TueStop": "recusandae",
    "WedEnabled": true,
    "WedStart": "nostrum",
    "WedStop": "unde",
    "ThuEnabled": false,
    "ThuStart": "maxime",
    "ThuStop": "porro",
    "FriEnabled": false,
    "FriStart": "nulla",
    "FriStop": "incidunt",
    "SatEnabled": false,
    "SatStart": "neque",
    "SatStop": "similique",
    "SunEnabled": true,
    "SunStart": "ut",
    "SunStop": "molestiae",
    "UseLunchHours": false,
    "LunchStart": "ipsam",
    "LunchStop": "eveniet"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": true,
    "PreFormMessage": "ullam",
    "RequiredFields": "Company",
    "PostFormEnabled": true,
    "PostFormHeader": "harum",
    "PostFormMessage": "voluptatem",
    "PostTranscriptEnabled": true,
    "LanguageIsoCode": "dolore",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "unde",
    "Font": "adipisci",
    "LogoEnabled": false,
    "LogoBlobId": 913,
    "LogoName": "Hammes Inc and Sons",
    "ShowAgentPhoto": false,
    "WelcomeTitle": "fugit",
    "WelcomeMessage": "amet",
    "OfflineHeader": "et",
    "OfflineMessage": "est",
    "OfflineFields": "Company",
    "UseAgentFirstname": true
  },
  "BotEnabled": true,
  "BotSettings": {
    "BotName": "Lockman LLC",
    "BotRegisterScriptId": 25,
    "BotSessionCreatedScriptId": 742,
    "BotSessionChangedScriptId": 688,
    "BotMessageReceivedScriptId": 828
  },
  "OfflineCollectConsent": false,
  "WarnChatMessageMinutes": 95,
  "WarnManagerChatMessageMinutes": 474,
  "UseQueueOfflineForm": true,
  "OfflineFormTimeLimit": 443,
  "OfflineFormQueueLength": 401
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 874,
  "Name": "Greenholt-Little",
  "Description": "Organized transitional service-desk",
  "WelcomeMessage": "similique",
  "Language": {
    "Id": 927,
    "Value": "repellendus",
    "Tooltip": "neque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 507
      }
    }
  },
  "LastAccept": "1998-03-19T18:28:48.2432979+01:00",
  "SecondsPrAccept": 408,
  "AlertRecipient": "numquam",
  "AlertTemplate": {
    "ReplyTemplateId": 313,
    "Name": "Lind, Powlowski and Paucek",
    "Description": "Sharable reciprocal access",
    "FolderId": 545
  },
  "CollectConsent": true,
  "BadgeHeader": "eaque",
  "CustomQueueTextEnabled": false,
  "CustomQueueText": "perferendis",
  "WarnNewChatMinutes": 872,
  "WarnManagerNewChatMinutes": 129,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 976,
    "Value": "voluptatum",
    "Tooltip": "mollitia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 140
      }
    }
  },
  "TicketPriority": {
    "Id": 739,
    "Value": "ut",
    "Tooltip": "earum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 551
      }
    }
  },
  "OpeningHoursEnabled": true,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": false,
    "MonStart": "sit",
    "MonStop": "omnis",
    "TueEnabled": true,
    "TueStart": "placeat",
    "TueStop": "excepturi",
    "WedEnabled": false,
    "WedStart": "corrupti",
    "WedStop": "dicta",
    "ThuEnabled": true,
    "ThuStart": "id",
    "ThuStop": "voluptatem",
    "FriEnabled": false,
    "FriStart": "architecto",
    "FriStop": "eaque",
    "SatEnabled": false,
    "SatStart": "saepe",
    "SatStop": "aliquid",
    "SunEnabled": false,
    "SunStart": "laudantium",
    "SunStop": "et",
    "UseLunchHours": false,
    "LunchStart": "nobis",
    "LunchStop": "quos"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": false,
    "PreFormMessage": "aspernatur",
    "RequiredFields": "Company",
    "PostFormEnabled": false,
    "PostFormHeader": "neque",
    "PostFormMessage": "excepturi",
    "PostTranscriptEnabled": false,
    "LanguageIsoCode": "est",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "ratione",
    "Font": "nisi",
    "LogoEnabled": false,
    "LogoBlobId": 379,
    "LogoName": "O'Hara-Weissnat",
    "ShowAgentPhoto": false,
    "WelcomeTitle": "autem",
    "WelcomeMessage": "dolores",
    "OfflineHeader": "voluptatum",
    "OfflineMessage": "vel",
    "OfflineFields": "Company",
    "UseAgentFirstname": true
  },
  "BotEnabled": false,
  "BotSettings": {
    "BotName": "Wolff Inc and Sons",
    "BotRegisterScriptId": 144,
    "BotSessionCreatedScriptId": 23,
    "BotSessionChangedScriptId": 845,
    "BotMessageReceivedScriptId": 597
  },
  "OfflineCollectConsent": false,
  "WarnChatMessageMinutes": 685,
  "WarnManagerChatMessageMinutes": 75,
  "UseQueueOfflineForm": false,
  "OfflineFormTimeLimit": 68,
  "OfflineFormQueueLength": 707,
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
      "FieldLength": 117
    }
  }
}
```