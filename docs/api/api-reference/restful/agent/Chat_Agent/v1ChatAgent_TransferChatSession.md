---
title: POST Agents/Chat/TransferChatSession
id: v1ChatAgent_TransferChatSession
---

# POST Agents/Chat/TransferChatSession

```http
POST /api/v1/Agents/Chat/TransferChatSession
```

Request to send the session to another user.

If the session does not belong to the user, nothing happens.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/TransferChatSession?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

ChatSessionId, ToAssociate 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatSessionId | int32 |  |
| ToAssociate | string |  |


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
POST /api/v1/Agents/Chat/TransferChatSession
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 888,
  "ToAssociate": "ipsa"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 612,
  "TopicId": 18,
  "User": {
    "AssociateId": 930,
    "Name": "Purdy-Rempel",
    "PersonId": 778,
    "Rank": 231,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 831,
    "FullName": "Ozella Moore MD",
    "FormalName": "Hahn-Berge",
    "Deleted": false,
    "EjUserId": 282,
    "UserName": "Dare, Paucek and Ryan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 468
      }
    }
  },
  "Person": {
    "Position": "cum",
    "PersonId": 239,
    "Mrmrs": "iste",
    "Firstname": "Colton",
    "Lastname": "Hammes",
    "MiddleName": "Champlin Inc and Sons",
    "Title": "quod",
    "Description": "Sharable optimal extranet",
    "Email": "kelvin@wiegand.name",
    "FullName": "Dennis Dooley",
    "DirectPhone": "387.258.4765",
    "FormalName": "Collier-Kuhn",
    "CountryId": 619,
    "ContactId": 584,
    "ContactName": "Lueilwitz LLC",
    "Retired": 33,
    "Rank": 212,
    "ActiveInterests": 56,
    "ContactDepartment": "",
    "ContactCountryId": 932,
    "ContactOrgNr": "1447225",
    "FaxPhone": "623-423-0112",
    "MobilePhone": "(743)380-0880 x432",
    "ContactPhone": "418-180-8542 x232",
    "AssociateName": "Walsh Inc and Sons",
    "AssociateId": 330,
    "UsePersonAddress": true,
    "ContactFax": "vel",
    "Kanafname": "debitis",
    "Kanalname": "officiis",
    "Post1": "voluptate",
    "Post2": "eveniet",
    "Post3": "qui",
    "EmailName": "spencer@bednar.com",
    "ContactFullName": "Mr. Edythe Fritsch",
    "ActiveErpLinks": 504,
    "TicketPriorityId": 187,
    "SupportLanguageId": 15,
    "SupportAssociateId": 129,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 781
      }
    }
  },
  "CustomerAlias": "accusamus",
  "CustomerHost": "veritatis",
  "CustomerName": "Johnson Group",
  "CustomerEmail": "kay.wolff@davisblock.co.uk",
  "CustomerPhone": "1-031-246-0210",
  "CustomerConsented": true,
  "CustomerCompanyName": "Stracke-Lind",
  "Status": "Closed",
  "FirstMessage": "harum",
  "LastMessage": "eos",
  "WhenRequested": "2000-10-08T16:48:28.9119239+02:00",
  "WhenStarted": "2010-05-01T16:48:28.9119239+02:00",
  "WhenEnded": "2017-08-24T16:48:28.9119239+02:00",
  "WhenIdle": "1997-12-09T16:48:28.9119239+01:00",
  "WhenFetched": "2000-04-13T16:48:28.9119239+02:00",
  "SessionKey": "eos",
  "InitialQueuePos": 648,
  "AlertLevel": 934,
  "Rank": 68,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 74,
    "Name": "Conroy-Prosacco",
    "OrgNr": "817612",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "dolore",
    "DirectPhone": "1-748-811-7023",
    "AssociateId": 865,
    "CountryId": 131,
    "EmailAddress": "elenor@veum.name",
    "Kananame": "beatae",
    "EmailAddressName": "cydney@ziemetorphy.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Jackie Bednar II",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "aut",
    "FullName": "Tianna Weimann",
    "IsOwnerContact": true,
    "ActiveErpLinks": 874,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "facilitate turn-key e-markets"
        },
        "FieldType": "System.String",
        "FieldLength": 932
      }
    }
  },
  "Project": {
    "ProjectId": 945,
    "Name": "Sporer Group",
    "Description": "Devolved contextually-based secured line",
    "URL": "http://www.example.com/",
    "Type": "at",
    "AssociateId": 237,
    "AssociateFullName": "Dayton McCullough",
    "TypeId": 983,
    "Updated": "2015-01-20T16:48:28.9129244+01:00",
    "StatusId": 814,
    "Status": "iste",
    "TextId": 273,
    "PublishTo": "1994-04-20T16:48:28.9139246+02:00",
    "PublishFrom": "1999-10-31T16:48:28.9139246+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1043253",
    "ActiveErpLinks": 974,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 744
      }
    }
  },
  "Sale": {
    "ContactName": "Kiehn LLC",
    "SaleDate": "2007-10-19T16:48:28.9139246+02:00",
    "SaleId": 413,
    "Probability": 55,
    "Title": "sed",
    "Amount": 11514.315999999999,
    "Currency": "dolorem",
    "ProjectName": "Johns-Wiegand",
    "AssociateFullName": "Daisy Predovic",
    "Description": "Pre-emptive tertiary hardware",
    "Status": "Lost",
    "WeightedAmount": 22646.284,
    "ProjectId": 78,
    "EarningPercent": 10433.086,
    "Earning": 23288.754,
    "ContactId": 151,
    "AssociateId": 619,
    "PersonId": 533,
    "SaleTypeId": 477,
    "SaleTypeName": "Kohler, Miller and Aufderhar",
    "PersonFullName": "Ramon Schamberger",
    "Completed": "Completed",
    "ActiveErpLinks": 752,
    "NextDueDate": "2016-07-03T16:48:28.9139246+02:00",
    "Number": "1471889",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 448
      }
    }
  },
  "Ticket": {
    "TicketId": 453,
    "Title": "autem",
    "CreatedAt": "2011-05-02T16:48:28.9139246+02:00",
    "LastChanged": "2017-02-08T16:48:28.9139246+01:00",
    "ReadByOwner": "2013-09-23T16:48:28.9139246+02:00",
    "ReadByCustomer": "2018-11-21T16:48:28.9139246+01:00",
    "FirstReadByUser": "2001-01-09T16:48:28.9139246+01:00",
    "Activate": "2010-12-02T16:48:28.9139246+01:00",
    "ClosedAt": "2009-12-21T16:48:28.9139246+01:00",
    "RepliedAt": "2012-06-19T16:48:28.9139246+02:00",
    "AlertTimeout": "2011-02-18T16:48:28.9139246+01:00",
    "Deadline": "2016-05-10T16:48:28.9139246+02:00",
    "CreatedBy": 749,
    "CreatedByName": "Kemmer Inc and Sons",
    "Author": "unde",
    "OwnedBy": 817,
    "OwnedByName": "Lang LLC",
    "Category": 141,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 27,
    "BaseStatus": "Active",
    "TicketStatus": 450,
    "Origin": "AutoGenerated",
    "CustId": 885,
    "CustFirstname": "Amparo",
    "CustMiddleName": "Schmidt-Torphy",
    "CustLastname": "Greenfelder",
    "AlertLevel": 788,
    "ConnectId": 245,
    "ReadStatus": "Green",
    "TimeToReply": 326,
    "RealTimeToReply": 547,
    "TimeToClose": 383,
    "RealTimeToClose": 864,
    "TimeSpentInternally": 645,
    "TimeSpentExternally": 511,
    "TimeSpentQueue": 492,
    "RealTimeSpentInternally": 423,
    "RealTimeSpentExternally": 18,
    "RealTimeSpentQueue": 5,
    "HasAttachment": false,
    "NumReplies": 494,
    "NumMessages": 395,
    "FromAddress": "quo",
    "CustFullname": "modi",
    "TicketStatusDisplayValue": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 328
      }
    }
  },
  "TransferTo": {
    "AssociateId": 639,
    "Name": "Kuhn, Hermiston and Stiedemann",
    "PersonId": 570,
    "Rank": 293,
    "Tooltip": "voluptatum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 982,
    "FullName": "Abbigail Keeling",
    "FormalName": "Stroman-Yundt",
    "Deleted": false,
    "EjUserId": 102,
    "UserName": "Welch LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 750
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
      "FieldLength": 331
    }
  }
}
```