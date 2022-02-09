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
| ChatbotIsActive | bool | Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Chat/RejectChatSessionTransfer
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 585
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 225,
  "TopicId": 665,
  "User": {
    "AssociateId": 565,
    "Name": "Schmidt, Torphy and Keeling",
    "PersonId": 498,
    "Rank": 410,
    "Tooltip": "repudiandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 356,
    "FullName": "Chadd Muller",
    "FormalName": "O'Conner LLC",
    "Deleted": true,
    "EjUserId": 438,
    "UserName": "Nader, Purdy and Jacobson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 894
      }
    }
  },
  "Person": {
    "Position": "eum",
    "PersonId": 115,
    "Mrmrs": "ab",
    "Firstname": "Else",
    "Lastname": "Stroman",
    "MiddleName": "Connelly, Rempel and Denesik",
    "Title": "numquam",
    "Description": "Stand-alone web-enabled website",
    "Email": "braeden@lednerjohns.biz",
    "FullName": "Sincere Watsica",
    "DirectPhone": "(307)211-6581",
    "FormalName": "Jaskolski, Haag and Grady",
    "CountryId": 307,
    "ContactId": 855,
    "ContactName": "Waelchi, Franecki and Klein",
    "Retired": 223,
    "Rank": 56,
    "ActiveInterests": 677,
    "ContactDepartment": "",
    "ContactCountryId": 392,
    "ContactOrgNr": "714150",
    "FaxPhone": "460-187-8787",
    "MobilePhone": "025.771.5721 x568",
    "ContactPhone": "402-318-5841 x2154",
    "AssociateName": "Haley-Kohler",
    "AssociateId": 940,
    "UsePersonAddress": true,
    "ContactFax": "non",
    "Kanafname": "est",
    "Kanalname": "eos",
    "Post1": "repellendus",
    "Post2": "voluptates",
    "Post3": "voluptates",
    "EmailName": "bella_jenkins@parisian.name",
    "ContactFullName": "Antwan Spencer",
    "ActiveErpLinks": 483,
    "TicketPriorityId": 645,
    "SupportLanguageId": 678,
    "SupportAssociateId": 610,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 756
      }
    }
  },
  "CustomerAlias": "distinctio",
  "CustomerHost": "et",
  "CustomerName": "Jones-Brown",
  "CustomerEmail": "lempi@treutel.uk",
  "CustomerPhone": "200-065-8113",
  "CustomerConsented": true,
  "CustomerCompanyName": "Champlin LLC",
  "Status": "Closed",
  "FirstMessage": "optio",
  "LastMessage": "hic",
  "WhenRequested": "2015-03-30T18:28:48.2942869+02:00",
  "WhenStarted": "2014-02-24T18:28:48.2942869+01:00",
  "WhenEnded": "2014-06-04T18:28:48.2942869+02:00",
  "WhenIdle": "2007-02-07T18:28:48.2942869+01:00",
  "WhenFetched": "2017-12-22T18:28:48.2942869+01:00",
  "SessionKey": "sit",
  "InitialQueuePos": 571,
  "AlertLevel": 993,
  "Rank": 172,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 78,
    "Name": "Hickle Inc and Sons",
    "OrgNr": "985500",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "unde",
    "DirectPhone": "1-644-120-2526",
    "AssociateId": 410,
    "CountryId": 492,
    "EmailAddress": "dario@barrows.co.uk",
    "Kananame": "et",
    "EmailAddressName": "zachariah.grady@watsica.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Emilio Quitzon",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "et",
    "FullName": "Rebekah Roob",
    "IsOwnerContact": true,
    "ActiveErpLinks": 850,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 685
      }
    }
  },
  "Project": {
    "ProjectId": 489,
    "Name": "McDermott-Vandervort",
    "Description": "Customer-focused eco-centric extranet",
    "URL": "http://www.example.com/",
    "Type": "maxime",
    "AssociateId": 956,
    "AssociateFullName": "Mrs. Otilia Koss",
    "TypeId": 234,
    "Updated": "1996-10-02T18:28:48.2952868+02:00",
    "StatusId": 175,
    "Status": "et",
    "TextId": 392,
    "PublishTo": "2000-12-07T18:28:48.2952868+01:00",
    "PublishFrom": "2011-12-03T18:28:48.2952868+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1111461",
    "ActiveErpLinks": 763,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 12
      }
    }
  },
  "Sale": {
    "ContactName": "Huel, Blanda and Gutmann",
    "SaleDate": "2008-02-08T18:28:48.2952868+01:00",
    "SaleId": 831,
    "Probability": 700,
    "Title": "et",
    "Amount": 17092.836,
    "Currency": "reprehenderit",
    "ProjectName": "Roob-Rice",
    "AssociateFullName": "Marshall Hegmann",
    "Description": "Open-source full-range neural-net",
    "Status": "Lost",
    "WeightedAmount": 18891.752,
    "ProjectId": 601,
    "EarningPercent": 28773.254,
    "Earning": 3867.3559999999998,
    "ContactId": 757,
    "AssociateId": 956,
    "PersonId": 432,
    "SaleTypeId": 374,
    "SaleTypeName": "Bayer Group",
    "PersonFullName": "Vergie Rempel",
    "Completed": "Completed",
    "ActiveErpLinks": 479,
    "NextDueDate": "1995-05-20T18:28:48.2952868+02:00",
    "Number": "622684",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 519
      }
    }
  },
  "Ticket": {
    "TicketId": 374,
    "Title": "earum",
    "CreatedAt": "1997-05-16T18:28:48.2952868+02:00",
    "LastChanged": "2018-11-19T18:28:48.2952868+01:00",
    "ReadByOwner": "2019-11-21T18:28:48.2952868+01:00",
    "ReadByCustomer": "2000-10-02T18:28:48.2952868+02:00",
    "FirstReadByUser": "2001-07-02T18:28:48.2952868+02:00",
    "Activate": "2001-09-23T18:28:48.2952868+02:00",
    "ClosedAt": "2012-09-21T18:28:48.2952868+02:00",
    "RepliedAt": "2019-12-16T18:28:48.2952868+01:00",
    "AlertTimeout": "2000-04-08T18:28:48.2952868+02:00",
    "Deadline": "2008-11-07T18:28:48.2952868+01:00",
    "CreatedBy": 389,
    "CreatedByName": "Blanda-Roberts",
    "Author": "molestiae",
    "OwnedBy": 344,
    "OwnedByName": "Jacobi, Skiles and Schmidt",
    "Category": 8,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 212,
    "PriorityName": "Casper-Dooley",
    "BaseStatus": "Active",
    "TicketStatus": 624,
    "TicketStatusDisplayValue": "vitae",
    "Origin": "AutoGenerated",
    "CustId": 332,
    "PersonFirstname": "Raphaelle",
    "PersonMiddleName": "Hamill Inc and Sons",
    "PersonLastname": "Keebler",
    "PersonFullname": "aliquam",
    "AlertLevel": 403,
    "ConnectId": 886,
    "ReadStatus": "Green",
    "TimeToReply": 707,
    "RealTimeToReply": 91,
    "TimeToClose": 590,
    "RealTimeToClose": 330,
    "TimeSpentInternally": 478,
    "TimeSpentExternally": 183,
    "TimeSpentQueue": 879,
    "RealTimeSpentInternally": 544,
    "RealTimeSpentExternally": 690,
    "RealTimeSpentQueue": 974,
    "HasAttachment": false,
    "NumReplies": 143,
    "NumMessages": 891,
    "FromAddress": "eos",
    "ContactId": 396,
    "ContactName": "Lesch-Mraz",
    "OwnedByAssociateId": 450,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 52
      }
    }
  },
  "TransferTo": {
    "AssociateId": 262,
    "Name": "Klocko, Champlin and Vandervort",
    "PersonId": 530,
    "Rank": 145,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 484,
    "FullName": "Miss Penelope Reichert",
    "FormalName": "Roberts-Dare",
    "Deleted": true,
    "EjUserId": 574,
    "UserName": "Osinski-Dach",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 679
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
      "FieldLength": 540
    }
  }
}
```