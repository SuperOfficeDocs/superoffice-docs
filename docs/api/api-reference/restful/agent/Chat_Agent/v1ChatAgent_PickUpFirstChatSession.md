---
title: POST Agents/Chat/PickUpFirstChatSession
id: v1ChatAgent_PickUpFirstChatSession
---

# POST Agents/Chat/PickUpFirstChatSession

```http
POST /api/v1/Agents/Chat/PickUpFirstChatSession
```

'answer' the first available session from the queue: assign the session to the user.

The welcome message is sent to the customer.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/PickUpFirstChatSession?$select=name,department,category/id
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
| ChatbotIsActive | bool | Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Chat/PickUpFirstChatSession
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 992,
  "TopicId": 146,
  "User": {
    "AssociateId": 827,
    "Name": "Corkery-Schmitt",
    "PersonId": 112,
    "Rank": 572,
    "Tooltip": "repellat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 737,
    "FullName": "Charlotte Kozey",
    "FormalName": "O'Reilly Group",
    "Deleted": true,
    "EjUserId": 738,
    "UserName": "Kilback, Gulgowski and Tremblay",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 665
      }
    }
  },
  "Person": {
    "Position": "tempore",
    "PersonId": 436,
    "Mrmrs": "est",
    "Firstname": "Erna",
    "Lastname": "Raynor",
    "MiddleName": "Monahan, Roberts and Bartell",
    "Title": "est",
    "Description": "Up-sized tangible installation",
    "Email": "darrion_sanford@torp.co.uk",
    "FullName": "Arnulfo Lind",
    "DirectPhone": "825-847-3581 x24648",
    "FormalName": "Jones, Ankunding and Yost",
    "CountryId": 560,
    "ContactId": 797,
    "ContactName": "Wisozk, Lebsack and Breitenberg",
    "Retired": 986,
    "Rank": 858,
    "ActiveInterests": 311,
    "ContactDepartment": "",
    "ContactCountryId": 153,
    "ContactOrgNr": "1032654",
    "FaxPhone": "864.382.0488",
    "MobilePhone": "1-528-331-5708",
    "ContactPhone": "(821)748-1873",
    "AssociateName": "Goyette Group",
    "AssociateId": 829,
    "UsePersonAddress": true,
    "ContactFax": "excepturi",
    "Kanafname": "necessitatibus",
    "Kanalname": "vero",
    "Post1": "eos",
    "Post2": "repellendus",
    "Post3": "deleniti",
    "EmailName": "hillary_wuckert@dickinson.biz",
    "ContactFullName": "Dejuan Boyle DDS",
    "ActiveErpLinks": 128,
    "TicketPriorityId": 320,
    "SupportLanguageId": 947,
    "SupportAssociateId": 101,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 219
      }
    }
  },
  "CustomerAlias": "reiciendis",
  "CustomerHost": "beatae",
  "CustomerName": "Durgan Group",
  "CustomerEmail": "stuart@gibsonbarrows.uk",
  "CustomerPhone": "(252)380-7020 x386",
  "CustomerConsented": false,
  "CustomerCompanyName": "White, Botsford and Goodwin",
  "Status": "Closed",
  "FirstMessage": "non",
  "LastMessage": "harum",
  "WhenRequested": "2008-08-28T18:28:48.3152862+02:00",
  "WhenStarted": "1997-01-10T18:28:48.3152862+01:00",
  "WhenEnded": "1996-02-11T18:28:48.3152862+01:00",
  "WhenIdle": "2013-03-17T18:28:48.3152862+01:00",
  "WhenFetched": "2003-02-09T18:28:48.3152862+01:00",
  "SessionKey": "nobis",
  "InitialQueuePos": 984,
  "AlertLevel": 71,
  "Rank": 355,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 56,
    "Name": "Simonis-Jaskolski",
    "OrgNr": "1624419",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "expedita",
    "DirectPhone": "1-514-028-3826 x5387",
    "AssociateId": 453,
    "CountryId": 975,
    "EmailAddress": "clyde.nicolas@heathcote.com",
    "Kananame": "non",
    "EmailAddressName": "marlon@schmittkirlin.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Tobin Schuppe DDS",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "incidunt",
    "FullName": "Santa Hane",
    "IsOwnerContact": false,
    "ActiveErpLinks": 793,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 453
      }
    }
  },
  "Project": {
    "ProjectId": 44,
    "Name": "Prosacco, Dare and Cole",
    "Description": "Devolved 3rd generation leverage",
    "URL": "http://www.example.com/",
    "Type": "culpa",
    "AssociateId": 320,
    "AssociateFullName": "Nicholas Smith",
    "TypeId": 676,
    "Updated": "2011-03-12T18:28:48.3162583+01:00",
    "StatusId": 476,
    "Status": "beatae",
    "TextId": 150,
    "PublishTo": "2021-11-01T18:28:48.3162583+01:00",
    "PublishFrom": "1995-05-27T18:28:48.3162583+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1016624",
    "ActiveErpLinks": 796,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 554
      }
    }
  },
  "Sale": {
    "ContactName": "Becker, Beier and Blick",
    "SaleDate": "2019-10-24T18:28:48.3162583+02:00",
    "SaleId": 732,
    "Probability": 895,
    "Title": "voluptatem",
    "Amount": 9593.1739999999991,
    "Currency": "nisi",
    "ProjectName": "Davis-Daugherty",
    "AssociateFullName": "Macie Bartell",
    "Description": "Profound methodical extranet",
    "Status": "Lost",
    "WeightedAmount": 31158.228,
    "ProjectId": 530,
    "EarningPercent": 14090.464,
    "Earning": 2341.098,
    "ContactId": 265,
    "AssociateId": 228,
    "PersonId": 638,
    "SaleTypeId": 340,
    "SaleTypeName": "Rath, Koelpin and Runte",
    "PersonFullName": "Dillon Green",
    "Completed": "Completed",
    "ActiveErpLinks": 763,
    "NextDueDate": "1996-01-22T18:28:48.3162583+01:00",
    "Number": "1343465",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 660
      }
    }
  },
  "Ticket": {
    "TicketId": 471,
    "Title": "ullam",
    "CreatedAt": "2003-12-14T18:28:48.3172864+01:00",
    "LastChanged": "2018-01-05T18:28:48.3172864+01:00",
    "ReadByOwner": "2011-08-16T18:28:48.3172864+02:00",
    "ReadByCustomer": "2003-11-20T18:28:48.3172864+01:00",
    "FirstReadByUser": "2007-09-11T18:28:48.3172864+02:00",
    "Activate": "2015-06-17T18:28:48.3172864+02:00",
    "ClosedAt": "2009-11-22T18:28:48.3172864+01:00",
    "RepliedAt": "2020-04-12T18:28:48.3172864+02:00",
    "AlertTimeout": "2007-05-07T18:28:48.3172864+02:00",
    "Deadline": "2004-09-25T18:28:48.3172864+02:00",
    "CreatedBy": 3,
    "CreatedByName": "Orn-Zemlak",
    "Author": "sed",
    "OwnedBy": 496,
    "OwnedByName": "Renner, Kuhn and Veum",
    "Category": 596,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 272,
    "PriorityName": "Breitenberg, Koss and Lockman",
    "BaseStatus": "Active",
    "TicketStatus": 588,
    "TicketStatusDisplayValue": "id",
    "Origin": "AutoGenerated",
    "CustId": 929,
    "PersonFirstname": "Will",
    "PersonMiddleName": "Huel Inc and Sons",
    "PersonLastname": "Welch",
    "PersonFullname": "magnam",
    "AlertLevel": 207,
    "ConnectId": 759,
    "ReadStatus": "Green",
    "TimeToReply": 761,
    "RealTimeToReply": 479,
    "TimeToClose": 831,
    "RealTimeToClose": 856,
    "TimeSpentInternally": 923,
    "TimeSpentExternally": 237,
    "TimeSpentQueue": 448,
    "RealTimeSpentInternally": 781,
    "RealTimeSpentExternally": 741,
    "RealTimeSpentQueue": 22,
    "HasAttachment": true,
    "NumReplies": 62,
    "NumMessages": 168,
    "FromAddress": "hic",
    "ContactId": 415,
    "ContactName": "Torphy, Smitham and Welch",
    "OwnedByAssociateId": 838,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 13
      }
    }
  },
  "TransferTo": {
    "AssociateId": 786,
    "Name": "Kertzmann Group",
    "PersonId": 199,
    "Rank": 245,
    "Tooltip": "quo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 512,
    "FullName": "Dovie Morissette V",
    "FormalName": "Connelly, Anderson and Streich",
    "Deleted": false,
    "EjUserId": 543,
    "UserName": "Bartell, Grant and Braun",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 369
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
        "Reason": "generate innovative partnerships"
      },
      "FieldType": "System.Int32",
      "FieldLength": 846
    }
  }
}
```