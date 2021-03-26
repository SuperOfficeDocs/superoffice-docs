---
title: POST Agents/Chat/RejectChatSessionTransfer
id: v1ChatAgent_RejectChatSessionTransfer
---

# POST Agents/Chat/RejectChatSessionTransfer

```http
POST /api/v1/Agents/Chat/RejectChatSessionTransfer
```

Do not want.

Deny the transfer to the user. If the session is not being transferred, nothing happens.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/RejectChatSessionTransfer?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

ChatSessionId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatSessionId | int32 |  |


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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Chat/RejectChatSessionTransfer
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 545
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 88,
  "TopicId": 506,
  "User": {
    "AssociateId": 224,
    "Name": "Stroman, Bailey and Nikolaus",
    "PersonId": 39,
    "Rank": 746,
    "Tooltip": "beatae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 649,
    "FullName": "Ewell Bartell",
    "FormalName": "Kreiger-Witting",
    "Deleted": false,
    "EjUserId": 68,
    "UserName": "Morissette-Lynch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 397
      }
    }
  },
  "Person": {
    "Position": "consectetur",
    "PersonId": 851,
    "Mrmrs": "ratione",
    "Firstname": "Alexander",
    "Lastname": "Jaskolski",
    "MiddleName": "Maggio-Walter",
    "Title": "nihil",
    "Description": "Diverse empowering moderator",
    "Email": "rosalyn_boehm@parisian.ca",
    "FullName": "Jakayla Johns",
    "DirectPhone": "475-200-2040",
    "FormalName": "Monahan-Morissette",
    "CountryId": 20,
    "ContactId": 4,
    "ContactName": "Macejkovic-Medhurst",
    "Retired": 549,
    "Rank": 488,
    "ActiveInterests": 732,
    "ContactDepartment": "",
    "ContactCountryId": 934,
    "ContactOrgNr": "1428012",
    "FaxPhone": "760.540.6774 x8573",
    "MobilePhone": "205.234.1648 x78845",
    "ContactPhone": "852.240.8547 x71458",
    "AssociateName": "Crooks, Leannon and Johnson",
    "AssociateId": 823,
    "UsePersonAddress": true,
    "ContactFax": "quis",
    "Kanafname": "et",
    "Kanalname": "dolores",
    "Post1": "rerum",
    "Post2": "autem",
    "Post3": "veniam",
    "EmailName": "vance_mclaughlin@keeling.com",
    "ContactFullName": "Orie Klocko",
    "ActiveErpLinks": 634,
    "TicketPriorityId": 42,
    "SupportLanguageId": 132,
    "SupportAssociateId": 960,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 413
      }
    }
  },
  "CustomerAlias": "dolor",
  "CustomerHost": "sint",
  "CustomerName": "Wolff LLC",
  "CustomerEmail": "johnathon@zieme.co.uk",
  "CustomerPhone": "705.810.0153 x585",
  "CustomerConsented": false,
  "CustomerCompanyName": "Lesch, Nitzsche and Maggio",
  "Status": "Closed",
  "FirstMessage": "ipsum",
  "LastMessage": "debitis",
  "WhenRequested": "2009-04-28T16:48:28.9309244+02:00",
  "WhenStarted": "2001-02-17T16:48:28.9309244+01:00",
  "WhenEnded": "2004-05-27T16:48:28.9309244+02:00",
  "WhenIdle": "2006-07-13T16:48:28.9309244+02:00",
  "WhenFetched": "1995-06-25T16:48:28.9309244+02:00",
  "SessionKey": "itaque",
  "InitialQueuePos": 972,
  "AlertLevel": 414,
  "Rank": 369,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 195,
    "Name": "Heathcote Inc and Sons",
    "OrgNr": "1675844",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ratione",
    "DirectPhone": "(732)058-5386",
    "AssociateId": 401,
    "CountryId": 346,
    "EmailAddress": "chaya@ledner.com",
    "Kananame": "cumque",
    "EmailAddressName": "deangelo@mertzhuel.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Leon Murphy MD",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "amet",
    "FullName": "Liliana Marquardt",
    "IsOwnerContact": true,
    "ActiveErpLinks": 299,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 332
      }
    }
  },
  "Project": {
    "ProjectId": 540,
    "Name": "Okuneva-Ondricka",
    "Description": "Switchable uniform challenge",
    "URL": "http://www.example.com/",
    "Type": "voluptate",
    "AssociateId": 268,
    "AssociateFullName": "Madisyn Kihn PhD",
    "TypeId": 622,
    "Updated": "1999-08-23T16:48:28.9319243+02:00",
    "StatusId": 723,
    "Status": "voluptas",
    "TextId": 783,
    "PublishTo": "1993-12-12T16:48:28.9319243+01:00",
    "PublishFrom": "1999-04-10T16:48:28.9319243+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "860926",
    "ActiveErpLinks": 992,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 231
      }
    }
  },
  "Sale": {
    "ContactName": "Schimmel, Kuvalis and Hills",
    "SaleDate": "1997-10-12T16:48:28.9319243+02:00",
    "SaleId": 808,
    "Probability": 887,
    "Title": "perspiciatis",
    "Amount": 28481.791999999998,
    "Currency": "dolorem",
    "ProjectName": "Hodkiewicz Group",
    "AssociateFullName": "Sydni Roob",
    "Description": "User-friendly mission-critical local area network",
    "Status": "Lost",
    "WeightedAmount": 18515.672,
    "ProjectId": 39,
    "EarningPercent": 10464.426,
    "Earning": 23066.239999999998,
    "ContactId": 105,
    "AssociateId": 12,
    "PersonId": 453,
    "SaleTypeId": 860,
    "SaleTypeName": "Lynch-Weber",
    "PersonFullName": "Elliott Homenick Sr.",
    "Completed": "Completed",
    "ActiveErpLinks": 8,
    "NextDueDate": "1998-12-09T16:48:28.9329243+01:00",
    "Number": "1692558",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 173
      }
    }
  },
  "Ticket": {
    "TicketId": 581,
    "Title": "voluptas",
    "CreatedAt": "2002-08-07T16:48:28.9329243+02:00",
    "LastChanged": "2018-12-25T16:48:28.9329243+01:00",
    "ReadByOwner": "1999-07-23T16:48:28.9329243+02:00",
    "ReadByCustomer": "2003-04-15T16:48:28.9329243+02:00",
    "FirstReadByUser": "2014-09-28T16:48:28.9329243+02:00",
    "Activate": "2003-04-29T16:48:28.9329243+02:00",
    "ClosedAt": "2019-01-01T16:48:28.9329243+01:00",
    "RepliedAt": "2015-09-09T16:48:28.9329243+02:00",
    "AlertTimeout": "2008-06-10T16:48:28.9329243+02:00",
    "Deadline": "2020-04-02T16:48:28.9329243+02:00",
    "CreatedBy": 122,
    "CreatedByName": "Swift, Kreiger and Pfannerstill",
    "Author": "totam",
    "OwnedBy": 891,
    "OwnedByName": "Blanda LLC",
    "Category": 380,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 752,
    "BaseStatus": "Active",
    "TicketStatus": 711,
    "Origin": "AutoGenerated",
    "CustId": 796,
    "CustFirstname": "Myles",
    "CustMiddleName": "Crooks Inc and Sons",
    "CustLastname": "Corwin",
    "AlertLevel": 246,
    "ConnectId": 773,
    "ReadStatus": "Green",
    "TimeToReply": 576,
    "RealTimeToReply": 905,
    "TimeToClose": 699,
    "RealTimeToClose": 525,
    "TimeSpentInternally": 224,
    "TimeSpentExternally": 182,
    "TimeSpentQueue": 687,
    "RealTimeSpentInternally": 43,
    "RealTimeSpentExternally": 888,
    "RealTimeSpentQueue": 113,
    "HasAttachment": true,
    "NumReplies": 310,
    "NumMessages": 402,
    "FromAddress": "quis",
    "CustFullname": "provident",
    "TicketStatusDisplayValue": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 520
      }
    }
  },
  "TransferTo": {
    "AssociateId": 530,
    "Name": "Grant, Koepp and Denesik",
    "PersonId": 875,
    "Rank": 965,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 911,
    "FullName": "Kelton Dicki",
    "FormalName": "Stark-Hammes",
    "Deleted": false,
    "EjUserId": 792,
    "UserName": "Balistreri, Parisian and Krajcik",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 881
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
      "FieldType": "System.String",
      "FieldLength": 534
    }
  }
}
```