---
title: PATCH ChatTopic/{id}
id: v1ChatTopicEntity_PatchChatTopicEntity
---

# PATCH ChatTopic/{id}

```http
PATCH /api/v1/ChatTopic/{id}
```

Update a ChatTopicEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.IChatAgent} service SaveChatTopicEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ChatTopicEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/ChatTopic/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes string 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | string | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | string | The property names to modify.  "/users/0/email", "/users/-", |
| value | object | New/Replaced value - string or object. |


## Response: object

Chat topics define who is assigned, when the channel is open for business, and look of the chat widget.



ChatTopicEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ChatTopicEntity  updated. |
| 404 | ChatTopicEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because ChatTopicEntity has changed since the requested If-Unmodified-Since timestamp. |

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
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/ChatTopic/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "distinctio",
    "value": {
      "value1": {
        "PrimaryKey": 9181,
        "EntityName": "sale",
        "saleId": 9181,
        "contactId": 1531,
        "name": "Trantow Inc and Sons"
      },
      "value2": {
        "PrimaryKey": 5588,
        "EntityName": "person",
        "personId": 5588,
        "fullName": "Alice Mosciski"
      }
    }
  },
  {
    "op": "add",
    "path": "distinctio",
    "value": {
      "value1": {
        "PrimaryKey": 9181,
        "EntityName": "sale",
        "saleId": 9181,
        "contactId": 1531,
        "name": "Trantow Inc and Sons"
      },
      "value2": {
        "PrimaryKey": 5588,
        "EntityName": "person",
        "personId": 5588,
        "fullName": "Alice Mosciski"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 ChatTopicEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 855,
  "Name": "Jones, Stark and Botsford",
  "Description": "Advanced leading edge success",
  "WelcomeMessage": "beatae",
  "Language": {
    "Id": 493,
    "Value": "et",
    "Tooltip": "aperiam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 123
      }
    }
  },
  "LastAccept": "2003-11-15T15:05:41.7800055+01:00",
  "SecondsPrAccept": 367,
  "AlertRecipient": "sed",
  "AlertTemplate": {
    "ReplyTemplateId": 292,
    "Name": "Powlowski, Morar and Spencer",
    "Description": "Mandatory attitude-oriented superstructure",
    "FolderId": 709
  },
  "CollectConsent": true,
  "BadgeHeader": "sunt",
  "CustomQueueTextEnabled": true,
  "CustomQueueText": "aliquid",
  "WarnNewChatMinutes": 852,
  "WarnManagerNewChatMinutes": 147,
  "TicketEnabled": true,
  "TicketCategory": {
    "Id": 739,
    "Value": "ut",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 748
      }
    }
  },
  "TicketPriority": {
    "Id": 230,
    "Value": "sit",
    "Tooltip": "quibusdam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 955
      }
    }
  },
  "OpeningHoursEnabled": true,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": true,
    "MonStart": "qui",
    "MonStop": "sit",
    "TueEnabled": false,
    "TueStart": "nobis",
    "TueStop": "similique",
    "WedEnabled": true,
    "WedStart": "ab",
    "WedStop": "et",
    "ThuEnabled": false,
    "ThuStart": "asperiores",
    "ThuStop": "et",
    "FriEnabled": true,
    "FriStart": "doloribus",
    "FriStop": "aut",
    "SatEnabled": false,
    "SatStart": "aperiam",
    "SatStop": "nemo",
    "SunEnabled": true,
    "SunStart": "qui",
    "SunStop": "placeat",
    "UseLunchHours": true,
    "LunchStart": "facilis",
    "LunchStop": "placeat"
  },
  "Widget": {
    "AutoFaqEnabled": false,
    "AutoFaqCategory": {},
    "PreFormEnabled": false,
    "PreFormMessage": "veniam",
    "RequiredFields": "Company",
    "PostFormEnabled": true,
    "PostFormHeader": "quia",
    "PostFormMessage": "ipsum",
    "PostTranscriptEnabled": false,
    "LanguageIsoCode": "autem",
    "Size": "Large",
    "Theme": "Classic",
    "Color": "qui",
    "Font": "est",
    "LogoEnabled": true,
    "LogoBlobId": 261,
    "LogoName": "Braun-Emard",
    "ShowAgentPhoto": false,
    "WelcomeTitle": "qui",
    "WelcomeMessage": "tempora",
    "OfflineHeader": "laboriosam",
    "OfflineMessage": "quidem",
    "OfflineFields": "Company",
    "UseAgentFirstname": false
  },
  "BotEnabled": true,
  "BotSettings": {
    "BotName": "Quigley Inc and Sons",
    "BotRegisterScriptId": 635,
    "BotSessionCreatedScriptId": 882,
    "BotSessionChangedScriptId": 321,
    "BotMessageReceivedScriptId": 35
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
      "FieldLength": 81
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```