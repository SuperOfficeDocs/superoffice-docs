---
title: POST ChatSession/{id}/TransferTo/{toAssociate}
id: v1ChatSessionEntity_TransferChatSession
---

# POST ChatSession/{id}/TransferTo/{toAssociate}

```http
POST /api/v1/ChatSession/{chatSessionId}/TransferTo/{toAssociate}
```

Request to send the session to another user.

If the session does not belong to the user, nothing happens.




| Path Part | Type | Description |
|-----------|------|-------------|
| chatSessionId | int32 | id of the chat session to send **Required** |
| toAssociate | string | Associate username or associate id to send session to. **Required** |



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
| ChatbotIsActive | bool | Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/ChatSession/{chatSessionId}/TransferTo/{toAssociate}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 899,
  "TopicId": 959,
  "User": {
    "AssociateId": 36,
    "Name": "Marks-Schroeder",
    "PersonId": 415,
    "Rank": 749,
    "Tooltip": "itaque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 658,
    "FullName": "Aylin Cummerata",
    "FormalName": "Monahan, Smitham and Olson",
    "Deleted": true,
    "EjUserId": 670,
    "UserName": "Robel Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 193
      }
    }
  },
  "Person": {
    "Position": "incidunt",
    "PersonId": 126,
    "Mrmrs": "natus",
    "Firstname": "Salma",
    "Lastname": "Powlowski",
    "MiddleName": "Borer, Marquardt and Klocko",
    "Title": "nihil",
    "Description": "Organic mission-critical support",
    "Email": "kennedi_kshlerin@damore.com",
    "FullName": "Zoie Stanton",
    "DirectPhone": "714-327-8750",
    "FormalName": "Jacobson-Haag",
    "CountryId": 610,
    "ContactId": 39,
    "ContactName": "Smith-Jacobson",
    "Retired": 106,
    "Rank": 443,
    "ActiveInterests": 831,
    "ContactDepartment": "",
    "ContactCountryId": 645,
    "ContactOrgNr": "1131423",
    "FaxPhone": "(730)117-7513",
    "MobilePhone": "1-447-608-4205 x57638",
    "ContactPhone": "(332)433-8847 x48755",
    "AssociateName": "Murphy-Kertzmann",
    "AssociateId": 354,
    "UsePersonAddress": false,
    "ContactFax": "quod",
    "Kanafname": "impedit",
    "Kanalname": "necessitatibus",
    "Post1": "est",
    "Post2": "cupiditate",
    "Post3": "repellendus",
    "EmailName": "walker@gerholdweissnat.name",
    "ContactFullName": "Brenda Littel",
    "ActiveErpLinks": 799,
    "TicketPriorityId": 153,
    "SupportLanguageId": 294,
    "SupportAssociateId": 420,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 936
      }
    }
  },
  "CustomerAlias": "sed",
  "CustomerHost": "ipsa",
  "CustomerName": "Marquardt LLC",
  "CustomerEmail": "keira.kris@friesenromaguera.co.uk",
  "CustomerPhone": "1-667-134-6713 x453",
  "CustomerConsented": true,
  "CustomerCompanyName": "Johnson-Homenick",
  "Status": "Closed",
  "FirstMessage": "voluptatem",
  "LastMessage": "maxime",
  "WhenRequested": "2016-09-08T18:25:50.0690818+02:00",
  "WhenStarted": "2011-01-13T18:25:50.0690818+01:00",
  "WhenEnded": "2000-09-24T18:25:50.0690818+02:00",
  "WhenIdle": "2005-06-16T18:25:50.0690818+02:00",
  "WhenFetched": "2011-06-22T18:25:50.0690818+02:00",
  "SessionKey": "dicta",
  "InitialQueuePos": 685,
  "AlertLevel": 296,
  "Rank": 46,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 750,
    "Name": "Tromp, O'Conner and Jacobson",
    "OrgNr": "1240914",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "qui",
    "DirectPhone": "(001)260-0466 x5843",
    "AssociateId": 346,
    "CountryId": 807,
    "EmailAddress": "cora@lesch.uk",
    "Kananame": "similique",
    "EmailAddressName": "oleta_fadel@stiedemannlemke.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ezra Predovic",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "fugit",
    "FullName": "Alberta Mraz",
    "IsOwnerContact": false,
    "ActiveErpLinks": 357,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 422
      }
    }
  },
  "Project": {
    "ProjectId": 231,
    "Name": "Reichert LLC",
    "Description": "Exclusive motivating emulation",
    "URL": "http://www.example.com/",
    "Type": "sunt",
    "AssociateId": 616,
    "AssociateFullName": "May Baumbach",
    "TypeId": 291,
    "Updated": "2019-08-03T18:25:50.0695969+02:00",
    "StatusId": 276,
    "Status": "nulla",
    "TextId": 47,
    "PublishTo": "2021-03-21T18:25:50.0695969+01:00",
    "PublishFrom": "1995-11-01T18:25:50.0695969+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1073736",
    "ActiveErpLinks": 962,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 288
      }
    }
  },
  "Sale": {
    "ContactName": "Bauch LLC",
    "SaleDate": "2000-04-18T18:25:50.0695969+02:00",
    "SaleId": 283,
    "Probability": 544,
    "Title": "et",
    "Amount": 22389.296,
    "Currency": "saepe",
    "ProjectName": "West-Rutherford",
    "AssociateFullName": "Dr. Hardy Rogahn",
    "Description": "Re-engineered interactive interface",
    "Status": "Lost",
    "WeightedAmount": 18023.634,
    "ProjectId": 124,
    "EarningPercent": 23592.752,
    "Earning": 14692.192,
    "ContactId": 156,
    "AssociateId": 413,
    "PersonId": 299,
    "SaleTypeId": 679,
    "SaleTypeName": "Thompson, Hickle and Greenholt",
    "PersonFullName": "Kiera Anderson",
    "Completed": "Completed",
    "ActiveErpLinks": 763,
    "NextDueDate": "2001-06-10T18:25:50.0705963+02:00",
    "Number": "938796",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 386
      }
    }
  },
  "Ticket": {
    "TicketId": 6,
    "Title": "error",
    "CreatedAt": "2006-01-30T18:25:50.0705963+01:00",
    "LastChanged": "2006-11-20T18:25:50.0705963+01:00",
    "ReadByOwner": "2003-08-17T18:25:50.0705963+02:00",
    "ReadByCustomer": "2021-02-15T18:25:50.0705963+01:00",
    "FirstReadByUser": "2011-06-22T18:25:50.0705963+02:00",
    "Activate": "2000-12-19T18:25:50.0705963+01:00",
    "ClosedAt": "2019-02-06T18:25:50.0705963+01:00",
    "RepliedAt": "2009-03-02T18:25:50.0705963+01:00",
    "AlertTimeout": "2011-01-01T18:25:50.0705963+01:00",
    "Deadline": "2020-11-27T18:25:50.0705963+01:00",
    "CreatedBy": 814,
    "CreatedByName": "Labadie-Doyle",
    "Author": "voluptas",
    "OwnedBy": 13,
    "OwnedByName": "O'Hara Inc and Sons",
    "Category": 510,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 502,
    "PriorityName": "Yost, Hills and Rogahn",
    "BaseStatus": "Active",
    "TicketStatus": 334,
    "TicketStatusDisplayValue": "consequatur",
    "Origin": "AutoGenerated",
    "CustId": 856,
    "PersonFirstname": "Rosario",
    "PersonMiddleName": "Christiansen, D'Amore and Stark",
    "PersonLastname": "Yost",
    "PersonFullname": "ut",
    "AlertLevel": 110,
    "ConnectId": 615,
    "ReadStatus": "Green",
    "TimeToReply": 950,
    "RealTimeToReply": 361,
    "TimeToClose": 659,
    "RealTimeToClose": 572,
    "TimeSpentInternally": 586,
    "TimeSpentExternally": 479,
    "TimeSpentQueue": 144,
    "RealTimeSpentInternally": 111,
    "RealTimeSpentExternally": 353,
    "RealTimeSpentQueue": 978,
    "HasAttachment": true,
    "NumReplies": 743,
    "NumMessages": 49,
    "FromAddress": "ipsa",
    "ContactId": 12,
    "ContactName": "Prosacco Inc and Sons",
    "OwnedByAssociateId": 431,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 663
      }
    }
  },
  "TransferTo": {
    "AssociateId": 485,
    "Name": "Medhurst, Cronin and Grant",
    "PersonId": 127,
    "Rank": 979,
    "Tooltip": "modi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 40,
    "FullName": "Meta Daugherty",
    "FormalName": "Steuber, Shanahan and Gerhold",
    "Deleted": true,
    "EjUserId": 879,
    "UserName": "Wolff, Bode and Kuhlman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 646
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
      "FieldLength": 89
    }
  }
}
```