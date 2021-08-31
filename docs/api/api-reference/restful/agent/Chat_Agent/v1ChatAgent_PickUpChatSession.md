---
title: PickUpChatSession
id: v1ChatAgent_PickUpChatSession
---

# PickUpChatSession

```http
POST /api/v1/Agents/Chat/PickUpChatSession
```

'answer' the session: assign the session to the user.

The welcome message is sent to the customer. Returns NULL if session was not in queue.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/PickUpChatSession?$select=name,department,category/id
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
POST /api/v1/Agents/Chat/PickUpChatSession
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 814
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 869,
  "TopicId": 101,
  "User": {
    "AssociateId": 371,
    "Name": "Funk-DuBuque",
    "PersonId": 775,
    "Rank": 890,
    "Tooltip": "quaerat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 428,
    "FullName": "Ellsworth Sawayn",
    "FormalName": "Stiedemann, McKenzie and Reynolds",
    "Deleted": false,
    "EjUserId": 789,
    "UserName": "Jacobi Group",
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
  "Person": {
    "Position": "dolores",
    "PersonId": 949,
    "Mrmrs": "dolorum",
    "Firstname": "Alessandro",
    "Lastname": "Auer",
    "MiddleName": "Larkin Inc and Sons",
    "Title": "dolore",
    "Description": "Visionary fresh-thinking archive",
    "Email": "kaya.fritsch@weber.biz",
    "FullName": "Kellen Schmidt",
    "DirectPhone": "1-565-635-6572 x7752",
    "FormalName": "Huels-Ruecker",
    "CountryId": 897,
    "ContactId": 487,
    "ContactName": "Hintz, Douglas and Rolfson",
    "Retired": 255,
    "Rank": 509,
    "ActiveInterests": 597,
    "ContactDepartment": "",
    "ContactCountryId": 113,
    "ContactOrgNr": "1027196",
    "FaxPhone": "372-358-3262 x6236",
    "MobilePhone": "573.583.0033 x821",
    "ContactPhone": "153-863-8378 x33574",
    "AssociateName": "Trantow-Jenkins",
    "AssociateId": 487,
    "UsePersonAddress": false,
    "ContactFax": "sunt",
    "Kanafname": "qui",
    "Kanalname": "eius",
    "Post1": "assumenda",
    "Post2": "veritatis",
    "Post3": "est",
    "EmailName": "jarred@nitzschehansen.us",
    "ContactFullName": "Hattie McGlynn",
    "ActiveErpLinks": 281,
    "TicketPriorityId": 38,
    "SupportLanguageId": 504,
    "SupportAssociateId": 190,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 560
      }
    }
  },
  "CustomerAlias": "atque",
  "CustomerHost": "qui",
  "CustomerName": "Sipes LLC",
  "CustomerEmail": "roxane.klocko@emmerich.us",
  "CustomerPhone": "012.724.6036 x4132",
  "CustomerConsented": true,
  "CustomerCompanyName": "Ebert Inc and Sons",
  "Status": "Closed",
  "FirstMessage": "dolorem",
  "LastMessage": "facilis",
  "WhenRequested": "1994-05-13T14:58:03.4563103+02:00",
  "WhenStarted": "2002-03-23T14:58:03.4563103+01:00",
  "WhenEnded": "2008-08-24T14:58:03.4563103+02:00",
  "WhenIdle": "2014-03-29T14:58:03.4563103+01:00",
  "WhenFetched": "2016-02-05T14:58:03.4563103+01:00",
  "SessionKey": "quis",
  "InitialQueuePos": 895,
  "AlertLevel": 253,
  "Rank": 209,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 477,
    "Name": "Zboncak, Quitzon and Kling",
    "OrgNr": "1716424",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "magni",
    "DirectPhone": "646-080-1118",
    "AssociateId": 90,
    "CountryId": 492,
    "EmailAddress": "broderick@gottlieb.name",
    "Kananame": "veniam",
    "EmailAddressName": "zoila_reynolds@kuphal.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Antonetta Carter",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "voluptatibus",
    "FullName": "Aimee Leannon",
    "IsOwnerContact": true,
    "ActiveErpLinks": 526,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 14
      }
    }
  },
  "Project": {
    "ProjectId": 431,
    "Name": "Denesik-Reichel",
    "Description": "Organic multimedia monitoring",
    "URL": "http://www.example.com/",
    "Type": "odit",
    "AssociateId": 917,
    "AssociateFullName": "Mose Sauer",
    "TypeId": 459,
    "Updated": "1996-11-28T14:58:03.4583103+01:00",
    "StatusId": 319,
    "Status": "quas",
    "TextId": 429,
    "PublishTo": "2006-03-16T14:58:03.4583103+01:00",
    "PublishFrom": "1997-08-13T14:58:03.4583103+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1948667",
    "ActiveErpLinks": 291,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 396
      }
    }
  },
  "Sale": {
    "ContactName": "Moore Inc and Sons",
    "SaleDate": "2015-01-31T14:58:03.4583103+01:00",
    "SaleId": 961,
    "Probability": 571,
    "Title": "unde",
    "Amount": 12178.724,
    "Currency": "aut",
    "ProjectName": "Boehm, Wintheiser and Doyle",
    "AssociateFullName": "Delphine Daniel V",
    "Description": "Polarised stable policy",
    "Status": "Lost",
    "WeightedAmount": 8991.446,
    "ProjectId": 480,
    "EarningPercent": 4190.1579999999994,
    "Earning": 16719.89,
    "ContactId": 419,
    "AssociateId": 208,
    "PersonId": 432,
    "SaleTypeId": 389,
    "SaleTypeName": "Treutel, Spencer and Wunsch",
    "PersonFullName": "Darian Kuhlman",
    "Completed": "Completed",
    "ActiveErpLinks": 889,
    "NextDueDate": "2009-06-23T14:58:03.4583103+02:00",
    "Number": "1169054",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 797
      }
    }
  },
  "Ticket": {
    "TicketId": 933,
    "Title": "temporibus",
    "CreatedAt": "2020-07-31T14:58:03.4583103+02:00",
    "LastChanged": "2021-06-04T14:58:03.4583103+02:00",
    "ReadByOwner": "2015-06-16T14:58:03.4583103+02:00",
    "ReadByCustomer": "2017-10-22T14:58:03.4583103+02:00",
    "FirstReadByUser": "2006-05-12T14:58:03.4583103+02:00",
    "Activate": "2011-01-31T14:58:03.4583103+01:00",
    "ClosedAt": "2000-12-12T14:58:03.4583103+01:00",
    "RepliedAt": "1999-08-07T14:58:03.4583103+02:00",
    "AlertTimeout": "2000-10-20T14:58:03.4583103+02:00",
    "Deadline": "1999-01-26T14:58:03.4583103+01:00",
    "CreatedBy": 37,
    "CreatedByName": "Heaney Group",
    "Author": "et",
    "OwnedBy": 92,
    "OwnedByName": "Wunsch Group",
    "Category": 959,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 352,
    "PriorityName": "D'Amore, Bergstrom and Harvey",
    "BaseStatus": "Active",
    "TicketStatus": 963,
    "TicketStatusDisplayValue": "laboriosam",
    "Origin": "AutoGenerated",
    "CustId": 652,
    "PersonFirstname": "Hassan",
    "PersonMiddleName": "Hodkiewicz-Murray",
    "PersonLastname": "Roob",
    "PersonFullname": "mollitia",
    "AlertLevel": 546,
    "ConnectId": 426,
    "ReadStatus": "Green",
    "TimeToReply": 999,
    "RealTimeToReply": 854,
    "TimeToClose": 405,
    "RealTimeToClose": 429,
    "TimeSpentInternally": 443,
    "TimeSpentExternally": 30,
    "TimeSpentQueue": 82,
    "RealTimeSpentInternally": 487,
    "RealTimeSpentExternally": 555,
    "RealTimeSpentQueue": 951,
    "HasAttachment": false,
    "NumReplies": 835,
    "NumMessages": 283,
    "FromAddress": "omnis",
    "ContactId": 971,
    "ContactName": "Beatty-Kovacek",
    "OwnedByAssociateId": 846,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 393
      }
    }
  },
  "TransferTo": {
    "AssociateId": 928,
    "Name": "Cummerata-Moore",
    "PersonId": 336,
    "Rank": 963,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 30,
    "FullName": "Reinhold Runte",
    "FormalName": "Tremblay-Funk",
    "Deleted": false,
    "EjUserId": 417,
    "UserName": "O'Hara, Schaden and McCullough",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 788
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
      "FieldLength": 421
    }
  }
}
```