---
title: POST Agents/Chat/PickUpFirstChatSession
id: v1ChatAgent_PickUpFirstChatSession
---

# POST Agents/Chat/PickUpFirstChatSession

```http
POST /api/v1/Agents/Chat/PickUpFirstChatSession
```

'answer' the first available session from the queue: assign the session to the user.

The welcome message is sent to the customer.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/PickUpFirstChatSession?$select=name,department,category/id
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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Chat/PickUpFirstChatSession
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 250,
  "TopicId": 473,
  "User": {
    "AssociateId": 902,
    "Name": "Thiel Inc and Sons",
    "PersonId": 691,
    "Rank": 818,
    "Tooltip": "nisi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 60,
    "FullName": "Miss Gaylord Rosenbaum",
    "FormalName": "Price Inc and Sons",
    "Deleted": false,
    "EjUserId": 21,
    "UserName": "Hoppe-Von",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 55
      }
    }
  },
  "Person": {
    "Position": "maxime",
    "PersonId": 245,
    "Mrmrs": "libero",
    "Firstname": "Sydney",
    "Lastname": "Murphy",
    "MiddleName": "Kovacek, Hagenes and Von",
    "Title": "itaque",
    "Description": "Cross-platform tertiary policy",
    "Email": "nathanael.bergstrom@cummerata.us",
    "FullName": "Michaela Bauch",
    "DirectPhone": "085-145-1803 x31852",
    "FormalName": "Sawayn, Zieme and Veum",
    "CountryId": 894,
    "ContactId": 515,
    "ContactName": "Herzog-Pacocha",
    "Retired": 563,
    "Rank": 745,
    "ActiveInterests": 27,
    "ContactDepartment": "",
    "ContactCountryId": 568,
    "ContactOrgNr": "1653359",
    "FaxPhone": "776.466.4208 x51380",
    "MobilePhone": "744-671-2358 x565",
    "ContactPhone": "315.321.7700 x457",
    "AssociateName": "Aufderhar-Cummerata",
    "AssociateId": 321,
    "UsePersonAddress": false,
    "ContactFax": "qui",
    "Kanafname": "aut",
    "Kanalname": "voluptatibus",
    "Post1": "porro",
    "Post2": "ad",
    "Post3": "possimus",
    "EmailName": "nasir@kautzer.ca",
    "ContactFullName": "Lambert Streich",
    "ActiveErpLinks": 568,
    "TicketPriorityId": 85,
    "SupportLanguageId": 433,
    "SupportAssociateId": 477,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 736
      }
    }
  },
  "CustomerAlias": "praesentium",
  "CustomerHost": "alias",
  "CustomerName": "Barrows Group",
  "CustomerEmail": "robin@grahammohr.biz",
  "CustomerPhone": "820-684-0553 x0705",
  "CustomerConsented": false,
  "CustomerCompanyName": "Rath, Will and King",
  "Status": "Closed",
  "FirstMessage": "ea",
  "LastMessage": "illo",
  "WhenRequested": "2003-03-15T16:48:28.9899241+01:00",
  "WhenStarted": "2003-02-03T16:48:28.9899241+01:00",
  "WhenEnded": "2007-07-14T16:48:28.9899241+02:00",
  "WhenIdle": "2015-02-16T16:48:28.9899241+01:00",
  "WhenFetched": "2004-09-08T16:48:28.9899241+02:00",
  "SessionKey": "harum",
  "InitialQueuePos": 983,
  "AlertLevel": 133,
  "Rank": 966,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 163,
    "Name": "Larkin-Goodwin",
    "OrgNr": "1479979",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "eius",
    "DirectPhone": "1-203-588-2186 x41802",
    "AssociateId": 954,
    "CountryId": 848,
    "EmailAddress": "madaline_bins@bechtelar.uk",
    "Kananame": "soluta",
    "EmailAddressName": "anthony.lemke@brekke.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mac Altenwerth",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "qui",
    "FullName": "Dan Mueller Jr.",
    "IsOwnerContact": true,
    "ActiveErpLinks": 425,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 860
      }
    }
  },
  "Project": {
    "ProjectId": 218,
    "Name": "Swift-Metz",
    "Description": "Versatile user-facing artificial intelligence",
    "URL": "http://www.example.com/",
    "Type": "minus",
    "AssociateId": 648,
    "AssociateFullName": "Tito Ratke",
    "TypeId": 993,
    "Updated": "2015-05-02T16:48:28.9909241+02:00",
    "StatusId": 854,
    "Status": "id",
    "TextId": 812,
    "PublishTo": "2014-08-16T16:48:28.9909241+02:00",
    "PublishFrom": "2012-05-03T16:48:28.9909241+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "719118",
    "ActiveErpLinks": 547,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 927
      }
    }
  },
  "Sale": {
    "ContactName": "O'Reilly, Russel and Fritsch",
    "SaleDate": "2016-08-20T16:48:28.9909241+02:00",
    "SaleId": 321,
    "Probability": 472,
    "Title": "repellendus",
    "Amount": 21630.868,
    "Currency": "quas",
    "ProjectName": "Gorczany LLC",
    "AssociateFullName": "Conner Lakin",
    "Description": "Proactive secondary moderator",
    "Status": "Lost",
    "WeightedAmount": 12921.482,
    "ProjectId": 54,
    "EarningPercent": 18092.582,
    "Earning": 16719.89,
    "ContactId": 574,
    "AssociateId": 982,
    "PersonId": 624,
    "SaleTypeId": 54,
    "SaleTypeName": "Conroy LLC",
    "PersonFullName": "Victor Wunsch",
    "Completed": "Completed",
    "ActiveErpLinks": 679,
    "NextDueDate": "2006-04-04T16:48:28.9909241+02:00",
    "Number": "1417481",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 609
      }
    }
  },
  "Ticket": {
    "TicketId": 739,
    "Title": "consequatur",
    "CreatedAt": "1999-01-02T16:48:28.9909241+01:00",
    "LastChanged": "1995-02-17T16:48:28.9909241+01:00",
    "ReadByOwner": "2011-11-16T16:48:28.9909241+01:00",
    "ReadByCustomer": "2012-07-05T16:48:28.9909241+02:00",
    "FirstReadByUser": "2016-10-03T16:48:28.9909241+02:00",
    "Activate": "2002-10-04T16:48:28.9909241+02:00",
    "ClosedAt": "2013-07-24T16:48:28.9909241+02:00",
    "RepliedAt": "2019-08-30T16:48:28.9909241+02:00",
    "AlertTimeout": "2014-04-29T16:48:28.9909241+02:00",
    "Deadline": "2001-07-11T16:48:28.9909241+02:00",
    "CreatedBy": 676,
    "CreatedByName": "Rodriguez-Kuhlman",
    "Author": "minus",
    "OwnedBy": 559,
    "OwnedByName": "Towne LLC",
    "Category": 318,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 547,
    "BaseStatus": "Active",
    "TicketStatus": 964,
    "Origin": "AutoGenerated",
    "CustId": 69,
    "CustFirstname": "Alejandra",
    "CustMiddleName": "Kunde, Kiehn and Smitham",
    "CustLastname": "Harber",
    "AlertLevel": 208,
    "ConnectId": 170,
    "ReadStatus": "Green",
    "TimeToReply": 712,
    "RealTimeToReply": 816,
    "TimeToClose": 981,
    "RealTimeToClose": 940,
    "TimeSpentInternally": 326,
    "TimeSpentExternally": 905,
    "TimeSpentQueue": 731,
    "RealTimeSpentInternally": 34,
    "RealTimeSpentExternally": 5,
    "RealTimeSpentQueue": 914,
    "HasAttachment": false,
    "NumReplies": 257,
    "NumMessages": 8,
    "FromAddress": "ea",
    "CustFullname": "pariatur",
    "TicketStatusDisplayValue": "ab",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 358
      }
    }
  },
  "TransferTo": {
    "AssociateId": 205,
    "Name": "Funk-Gleichner",
    "PersonId": 757,
    "Rank": 276,
    "Tooltip": "corporis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 323,
    "FullName": "Alana Roberts",
    "FormalName": "Wiegand Inc and Sons",
    "Deleted": true,
    "EjUserId": 946,
    "UserName": "Lebsack-Beatty",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 597
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
      "FieldType": "System.Int32",
      "FieldLength": 32
    }
  }
}
```