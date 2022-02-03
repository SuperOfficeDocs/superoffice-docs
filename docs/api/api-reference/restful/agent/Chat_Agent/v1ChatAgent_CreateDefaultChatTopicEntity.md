---
title: POST Agents/Chat/CreateDefaultChatTopicEntity
id: v1ChatAgent_CreateDefaultChatTopicEntity
---

# POST Agents/Chat/CreateDefaultChatTopicEntity

```http
POST /api/v1/Agents/Chat/CreateDefaultChatTopicEntity
```

Set default values into a new ChatTopicEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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
POST /api/v1/Agents/Chat/CreateDefaultChatTopicEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 24,
  "Name": "Raynor-Gorczany",
  "Description": "Adaptive analyzing moderator",
  "WelcomeMessage": "accusantium",
  "Language": {
    "Id": 354,
    "Value": "et",
    "Tooltip": "voluptatum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 731
      }
    }
  },
  "LastAccept": "2018-10-24T18:28:48.2402972+02:00",
  "SecondsPrAccept": 962,
  "AlertRecipient": "qui",
  "AlertTemplate": {
    "ReplyTemplateId": 596,
    "Name": "Mohr-Howell",
    "Description": "Focused systemic concept",
    "FolderId": 738
  },
  "CollectConsent": false,
  "BadgeHeader": "quo",
  "CustomQueueTextEnabled": false,
  "CustomQueueText": "voluptatibus",
  "WarnNewChatMinutes": 841,
  "WarnManagerNewChatMinutes": 728,
  "TicketEnabled": true,
  "TicketCategory": {
    "Id": 735,
    "Value": "aut",
    "Tooltip": "eum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 171
      }
    }
  },
  "TicketPriority": {
    "Id": 514,
    "Value": "in",
    "Tooltip": "hic",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 861
      }
    }
  },
  "OpeningHoursEnabled": true,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": false,
    "MonStart": "dolor",
    "MonStop": "sunt",
    "TueEnabled": true,
    "TueStart": "adipisci",
    "TueStop": "quidem",
    "WedEnabled": false,
    "WedStart": "doloremque",
    "WedStop": "in",
    "ThuEnabled": true,
    "ThuStart": "ex",
    "ThuStop": "non",
    "FriEnabled": true,
    "FriStart": "ipsam",
    "FriStop": "aliquid",
    "SatEnabled": false,
    "SatStart": "blanditiis",
    "SatStop": "esse",
    "SunEnabled": false,
    "SunStart": "quia",
    "SunStop": "inventore",
    "UseLunchHours": false,
    "LunchStart": "impedit",
    "LunchStop": "doloribus"
  },
  "Widget": {
    "AutoFaqEnabled": false,
    "AutoFaqCategory": {},
    "PreFormEnabled": true,
    "PreFormMessage": "odio",
    "RequiredFields": "Company",
    "PostFormEnabled": false,
    "PostFormHeader": "expedita",
    "PostFormMessage": "similique",
    "PostTranscriptEnabled": false,
    "LanguageIsoCode": "aut",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "ullam",
    "Font": "dignissimos",
    "LogoEnabled": true,
    "LogoBlobId": 954,
    "LogoName": "Emard Group",
    "ShowAgentPhoto": true,
    "WelcomeTitle": "odio",
    "WelcomeMessage": "nobis",
    "OfflineHeader": "nihil",
    "OfflineMessage": "nisi",
    "OfflineFields": "Company",
    "UseAgentFirstname": false
  },
  "BotEnabled": false,
  "BotSettings": {
    "BotName": "Thiel-McLaughlin",
    "BotRegisterScriptId": 399,
    "BotSessionCreatedScriptId": 232,
    "BotSessionChangedScriptId": 679,
    "BotMessageReceivedScriptId": 883
  },
  "OfflineCollectConsent": true,
  "WarnChatMessageMinutes": 454,
  "WarnManagerChatMessageMinutes": 946,
  "UseQueueOfflineForm": false,
  "OfflineFormTimeLimit": 473,
  "OfflineFormQueueLength": 898,
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
      "FieldLength": 39
    }
  }
}
```