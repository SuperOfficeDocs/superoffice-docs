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
    "ChatSessionId": 558,
    "TopicId": 488,
    "User": {
      "AssociateId": 175,
      "Name": "Harris-Reynolds",
      "PersonId": 683,
      "Rank": 139,
      "Tooltip": "iste",
      "Type": "AnonymousAssociate",
      "GroupIdx": 4,
      "FullName": "Lurline Vandervort",
      "FormalName": "Lindgren, Funk and Vandervort",
      "Deleted": true,
      "EjUserId": 410,
      "UserName": "McClure-Kreiger",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 884
        }
      }
    },
    "Person": {
      "Position": "sunt",
      "PersonId": 937,
      "Mrmrs": "at",
      "Firstname": "Willard",
      "Lastname": "Conn",
      "MiddleName": "Bernier-Kub",
      "Title": "et",
      "Description": "Centralized responsive software",
      "Email": "matteo_smitham@greenfelder.co.uk",
      "FullName": "Luciano Gutkowski",
      "DirectPhone": "866.507.6151",
      "FormalName": "Anderson LLC",
      "CountryId": 336,
      "ContactId": 678,
      "ContactName": "Gottlieb Inc and Sons",
      "Retired": 208,
      "Rank": 617,
      "ActiveInterests": 529,
      "ContactDepartment": "",
      "ContactCountryId": 788,
      "ContactOrgNr": "1735950",
      "FaxPhone": "(545)751-6863 x73520",
      "MobilePhone": "1-147-738-1762 x3651",
      "ContactPhone": "1-751-124-6483 x55227",
      "AssociateName": "Walsh-McLaughlin",
      "AssociateId": 821,
      "UsePersonAddress": false,
      "ContactFax": "accusantium",
      "Kanafname": "quas",
      "Kanalname": "veniam",
      "Post1": "sed",
      "Post2": "dolor",
      "Post3": "nostrum",
      "EmailName": "janelle_sanford@bernierroberts.com",
      "ContactFullName": "Vidal Stamm",
      "ActiveErpLinks": 495,
      "TicketPriorityId": 798,
      "SupportLanguageId": 297,
      "SupportAssociateId": 908,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 508
        }
      }
    },
    "CustomerAlias": "voluptas",
    "CustomerHost": "dolorum",
    "CustomerName": "Legros, Olson and Mayert",
    "CustomerEmail": "nicolette_dickens@heathcote.co.uk",
    "CustomerPhone": "301-775-1215 x63311",
    "CustomerConsented": false,
    "CustomerCompanyName": "Trantow LLC",
    "Status": "Closed",
    "FirstMessage": "et",
    "LastMessage": "vel",
    "WhenRequested": "2008-05-31T18:25:50.0585635+02:00",
    "WhenStarted": "2001-07-10T18:25:50.0585635+02:00",
    "WhenEnded": "2009-08-13T18:25:50.0585635+02:00",
    "WhenIdle": "1998-12-13T18:25:50.0585635+01:00",
    "WhenFetched": "2000-09-23T18:25:50.0585635+02:00",
    "SessionKey": "voluptatem",
    "InitialQueuePos": 535,
    "AlertLevel": 173,
    "Rank": 78,
    "Flags": "CustomerIsTyping",
    "Contact": {
      "ContactId": 813,
      "Name": "O'Hara-Franecki",
      "OrgNr": "641870",
      "Department": "",
      "URL": "http://www.example.com/",
      "City": "et",
      "DirectPhone": "255.347.4718 x27330",
      "AssociateId": 167,
      "CountryId": 294,
      "EmailAddress": "jayson.daniel@gulgowski.uk",
      "Kananame": "fuga",
      "EmailAddressName": "dannie_lueilwitz@handstiedemann.com",
      "URLName": "http://www.example.com/",
      "AssociateFullName": "Dr. Ian Fisher",
      "BusinessName": "Information Technology",
      "CategoryName": "VIP Customer",
      "CountryName": "Sokovia",
      "Address": {},
      "FormattedAddress": "cumque",
      "FullName": "Alize Boyer",
      "IsOwnerContact": true,
      "ActiveErpLinks": 969,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 61
        }
      }
    },
    "Project": {
      "ProjectId": 126,
      "Name": "Dicki, Koelpin and Satterfield",
      "Description": "Centralized eco-centric protocol",
      "URL": "http://www.example.com/",
      "Type": "esse",
      "AssociateId": 255,
      "AssociateFullName": "Kristofer Lueilwitz",
      "TypeId": 427,
      "Updated": "1997-11-07T18:25:50.0595631+01:00",
      "StatusId": 522,
      "Status": "fugit",
      "TextId": 985,
      "PublishTo": "2012-03-05T18:25:50.0595631+01:00",
      "PublishFrom": "1998-07-09T18:25:50.0595631+02:00",
      "IsPublished": true,
      "URLName": "http://www.example.com/",
      "ProjectNumber": "1425848",
      "ActiveErpLinks": 452,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 438
        }
      }
    },
    "Sale": {
      "ContactName": "Harris, Kuphal and Cummings",
      "SaleDate": "2009-07-11T18:25:50.0595631+02:00",
      "SaleId": 814,
      "Probability": 203,
      "Title": "beatae",
      "Amount": 5308.996,
      "Currency": "repellat",
      "ProjectName": "Shanahan-Maggio",
      "AssociateFullName": "Brooklyn Kub",
      "Description": "Progressive bifurcated hierarchy",
      "Status": "Lost",
      "WeightedAmount": 5528.376,
      "ProjectId": 163,
      "EarningPercent": 22072.762,
      "Earning": 8468.068,
      "ContactId": 434,
      "AssociateId": 526,
      "PersonId": 704,
      "SaleTypeId": 330,
      "SaleTypeName": "Cassin, Adams and Luettgen",
      "PersonFullName": "Thaddeus Gutmann",
      "Completed": "Completed",
      "ActiveErpLinks": 104,
      "NextDueDate": "2005-02-14T18:25:50.0595631+01:00",
      "Number": "1336766",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 358
        }
      }
    },
    "Ticket": {
      "TicketId": 412,
      "Title": "aspernatur",
      "CreatedAt": "1998-03-07T18:25:50.0605638+01:00",
      "LastChanged": "2013-05-25T18:25:50.0605638+02:00",
      "ReadByOwner": "2004-06-13T18:25:50.0605638+02:00",
      "ReadByCustomer": "2007-05-18T18:25:50.0605638+02:00",
      "FirstReadByUser": "2003-10-20T18:25:50.0605638+02:00",
      "Activate": "1994-10-24T18:25:50.0605638+02:00",
      "ClosedAt": "2016-12-28T18:25:50.0605638+01:00",
      "RepliedAt": "2017-08-09T18:25:50.0605638+02:00",
      "AlertTimeout": "2012-08-16T18:25:50.0605638+02:00",
      "Deadline": "2009-03-17T18:25:50.0605638+01:00",
      "CreatedBy": 183,
      "CreatedByName": "Padberg-Crona",
      "Author": "non",
      "OwnedBy": 669,
      "OwnedByName": "Torp, Halvorson and Nolan",
      "Category": 591,
      "CategoryName": "VIP Customer",
      "CategoryFullname": "VIP Customer",
      "Slevel": "External",
      "Priority": 384,
      "PriorityName": "Kohler Group",
      "BaseStatus": "Active",
      "TicketStatus": 234,
      "TicketStatusDisplayValue": "ut",
      "Origin": "AutoGenerated",
      "CustId": 949,
      "PersonFirstname": "Herbert",
      "PersonMiddleName": "Auer, Hamill and Medhurst",
      "PersonLastname": "Hegmann",
      "PersonFullname": "voluptas",
      "AlertLevel": 765,
      "ConnectId": 968,
      "ReadStatus": "Green",
      "TimeToReply": 923,
      "RealTimeToReply": 234,
      "TimeToClose": 1001,
      "RealTimeToClose": 504,
      "TimeSpentInternally": 650,
      "TimeSpentExternally": 732,
      "TimeSpentQueue": 525,
      "RealTimeSpentInternally": 366,
      "RealTimeSpentExternally": 528,
      "RealTimeSpentQueue": 169,
      "HasAttachment": true,
      "NumReplies": 279,
      "NumMessages": 586,
      "FromAddress": "rem",
      "ContactId": 196,
      "ContactName": "Stanton Group",
      "OwnedByAssociateId": 370,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 254
        }
      }
    },
    "TransferTo": {
      "AssociateId": 323,
      "Name": "Trantow, Bins and Nolan",
      "PersonId": 317,
      "Rank": 990,
      "Tooltip": "fuga",
      "Type": "AnonymousAssociate",
      "GroupIdx": 463,
      "FullName": "Jamir Grady",
      "FormalName": "Kuphal, Kihn and Wyman",
      "Deleted": true,
      "EjUserId": 782,
      "UserName": "Lynch, Keeling and Bergnaum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "seize interactive networks"
          },
          "FieldType": "System.String",
          "FieldLength": 837
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
        "FieldLength": 452
      }
    }
  }
]
```