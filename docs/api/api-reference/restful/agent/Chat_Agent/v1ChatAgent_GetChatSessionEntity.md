---
title: POST Agents/Chat/GetChatSessionEntity
id: v1ChatAgent_GetChatSessionEntity
---

# POST Agents/Chat/GetChatSessionEntity

```http
POST /api/v1/Agents/Chat/GetChatSessionEntity
```

Gets a ChatSessionEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| chatSessionEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/GetChatSessionEntity?chatSessionEntityId=59
POST /api/v1/Agents/Chat/GetChatSessionEntity?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
POST /api/v1/Agents/Chat/GetChatSessionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 192,
  "TopicId": 694,
  "User": {
    "AssociateId": 600,
    "Name": "Waelchi LLC",
    "PersonId": 905,
    "Rank": 3,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 830,
    "FullName": "Ana Langosh",
    "FormalName": "Dooley LLC",
    "Deleted": false,
    "EjUserId": 788,
    "UserName": "Barton, Towne and Schultz",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 819
      }
    }
  },
  "Person": {
    "Position": "magnam",
    "PersonId": 814,
    "Mrmrs": "officia",
    "Firstname": "Ernesto",
    "Lastname": "Lemke",
    "MiddleName": "Murazik, Tremblay and Rempel",
    "Title": "velit",
    "Description": "Public-key bi-directional framework",
    "Email": "kamren@rohanleuschke.com",
    "FullName": "Katlynn Zemlak",
    "DirectPhone": "(117)751-3076",
    "FormalName": "Beatty Inc and Sons",
    "CountryId": 578,
    "ContactId": 523,
    "ContactName": "Keeling, Gutmann and Rogahn",
    "Retired": 759,
    "Rank": 378,
    "ActiveInterests": 79,
    "ContactDepartment": "",
    "ContactCountryId": 524,
    "ContactOrgNr": "863630",
    "FaxPhone": "420.720.2138",
    "MobilePhone": "253-273-0020 x27607",
    "ContactPhone": "802-204-8877",
    "AssociateName": "Auer, Zulauf and Waelchi",
    "AssociateId": 407,
    "UsePersonAddress": true,
    "ContactFax": "deserunt",
    "Kanafname": "ipsum",
    "Kanalname": "ab",
    "Post1": "dolores",
    "Post2": "nobis",
    "Post3": "quia",
    "EmailName": "javon@rodriguez.info",
    "ContactFullName": "Astrid Cartwright",
    "ActiveErpLinks": 694,
    "TicketPriorityId": 786,
    "SupportLanguageId": 868,
    "SupportAssociateId": 584,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 520
      }
    }
  },
  "CustomerAlias": "ipsa",
  "CustomerHost": "et",
  "CustomerName": "Barton Inc and Sons",
  "CustomerEmail": "london@sporer.info",
  "CustomerPhone": "576.241.5142",
  "CustomerConsented": true,
  "CustomerCompanyName": "Schoen Inc and Sons",
  "Status": "Closed",
  "FirstMessage": "sed",
  "LastMessage": "reiciendis",
  "WhenRequested": "2011-04-19T16:48:28.8939219+02:00",
  "WhenStarted": "2003-08-19T16:48:28.8939219+02:00",
  "WhenEnded": "2008-09-14T16:48:28.8939219+02:00",
  "WhenIdle": "2007-08-28T16:48:28.8939219+02:00",
  "WhenFetched": "2017-04-29T16:48:28.8939219+02:00",
  "SessionKey": "fugit",
  "InitialQueuePos": 641,
  "AlertLevel": 828,
  "Rank": 928,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 201,
    "Name": "Sporer-Jaskolski",
    "OrgNr": "972443",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "animi",
    "DirectPhone": "477.208.3808",
    "AssociateId": 313,
    "CountryId": 809,
    "EmailAddress": "jayson_cormier@mitchelltorp.uk",
    "Kananame": "minus",
    "EmailAddressName": "titus@olson.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Selena Emard",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "atque",
    "FullName": "Roxanne Sawayn",
    "IsOwnerContact": false,
    "ActiveErpLinks": 184,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 662
      }
    }
  },
  "Project": {
    "ProjectId": 787,
    "Name": "Gibson, Huel and Marquardt",
    "Description": "Horizontal national array",
    "URL": "http://www.example.com/",
    "Type": "dicta",
    "AssociateId": 308,
    "AssociateFullName": "Serena Sanford V",
    "TypeId": 950,
    "Updated": "2015-11-04T16:48:28.8949244+01:00",
    "StatusId": 405,
    "Status": "tenetur",
    "TextId": 113,
    "PublishTo": "2016-09-16T16:48:28.8949244+02:00",
    "PublishFrom": "2000-04-03T16:48:28.8949244+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "510732",
    "ActiveErpLinks": 634,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 528
      }
    }
  },
  "Sale": {
    "ContactName": "Muller-Spencer",
    "SaleDate": "1995-04-11T16:48:28.8949244+02:00",
    "SaleId": 312,
    "Probability": 668,
    "Title": "dicta",
    "Amount": 27162.378,
    "Currency": "possimus",
    "ProjectName": "Christiansen-Batz",
    "AssociateFullName": "Miracle Blanda",
    "Description": "Devolved modular website",
    "Status": "Lost",
    "WeightedAmount": 23370.237999999998,
    "ProjectId": 815,
    "EarningPercent": 17199.392,
    "Earning": 19433.934,
    "ContactId": 179,
    "AssociateId": 296,
    "PersonId": 71,
    "SaleTypeId": 387,
    "SaleTypeName": "Reinger, Leuschke and Cormier",
    "PersonFullName": "Steve McCullough",
    "Completed": "Completed",
    "ActiveErpLinks": 831,
    "NextDueDate": "2013-03-07T16:48:28.8959242+01:00",
    "Number": "755023",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 354
      }
    }
  },
  "Ticket": {
    "TicketId": 630,
    "Title": "non",
    "CreatedAt": "2019-12-07T16:48:28.8959242+01:00",
    "LastChanged": "2008-06-18T16:48:28.8959242+02:00",
    "ReadByOwner": "2005-12-10T16:48:28.8959242+01:00",
    "ReadByCustomer": "2000-02-17T16:48:28.8959242+01:00",
    "FirstReadByUser": "1995-07-19T16:48:28.8959242+02:00",
    "Activate": "2015-08-18T16:48:28.8959242+02:00",
    "ClosedAt": "1997-12-09T16:48:28.8959242+01:00",
    "RepliedAt": "2003-03-26T16:48:28.8959242+01:00",
    "AlertTimeout": "1999-01-10T16:48:28.8959242+01:00",
    "Deadline": "2013-03-30T16:48:28.8959242+01:00",
    "CreatedBy": 329,
    "CreatedByName": "Hilpert LLC",
    "Author": "eos",
    "OwnedBy": 995,
    "OwnedByName": "Howe LLC",
    "Category": 137,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 686,
    "BaseStatus": "Active",
    "TicketStatus": 886,
    "Origin": "AutoGenerated",
    "CustId": 514,
    "CustFirstname": "Forest",
    "CustMiddleName": "McClure, Dietrich and Zemlak",
    "CustLastname": "Lind",
    "AlertLevel": 367,
    "ConnectId": 23,
    "ReadStatus": "Green",
    "TimeToReply": 172,
    "RealTimeToReply": 958,
    "TimeToClose": 603,
    "RealTimeToClose": 946,
    "TimeSpentInternally": 711,
    "TimeSpentExternally": 247,
    "TimeSpentQueue": 774,
    "RealTimeSpentInternally": 746,
    "RealTimeSpentExternally": 503,
    "RealTimeSpentQueue": 163,
    "HasAttachment": false,
    "NumReplies": 821,
    "NumMessages": 614,
    "FromAddress": "labore",
    "CustFullname": "et",
    "TicketStatusDisplayValue": "autem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 888
      }
    }
  },
  "TransferTo": {
    "AssociateId": 590,
    "Name": "Kuhlman, Satterfield and Farrell",
    "PersonId": 97,
    "Rank": 338,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 785,
    "FullName": "Alia Morissette",
    "FormalName": "Stokes-Towne",
    "Deleted": false,
    "EjUserId": 942,
    "UserName": "Reichert, Kertzmann and Pouros",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "harness robust deliverables"
        },
        "FieldType": "System.Int32",
        "FieldLength": 573
      }
    }
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": "exploit robust synergies"
  },
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
}
```