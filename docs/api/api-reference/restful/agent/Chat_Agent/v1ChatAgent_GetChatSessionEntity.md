---
title: POST Agents/Chat/GetChatSessionEntity
id: v1ChatAgent_GetChatSessionEntity
---

# POST Agents/Chat/GetChatSessionEntity

```http
POST /api/v1/Agents/Chat/GetChatSessionEntity
```

Gets a ChatSessionEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| chatSessionEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/GetChatSessionEntity?chatSessionEntityId=873
POST /api/v1/Agents/Chat/GetChatSessionEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Chat/GetChatSessionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 802,
  "TopicId": 790,
  "User": {
    "AssociateId": 90,
    "Name": "Murazik-Funk",
    "PersonId": 817,
    "Rank": 907,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 719,
    "FullName": "Hal White",
    "FormalName": "Connelly, Turcotte and Bartoletti",
    "Deleted": true,
    "EjUserId": 381,
    "UserName": "Goyette, Bahringer and Collins",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 661
      }
    }
  },
  "Person": {
    "Position": "blanditiis",
    "PersonId": 475,
    "Mrmrs": "ullam",
    "Firstname": "Erick",
    "Lastname": "Rempel",
    "MiddleName": "Hilpert-Pouros",
    "Title": "et",
    "Description": "Operative client-driven installation",
    "Email": "jonathan.harris@schambergerbreitenberg.ca",
    "FullName": "Maya Moore",
    "DirectPhone": "(403)076-2118 x45012",
    "FormalName": "Durgan, Bernier and Nolan",
    "CountryId": 850,
    "ContactId": 769,
    "ContactName": "Labadie, Mueller and Lang",
    "Retired": 132,
    "Rank": 481,
    "ActiveInterests": 871,
    "ContactDepartment": "",
    "ContactCountryId": 926,
    "ContactOrgNr": "1319861",
    "FaxPhone": "(424)861-8202 x5842",
    "MobilePhone": "432-406-0656 x451",
    "ContactPhone": "020.075.8774",
    "AssociateName": "Reichert, Maggio and Reichel",
    "AssociateId": 472,
    "UsePersonAddress": false,
    "ContactFax": "repellat",
    "Kanafname": "illo",
    "Kanalname": "nobis",
    "Post1": "corporis",
    "Post2": "molestiae",
    "Post3": "dolores",
    "EmailName": "cloyd.lakin@upton.ca",
    "ContactFullName": "Liza Nader",
    "ActiveErpLinks": 431,
    "TicketPriorityId": 656,
    "SupportLanguageId": 543,
    "SupportAssociateId": 782,
    "CategoryName": "VIP Customer",
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
  "CustomerAlias": "distinctio",
  "CustomerHost": "sint",
  "CustomerName": "Crona, Wiza and Johnson",
  "CustomerEmail": "ned_willms@kunze.ca",
  "CustomerPhone": "305.733.7325",
  "CustomerConsented": false,
  "CustomerCompanyName": "Senger LLC",
  "Status": "Closed",
  "FirstMessage": "aut",
  "LastMessage": "exercitationem",
  "WhenRequested": "2019-08-14T18:28:48.2522838+02:00",
  "WhenStarted": "2004-06-30T18:28:48.2522838+02:00",
  "WhenEnded": "2001-11-14T18:28:48.2522838+01:00",
  "WhenIdle": "2006-10-07T18:28:48.2522838+02:00",
  "WhenFetched": "1996-04-28T18:28:48.2522838+02:00",
  "SessionKey": "commodi",
  "InitialQueuePos": 812,
  "AlertLevel": 207,
  "Rank": 667,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 931,
    "Name": "Welch, Hudson and Gaylord",
    "OrgNr": "868438",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "voluptatem",
    "DirectPhone": "1-144-227-0522",
    "AssociateId": 264,
    "CountryId": 567,
    "EmailAddress": "nichole_klocko@gerlach.ca",
    "Kananame": "pariatur",
    "EmailAddressName": "veda.keebler@rohandavis.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Waylon Rodriguez",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "sed",
    "FullName": "Miss Declan Langosh",
    "IsOwnerContact": false,
    "ActiveErpLinks": 606,
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
  "Project": {
    "ProjectId": 433,
    "Name": "Mertz-Streich",
    "Description": "Stand-alone empowering portal",
    "URL": "http://www.example.com/",
    "Type": "voluptas",
    "AssociateId": 442,
    "AssociateFullName": "Robert Glover",
    "TypeId": 79,
    "Updated": "2010-07-08T18:28:48.2532863+02:00",
    "StatusId": 689,
    "Status": "illo",
    "TextId": 809,
    "PublishTo": "1998-09-16T18:28:48.2542958+02:00",
    "PublishFrom": "2005-09-15T18:28:48.2542958+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "721867",
    "ActiveErpLinks": 438,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 812
      }
    }
  },
  "Sale": {
    "ContactName": "Goodwin, Parker and Barrows",
    "SaleDate": "2002-02-13T18:28:48.2542958+01:00",
    "SaleId": 769,
    "Probability": 796,
    "Title": "rerum",
    "Amount": 11210.318,
    "Currency": "libero",
    "ProjectName": "Wyman Inc and Sons",
    "AssociateFullName": "Cierra Kerluke",
    "Description": "De-engineered asynchronous algorithm",
    "Status": "Lost",
    "WeightedAmount": 11689.82,
    "ProjectId": 363,
    "EarningPercent": 25698.8,
    "Earning": 20032.528,
    "ContactId": 667,
    "AssociateId": 375,
    "PersonId": 139,
    "SaleTypeId": 430,
    "SaleTypeName": "Hackett, Denesik and Wolff",
    "PersonFullName": "Casimer Zieme",
    "Completed": "Completed",
    "ActiveErpLinks": 551,
    "NextDueDate": "2013-06-01T18:28:48.2542958+02:00",
    "Number": "1503030",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 178
      }
    }
  },
  "Ticket": {
    "TicketId": 408,
    "Title": "numquam",
    "CreatedAt": "1996-04-26T18:28:48.2552919+02:00",
    "LastChanged": "2015-01-28T18:28:48.2552919+01:00",
    "ReadByOwner": "2006-02-22T18:28:48.2552919+01:00",
    "ReadByCustomer": "1998-07-20T18:28:48.2552919+02:00",
    "FirstReadByUser": "2009-03-18T18:28:48.2552919+01:00",
    "Activate": "2000-08-09T18:28:48.2552919+02:00",
    "ClosedAt": "2015-12-20T18:28:48.2552919+01:00",
    "RepliedAt": "1997-03-03T18:28:48.2552919+01:00",
    "AlertTimeout": "2013-02-20T18:28:48.2552919+01:00",
    "Deadline": "2016-03-02T18:28:48.2552919+01:00",
    "CreatedBy": 85,
    "CreatedByName": "Johnson Group",
    "Author": "unde",
    "OwnedBy": 786,
    "OwnedByName": "DuBuque-Dickens",
    "Category": 886,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 384,
    "PriorityName": "Steuber, Krajcik and Corwin",
    "BaseStatus": "Active",
    "TicketStatus": 677,
    "TicketStatusDisplayValue": "facilis",
    "Origin": "AutoGenerated",
    "CustId": 884,
    "PersonFirstname": "Carmella",
    "PersonMiddleName": "Daugherty Inc and Sons",
    "PersonLastname": "Klein",
    "PersonFullname": "sed",
    "AlertLevel": 580,
    "ConnectId": 263,
    "ReadStatus": "Green",
    "TimeToReply": 597,
    "RealTimeToReply": 468,
    "TimeToClose": 209,
    "RealTimeToClose": 201,
    "TimeSpentInternally": 215,
    "TimeSpentExternally": 514,
    "TimeSpentQueue": 153,
    "RealTimeSpentInternally": 930,
    "RealTimeSpentExternally": 692,
    "RealTimeSpentQueue": 202,
    "HasAttachment": false,
    "NumReplies": 332,
    "NumMessages": 409,
    "FromAddress": "est",
    "ContactId": 999,
    "ContactName": "Murazik, Keeling and Farrell",
    "OwnedByAssociateId": 673,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 264
      }
    }
  },
  "TransferTo": {
    "AssociateId": 466,
    "Name": "Hagenes Inc and Sons",
    "PersonId": 768,
    "Rank": 6,
    "Tooltip": "fuga",
    "Type": "AnonymousAssociate",
    "GroupIdx": 789,
    "FullName": "Lyda Gorczany",
    "FormalName": "Glover, Lebsack and Raynor",
    "Deleted": false,
    "EjUserId": 33,
    "UserName": "Shields Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 736
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
      "FieldLength": 989
    }
  }
}
```