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
| Language |  | Customer language used in this topic. Optional |
| LastAccept | date-time | The last time a session was accepted from the inside for this topic. |
| SecondsPrAccept | int32 | The average number of seconds per accept for this topic. |
| AlertRecipient | string | The recipient(s) for the alert template |
| AlertTemplate |  | Template to use for alerts. |
| Flags | string | Alert by e-mail, popup, etc. |
| BadgeHeader | string | The badge header of the chat topic |
| CustomQueueText | string | A text to be used in the queue message in the chat widget. Usage is controlled by the flags field, bit number 3 |
| WarnNewChatSeconds | int32 | Contains the user notify time in seconds |
| WarnManagerNewChatSeconds | int32 | Contains the manager notify time in seconds |
| TicketEnabled | bool | Enable ticket submission in offline mode |
| TicketCategory |  | Category on ticket created from off-line request |
| TicketPriority |  | Priority on ticket created from off-line request |
| OpeningHoursEnabled | bool | Whether to use opening hours or not. |
| OpeningHours |  | Opening hours settings |
| Widget |  | Settings for the chat widget |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/ChatTopic/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 593,
  "Name": "Kuvalis Inc and Sons",
  "Description": "Proactive intangible concept",
  "WelcomeMessage": "quia",
  "Language": {
    "Id": 922,
    "Value": "iusto",
    "Tooltip": "tenetur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 745
      }
    }
  },
  "LastAccept": "2007-09-13T09:40:58.8313748+02:00",
  "SecondsPrAccept": 963,
  "AlertRecipient": "omnis",
  "AlertTemplate": {
    "ReplyTemplateId": 123,
    "Name": "Macejkovic, Wisozk and Oberbrunner",
    "Description": "Ergonomic multi-tasking neural-net",
    "FolderId": 148
  },
  "Flags": "CollectConsent",
  "BadgeHeader": "sit",
  "CustomQueueText": "et",
  "WarnNewChatSeconds": 543,
  "WarnManagerNewChatSeconds": 206,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 469,
    "Value": "voluptatum",
    "Tooltip": "quia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 799
      }
    }
  },
  "TicketPriority": {
    "Id": 648,
    "Value": "non",
    "Tooltip": "consequatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 97
      }
    }
  },
  "OpeningHoursEnabled": false,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": false,
    "MonStart": "2003-02-14T09:40:58.8313748+01:00",
    "MonStop": "1997-02-02T09:40:58.8313748+01:00",
    "TueEnabled": false,
    "TueStart": "2002-09-05T09:40:58.8313748+02:00",
    "TueStop": "2008-12-23T09:40:58.8313748+01:00",
    "WedEnabled": false,
    "WedStart": "2019-06-27T09:40:58.8313748+02:00",
    "WedStop": "2000-12-01T09:40:58.8313748+01:00",
    "ThuEnabled": false,
    "ThuStart": "2020-06-28T09:40:58.8313748+02:00",
    "ThuStop": "2002-05-19T09:40:58.8313748+02:00",
    "FriEnabled": false,
    "FriStart": "1995-07-05T09:40:58.8313748+02:00",
    "FriStop": "1999-08-16T09:40:58.8313748+02:00",
    "SatEnabled": true,
    "SatStart": "2012-12-13T09:40:58.8313748+01:00",
    "SatStop": "2001-08-22T09:40:58.8313748+02:00",
    "SunEnabled": true,
    "SunStart": "1999-05-27T09:40:58.8313748+02:00",
    "SunStop": "1994-03-20T09:40:58.8313748+01:00"
  },
  "Widget": {
    "AutoFaqEnabled": false,
    "AutoFaqCategory": {},
    "PreFormEnabled": false,
    "PreFormMessage": "animi",
    "RequiredFields": "Company",
    "PostFormEnabled": false,
    "PostFormHeader": "facilis",
    "PostFormMessage": "quo",
    "PostTranscriptEnabled": true,
    "LanguageIsoCode": "accusantium",
    "Theme": "Classic",
    "Color": "qui",
    "Font": "quibusdam",
    "ShowLogo": true,
    "ShowAgentPhoto": false,
    "WelcomeTitle": "tempora",
    "WelcomeMessage": "assumenda",
    "OfflineHeader": "sapiente",
    "OfflineMessage": "explicabo",
    "OfflineFields": "Company"
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
      "FieldLength": 998
    }
  }
}
```