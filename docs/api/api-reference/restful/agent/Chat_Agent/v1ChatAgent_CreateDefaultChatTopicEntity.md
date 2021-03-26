---
title: POST Agents/Chat/CreateDefaultChatTopicEntity
id: v1ChatAgent_CreateDefaultChatTopicEntity
---

# POST Agents/Chat/CreateDefaultChatTopicEntity

```http
POST /api/v1/Agents/Chat/CreateDefaultChatTopicEntity
```

Set default values into a new ChatTopicEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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
POST /api/v1/Agents/Chat/CreateDefaultChatTopicEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 954,
  "Name": "Berge-Kuphal",
  "Description": "Advanced regional implementation",
  "WelcomeMessage": "est",
  "Language": {
    "Id": 949,
    "Value": "cum",
    "Tooltip": "enim",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 337
      }
    }
  },
  "LastAccept": "2006-10-03T16:48:28.8091634+02:00",
  "SecondsPrAccept": 537,
  "AlertRecipient": "tempore",
  "AlertTemplate": {
    "ReplyTemplateId": 462,
    "Name": "Ullrich-Stokes",
    "Description": "Horizontal non-volatile core",
    "FolderId": 326
  },
  "Flags": "CollectConsent",
  "BadgeHeader": "sint",
  "CustomQueueText": "provident",
  "WarnNewChatSeconds": 159,
  "WarnManagerNewChatSeconds": 508,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 87,
    "Value": "consequatur",
    "Tooltip": "quis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 315
      }
    }
  },
  "TicketPriority": {
    "Id": 56,
    "Value": "ut",
    "Tooltip": "tempora",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 282
      }
    }
  },
  "OpeningHoursEnabled": false,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": false,
    "MonStart": "2004-12-11T16:48:28.8091634+01:00",
    "MonStop": "2016-11-02T16:48:28.8091634+01:00",
    "TueEnabled": true,
    "TueStart": "2000-09-16T16:48:28.8091634+02:00",
    "TueStop": "2015-07-16T16:48:28.8091634+02:00",
    "WedEnabled": true,
    "WedStart": "2001-08-08T16:48:28.8091634+02:00",
    "WedStop": "1997-03-20T16:48:28.8091634+01:00",
    "ThuEnabled": true,
    "ThuStart": "2002-04-30T16:48:28.8091634+02:00",
    "ThuStop": "1999-12-17T16:48:28.8091634+01:00",
    "FriEnabled": true,
    "FriStart": "2012-04-06T16:48:28.8091634+02:00",
    "FriStop": "2017-02-11T16:48:28.8091634+01:00",
    "SatEnabled": true,
    "SatStart": "2009-02-05T16:48:28.8091634+01:00",
    "SatStop": "2016-08-18T16:48:28.8091634+02:00",
    "SunEnabled": true,
    "SunStart": "2010-09-09T16:48:28.8091634+02:00",
    "SunStop": "1993-12-21T16:48:28.8091634+01:00"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": true,
    "PreFormMessage": "ipsam",
    "RequiredFields": "Company",
    "PostFormEnabled": true,
    "PostFormHeader": "alias",
    "PostFormMessage": "non",
    "PostTranscriptEnabled": false,
    "LanguageIsoCode": "enim",
    "Theme": "Classic",
    "Color": "molestiae",
    "Font": "et",
    "ShowLogo": true,
    "ShowAgentPhoto": true,
    "WelcomeTitle": "praesentium",
    "WelcomeMessage": "fuga",
    "OfflineHeader": "distinctio",
    "OfflineMessage": "nostrum",
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
      "FieldLength": 702
    }
  }
}
```