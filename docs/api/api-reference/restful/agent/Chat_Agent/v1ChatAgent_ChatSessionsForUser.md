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
    "ChatSessionId": 989,
    "TopicId": 375,
    "User": {
      "AssociateId": 350,
      "Name": "Hackett LLC",
      "PersonId": 535,
      "Rank": 868,
      "Tooltip": "repellat",
      "Type": "AnonymousAssociate",
      "GroupIdx": 1001,
      "FullName": "Miss Preston Gutmann",
      "FormalName": "Muller, Harvey and Auer",
      "Deleted": true,
      "EjUserId": 612,
      "UserName": "Carroll, Bailey and Bogisich",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 579
        }
      }
    },
    "Person": {
      "Position": "nihil",
      "PersonId": 730,
      "Mrmrs": "et",
      "Firstname": "Josianne",
      "Lastname": "Mraz",
      "MiddleName": "Halvorson-Nader",
      "Title": "magnam",
      "Description": "Synergized mobile focus group",
      "Email": "misael@will.name",
      "FullName": "Allison McDermott V",
      "DirectPhone": "422.188.1426",
      "FormalName": "Homenick Group",
      "CountryId": 283,
      "ContactId": 685,
      "ContactName": "Hackett Group",
      "Retired": 229,
      "Rank": 9,
      "ActiveInterests": 739,
      "ContactDepartment": "",
      "ContactCountryId": 774,
      "ContactOrgNr": "1177984",
      "FaxPhone": "525-551-0403 x2067",
      "MobilePhone": "1-235-832-6777",
      "ContactPhone": "1-355-244-7237",
      "AssociateName": "Mitchell, Boehm and Champlin",
      "AssociateId": 298,
      "UsePersonAddress": true,
      "ContactFax": "exercitationem",
      "Kanafname": "numquam",
      "Kanalname": "in",
      "Post1": "quam",
      "Post2": "quia",
      "Post3": "accusantium",
      "EmailName": "trevor@schulistschneider.us",
      "ContactFullName": "Janick Towne",
      "ActiveErpLinks": 742,
      "TicketPriorityId": 930,
      "SupportLanguageId": 750,
      "SupportAssociateId": 239,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 383
        }
      }
    },
    "CustomerAlias": "sint",
    "CustomerHost": "ipsa",
    "CustomerName": "Jacobs LLC",
    "CustomerEmail": "leon.williamson@erdman.ca",
    "CustomerPhone": "833-176-3734 x31848",
    "CustomerConsented": false,
    "CustomerCompanyName": "Borer LLC",
    "Status": "Closed",
    "FirstMessage": "ut",
    "LastMessage": "maiores",
    "WhenRequested": "1995-09-23T16:48:28.9029243+02:00",
    "WhenStarted": "2015-11-06T16:48:28.9029243+01:00",
    "WhenEnded": "1995-01-24T16:48:28.9029243+01:00",
    "WhenIdle": "1998-08-04T16:48:28.9029243+02:00",
    "WhenFetched": "2001-03-13T16:48:28.9029243+01:00",
    "SessionKey": "laboriosam",
    "InitialQueuePos": 642,
    "AlertLevel": 140,
    "Rank": 407,
    "Flags": "CustomerIsTyping",
    "Contact": {
      "ContactId": 79,
      "Name": "Gerhold, Wolf and Rolfson",
      "OrgNr": "690743",
      "Department": "",
      "URL": "http://www.example.com/",
      "City": "magni",
      "DirectPhone": "1-570-112-5475 x7315",
      "AssociateId": 809,
      "CountryId": 515,
      "EmailAddress": "marcia@reinger.ca",
      "Kananame": "quo",
      "EmailAddressName": "orland.turner@rueckerlemke.biz",
      "URLName": "http://www.example.com/",
      "AssociateFullName": "Dandre Maggio",
      "BusinessName": "Information Technology",
      "CategoryName": "VIP Customer",
      "CountryName": "Sokovia",
      "Address": {},
      "FormattedAddress": "dolor",
      "FullName": "Jayson Bailey",
      "IsOwnerContact": true,
      "ActiveErpLinks": 591,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 545
        }
      }
    },
    "Project": {
      "ProjectId": 68,
      "Name": "Welch-Williamson",
      "Description": "Cross-platform actuating neural-net",
      "URL": "http://www.example.com/",
      "Type": "libero",
      "AssociateId": 63,
      "AssociateFullName": "Cortez Kshlerin",
      "TypeId": 408,
      "Updated": "2015-09-24T16:48:28.9039243+02:00",
      "StatusId": 727,
      "Status": "sunt",
      "TextId": 128,
      "PublishTo": "2015-09-05T16:48:28.9039243+02:00",
      "PublishFrom": "2006-11-27T16:48:28.9039243+01:00",
      "IsPublished": false,
      "URLName": "http://www.example.com/",
      "ProjectNumber": "730161",
      "ActiveErpLinks": 734,
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
    "Sale": {
      "ContactName": "Armstrong-Connelly",
      "SaleDate": "2004-01-18T16:48:28.9039243+01:00",
      "SaleId": 124,
      "Probability": 713,
      "Title": "sapiente",
      "Amount": 19728.53,
      "Currency": "rem",
      "ProjectName": "Klein, Lubowitz and Kutch",
      "AssociateFullName": "Kevin Boyer",
      "Description": "Centralized solution-oriented emulation",
      "Status": "Lost",
      "WeightedAmount": 14544.894,
      "ProjectId": 736,
      "EarningPercent": 156.7,
      "Earning": 636.202,
      "ContactId": 101,
      "AssociateId": 337,
      "PersonId": 254,
      "SaleTypeId": 227,
      "SaleTypeName": "Terry-Kuvalis",
      "PersonFullName": "Damion Bayer",
      "Completed": "Completed",
      "ActiveErpLinks": 585,
      "NextDueDate": "2011-04-24T16:48:28.904924+02:00",
      "Number": "1156630",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 656
        }
      }
    },
    "Ticket": {
      "TicketId": 212,
      "Title": "velit",
      "CreatedAt": "2006-07-22T16:48:28.904924+02:00",
      "LastChanged": "2009-12-05T16:48:28.904924+01:00",
      "ReadByOwner": "2016-10-08T16:48:28.904924+02:00",
      "ReadByCustomer": "2009-11-09T16:48:28.904924+01:00",
      "FirstReadByUser": "2018-04-06T16:48:28.904924+02:00",
      "Activate": "2011-10-04T16:48:28.904924+02:00",
      "ClosedAt": "2009-06-03T16:48:28.904924+02:00",
      "RepliedAt": "1998-10-20T16:48:28.904924+02:00",
      "AlertTimeout": "2006-02-06T16:48:28.904924+01:00",
      "Deadline": "2010-02-10T16:48:28.904924+01:00",
      "CreatedBy": 624,
      "CreatedByName": "Moore LLC",
      "Author": "ea",
      "OwnedBy": 27,
      "OwnedByName": "Kuhic-Runte",
      "Category": 332,
      "CategoryName": "VIP Customer",
      "CategoryFullname": "VIP Customer",
      "Slevel": "External",
      "Priority": 584,
      "BaseStatus": "Active",
      "TicketStatus": 736,
      "Origin": "AutoGenerated",
      "CustId": 363,
      "CustFirstname": "Josiane",
      "CustMiddleName": "Anderson Inc and Sons",
      "CustLastname": "Schimmel",
      "AlertLevel": 953,
      "ConnectId": 687,
      "ReadStatus": "Green",
      "TimeToReply": 841,
      "RealTimeToReply": 64,
      "TimeToClose": 198,
      "RealTimeToClose": 770,
      "TimeSpentInternally": 160,
      "TimeSpentExternally": 256,
      "TimeSpentQueue": 406,
      "RealTimeSpentInternally": 494,
      "RealTimeSpentExternally": 292,
      "RealTimeSpentQueue": 962,
      "HasAttachment": true,
      "NumReplies": 84,
      "NumMessages": 60,
      "FromAddress": "non",
      "CustFullname": "inventore",
      "TicketStatusDisplayValue": "ullam",
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
    "TransferTo": {
      "AssociateId": 682,
      "Name": "Wyman, Veum and Leannon",
      "PersonId": 543,
      "Rank": 327,
      "Tooltip": "voluptatem",
      "Type": "AnonymousAssociate",
      "GroupIdx": 606,
      "FullName": "Evalyn Shields",
      "FormalName": "Harber, Langosh and Walter",
      "Deleted": false,
      "EjUserId": 293,
      "UserName": "Kovacek Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 585
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
        "FieldLength": 11
      }
    }
  }
]
```