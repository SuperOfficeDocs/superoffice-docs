---
title: POST ChatTopic/{id}/Sessions
id: v1ChatTopicEntity_CreateChatSessionForTopic
---

# POST ChatTopic/{id}/Sessions

```http
POST /api/v1/ChatTopic/{chatTopicId}/Sessions
```

Create a new session on a chat topic






| Path Part | Type | Description |
|-----------|------|-------------|
| chatTopicId | int32 | Id of the chat topic **Required** |



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
POST /api/v1/ChatTopic/{chatTopicId}/Sessions
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 92,
  "TopicId": 655,
  "User": {
    "AssociateId": 751,
    "Name": "Ortiz LLC",
    "PersonId": 826,
    "Rank": 975,
    "Tooltip": "odit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 755,
    "FullName": "Hannah Kuhlman",
    "FormalName": "Brakus LLC",
    "Deleted": false,
    "EjUserId": 673,
    "UserName": "Torp Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 534
      }
    }
  },
  "Person": {
    "Position": "delectus",
    "PersonId": 226,
    "Mrmrs": "sit",
    "Firstname": "Jamel",
    "Lastname": "Walker",
    "MiddleName": "Pouros, Okuneva and Carroll",
    "Title": "vel",
    "Description": "Centralized uniform extranet",
    "Email": "marcelina.dach@rennerbins.uk",
    "FullName": "Evert O'Conner",
    "DirectPhone": "1-166-271-1032 x726",
    "FormalName": "Schmeler-Jerde",
    "CountryId": 986,
    "ContactId": 786,
    "ContactName": "McLaughlin-Daugherty",
    "Retired": 573,
    "Rank": 324,
    "ActiveInterests": 370,
    "ContactDepartment": "",
    "ContactCountryId": 692,
    "ContactOrgNr": "1752383",
    "FaxPhone": "(787)735-0877 x27883",
    "MobilePhone": "(030)853-0703 x53381",
    "ContactPhone": "(314)284-3074",
    "AssociateName": "Willms Inc and Sons",
    "AssociateId": 728,
    "UsePersonAddress": true,
    "ContactFax": "rerum",
    "Kanafname": "ullam",
    "Kanalname": "vero",
    "Post1": "ut",
    "Post2": "accusamus",
    "Post3": "possimus",
    "EmailName": "tianna@millsschulist.biz",
    "ContactFullName": "Justyn Schamberger",
    "ActiveErpLinks": 395,
    "TicketPriorityId": 69,
    "SupportLanguageId": 945,
    "SupportAssociateId": 580,
    "CategoryName": "VIP Customer",
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
  "CustomerAlias": "magni",
  "CustomerHost": "sit",
  "CustomerName": "Adams LLC",
  "CustomerEmail": "marie_hyatt@tillmancruickshank.uk",
  "CustomerPhone": "(621)173-2214 x27461",
  "CustomerConsented": false,
  "CustomerCompanyName": "Baumbach, Crona and Ritchie",
  "Status": "Closed",
  "FirstMessage": "non",
  "LastMessage": "labore",
  "WhenRequested": "2001-09-08T18:25:50.1896249+02:00",
  "WhenStarted": "2018-03-29T18:25:50.1896249+02:00",
  "WhenEnded": "1998-10-23T18:25:50.1896249+02:00",
  "WhenIdle": "2005-08-31T18:25:50.1896249+02:00",
  "WhenFetched": "2017-12-10T18:25:50.1896249+01:00",
  "SessionKey": "incidunt",
  "InitialQueuePos": 628,
  "AlertLevel": 45,
  "Rank": 862,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 768,
    "Name": "Hand Group",
    "OrgNr": "1060964",
    "Department": "maximize integrated relationships",
    "URL": "http://www.example.com/",
    "City": "a",
    "DirectPhone": "(457)063-2328 x1236",
    "AssociateId": 51,
    "CountryId": 576,
    "EmailAddress": "demario@stokesjohnston.com",
    "Kananame": "quisquam",
    "EmailAddressName": "sammy@grahamhand.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Harley Dare",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "consequuntur",
    "FullName": "Anne Ernser",
    "IsOwnerContact": false,
    "ActiveErpLinks": 694,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 117
      }
    }
  },
  "Project": {
    "ProjectId": 196,
    "Name": "Koch-Koss",
    "Description": "Cloned 4th generation product",
    "URL": "http://www.example.com/",
    "Type": "fugiat",
    "AssociateId": 99,
    "AssociateFullName": "Elise Schmitt",
    "TypeId": 122,
    "Updated": "2002-10-09T18:25:50.1906249+02:00",
    "StatusId": 835,
    "Status": "aut",
    "TextId": 78,
    "PublishTo": "2019-02-24T18:25:50.1906249+01:00",
    "PublishFrom": "2016-07-16T18:25:50.1906249+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "330165",
    "ActiveErpLinks": 590,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 326
      }
    }
  },
  "Sale": {
    "ContactName": "Grimes, Blanda and Nitzsche",
    "SaleDate": "2003-07-17T18:25:50.1906249+02:00",
    "SaleId": 527,
    "Probability": 710,
    "Title": "necessitatibus",
    "Amount": 6183.382,
    "Currency": "quis",
    "ProjectName": "McClure-Blick",
    "AssociateFullName": "Rex Romaguera",
    "Description": "User-centric incremental archive",
    "Status": "Lost",
    "WeightedAmount": 17393.7,
    "ProjectId": 275,
    "EarningPercent": 13253.686,
    "Earning": 28835.933999999997,
    "ContactId": 480,
    "AssociateId": 528,
    "PersonId": 206,
    "SaleTypeId": 885,
    "SaleTypeName": "Ledner-Zemlak",
    "PersonFullName": "Alex Schmitt",
    "Completed": "Completed",
    "ActiveErpLinks": 660,
    "NextDueDate": "2018-04-21T18:25:50.1916241+02:00",
    "Number": "1585249",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "engineer impactful mindshare"
        },
        "FieldType": "System.String",
        "FieldLength": 136
      }
    }
  },
  "Ticket": {
    "TicketId": 997,
    "Title": "voluptas",
    "CreatedAt": "2001-08-26T18:25:50.1916241+02:00",
    "LastChanged": "2006-08-04T18:25:50.1916241+02:00",
    "ReadByOwner": "2014-11-23T18:25:50.1916241+01:00",
    "ReadByCustomer": "2015-07-14T18:25:50.1916241+02:00",
    "FirstReadByUser": "2019-02-27T18:25:50.1916241+01:00",
    "Activate": "2001-08-17T18:25:50.1916241+02:00",
    "ClosedAt": "1999-12-21T18:25:50.1916241+01:00",
    "RepliedAt": "2015-11-20T18:25:50.1916241+01:00",
    "AlertTimeout": "2001-05-10T18:25:50.1916241+02:00",
    "Deadline": "2020-08-15T18:25:50.1916241+02:00",
    "CreatedBy": 184,
    "CreatedByName": "Abshire LLC",
    "Author": "autem",
    "OwnedBy": 455,
    "OwnedByName": "Goodwin-Prohaska",
    "Category": 169,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 354,
    "PriorityName": "Ondricka-Miller",
    "BaseStatus": "Active",
    "TicketStatus": 489,
    "TicketStatusDisplayValue": "eos",
    "Origin": "AutoGenerated",
    "CustId": 532,
    "PersonFirstname": "Roger",
    "PersonMiddleName": "Steuber Group",
    "PersonLastname": "Rippin",
    "PersonFullname": "non",
    "AlertLevel": 63,
    "ConnectId": 391,
    "ReadStatus": "Green",
    "TimeToReply": 383,
    "RealTimeToReply": 550,
    "TimeToClose": 810,
    "RealTimeToClose": 230,
    "TimeSpentInternally": 98,
    "TimeSpentExternally": 211,
    "TimeSpentQueue": 22,
    "RealTimeSpentInternally": 356,
    "RealTimeSpentExternally": 328,
    "RealTimeSpentQueue": 584,
    "HasAttachment": false,
    "NumReplies": 666,
    "NumMessages": 597,
    "FromAddress": "quia",
    "ContactId": 723,
    "ContactName": "Kuphal-Zulauf",
    "OwnedByAssociateId": 315,
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
  "TransferTo": {
    "AssociateId": 362,
    "Name": "Rogahn, Schmeler and Nikolaus",
    "PersonId": 727,
    "Rank": 624,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 243,
    "FullName": "Mohammed Kemmer",
    "FormalName": "Lehner-Kohler",
    "Deleted": true,
    "EjUserId": 814,
    "UserName": "Schroeder, Daniel and Lebsack",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 161
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
      "FieldLength": 158
    }
  }
}
```