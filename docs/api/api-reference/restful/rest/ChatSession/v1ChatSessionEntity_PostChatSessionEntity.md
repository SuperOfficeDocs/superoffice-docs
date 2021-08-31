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
  "ChatSessionId": 405,
  "TopicId": 509,
  "User": {
    "AssociateId": 878,
    "Name": "Simonis, Gerhold and Bashirian",
    "PersonId": 622,
    "Rank": 857,
    "Tooltip": "fuga",
    "Type": "AnonymousAssociate",
    "GroupIdx": 822,
    "FullName": "Rebeka Haag",
    "FormalName": "Johnston-Collier",
    "Deleted": true,
    "EjUserId": 307,
    "UserName": "O'Conner Inc and Sons"
  },
  "Person": {
    "Position": "ratione",
    "PersonId": 553,
    "Mrmrs": "et",
    "Firstname": "Linnie",
    "Lastname": "Walker",
    "MiddleName": "Adams Inc and Sons",
    "Title": "facere",
    "Description": "Down-sized empowering open architecture",
    "Email": "andrew@townepfeffer.uk",
    "FullName": "Mr. Liam Bernier",
    "DirectPhone": "544.501.7646",
    "FormalName": "Schumm, Dickens and Fay",
    "CountryId": 678,
    "ContactId": 504,
    "ContactName": "Powlowski LLC",
    "Retired": 69,
    "Rank": 93,
    "ActiveInterests": 274,
    "ContactDepartment": "",
    "ContactCountryId": 742,
    "ContactOrgNr": "1123096",
    "FaxPhone": "(864)081-0035",
    "MobilePhone": "128-470-6225 x088",
    "ContactPhone": "102-377-2188 x086",
    "AssociateName": "Orn, Casper and Emard",
    "AssociateId": 291,
    "UsePersonAddress": false,
    "ContactFax": "culpa",
    "Kanafname": "quia",
    "Kanalname": "esse",
    "Post1": "illo",
    "Post2": "et",
    "Post3": "hic",
    "EmailName": "julia_reilly@schimmel.ca",
    "ContactFullName": "Bradly Wolff",
    "ActiveErpLinks": 364,
    "TicketPriorityId": 1000,
    "SupportLanguageId": 380,
    "SupportAssociateId": 882,
    "CategoryName": "VIP Customer"
  },
  "CustomerAlias": "repudiandae",
  "CustomerHost": "quia",
  "CustomerName": "Reichert-Zulauf",
  "CustomerEmail": "russel@sipes.name",
  "CustomerPhone": "(624)282-4004",
  "CustomerConsented": true,
  "CustomerCompanyName": "Prosacco-Bode",
  "Status": "Closed",
  "FirstMessage": "assumenda",
  "LastMessage": "ut",
  "WhenRequested": "2007-01-09T15:05:41.6140027+01:00",
  "WhenStarted": "2010-09-30T15:05:41.6140027+02:00",
  "WhenEnded": "2017-10-24T15:05:41.6140027+02:00",
  "WhenIdle": "2009-10-25T15:05:41.6140027+01:00",
  "WhenFetched": "2007-10-26T15:05:41.6140027+02:00",
  "SessionKey": "tempora",
  "InitialQueuePos": 802,
  "AlertLevel": 154,
  "Rank": 724,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 315,
    "Name": "Rohan LLC",
    "OrgNr": "913122",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ab",
    "DirectPhone": "1-327-078-0882",
    "AssociateId": 311,
    "CountryId": 659,
    "EmailAddress": "gilberto@mccullough.co.uk",
    "Kananame": "totam",
    "EmailAddressName": "freeman@ebertcronin.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Wilton O'Kon Sr.",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quia",
    "FullName": "Beaulah Crist II",
    "IsOwnerContact": true,
    "ActiveErpLinks": 713
  },
  "Project": {
    "ProjectId": 302,
    "Name": "Tillman Inc and Sons",
    "Description": "Multi-lateral encompassing monitoring",
    "URL": "http://www.example.com/",
    "Type": "commodi",
    "AssociateId": 856,
    "AssociateFullName": "Triston Kohler",
    "TypeId": 8,
    "Updated": "2012-09-07T15:05:41.6140027+02:00",
    "StatusId": 645,
    "Status": "debitis",
    "TextId": 467,
    "PublishTo": "1998-08-03T15:05:41.6140027+02:00",
    "PublishFrom": "2004-04-15T15:05:41.6140027+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1773128",
    "ActiveErpLinks": 245
  },
  "Sale": {
    "ContactName": "Murazik LLC",
    "SaleDate": "2016-02-01T15:05:41.6150024+01:00",
    "SaleId": 286,
    "Probability": 514,
    "Title": "dolores",
    "Amount": 9141.8779999999988,
    "Currency": "sint",
    "ProjectName": "Bayer-Turcotte",
    "AssociateFullName": "Ms. Felipa Keebler",
    "Description": "Function-based holistic paradigm",
    "Status": "Lost",
    "WeightedAmount": 21198.376,
    "ProjectId": 797,
    "EarningPercent": 16064.884,
    "Earning": 30424.872,
    "ContactId": 280,
    "AssociateId": 810,
    "PersonId": 539,
    "SaleTypeId": 78,
    "SaleTypeName": "Hickle Group",
    "PersonFullName": "Mrs. Meredith Casper",
    "Completed": "Completed",
    "ActiveErpLinks": 78,
    "NextDueDate": "2012-04-26T15:05:41.6150024+02:00",
    "Number": "650316"
  },
  "Ticket": {
    "TicketId": 176,
    "Title": "consequatur",
    "CreatedAt": "2020-01-30T15:05:41.6150024+01:00",
    "LastChanged": "2019-04-13T15:05:41.6150024+02:00",
    "ReadByOwner": "1994-12-23T15:05:41.6150024+01:00",
    "ReadByCustomer": "2010-08-19T15:05:41.6150024+02:00",
    "FirstReadByUser": "2013-09-23T15:05:41.6150024+02:00",
    "Activate": "2013-11-27T15:05:41.6150024+01:00",
    "ClosedAt": "2003-03-17T15:05:41.6150024+01:00",
    "RepliedAt": "2007-08-29T15:05:41.6150024+02:00",
    "AlertTimeout": "2008-12-26T15:05:41.6150024+01:00",
    "Deadline": "2007-03-27T15:05:41.6150024+02:00",
    "CreatedBy": 460,
    "CreatedByName": "Rippin, Pollich and Hahn",
    "Author": "et",
    "OwnedBy": 959,
    "OwnedByName": "McClure Inc and Sons",
    "Category": 639,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 559,
    "PriorityName": "Kautzer-Rogahn",
    "BaseStatus": "Active",
    "TicketStatus": 987,
    "TicketStatusDisplayValue": "enim",
    "Origin": "AutoGenerated",
    "CustId": 448,
    "PersonFirstname": "Winnifred",
    "PersonMiddleName": "Tillman-Gutkowski",
    "PersonLastname": "Jakubowski",
    "PersonFullname": "autem",
    "AlertLevel": 523,
    "ConnectId": 856,
    "ReadStatus": "Green",
    "TimeToReply": 483,
    "RealTimeToReply": 887,
    "TimeToClose": 762,
    "RealTimeToClose": 387,
    "TimeSpentInternally": 915,
    "TimeSpentExternally": 764,
    "TimeSpentQueue": 109,
    "RealTimeSpentInternally": 706,
    "RealTimeSpentExternally": 490,
    "RealTimeSpentQueue": 961,
    "HasAttachment": false,
    "NumReplies": 660,
    "NumMessages": 422,
    "FromAddress": "esse",
    "ContactId": 53,
    "ContactName": "Lesch, Hamill and Ledner",
    "OwnedByAssociateId": 198
  },
  "TransferTo": {
    "AssociateId": 258,
    "Name": "Kutch, Rolfson and Feil",
    "PersonId": 432,
    "Rank": 932,
    "Tooltip": "impedit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 62,
    "FullName": "Candice Lueilwitz",
    "FormalName": "McLaughlin, Bayer and Skiles",
    "Deleted": false,
    "EjUserId": 880,
    "UserName": "Sauer-Legros"
  },
  "ChatbotIsActive": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 812,
  "TopicId": 92,
  "User": {
    "AssociateId": 569,
    "Name": "Cassin, Schmeler and Macejkovic",
    "PersonId": 120,
    "Rank": 617,
    "Tooltip": "distinctio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 87,
    "FullName": "Aurelio Crist",
    "FormalName": "Willms, Erdman and Smitham",
    "Deleted": false,
    "EjUserId": 403,
    "UserName": "Quitzon, Bailey and Ernser",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 804
      }
    }
  },
  "Person": {
    "Position": "nemo",
    "PersonId": 68,
    "Mrmrs": "beatae",
    "Firstname": "Andreanne",
    "Lastname": "Lynch",
    "MiddleName": "Harvey Group",
    "Title": "numquam",
    "Description": "Object-based tertiary solution",
    "Email": "alford_kozey@wintheiserhodkiewicz.biz",
    "FullName": "Kari Jaskolski",
    "DirectPhone": "1-768-544-7533",
    "FormalName": "Mraz-Barton",
    "CountryId": 597,
    "ContactId": 586,
    "ContactName": "Lemke-Kub",
    "Retired": 303,
    "Rank": 901,
    "ActiveInterests": 860,
    "ContactDepartment": "",
    "ContactCountryId": 147,
    "ContactOrgNr": "341738",
    "FaxPhone": "178-561-6663 x3076",
    "MobilePhone": "(243)533-7361 x7244",
    "ContactPhone": "564.738.6662 x82811",
    "AssociateName": "Moore-Murazik",
    "AssociateId": 211,
    "UsePersonAddress": false,
    "ContactFax": "nihil",
    "Kanafname": "autem",
    "Kanalname": "quis",
    "Post1": "nesciunt",
    "Post2": "molestiae",
    "Post3": "nesciunt",
    "EmailName": "mckenzie@rau.us",
    "ContactFullName": "Luciano Schmitt",
    "ActiveErpLinks": 756,
    "TicketPriorityId": 322,
    "SupportLanguageId": 410,
    "SupportAssociateId": 127,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 610
      }
    }
  },
  "CustomerAlias": "laborum",
  "CustomerHost": "recusandae",
  "CustomerName": "Tillman-Corkery",
  "CustomerEmail": "maynard.larkin@crooksrowe.uk",
  "CustomerPhone": "012.485.3485 x8230",
  "CustomerConsented": true,
  "CustomerCompanyName": "Medhurst Group",
  "Status": "Closed",
  "FirstMessage": "vero",
  "LastMessage": "et",
  "WhenRequested": "1995-09-02T15:05:41.6240023+02:00",
  "WhenStarted": "2006-01-27T15:05:41.6240023+01:00",
  "WhenEnded": "1999-06-21T15:05:41.6240023+02:00",
  "WhenIdle": "2013-06-09T15:05:41.6240023+02:00",
  "WhenFetched": "2017-08-05T15:05:41.6240023+02:00",
  "SessionKey": "consequuntur",
  "InitialQueuePos": 644,
  "AlertLevel": 995,
  "Rank": 907,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 55,
    "Name": "Torphy, Borer and Mosciski",
    "OrgNr": "860118",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "beatae",
    "DirectPhone": "1-825-728-2018 x61381",
    "AssociateId": 311,
    "CountryId": 212,
    "EmailAddress": "oscar@will.name",
    "Kananame": "ex",
    "EmailAddressName": "elnora.anderson@goyette.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Jed Nikolaus",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "sint",
    "FullName": "Hailey Welch DDS",
    "IsOwnerContact": false,
    "ActiveErpLinks": 291,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 443
      }
    }
  },
  "Project": {
    "ProjectId": 297,
    "Name": "Kutch Inc and Sons",
    "Description": "De-engineered zero administration knowledge user",
    "URL": "http://www.example.com/",
    "Type": "tempore",
    "AssociateId": 231,
    "AssociateFullName": "Harold Walter",
    "TypeId": 946,
    "Updated": "2017-12-07T15:05:41.6250022+01:00",
    "StatusId": 882,
    "Status": "dolores",
    "TextId": 365,
    "PublishTo": "2015-04-19T15:05:41.6250022+02:00",
    "PublishFrom": "2002-09-26T15:05:41.6250022+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1232658",
    "ActiveErpLinks": 576,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 94
      }
    }
  },
  "Sale": {
    "ContactName": "Volkman, Stanton and Hammes",
    "SaleDate": "1997-12-23T15:05:41.6250022+01:00",
    "SaleId": 812,
    "Probability": 967,
    "Title": "eaque",
    "Amount": 25814.757999999998,
    "Currency": "sed",
    "ProjectName": "Wisoky, Champlin and Zulauf",
    "AssociateFullName": "Jaydon Zulauf",
    "Description": "Pre-emptive responsive protocol",
    "Status": "Lost",
    "WeightedAmount": 4431.476,
    "ProjectId": 953,
    "EarningPercent": 23508.134,
    "Earning": 19609.438,
    "ContactId": 195,
    "AssociateId": 125,
    "PersonId": 672,
    "SaleTypeId": 659,
    "SaleTypeName": "Wintheiser, Klocko and Wiza",
    "PersonFullName": "Antonina Bosco",
    "Completed": "Completed",
    "ActiveErpLinks": 136,
    "NextDueDate": "2016-12-31T15:05:41.6260024+01:00",
    "Number": "772914",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 758
      }
    }
  },
  "Ticket": {
    "TicketId": 704,
    "Title": "eum",
    "CreatedAt": "2000-04-03T15:05:41.6260024+02:00",
    "LastChanged": "2020-12-25T15:05:41.6260024+01:00",
    "ReadByOwner": "2021-04-11T15:05:41.6260024+02:00",
    "ReadByCustomer": "1995-03-23T15:05:41.6260024+01:00",
    "FirstReadByUser": "2013-08-25T15:05:41.6260024+02:00",
    "Activate": "1997-04-20T15:05:41.6260024+02:00",
    "ClosedAt": "2010-09-01T15:05:41.6260024+02:00",
    "RepliedAt": "2002-04-15T15:05:41.6260024+02:00",
    "AlertTimeout": "2011-07-12T15:05:41.6260024+02:00",
    "Deadline": "2018-07-08T15:05:41.6260024+02:00",
    "CreatedBy": 186,
    "CreatedByName": "Kassulke, Hilll and Cummerata",
    "Author": "sequi",
    "OwnedBy": 477,
    "OwnedByName": "Schulist, Walsh and Prohaska",
    "Category": 422,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 452,
    "PriorityName": "Hickle-Doyle",
    "BaseStatus": "Active",
    "TicketStatus": 839,
    "TicketStatusDisplayValue": "et",
    "Origin": "AutoGenerated",
    "CustId": 742,
    "PersonFirstname": "Shyanne",
    "PersonMiddleName": "White-Abbott",
    "PersonLastname": "Cummings",
    "PersonFullname": "repudiandae",
    "AlertLevel": 366,
    "ConnectId": 723,
    "ReadStatus": "Green",
    "TimeToReply": 951,
    "RealTimeToReply": 399,
    "TimeToClose": 903,
    "RealTimeToClose": 78,
    "TimeSpentInternally": 145,
    "TimeSpentExternally": 245,
    "TimeSpentQueue": 962,
    "RealTimeSpentInternally": 283,
    "RealTimeSpentExternally": 712,
    "RealTimeSpentQueue": 911,
    "HasAttachment": true,
    "NumReplies": 83,
    "NumMessages": 606,
    "FromAddress": "sint",
    "ContactId": 825,
    "ContactName": "Dooley-Towne",
    "OwnedByAssociateId": 534,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 688
      }
    }
  },
  "TransferTo": {
    "AssociateId": 481,
    "Name": "Christiansen-Cremin",
    "PersonId": 310,
    "Rank": 910,
    "Tooltip": "natus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 475,
    "FullName": "Amie Mante",
    "FormalName": "Beier LLC",
    "Deleted": false,
    "EjUserId": 714,
    "UserName": "Lynch Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 486
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
      "FieldLength": 689
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```