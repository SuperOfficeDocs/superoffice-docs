---
title: POST Agents/Chat/ChatTopicsForUser
id: v1ChatAgent_ChatTopicsForUser
---

# POST Agents/Chat/ChatTopicsForUser

```http
POST /api/v1/Agents/Chat/ChatTopicsForUser
```

Get all chat topics which this user is a member of.

Members means that you have at least one of: Can Respond, Notifications, Listen or Manager





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/ChatTopicsForUser?$select=name,department,category/id
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
POST /api/v1/Agents/Chat/ChatTopicsForUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ChatTopicId": 431,
    "Name": "Beahan, Brekke and Witting",
    "Description": "Face to face intangible firmware",
    "WelcomeMessage": "molestiae",
    "Language": {
      "Id": 71,
      "Value": "consequatur",
      "Tooltip": "ut",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 235
        }
      }
    },
    "LastAccept": "2004-12-07T16:48:28.8819193+01:00",
    "SecondsPrAccept": 58,
    "AlertRecipient": "ullam",
    "AlertTemplate": {
      "ReplyTemplateId": 845,
      "Name": "Morissette, Erdman and Anderson",
      "Description": "Versatile client-driven neural-net",
      "FolderId": 882
    },
    "Flags": "CollectConsent",
    "BadgeHeader": "et",
    "CustomQueueText": "voluptatem",
    "WarnNewChatSeconds": 514,
    "WarnManagerNewChatSeconds": 705,
    "TicketEnabled": false,
    "TicketCategory": {
      "Id": 731,
      "Value": "quisquam",
      "Tooltip": "omnis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 859
        }
      }
    },
    "TicketPriority": {
      "Id": 55,
      "Value": "velit",
      "Tooltip": "ex",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 206
        }
      }
    },
    "OpeningHoursEnabled": true,
    "OpeningHours": {
      "TzLocation": {},
      "MonEnabled": true,
      "MonStart": "2019-06-10T16:48:28.8819193+02:00",
      "MonStop": "2006-12-18T16:48:28.8819193+01:00",
      "TueEnabled": true,
      "TueStart": "1996-10-11T16:48:28.8819193+02:00",
      "TueStop": "2014-04-23T16:48:28.8819193+02:00",
      "WedEnabled": true,
      "WedStart": "2011-05-08T16:48:28.8819193+02:00",
      "WedStop": "2007-04-05T16:48:28.8819193+02:00",
      "ThuEnabled": true,
      "ThuStart": "2014-01-04T16:48:28.8819193+01:00",
      "ThuStop": "1999-04-04T16:48:28.8819193+02:00",
      "FriEnabled": true,
      "FriStart": "2007-06-03T16:48:28.8819193+02:00",
      "FriStop": "2004-03-16T16:48:28.8819193+01:00",
      "SatEnabled": false,
      "SatStart": "2019-03-22T16:48:28.8819193+01:00",
      "SatStop": "2011-09-17T16:48:28.8819193+02:00",
      "SunEnabled": true,
      "SunStart": "2019-06-21T16:48:28.8819193+02:00",
      "SunStop": "2010-04-05T16:48:28.8819193+02:00"
    },
    "Widget": {
      "AutoFaqEnabled": true,
      "AutoFaqCategory": {},
      "PreFormEnabled": true,
      "PreFormMessage": "repudiandae",
      "RequiredFields": "Company",
      "PostFormEnabled": true,
      "PostFormHeader": "mollitia",
      "PostFormMessage": "natus",
      "PostTranscriptEnabled": true,
      "LanguageIsoCode": "ipsam",
      "Theme": "Classic",
      "Color": "non",
      "Font": "dolorem",
      "ShowLogo": false,
      "ShowAgentPhoto": false,
      "WelcomeTitle": "et",
      "WelcomeMessage": "deserunt",
      "OfflineHeader": "suscipit",
      "OfflineMessage": "cumque",
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
          "Reason": "extend leading-edge applications"
        },
        "FieldType": "System.Int32",
        "FieldLength": 439
      }
    }
  }
]
```