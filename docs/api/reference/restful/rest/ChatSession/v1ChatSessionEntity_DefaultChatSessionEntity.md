---
title: GET ChatSession/default
id: v1ChatSessionEntity_DefaultChatSessionEntity
---

# GET ChatSession/default

```http
GET /api/v1/ChatSession/default
```

Set default values into a new ChatSessionEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Chat agent service CreateDefaultChatSessionEntity.






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
GET /api/v1/ChatSession/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 186,
  "TopicId": 543,
  "User": {
    "AssociateId": 740,
    "Name": "Corkery-Mayer",
    "PersonId": 537,
    "Rank": 802,
    "Tooltip": "saepe",
    "Type": "AnonymousAssociate",
    "GroupIdx": 815,
    "FullName": "Ryder Kuvalis",
    "FormalName": "Hamill LLC",
    "Deleted": true,
    "EjUserId": 526,
    "UserName": "Lebsack LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 541
      }
    }
  },
  "Person": {
    "Position": "sed",
    "PersonId": 413,
    "Mrmrs": "explicabo",
    "Firstname": "Micheal",
    "Lastname": "Bednar",
    "MiddleName": "Kuvalis-Moen",
    "Title": "earum",
    "Description": "Enterprise-wide static firmware",
    "Email": "shirley@monahan.co.uk",
    "FullName": "Ena Swaniawski",
    "DirectPhone": "785.836.3075",
    "FormalName": "Bednar-Stanton",
    "CountryId": 100,
    "ContactId": 626,
    "ContactName": "Zulauf-Mann",
    "Retired": 837,
    "Rank": 525,
    "ActiveInterests": 105,
    "ContactDepartment": "",
    "ContactCountryId": 2,
    "ContactOrgNr": "1119093",
    "FaxPhone": "220-640-8871 x6417",
    "MobilePhone": "106.577.4700 x143",
    "ContactPhone": "(182)273-0800",
    "AssociateName": "Borer-West",
    "AssociateId": 263,
    "UsePersonAddress": true,
    "ContactFax": "praesentium",
    "Kanafname": "aperiam",
    "Kanalname": "ut",
    "Post1": "ad",
    "Post2": "vero",
    "Post3": "vel",
    "EmailName": "abner@hauck.info",
    "ContactFullName": "Dahlia Lehner",
    "ActiveErpLinks": 263,
    "TicketPriorityId": 371,
    "SupportLanguageId": 438,
    "SupportAssociateId": 556,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 156
      }
    }
  },
  "CustomerAlias": "et",
  "CustomerHost": "consequatur",
  "CustomerName": "Little-Runte",
  "CustomerEmail": "haskell@marvin.uk",
  "CustomerPhone": "045-826-7415 x211",
  "CustomerConsented": true,
  "CustomerCompanyName": "Hoeger-Paucek",
  "Status": "Closed",
  "FirstMessage": "optio",
  "LastMessage": "illum",
  "WhenRequested": "2006-07-20T18:25:49.996563+02:00",
  "WhenStarted": "2019-04-16T18:25:49.996563+02:00",
  "WhenEnded": "2004-08-31T18:25:49.996563+02:00",
  "WhenIdle": "2016-10-09T18:25:49.996563+02:00",
  "WhenFetched": "2006-04-13T18:25:49.996563+02:00",
  "SessionKey": "sed",
  "InitialQueuePos": 636,
  "AlertLevel": 65,
  "Rank": 578,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 841,
    "Name": "Torp Group",
    "OrgNr": "948294",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "enim",
    "DirectPhone": "502.367.0488 x6228",
    "AssociateId": 478,
    "CountryId": 349,
    "EmailAddress": "coby@gleichner.biz",
    "Kananame": "ex",
    "EmailAddressName": "micheal.kiehn@schulist.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Zena Huel",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "consequatur",
    "FullName": "Catharine Collier",
    "IsOwnerContact": true,
    "ActiveErpLinks": 594,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 895
      }
    }
  },
  "Project": {
    "ProjectId": 507,
    "Name": "McGlynn, Oberbrunner and Olson",
    "Description": "Adaptive disintermediate approach",
    "URL": "http://www.example.com/",
    "Type": "aliquam",
    "AssociateId": 996,
    "AssociateFullName": "Mr. Louisa Bednar",
    "TypeId": 69,
    "Updated": "2017-03-26T18:25:49.9985704+02:00",
    "StatusId": 318,
    "Status": "labore",
    "TextId": 61,
    "PublishTo": "2008-09-30T18:25:49.9985704+02:00",
    "PublishFrom": "1995-10-05T18:25:49.9985704+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "759582",
    "ActiveErpLinks": 103,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 510
      }
    }
  },
  "Sale": {
    "ContactName": "Powlowski, Schuster and Trantow",
    "SaleDate": "2006-11-07T18:25:49.9985704+01:00",
    "SaleId": 315,
    "Probability": 168,
    "Title": "quo",
    "Amount": 22677.624,
    "Currency": "officia",
    "ProjectName": "Spencer Group",
    "AssociateFullName": "Justina Block Jr.",
    "Description": "Managed clear-thinking application",
    "Status": "Lost",
    "WeightedAmount": 26137.559999999998,
    "ProjectId": 26,
    "EarningPercent": 29425.126,
    "Earning": 9477.216,
    "ContactId": 260,
    "AssociateId": 292,
    "PersonId": 904,
    "SaleTypeId": 942,
    "SaleTypeName": "Haag-Rodriguez",
    "PersonFullName": "Eveline Hahn DDS",
    "Completed": "Completed",
    "ActiveErpLinks": 755,
    "NextDueDate": "2021-10-12T18:25:49.9995334+02:00",
    "Number": "1248071",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 817
      }
    }
  },
  "Ticket": {
    "TicketId": 444,
    "Title": "quia",
    "CreatedAt": "2006-04-12T18:25:49.9995334+02:00",
    "LastChanged": "2014-03-26T18:25:49.9995334+01:00",
    "ReadByOwner": "2009-12-30T18:25:49.9995334+01:00",
    "ReadByCustomer": "2003-05-05T18:25:49.9995334+02:00",
    "FirstReadByUser": "2012-04-29T18:25:49.9995334+02:00",
    "Activate": "2000-11-28T18:25:49.9995334+01:00",
    "ClosedAt": "1996-12-09T18:25:49.9995334+01:00",
    "RepliedAt": "1994-11-04T18:25:49.9995334+01:00",
    "AlertTimeout": "1998-02-20T18:25:49.9995334+01:00",
    "Deadline": "2005-03-06T18:25:49.9995334+01:00",
    "CreatedBy": 13,
    "CreatedByName": "Jenkins, Watsica and Sauer",
    "Author": "veniam",
    "OwnedBy": 396,
    "OwnedByName": "Keebler, Stanton and Schaden",
    "Category": 574,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 419,
    "PriorityName": "Kassulke-Gleason",
    "BaseStatus": "Active",
    "TicketStatus": 136,
    "TicketStatusDisplayValue": "eos",
    "Origin": "AutoGenerated",
    "CustId": 84,
    "PersonFirstname": "Esta",
    "PersonMiddleName": "D'Amore-Murphy",
    "PersonLastname": "Huels",
    "PersonFullname": "et",
    "AlertLevel": 327,
    "ConnectId": 878,
    "ReadStatus": "Green",
    "TimeToReply": 743,
    "RealTimeToReply": 99,
    "TimeToClose": 203,
    "RealTimeToClose": 702,
    "TimeSpentInternally": 736,
    "TimeSpentExternally": 942,
    "TimeSpentQueue": 610,
    "RealTimeSpentInternally": 422,
    "RealTimeSpentExternally": 770,
    "RealTimeSpentQueue": 186,
    "HasAttachment": true,
    "NumReplies": 786,
    "NumMessages": 709,
    "FromAddress": "quaerat",
    "ContactId": 807,
    "ContactName": "Nolan-Heller",
    "OwnedByAssociateId": 735,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "incentivize frictionless e-markets"
        },
        "FieldType": "System.Int32",
        "FieldLength": 86
      }
    }
  },
  "TransferTo": {
    "AssociateId": 655,
    "Name": "Goldner, Zulauf and Lebsack",
    "PersonId": 912,
    "Rank": 678,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 728,
    "FullName": "Maverick Ledner",
    "FormalName": "Bosco, Klocko and Reilly",
    "Deleted": false,
    "EjUserId": 955,
    "UserName": "Hilll LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 144
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
        "Reason": "maximize cutting-edge web services"
      },
      "FieldType": "System.Int32",
      "FieldLength": 495
    }
  }
}
```