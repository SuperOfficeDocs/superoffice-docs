---
title: POST ChatSession/{id}/Pickup
id: v1ChatSessionEntity_PickUpChatSession
---

# POST ChatSession/{id}/Pickup

```http
POST /api/v1/ChatSession/{chatSessionId}/Pickup
```

'answer' the session: assign the session to the user.

The welcome message is sent to the customer. Returns NULL if session was not in queue.




| Path Part | Type | Description |
|-----------|------|-------------|
| chatSessionId | int32 | id of the chat session to answer **Required** |



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
POST /api/v1/ChatSession/{chatSessionId}/Pickup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 261,
  "TopicId": 846,
  "User": {
    "AssociateId": 900,
    "Name": "VonRueden, Moore and Littel",
    "PersonId": 835,
    "Rank": 718,
    "Tooltip": "reprehenderit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 646,
    "FullName": "Nikolas Nolan",
    "FormalName": "McLaughlin-Zboncak",
    "Deleted": true,
    "EjUserId": 579,
    "UserName": "Fay Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 618
      }
    }
  },
  "Person": {
    "Position": "voluptatem",
    "PersonId": 257,
    "Mrmrs": "ut",
    "Firstname": "Tyra",
    "Lastname": "Stehr",
    "MiddleName": "Mueller, O'Kon and Kemmer",
    "Title": "sit",
    "Description": "Stand-alone mobile task-force",
    "Email": "cristopher@mitchellschuster.ca",
    "FullName": "Kenyon Shanahan",
    "DirectPhone": "215.653.2825 x56860",
    "FormalName": "Aufderhar Group",
    "CountryId": 157,
    "ContactId": 367,
    "ContactName": "Rohan, Kshlerin and Grimes",
    "Retired": 897,
    "Rank": 919,
    "ActiveInterests": 927,
    "ContactDepartment": "",
    "ContactCountryId": 796,
    "ContactOrgNr": "1304833",
    "FaxPhone": "(726)617-0022 x5024",
    "MobilePhone": "1-747-583-4046",
    "ContactPhone": "1-764-512-2875",
    "AssociateName": "Jakubowski Group",
    "AssociateId": 166,
    "UsePersonAddress": false,
    "ContactFax": "veritatis",
    "Kanafname": "sit",
    "Kanalname": "repellat",
    "Post1": "et",
    "Post2": "amet",
    "Post3": "et",
    "EmailName": "dorothea@danielcummings.co.uk",
    "ContactFullName": "Winnifred Hilpert",
    "ActiveErpLinks": 496,
    "TicketPriorityId": 673,
    "SupportLanguageId": 123,
    "SupportAssociateId": 298,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 653
      }
    }
  },
  "CustomerAlias": "aspernatur",
  "CustomerHost": "qui",
  "CustomerName": "Gerlach LLC",
  "CustomerEmail": "ernestina@halvorson.co.uk",
  "CustomerPhone": "417-863-4730 x145",
  "CustomerConsented": true,
  "CustomerCompanyName": "Torphy-Nader",
  "Status": "Closed",
  "FirstMessage": "delectus",
  "LastMessage": "sunt",
  "WhenRequested": "2019-06-23T15:05:41.7420031+02:00",
  "WhenStarted": "2020-09-01T15:05:41.7420031+02:00",
  "WhenEnded": "2015-07-19T15:05:41.7420031+02:00",
  "WhenIdle": "2021-04-12T15:05:41.7420031+02:00",
  "WhenFetched": "2021-04-23T15:05:41.7420031+02:00",
  "SessionKey": "quo",
  "InitialQueuePos": 779,
  "AlertLevel": 493,
  "Rank": 466,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 52,
    "Name": "Wolff LLC",
    "OrgNr": "1568514",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "doloribus",
    "DirectPhone": "1-716-508-3558 x0130",
    "AssociateId": 803,
    "CountryId": 675,
    "EmailAddress": "gisselle_ankunding@medhurstratke.com",
    "Kananame": "neque",
    "EmailAddressName": "hilbert_yundt@schaefer.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Reese Lind",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "alias",
    "FullName": "Grady Cummings",
    "IsOwnerContact": false,
    "ActiveErpLinks": 569,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 917
      }
    }
  },
  "Project": {
    "ProjectId": 659,
    "Name": "Abernathy Group",
    "Description": "Inverse zero administration artificial intelligence",
    "URL": "http://www.example.com/",
    "Type": "quas",
    "AssociateId": 540,
    "AssociateFullName": "Rosemary Jones",
    "TypeId": 14,
    "Updated": "1997-08-23T15:05:41.7430031+02:00",
    "StatusId": 675,
    "Status": "ipsam",
    "TextId": 986,
    "PublishTo": "1994-11-18T15:05:41.7430031+01:00",
    "PublishFrom": "1999-06-29T15:05:41.7430031+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "382049",
    "ActiveErpLinks": 391,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 765
      }
    }
  },
  "Sale": {
    "ContactName": "Weimann Group",
    "SaleDate": "2013-08-24T15:05:41.7430031+02:00",
    "SaleId": 615,
    "Probability": 773,
    "Title": "maiores",
    "Amount": 11680.418,
    "Currency": "quaerat",
    "ProjectName": "Aufderhar Inc and Sons",
    "AssociateFullName": "Ms. Carey Hauck",
    "Description": "Innovative discrete capacity",
    "Status": "Lost",
    "WeightedAmount": 27889.466,
    "ProjectId": 847,
    "EarningPercent": 27942.744,
    "Earning": 3300.102,
    "ContactId": 677,
    "AssociateId": 98,
    "PersonId": 755,
    "SaleTypeId": 542,
    "SaleTypeName": "Herzog-O'Reilly",
    "PersonFullName": "Fiona Metz",
    "Completed": "Completed",
    "ActiveErpLinks": 556,
    "NextDueDate": "1999-06-19T15:05:41.7440025+02:00",
    "Number": "615373",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 726
      }
    }
  },
  "Ticket": {
    "TicketId": 706,
    "Title": "nam",
    "CreatedAt": "2018-02-19T15:05:41.7440025+01:00",
    "LastChanged": "1998-12-19T15:05:41.7440025+01:00",
    "ReadByOwner": "2015-03-26T15:05:41.7440025+01:00",
    "ReadByCustomer": "2003-08-19T15:05:41.7440025+02:00",
    "FirstReadByUser": "2015-05-06T15:05:41.7440025+02:00",
    "Activate": "2017-08-09T15:05:41.7440025+02:00",
    "ClosedAt": "2005-01-02T15:05:41.7440025+01:00",
    "RepliedAt": "2016-12-02T15:05:41.7440025+01:00",
    "AlertTimeout": "2020-04-12T15:05:41.7440025+02:00",
    "Deadline": "1996-02-09T15:05:41.7440025+01:00",
    "CreatedBy": 403,
    "CreatedByName": "Boyer-Jaskolski",
    "Author": "fugiat",
    "OwnedBy": 956,
    "OwnedByName": "Mohr, Lockman and Windler",
    "Category": 407,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 601,
    "PriorityName": "Conroy-Von",
    "BaseStatus": "Active",
    "TicketStatus": 754,
    "TicketStatusDisplayValue": "quia",
    "Origin": "AutoGenerated",
    "CustId": 316,
    "PersonFirstname": "Adolfo",
    "PersonMiddleName": "Walsh, Gutmann and Rowe",
    "PersonLastname": "Christiansen",
    "PersonFullname": "eos",
    "AlertLevel": 183,
    "ConnectId": 548,
    "ReadStatus": "Green",
    "TimeToReply": 155,
    "RealTimeToReply": 304,
    "TimeToClose": 148,
    "RealTimeToClose": 968,
    "TimeSpentInternally": 460,
    "TimeSpentExternally": 390,
    "TimeSpentQueue": 988,
    "RealTimeSpentInternally": 826,
    "RealTimeSpentExternally": 98,
    "RealTimeSpentQueue": 243,
    "HasAttachment": false,
    "NumReplies": 725,
    "NumMessages": 623,
    "FromAddress": "magni",
    "ContactId": 89,
    "ContactName": "Conroy LLC",
    "OwnedByAssociateId": 103,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 85
      }
    }
  },
  "TransferTo": {
    "AssociateId": 441,
    "Name": "Leffler Inc and Sons",
    "PersonId": 773,
    "Rank": 93,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 929,
    "FullName": "Dandre Zieme",
    "FormalName": "Adams, Hettinger and Windler",
    "Deleted": true,
    "EjUserId": 91,
    "UserName": "Hagenes Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 42
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
      "FieldLength": 111
    }
  }
}
```