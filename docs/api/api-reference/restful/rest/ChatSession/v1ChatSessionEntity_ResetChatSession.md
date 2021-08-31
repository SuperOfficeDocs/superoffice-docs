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
| ChatbotIsActive | bool | Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/ChatSession/{chatSessionId}/Reset
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 192,
  "TopicId": 665,
  "User": {
    "AssociateId": 413,
    "Name": "Borer-Harvey",
    "PersonId": 808,
    "Rank": 749,
    "Tooltip": "molestiae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 977,
    "FullName": "Meta Blanda",
    "FormalName": "Vandervort Inc and Sons",
    "Deleted": true,
    "EjUserId": 290,
    "UserName": "Marvin LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 40
      }
    }
  },
  "Person": {
    "Position": "dolore",
    "PersonId": 850,
    "Mrmrs": "quia",
    "Firstname": "Delpha",
    "Lastname": "Kiehn",
    "MiddleName": "Dach Inc and Sons",
    "Title": "est",
    "Description": "Horizontal value-added moratorium",
    "Email": "melyssa@stiedemannkemmer.co.uk",
    "FullName": "Dashawn Shanahan",
    "DirectPhone": "1-301-518-5124",
    "FormalName": "Reynolds-Jakubowski",
    "CountryId": 625,
    "ContactId": 728,
    "ContactName": "McLaughlin Group",
    "Retired": 70,
    "Rank": 161,
    "ActiveInterests": 657,
    "ContactDepartment": "",
    "ContactCountryId": 346,
    "ContactOrgNr": "873475",
    "FaxPhone": "184-040-0361 x24001",
    "MobilePhone": "(031)226-1137 x154",
    "ContactPhone": "660.275.5204",
    "AssociateName": "Bahringer, Waelchi and Mann",
    "AssociateId": 914,
    "UsePersonAddress": true,
    "ContactFax": "aut",
    "Kanafname": "amet",
    "Kanalname": "rerum",
    "Post1": "incidunt",
    "Post2": "ea",
    "Post3": "quia",
    "EmailName": "mina_hermiston@hagenes.uk",
    "ContactFullName": "Dashawn Labadie",
    "ActiveErpLinks": 848,
    "TicketPriorityId": 803,
    "SupportLanguageId": 391,
    "SupportAssociateId": 688,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 567
      }
    }
  },
  "CustomerAlias": "quia",
  "CustomerHost": "nesciunt",
  "CustomerName": "Greenholt, Kassulke and Schmeler",
  "CustomerEmail": "roscoe_jerde@gusikowski.biz",
  "CustomerPhone": "151.351.6431",
  "CustomerConsented": false,
  "CustomerCompanyName": "Nader-Feest",
  "Status": "Closed",
  "FirstMessage": "ipsa",
  "LastMessage": "est",
  "WhenRequested": "2002-11-16T15:05:41.7610052+01:00",
  "WhenStarted": "2003-01-02T15:05:41.7610052+01:00",
  "WhenEnded": "2005-01-23T15:05:41.7610052+01:00",
  "WhenIdle": "1997-06-18T15:05:41.7610052+02:00",
  "WhenFetched": "2004-10-01T15:05:41.7610052+02:00",
  "SessionKey": "qui",
  "InitialQueuePos": 942,
  "AlertLevel": 823,
  "Rank": 636,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 169,
    "Name": "Baumbach Inc and Sons",
    "OrgNr": "352518",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "libero",
    "DirectPhone": "318-221-1475 x22486",
    "AssociateId": 516,
    "CountryId": 726,
    "EmailAddress": "helga.donnelly@stamm.uk",
    "Kananame": "reprehenderit",
    "EmailAddressName": "harmony@carter.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mackenzie Mosciski",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "et",
    "FullName": "Germaine Anderson",
    "IsOwnerContact": false,
    "ActiveErpLinks": 287,
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
  "Project": {
    "ProjectId": 648,
    "Name": "Tillman-Kuphal",
    "Description": "Persistent mobile hardware",
    "URL": "http://www.example.com/",
    "Type": "nesciunt",
    "AssociateId": 272,
    "AssociateFullName": "Maymie Schuster",
    "TypeId": 482,
    "Updated": "2010-10-22T15:05:41.7620049+02:00",
    "StatusId": 844,
    "Status": "optio",
    "TextId": 558,
    "PublishTo": "2003-10-16T15:05:41.7620049+02:00",
    "PublishFrom": "2016-08-25T15:05:41.7620049+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "260686",
    "ActiveErpLinks": 622,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 864
      }
    }
  },
  "Sale": {
    "ContactName": "Crona-Strosin",
    "SaleDate": "2012-02-01T15:05:41.7620049+01:00",
    "SaleId": 817,
    "Probability": 430,
    "Title": "molestiae",
    "Amount": 19377.522,
    "Currency": "ut",
    "ProjectName": "Conn, Kulas and Heidenreich",
    "AssociateFullName": "Ayden Lowe",
    "Description": "Triple-buffered mobile budgetary management",
    "Status": "Lost",
    "WeightedAmount": 4340.59,
    "ProjectId": 30,
    "EarningPercent": 13529.478,
    "Earning": 12263.341999999999,
    "ContactId": 785,
    "AssociateId": 363,
    "PersonId": 729,
    "SaleTypeId": 881,
    "SaleTypeName": "Schmitt, Kub and Kub",
    "PersonFullName": "Bertrand Volkman",
    "Completed": "Completed",
    "ActiveErpLinks": 8,
    "NextDueDate": "2020-03-25T15:05:41.7630049+01:00",
    "Number": "1367992",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 778
      }
    }
  },
  "Ticket": {
    "TicketId": 46,
    "Title": "possimus",
    "CreatedAt": "2006-03-25T15:05:41.7630049+01:00",
    "LastChanged": "2007-05-10T15:05:41.7630049+02:00",
    "ReadByOwner": "2017-08-18T15:05:41.7630049+02:00",
    "ReadByCustomer": "1996-11-05T15:05:41.7630049+01:00",
    "FirstReadByUser": "2012-09-15T15:05:41.7630049+02:00",
    "Activate": "2001-12-04T15:05:41.7630049+01:00",
    "ClosedAt": "2011-08-22T15:05:41.7630049+02:00",
    "RepliedAt": "2021-02-24T15:05:41.7630049+01:00",
    "AlertTimeout": "1998-08-04T15:05:41.7630049+02:00",
    "Deadline": "1996-07-11T15:05:41.7630049+02:00",
    "CreatedBy": 425,
    "CreatedByName": "McDermott-Donnelly",
    "Author": "magni",
    "OwnedBy": 545,
    "OwnedByName": "O'Hara-Stamm",
    "Category": 237,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 747,
    "PriorityName": "Stehr-Cruickshank",
    "BaseStatus": "Active",
    "TicketStatus": 622,
    "TicketStatusDisplayValue": "illum",
    "Origin": "AutoGenerated",
    "CustId": 348,
    "PersonFirstname": "Haven",
    "PersonMiddleName": "Cruickshank-Hermiston",
    "PersonLastname": "Romaguera",
    "PersonFullname": "nesciunt",
    "AlertLevel": 767,
    "ConnectId": 283,
    "ReadStatus": "Green",
    "TimeToReply": 73,
    "RealTimeToReply": 436,
    "TimeToClose": 584,
    "RealTimeToClose": 410,
    "TimeSpentInternally": 867,
    "TimeSpentExternally": 722,
    "TimeSpentQueue": 785,
    "RealTimeSpentInternally": 537,
    "RealTimeSpentExternally": 668,
    "RealTimeSpentQueue": 388,
    "HasAttachment": true,
    "NumReplies": 522,
    "NumMessages": 522,
    "FromAddress": "omnis",
    "ContactId": 604,
    "ContactName": "Cruickshank LLC",
    "OwnedByAssociateId": 747,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 79
      }
    }
  },
  "TransferTo": {
    "AssociateId": 229,
    "Name": "Barton, Homenick and Hirthe",
    "PersonId": 649,
    "Rank": 232,
    "Tooltip": "error",
    "Type": "AnonymousAssociate",
    "GroupIdx": 608,
    "FullName": "Vince Kiehn",
    "FormalName": "Kutch Group",
    "Deleted": false,
    "EjUserId": 153,
    "UserName": "Wilkinson Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 153
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
      "FieldLength": 173
    }
  }
}
```