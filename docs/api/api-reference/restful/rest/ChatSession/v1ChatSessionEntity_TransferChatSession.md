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
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 803,
  "TopicId": 10,
  "User": {
    "AssociateId": 921,
    "Name": "Wehner, Haag and Kuvalis",
    "PersonId": 522,
    "Rank": 898,
    "Tooltip": "tempora",
    "Type": "AnonymousAssociate",
    "GroupIdx": 764,
    "FullName": "Kevon Kerluke DDS",
    "FormalName": "Schowalter, Nader and Wilderman",
    "Deleted": false,
    "EjUserId": 136,
    "UserName": "Rohan, Gottlieb and Ankunding",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 498
      }
    }
  },
  "Person": {
    "Position": "repellat",
    "PersonId": 70,
    "Mrmrs": "non",
    "Firstname": "Eldridge",
    "Lastname": "Pollich",
    "MiddleName": "Cummings-Krajcik",
    "Title": "porro",
    "Description": "Centralized dynamic encryption",
    "Email": "royce@hahn.ca",
    "FullName": "Macie Wisoky",
    "DirectPhone": "(115)286-0746 x68310",
    "FormalName": "Nitzsche-Crona",
    "CountryId": 565,
    "ContactId": 119,
    "ContactName": "Kohler LLC",
    "Retired": 871,
    "Rank": 161,
    "ActiveInterests": 702,
    "ContactDepartment": "",
    "ContactCountryId": 56,
    "ContactOrgNr": "432336",
    "FaxPhone": "(323)146-7566",
    "MobilePhone": "746-841-6785",
    "ContactPhone": "(776)671-1185",
    "AssociateName": "Kuhn Inc and Sons",
    "AssociateId": 710,
    "UsePersonAddress": true,
    "ContactFax": "in",
    "Kanafname": "assumenda",
    "Kanalname": "nulla",
    "Post1": "fugiat",
    "Post2": "et",
    "Post3": "aliquam",
    "EmailName": "fred@homenick.biz",
    "ContactFullName": "Gia Langworth",
    "ActiveErpLinks": 478,
    "TicketPriorityId": 775,
    "SupportLanguageId": 918,
    "SupportAssociateId": 740,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 624
      }
    }
  },
  "CustomerAlias": "aperiam",
  "CustomerHost": "velit",
  "CustomerName": "Davis-Corkery",
  "CustomerEmail": "clark@fisher.co.uk",
  "CustomerPhone": "570-651-0682 x44760",
  "CustomerConsented": true,
  "CustomerCompanyName": "Renner Inc and Sons",
  "Status": "Closed",
  "FirstMessage": "porro",
  "LastMessage": "et",
  "WhenRequested": "2016-08-12T15:05:41.6810029+02:00",
  "WhenStarted": "2016-08-25T15:05:41.6810029+02:00",
  "WhenEnded": "2016-12-17T15:05:41.6810029+01:00",
  "WhenIdle": "2020-12-06T15:05:41.6810029+01:00",
  "WhenFetched": "2001-01-28T15:05:41.6810029+01:00",
  "SessionKey": "ut",
  "InitialQueuePos": 531,
  "AlertLevel": 406,
  "Rank": 961,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 859,
    "Name": "Schroeder Inc and Sons",
    "OrgNr": "946465",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "debitis",
    "DirectPhone": "534-168-6608",
    "AssociateId": 921,
    "CountryId": 827,
    "EmailAddress": "kyleigh@beahanbailey.co.uk",
    "Kananame": "aliquid",
    "EmailAddressName": "berneice_koelpin@tromp.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Jamey Mraz",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "dolor",
    "FullName": "Josh Smitham",
    "IsOwnerContact": false,
    "ActiveErpLinks": 868,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "empower out-of-the-box action-items"
        },
        "FieldType": "System.Int32",
        "FieldLength": 362
      }
    }
  },
  "Project": {
    "ProjectId": 33,
    "Name": "Fadel, McLaughlin and Hermiston",
    "Description": "Open-architected dedicated migration",
    "URL": "http://www.example.com/",
    "Type": "accusantium",
    "AssociateId": 558,
    "AssociateFullName": "Abby Yost",
    "TypeId": 854,
    "Updated": "2007-03-29T15:05:41.6820025+02:00",
    "StatusId": 14,
    "Status": "mollitia",
    "TextId": 306,
    "PublishTo": "2002-09-03T15:05:41.6820025+02:00",
    "PublishFrom": "2003-12-04T15:05:41.6830025+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "693378",
    "ActiveErpLinks": 342,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 68
      }
    }
  },
  "Sale": {
    "ContactName": "Runte Group",
    "SaleDate": "2018-11-06T15:05:41.6830025+01:00",
    "SaleId": 144,
    "Probability": 972,
    "Title": "vitae",
    "Amount": 14046.588,
    "Currency": "quis",
    "ProjectName": "O'Conner-Mraz",
    "AssociateFullName": "Eunice Prosacco",
    "Description": "Team-oriented bifurcated leverage",
    "Status": "Lost",
    "WeightedAmount": 24460.87,
    "ProjectId": 745,
    "EarningPercent": 22862.53,
    "Earning": 20910.048,
    "ContactId": 385,
    "AssociateId": 184,
    "PersonId": 158,
    "SaleTypeId": 967,
    "SaleTypeName": "Herzog Inc and Sons",
    "PersonFullName": "Jaime Schmidt",
    "Completed": "Completed",
    "ActiveErpLinks": 691,
    "NextDueDate": "1997-01-19T15:05:41.6830025+01:00",
    "Number": "1726092",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 651
      }
    }
  },
  "Ticket": {
    "TicketId": 933,
    "Title": "repellat",
    "CreatedAt": "2018-03-24T15:05:41.6830025+01:00",
    "LastChanged": "2018-10-01T15:05:41.6830025+02:00",
    "ReadByOwner": "2013-11-03T15:05:41.6830025+01:00",
    "ReadByCustomer": "2004-03-22T15:05:41.6830025+01:00",
    "FirstReadByUser": "2014-01-26T15:05:41.6830025+01:00",
    "Activate": "1997-11-18T15:05:41.6830025+01:00",
    "ClosedAt": "2016-11-18T15:05:41.6830025+01:00",
    "RepliedAt": "1999-11-29T15:05:41.6830025+01:00",
    "AlertTimeout": "2009-06-24T15:05:41.6830025+02:00",
    "Deadline": "2020-12-26T15:05:41.6830025+01:00",
    "CreatedBy": 82,
    "CreatedByName": "Rosenbaum-Schaefer",
    "Author": "sed",
    "OwnedBy": 433,
    "OwnedByName": "Connelly-Reilly",
    "Category": 191,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 174,
    "PriorityName": "Schneider-Bashirian",
    "BaseStatus": "Active",
    "TicketStatus": 282,
    "TicketStatusDisplayValue": "aliquam",
    "Origin": "AutoGenerated",
    "CustId": 800,
    "PersonFirstname": "Khalil",
    "PersonMiddleName": "Bednar-Beatty",
    "PersonLastname": "Parisian",
    "PersonFullname": "vitae",
    "AlertLevel": 366,
    "ConnectId": 700,
    "ReadStatus": "Green",
    "TimeToReply": 357,
    "RealTimeToReply": 765,
    "TimeToClose": 611,
    "RealTimeToClose": 465,
    "TimeSpentInternally": 86,
    "TimeSpentExternally": 95,
    "TimeSpentQueue": 231,
    "RealTimeSpentInternally": 815,
    "RealTimeSpentExternally": 93,
    "RealTimeSpentQueue": 62,
    "HasAttachment": false,
    "NumReplies": 372,
    "NumMessages": 809,
    "FromAddress": "recusandae",
    "ContactId": 637,
    "ContactName": "Fisher, Mitchell and Trantow",
    "OwnedByAssociateId": 455,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 866
      }
    }
  },
  "TransferTo": {
    "AssociateId": 375,
    "Name": "Aufderhar, Kemmer and Bechtelar",
    "PersonId": 509,
    "Rank": 777,
    "Tooltip": "cupiditate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 410,
    "FullName": "Mrs. Vance D'Amore",
    "FormalName": "Leffler Inc and Sons",
    "Deleted": true,
    "EjUserId": 8,
    "UserName": "Mayert Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 843
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
      "FieldType": "System.Int32",
      "FieldLength": 600
    }
  }
}
```