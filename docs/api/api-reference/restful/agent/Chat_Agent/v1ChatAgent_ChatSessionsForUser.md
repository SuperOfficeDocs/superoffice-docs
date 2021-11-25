---
title: POST Agents/Chat/ChatSessionsForUser
id: v1ChatAgent_ChatSessionsForUser
---

# POST Agents/Chat/ChatSessionsForUser

```http
POST /api/v1/Agents/Chat/ChatSessionsForUser
```

Get all chat sessions which this user is a member of.

Members means that you have at least one of: Can Respond, Notifications, Listen or Manager





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/ChatSessionsForUser?$select=name,department,category/id
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


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
POST /api/v1/Agents/Chat/ChatSessionsForUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ChatSessionId": 728,
    "TopicId": 56,
    "User": {
      "AssociateId": 818,
      "Name": "Bauch-Hegmann",
      "PersonId": 131,
      "Rank": 732,
      "Tooltip": "omnis",
      "Type": "AnonymousAssociate",
      "GroupIdx": 426,
      "FullName": "Arvid Ziemann",
      "FormalName": "Ankunding, Gutmann and McKenzie",
      "Deleted": true,
      "EjUserId": 543,
      "UserName": "Frami-Greenfelder",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 260
        }
      }
    },
    "Person": {
      "Position": "cumque",
      "PersonId": 748,
      "Mrmrs": "ad",
      "Firstname": "Ali",
      "Lastname": "Rau",
      "MiddleName": "Pouros, Trantow and Brekke",
      "Title": "aut",
      "Description": "Exclusive motivating parallelism",
      "Email": "cleora@bayerschuppe.info",
      "FullName": "Cristobal Bergnaum",
      "DirectPhone": "1-227-444-4722",
      "FormalName": "Schoen, Corwin and Hoppe",
      "CountryId": 371,
      "ContactId": 58,
      "ContactName": "Cartwright Inc and Sons",
      "Retired": 600,
      "Rank": 485,
      "ActiveInterests": 293,
      "ContactDepartment": "",
      "ContactCountryId": 518,
      "ContactOrgNr": "1821163",
      "FaxPhone": "(735)142-8641",
      "MobilePhone": "354.002.8400",
      "ContactPhone": "(663)047-8424 x5363",
      "AssociateName": "Cartwright-Goldner",
      "AssociateId": 570,
      "UsePersonAddress": true,
      "ContactFax": "molestiae",
      "Kanafname": "delectus",
      "Kanalname": "est",
      "Post1": "rem",
      "Post2": "dolores",
      "Post3": "et",
      "EmailName": "alia.pacocha@schmeler.co.uk",
      "ContactFullName": "Zelda Smith",
      "ActiveErpLinks": 639,
      "TicketPriorityId": 738,
      "SupportLanguageId": 156,
      "SupportAssociateId": 811,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 652
        }
      }
    },
    "CustomerAlias": "pariatur",
    "CustomerHost": "placeat",
    "CustomerName": "Runte, Orn and Jenkins",
    "CustomerEmail": "francisca@wilderman.name",
    "CustomerPhone": "466.267.0780",
    "CustomerConsented": true,
    "CustomerCompanyName": "Kirlin, Greenfelder and Tremblay",
    "Status": "Closed",
    "FirstMessage": "earum",
    "LastMessage": "recusandae",
    "WhenRequested": "2005-02-02T18:28:48.2632862+01:00",
    "WhenStarted": "2011-06-16T18:28:48.2632862+02:00",
    "WhenEnded": "1998-11-24T18:28:48.2632862+01:00",
    "WhenIdle": "2018-07-20T18:28:48.2632862+02:00",
    "WhenFetched": "2018-04-10T18:28:48.2632862+02:00",
    "SessionKey": "velit",
    "InitialQueuePos": 757,
    "AlertLevel": 68,
    "Rank": 44,
    "Flags": "CustomerIsTyping",
    "Contact": {
      "ContactId": 610,
      "Name": "Rosenbaum, Gaylord and Schuppe",
      "OrgNr": "1548665",
      "Department": "",
      "URL": "http://www.example.com/",
      "City": "est",
      "DirectPhone": "763.680.4756 x487",
      "AssociateId": 174,
      "CountryId": 918,
      "EmailAddress": "clara_hoppe@schaefer.name",
      "Kananame": "magni",
      "EmailAddressName": "ali.ernser@bechtelarkirlin.com",
      "URLName": "http://www.example.com/",
      "AssociateFullName": "Ms. Axel Parisian",
      "BusinessName": "Information Technology",
      "CategoryName": "VIP Customer",
      "CountryName": "Sokovia",
      "Address": {},
      "FormattedAddress": "eos",
      "FullName": "Edyth Fritsch",
      "IsOwnerContact": true,
      "ActiveErpLinks": 378,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 85
        }
      }
    },
    "Project": {
      "ProjectId": 905,
      "Name": "Pollich Inc and Sons",
      "Description": "Reduced heuristic productivity",
      "URL": "http://www.example.com/",
      "Type": "repellendus",
      "AssociateId": 724,
      "AssociateFullName": "Dock Bartoletti",
      "TypeId": 392,
      "Updated": "2005-08-30T18:28:48.2642866+02:00",
      "StatusId": 249,
      "Status": "repellat",
      "TextId": 789,
      "PublishTo": "2001-09-13T18:28:48.2642866+02:00",
      "PublishFrom": "2005-02-17T18:28:48.2642866+01:00",
      "IsPublished": false,
      "URLName": "http://www.example.com/",
      "ProjectNumber": "1661449",
      "ActiveErpLinks": 523,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 505
        }
      }
    },
    "Sale": {
      "ContactName": "Lynch-Ernser",
      "SaleDate": "2002-03-28T18:28:48.2642866+01:00",
      "SaleId": 956,
      "Probability": 173,
      "Title": "quisquam",
      "Amount": 25780.284,
      "Currency": "impedit",
      "ProjectName": "Muller Inc and Sons",
      "AssociateFullName": "Stan Swaniawski",
      "Description": "Front-line tertiary monitoring",
      "Status": "Lost",
      "WeightedAmount": 20938.254,
      "ProjectId": 161,
      "EarningPercent": 3748.2639999999997,
      "Earning": 7455.786,
      "ContactId": 472,
      "AssociateId": 86,
      "PersonId": 143,
      "SaleTypeId": 954,
      "SaleTypeName": "Price, Johns and Frami",
      "PersonFullName": "Connor Crooks",
      "Completed": "Completed",
      "ActiveErpLinks": 550,
      "NextDueDate": "2019-10-01T18:28:48.2652954+02:00",
      "Number": "653576",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 80
        }
      }
    },
    "Ticket": {
      "TicketId": 476,
      "Title": "molestias",
      "CreatedAt": "1995-07-01T18:28:48.2652954+02:00",
      "LastChanged": "1998-11-16T18:28:48.2652954+01:00",
      "ReadByOwner": "2004-02-18T18:28:48.2652954+01:00",
      "ReadByCustomer": "2001-10-01T18:28:48.2652954+02:00",
      "FirstReadByUser": "2018-03-26T18:28:48.2652954+02:00",
      "Activate": "1997-11-16T18:28:48.2652954+01:00",
      "ClosedAt": "2011-10-31T18:28:48.2652954+01:00",
      "RepliedAt": "1996-11-26T18:28:48.2652954+01:00",
      "AlertTimeout": "2010-11-29T18:28:48.2652954+01:00",
      "Deadline": "2019-02-02T18:28:48.2652954+01:00",
      "CreatedBy": 482,
      "CreatedByName": "Bogisich-Armstrong",
      "Author": "fugit",
      "OwnedBy": 12,
      "OwnedByName": "Auer Inc and Sons",
      "Category": 110,
      "CategoryName": "VIP Customer",
      "CategoryFullname": "VIP Customer",
      "Slevel": "External",
      "Priority": 570,
      "PriorityName": "Farrell Group",
      "BaseStatus": "Active",
      "TicketStatus": 611,
      "TicketStatusDisplayValue": "accusamus",
      "Origin": "AutoGenerated",
      "CustId": 765,
      "PersonFirstname": "Jazlyn",
      "PersonMiddleName": "Daugherty-Bruen",
      "PersonLastname": "Beer",
      "PersonFullname": "veniam",
      "AlertLevel": 369,
      "ConnectId": 64,
      "ReadStatus": "Green",
      "TimeToReply": 762,
      "RealTimeToReply": 229,
      "TimeToClose": 70,
      "RealTimeToClose": 596,
      "TimeSpentInternally": 133,
      "TimeSpentExternally": 421,
      "TimeSpentQueue": 761,
      "RealTimeSpentInternally": 771,
      "RealTimeSpentExternally": 280,
      "RealTimeSpentQueue": 789,
      "HasAttachment": true,
      "NumReplies": 792,
      "NumMessages": 400,
      "FromAddress": "enim",
      "ContactId": 327,
      "ContactName": "Klein-O'Hara",
      "OwnedByAssociateId": 760,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 718
        }
      }
    },
    "TransferTo": {
      "AssociateId": 1001,
      "Name": "Smitham-O'Keefe",
      "PersonId": 59,
      "Rank": 50,
      "Tooltip": "est",
      "Type": "AnonymousAssociate",
      "GroupIdx": 818,
      "FullName": "Mrs. Deron Nader",
      "FormalName": "Schneider-Stark",
      "Deleted": true,
      "EjUserId": 594,
      "UserName": "Haag Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 735
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
          "Reason": "architect strategic action-items"
        },
        "FieldType": "System.String",
        "FieldLength": 624
      }
    }
  }
]
```