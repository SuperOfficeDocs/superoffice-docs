---
title: POST ChatTopic
id: v1ChatTopicEntity_PostChatTopicEntity
---

# POST ChatTopic

```http
POST /api/v1/ChatTopic
```

Creates a new ChatTopicEntity

Calls the Chat agent service SaveChatTopicEntity.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/ChatTopic?$select=name,department,category/id
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

## Request Body: newEntity  

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



ChatTopicEntity entity with API _Links added.

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
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/ChatTopic
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 55,
  "Name": "Herman Group",
  "Description": "Reactive impactful Graphical User Interface",
  "WelcomeMessage": "nobis",
  "Language": {
    "Id": 917,
    "Value": "temporibus",
    "Tooltip": "dolores"
  },
  "LastAccept": "2009-02-18T09:40:58.8323422+01:00",
  "SecondsPrAccept": 599,
  "AlertRecipient": "numquam",
  "AlertTemplate": {
    "ReplyTemplateId": 249,
    "Name": "Hettinger Group",
    "Description": "Centralized motivating task-force",
    "FolderId": 755
  },
  "Flags": "CollectConsent",
  "BadgeHeader": "doloremque",
  "CustomQueueText": "similique",
  "WarnNewChatSeconds": 261,
  "WarnManagerNewChatSeconds": 501,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 241,
    "Value": "aliquid",
    "Tooltip": "ex"
  },
  "TicketPriority": {
    "Id": 41,
    "Value": "adipisci",
    "Tooltip": "at"
  },
  "OpeningHoursEnabled": false,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": true,
    "MonStart": "2002-12-09T09:40:58.8323422+01:00",
    "MonStop": "2004-11-22T09:40:58.8323422+01:00",
    "TueEnabled": false,
    "TueStart": "2018-12-11T09:40:58.8323422+01:00",
    "TueStop": "2001-09-26T09:40:58.8323422+02:00",
    "WedEnabled": true,
    "WedStart": "2019-10-31T09:40:58.8323422+01:00",
    "WedStop": "2008-01-17T09:40:58.8323422+01:00",
    "ThuEnabled": false,
    "ThuStart": "2013-06-16T09:40:58.8323422+02:00",
    "ThuStop": "1995-02-20T09:40:58.8323422+01:00",
    "FriEnabled": false,
    "FriStart": "1997-12-01T09:40:58.8323422+01:00",
    "FriStop": "1995-04-02T09:40:58.8323422+02:00",
    "SatEnabled": true,
    "SatStart": "2000-07-08T09:40:58.8323422+02:00",
    "SatStop": "2021-02-15T09:40:58.8323422+01:00",
    "SunEnabled": true,
    "SunStart": "2011-10-03T09:40:58.8323422+02:00",
    "SunStop": "1997-05-11T09:40:58.8323422+02:00"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": false,
    "PreFormMessage": "necessitatibus",
    "RequiredFields": "Company",
    "PostFormEnabled": false,
    "PostFormHeader": "quia",
    "PostFormMessage": "dolorem",
    "PostTranscriptEnabled": false,
    "LanguageIsoCode": "illum",
    "Theme": "Classic",
    "Color": "sunt",
    "Font": "rerum",
    "ShowLogo": true,
    "ShowAgentPhoto": true,
    "WelcomeTitle": "sit",
    "WelcomeMessage": "a",
    "OfflineHeader": "rerum",
    "OfflineMessage": "ea",
    "OfflineFields": "Company"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 61,
  "Name": "Welch LLC",
  "Description": "Innovative asynchronous process improvement",
  "WelcomeMessage": "facilis",
  "Language": {
    "Id": 492,
    "Value": "praesentium",
    "Tooltip": "officiis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 666
      }
    }
  },
  "LastAccept": "2006-04-06T09:40:58.834344+02:00",
  "SecondsPrAccept": 272,
  "AlertRecipient": "sequi",
  "AlertTemplate": {
    "ReplyTemplateId": 463,
    "Name": "Conn-Schneider",
    "Description": "Cross-group client-driven moderator",
    "FolderId": 664
  },
  "Flags": "CollectConsent",
  "BadgeHeader": "culpa",
  "CustomQueueText": "consequatur",
  "WarnNewChatSeconds": 169,
  "WarnManagerNewChatSeconds": 177,
  "TicketEnabled": true,
  "TicketCategory": {
    "Id": 246,
    "Value": "ut",
    "Tooltip": "reprehenderit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "incentivize collaborative functionalities"
        },
        "FieldType": "System.Int32",
        "FieldLength": 954
      }
    }
  },
  "TicketPriority": {
    "Id": 107,
    "Value": "ut",
    "Tooltip": "ab",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 239
      }
    }
  },
  "OpeningHoursEnabled": false,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": false,
    "MonStart": "2005-02-21T09:40:58.834344+01:00",
    "MonStop": "1996-02-12T09:40:58.834344+01:00",
    "TueEnabled": false,
    "TueStart": "2003-07-02T09:40:58.834344+02:00",
    "TueStop": "2007-12-29T09:40:58.834344+01:00",
    "WedEnabled": false,
    "WedStart": "2020-04-26T09:40:58.834344+02:00",
    "WedStop": "2019-07-13T09:40:58.834344+02:00",
    "ThuEnabled": true,
    "ThuStart": "1997-10-17T09:40:58.834344+02:00",
    "ThuStop": "2005-06-05T09:40:58.834344+02:00",
    "FriEnabled": true,
    "FriStart": "1997-08-11T09:40:58.834344+02:00",
    "FriStop": "2021-02-26T09:40:58.834344+01:00",
    "SatEnabled": true,
    "SatStart": "2000-05-31T09:40:58.834344+02:00",
    "SatStop": "2010-05-03T09:40:58.834344+02:00",
    "SunEnabled": true,
    "SunStart": "1997-01-31T09:40:58.834344+01:00",
    "SunStop": "1997-10-09T09:40:58.834344+02:00"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": true,
    "PreFormMessage": "iste",
    "RequiredFields": "Company",
    "PostFormEnabled": false,
    "PostFormHeader": "quo",
    "PostFormMessage": "id",
    "PostTranscriptEnabled": false,
    "LanguageIsoCode": "nam",
    "Theme": "Classic",
    "Color": "reprehenderit",
    "Font": "esse",
    "ShowLogo": false,
    "ShowAgentPhoto": true,
    "WelcomeTitle": "et",
    "WelcomeMessage": "explicabo",
    "OfflineHeader": "ipsam",
    "OfflineMessage": "porro",
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
      "FieldLength": 784
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```