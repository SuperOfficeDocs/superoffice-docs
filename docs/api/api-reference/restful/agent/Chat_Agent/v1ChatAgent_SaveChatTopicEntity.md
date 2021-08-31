---
title: SaveChatTopicEntity
id: v1ChatAgent_SaveChatTopicEntity
---

# SaveChatTopicEntity

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
  "ChatTopicId": 488,
  "Name": "Huels LLC",
  "Description": "Optimized impactful paradigm",
  "WelcomeMessage": "ut",
  "Language": {
    "Id": 999,
    "Value": "omnis",
    "Tooltip": "ut"
  },
  "LastAccept": "2019-05-10T14:58:03.3022465+02:00",
  "SecondsPrAccept": 971,
  "AlertRecipient": "veniam",
  "AlertTemplate": {
    "ReplyTemplateId": 887,
    "Name": "Marks, Orn and Hansen",
    "Description": "Versatile scalable infrastructure",
    "FolderId": 152
  },
  "CollectConsent": true,
  "BadgeHeader": "ducimus",
  "CustomQueueTextEnabled": false,
  "CustomQueueText": "velit",
  "WarnNewChatMinutes": 407,
  "WarnManagerNewChatMinutes": 825,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 185,
    "Value": "quia",
    "Tooltip": "est"
  },
  "TicketPriority": {
    "Id": 430,
    "Value": "nisi",
    "Tooltip": "corrupti"
  },
  "OpeningHoursEnabled": false,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": true,
    "MonStart": "totam",
    "MonStop": "et",
    "TueEnabled": false,
    "TueStart": "omnis",
    "TueStop": "eos",
    "WedEnabled": true,
    "WedStart": "veritatis",
    "WedStop": "harum",
    "ThuEnabled": false,
    "ThuStart": "repellat",
    "ThuStop": "ut",
    "FriEnabled": true,
    "FriStart": "dignissimos",
    "FriStop": "facilis",
    "SatEnabled": false,
    "SatStart": "autem",
    "SatStop": "eveniet",
    "SunEnabled": false,
    "SunStart": "voluptatem",
    "SunStop": "non",
    "UseLunchHours": false,
    "LunchStart": "sed",
    "LunchStop": "perspiciatis"
  },
  "Widget": {
    "AutoFaqEnabled": false,
    "AutoFaqCategory": {},
    "PreFormEnabled": false,
    "PreFormMessage": "omnis",
    "RequiredFields": "Company",
    "PostFormEnabled": true,
    "PostFormHeader": "eaque",
    "PostFormMessage": "cumque",
    "PostTranscriptEnabled": true,
    "LanguageIsoCode": "sit",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "quae",
    "Font": "nobis",
    "LogoEnabled": false,
    "LogoBlobId": 375,
    "LogoName": "Mosciski Group",
    "ShowAgentPhoto": false,
    "WelcomeTitle": "occaecati",
    "WelcomeMessage": "molestiae",
    "OfflineHeader": "facilis",
    "OfflineMessage": "et",
    "OfflineFields": "Company",
    "UseAgentFirstname": false
  },
  "BotEnabled": false,
  "BotSettings": {
    "BotName": "Orn-Bashirian",
    "BotRegisterScriptId": 165,
    "BotSessionCreatedScriptId": 700,
    "BotSessionChangedScriptId": 449,
    "BotMessageReceivedScriptId": 404
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 750,
  "Name": "Weimann-Schmidt",
  "Description": "Reactive high-level knowledge user",
  "WelcomeMessage": "sapiente",
  "Language": {
    "Id": 758,
    "Value": "odio",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 251
      }
    }
  },
  "LastAccept": "2018-08-12T14:58:03.3042409+02:00",
  "SecondsPrAccept": 950,
  "AlertRecipient": "qui",
  "AlertTemplate": {
    "ReplyTemplateId": 908,
    "Name": "Barrows Group",
    "Description": "Synergistic bandwidth-monitored matrix",
    "FolderId": 32
  },
  "CollectConsent": false,
  "BadgeHeader": "dolore",
  "CustomQueueTextEnabled": true,
  "CustomQueueText": "nemo",
  "WarnNewChatMinutes": 779,
  "WarnManagerNewChatMinutes": 271,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 358,
    "Value": "consequatur",
    "Tooltip": "culpa",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 1001
      }
    }
  },
  "TicketPriority": {
    "Id": 13,
    "Value": "quia",
    "Tooltip": "molestiae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "utilize world-class applications"
        },
        "FieldType": "System.String",
        "FieldLength": 951
      }
    }
  },
  "OpeningHoursEnabled": false,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": true,
    "MonStart": "recusandae",
    "MonStop": "commodi",
    "TueEnabled": true,
    "TueStart": "et",
    "TueStop": "eaque",
    "WedEnabled": false,
    "WedStart": "possimus",
    "WedStop": "repellendus",
    "ThuEnabled": true,
    "ThuStart": "est",
    "ThuStop": "eius",
    "FriEnabled": false,
    "FriStart": "et",
    "FriStop": "et",
    "SatEnabled": true,
    "SatStart": "explicabo",
    "SatStop": "et",
    "SunEnabled": false,
    "SunStart": "libero",
    "SunStop": "soluta",
    "UseLunchHours": false,
    "LunchStart": "distinctio",
    "LunchStop": "aut"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": true,
    "PreFormMessage": "optio",
    "RequiredFields": "Company",
    "PostFormEnabled": true,
    "PostFormHeader": "dolorum",
    "PostFormMessage": "est",
    "PostTranscriptEnabled": true,
    "LanguageIsoCode": "qui",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "doloribus",
    "Font": "illo",
    "LogoEnabled": false,
    "LogoBlobId": 410,
    "LogoName": "Ledner Inc and Sons",
    "ShowAgentPhoto": true,
    "WelcomeTitle": "sapiente",
    "WelcomeMessage": "nesciunt",
    "OfflineHeader": "doloremque",
    "OfflineMessage": "distinctio",
    "OfflineFields": "Company",
    "UseAgentFirstname": false
  },
  "BotEnabled": true,
  "BotSettings": {
    "BotName": "Dach Inc and Sons",
    "BotRegisterScriptId": 530,
    "BotSessionCreatedScriptId": 707,
    "BotSessionChangedScriptId": 167,
    "BotMessageReceivedScriptId": 765
  },
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
      "FieldType": "System.String",
      "FieldLength": 35
    }
  }
}
```