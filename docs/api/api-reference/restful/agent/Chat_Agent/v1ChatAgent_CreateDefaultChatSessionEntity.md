---
title: POST Agents/Chat/CreateDefaultChatSessionEntity
id: v1ChatAgent_CreateDefaultChatSessionEntity
---

# POST Agents/Chat/CreateDefaultChatSessionEntity

```http
POST /api/v1/Agents/Chat/CreateDefaultChatSessionEntity
```

Set default values into a new ChatSessionEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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
POST /api/v1/Agents/Chat/CreateDefaultChatSessionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 275,
  "TopicId": 504,
  "User": {
    "AssociateId": 94,
    "Name": "Cartwright-Schmitt",
    "PersonId": 118,
    "Rank": 169,
    "Tooltip": "voluptate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 925,
    "FullName": "Dr. Breanne Davis",
    "FormalName": "Wolff-Weber",
    "Deleted": false,
    "EjUserId": 775,
    "UserName": "Bechtelar, Quitzon and Powlowski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 177
      }
    }
  },
  "Person": {
    "Position": "dicta",
    "PersonId": 867,
    "Mrmrs": "omnis",
    "Firstname": "Rosalia",
    "Lastname": "Bayer",
    "MiddleName": "Collier, Lehner and Kozey",
    "Title": "optio",
    "Description": "Enhanced multimedia approach",
    "Email": "jazmyne.reichert@crooksdickens.uk",
    "FullName": "Destiny Hilpert",
    "DirectPhone": "(385)018-2274 x480",
    "FormalName": "Green LLC",
    "CountryId": 462,
    "ContactId": 73,
    "ContactName": "Parisian LLC",
    "Retired": 641,
    "Rank": 724,
    "ActiveInterests": 69,
    "ContactDepartment": "",
    "ContactCountryId": 223,
    "ContactOrgNr": "1122150",
    "FaxPhone": "(362)455-1845 x68224",
    "MobilePhone": "052-768-6160",
    "ContactPhone": "1-242-828-3361 x4450",
    "AssociateName": "Zboncak-Kilback",
    "AssociateId": 373,
    "UsePersonAddress": false,
    "ContactFax": "qui",
    "Kanafname": "quae",
    "Kanalname": "qui",
    "Post1": "cupiditate",
    "Post2": "voluptatum",
    "Post3": "aut",
    "EmailName": "kasey_wilkinson@dietrichpacocha.uk",
    "ContactFullName": "Tania Stiedemann",
    "ActiveErpLinks": 763,
    "TicketPriorityId": 848,
    "SupportLanguageId": 568,
    "SupportAssociateId": 150,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 975
      }
    }
  },
  "CustomerAlias": "consequatur",
  "CustomerHost": "aut",
  "CustomerName": "Aufderhar-Klein",
  "CustomerEmail": "frederick_jacobi@vandervort.co.uk",
  "CustomerPhone": "1-861-076-8714 x4103",
  "CustomerConsented": false,
  "CustomerCompanyName": "Tremblay, Kutch and Sauer",
  "Status": "Closed",
  "FirstMessage": "sunt",
  "LastMessage": "recusandae",
  "WhenRequested": "2021-09-14T18:28:48.1793+02:00",
  "WhenStarted": "2006-04-08T18:28:48.1793+02:00",
  "WhenEnded": "2013-06-24T18:28:48.1793+02:00",
  "WhenIdle": "2003-09-13T18:28:48.1793+02:00",
  "WhenFetched": "2006-01-22T18:28:48.1793+01:00",
  "SessionKey": "rerum",
  "InitialQueuePos": 32,
  "AlertLevel": 785,
  "Rank": 832,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 857,
    "Name": "Feil-Daugherty",
    "OrgNr": "1344865",
    "Department": "engineer wireless interfaces",
    "URL": "http://www.example.com/",
    "City": "ut",
    "DirectPhone": "1-853-386-7321 x02421",
    "AssociateId": 514,
    "CountryId": 592,
    "EmailAddress": "haylie@farrell.com",
    "Kananame": "quia",
    "EmailAddressName": "heather@roob.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mrs. Nestor Wehner",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ut",
    "FullName": "Mr. Vernon Smith",
    "IsOwnerContact": false,
    "ActiveErpLinks": 391,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 616
      }
    }
  },
  "Project": {
    "ProjectId": 898,
    "Name": "Erdman Inc and Sons",
    "Description": "Streamlined directional orchestration",
    "URL": "http://www.example.com/",
    "Type": "corrupti",
    "AssociateId": 712,
    "AssociateFullName": "Miss Evert Cassin",
    "TypeId": 616,
    "Updated": "2005-12-09T18:28:48.1802915+01:00",
    "StatusId": 858,
    "Status": "adipisci",
    "TextId": 92,
    "PublishTo": "2007-10-19T18:28:48.1802915+02:00",
    "PublishFrom": "2014-03-13T18:28:48.1802915+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "387506",
    "ActiveErpLinks": 399,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 763
      }
    }
  },
  "Sale": {
    "ContactName": "Hilpert-Hamill",
    "SaleDate": "1999-11-14T18:28:48.1802915+01:00",
    "SaleId": 852,
    "Probability": 455,
    "Title": "quia",
    "Amount": 28817.129999999997,
    "Currency": "tempore",
    "ProjectName": "King, Mante and Kling",
    "AssociateFullName": "Mariana Sipes",
    "Description": "Enhanced 24 hour internet solution",
    "Status": "Lost",
    "WeightedAmount": 23808.998,
    "ProjectId": 909,
    "EarningPercent": 3118.33,
    "Earning": 19274.1,
    "ContactId": 71,
    "AssociateId": 172,
    "PersonId": 819,
    "SaleTypeId": 439,
    "SaleTypeName": "Hagenes, Kshlerin and Reinger",
    "PersonFullName": "Meredith Haley",
    "Completed": "Completed",
    "ActiveErpLinks": 277,
    "NextDueDate": "2017-06-25T18:28:48.1802915+02:00",
    "Number": "764505",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 673
      }
    }
  },
  "Ticket": {
    "TicketId": 832,
    "Title": "deserunt",
    "CreatedAt": "1997-07-11T18:28:48.1802915+02:00",
    "LastChanged": "2002-03-06T18:28:48.1802915+01:00",
    "ReadByOwner": "2009-03-19T18:28:48.1802915+01:00",
    "ReadByCustomer": "2017-03-18T18:28:48.1802915+01:00",
    "FirstReadByUser": "2010-05-14T18:28:48.1802915+02:00",
    "Activate": "2015-08-25T18:28:48.1802915+02:00",
    "ClosedAt": "2008-12-11T18:28:48.1802915+01:00",
    "RepliedAt": "2005-02-21T18:28:48.1802915+01:00",
    "AlertTimeout": "2010-08-18T18:28:48.1802915+02:00",
    "Deadline": "2002-08-06T18:28:48.1802915+02:00",
    "CreatedBy": 237,
    "CreatedByName": "Grimes-Hudson",
    "Author": "possimus",
    "OwnedBy": 363,
    "OwnedByName": "Reichert-Greenholt",
    "Category": 748,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 139,
    "PriorityName": "Beier-Torp",
    "BaseStatus": "Active",
    "TicketStatus": 623,
    "TicketStatusDisplayValue": "corrupti",
    "Origin": "AutoGenerated",
    "CustId": 786,
    "PersonFirstname": "Guiseppe",
    "PersonMiddleName": "Walter-Raynor",
    "PersonLastname": "Ledner",
    "PersonFullname": "veritatis",
    "AlertLevel": 500,
    "ConnectId": 803,
    "ReadStatus": "Green",
    "TimeToReply": 905,
    "RealTimeToReply": 836,
    "TimeToClose": 42,
    "RealTimeToClose": 779,
    "TimeSpentInternally": 822,
    "TimeSpentExternally": 258,
    "TimeSpentQueue": 861,
    "RealTimeSpentInternally": 691,
    "RealTimeSpentExternally": 58,
    "RealTimeSpentQueue": 312,
    "HasAttachment": true,
    "NumReplies": 372,
    "NumMessages": 849,
    "FromAddress": "qui",
    "ContactId": 908,
    "ContactName": "Lesch LLC",
    "OwnedByAssociateId": 853,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 453
      }
    }
  },
  "TransferTo": {
    "AssociateId": 981,
    "Name": "Koelpin, Runolfsdottir and Fay",
    "PersonId": 223,
    "Rank": 299,
    "Tooltip": "quos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 231,
    "FullName": "Jorge Goyette",
    "FormalName": "Murazik Group",
    "Deleted": false,
    "EjUserId": 434,
    "UserName": "Padberg Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 621
      }
    }
  },
  "ChatbotIsActive": true,
  "TableRight": {
    "Mask": "Delete",
    "Reason": "matrix impactful methodologies"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 103
    }
  }
}
```