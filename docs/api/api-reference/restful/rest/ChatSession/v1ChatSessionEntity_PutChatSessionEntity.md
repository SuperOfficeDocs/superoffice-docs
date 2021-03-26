---
title: PUT ChatSession/{id}
id: v1ChatSessionEntity_PutChatSessionEntity
---

# PUT ChatSession/{id}

```http
PUT /api/v1/ChatSession/{id}
```

Updates the existing ChatSessionEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ChatSessionEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/ChatSession/{id}?$select=name,department,category/id
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

The ChatSessionEntity to be saved. 

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


## Response: object

Chat sessions belong to a chat topic, and contain messages to/from users



ChatSessionEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ChatSessionEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/ChatSession/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 886,
  "TopicId": 420,
  "User": {
    "AssociateId": 555,
    "Name": "Hills LLC",
    "PersonId": 585,
    "Rank": 672,
    "Tooltip": "quae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 452,
    "FullName": "Bret Witting",
    "FormalName": "Greenfelder, Nicolas and Goyette",
    "Deleted": true,
    "EjUserId": 367,
    "UserName": "Boehm-Turner"
  },
  "Person": {
    "Position": "omnis",
    "PersonId": 546,
    "Mrmrs": "non",
    "Firstname": "Keaton",
    "Lastname": "Runolfsson",
    "MiddleName": "Bashirian Inc and Sons",
    "Title": "alias",
    "Description": "Profound radical open system",
    "Email": "orland.heaney@mitchellwuckert.ca",
    "FullName": "Mozelle Feest",
    "DirectPhone": "(305)833-5158",
    "FormalName": "Connelly Group",
    "CountryId": 282,
    "ContactId": 507,
    "ContactName": "Sauer-Cole",
    "Retired": 971,
    "Rank": 281,
    "ActiveInterests": 539,
    "ContactDepartment": "",
    "ContactCountryId": 591,
    "ContactOrgNr": "610409",
    "FaxPhone": "1-628-254-2438",
    "MobilePhone": "255-040-6414 x005",
    "ContactPhone": "1-768-444-0835 x3233",
    "AssociateName": "Stamm, Halvorson and West",
    "AssociateId": 537,
    "UsePersonAddress": false,
    "ContactFax": "sunt",
    "Kanafname": "enim",
    "Kanalname": "voluptas",
    "Post1": "odit",
    "Post2": "iste",
    "Post3": "sed",
    "EmailName": "joelle@runte.info",
    "ContactFullName": "Gwen Hammes",
    "ActiveErpLinks": 226,
    "TicketPriorityId": 24,
    "SupportLanguageId": 662,
    "SupportAssociateId": 299,
    "CategoryName": "VIP Customer"
  },
  "CustomerAlias": "ea",
  "CustomerHost": "suscipit",
  "CustomerName": "Cruickshank LLC",
  "CustomerEmail": "cleveland.koch@lowe.name",
  "CustomerPhone": "(701)775-0430",
  "CustomerConsented": true,
  "CustomerCompanyName": "Fadel-Hegmann",
  "Status": "Closed",
  "FirstMessage": "optio",
  "LastMessage": "molestiae",
  "WhenRequested": "2009-07-12T09:40:58.7033737+02:00",
  "WhenStarted": "2006-12-11T09:40:58.7033737+01:00",
  "WhenEnded": "2012-04-28T09:40:58.7033737+02:00",
  "WhenIdle": "2009-09-29T09:40:58.7033737+02:00",
  "WhenFetched": "2003-10-10T09:40:58.7033737+02:00",
  "SessionKey": "enim",
  "InitialQueuePos": 484,
  "AlertLevel": 309,
  "Rank": 652,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 199,
    "Name": "Kshlerin, Gleichner and Kessler",
    "OrgNr": "1474533",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "autem",
    "DirectPhone": "(770)408-8107 x5244",
    "AssociateId": 459,
    "CountryId": 643,
    "EmailAddress": "alverta_champlin@stiedemann.us",
    "Kananame": "a",
    "EmailAddressName": "emiliano.franecki@murray.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Florida Conroy",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "laboriosam",
    "FullName": "Brady Marquardt",
    "IsOwnerContact": false,
    "ActiveErpLinks": 637
  },
  "Project": {
    "ProjectId": 551,
    "Name": "Rice, Wyman and Hammes",
    "Description": "Adaptive foreground Graphic Interface",
    "URL": "http://www.example.com/",
    "Type": "sapiente",
    "AssociateId": 971,
    "AssociateFullName": "Carlo Erdman",
    "TypeId": 940,
    "Updated": "2020-10-23T09:40:58.7053405+02:00",
    "StatusId": 11,
    "Status": "voluptatibus",
    "TextId": 609,
    "PublishTo": "2010-04-23T09:40:58.7053405+02:00",
    "PublishFrom": "2004-06-13T09:40:58.7053405+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1812507",
    "ActiveErpLinks": 285
  },
  "Sale": {
    "ContactName": "Gislason-Denesik",
    "SaleDate": "2005-11-25T09:40:58.7053405+01:00",
    "SaleId": 583,
    "Probability": 286,
    "Title": "ut",
    "Amount": 22702.696,
    "Currency": "eius",
    "ProjectName": "Zieme, Botsford and Stamm",
    "AssociateFullName": "Violette Schmidt",
    "Description": "Re-contextualized multimedia complexity",
    "Status": "Lost",
    "WeightedAmount": 26397.682,
    "ProjectId": 326,
    "EarningPercent": 17468.916,
    "Earning": 8138.998,
    "ContactId": 594,
    "AssociateId": 918,
    "PersonId": 238,
    "SaleTypeId": 938,
    "SaleTypeName": "Treutel Inc and Sons",
    "PersonFullName": "Miss Brigitte Eichmann",
    "Completed": "Completed",
    "ActiveErpLinks": 381,
    "NextDueDate": "2002-06-29T09:40:58.7053405+02:00",
    "Number": "1244438"
  },
  "Ticket": {
    "TicketId": 498,
    "Title": "autem",
    "CreatedAt": "2018-10-17T09:40:58.7053405+02:00",
    "LastChanged": "1997-06-14T09:40:58.7053405+02:00",
    "ReadByOwner": "1996-12-24T09:40:58.7053405+01:00",
    "ReadByCustomer": "2000-05-23T09:40:58.7053405+02:00",
    "FirstReadByUser": "2003-11-03T09:40:58.7053405+01:00",
    "Activate": "2003-06-28T09:40:58.7053405+02:00",
    "ClosedAt": "1995-08-25T09:40:58.7053405+02:00",
    "RepliedAt": "2018-02-25T09:40:58.7053405+01:00",
    "AlertTimeout": "2012-03-11T09:40:58.7053405+01:00",
    "Deadline": "2018-12-30T09:40:58.7053405+01:00",
    "CreatedBy": 447,
    "CreatedByName": "Stokes-Abernathy",
    "Author": "eligendi",
    "OwnedBy": 566,
    "OwnedByName": "Schaefer Group",
    "Category": 324,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 960,
    "BaseStatus": "Active",
    "TicketStatus": 711,
    "Origin": "AutoGenerated",
    "CustId": 859,
    "CustFirstname": "Helene",
    "CustMiddleName": "Grant Inc and Sons",
    "CustLastname": "Jones",
    "AlertLevel": 3,
    "ConnectId": 531,
    "ReadStatus": "Green",
    "TimeToReply": 393,
    "RealTimeToReply": 709,
    "TimeToClose": 157,
    "RealTimeToClose": 603,
    "TimeSpentInternally": 290,
    "TimeSpentExternally": 319,
    "TimeSpentQueue": 787,
    "RealTimeSpentInternally": 681,
    "RealTimeSpentExternally": 958,
    "RealTimeSpentQueue": 190,
    "HasAttachment": false,
    "NumReplies": 356,
    "NumMessages": 107,
    "FromAddress": "asperiores",
    "CustFullname": "vero",
    "TicketStatusDisplayValue": "repellat"
  },
  "TransferTo": {
    "AssociateId": 474,
    "Name": "Vandervort LLC",
    "PersonId": 53,
    "Rank": 88,
    "Tooltip": "excepturi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 43,
    "FullName": "Al Johnson",
    "FormalName": "Lemke Group",
    "Deleted": false,
    "EjUserId": 411,
    "UserName": "Kunze-Ledner"
  }
}
```

```http_
HTTP/1.1 200 ChatSessionEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 444,
  "TopicId": 564,
  "User": {
    "AssociateId": 358,
    "Name": "Dickens-Quigley",
    "PersonId": 425,
    "Rank": 236,
    "Tooltip": "beatae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 175,
    "FullName": "Devyn Fritsch II",
    "FormalName": "Kuphal, Bergnaum and Greenholt",
    "Deleted": false,
    "EjUserId": 670,
    "UserName": "Mohr LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 609
      }
    }
  },
  "Person": {
    "Position": "repudiandae",
    "PersonId": 83,
    "Mrmrs": "saepe",
    "Firstname": "Lew",
    "Lastname": "Labadie",
    "MiddleName": "Schinner, Bradtke and Haag",
    "Title": "qui",
    "Description": "Decentralized multi-state leverage",
    "Email": "abbey@cole.ca",
    "FullName": "Dorris Mohr",
    "DirectPhone": "268.477.5113 x2256",
    "FormalName": "Bednar-Jacobi",
    "CountryId": 760,
    "ContactId": 655,
    "ContactName": "Lang-Monahan",
    "Retired": 29,
    "Rank": 97,
    "ActiveInterests": 662,
    "ContactDepartment": "",
    "ContactCountryId": 462,
    "ContactOrgNr": "1143764",
    "FaxPhone": "1-452-711-7547",
    "MobilePhone": "041.162.3721 x7522",
    "ContactPhone": "(687)732-3785 x8741",
    "AssociateName": "Shanahan Inc and Sons",
    "AssociateId": 843,
    "UsePersonAddress": false,
    "ContactFax": "sed",
    "Kanafname": "et",
    "Kanalname": "qui",
    "Post1": "unde",
    "Post2": "fugit",
    "Post3": "consequatur",
    "EmailName": "korey@kirlinvolkman.biz",
    "ContactFullName": "Iliana Lind",
    "ActiveErpLinks": 665,
    "TicketPriorityId": 639,
    "SupportLanguageId": 215,
    "SupportAssociateId": 548,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 674
      }
    }
  },
  "CustomerAlias": "quis",
  "CustomerHost": "dolor",
  "CustomerName": "Schaefer-Lynch",
  "CustomerEmail": "winona_bruen@parisian.biz",
  "CustomerPhone": "582-863-1530",
  "CustomerConsented": false,
  "CustomerCompanyName": "Pacocha-Herzog",
  "Status": "Closed",
  "FirstMessage": "numquam",
  "LastMessage": "dignissimos",
  "WhenRequested": "2000-11-12T09:40:58.713374+01:00",
  "WhenStarted": "2016-07-30T09:40:58.713374+02:00",
  "WhenEnded": "2015-01-05T09:40:58.713374+01:00",
  "WhenIdle": "2010-04-11T09:40:58.713374+02:00",
  "WhenFetched": "1999-07-29T09:40:58.713374+02:00",
  "SessionKey": "dolorum",
  "InitialQueuePos": 930,
  "AlertLevel": 762,
  "Rank": 530,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 862,
    "Name": "Treutel, Zboncak and Veum",
    "OrgNr": "1061752",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "eligendi",
    "DirectPhone": "(835)801-5770",
    "AssociateId": 809,
    "CountryId": 463,
    "EmailAddress": "amira.lehner@baileybrekke.uk",
    "Kananame": "odit",
    "EmailAddressName": "cleo@mcdermott.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Alysson Hermann",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "facere",
    "FullName": "Donato Stamm",
    "IsOwnerContact": false,
    "ActiveErpLinks": 814,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 969
      }
    }
  },
  "Project": {
    "ProjectId": 693,
    "Name": "Becker Inc and Sons",
    "Description": "Triple-buffered user-facing installation",
    "URL": "http://www.example.com/",
    "Type": "autem",
    "AssociateId": 838,
    "AssociateFullName": "Eddie Trantow",
    "TypeId": 795,
    "Updated": "2017-10-13T09:40:58.713374+02:00",
    "StatusId": 395,
    "Status": "quos",
    "TextId": 479,
    "PublishTo": "2016-05-20T09:40:58.713374+02:00",
    "PublishFrom": "2008-04-11T09:40:58.713374+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1602195",
    "ActiveErpLinks": 711,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 721
      }
    }
  },
  "Sale": {
    "ContactName": "Champlin-O'Connell",
    "SaleDate": "2018-05-31T09:40:58.7143706+02:00",
    "SaleId": 393,
    "Probability": 416,
    "Title": "qui",
    "Amount": 23730.647999999997,
    "Currency": "placeat",
    "ProjectName": "Auer, Fritsch and Larkin",
    "AssociateFullName": "Ms. Lavonne Krajcik",
    "Description": "Re-contextualized full-range success",
    "Status": "Lost",
    "WeightedAmount": 30766.478,
    "ProjectId": 128,
    "EarningPercent": 15497.63,
    "Earning": 28253.01,
    "ContactId": 341,
    "AssociateId": 178,
    "PersonId": 588,
    "SaleTypeId": 403,
    "SaleTypeName": "Welch LLC",
    "PersonFullName": "Melissa Dibbert I",
    "Completed": "Completed",
    "ActiveErpLinks": 381,
    "NextDueDate": "1995-08-04T09:40:58.7153814+02:00",
    "Number": "420471",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 457
      }
    }
  },
  "Ticket": {
    "TicketId": 538,
    "Title": "dolor",
    "CreatedAt": "2014-08-13T09:40:58.7153814+02:00",
    "LastChanged": "1996-07-03T09:40:58.7153814+02:00",
    "ReadByOwner": "2012-11-07T09:40:58.7153814+01:00",
    "ReadByCustomer": "1998-04-03T09:40:58.7153814+02:00",
    "FirstReadByUser": "2013-01-01T09:40:58.7153814+01:00",
    "Activate": "2001-03-04T09:40:58.7153814+01:00",
    "ClosedAt": "2001-05-08T09:40:58.7153814+02:00",
    "RepliedAt": "2002-12-11T09:40:58.7153814+01:00",
    "AlertTimeout": "1994-06-29T09:40:58.7153814+02:00",
    "Deadline": "1996-09-02T09:40:58.7153814+02:00",
    "CreatedBy": 514,
    "CreatedByName": "Wintheiser, D'Amore and Gottlieb",
    "Author": "repellat",
    "OwnedBy": 437,
    "OwnedByName": "Schroeder Group",
    "Category": 287,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 99,
    "BaseStatus": "Active",
    "TicketStatus": 168,
    "Origin": "AutoGenerated",
    "CustId": 591,
    "CustFirstname": "Dena",
    "CustMiddleName": "Batz, Hettinger and Collier",
    "CustLastname": "Huel",
    "AlertLevel": 346,
    "ConnectId": 500,
    "ReadStatus": "Green",
    "TimeToReply": 107,
    "RealTimeToReply": 284,
    "TimeToClose": 444,
    "RealTimeToClose": 984,
    "TimeSpentInternally": 520,
    "TimeSpentExternally": 207,
    "TimeSpentQueue": 605,
    "RealTimeSpentInternally": 868,
    "RealTimeSpentExternally": 89,
    "RealTimeSpentQueue": 290,
    "HasAttachment": false,
    "NumReplies": 535,
    "NumMessages": 137,
    "FromAddress": "voluptatem",
    "CustFullname": "qui",
    "TicketStatusDisplayValue": "a",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 135
      }
    }
  },
  "TransferTo": {
    "AssociateId": 15,
    "Name": "Jewess Inc and Sons",
    "PersonId": 859,
    "Rank": 150,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 783,
    "FullName": "Skyla Cremin",
    "FormalName": "Shields-Howell",
    "Deleted": true,
    "EjUserId": 496,
    "UserName": "Predovic Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 659
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
      "FieldLength": 695
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```