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
| 200 | ChatTopicEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/ChatTopic/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 940,
  "Name": "Jacobi Inc and Sons",
  "Description": "Synchronised assymetric throughput",
  "WelcomeMessage": "ratione",
  "Language": {
    "Id": 654,
    "Value": "ipsa",
    "Tooltip": "iste"
  },
  "LastAccept": "2008-11-21T09:40:58.8373714+01:00",
  "SecondsPrAccept": 959,
  "AlertRecipient": "autem",
  "AlertTemplate": {
    "ReplyTemplateId": 226,
    "Name": "Ziemann, Will and Schimmel",
    "Description": "Synergized heuristic standardization",
    "FolderId": 239
  },
  "Flags": "CollectConsent",
  "BadgeHeader": "ratione",
  "CustomQueueText": "quod",
  "WarnNewChatSeconds": 603,
  "WarnManagerNewChatSeconds": 489,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 888,
    "Value": "nostrum",
    "Tooltip": "quo"
  },
  "TicketPriority": {
    "Id": 106,
    "Value": "animi",
    "Tooltip": "voluptate"
  },
  "OpeningHoursEnabled": false,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": false,
    "MonStart": "2001-11-03T09:40:58.8373714+01:00",
    "MonStop": "1997-10-26T09:40:58.8373714+01:00",
    "TueEnabled": false,
    "TueStart": "2015-02-18T09:40:58.8373714+01:00",
    "TueStop": "2013-05-29T09:40:58.8373714+02:00",
    "WedEnabled": true,
    "WedStart": "2005-09-27T09:40:58.8373714+02:00",
    "WedStop": "1999-10-07T09:40:58.8373714+02:00",
    "ThuEnabled": false,
    "ThuStart": "2012-07-06T09:40:58.8373714+02:00",
    "ThuStop": "2006-12-01T09:40:58.8373714+01:00",
    "FriEnabled": false,
    "FriStart": "1994-01-09T09:40:58.8373714+01:00",
    "FriStop": "1997-12-28T09:40:58.8373714+01:00",
    "SatEnabled": true,
    "SatStart": "2008-01-12T09:40:58.8373714+01:00",
    "SatStop": "2021-02-28T09:40:58.8373714+01:00",
    "SunEnabled": false,
    "SunStart": "1994-03-08T09:40:58.8373714+01:00",
    "SunStop": "2009-03-06T09:40:58.8373714+01:00"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": false,
    "PreFormMessage": "quod",
    "RequiredFields": "Company",
    "PostFormEnabled": false,
    "PostFormHeader": "consequatur",
    "PostFormMessage": "ex",
    "PostTranscriptEnabled": false,
    "LanguageIsoCode": "quas",
    "Theme": "Classic",
    "Color": "facere",
    "Font": "et",
    "ShowLogo": false,
    "ShowAgentPhoto": false,
    "WelcomeTitle": "nihil",
    "WelcomeMessage": "similique",
    "OfflineHeader": "unde",
    "OfflineMessage": "et",
    "OfflineFields": "Company"
  }
}
```

```http_
HTTP/1.1 200 ChatTopicEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 674,
  "Name": "O'Keefe-Aufderhar",
  "Description": "Re-contextualized well-modulated software",
  "WelcomeMessage": "harum",
  "Language": {
    "Id": 192,
    "Value": "ut",
    "Tooltip": "soluta",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 21
      }
    }
  },
  "LastAccept": "1995-02-06T09:40:58.8393714+01:00",
  "SecondsPrAccept": 566,
  "AlertRecipient": "illum",
  "AlertTemplate": {
    "ReplyTemplateId": 46,
    "Name": "West, Weissnat and Doyle",
    "Description": "Stand-alone system-worthy contingency",
    "FolderId": 968
  },
  "Flags": "CollectConsent",
  "BadgeHeader": "odit",
  "CustomQueueText": "eum",
  "WarnNewChatSeconds": 219,
  "WarnManagerNewChatSeconds": 516,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 762,
    "Value": "voluptas",
    "Tooltip": "est",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 219
      }
    }
  },
  "TicketPriority": {
    "Id": 84,
    "Value": "accusantium",
    "Tooltip": "nemo",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 292
      }
    }
  },
  "OpeningHoursEnabled": false,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": true,
    "MonStart": "1999-10-27T09:40:58.8393714+02:00",
    "MonStop": "2000-06-01T09:40:58.8393714+02:00",
    "TueEnabled": true,
    "TueStart": "2008-09-01T09:40:58.8393714+02:00",
    "TueStop": "2010-03-12T09:40:58.8393714+01:00",
    "WedEnabled": true,
    "WedStart": "2019-12-26T09:40:58.8393714+01:00",
    "WedStop": "2009-08-11T09:40:58.8393714+02:00",
    "ThuEnabled": true,
    "ThuStart": "2010-06-08T09:40:58.8393714+02:00",
    "ThuStop": "2017-07-30T09:40:58.8393714+02:00",
    "FriEnabled": true,
    "FriStart": "2008-07-13T09:40:58.8393714+02:00",
    "FriStop": "2014-06-14T09:40:58.8393714+02:00",
    "SatEnabled": true,
    "SatStart": "1998-01-14T09:40:58.8393714+01:00",
    "SatStop": "1999-03-07T09:40:58.8393714+01:00",
    "SunEnabled": true,
    "SunStart": "2012-06-21T09:40:58.8393714+02:00",
    "SunStop": "2020-10-12T09:40:58.8393714+02:00"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": true,
    "PreFormMessage": "quod",
    "RequiredFields": "Company",
    "PostFormEnabled": true,
    "PostFormHeader": "sed",
    "PostFormMessage": "tempore",
    "PostTranscriptEnabled": true,
    "LanguageIsoCode": "voluptas",
    "Theme": "Classic",
    "Color": "alias",
    "Font": "et",
    "ShowLogo": true,
    "ShowAgentPhoto": true,
    "WelcomeTitle": "exercitationem",
    "WelcomeMessage": "dolorem",
    "OfflineHeader": "assumenda",
    "OfflineMessage": "optio",
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
      "FieldLength": 848
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```