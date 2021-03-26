---
title: POST Agents/Chat/SaveChatTopicEntity
id: v1ChatAgent_SaveChatTopicEntity
---

# POST Agents/Chat/SaveChatTopicEntity

```http
POST /api/v1/Agents/Chat/SaveChatTopicEntity
```

Updates the existing ChatTopicEntity or creates a new ChatTopicEntity if the id parameter is empty








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
POST /api/v1/Agents/Chat/SaveChatTopicEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 558,
  "Name": "Brekke-Senger",
  "Description": "Diverse foreground paradigm",
  "WelcomeMessage": "et",
  "Language": {
    "Id": 118,
    "Value": "vero",
    "Tooltip": "officiis"
  },
  "LastAccept": "2012-05-10T16:48:28.810178+02:00",
  "SecondsPrAccept": 782,
  "AlertRecipient": "molestiae",
  "AlertTemplate": {
    "ReplyTemplateId": 385,
    "Name": "Lowe Inc and Sons",
    "Description": "Up-sized 4th generation data-warehouse",
    "FolderId": 96
  },
  "Flags": "CollectConsent",
  "BadgeHeader": "asperiores",
  "CustomQueueText": "error",
  "WarnNewChatSeconds": 358,
  "WarnManagerNewChatSeconds": 384,
  "TicketEnabled": true,
  "TicketCategory": {
    "Id": 724,
    "Value": "omnis",
    "Tooltip": "illum"
  },
  "TicketPriority": {
    "Id": 599,
    "Value": "ut",
    "Tooltip": "quas"
  },
  "OpeningHoursEnabled": false,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": false,
    "MonStart": "2011-01-18T16:48:28.810178+01:00",
    "MonStop": "2009-09-13T16:48:28.810178+02:00",
    "TueEnabled": false,
    "TueStart": "2006-04-28T16:48:28.810178+02:00",
    "TueStop": "2013-11-12T16:48:28.810178+01:00",
    "WedEnabled": false,
    "WedStart": "2007-03-19T16:48:28.810178+01:00",
    "WedStop": "2003-08-27T16:48:28.810178+02:00",
    "ThuEnabled": true,
    "ThuStart": "2015-01-07T16:48:28.810178+01:00",
    "ThuStop": "2002-04-20T16:48:28.810178+02:00",
    "FriEnabled": true,
    "FriStart": "2005-11-16T16:48:28.810178+01:00",
    "FriStop": "2018-02-18T16:48:28.810178+01:00",
    "SatEnabled": false,
    "SatStart": "2002-05-17T16:48:28.810178+02:00",
    "SatStop": "2005-10-30T16:48:28.810178+01:00",
    "SunEnabled": false,
    "SunStart": "2006-02-14T16:48:28.810178+01:00",
    "SunStop": "2016-08-20T16:48:28.810178+02:00"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": true,
    "PreFormMessage": "perferendis",
    "RequiredFields": "Company",
    "PostFormEnabled": false,
    "PostFormHeader": "repellendus",
    "PostFormMessage": "est",
    "PostTranscriptEnabled": true,
    "LanguageIsoCode": "veniam",
    "Theme": "Classic",
    "Color": "dolorem",
    "Font": "qui",
    "ShowLogo": true,
    "ShowAgentPhoto": false,
    "WelcomeTitle": "quod",
    "WelcomeMessage": "dolores",
    "OfflineHeader": "deleniti",
    "OfflineMessage": "cumque",
    "OfflineFields": "Company"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 833,
  "Name": "Dare LLC",
  "Description": "Multi-tiered coherent interface",
  "WelcomeMessage": "laudantium",
  "Language": {
    "Id": 861,
    "Value": "fugit",
    "Tooltip": "minus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 474
      }
    }
  },
  "LastAccept": "2018-06-01T16:48:28.8121636+02:00",
  "SecondsPrAccept": 421,
  "AlertRecipient": "animi",
  "AlertTemplate": {
    "ReplyTemplateId": 813,
    "Name": "Schmitt, Kuphal and Langosh",
    "Description": "Monitored contextually-based structure",
    "FolderId": 481
  },
  "Flags": "CollectConsent",
  "BadgeHeader": "minima",
  "CustomQueueText": "vel",
  "WarnNewChatSeconds": 360,
  "WarnManagerNewChatSeconds": 976,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 289,
    "Value": "aliquid",
    "Tooltip": "provident",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "orchestrate wireless experiences"
        },
        "FieldType": "System.String",
        "FieldLength": 471
      }
    }
  },
  "TicketPriority": {
    "Id": 915,
    "Value": "eum",
    "Tooltip": "incidunt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 983
      }
    }
  },
  "OpeningHoursEnabled": false,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": true,
    "MonStart": "2011-06-26T16:48:28.8131634+02:00",
    "MonStop": "2005-04-28T16:48:28.8131634+02:00",
    "TueEnabled": true,
    "TueStart": "2012-05-31T16:48:28.8131634+02:00",
    "TueStop": "2013-06-17T16:48:28.8131634+02:00",
    "WedEnabled": true,
    "WedStart": "2007-11-20T16:48:28.8131634+01:00",
    "WedStop": "2013-10-10T16:48:28.8131634+02:00",
    "ThuEnabled": true,
    "ThuStart": "2013-11-22T16:48:28.8131634+01:00",
    "ThuStop": "2002-09-13T16:48:28.8131634+02:00",
    "FriEnabled": false,
    "FriStart": "2010-11-03T16:48:28.8131634+01:00",
    "FriStop": "2014-04-15T16:48:28.8131634+02:00",
    "SatEnabled": true,
    "SatStart": "2013-08-20T16:48:28.8131634+02:00",
    "SatStop": "2003-09-03T16:48:28.8131634+02:00",
    "SunEnabled": false,
    "SunStart": "2011-11-04T16:48:28.8131634+01:00",
    "SunStop": "2001-09-13T16:48:28.8131634+02:00"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": false,
    "PreFormMessage": "error",
    "RequiredFields": "Company",
    "PostFormEnabled": true,
    "PostFormHeader": "sit",
    "PostFormMessage": "at",
    "PostTranscriptEnabled": true,
    "LanguageIsoCode": "id",
    "Theme": "Classic",
    "Color": "et",
    "Font": "impedit",
    "ShowLogo": false,
    "ShowAgentPhoto": false,
    "WelcomeTitle": "soluta",
    "WelcomeMessage": "sed",
    "OfflineHeader": "occaecati",
    "OfflineMessage": "enim",
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
      "FieldLength": 580
    }
  }
}
```