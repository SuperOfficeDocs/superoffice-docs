---
title: POST ChatSession
id: v1ChatSessionEntity_PostChatSessionEntity
---

# POST ChatSession

```http
POST /api/v1/ChatSession
```

Creates a new ChatSessionEntity

Calls the Chat agent service SaveChatSessionEntity.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/ChatSession?$select=name,department,category/id
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

## Request Body: newEntity  

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



ChatSessionEntity entity with API _Links added.

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
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/ChatSession
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 275,
  "TopicId": 892,
  "User": {
    "AssociateId": 675,
    "Name": "Howe, Kautzer and Champlin",
    "PersonId": 448,
    "Rank": 676,
    "Tooltip": "recusandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 532,
    "FullName": "Mrs. Alyce Kiehn",
    "FormalName": "Ortiz, Anderson and Gottlieb",
    "Deleted": false,
    "EjUserId": 286,
    "UserName": "Ruecker Group"
  },
  "Person": {
    "Position": "asperiores",
    "PersonId": 989,
    "Mrmrs": "vel",
    "Firstname": "Louie",
    "Lastname": "Kutch",
    "MiddleName": "Legros-Rau",
    "Title": "dolore",
    "Description": "Public-key systematic emulation",
    "Email": "kali.sipes@jenkinsklocko.com",
    "FullName": "Jarrett Bednar",
    "DirectPhone": "1-222-551-6814 x44210",
    "FormalName": "Lockman-Orn",
    "CountryId": 199,
    "ContactId": 100,
    "ContactName": "Renner, Langosh and Keeling",
    "Retired": 57,
    "Rank": 275,
    "ActiveInterests": 121,
    "ContactDepartment": "",
    "ContactCountryId": 996,
    "ContactOrgNr": "1194748",
    "FaxPhone": "1-662-120-7087 x1206",
    "MobilePhone": "1-438-582-8047 x742",
    "ContactPhone": "383-066-5782",
    "AssociateName": "Steuber-Brekke",
    "AssociateId": 118,
    "UsePersonAddress": false,
    "ContactFax": "quia",
    "Kanafname": "suscipit",
    "Kanalname": "animi",
    "Post1": "aperiam",
    "Post2": "quos",
    "Post3": "et",
    "EmailName": "maudie.herzog@larsonbeahan.ca",
    "ContactFullName": "Priscilla Funk",
    "ActiveErpLinks": 291,
    "TicketPriorityId": 973,
    "SupportLanguageId": 974,
    "SupportAssociateId": 634,
    "CategoryName": "VIP Customer"
  },
  "CustomerAlias": "est",
  "CustomerHost": "inventore",
  "CustomerName": "Spencer Inc and Sons",
  "CustomerEmail": "lavinia.emard@kertzmannkuvalis.name",
  "CustomerPhone": "528-815-8730",
  "CustomerConsented": false,
  "CustomerCompanyName": "Satterfield Group",
  "Status": "Closed",
  "FirstMessage": "voluptas",
  "LastMessage": "molestias",
  "WhenRequested": "2012-05-25T18:25:50.0025634+02:00",
  "WhenStarted": "1996-11-08T18:25:50.0025634+01:00",
  "WhenEnded": "2009-12-23T18:25:50.0025634+01:00",
  "WhenIdle": "2014-08-04T18:25:50.0025634+02:00",
  "WhenFetched": "1995-08-18T18:25:50.0025634+02:00",
  "SessionKey": "id",
  "InitialQueuePos": 742,
  "AlertLevel": 867,
  "Rank": 345,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 609,
    "Name": "Wiegand LLC",
    "OrgNr": "1656695",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "odio",
    "DirectPhone": "636-020-1537 x74852",
    "AssociateId": 125,
    "CountryId": 64,
    "EmailAddress": "haleigh.sporer@lemke.uk",
    "Kananame": "sunt",
    "EmailAddressName": "deontae@hauck.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Kevin Mayer",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "nesciunt",
    "FullName": "Golden Lynch",
    "IsOwnerContact": true,
    "ActiveErpLinks": 461
  },
  "Project": {
    "ProjectId": 490,
    "Name": "Cole Inc and Sons",
    "Description": "Grass-roots discrete local area network",
    "URL": "http://www.example.com/",
    "Type": "aperiam",
    "AssociateId": 652,
    "AssociateFullName": "Yessenia Renner",
    "TypeId": 804,
    "Updated": "2012-04-10T18:25:50.0045636+02:00",
    "StatusId": 657,
    "Status": "perferendis",
    "TextId": 989,
    "PublishTo": "2011-02-04T18:25:50.0045636+01:00",
    "PublishFrom": "2014-03-21T18:25:50.0045636+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1031148",
    "ActiveErpLinks": 324
  },
  "Sale": {
    "ContactName": "Reichert LLC",
    "SaleDate": "1997-02-15T18:25:50.0045636+01:00",
    "SaleId": 307,
    "Probability": 16,
    "Title": "facere",
    "Amount": 18380.91,
    "Currency": "adipisci",
    "ProjectName": "Koss Group",
    "AssociateFullName": "Marilou Farrell",
    "Description": "Front-line 6th generation intranet",
    "Status": "Lost",
    "WeightedAmount": 26269.188,
    "ProjectId": 776,
    "EarningPercent": 11326.276,
    "Earning": 15748.35,
    "ContactId": 930,
    "AssociateId": 381,
    "PersonId": 575,
    "SaleTypeId": 699,
    "SaleTypeName": "Wiza Inc and Sons",
    "PersonFullName": "Moises Hammes V",
    "Completed": "Completed",
    "ActiveErpLinks": 994,
    "NextDueDate": "2001-12-19T18:25:50.0045636+01:00",
    "Number": "728018"
  },
  "Ticket": {
    "TicketId": 240,
    "Title": "facere",
    "CreatedAt": "2017-07-31T18:25:50.0045636+02:00",
    "LastChanged": "2012-09-29T18:25:50.0045636+02:00",
    "ReadByOwner": "2014-02-17T18:25:50.0045636+01:00",
    "ReadByCustomer": "2014-05-18T18:25:50.0045636+02:00",
    "FirstReadByUser": "2019-07-27T18:25:50.0045636+02:00",
    "Activate": "2002-05-05T18:25:50.0045636+02:00",
    "ClosedAt": "2020-06-26T18:25:50.0045636+02:00",
    "RepliedAt": "2016-02-29T18:25:50.0045636+01:00",
    "AlertTimeout": "2021-03-06T18:25:50.0045636+01:00",
    "Deadline": "2010-09-10T18:25:50.0045636+02:00",
    "CreatedBy": 640,
    "CreatedByName": "White Inc and Sons",
    "Author": "autem",
    "OwnedBy": 636,
    "OwnedByName": "Becker LLC",
    "Category": 76,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 140,
    "PriorityName": "Johns, Harvey and Larkin",
    "BaseStatus": "Active",
    "TicketStatus": 579,
    "TicketStatusDisplayValue": "ducimus",
    "Origin": "AutoGenerated",
    "CustId": 695,
    "PersonFirstname": "Aimee",
    "PersonMiddleName": "Cummings LLC",
    "PersonLastname": "Braun",
    "PersonFullname": "voluptatibus",
    "AlertLevel": 128,
    "ConnectId": 765,
    "ReadStatus": "Green",
    "TimeToReply": 775,
    "RealTimeToReply": 89,
    "TimeToClose": 132,
    "RealTimeToClose": 619,
    "TimeSpentInternally": 116,
    "TimeSpentExternally": 592,
    "TimeSpentQueue": 353,
    "RealTimeSpentInternally": 4,
    "RealTimeSpentExternally": 772,
    "RealTimeSpentQueue": 186,
    "HasAttachment": false,
    "NumReplies": 682,
    "NumMessages": 61,
    "FromAddress": "ut",
    "ContactId": 857,
    "ContactName": "Donnelly, Schultz and Murray",
    "OwnedByAssociateId": 609
  },
  "TransferTo": {
    "AssociateId": 962,
    "Name": "Kunde Group",
    "PersonId": 846,
    "Rank": 236,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 72,
    "FullName": "Elva Barrows",
    "FormalName": "O'Kon-Green",
    "Deleted": false,
    "EjUserId": 404,
    "UserName": "Fahey-Jewess"
  },
  "ChatbotIsActive": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 411,
  "TopicId": 729,
  "User": {
    "AssociateId": 878,
    "Name": "Altenwerth Inc and Sons",
    "PersonId": 85,
    "Rank": 594,
    "Tooltip": "dolorem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 131,
    "FullName": "Carmella Kozey DDS",
    "FormalName": "Cartwright-Weissnat",
    "Deleted": true,
    "EjUserId": 588,
    "UserName": "Borer-Zulauf",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 953
      }
    }
  },
  "Person": {
    "Position": "libero",
    "PersonId": 251,
    "Mrmrs": "voluptas",
    "Firstname": "Oral",
    "Lastname": "Eichmann",
    "MiddleName": "Shanahan-Lakin",
    "Title": "inventore",
    "Description": "Pre-emptive secondary superstructure",
    "Email": "thurman@casper.com",
    "FullName": "Meta Altenwerth",
    "DirectPhone": "(285)725-5144 x8723",
    "FormalName": "Weissnat, Von and Walter",
    "CountryId": 768,
    "ContactId": 883,
    "ContactName": "Runolfsson-Lesch",
    "Retired": 941,
    "Rank": 75,
    "ActiveInterests": 843,
    "ContactDepartment": "",
    "ContactCountryId": 588,
    "ContactOrgNr": "1825293",
    "FaxPhone": "401.428.8164",
    "MobilePhone": "(232)156-1025 x810",
    "ContactPhone": "1-367-438-1533 x608",
    "AssociateName": "Bayer, Wisozk and Quigley",
    "AssociateId": 63,
    "UsePersonAddress": true,
    "ContactFax": "totam",
    "Kanafname": "nihil",
    "Kanalname": "sit",
    "Post1": "vel",
    "Post2": "laborum",
    "Post3": "officia",
    "EmailName": "bobby_schowalter@conroy.us",
    "ContactFullName": "Elinor Okuneva",
    "ActiveErpLinks": 966,
    "TicketPriorityId": 856,
    "SupportLanguageId": 414,
    "SupportAssociateId": 564,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 303
      }
    }
  },
  "CustomerAlias": "rerum",
  "CustomerHost": "ut",
  "CustomerName": "Friesen Group",
  "CustomerEmail": "dolly_medhurst@balistreri.info",
  "CustomerPhone": "1-888-778-6777 x1745",
  "CustomerConsented": false,
  "CustomerCompanyName": "Stehr, Hackett and Quigley",
  "Status": "Closed",
  "FirstMessage": "voluptatem",
  "LastMessage": "natus",
  "WhenRequested": "2016-04-28T18:25:50.012563+02:00",
  "WhenStarted": "2013-11-02T18:25:50.012563+01:00",
  "WhenEnded": "2008-02-08T18:25:50.012563+01:00",
  "WhenIdle": "2010-02-25T18:25:50.012563+01:00",
  "WhenFetched": "1996-06-24T18:25:50.012563+02:00",
  "SessionKey": "harum",
  "InitialQueuePos": 159,
  "AlertLevel": 65,
  "Rank": 688,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 727,
    "Name": "Daniel-Kovacek",
    "OrgNr": "1050371",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "dolore",
    "DirectPhone": "125-064-6004",
    "AssociateId": 826,
    "CountryId": 100,
    "EmailAddress": "luis@keelingheaney.name",
    "Kananame": "quia",
    "EmailAddressName": "pamela@bartoletti.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Olaf McKenzie",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "voluptatibus",
    "FullName": "Juston Beier",
    "IsOwnerContact": false,
    "ActiveErpLinks": 857,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 917
      }
    }
  },
  "Project": {
    "ProjectId": 59,
    "Name": "Dickinson, Rowe and Murazik",
    "Description": "Face to face intangible task-force",
    "URL": "http://www.example.com/",
    "Type": "est",
    "AssociateId": 953,
    "AssociateFullName": "Antonio Wintheiser",
    "TypeId": 358,
    "Updated": "2009-09-24T18:25:50.0135631+02:00",
    "StatusId": 617,
    "Status": "praesentium",
    "TextId": 781,
    "PublishTo": "1997-10-01T18:25:50.0135631+02:00",
    "PublishFrom": "2012-11-19T18:25:50.0135631+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "987014",
    "ActiveErpLinks": 447,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 579
      }
    }
  },
  "Sale": {
    "ContactName": "Reichert, Green and Gerlach",
    "SaleDate": "2021-10-01T18:25:50.0145347+02:00",
    "SaleId": 811,
    "Probability": 667,
    "Title": "voluptatum",
    "Amount": 30703.798,
    "Currency": "saepe",
    "ProjectName": "Schumm LLC",
    "AssociateFullName": "Kory Mann",
    "Description": "Reactive intermediate core",
    "Status": "Lost",
    "WeightedAmount": 23501.865999999998,
    "ProjectId": 747,
    "EarningPercent": 1034.22,
    "Earning": 22831.19,
    "ContactId": 482,
    "AssociateId": 50,
    "PersonId": 920,
    "SaleTypeId": 183,
    "SaleTypeName": "Welch-Hyatt",
    "PersonFullName": "Rex Farrell",
    "Completed": "Completed",
    "ActiveErpLinks": 813,
    "NextDueDate": "1995-08-22T18:25:50.0155332+02:00",
    "Number": "1325710",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 629
      }
    }
  },
  "Ticket": {
    "TicketId": 988,
    "Title": "soluta",
    "CreatedAt": "2001-06-06T18:25:50.0155332+02:00",
    "LastChanged": "2015-12-13T18:25:50.0155332+01:00",
    "ReadByOwner": "1998-03-14T18:25:50.0155332+01:00",
    "ReadByCustomer": "2015-06-22T18:25:50.0155332+02:00",
    "FirstReadByUser": "1997-10-19T18:25:50.0155332+02:00",
    "Activate": "1994-08-31T18:25:50.0155332+02:00",
    "ClosedAt": "2012-08-20T18:25:50.0155332+02:00",
    "RepliedAt": "2008-08-27T18:25:50.0155332+02:00",
    "AlertTimeout": "1995-04-03T18:25:50.0155332+02:00",
    "Deadline": "2007-01-02T18:25:50.0155332+01:00",
    "CreatedBy": 229,
    "CreatedByName": "Hansen LLC",
    "Author": "exercitationem",
    "OwnedBy": 502,
    "OwnedByName": "Kunde LLC",
    "Category": 994,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 559,
    "PriorityName": "Moen, Crona and Runte",
    "BaseStatus": "Active",
    "TicketStatus": 8,
    "TicketStatusDisplayValue": "sed",
    "Origin": "AutoGenerated",
    "CustId": 668,
    "PersonFirstname": "Prince",
    "PersonMiddleName": "Prohaska Inc and Sons",
    "PersonLastname": "Frami",
    "PersonFullname": "ea",
    "AlertLevel": 588,
    "ConnectId": 343,
    "ReadStatus": "Green",
    "TimeToReply": 525,
    "RealTimeToReply": 586,
    "TimeToClose": 684,
    "RealTimeToClose": 220,
    "TimeSpentInternally": 162,
    "TimeSpentExternally": 993,
    "TimeSpentQueue": 165,
    "RealTimeSpentInternally": 981,
    "RealTimeSpentExternally": 422,
    "RealTimeSpentQueue": 492,
    "HasAttachment": false,
    "NumReplies": 688,
    "NumMessages": 581,
    "FromAddress": "aspernatur",
    "ContactId": 629,
    "ContactName": "Fahey, Kessler and Krajcik",
    "OwnedByAssociateId": 704,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 528
      }
    }
  },
  "TransferTo": {
    "AssociateId": 319,
    "Name": "Wolff-Funk",
    "PersonId": 144,
    "Rank": 94,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 35,
    "FullName": "Tiana Wehner V",
    "FormalName": "Spinka, Greenfelder and Predovic",
    "Deleted": false,
    "EjUserId": 949,
    "UserName": "Reichel Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 179
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
      "FieldLength": 693
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```