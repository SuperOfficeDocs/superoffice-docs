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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 794,
  "TopicId": 97,
  "User": {
    "AssociateId": 460,
    "Name": "Ankunding, Tillman and Terry",
    "PersonId": 202,
    "Rank": 531,
    "Tooltip": "reprehenderit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 473,
    "FullName": "Assunta Padberg",
    "FormalName": "Cronin-Ryan",
    "Deleted": false,
    "EjUserId": 991,
    "UserName": "Murphy LLC"
  },
  "Person": {
    "Position": "est",
    "PersonId": 71,
    "Mrmrs": "nulla",
    "Firstname": "Delores",
    "Lastname": "Rodriguez",
    "MiddleName": "Kshlerin, Windler and Skiles",
    "Title": "dolorem",
    "Description": "Persistent attitude-oriented project",
    "Email": "june@steuberfarrell.com",
    "FullName": "Ms. Ryley Casper",
    "DirectPhone": "(377)144-7527 x332",
    "FormalName": "Koelpin-Heathcote",
    "CountryId": 509,
    "ContactId": 881,
    "ContactName": "Lakin-Toy",
    "Retired": 55,
    "Rank": 982,
    "ActiveInterests": 790,
    "ContactDepartment": "",
    "ContactCountryId": 657,
    "ContactOrgNr": "1157596",
    "FaxPhone": "656.663.1573 x12878",
    "MobilePhone": "132-674-5355 x37057",
    "ContactPhone": "(454)155-4136 x5411",
    "AssociateName": "Dickens, Zulauf and Wintheiser",
    "AssociateId": 286,
    "UsePersonAddress": true,
    "ContactFax": "et",
    "Kanafname": "ipsum",
    "Kanalname": "et",
    "Post1": "nesciunt",
    "Post2": "minima",
    "Post3": "velit",
    "EmailName": "johnnie@hahn.com",
    "ContactFullName": "Rod Cole",
    "ActiveErpLinks": 416,
    "TicketPriorityId": 146,
    "SupportLanguageId": 892,
    "SupportAssociateId": 21,
    "CategoryName": "VIP Customer"
  },
  "CustomerAlias": "nihil",
  "CustomerHost": "sequi",
  "CustomerName": "Boyle, Hickle and Little",
  "CustomerEmail": "rosella@hermannbuckridge.uk",
  "CustomerPhone": "1-310-140-6357 x176",
  "CustomerConsented": true,
  "CustomerCompanyName": "Doyle Group",
  "Status": "Closed",
  "FirstMessage": "accusantium",
  "LastMessage": "quos",
  "WhenRequested": "1998-10-01T18:28:48.1842913+02:00",
  "WhenStarted": "2009-10-01T18:28:48.1842913+02:00",
  "WhenEnded": "2008-12-28T18:28:48.1842913+01:00",
  "WhenIdle": "1999-02-05T18:28:48.1842913+01:00",
  "WhenFetched": "1995-12-01T18:28:48.1842913+01:00",
  "SessionKey": "consequatur",
  "InitialQueuePos": 809,
  "AlertLevel": 984,
  "Rank": 682,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 26,
    "Name": "West-Hayes",
    "OrgNr": "436061",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "vitae",
    "DirectPhone": "252-508-5400",
    "AssociateId": 381,
    "CountryId": 835,
    "EmailAddress": "evan_ortiz@boylekemmer.us",
    "Kananame": "accusamus",
    "EmailAddressName": "alexandrine_yundt@stoltenbergzemlak.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ms. Leif Kiehn",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "vel",
    "FullName": "Conor Stoltenberg II",
    "IsOwnerContact": true,
    "ActiveErpLinks": 299
  },
  "Project": {
    "ProjectId": 906,
    "Name": "Hoppe-Dicki",
    "Description": "Persistent mission-critical orchestration",
    "URL": "http://www.example.com/",
    "Type": "consequatur",
    "AssociateId": 877,
    "AssociateFullName": "Miss Darrell Kemmer",
    "TypeId": 110,
    "Updated": "2014-07-05T18:28:48.1852918+02:00",
    "StatusId": 916,
    "Status": "ut",
    "TextId": 783,
    "PublishTo": "2007-10-11T18:28:48.1852918+02:00",
    "PublishFrom": "2015-07-05T18:28:48.1852918+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1088086",
    "ActiveErpLinks": 432
  },
  "Sale": {
    "ContactName": "Schumm, Kuphal and Johns",
    "SaleDate": "2015-06-18T18:28:48.1852918+02:00",
    "SaleId": 76,
    "Probability": 969,
    "Title": "delectus",
    "Amount": 28472.39,
    "Currency": "cupiditate",
    "ProjectName": "Russel-Corwin",
    "AssociateFullName": "Alf Dooley",
    "Description": "Monitored static concept",
    "Status": "Lost",
    "WeightedAmount": 22057.092,
    "ProjectId": 901,
    "EarningPercent": 9094.868,
    "Earning": 23909.286,
    "ContactId": 823,
    "AssociateId": 584,
    "PersonId": 783,
    "SaleTypeId": 672,
    "SaleTypeName": "Ledner-Willms",
    "PersonFullName": "Quinten Trantow PhD",
    "Completed": "Completed",
    "ActiveErpLinks": 642,
    "NextDueDate": "1994-08-03T18:28:48.1852918+02:00",
    "Number": "1503538"
  },
  "Ticket": {
    "TicketId": 472,
    "Title": "dolorum",
    "CreatedAt": "2011-03-09T18:28:48.1852918+01:00",
    "LastChanged": "2002-07-08T18:28:48.1852918+02:00",
    "ReadByOwner": "2000-11-05T18:28:48.1852918+01:00",
    "ReadByCustomer": "2004-08-23T18:28:48.1852918+02:00",
    "FirstReadByUser": "1998-07-06T18:28:48.1852918+02:00",
    "Activate": "2016-06-17T18:28:48.1852918+02:00",
    "ClosedAt": "2000-03-29T18:28:48.1852918+02:00",
    "RepliedAt": "2010-09-13T18:28:48.1852918+02:00",
    "AlertTimeout": "2011-07-08T18:28:48.1852918+02:00",
    "Deadline": "2015-11-19T18:28:48.1852918+01:00",
    "CreatedBy": 695,
    "CreatedByName": "Mills Inc and Sons",
    "Author": "aliquam",
    "OwnedBy": 387,
    "OwnedByName": "Greenholt, Graham and Cartwright",
    "Category": 564,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 966,
    "PriorityName": "Simonis LLC",
    "BaseStatus": "Active",
    "TicketStatus": 453,
    "TicketStatusDisplayValue": "quos",
    "Origin": "AutoGenerated",
    "CustId": 505,
    "PersonFirstname": "Drake",
    "PersonMiddleName": "Bednar, Bechtelar and Wilderman",
    "PersonLastname": "Walter",
    "PersonFullname": "fugiat",
    "AlertLevel": 119,
    "ConnectId": 583,
    "ReadStatus": "Green",
    "TimeToReply": 113,
    "RealTimeToReply": 783,
    "TimeToClose": 231,
    "RealTimeToClose": 263,
    "TimeSpentInternally": 170,
    "TimeSpentExternally": 746,
    "TimeSpentQueue": 402,
    "RealTimeSpentInternally": 986,
    "RealTimeSpentExternally": 178,
    "RealTimeSpentQueue": 916,
    "HasAttachment": false,
    "NumReplies": 831,
    "NumMessages": 485,
    "FromAddress": "quis",
    "ContactId": 25,
    "ContactName": "Fay-Will",
    "OwnedByAssociateId": 315
  },
  "TransferTo": {
    "AssociateId": 729,
    "Name": "Mohr Inc and Sons",
    "PersonId": 232,
    "Rank": 419,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 824,
    "FullName": "Abelardo Wuckert",
    "FormalName": "Stehr LLC",
    "Deleted": false,
    "EjUserId": 385,
    "UserName": "Quigley-O'Reilly"
  },
  "ChatbotIsActive": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 625,
  "TopicId": 788,
  "User": {
    "AssociateId": 274,
    "Name": "Baumbach-Marquardt",
    "PersonId": 734,
    "Rank": 152,
    "Tooltip": "voluptate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 957,
    "FullName": "Jonas Paucek",
    "FormalName": "Fadel-Treutel",
    "Deleted": false,
    "EjUserId": 642,
    "UserName": "Johnston LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 159
      }
    }
  },
  "Person": {
    "Position": "accusamus",
    "PersonId": 127,
    "Mrmrs": "inventore",
    "Firstname": "Torrance",
    "Lastname": "Schultz",
    "MiddleName": "Cummerata, Grimes and Cruickshank",
    "Title": "officiis",
    "Description": "Multi-lateral zero administration concept",
    "Email": "jace_watsica@powlowski.info",
    "FullName": "Annetta Morar",
    "DirectPhone": "124.163.4248 x200",
    "FormalName": "Larkin-Goyette",
    "CountryId": 62,
    "ContactId": 613,
    "ContactName": "Daniel, Goldner and Erdman",
    "Retired": 476,
    "Rank": 291,
    "ActiveInterests": 681,
    "ContactDepartment": "",
    "ContactCountryId": 854,
    "ContactOrgNr": "659937",
    "FaxPhone": "(082)267-6844",
    "MobilePhone": "650.267.6147 x71328",
    "ContactPhone": "(243)581-2826 x78640",
    "AssociateName": "King Inc and Sons",
    "AssociateId": 583,
    "UsePersonAddress": false,
    "ContactFax": "et",
    "Kanafname": "quas",
    "Kanalname": "iure",
    "Post1": "rem",
    "Post2": "eum",
    "Post3": "voluptates",
    "EmailName": "woodrow_kuhn@trantow.ca",
    "ContactFullName": "Bridie Wyman",
    "ActiveErpLinks": 982,
    "TicketPriorityId": 1001,
    "SupportLanguageId": 742,
    "SupportAssociateId": 498,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 711
      }
    }
  },
  "CustomerAlias": "minus",
  "CustomerHost": "esse",
  "CustomerName": "Kuphal Group",
  "CustomerEmail": "joy@schowalteroberbrunner.uk",
  "CustomerPhone": "826-858-5001 x20043",
  "CustomerConsented": false,
  "CustomerCompanyName": "Rogahn-Lemke",
  "Status": "Closed",
  "FirstMessage": "quia",
  "LastMessage": "sunt",
  "WhenRequested": "2012-04-01T18:28:48.2332924+02:00",
  "WhenStarted": "1994-10-09T18:28:48.2332924+02:00",
  "WhenEnded": "2015-02-17T18:28:48.2332924+01:00",
  "WhenIdle": "2008-02-02T18:28:48.2332924+01:00",
  "WhenFetched": "2006-07-02T18:28:48.2332924+02:00",
  "SessionKey": "natus",
  "InitialQueuePos": 491,
  "AlertLevel": 578,
  "Rank": 153,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 510,
    "Name": "Yost, Corkery and Sanford",
    "OrgNr": "323199",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "fugit",
    "DirectPhone": "(438)580-1216",
    "AssociateId": 937,
    "CountryId": 124,
    "EmailAddress": "lacy_bechtelar@cormiernicolas.info",
    "Kananame": "eos",
    "EmailAddressName": "thurman@nitzsche.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ilene Larkin",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "praesentium",
    "FullName": "Joana Stoltenberg",
    "IsOwnerContact": false,
    "ActiveErpLinks": 933,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 291
      }
    }
  },
  "Project": {
    "ProjectId": 936,
    "Name": "Marquardt Group",
    "Description": "Grass-roots leading edge architecture",
    "URL": "http://www.example.com/",
    "Type": "quidem",
    "AssociateId": 510,
    "AssociateFullName": "Eliseo McDermott",
    "TypeId": 626,
    "Updated": "1996-04-07T18:28:48.2342946+02:00",
    "StatusId": 33,
    "Status": "nemo",
    "TextId": 462,
    "PublishTo": "2012-03-11T18:28:48.2342946+01:00",
    "PublishFrom": "2013-03-03T18:28:48.2342946+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1103386",
    "ActiveErpLinks": 666,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "revolutionize dot-com e-markets"
        },
        "FieldType": "System.Int32",
        "FieldLength": 138
      }
    }
  },
  "Sale": {
    "ContactName": "Emard-Ward",
    "SaleDate": "2017-07-03T18:28:48.2352928+02:00",
    "SaleId": 353,
    "Probability": 412,
    "Title": "ipsa",
    "Amount": 21160.768,
    "Currency": "aut",
    "ProjectName": "Kutch Inc and Sons",
    "AssociateFullName": "Shanel Walsh",
    "Description": "Open-architected fault-tolerant moratorium",
    "Status": "Lost",
    "WeightedAmount": 692.614,
    "ProjectId": 972,
    "EarningPercent": 4976.7919999999995,
    "Earning": 1247.3319999999999,
    "ContactId": 720,
    "AssociateId": 16,
    "PersonId": 976,
    "SaleTypeId": 475,
    "SaleTypeName": "Metz Inc and Sons",
    "PersonFullName": "Ima Streich",
    "Completed": "Completed",
    "ActiveErpLinks": 696,
    "NextDueDate": "2000-08-30T18:28:48.2352928+02:00",
    "Number": "812538",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 454
      }
    }
  },
  "Ticket": {
    "TicketId": 973,
    "Title": "aliquid",
    "CreatedAt": "2007-12-31T18:28:48.2352928+01:00",
    "LastChanged": "2002-09-13T18:28:48.2352928+02:00",
    "ReadByOwner": "2016-04-16T18:28:48.2352928+02:00",
    "ReadByCustomer": "1997-01-29T18:28:48.2352928+01:00",
    "FirstReadByUser": "1994-11-15T18:28:48.2352928+01:00",
    "Activate": "2016-02-13T18:28:48.2352928+01:00",
    "ClosedAt": "2008-02-05T18:28:48.2352928+01:00",
    "RepliedAt": "2019-04-02T18:28:48.2352928+02:00",
    "AlertTimeout": "2010-08-03T18:28:48.2352928+02:00",
    "Deadline": "2015-03-04T18:28:48.2352928+01:00",
    "CreatedBy": 772,
    "CreatedByName": "Murray LLC",
    "Author": "similique",
    "OwnedBy": 426,
    "OwnedByName": "Runolfsdottir Group",
    "Category": 61,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 307,
    "PriorityName": "Corwin Group",
    "BaseStatus": "Active",
    "TicketStatus": 657,
    "TicketStatusDisplayValue": "nisi",
    "Origin": "AutoGenerated",
    "CustId": 189,
    "PersonFirstname": "Presley",
    "PersonMiddleName": "Labadie-Goldner",
    "PersonLastname": "Gleichner",
    "PersonFullname": "laborum",
    "AlertLevel": 829,
    "ConnectId": 832,
    "ReadStatus": "Green",
    "TimeToReply": 454,
    "RealTimeToReply": 125,
    "TimeToClose": 926,
    "RealTimeToClose": 656,
    "TimeSpentInternally": 50,
    "TimeSpentExternally": 738,
    "TimeSpentQueue": 697,
    "RealTimeSpentInternally": 848,
    "RealTimeSpentExternally": 256,
    "RealTimeSpentQueue": 185,
    "HasAttachment": true,
    "NumReplies": 565,
    "NumMessages": 294,
    "FromAddress": "qui",
    "ContactId": 22,
    "ContactName": "Corwin, Wilkinson and Stanton",
    "OwnedByAssociateId": 476,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 321
      }
    }
  },
  "TransferTo": {
    "AssociateId": 267,
    "Name": "Bayer, Gusikowski and Bode",
    "PersonId": 659,
    "Rank": 940,
    "Tooltip": "quo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 183,
    "FullName": "Jermey Schaefer",
    "FormalName": "Willms-Ryan",
    "Deleted": true,
    "EjUserId": 336,
    "UserName": "Feil, Blanda and Green",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 461
      }
    }
  },
  "ChatbotIsActive": false,
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
      "FieldLength": 337
    }
  }
}
```