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
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 579,
  "TopicId": 476,
  "User": {
    "AssociateId": 81,
    "Name": "Littel, Brakus and Pacocha",
    "PersonId": 586,
    "Rank": 97,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 439,
    "FullName": "Bridget Aufderhar",
    "FormalName": "Halvorson-Sporer",
    "Deleted": false,
    "EjUserId": 174,
    "UserName": "Ondricka LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 758
      }
    }
  },
  "Person": {
    "Position": "animi",
    "PersonId": 207,
    "Mrmrs": "cum",
    "Firstname": "Lucas",
    "Lastname": "Sanford",
    "MiddleName": "Upton Group",
    "Title": "voluptatem",
    "Description": "Pre-emptive value-added success",
    "Email": "rebecca.satterfield@aufderharcremin.uk",
    "FullName": "Ervin Fritsch",
    "DirectPhone": "476-851-8845 x37777",
    "FormalName": "Keeling Inc and Sons",
    "CountryId": 825,
    "ContactId": 32,
    "ContactName": "Dickinson Group",
    "Retired": 547,
    "Rank": 447,
    "ActiveInterests": 206,
    "ContactDepartment": "",
    "ContactCountryId": 739,
    "ContactOrgNr": "589853",
    "FaxPhone": "237-241-8476",
    "MobilePhone": "333.585.1006 x41521",
    "ContactPhone": "437.143.3138",
    "AssociateName": "Huel-VonRueden",
    "AssociateId": 452,
    "UsePersonAddress": false,
    "ContactFax": "voluptatem",
    "Kanafname": "quibusdam",
    "Kanalname": "fugit",
    "Post1": "modi",
    "Post2": "in",
    "Post3": "inventore",
    "EmailName": "miller@dubuque.us",
    "ContactFullName": "Ms. Brooke Yost",
    "ActiveErpLinks": 531,
    "TicketPriorityId": 523,
    "SupportLanguageId": 11,
    "SupportAssociateId": 928,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 29
      }
    }
  },
  "CustomerAlias": "quia",
  "CustomerHost": "ut",
  "CustomerName": "Tromp-Hirthe",
  "CustomerEmail": "nova.oconnell@anderson.co.uk",
  "CustomerPhone": "1-831-750-8850",
  "CustomerConsented": false,
  "CustomerCompanyName": "Schamberger, Jones and Stanton",
  "Status": "Closed",
  "FirstMessage": "est",
  "LastMessage": "ipsam",
  "WhenRequested": "2009-06-20T18:25:50.1526241+02:00",
  "WhenStarted": "2007-12-10T18:25:50.1526241+01:00",
  "WhenEnded": "2015-06-07T18:25:50.1526241+02:00",
  "WhenIdle": "2013-08-10T18:25:50.1526241+02:00",
  "WhenFetched": "1999-03-05T18:25:50.1526241+01:00",
  "SessionKey": "culpa",
  "InitialQueuePos": 970,
  "AlertLevel": 838,
  "Rank": 9,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 930,
    "Name": "Parker-Zboncak",
    "OrgNr": "838724",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "porro",
    "DirectPhone": "534-066-3108",
    "AssociateId": 241,
    "CountryId": 791,
    "EmailAddress": "scarlett.dubuque@wiegand.name",
    "Kananame": "et",
    "EmailAddressName": "sallie@breitenberg.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Aida Heathcote",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "sunt",
    "FullName": "Casimir Schamberger",
    "IsOwnerContact": true,
    "ActiveErpLinks": 162,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 838
      }
    }
  },
  "Project": {
    "ProjectId": 108,
    "Name": "Conn, Rowe and Schowalter",
    "Description": "Organic mobile benchmark",
    "URL": "http://www.example.com/",
    "Type": "corporis",
    "AssociateId": 255,
    "AssociateFullName": "Johathan Rempel",
    "TypeId": 383,
    "Updated": "2015-02-24T18:25:50.1536245+01:00",
    "StatusId": 448,
    "Status": "et",
    "TextId": 182,
    "PublishTo": "2011-11-15T18:25:50.1536245+01:00",
    "PublishFrom": "1997-09-16T18:25:50.1536245+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1328983",
    "ActiveErpLinks": 59,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 792
      }
    }
  },
  "Sale": {
    "ContactName": "Ernser-Cummerata",
    "SaleDate": "2013-11-30T18:25:50.1536245+01:00",
    "SaleId": 511,
    "Probability": 330,
    "Title": "laudantium",
    "Amount": 9342.454,
    "Currency": "voluptate",
    "ProjectName": "Roob-Baumbach",
    "AssociateFullName": "Pauline Haag",
    "Description": "Mandatory fresh-thinking throughput",
    "Status": "Lost",
    "WeightedAmount": 4826.36,
    "ProjectId": 340,
    "EarningPercent": 18249.282,
    "Earning": 14742.336,
    "ContactId": 224,
    "AssociateId": 843,
    "PersonId": 445,
    "SaleTypeId": 129,
    "SaleTypeName": "Gutkowski, Douglas and Kerluke",
    "PersonFullName": "Trevion Bartell",
    "Completed": "Completed",
    "ActiveErpLinks": 220,
    "NextDueDate": "2015-11-21T18:25:50.1546291+01:00",
    "Number": "576316",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 776
      }
    }
  },
  "Ticket": {
    "TicketId": 863,
    "Title": "pariatur",
    "CreatedAt": "1998-06-24T18:25:50.1546291+02:00",
    "LastChanged": "1998-11-08T18:25:50.1546291+01:00",
    "ReadByOwner": "2001-05-03T18:25:50.1546291+02:00",
    "ReadByCustomer": "1999-04-14T18:25:50.1546291+02:00",
    "FirstReadByUser": "2021-09-21T18:25:50.1546291+02:00",
    "Activate": "2001-07-01T18:25:50.1546291+02:00",
    "ClosedAt": "2019-10-26T18:25:50.1546291+02:00",
    "RepliedAt": "2016-03-03T18:25:50.1546291+01:00",
    "AlertTimeout": "1997-09-10T18:25:50.1546291+02:00",
    "Deadline": "2005-12-09T18:25:50.1546291+01:00",
    "CreatedBy": 823,
    "CreatedByName": "Kub Inc and Sons",
    "Author": "unde",
    "OwnedBy": 570,
    "OwnedByName": "Bernhard Inc and Sons",
    "Category": 107,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 661,
    "PriorityName": "Emard LLC",
    "BaseStatus": "Active",
    "TicketStatus": 732,
    "TicketStatusDisplayValue": "nemo",
    "Origin": "AutoGenerated",
    "CustId": 611,
    "PersonFirstname": "Austyn",
    "PersonMiddleName": "McGlynn, Graham and Abbott",
    "PersonLastname": "Kozey",
    "PersonFullname": "eligendi",
    "AlertLevel": 396,
    "ConnectId": 731,
    "ReadStatus": "Green",
    "TimeToReply": 551,
    "RealTimeToReply": 398,
    "TimeToClose": 934,
    "RealTimeToClose": 569,
    "TimeSpentInternally": 244,
    "TimeSpentExternally": 651,
    "TimeSpentQueue": 764,
    "RealTimeSpentInternally": 465,
    "RealTimeSpentExternally": 572,
    "RealTimeSpentQueue": 794,
    "HasAttachment": false,
    "NumReplies": 746,
    "NumMessages": 48,
    "FromAddress": "nam",
    "ContactId": 612,
    "ContactName": "Hammes-Heathcote",
    "OwnedByAssociateId": 366,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 192
      }
    }
  },
  "TransferTo": {
    "AssociateId": 495,
    "Name": "Beatty, Littel and Bosco",
    "PersonId": 10,
    "Rank": 378,
    "Tooltip": "autem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 112,
    "FullName": "Ebba Schaefer",
    "FormalName": "Bode Inc and Sons",
    "Deleted": false,
    "EjUserId": 239,
    "UserName": "Funk, Franecki and Lind",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 546
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
      "FieldLength": 743
    }
  }
}
```