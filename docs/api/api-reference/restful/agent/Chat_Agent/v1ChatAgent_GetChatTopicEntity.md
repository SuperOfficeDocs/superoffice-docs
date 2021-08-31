---
title: GetChatTopicEntity
id: v1ChatAgent_GetChatTopicEntity
---

# GetChatTopicEntity

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
POST /api/v1/Agents/Chat/GetChatTopicEntity?chatTopicEntityId=575
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
  "ChatTopicId": 752,
  "Name": "Morissette, Prosacco and Bechtelar",
  "Description": "Networked composite benchmark",
  "WelcomeMessage": "eaque",
  "Language": {
    "Id": 49,
    "Value": "soluta",
    "Tooltip": "voluptas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "embrace proactive interfaces"
        },
        "FieldType": "System.String",
        "FieldLength": 846
      }
    }
  },
  "LastAccept": "2008-02-04T14:58:03.3822423+01:00",
  "SecondsPrAccept": 234,
  "AlertRecipient": "expedita",
  "AlertTemplate": {
    "ReplyTemplateId": 194,
    "Name": "Auer LLC",
    "Description": "Customer-focused bandwidth-monitored secured line",
    "FolderId": 397
  },
  "CollectConsent": false,
  "BadgeHeader": "est",
  "CustomQueueTextEnabled": false,
  "CustomQueueText": "dolor",
  "WarnNewChatMinutes": 292,
  "WarnManagerNewChatMinutes": 654,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 165,
    "Value": "reiciendis",
    "Tooltip": "repellat",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 375
      }
    }
  },
  "TicketPriority": {
    "Id": 344,
    "Value": "cumque",
    "Tooltip": "ea",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 302
      }
    }
  },
  "OpeningHoursEnabled": false,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": true,
    "MonStart": "et",
    "MonStop": "nulla",
    "TueEnabled": true,
    "TueStart": "quibusdam",
    "TueStop": "similique",
    "WedEnabled": false,
    "WedStart": "veniam",
    "WedStop": "quasi",
    "ThuEnabled": true,
    "ThuStart": "minima",
    "ThuStop": "adipisci",
    "FriEnabled": true,
    "FriStart": "iste",
    "FriStop": "dolor",
    "SatEnabled": true,
    "SatStart": "non",
    "SatStop": "ut",
    "SunEnabled": true,
    "SunStart": "atque",
    "SunStop": "sed",
    "UseLunchHours": false,
    "LunchStart": "exercitationem",
    "LunchStop": "et"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": false,
    "PreFormMessage": "quis",
    "RequiredFields": "Company",
    "PostFormEnabled": true,
    "PostFormHeader": "provident",
    "PostFormMessage": "architecto",
    "PostTranscriptEnabled": true,
    "LanguageIsoCode": "non",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "atque",
    "Font": "qui",
    "LogoEnabled": false,
    "LogoBlobId": 593,
    "LogoName": "Ortiz, Howe and Kuhn",
    "ShowAgentPhoto": true,
    "WelcomeTitle": "reiciendis",
    "WelcomeMessage": "suscipit",
    "OfflineHeader": "quo",
    "OfflineMessage": "consequatur",
    "OfflineFields": "Company",
    "UseAgentFirstname": true
  },
  "BotEnabled": true,
  "BotSettings": {
    "BotName": "Tremblay Group",
    "BotRegisterScriptId": 538,
    "BotSessionCreatedScriptId": 165,
    "BotSessionChangedScriptId": 95,
    "BotMessageReceivedScriptId": 55
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
      "FieldLength": 763
    }
  }
}
```