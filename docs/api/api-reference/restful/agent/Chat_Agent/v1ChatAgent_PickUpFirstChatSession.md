---
title: PickUpFirstChatSession
id: v1ChatAgent_PickUpFirstChatSession
---

# PickUpFirstChatSession

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
| ChatbotIsActive | bool | Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Chat/PickUpFirstChatSession
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 747,
  "TopicId": 502,
  "User": {
    "AssociateId": 71,
    "Name": "Kub-Botsford",
    "PersonId": 728,
    "Rank": 382,
    "Tooltip": "temporibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 867,
    "FullName": "Maida Gaylord",
    "FormalName": "Schuppe LLC",
    "Deleted": false,
    "EjUserId": 474,
    "UserName": "Kiehn, Kling and Hintz",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 687
      }
    }
  },
  "Person": {
    "Position": "accusamus",
    "PersonId": 367,
    "Mrmrs": "doloribus",
    "Firstname": "Jesse",
    "Lastname": "Hackett",
    "MiddleName": "Dickinson LLC",
    "Title": "asperiores",
    "Description": "Digitized next generation capacity",
    "Email": "margaretta_volkman@okeefe.com",
    "FullName": "Mrs. Giovanni Gusikowski",
    "DirectPhone": "655-300-7317",
    "FormalName": "Heller, Ziemann and Schoen",
    "CountryId": 486,
    "ContactId": 760,
    "ContactName": "Grady, Bogan and Grant",
    "Retired": 540,
    "Rank": 703,
    "ActiveInterests": 134,
    "ContactDepartment": "",
    "ContactCountryId": 838,
    "ContactOrgNr": "663490",
    "FaxPhone": "1-156-001-4615 x1524",
    "MobilePhone": "1-814-575-3282 x048",
    "ContactPhone": "640-312-4163 x626",
    "AssociateName": "Corwin-Collins",
    "AssociateId": 434,
    "UsePersonAddress": true,
    "ContactFax": "quia",
    "Kanafname": "autem",
    "Kanalname": "consequatur",
    "Post1": "sunt",
    "Post2": "ipsam",
    "Post3": "et",
    "EmailName": "meta_haley@cartercollins.com",
    "ContactFullName": "Dexter Wolff DDS",
    "ActiveErpLinks": 454,
    "TicketPriorityId": 207,
    "SupportLanguageId": 888,
    "SupportAssociateId": 580,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 864
      }
    }
  },
  "CustomerAlias": "alias",
  "CustomerHost": "illum",
  "CustomerName": "Wehner Inc and Sons",
  "CustomerEmail": "margarete.klocko@kling.us",
  "CustomerPhone": "(730)081-7714",
  "CustomerConsented": true,
  "CustomerCompanyName": "Kris Inc and Sons",
  "Status": "Closed",
  "FirstMessage": "dolor",
  "LastMessage": "non",
  "WhenRequested": "1994-07-05T14:58:03.5073162+02:00",
  "WhenStarted": "2014-10-06T14:58:03.5073162+02:00",
  "WhenEnded": "2002-12-05T14:58:03.5073162+01:00",
  "WhenIdle": "2019-04-16T14:58:03.5073162+02:00",
  "WhenFetched": "2006-10-17T14:58:03.5073162+02:00",
  "SessionKey": "quos",
  "InitialQueuePos": 565,
  "AlertLevel": 90,
  "Rank": 806,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 296,
    "Name": "Stiedemann-Senger",
    "OrgNr": "1284791",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "et",
    "DirectPhone": "(165)651-1474 x0583",
    "AssociateId": 812,
    "CountryId": 124,
    "EmailAddress": "jovanny@kuvalis.info",
    "Kananame": "qui",
    "EmailAddressName": "norberto@okon.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mr. Wilmer Funk",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "sunt",
    "FullName": "Mrs. Tyree Rippin",
    "IsOwnerContact": true,
    "ActiveErpLinks": 60,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 686
      }
    }
  },
  "Project": {
    "ProjectId": 631,
    "Name": "Ankunding-O'Connell",
    "Description": "Distributed directional toolset",
    "URL": "http://www.example.com/",
    "Type": "ipsa",
    "AssociateId": 346,
    "AssociateFullName": "Cathrine Mertz",
    "TypeId": 837,
    "Updated": "1996-04-17T14:58:03.5082818+02:00",
    "StatusId": 506,
    "Status": "tempora",
    "TextId": 457,
    "PublishTo": "1994-11-15T14:58:03.5082818+01:00",
    "PublishFrom": "2004-07-09T14:58:03.5082818+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "732299",
    "ActiveErpLinks": 60,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 177
      }
    }
  },
  "Sale": {
    "ContactName": "Mayer-Reinger",
    "SaleDate": "2000-11-18T14:58:03.5082818+01:00",
    "SaleId": 486,
    "Probability": 136,
    "Title": "facilis",
    "Amount": 23461.124,
    "Currency": "vel",
    "ProjectName": "Muller Inc and Sons",
    "AssociateFullName": "Sanford Tremblay",
    "Description": "Re-contextualized attitude-oriented protocol",
    "Status": "Lost",
    "WeightedAmount": 29810.608,
    "ProjectId": 983,
    "EarningPercent": 24896.496,
    "Earning": 22386.162,
    "ContactId": 60,
    "AssociateId": 938,
    "PersonId": 7,
    "SaleTypeId": 777,
    "SaleTypeName": "Dicki-Purdy",
    "PersonFullName": "Chris Koepp",
    "Completed": "Completed",
    "ActiveErpLinks": 980,
    "NextDueDate": "2010-06-20T14:58:03.5093128+02:00",
    "Number": "813652",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 765
      }
    }
  },
  "Ticket": {
    "TicketId": 643,
    "Title": "alias",
    "CreatedAt": "2008-07-17T14:58:03.5093128+02:00",
    "LastChanged": "1994-12-17T14:58:03.5093128+01:00",
    "ReadByOwner": "2011-07-16T14:58:03.5093128+02:00",
    "ReadByCustomer": "2017-03-19T14:58:03.5093128+01:00",
    "FirstReadByUser": "2014-01-28T14:58:03.5093128+01:00",
    "Activate": "2008-10-26T14:58:03.5093128+01:00",
    "ClosedAt": "2005-05-05T14:58:03.5093128+02:00",
    "RepliedAt": "2012-02-07T14:58:03.5093128+01:00",
    "AlertTimeout": "2004-08-01T14:58:03.5093128+02:00",
    "Deadline": "2005-05-15T14:58:03.5093128+02:00",
    "CreatedBy": 933,
    "CreatedByName": "Kassulke Inc and Sons",
    "Author": "accusamus",
    "OwnedBy": 161,
    "OwnedByName": "Brekke LLC",
    "Category": 444,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 753,
    "PriorityName": "Kub, Moore and Jakubowski",
    "BaseStatus": "Active",
    "TicketStatus": 967,
    "TicketStatusDisplayValue": "eius",
    "Origin": "AutoGenerated",
    "CustId": 850,
    "PersonFirstname": "Anais",
    "PersonMiddleName": "Bartell-Jakubowski",
    "PersonLastname": "Kassulke",
    "PersonFullname": "labore",
    "AlertLevel": 961,
    "ConnectId": 835,
    "ReadStatus": "Green",
    "TimeToReply": 173,
    "RealTimeToReply": 48,
    "TimeToClose": 366,
    "RealTimeToClose": 687,
    "TimeSpentInternally": 505,
    "TimeSpentExternally": 485,
    "TimeSpentQueue": 994,
    "RealTimeSpentInternally": 201,
    "RealTimeSpentExternally": 493,
    "RealTimeSpentQueue": 534,
    "HasAttachment": true,
    "NumReplies": 560,
    "NumMessages": 733,
    "FromAddress": "deleniti",
    "ContactId": 677,
    "ContactName": "Berge-Yundt",
    "OwnedByAssociateId": 385,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 198
      }
    }
  },
  "TransferTo": {
    "AssociateId": 371,
    "Name": "Pfeffer, Koelpin and Reynolds",
    "PersonId": 361,
    "Rank": 873,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 582,
    "FullName": "Boris Walter",
    "FormalName": "Casper, Wiza and Hudson",
    "Deleted": false,
    "EjUserId": 623,
    "UserName": "Kunze-Reinger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 249
      }
    }
  },
  "ChatbotIsActive": true,
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
      "FieldLength": 169
    }
  }
}
```