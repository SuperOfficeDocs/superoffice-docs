---
title: ResetChatSession
id: v1ChatAgent_ResetChatSession
---

# ResetChatSession

```http
POST /api/v1/Agents/Chat/ResetChatSession
```

Reset chat session, put it back on the queue for pickup.

Used by bots to hand off a session to human





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/ResetChatSession?$select=name,department,category/id
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
POST /api/v1/Agents/Chat/ResetChatSession
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 317
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 965,
  "TopicId": 918,
  "User": {
    "AssociateId": 306,
    "Name": "Hermiston Inc and Sons",
    "PersonId": 528,
    "Rank": 301,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 326,
    "FullName": "Pietro Schaefer",
    "FormalName": "Padberg-Donnelly",
    "Deleted": false,
    "EjUserId": 721,
    "UserName": "Stehr Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 297
      }
    }
  },
  "Person": {
    "Position": "voluptatem",
    "PersonId": 491,
    "Mrmrs": "voluptatem",
    "Firstname": "Price",
    "Lastname": "Stehr",
    "MiddleName": "Mraz-Block",
    "Title": "harum",
    "Description": "Visionary contextually-based core",
    "Email": "kennedi@jacobi.co.uk",
    "FullName": "Zachery Cremin",
    "DirectPhone": "1-003-012-6575",
    "FormalName": "Roob Group",
    "CountryId": 765,
    "ContactId": 524,
    "ContactName": "Franecki, Cummings and Hyatt",
    "Retired": 792,
    "Rank": 566,
    "ActiveInterests": 966,
    "ContactDepartment": "",
    "ContactCountryId": 885,
    "ContactOrgNr": "968579",
    "FaxPhone": "(132)323-5163 x3361",
    "MobilePhone": "(151)274-7674",
    "ContactPhone": "350.542.0551 x426",
    "AssociateName": "Collier-Murphy",
    "AssociateId": 775,
    "UsePersonAddress": true,
    "ContactFax": "voluptas",
    "Kanafname": "libero",
    "Kanalname": "dolor",
    "Post1": "soluta",
    "Post2": "laboriosam",
    "Post3": "quaerat",
    "EmailName": "jaida_padberg@beer.name",
    "ContactFullName": "Emily Brakus IV",
    "ActiveErpLinks": 876,
    "TicketPriorityId": 643,
    "SupportLanguageId": 433,
    "SupportAssociateId": 439,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 105
      }
    }
  },
  "CustomerAlias": "maiores",
  "CustomerHost": "rerum",
  "CustomerName": "Blick, Glover and Rohan",
  "CustomerEmail": "maybell_kshlerin@kunzeboehm.us",
  "CustomerPhone": "(404)535-4415",
  "CustomerConsented": true,
  "CustomerCompanyName": "Fisher-Renner",
  "Status": "Closed",
  "FirstMessage": "nesciunt",
  "LastMessage": "rem",
  "WhenRequested": "2016-07-30T14:58:03.517284+02:00",
  "WhenStarted": "2001-09-21T14:58:03.517284+02:00",
  "WhenEnded": "2014-01-09T14:58:03.517284+01:00",
  "WhenIdle": "1994-10-29T14:58:03.517284+02:00",
  "WhenFetched": "1999-07-10T14:58:03.517284+02:00",
  "SessionKey": "ipsa",
  "InitialQueuePos": 467,
  "AlertLevel": 574,
  "Rank": 621,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 378,
    "Name": "Blanda-Hegmann",
    "OrgNr": "981585",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "perferendis",
    "DirectPhone": "1-234-413-5801",
    "AssociateId": 212,
    "CountryId": 213,
    "EmailAddress": "celestine.cummings@robel.us",
    "Kananame": "officiis",
    "EmailAddressName": "alyson.mcclure@tremblay.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Lura Glover",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "earum",
    "FullName": "Noelia Legros",
    "IsOwnerContact": false,
    "ActiveErpLinks": 67,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 407
      }
    }
  },
  "Project": {
    "ProjectId": 919,
    "Name": "West Group",
    "Description": "Visionary context-sensitive initiative",
    "URL": "http://www.example.com/",
    "Type": "ut",
    "AssociateId": 670,
    "AssociateFullName": "Gabriel Kovacek IV",
    "TypeId": 198,
    "Updated": "2006-07-23T14:58:03.5182919+02:00",
    "StatusId": 53,
    "Status": "quidem",
    "TextId": 982,
    "PublishTo": "2013-10-05T14:58:03.5182919+02:00",
    "PublishFrom": "2006-03-28T14:58:03.5182919+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "717634",
    "ActiveErpLinks": 36,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 99
      }
    }
  },
  "Sale": {
    "ContactName": "Pagac, Hilpert and Leannon",
    "SaleDate": "2018-02-05T14:58:03.5182919+01:00",
    "SaleId": 89,
    "Probability": 635,
    "Title": "voluptates",
    "Amount": 3397.256,
    "Currency": "quia",
    "ProjectName": "Mills Group",
    "AssociateFullName": "Ruben Green",
    "Description": "Fundamental bandwidth-monitored access",
    "Status": "Lost",
    "WeightedAmount": 26902.255999999998,
    "ProjectId": 524,
    "EarningPercent": 3641.708,
    "Earning": 11081.824,
    "ContactId": 225,
    "AssociateId": 462,
    "PersonId": 673,
    "SaleTypeId": 953,
    "SaleTypeName": "Walter, Lesch and Friesen",
    "PersonFullName": "Jerrod Zulauf",
    "Completed": "Completed",
    "ActiveErpLinks": 342,
    "NextDueDate": "2018-09-06T14:58:03.5192957+02:00",
    "Number": "1558864",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 967
      }
    }
  },
  "Ticket": {
    "TicketId": 265,
    "Title": "sed",
    "CreatedAt": "2003-07-23T14:58:03.5192957+02:00",
    "LastChanged": "2016-09-21T14:58:03.5192957+02:00",
    "ReadByOwner": "2018-06-06T14:58:03.5192957+02:00",
    "ReadByCustomer": "2015-05-24T14:58:03.5192957+02:00",
    "FirstReadByUser": "1995-11-28T14:58:03.5192957+01:00",
    "Activate": "2019-05-21T14:58:03.5192957+02:00",
    "ClosedAt": "2015-11-05T14:58:03.5192957+01:00",
    "RepliedAt": "1999-03-18T14:58:03.5192957+01:00",
    "AlertTimeout": "1998-05-30T14:58:03.5192957+02:00",
    "Deadline": "2010-07-27T14:58:03.5192957+02:00",
    "CreatedBy": 778,
    "CreatedByName": "Daniel, Ritchie and Will",
    "Author": "libero",
    "OwnedBy": 787,
    "OwnedByName": "Steuber LLC",
    "Category": 572,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 950,
    "PriorityName": "DuBuque LLC",
    "BaseStatus": "Active",
    "TicketStatus": 332,
    "TicketStatusDisplayValue": "voluptatem",
    "Origin": "AutoGenerated",
    "CustId": 887,
    "PersonFirstname": "Theodore",
    "PersonMiddleName": "Russel Group",
    "PersonLastname": "Price",
    "PersonFullname": "dolorem",
    "AlertLevel": 536,
    "ConnectId": 678,
    "ReadStatus": "Green",
    "TimeToReply": 549,
    "RealTimeToReply": 565,
    "TimeToClose": 247,
    "RealTimeToClose": 746,
    "TimeSpentInternally": 903,
    "TimeSpentExternally": 854,
    "TimeSpentQueue": 240,
    "RealTimeSpentInternally": 713,
    "RealTimeSpentExternally": 181,
    "RealTimeSpentQueue": 214,
    "HasAttachment": true,
    "NumReplies": 88,
    "NumMessages": 93,
    "FromAddress": "ipsum",
    "ContactId": 5,
    "ContactName": "Quitzon, Hahn and Kuhic",
    "OwnedByAssociateId": 711,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 252
      }
    }
  },
  "TransferTo": {
    "AssociateId": 731,
    "Name": "McGlynn Group",
    "PersonId": 191,
    "Rank": 887,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 356,
    "FullName": "Wilhelmine Koch",
    "FormalName": "Beahan-Bosco",
    "Deleted": true,
    "EjUserId": 972,
    "UserName": "Jacobs, Smith and VonRueden",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 863
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
      "FieldLength": 268
    }
  }
}
```