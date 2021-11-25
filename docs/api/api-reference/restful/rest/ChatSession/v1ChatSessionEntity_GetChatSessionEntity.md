---
title: GET ChatSession/{id}
id: v1ChatSessionEntity_GetChatSessionEntity
---

# GET ChatSession/{id}

```http
GET /api/v1/ChatSession/{id}
```

Gets a ChatSessionEntity object.

Calls the Chat agent service GetChatSessionEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ChatSessionEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
GET /api/v1/ChatSession/{id}?$select=name,department,category/id
```


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



ChatSessionEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ChatSessionEntity found. |
| 404 | Not Found. |

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
| _Links | object |  |

## Sample Request

```http!
GET /api/v1/ChatSession/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 ChatSessionEntity found.
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 860,
  "TopicId": 190,
  "User": {
    "AssociateId": 530,
    "Name": "White LLC",
    "PersonId": 429,
    "Rank": 1000,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 150,
    "FullName": "Kiana Rau",
    "FormalName": "Stehr, Ledner and Schmidt",
    "Deleted": false,
    "EjUserId": 634,
    "UserName": "Champlin-Watsica",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 747
      }
    }
  },
  "Person": {
    "Position": "nam",
    "PersonId": 117,
    "Mrmrs": "harum",
    "Firstname": "Jarrett",
    "Lastname": "Kerluke",
    "MiddleName": "Prosacco, Keeling and Tremblay",
    "Title": "provident",
    "Description": "Networked grid-enabled Graphical User Interface",
    "Email": "winona@leuschke.uk",
    "FullName": "Mrs. Elmira Armstrong",
    "DirectPhone": "051-226-6752",
    "FormalName": "Koch-Collier",
    "CountryId": 906,
    "ContactId": 271,
    "ContactName": "Murphy-Bergstrom",
    "Retired": 165,
    "Rank": 138,
    "ActiveInterests": 205,
    "ContactDepartment": "",
    "ContactCountryId": 520,
    "ContactOrgNr": "822904",
    "FaxPhone": "741.012.4160 x153",
    "MobilePhone": "(756)143-3040 x32170",
    "ContactPhone": "014.671.5511",
    "AssociateName": "Veum Inc and Sons",
    "AssociateId": 162,
    "UsePersonAddress": true,
    "ContactFax": "harum",
    "Kanafname": "nemo",
    "Kanalname": "a",
    "Post1": "omnis",
    "Post2": "voluptatem",
    "Post3": "aperiam",
    "EmailName": "lonnie@denesik.uk",
    "ContactFullName": "Mr. Alvena Pouros",
    "ActiveErpLinks": 5,
    "TicketPriorityId": 713,
    "SupportLanguageId": 989,
    "SupportAssociateId": 145,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 493
      }
    }
  },
  "CustomerAlias": "aliquid",
  "CustomerHost": "consequatur",
  "CustomerName": "Simonis-Marquardt",
  "CustomerEmail": "giovanny@nitzsche.co.uk",
  "CustomerPhone": "(482)036-6110",
  "CustomerConsented": false,
  "CustomerCompanyName": "Mertz LLC",
  "Status": "Closed",
  "FirstMessage": "enim",
  "LastMessage": "distinctio",
  "WhenRequested": "1995-03-25T18:25:50.0235632+01:00",
  "WhenStarted": "2003-03-26T18:25:50.0235632+01:00",
  "WhenEnded": "2013-04-14T18:25:50.0235632+02:00",
  "WhenIdle": "2014-08-26T18:25:50.0235632+02:00",
  "WhenFetched": "2015-12-19T18:25:50.0235632+01:00",
  "SessionKey": "aut",
  "InitialQueuePos": 789,
  "AlertLevel": 8,
  "Rank": 295,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 965,
    "Name": "Wuckert LLC",
    "OrgNr": "688430",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "itaque",
    "DirectPhone": "026.364.8754 x3880",
    "AssociateId": 403,
    "CountryId": 154,
    "EmailAddress": "amina_jast@rolfson.co.uk",
    "Kananame": "voluptas",
    "EmailAddressName": "arne_kshlerin@corwin.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Tatum Larson",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "aperiam",
    "FullName": "Hiram Simonis",
    "IsOwnerContact": true,
    "ActiveErpLinks": 971,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 371
      }
    }
  },
  "Project": {
    "ProjectId": 458,
    "Name": "Mueller, Lebsack and Strosin",
    "Description": "Future-proofed fault-tolerant strategy",
    "URL": "http://www.example.com/",
    "Type": "eos",
    "AssociateId": 197,
    "AssociateFullName": "Miss Tiara Wolff",
    "TypeId": 373,
    "Updated": "1998-11-04T18:25:50.0245654+01:00",
    "StatusId": 63,
    "Status": "rerum",
    "TextId": 506,
    "PublishTo": "2000-01-25T18:25:50.0245654+01:00",
    "PublishFrom": "2007-05-01T18:25:50.0245654+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1325425",
    "ActiveErpLinks": 322,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 668
      }
    }
  },
  "Sale": {
    "ContactName": "Robel-Rath",
    "SaleDate": "2016-08-13T18:25:50.0245654+02:00",
    "SaleId": 747,
    "Probability": 377,
    "Title": "alias",
    "Amount": 16823.311999999998,
    "Currency": "est",
    "ProjectName": "Olson-Nader",
    "AssociateFullName": "Mrs. Joanny Stehr",
    "Description": "Profit-focused bandwidth-monitored array",
    "Status": "Lost",
    "WeightedAmount": 8822.21,
    "ProjectId": 866,
    "EarningPercent": 20643.658,
    "Earning": 6477.978,
    "ContactId": 804,
    "AssociateId": 148,
    "PersonId": 925,
    "SaleTypeId": 24,
    "SaleTypeName": "Bosco-Emard",
    "PersonFullName": "Preston Gislason Jr.",
    "Completed": "Completed",
    "ActiveErpLinks": 235,
    "NextDueDate": "1994-08-13T18:25:50.0255635+02:00",
    "Number": "275659",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 184
      }
    }
  },
  "Ticket": {
    "TicketId": 873,
    "Title": "aliquid",
    "CreatedAt": "2002-05-03T18:25:50.0255635+02:00",
    "LastChanged": "1999-07-31T18:25:50.0255635+02:00",
    "ReadByOwner": "2017-10-10T18:25:50.0255635+02:00",
    "ReadByCustomer": "2018-01-21T18:25:50.0255635+01:00",
    "FirstReadByUser": "1995-09-23T18:25:50.0255635+02:00",
    "Activate": "2006-07-30T18:25:50.0255635+02:00",
    "ClosedAt": "2004-08-21T18:25:50.0255635+02:00",
    "RepliedAt": "2009-04-16T18:25:50.0255635+02:00",
    "AlertTimeout": "1998-08-30T18:25:50.0255635+02:00",
    "Deadline": "2007-04-11T18:25:50.0255635+02:00",
    "CreatedBy": 540,
    "CreatedByName": "Kreiger-Blick",
    "Author": "soluta",
    "OwnedBy": 682,
    "OwnedByName": "Kohler-Skiles",
    "Category": 761,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 773,
    "PriorityName": "Nolan-Veum",
    "BaseStatus": "Active",
    "TicketStatus": 134,
    "TicketStatusDisplayValue": "magni",
    "Origin": "AutoGenerated",
    "CustId": 337,
    "PersonFirstname": "Lew",
    "PersonMiddleName": "Durgan, Durgan and Feil",
    "PersonLastname": "Wilderman",
    "PersonFullname": "harum",
    "AlertLevel": 172,
    "ConnectId": 807,
    "ReadStatus": "Green",
    "TimeToReply": 201,
    "RealTimeToReply": 696,
    "TimeToClose": 425,
    "RealTimeToClose": 736,
    "TimeSpentInternally": 985,
    "TimeSpentExternally": 119,
    "TimeSpentQueue": 201,
    "RealTimeSpentInternally": 52,
    "RealTimeSpentExternally": 785,
    "RealTimeSpentQueue": 406,
    "HasAttachment": true,
    "NumReplies": 595,
    "NumMessages": 507,
    "FromAddress": "provident",
    "ContactId": 498,
    "ContactName": "Langosh LLC",
    "OwnedByAssociateId": 59,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 958
      }
    }
  },
  "TransferTo": {
    "AssociateId": 688,
    "Name": "Haag, Kessler and Rempel",
    "PersonId": 141,
    "Rank": 835,
    "Tooltip": "tenetur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 574,
    "FullName": "Dale Daugherty",
    "FormalName": "Armstrong Inc and Sons",
    "Deleted": true,
    "EjUserId": 694,
    "UserName": "Gislason, Douglas and Prosacco",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 218
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
        "Reason": "target web-enabled paradigms"
      },
      "FieldType": "System.Int32",
      "FieldLength": 813
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```