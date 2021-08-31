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
  "ChatSessionId": 311,
  "TopicId": 441,
  "User": {
    "AssociateId": 485,
    "Name": "Barrows, Sauer and Homenick",
    "PersonId": 712,
    "Rank": 972,
    "Tooltip": "modi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 859,
    "FullName": "Evelyn Koss PhD",
    "FormalName": "Toy LLC",
    "Deleted": false,
    "EjUserId": 717,
    "UserName": "Lindgren Group"
  },
  "Person": {
    "Position": "animi",
    "PersonId": 785,
    "Mrmrs": "quae",
    "Firstname": "Edna",
    "Lastname": "Carroll",
    "MiddleName": "Dach Group",
    "Title": "impedit",
    "Description": "Secured responsive adapter",
    "Email": "lorine_sauer@abbott.name",
    "FullName": "Margot Denesik",
    "DirectPhone": "1-025-180-0150 x860",
    "FormalName": "Pfeffer, Koss and Kuphal",
    "CountryId": 761,
    "ContactId": 111,
    "ContactName": "Streich Group",
    "Retired": 314,
    "Rank": 850,
    "ActiveInterests": 520,
    "ContactDepartment": "",
    "ContactCountryId": 787,
    "ContactOrgNr": "1710388",
    "FaxPhone": "130-508-1666 x67858",
    "MobilePhone": "(622)346-5861",
    "ContactPhone": "1-652-213-7745 x46637",
    "AssociateName": "Hegmann, Lakin and Bailey",
    "AssociateId": 881,
    "UsePersonAddress": false,
    "ContactFax": "blanditiis",
    "Kanafname": "unde",
    "Kanalname": "molestiae",
    "Post1": "et",
    "Post2": "sed",
    "Post3": "molestiae",
    "EmailName": "glennie.kulas@larkinkemmer.com",
    "ContactFullName": "Gisselle Kihn",
    "ActiveErpLinks": 236,
    "TicketPriorityId": 526,
    "SupportLanguageId": 538,
    "SupportAssociateId": 18,
    "CategoryName": "VIP Customer"
  },
  "CustomerAlias": "impedit",
  "CustomerHost": "voluptatum",
  "CustomerName": "Friesen-Donnelly",
  "CustomerEmail": "cary.powlowski@wuckertkoch.us",
  "CustomerPhone": "1-457-686-4785 x6040",
  "CustomerConsented": false,
  "CustomerCompanyName": "Bradtke LLC",
  "Status": "Closed",
  "FirstMessage": "deserunt",
  "LastMessage": "tempora",
  "WhenRequested": "2003-03-22T15:05:41.641003+01:00",
  "WhenStarted": "1999-09-22T15:05:41.641003+02:00",
  "WhenEnded": "2006-06-20T15:05:41.641003+02:00",
  "WhenIdle": "1996-06-23T15:05:41.641003+02:00",
  "WhenFetched": "2018-07-25T15:05:41.641003+02:00",
  "SessionKey": "reiciendis",
  "InitialQueuePos": 458,
  "AlertLevel": 745,
  "Rank": 375,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 951,
    "Name": "Rice-Ryan",
    "OrgNr": "1043314",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "atque",
    "DirectPhone": "(512)166-3575",
    "AssociateId": 154,
    "CountryId": 852,
    "EmailAddress": "bethany@hoppe.co.uk",
    "Kananame": "magni",
    "EmailAddressName": "london_berge@green.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Kris Doyle",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "nesciunt",
    "FullName": "Miss Daphney Runte",
    "IsOwnerContact": true,
    "ActiveErpLinks": 156
  },
  "Project": {
    "ProjectId": 542,
    "Name": "Wehner, Schultz and Kulas",
    "Description": "Compatible clear-thinking middleware",
    "URL": "http://www.example.com/",
    "Type": "eligendi",
    "AssociateId": 174,
    "AssociateFullName": "Geovanni Konopelski",
    "TypeId": 939,
    "Updated": "2004-01-28T15:05:41.6420025+01:00",
    "StatusId": 564,
    "Status": "sunt",
    "TextId": 651,
    "PublishTo": "2011-04-08T15:05:41.6420025+02:00",
    "PublishFrom": "2018-08-08T15:05:41.6420025+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1096056",
    "ActiveErpLinks": 952
  },
  "Sale": {
    "ContactName": "Gibson, Armstrong and Heller",
    "SaleDate": "2017-06-11T15:05:41.6420025+02:00",
    "SaleId": 27,
    "Probability": 993,
    "Title": "rem",
    "Amount": 7693.9699999999993,
    "Currency": "illum",
    "ProjectName": "Windler-Veum",
    "AssociateFullName": "Johnpaul Nienow",
    "Description": "Open-architected optimizing secured line",
    "Status": "Lost",
    "WeightedAmount": 6948.0779999999995,
    "ProjectId": 458,
    "EarningPercent": 1432.238,
    "Earning": 24125.532,
    "ContactId": 679,
    "AssociateId": 742,
    "PersonId": 776,
    "SaleTypeId": 430,
    "SaleTypeName": "Schuppe-Smith",
    "PersonFullName": "Harley Tromp",
    "Completed": "Completed",
    "ActiveErpLinks": 464,
    "NextDueDate": "2006-11-25T15:05:41.6430025+01:00",
    "Number": "988642"
  },
  "Ticket": {
    "TicketId": 533,
    "Title": "eligendi",
    "CreatedAt": "2003-12-01T15:05:41.6430025+01:00",
    "LastChanged": "2001-04-01T15:05:41.6430025+02:00",
    "ReadByOwner": "2019-03-15T15:05:41.6430025+01:00",
    "ReadByCustomer": "2018-03-09T15:05:41.6430025+01:00",
    "FirstReadByUser": "2001-06-24T15:05:41.6430025+02:00",
    "Activate": "2002-03-04T15:05:41.6430025+01:00",
    "ClosedAt": "2005-03-24T15:05:41.6430025+01:00",
    "RepliedAt": "2005-03-30T15:05:41.6430025+02:00",
    "AlertTimeout": "2005-03-03T15:05:41.6430025+01:00",
    "Deadline": "2015-05-22T15:05:41.6430025+02:00",
    "CreatedBy": 132,
    "CreatedByName": "Bauch, Luettgen and Haag",
    "Author": "ut",
    "OwnedBy": 252,
    "OwnedByName": "Baumbach LLC",
    "Category": 176,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 826,
    "PriorityName": "Anderson-Beier",
    "BaseStatus": "Active",
    "TicketStatus": 100,
    "TicketStatusDisplayValue": "et",
    "Origin": "AutoGenerated",
    "CustId": 699,
    "PersonFirstname": "Justen",
    "PersonMiddleName": "Gusikowski, Parisian and Lowe",
    "PersonLastname": "Abernathy",
    "PersonFullname": "eum",
    "AlertLevel": 50,
    "ConnectId": 218,
    "ReadStatus": "Green",
    "TimeToReply": 416,
    "RealTimeToReply": 422,
    "TimeToClose": 861,
    "RealTimeToClose": 50,
    "TimeSpentInternally": 158,
    "TimeSpentExternally": 156,
    "TimeSpentQueue": 802,
    "RealTimeSpentInternally": 592,
    "RealTimeSpentExternally": 455,
    "RealTimeSpentQueue": 954,
    "HasAttachment": true,
    "NumReplies": 475,
    "NumMessages": 767,
    "FromAddress": "in",
    "ContactId": 727,
    "ContactName": "Lowe-Kuphal",
    "OwnedByAssociateId": 236
  },
  "TransferTo": {
    "AssociateId": 324,
    "Name": "Greenholt, Lang and Rohan",
    "PersonId": 8,
    "Rank": 706,
    "Tooltip": "dolore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 218,
    "FullName": "Vernon Hilpert",
    "FormalName": "Christiansen-Cremin",
    "Deleted": true,
    "EjUserId": 894,
    "UserName": "Mante, Haley and Skiles"
  },
  "ChatbotIsActive": false
}
```

```http_
HTTP/1.1 200 ChatSessionEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 692,
  "TopicId": 461,
  "User": {
    "AssociateId": 101,
    "Name": "Haley-Fadel",
    "PersonId": 274,
    "Rank": 676,
    "Tooltip": "quibusdam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 948,
    "FullName": "Jaylen Little",
    "FormalName": "Von, Auer and Johns",
    "Deleted": true,
    "EjUserId": 642,
    "UserName": "Kunze-Reichert",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "leverage dynamic infomediaries"
        },
        "FieldType": "System.String",
        "FieldLength": 839
      }
    }
  },
  "Person": {
    "Position": "eos",
    "PersonId": 880,
    "Mrmrs": "temporibus",
    "Firstname": "Mollie",
    "Lastname": "Gaylord",
    "MiddleName": "Schowalter Inc and Sons",
    "Title": "atque",
    "Description": "Stand-alone empowering conglomeration",
    "Email": "millie@harriskessler.biz",
    "FullName": "Dr. Georgiana Cronin",
    "DirectPhone": "321.088.3850 x40615",
    "FormalName": "Mohr Inc and Sons",
    "CountryId": 696,
    "ContactId": 47,
    "ContactName": "Howell, VonRueden and Cartwright",
    "Retired": 452,
    "Rank": 967,
    "ActiveInterests": 368,
    "ContactDepartment": "",
    "ContactCountryId": 186,
    "ContactOrgNr": "1859632",
    "FaxPhone": "(273)876-3807 x614",
    "MobilePhone": "517-548-6128 x3058",
    "ContactPhone": "765-107-8761 x7668",
    "AssociateName": "O'Keefe, Schamberger and Morar",
    "AssociateId": 817,
    "UsePersonAddress": true,
    "ContactFax": "quo",
    "Kanafname": "qui",
    "Kanalname": "consequatur",
    "Post1": "sed",
    "Post2": "iste",
    "Post3": "voluptatem",
    "EmailName": "ford@bosco.name",
    "ContactFullName": "Pansy Reilly",
    "ActiveErpLinks": 389,
    "TicketPriorityId": 72,
    "SupportLanguageId": 478,
    "SupportAssociateId": 658,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 490
      }
    }
  },
  "CustomerAlias": "animi",
  "CustomerHost": "temporibus",
  "CustomerName": "Kautzer-Cruickshank",
  "CustomerEmail": "chelsie@doyle.uk",
  "CustomerPhone": "136-236-6471 x057",
  "CustomerConsented": false,
  "CustomerCompanyName": "Schinner Group",
  "Status": "Closed",
  "FirstMessage": "quae",
  "LastMessage": "tenetur",
  "WhenRequested": "2012-08-07T15:05:41.6500025+02:00",
  "WhenStarted": "2011-10-10T15:05:41.6500025+02:00",
  "WhenEnded": "1999-12-24T15:05:41.6500025+01:00",
  "WhenIdle": "1996-03-04T15:05:41.6500025+01:00",
  "WhenFetched": "2019-10-23T15:05:41.6500025+02:00",
  "SessionKey": "et",
  "InitialQueuePos": 747,
  "AlertLevel": 290,
  "Rank": 64,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 952,
    "Name": "Blick, Wiegand and Stark",
    "OrgNr": "1075660",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "placeat",
    "DirectPhone": "1-605-413-3373",
    "AssociateId": 411,
    "CountryId": 204,
    "EmailAddress": "everette@keelingnader.info",
    "Kananame": "odit",
    "EmailAddressName": "vita.spinka@wunsch.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Donato Franecki",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "perferendis",
    "FullName": "Niko Grimes",
    "IsOwnerContact": false,
    "ActiveErpLinks": 672,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 283
      }
    }
  },
  "Project": {
    "ProjectId": 989,
    "Name": "Quitzon-Anderson",
    "Description": "Phased empowering challenge",
    "URL": "http://www.example.com/",
    "Type": "sint",
    "AssociateId": 148,
    "AssociateFullName": "Jaylon Schiller",
    "TypeId": 784,
    "Updated": "1999-12-17T15:05:41.6510024+01:00",
    "StatusId": 792,
    "Status": "sed",
    "TextId": 392,
    "PublishTo": "2018-08-12T15:05:41.6510024+02:00",
    "PublishFrom": "2013-01-26T15:05:41.6510024+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1159166",
    "ActiveErpLinks": 56,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 90
      }
    }
  },
  "Sale": {
    "ContactName": "Boyer Group",
    "SaleDate": "1996-11-11T15:05:41.6510024+01:00",
    "SaleId": 687,
    "Probability": 266,
    "Title": "voluptatem",
    "Amount": 30431.14,
    "Currency": "est",
    "ProjectName": "Muller LLC",
    "AssociateFullName": "Ms. Junior Schowalter",
    "Description": "Virtual hybrid pricing structure",
    "Status": "Lost",
    "WeightedAmount": 25.072,
    "ProjectId": 992,
    "EarningPercent": 25645.522,
    "Earning": 30312.048,
    "ContactId": 915,
    "AssociateId": 381,
    "PersonId": 714,
    "SaleTypeId": 958,
    "SaleTypeName": "Lynch, Barrows and Romaguera",
    "PersonFullName": "Ambrose VonRueden",
    "Completed": "Completed",
    "ActiveErpLinks": 109,
    "NextDueDate": "2007-06-28T15:05:41.6520045+02:00",
    "Number": "1260954",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 33
      }
    }
  },
  "Ticket": {
    "TicketId": 690,
    "Title": "inventore",
    "CreatedAt": "2009-09-14T15:05:41.6520045+02:00",
    "LastChanged": "2007-04-15T15:05:41.6520045+02:00",
    "ReadByOwner": "1996-02-09T15:05:41.6520045+01:00",
    "ReadByCustomer": "1999-12-19T15:05:41.6520045+01:00",
    "FirstReadByUser": "2004-04-13T15:05:41.6520045+02:00",
    "Activate": "2012-07-29T15:05:41.6520045+02:00",
    "ClosedAt": "2002-01-02T15:05:41.6520045+01:00",
    "RepliedAt": "2019-01-27T15:05:41.6520045+01:00",
    "AlertTimeout": "2001-07-19T15:05:41.6520045+02:00",
    "Deadline": "2019-04-09T15:05:41.6520045+02:00",
    "CreatedBy": 720,
    "CreatedByName": "Walker-Haag",
    "Author": "quis",
    "OwnedBy": 91,
    "OwnedByName": "Swaniawski LLC",
    "Category": 53,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 954,
    "PriorityName": "Kling, Anderson and Yost",
    "BaseStatus": "Active",
    "TicketStatus": 704,
    "TicketStatusDisplayValue": "temporibus",
    "Origin": "AutoGenerated",
    "CustId": 194,
    "PersonFirstname": "Emmalee",
    "PersonMiddleName": "Keebler Group",
    "PersonLastname": "Runolfsson",
    "PersonFullname": "quam",
    "AlertLevel": 10,
    "ConnectId": 957,
    "ReadStatus": "Green",
    "TimeToReply": 491,
    "RealTimeToReply": 391,
    "TimeToClose": 168,
    "RealTimeToClose": 570,
    "TimeSpentInternally": 464,
    "TimeSpentExternally": 214,
    "TimeSpentQueue": 926,
    "RealTimeSpentInternally": 654,
    "RealTimeSpentExternally": 981,
    "RealTimeSpentQueue": 818,
    "HasAttachment": true,
    "NumReplies": 11,
    "NumMessages": 798,
    "FromAddress": "incidunt",
    "ContactId": 337,
    "ContactName": "Heathcote-Kovacek",
    "OwnedByAssociateId": 394,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 160
      }
    }
  },
  "TransferTo": {
    "AssociateId": 605,
    "Name": "McCullough LLC",
    "PersonId": 324,
    "Rank": 660,
    "Tooltip": "dolorum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 457,
    "FullName": "Elvera Green",
    "FormalName": "Lebsack-Bartoletti",
    "Deleted": false,
    "EjUserId": 597,
    "UserName": "Koelpin, Bradtke and Hackett",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 433
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
      "FieldLength": 952
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```