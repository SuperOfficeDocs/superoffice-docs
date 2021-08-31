---
title: TransferChatSession
id: v1ChatAgent_TransferChatSession
---

# TransferChatSession

```http
POST /api/v1/Agents/Chat/TransferChatSession
```

Request to send the session to another user.

If the session does not belong to the user, nothing happens.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/TransferChatSession?$select=name,department,category/id
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

ChatSessionId, ToAssociate 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatSessionId | int32 |  |
| ToAssociate | string |  |


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
POST /api/v1/Agents/Chat/TransferChatSession
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 993,
  "ToAssociate": "amet"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 78,
  "TopicId": 209,
  "User": {
    "AssociateId": 970,
    "Name": "Harber, Mayert and Veum",
    "PersonId": 671,
    "Rank": 952,
    "Tooltip": "facere",
    "Type": "AnonymousAssociate",
    "GroupIdx": 946,
    "FullName": "Breana Gislason",
    "FormalName": "Rice Group",
    "Deleted": true,
    "EjUserId": 869,
    "UserName": "Boehm-Wisoky",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 455
      }
    }
  },
  "Person": {
    "Position": "vel",
    "PersonId": 85,
    "Mrmrs": "expedita",
    "Firstname": "Hettie",
    "Lastname": "Kovacek",
    "MiddleName": "Dickens, Veum and Keeling",
    "Title": "qui",
    "Description": "Re-contextualized bottom-line task-force",
    "Email": "assunta@schoen.uk",
    "FullName": "Cullen Morissette",
    "DirectPhone": "510-640-4251",
    "FormalName": "Muller, Larkin and Wilderman",
    "CountryId": 434,
    "ContactId": 79,
    "ContactName": "Gutkowski-Bins",
    "Retired": 230,
    "Rank": 144,
    "ActiveInterests": 266,
    "ContactDepartment": "whiteboard scalable partnerships",
    "ContactCountryId": 744,
    "ContactOrgNr": "1218361",
    "FaxPhone": "460-375-1186",
    "MobilePhone": "(456)441-7100 x2137",
    "ContactPhone": "825.325.8560",
    "AssociateName": "Botsford-Connelly",
    "AssociateId": 859,
    "UsePersonAddress": false,
    "ContactFax": "autem",
    "Kanafname": "perspiciatis",
    "Kanalname": "est",
    "Post1": "nesciunt",
    "Post2": "aut",
    "Post3": "omnis",
    "EmailName": "wendy@mohr.ca",
    "ContactFullName": "Lazaro Stiedemann",
    "ActiveErpLinks": 597,
    "TicketPriorityId": 515,
    "SupportLanguageId": 451,
    "SupportAssociateId": 118,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 479
      }
    }
  },
  "CustomerAlias": "sed",
  "CustomerHost": "enim",
  "CustomerName": "Thompson Group",
  "CustomerEmail": "rosalyn.quitzon@dachwitting.ca",
  "CustomerPhone": "755.438.4620",
  "CustomerConsented": false,
  "CustomerCompanyName": "Torphy, Kassulke and Boehm",
  "Status": "Closed",
  "FirstMessage": "nobis",
  "LastMessage": "omnis",
  "WhenRequested": "2016-12-05T14:58:03.428243+01:00",
  "WhenStarted": "2008-03-30T14:58:03.428243+02:00",
  "WhenEnded": "2017-03-20T14:58:03.428243+01:00",
  "WhenIdle": "2019-02-01T14:58:03.428243+01:00",
  "WhenFetched": "2014-07-28T14:58:03.428243+02:00",
  "SessionKey": "et",
  "InitialQueuePos": 358,
  "AlertLevel": 705,
  "Rank": 38,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 627,
    "Name": "Bechtelar, Hahn and Willms",
    "OrgNr": "913251",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "qui",
    "DirectPhone": "002.083.1014 x16224",
    "AssociateId": 502,
    "CountryId": 271,
    "EmailAddress": "brisa.bahringer@heathcote.name",
    "Kananame": "fugit",
    "EmailAddressName": "domenico@murphy.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Andreane Ruecker",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "rerum",
    "FullName": "Darrick Pacocha",
    "IsOwnerContact": false,
    "ActiveErpLinks": 203,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 999
      }
    }
  },
  "Project": {
    "ProjectId": 512,
    "Name": "Fay, Keebler and Schinner",
    "Description": "Intuitive well-modulated project",
    "URL": "http://www.example.com/",
    "Type": "voluptate",
    "AssociateId": 184,
    "AssociateFullName": "Mrs. Zula Rowe",
    "TypeId": 310,
    "Updated": "1998-03-29T14:58:03.4292408+02:00",
    "StatusId": 386,
    "Status": "ipsa",
    "TextId": 841,
    "PublishTo": "2010-12-12T14:58:03.4292408+01:00",
    "PublishFrom": "2001-06-17T14:58:03.4292408+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1489419",
    "ActiveErpLinks": 943,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 511
      }
    }
  },
  "Sale": {
    "ContactName": "Altenwerth-Carroll",
    "SaleDate": "2004-12-04T14:58:03.4292408+01:00",
    "SaleId": 359,
    "Probability": 647,
    "Title": "doloremque",
    "Amount": 24037.78,
    "Currency": "soluta",
    "ProjectName": "Hermann Inc and Sons",
    "AssociateFullName": "Aron Feest",
    "Description": "Universal interactive focus group",
    "Status": "Lost",
    "WeightedAmount": 19527.953999999998,
    "ProjectId": 786,
    "EarningPercent": 4964.2559999999994,
    "Earning": 3732.594,
    "ContactId": 175,
    "AssociateId": 162,
    "PersonId": 696,
    "SaleTypeId": 47,
    "SaleTypeName": "Morissette-Jones",
    "PersonFullName": "Stacey Larkin",
    "Completed": "Completed",
    "ActiveErpLinks": 186,
    "NextDueDate": "2011-01-12T14:58:03.4292408+01:00",
    "Number": "1067097",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 825
      }
    }
  },
  "Ticket": {
    "TicketId": 162,
    "Title": "eum",
    "CreatedAt": "2020-02-11T14:58:03.4292408+01:00",
    "LastChanged": "1996-01-17T14:58:03.4292408+01:00",
    "ReadByOwner": "2003-05-13T14:58:03.4292408+02:00",
    "ReadByCustomer": "2002-04-20T14:58:03.4292408+02:00",
    "FirstReadByUser": "2009-09-20T14:58:03.4292408+02:00",
    "Activate": "1999-01-09T14:58:03.4292408+01:00",
    "ClosedAt": "1999-10-27T14:58:03.4292408+02:00",
    "RepliedAt": "2008-07-28T14:58:03.4292408+02:00",
    "AlertTimeout": "2020-07-12T14:58:03.4292408+02:00",
    "Deadline": "2015-06-29T14:58:03.4292408+02:00",
    "CreatedBy": 960,
    "CreatedByName": "Denesik-Kshlerin",
    "Author": "voluptatibus",
    "OwnedBy": 301,
    "OwnedByName": "Funk-Paucek",
    "Category": 460,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 730,
    "PriorityName": "Stamm, Labadie and Thiel",
    "BaseStatus": "Active",
    "TicketStatus": 677,
    "TicketStatusDisplayValue": "sapiente",
    "Origin": "AutoGenerated",
    "CustId": 29,
    "PersonFirstname": "Pattie",
    "PersonMiddleName": "Rosenbaum LLC",
    "PersonLastname": "Rowe",
    "PersonFullname": "animi",
    "AlertLevel": 818,
    "ConnectId": 421,
    "ReadStatus": "Green",
    "TimeToReply": 848,
    "RealTimeToReply": 227,
    "TimeToClose": 898,
    "RealTimeToClose": 221,
    "TimeSpentInternally": 179,
    "TimeSpentExternally": 155,
    "TimeSpentQueue": 374,
    "RealTimeSpentInternally": 527,
    "RealTimeSpentExternally": 225,
    "RealTimeSpentQueue": 908,
    "HasAttachment": true,
    "NumReplies": 926,
    "NumMessages": 561,
    "FromAddress": "assumenda",
    "ContactId": 863,
    "ContactName": "White, Brekke and Schmitt",
    "OwnedByAssociateId": 244,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 395
      }
    }
  },
  "TransferTo": {
    "AssociateId": 383,
    "Name": "Moen, Leuschke and Johns",
    "PersonId": 656,
    "Rank": 870,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 675,
    "FullName": "Edwardo Prohaska",
    "FormalName": "Gutkowski-Goldner",
    "Deleted": false,
    "EjUserId": 93,
    "UserName": "Streich-Lindgren",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 255
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
      "FieldLength": 433
    }
  }
}
```