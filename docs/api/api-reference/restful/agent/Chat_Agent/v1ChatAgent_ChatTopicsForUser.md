---
title: POST Agents/Chat/ChatTopicsForUser
id: v1ChatAgent_ChatTopicsForUser
---

# POST Agents/Chat/ChatTopicsForUser

```http
POST /api/v1/Agents/Chat/ChatTopicsForUser
```

Get all chat topics which this user is a member of.

Members means that you have at least one of: Can Respond, Notifications, Listen or Manager





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/ChatTopicsForUser?$select=name,department,category/id
```


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
POST /api/v1/Agents/Chat/ChatTopicsForUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ChatTopicId": 497,
    "Name": "Mitchell LLC",
    "Description": "Visionary systematic concept",
    "WelcomeMessage": "dolores",
    "Language": {
      "Id": 535,
      "Value": "officia",
      "Tooltip": "blanditiis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 323
        }
      }
    },
    "LastAccept": "2001-05-23T18:28:48.3322902+02:00",
    "SecondsPrAccept": 215,
    "AlertRecipient": "et",
    "AlertTemplate": {
      "ReplyTemplateId": 379,
      "Name": "Hane Group",
      "Description": "Sharable intangible conglomeration",
      "FolderId": 729
    },
    "CollectConsent": false,
    "BadgeHeader": "ipsum",
    "CustomQueueTextEnabled": false,
    "CustomQueueText": "eos",
    "WarnNewChatMinutes": 200,
    "WarnManagerNewChatMinutes": 793,
    "TicketEnabled": false,
    "TicketCategory": {
      "Id": 814,
      "Value": "officia",
      "Tooltip": "doloribus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 252
        }
      }
    },
    "TicketPriority": {
      "Id": 139,
      "Value": "harum",
      "Tooltip": "qui",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 734
        }
      }
    },
    "OpeningHoursEnabled": false,
    "OpeningHours": {
      "TzLocation": {},
      "MonEnabled": true,
      "MonStart": "ipsa",
      "MonStop": "totam",
      "TueEnabled": false,
      "TueStart": "sed",
      "TueStop": "ipsum",
      "WedEnabled": true,
      "WedStart": "ipsam",
      "WedStop": "tempore",
      "ThuEnabled": false,
      "ThuStart": "mollitia",
      "ThuStop": "iure",
      "FriEnabled": true,
      "FriStart": "consequuntur",
      "FriStop": "iure",
      "SatEnabled": false,
      "SatStart": "cum",
      "SatStop": "velit",
      "SunEnabled": false,
      "SunStart": "consequuntur",
      "SunStop": "optio",
      "UseLunchHours": true,
      "LunchStart": "aut",
      "LunchStop": "quis"
    },
    "Widget": {
      "AutoFaqEnabled": true,
      "AutoFaqCategory": {},
      "PreFormEnabled": true,
      "PreFormMessage": "et",
      "RequiredFields": "Company",
      "PostFormEnabled": true,
      "PostFormHeader": "culpa",
      "PostFormMessage": "sint",
      "PostTranscriptEnabled": true,
      "LanguageIsoCode": "ut",
      "Size": "Large",
      "Theme": "Classic",
      "Color": "magni",
      "Font": "nostrum",
      "LogoEnabled": false,
      "LogoBlobId": 678,
      "LogoName": "Cummerata Inc and Sons",
      "ShowAgentPhoto": true,
      "WelcomeTitle": "similique",
      "WelcomeMessage": "ea",
      "OfflineHeader": "dolorem",
      "OfflineMessage": "deleniti",
      "OfflineFields": "Company",
      "UseAgentFirstname": true
    },
    "BotEnabled": false,
    "BotSettings": {
      "BotName": "Pouros-Hettinger",
      "BotRegisterScriptId": 946,
      "BotSessionCreatedScriptId": 954,
      "BotSessionChangedScriptId": 515,
      "BotMessageReceivedScriptId": 446
    },
    "OfflineCollectConsent": false,
    "WarnChatMessageMinutes": 959,
    "WarnManagerChatMessageMinutes": 205,
    "UseQueueOfflineForm": false,
    "OfflineFormTimeLimit": 787,
    "OfflineFormQueueLength": 170,
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
        "FieldLength": 698
      }
    }
  }
]
```