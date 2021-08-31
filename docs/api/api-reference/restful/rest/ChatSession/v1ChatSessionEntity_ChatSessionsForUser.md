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
| ChatbotIsActive | bool | Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/ChatSession/ForCurrentUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ChatSessionId": 938,
    "TopicId": 210,
    "User": {
      "AssociateId": 83,
      "Name": "Keebler Inc and Sons",
      "PersonId": 517,
      "Rank": 900,
      "Tooltip": "quia",
      "Type": "AnonymousAssociate",
      "GroupIdx": 198,
      "FullName": "Elaina McClure",
      "FormalName": "Kshlerin, Keebler and Rolfson",
      "Deleted": true,
      "EjUserId": 746,
      "UserName": "Powlowski LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 643
        }
      }
    },
    "Person": {
      "Position": "est",
      "PersonId": 454,
      "Mrmrs": "omnis",
      "Firstname": "Verna",
      "Lastname": "Schinner",
      "MiddleName": "Johnson Group",
      "Title": "mollitia",
      "Description": "Inverse 6th generation focus group",
      "Email": "ludwig@hilpert.name",
      "FullName": "Josephine Bayer",
      "DirectPhone": "1-484-654-1710",
      "FormalName": "Schmeler, Johns and Hansen",
      "CountryId": 498,
      "ContactId": 496,
      "ContactName": "Okuneva-Kessler",
      "Retired": 158,
      "Rank": 964,
      "ActiveInterests": 689,
      "ContactDepartment": "",
      "ContactCountryId": 356,
      "ContactOrgNr": "1447982",
      "FaxPhone": "227.688.6475 x624",
      "MobilePhone": "483-573-0283 x207",
      "ContactPhone": "1-721-878-7532",
      "AssociateName": "Schuppe, Rogahn and Spencer",
      "AssociateId": 633,
      "UsePersonAddress": false,
      "ContactFax": "molestiae",
      "Kanafname": "qui",
      "Kanalname": "quibusdam",
      "Post1": "id",
      "Post2": "commodi",
      "Post3": "accusantium",
      "EmailName": "francisca@stiedemannbosco.ca",
      "ContactFullName": "Lavern Jenkins",
      "ActiveErpLinks": 725,
      "TicketPriorityId": 360,
      "SupportLanguageId": 535,
      "SupportAssociateId": 585,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 832
        }
      }
    },
    "CustomerAlias": "est",
    "CustomerHost": "tempore",
    "CustomerName": "O'Conner, Terry and Carter",
    "CustomerEmail": "mohammad@weimann.ca",
    "CustomerPhone": "720-786-1104 x003",
    "CustomerConsented": true,
    "CustomerCompanyName": "Goodwin-Glover",
    "Status": "Closed",
    "FirstMessage": "facere",
    "LastMessage": "ex",
    "WhenRequested": "2011-06-06T15:05:41.6710023+02:00",
    "WhenStarted": "2002-03-17T15:05:41.6710023+01:00",
    "WhenEnded": "2006-09-30T15:05:41.6710023+02:00",
    "WhenIdle": "2001-06-11T15:05:41.6710023+02:00",
    "WhenFetched": "1996-02-07T15:05:41.6710023+01:00",
    "SessionKey": "quisquam",
    "InitialQueuePos": 659,
    "AlertLevel": 992,
    "Rank": 622,
    "Flags": "CustomerIsTyping",
    "Contact": {
      "ContactId": 91,
      "Name": "Nikolaus, Larkin and Donnelly",
      "OrgNr": "1200957",
      "Department": "",
      "URL": "http://www.example.com/",
      "City": "quidem",
      "DirectPhone": "(576)026-6426 x148",
      "AssociateId": 295,
      "CountryId": 315,
      "EmailAddress": "pearline@jenkinshirthe.ca",
      "Kananame": "eius",
      "EmailAddressName": "gene@rosenbaum.ca",
      "URLName": "http://www.example.com/",
      "AssociateFullName": "Dario Rau",
      "BusinessName": "Information Technology",
      "CategoryName": "VIP Customer",
      "CountryName": "Sokovia",
      "Address": {},
      "FormattedAddress": "sed",
      "FullName": "Allene Walker",
      "IsOwnerContact": false,
      "ActiveErpLinks": 15,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 97
        }
      }
    },
    "Project": {
      "ProjectId": 948,
      "Name": "Rippin Inc and Sons",
      "Description": "Team-oriented next generation installation",
      "URL": "http://www.example.com/",
      "Type": "expedita",
      "AssociateId": 262,
      "AssociateFullName": "Camden McDermott",
      "TypeId": 365,
      "Updated": "2004-05-06T15:05:41.6720025+02:00",
      "StatusId": 364,
      "Status": "mollitia",
      "TextId": 512,
      "PublishTo": "2002-10-19T15:05:41.6720025+02:00",
      "PublishFrom": "2011-01-04T15:05:41.6720025+01:00",
      "IsPublished": false,
      "URLName": "http://www.example.com/",
      "ProjectNumber": "1739764",
      "ActiveErpLinks": 175,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "transition next-generation niches"
          },
          "FieldType": "System.Int32",
          "FieldLength": 45
        }
      }
    },
    "Sale": {
      "ContactName": "Cassin LLC",
      "SaleDate": "2019-09-06T15:05:41.6720025+02:00",
      "SaleId": 125,
      "Probability": 536,
      "Title": "nostrum",
      "Amount": 1629.6799999999998,
      "Currency": "in",
      "ProjectName": "Willms-Witting",
      "AssociateFullName": "Maribel Green I",
      "Description": "Business-focused fault-tolerant toolset",
      "Status": "Lost",
      "WeightedAmount": 22116.638,
      "ProjectId": 37,
      "EarningPercent": 17597.41,
      "Earning": 23273.084,
      "ContactId": 52,
      "AssociateId": 311,
      "PersonId": 566,
      "SaleTypeId": 636,
      "SaleTypeName": "Gerhold Group",
      "PersonFullName": "Arnoldo Klocko",
      "Completed": "Completed",
      "ActiveErpLinks": 562,
      "NextDueDate": "2015-02-20T15:05:41.6720025+01:00",
      "Number": "822439",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 338
        }
      }
    },
    "Ticket": {
      "TicketId": 290,
      "Title": "sed",
      "CreatedAt": "2010-02-28T15:05:41.6720025+01:00",
      "LastChanged": "2008-10-21T15:05:41.6720025+02:00",
      "ReadByOwner": "2005-10-01T15:05:41.6720025+02:00",
      "ReadByCustomer": "2004-06-14T15:05:41.6720025+02:00",
      "FirstReadByUser": "2012-06-26T15:05:41.6720025+02:00",
      "Activate": "1994-05-16T15:05:41.6720025+02:00",
      "ClosedAt": "2019-06-27T15:05:41.6720025+02:00",
      "RepliedAt": "2011-03-21T15:05:41.6720025+01:00",
      "AlertTimeout": "2010-03-02T15:05:41.6720025+01:00",
      "Deadline": "2012-01-21T15:05:41.6720025+01:00",
      "CreatedBy": 512,
      "CreatedByName": "Kshlerin-Thompson",
      "Author": "esse",
      "OwnedBy": 273,
      "OwnedByName": "McCullough Inc and Sons",
      "Category": 890,
      "CategoryName": "VIP Customer",
      "CategoryFullname": "VIP Customer",
      "Slevel": "External",
      "Priority": 704,
      "PriorityName": "Wolf, O'Connell and Wyman",
      "BaseStatus": "Active",
      "TicketStatus": 49,
      "TicketStatusDisplayValue": "cumque",
      "Origin": "AutoGenerated",
      "CustId": 709,
      "PersonFirstname": "Rosendo",
      "PersonMiddleName": "Botsford, Becker and Kunde",
      "PersonLastname": "Walker",
      "PersonFullname": "dolorem",
      "AlertLevel": 703,
      "ConnectId": 41,
      "ReadStatus": "Green",
      "TimeToReply": 51,
      "RealTimeToReply": 859,
      "TimeToClose": 934,
      "RealTimeToClose": 528,
      "TimeSpentInternally": 493,
      "TimeSpentExternally": 221,
      "TimeSpentQueue": 722,
      "RealTimeSpentInternally": 21,
      "RealTimeSpentExternally": 706,
      "RealTimeSpentQueue": 981,
      "HasAttachment": true,
      "NumReplies": 726,
      "NumMessages": 769,
      "FromAddress": "et",
      "ContactId": 689,
      "ContactName": "Hartmann LLC",
      "OwnedByAssociateId": 708,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 637
        }
      }
    },
    "TransferTo": {
      "AssociateId": 993,
      "Name": "Hettinger-Ryan",
      "PersonId": 396,
      "Rank": 710,
      "Tooltip": "amet",
      "Type": "AnonymousAssociate",
      "GroupIdx": 79,
      "FullName": "Blair Rau",
      "FormalName": "Funk-Shields",
      "Deleted": false,
      "EjUserId": 681,
      "UserName": "Rempel-Lemke",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 845
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
        "FieldLength": 813
      }
    }
  }
]
```