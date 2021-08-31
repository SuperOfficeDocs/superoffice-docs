---
title: AcceptChatSessionTransfer
id: v1ChatAgent_AcceptChatSessionTransfer
---

# AcceptChatSessionTransfer

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
| ChatbotIsActive | bool | Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Chat/AcceptChatSessionTransfer
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 828
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 45,
  "TopicId": 35,
  "User": {
    "AssociateId": 392,
    "Name": "Herzog, Zboncak and Russel",
    "PersonId": 611,
    "Rank": 741,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 901,
    "FullName": "Tanner Buckridge",
    "FormalName": "Schmeler, Tromp and Schaden",
    "Deleted": true,
    "EjUserId": 458,
    "UserName": "Runolfsdottir-Gerlach",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 320
      }
    }
  },
  "Person": {
    "Position": "est",
    "PersonId": 54,
    "Mrmrs": "occaecati",
    "Firstname": "Malvina",
    "Lastname": "Gerlach",
    "MiddleName": "Greenfelder Inc and Sons",
    "Title": "beatae",
    "Description": "Reverse-engineered zero administration knowledge user",
    "Email": "kayla.torp@boyletorp.ca",
    "FullName": "Ms. Germaine McGlynn",
    "DirectPhone": "555.142.7510 x365",
    "FormalName": "Kunze, Lindgren and Monahan",
    "CountryId": 708,
    "ContactId": 608,
    "ContactName": "Von-Walker",
    "Retired": 707,
    "Rank": 589,
    "ActiveInterests": 974,
    "ContactDepartment": "",
    "ContactCountryId": 221,
    "ContactOrgNr": "1158439",
    "FaxPhone": "410.656.5154 x08646",
    "MobilePhone": "1-713-047-7056",
    "ContactPhone": "(015)083-1426 x82784",
    "AssociateName": "Considine LLC",
    "AssociateId": 971,
    "UsePersonAddress": true,
    "ContactFax": "illum",
    "Kanafname": "maiores",
    "Kanalname": "mollitia",
    "Post1": "non",
    "Post2": "ex",
    "Post3": "ipsa",
    "EmailName": "ronny_ziemann@hudson.ca",
    "ContactFullName": "Ms. Hilton Swift",
    "ActiveErpLinks": 857,
    "TicketPriorityId": 600,
    "SupportLanguageId": 91,
    "SupportAssociateId": 4,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 683
      }
    }
  },
  "CustomerAlias": "eligendi",
  "CustomerHost": "nemo",
  "CustomerName": "Batz-Gutmann",
  "CustomerEmail": "lexus@torphy.uk",
  "CustomerPhone": "1-241-614-5123 x01804",
  "CustomerConsented": false,
  "CustomerCompanyName": "Gleason, Herzog and Hoeger",
  "Status": "Closed",
  "FirstMessage": "est",
  "LastMessage": "aliquid",
  "WhenRequested": "1997-04-14T14:58:03.4382433+02:00",
  "WhenStarted": "2013-12-16T14:58:03.4382433+01:00",
  "WhenEnded": "1995-09-06T14:58:03.4382433+02:00",
  "WhenIdle": "2014-10-31T14:58:03.4382433+01:00",
  "WhenFetched": "2004-02-13T14:58:03.4382433+01:00",
  "SessionKey": "a",
  "InitialQueuePos": 398,
  "AlertLevel": 657,
  "Rank": 780,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 652,
    "Name": "Lang, Feil and Stanton",
    "OrgNr": "1487038",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "eos",
    "DirectPhone": "1-107-135-0786",
    "AssociateId": 813,
    "CountryId": 404,
    "EmailAddress": "cary@torp.com",
    "Kananame": "laboriosam",
    "EmailAddressName": "willis@spinka.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Laurel King",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "possimus",
    "FullName": "Kristina Champlin",
    "IsOwnerContact": false,
    "ActiveErpLinks": 372,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 320
      }
    }
  },
  "Project": {
    "ProjectId": 864,
    "Name": "Russel, Smitham and Krajcik",
    "Description": "Diverse analyzing capacity",
    "URL": "http://www.example.com/",
    "Type": "veniam",
    "AssociateId": 180,
    "AssociateFullName": "Arnaldo Wisoky",
    "TypeId": 843,
    "Updated": "2018-08-22T14:58:03.4388898+02:00",
    "StatusId": 616,
    "Status": "est",
    "TextId": 437,
    "PublishTo": "2006-09-14T14:58:03.4388898+02:00",
    "PublishFrom": "2016-03-17T14:58:03.4388898+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1020299",
    "ActiveErpLinks": 915,
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
  "Sale": {
    "ContactName": "Kautzer Group",
    "SaleDate": "2009-01-03T14:58:03.4388898+01:00",
    "SaleId": 479,
    "Probability": 464,
    "Title": "nihil",
    "Amount": 11432.832,
    "Currency": "ab",
    "ProjectName": "Walker-Cummerata",
    "AssociateFullName": "Floyd Jaskolski",
    "Description": "Polarised directional portal",
    "Status": "Lost",
    "WeightedAmount": 4776.2159999999994,
    "ProjectId": 590,
    "EarningPercent": 30127.142,
    "Earning": 24178.809999999998,
    "ContactId": 664,
    "AssociateId": 371,
    "PersonId": 804,
    "SaleTypeId": 788,
    "SaleTypeName": "Kreiger-Batz",
    "PersonFullName": "Carey Bruen",
    "Completed": "Completed",
    "ActiveErpLinks": 645,
    "NextDueDate": "2004-09-16T14:58:03.4394299+02:00",
    "Number": "869175",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 136
      }
    }
  },
  "Ticket": {
    "TicketId": 388,
    "Title": "ad",
    "CreatedAt": "2013-02-03T14:58:03.4394299+01:00",
    "LastChanged": "2012-04-28T14:58:03.4394299+02:00",
    "ReadByOwner": "2002-09-11T14:58:03.4394299+02:00",
    "ReadByCustomer": "2007-10-20T14:58:03.4394299+02:00",
    "FirstReadByUser": "2018-08-16T14:58:03.4394299+02:00",
    "Activate": "2001-03-14T14:58:03.4394299+01:00",
    "ClosedAt": "2019-02-16T14:58:03.4394299+01:00",
    "RepliedAt": "2000-11-07T14:58:03.4394299+01:00",
    "AlertTimeout": "2021-02-25T14:58:03.4394299+01:00",
    "Deadline": "1998-09-02T14:58:03.4394299+02:00",
    "CreatedBy": 796,
    "CreatedByName": "Schultz, Botsford and Jast",
    "Author": "et",
    "OwnedBy": 75,
    "OwnedByName": "Berge Group",
    "Category": 55,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 718,
    "PriorityName": "Casper, Upton and Stamm",
    "BaseStatus": "Active",
    "TicketStatus": 196,
    "TicketStatusDisplayValue": "in",
    "Origin": "AutoGenerated",
    "CustId": 389,
    "PersonFirstname": "Anabel",
    "PersonMiddleName": "Botsford-Bednar",
    "PersonLastname": "Hilll",
    "PersonFullname": "modi",
    "AlertLevel": 396,
    "ConnectId": 96,
    "ReadStatus": "Green",
    "TimeToReply": 851,
    "RealTimeToReply": 930,
    "TimeToClose": 677,
    "RealTimeToClose": 287,
    "TimeSpentInternally": 491,
    "TimeSpentExternally": 552,
    "TimeSpentQueue": 158,
    "RealTimeSpentInternally": 63,
    "RealTimeSpentExternally": 377,
    "RealTimeSpentQueue": 109,
    "HasAttachment": false,
    "NumReplies": 261,
    "NumMessages": 466,
    "FromAddress": "porro",
    "ContactId": 989,
    "ContactName": "Frami, Dickinson and Senger",
    "OwnedByAssociateId": 388,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "strategize vertical experiences"
        },
        "FieldType": "System.String",
        "FieldLength": 746
      }
    }
  },
  "TransferTo": {
    "AssociateId": 707,
    "Name": "Smitham, Hintz and Williamson",
    "PersonId": 969,
    "Rank": 869,
    "Tooltip": "ducimus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 359,
    "FullName": "Mr. Giuseppe Dooley",
    "FormalName": "Thompson-Schinner",
    "Deleted": false,
    "EjUserId": 119,
    "UserName": "Hoeger-Kirlin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 525
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
      "FieldLength": 414
    }
  }
}
```