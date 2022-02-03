---
title: GET ChatTopic/default
id: v1ChatTopicEntity_DefaultChatTopicEntity
---

# GET ChatTopic/default

```http
GET /api/v1/ChatTopic/default
```

Set default values into a new ChatTopicEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Chat agent service CreateDefaultChatTopicEntity.






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
GET /api/v1/ChatTopic/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 102,
  "Name": "Willms, Zulauf and Gleason",
  "Description": "Extended neutral monitoring",
  "WelcomeMessage": "voluptates",
  "Language": {
    "Id": 940,
    "Value": "quod",
    "Tooltip": "debitis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 197
      }
    }
  },
  "LastAccept": "2009-02-23T18:25:50.1576203+01:00",
  "SecondsPrAccept": 13,
  "AlertRecipient": "dolorum",
  "AlertTemplate": {
    "ReplyTemplateId": 883,
    "Name": "Ledner, Mayert and Zemlak",
    "Description": "Innovative user-facing knowledge base",
    "FolderId": 769
  },
  "CollectConsent": true,
  "BadgeHeader": "dicta",
  "CustomQueueTextEnabled": false,
  "CustomQueueText": "non",
  "WarnNewChatMinutes": 231,
  "WarnManagerNewChatMinutes": 486,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 557,
    "Value": "beatae",
    "Tooltip": "vel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 308
      }
    }
  },
  "TicketPriority": {
    "Id": 54,
    "Value": "maiores",
    "Tooltip": "quis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 63
      }
    }
  },
  "OpeningHoursEnabled": false,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": false,
    "MonStart": "minima",
    "MonStop": "nisi",
    "TueEnabled": true,
    "TueStart": "impedit",
    "TueStop": "vitae",
    "WedEnabled": false,
    "WedStart": "sunt",
    "WedStop": "quo",
    "ThuEnabled": true,
    "ThuStart": "ut",
    "ThuStop": "consequuntur",
    "FriEnabled": false,
    "FriStart": "qui",
    "FriStop": "aut",
    "SatEnabled": true,
    "SatStart": "illo",
    "SatStop": "occaecati",
    "SunEnabled": true,
    "SunStart": "accusamus",
    "SunStop": "autem",
    "UseLunchHours": false,
    "LunchStart": "nemo",
    "LunchStop": "eaque"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": true,
    "PreFormMessage": "dolor",
    "RequiredFields": "Company",
    "PostFormEnabled": true,
    "PostFormHeader": "ad",
    "PostFormMessage": "fugiat",
    "PostTranscriptEnabled": true,
    "LanguageIsoCode": "voluptate",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "aut",
    "Font": "eius",
    "LogoEnabled": false,
    "LogoBlobId": 391,
    "LogoName": "Willms Inc and Sons",
    "ShowAgentPhoto": false,
    "WelcomeTitle": "voluptatem",
    "WelcomeMessage": "sint",
    "OfflineHeader": "dolor",
    "OfflineMessage": "et",
    "OfflineFields": "Company",
    "UseAgentFirstname": false
  },
  "BotEnabled": false,
  "BotSettings": {
    "BotName": "Lowe, Rath and Ratke",
    "BotRegisterScriptId": 783,
    "BotSessionCreatedScriptId": 510,
    "BotSessionChangedScriptId": 924,
    "BotMessageReceivedScriptId": 916
  },
  "OfflineCollectConsent": true,
  "WarnChatMessageMinutes": 627,
  "WarnManagerChatMessageMinutes": 711,
  "UseQueueOfflineForm": false,
  "OfflineFormTimeLimit": 474,
  "OfflineFormQueueLength": 465,
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
      "FieldLength": 93
    }
  }
}
```