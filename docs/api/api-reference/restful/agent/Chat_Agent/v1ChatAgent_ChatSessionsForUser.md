---
title: ChatSessionsForUser
id: v1ChatAgent_ChatSessionsForUser
---

# ChatSessionsForUser

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
    "ChatSessionId": 519,
    "TopicId": 634,
    "User": {
      "AssociateId": 16,
      "Name": "Bergstrom-Hand",
      "PersonId": 177,
      "Rank": 889,
      "Tooltip": "unde",
      "Type": "AnonymousAssociate",
      "GroupIdx": 999,
      "FullName": "Miss Eleanora Pfannerstill",
      "FormalName": "Mante, Prohaska and Schultz",
      "Deleted": true,
      "EjUserId": 751,
      "UserName": "Nienow Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 361
        }
      }
    },
    "Person": {
      "Position": "voluptatem",
      "PersonId": 630,
      "Mrmrs": "dolores",
      "Firstname": "Dexter",
      "Lastname": "Cormier",
      "MiddleName": "Armstrong-Stroman",
      "Title": "deleniti",
      "Description": "Implemented fault-tolerant product",
      "Email": "eric_stehr@kuhic.name",
      "FullName": "Cydney Lubowitz",
      "DirectPhone": "435.234.4633 x7841",
      "FormalName": "Parker Group",
      "CountryId": 431,
      "ContactId": 337,
      "ContactName": "Herzog, Homenick and Ratke",
      "Retired": 461,
      "Rank": 126,
      "ActiveInterests": 80,
      "ContactDepartment": "",
      "ContactCountryId": 872,
      "ContactOrgNr": "1206761",
      "FaxPhone": "854-614-4787",
      "MobilePhone": "1-354-637-3211 x7530",
      "ContactPhone": "(012)756-1272 x8472",
      "AssociateName": "Lockman LLC",
      "AssociateId": 97,
      "UsePersonAddress": false,
      "ContactFax": "consequuntur",
      "Kanafname": "esse",
      "Kanalname": "autem",
      "Post1": "minus",
      "Post2": "illum",
      "Post3": "delectus",
      "EmailName": "kody@harveyhansen.ca",
      "ContactFullName": "Cielo Altenwerth I",
      "ActiveErpLinks": 264,
      "TicketPriorityId": 732,
      "SupportLanguageId": 388,
      "SupportAssociateId": 404,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 54
        }
      }
    },
    "CustomerAlias": "non",
    "CustomerHost": "voluptas",
    "CustomerName": "Lesch Inc and Sons",
    "CustomerEmail": "letitia.dibbert@corwin.us",
    "CustomerPhone": "(828)781-8577 x10238",
    "CustomerConsented": false,
    "CustomerCompanyName": "Daugherty, Mayer and Kilback",
    "Status": "Closed",
    "FirstMessage": "sit",
    "LastMessage": "sed",
    "WhenRequested": "1995-08-12T14:58:03.4182408+02:00",
    "WhenStarted": "2018-07-31T14:58:03.4182408+02:00",
    "WhenEnded": "2021-08-22T14:58:03.4182408+02:00",
    "WhenIdle": "2020-07-25T14:58:03.4182408+02:00",
    "WhenFetched": "2020-01-14T14:58:03.4182408+01:00",
    "SessionKey": "aperiam",
    "InitialQueuePos": 33,
    "AlertLevel": 510,
    "Rank": 501,
    "Flags": "CustomerIsTyping",
    "Contact": {
      "ContactId": 103,
      "Name": "O'Kon Inc and Sons",
      "OrgNr": "736925",
      "Department": "",
      "URL": "http://www.example.com/",
      "City": "doloribus",
      "DirectPhone": "252.212.1853 x2620",
      "AssociateId": 89,
      "CountryId": 908,
      "EmailAddress": "murray.cronin@schaden.biz",
      "Kananame": "occaecati",
      "EmailAddressName": "rodrick@donnelly.com",
      "URLName": "http://www.example.com/",
      "AssociateFullName": "Lonie Koss",
      "BusinessName": "Information Technology",
      "CategoryName": "VIP Customer",
      "CountryName": "Sokovia",
      "Address": {},
      "FormattedAddress": "aut",
      "FullName": "Henry Von",
      "IsOwnerContact": true,
      "ActiveErpLinks": 939,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 918
        }
      }
    },
    "Project": {
      "ProjectId": 627,
      "Name": "Prosacco LLC",
      "Description": "Optional local service-desk",
      "URL": "http://www.example.com/",
      "Type": "provident",
      "AssociateId": 746,
      "AssociateFullName": "Lelia Kiehn",
      "TypeId": 810,
      "Updated": "1997-11-14T14:58:03.4192404+01:00",
      "StatusId": 70,
      "Status": "quia",
      "TextId": 949,
      "PublishTo": "2005-08-03T14:58:03.4192404+02:00",
      "PublishFrom": "2007-05-27T14:58:03.4192404+02:00",
      "IsPublished": true,
      "URLName": "http://www.example.com/",
      "ProjectNumber": "769102",
      "ActiveErpLinks": 795,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 875
        }
      }
    },
    "Sale": {
      "ContactName": "Schmitt, Schiller and Gorczany",
      "SaleDate": "1998-12-20T14:58:03.4192404+01:00",
      "SaleId": 897,
      "Probability": 8,
      "Title": "nam",
      "Amount": 20035.662,
      "Currency": "sit",
      "ProjectName": "Boyle Group",
      "AssociateFullName": "Clotilde Kassulke V",
      "Description": "Automated 6th generation knowledge base",
      "Status": "Lost",
      "WeightedAmount": 30694.396,
      "ProjectId": 767,
      "EarningPercent": 12404.372,
      "Earning": 7082.84,
      "ContactId": 627,
      "AssociateId": 553,
      "PersonId": 738,
      "SaleTypeId": 695,
      "SaleTypeName": "McGlynn, Torphy and Paucek",
      "PersonFullName": "Muhammad Hansen",
      "Completed": "Completed",
      "ActiveErpLinks": 915,
      "NextDueDate": "1998-01-20T14:58:03.4192404+01:00",
      "Number": "1644061",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 505
        }
      }
    },
    "Ticket": {
      "TicketId": 304,
      "Title": "molestiae",
      "CreatedAt": "2005-05-16T14:58:03.4192404+02:00",
      "LastChanged": "2009-09-03T14:58:03.4192404+02:00",
      "ReadByOwner": "2019-10-09T14:58:03.4192404+02:00",
      "ReadByCustomer": "2016-05-18T14:58:03.4192404+02:00",
      "FirstReadByUser": "1999-04-24T14:58:03.4192404+02:00",
      "Activate": "2013-10-11T14:58:03.4192404+02:00",
      "ClosedAt": "1996-07-15T14:58:03.4192404+02:00",
      "RepliedAt": "1999-05-27T14:58:03.4192404+02:00",
      "AlertTimeout": "2007-08-13T14:58:03.4192404+02:00",
      "Deadline": "2009-10-21T14:58:03.4192404+02:00",
      "CreatedBy": 671,
      "CreatedByName": "McCullough-Ward",
      "Author": "eveniet",
      "OwnedBy": 745,
      "OwnedByName": "Jenkins Group",
      "Category": 496,
      "CategoryName": "VIP Customer",
      "CategoryFullname": "VIP Customer",
      "Slevel": "External",
      "Priority": 814,
      "PriorityName": "Dibbert, Casper and Stark",
      "BaseStatus": "Active",
      "TicketStatus": 811,
      "TicketStatusDisplayValue": "saepe",
      "Origin": "AutoGenerated",
      "CustId": 736,
      "PersonFirstname": "Litzy",
      "PersonMiddleName": "Funk Group",
      "PersonLastname": "Huels",
      "PersonFullname": "qui",
      "AlertLevel": 25,
      "ConnectId": 922,
      "ReadStatus": "Green",
      "TimeToReply": 183,
      "RealTimeToReply": 246,
      "TimeToClose": 482,
      "RealTimeToClose": 354,
      "TimeSpentInternally": 781,
      "TimeSpentExternally": 624,
      "TimeSpentQueue": 275,
      "RealTimeSpentInternally": 514,
      "RealTimeSpentExternally": 375,
      "RealTimeSpentQueue": 890,
      "HasAttachment": true,
      "NumReplies": 432,
      "NumMessages": 726,
      "FromAddress": "consequatur",
      "ContactId": 9,
      "ContactName": "Kemmer, Miller and Abernathy",
      "OwnedByAssociateId": 5,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 957
        }
      }
    },
    "TransferTo": {
      "AssociateId": 790,
      "Name": "Bogan, Hegmann and Beier",
      "PersonId": 19,
      "Rank": 763,
      "Tooltip": "inventore",
      "Type": "AnonymousAssociate",
      "GroupIdx": 459,
      "FullName": "Olaf Bernier",
      "FormalName": "Lesch, Zieme and Larson",
      "Deleted": true,
      "EjUserId": 630,
      "UserName": "Jewess LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 961
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
        "FieldLength": 398
      }
    }
  }
]
```