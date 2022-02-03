---
title: GET ChatTopic/ForCurrentUser
id: v1ChatTopicEntity_ChatTopicsForUser
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


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
GET /api/v1/ChatTopic/ForCurrentUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ChatTopicId": 332,
    "Name": "Smith, Hodkiewicz and Oberbrunner",
    "Description": "Persistent value-added access",
    "WelcomeMessage": "quos",
    "Language": {
      "Id": 522,
      "Value": "qui",
      "Tooltip": "ea",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 129
        }
      }
    },
    "LastAccept": "2003-06-03T18:25:50.1745957+02:00",
    "SecondsPrAccept": 189,
    "AlertRecipient": "qui",
    "AlertTemplate": {
      "ReplyTemplateId": 285,
      "Name": "Carter, Bernier and Roob",
      "Description": "Enterprise-wide fault-tolerant budgetary management",
      "FolderId": 241
    },
    "CollectConsent": false,
    "BadgeHeader": "accusamus",
    "CustomQueueTextEnabled": true,
    "CustomQueueText": "quia",
    "WarnNewChatMinutes": 948,
    "WarnManagerNewChatMinutes": 295,
    "TicketEnabled": true,
    "TicketCategory": {
      "Id": 910,
      "Value": "similique",
      "Tooltip": "repellat",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 129
        }
      }
    },
    "TicketPriority": {
      "Id": 264,
      "Value": "ab",
      "Tooltip": "minima",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 544
        }
      }
    },
    "OpeningHoursEnabled": false,
    "OpeningHours": {
      "TzLocation": {},
      "MonEnabled": false,
      "MonStart": "assumenda",
      "MonStop": "aliquid",
      "TueEnabled": true,
      "TueStart": "magnam",
      "TueStop": "ex",
      "WedEnabled": false,
      "WedStart": "et",
      "WedStop": "molestiae",
      "ThuEnabled": true,
      "ThuStart": "sit",
      "ThuStop": "quo",
      "FriEnabled": true,
      "FriStart": "dicta",
      "FriStop": "magni",
      "SatEnabled": false,
      "SatStart": "facere",
      "SatStop": "repellat",
      "SunEnabled": false,
      "SunStart": "harum",
      "SunStop": "voluptas",
      "UseLunchHours": true,
      "LunchStart": "reiciendis",
      "LunchStop": "dolor"
    },
    "Widget": {
      "AutoFaqEnabled": false,
      "AutoFaqCategory": {},
      "PreFormEnabled": false,
      "PreFormMessage": "ipsam",
      "RequiredFields": "Company",
      "PostFormEnabled": true,
      "PostFormHeader": "numquam",
      "PostFormMessage": "alias",
      "PostTranscriptEnabled": true,
      "LanguageIsoCode": "sit",
      "Size": "Large",
      "Theme": "Classic",
      "Color": "aspernatur",
      "Font": "deserunt",
      "LogoEnabled": false,
      "LogoBlobId": 92,
      "LogoName": "Howe-Pagac",
      "ShowAgentPhoto": false,
      "WelcomeTitle": "esse",
      "WelcomeMessage": "quasi",
      "OfflineHeader": "eos",
      "OfflineMessage": "aut",
      "OfflineFields": "Company",
      "UseAgentFirstname": false
    },
    "BotEnabled": true,
    "BotSettings": {
      "BotName": "Rutherford Group",
      "BotRegisterScriptId": 918,
      "BotSessionCreatedScriptId": 817,
      "BotSessionChangedScriptId": 976,
      "BotMessageReceivedScriptId": 219
    },
    "OfflineCollectConsent": false,
    "WarnChatMessageMinutes": 881,
    "WarnManagerChatMessageMinutes": 671,
    "UseQueueOfflineForm": true,
    "OfflineFormTimeLimit": 930,
    "OfflineFormQueueLength": 51,
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
        "FieldLength": 692
      }
    }
  }
]
```