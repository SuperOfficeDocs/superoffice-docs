---
title: PUT ChatTopic/{id}
id: v1ChatTopicEntity_PutChatTopicEntity
---

# PUT ChatTopic/{id}

```http
PUT /api/v1/ChatTopic/{id}
```

Updates the existing ChatTopicEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ChatTopicEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/ChatTopic/{id}?$select=name,department,category/id
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
| OfflineCollectConsent | bool | Collect offline consent to store from user |
| WarnChatMessageMinutes | int32 | Contains the user notify time in minutes for new chat messages |
| WarnManagerChatMessageMinutes | int32 | Contains the manager notify time in minutes for new chat messages |
| UseQueueOfflineForm | bool | Use offline form capability from chat queue |
| OfflineFormTimeLimit | int32 | The number of minutes in the queue before the offline form is available |
| OfflineFormQueueLength | int32 | The number of customers in the queue before the offline form is available |


## Response: object

Chat topics define who is assigned, when the channel is open for business, and look of the chat widget.



ChatTopicEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ChatTopicEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/ChatTopic/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 841,
  "Name": "Collier, Mertz and Shanahan",
  "Description": "Advanced local array",
  "WelcomeMessage": "vitae",
  "Language": {
    "Id": 46,
    "Value": "sed",
    "Tooltip": "ullam"
  },
  "LastAccept": "2010-06-25T18:25:50.1656241+02:00",
  "SecondsPrAccept": 716,
  "AlertRecipient": "dicta",
  "AlertTemplate": {
    "ReplyTemplateId": 841,
    "Name": "Franecki Inc and Sons",
    "Description": "Synchronised high-level pricing structure",
    "FolderId": 130
  },
  "CollectConsent": true,
  "BadgeHeader": "inventore",
  "CustomQueueTextEnabled": false,
  "CustomQueueText": "dolor",
  "WarnNewChatMinutes": 631,
  "WarnManagerNewChatMinutes": 677,
  "TicketEnabled": true,
  "TicketCategory": {
    "Id": 456,
    "Value": "est",
    "Tooltip": "ipsa"
  },
  "TicketPriority": {
    "Id": 4,
    "Value": "et",
    "Tooltip": "qui"
  },
  "OpeningHoursEnabled": true,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": true,
    "MonStart": "repellendus",
    "MonStop": "non",
    "TueEnabled": true,
    "TueStart": "modi",
    "TueStop": "placeat",
    "WedEnabled": true,
    "WedStart": "quasi",
    "WedStop": "eum",
    "ThuEnabled": false,
    "ThuStart": "aut",
    "ThuStop": "recusandae",
    "FriEnabled": true,
    "FriStart": "voluptates",
    "FriStop": "laborum",
    "SatEnabled": false,
    "SatStart": "quibusdam",
    "SatStop": "maxime",
    "SunEnabled": false,
    "SunStart": "quidem",
    "SunStop": "vel",
    "UseLunchHours": false,
    "LunchStart": "culpa",
    "LunchStop": "illo"
  },
  "Widget": {
    "AutoFaqEnabled": false,
    "AutoFaqCategory": {},
    "PreFormEnabled": true,
    "PreFormMessage": "rerum",
    "RequiredFields": "Company",
    "PostFormEnabled": false,
    "PostFormHeader": "iusto",
    "PostFormMessage": "laboriosam",
    "PostTranscriptEnabled": false,
    "LanguageIsoCode": "occaecati",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "unde",
    "Font": "et",
    "LogoEnabled": false,
    "LogoBlobId": 403,
    "LogoName": "Ebert-Stamm",
    "ShowAgentPhoto": true,
    "WelcomeTitle": "quas",
    "WelcomeMessage": "quasi",
    "OfflineHeader": "consequatur",
    "OfflineMessage": "expedita",
    "OfflineFields": "Company",
    "UseAgentFirstname": false
  },
  "BotEnabled": true,
  "BotSettings": {
    "BotName": "Gleason-Sawayn",
    "BotRegisterScriptId": 654,
    "BotSessionCreatedScriptId": 919,
    "BotSessionChangedScriptId": 330,
    "BotMessageReceivedScriptId": 143
  },
  "OfflineCollectConsent": false,
  "WarnChatMessageMinutes": 179,
  "WarnManagerChatMessageMinutes": 23,
  "UseQueueOfflineForm": false,
  "OfflineFormTimeLimit": 750,
  "OfflineFormQueueLength": 592
}
```

```http_
HTTP/1.1 200 ChatTopicEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 679,
  "Name": "Ankunding-Mraz",
  "Description": "Open-source transitional focus group",
  "WelcomeMessage": "unde",
  "Language": {
    "Id": 143,
    "Value": "magni",
    "Tooltip": "est",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 220
      }
    }
  },
  "LastAccept": "2017-10-27T18:25:50.167624+02:00",
  "SecondsPrAccept": 477,
  "AlertRecipient": "quibusdam",
  "AlertTemplate": {
    "ReplyTemplateId": 504,
    "Name": "Goyette, Anderson and Kertzmann",
    "Description": "Synergistic attitude-oriented knowledge user",
    "FolderId": 392
  },
  "CollectConsent": false,
  "BadgeHeader": "cum",
  "CustomQueueTextEnabled": false,
  "CustomQueueText": "voluptatem",
  "WarnNewChatMinutes": 934,
  "WarnManagerNewChatMinutes": 385,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 891,
    "Value": "mollitia",
    "Tooltip": "est",
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
    "Id": 296,
    "Value": "commodi",
    "Tooltip": "eum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 284
      }
    }
  },
  "OpeningHoursEnabled": true,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": false,
    "MonStart": "deleniti",
    "MonStop": "doloribus",
    "TueEnabled": false,
    "TueStart": "voluptatem",
    "TueStop": "vel",
    "WedEnabled": false,
    "WedStart": "maxime",
    "WedStop": "et",
    "ThuEnabled": false,
    "ThuStart": "sed",
    "ThuStop": "consequatur",
    "FriEnabled": false,
    "FriStart": "consequuntur",
    "FriStop": "vel",
    "SatEnabled": false,
    "SatStart": "dolore",
    "SatStop": "et",
    "SunEnabled": false,
    "SunStart": "reiciendis",
    "SunStop": "et",
    "UseLunchHours": true,
    "LunchStart": "ab",
    "LunchStop": "vel"
  },
  "Widget": {
    "AutoFaqEnabled": false,
    "AutoFaqCategory": {},
    "PreFormEnabled": true,
    "PreFormMessage": "dolores",
    "RequiredFields": "Company",
    "PostFormEnabled": false,
    "PostFormHeader": "non",
    "PostFormMessage": "et",
    "PostTranscriptEnabled": true,
    "LanguageIsoCode": "sed",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "laboriosam",
    "Font": "iure",
    "LogoEnabled": true,
    "LogoBlobId": 725,
    "LogoName": "Harvey, Huel and Stokes",
    "ShowAgentPhoto": true,
    "WelcomeTitle": "voluptatem",
    "WelcomeMessage": "dolor",
    "OfflineHeader": "placeat",
    "OfflineMessage": "asperiores",
    "OfflineFields": "Company",
    "UseAgentFirstname": false
  },
  "BotEnabled": false,
  "BotSettings": {
    "BotName": "Brekke-Stehr",
    "BotRegisterScriptId": 987,
    "BotSessionCreatedScriptId": 503,
    "BotSessionChangedScriptId": 110,
    "BotMessageReceivedScriptId": 739
  },
  "OfflineCollectConsent": false,
  "WarnChatMessageMinutes": 282,
  "WarnManagerChatMessageMinutes": 161,
  "UseQueueOfflineForm": false,
  "OfflineFormTimeLimit": 96,
  "OfflineFormQueueLength": 160,
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
      "FieldLength": 703
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```