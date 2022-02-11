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
| ChatbotIsActive | bool | Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user. |


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
| ChatbotIsActive | bool | Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/ChatSession/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 646,
  "TopicId": 572,
  "User": {
    "AssociateId": 691,
    "Name": "Koss-Koss",
    "PersonId": 608,
    "Rank": 277,
    "Tooltip": "ducimus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 854,
    "FullName": "Freddy Goldner",
    "FormalName": "Kub, Cummerata and Conroy",
    "Deleted": false,
    "EjUserId": 274,
    "UserName": "Ratke, Zboncak and DuBuque"
  },
  "Person": {
    "Position": "et",
    "PersonId": 436,
    "Mrmrs": "magni",
    "Firstname": "Ursula",
    "Lastname": "Doyle",
    "MiddleName": "Rosenbaum-Beahan",
    "Title": "in",
    "Description": "Organic contextually-based open system",
    "Email": "chester@osinskidicki.name",
    "FullName": "Ophelia Emmerich",
    "DirectPhone": "586.006.7638 x0146",
    "FormalName": "Gorczany-Jakubowski",
    "CountryId": 877,
    "ContactId": 319,
    "ContactName": "Carter, Walsh and Watsica",
    "Retired": 451,
    "Rank": 639,
    "ActiveInterests": 93,
    "ContactDepartment": "",
    "ContactCountryId": 43,
    "ContactOrgNr": "1110352",
    "FaxPhone": "518.504.3624 x7135",
    "MobilePhone": "1-551-848-4255 x01381",
    "ContactPhone": "811-384-1468 x18327",
    "AssociateName": "Schinner-Quitzon",
    "AssociateId": 434,
    "UsePersonAddress": false,
    "ContactFax": "rerum",
    "Kanafname": "aut",
    "Kanalname": "voluptates",
    "Post1": "non",
    "Post2": "ipsam",
    "Post3": "placeat",
    "EmailName": "marquise@adams.name",
    "ContactFullName": "Ms. Margarett Dach",
    "ActiveErpLinks": 513,
    "TicketPriorityId": 782,
    "SupportLanguageId": 470,
    "SupportAssociateId": 897,
    "CategoryName": "VIP Customer"
  },
  "CustomerAlias": "voluptas",
  "CustomerHost": "nihil",
  "CustomerName": "Ledner, Dibbert and West",
  "CustomerEmail": "elisabeth@denesikbayer.com",
  "CustomerPhone": "438-376-2734",
  "CustomerConsented": false,
  "CustomerCompanyName": "Langosh Inc and Sons",
  "Status": "Closed",
  "FirstMessage": "voluptatem",
  "LastMessage": "perferendis",
  "WhenRequested": "1996-10-31T18:25:50.0305347+01:00",
  "WhenStarted": "2019-05-27T18:25:50.0305347+02:00",
  "WhenEnded": "2006-05-03T18:25:50.0305347+02:00",
  "WhenIdle": "1997-06-07T18:25:50.0305347+02:00",
  "WhenFetched": "2011-09-04T18:25:50.0305347+02:00",
  "SessionKey": "asperiores",
  "InitialQueuePos": 744,
  "AlertLevel": 963,
  "Rank": 707,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 87,
    "Name": "Turner, Ebert and Cronin",
    "OrgNr": "1321734",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "quia",
    "DirectPhone": "1-008-816-6282",
    "AssociateId": 457,
    "CountryId": 32,
    "EmailAddress": "burdette@lehner.info",
    "Kananame": "nemo",
    "EmailAddressName": "kaylah@schulistjaskolski.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Dr. Moshe Okuneva",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "voluptas",
    "FullName": "Allan Lueilwitz",
    "IsOwnerContact": false,
    "ActiveErpLinks": 443
  },
  "Project": {
    "ProjectId": 10,
    "Name": "Ziemann LLC",
    "Description": "Realigned intangible migration",
    "URL": "http://www.example.com/",
    "Type": "id",
    "AssociateId": 66,
    "AssociateFullName": "Coty Auer Sr.",
    "TypeId": 845,
    "Updated": "2016-08-11T18:25:50.0315641+02:00",
    "StatusId": 836,
    "Status": "blanditiis",
    "TextId": 459,
    "PublishTo": "2018-08-31T18:25:50.0315641+02:00",
    "PublishFrom": "1999-11-17T18:25:50.0315641+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1030251",
    "ActiveErpLinks": 259
  },
  "Sale": {
    "ContactName": "Hoppe-Dickens",
    "SaleDate": "2007-07-09T18:25:50.0315641+02:00",
    "SaleId": 106,
    "Probability": 390,
    "Title": "sed",
    "Amount": 5860.58,
    "Currency": "maiores",
    "ProjectName": "Hilll-Bahringer",
    "AssociateFullName": "Terry Schneider",
    "Description": "Ergonomic solution-oriented process improvement",
    "Status": "Lost",
    "WeightedAmount": 15460.021999999999,
    "ProjectId": 228,
    "EarningPercent": 20317.721999999998,
    "Earning": 29421.992,
    "ContactId": 76,
    "AssociateId": 102,
    "PersonId": 540,
    "SaleTypeId": 325,
    "SaleTypeName": "Wiegand Inc and Sons",
    "PersonFullName": "Jacynthe Swift",
    "Completed": "Completed",
    "ActiveErpLinks": 708,
    "NextDueDate": "2019-09-16T18:25:50.0315641+02:00",
    "Number": "1786902"
  },
  "Ticket": {
    "TicketId": 677,
    "Title": "reiciendis",
    "CreatedAt": "2012-05-30T18:25:50.0315641+02:00",
    "LastChanged": "2016-03-18T18:25:50.0315641+01:00",
    "ReadByOwner": "2016-07-29T18:25:50.0315641+02:00",
    "ReadByCustomer": "2005-07-12T18:25:50.0315641+02:00",
    "FirstReadByUser": "2010-01-08T18:25:50.0315641+01:00",
    "Activate": "2004-03-07T18:25:50.0315641+01:00",
    "ClosedAt": "2016-06-07T18:25:50.0315641+02:00",
    "RepliedAt": "2021-11-21T18:25:50.0315641+01:00",
    "AlertTimeout": "2018-05-24T18:25:50.0315641+02:00",
    "Deadline": "1997-09-10T18:25:50.0315641+02:00",
    "CreatedBy": 561,
    "CreatedByName": "Cummerata-Cronin",
    "Author": "qui",
    "OwnedBy": 31,
    "OwnedByName": "Zulauf Group",
    "Category": 984,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 700,
    "PriorityName": "Vandervort Inc and Sons",
    "BaseStatus": "Active",
    "TicketStatus": 214,
    "TicketStatusDisplayValue": "minima",
    "Origin": "AutoGenerated",
    "CustId": 88,
    "PersonFirstname": "Rashawn",
    "PersonMiddleName": "Thompson-Kertzmann",
    "PersonLastname": "Roberts",
    "PersonFullname": "nam",
    "AlertLevel": 893,
    "ConnectId": 125,
    "ReadStatus": "Green",
    "TimeToReply": 825,
    "RealTimeToReply": 404,
    "TimeToClose": 787,
    "RealTimeToClose": 916,
    "TimeSpentInternally": 710,
    "TimeSpentExternally": 86,
    "TimeSpentQueue": 167,
    "RealTimeSpentInternally": 495,
    "RealTimeSpentExternally": 932,
    "RealTimeSpentQueue": 540,
    "HasAttachment": false,
    "NumReplies": 106,
    "NumMessages": 999,
    "FromAddress": "molestias",
    "ContactId": 900,
    "ContactName": "Graham, Bode and Yundt",
    "OwnedByAssociateId": 278
  },
  "TransferTo": {
    "AssociateId": 850,
    "Name": "Kovacek, Rempel and O'Conner",
    "PersonId": 281,
    "Rank": 101,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 108,
    "FullName": "Orlo Reichert",
    "FormalName": "Lang Group",
    "Deleted": true,
    "EjUserId": 484,
    "UserName": "Fay LLC"
  },
  "ChatbotIsActive": true
}
```

```http_
HTTP/1.1 200 ChatSessionEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 129,
  "TopicId": 81,
  "User": {
    "AssociateId": 785,
    "Name": "Rodriguez-Stoltenberg",
    "PersonId": 793,
    "Rank": 452,
    "Tooltip": "quisquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 448,
    "FullName": "Miss Jordane Blanda",
    "FormalName": "Murray LLC",
    "Deleted": false,
    "EjUserId": 97,
    "UserName": "Bechtelar-Spencer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 834
      }
    }
  },
  "Person": {
    "Position": "accusantium",
    "PersonId": 843,
    "Mrmrs": "et",
    "Firstname": "Sandrine",
    "Lastname": "Bednar",
    "MiddleName": "Carroll Inc and Sons",
    "Title": "maxime",
    "Description": "Cloned asynchronous forecast",
    "Email": "desiree@miller.name",
    "FullName": "Eryn Murray",
    "DirectPhone": "546.088.3183",
    "FormalName": "Thiel-Wisozk",
    "CountryId": 381,
    "ContactId": 227,
    "ContactName": "Emard, Williamson and Balistreri",
    "Retired": 824,
    "Rank": 720,
    "ActiveInterests": 581,
    "ContactDepartment": "",
    "ContactCountryId": 58,
    "ContactOrgNr": "1382961",
    "FaxPhone": "(638)661-6433 x211",
    "MobilePhone": "516-632-6356 x327",
    "ContactPhone": "(045)234-5706 x8628",
    "AssociateName": "Hoeger, West and Sawayn",
    "AssociateId": 829,
    "UsePersonAddress": true,
    "ContactFax": "qui",
    "Kanafname": "voluptatem",
    "Kanalname": "exercitationem",
    "Post1": "commodi",
    "Post2": "quia",
    "Post3": "reprehenderit",
    "EmailName": "anthony@wardpagac.co.uk",
    "ContactFullName": "Nick Robel",
    "ActiveErpLinks": 807,
    "TicketPriorityId": 80,
    "SupportLanguageId": 988,
    "SupportAssociateId": 822,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 547
      }
    }
  },
  "CustomerAlias": "possimus",
  "CustomerHost": "voluptatum",
  "CustomerName": "Lockman-Mante",
  "CustomerEmail": "eveline@berge.co.uk",
  "CustomerPhone": "442-148-6880 x62324",
  "CustomerConsented": false,
  "CustomerCompanyName": "Armstrong Group",
  "Status": "Closed",
  "FirstMessage": "harum",
  "LastMessage": "consequatur",
  "WhenRequested": "2007-09-01T18:25:50.0395631+02:00",
  "WhenStarted": "1997-11-04T18:25:50.0395631+01:00",
  "WhenEnded": "2000-11-17T18:25:50.0395631+01:00",
  "WhenIdle": "2012-09-16T18:25:50.0395631+02:00",
  "WhenFetched": "2015-06-06T18:25:50.0395631+02:00",
  "SessionKey": "aut",
  "InitialQueuePos": 443,
  "AlertLevel": 728,
  "Rank": 239,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 296,
    "Name": "Treutel-Haley",
    "OrgNr": "1202373",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ea",
    "DirectPhone": "1-217-707-5453 x7525",
    "AssociateId": 588,
    "CountryId": 135,
    "EmailAddress": "marcelle@witting.ca",
    "Kananame": "omnis",
    "EmailAddressName": "edgardo@pricedaniel.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Wade Langosh",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "veniam",
    "FullName": "Tierra Kuhlman",
    "IsOwnerContact": true,
    "ActiveErpLinks": 931,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 850
      }
    }
  },
  "Project": {
    "ProjectId": 731,
    "Name": "Cummings, Gerhold and Rempel",
    "Description": "Open-architected coherent circuit",
    "URL": "http://www.example.com/",
    "Type": "et",
    "AssociateId": 481,
    "AssociateFullName": "Anastacio Berge",
    "TypeId": 644,
    "Updated": "2000-01-10T18:25:50.0395631+01:00",
    "StatusId": 484,
    "Status": "corporis",
    "TextId": 733,
    "PublishTo": "2000-03-30T18:25:50.0395631+02:00",
    "PublishFrom": "1998-11-02T18:25:50.0395631+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1332399",
    "ActiveErpLinks": 903,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 289
      }
    }
  },
  "Sale": {
    "ContactName": "Goodwin-Kuhic",
    "SaleDate": "2014-01-03T18:25:50.0405657+01:00",
    "SaleId": 51,
    "Probability": 520,
    "Title": "vitae",
    "Amount": 30459.345999999998,
    "Currency": "nihil",
    "ProjectName": "Leannon-Bode",
    "AssociateFullName": "Lottie Murazik",
    "Description": "Synergistic static forecast",
    "Status": "Lost",
    "WeightedAmount": 16707.354,
    "ProjectId": 658,
    "EarningPercent": 11526.851999999999,
    "Earning": 1789.514,
    "ContactId": 888,
    "AssociateId": 588,
    "PersonId": 192,
    "SaleTypeId": 905,
    "SaleTypeName": "Gutmann, Haley and Ondricka",
    "PersonFullName": "Tod DuBuque Sr.",
    "Completed": "Completed",
    "ActiveErpLinks": 14,
    "NextDueDate": "2018-06-26T18:25:50.0405657+02:00",
    "Number": "1081315",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 375
      }
    }
  },
  "Ticket": {
    "TicketId": 322,
    "Title": "dolorem",
    "CreatedAt": "2002-03-14T18:25:50.0405657+01:00",
    "LastChanged": "2014-05-22T18:25:50.0405657+02:00",
    "ReadByOwner": "2012-07-05T18:25:50.0405657+02:00",
    "ReadByCustomer": "2021-02-08T18:25:50.0405657+01:00",
    "FirstReadByUser": "2017-05-15T18:25:50.0405657+02:00",
    "Activate": "1998-11-15T18:25:50.0405657+01:00",
    "ClosedAt": "1995-05-13T18:25:50.0405657+02:00",
    "RepliedAt": "2004-12-16T18:25:50.0405657+01:00",
    "AlertTimeout": "2018-08-08T18:25:50.0405657+02:00",
    "Deadline": "2015-07-28T18:25:50.0405657+02:00",
    "CreatedBy": 164,
    "CreatedByName": "Ward, Daugherty and Considine",
    "Author": "iure",
    "OwnedBy": 754,
    "OwnedByName": "Corwin-Mitchell",
    "Category": 478,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 853,
    "PriorityName": "Osinski, Bayer and Marks",
    "BaseStatus": "Active",
    "TicketStatus": 341,
    "TicketStatusDisplayValue": "similique",
    "Origin": "AutoGenerated",
    "CustId": 25,
    "PersonFirstname": "Christian",
    "PersonMiddleName": "Willms-Graham",
    "PersonLastname": "Kunze",
    "PersonFullname": "sapiente",
    "AlertLevel": 588,
    "ConnectId": 41,
    "ReadStatus": "Green",
    "TimeToReply": 852,
    "RealTimeToReply": 195,
    "TimeToClose": 753,
    "RealTimeToClose": 224,
    "TimeSpentInternally": 819,
    "TimeSpentExternally": 282,
    "TimeSpentQueue": 641,
    "RealTimeSpentInternally": 622,
    "RealTimeSpentExternally": 959,
    "RealTimeSpentQueue": 868,
    "HasAttachment": false,
    "NumReplies": 245,
    "NumMessages": 418,
    "FromAddress": "nemo",
    "ContactId": 495,
    "ContactName": "Jacobi, Mills and Sauer",
    "OwnedByAssociateId": 549,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 996
      }
    }
  },
  "TransferTo": {
    "AssociateId": 595,
    "Name": "Brakus-Funk",
    "PersonId": 45,
    "Rank": 191,
    "Tooltip": "iusto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 2,
    "FullName": "Thaddeus Schuster",
    "FormalName": "Rice, Price and Berge",
    "Deleted": false,
    "EjUserId": 704,
    "UserName": "Weimann-Collins",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 525
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
      "FieldType": "System.String",
      "FieldLength": 848
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```