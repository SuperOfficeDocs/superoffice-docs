---
title: GET ChatTopic/{id}
id: v1ChatTopicEntity_GetChatTopicEntity
---

# GET ChatTopic/{id}

```http
GET /api/v1/ChatTopic/{id}
```

Gets a ChatTopicEntity object.

Calls the Chat agent service GetChatTopicEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ChatTopicEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
GET /api/v1/ChatTopic/{id}?$select=name,department,category/id
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


## Response: object

Chat topics define who is assigned, when the channel is open for business, and look of the chat widget.



ChatTopicEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ChatTopicEntity found. |
| 404 | Not Found. |

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
| _Links | object |  |

## Sample Request

```http!
GET /api/v1/ChatTopic/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 ChatTopicEntity found.
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 652,
  "Name": "Bauch-Bednar",
  "Description": "Synergistic solution-oriented capacity",
  "WelcomeMessage": "quos",
  "Language": {
    "Id": 400,
    "Value": "impedit",
    "Tooltip": "praesentium",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 977
      }
    }
  },
  "LastAccept": "2013-04-12T18:25:50.1636295+02:00",
  "SecondsPrAccept": 694,
  "AlertRecipient": "ipsa",
  "AlertTemplate": {
    "ReplyTemplateId": 553,
    "Name": "Hoeger, Schmitt and Mertz",
    "Description": "Down-sized explicit instruction set",
    "FolderId": 311
  },
  "CollectConsent": true,
  "BadgeHeader": "rerum",
  "CustomQueueTextEnabled": true,
  "CustomQueueText": "sunt",
  "WarnNewChatMinutes": 587,
  "WarnManagerNewChatMinutes": 328,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 438,
    "Value": "amet",
    "Tooltip": "est",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 107
      }
    }
  },
  "TicketPriority": {
    "Id": 238,
    "Value": "harum",
    "Tooltip": "ipsa",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 44
      }
    }
  },
  "OpeningHoursEnabled": false,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": true,
    "MonStart": "hic",
    "MonStop": "reiciendis",
    "TueEnabled": true,
    "TueStart": "perspiciatis",
    "TueStop": "doloribus",
    "WedEnabled": false,
    "WedStart": "nesciunt",
    "WedStop": "facilis",
    "ThuEnabled": true,
    "ThuStart": "vero",
    "ThuStop": "tempora",
    "FriEnabled": true,
    "FriStart": "labore",
    "FriStop": "dolores",
    "SatEnabled": false,
    "SatStart": "perspiciatis",
    "SatStop": "quia",
    "SunEnabled": false,
    "SunStart": "non",
    "SunStop": "voluptatem",
    "UseLunchHours": true,
    "LunchStart": "consequatur",
    "LunchStop": "id"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": false,
    "PreFormMessage": "consequatur",
    "RequiredFields": "Company",
    "PostFormEnabled": false,
    "PostFormHeader": "voluptatibus",
    "PostFormMessage": "repellendus",
    "PostTranscriptEnabled": false,
    "LanguageIsoCode": "magnam",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "doloribus",
    "Font": "laborum",
    "LogoEnabled": true,
    "LogoBlobId": 412,
    "LogoName": "Jones, Kirlin and Cassin",
    "ShowAgentPhoto": false,
    "WelcomeTitle": "magnam",
    "WelcomeMessage": "sed",
    "OfflineHeader": "earum",
    "OfflineMessage": "aliquam",
    "OfflineFields": "Company",
    "UseAgentFirstname": true
  },
  "BotEnabled": true,
  "BotSettings": {
    "BotName": "Langosh, Haley and McGlynn",
    "BotRegisterScriptId": 698,
    "BotSessionCreatedScriptId": 515,
    "BotSessionChangedScriptId": 338,
    "BotMessageReceivedScriptId": 613
  },
  "OfflineCollectConsent": true,
  "WarnChatMessageMinutes": 507,
  "WarnManagerChatMessageMinutes": 714,
  "UseQueueOfflineForm": true,
  "OfflineFormTimeLimit": 930,
  "OfflineFormQueueLength": 450,
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
      "FieldLength": 257
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```