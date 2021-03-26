---
title: POST ChatSession/{id}/Reset
id: v1ChatSessionEntity_ResetChatSession
---

# POST ChatSession/{id}/Reset

```http
POST /api/v1/ChatSession/{chatSessionId}/Reset
```

Reset chat session, put it back on the queue for pickup.

Used by bots to hand off a session to human




| Path Part | Type | Description |
|-----------|------|-------------|
| chatSessionId | int32 | id of the chat session to reset **Required** |



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
POST /api/v1/ChatSession/{chatSessionId}/Reset
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 98,
  "TopicId": 82,
  "User": {
    "AssociateId": 194,
    "Name": "Bogan-Wolff",
    "PersonId": 669,
    "Rank": 724,
    "Tooltip": "voluptates",
    "Type": "AnonymousAssociate",
    "GroupIdx": 388,
    "FullName": "Miss Eudora Davis",
    "FormalName": "King, Gutkowski and Fadel",
    "Deleted": false,
    "EjUserId": 75,
    "UserName": "Flatley Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 215
      }
    }
  },
  "Person": {
    "Position": "debitis",
    "PersonId": 534,
    "Mrmrs": "minus",
    "Firstname": "Julio",
    "Lastname": "Witting",
    "MiddleName": "Turcotte, Romaguera and Kuhlman",
    "Title": "incidunt",
    "Description": "Fully-configurable disintermediate toolset",
    "Email": "juana@herzogdubuque.com",
    "FullName": "Aurelie Lind",
    "DirectPhone": "078-134-7420",
    "FormalName": "King Inc and Sons",
    "CountryId": 150,
    "ContactId": 367,
    "ContactName": "Waters Group",
    "Retired": 815,
    "Rank": 362,
    "ActiveInterests": 715,
    "ContactDepartment": "",
    "ContactCountryId": 973,
    "ContactOrgNr": "328636",
    "FaxPhone": "030-303-3441",
    "MobilePhone": "638.868.2762 x28811",
    "ContactPhone": "(142)761-0434",
    "AssociateName": "Wisozk, Rohan and Bechtelar",
    "AssociateId": 788,
    "UsePersonAddress": false,
    "ContactFax": "dolore",
    "Kanafname": "minima",
    "Kanalname": "quis",
    "Post1": "omnis",
    "Post2": "corrupti",
    "Post3": "voluptatibus",
    "EmailName": "ibrahim.emard@crona.com",
    "ContactFullName": "Emile Miller",
    "ActiveErpLinks": 311,
    "TicketPriorityId": 466,
    "SupportLanguageId": 546,
    "SupportAssociateId": 225,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 650
      }
    }
  },
  "CustomerAlias": "harum",
  "CustomerHost": "quisquam",
  "CustomerName": "Smitham LLC",
  "CustomerEmail": "kaia.collier@runolfsson.info",
  "CustomerPhone": "460-577-3785",
  "CustomerConsented": false,
  "CustomerCompanyName": "Shanahan-Runolfsson",
  "Status": "Closed",
  "FirstMessage": "blanditiis",
  "LastMessage": "non",
  "WhenRequested": "2018-02-03T09:40:58.8263655+01:00",
  "WhenStarted": "2003-08-15T09:40:58.8263655+02:00",
  "WhenEnded": "2012-05-26T09:40:58.8263655+02:00",
  "WhenIdle": "2015-05-11T09:40:58.8263655+02:00",
  "WhenFetched": "2018-04-23T09:40:58.8263655+02:00",
  "SessionKey": "voluptate",
  "InitialQueuePos": 434,
  "AlertLevel": 753,
  "Rank": 203,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 835,
    "Name": "Ratke LLC",
    "OrgNr": "1155445",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "vel",
    "DirectPhone": "287-370-8676 x6055",
    "AssociateId": 363,
    "CountryId": 136,
    "EmailAddress": "telly@kassulke.biz",
    "Kananame": "est",
    "EmailAddressName": "marcia.zulauf@carroll.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Sharon Rath",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "qui",
    "FullName": "Marielle Kassulke MD",
    "IsOwnerContact": false,
    "ActiveErpLinks": 467,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 80
      }
    }
  },
  "Project": {
    "ProjectId": 179,
    "Name": "Veum-Hettinger",
    "Description": "Organized exuding database",
    "URL": "http://www.example.com/",
    "Type": "ut",
    "AssociateId": 993,
    "AssociateFullName": "Arthur Hirthe",
    "TypeId": 695,
    "Updated": "2000-02-25T09:40:58.8273668+01:00",
    "StatusId": 483,
    "Status": "quo",
    "TextId": 170,
    "PublishTo": "2001-10-26T09:40:58.8273668+02:00",
    "PublishFrom": "2000-08-15T09:40:58.8273668+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1257437",
    "ActiveErpLinks": 681,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 693
      }
    }
  },
  "Sale": {
    "ContactName": "Jacobi Inc and Sons",
    "SaleDate": "2015-10-08T09:40:58.8273668+02:00",
    "SaleId": 593,
    "Probability": 111,
    "Title": "qui",
    "Amount": 23624.092,
    "Currency": "molestias",
    "ProjectName": "Gutkowski-Kessler",
    "AssociateFullName": "Coby Cremin",
    "Description": "Front-line optimal success",
    "Status": "Lost",
    "WeightedAmount": 26548.113999999998,
    "ProjectId": 688,
    "EarningPercent": 18879.216,
    "Earning": 27475.778,
    "ContactId": 327,
    "AssociateId": 529,
    "PersonId": 32,
    "SaleTypeId": 260,
    "SaleTypeName": "Hoppe, Hoppe and Lehner",
    "PersonFullName": "Antonia McKenzie",
    "Completed": "Completed",
    "ActiveErpLinks": 886,
    "NextDueDate": "1999-09-27T09:40:58.828342+02:00",
    "Number": "988363",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 663
      }
    }
  },
  "Ticket": {
    "TicketId": 75,
    "Title": "quia",
    "CreatedAt": "2019-07-09T09:40:58.828342+02:00",
    "LastChanged": "2008-10-04T09:40:58.828342+02:00",
    "ReadByOwner": "2006-10-24T09:40:58.828342+02:00",
    "ReadByCustomer": "1996-12-30T09:40:58.828342+01:00",
    "FirstReadByUser": "2013-12-09T09:40:58.828342+01:00",
    "Activate": "1998-07-31T09:40:58.828342+02:00",
    "ClosedAt": "2015-05-16T09:40:58.828342+02:00",
    "RepliedAt": "2011-08-24T09:40:58.828342+02:00",
    "AlertTimeout": "2001-09-01T09:40:58.828342+02:00",
    "Deadline": "2010-04-09T09:40:58.828342+02:00",
    "CreatedBy": 324,
    "CreatedByName": "McClure LLC",
    "Author": "quasi",
    "OwnedBy": 63,
    "OwnedByName": "Braun LLC",
    "Category": 373,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 583,
    "BaseStatus": "Active",
    "TicketStatus": 519,
    "Origin": "AutoGenerated",
    "CustId": 491,
    "CustFirstname": "Gisselle",
    "CustMiddleName": "Johns, Weimann and Schmitt",
    "CustLastname": "Terry",
    "AlertLevel": 321,
    "ConnectId": 970,
    "ReadStatus": "Green",
    "TimeToReply": 159,
    "RealTimeToReply": 501,
    "TimeToClose": 121,
    "RealTimeToClose": 706,
    "TimeSpentInternally": 676,
    "TimeSpentExternally": 723,
    "TimeSpentQueue": 877,
    "RealTimeSpentInternally": 219,
    "RealTimeSpentExternally": 563,
    "RealTimeSpentQueue": 521,
    "HasAttachment": true,
    "NumReplies": 70,
    "NumMessages": 950,
    "FromAddress": "quia",
    "CustFullname": "ut",
    "TicketStatusDisplayValue": "quo",
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
  "TransferTo": {
    "AssociateId": 119,
    "Name": "Schuster-Hilll",
    "PersonId": 297,
    "Rank": 461,
    "Tooltip": "reprehenderit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 369,
    "FullName": "Tanya Macejkovic",
    "FormalName": "Jacobi Group",
    "Deleted": false,
    "EjUserId": 75,
    "UserName": "Purdy-Zulauf",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 189
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
      "FieldType": "System.Int32",
      "FieldLength": 857
    }
  }
}
```