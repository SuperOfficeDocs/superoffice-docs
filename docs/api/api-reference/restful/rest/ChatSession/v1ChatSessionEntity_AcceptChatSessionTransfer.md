---
title: POST ChatSession/{id}/AcceptTransfer
id: v1ChatSessionEntity_AcceptChatSessionTransfer
---

# POST ChatSession/{id}/AcceptTransfer

```http
POST /api/v1/ChatSession/{chatSessionId}/AcceptTransfer
```

Accept the transfer: assign the session to the user.

If the session is not being transferred, nothing happens.




| Path Part | Type | Description |
|-----------|------|-------------|
| chatSessionId | int32 | id of the chat session to send **Required** |



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
POST /api/v1/ChatSession/{chatSessionId}/AcceptTransfer
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 192,
  "TopicId": 821,
  "User": {
    "AssociateId": 41,
    "Name": "Gerlach-D'Amore",
    "PersonId": 46,
    "Rank": 386,
    "Tooltip": "praesentium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 843,
    "FullName": "Marguerite Heaney",
    "FormalName": "Runolfsson, Terry and Reichert",
    "Deleted": false,
    "EjUserId": 729,
    "UserName": "Schinner, Gleason and Torphy",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 62
      }
    }
  },
  "Person": {
    "Position": "sit",
    "PersonId": 263,
    "Mrmrs": "dolore",
    "Firstname": "Minerva",
    "Lastname": "Kovacek",
    "MiddleName": "Stoltenberg LLC",
    "Title": "veniam",
    "Description": "Persistent executive encoding",
    "Email": "alvina.shanahan@rath.ca",
    "FullName": "Sidney Bernier",
    "DirectPhone": "(065)340-2611 x228",
    "FormalName": "Kulas, Ullrich and Hahn",
    "CountryId": 154,
    "ContactId": 529,
    "ContactName": "Hilll LLC",
    "Retired": 655,
    "Rank": 843,
    "ActiveInterests": 459,
    "ContactDepartment": "",
    "ContactCountryId": 918,
    "ContactOrgNr": "386680",
    "FaxPhone": "461-243-2101 x25147",
    "MobilePhone": "711.515.3804",
    "ContactPhone": "1-685-186-2540",
    "AssociateName": "Johns, Bednar and Okuneva",
    "AssociateId": 101,
    "UsePersonAddress": true,
    "ContactFax": "eos",
    "Kanafname": "laboriosam",
    "Kanalname": "aperiam",
    "Post1": "asperiores",
    "Post2": "magni",
    "Post3": "rerum",
    "EmailName": "fern.cronin@hamill.uk",
    "ContactFullName": "Elena Windler",
    "ActiveErpLinks": 865,
    "TicketPriorityId": 901,
    "SupportLanguageId": 288,
    "SupportAssociateId": 94,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 984
      }
    }
  },
  "CustomerAlias": "et",
  "CustomerHost": "beatae",
  "CustomerName": "Daugherty-West",
  "CustomerEmail": "libbie_jones@grady.com",
  "CustomerPhone": "(446)175-3564 x26170",
  "CustomerConsented": false,
  "CustomerCompanyName": "Lubowitz-Kuhn",
  "Status": "Closed",
  "FirstMessage": "temporibus",
  "LastMessage": "autem",
  "WhenRequested": "2001-03-06T09:40:58.7573759+01:00",
  "WhenStarted": "2002-01-02T09:40:58.7573759+01:00",
  "WhenEnded": "1997-07-13T09:40:58.7573759+02:00",
  "WhenIdle": "2005-09-15T09:40:58.7573759+02:00",
  "WhenFetched": "2008-11-05T09:40:58.7573759+01:00",
  "SessionKey": "quia",
  "InitialQueuePos": 312,
  "AlertLevel": 119,
  "Rank": 238,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 250,
    "Name": "Schinner-Hackett",
    "OrgNr": "1581346",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "cumque",
    "DirectPhone": "(837)377-0076 x6634",
    "AssociateId": 78,
    "CountryId": 713,
    "EmailAddress": "bertha.glover@murazik.info",
    "Kananame": "dolorum",
    "EmailAddressName": "khalil@nitzsche.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Dimitri Bernier",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "culpa",
    "FullName": "Barney Emard",
    "IsOwnerContact": true,
    "ActiveErpLinks": 539,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 343
      }
    }
  },
  "Project": {
    "ProjectId": 234,
    "Name": "Swaniawski LLC",
    "Description": "Open-source global orchestration",
    "URL": "http://www.example.com/",
    "Type": "quos",
    "AssociateId": 608,
    "AssociateFullName": "Ernest Friesen",
    "TypeId": 862,
    "Updated": "2006-11-25T09:40:58.7603761+01:00",
    "StatusId": 153,
    "Status": "sunt",
    "TextId": 678,
    "PublishTo": "2003-03-31T09:40:58.7603761+02:00",
    "PublishFrom": "2001-08-19T09:40:58.7603761+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1259427",
    "ActiveErpLinks": 534,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 343
      }
    }
  },
  "Sale": {
    "ContactName": "Gutmann-Gibson",
    "SaleDate": "2008-02-12T09:40:58.7603761+01:00",
    "SaleId": 279,
    "Probability": 13,
    "Title": "consequatur",
    "Amount": 7521.5999999999995,
    "Currency": "fuga",
    "ProjectName": "Hilpert, Rutherford and Koepp",
    "AssociateFullName": "Demarcus Lynch",
    "Description": "Ergonomic needs-based budgetary management",
    "Status": "Lost",
    "WeightedAmount": 9721.668,
    "ProjectId": 842,
    "EarningPercent": 12802.39,
    "Earning": 19596.902,
    "ContactId": 423,
    "AssociateId": 571,
    "PersonId": 254,
    "SaleTypeId": 871,
    "SaleTypeName": "Gerhold Group",
    "PersonFullName": "Mr. Eliseo Hermann",
    "Completed": "Completed",
    "ActiveErpLinks": 974,
    "NextDueDate": "1997-12-31T09:40:58.7603761+01:00",
    "Number": "506349",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 662
      }
    }
  },
  "Ticket": {
    "TicketId": 344,
    "Title": "quia",
    "CreatedAt": "2019-05-12T09:40:58.7603761+02:00",
    "LastChanged": "2013-07-04T09:40:58.7603761+02:00",
    "ReadByOwner": "2001-09-13T09:40:58.7603761+02:00",
    "ReadByCustomer": "1995-09-30T09:40:58.7603761+02:00",
    "FirstReadByUser": "2019-09-11T09:40:58.7603761+02:00",
    "Activate": "2015-07-29T09:40:58.7603761+02:00",
    "ClosedAt": "1995-11-10T09:40:58.7603761+01:00",
    "RepliedAt": "1993-12-24T09:40:58.7603761+01:00",
    "AlertTimeout": "2009-08-31T09:40:58.7603761+02:00",
    "Deadline": "2019-04-21T09:40:58.7603761+02:00",
    "CreatedBy": 654,
    "CreatedByName": "Schiller-Lubowitz",
    "Author": "voluptate",
    "OwnedBy": 369,
    "OwnedByName": "Heidenreich Group",
    "Category": 165,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 403,
    "BaseStatus": "Active",
    "TicketStatus": 393,
    "Origin": "AutoGenerated",
    "CustId": 792,
    "CustFirstname": "Mallory",
    "CustMiddleName": "Schamberger-Rogahn",
    "CustLastname": "Goyette",
    "AlertLevel": 385,
    "ConnectId": 395,
    "ReadStatus": "Green",
    "TimeToReply": 589,
    "RealTimeToReply": 537,
    "TimeToClose": 329,
    "RealTimeToClose": 904,
    "TimeSpentInternally": 819,
    "TimeSpentExternally": 158,
    "TimeSpentQueue": 307,
    "RealTimeSpentInternally": 935,
    "RealTimeSpentExternally": 781,
    "RealTimeSpentQueue": 322,
    "HasAttachment": true,
    "NumReplies": 371,
    "NumMessages": 791,
    "FromAddress": "molestias",
    "CustFullname": "dolorum",
    "TicketStatusDisplayValue": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 127
      }
    }
  },
  "TransferTo": {
    "AssociateId": 541,
    "Name": "Jewess-Gerlach",
    "PersonId": 601,
    "Rank": 635,
    "Tooltip": "quis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 400,
    "FullName": "Otho Swaniawski",
    "FormalName": "Collins LLC",
    "Deleted": false,
    "EjUserId": 860,
    "UserName": "Mraz Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "implement one-to-one e-business"
        },
        "FieldType": "System.Int32",
        "FieldLength": 128
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
      "FieldLength": 412
    }
  }
}
```