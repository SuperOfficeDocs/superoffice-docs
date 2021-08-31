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
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 963,
  "TopicId": 918,
  "User": {
    "AssociateId": 209,
    "Name": "Toy Inc and Sons",
    "PersonId": 211,
    "Rank": 331,
    "Tooltip": "impedit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 533,
    "FullName": "Ephraim West",
    "FormalName": "Crona-Osinski",
    "Deleted": true,
    "EjUserId": 561,
    "UserName": "Erdman, Lowe and Quigley",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 716
      }
    }
  },
  "Person": {
    "Position": "fugit",
    "PersonId": 694,
    "Mrmrs": "a",
    "Firstname": "Lorna",
    "Lastname": "Gerlach",
    "MiddleName": "Romaguera Inc and Sons",
    "Title": "ut",
    "Description": "Quality-focused non-volatile implementation",
    "Email": "newell@howegorczany.uk",
    "FullName": "Nelle Veum",
    "DirectPhone": "(076)344-5041",
    "FormalName": "Ankunding, Langosh and Marvin",
    "CountryId": 654,
    "ContactId": 66,
    "ContactName": "Raynor, Beahan and VonRueden",
    "Retired": 31,
    "Rank": 866,
    "ActiveInterests": 210,
    "ContactDepartment": "",
    "ContactCountryId": 86,
    "ContactOrgNr": "1213948",
    "FaxPhone": "1-823-370-7646 x25111",
    "MobilePhone": "642.761.5068 x025",
    "ContactPhone": "241.502.6324 x67404",
    "AssociateName": "Rice-Stamm",
    "AssociateId": 665,
    "UsePersonAddress": false,
    "ContactFax": "harum",
    "Kanafname": "quis",
    "Kanalname": "repellendus",
    "Post1": "voluptas",
    "Post2": "temporibus",
    "Post3": "et",
    "EmailName": "kade@quitzonkoelpin.ca",
    "ContactFullName": "Tyreek Torp II",
    "ActiveErpLinks": 220,
    "TicketPriorityId": 777,
    "SupportLanguageId": 175,
    "SupportAssociateId": 859,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 315
      }
    }
  },
  "CustomerAlias": "non",
  "CustomerHost": "eaque",
  "CustomerName": "Oberbrunner, Shanahan and Senger",
  "CustomerEmail": "donato@homenickreynolds.uk",
  "CustomerPhone": "(060)568-1666 x638",
  "CustomerConsented": true,
  "CustomerCompanyName": "Carter-Bahringer",
  "Status": "Closed",
  "FirstMessage": "provident",
  "LastMessage": "inventore",
  "WhenRequested": "2019-05-05T15:05:41.731003+02:00",
  "WhenStarted": "2005-03-31T15:05:41.731003+02:00",
  "WhenEnded": "1999-02-18T15:05:41.731003+01:00",
  "WhenIdle": "1997-06-08T15:05:41.731003+02:00",
  "WhenFetched": "2004-02-23T15:05:41.731003+01:00",
  "SessionKey": "vero",
  "InitialQueuePos": 281,
  "AlertLevel": 503,
  "Rank": 582,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 305,
    "Name": "Brakus LLC",
    "OrgNr": "1825060",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "quos",
    "DirectPhone": "212-750-1563 x86063",
    "AssociateId": 786,
    "CountryId": 870,
    "EmailAddress": "anissa@kertzmann.biz",
    "Kananame": "aut",
    "EmailAddressName": "jamaal@sporer.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Cortez Ryan",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "officia",
    "FullName": "Mr. Alexandre Prosacco",
    "IsOwnerContact": false,
    "ActiveErpLinks": 829,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 65
      }
    }
  },
  "Project": {
    "ProjectId": 435,
    "Name": "Dare Group",
    "Description": "Configurable 24 hour migration",
    "URL": "http://www.example.com/",
    "Type": "vitae",
    "AssociateId": 43,
    "AssociateFullName": "Declan Langworth",
    "TypeId": 850,
    "Updated": "2002-10-25T15:05:41.7330034+02:00",
    "StatusId": 583,
    "Status": "molestiae",
    "TextId": 458,
    "PublishTo": "2010-08-18T15:05:41.7340038+02:00",
    "PublishFrom": "1999-05-15T15:05:41.7340038+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "204857",
    "ActiveErpLinks": 868,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 806
      }
    }
  },
  "Sale": {
    "ContactName": "Willms-Satterfield",
    "SaleDate": "2020-11-29T15:05:41.7340038+01:00",
    "SaleId": 48,
    "Probability": 808,
    "Title": "rerum",
    "Amount": 26607.66,
    "Currency": "ducimus",
    "ProjectName": "Schmitt-Powlowski",
    "AssociateFullName": "Zelma Rowe",
    "Description": "Networked client-server access",
    "Status": "Lost",
    "WeightedAmount": 31236.577999999998,
    "ProjectId": 771,
    "EarningPercent": 12677.029999999999,
    "Earning": 6543.7919999999995,
    "ContactId": 250,
    "AssociateId": 541,
    "PersonId": 234,
    "SaleTypeId": 982,
    "SaleTypeName": "Sipes Group",
    "PersonFullName": "Leilani Parker",
    "Completed": "Completed",
    "ActiveErpLinks": 816,
    "NextDueDate": "2015-10-11T15:05:41.7340038+02:00",
    "Number": "510221",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 572
      }
    }
  },
  "Ticket": {
    "TicketId": 11,
    "Title": "perferendis",
    "CreatedAt": "2016-03-19T15:05:41.7340038+01:00",
    "LastChanged": "2003-12-02T15:05:41.7340038+01:00",
    "ReadByOwner": "2016-03-21T15:05:41.7340038+01:00",
    "ReadByCustomer": "2018-10-01T15:05:41.7340038+02:00",
    "FirstReadByUser": "2000-07-25T15:05:41.7340038+02:00",
    "Activate": "1998-05-18T15:05:41.7340038+02:00",
    "ClosedAt": "2017-09-29T15:05:41.7340038+02:00",
    "RepliedAt": "2001-03-01T15:05:41.7340038+01:00",
    "AlertTimeout": "2010-08-19T15:05:41.7340038+02:00",
    "Deadline": "2016-06-10T15:05:41.7340038+02:00",
    "CreatedBy": 376,
    "CreatedByName": "Schmeler, Gleason and Yundt",
    "Author": "quisquam",
    "OwnedBy": 25,
    "OwnedByName": "Dickens-Donnelly",
    "Category": 14,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 183,
    "PriorityName": "Bartell-Connelly",
    "BaseStatus": "Active",
    "TicketStatus": 361,
    "TicketStatusDisplayValue": "velit",
    "Origin": "AutoGenerated",
    "CustId": 467,
    "PersonFirstname": "Daryl",
    "PersonMiddleName": "McCullough-Sauer",
    "PersonLastname": "Bahringer",
    "PersonFullname": "consequuntur",
    "AlertLevel": 328,
    "ConnectId": 857,
    "ReadStatus": "Green",
    "TimeToReply": 891,
    "RealTimeToReply": 441,
    "TimeToClose": 398,
    "RealTimeToClose": 672,
    "TimeSpentInternally": 776,
    "TimeSpentExternally": 479,
    "TimeSpentQueue": 793,
    "RealTimeSpentInternally": 263,
    "RealTimeSpentExternally": 549,
    "RealTimeSpentQueue": 540,
    "HasAttachment": false,
    "NumReplies": 817,
    "NumMessages": 188,
    "FromAddress": "sit",
    "ContactId": 563,
    "ContactName": "Quitzon, Medhurst and Howell",
    "OwnedByAssociateId": 389,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 563
      }
    }
  },
  "TransferTo": {
    "AssociateId": 928,
    "Name": "Casper-Predovic",
    "PersonId": 963,
    "Rank": 346,
    "Tooltip": "nisi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 392,
    "FullName": "Caleigh Herzog",
    "FormalName": "Bernier-Mante",
    "Deleted": false,
    "EjUserId": 653,
    "UserName": "Veum, Johnson and Crist",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 324
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
      "FieldType": "System.Int32",
      "FieldLength": 45
    }
  }
}
```