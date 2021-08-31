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
  "ChatSessionId": 928,
  "TopicId": 602,
  "User": {
    "AssociateId": 387,
    "Name": "Rodriguez-Dibbert",
    "PersonId": 251,
    "Rank": 356,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 133,
    "FullName": "Godfrey Harber",
    "FormalName": "Moore-Rutherford",
    "Deleted": false,
    "EjUserId": 450,
    "UserName": "Gottlieb Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "whiteboard global e-tailers"
        },
        "FieldType": "System.String",
        "FieldLength": 333
      }
    }
  },
  "Person": {
    "Position": "laboriosam",
    "PersonId": 859,
    "Mrmrs": "quae",
    "Firstname": "Rollin",
    "Lastname": "Hilpert",
    "MiddleName": "Hessel, Gusikowski and Moore",
    "Title": "nihil",
    "Description": "Multi-channelled 24 hour utilisation",
    "Email": "nathaniel.toy@green.name",
    "FullName": "Lyda Lockman",
    "DirectPhone": "208-855-7022",
    "FormalName": "Kuhic-Connelly",
    "CountryId": 795,
    "ContactId": 413,
    "ContactName": "Smith Group",
    "Retired": 575,
    "Rank": 597,
    "ActiveInterests": 379,
    "ContactDepartment": "enable sexy e-business",
    "ContactCountryId": 809,
    "ContactOrgNr": "405039",
    "FaxPhone": "(773)235-2366 x05862",
    "MobilePhone": "862.711.7085",
    "ContactPhone": "1-830-736-1338",
    "AssociateName": "Rutherford Inc and Sons",
    "AssociateId": 116,
    "UsePersonAddress": false,
    "ContactFax": "beatae",
    "Kanafname": "earum",
    "Kanalname": "esse",
    "Post1": "quia",
    "Post2": "inventore",
    "Post3": "ut",
    "EmailName": "nadia_hand@rippinkertzmann.us",
    "ContactFullName": "Libbie Shanahan",
    "ActiveErpLinks": 740,
    "TicketPriorityId": 962,
    "SupportLanguageId": 837,
    "SupportAssociateId": 310,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 978
      }
    }
  },
  "CustomerAlias": "voluptas",
  "CustomerHost": "aut",
  "CustomerName": "Mayer, Altenwerth and Fahey",
  "CustomerEmail": "annette.block@green.biz",
  "CustomerPhone": "570-768-4268 x508",
  "CustomerConsented": false,
  "CustomerCompanyName": "Bode Inc and Sons",
  "Status": "Closed",
  "FirstMessage": "assumenda",
  "LastMessage": "placeat",
  "WhenRequested": "2012-08-26T15:05:41.6350025+02:00",
  "WhenStarted": "2007-09-07T15:05:41.6350025+02:00",
  "WhenEnded": "2001-10-26T15:05:41.6350025+02:00",
  "WhenIdle": "2013-06-16T15:05:41.6350025+02:00",
  "WhenFetched": "2002-11-11T15:05:41.6350025+01:00",
  "SessionKey": "aperiam",
  "InitialQueuePos": 450,
  "AlertLevel": 504,
  "Rank": 394,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 416,
    "Name": "Streich, Weimann and Ferry",
    "OrgNr": "412819",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "illum",
    "DirectPhone": "550-576-2807",
    "AssociateId": 267,
    "CountryId": 880,
    "EmailAddress": "judson.kihn@altenwerth.us",
    "Kananame": "quia",
    "EmailAddressName": "krystel@hodkiewicz.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Evie Nikolaus",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "corporis",
    "FullName": "Birdie Farrell",
    "IsOwnerContact": true,
    "ActiveErpLinks": 707,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 340
      }
    }
  },
  "Project": {
    "ProjectId": 772,
    "Name": "Weissnat LLC",
    "Description": "Inverse client-server local area network",
    "URL": "http://www.example.com/",
    "Type": "esse",
    "AssociateId": 322,
    "AssociateFullName": "Karolann Kub",
    "TypeId": 155,
    "Updated": "2008-05-11T15:05:41.6360025+02:00",
    "StatusId": 760,
    "Status": "sunt",
    "TextId": 487,
    "PublishTo": "2006-12-27T15:05:41.6360025+01:00",
    "PublishFrom": "2020-01-14T15:05:41.6360025+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1576027",
    "ActiveErpLinks": 228,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 151
      }
    }
  },
  "Sale": {
    "ContactName": "Tromp Inc and Sons",
    "SaleDate": "1995-03-22T15:05:41.6360025+01:00",
    "SaleId": 838,
    "Probability": 684,
    "Title": "voluptates",
    "Amount": 1313.146,
    "Currency": "animi",
    "ProjectName": "Senger, Waters and Hamill",
    "AssociateFullName": "Nikita Hettinger",
    "Description": "Versatile optimizing firmware",
    "Status": "Lost",
    "WeightedAmount": 23498.732,
    "ProjectId": 697,
    "EarningPercent": 30656.788,
    "Earning": 8734.458,
    "ContactId": 231,
    "AssociateId": 524,
    "PersonId": 994,
    "SaleTypeId": 111,
    "SaleTypeName": "Flatley, Herman and Aufderhar",
    "PersonFullName": "Ms. Gay McClure",
    "Completed": "Completed",
    "ActiveErpLinks": 473,
    "NextDueDate": "2020-04-14T15:05:41.6370024+02:00",
    "Number": "1261514",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 237
      }
    }
  },
  "Ticket": {
    "TicketId": 612,
    "Title": "non",
    "CreatedAt": "2008-10-14T15:05:41.6370024+02:00",
    "LastChanged": "2013-03-10T15:05:41.6370024+01:00",
    "ReadByOwner": "1994-12-29T15:05:41.6370024+01:00",
    "ReadByCustomer": "2008-09-18T15:05:41.6370024+02:00",
    "FirstReadByUser": "1998-11-24T15:05:41.6370024+01:00",
    "Activate": "2020-03-24T15:05:41.6370024+01:00",
    "ClosedAt": "2017-08-03T15:05:41.6370024+02:00",
    "RepliedAt": "2009-10-05T15:05:41.6370024+02:00",
    "AlertTimeout": "1994-08-16T15:05:41.6370024+02:00",
    "Deadline": "2006-05-26T15:05:41.6370024+02:00",
    "CreatedBy": 454,
    "CreatedByName": "Von, Waters and Wyman",
    "Author": "non",
    "OwnedBy": 805,
    "OwnedByName": "Treutel, Baumbach and Dare",
    "Category": 717,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 695,
    "PriorityName": "Smitham-Turner",
    "BaseStatus": "Active",
    "TicketStatus": 324,
    "TicketStatusDisplayValue": "dolorum",
    "Origin": "AutoGenerated",
    "CustId": 466,
    "PersonFirstname": "Lucas",
    "PersonMiddleName": "Gleichner-Thompson",
    "PersonLastname": "Dickens",
    "PersonFullname": "enim",
    "AlertLevel": 944,
    "ConnectId": 594,
    "ReadStatus": "Green",
    "TimeToReply": 21,
    "RealTimeToReply": 139,
    "TimeToClose": 933,
    "RealTimeToClose": 482,
    "TimeSpentInternally": 864,
    "TimeSpentExternally": 529,
    "TimeSpentQueue": 130,
    "RealTimeSpentInternally": 434,
    "RealTimeSpentExternally": 792,
    "RealTimeSpentQueue": 410,
    "HasAttachment": true,
    "NumReplies": 296,
    "NumMessages": 596,
    "FromAddress": "dolor",
    "ContactId": 364,
    "ContactName": "Frami LLC",
    "OwnedByAssociateId": 666,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 454
      }
    }
  },
  "TransferTo": {
    "AssociateId": 294,
    "Name": "Bogisich-Nolan",
    "PersonId": 616,
    "Rank": 764,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 625,
    "FullName": "Kayley Lesch",
    "FormalName": "Bauch-Goyette",
    "Deleted": true,
    "EjUserId": 613,
    "UserName": "Schoen, Wuckert and Heathcote",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 828
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
      "FieldType": "System.Int32",
      "FieldLength": 441
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```