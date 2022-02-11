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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "repudiandae",
    "value": {
      "value1": {
        "PrimaryKey": 6766,
        "EntityName": "sale",
        "saleId": 6766,
        "contactId": 5433,
        "name": "Boyer, Kuhlman and Sanford"
      },
      "value2": {
        "PrimaryKey": 5727,
        "EntityName": "sale",
        "saleId": 5727,
        "contactId": 9733,
        "name": "Stroman-Bode"
      }
    }
  },
  {
    "op": "add",
    "path": "repudiandae",
    "value": {
      "value1": {
        "PrimaryKey": 6766,
        "EntityName": "sale",
        "saleId": 6766,
        "contactId": 5433,
        "name": "Boyer, Kuhlman and Sanford"
      },
      "value2": {
        "PrimaryKey": 5727,
        "EntityName": "sale",
        "saleId": 5727,
        "contactId": 9733,
        "name": "Stroman-Bode"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 ChatSessionEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 779,
  "TopicId": 339,
  "User": {
    "AssociateId": 810,
    "Name": "Lueilwitz, Ryan and Goyette",
    "PersonId": 930,
    "Rank": 216,
    "Tooltip": "nobis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 431,
    "FullName": "Dortha Turner",
    "FormalName": "McDermott-Murray",
    "Deleted": false,
    "EjUserId": 910,
    "UserName": "O'Hara-Zulauf",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 369
      }
    }
  },
  "Person": {
    "Position": "non",
    "PersonId": 813,
    "Mrmrs": "minima",
    "Firstname": "Keon",
    "Lastname": "Prohaska",
    "MiddleName": "Boyer-Koelpin",
    "Title": "necessitatibus",
    "Description": "Advanced systemic conglomeration",
    "Email": "vincenzo_hickle@brownfeil.uk",
    "FullName": "Stephon VonRueden",
    "DirectPhone": "367.842.8408 x70706",
    "FormalName": "Bogan, Halvorson and Roberts",
    "CountryId": 542,
    "ContactId": 46,
    "ContactName": "Skiles Inc and Sons",
    "Retired": 302,
    "Rank": 665,
    "ActiveInterests": 880,
    "ContactDepartment": "",
    "ContactCountryId": 188,
    "ContactOrgNr": "913693",
    "FaxPhone": "1-352-724-6503 x17154",
    "MobilePhone": "333.213.8276 x673",
    "ContactPhone": "(226)852-6845 x5136",
    "AssociateName": "Wisozk, Waelchi and O'Reilly",
    "AssociateId": 160,
    "UsePersonAddress": true,
    "ContactFax": "possimus",
    "Kanafname": "et",
    "Kanalname": "voluptatibus",
    "Post1": "ab",
    "Post2": "excepturi",
    "Post3": "debitis",
    "EmailName": "ike@walsh.com",
    "ContactFullName": "Darrel Schimmel",
    "ActiveErpLinks": 424,
    "TicketPriorityId": 910,
    "SupportLanguageId": 798,
    "SupportAssociateId": 716,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 310
      }
    }
  },
  "CustomerAlias": "at",
  "CustomerHost": "nihil",
  "CustomerName": "Rohan LLC",
  "CustomerEmail": "rosalinda.pagac@ratkewhite.co.uk",
  "CustomerPhone": "680-507-6684 x47416",
  "CustomerConsented": true,
  "CustomerCompanyName": "Ritchie-Bradtke",
  "Status": "Closed",
  "FirstMessage": "ipsum",
  "LastMessage": "est",
  "WhenRequested": "2008-10-19T18:25:50.0485682+02:00",
  "WhenStarted": "1996-04-12T18:25:50.0485682+02:00",
  "WhenEnded": "2014-07-12T18:25:50.0485682+02:00",
  "WhenIdle": "2020-09-10T18:25:50.0485682+02:00",
  "WhenFetched": "2013-09-24T18:25:50.0485682+02:00",
  "SessionKey": "vitae",
  "InitialQueuePos": 476,
  "AlertLevel": 900,
  "Rank": 963,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 101,
    "Name": "Moen, Greenfelder and Balistreri",
    "OrgNr": "463181",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ut",
    "DirectPhone": "1-453-518-7304 x7210",
    "AssociateId": 587,
    "CountryId": 686,
    "EmailAddress": "elta@altenwerthwhite.ca",
    "Kananame": "facilis",
    "EmailAddressName": "pietro@binslemke.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Kevon Johnston",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "qui",
    "FullName": "Lucile Ondricka",
    "IsOwnerContact": true,
    "ActiveErpLinks": 108,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 485
      }
    }
  },
  "Project": {
    "ProjectId": 301,
    "Name": "Kertzmann-Effertz",
    "Description": "Monitored grid-enabled throughput",
    "URL": "http://www.example.com/",
    "Type": "aut",
    "AssociateId": 261,
    "AssociateFullName": "Trey Koss",
    "TypeId": 759,
    "Updated": "2007-06-13T18:25:50.0495639+02:00",
    "StatusId": 416,
    "Status": "omnis",
    "TextId": 818,
    "PublishTo": "2003-08-15T18:25:50.0495639+02:00",
    "PublishFrom": "2018-03-01T18:25:50.0495639+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1291415",
    "ActiveErpLinks": 629,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 909
      }
    }
  },
  "Sale": {
    "ContactName": "Homenick-Jacobs",
    "SaleDate": "2003-09-30T18:25:50.0495639+02:00",
    "SaleId": 698,
    "Probability": 348,
    "Title": "ea",
    "Amount": 7342.9619999999995,
    "Currency": "explicabo",
    "ProjectName": "Walsh-Klocko",
    "AssociateFullName": "Zoie Langosh Sr.",
    "Description": "Team-oriented bi-directional website",
    "Status": "Lost",
    "WeightedAmount": 26623.329999999998,
    "ProjectId": 733,
    "EarningPercent": 6666.018,
    "Earning": 10868.712,
    "ContactId": 71,
    "AssociateId": 736,
    "PersonId": 39,
    "SaleTypeId": 587,
    "SaleTypeName": "Huels-Ernser",
    "PersonFullName": "Olga Terry",
    "Completed": "Completed",
    "ActiveErpLinks": 278,
    "NextDueDate": "2000-09-08T18:25:50.0505631+02:00",
    "Number": "455415",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 722
      }
    }
  },
  "Ticket": {
    "TicketId": 205,
    "Title": "assumenda",
    "CreatedAt": "2001-12-28T18:25:50.0505631+01:00",
    "LastChanged": "2010-11-10T18:25:50.0505631+01:00",
    "ReadByOwner": "2018-10-12T18:25:50.0505631+02:00",
    "ReadByCustomer": "1999-05-31T18:25:50.0505631+02:00",
    "FirstReadByUser": "2017-06-24T18:25:50.0505631+02:00",
    "Activate": "2005-09-13T18:25:50.0505631+02:00",
    "ClosedAt": "1996-09-13T18:25:50.0505631+02:00",
    "RepliedAt": "2001-02-03T18:25:50.0505631+01:00",
    "AlertTimeout": "2007-04-20T18:25:50.0505631+02:00",
    "Deadline": "2003-07-21T18:25:50.0505631+02:00",
    "CreatedBy": 452,
    "CreatedByName": "Gorczany-Rohan",
    "Author": "est",
    "OwnedBy": 159,
    "OwnedByName": "Fisher, Hettinger and Pfannerstill",
    "Category": 287,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 239,
    "PriorityName": "Koss-Bosco",
    "BaseStatus": "Active",
    "TicketStatus": 287,
    "TicketStatusDisplayValue": "aut",
    "Origin": "AutoGenerated",
    "CustId": 136,
    "PersonFirstname": "Eliezer",
    "PersonMiddleName": "Nader LLC",
    "PersonLastname": "O'Hara",
    "PersonFullname": "harum",
    "AlertLevel": 642,
    "ConnectId": 14,
    "ReadStatus": "Green",
    "TimeToReply": 695,
    "RealTimeToReply": 828,
    "TimeToClose": 426,
    "RealTimeToClose": 136,
    "TimeSpentInternally": 296,
    "TimeSpentExternally": 736,
    "TimeSpentQueue": 645,
    "RealTimeSpentInternally": 989,
    "RealTimeSpentExternally": 22,
    "RealTimeSpentQueue": 965,
    "HasAttachment": false,
    "NumReplies": 85,
    "NumMessages": 443,
    "FromAddress": "debitis",
    "ContactId": 451,
    "ContactName": "Kuphal, Yundt and Kovacek",
    "OwnedByAssociateId": 830,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 979
      }
    }
  },
  "TransferTo": {
    "AssociateId": 744,
    "Name": "Daugherty, Kuvalis and Kohler",
    "PersonId": 610,
    "Rank": 725,
    "Tooltip": "earum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 413,
    "FullName": "Ethelyn Schinner",
    "FormalName": "Nitzsche Group",
    "Deleted": false,
    "EjUserId": 47,
    "UserName": "Emard LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 545
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
      "FieldType": "System.Int32",
      "FieldLength": 211
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```