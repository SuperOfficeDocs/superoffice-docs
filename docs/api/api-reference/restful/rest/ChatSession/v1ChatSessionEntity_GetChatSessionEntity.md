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
  "ChatSessionId": 291,
  "TopicId": 58,
  "User": {
    "AssociateId": 557,
    "Name": "Hodkiewicz, Bogisich and Mueller",
    "PersonId": 575,
    "Rank": 858,
    "Tooltip": "dignissimos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 656,
    "FullName": "Regan Stamm",
    "FormalName": "Reynolds Inc and Sons",
    "Deleted": false,
    "EjUserId": 904,
    "UserName": "Crist LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 145
      }
    }
  },
  "Person": {
    "Position": "accusamus",
    "PersonId": 760,
    "Mrmrs": "error",
    "Firstname": "Toney",
    "Lastname": "Harris",
    "MiddleName": "Herman, Conn and Langosh",
    "Title": "quia",
    "Description": "Multi-lateral system-worthy encryption",
    "Email": "alan@leschzulauf.co.uk",
    "FullName": "Jarvis Raynor",
    "DirectPhone": "(728)838-2418 x42561",
    "FormalName": "Kuhn, Ullrich and Erdman",
    "CountryId": 553,
    "ContactId": 448,
    "ContactName": "Dickens-Stanton",
    "Retired": 293,
    "Rank": 343,
    "ActiveInterests": 59,
    "ContactDepartment": "",
    "ContactCountryId": 147,
    "ContactOrgNr": "1178361",
    "FaxPhone": "(461)083-6435",
    "MobilePhone": "(760)352-0502",
    "ContactPhone": "330.060.8038",
    "AssociateName": "Gerhold Group",
    "AssociateId": 901,
    "UsePersonAddress": false,
    "ContactFax": "ipsa",
    "Kanafname": "eos",
    "Kanalname": "voluptatem",
    "Post1": "sit",
    "Post2": "vitae",
    "Post3": "voluptates",
    "EmailName": "tess@price.co.uk",
    "ContactFullName": "Diamond Sauer",
    "ActiveErpLinks": 63,
    "TicketPriorityId": 889,
    "SupportLanguageId": 705,
    "SupportAssociateId": 744,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 316
      }
    }
  },
  "CustomerAlias": "molestias",
  "CustomerHost": "provident",
  "CustomerName": "Durgan Group",
  "CustomerEmail": "tommie@armstrongmuller.com",
  "CustomerPhone": "1-831-411-2224 x5701",
  "CustomerConsented": true,
  "CustomerCompanyName": "Bailey-Senger",
  "Status": "Closed",
  "FirstMessage": "quas",
  "LastMessage": "illo",
  "WhenRequested": "2010-11-04T09:40:58.6973704+01:00",
  "WhenStarted": "2011-02-17T09:40:58.6973704+01:00",
  "WhenEnded": "2001-09-27T09:40:58.6973704+02:00",
  "WhenIdle": "2017-02-12T09:40:58.6973704+01:00",
  "WhenFetched": "2015-01-08T09:40:58.6973704+01:00",
  "SessionKey": "odio",
  "InitialQueuePos": 276,
  "AlertLevel": 640,
  "Rank": 606,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 922,
    "Name": "Muller Inc and Sons",
    "OrgNr": "277254",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ad",
    "DirectPhone": "(821)704-5112 x2336",
    "AssociateId": 116,
    "CountryId": 443,
    "EmailAddress": "adell@schimmelfranecki.name",
    "Kananame": "minus",
    "EmailAddressName": "bette@stoltenberg.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ella Hettinger",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "sed",
    "FullName": "Erick Crooks",
    "IsOwnerContact": true,
    "ActiveErpLinks": 878,
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
  "Project": {
    "ProjectId": 532,
    "Name": "Torphy, Beahan and Reynolds",
    "Description": "Automated actuating circuit",
    "URL": "http://www.example.com/",
    "Type": "dignissimos",
    "AssociateId": 897,
    "AssociateFullName": "Ms. Lane Wiegand",
    "TypeId": 769,
    "Updated": "2002-01-22T09:40:58.6993703+01:00",
    "StatusId": 543,
    "Status": "occaecati",
    "TextId": 276,
    "PublishTo": "2018-11-05T09:40:58.6993703+01:00",
    "PublishFrom": "1994-01-10T09:40:58.6993703+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1880896",
    "ActiveErpLinks": 731,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 166
      }
    }
  },
  "Sale": {
    "ContactName": "Turcotte-Oberbrunner",
    "SaleDate": "2002-01-11T09:40:58.6993703+01:00",
    "SaleId": 183,
    "Probability": 882,
    "Title": "sint",
    "Amount": 10746.485999999999,
    "Currency": "repellendus",
    "ProjectName": "VonRueden, McKenzie and Bergnaum",
    "AssociateFullName": "Murphy Ebert V",
    "Description": "Devolved interactive process improvement",
    "Status": "Lost",
    "WeightedAmount": 25357.194,
    "ProjectId": 445,
    "EarningPercent": 29469.002,
    "Earning": 19929.106,
    "ContactId": 52,
    "AssociateId": 850,
    "PersonId": 319,
    "SaleTypeId": 218,
    "SaleTypeName": "Macejkovic Inc and Sons",
    "PersonFullName": "Camryn Ryan",
    "Completed": "Completed",
    "ActiveErpLinks": 772,
    "NextDueDate": "1996-12-12T09:40:58.6993703+01:00",
    "Number": "1510156",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 266
      }
    }
  },
  "Ticket": {
    "TicketId": 76,
    "Title": "recusandae",
    "CreatedAt": "2000-09-06T09:40:58.6993703+02:00",
    "LastChanged": "1993-12-31T09:40:58.6993703+01:00",
    "ReadByOwner": "2003-09-09T09:40:58.6993703+02:00",
    "ReadByCustomer": "2010-01-30T09:40:58.6993703+01:00",
    "FirstReadByUser": "2000-12-17T09:40:58.7003425+01:00",
    "Activate": "2004-02-21T09:40:58.7003425+01:00",
    "ClosedAt": "2001-05-07T09:40:58.7003425+02:00",
    "RepliedAt": "2017-10-24T09:40:58.7003425+02:00",
    "AlertTimeout": "1998-04-11T09:40:58.7003425+02:00",
    "Deadline": "2014-03-06T09:40:58.7003425+01:00",
    "CreatedBy": 242,
    "CreatedByName": "Ruecker Inc and Sons",
    "Author": "molestias",
    "OwnedBy": 608,
    "OwnedByName": "Nikolaus Inc and Sons",
    "Category": 914,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 846,
    "BaseStatus": "Active",
    "TicketStatus": 708,
    "Origin": "AutoGenerated",
    "CustId": 918,
    "CustFirstname": "Frederique",
    "CustMiddleName": "Hamill, Daugherty and Streich",
    "CustLastname": "Wiza",
    "AlertLevel": 120,
    "ConnectId": 99,
    "ReadStatus": "Green",
    "TimeToReply": 577,
    "RealTimeToReply": 772,
    "TimeToClose": 824,
    "RealTimeToClose": 657,
    "TimeSpentInternally": 679,
    "TimeSpentExternally": 28,
    "TimeSpentQueue": 939,
    "RealTimeSpentInternally": 634,
    "RealTimeSpentExternally": 531,
    "RealTimeSpentQueue": 643,
    "HasAttachment": true,
    "NumReplies": 557,
    "NumMessages": 374,
    "FromAddress": "aut",
    "CustFullname": "iusto",
    "TicketStatusDisplayValue": "sit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "aggregate cross-media content"
        },
        "FieldType": "System.String",
        "FieldLength": 361
      }
    }
  },
  "TransferTo": {
    "AssociateId": 144,
    "Name": "Block-Hintz",
    "PersonId": 273,
    "Rank": 646,
    "Tooltip": "cumque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 838,
    "FullName": "Winfield Labadie",
    "FormalName": "Johnson, Effertz and Vandervort",
    "Deleted": true,
    "EjUserId": 170,
    "UserName": "Ziemann-Predovic",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 497
      }
    }
  },
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
      "FieldLength": 375
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```