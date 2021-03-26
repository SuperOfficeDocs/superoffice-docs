---
title: POST Agents/Chat/AcceptChatSessionTransfer
id: v1ChatAgent_AcceptChatSessionTransfer
---

# POST Agents/Chat/AcceptChatSessionTransfer

```http
POST /api/v1/Agents/Chat/AcceptChatSessionTransfer
```

Accept the transfer: assign the session to the user.

If the session is not being transferred, nothing happens.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/AcceptChatSessionTransfer?$select=name,department,category/id
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

ChatSessionId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatSessionId | int32 |  |


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
POST /api/v1/Agents/Chat/AcceptChatSessionTransfer
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 201
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 340,
  "TopicId": 739,
  "User": {
    "AssociateId": 123,
    "Name": "Abbott-Lowe",
    "PersonId": 691,
    "Rank": 243,
    "Tooltip": "assumenda",
    "Type": "AnonymousAssociate",
    "GroupIdx": 433,
    "FullName": "Leda Yundt",
    "FormalName": "Hauck-Smitham",
    "Deleted": false,
    "EjUserId": 332,
    "UserName": "Schmeler-Schimmel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 616
      }
    }
  },
  "Person": {
    "Position": "sequi",
    "PersonId": 994,
    "Mrmrs": "aut",
    "Firstname": "Josianne",
    "Lastname": "Hand",
    "MiddleName": "Trantow, Kassulke and Frami",
    "Title": "nihil",
    "Description": "Visionary discrete structure",
    "Email": "garnet@russel.info",
    "FullName": "Una Bosco",
    "DirectPhone": "1-648-572-8503 x42858",
    "FormalName": "Walker Inc and Sons",
    "CountryId": 860,
    "ContactId": 282,
    "ContactName": "Hickle-Volkman",
    "Retired": 785,
    "Rank": 185,
    "ActiveInterests": 82,
    "ContactDepartment": "",
    "ContactCountryId": 452,
    "ContactOrgNr": "656323",
    "FaxPhone": "275-518-7466",
    "MobilePhone": "144-071-2678 x075",
    "ContactPhone": "1-513-634-2631",
    "AssociateName": "Haley-West",
    "AssociateId": 798,
    "UsePersonAddress": true,
    "ContactFax": "et",
    "Kanafname": "excepturi",
    "Kanalname": "neque",
    "Post1": "veniam",
    "Post2": "labore",
    "Post3": "numquam",
    "EmailName": "jeremie.ernser@aufderhar.info",
    "ContactFullName": "Nolan Herzog",
    "ActiveErpLinks": 283,
    "TicketPriorityId": 116,
    "SupportLanguageId": 481,
    "SupportAssociateId": 205,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 260
      }
    }
  },
  "CustomerAlias": "culpa",
  "CustomerHost": "quaerat",
  "CustomerName": "Gulgowski, Murazik and Daniel",
  "CustomerEmail": "serena@koch.us",
  "CustomerPhone": "1-218-425-2357 x7276",
  "CustomerConsented": true,
  "CustomerCompanyName": "Maggio, Ratke and Kshlerin",
  "Status": "Closed",
  "FirstMessage": "nobis",
  "LastMessage": "exercitationem",
  "WhenRequested": "2002-08-07T16:48:28.9219249+02:00",
  "WhenStarted": "2010-06-24T16:48:28.9219249+02:00",
  "WhenEnded": "2018-04-11T16:48:28.9219249+02:00",
  "WhenIdle": "2014-02-17T16:48:28.9219249+01:00",
  "WhenFetched": "1996-02-17T16:48:28.9219249+01:00",
  "SessionKey": "ullam",
  "InitialQueuePos": 766,
  "AlertLevel": 11,
  "Rank": 400,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 991,
    "Name": "Ankunding Inc and Sons",
    "OrgNr": "743385",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "reprehenderit",
    "DirectPhone": "1-074-086-6046",
    "AssociateId": 548,
    "CountryId": 353,
    "EmailAddress": "russel_lueilwitz@kautzer.ca",
    "Kananame": "modi",
    "EmailAddressName": "horace@nitzsche.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Logan Roob",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "totam",
    "FullName": "Leora Metz V",
    "IsOwnerContact": true,
    "ActiveErpLinks": 16,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 517
      }
    }
  },
  "Project": {
    "ProjectId": 675,
    "Name": "Nienow, O'Keefe and Crona",
    "Description": "Function-based 4th generation attitude",
    "URL": "http://www.example.com/",
    "Type": "officiis",
    "AssociateId": 828,
    "AssociateFullName": "Dr. Forrest Beer",
    "TypeId": 893,
    "Updated": "2014-02-03T16:48:28.922927+01:00",
    "StatusId": 152,
    "Status": "eius",
    "TextId": 866,
    "PublishTo": "1994-09-14T16:48:28.922927+02:00",
    "PublishFrom": "2018-08-19T16:48:28.922927+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "750278",
    "ActiveErpLinks": 306,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 842
      }
    }
  },
  "Sale": {
    "ContactName": "Homenick Group",
    "SaleDate": "2000-05-23T16:48:28.922927+02:00",
    "SaleId": 732,
    "Probability": 547,
    "Title": "reprehenderit",
    "Amount": 4867.102,
    "Currency": "molestias",
    "ProjectName": "Mayer, Nitzsche and Bogan",
    "AssociateFullName": "Dave Luettgen",
    "Description": "Focused radical framework",
    "Status": "Lost",
    "WeightedAmount": 13610.962,
    "ProjectId": 653,
    "EarningPercent": 22075.896,
    "Earning": 19064.122,
    "ContactId": 756,
    "AssociateId": 150,
    "PersonId": 916,
    "SaleTypeId": 26,
    "SaleTypeName": "Goodwin LLC",
    "PersonFullName": "Dr. Maye Connelly",
    "Completed": "Completed",
    "ActiveErpLinks": 330,
    "NextDueDate": "2011-10-05T16:48:28.922927+02:00",
    "Number": "1032416",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 18
      }
    }
  },
  "Ticket": {
    "TicketId": 520,
    "Title": "quam",
    "CreatedAt": "2008-02-18T16:48:28.922927+01:00",
    "LastChanged": "2019-05-24T16:48:28.922927+02:00",
    "ReadByOwner": "2010-10-14T16:48:28.922927+02:00",
    "ReadByCustomer": "2006-02-07T16:48:28.922927+01:00",
    "FirstReadByUser": "2003-02-07T16:48:28.922927+01:00",
    "Activate": "2008-04-14T16:48:28.922927+02:00",
    "ClosedAt": "2001-06-12T16:48:28.922927+02:00",
    "RepliedAt": "1995-03-31T16:48:28.922927+02:00",
    "AlertTimeout": "2019-10-01T16:48:28.922927+02:00",
    "Deadline": "2019-09-05T16:48:28.922927+02:00",
    "CreatedBy": 123,
    "CreatedByName": "Smitham, Krajcik and Cole",
    "Author": "ut",
    "OwnedBy": 565,
    "OwnedByName": "Shields-Homenick",
    "Category": 626,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 232,
    "BaseStatus": "Active",
    "TicketStatus": 481,
    "Origin": "AutoGenerated",
    "CustId": 184,
    "CustFirstname": "Annabel",
    "CustMiddleName": "Pfannerstill Inc and Sons",
    "CustLastname": "Langosh",
    "AlertLevel": 730,
    "ConnectId": 437,
    "ReadStatus": "Green",
    "TimeToReply": 718,
    "RealTimeToReply": 724,
    "TimeToClose": 728,
    "RealTimeToClose": 563,
    "TimeSpentInternally": 92,
    "TimeSpentExternally": 755,
    "TimeSpentQueue": 89,
    "RealTimeSpentInternally": 544,
    "RealTimeSpentExternally": 208,
    "RealTimeSpentQueue": 557,
    "HasAttachment": true,
    "NumReplies": 282,
    "NumMessages": 978,
    "FromAddress": "quia",
    "CustFullname": "reiciendis",
    "TicketStatusDisplayValue": "eaque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 607
      }
    }
  },
  "TransferTo": {
    "AssociateId": 184,
    "Name": "Lind, Tillman and Rosenbaum",
    "PersonId": 371,
    "Rank": 33,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 175,
    "FullName": "Ms. Rodolfo Wuckert",
    "FormalName": "Murphy, Lesch and Boyer",
    "Deleted": true,
    "EjUserId": 393,
    "UserName": "Hansen Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 115
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
      "FieldLength": 118
    }
  }
}
```