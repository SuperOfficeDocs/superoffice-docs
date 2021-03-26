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
GET /api/v1/ChatTopic/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 ChatTopicEntity found.
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 174,
  "Name": "Runte, Yost and Schmeler",
  "Description": "Progressive tangible extranet",
  "WelcomeMessage": "omnis",
  "Language": {
    "Id": 16,
    "Value": "amet",
    "Tooltip": "unde",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 359
      }
    }
  },
  "LastAccept": "2004-10-27T09:40:58.8363697+02:00",
  "SecondsPrAccept": 642,
  "AlertRecipient": "deleniti",
  "AlertTemplate": {
    "ReplyTemplateId": 15,
    "Name": "Runte-Hauck",
    "Description": "Intuitive system-worthy extranet",
    "FolderId": 133
  },
  "Flags": "CollectConsent",
  "BadgeHeader": "unde",
  "CustomQueueText": "sapiente",
  "WarnNewChatSeconds": 669,
  "WarnManagerNewChatSeconds": 92,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 23,
    "Value": "occaecati",
    "Tooltip": "veniam",
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
  "TicketPriority": {
    "Id": 387,
    "Value": "cumque",
    "Tooltip": "asperiores",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "engage bleeding-edge deliverables"
        },
        "FieldType": "System.Int32",
        "FieldLength": 31
      }
    }
  },
  "OpeningHoursEnabled": true,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": true,
    "MonStart": "2009-03-02T09:40:58.8373714+01:00",
    "MonStop": "2010-07-19T09:40:58.8373714+02:00",
    "TueEnabled": false,
    "TueStart": "2005-10-01T09:40:58.8373714+02:00",
    "TueStop": "2009-11-27T09:40:58.8373714+01:00",
    "WedEnabled": false,
    "WedStart": "2011-03-14T09:40:58.8373714+01:00",
    "WedStop": "2005-02-26T09:40:58.8373714+01:00",
    "ThuEnabled": false,
    "ThuStart": "2018-11-11T09:40:58.8373714+01:00",
    "ThuStop": "2002-10-03T09:40:58.8373714+02:00",
    "FriEnabled": true,
    "FriStart": "1995-11-10T09:40:58.8373714+01:00",
    "FriStop": "2017-12-02T09:40:58.8373714+01:00",
    "SatEnabled": false,
    "SatStart": "2015-11-28T09:40:58.8373714+01:00",
    "SatStop": "2008-12-04T09:40:58.8373714+01:00",
    "SunEnabled": false,
    "SunStart": "2003-07-09T09:40:58.8373714+02:00",
    "SunStop": "2002-10-02T09:40:58.8373714+02:00"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": false,
    "PreFormMessage": "impedit",
    "RequiredFields": "Company",
    "PostFormEnabled": true,
    "PostFormHeader": "sint",
    "PostFormMessage": "repudiandae",
    "PostTranscriptEnabled": false,
    "LanguageIsoCode": "nobis",
    "Theme": "Classic",
    "Color": "ut",
    "Font": "repellat",
    "ShowLogo": false,
    "ShowAgentPhoto": true,
    "WelcomeTitle": "quibusdam",
    "WelcomeMessage": "et",
    "OfflineHeader": "distinctio",
    "OfflineMessage": "doloribus",
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
      "FieldLength": 455
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```