---
title: POST ChatSession/{id}/RejectTransfer
id: v1ChatSessionEntity_RejectChatSessionTransfer
---

# POST ChatSession/{id}/RejectTransfer

```http
POST /api/v1/ChatSession/{chatSessionId}/RejectTransfer
```

Do not want.

Deny the transfer to the user. If the session is not being transferred, nothing happens.




| Path Part | Type | Description |
|-----------|------|-------------|
| chatSessionId | int32 | id of the chat session to send back **Required** |



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
POST /api/v1/ChatSession/{chatSessionId}/RejectTransfer
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 794,
  "TopicId": 393,
  "User": {
    "AssociateId": 53,
    "Name": "Rowe Group",
    "PersonId": 686,
    "Rank": 287,
    "Tooltip": "temporibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 324,
    "FullName": "Aurelio Rutherford",
    "FormalName": "Pacocha, Terry and Sanford",
    "Deleted": false,
    "EjUserId": 517,
    "UserName": "Borer-Bergstrom",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 57
      }
    }
  },
  "Person": {
    "Position": "aut",
    "PersonId": 286,
    "Mrmrs": "impedit",
    "Firstname": "Kaley",
    "Lastname": "Little",
    "MiddleName": "Jast, Considine and Schowalter",
    "Title": "consequuntur",
    "Description": "Streamlined 4th generation portal",
    "Email": "jamarcus.feest@johns.ca",
    "FullName": "Lawrence Strosin",
    "DirectPhone": "288.885.3245",
    "FormalName": "Collins-Little",
    "CountryId": 846,
    "ContactId": 299,
    "ContactName": "Bergstrom-Douglas",
    "Retired": 727,
    "Rank": 687,
    "ActiveInterests": 381,
    "ContactDepartment": "",
    "ContactCountryId": 396,
    "ContactOrgNr": "967747",
    "FaxPhone": "042.620.6153 x176",
    "MobilePhone": "(362)172-6110 x457",
    "ContactPhone": "085.353.5887",
    "AssociateName": "Kuvalis LLC",
    "AssociateId": 384,
    "UsePersonAddress": true,
    "ContactFax": "aliquid",
    "Kanafname": "cupiditate",
    "Kanalname": "voluptatem",
    "Post1": "aut",
    "Post2": "omnis",
    "Post3": "eos",
    "EmailName": "eunice.champlin@feestkris.com",
    "ContactFullName": "Robyn Sporer",
    "ActiveErpLinks": 236,
    "TicketPriorityId": 336,
    "SupportLanguageId": 908,
    "SupportAssociateId": 477,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 349
      }
    }
  },
  "CustomerAlias": "nemo",
  "CustomerHost": "magnam",
  "CustomerName": "Harber-Collins",
  "CustomerEmail": "therese.sporer@lueilwitz.uk",
  "CustomerPhone": "1-566-528-1404 x8127",
  "CustomerConsented": false,
  "CustomerCompanyName": "Jacobson, Keebler and Connelly",
  "Status": "Closed",
  "FirstMessage": "sunt",
  "LastMessage": "quibusdam",
  "WhenRequested": "2007-01-18T09:40:58.7683705+01:00",
  "WhenStarted": "2005-03-01T09:40:58.7683705+01:00",
  "WhenEnded": "2005-12-04T09:40:58.7683705+01:00",
  "WhenIdle": "2000-05-04T09:40:58.7683705+02:00",
  "WhenFetched": "1998-08-16T09:40:58.7683705+02:00",
  "SessionKey": "nostrum",
  "InitialQueuePos": 622,
  "AlertLevel": 852,
  "Rank": 172,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 72,
    "Name": "Green, Blick and Thiel",
    "OrgNr": "497577",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "aliquid",
    "DirectPhone": "1-215-181-4874 x18063",
    "AssociateId": 458,
    "CountryId": 723,
    "EmailAddress": "crystel.hauck@vonrueden.co.uk",
    "Kananame": "ex",
    "EmailAddressName": "janessa@terryking.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Destini Johnston",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "est",
    "FullName": "Casper Corkery",
    "IsOwnerContact": false,
    "ActiveErpLinks": 337,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 224
      }
    }
  },
  "Project": {
    "ProjectId": 396,
    "Name": "Murphy-Pfeffer",
    "Description": "Reactive user-facing workforce",
    "URL": "http://www.example.com/",
    "Type": "dolor",
    "AssociateId": 219,
    "AssociateFullName": "Brennon Schimmel",
    "TypeId": 772,
    "Updated": "2015-05-19T09:40:58.796374+02:00",
    "StatusId": 459,
    "Status": "rerum",
    "TextId": 670,
    "PublishTo": "2008-08-20T09:40:58.796374+02:00",
    "PublishFrom": "2007-08-12T09:40:58.796374+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "287965",
    "ActiveErpLinks": 36,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 416
      }
    }
  },
  "Sale": {
    "ContactName": "Mann, Schaefer and Effertz",
    "SaleDate": "1996-10-29T09:40:58.796374+01:00",
    "SaleId": 960,
    "Probability": 809,
    "Title": "quibusdam",
    "Amount": 5503.304,
    "Currency": "qui",
    "ProjectName": "Bode, DuBuque and Hamill",
    "AssociateFullName": "Renee Huels",
    "Description": "Upgradable holistic website",
    "Status": "Lost",
    "WeightedAmount": 8844.148,
    "ProjectId": 336,
    "EarningPercent": 22718.365999999998,
    "Earning": 30443.676,
    "ContactId": 451,
    "AssociateId": 347,
    "PersonId": 657,
    "SaleTypeId": 809,
    "SaleTypeName": "Sauer, Dietrich and Hettinger",
    "PersonFullName": "Aniyah Waelchi",
    "Completed": "Completed",
    "ActiveErpLinks": 813,
    "NextDueDate": "2010-02-10T09:40:58.7973704+01:00",
    "Number": "1165998",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "implement back-end action-items"
        },
        "FieldType": "System.String",
        "FieldLength": 966
      }
    }
  },
  "Ticket": {
    "TicketId": 482,
    "Title": "expedita",
    "CreatedAt": "2013-08-07T09:40:58.7973704+02:00",
    "LastChanged": "1995-04-05T09:40:58.7973704+02:00",
    "ReadByOwner": "1998-08-12T09:40:58.7973704+02:00",
    "ReadByCustomer": "1997-10-30T09:40:58.7973704+01:00",
    "FirstReadByUser": "2007-05-27T09:40:58.7973704+02:00",
    "Activate": "1997-03-18T09:40:58.7973704+01:00",
    "ClosedAt": "2016-09-04T09:40:58.7973704+02:00",
    "RepliedAt": "1994-03-12T09:40:58.7973704+01:00",
    "AlertTimeout": "2011-06-01T09:40:58.7973704+02:00",
    "Deadline": "2007-09-06T09:40:58.7973704+02:00",
    "CreatedBy": 145,
    "CreatedByName": "Murazik-Osinski",
    "Author": "porro",
    "OwnedBy": 556,
    "OwnedByName": "Murray Group",
    "Category": 585,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 850,
    "BaseStatus": "Active",
    "TicketStatus": 250,
    "Origin": "AutoGenerated",
    "CustId": 329,
    "CustFirstname": "Cielo",
    "CustMiddleName": "O'Conner-Hoeger",
    "CustLastname": "Daniel",
    "AlertLevel": 738,
    "ConnectId": 232,
    "ReadStatus": "Green",
    "TimeToReply": 248,
    "RealTimeToReply": 540,
    "TimeToClose": 797,
    "RealTimeToClose": 561,
    "TimeSpentInternally": 46,
    "TimeSpentExternally": 738,
    "TimeSpentQueue": 825,
    "RealTimeSpentInternally": 49,
    "RealTimeSpentExternally": 124,
    "RealTimeSpentQueue": 407,
    "HasAttachment": true,
    "NumReplies": 528,
    "NumMessages": 337,
    "FromAddress": "fuga",
    "CustFullname": "impedit",
    "TicketStatusDisplayValue": "voluptatem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 389
      }
    }
  },
  "TransferTo": {
    "AssociateId": 607,
    "Name": "Lockman-Wuckert",
    "PersonId": 360,
    "Rank": 709,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 400,
    "FullName": "Josephine Daugherty DDS",
    "FormalName": "McKenzie, Denesik and Rowe",
    "Deleted": true,
    "EjUserId": 728,
    "UserName": "Cremin LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 409
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
        "Reason": "unleash intuitive platforms"
      },
      "FieldType": "System.Int32",
      "FieldLength": 184
    }
  }
}
```