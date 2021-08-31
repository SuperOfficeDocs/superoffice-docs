---
title: GET ChatTopic/default
id: v1ChatTopicEntity_DefaultChatTopicEntity
---

# GET ChatTopic/default

```http
GET /api/v1/ChatTopic/default
```

Set default values into a new ChatTopicEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Chat agent service CreateDefaultChatTopicEntity.






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
GET /api/v1/ChatTopic/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 72,
  "Name": "Kulas Inc and Sons",
  "Description": "Business-focused bifurcated internet solution",
  "WelcomeMessage": "eius",
  "Language": {
    "Id": 634,
    "Value": "unde",
    "Tooltip": "quae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 324
      }
    }
  },
  "LastAccept": "2006-11-13T15:05:41.7660052+01:00",
  "SecondsPrAccept": 787,
  "AlertRecipient": "eius",
  "AlertTemplate": {
    "ReplyTemplateId": 351,
    "Name": "Pacocha-Fritsch",
    "Description": "Visionary optimizing moratorium",
    "FolderId": 758
  },
  "CollectConsent": false,
  "BadgeHeader": "sint",
  "CustomQueueTextEnabled": false,
  "CustomQueueText": "temporibus",
  "WarnNewChatMinutes": 291,
  "WarnManagerNewChatMinutes": 677,
  "TicketEnabled": true,
  "TicketCategory": {
    "Id": 887,
    "Value": "fugit",
    "Tooltip": "laboriosam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 512
      }
    }
  },
  "TicketPriority": {
    "Id": 112,
    "Value": "officiis",
    "Tooltip": "optio",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 931
      }
    }
  },
  "OpeningHoursEnabled": true,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": false,
    "MonStart": "nesciunt",
    "MonStop": "aut",
    "TueEnabled": true,
    "TueStart": "rerum",
    "TueStop": "voluptatum",
    "WedEnabled": false,
    "WedStart": "expedita",
    "WedStop": "ullam",
    "ThuEnabled": false,
    "ThuStart": "qui",
    "ThuStop": "aut",
    "FriEnabled": true,
    "FriStart": "dolor",
    "FriStop": "harum",
    "SatEnabled": true,
    "SatStart": "mollitia",
    "SatStop": "necessitatibus",
    "SunEnabled": true,
    "SunStart": "eos",
    "SunStop": "voluptatem",
    "UseLunchHours": true,
    "LunchStart": "est",
    "LunchStop": "rerum"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": true,
    "PreFormMessage": "mollitia",
    "RequiredFields": "Company",
    "PostFormEnabled": true,
    "PostFormHeader": "dignissimos",
    "PostFormMessage": "ipsa",
    "PostTranscriptEnabled": false,
    "LanguageIsoCode": "id",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "quidem",
    "Font": "voluptatem",
    "LogoEnabled": false,
    "LogoBlobId": 580,
    "LogoName": "Christiansen-Robel",
    "ShowAgentPhoto": false,
    "WelcomeTitle": "aut",
    "WelcomeMessage": "minima",
    "OfflineHeader": "non",
    "OfflineMessage": "ut",
    "OfflineFields": "Company",
    "UseAgentFirstname": false
  },
  "BotEnabled": true,
  "BotSettings": {
    "BotName": "Mayert, Rodriguez and Hermann",
    "BotRegisterScriptId": 228,
    "BotSessionCreatedScriptId": 444,
    "BotSessionChangedScriptId": 975,
    "BotMessageReceivedScriptId": 474
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
      "FieldLength": 639
    }
  }
}
```