---
title: POST ChatSession/{id}/AcceptTransfer
id: v1ChatSessionEntity_AcceptChatSessionTransfer
---

# POST ChatSession/{id}/AcceptTransfer

```http
POST /api/v1/ChatSession/{chatSessionId}/AcceptTransfer
```

Accept the transfer: assign the session to the user.

If the session is not being transferred, nothing happens.




| Path Part | Type | Description |
|-----------|------|-------------|
| chatSessionId | int32 | id of the chat session to send **Required** |



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
POST /api/v1/ChatSession/{chatSessionId}/AcceptTransfer
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 635,
  "TopicId": 649,
  "User": {
    "AssociateId": 118,
    "Name": "Hartmann, Ernser and Wolff",
    "PersonId": 756,
    "Rank": 316,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 644,
    "FullName": "Bernie Dooley DDS",
    "FormalName": "Yundt-Bernhard",
    "Deleted": true,
    "EjUserId": 975,
    "UserName": "Bednar-Hettinger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 232
      }
    }
  },
  "Person": {
    "Position": "deserunt",
    "PersonId": 3,
    "Mrmrs": "vel",
    "Firstname": "Keegan",
    "Lastname": "Dickinson",
    "MiddleName": "Bernier-Barrows",
    "Title": "veritatis",
    "Description": "Networked transitional info-mediaries",
    "Email": "santino_witting@blick.co.uk",
    "FullName": "Araceli Vandervort",
    "DirectPhone": "(205)043-4781 x7268",
    "FormalName": "Orn, Keebler and Hoeger",
    "CountryId": 6,
    "ContactId": 943,
    "ContactName": "Thompson Inc and Sons",
    "Retired": 495,
    "Rank": 422,
    "ActiveInterests": 749,
    "ContactDepartment": "",
    "ContactCountryId": 154,
    "ContactOrgNr": "813462",
    "FaxPhone": "1-148-844-0058 x0460",
    "MobilePhone": "213-467-0853 x8056",
    "ContactPhone": "(344)467-7021 x32388",
    "AssociateName": "Johnston-Koelpin",
    "AssociateId": 773,
    "UsePersonAddress": true,
    "ContactFax": "assumenda",
    "Kanafname": "aut",
    "Kanalname": "beatae",
    "Post1": "corporis",
    "Post2": "occaecati",
    "Post3": "dignissimos",
    "EmailName": "presley@mitchellabernathy.us",
    "ContactFullName": "Rudolph Lakin",
    "ActiveErpLinks": 107,
    "TicketPriorityId": 137,
    "SupportLanguageId": 316,
    "SupportAssociateId": 272,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 624
      }
    }
  },
  "CustomerAlias": "et",
  "CustomerHost": "consequatur",
  "CustomerName": "Kemmer LLC",
  "CustomerEmail": "marvin_moore@krajcik.biz",
  "CustomerPhone": "884.333.1188 x2544",
  "CustomerConsented": true,
  "CustomerCompanyName": "Kunze-Parisian",
  "Status": "Closed",
  "FirstMessage": "voluptas",
  "LastMessage": "quae",
  "WhenRequested": "2011-11-17T18:25:50.079597+01:00",
  "WhenStarted": "1994-07-28T18:25:50.079597+02:00",
  "WhenEnded": "1995-11-19T18:25:50.079597+01:00",
  "WhenIdle": "2013-04-25T18:25:50.079597+02:00",
  "WhenFetched": "2003-10-11T18:25:50.079597+02:00",
  "SessionKey": "natus",
  "InitialQueuePos": 34,
  "AlertLevel": 593,
  "Rank": 411,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 311,
    "Name": "Denesik-Murray",
    "OrgNr": "898401",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "saepe",
    "DirectPhone": "181.122.7706",
    "AssociateId": 25,
    "CountryId": 327,
    "EmailAddress": "charles.johns@labadie.us",
    "Kananame": "qui",
    "EmailAddressName": "zachary@mohr.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Reynold Pollich",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "maxime",
    "FullName": "Demarco Barrows",
    "IsOwnerContact": false,
    "ActiveErpLinks": 161,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 236
      }
    }
  },
  "Project": {
    "ProjectId": 550,
    "Name": "Kutch, Wyman and Sanford",
    "Description": "Adaptive demand-driven service-desk",
    "URL": "http://www.example.com/",
    "Type": "qui",
    "AssociateId": 118,
    "AssociateFullName": "Idella Howe",
    "TypeId": 747,
    "Updated": "2018-01-02T18:25:50.0806241+01:00",
    "StatusId": 928,
    "Status": "explicabo",
    "TextId": 931,
    "PublishTo": "2011-09-30T18:25:50.0806241+02:00",
    "PublishFrom": "2016-01-06T18:25:50.0806241+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1348778",
    "ActiveErpLinks": 194,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 908
      }
    }
  },
  "Sale": {
    "ContactName": "Walsh LLC",
    "SaleDate": "2003-04-25T18:25:50.0806241+02:00",
    "SaleId": 181,
    "Probability": 521,
    "Title": "et",
    "Amount": 26068.611999999997,
    "Currency": "id",
    "ProjectName": "Franecki-Strosin",
    "AssociateFullName": "Cordie Funk PhD",
    "Description": "Face to face national core",
    "Status": "Lost",
    "WeightedAmount": 11658.48,
    "ProjectId": 836,
    "EarningPercent": 27068.358,
    "Earning": 10464.426,
    "ContactId": 692,
    "AssociateId": 737,
    "PersonId": 404,
    "SaleTypeId": 587,
    "SaleTypeName": "Waelchi Inc and Sons",
    "PersonFullName": "Madisyn Dicki",
    "Completed": "Completed",
    "ActiveErpLinks": 763,
    "NextDueDate": "2016-03-15T18:25:50.0806241+01:00",
    "Number": "879243",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 328
      }
    }
  },
  "Ticket": {
    "TicketId": 780,
    "Title": "qui",
    "CreatedAt": "2004-09-18T18:25:50.0806241+02:00",
    "LastChanged": "2011-09-11T18:25:50.0806241+02:00",
    "ReadByOwner": "1996-03-10T18:25:50.0806241+01:00",
    "ReadByCustomer": "2020-03-02T18:25:50.0806241+01:00",
    "FirstReadByUser": "2020-04-13T18:25:50.0806241+02:00",
    "Activate": "1996-06-09T18:25:50.0806241+02:00",
    "ClosedAt": "2003-06-18T18:25:50.0806241+02:00",
    "RepliedAt": "2007-04-29T18:25:50.0806241+02:00",
    "AlertTimeout": "2006-10-06T18:25:50.0806241+02:00",
    "Deadline": "2001-02-10T18:25:50.0806241+01:00",
    "CreatedBy": 817,
    "CreatedByName": "Shields, Romaguera and Spencer",
    "Author": "beatae",
    "OwnedBy": 684,
    "OwnedByName": "Marvin-Effertz",
    "Category": 949,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 493,
    "PriorityName": "Bednar-Aufderhar",
    "BaseStatus": "Active",
    "TicketStatus": 757,
    "TicketStatusDisplayValue": "molestias",
    "Origin": "AutoGenerated",
    "CustId": 369,
    "PersonFirstname": "Kasandra",
    "PersonMiddleName": "Barrows LLC",
    "PersonLastname": "Auer",
    "PersonFullname": "ullam",
    "AlertLevel": 1001,
    "ConnectId": 126,
    "ReadStatus": "Green",
    "TimeToReply": 184,
    "RealTimeToReply": 948,
    "TimeToClose": 364,
    "RealTimeToClose": 399,
    "TimeSpentInternally": 901,
    "TimeSpentExternally": 845,
    "TimeSpentQueue": 633,
    "RealTimeSpentInternally": 860,
    "RealTimeSpentExternally": 646,
    "RealTimeSpentQueue": 418,
    "HasAttachment": true,
    "NumReplies": 933,
    "NumMessages": 681,
    "FromAddress": "ducimus",
    "ContactId": 410,
    "ContactName": "Vandervort Inc and Sons",
    "OwnedByAssociateId": 779,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 480
      }
    }
  },
  "TransferTo": {
    "AssociateId": 283,
    "Name": "Schroeder-Miller",
    "PersonId": 60,
    "Rank": 822,
    "Tooltip": "in",
    "Type": "AnonymousAssociate",
    "GroupIdx": 310,
    "FullName": "Ms. Elaina Okuneva",
    "FormalName": "Purdy Inc and Sons",
    "Deleted": false,
    "EjUserId": 865,
    "UserName": "Wolf, Morar and Kautzer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 861
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
      "FieldLength": 886
    }
  }
}
```