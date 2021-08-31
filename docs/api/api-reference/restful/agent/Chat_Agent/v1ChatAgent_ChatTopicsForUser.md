---
title: ChatTopicsForUser
id: v1ChatAgent_ChatTopicsForUser
---

# ChatTopicsForUser

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Chat/ChatTopicsForUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ChatTopicId": 768,
    "Name": "Russel, Schmitt and Bogan",
    "Description": "Synergized composite artificial intelligence",
    "WelcomeMessage": "similique",
    "Language": {
      "Id": 292,
      "Value": "ut",
      "Tooltip": "numquam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 763
        }
      }
    },
    "LastAccept": "2008-09-23T14:58:03.3852433+02:00",
    "SecondsPrAccept": 675,
    "AlertRecipient": "eum",
    "AlertTemplate": {
      "ReplyTemplateId": 428,
      "Name": "Runolfsdottir-Christiansen",
      "Description": "Networked actuating encoding",
      "FolderId": 963
    },
    "CollectConsent": false,
    "BadgeHeader": "sequi",
    "CustomQueueTextEnabled": false,
    "CustomQueueText": "nesciunt",
    "WarnNewChatMinutes": 272,
    "WarnManagerNewChatMinutes": 459,
    "TicketEnabled": true,
    "TicketCategory": {
      "Id": 817,
      "Value": "corrupti",
      "Tooltip": "placeat",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 742
        }
      }
    },
    "TicketPriority": {
      "Id": 271,
      "Value": "et",
      "Tooltip": "nostrum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 346
        }
      }
    },
    "OpeningHoursEnabled": true,
    "OpeningHours": {
      "TzLocation": {},
      "MonEnabled": true,
      "MonStart": "porro",
      "MonStop": "neque",
      "TueEnabled": false,
      "TueStart": "consequuntur",
      "TueStop": "sunt",
      "WedEnabled": true,
      "WedStart": "voluptas",
      "WedStop": "occaecati",
      "ThuEnabled": false,
      "ThuStart": "ea",
      "ThuStop": "cum",
      "FriEnabled": false,
      "FriStart": "voluptatem",
      "FriStop": "quibusdam",
      "SatEnabled": false,
      "SatStart": "est",
      "SatStop": "in",
      "SunEnabled": false,
      "SunStart": "vel",
      "SunStop": "eos",
      "UseLunchHours": true,
      "LunchStart": "aut",
      "LunchStop": "nisi"
    },
    "Widget": {
      "AutoFaqEnabled": true,
      "AutoFaqCategory": {},
      "PreFormEnabled": false,
      "PreFormMessage": "exercitationem",
      "RequiredFields": "Company",
      "PostFormEnabled": true,
      "PostFormHeader": "cum",
      "PostFormMessage": "harum",
      "PostTranscriptEnabled": true,
      "LanguageIsoCode": "a",
      "Size": "Large",
      "Theme": "Classic",
      "Color": "atque",
      "Font": "ut",
      "LogoEnabled": true,
      "LogoBlobId": 448,
      "LogoName": "Quitzon Group",
      "ShowAgentPhoto": false,
      "WelcomeTitle": "quam",
      "WelcomeMessage": "voluptatibus",
      "OfflineHeader": "natus",
      "OfflineMessage": "aperiam",
      "OfflineFields": "Company",
      "UseAgentFirstname": false
    },
    "BotEnabled": false,
    "BotSettings": {
      "BotName": "Wisozk LLC",
      "BotRegisterScriptId": 761,
      "BotSessionCreatedScriptId": 344,
      "BotSessionChangedScriptId": 486,
      "BotMessageReceivedScriptId": 315
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
        "FieldLength": 650
      }
    }
  }
]
```