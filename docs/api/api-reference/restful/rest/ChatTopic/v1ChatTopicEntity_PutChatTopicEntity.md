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
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/ChatTopic/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 53,
  "Name": "Jast-Toy",
  "Description": "Expanded high-level capability",
  "WelcomeMessage": "aut",
  "Language": {
    "Id": 419,
    "Value": "nam",
    "Tooltip": "quibusdam"
  },
  "LastAccept": "2000-06-23T15:05:41.7740053+02:00",
  "SecondsPrAccept": 140,
  "AlertRecipient": "maxime",
  "AlertTemplate": {
    "ReplyTemplateId": 698,
    "Name": "Hamill-Williamson",
    "Description": "Distributed explicit throughput",
    "FolderId": 29
  },
  "CollectConsent": false,
  "BadgeHeader": "dolorum",
  "CustomQueueTextEnabled": true,
  "CustomQueueText": "dignissimos",
  "WarnNewChatMinutes": 704,
  "WarnManagerNewChatMinutes": 331,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 433,
    "Value": "nam",
    "Tooltip": "labore"
  },
  "TicketPriority": {
    "Id": 177,
    "Value": "aperiam",
    "Tooltip": "inventore"
  },
  "OpeningHoursEnabled": true,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": false,
    "MonStart": "magni",
    "MonStop": "ex",
    "TueEnabled": true,
    "TueStart": "quisquam",
    "TueStop": "explicabo",
    "WedEnabled": true,
    "WedStart": "rerum",
    "WedStop": "accusamus",
    "ThuEnabled": false,
    "ThuStart": "qui",
    "ThuStop": "quasi",
    "FriEnabled": false,
    "FriStart": "eum",
    "FriStop": "porro",
    "SatEnabled": false,
    "SatStart": "praesentium",
    "SatStop": "similique",
    "SunEnabled": false,
    "SunStart": "voluptatem",
    "SunStop": "quos",
    "UseLunchHours": true,
    "LunchStart": "et",
    "LunchStop": "beatae"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": false,
    "PreFormMessage": "debitis",
    "RequiredFields": "Company",
    "PostFormEnabled": true,
    "PostFormHeader": "ex",
    "PostFormMessage": "laudantium",
    "PostTranscriptEnabled": true,
    "LanguageIsoCode": "illum",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "rem",
    "Font": "repellat",
    "LogoEnabled": true,
    "LogoBlobId": 888,
    "LogoName": "Jerde-Franecki",
    "ShowAgentPhoto": true,
    "WelcomeTitle": "porro",
    "WelcomeMessage": "quod",
    "OfflineHeader": "ea",
    "OfflineMessage": "saepe",
    "OfflineFields": "Company",
    "UseAgentFirstname": false
  },
  "BotEnabled": false,
  "BotSettings": {
    "BotName": "Wilderman-Homenick",
    "BotRegisterScriptId": 332,
    "BotSessionCreatedScriptId": 162,
    "BotSessionChangedScriptId": 803,
    "BotMessageReceivedScriptId": 90
  }
}
```

```http_
HTTP/1.1 200 ChatTopicEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 415,
  "Name": "Goyette Group",
  "Description": "Reactive interactive contingency",
  "WelcomeMessage": "omnis",
  "Language": {
    "Id": 415,
    "Value": "soluta",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 402
      }
    }
  },
  "LastAccept": "1999-03-06T15:05:41.7770049+01:00",
  "SecondsPrAccept": 583,
  "AlertRecipient": "quod",
  "AlertTemplate": {
    "ReplyTemplateId": 315,
    "Name": "Dooley-Murray",
    "Description": "Configurable 24 hour interface",
    "FolderId": 690
  },
  "CollectConsent": false,
  "BadgeHeader": "nihil",
  "CustomQueueTextEnabled": false,
  "CustomQueueText": "neque",
  "WarnNewChatMinutes": 969,
  "WarnManagerNewChatMinutes": 805,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 261,
    "Value": "molestiae",
    "Tooltip": "quibusdam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 314
      }
    }
  },
  "TicketPriority": {
    "Id": 1000,
    "Value": "omnis",
    "Tooltip": "repudiandae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 933
      }
    }
  },
  "OpeningHoursEnabled": false,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": false,
    "MonStart": "et",
    "MonStop": "sint",
    "TueEnabled": true,
    "TueStart": "voluptatem",
    "TueStop": "excepturi",
    "WedEnabled": true,
    "WedStart": "rerum",
    "WedStop": "et",
    "ThuEnabled": false,
    "ThuStart": "asperiores",
    "ThuStop": "sint",
    "FriEnabled": true,
    "FriStart": "dolore",
    "FriStop": "alias",
    "SatEnabled": true,
    "SatStart": "error",
    "SatStop": "iusto",
    "SunEnabled": false,
    "SunStart": "incidunt",
    "SunStop": "et",
    "UseLunchHours": false,
    "LunchStart": "illo",
    "LunchStop": "molestiae"
  },
  "Widget": {
    "AutoFaqEnabled": false,
    "AutoFaqCategory": {},
    "PreFormEnabled": false,
    "PreFormMessage": "officiis",
    "RequiredFields": "Company",
    "PostFormEnabled": false,
    "PostFormHeader": "reprehenderit",
    "PostFormMessage": "aliquid",
    "PostTranscriptEnabled": false,
    "LanguageIsoCode": "qui",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "dolorem",
    "Font": "eius",
    "LogoEnabled": true,
    "LogoBlobId": 954,
    "LogoName": "Yundt LLC",
    "ShowAgentPhoto": false,
    "WelcomeTitle": "et",
    "WelcomeMessage": "sint",
    "OfflineHeader": "minus",
    "OfflineMessage": "deleniti",
    "OfflineFields": "Company",
    "UseAgentFirstname": false
  },
  "BotEnabled": false,
  "BotSettings": {
    "BotName": "Hilpert, White and Bashirian",
    "BotRegisterScriptId": 338,
    "BotSessionCreatedScriptId": 744,
    "BotSessionChangedScriptId": 995,
    "BotMessageReceivedScriptId": 924
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
      "FieldLength": 217
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```