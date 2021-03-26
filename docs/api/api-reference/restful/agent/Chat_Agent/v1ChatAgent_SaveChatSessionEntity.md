---
title: POST Agents/Chat/SaveChatSessionEntity
id: v1ChatAgent_SaveChatSessionEntity
---

# POST Agents/Chat/SaveChatSessionEntity

```http
POST /api/v1/Agents/Chat/SaveChatSessionEntity
```

Updates the existing ChatSessionEntity or creates a new ChatSessionEntity if the id parameter is empty








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



Carrier object for ChatSessionEntity.
Services for the ChatSessionEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IChatAgent">Chat Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

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

## Sample Request

```http!
POST /api/v1/Agents/Chat/SaveChatSessionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 387,
  "TopicId": 954,
  "User": {
    "AssociateId": 527,
    "Name": "Harber-Kub",
    "PersonId": 873,
    "Rank": 10,
    "Tooltip": "odit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 290,
    "FullName": "Cary DuBuque",
    "FormalName": "Goldner, Bogan and Mills",
    "Deleted": true,
    "EjUserId": 524,
    "UserName": "Hayes Group"
  },
  "Person": {
    "Position": "possimus",
    "PersonId": 578,
    "Mrmrs": "incidunt",
    "Firstname": "Oceane",
    "Lastname": "Gislason",
    "MiddleName": "Larkin-Friesen",
    "Title": "est",
    "Description": "Universal multi-state model",
    "Email": "tatyana@zboncak.name",
    "FullName": "Javier Kautzer",
    "DirectPhone": "(542)480-5535",
    "FormalName": "Boyle, Sanford and Schiller",
    "CountryId": 841,
    "ContactId": 967,
    "ContactName": "Okuneva, Kautzer and Keebler",
    "Retired": 915,
    "Rank": 615,
    "ActiveInterests": 446,
    "ContactDepartment": "",
    "ContactCountryId": 263,
    "ContactOrgNr": "944895",
    "FaxPhone": "702-031-1718",
    "MobilePhone": "1-512-201-7014",
    "ContactPhone": "160.818.0622",
    "AssociateName": "Metz, Schuster and Haley",
    "AssociateId": 252,
    "UsePersonAddress": false,
    "ContactFax": "facilis",
    "Kanafname": "eaque",
    "Kanalname": "dolor",
    "Post1": "temporibus",
    "Post2": "id",
    "Post3": "autem",
    "EmailName": "irving@brakuslebsack.ca",
    "ContactFullName": "Karlee Beahan",
    "ActiveErpLinks": 348,
    "TicketPriorityId": 950,
    "SupportLanguageId": 206,
    "SupportAssociateId": 779,
    "CategoryName": "VIP Customer"
  },
  "CustomerAlias": "est",
  "CustomerHost": "pariatur",
  "CustomerName": "Kub-Watsica",
  "CustomerEmail": "elta.kling@kilbackharvey.us",
  "CustomerPhone": "(265)552-7660 x136",
  "CustomerConsented": false,
  "CustomerCompanyName": "Powlowski-Jaskolski",
  "Status": "Closed",
  "FirstMessage": "inventore",
  "LastMessage": "itaque",
  "WhenRequested": "2002-01-03T16:48:28.8659328+01:00",
  "WhenStarted": "2017-12-24T16:48:28.8659328+01:00",
  "WhenEnded": "2009-06-09T16:48:28.8659328+02:00",
  "WhenIdle": "2006-01-04T16:48:28.8659328+01:00",
  "WhenFetched": "2017-07-01T16:48:28.8659328+02:00",
  "SessionKey": "dicta",
  "InitialQueuePos": 516,
  "AlertLevel": 77,
  "Rank": 271,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 89,
    "Name": "Morissette, Hills and Mertz",
    "OrgNr": "179961",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "nesciunt",
    "DirectPhone": "(251)456-1172 x120",
    "AssociateId": 462,
    "CountryId": 180,
    "EmailAddress": "chaya@nicolasdare.name",
    "Kananame": "placeat",
    "EmailAddressName": "willa_hane@christiansen.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Corine Stanton",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "dignissimos",
    "FullName": "Misty Hane",
    "IsOwnerContact": true,
    "ActiveErpLinks": 889
  },
  "Project": {
    "ProjectId": 410,
    "Name": "Terry LLC",
    "Description": "Persevering transitional Graphical User Interface",
    "URL": "http://www.example.com/",
    "Type": "accusamus",
    "AssociateId": 461,
    "AssociateFullName": "Willa Kulas",
    "TypeId": 324,
    "Updated": "1998-06-14T16:48:28.8669243+02:00",
    "StatusId": 496,
    "Status": "accusamus",
    "TextId": 435,
    "PublishTo": "2011-03-12T16:48:28.8669243+01:00",
    "PublishFrom": "2019-09-03T16:48:28.8669243+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "461640",
    "ActiveErpLinks": 543
  },
  "Sale": {
    "ContactName": "Monahan, Hansen and O'Connell",
    "SaleDate": "2005-02-27T16:48:28.8669243+01:00",
    "SaleId": 720,
    "Probability": 310,
    "Title": "aut",
    "Amount": 16876.59,
    "Currency": "quod",
    "ProjectName": "Douglas-Jewess",
    "AssociateFullName": "Aubrey Lueilwitz",
    "Description": "Quality-focused client-driven projection",
    "Status": "Lost",
    "WeightedAmount": 16494.242,
    "ProjectId": 20,
    "EarningPercent": 29747.928,
    "Earning": 883.788,
    "ContactId": 857,
    "AssociateId": 895,
    "PersonId": 971,
    "SaleTypeId": 832,
    "SaleTypeName": "Cummings, Lueilwitz and VonRueden",
    "PersonFullName": "Elian Bogisich",
    "Completed": "Completed",
    "ActiveErpLinks": 285,
    "NextDueDate": "2000-12-15T16:48:28.8679249+01:00",
    "Number": "549344"
  },
  "Ticket": {
    "TicketId": 387,
    "Title": "reprehenderit",
    "CreatedAt": "2000-08-26T16:48:28.8679249+02:00",
    "LastChanged": "2020-01-15T16:48:28.8679249+01:00",
    "ReadByOwner": "2003-01-02T16:48:28.8679249+01:00",
    "ReadByCustomer": "2020-10-10T16:48:28.8679249+02:00",
    "FirstReadByUser": "1994-08-25T16:48:28.8679249+02:00",
    "Activate": "1994-10-15T16:48:28.8679249+02:00",
    "ClosedAt": "1997-02-23T16:48:28.8679249+01:00",
    "RepliedAt": "2009-01-29T16:48:28.8679249+01:00",
    "AlertTimeout": "2017-03-26T16:48:28.8679249+02:00",
    "Deadline": "2000-12-13T16:48:28.8679249+01:00",
    "CreatedBy": 106,
    "CreatedByName": "Hackett Group",
    "Author": "eos",
    "OwnedBy": 417,
    "OwnedByName": "Gottlieb, Mann and Goldner",
    "Category": 189,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 434,
    "BaseStatus": "Active",
    "TicketStatus": 309,
    "Origin": "AutoGenerated",
    "CustId": 274,
    "CustFirstname": "Verna",
    "CustMiddleName": "Olson, Hansen and Robel",
    "CustLastname": "Murazik",
    "AlertLevel": 199,
    "ConnectId": 986,
    "ReadStatus": "Green",
    "TimeToReply": 878,
    "RealTimeToReply": 1000,
    "TimeToClose": 866,
    "RealTimeToClose": 95,
    "TimeSpentInternally": 724,
    "TimeSpentExternally": 411,
    "TimeSpentQueue": 180,
    "RealTimeSpentInternally": 666,
    "RealTimeSpentExternally": 214,
    "RealTimeSpentQueue": 780,
    "HasAttachment": false,
    "NumReplies": 726,
    "NumMessages": 879,
    "FromAddress": "ut",
    "CustFullname": "eius",
    "TicketStatusDisplayValue": "error"
  },
  "TransferTo": {
    "AssociateId": 444,
    "Name": "Treutel LLC",
    "PersonId": 268,
    "Rank": 609,
    "Tooltip": "vel",
    "Type": "AnonymousAssociate",
    "GroupIdx": 778,
    "FullName": "Marjorie Kuphal",
    "FormalName": "Pacocha-Leuschke",
    "Deleted": false,
    "EjUserId": 416,
    "UserName": "Lowe-Sanford"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 823,
  "TopicId": 86,
  "User": {
    "AssociateId": 501,
    "Name": "Littel Group",
    "PersonId": 803,
    "Rank": 228,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 94,
    "FullName": "Miss Mazie Langosh",
    "FormalName": "Gerhold, Nikolaus and Morar",
    "Deleted": true,
    "EjUserId": 115,
    "UserName": "Mraz LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 406
      }
    }
  },
  "Person": {
    "Position": "minus",
    "PersonId": 507,
    "Mrmrs": "ad",
    "Firstname": "Tyson",
    "Lastname": "Moore",
    "MiddleName": "Farrell Inc and Sons",
    "Title": "sint",
    "Description": "Persevering global conglomeration",
    "Email": "dameon.hickle@grant.com",
    "FullName": "Kareem Gerhold",
    "DirectPhone": "1-874-706-7270 x6660",
    "FormalName": "Kulas-Frami",
    "CountryId": 824,
    "ContactId": 699,
    "ContactName": "Parisian-Volkman",
    "Retired": 689,
    "Rank": 427,
    "ActiveInterests": 328,
    "ContactDepartment": "",
    "ContactCountryId": 763,
    "ContactOrgNr": "207671",
    "FaxPhone": "(070)251-6161 x613",
    "MobilePhone": "(455)272-8577 x00114",
    "ContactPhone": "861-288-6432 x70046",
    "AssociateName": "Kreiger-Schultz",
    "AssociateId": 928,
    "UsePersonAddress": false,
    "ContactFax": "non",
    "Kanafname": "pariatur",
    "Kanalname": "sint",
    "Post1": "incidunt",
    "Post2": "dolorum",
    "Post3": "sunt",
    "EmailName": "tamara.beer@corwin.ca",
    "ContactFullName": "Caleb Schmitt",
    "ActiveErpLinks": 604,
    "TicketPriorityId": 437,
    "SupportLanguageId": 953,
    "SupportAssociateId": 484,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 561
      }
    }
  },
  "CustomerAlias": "amet",
  "CustomerHost": "neque",
  "CustomerName": "Kerluke-Greenfelder",
  "CustomerEmail": "imogene_lakin@schoen.com",
  "CustomerPhone": "1-125-328-2646",
  "CustomerConsented": false,
  "CustomerCompanyName": "Luettgen-Barton",
  "Status": "Closed",
  "FirstMessage": "nam",
  "LastMessage": "fuga",
  "WhenRequested": "2010-09-03T16:48:28.8749207+02:00",
  "WhenStarted": "1996-01-23T16:48:28.8749207+01:00",
  "WhenEnded": "2000-10-15T16:48:28.8749207+02:00",
  "WhenIdle": "1998-12-07T16:48:28.8749207+01:00",
  "WhenFetched": "2004-03-16T16:48:28.8749207+01:00",
  "SessionKey": "autem",
  "InitialQueuePos": 471,
  "AlertLevel": 693,
  "Rank": 407,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 997,
    "Name": "Doyle-Nitzsche",
    "OrgNr": "383919",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "incidunt",
    "DirectPhone": "(705)667-1323 x565",
    "AssociateId": 848,
    "CountryId": 392,
    "EmailAddress": "ignacio@okuneva.uk",
    "Kananame": "ut",
    "EmailAddressName": "monserrate.effertz@robel.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Camron Larson",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "vitae",
    "FullName": "Dr. Sheridan Cronin",
    "IsOwnerContact": true,
    "ActiveErpLinks": 419,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 744
      }
    }
  },
  "Project": {
    "ProjectId": 358,
    "Name": "Stanton LLC",
    "Description": "Intuitive high-level emulation",
    "URL": "http://www.example.com/",
    "Type": "ut",
    "AssociateId": 707,
    "AssociateFullName": "Dr. Jalyn O'Reilly",
    "TypeId": 304,
    "Updated": "2002-12-03T16:48:28.8758962+01:00",
    "StatusId": 730,
    "Status": "quasi",
    "TextId": 916,
    "PublishTo": "2008-06-29T16:48:28.8758962+02:00",
    "PublishFrom": "2012-04-20T16:48:28.8758962+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "692154",
    "ActiveErpLinks": 177,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 216
      }
    }
  },
  "Sale": {
    "ContactName": "Hirthe LLC",
    "SaleDate": "2005-10-11T16:48:28.8758962+02:00",
    "SaleId": 856,
    "Probability": 665,
    "Title": "eveniet",
    "Amount": 9972.387999999999,
    "Currency": "unde",
    "ProjectName": "Graham Inc and Sons",
    "AssociateFullName": "Mr. Gianni Erdman",
    "Description": "Synchronised fault-tolerant open architecture",
    "Status": "Lost",
    "WeightedAmount": 5700.746,
    "ProjectId": 337,
    "EarningPercent": 8690.582,
    "Earning": 955.87,
    "ContactId": 727,
    "AssociateId": 489,
    "PersonId": 322,
    "SaleTypeId": 230,
    "SaleTypeName": "Kuhic, Ortiz and Aufderhar",
    "PersonFullName": "Maeve Kunde",
    "Completed": "Completed",
    "ActiveErpLinks": 813,
    "NextDueDate": "2003-09-30T16:48:28.8758962+02:00",
    "Number": "1609953",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 358
      }
    }
  },
  "Ticket": {
    "TicketId": 41,
    "Title": "ipsam",
    "CreatedAt": "2015-11-22T16:48:28.8769244+01:00",
    "LastChanged": "1999-08-29T16:48:28.8769244+02:00",
    "ReadByOwner": "2006-02-08T16:48:28.8769244+01:00",
    "ReadByCustomer": "1995-08-17T16:48:28.8769244+02:00",
    "FirstReadByUser": "1994-05-05T16:48:28.8769244+02:00",
    "Activate": "2006-11-04T16:48:28.8769244+01:00",
    "ClosedAt": "1996-12-16T16:48:28.8769244+01:00",
    "RepliedAt": "2015-11-26T16:48:28.8769244+01:00",
    "AlertTimeout": "2017-04-28T16:48:28.8769244+02:00",
    "Deadline": "2013-05-15T16:48:28.8769244+02:00",
    "CreatedBy": 826,
    "CreatedByName": "Jacobson, Marvin and Borer",
    "Author": "inventore",
    "OwnedBy": 441,
    "OwnedByName": "Romaguera LLC",
    "Category": 640,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 410,
    "BaseStatus": "Active",
    "TicketStatus": 615,
    "Origin": "AutoGenerated",
    "CustId": 99,
    "CustFirstname": "Clare",
    "CustMiddleName": "Waelchi, Zboncak and Herzog",
    "CustLastname": "D'Amore",
    "AlertLevel": 127,
    "ConnectId": 442,
    "ReadStatus": "Green",
    "TimeToReply": 556,
    "RealTimeToReply": 689,
    "TimeToClose": 496,
    "RealTimeToClose": 520,
    "TimeSpentInternally": 465,
    "TimeSpentExternally": 356,
    "TimeSpentQueue": 614,
    "RealTimeSpentInternally": 989,
    "RealTimeSpentExternally": 702,
    "RealTimeSpentQueue": 375,
    "HasAttachment": true,
    "NumReplies": 228,
    "NumMessages": 603,
    "FromAddress": "sint",
    "CustFullname": "est",
    "TicketStatusDisplayValue": "iste",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "innovate viral bandwidth"
        },
        "FieldType": "System.String",
        "FieldLength": 6
      }
    }
  },
  "TransferTo": {
    "AssociateId": 174,
    "Name": "Sipes-Mayer",
    "PersonId": 234,
    "Rank": 451,
    "Tooltip": "magnam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 753,
    "FullName": "Dasia Walker",
    "FormalName": "Terry LLC",
    "Deleted": false,
    "EjUserId": 241,
    "UserName": "Strosin-McKenzie",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 752
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
      "FieldType": "System.String",
      "FieldLength": 320
    }
  }
}
```