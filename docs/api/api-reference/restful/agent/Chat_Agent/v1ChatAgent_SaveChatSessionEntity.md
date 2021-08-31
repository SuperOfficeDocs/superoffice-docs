---
title: SaveChatSessionEntity
id: v1ChatAgent_SaveChatSessionEntity
---

# SaveChatSessionEntity

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
| ChatbotIsActive | bool | Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user. |


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
| ChatbotIsActive | bool | Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Chat/SaveChatSessionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 207,
  "TopicId": 638,
  "User": {
    "AssociateId": 26,
    "Name": "Ward-Murazik",
    "PersonId": 478,
    "Rank": 731,
    "Tooltip": "amet",
    "Type": "AnonymousAssociate",
    "GroupIdx": 310,
    "FullName": "Jamil Moore",
    "FormalName": "Fahey-Hirthe",
    "Deleted": true,
    "EjUserId": 666,
    "UserName": "Shanahan-Treutel"
  },
  "Person": {
    "Position": "et",
    "PersonId": 989,
    "Mrmrs": "ea",
    "Firstname": "Shad",
    "Lastname": "Dibbert",
    "MiddleName": "Frami-Runte",
    "Title": "sed",
    "Description": "Down-sized leading edge adapter",
    "Email": "virginia@sawayn.ca",
    "FullName": "Mr. Ora Langworth",
    "DirectPhone": "173.505.3625 x800",
    "FormalName": "Harber, Rosenbaum and Goldner",
    "CountryId": 541,
    "ContactId": 418,
    "ContactName": "Jacobs Inc and Sons",
    "Retired": 201,
    "Rank": 233,
    "ActiveInterests": 412,
    "ContactDepartment": "",
    "ContactCountryId": 589,
    "ContactOrgNr": "852924",
    "FaxPhone": "(710)763-0565 x7423",
    "MobilePhone": "708-877-4321",
    "ContactPhone": "(511)407-4466",
    "AssociateName": "Franecki Inc and Sons",
    "AssociateId": 997,
    "UsePersonAddress": false,
    "ContactFax": "fugiat",
    "Kanafname": "odio",
    "Kanalname": "quisquam",
    "Post1": "accusantium",
    "Post2": "corrupti",
    "Post3": "et",
    "EmailName": "sheila@stehrrogahn.biz",
    "ContactFullName": "Marion Schuppe",
    "ActiveErpLinks": 439,
    "TicketPriorityId": 182,
    "SupportLanguageId": 574,
    "SupportAssociateId": 19,
    "CategoryName": "VIP Customer"
  },
  "CustomerAlias": "possimus",
  "CustomerHost": "voluptatum",
  "CustomerName": "Schmitt, Skiles and Walter",
  "CustomerEmail": "cecilia@lemkeschumm.com",
  "CustomerPhone": "715.031.0637",
  "CustomerConsented": true,
  "CustomerCompanyName": "Kertzmann-Hahn",
  "Status": "Closed",
  "FirstMessage": "et",
  "LastMessage": "quam",
  "WhenRequested": "1996-09-06T14:58:03.3182408+02:00",
  "WhenStarted": "1995-04-07T14:58:03.3182408+02:00",
  "WhenEnded": "2018-07-28T14:58:03.3182408+02:00",
  "WhenIdle": "2006-07-09T14:58:03.3182408+02:00",
  "WhenFetched": "1999-08-29T14:58:03.3182408+02:00",
  "SessionKey": "qui",
  "InitialQueuePos": 727,
  "AlertLevel": 311,
  "Rank": 716,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 320,
    "Name": "Jakubowski, Grady and Schumm",
    "OrgNr": "1449428",
    "Department": "aggregate user-centric web services",
    "URL": "http://www.example.com/",
    "City": "sit",
    "DirectPhone": "313.518.0233 x365",
    "AssociateId": 843,
    "CountryId": 349,
    "EmailAddress": "hillard_wilkinson@lynchkassulke.com",
    "Kananame": "dolores",
    "EmailAddressName": "hailee@bayerluettgen.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Otilia Will",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "deleniti",
    "FullName": "Bertram Christiansen",
    "IsOwnerContact": false,
    "ActiveErpLinks": 714
  },
  "Project": {
    "ProjectId": 37,
    "Name": "Bernier-Swift",
    "Description": "Business-focused 5th generation throughput",
    "URL": "http://www.example.com/",
    "Type": "distinctio",
    "AssociateId": 434,
    "AssociateFullName": "Bret Purdy Jr.",
    "TypeId": 964,
    "Updated": "2021-04-02T14:58:03.3192468+02:00",
    "StatusId": 240,
    "Status": "et",
    "TextId": 564,
    "PublishTo": "2007-12-11T14:58:03.3192468+01:00",
    "PublishFrom": "2015-02-26T14:58:03.3192468+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "930279",
    "ActiveErpLinks": 969
  },
  "Sale": {
    "ContactName": "Kautzer-Streich",
    "SaleDate": "2018-06-13T14:58:03.3192468+02:00",
    "SaleId": 318,
    "Probability": 601,
    "Title": "repudiandae",
    "Amount": 16425.293999999998,
    "Currency": "sed",
    "ProjectName": "Kassulke Inc and Sons",
    "AssociateFullName": "Meredith Homenick",
    "Description": "Cross-platform needs-based portal",
    "Status": "Lost",
    "WeightedAmount": 28813.996,
    "ProjectId": 451,
    "EarningPercent": 14601.305999999999,
    "Earning": 5891.92,
    "ContactId": 997,
    "AssociateId": 226,
    "PersonId": 183,
    "SaleTypeId": 212,
    "SaleTypeName": "Predovic, Pacocha and Hayes",
    "PersonFullName": "Mrs. Joyce Waters",
    "Completed": "Completed",
    "ActiveErpLinks": 117,
    "NextDueDate": "2003-12-27T14:58:03.3202474+01:00",
    "Number": "1716629"
  },
  "Ticket": {
    "TicketId": 515,
    "Title": "saepe",
    "CreatedAt": "1995-06-10T14:58:03.3202474+02:00",
    "LastChanged": "2002-10-18T14:58:03.3202474+02:00",
    "ReadByOwner": "2003-01-13T14:58:03.3202474+01:00",
    "ReadByCustomer": "2018-10-17T14:58:03.3202474+02:00",
    "FirstReadByUser": "2000-01-11T14:58:03.3202474+01:00",
    "Activate": "1998-04-06T14:58:03.3202474+02:00",
    "ClosedAt": "2002-03-05T14:58:03.3202474+01:00",
    "RepliedAt": "2002-05-03T14:58:03.3202474+02:00",
    "AlertTimeout": "2000-01-20T14:58:03.3202474+01:00",
    "Deadline": "1997-04-20T14:58:03.3202474+02:00",
    "CreatedBy": 734,
    "CreatedByName": "Jacobi, Ward and Hammes",
    "Author": "accusantium",
    "OwnedBy": 703,
    "OwnedByName": "Dietrich, Kihn and Weimann",
    "Category": 329,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 936,
    "PriorityName": "Smitham, Altenwerth and Bayer",
    "BaseStatus": "Active",
    "TicketStatus": 286,
    "TicketStatusDisplayValue": "vel",
    "Origin": "AutoGenerated",
    "CustId": 232,
    "PersonFirstname": "Elmore",
    "PersonMiddleName": "Blick-Johnson",
    "PersonLastname": "Weissnat",
    "PersonFullname": "delectus",
    "AlertLevel": 554,
    "ConnectId": 212,
    "ReadStatus": "Green",
    "TimeToReply": 545,
    "RealTimeToReply": 532,
    "TimeToClose": 617,
    "RealTimeToClose": 796,
    "TimeSpentInternally": 272,
    "TimeSpentExternally": 897,
    "TimeSpentQueue": 93,
    "RealTimeSpentInternally": 788,
    "RealTimeSpentExternally": 876,
    "RealTimeSpentQueue": 451,
    "HasAttachment": true,
    "NumReplies": 363,
    "NumMessages": 854,
    "FromAddress": "aut",
    "ContactId": 18,
    "ContactName": "Olson, Wisozk and Mitchell",
    "OwnedByAssociateId": 328
  },
  "TransferTo": {
    "AssociateId": 600,
    "Name": "Price, Armstrong and Simonis",
    "PersonId": 953,
    "Rank": 282,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 389,
    "FullName": "Mr. Giovanna Friesen",
    "FormalName": "Eichmann Group",
    "Deleted": false,
    "EjUserId": 195,
    "UserName": "Kuvalis-Cartwright"
  },
  "ChatbotIsActive": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 290,
  "TopicId": 396,
  "User": {
    "AssociateId": 350,
    "Name": "Grady-Morissette",
    "PersonId": 794,
    "Rank": 866,
    "Tooltip": "asperiores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 823,
    "FullName": "Marcus Rowe",
    "FormalName": "Bailey-Thompson",
    "Deleted": false,
    "EjUserId": 675,
    "UserName": "D'Amore, Dickens and McClure",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 848
      }
    }
  },
  "Person": {
    "Position": "corporis",
    "PersonId": 693,
    "Mrmrs": "nostrum",
    "Firstname": "Dennis",
    "Lastname": "Olson",
    "MiddleName": "Rodriguez-Considine",
    "Title": "praesentium",
    "Description": "Versatile encompassing artificial intelligence",
    "Email": "simone@farrelldickens.ca",
    "FullName": "Evans Klein",
    "DirectPhone": "751-165-3280 x62343",
    "FormalName": "Hagenes Group",
    "CountryId": 879,
    "ContactId": 109,
    "ContactName": "Quitzon LLC",
    "Retired": 74,
    "Rank": 815,
    "ActiveInterests": 690,
    "ContactDepartment": "",
    "ContactCountryId": 634,
    "ContactOrgNr": "370711",
    "FaxPhone": "(824)354-2853",
    "MobilePhone": "1-023-040-7128",
    "ContactPhone": "(351)103-0272 x686",
    "AssociateName": "Stehr Inc and Sons",
    "AssociateId": 720,
    "UsePersonAddress": true,
    "ContactFax": "voluptas",
    "Kanafname": "facere",
    "Kanalname": "eligendi",
    "Post1": "nam",
    "Post2": "nesciunt",
    "Post3": "maxime",
    "EmailName": "adolf.kunde@thompson.ca",
    "ContactFullName": "Stan Gottlieb",
    "ActiveErpLinks": 564,
    "TicketPriorityId": 897,
    "SupportLanguageId": 345,
    "SupportAssociateId": 356,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 910
      }
    }
  },
  "CustomerAlias": "porro",
  "CustomerHost": "architecto",
  "CustomerName": "Medhurst LLC",
  "CustomerEmail": "alysha@oharawalker.co.uk",
  "CustomerPhone": "257-218-8281",
  "CustomerConsented": false,
  "CustomerCompanyName": "Dickinson Inc and Sons",
  "Status": "Closed",
  "FirstMessage": "doloribus",
  "LastMessage": "deleniti",
  "WhenRequested": "2012-09-09T14:58:03.3732065+02:00",
  "WhenStarted": "2005-11-22T14:58:03.3732065+01:00",
  "WhenEnded": "2016-02-28T14:58:03.3732065+01:00",
  "WhenIdle": "1999-03-12T14:58:03.3732065+01:00",
  "WhenFetched": "2019-01-09T14:58:03.3732065+01:00",
  "SessionKey": "exercitationem",
  "InitialQueuePos": 333,
  "AlertLevel": 744,
  "Rank": 391,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 197,
    "Name": "Emard, Larkin and McClure",
    "OrgNr": "1259050",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "nihil",
    "DirectPhone": "768-113-3123",
    "AssociateId": 925,
    "CountryId": 445,
    "EmailAddress": "jane.spencer@tromp.com",
    "Kananame": "quo",
    "EmailAddressName": "vivienne@padberg.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Sophia Rutherford",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "est",
    "FullName": "Roy Wintheiser",
    "IsOwnerContact": true,
    "ActiveErpLinks": 895,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 740
      }
    }
  },
  "Project": {
    "ProjectId": 274,
    "Name": "Kris-Beahan",
    "Description": "Multi-lateral static superstructure",
    "URL": "http://www.example.com/",
    "Type": "tenetur",
    "AssociateId": 67,
    "AssociateFullName": "Zackery VonRueden",
    "TypeId": 943,
    "Updated": "2017-03-26T14:58:03.3772429+02:00",
    "StatusId": 338,
    "Status": "voluptas",
    "TextId": 468,
    "PublishTo": "2020-03-01T14:58:03.3772429+01:00",
    "PublishFrom": "1998-11-02T14:58:03.3772429+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1084980",
    "ActiveErpLinks": 781,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 709
      }
    }
  },
  "Sale": {
    "ContactName": "Padberg, Lockman and Runolfsson",
    "SaleDate": "2018-12-13T14:58:03.3772429+01:00",
    "SaleId": 757,
    "Probability": 439,
    "Title": "et",
    "Amount": 4212.096,
    "Currency": "ipsam",
    "ProjectName": "Welch Group",
    "AssociateFullName": "Maurice Leffler",
    "Description": "Universal scalable standardization",
    "Status": "Lost",
    "WeightedAmount": 6283.67,
    "ProjectId": 144,
    "EarningPercent": 2234.542,
    "Earning": 28334.494,
    "ContactId": 247,
    "AssociateId": 862,
    "PersonId": 70,
    "SaleTypeId": 270,
    "SaleTypeName": "Stehr, Daugherty and Sipes",
    "PersonFullName": "Gina Gusikowski",
    "Completed": "Completed",
    "ActiveErpLinks": 820,
    "NextDueDate": "2016-07-23T14:58:03.3782143+02:00",
    "Number": "738914",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 743
      }
    }
  },
  "Ticket": {
    "TicketId": 822,
    "Title": "sapiente",
    "CreatedAt": "1995-10-28T14:58:03.3782143+02:00",
    "LastChanged": "2019-05-17T14:58:03.3782143+02:00",
    "ReadByOwner": "2017-11-07T14:58:03.3782143+01:00",
    "ReadByCustomer": "2019-07-16T14:58:03.3782143+02:00",
    "FirstReadByUser": "1996-09-10T14:58:03.3782143+02:00",
    "Activate": "1998-05-23T14:58:03.3782143+02:00",
    "ClosedAt": "1999-03-31T14:58:03.3782143+02:00",
    "RepliedAt": "2008-08-25T14:58:03.3782143+02:00",
    "AlertTimeout": "2010-07-16T14:58:03.3782143+02:00",
    "Deadline": "2002-08-17T14:58:03.3782143+02:00",
    "CreatedBy": 197,
    "CreatedByName": "Mayer-Funk",
    "Author": "suscipit",
    "OwnedBy": 972,
    "OwnedByName": "Deckow Group",
    "Category": 319,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 471,
    "PriorityName": "Reilly, Block and Spinka",
    "BaseStatus": "Active",
    "TicketStatus": 572,
    "TicketStatusDisplayValue": "sit",
    "Origin": "AutoGenerated",
    "CustId": 164,
    "PersonFirstname": "Spencer",
    "PersonMiddleName": "Denesik LLC",
    "PersonLastname": "Sanford",
    "PersonFullname": "voluptatibus",
    "AlertLevel": 148,
    "ConnectId": 916,
    "ReadStatus": "Green",
    "TimeToReply": 533,
    "RealTimeToReply": 625,
    "TimeToClose": 679,
    "RealTimeToClose": 150,
    "TimeSpentInternally": 762,
    "TimeSpentExternally": 740,
    "TimeSpentQueue": 297,
    "RealTimeSpentInternally": 672,
    "RealTimeSpentExternally": 608,
    "RealTimeSpentQueue": 640,
    "HasAttachment": true,
    "NumReplies": 648,
    "NumMessages": 776,
    "FromAddress": "molestiae",
    "ContactId": 355,
    "ContactName": "Adams, Rogahn and Turner",
    "OwnedByAssociateId": 907,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "harness cross-platform infrastructures"
        },
        "FieldType": "System.Int32",
        "FieldLength": 675
      }
    }
  },
  "TransferTo": {
    "AssociateId": 196,
    "Name": "Douglas, Sipes and Jacobs",
    "PersonId": 276,
    "Rank": 939,
    "Tooltip": "quae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 84,
    "FullName": "Dortha Simonis",
    "FormalName": "Kihn, Beier and Friesen",
    "Deleted": true,
    "EjUserId": 571,
    "UserName": "Johnston LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 991
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
      "FieldLength": 623
    }
  }
}
```