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
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/ChatSession/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "aut",
    "value": {
      "value1": {
        "PrimaryKey": 1211,
        "EntityName": "person",
        "personId": 1211,
        "fullName": "Milan Hilpert"
      },
      "value2": {
        "PrimaryKey": 7172,
        "EntityName": "person",
        "personId": 7172,
        "fullName": "Newell Howe II"
      }
    }
  },
  {
    "op": "add",
    "path": "aut",
    "value": {
      "value1": {
        "PrimaryKey": 1211,
        "EntityName": "person",
        "personId": 1211,
        "fullName": "Milan Hilpert"
      },
      "value2": {
        "PrimaryKey": 7172,
        "EntityName": "person",
        "personId": 7172,
        "fullName": "Newell Howe II"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 ChatSessionEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 946,
  "TopicId": 188,
  "User": {
    "AssociateId": 866,
    "Name": "Johnston LLC",
    "PersonId": 841,
    "Rank": 395,
    "Tooltip": "corrupti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 371,
    "FullName": "Dayna Conroy",
    "FormalName": "Champlin, Durgan and Kihn",
    "Deleted": false,
    "EjUserId": 516,
    "UserName": "Howell Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "engage cross-platform content"
        },
        "FieldType": "System.Int32",
        "FieldLength": 2
      }
    }
  },
  "Person": {
    "Position": "in",
    "PersonId": 766,
    "Mrmrs": "sunt",
    "Firstname": "Estell",
    "Lastname": "Davis",
    "MiddleName": "McGlynn LLC",
    "Title": "et",
    "Description": "Fundamental discrete alliance",
    "Email": "cynthia.goyette@kris.uk",
    "FullName": "Phoebe Padberg",
    "DirectPhone": "1-271-834-0884",
    "FormalName": "Heathcote Group",
    "CountryId": 168,
    "ContactId": 860,
    "ContactName": "Weber LLC",
    "Retired": 52,
    "Rank": 894,
    "ActiveInterests": 21,
    "ContactDepartment": "",
    "ContactCountryId": 371,
    "ContactOrgNr": "814481",
    "FaxPhone": "1-478-282-5067",
    "MobilePhone": "(537)207-6886",
    "ContactPhone": "1-724-367-1034",
    "AssociateName": "Bins, Wisozk and Feest",
    "AssociateId": 68,
    "UsePersonAddress": false,
    "ContactFax": "omnis",
    "Kanafname": "voluptates",
    "Kanalname": "quasi",
    "Post1": "ullam",
    "Post2": "velit",
    "Post3": "earum",
    "EmailName": "marjolaine@feilmills.com",
    "ContactFullName": "Kyra Schumm",
    "ActiveErpLinks": 556,
    "TicketPriorityId": 549,
    "SupportLanguageId": 876,
    "SupportAssociateId": 921,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 873
      }
    }
  },
  "CustomerAlias": "rerum",
  "CustomerHost": "aut",
  "CustomerName": "Bradtke Inc and Sons",
  "CustomerEmail": "rebeca@schroeder.uk",
  "CustomerPhone": "1-115-674-4624 x701",
  "CustomerConsented": false,
  "CustomerCompanyName": "Prohaska, Rau and Dicki",
  "Status": "Closed",
  "FirstMessage": "ipsam",
  "LastMessage": "recusandae",
  "WhenRequested": "2016-04-17T09:40:58.7253762+02:00",
  "WhenStarted": "2005-04-02T09:40:58.7253762+02:00",
  "WhenEnded": "2009-07-14T09:40:58.7253762+02:00",
  "WhenIdle": "1994-03-19T09:40:58.7253762+01:00",
  "WhenFetched": "1999-10-08T09:40:58.7253762+02:00",
  "SessionKey": "consequuntur",
  "InitialQueuePos": 204,
  "AlertLevel": 609,
  "Rank": 147,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 746,
    "Name": "Bernhard, Mohr and Terry",
    "OrgNr": "1198705",
    "Department": "repurpose back-end action-items",
    "URL": "http://www.example.com/",
    "City": "perferendis",
    "DirectPhone": "710-176-2424 x134",
    "AssociateId": 687,
    "CountryId": 467,
    "EmailAddress": "douglas@torphy.co.uk",
    "Kananame": "harum",
    "EmailAddressName": "elza@schimmel.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Rigoberto Larkin",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "unde",
    "FullName": "Benedict Bartoletti",
    "IsOwnerContact": true,
    "ActiveErpLinks": 826,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 502
      }
    }
  },
  "Project": {
    "ProjectId": 601,
    "Name": "Kessler-Schmeler",
    "Description": "Devolved multimedia intranet",
    "URL": "http://www.example.com/",
    "Type": "aut",
    "AssociateId": 179,
    "AssociateFullName": "Freida McCullough",
    "TypeId": 565,
    "Updated": "1994-02-28T09:40:58.7263709+01:00",
    "StatusId": 883,
    "Status": "sapiente",
    "TextId": 36,
    "PublishTo": "2006-05-16T09:40:58.7263709+02:00",
    "PublishFrom": "1998-04-15T09:40:58.7263709+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "669569",
    "ActiveErpLinks": 995,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 269
      }
    }
  },
  "Sale": {
    "ContactName": "Kunze-Kihn",
    "SaleDate": "1999-02-23T09:40:58.7263709+01:00",
    "SaleId": 747,
    "Probability": 35,
    "Title": "accusamus",
    "Amount": 8963.24,
    "Currency": "unde",
    "ProjectName": "Corwin-Renner",
    "AssociateFullName": "Lenore Davis",
    "Description": "Implemented interactive alliance",
    "Status": "Lost",
    "WeightedAmount": 3911.232,
    "ProjectId": 429,
    "EarningPercent": 22918.942,
    "Earning": 22530.326,
    "ContactId": 664,
    "AssociateId": 966,
    "PersonId": 800,
    "SaleTypeId": 420,
    "SaleTypeName": "Kertzmann, Green and Jacobson",
    "PersonFullName": "Marianna Pagac",
    "Completed": "Completed",
    "ActiveErpLinks": 564,
    "NextDueDate": "1998-04-26T09:40:58.7263709+02:00",
    "Number": "855646",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 488
      }
    }
  },
  "Ticket": {
    "TicketId": 145,
    "Title": "et",
    "CreatedAt": "2012-11-06T09:40:58.7273707+01:00",
    "LastChanged": "2009-11-09T09:40:58.7273707+01:00",
    "ReadByOwner": "1998-12-21T09:40:58.7273707+01:00",
    "ReadByCustomer": "2011-06-10T09:40:58.7273707+02:00",
    "FirstReadByUser": "1998-11-10T09:40:58.7273707+01:00",
    "Activate": "2018-08-30T09:40:58.7273707+02:00",
    "ClosedAt": "2017-05-18T09:40:58.7273707+02:00",
    "RepliedAt": "2013-01-24T09:40:58.7273707+01:00",
    "AlertTimeout": "2019-04-08T09:40:58.7273707+02:00",
    "Deadline": "2001-08-27T09:40:58.7273707+02:00",
    "CreatedBy": 89,
    "CreatedByName": "Bernier Group",
    "Author": "atque",
    "OwnedBy": 184,
    "OwnedByName": "Zieme Inc and Sons",
    "Category": 56,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 253,
    "BaseStatus": "Active",
    "TicketStatus": 538,
    "Origin": "AutoGenerated",
    "CustId": 718,
    "CustFirstname": "Bianka",
    "CustMiddleName": "Borer, Frami and Marvin",
    "CustLastname": "Wolf",
    "AlertLevel": 62,
    "ConnectId": 494,
    "ReadStatus": "Green",
    "TimeToReply": 992,
    "RealTimeToReply": 85,
    "TimeToClose": 475,
    "RealTimeToClose": 311,
    "TimeSpentInternally": 847,
    "TimeSpentExternally": 381,
    "TimeSpentQueue": 608,
    "RealTimeSpentInternally": 643,
    "RealTimeSpentExternally": 476,
    "RealTimeSpentQueue": 756,
    "HasAttachment": true,
    "NumReplies": 464,
    "NumMessages": 559,
    "FromAddress": "sequi",
    "CustFullname": "ratione",
    "TicketStatusDisplayValue": "pariatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "reinvent transparent schemas"
        },
        "FieldType": "System.Int32",
        "FieldLength": 25
      }
    }
  },
  "TransferTo": {
    "AssociateId": 589,
    "Name": "Konopelski, Lang and Brekke",
    "PersonId": 11,
    "Rank": 373,
    "Tooltip": "quos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 786,
    "FullName": "Emmalee Padberg",
    "FormalName": "Mohr Inc and Sons",
    "Deleted": false,
    "EjUserId": 555,
    "UserName": "Lynch Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 453
      }
    }
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
      "FieldLength": 671
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```