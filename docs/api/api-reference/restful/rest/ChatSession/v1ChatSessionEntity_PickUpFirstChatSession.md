---
title: POST ChatSession/Pickup
id: v1ChatSessionEntity_PickUpFirstChatSession
---

# POST ChatSession/Pickup

```http
POST /api/v1/ChatSession/Pickup
```

'answer' the first available session from the queue: assign the session to the user.

The welcome message is sent to the customer.






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
POST /api/v1/ChatSession/Pickup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 126,
  "TopicId": 661,
  "User": {
    "AssociateId": 88,
    "Name": "Kreiger Inc and Sons",
    "PersonId": 66,
    "Rank": 846,
    "Tooltip": "aliquid",
    "Type": "AnonymousAssociate",
    "GroupIdx": 520,
    "FullName": "Chaim Barton",
    "FormalName": "Von Group",
    "Deleted": false,
    "EjUserId": 21,
    "UserName": "Douglas, Moen and McClure",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 3
      }
    }
  },
  "Person": {
    "Position": "repellendus",
    "PersonId": 817,
    "Mrmrs": "autem",
    "Firstname": "Baylee",
    "Lastname": "Kuphal",
    "MiddleName": "Leuschke, O'Hara and Hegmann",
    "Title": "suscipit",
    "Description": "Organic reciprocal functionalities",
    "Email": "derrick_franecki@blick.info",
    "FullName": "Lola Stroman",
    "DirectPhone": "1-044-830-5347 x63624",
    "FormalName": "Morar Inc and Sons",
    "CountryId": 685,
    "ContactId": 300,
    "ContactName": "Emard-Torp",
    "Retired": 313,
    "Rank": 885,
    "ActiveInterests": 548,
    "ContactDepartment": "",
    "ContactCountryId": 152,
    "ContactOrgNr": "755171",
    "FaxPhone": "(125)501-3128",
    "MobilePhone": "774-256-5714 x854",
    "ContactPhone": "520-714-5465 x10641",
    "AssociateName": "Bode LLC",
    "AssociateId": 349,
    "UsePersonAddress": true,
    "ContactFax": "aut",
    "Kanafname": "sunt",
    "Kanalname": "consectetur",
    "Post1": "et",
    "Post2": "rerum",
    "Post3": "nam",
    "EmailName": "rashawn@torphudson.uk",
    "ContactFullName": "Jazmyne Sanford II",
    "ActiveErpLinks": 137,
    "TicketPriorityId": 972,
    "SupportLanguageId": 181,
    "SupportAssociateId": 478,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "reintermediate holistic portals"
        },
        "FieldType": "System.String",
        "FieldLength": 224
      }
    }
  },
  "CustomerAlias": "rem",
  "CustomerHost": "ducimus",
  "CustomerName": "Swaniawski-Weissnat",
  "CustomerEmail": "myra_boyle@kohlerbailey.info",
  "CustomerPhone": "276-272-0773",
  "CustomerConsented": true,
  "CustomerCompanyName": "King Inc and Sons",
  "Status": "Closed",
  "FirstMessage": "nobis",
  "LastMessage": "sunt",
  "WhenRequested": "2012-05-02T15:05:41.7520049+02:00",
  "WhenStarted": "1999-07-23T15:05:41.7520049+02:00",
  "WhenEnded": "2009-09-22T15:05:41.7520049+02:00",
  "WhenIdle": "1996-04-20T15:05:41.7520049+02:00",
  "WhenFetched": "2007-10-27T15:05:41.7520049+02:00",
  "SessionKey": "officia",
  "InitialQueuePos": 42,
  "AlertLevel": 752,
  "Rank": 39,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 713,
    "Name": "Donnelly-Blanda",
    "OrgNr": "561249",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ea",
    "DirectPhone": "(465)037-4467",
    "AssociateId": 659,
    "CountryId": 27,
    "EmailAddress": "judd@simonis.com",
    "Kananame": "ad",
    "EmailAddressName": "demarco@deckow.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Sabrina Ritchie",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "nihil",
    "FullName": "Mrs. Sandy Blanda",
    "IsOwnerContact": false,
    "ActiveErpLinks": 858,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 555
      }
    }
  },
  "Project": {
    "ProjectId": 53,
    "Name": "Wisozk Group",
    "Description": "Adaptive multi-tasking software",
    "URL": "http://www.example.com/",
    "Type": "ullam",
    "AssociateId": 471,
    "AssociateFullName": "Aryanna Bosco I",
    "TypeId": 896,
    "Updated": "2009-03-24T15:05:41.7520049+01:00",
    "StatusId": 390,
    "Status": "aut",
    "TextId": 72,
    "PublishTo": "2004-07-09T15:05:41.7520049+02:00",
    "PublishFrom": "1995-05-23T15:05:41.7520049+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1177907",
    "ActiveErpLinks": 152,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "utilize value-added paradigms"
        },
        "FieldType": "System.String",
        "FieldLength": 131
      }
    }
  },
  "Sale": {
    "ContactName": "Dooley-Murphy",
    "SaleDate": "2015-11-07T15:05:41.7530051+01:00",
    "SaleId": 998,
    "Probability": 40,
    "Title": "ut",
    "Amount": 9489.752,
    "Currency": "dolores",
    "ProjectName": "Zieme Inc and Sons",
    "AssociateFullName": "Chelsie Heathcote",
    "Description": "Multi-lateral responsive initiative",
    "Status": "Lost",
    "WeightedAmount": 29045.912,
    "ProjectId": 93,
    "EarningPercent": 30782.147999999997,
    "Earning": 23041.167999999998,
    "ContactId": 745,
    "AssociateId": 854,
    "PersonId": 18,
    "SaleTypeId": 675,
    "SaleTypeName": "Grady-Jacobs",
    "PersonFullName": "Verla Koch",
    "Completed": "Completed",
    "ActiveErpLinks": 267,
    "NextDueDate": "2015-01-16T15:05:41.7530051+01:00",
    "Number": "686414",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 522
      }
    }
  },
  "Ticket": {
    "TicketId": 95,
    "Title": "rerum",
    "CreatedAt": "1995-10-24T15:05:41.7530051+02:00",
    "LastChanged": "2021-05-15T15:05:41.7530051+02:00",
    "ReadByOwner": "1994-10-06T15:05:41.7530051+02:00",
    "ReadByCustomer": "2002-11-05T15:05:41.7530051+01:00",
    "FirstReadByUser": "2006-09-04T15:05:41.7530051+02:00",
    "Activate": "2014-04-03T15:05:41.7530051+02:00",
    "ClosedAt": "2016-05-12T15:05:41.7530051+02:00",
    "RepliedAt": "2020-02-05T15:05:41.7530051+01:00",
    "AlertTimeout": "2002-05-20T15:05:41.7530051+02:00",
    "Deadline": "2018-09-25T15:05:41.7530051+02:00",
    "CreatedBy": 649,
    "CreatedByName": "Fritsch-Dibbert",
    "Author": "et",
    "OwnedBy": 778,
    "OwnedByName": "Renner Group",
    "Category": 42,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 623,
    "PriorityName": "Brakus, Blick and Kutch",
    "BaseStatus": "Active",
    "TicketStatus": 542,
    "TicketStatusDisplayValue": "sunt",
    "Origin": "AutoGenerated",
    "CustId": 737,
    "PersonFirstname": "Philip",
    "PersonMiddleName": "Abshire, Pollich and Smitham",
    "PersonLastname": "Rippin",
    "PersonFullname": "ullam",
    "AlertLevel": 900,
    "ConnectId": 758,
    "ReadStatus": "Green",
    "TimeToReply": 620,
    "RealTimeToReply": 766,
    "TimeToClose": 141,
    "RealTimeToClose": 110,
    "TimeSpentInternally": 383,
    "TimeSpentExternally": 669,
    "TimeSpentQueue": 548,
    "RealTimeSpentInternally": 367,
    "RealTimeSpentExternally": 363,
    "RealTimeSpentQueue": 259,
    "HasAttachment": false,
    "NumReplies": 200,
    "NumMessages": 391,
    "FromAddress": "qui",
    "ContactId": 473,
    "ContactName": "Halvorson, Larkin and Bradtke",
    "OwnedByAssociateId": 537,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 279
      }
    }
  },
  "TransferTo": {
    "AssociateId": 238,
    "Name": "Wehner LLC",
    "PersonId": 602,
    "Rank": 444,
    "Tooltip": "doloribus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 298,
    "FullName": "Trenton Huel",
    "FormalName": "Swaniawski-Beer",
    "Deleted": true,
    "EjUserId": 529,
    "UserName": "Toy-Quitzon",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 267
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
      "FieldLength": 25
    }
  }
}
```