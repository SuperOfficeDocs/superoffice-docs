---
title: POST ChatSession/Pickup
id: v1ChatSessionEntity_PickUpFirstChatSession
---

# POST ChatSession/Pickup

```http
POST /api/v1/ChatSession/Pickup
```

'answer' the first available session from the queue: assign the session to the user.

The welcome message is sent to the customer.






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
POST /api/v1/ChatSession/Pickup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 813,
  "TopicId": 115,
  "User": {
    "AssociateId": 482,
    "Name": "McDermott LLC",
    "PersonId": 64,
    "Rank": 150,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 239,
    "FullName": "Kolby Abbott",
    "FormalName": "Kling LLC",
    "Deleted": false,
    "EjUserId": 418,
    "UserName": "Towne, Watsica and Beier",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 714
      }
    }
  },
  "Person": {
    "Position": "nobis",
    "PersonId": 465,
    "Mrmrs": "et",
    "Firstname": "Agustina",
    "Lastname": "Pfannerstill",
    "MiddleName": "Smitham Inc and Sons",
    "Title": "exercitationem",
    "Description": "Polarised 4th generation open architecture",
    "Email": "madyson@thiel.uk",
    "FullName": "Emma Wiza",
    "DirectPhone": "238.137.1733 x612",
    "FormalName": "Pfeffer-Trantow",
    "CountryId": 939,
    "ContactId": 273,
    "ContactName": "VonRueden-Johnston",
    "Retired": 804,
    "Rank": 969,
    "ActiveInterests": 202,
    "ContactDepartment": "",
    "ContactCountryId": 404,
    "ContactOrgNr": "869396",
    "FaxPhone": "1-243-462-5673",
    "MobilePhone": "(542)507-3415",
    "ContactPhone": "1-080-143-6204 x440",
    "AssociateName": "Gutmann, O'Reilly and Lindgren",
    "AssociateId": 306,
    "UsePersonAddress": true,
    "ContactFax": "illo",
    "Kanafname": "ipsa",
    "Kanalname": "et",
    "Post1": "nemo",
    "Post2": "quae",
    "Post3": "autem",
    "EmailName": "omer@kessler.ca",
    "ContactFullName": "Clark Bayer",
    "ActiveErpLinks": 615,
    "TicketPriorityId": 403,
    "SupportLanguageId": 759,
    "SupportAssociateId": 98,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "unleash synergistic channels"
        },
        "FieldType": "System.String",
        "FieldLength": 182
      }
    }
  },
  "CustomerAlias": "iusto",
  "CustomerHost": "dolor",
  "CustomerName": "Roob, Feest and Wuckert",
  "CustomerEmail": "kaleigh@wolf.co.uk",
  "CustomerPhone": "(348)284-7034 x2173",
  "CustomerConsented": false,
  "CustomerCompanyName": "Sporer-Fadel",
  "Status": "Closed",
  "FirstMessage": "laboriosam",
  "LastMessage": "voluptatem",
  "WhenRequested": "2008-12-12T09:40:58.8163549+01:00",
  "WhenStarted": "2002-09-28T09:40:58.8163549+02:00",
  "WhenEnded": "2011-05-20T09:40:58.8163549+02:00",
  "WhenIdle": "1999-01-26T09:40:58.8163549+01:00",
  "WhenFetched": "2019-05-05T09:40:58.8163549+02:00",
  "SessionKey": "reprehenderit",
  "InitialQueuePos": 428,
  "AlertLevel": 11,
  "Rank": 977,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 775,
    "Name": "Schinner Group",
    "OrgNr": "1534496",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "doloremque",
    "DirectPhone": "1-543-550-3617 x3114",
    "AssociateId": 559,
    "CountryId": 589,
    "EmailAddress": "raleigh_bechtelar@goodwin.ca",
    "Kananame": "magnam",
    "EmailAddressName": "selmer.west@yundt.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Blaze Zulauf",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "dolores",
    "FullName": "Adolfo Padberg",
    "IsOwnerContact": false,
    "ActiveErpLinks": 139,
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
  "Project": {
    "ProjectId": 413,
    "Name": "Williamson LLC",
    "Description": "Robust zero defect open system",
    "URL": "http://www.example.com/",
    "Type": "voluptas",
    "AssociateId": 854,
    "AssociateFullName": "Enid Hyatt",
    "TypeId": 503,
    "Updated": "2010-06-07T09:40:58.8173418+02:00",
    "StatusId": 190,
    "Status": "aliquid",
    "TextId": 933,
    "PublishTo": "2003-04-10T09:40:58.8173418+02:00",
    "PublishFrom": "2002-10-01T09:40:58.8173418+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1087916",
    "ActiveErpLinks": 314,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 403
      }
    }
  },
  "Sale": {
    "ContactName": "Kub Group",
    "SaleDate": "2017-04-15T09:40:58.8173418+02:00",
    "SaleId": 347,
    "Probability": 467,
    "Title": "maiores",
    "Amount": 19076.658,
    "Currency": "incidunt",
    "ProjectName": "Jerde, Schiller and Corkery",
    "AssociateFullName": "Chance Bashirian IV",
    "Description": "Face to face needs-based focus group",
    "Status": "Lost",
    "WeightedAmount": 21934.865999999998,
    "ProjectId": 451,
    "EarningPercent": 20414.876,
    "Earning": 30534.561999999998,
    "ContactId": 693,
    "AssociateId": 463,
    "PersonId": 121,
    "SaleTypeId": 635,
    "SaleTypeName": "Herman, Wolff and Ferry",
    "PersonFullName": "Alda Daugherty",
    "Completed": "Completed",
    "ActiveErpLinks": 37,
    "NextDueDate": "2012-06-20T09:40:58.8183424+02:00",
    "Number": "389944",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 262
      }
    }
  },
  "Ticket": {
    "TicketId": 646,
    "Title": "quis",
    "CreatedAt": "2017-06-12T09:40:58.8183424+02:00",
    "LastChanged": "2018-05-25T09:40:58.8183424+02:00",
    "ReadByOwner": "2006-10-05T09:40:58.8183424+02:00",
    "ReadByCustomer": "2019-05-29T09:40:58.8183424+02:00",
    "FirstReadByUser": "2001-08-15T09:40:58.8183424+02:00",
    "Activate": "2000-09-10T09:40:58.8183424+02:00",
    "ClosedAt": "1998-12-13T09:40:58.8183424+01:00",
    "RepliedAt": "2013-10-07T09:40:58.8183424+02:00",
    "AlertTimeout": "2002-03-21T09:40:58.8183424+01:00",
    "Deadline": "2002-03-26T09:40:58.8183424+01:00",
    "CreatedBy": 493,
    "CreatedByName": "Ledner-Kuhlman",
    "Author": "nostrum",
    "OwnedBy": 486,
    "OwnedByName": "Lubowitz-Satterfield",
    "Category": 185,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 986,
    "BaseStatus": "Active",
    "TicketStatus": 963,
    "Origin": "AutoGenerated",
    "CustId": 152,
    "CustFirstname": "Kacie",
    "CustMiddleName": "Murray, Hudson and Harber",
    "CustLastname": "Franecki",
    "AlertLevel": 174,
    "ConnectId": 982,
    "ReadStatus": "Green",
    "TimeToReply": 414,
    "RealTimeToReply": 287,
    "TimeToClose": 264,
    "RealTimeToClose": 490,
    "TimeSpentInternally": 554,
    "TimeSpentExternally": 754,
    "TimeSpentQueue": 486,
    "RealTimeSpentInternally": 361,
    "RealTimeSpentExternally": 546,
    "RealTimeSpentQueue": 939,
    "HasAttachment": false,
    "NumReplies": 701,
    "NumMessages": 559,
    "FromAddress": "suscipit",
    "CustFullname": "sunt",
    "TicketStatusDisplayValue": "odit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "streamline scalable communities"
        },
        "FieldType": "System.String",
        "FieldLength": 282
      }
    }
  },
  "TransferTo": {
    "AssociateId": 274,
    "Name": "Gutkowski Inc and Sons",
    "PersonId": 136,
    "Rank": 356,
    "Tooltip": "ab",
    "Type": "AnonymousAssociate",
    "GroupIdx": 200,
    "FullName": "Anjali Fahey III",
    "FormalName": "Muller-Waters",
    "Deleted": true,
    "EjUserId": 811,
    "UserName": "Wolf-McKenzie",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 586
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
      "FieldLength": 32
    }
  }
}
```