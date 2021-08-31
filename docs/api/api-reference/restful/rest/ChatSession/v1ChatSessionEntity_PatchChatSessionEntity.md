---
title: PATCH ChatSession/{id}
id: v1ChatSessionEntity_PatchChatSessionEntity
---

# PATCH ChatSession/{id}

```http
PATCH /api/v1/ChatSession/{id}
```

Update a ChatSessionEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

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



Calls the {SuperOffice.CRM.Services.IChatAgent} service SaveChatSessionEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ChatSessionEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/ChatSession/{id}?$select=name,department,category/id
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

Chat sessions belong to a chat topic, and contain messages to/from users



ChatSessionEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ChatSessionEntity  updated. |
| 404 | ChatSessionEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because ChatSessionEntity has changed since the requested If-Unmodified-Since timestamp. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatSessionId | int32 | The primary key (auto-incremented) |
| TopicId | int32 | The reference to the associated chat topic. |
| User |  | User agent handling this session |
| Person |  | Customer person in this session - could be empty if we don't know exactly. |
| CustomerAlias | string | The alias for the customer. |
| CustomerHost | string | The hostname or IP address for the customer. |
| CustomerName | string | The name of customer, if provided |
| CustomerEmail | string | The email address of the customer, if provided |
| CustomerPhone | string | The phone number of the customer, if provided |
| CustomerConsented | bool | The customer consented when starting the session |
| CustomerCompanyName | string | The name of the customers company, if provided |
| Status | string | Enum indicating the status for the session (pending, active, closed, etc). |
| FirstMessage | string | A copy of the first message in the chat session |
| LastMessage | string | A copy of the last message in the chat session |
| WhenRequested | date-time | When the session was requested by the customer. |
| WhenStarted | date-time | When the session was accepted by a user. |
| WhenEnded | date-time | When the session was ended. |
| WhenIdle | date-time | The last time anyone sent a message for this session. |
| WhenFetched | date-time | The last time the customer&amp;apos;s client refetched the data. Used to detect &amp;apos;dead&amp;apos; session. |
| SessionKey | string | Key used to authenticate the session. |
| InitialQueuePos | int32 | The initial queue pos (i.e. the number of pending sessions + 1) when the session was requested. |
| AlertLevel | int32 | The alert level for this chat session. |
| Rank | int32 | Lowest possible unique number for active sessions for user. User for color index. Starting at 1. |
| Flags | string | Various flags for the chat session |
| Contact |  | Contact this session is connected to - could be empty if we don't know exactly. |
| Project |  | Project the session is connectedto - could be empty if we don't know exactly. |
| Sale |  | Sale the session is connected to - could be empty if we don't know exactly. |
| Ticket |  | Ticket the session is connected to - could be empty if we don't know exactly. |
| TransferTo |  | User agent that has a pending transfer of the chat session |
| ChatbotIsActive | bool | Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/ChatSession/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "sit",
    "value": {
      "value1": {
        "PrimaryKey": 3215,
        "EntityName": "person",
        "personId": 3215,
        "fullName": "Jaren Volkman"
      },
      "value2": {
        "PrimaryKey": 3406,
        "EntityName": "sale",
        "saleId": 3406,
        "contactId": 1096,
        "name": "Bayer, Davis and Schuster"
      }
    }
  },
  {
    "op": "add",
    "path": "sit",
    "value": {
      "value1": {
        "PrimaryKey": 3215,
        "EntityName": "person",
        "personId": 3215,
        "fullName": "Jaren Volkman"
      },
      "value2": {
        "PrimaryKey": 3406,
        "EntityName": "sale",
        "saleId": 3406,
        "contactId": 1096,
        "name": "Bayer, Davis and Schuster"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 ChatSessionEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 182,
  "TopicId": 369,
  "User": {
    "AssociateId": 885,
    "Name": "Kulas LLC",
    "PersonId": 298,
    "Rank": 83,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 665,
    "FullName": "Roslyn Romaguera",
    "FormalName": "McGlynn-Zulauf",
    "Deleted": false,
    "EjUserId": 364,
    "UserName": "Kuhlman-Herman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 81
      }
    }
  },
  "Person": {
    "Position": "sed",
    "PersonId": 294,
    "Mrmrs": "autem",
    "Firstname": "Krystal",
    "Lastname": "Osinski",
    "MiddleName": "Roob Inc and Sons",
    "Title": "quia",
    "Description": "Polarised encompassing database",
    "Email": "cheyanne@kovacek.name",
    "FullName": "Darrell Cole",
    "DirectPhone": "1-471-608-1748 x872",
    "FormalName": "Block-Botsford",
    "CountryId": 687,
    "ContactId": 999,
    "ContactName": "Kling-Schiller",
    "Retired": 380,
    "Rank": 23,
    "ActiveInterests": 136,
    "ContactDepartment": "",
    "ContactCountryId": 173,
    "ContactOrgNr": "1113237",
    "FaxPhone": "137-132-6446 x283",
    "MobilePhone": "(324)773-1287",
    "ContactPhone": "(617)847-1733 x5058",
    "AssociateName": "Hodkiewicz LLC",
    "AssociateId": 213,
    "UsePersonAddress": true,
    "ContactFax": "ut",
    "Kanafname": "enim",
    "Kanalname": "nulla",
    "Post1": "veniam",
    "Post2": "sit",
    "Post3": "recusandae",
    "EmailName": "adrain@okondaniel.info",
    "ContactFullName": "Adell Treutel",
    "ActiveErpLinks": 50,
    "TicketPriorityId": 110,
    "SupportLanguageId": 67,
    "SupportAssociateId": 687,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 974
      }
    }
  },
  "CustomerAlias": "perferendis",
  "CustomerHost": "sit",
  "CustomerName": "Ruecker, Collier and Heathcote",
  "CustomerEmail": "christine.reichert@hoppeschaden.co.uk",
  "CustomerPhone": "101-284-8130 x325",
  "CustomerConsented": false,
  "CustomerCompanyName": "Swaniawski-Hagenes",
  "Status": "Closed",
  "FirstMessage": "est",
  "LastMessage": "omnis",
  "WhenRequested": "2014-10-26T15:05:41.6600023+01:00",
  "WhenStarted": "2012-02-09T15:05:41.6600023+01:00",
  "WhenEnded": "2013-02-19T15:05:41.6600023+01:00",
  "WhenIdle": "2011-09-25T15:05:41.6600023+02:00",
  "WhenFetched": "2003-10-03T15:05:41.6600023+02:00",
  "SessionKey": "quis",
  "InitialQueuePos": 339,
  "AlertLevel": 666,
  "Rank": 323,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 239,
    "Name": "Conroy-Reynolds",
    "OrgNr": "1558668",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "illum",
    "DirectPhone": "1-660-124-7237",
    "AssociateId": 429,
    "CountryId": 533,
    "EmailAddress": "ray@white.ca",
    "Kananame": "voluptatem",
    "EmailAddressName": "bert@howe.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Laverne Doyle IV",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "aspernatur",
    "FullName": "Karley Oberbrunner",
    "IsOwnerContact": true,
    "ActiveErpLinks": 180,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 89
      }
    }
  },
  "Project": {
    "ProjectId": 331,
    "Name": "Macejkovic-Purdy",
    "Description": "Configurable eco-centric throughput",
    "URL": "http://www.example.com/",
    "Type": "minima",
    "AssociateId": 588,
    "AssociateFullName": "Stevie Grimes II",
    "TypeId": 592,
    "Updated": "2002-02-21T15:05:41.6610022+01:00",
    "StatusId": 798,
    "Status": "asperiores",
    "TextId": 711,
    "PublishTo": "2003-11-03T15:05:41.6610022+01:00",
    "PublishFrom": "2018-01-18T15:05:41.6610022+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "875100",
    "ActiveErpLinks": 982,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "whiteboard 24/365 vortals"
        },
        "FieldType": "System.String",
        "FieldLength": 479
      }
    }
  },
  "Sale": {
    "ContactName": "Bergnaum, Marks and Rosenbaum",
    "SaleDate": "2002-12-26T15:05:41.6610022+01:00",
    "SaleId": 315,
    "Probability": 175,
    "Title": "fugiat",
    "Amount": 28970.696,
    "Currency": "pariatur",
    "ProjectName": "Corkery Inc and Sons",
    "AssociateFullName": "Ms. George Mueller",
    "Description": "User-centric object-oriented help-desk",
    "Status": "Lost",
    "WeightedAmount": 9154.4139999999989,
    "ProjectId": 121,
    "EarningPercent": 8580.892,
    "Earning": 4049.1279999999997,
    "ContactId": 56,
    "AssociateId": 810,
    "PersonId": 97,
    "SaleTypeId": 892,
    "SaleTypeName": "Lueilwitz LLC",
    "PersonFullName": "Delaney Aufderhar",
    "Completed": "Completed",
    "ActiveErpLinks": 116,
    "NextDueDate": "2008-04-01T15:05:41.6620022+02:00",
    "Number": "1337171",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 596
      }
    }
  },
  "Ticket": {
    "TicketId": 237,
    "Title": "eaque",
    "CreatedAt": "2019-06-18T15:05:41.6620022+02:00",
    "LastChanged": "2018-10-12T15:05:41.6620022+02:00",
    "ReadByOwner": "2021-06-19T15:05:41.6620022+02:00",
    "ReadByCustomer": "1998-09-30T15:05:41.6620022+02:00",
    "FirstReadByUser": "2004-05-19T15:05:41.6620022+02:00",
    "Activate": "2001-02-20T15:05:41.6620022+01:00",
    "ClosedAt": "2008-01-26T15:05:41.6620022+01:00",
    "RepliedAt": "1997-11-25T15:05:41.6620022+01:00",
    "AlertTimeout": "2014-01-13T15:05:41.6620022+01:00",
    "Deadline": "2004-02-27T15:05:41.6620022+01:00",
    "CreatedBy": 410,
    "CreatedByName": "Carter LLC",
    "Author": "aperiam",
    "OwnedBy": 821,
    "OwnedByName": "Russel Group",
    "Category": 990,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 611,
    "PriorityName": "Cole Inc and Sons",
    "BaseStatus": "Active",
    "TicketStatus": 619,
    "TicketStatusDisplayValue": "doloribus",
    "Origin": "AutoGenerated",
    "CustId": 40,
    "PersonFirstname": "Elenora",
    "PersonMiddleName": "Reinger Group",
    "PersonLastname": "Tillman",
    "PersonFullname": "molestiae",
    "AlertLevel": 677,
    "ConnectId": 868,
    "ReadStatus": "Green",
    "TimeToReply": 742,
    "RealTimeToReply": 316,
    "TimeToClose": 707,
    "RealTimeToClose": 307,
    "TimeSpentInternally": 705,
    "TimeSpentExternally": 130,
    "TimeSpentQueue": 84,
    "RealTimeSpentInternally": 175,
    "RealTimeSpentExternally": 484,
    "RealTimeSpentQueue": 304,
    "HasAttachment": true,
    "NumReplies": 50,
    "NumMessages": 50,
    "FromAddress": "dolores",
    "ContactId": 742,
    "ContactName": "Kuvalis, Lesch and Thiel",
    "OwnedByAssociateId": 880,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "seize visionary partnerships"
        },
        "FieldType": "System.String",
        "FieldLength": 748
      }
    }
  },
  "TransferTo": {
    "AssociateId": 153,
    "Name": "Hilll-Botsford",
    "PersonId": 919,
    "Rank": 612,
    "Tooltip": "exercitationem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 829,
    "FullName": "Arturo Lemke",
    "FormalName": "Labadie, Ernser and Marvin",
    "Deleted": true,
    "EjUserId": 970,
    "UserName": "Kulas, Conroy and McDermott",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "recontextualize dot-com content"
        },
        "FieldType": "System.Int32",
        "FieldLength": 337
      }
    }
  },
  "ChatbotIsActive": true,
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
      "FieldLength": 936
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```