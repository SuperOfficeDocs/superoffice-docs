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
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/ChatSession
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 684,
  "TopicId": 16,
  "User": {
    "AssociateId": 181,
    "Name": "Langosh-Wunsch",
    "PersonId": 981,
    "Rank": 89,
    "Tooltip": "quo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 121,
    "FullName": "Golden Kiehn",
    "FormalName": "Wiza, Fisher and Terry",
    "Deleted": true,
    "EjUserId": 126,
    "UserName": "Kilback-Schmeler"
  },
  "Person": {
    "Position": "deserunt",
    "PersonId": 907,
    "Mrmrs": "dignissimos",
    "Firstname": "Chadd",
    "Lastname": "Nolan",
    "MiddleName": "Lind-Labadie",
    "Title": "repellendus",
    "Description": "User-friendly regional application",
    "Email": "lurline@johnson.info",
    "FullName": "Jalen Will",
    "DirectPhone": "1-873-501-5358 x04500",
    "FormalName": "Mayert, Kshlerin and Johns",
    "CountryId": 662,
    "ContactId": 976,
    "ContactName": "Daniel Group",
    "Retired": 355,
    "Rank": 240,
    "ActiveInterests": 149,
    "ContactDepartment": "",
    "ContactCountryId": 237,
    "ContactOrgNr": "643492",
    "FaxPhone": "442-608-3715 x210",
    "MobilePhone": "(236)724-0286",
    "ContactPhone": "(627)881-4250 x0725",
    "AssociateName": "Bayer-Lueilwitz",
    "AssociateId": 444,
    "UsePersonAddress": true,
    "ContactFax": "accusantium",
    "Kanafname": "quaerat",
    "Kanalname": "quibusdam",
    "Post1": "reprehenderit",
    "Post2": "quia",
    "Post3": "quia",
    "EmailName": "javon.jerde@moentreutel.us",
    "ContactFullName": "Maynard Sporer",
    "ActiveErpLinks": 437,
    "TicketPriorityId": 11,
    "SupportLanguageId": 138,
    "SupportAssociateId": 518,
    "CategoryName": "VIP Customer"
  },
  "CustomerAlias": "non",
  "CustomerHost": "ducimus",
  "CustomerName": "Stehr-Lemke",
  "CustomerEmail": "margarete.abshire@dach.info",
  "CustomerPhone": "284.321.0351",
  "CustomerConsented": false,
  "CustomerCompanyName": "Deckow Inc and Sons",
  "Status": "Closed",
  "FirstMessage": "minima",
  "LastMessage": "sit",
  "WhenRequested": "2015-12-27T09:40:58.6783426+01:00",
  "WhenStarted": "2002-10-30T09:40:58.6783426+01:00",
  "WhenEnded": "1996-05-15T09:40:58.6783426+02:00",
  "WhenIdle": "2012-06-09T09:40:58.6783426+02:00",
  "WhenFetched": "2019-05-29T09:40:58.6783426+02:00",
  "SessionKey": "in",
  "InitialQueuePos": 400,
  "AlertLevel": 650,
  "Rank": 771,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 185,
    "Name": "Wilderman, Ondricka and Dooley",
    "OrgNr": "730793",
    "Department": "enhance rich interfaces",
    "URL": "http://www.example.com/",
    "City": "fugiat",
    "DirectPhone": "(554)768-7655 x4253",
    "AssociateId": 685,
    "CountryId": 827,
    "EmailAddress": "fidel_walter@gulgowski.co.uk",
    "Kananame": "tempora",
    "EmailAddressName": "carolyne@moen.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Jodie Buckridge",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "est",
    "FullName": "Paula Spencer",
    "IsOwnerContact": true,
    "ActiveErpLinks": 105
  },
  "Project": {
    "ProjectId": 396,
    "Name": "Strosin LLC",
    "Description": "Distributed homogeneous groupware",
    "URL": "http://www.example.com/",
    "Type": "incidunt",
    "AssociateId": 342,
    "AssociateFullName": "Mattie Gerlach",
    "TypeId": 266,
    "Updated": "1994-08-08T09:40:58.6793694+02:00",
    "StatusId": 769,
    "Status": "placeat",
    "TextId": 769,
    "PublishTo": "2006-10-05T09:40:58.6793694+02:00",
    "PublishFrom": "2010-11-05T09:40:58.6793694+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1101332",
    "ActiveErpLinks": 950
  },
  "Sale": {
    "ContactName": "Mante, Von and Eichmann",
    "SaleDate": "2008-08-09T09:40:58.6793694+02:00",
    "SaleId": 880,
    "Probability": 87,
    "Title": "adipisci",
    "Amount": 28215.402,
    "Currency": "sequi",
    "ProjectName": "Batz-Nolan",
    "AssociateFullName": "Akeem Hintz",
    "Description": "Function-based clear-thinking throughput",
    "Status": "Lost",
    "WeightedAmount": 26635.865999999998,
    "ProjectId": 939,
    "EarningPercent": 26322.466,
    "Earning": 8966.374,
    "ContactId": 43,
    "AssociateId": 75,
    "PersonId": 966,
    "SaleTypeId": 726,
    "SaleTypeName": "Haag-Morar",
    "PersonFullName": "Desiree Upton",
    "Completed": "Completed",
    "ActiveErpLinks": 959,
    "NextDueDate": "2000-02-21T09:40:58.680366+01:00",
    "Number": "1283481"
  },
  "Ticket": {
    "TicketId": 201,
    "Title": "commodi",
    "CreatedAt": "2004-07-23T09:40:58.680366+02:00",
    "LastChanged": "2004-06-21T09:40:58.680366+02:00",
    "ReadByOwner": "1994-09-02T09:40:58.680366+02:00",
    "ReadByCustomer": "2001-09-27T09:40:58.680366+02:00",
    "FirstReadByUser": "2017-11-08T09:40:58.680366+01:00",
    "Activate": "1999-12-26T09:40:58.680366+01:00",
    "ClosedAt": "2011-05-30T09:40:58.680366+02:00",
    "RepliedAt": "2005-05-22T09:40:58.680366+02:00",
    "AlertTimeout": "2006-11-06T09:40:58.680366+01:00",
    "Deadline": "2018-11-16T09:40:58.680366+01:00",
    "CreatedBy": 6,
    "CreatedByName": "Raynor, Wolff and Hilpert",
    "Author": "quo",
    "OwnedBy": 13,
    "OwnedByName": "Konopelski-Klocko",
    "Category": 58,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 74,
    "BaseStatus": "Active",
    "TicketStatus": 738,
    "Origin": "AutoGenerated",
    "CustId": 65,
    "CustFirstname": "Leif",
    "CustMiddleName": "Hegmann, Rodriguez and Daugherty",
    "CustLastname": "Kub",
    "AlertLevel": 330,
    "ConnectId": 229,
    "ReadStatus": "Green",
    "TimeToReply": 331,
    "RealTimeToReply": 952,
    "TimeToClose": 190,
    "RealTimeToClose": 367,
    "TimeSpentInternally": 864,
    "TimeSpentExternally": 783,
    "TimeSpentQueue": 531,
    "RealTimeSpentInternally": 561,
    "RealTimeSpentExternally": 570,
    "RealTimeSpentQueue": 190,
    "HasAttachment": false,
    "NumReplies": 586,
    "NumMessages": 597,
    "FromAddress": "consequatur",
    "CustFullname": "mollitia",
    "TicketStatusDisplayValue": "omnis"
  },
  "TransferTo": {
    "AssociateId": 74,
    "Name": "Waters, Howe and Larkin",
    "PersonId": 297,
    "Rank": 976,
    "Tooltip": "id",
    "Type": "AnonymousAssociate",
    "GroupIdx": 512,
    "FullName": "Mable Corkery PhD",
    "FormalName": "Berge-Hayes",
    "Deleted": true,
    "EjUserId": 598,
    "UserName": "Altenwerth LLC"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 755,
  "TopicId": 647,
  "User": {
    "AssociateId": 808,
    "Name": "Stoltenberg Group",
    "PersonId": 514,
    "Rank": 900,
    "Tooltip": "nihil",
    "Type": "AnonymousAssociate",
    "GroupIdx": 264,
    "FullName": "Israel Strosin",
    "FormalName": "Towne-Durgan",
    "Deleted": true,
    "EjUserId": 976,
    "UserName": "Daugherty Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 576
      }
    }
  },
  "Person": {
    "Position": "autem",
    "PersonId": 310,
    "Mrmrs": "enim",
    "Firstname": "Einar",
    "Lastname": "Langworth",
    "MiddleName": "Conn-Feeney",
    "Title": "earum",
    "Description": "Digitized high-level data-warehouse",
    "Email": "rashad_pfannerstill@spencer.co.uk",
    "FullName": "Marcelo Jakubowski",
    "DirectPhone": "(058)627-1545",
    "FormalName": "Rogahn, Witting and Kassulke",
    "CountryId": 982,
    "ContactId": 734,
    "ContactName": "Roberts Inc and Sons",
    "Retired": 831,
    "Rank": 516,
    "ActiveInterests": 907,
    "ContactDepartment": "",
    "ContactCountryId": 868,
    "ContactOrgNr": "725048",
    "FaxPhone": "(612)428-0481 x48007",
    "MobilePhone": "1-808-667-8803 x5618",
    "ContactPhone": "(288)332-0478",
    "AssociateName": "Bogisich, Lynch and Pfeffer",
    "AssociateId": 854,
    "UsePersonAddress": true,
    "ContactFax": "est",
    "Kanafname": "expedita",
    "Kanalname": "perspiciatis",
    "Post1": "non",
    "Post2": "ut",
    "Post3": "dignissimos",
    "EmailName": "ervin.hand@blanda.com",
    "ContactFullName": "Glennie Kunze",
    "ActiveErpLinks": 932,
    "TicketPriorityId": 613,
    "SupportLanguageId": 51,
    "SupportAssociateId": 775,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 227
      }
    }
  },
  "CustomerAlias": "incidunt",
  "CustomerHost": "inventore",
  "CustomerName": "Goyette, Gulgowski and Romaguera",
  "CustomerEmail": "nathan@cruickshanktorp.ca",
  "CustomerPhone": "455.144.8002 x561",
  "CustomerConsented": true,
  "CustomerCompanyName": "Kub, Bradtke and Towne",
  "Status": "Closed",
  "FirstMessage": "et",
  "LastMessage": "tempora",
  "WhenRequested": "2011-12-16T09:40:58.6873659+01:00",
  "WhenStarted": "2002-10-13T09:40:58.6873659+02:00",
  "WhenEnded": "2000-01-02T09:40:58.6873659+01:00",
  "WhenIdle": "2008-12-09T09:40:58.6873659+01:00",
  "WhenFetched": "2006-04-27T09:40:58.6873659+02:00",
  "SessionKey": "dolorem",
  "InitialQueuePos": 233,
  "AlertLevel": 615,
  "Rank": 322,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 539,
    "Name": "Borer LLC",
    "OrgNr": "1634662",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "est",
    "DirectPhone": "251.252.3263 x8832",
    "AssociateId": 458,
    "CountryId": 711,
    "EmailAddress": "gavin@vonbergnaum.co.uk",
    "Kananame": "ratione",
    "EmailAddressName": "marlene.kling@huels.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Adrian Buckridge",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "amet",
    "FullName": "Breana Roob",
    "IsOwnerContact": false,
    "ActiveErpLinks": 865,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "deliver cross-platform users"
        },
        "FieldType": "System.Int32",
        "FieldLength": 186
      }
    }
  },
  "Project": {
    "ProjectId": 707,
    "Name": "Lehner, Schowalter and Predovic",
    "Description": "Extended bottom-line toolset",
    "URL": "http://www.example.com/",
    "Type": "eveniet",
    "AssociateId": 861,
    "AssociateFullName": "Durward Hermann",
    "TypeId": 430,
    "Updated": "2008-10-31T09:40:58.6883748+01:00",
    "StatusId": 201,
    "Status": "veniam",
    "TextId": 343,
    "PublishTo": "2019-12-13T09:40:58.6883748+01:00",
    "PublishFrom": "1998-01-09T09:40:58.6883748+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "685415",
    "ActiveErpLinks": 108,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 412
      }
    }
  },
  "Sale": {
    "ContactName": "Mitchell, Gleichner and Schroeder",
    "SaleDate": "2002-05-08T09:40:58.6893422+02:00",
    "SaleId": 39,
    "Probability": 936,
    "Title": "assumenda",
    "Amount": 23034.899999999998,
    "Currency": "optio",
    "ProjectName": "Berge, Glover and Schmitt",
    "AssociateFullName": "Joesph Langworth",
    "Description": "Programmable encompassing parallelism",
    "Status": "Lost",
    "WeightedAmount": 26510.505999999998,
    "ProjectId": 139,
    "EarningPercent": 26880.318,
    "Earning": 15450.619999999999,
    "ContactId": 8,
    "AssociateId": 651,
    "PersonId": 591,
    "SaleTypeId": 97,
    "SaleTypeName": "Wehner, Tremblay and Tromp",
    "PersonFullName": "Marley Konopelski",
    "Completed": "Completed",
    "ActiveErpLinks": 392,
    "NextDueDate": "2007-01-10T09:40:58.6893422+01:00",
    "Number": "409595",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 967
      }
    }
  },
  "Ticket": {
    "TicketId": 356,
    "Title": "ea",
    "CreatedAt": "2009-06-30T09:40:58.6893422+02:00",
    "LastChanged": "2002-09-26T09:40:58.6893422+02:00",
    "ReadByOwner": "1995-06-09T09:40:58.6893422+02:00",
    "ReadByCustomer": "2011-05-20T09:40:58.6893422+02:00",
    "FirstReadByUser": "2019-06-16T09:40:58.6893422+02:00",
    "Activate": "2013-08-28T09:40:58.6893422+02:00",
    "ClosedAt": "2018-08-18T09:40:58.6893422+02:00",
    "RepliedAt": "2009-08-21T09:40:58.6893422+02:00",
    "AlertTimeout": "2002-10-23T09:40:58.6893422+02:00",
    "Deadline": "1998-06-15T09:40:58.6893422+02:00",
    "CreatedBy": 546,
    "CreatedByName": "Hartmann, Davis and Nikolaus",
    "Author": "omnis",
    "OwnedBy": 989,
    "OwnedByName": "Armstrong Inc and Sons",
    "Category": 211,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 127,
    "BaseStatus": "Active",
    "TicketStatus": 132,
    "Origin": "AutoGenerated",
    "CustId": 963,
    "CustFirstname": "Jamal",
    "CustMiddleName": "Trantow, Conn and Rolfson",
    "CustLastname": "Greenfelder",
    "AlertLevel": 163,
    "ConnectId": 421,
    "ReadStatus": "Green",
    "TimeToReply": 580,
    "RealTimeToReply": 831,
    "TimeToClose": 624,
    "RealTimeToClose": 161,
    "TimeSpentInternally": 264,
    "TimeSpentExternally": 797,
    "TimeSpentQueue": 835,
    "RealTimeSpentInternally": 847,
    "RealTimeSpentExternally": 593,
    "RealTimeSpentQueue": 881,
    "HasAttachment": true,
    "NumReplies": 909,
    "NumMessages": 120,
    "FromAddress": "reiciendis",
    "CustFullname": "labore",
    "TicketStatusDisplayValue": "eius",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 936
      }
    }
  },
  "TransferTo": {
    "AssociateId": 750,
    "Name": "Williamson Group",
    "PersonId": 941,
    "Rank": 408,
    "Tooltip": "ipsa",
    "Type": "AnonymousAssociate",
    "GroupIdx": 222,
    "FullName": "Cheyanne Crona",
    "FormalName": "Steuber-Steuber",
    "Deleted": true,
    "EjUserId": 10,
    "UserName": "Luettgen Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 200
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
      "FieldLength": 588
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```