---
title: POST Agents/Chat/GetChatTopicEntity
id: v1ChatAgent_GetChatTopicEntity
---

# POST Agents/Chat/GetChatTopicEntity

```http
POST /api/v1/Agents/Chat/GetChatTopicEntity
```

Gets a ChatTopicEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| chatTopicEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/GetChatTopicEntity?chatTopicEntityId=351
POST /api/v1/Agents/Chat/GetChatTopicEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Chat/GetChatTopicEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 475,
  "Name": "Corwin-Sporer",
  "Description": "Managed grid-enabled installation",
  "WelcomeMessage": "earum",
  "Language": {
    "Id": 657,
    "Value": "repudiandae",
    "Tooltip": "quas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "facilitate visionary paradigms"
        },
        "FieldType": "System.String",
        "FieldLength": 366
      }
    }
  },
  "LastAccept": "2004-06-11T18:28:48.3302944+02:00",
  "SecondsPrAccept": 699,
  "AlertRecipient": "sit",
  "AlertTemplate": {
    "ReplyTemplateId": 966,
    "Name": "Prohaska Inc and Sons",
    "Description": "Triple-buffered attitude-oriented website",
    "FolderId": 850
  },
  "CollectConsent": true,
  "BadgeHeader": "rem",
  "CustomQueueTextEnabled": false,
  "CustomQueueText": "corrupti",
  "WarnNewChatMinutes": 287,
  "WarnManagerNewChatMinutes": 425,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 579,
    "Value": "sit",
    "Tooltip": "non",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 658
      }
    }
  },
  "TicketPriority": {
    "Id": 532,
    "Value": "rerum",
    "Tooltip": "quo",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 459
      }
    }
  },
  "OpeningHoursEnabled": true,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": false,
    "MonStart": "aperiam",
    "MonStop": "est",
    "TueEnabled": true,
    "TueStart": "voluptates",
    "TueStop": "sunt",
    "WedEnabled": true,
    "WedStart": "omnis",
    "WedStop": "soluta",
    "ThuEnabled": true,
    "ThuStart": "at",
    "ThuStop": "eaque",
    "FriEnabled": true,
    "FriStart": "aliquam",
    "FriStop": "in",
    "SatEnabled": false,
    "SatStart": "error",
    "SatStop": "occaecati",
    "SunEnabled": false,
    "SunStart": "doloremque",
    "SunStop": "dolorum",
    "UseLunchHours": true,
    "LunchStart": "labore",
    "LunchStop": "dolorem"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": true,
    "PreFormMessage": "et",
    "RequiredFields": "Company",
    "PostFormEnabled": true,
    "PostFormHeader": "dicta",
    "PostFormMessage": "omnis",
    "PostTranscriptEnabled": true,
    "LanguageIsoCode": "optio",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "aut",
    "Font": "ut",
    "LogoEnabled": true,
    "LogoBlobId": 858,
    "LogoName": "Corkery Group",
    "ShowAgentPhoto": true,
    "WelcomeTitle": "ea",
    "WelcomeMessage": "itaque",
    "OfflineHeader": "sint",
    "OfflineMessage": "corrupti",
    "OfflineFields": "Company",
    "UseAgentFirstname": false
  },
  "BotEnabled": true,
  "BotSettings": {
    "BotName": "Hartmann, Schmeler and Kemmer",
    "BotRegisterScriptId": 50,
    "BotSessionCreatedScriptId": 123,
    "BotSessionChangedScriptId": 331,
    "BotMessageReceivedScriptId": 986
  },
  "OfflineCollectConsent": true,
  "WarnChatMessageMinutes": 287,
  "WarnManagerChatMessageMinutes": 635,
  "UseQueueOfflineForm": false,
  "OfflineFormTimeLimit": 108,
  "OfflineFormQueueLength": 495,
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
      "FieldLength": 885
    }
  }
}
```