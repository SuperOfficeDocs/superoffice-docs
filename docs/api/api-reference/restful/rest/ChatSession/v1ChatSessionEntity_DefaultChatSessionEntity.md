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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 441,
  "TopicId": 634,
  "User": {
    "AssociateId": 659,
    "Name": "Schinner-Predovic",
    "PersonId": 415,
    "Rank": 966,
    "Tooltip": "molestiae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 165,
    "FullName": "Zachariah Dare",
    "FormalName": "Keeling, Parisian and Smitham",
    "Deleted": false,
    "EjUserId": 805,
    "UserName": "Pollich Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 339
      }
    }
  },
  "Person": {
    "Position": "nam",
    "PersonId": 869,
    "Mrmrs": "id",
    "Firstname": "Elliott",
    "Lastname": "Goodwin",
    "MiddleName": "Greenfelder-Zemlak",
    "Title": "quia",
    "Description": "Proactive didactic project",
    "Email": "chelsey_collier@collier.biz",
    "FullName": "Audrey Roberts",
    "DirectPhone": "1-848-600-8701",
    "FormalName": "Baumbach-Rau",
    "CountryId": 552,
    "ContactId": 570,
    "ContactName": "Nolan-Ratke",
    "Retired": 107,
    "Rank": 533,
    "ActiveInterests": 326,
    "ContactDepartment": "",
    "ContactCountryId": 949,
    "ContactOrgNr": "1312231",
    "FaxPhone": "178.185.5866 x0204",
    "MobilePhone": "1-850-401-5620",
    "ContactPhone": "(818)755-7271",
    "AssociateName": "Turcotte, Collier and Sauer",
    "AssociateId": 485,
    "UsePersonAddress": false,
    "ContactFax": "aut",
    "Kanafname": "eum",
    "Kanalname": "omnis",
    "Post1": "vel",
    "Post2": "saepe",
    "Post3": "quibusdam",
    "EmailName": "liliane.mclaughlin@treutel.us",
    "ContactFullName": "Rasheed Davis",
    "ActiveErpLinks": 446,
    "TicketPriorityId": 380,
    "SupportLanguageId": 768,
    "SupportAssociateId": 684,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 924
      }
    }
  },
  "CustomerAlias": "est",
  "CustomerHost": "porro",
  "CustomerName": "Tillman, Paucek and Kautzer",
  "CustomerEmail": "albertha@heidenreichpollich.biz",
  "CustomerPhone": "(520)372-1170",
  "CustomerConsented": false,
  "CustomerCompanyName": "Abshire, Treutel and Stroman",
  "Status": "Closed",
  "FirstMessage": "eos",
  "LastMessage": "aut",
  "WhenRequested": "2016-06-22T15:05:41.6070024+02:00",
  "WhenStarted": "2013-02-07T15:05:41.6070024+01:00",
  "WhenEnded": "1996-11-24T15:05:41.6070024+01:00",
  "WhenIdle": "2014-10-20T15:05:41.6070024+02:00",
  "WhenFetched": "2002-03-28T15:05:41.6070024+01:00",
  "SessionKey": "totam",
  "InitialQueuePos": 223,
  "AlertLevel": 324,
  "Rank": 356,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 492,
    "Name": "Greenfelder, Cremin and Keebler",
    "OrgNr": "823312",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "est",
    "DirectPhone": "(552)864-5024 x658",
    "AssociateId": 302,
    "CountryId": 348,
    "EmailAddress": "luisa.runte@schultz.com",
    "Kananame": "quo",
    "EmailAddressName": "hudson_robel@grady.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Deangelo Adams",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "porro",
    "FullName": "Macy Graham",
    "IsOwnerContact": true,
    "ActiveErpLinks": 979,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 855
      }
    }
  },
  "Project": {
    "ProjectId": 86,
    "Name": "Zulauf-Jewess",
    "Description": "Universal optimizing monitoring",
    "URL": "http://www.example.com/",
    "Type": "architecto",
    "AssociateId": 110,
    "AssociateFullName": "Vivianne Schamberger",
    "TypeId": 133,
    "Updated": "2015-05-30T15:05:41.608012+02:00",
    "StatusId": 488,
    "Status": "iusto",
    "TextId": 134,
    "PublishTo": "2016-10-27T15:05:41.608012+02:00",
    "PublishFrom": "2006-07-25T15:05:41.608012+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1590639",
    "ActiveErpLinks": 703,
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
  "Sale": {
    "ContactName": "Hickle-Bergstrom",
    "SaleDate": "2013-01-01T15:05:41.608012+01:00",
    "SaleId": 891,
    "Probability": 354,
    "Title": "quod",
    "Amount": 19029.648,
    "Currency": "impedit",
    "ProjectName": "Mueller Inc and Sons",
    "AssociateFullName": "Carmella Rohan",
    "Description": "Customizable incremental analyzer",
    "Status": "Lost",
    "WeightedAmount": 16118.162,
    "ProjectId": 334,
    "EarningPercent": 1062.426,
    "Earning": 6863.46,
    "ContactId": 304,
    "AssociateId": 981,
    "PersonId": 648,
    "SaleTypeId": 172,
    "SaleTypeName": "Block, Kunze and Cassin",
    "PersonFullName": "Jamal Roberts",
    "Completed": "Completed",
    "ActiveErpLinks": 653,
    "NextDueDate": "1997-01-05T15:05:41.608012+01:00",
    "Number": "1610189",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 426
      }
    }
  },
  "Ticket": {
    "TicketId": 114,
    "Title": "itaque",
    "CreatedAt": "1998-01-15T15:05:41.6090022+01:00",
    "LastChanged": "2003-05-04T15:05:41.6090022+02:00",
    "ReadByOwner": "1995-08-15T15:05:41.6090022+02:00",
    "ReadByCustomer": "2002-09-24T15:05:41.6090022+02:00",
    "FirstReadByUser": "2001-10-06T15:05:41.6090022+02:00",
    "Activate": "2008-09-27T15:05:41.6090022+02:00",
    "ClosedAt": "2003-03-28T15:05:41.6090022+01:00",
    "RepliedAt": "2019-01-13T15:05:41.6090022+01:00",
    "AlertTimeout": "2020-10-05T15:05:41.6090022+02:00",
    "Deadline": "2020-10-01T15:05:41.6090022+02:00",
    "CreatedBy": 99,
    "CreatedByName": "Hilpert-Rolfson",
    "Author": "necessitatibus",
    "OwnedBy": 289,
    "OwnedByName": "Weimann Group",
    "Category": 704,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 569,
    "PriorityName": "Flatley Group",
    "BaseStatus": "Active",
    "TicketStatus": 897,
    "TicketStatusDisplayValue": "voluptatem",
    "Origin": "AutoGenerated",
    "CustId": 108,
    "PersonFirstname": "Garnett",
    "PersonMiddleName": "Sawayn LLC",
    "PersonLastname": "Runolfsdottir",
    "PersonFullname": "est",
    "AlertLevel": 655,
    "ConnectId": 139,
    "ReadStatus": "Green",
    "TimeToReply": 711,
    "RealTimeToReply": 559,
    "TimeToClose": 556,
    "RealTimeToClose": 315,
    "TimeSpentInternally": 409,
    "TimeSpentExternally": 80,
    "TimeSpentQueue": 174,
    "RealTimeSpentInternally": 966,
    "RealTimeSpentExternally": 783,
    "RealTimeSpentQueue": 215,
    "HasAttachment": true,
    "NumReplies": 116,
    "NumMessages": 236,
    "FromAddress": "aut",
    "ContactId": 855,
    "ContactName": "Yost-Frami",
    "OwnedByAssociateId": 779,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 992
      }
    }
  },
  "TransferTo": {
    "AssociateId": 214,
    "Name": "Wisoky Inc and Sons",
    "PersonId": 127,
    "Rank": 901,
    "Tooltip": "quis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 336,
    "FullName": "Adeline Lindgren",
    "FormalName": "Hartmann, Cormier and Reichert",
    "Deleted": false,
    "EjUserId": 483,
    "UserName": "Watsica-Gerlach",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 913
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
      "FieldLength": 135
    }
  }
}
```