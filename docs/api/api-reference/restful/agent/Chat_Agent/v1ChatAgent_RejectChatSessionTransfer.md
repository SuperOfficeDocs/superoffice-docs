---
title: RejectChatSessionTransfer
id: v1ChatAgent_RejectChatSessionTransfer
---

# RejectChatSessionTransfer

```http
POST /api/v1/Agents/Chat/RejectChatSessionTransfer
```

Do not want.

Deny the transfer to the user. If the session is not being transferred, nothing happens.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/RejectChatSessionTransfer?$select=name,department,category/id
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

## Request Body: request  

ChatSessionId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatSessionId | int32 |  |


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
POST /api/v1/Agents/Chat/RejectChatSessionTransfer
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 358
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 975,
  "TopicId": 198,
  "User": {
    "AssociateId": 697,
    "Name": "Deckow Group",
    "PersonId": 792,
    "Rank": 284,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 49,
    "FullName": "Else Fritsch",
    "FormalName": "Hoppe-Swift",
    "Deleted": false,
    "EjUserId": 389,
    "UserName": "Gusikowski-Lockman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 589
      }
    }
  },
  "Person": {
    "Position": "nihil",
    "PersonId": 883,
    "Mrmrs": "voluptate",
    "Firstname": "Edmond",
    "Lastname": "Hilll",
    "MiddleName": "Sipes-Rohan",
    "Title": "accusamus",
    "Description": "Mandatory holistic synergy",
    "Email": "marjory@kling.name",
    "FullName": "Donato Lubowitz",
    "DirectPhone": "286-568-5375 x846",
    "FormalName": "DuBuque, Okuneva and Johnson",
    "CountryId": 615,
    "ContactId": 361,
    "ContactName": "Keeling Group",
    "Retired": 480,
    "Rank": 31,
    "ActiveInterests": 866,
    "ContactDepartment": "innovate synergistic users",
    "ContactCountryId": 60,
    "ContactOrgNr": "961024",
    "FaxPhone": "1-884-810-1206 x32106",
    "MobilePhone": "(146)840-3357 x5175",
    "ContactPhone": "1-235-666-6252 x6321",
    "AssociateName": "Price, Bergnaum and Barton",
    "AssociateId": 25,
    "UsePersonAddress": false,
    "ContactFax": "est",
    "Kanafname": "iure",
    "Kanalname": "fuga",
    "Post1": "suscipit",
    "Post2": "ea",
    "Post3": "quam",
    "EmailName": "velma@wisozk.us",
    "ContactFullName": "Uriah Kling",
    "ActiveErpLinks": 290,
    "TicketPriorityId": 133,
    "SupportLanguageId": 673,
    "SupportAssociateId": 839,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "morph plug-and-play markets"
        },
        "FieldType": "System.String",
        "FieldLength": 144
      }
    }
  },
  "CustomerAlias": "hic",
  "CustomerHost": "dolorum",
  "CustomerName": "Dicki-Runte",
  "CustomerEmail": "martin@smithdurgan.us",
  "CustomerPhone": "(820)616-0012",
  "CustomerConsented": true,
  "CustomerCompanyName": "Lowe LLC",
  "Status": "Closed",
  "FirstMessage": "voluptate",
  "LastMessage": "accusamus",
  "WhenRequested": "1999-09-22T14:58:03.4472764+02:00",
  "WhenStarted": "2005-11-27T14:58:03.4472764+01:00",
  "WhenEnded": "2008-02-27T14:58:03.4472764+01:00",
  "WhenIdle": "2000-11-24T14:58:03.4472764+01:00",
  "WhenFetched": "2008-02-20T14:58:03.4472764+01:00",
  "SessionKey": "qui",
  "InitialQueuePos": 576,
  "AlertLevel": 792,
  "Rank": 262,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 454,
    "Name": "Hirthe, Little and Orn",
    "OrgNr": "1114508",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "vel",
    "DirectPhone": "668-155-3588",
    "AssociateId": 520,
    "CountryId": 338,
    "EmailAddress": "michaela@leannonleffler.uk",
    "Kananame": "ratione",
    "EmailAddressName": "rashad@schiller.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Miss Loren Labadie",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "aliquid",
    "FullName": "Miss Quincy Ritchie",
    "IsOwnerContact": false,
    "ActiveErpLinks": 352,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 140
      }
    }
  },
  "Project": {
    "ProjectId": 340,
    "Name": "Watsica LLC",
    "Description": "Team-oriented solution-oriented conglomeration",
    "URL": "http://www.example.com/",
    "Type": "qui",
    "AssociateId": 767,
    "AssociateFullName": "Mara Reilly DVM",
    "TypeId": 670,
    "Updated": "2017-04-28T14:58:03.4482809+02:00",
    "StatusId": 593,
    "Status": "harum",
    "TextId": 716,
    "PublishTo": "2021-02-27T14:58:03.4482809+01:00",
    "PublishFrom": "2010-04-19T14:58:03.4482809+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "449704",
    "ActiveErpLinks": 732,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 180
      }
    }
  },
  "Sale": {
    "ContactName": "Wintheiser, Wuckert and Dare",
    "SaleDate": "2008-08-23T14:58:03.4482809+02:00",
    "SaleId": 919,
    "Probability": 860,
    "Title": "assumenda",
    "Amount": 5456.294,
    "Currency": "ullam",
    "ProjectName": "Kling, Brakus and Howell",
    "AssociateFullName": "Dr. Antone O'Connell",
    "Description": "Reverse-engineered optimizing attitude",
    "Status": "Lost",
    "WeightedAmount": 3754.5319999999997,
    "ProjectId": 925,
    "EarningPercent": 14150.01,
    "Earning": 23971.966,
    "ContactId": 308,
    "AssociateId": 153,
    "PersonId": 923,
    "SaleTypeId": 504,
    "SaleTypeName": "Lowe-Becker",
    "PersonFullName": "Marquise Lockman",
    "Completed": "Completed",
    "ActiveErpLinks": 752,
    "NextDueDate": "2013-06-09T14:58:03.4492811+02:00",
    "Number": "821751",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 641
      }
    }
  },
  "Ticket": {
    "TicketId": 263,
    "Title": "saepe",
    "CreatedAt": "2002-09-20T14:58:03.4492811+02:00",
    "LastChanged": "2019-12-19T14:58:03.4492811+01:00",
    "ReadByOwner": "2004-02-03T14:58:03.4492811+01:00",
    "ReadByCustomer": "2019-11-13T14:58:03.4492811+01:00",
    "FirstReadByUser": "2010-03-17T14:58:03.4492811+01:00",
    "Activate": "1995-02-23T14:58:03.4492811+01:00",
    "ClosedAt": "1998-08-16T14:58:03.4492811+02:00",
    "RepliedAt": "2007-03-06T14:58:03.4492811+01:00",
    "AlertTimeout": "2020-02-21T14:58:03.4492811+01:00",
    "Deadline": "2006-07-20T14:58:03.4492811+02:00",
    "CreatedBy": 467,
    "CreatedByName": "O'Kon LLC",
    "Author": "aut",
    "OwnedBy": 686,
    "OwnedByName": "Jacobs Group",
    "Category": 703,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 368,
    "PriorityName": "Heidenreich Inc and Sons",
    "BaseStatus": "Active",
    "TicketStatus": 667,
    "TicketStatusDisplayValue": "ea",
    "Origin": "AutoGenerated",
    "CustId": 192,
    "PersonFirstname": "Maximillia",
    "PersonMiddleName": "Klocko-Stokes",
    "PersonLastname": "Stoltenberg",
    "PersonFullname": "dolores",
    "AlertLevel": 87,
    "ConnectId": 441,
    "ReadStatus": "Green",
    "TimeToReply": 495,
    "RealTimeToReply": 930,
    "TimeToClose": 286,
    "RealTimeToClose": 209,
    "TimeSpentInternally": 971,
    "TimeSpentExternally": 578,
    "TimeSpentQueue": 207,
    "RealTimeSpentInternally": 263,
    "RealTimeSpentExternally": 35,
    "RealTimeSpentQueue": 416,
    "HasAttachment": false,
    "NumReplies": 246,
    "NumMessages": 192,
    "FromAddress": "optio",
    "ContactId": 324,
    "ContactName": "Graham, Johnson and Dare",
    "OwnedByAssociateId": 317,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 396
      }
    }
  },
  "TransferTo": {
    "AssociateId": 244,
    "Name": "Huel Inc and Sons",
    "PersonId": 134,
    "Rank": 92,
    "Tooltip": "eum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 999,
    "FullName": "Alfonso Connelly",
    "FormalName": "Witting LLC",
    "Deleted": false,
    "EjUserId": 371,
    "UserName": "Harris, Klein and Fadel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "deliver next-generation applications"
        },
        "FieldType": "System.String",
        "FieldLength": 265
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
      "FieldLength": 418
    }
  }
}
```