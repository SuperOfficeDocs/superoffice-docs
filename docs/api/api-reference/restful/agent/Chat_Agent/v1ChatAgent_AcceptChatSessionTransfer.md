---
title: POST Agents/Chat/AcceptChatSessionTransfer
id: v1ChatAgent_AcceptChatSessionTransfer
---

# POST Agents/Chat/AcceptChatSessionTransfer

```http
POST /api/v1/Agents/Chat/AcceptChatSessionTransfer
```

Accept the transfer: assign the session to the user.

If the session is not being transferred, nothing happens.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/AcceptChatSessionTransfer?$select=name,department,category/id
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
| ChatbotIsActive | bool | Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Chat/AcceptChatSessionTransfer
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 861
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 615,
  "TopicId": 835,
  "User": {
    "AssociateId": 380,
    "Name": "Kshlerin, Zemlak and Howe",
    "PersonId": 71,
    "Rank": 530,
    "Tooltip": "recusandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 860,
    "FullName": "Jeanie Howell",
    "FormalName": "McDermott LLC",
    "Deleted": true,
    "EjUserId": 583,
    "UserName": "Roob Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "envisioneer granular interfaces"
        },
        "FieldType": "System.String",
        "FieldLength": 52
      }
    }
  },
  "Person": {
    "Position": "consequatur",
    "PersonId": 565,
    "Mrmrs": "nesciunt",
    "Firstname": "Elise",
    "Lastname": "Stokes",
    "MiddleName": "O'Keefe-Reichel",
    "Title": "earum",
    "Description": "Synergized encompassing methodology",
    "Email": "everette@haag.us",
    "FullName": "Elnora Jewess",
    "DirectPhone": "040.360.4542",
    "FormalName": "Greenholt LLC",
    "CountryId": 328,
    "ContactId": 91,
    "ContactName": "Bashirian Group",
    "Retired": 715,
    "Rank": 181,
    "ActiveInterests": 301,
    "ContactDepartment": "",
    "ContactCountryId": 554,
    "ContactOrgNr": "172810",
    "FaxPhone": "222.704.1407 x61858",
    "MobilePhone": "203.686.1426",
    "ContactPhone": "201.802.6722 x625",
    "AssociateName": "Swift Inc and Sons",
    "AssociateId": 278,
    "UsePersonAddress": true,
    "ContactFax": "doloribus",
    "Kanafname": "enim",
    "Kanalname": "natus",
    "Post1": "fuga",
    "Post2": "eaque",
    "Post3": "ab",
    "EmailName": "karley.upton@kohler.biz",
    "ContactFullName": "Devonte Schneider",
    "ActiveErpLinks": 686,
    "TicketPriorityId": 73,
    "SupportLanguageId": 560,
    "SupportAssociateId": 875,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 502
      }
    }
  },
  "CustomerAlias": "voluptatem",
  "CustomerHost": "porro",
  "CustomerName": "Wintheiser-Cremin",
  "CustomerEmail": "jayce.swift@hayes.com",
  "CustomerPhone": "1-623-336-8625 x70577",
  "CustomerConsented": false,
  "CustomerCompanyName": "Brekke, Rohan and Cummerata",
  "Status": "Closed",
  "FirstMessage": "rerum",
  "LastMessage": "voluptatem",
  "WhenRequested": "2011-01-20T18:28:48.284282+01:00",
  "WhenStarted": "2012-10-24T18:28:48.284282+02:00",
  "WhenEnded": "2020-08-11T18:28:48.284282+02:00",
  "WhenIdle": "2005-10-12T18:28:48.284282+02:00",
  "WhenFetched": "2009-03-08T18:28:48.284282+01:00",
  "SessionKey": "sed",
  "InitialQueuePos": 338,
  "AlertLevel": 961,
  "Rank": 30,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 648,
    "Name": "Lind Inc and Sons",
    "OrgNr": "1434166",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "corporis",
    "DirectPhone": "850-630-7023 x2000",
    "AssociateId": 396,
    "CountryId": 888,
    "EmailAddress": "presley@hahn.ca",
    "Kananame": "voluptatum",
    "EmailAddressName": "rosemary@kirlinraynor.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Kennedi Altenwerth V",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "assumenda",
    "FullName": "Stephon Cartwright",
    "IsOwnerContact": true,
    "ActiveErpLinks": 751,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 49
      }
    }
  },
  "Project": {
    "ProjectId": 555,
    "Name": "Lesch Group",
    "Description": "Organic static hub",
    "URL": "http://www.example.com/",
    "Type": "asperiores",
    "AssociateId": 963,
    "AssociateFullName": "Nelson McDermott",
    "TypeId": 349,
    "Updated": "2008-05-08T18:28:48.2852833+02:00",
    "StatusId": 500,
    "Status": "suscipit",
    "TextId": 716,
    "PublishTo": "2015-03-20T18:28:48.2852833+01:00",
    "PublishFrom": "2002-01-30T18:28:48.2852833+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "959010",
    "ActiveErpLinks": 627,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 632
      }
    }
  },
  "Sale": {
    "ContactName": "Hoppe-Wyman",
    "SaleDate": "2017-09-04T18:28:48.2852833+02:00",
    "SaleId": 431,
    "Probability": 787,
    "Title": "doloremque",
    "Amount": 17287.144,
    "Currency": "possimus",
    "ProjectName": "Gerlach, Auer and Pacocha",
    "AssociateFullName": "Aileen Jacobs V",
    "Description": "Pre-emptive value-added Graphical User Interface",
    "Status": "Lost",
    "WeightedAmount": 28986.365999999998,
    "ProjectId": 416,
    "EarningPercent": 10138.49,
    "Earning": 14776.81,
    "ContactId": 609,
    "AssociateId": 33,
    "PersonId": 278,
    "SaleTypeId": 662,
    "SaleTypeName": "Sanford-Pacocha",
    "PersonFullName": "Kip Green",
    "Completed": "Completed",
    "ActiveErpLinks": 157,
    "NextDueDate": "2006-07-10T18:28:48.2862811+02:00",
    "Number": "1176658",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 577
      }
    }
  },
  "Ticket": {
    "TicketId": 465,
    "Title": "dolor",
    "CreatedAt": "2014-03-27T18:28:48.2862811+01:00",
    "LastChanged": "2005-04-22T18:28:48.2862811+02:00",
    "ReadByOwner": "2008-03-28T18:28:48.2862811+01:00",
    "ReadByCustomer": "2003-03-06T18:28:48.2862811+01:00",
    "FirstReadByUser": "2020-06-21T18:28:48.2862811+02:00",
    "Activate": "2003-02-22T18:28:48.2862811+01:00",
    "ClosedAt": "2017-12-01T18:28:48.2862811+01:00",
    "RepliedAt": "2009-10-28T18:28:48.2862811+01:00",
    "AlertTimeout": "2020-04-19T18:28:48.2862811+02:00",
    "Deadline": "2001-08-21T18:28:48.2862811+02:00",
    "CreatedBy": 107,
    "CreatedByName": "Daugherty Group",
    "Author": "et",
    "OwnedBy": 151,
    "OwnedByName": "McDermott, McGlynn and Boyle",
    "Category": 937,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 247,
    "PriorityName": "VonRueden, Krajcik and Nicolas",
    "BaseStatus": "Active",
    "TicketStatus": 970,
    "TicketStatusDisplayValue": "eos",
    "Origin": "AutoGenerated",
    "CustId": 829,
    "PersonFirstname": "Nettie",
    "PersonMiddleName": "Crooks, Walsh and Reilly",
    "PersonLastname": "Yundt",
    "PersonFullname": "dolores",
    "AlertLevel": 233,
    "ConnectId": 857,
    "ReadStatus": "Green",
    "TimeToReply": 249,
    "RealTimeToReply": 532,
    "TimeToClose": 470,
    "RealTimeToClose": 508,
    "TimeSpentInternally": 680,
    "TimeSpentExternally": 809,
    "TimeSpentQueue": 685,
    "RealTimeSpentInternally": 879,
    "RealTimeSpentExternally": 478,
    "RealTimeSpentQueue": 684,
    "HasAttachment": true,
    "NumReplies": 184,
    "NumMessages": 254,
    "FromAddress": "dolores",
    "ContactId": 209,
    "ContactName": "Pacocha-Borer",
    "OwnedByAssociateId": 902,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 250
      }
    }
  },
  "TransferTo": {
    "AssociateId": 606,
    "Name": "Fadel-Cummerata",
    "PersonId": 598,
    "Rank": 305,
    "Tooltip": "nihil",
    "Type": "AnonymousAssociate",
    "GroupIdx": 198,
    "FullName": "Gilberto Altenwerth",
    "FormalName": "Bogisich Inc and Sons",
    "Deleted": true,
    "EjUserId": 985,
    "UserName": "Considine, Jakubowski and Kuhic",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 783
      }
    }
  },
  "ChatbotIsActive": false,
  "TableRight": {
    "Mask": "Delete",
    "Reason": "productize wireless e-services"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 342
    }
  }
}
```