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
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/ChatTopic
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 574,
  "Name": "Klein Inc and Sons",
  "Description": "Business-focused next generation array",
  "WelcomeMessage": "animi",
  "Language": {
    "Id": 366,
    "Value": "qui",
    "Tooltip": "provident"
  },
  "LastAccept": "2018-08-12T15:05:41.7680051+02:00",
  "SecondsPrAccept": 850,
  "AlertRecipient": "voluptatem",
  "AlertTemplate": {
    "ReplyTemplateId": 138,
    "Name": "Lehner-Beer",
    "Description": "User-centric responsive moratorium",
    "FolderId": 138
  },
  "CollectConsent": false,
  "BadgeHeader": "atque",
  "CustomQueueTextEnabled": true,
  "CustomQueueText": "aperiam",
  "WarnNewChatMinutes": 981,
  "WarnManagerNewChatMinutes": 642,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 890,
    "Value": "eos",
    "Tooltip": "quasi"
  },
  "TicketPriority": {
    "Id": 137,
    "Value": "voluptatibus",
    "Tooltip": "ab"
  },
  "OpeningHoursEnabled": false,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": true,
    "MonStart": "ea",
    "MonStop": "ut",
    "TueEnabled": true,
    "TueStart": "sed",
    "TueStop": "sint",
    "WedEnabled": true,
    "WedStart": "ut",
    "WedStop": "ipsum",
    "ThuEnabled": true,
    "ThuStart": "suscipit",
    "ThuStop": "ad",
    "FriEnabled": true,
    "FriStart": "perferendis",
    "FriStop": "occaecati",
    "SatEnabled": true,
    "SatStart": "et",
    "SatStop": "voluptas",
    "SunEnabled": true,
    "SunStart": "placeat",
    "SunStop": "vero",
    "UseLunchHours": true,
    "LunchStart": "architecto",
    "LunchStop": "ad"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": false,
    "PreFormMessage": "alias",
    "RequiredFields": "Company",
    "PostFormEnabled": false,
    "PostFormHeader": "quos",
    "PostFormMessage": "soluta",
    "PostTranscriptEnabled": false,
    "LanguageIsoCode": "nihil",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "et",
    "Font": "necessitatibus",
    "LogoEnabled": true,
    "LogoBlobId": 567,
    "LogoName": "Steuber, Gibson and Kerluke",
    "ShowAgentPhoto": false,
    "WelcomeTitle": "nihil",
    "WelcomeMessage": "quasi",
    "OfflineHeader": "minus",
    "OfflineMessage": "in",
    "OfflineFields": "Company",
    "UseAgentFirstname": false
  },
  "BotEnabled": false,
  "BotSettings": {
    "BotName": "Kemmer Group",
    "BotRegisterScriptId": 656,
    "BotSessionCreatedScriptId": 359,
    "BotSessionChangedScriptId": 165,
    "BotMessageReceivedScriptId": 582
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 882,
  "Name": "Fadel-Kuvalis",
  "Description": "Versatile zero administration extranet",
  "WelcomeMessage": "sed",
  "Language": {
    "Id": 207,
    "Value": "exercitationem",
    "Tooltip": "fuga",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 498
      }
    }
  },
  "LastAccept": "2007-01-18T15:05:41.7700052+01:00",
  "SecondsPrAccept": 737,
  "AlertRecipient": "quia",
  "AlertTemplate": {
    "ReplyTemplateId": 60,
    "Name": "Dicki-Johns",
    "Description": "Fundamental scalable collaboration",
    "FolderId": 552
  },
  "CollectConsent": true,
  "BadgeHeader": "ea",
  "CustomQueueTextEnabled": false,
  "CustomQueueText": "in",
  "WarnNewChatMinutes": 964,
  "WarnManagerNewChatMinutes": 913,
  "TicketEnabled": true,
  "TicketCategory": {
    "Id": 563,
    "Value": "aperiam",
    "Tooltip": "soluta",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 718
      }
    }
  },
  "TicketPriority": {
    "Id": 166,
    "Value": "quae",
    "Tooltip": "aspernatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 537
      }
    }
  },
  "OpeningHoursEnabled": false,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": true,
    "MonStart": "rerum",
    "MonStop": "sunt",
    "TueEnabled": false,
    "TueStart": "et",
    "TueStop": "aut",
    "WedEnabled": true,
    "WedStart": "inventore",
    "WedStop": "accusantium",
    "ThuEnabled": false,
    "ThuStart": "hic",
    "ThuStop": "autem",
    "FriEnabled": false,
    "FriStart": "ut",
    "FriStop": "facilis",
    "SatEnabled": false,
    "SatStart": "quos",
    "SatStop": "officia",
    "SunEnabled": true,
    "SunStart": "eos",
    "SunStop": "mollitia",
    "UseLunchHours": false,
    "LunchStart": "soluta",
    "LunchStop": "voluptate"
  },
  "Widget": {
    "AutoFaqEnabled": false,
    "AutoFaqCategory": {},
    "PreFormEnabled": false,
    "PreFormMessage": "quasi",
    "RequiredFields": "Company",
    "PostFormEnabled": true,
    "PostFormHeader": "autem",
    "PostFormMessage": "consequuntur",
    "PostTranscriptEnabled": true,
    "LanguageIsoCode": "quas",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "corporis",
    "Font": "vero",
    "LogoEnabled": true,
    "LogoBlobId": 66,
    "LogoName": "Gerhold-Heidenreich",
    "ShowAgentPhoto": false,
    "WelcomeTitle": "enim",
    "WelcomeMessage": "expedita",
    "OfflineHeader": "ab",
    "OfflineMessage": "consequatur",
    "OfflineFields": "Company",
    "UseAgentFirstname": false
  },
  "BotEnabled": true,
  "BotSettings": {
    "BotName": "Cummerata, Casper and Morissette",
    "BotRegisterScriptId": 703,
    "BotSessionCreatedScriptId": 713,
    "BotSessionChangedScriptId": 805,
    "BotMessageReceivedScriptId": 271
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
      "FieldLength": 253
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```