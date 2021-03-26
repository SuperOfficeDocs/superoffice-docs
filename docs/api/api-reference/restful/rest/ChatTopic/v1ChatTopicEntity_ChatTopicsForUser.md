---
title: GET ChatTopic/ForCurrentUser
id: v1ChatTopicEntity_ChatTopicsForUser
---

# GET ChatTopic/ForCurrentUser

```http
GET /api/v1/ChatTopic/ForCurrentUser
```

Get all chat topics which this user is a member of.

Members means that you have at least one of: Can Respond, Notifications, Listen or Manager






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


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
GET /api/v1/ChatTopic/ForCurrentUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ChatTopicId": 545,
    "Name": "Corwin-McClure",
    "Description": "Virtual dynamic database",
    "WelcomeMessage": "voluptatem",
    "Language": {
      "Id": 72,
      "Value": "rem",
      "Tooltip": "quis",
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
    "LastAccept": "2008-05-28T09:40:58.843373+02:00",
    "SecondsPrAccept": 302,
    "AlertRecipient": "consectetur",
    "AlertTemplate": {
      "ReplyTemplateId": 677,
      "Name": "Dare Group",
      "Description": "Ameliorated system-worthy contingency",
      "FolderId": 860
    },
    "Flags": "CollectConsent",
    "BadgeHeader": "dolor",
    "CustomQueueText": "saepe",
    "WarnNewChatSeconds": 460,
    "WarnManagerNewChatSeconds": 620,
    "TicketEnabled": true,
    "TicketCategory": {
      "Id": 914,
      "Value": "eum",
      "Tooltip": "deserunt",
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
    "TicketPriority": {
      "Id": 881,
      "Value": "rerum",
      "Tooltip": "impedit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 352
        }
      }
    },
    "OpeningHoursEnabled": false,
    "OpeningHours": {
      "TzLocation": {},
      "MonEnabled": true,
      "MonStart": "2010-03-01T09:40:58.843373+01:00",
      "MonStop": "2020-02-05T09:40:58.843373+01:00",
      "TueEnabled": true,
      "TueStart": "2010-12-20T09:40:58.843373+01:00",
      "TueStop": "1998-06-15T09:40:58.843373+02:00",
      "WedEnabled": true,
      "WedStart": "2001-04-09T09:40:58.843373+02:00",
      "WedStop": "2016-04-12T09:40:58.843373+02:00",
      "ThuEnabled": true,
      "ThuStart": "2001-09-28T09:40:58.843373+02:00",
      "ThuStop": "2010-07-07T09:40:58.843373+02:00",
      "FriEnabled": false,
      "FriStart": "2003-10-26T09:40:58.843373+01:00",
      "FriStop": "2016-04-30T09:40:58.843373+02:00",
      "SatEnabled": true,
      "SatStart": "1995-02-07T09:40:58.843373+01:00",
      "SatStop": "2008-04-15T09:40:58.843373+02:00",
      "SunEnabled": false,
      "SunStart": "2004-10-26T09:40:58.843373+02:00",
      "SunStop": "2003-04-04T09:40:58.843373+02:00"
    },
    "Widget": {
      "AutoFaqEnabled": true,
      "AutoFaqCategory": {},
      "PreFormEnabled": true,
      "PreFormMessage": "voluptatem",
      "RequiredFields": "Company",
      "PostFormEnabled": true,
      "PostFormHeader": "harum",
      "PostFormMessage": "libero",
      "PostTranscriptEnabled": true,
      "LanguageIsoCode": "optio",
      "Theme": "Classic",
      "Color": "accusamus",
      "Font": "qui",
      "ShowLogo": true,
      "ShowAgentPhoto": true,
      "WelcomeTitle": "cumque",
      "WelcomeMessage": "fuga",
      "OfflineHeader": "vel",
      "OfflineMessage": "ducimus",
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
        "FieldType": "System.Int32",
        "FieldLength": 864
      }
    }
  }
]
```