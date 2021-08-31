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
  "ChatTopicId": 788,
  "Name": "Schaden, Wehner and Wintheiser",
  "Description": "Object-based systematic workforce",
  "WelcomeMessage": "vel",
  "Language": {
    "Id": 78,
    "Value": "ea",
    "Tooltip": "et",
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
  "LastAccept": "2001-04-28T15:05:41.7730057+02:00",
  "SecondsPrAccept": 515,
  "AlertRecipient": "dolorem",
  "AlertTemplate": {
    "ReplyTemplateId": 441,
    "Name": "Legros, Swaniawski and Mitchell",
    "Description": "Integrated leading edge strategy",
    "FolderId": 497
  },
  "CollectConsent": true,
  "BadgeHeader": "velit",
  "CustomQueueTextEnabled": false,
  "CustomQueueText": "doloribus",
  "WarnNewChatMinutes": 429,
  "WarnManagerNewChatMinutes": 21,
  "TicketEnabled": true,
  "TicketCategory": {
    "Id": 608,
    "Value": "expedita",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 593
      }
    }
  },
  "TicketPriority": {
    "Id": 961,
    "Value": "harum",
    "Tooltip": "voluptatum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 165
      }
    }
  },
  "OpeningHoursEnabled": true,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": false,
    "MonStart": "id",
    "MonStop": "excepturi",
    "TueEnabled": false,
    "TueStart": "velit",
    "TueStop": "animi",
    "WedEnabled": true,
    "WedStart": "ipsum",
    "WedStop": "nisi",
    "ThuEnabled": false,
    "ThuStart": "dolorem",
    "ThuStop": "consectetur",
    "FriEnabled": true,
    "FriStart": "at",
    "FriStop": "mollitia",
    "SatEnabled": true,
    "SatStart": "minima",
    "SatStop": "est",
    "SunEnabled": false,
    "SunStart": "dolorem",
    "SunStop": "iure",
    "UseLunchHours": true,
    "LunchStart": "reprehenderit",
    "LunchStop": "eum"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": false,
    "PreFormMessage": "voluptatem",
    "RequiredFields": "Company",
    "PostFormEnabled": false,
    "PostFormHeader": "sit",
    "PostFormMessage": "sunt",
    "PostTranscriptEnabled": false,
    "LanguageIsoCode": "accusamus",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "in",
    "Font": "aliquam",
    "LogoEnabled": true,
    "LogoBlobId": 721,
    "LogoName": "Toy, Walsh and Pfeffer",
    "ShowAgentPhoto": true,
    "WelcomeTitle": "dolor",
    "WelcomeMessage": "adipisci",
    "OfflineHeader": "laudantium",
    "OfflineMessage": "explicabo",
    "OfflineFields": "Company",
    "UseAgentFirstname": false
  },
  "BotEnabled": false,
  "BotSettings": {
    "BotName": "Hamill, Weber and Collins",
    "BotRegisterScriptId": 530,
    "BotSessionCreatedScriptId": 573,
    "BotSessionChangedScriptId": 949,
    "BotMessageReceivedScriptId": 899
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
      "FieldLength": 753
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```