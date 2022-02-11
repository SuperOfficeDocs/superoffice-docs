---
title: POST ChatSession/{id}/RejectTransfer
id: v1ChatSessionEntity_RejectChatSessionTransfer
---

# POST ChatSession/{id}/RejectTransfer

```http
POST /api/v1/ChatSession/{chatSessionId}/RejectTransfer
```

Do not want.

Deny the transfer to the user. If the session is not being transferred, nothing happens.




| Path Part | Type | Description |
|-----------|------|-------------|
| chatSessionId | int32 | id of the chat session to send back **Required** |



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
| ChatbotIsActive | bool | Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/ChatSession/{chatSessionId}/RejectTransfer
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 748,
  "TopicId": 507,
  "User": {
    "AssociateId": 88,
    "Name": "VonRueden-Green",
    "PersonId": 152,
    "Rank": 400,
    "Tooltip": "possimus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 667,
    "FullName": "Sally Kreiger",
    "FormalName": "Beer, Blick and Schmidt",
    "Deleted": true,
    "EjUserId": 852,
    "UserName": "Kemmer Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 809
      }
    }
  },
  "Person": {
    "Position": "doloremque",
    "PersonId": 871,
    "Mrmrs": "rem",
    "Firstname": "Alicia",
    "Lastname": "Nader",
    "MiddleName": "Kuvalis Inc and Sons",
    "Title": "rem",
    "Description": "Robust systematic website",
    "Email": "sylvester_rodriguez@goodwinwiegand.info",
    "FullName": "Zelda Hoeger",
    "DirectPhone": "602-123-3527 x5182",
    "FormalName": "Gibson Group",
    "CountryId": 160,
    "ContactId": 328,
    "ContactName": "Ziemann-Bernier",
    "Retired": 758,
    "Rank": 858,
    "ActiveInterests": 884,
    "ContactDepartment": "",
    "ContactCountryId": 470,
    "ContactOrgNr": "1353830",
    "FaxPhone": "140-380-1050",
    "MobilePhone": "267-337-2867 x466",
    "ContactPhone": "(524)238-7786 x0042",
    "AssociateName": "Block Group",
    "AssociateId": 545,
    "UsePersonAddress": true,
    "ContactFax": "voluptas",
    "Kanafname": "delectus",
    "Kanalname": "dignissimos",
    "Post1": "et",
    "Post2": "dolores",
    "Post3": "qui",
    "EmailName": "elyse_haley@raynor.com",
    "ContactFullName": "Hilario Rosenbaum",
    "ActiveErpLinks": 127,
    "TicketPriorityId": 255,
    "SupportLanguageId": 332,
    "SupportAssociateId": 262,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 944
      }
    }
  },
  "CustomerAlias": "ducimus",
  "CustomerHost": "necessitatibus",
  "CustomerName": "Heidenreich Group",
  "CustomerEmail": "freeda_fadel@mclaughlin.info",
  "CustomerPhone": "843-130-4357 x21728",
  "CustomerConsented": false,
  "CustomerCompanyName": "Satterfield-Hickle",
  "Status": "Closed",
  "FirstMessage": "perferendis",
  "LastMessage": "est",
  "WhenRequested": "1994-07-24T18:25:50.1186249+02:00",
  "WhenStarted": "1999-07-16T18:25:50.1186249+02:00",
  "WhenEnded": "2006-09-29T18:25:50.1186249+02:00",
  "WhenIdle": "2011-01-25T18:25:50.1186249+01:00",
  "WhenFetched": "2001-01-28T18:25:50.1186249+01:00",
  "SessionKey": "amet",
  "InitialQueuePos": 986,
  "AlertLevel": 537,
  "Rank": 448,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 207,
    "Name": "Schumm LLC",
    "OrgNr": "489349",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "excepturi",
    "DirectPhone": "(653)211-1808 x8051",
    "AssociateId": 543,
    "CountryId": 459,
    "EmailAddress": "kim@oconnergottlieb.ca",
    "Kananame": "ut",
    "EmailAddressName": "dusty_dicki@okuneva.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mrs. Demond Durgan",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "dolorum",
    "FullName": "Mr. Arne King",
    "IsOwnerContact": true,
    "ActiveErpLinks": 3,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 49
      }
    }
  },
  "Project": {
    "ProjectId": 982,
    "Name": "Wuckert, Harvey and Stokes",
    "Description": "Intuitive asynchronous concept",
    "URL": "http://www.example.com/",
    "Type": "facilis",
    "AssociateId": 862,
    "AssociateFullName": "Vivien Wiza",
    "TypeId": 428,
    "Updated": "2003-03-02T18:25:50.1196265+01:00",
    "StatusId": 681,
    "Status": "et",
    "TextId": 803,
    "PublishTo": "2013-12-18T18:25:50.1196265+01:00",
    "PublishFrom": "2015-01-10T18:25:50.1196265+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1327543",
    "ActiveErpLinks": 625,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "transition virtual architectures"
        },
        "FieldType": "System.String",
        "FieldLength": 947
      }
    }
  },
  "Sale": {
    "ContactName": "White Group",
    "SaleDate": "2013-07-11T18:25:50.1196265+02:00",
    "SaleId": 945,
    "Probability": 45,
    "Title": "incidunt",
    "Amount": 1382.094,
    "Currency": "quam",
    "ProjectName": "Leannon, Beier and Brekke",
    "AssociateFullName": "Miss Emory Wintheiser",
    "Description": "Decentralized tangible pricing structure",
    "Status": "Lost",
    "WeightedAmount": 25166.02,
    "ProjectId": 28,
    "EarningPercent": 30174.152,
    "Earning": 7408.776,
    "ContactId": 206,
    "AssociateId": 969,
    "PersonId": 328,
    "SaleTypeId": 655,
    "SaleTypeName": "Ferry LLC",
    "PersonFullName": "Alden Ondricka",
    "Completed": "Completed",
    "ActiveErpLinks": 738,
    "NextDueDate": "2018-06-24T18:25:50.1206283+02:00",
    "Number": "1387370",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 196
      }
    }
  },
  "Ticket": {
    "TicketId": 852,
    "Title": "sunt",
    "CreatedAt": "2019-01-30T18:25:50.1206283+01:00",
    "LastChanged": "2019-06-05T18:25:50.1206283+02:00",
    "ReadByOwner": "2021-03-30T18:25:50.1206283+02:00",
    "ReadByCustomer": "2005-09-28T18:25:50.1206283+02:00",
    "FirstReadByUser": "2009-03-09T18:25:50.1206283+01:00",
    "Activate": "2020-04-27T18:25:50.1206283+02:00",
    "ClosedAt": "2011-05-08T18:25:50.1206283+02:00",
    "RepliedAt": "2015-11-28T18:25:50.1206283+01:00",
    "AlertTimeout": "1995-08-07T18:25:50.1206283+02:00",
    "Deadline": "2014-04-01T18:25:50.1206283+02:00",
    "CreatedBy": 982,
    "CreatedByName": "Kreiger, Gibson and Raynor",
    "Author": "sit",
    "OwnedBy": 523,
    "OwnedByName": "Feeney, Bode and Hessel",
    "Category": 414,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 841,
    "PriorityName": "Halvorson-Lang",
    "BaseStatus": "Active",
    "TicketStatus": 133,
    "TicketStatusDisplayValue": "fugit",
    "Origin": "AutoGenerated",
    "CustId": 115,
    "PersonFirstname": "Samanta",
    "PersonMiddleName": "Murphy LLC",
    "PersonLastname": "Rutherford",
    "PersonFullname": "odio",
    "AlertLevel": 809,
    "ConnectId": 703,
    "ReadStatus": "Green",
    "TimeToReply": 757,
    "RealTimeToReply": 319,
    "TimeToClose": 337,
    "RealTimeToClose": 310,
    "TimeSpentInternally": 530,
    "TimeSpentExternally": 492,
    "TimeSpentQueue": 340,
    "RealTimeSpentInternally": 674,
    "RealTimeSpentExternally": 887,
    "RealTimeSpentQueue": 332,
    "HasAttachment": true,
    "NumReplies": 743,
    "NumMessages": 679,
    "FromAddress": "placeat",
    "ContactId": 125,
    "ContactName": "Swaniawski, Lehner and Shields",
    "OwnedByAssociateId": 449,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "facilitate 24/365 supply-chains"
        },
        "FieldType": "System.String",
        "FieldLength": 836
      }
    }
  },
  "TransferTo": {
    "AssociateId": 749,
    "Name": "Schimmel-Goodwin",
    "PersonId": 661,
    "Rank": 315,
    "Tooltip": "occaecati",
    "Type": "AnonymousAssociate",
    "GroupIdx": 10,
    "FullName": "Cleora Schiller",
    "FormalName": "Fahey LLC",
    "Deleted": true,
    "EjUserId": 125,
    "UserName": "Dicki-Rogahn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 275
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
      "FieldLength": 48
    }
  }
}
```