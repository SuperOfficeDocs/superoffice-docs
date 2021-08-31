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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/ChatTopic/ForCurrentUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ChatTopicId": 847,
    "Name": "Goyette Group",
    "Description": "Cross-platform 6th generation system engine",
    "WelcomeMessage": "dicta",
    "Language": {
      "Id": 897,
      "Value": "illum",
      "Tooltip": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 230
        }
      }
    },
    "LastAccept": "2000-04-03T15:05:41.7850051+02:00",
    "SecondsPrAccept": 993,
    "AlertRecipient": "perspiciatis",
    "AlertTemplate": {
      "ReplyTemplateId": 535,
      "Name": "Schowalter-Ferry",
      "Description": "Ergonomic dynamic matrix",
      "FolderId": 595
    },
    "CollectConsent": false,
    "BadgeHeader": "perspiciatis",
    "CustomQueueTextEnabled": false,
    "CustomQueueText": "ut",
    "WarnNewChatMinutes": 129,
    "WarnManagerNewChatMinutes": 438,
    "TicketEnabled": true,
    "TicketCategory": {
      "Id": 537,
      "Value": "iste",
      "Tooltip": "quo",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 817
        }
      }
    },
    "TicketPriority": {
      "Id": 698,
      "Value": "voluptatibus",
      "Tooltip": "eveniet",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 565
        }
      }
    },
    "OpeningHoursEnabled": false,
    "OpeningHours": {
      "TzLocation": {},
      "MonEnabled": false,
      "MonStart": "aut",
      "MonStop": "adipisci",
      "TueEnabled": true,
      "TueStart": "adipisci",
      "TueStop": "veritatis",
      "WedEnabled": true,
      "WedStart": "quidem",
      "WedStop": "qui",
      "ThuEnabled": true,
      "ThuStart": "nihil",
      "ThuStop": "illum",
      "FriEnabled": false,
      "FriStart": "quia",
      "FriStop": "laborum",
      "SatEnabled": true,
      "SatStart": "ex",
      "SatStop": "delectus",
      "SunEnabled": false,
      "SunStart": "ea",
      "SunStop": "sed",
      "UseLunchHours": false,
      "LunchStart": "doloribus",
      "LunchStop": "ut"
    },
    "Widget": {
      "AutoFaqEnabled": false,
      "AutoFaqCategory": {},
      "PreFormEnabled": true,
      "PreFormMessage": "ut",
      "RequiredFields": "Company",
      "PostFormEnabled": true,
      "PostFormHeader": "est",
      "PostFormMessage": "est",
      "PostTranscriptEnabled": true,
      "LanguageIsoCode": "voluptatem",
      "Size": "Large",
      "Theme": "Classic",
      "Color": "soluta",
      "Font": "aut",
      "LogoEnabled": false,
      "LogoBlobId": 883,
      "LogoName": "Funk, Hackett and Grant",
      "ShowAgentPhoto": false,
      "WelcomeTitle": "quam",
      "WelcomeMessage": "corporis",
      "OfflineHeader": "reprehenderit",
      "OfflineMessage": "magnam",
      "OfflineFields": "Company",
      "UseAgentFirstname": false
    },
    "BotEnabled": true,
    "BotSettings": {
      "BotName": "Rolfson Inc and Sons",
      "BotRegisterScriptId": 914,
      "BotSessionCreatedScriptId": 2,
      "BotSessionChangedScriptId": 683,
      "BotMessageReceivedScriptId": 293
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
        "FieldType": "System.Int32",
        "FieldLength": 418
      }
    }
  }
]
```