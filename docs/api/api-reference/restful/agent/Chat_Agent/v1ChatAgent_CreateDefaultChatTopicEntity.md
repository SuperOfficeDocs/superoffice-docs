---
title: CreateDefaultChatTopicEntity
id: v1ChatAgent_CreateDefaultChatTopicEntity
---

# CreateDefaultChatTopicEntity

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Chat/CreateDefaultChatTopicEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 86,
  "Name": "Marks-Deckow",
  "Description": "Managed 3rd generation instruction set",
  "WelcomeMessage": "aut",
  "Language": {
    "Id": 835,
    "Value": "tempora",
    "Tooltip": "nulla",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 185
      }
    }
  },
  "LastAccept": "1995-04-12T14:58:03.3012407+02:00",
  "SecondsPrAccept": 749,
  "AlertRecipient": "laudantium",
  "AlertTemplate": {
    "ReplyTemplateId": 21,
    "Name": "Donnelly, Dickens and Crona",
    "Description": "Front-line stable parallelism",
    "FolderId": 814
  },
  "CollectConsent": false,
  "BadgeHeader": "ea",
  "CustomQueueTextEnabled": false,
  "CustomQueueText": "ea",
  "WarnNewChatMinutes": 894,
  "WarnManagerNewChatMinutes": 841,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 66,
    "Value": "temporibus",
    "Tooltip": "est",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 766
      }
    }
  },
  "TicketPriority": {
    "Id": 824,
    "Value": "consequatur",
    "Tooltip": "mollitia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 820
      }
    }
  },
  "OpeningHoursEnabled": false,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": true,
    "MonStart": "non",
    "MonStop": "vitae",
    "TueEnabled": true,
    "TueStart": "qui",
    "TueStop": "maiores",
    "WedEnabled": false,
    "WedStart": "et",
    "WedStop": "quia",
    "ThuEnabled": false,
    "ThuStart": "cum",
    "ThuStop": "accusantium",
    "FriEnabled": false,
    "FriStart": "blanditiis",
    "FriStop": "sit",
    "SatEnabled": true,
    "SatStart": "alias",
    "SatStop": "maiores",
    "SunEnabled": true,
    "SunStart": "ut",
    "SunStop": "id",
    "UseLunchHours": false,
    "LunchStart": "dolore",
    "LunchStop": "error"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": true,
    "PreFormMessage": "porro",
    "RequiredFields": "Company",
    "PostFormEnabled": true,
    "PostFormHeader": "totam",
    "PostFormMessage": "repudiandae",
    "PostTranscriptEnabled": false,
    "LanguageIsoCode": "voluptatem",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "voluptate",
    "Font": "pariatur",
    "LogoEnabled": true,
    "LogoBlobId": 20,
    "LogoName": "O'Keefe-Wyman",
    "ShowAgentPhoto": false,
    "WelcomeTitle": "voluptatem",
    "WelcomeMessage": "id",
    "OfflineHeader": "eum",
    "OfflineMessage": "aut",
    "OfflineFields": "Company",
    "UseAgentFirstname": false
  },
  "BotEnabled": true,
  "BotSettings": {
    "BotName": "Ritchie, Hayes and Torphy",
    "BotRegisterScriptId": 250,
    "BotSessionCreatedScriptId": 537,
    "BotSessionChangedScriptId": 458,
    "BotMessageReceivedScriptId": 578
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
      "FieldLength": 334
    }
  }
}
```