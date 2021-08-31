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
  "ChatSessionId": 479,
  "TopicId": 251,
  "User": {
    "AssociateId": 692,
    "Name": "Ernser Inc and Sons",
    "PersonId": 275,
    "Rank": 320,
    "Tooltip": "soluta",
    "Type": "AnonymousAssociate",
    "GroupIdx": 88,
    "FullName": "Hilda Gleason",
    "FormalName": "Hegmann LLC",
    "Deleted": false,
    "EjUserId": 491,
    "UserName": "Baumbach, Bins and Stoltenberg",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 146
      }
    }
  },
  "Person": {
    "Position": "aut",
    "PersonId": 894,
    "Mrmrs": "et",
    "Firstname": "Toby",
    "Lastname": "Ankunding",
    "MiddleName": "Mayert-Bruen",
    "Title": "autem",
    "Description": "Operative analyzing neural-net",
    "Email": "gisselle.lind@nitzscheschuster.us",
    "FullName": "Cristina Beier",
    "DirectPhone": "317.754.1717 x870",
    "FormalName": "Rice-Maggio",
    "CountryId": 234,
    "ContactId": 386,
    "ContactName": "Wilderman, Terry and Hettinger",
    "Retired": 371,
    "Rank": 471,
    "ActiveInterests": 828,
    "ContactDepartment": "optimize dot-com systems",
    "ContactCountryId": 691,
    "ContactOrgNr": "414994",
    "FaxPhone": "353.624.2324",
    "MobilePhone": "1-354-282-0330 x60738",
    "ContactPhone": "1-351-465-5673 x788",
    "AssociateName": "Lind-Nitzsche",
    "AssociateId": 850,
    "UsePersonAddress": true,
    "ContactFax": "velit",
    "Kanafname": "dolorem",
    "Kanalname": "qui",
    "Post1": "cumque",
    "Post2": "architecto",
    "Post3": "molestias",
    "EmailName": "gianni.willms@sawayn.com",
    "ContactFullName": "Vivianne Stracke",
    "ActiveErpLinks": 416,
    "TicketPriorityId": 529,
    "SupportLanguageId": 446,
    "SupportAssociateId": 126,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 78
      }
    }
  },
  "CustomerAlias": "ex",
  "CustomerHost": "repellendus",
  "CustomerName": "Maggio, Bartell and Schaefer",
  "CustomerEmail": "william_mcglynn@hansen.uk",
  "CustomerPhone": "856-571-2263 x0841",
  "CustomerConsented": true,
  "CustomerCompanyName": "Leuschke-Graham",
  "Status": "Closed",
  "FirstMessage": "sed",
  "LastMessage": "vel",
  "WhenRequested": "2001-01-23T15:05:41.8030053+01:00",
  "WhenStarted": "2014-07-04T15:05:41.8030053+02:00",
  "WhenEnded": "2016-04-11T15:05:41.8030053+02:00",
  "WhenIdle": "2014-10-15T15:05:41.8030053+02:00",
  "WhenFetched": "2020-01-03T15:05:41.8030053+01:00",
  "SessionKey": "consequatur",
  "InitialQueuePos": 88,
  "AlertLevel": 697,
  "Rank": 19,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 543,
    "Name": "Schowalter LLC",
    "OrgNr": "545199",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ad",
    "DirectPhone": "872.650.4053",
    "AssociateId": 74,
    "CountryId": 951,
    "EmailAddress": "abner@morar.com",
    "Kananame": "debitis",
    "EmailAddressName": "gabriella@ziemann.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Dr. Andrew Bahringer",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "est",
    "FullName": "Pascale Kassulke PhD",
    "IsOwnerContact": true,
    "ActiveErpLinks": 450,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 59
      }
    }
  },
  "Project": {
    "ProjectId": 661,
    "Name": "McLaughlin-Blick",
    "Description": "Self-enabling bottom-line project",
    "URL": "http://www.example.com/",
    "Type": "quo",
    "AssociateId": 712,
    "AssociateFullName": "Ricky McLaughlin",
    "TypeId": 901,
    "Updated": "2012-06-26T15:05:41.804005+02:00",
    "StatusId": 102,
    "Status": "vel",
    "TextId": 463,
    "PublishTo": "2017-01-27T15:05:41.804005+01:00",
    "PublishFrom": "2005-10-27T15:05:41.804005+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "320047",
    "ActiveErpLinks": 970,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 490
      }
    }
  },
  "Sale": {
    "ContactName": "Littel, McGlynn and Gorczany",
    "SaleDate": "2013-01-25T15:05:41.804005+01:00",
    "SaleId": 278,
    "Probability": 552,
    "Title": "placeat",
    "Amount": 28071.237999999998,
    "Currency": "beatae",
    "ProjectName": "Dibbert, Gleason and Hane",
    "AssociateFullName": "Cletus Leffler",
    "Description": "Operative exuding monitoring",
    "Status": "Lost",
    "WeightedAmount": 26002.798,
    "ProjectId": 878,
    "EarningPercent": 14996.189999999999,
    "Earning": 10144.758,
    "ContactId": 350,
    "AssociateId": 369,
    "PersonId": 111,
    "SaleTypeId": 588,
    "SaleTypeName": "Beatty Group",
    "PersonFullName": "Mr. Randall Lubowitz",
    "Completed": "Completed",
    "ActiveErpLinks": 625,
    "NextDueDate": "2000-03-02T15:05:41.804005+01:00",
    "Number": "60107",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 686
      }
    }
  },
  "Ticket": {
    "TicketId": 151,
    "Title": "eveniet",
    "CreatedAt": "2005-12-16T15:05:41.804005+01:00",
    "LastChanged": "2021-01-30T15:05:41.804005+01:00",
    "ReadByOwner": "2011-04-28T15:05:41.804005+02:00",
    "ReadByCustomer": "2015-10-11T15:05:41.804005+02:00",
    "FirstReadByUser": "2018-09-17T15:05:41.804005+02:00",
    "Activate": "2018-12-05T15:05:41.804005+01:00",
    "ClosedAt": "2004-07-12T15:05:41.804005+02:00",
    "RepliedAt": "2000-12-11T15:05:41.804005+01:00",
    "AlertTimeout": "2010-09-04T15:05:41.804005+02:00",
    "Deadline": "1998-10-16T15:05:41.804005+02:00",
    "CreatedBy": 954,
    "CreatedByName": "Quitzon LLC",
    "Author": "distinctio",
    "OwnedBy": 29,
    "OwnedByName": "Bruen Inc and Sons",
    "Category": 516,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 918,
    "PriorityName": "Rodriguez, Hermiston and Muller",
    "BaseStatus": "Active",
    "TicketStatus": 276,
    "TicketStatusDisplayValue": "autem",
    "Origin": "AutoGenerated",
    "CustId": 521,
    "PersonFirstname": "Janet",
    "PersonMiddleName": "Maggio-Streich",
    "PersonLastname": "Skiles",
    "PersonFullname": "aut",
    "AlertLevel": 540,
    "ConnectId": 56,
    "ReadStatus": "Green",
    "TimeToReply": 445,
    "RealTimeToReply": 672,
    "TimeToClose": 585,
    "RealTimeToClose": 314,
    "TimeSpentInternally": 400,
    "TimeSpentExternally": 177,
    "TimeSpentQueue": 895,
    "RealTimeSpentInternally": 64,
    "RealTimeSpentExternally": 467,
    "RealTimeSpentQueue": 38,
    "HasAttachment": false,
    "NumReplies": 384,
    "NumMessages": 734,
    "FromAddress": "rem",
    "ContactId": 470,
    "ContactName": "Kozey, Dicki and Kris",
    "OwnedByAssociateId": 617,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 241
      }
    }
  },
  "TransferTo": {
    "AssociateId": 105,
    "Name": "Schimmel, Dickinson and O'Connell",
    "PersonId": 140,
    "Rank": 566,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 236,
    "FullName": "Alvena Fahey I",
    "FormalName": "Reichert-Hansen",
    "Deleted": true,
    "EjUserId": 794,
    "UserName": "Schmitt LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 500
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
      "FieldLength": 74
    }
  }
}
```