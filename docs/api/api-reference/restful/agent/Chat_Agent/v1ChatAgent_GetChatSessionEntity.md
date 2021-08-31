---
title: GetChatSessionEntity
id: v1ChatAgent_GetChatSessionEntity
---

# GetChatSessionEntity

```http
POST /api/v1/Agents/Chat/GetChatSessionEntity
```

Gets a ChatSessionEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| chatSessionEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/GetChatSessionEntity?chatSessionEntityId=825
POST /api/v1/Agents/Chat/GetChatSessionEntity?$select=name,department,category/id
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
| ChatbotIsActive | bool | Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Chat/GetChatSessionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 413,
  "TopicId": 362,
  "User": {
    "AssociateId": 914,
    "Name": "Ward LLC",
    "PersonId": 294,
    "Rank": 664,
    "Tooltip": "repellendus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 267,
    "FullName": "Laurel Hoppe",
    "FormalName": "Kassulke-Osinski",
    "Deleted": false,
    "EjUserId": 608,
    "UserName": "Koss Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 309
      }
    }
  },
  "Person": {
    "Position": "ad",
    "PersonId": 140,
    "Mrmrs": "quasi",
    "Firstname": "Guiseppe",
    "Lastname": "Braun",
    "MiddleName": "O'Keefe-Wisozk",
    "Title": "eligendi",
    "Description": "Managed bottom-line function",
    "Email": "jan@cummings.biz",
    "FullName": "Otilia Roob",
    "DirectPhone": "630.841.1131 x32367",
    "FormalName": "Feest, Renner and Jacobson",
    "CountryId": 606,
    "ContactId": 978,
    "ContactName": "Kilback-Renner",
    "Retired": 461,
    "Rank": 350,
    "ActiveInterests": 411,
    "ContactDepartment": "",
    "ContactCountryId": 761,
    "ContactOrgNr": "1304668",
    "FaxPhone": "(332)003-0654 x008",
    "MobilePhone": "052.136.3182 x8241",
    "ContactPhone": "446.487.0376 x7558",
    "AssociateName": "Huel-Johnston",
    "AssociateId": 737,
    "UsePersonAddress": false,
    "ContactFax": "at",
    "Kanafname": "quidem",
    "Kanalname": "necessitatibus",
    "Post1": "incidunt",
    "Post2": "sit",
    "Post3": "aut",
    "EmailName": "taylor_collins@homenick.co.uk",
    "ContactFullName": "Agustin Cartwright",
    "ActiveErpLinks": 513,
    "TicketPriorityId": 378,
    "SupportLanguageId": 611,
    "SupportAssociateId": 149,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 894
      }
    }
  },
  "CustomerAlias": "omnis",
  "CustomerHost": "necessitatibus",
  "CustomerName": "Bernier, Schultz and Kris",
  "CustomerEmail": "ottis_morar@morarwelch.name",
  "CustomerPhone": "1-574-075-6268 x2563",
  "CustomerConsented": true,
  "CustomerCompanyName": "Cassin, Rath and Fritsch",
  "Status": "Closed",
  "FirstMessage": "doloremque",
  "LastMessage": "modi",
  "WhenRequested": "1997-01-09T14:58:03.4082417+01:00",
  "WhenStarted": "1995-02-23T14:58:03.4082417+01:00",
  "WhenEnded": "2013-01-20T14:58:03.4082417+01:00",
  "WhenIdle": "2013-05-29T14:58:03.4092465+02:00",
  "WhenFetched": "2010-08-29T14:58:03.4092465+02:00",
  "SessionKey": "eveniet",
  "InitialQueuePos": 433,
  "AlertLevel": 732,
  "Rank": 444,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 319,
    "Name": "Thompson LLC",
    "OrgNr": "954525",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ipsum",
    "DirectPhone": "773.562.8666 x572",
    "AssociateId": 114,
    "CountryId": 905,
    "EmailAddress": "jackeline@barrows.name",
    "Kananame": "exercitationem",
    "EmailAddressName": "sedrick.carter@bradtkejohnston.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Manuel Balistreri",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ut",
    "FullName": "Mckenzie Jast",
    "IsOwnerContact": false,
    "ActiveErpLinks": 742,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 532
      }
    }
  },
  "Project": {
    "ProjectId": 811,
    "Name": "Pollich, McLaughlin and McDermott",
    "Description": "Realigned client-server challenge",
    "URL": "http://www.example.com/",
    "Type": "asperiores",
    "AssociateId": 539,
    "AssociateFullName": "Dr. Reina Bayer",
    "TypeId": 785,
    "Updated": "2012-01-10T14:58:03.4092465+01:00",
    "StatusId": 640,
    "Status": "qui",
    "TextId": 895,
    "PublishTo": "2006-03-14T14:58:03.4092465+01:00",
    "PublishFrom": "2019-05-03T14:58:03.4092465+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1137365",
    "ActiveErpLinks": 183,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 889
      }
    }
  },
  "Sale": {
    "ContactName": "Stehr-Eichmann",
    "SaleDate": "2019-11-11T14:58:03.4102405+01:00",
    "SaleId": 480,
    "Probability": 431,
    "Title": "sint",
    "Amount": 22154.246,
    "Currency": "qui",
    "ProjectName": "Bartoletti, McLaughlin and Satterfield",
    "AssociateFullName": "Shanon Hettinger",
    "Description": "Diverse fault-tolerant forecast",
    "Status": "Lost",
    "WeightedAmount": 19399.46,
    "ProjectId": 639,
    "EarningPercent": 7672.032,
    "Earning": 21383.282,
    "ContactId": 918,
    "AssociateId": 171,
    "PersonId": 872,
    "SaleTypeId": 536,
    "SaleTypeName": "Crist-Nikolaus",
    "PersonFullName": "Dr. Dock Mitchell",
    "Completed": "Completed",
    "ActiveErpLinks": 569,
    "NextDueDate": "2011-12-16T14:58:03.4102405+01:00",
    "Number": "728188",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 628
      }
    }
  },
  "Ticket": {
    "TicketId": 53,
    "Title": "facilis",
    "CreatedAt": "1999-12-21T14:58:03.4102405+01:00",
    "LastChanged": "2013-06-23T14:58:03.4102405+02:00",
    "ReadByOwner": "2014-08-26T14:58:03.4102405+02:00",
    "ReadByCustomer": "1999-09-11T14:58:03.4102405+02:00",
    "FirstReadByUser": "2002-07-10T14:58:03.4102405+02:00",
    "Activate": "2007-01-19T14:58:03.4102405+01:00",
    "ClosedAt": "2020-09-17T14:58:03.4102405+02:00",
    "RepliedAt": "2015-03-24T14:58:03.4102405+01:00",
    "AlertTimeout": "2005-11-22T14:58:03.4102405+01:00",
    "Deadline": "1999-03-09T14:58:03.4102405+01:00",
    "CreatedBy": 798,
    "CreatedByName": "Mayert-Nolan",
    "Author": "quasi",
    "OwnedBy": 575,
    "OwnedByName": "Walter LLC",
    "Category": 513,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 128,
    "PriorityName": "Steuber, Sawayn and Farrell",
    "BaseStatus": "Active",
    "TicketStatus": 435,
    "TicketStatusDisplayValue": "et",
    "Origin": "AutoGenerated",
    "CustId": 736,
    "PersonFirstname": "Julian",
    "PersonMiddleName": "Feest Inc and Sons",
    "PersonLastname": "Heller",
    "PersonFullname": "sunt",
    "AlertLevel": 965,
    "ConnectId": 33,
    "ReadStatus": "Green",
    "TimeToReply": 936,
    "RealTimeToReply": 773,
    "TimeToClose": 843,
    "RealTimeToClose": 28,
    "TimeSpentInternally": 481,
    "TimeSpentExternally": 379,
    "TimeSpentQueue": 116,
    "RealTimeSpentInternally": 595,
    "RealTimeSpentExternally": 331,
    "RealTimeSpentQueue": 127,
    "HasAttachment": false,
    "NumReplies": 133,
    "NumMessages": 475,
    "FromAddress": "praesentium",
    "ContactId": 949,
    "ContactName": "Gutmann, Bode and Schmitt",
    "OwnedByAssociateId": 107,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "drive proactive architectures"
        },
        "FieldType": "System.String",
        "FieldLength": 765
      }
    }
  },
  "TransferTo": {
    "AssociateId": 223,
    "Name": "Herman-Murphy",
    "PersonId": 482,
    "Rank": 293,
    "Tooltip": "accusantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 759,
    "FullName": "Kip Halvorson",
    "FormalName": "Grant, Kuvalis and Corkery",
    "Deleted": true,
    "EjUserId": 606,
    "UserName": "Stamm LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 231
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
      "FieldLength": 441
    }
  }
}
```