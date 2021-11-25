---
title: POST Agents/Chat/ResetChatSession
id: v1ChatAgent_ResetChatSession
---

# POST Agents/Chat/ResetChatSession

```http
POST /api/v1/Agents/Chat/ResetChatSession
```

Reset chat session, put it back on the queue for pickup.

Used by bots to hand off a session to human





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/ResetChatSession?$select=name,department,category/id
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
POST /api/v1/Agents/Chat/ResetChatSession
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 544
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 569,
  "TopicId": 381,
  "User": {
    "AssociateId": 917,
    "Name": "Kulas, Dach and Murazik",
    "PersonId": 985,
    "Rank": 725,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 444,
    "FullName": "Frederik Hilll",
    "FormalName": "Beier Inc and Sons",
    "Deleted": true,
    "EjUserId": 163,
    "UserName": "Dare, Windler and Kirlin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 798
      }
    }
  },
  "Person": {
    "Position": "dolore",
    "PersonId": 958,
    "Mrmrs": "est",
    "Firstname": "Corbin",
    "Lastname": "Hane",
    "MiddleName": "Marvin LLC",
    "Title": "praesentium",
    "Description": "Devolved multi-tasking framework",
    "Email": "tierra@bayer.uk",
    "FullName": "Curtis Klein",
    "DirectPhone": "(518)457-4141",
    "FormalName": "Baumbach Group",
    "CountryId": 527,
    "ContactId": 43,
    "ContactName": "Renner LLC",
    "Retired": 662,
    "Rank": 651,
    "ActiveInterests": 990,
    "ContactDepartment": "",
    "ContactCountryId": 808,
    "ContactOrgNr": "1348152",
    "FaxPhone": "1-227-646-8551 x20758",
    "MobilePhone": "110.714.6761 x57023",
    "ContactPhone": "1-055-237-5301",
    "AssociateName": "VonRueden, Watsica and Pfannerstill",
    "AssociateId": 701,
    "UsePersonAddress": true,
    "ContactFax": "alias",
    "Kanafname": "et",
    "Kanalname": "rerum",
    "Post1": "minus",
    "Post2": "perferendis",
    "Post3": "vel",
    "EmailName": "bridgette@grahamreinger.co.uk",
    "ContactFullName": "Mrs. Wendell Ondricka",
    "ActiveErpLinks": 621,
    "TicketPriorityId": 314,
    "SupportLanguageId": 532,
    "SupportAssociateId": 660,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 801
      }
    }
  },
  "CustomerAlias": "veritatis",
  "CustomerHost": "corrupti",
  "CustomerName": "Boehm Inc and Sons",
  "CustomerEmail": "ethelyn.stiedemann@nolan.us",
  "CustomerPhone": "865.175.4003",
  "CustomerConsented": false,
  "CustomerCompanyName": "Collier Group",
  "Status": "Closed",
  "FirstMessage": "quibusdam",
  "LastMessage": "ut",
  "WhenRequested": "1996-04-20T18:28:48.3252864+02:00",
  "WhenStarted": "2002-11-26T18:28:48.3252864+01:00",
  "WhenEnded": "2019-10-23T18:28:48.3252864+02:00",
  "WhenIdle": "2010-08-13T18:28:48.3252864+02:00",
  "WhenFetched": "2018-03-24T18:28:48.3252864+01:00",
  "SessionKey": "omnis",
  "InitialQueuePos": 676,
  "AlertLevel": 393,
  "Rank": 92,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 268,
    "Name": "Franecki-Koss",
    "OrgNr": "1051964",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "quae",
    "DirectPhone": "838-626-1406 x718",
    "AssociateId": 348,
    "CountryId": 496,
    "EmailAddress": "elody_fisher@wiza.co.uk",
    "Kananame": "fugit",
    "EmailAddressName": "rodolfo@bauchmclaughlin.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Aylin Kuhlman DVM",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "aspernatur",
    "FullName": "Rick Gaylord",
    "IsOwnerContact": false,
    "ActiveErpLinks": 171,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 62
      }
    }
  },
  "Project": {
    "ProjectId": 503,
    "Name": "Wolf, Ward and Walter",
    "Description": "Monitored explicit ability",
    "URL": "http://www.example.com/",
    "Type": "recusandae",
    "AssociateId": 397,
    "AssociateFullName": "Kurtis Veum",
    "TypeId": 857,
    "Updated": "2007-02-23T18:28:48.3262861+01:00",
    "StatusId": 465,
    "Status": "natus",
    "TextId": 661,
    "PublishTo": "2018-12-21T18:28:48.3262861+01:00",
    "PublishFrom": "2009-03-04T18:28:48.3262861+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "987350",
    "ActiveErpLinks": 597,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 806
      }
    }
  },
  "Sale": {
    "ContactName": "O'Keefe, Trantow and Becker",
    "SaleDate": "1997-07-09T18:28:48.3262861+02:00",
    "SaleId": 937,
    "Probability": 688,
    "Title": "nam",
    "Amount": 23094.446,
    "Currency": "aspernatur",
    "ProjectName": "Adams Group",
    "AssociateFullName": "Brando VonRueden III",
    "Description": "Assimilated next generation system engine",
    "Status": "Lost",
    "WeightedAmount": 15980.266,
    "ProjectId": 955,
    "EarningPercent": 1150.1779999999999,
    "Earning": 15572.846,
    "ContactId": 780,
    "AssociateId": 141,
    "PersonId": 333,
    "SaleTypeId": 775,
    "SaleTypeName": "Leffler-Nader",
    "PersonFullName": "Name Aufderhar IV",
    "Completed": "Completed",
    "ActiveErpLinks": 921,
    "NextDueDate": "1998-07-30T18:28:48.3262861+02:00",
    "Number": "1123392",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 415
      }
    }
  },
  "Ticket": {
    "TicketId": 398,
    "Title": "id",
    "CreatedAt": "2009-01-21T18:28:48.3262861+01:00",
    "LastChanged": "2001-03-16T18:28:48.3262861+01:00",
    "ReadByOwner": "2005-11-10T18:28:48.3262861+01:00",
    "ReadByCustomer": "2009-11-29T18:28:48.3262861+01:00",
    "FirstReadByUser": "2019-03-15T18:28:48.3262861+01:00",
    "Activate": "2000-09-15T18:28:48.3262861+02:00",
    "ClosedAt": "1998-02-22T18:28:48.3262861+01:00",
    "RepliedAt": "2011-05-20T18:28:48.3262861+02:00",
    "AlertTimeout": "2019-02-24T18:28:48.3262861+01:00",
    "Deadline": "1998-07-12T18:28:48.3262861+02:00",
    "CreatedBy": 440,
    "CreatedByName": "Wiza, Hartmann and Windler",
    "Author": "similique",
    "OwnedBy": 420,
    "OwnedByName": "Crooks, Cummerata and Mertz",
    "Category": 900,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 184,
    "PriorityName": "Corwin-Wintheiser",
    "BaseStatus": "Active",
    "TicketStatus": 946,
    "TicketStatusDisplayValue": "aspernatur",
    "Origin": "AutoGenerated",
    "CustId": 536,
    "PersonFirstname": "Sallie",
    "PersonMiddleName": "Schimmel Inc and Sons",
    "PersonLastname": "Lemke",
    "PersonFullname": "officiis",
    "AlertLevel": 637,
    "ConnectId": 432,
    "ReadStatus": "Green",
    "TimeToReply": 482,
    "RealTimeToReply": 945,
    "TimeToClose": 380,
    "RealTimeToClose": 440,
    "TimeSpentInternally": 860,
    "TimeSpentExternally": 398,
    "TimeSpentQueue": 442,
    "RealTimeSpentInternally": 996,
    "RealTimeSpentExternally": 627,
    "RealTimeSpentQueue": 137,
    "HasAttachment": true,
    "NumReplies": 875,
    "NumMessages": 859,
    "FromAddress": "aliquam",
    "ContactId": 745,
    "ContactName": "Turcotte-Rath",
    "OwnedByAssociateId": 157,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 440
      }
    }
  },
  "TransferTo": {
    "AssociateId": 472,
    "Name": "Oberbrunner, Krajcik and Torp",
    "PersonId": 311,
    "Rank": 289,
    "Tooltip": "dolorem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 2,
    "FullName": "Weston Ratke Sr.",
    "FormalName": "Kutch LLC",
    "Deleted": true,
    "EjUserId": 348,
    "UserName": "Yundt Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 841
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
        "Reason": "synthesize collaborative web services"
      },
      "FieldType": "System.String",
      "FieldLength": 752
    }
  }
}
```