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
POST /api/v1/Agents/Chat/GetChatTopicEntity?chatTopicEntityId=25
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
POST /api/v1/Agents/Chat/GetChatTopicEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 346,
  "Name": "Hoppe-Terry",
  "Description": "Cloned bandwidth-monitored approach",
  "WelcomeMessage": "dolor",
  "Language": {
    "Id": 846,
    "Value": "rerum",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 922
      }
    }
  },
  "LastAccept": "1996-08-24T16:48:28.8799193+02:00",
  "SecondsPrAccept": 405,
  "AlertRecipient": "et",
  "AlertTemplate": {
    "ReplyTemplateId": 570,
    "Name": "Ondricka-Considine",
    "Description": "Multi-channelled interactive success",
    "FolderId": 459
  },
  "Flags": "CollectConsent",
  "BadgeHeader": "quibusdam",
  "CustomQueueText": "mollitia",
  "WarnNewChatSeconds": 479,
  "WarnManagerNewChatSeconds": 74,
  "TicketEnabled": false,
  "TicketCategory": {
    "Id": 98,
    "Value": "aut",
    "Tooltip": "id",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 678
      }
    }
  },
  "TicketPriority": {
    "Id": 352,
    "Value": "rerum",
    "Tooltip": "dolores",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 694
      }
    }
  },
  "OpeningHoursEnabled": true,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": true,
    "MonStart": "2015-05-28T16:48:28.8799193+02:00",
    "MonStop": "1995-08-05T16:48:28.8799193+02:00",
    "TueEnabled": false,
    "TueStart": "2006-08-03T16:48:28.8799193+02:00",
    "TueStop": "2016-08-30T16:48:28.8799193+02:00",
    "WedEnabled": true,
    "WedStart": "1997-05-01T16:48:28.8799193+02:00",
    "WedStop": "1998-01-23T16:48:28.8799193+01:00",
    "ThuEnabled": true,
    "ThuStart": "1994-04-17T16:48:28.8799193+02:00",
    "ThuStop": "2012-10-03T16:48:28.8799193+02:00",
    "FriEnabled": false,
    "FriStart": "1999-01-19T16:48:28.8799193+01:00",
    "FriStop": "2009-09-25T16:48:28.8799193+02:00",
    "SatEnabled": false,
    "SatStart": "1998-09-17T16:48:28.8799193+02:00",
    "SatStop": "2010-06-06T16:48:28.8799193+02:00",
    "SunEnabled": true,
    "SunStart": "1996-02-23T16:48:28.8799193+01:00",
    "SunStop": "1997-09-08T16:48:28.8799193+02:00"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": true,
    "PreFormMessage": "aspernatur",
    "RequiredFields": "Company",
    "PostFormEnabled": true,
    "PostFormHeader": "quo",
    "PostFormMessage": "culpa",
    "PostTranscriptEnabled": false,
    "LanguageIsoCode": "totam",
    "Theme": "Classic",
    "Color": "nesciunt",
    "Font": "voluptatum",
    "ShowLogo": true,
    "ShowAgentPhoto": true,
    "WelcomeTitle": "et",
    "WelcomeMessage": "eligendi",
    "OfflineHeader": "voluptas",
    "OfflineMessage": "fugit",
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
      "FieldLength": 985
    }
  }
}
```