---
title: CreateDefaultChatSessionEntity
id: v1ChatAgent_CreateDefaultChatSessionEntity
---

# CreateDefaultChatSessionEntity

```http
POST /api/v1/Agents/Chat/CreateDefaultChatSessionEntity
```

Set default values into a new ChatSessionEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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
POST /api/v1/Agents/Chat/CreateDefaultChatSessionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 887,
  "TopicId": 878,
  "User": {
    "AssociateId": 462,
    "Name": "Schamberger-Ritchie",
    "PersonId": 554,
    "Rank": 368,
    "Tooltip": "itaque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 467,
    "FullName": "Reilly Kling",
    "FormalName": "Hyatt Inc and Sons",
    "Deleted": false,
    "EjUserId": 692,
    "UserName": "Heidenreich-Tromp",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 590
      }
    }
  },
  "Person": {
    "Position": "perspiciatis",
    "PersonId": 317,
    "Mrmrs": "omnis",
    "Firstname": "Hayden",
    "Lastname": "Hudson",
    "MiddleName": "Miller Inc and Sons",
    "Title": "non",
    "Description": "Ameliorated asynchronous project",
    "Email": "desiree@kirlin.us",
    "FullName": "Joesph Beier",
    "DirectPhone": "544-885-3117 x8230",
    "FormalName": "Price-Stiedemann",
    "CountryId": 151,
    "ContactId": 102,
    "ContactName": "Stracke-Mertz",
    "Retired": 708,
    "Rank": 888,
    "ActiveInterests": 644,
    "ContactDepartment": "",
    "ContactCountryId": 569,
    "ContactOrgNr": "502352",
    "FaxPhone": "675.868.5515 x17785",
    "MobilePhone": "1-336-545-3460 x65310",
    "ContactPhone": "720.063.2412",
    "AssociateName": "Kertzmann, Hyatt and Ziemann",
    "AssociateId": 724,
    "UsePersonAddress": false,
    "ContactFax": "eligendi",
    "Kanafname": "neque",
    "Kanalname": "libero",
    "Post1": "beatae",
    "Post2": "ipsa",
    "Post3": "eligendi",
    "EmailName": "trenton@wisozk.name",
    "ContactFullName": "Louvenia Thompson",
    "ActiveErpLinks": 491,
    "TicketPriorityId": 212,
    "SupportLanguageId": 928,
    "SupportAssociateId": 113,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 671
      }
    }
  },
  "CustomerAlias": "magni",
  "CustomerHost": "nisi",
  "CustomerName": "Hartmann LLC",
  "CustomerEmail": "stuart_dubuque@anderson.us",
  "CustomerPhone": "218.073.8077 x440",
  "CustomerConsented": true,
  "CustomerCompanyName": "Flatley LLC",
  "Status": "Closed",
  "FirstMessage": "autem",
  "LastMessage": "consectetur",
  "WhenRequested": "2005-03-08T14:58:03.3132407+01:00",
  "WhenStarted": "2003-11-18T14:58:03.3132407+01:00",
  "WhenEnded": "2015-12-04T14:58:03.3132407+01:00",
  "WhenIdle": "2002-10-28T14:58:03.3132407+01:00",
  "WhenFetched": "2012-12-29T14:58:03.3132407+01:00",
  "SessionKey": "ut",
  "InitialQueuePos": 872,
  "AlertLevel": 808,
  "Rank": 515,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 515,
    "Name": "Hammes, Hagenes and O'Conner",
    "OrgNr": "818964",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "voluptatem",
    "DirectPhone": "1-127-204-5278 x215",
    "AssociateId": 295,
    "CountryId": 811,
    "EmailAddress": "bessie@denesik.co.uk",
    "Kananame": "at",
    "EmailAddressName": "jeffrey_waters@hahn.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mr. Jerel Wilderman",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "consequatur",
    "FullName": "Guiseppe Gleason",
    "IsOwnerContact": false,
    "ActiveErpLinks": 730,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 748
      }
    }
  },
  "Project": {
    "ProjectId": 20,
    "Name": "Williamson, McDermott and Mann",
    "Description": "Centralized clear-thinking initiative",
    "URL": "http://www.example.com/",
    "Type": "ea",
    "AssociateId": 315,
    "AssociateFullName": "Citlalli Maggio",
    "TypeId": 848,
    "Updated": "1996-01-24T14:58:03.3142431+01:00",
    "StatusId": 574,
    "Status": "voluptatem",
    "TextId": 104,
    "PublishTo": "2008-06-20T14:58:03.3142431+02:00",
    "PublishFrom": "1999-10-03T14:58:03.3142431+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "431433",
    "ActiveErpLinks": 457,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 243
      }
    }
  },
  "Sale": {
    "ContactName": "Glover Group",
    "SaleDate": "2018-11-21T14:58:03.3142431+01:00",
    "SaleId": 914,
    "Probability": 919,
    "Title": "fuga",
    "Amount": 1081.23,
    "Currency": "accusamus",
    "ProjectName": "Haag-Littel",
    "AssociateFullName": "Christelle Maggio",
    "Description": "Switchable full-range middleware",
    "Status": "Lost",
    "WeightedAmount": 14162.546,
    "ProjectId": 116,
    "EarningPercent": 19054.72,
    "Earning": 8301.966,
    "ContactId": 219,
    "AssociateId": 983,
    "PersonId": 638,
    "SaleTypeId": 480,
    "SaleTypeName": "Greenfelder LLC",
    "PersonFullName": "Dr. Elizabeth Baumbach",
    "Completed": "Completed",
    "ActiveErpLinks": 89,
    "NextDueDate": "2003-10-29T14:58:03.3152408+01:00",
    "Number": "1509959",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 233
      }
    }
  },
  "Ticket": {
    "TicketId": 882,
    "Title": "enim",
    "CreatedAt": "1999-09-24T14:58:03.3152408+02:00",
    "LastChanged": "1996-05-10T14:58:03.3152408+02:00",
    "ReadByOwner": "1997-04-05T14:58:03.3152408+02:00",
    "ReadByCustomer": "1995-12-07T14:58:03.3152408+01:00",
    "FirstReadByUser": "2013-07-15T14:58:03.3152408+02:00",
    "Activate": "1998-09-11T14:58:03.3152408+02:00",
    "ClosedAt": "2019-05-02T14:58:03.3152408+02:00",
    "RepliedAt": "2003-11-07T14:58:03.3152408+01:00",
    "AlertTimeout": "2017-05-21T14:58:03.3152408+02:00",
    "Deadline": "2016-12-30T14:58:03.3152408+01:00",
    "CreatedBy": 838,
    "CreatedByName": "Weber, Raynor and Cormier",
    "Author": "qui",
    "OwnedBy": 423,
    "OwnedByName": "Hessel-Flatley",
    "Category": 481,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 479,
    "PriorityName": "Kuhlman Inc and Sons",
    "BaseStatus": "Active",
    "TicketStatus": 190,
    "TicketStatusDisplayValue": "autem",
    "Origin": "AutoGenerated",
    "CustId": 726,
    "PersonFirstname": "Marcellus",
    "PersonMiddleName": "Lubowitz, Erdman and Herman",
    "PersonLastname": "Cremin",
    "PersonFullname": "eos",
    "AlertLevel": 653,
    "ConnectId": 888,
    "ReadStatus": "Green",
    "TimeToReply": 252,
    "RealTimeToReply": 958,
    "TimeToClose": 996,
    "RealTimeToClose": 864,
    "TimeSpentInternally": 801,
    "TimeSpentExternally": 342,
    "TimeSpentQueue": 403,
    "RealTimeSpentInternally": 811,
    "RealTimeSpentExternally": 311,
    "RealTimeSpentQueue": 132,
    "HasAttachment": true,
    "NumReplies": 324,
    "NumMessages": 786,
    "FromAddress": "facere",
    "ContactId": 807,
    "ContactName": "Terry, Koelpin and D'Amore",
    "OwnedByAssociateId": 795,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 885
      }
    }
  },
  "TransferTo": {
    "AssociateId": 596,
    "Name": "Hirthe, Gleichner and Hoeger",
    "PersonId": 504,
    "Rank": 593,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 234,
    "FullName": "Chelsea Jast",
    "FormalName": "McCullough, Mann and Blanda",
    "Deleted": false,
    "EjUserId": 603,
    "UserName": "Runte-Schneider",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 985
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
      "FieldLength": 980
    }
  }
}
```