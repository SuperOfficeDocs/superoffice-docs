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
PATCH /api/v1/ChatTopic/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "sed",
    "value": {
      "value1": {
        "PrimaryKey": 5089,
        "EntityName": "sale",
        "saleId": 5089,
        "contactId": 9135,
        "name": "Willms-Medhurst"
      },
      "value2": {
        "PrimaryKey": 852,
        "EntityName": "sale",
        "saleId": 852,
        "contactId": 221,
        "name": "Dickinson Inc and Sons"
      }
    }
  },
  {
    "op": "add",
    "path": "sed",
    "value": {
      "value1": {
        "PrimaryKey": 5089,
        "EntityName": "sale",
        "saleId": 5089,
        "contactId": 9135,
        "name": "Willms-Medhurst"
      },
      "value2": {
        "PrimaryKey": 852,
        "EntityName": "sale",
        "saleId": 852,
        "contactId": 221,
        "name": "Dickinson Inc and Sons"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 ChatTopicEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 341,
  "Name": "Streich-Kunde",
  "Description": "Quality-focused regional hub",
  "WelcomeMessage": "qui",
  "Language": {
    "Id": 308,
    "Value": "rerum",
    "Tooltip": "molestiae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 782
      }
    }
  },
  "LastAccept": "2001-06-30T09:40:58.8403708+02:00",
  "SecondsPrAccept": 325,
  "AlertRecipient": "explicabo",
  "AlertTemplate": {
    "ReplyTemplateId": 608,
    "Name": "Gislason, Turner and Leannon",
    "Description": "Mandatory contextually-based frame",
    "FolderId": 722
  },
  "Flags": "CollectConsent",
  "BadgeHeader": "atque",
  "CustomQueueText": "quae",
  "WarnNewChatSeconds": 565,
  "WarnManagerNewChatSeconds": 763,
  "TicketEnabled": true,
  "TicketCategory": {
    "Id": 818,
    "Value": "iusto",
    "Tooltip": "ipsa",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 677
      }
    }
  },
  "TicketPriority": {
    "Id": 491,
    "Value": "id",
    "Tooltip": "iure",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 938
      }
    }
  },
  "OpeningHoursEnabled": true,
  "OpeningHours": {
    "TzLocation": {},
    "MonEnabled": true,
    "MonStart": "1999-09-06T09:40:58.8413726+02:00",
    "MonStop": "2013-11-18T09:40:58.8413726+01:00",
    "TueEnabled": true,
    "TueStart": "2019-02-21T09:40:58.8413726+01:00",
    "TueStop": "2020-04-05T09:40:58.8413726+02:00",
    "WedEnabled": false,
    "WedStart": "1995-09-02T09:40:58.8413726+02:00",
    "WedStop": "2015-05-10T09:40:58.8413726+02:00",
    "ThuEnabled": true,
    "ThuStart": "1999-12-12T09:40:58.8413726+01:00",
    "ThuStop": "2008-03-31T09:40:58.8413726+02:00",
    "FriEnabled": true,
    "FriStart": "2016-04-01T09:40:58.8413726+02:00",
    "FriStop": "2006-06-06T09:40:58.8413726+02:00",
    "SatEnabled": false,
    "SatStart": "2020-01-06T09:40:58.8413726+01:00",
    "SatStop": "1995-08-22T09:40:58.8413726+02:00",
    "SunEnabled": true,
    "SunStart": "2005-10-16T09:40:58.8413726+02:00",
    "SunStop": "1996-02-05T09:40:58.8413726+01:00"
  },
  "Widget": {
    "AutoFaqEnabled": true,
    "AutoFaqCategory": {},
    "PreFormEnabled": true,
    "PreFormMessage": "rerum",
    "RequiredFields": "Company",
    "PostFormEnabled": false,
    "PostFormHeader": "omnis",
    "PostFormMessage": "officiis",
    "PostTranscriptEnabled": true,
    "LanguageIsoCode": "iste",
    "Theme": "Classic",
    "Color": "unde",
    "Font": "ea",
    "ShowLogo": true,
    "ShowAgentPhoto": true,
    "WelcomeTitle": "qui",
    "WelcomeMessage": "eveniet",
    "OfflineHeader": "quisquam",
    "OfflineMessage": "ut",
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
      "FieldLength": 915
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```