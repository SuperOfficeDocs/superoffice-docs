---
title: POST Agents/Chat/CreateDefaultChatSessionEntity
id: v1ChatAgent_CreateDefaultChatSessionEntity
---

# POST Agents/Chat/CreateDefaultChatSessionEntity

```http
POST /api/v1/Agents/Chat/CreateDefaultChatSessionEntity
```

Set default values into a new ChatSessionEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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
POST /api/v1/Agents/Chat/CreateDefaultChatSessionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 675,
  "TopicId": 200,
  "User": {
    "AssociateId": 507,
    "Name": "Beer Inc and Sons",
    "PersonId": 328,
    "Rank": 497,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 895,
    "FullName": "Miss Lavonne Buckridge",
    "FormalName": "Farrell, Frami and Pfeffer",
    "Deleted": true,
    "EjUserId": 619,
    "UserName": "Wintheiser, Hahn and Schuster",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 268
      }
    }
  },
  "Person": {
    "Position": "reprehenderit",
    "PersonId": 339,
    "Mrmrs": "vero",
    "Firstname": "Cornell",
    "Lastname": "Becker",
    "MiddleName": "Jones-Hodkiewicz",
    "Title": "quia",
    "Description": "Vision-oriented explicit capability",
    "Email": "mabelle@heaney.ca",
    "FullName": "Charlene Jerde",
    "DirectPhone": "(348)253-1758",
    "FormalName": "Stehr-Von",
    "CountryId": 391,
    "ContactId": 61,
    "ContactName": "Schneider-Stroman",
    "Retired": 931,
    "Rank": 126,
    "ActiveInterests": 621,
    "ContactDepartment": "",
    "ContactCountryId": 822,
    "ContactOrgNr": "456484",
    "FaxPhone": "(537)061-7774 x41730",
    "MobilePhone": "624.788.7766",
    "ContactPhone": "238-650-6668",
    "AssociateName": "Cronin-Huel",
    "AssociateId": 22,
    "UsePersonAddress": true,
    "ContactFax": "perspiciatis",
    "Kanafname": "et",
    "Kanalname": "occaecati",
    "Post1": "iusto",
    "Post2": "mollitia",
    "Post3": "autem",
    "EmailName": "marilie_wyman@zulauf.ca",
    "ContactFullName": "Reta Schinner",
    "ActiveErpLinks": 875,
    "TicketPriorityId": 128,
    "SupportLanguageId": 123,
    "SupportAssociateId": 696,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 68
      }
    }
  },
  "CustomerAlias": "omnis",
  "CustomerHost": "quis",
  "CustomerName": "Smitham Inc and Sons",
  "CustomerEmail": "monica.abernathy@casper.biz",
  "CustomerPhone": "008.214.4666 x1487",
  "CustomerConsented": false,
  "CustomerCompanyName": "Lehner LLC",
  "Status": "Closed",
  "FirstMessage": "vitae",
  "LastMessage": "dolore",
  "WhenRequested": "2017-04-15T16:48:28.8599243+02:00",
  "WhenStarted": "2014-11-30T16:48:28.8599243+01:00",
  "WhenEnded": "2013-03-27T16:48:28.8599243+01:00",
  "WhenIdle": "2016-02-08T16:48:28.8599243+01:00",
  "WhenFetched": "2012-04-20T16:48:28.8599243+02:00",
  "SessionKey": "sint",
  "InitialQueuePos": 674,
  "AlertLevel": 70,
  "Rank": 439,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 660,
    "Name": "Gerlach Group",
    "OrgNr": "1508183",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "laborum",
    "DirectPhone": "656.847.6500 x667",
    "AssociateId": 827,
    "CountryId": 47,
    "EmailAddress": "elaina.huel@blick.co.uk",
    "Kananame": "dolorem",
    "EmailAddressName": "trystan@mosciski.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Margarette Konopelski",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "sint",
    "FullName": "Reba Macejkovic",
    "IsOwnerContact": false,
    "ActiveErpLinks": 79,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 932
      }
    }
  },
  "Project": {
    "ProjectId": 403,
    "Name": "Schuppe-Bauch",
    "Description": "Front-line bifurcated open architecture",
    "URL": "http://www.example.com/",
    "Type": "et",
    "AssociateId": 581,
    "AssociateFullName": "Claude Rice",
    "TypeId": 64,
    "Updated": "1997-10-10T16:48:28.8609311+02:00",
    "StatusId": 108,
    "Status": "earum",
    "TextId": 791,
    "PublishTo": "2002-02-28T16:48:28.8609311+01:00",
    "PublishFrom": "2020-04-23T16:48:28.8609311+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "776140",
    "ActiveErpLinks": 352,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 500
      }
    }
  },
  "Sale": {
    "ContactName": "Bradtke, Prosacco and Watsica",
    "SaleDate": "2014-10-11T16:48:28.8609311+02:00",
    "SaleId": 46,
    "Probability": 508,
    "Title": "in",
    "Amount": 25839.829999999998,
    "Currency": "enim",
    "ProjectName": "Daniel Group",
    "AssociateFullName": "Mrs. Katelynn Roob",
    "Description": "Reactive motivating artificial intelligence",
    "Status": "Lost",
    "WeightedAmount": 17503.39,
    "ProjectId": 957,
    "EarningPercent": 28111.98,
    "Earning": 6738.0999999999995,
    "ContactId": 80,
    "AssociateId": 402,
    "PersonId": 693,
    "SaleTypeId": 302,
    "SaleTypeName": "Steuber, Swift and Kuphal",
    "PersonFullName": "Roslyn Gerhold",
    "Completed": "Completed",
    "ActiveErpLinks": 19,
    "NextDueDate": "2011-08-25T16:48:28.8619239+02:00",
    "Number": "657151",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 713
      }
    }
  },
  "Ticket": {
    "TicketId": 15,
    "Title": "ut",
    "CreatedAt": "2020-07-03T16:48:28.8619239+02:00",
    "LastChanged": "2008-09-05T16:48:28.8619239+02:00",
    "ReadByOwner": "2005-05-05T16:48:28.8619239+02:00",
    "ReadByCustomer": "2017-09-17T16:48:28.8619239+02:00",
    "FirstReadByUser": "1997-08-15T16:48:28.8619239+02:00",
    "Activate": "1996-08-30T16:48:28.8619239+02:00",
    "ClosedAt": "2020-01-07T16:48:28.8619239+01:00",
    "RepliedAt": "2017-04-07T16:48:28.8619239+02:00",
    "AlertTimeout": "1994-06-19T16:48:28.8619239+02:00",
    "Deadline": "2011-12-16T16:48:28.8619239+01:00",
    "CreatedBy": 831,
    "CreatedByName": "Kihn-Torphy",
    "Author": "ut",
    "OwnedBy": 456,
    "OwnedByName": "Osinski-Jaskolski",
    "Category": 226,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 50,
    "BaseStatus": "Active",
    "TicketStatus": 356,
    "Origin": "AutoGenerated",
    "CustId": 705,
    "CustFirstname": "Trevor",
    "CustMiddleName": "Mante, Denesik and Douglas",
    "CustLastname": "Monahan",
    "AlertLevel": 57,
    "ConnectId": 666,
    "ReadStatus": "Green",
    "TimeToReply": 230,
    "RealTimeToReply": 728,
    "TimeToClose": 13,
    "RealTimeToClose": 605,
    "TimeSpentInternally": 438,
    "TimeSpentExternally": 706,
    "TimeSpentQueue": 282,
    "RealTimeSpentInternally": 163,
    "RealTimeSpentExternally": 189,
    "RealTimeSpentQueue": 923,
    "HasAttachment": false,
    "NumReplies": 512,
    "NumMessages": 594,
    "FromAddress": "recusandae",
    "CustFullname": "laboriosam",
    "TicketStatusDisplayValue": "quia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 776
      }
    }
  },
  "TransferTo": {
    "AssociateId": 487,
    "Name": "Braun Inc and Sons",
    "PersonId": 411,
    "Rank": 155,
    "Tooltip": "illum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 224,
    "FullName": "Blaze Reinger",
    "FormalName": "Bernhard-Wiza",
    "Deleted": false,
    "EjUserId": 787,
    "UserName": "Lockman, Keeling and Maggio",
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
      "FieldLength": 434
    }
  }
}
```