---
title: GET ChatSession/ForCurrentUser
id: v1ChatSessionEntity_ChatSessionsForUser
---

# GET ChatSession/ForCurrentUser

```http
GET /api/v1/ChatSession/ForCurrentUser
```

Get all chat sessions which this user is a member of.

Members means that you have at least one of: Can Respond, Notifications, Listen or Manager






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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/ChatSession/ForCurrentUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ChatSessionId": 518,
    "TopicId": 461,
    "User": {
      "AssociateId": 397,
      "Name": "Kshlerin-Larson",
      "PersonId": 963,
      "Rank": 98,
      "Tooltip": "in",
      "Type": "AnonymousAssociate",
      "GroupIdx": 788,
      "FullName": "Dr. Verlie Hills",
      "FormalName": "Sauer Group",
      "Deleted": false,
      "EjUserId": 738,
      "UserName": "Robel-Toy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 864
        }
      }
    },
    "Person": {
      "Position": "nulla",
      "PersonId": 375,
      "Mrmrs": "ut",
      "Firstname": "Marilyne",
      "Lastname": "Mohr",
      "MiddleName": "Shields LLC",
      "Title": "ea",
      "Description": "Adaptive optimal alliance",
      "Email": "mertie_romaguera@feest.uk",
      "FullName": "Camryn Eichmann",
      "DirectPhone": "(164)443-0801",
      "FormalName": "Kertzmann-Jakubowski",
      "CountryId": 325,
      "ContactId": 924,
      "ContactName": "Parisian-Nolan",
      "Retired": 442,
      "Rank": 676,
      "ActiveInterests": 1001,
      "ContactDepartment": "",
      "ContactCountryId": 52,
      "ContactOrgNr": "643332",
      "FaxPhone": "(757)378-1542",
      "MobilePhone": "1-858-868-4203",
      "ContactPhone": "266.764.0762 x01541",
      "AssociateName": "Harber-Krajcik",
      "AssociateId": 310,
      "UsePersonAddress": false,
      "ContactFax": "est",
      "Kanafname": "temporibus",
      "Kanalname": "occaecati",
      "Post1": "labore",
      "Post2": "error",
      "Post3": "iure",
      "EmailName": "rebekah.bogisich@armstrongemmerich.ca",
      "ContactFullName": "Lucious Oberbrunner",
      "ActiveErpLinks": 1000,
      "TicketPriorityId": 885,
      "SupportLanguageId": 451,
      "SupportAssociateId": 272,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    },
    "CustomerAlias": "assumenda",
    "CustomerHost": "odit",
    "CustomerName": "Leffler, Williamson and Terry",
    "CustomerEmail": "omari@kreiger.ca",
    "CustomerPhone": "1-710-822-6318",
    "CustomerConsented": true,
    "CustomerCompanyName": "Legros, Friesen and Harber",
    "Status": "Closed",
    "FirstMessage": "voluptate",
    "LastMessage": "et",
    "WhenRequested": "2010-10-19T09:40:58.7363769+02:00",
    "WhenStarted": "2001-10-12T09:40:58.7363769+02:00",
    "WhenEnded": "2004-08-06T09:40:58.7363769+02:00",
    "WhenIdle": "2005-11-22T09:40:58.7363769+01:00",
    "WhenFetched": "2001-11-07T09:40:58.7363769+01:00",
    "SessionKey": "accusantium",
    "InitialQueuePos": 821,
    "AlertLevel": 628,
    "Rank": 162,
    "Flags": "CustomerIsTyping",
    "Contact": {
      "ContactId": 551,
      "Name": "Connelly LLC",
      "OrgNr": "849096",
      "Department": "",
      "URL": "http://www.example.com/",
      "City": "error",
      "DirectPhone": "(176)203-8324",
      "AssociateId": 699,
      "CountryId": 400,
      "EmailAddress": "timmothy@lowe.us",
      "Kananame": "ut",
      "EmailAddressName": "melvina.johns@nitzsche.co.uk",
      "URLName": "http://www.example.com/",
      "AssociateFullName": "Miss Kendra Kub",
      "BusinessName": "Information Technology",
      "CategoryName": "VIP Customer",
      "CountryName": "Sokovia",
      "Address": {},
      "FormattedAddress": "consectetur",
      "FullName": "Salma Friesen",
      "IsOwnerContact": false,
      "ActiveErpLinks": 792,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 676
        }
      }
    },
    "Project": {
      "ProjectId": 846,
      "Name": "Gibson Inc and Sons",
      "Description": "Fully-configurable object-oriented architecture",
      "URL": "http://www.example.com/",
      "Type": "libero",
      "AssociateId": 333,
      "AssociateFullName": "Jayden Simonis II",
      "TypeId": 642,
      "Updated": "2010-01-26T09:40:58.7373763+01:00",
      "StatusId": 961,
      "Status": "reprehenderit",
      "TextId": 207,
      "PublishTo": "1997-09-25T09:40:58.7373763+02:00",
      "PublishFrom": "2017-08-07T09:40:58.7373763+02:00",
      "IsPublished": false,
      "URLName": "http://www.example.com/",
      "ProjectNumber": "1174468",
      "ActiveErpLinks": 301,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 385
        }
      }
    },
    "Sale": {
      "ContactName": "Larson Inc and Sons",
      "SaleDate": "2010-09-18T09:40:58.7373763+02:00",
      "SaleId": 576,
      "Probability": 520,
      "Title": "quia",
      "Amount": 15469.423999999999,
      "Currency": "a",
      "ProjectName": "Treutel-Crist",
      "AssociateFullName": "Melvin Zemlak",
      "Description": "Operative mission-critical customer loyalty",
      "Status": "Lost",
      "WeightedAmount": 29848.216,
      "ProjectId": 986,
      "EarningPercent": 5478.232,
      "Earning": 25592.244,
      "ContactId": 714,
      "AssociateId": 239,
      "PersonId": 828,
      "SaleTypeId": 478,
      "SaleTypeName": "Bashirian Group",
      "PersonFullName": "Ed Deckow",
      "Completed": "Completed",
      "ActiveErpLinks": 154,
      "NextDueDate": "2009-01-11T09:40:58.7383776+01:00",
      "Number": "872131",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 64
        }
      }
    },
    "Ticket": {
      "TicketId": 248,
      "Title": "ut",
      "CreatedAt": "2000-06-13T09:40:58.7383776+02:00",
      "LastChanged": "2020-05-06T09:40:58.7383776+02:00",
      "ReadByOwner": "2020-06-20T09:40:58.7383776+02:00",
      "ReadByCustomer": "2012-10-22T09:40:58.7383776+02:00",
      "FirstReadByUser": "2017-02-18T09:40:58.7383776+01:00",
      "Activate": "2004-01-02T09:40:58.7383776+01:00",
      "ClosedAt": "2011-05-02T09:40:58.7383776+02:00",
      "RepliedAt": "2006-02-12T09:40:58.7383776+01:00",
      "AlertTimeout": "2015-11-06T09:40:58.7383776+01:00",
      "Deadline": "2006-07-28T09:40:58.7383776+02:00",
      "CreatedBy": 156,
      "CreatedByName": "Stoltenberg-Goyette",
      "Author": "cumque",
      "OwnedBy": 478,
      "OwnedByName": "Carroll Inc and Sons",
      "Category": 614,
      "CategoryName": "VIP Customer",
      "CategoryFullname": "VIP Customer",
      "Slevel": "External",
      "Priority": 768,
      "BaseStatus": "Active",
      "TicketStatus": 548,
      "Origin": "AutoGenerated",
      "CustId": 490,
      "CustFirstname": "Dallin",
      "CustMiddleName": "Haley Group",
      "CustLastname": "Walter",
      "AlertLevel": 488,
      "ConnectId": 478,
      "ReadStatus": "Green",
      "TimeToReply": 795,
      "RealTimeToReply": 450,
      "TimeToClose": 711,
      "RealTimeToClose": 888,
      "TimeSpentInternally": 215,
      "TimeSpentExternally": 128,
      "TimeSpentQueue": 733,
      "RealTimeSpentInternally": 987,
      "RealTimeSpentExternally": 104,
      "RealTimeSpentQueue": 999,
      "HasAttachment": false,
      "NumReplies": 890,
      "NumMessages": 842,
      "FromAddress": "dicta",
      "CustFullname": "assumenda",
      "TicketStatusDisplayValue": "nostrum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 472
        }
      }
    },
    "TransferTo": {
      "AssociateId": 763,
      "Name": "Connelly-Connelly",
      "PersonId": 506,
      "Rank": 884,
      "Tooltip": "tempora",
      "Type": "AnonymousAssociate",
      "GroupIdx": 387,
      "FullName": "Noble Friesen",
      "FormalName": "Jakubowski, Turcotte and Volkman",
      "Deleted": false,
      "EjUserId": 988,
      "UserName": "Lynch-Orn",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 964
        }
      }
    },
    "TableRight": {
      "Mask": "Delete",
      "Reason": "extend mission-critical applications"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 950
      }
    }
  }
]
```