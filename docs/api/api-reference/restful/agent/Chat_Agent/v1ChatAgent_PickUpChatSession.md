---
title: POST Agents/Chat/PickUpChatSession
id: v1ChatAgent_PickUpChatSession
---

# POST Agents/Chat/PickUpChatSession

```http
POST /api/v1/Agents/Chat/PickUpChatSession
```

'answer' the session: assign the session to the user.

The welcome message is sent to the customer. Returns NULL if session was not in queue.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/PickUpChatSession?$select=name,department,category/id
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
POST /api/v1/Agents/Chat/PickUpChatSession
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 387
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 416,
  "TopicId": 953,
  "User": {
    "AssociateId": 265,
    "Name": "Bogisich-Halvorson",
    "PersonId": 376,
    "Rank": 912,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 114,
    "FullName": "Dereck Lehner",
    "FormalName": "O'Keefe, Boyer and Reynolds",
    "Deleted": true,
    "EjUserId": 608,
    "UserName": "Tromp, Champlin and Boyle",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 421
      }
    }
  },
  "Person": {
    "Position": "ipsum",
    "PersonId": 374,
    "Mrmrs": "reprehenderit",
    "Firstname": "River",
    "Lastname": "Rau",
    "MiddleName": "Stokes Group",
    "Title": "harum",
    "Description": "Balanced multi-state encryption",
    "Email": "emmitt@runte.uk",
    "FullName": "Bethel VonRueden",
    "DirectPhone": "501-487-8455",
    "FormalName": "Marquardt Inc and Sons",
    "CountryId": 423,
    "ContactId": 818,
    "ContactName": "Schinner, Dare and Corwin",
    "Retired": 461,
    "Rank": 557,
    "ActiveInterests": 117,
    "ContactDepartment": "",
    "ContactCountryId": 720,
    "ContactOrgNr": "1159749",
    "FaxPhone": "(224)425-3157 x3066",
    "MobilePhone": "060.663.3254 x844",
    "ContactPhone": "1-436-416-2110 x862",
    "AssociateName": "Will LLC",
    "AssociateId": 153,
    "UsePersonAddress": true,
    "ContactFax": "repellat",
    "Kanafname": "eveniet",
    "Kanalname": "accusantium",
    "Post1": "sit",
    "Post2": "molestiae",
    "Post3": "sint",
    "EmailName": "carter@orn.ca",
    "ContactFullName": "Joyce Beatty",
    "ActiveErpLinks": 324,
    "TicketPriorityId": 952,
    "SupportLanguageId": 562,
    "SupportAssociateId": 69,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 274
      }
    }
  },
  "CustomerAlias": "sed",
  "CustomerHost": "non",
  "CustomerName": "Kreiger, Kuhn and Lubowitz",
  "CustomerEmail": "miracle_stokes@hahn.biz",
  "CustomerPhone": "758.475.8660 x3426",
  "CustomerConsented": true,
  "CustomerCompanyName": "Lubowitz-Rodriguez",
  "Status": "Closed",
  "FirstMessage": "iusto",
  "LastMessage": "quia",
  "WhenRequested": "2003-02-22T16:48:28.9409255+01:00",
  "WhenStarted": "2003-04-19T16:48:28.9409255+02:00",
  "WhenEnded": "1997-08-04T16:48:28.9409255+02:00",
  "WhenIdle": "2003-01-11T16:48:28.9409255+01:00",
  "WhenFetched": "2003-02-02T16:48:28.9409255+01:00",
  "SessionKey": "aut",
  "InitialQueuePos": 687,
  "AlertLevel": 338,
  "Rank": 320,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 138,
    "Name": "Hartmann-Thiel",
    "OrgNr": "993363",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "aut",
    "DirectPhone": "124-153-6468 x343",
    "AssociateId": 278,
    "CountryId": 840,
    "EmailAddress": "wava@kutch.uk",
    "Kananame": "modi",
    "EmailAddressName": "kamryn@donnellypacocha.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Camilla Hudson",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "voluptas",
    "FullName": "Gideon Hills",
    "IsOwnerContact": true,
    "ActiveErpLinks": 16,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 643
      }
    }
  },
  "Project": {
    "ProjectId": 337,
    "Name": "Pfeffer-Dach",
    "Description": "Balanced 5th generation contingency",
    "URL": "http://www.example.com/",
    "Type": "commodi",
    "AssociateId": 542,
    "AssociateFullName": "Adelle Eichmann Jr.",
    "TypeId": 278,
    "Updated": "2003-12-28T16:48:28.9419265+01:00",
    "StatusId": 995,
    "Status": "dicta",
    "TextId": 19,
    "PublishTo": "1996-03-15T16:48:28.9419265+01:00",
    "PublishFrom": "1998-06-04T16:48:28.9419265+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1469689",
    "ActiveErpLinks": 833,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 238
      }
    }
  },
  "Sale": {
    "ContactName": "Jerde, Fay and Herzog",
    "SaleDate": "1996-12-14T16:48:28.9419265+01:00",
    "SaleId": 557,
    "Probability": 854,
    "Title": "eos",
    "Amount": 19825.684,
    "Currency": "alias",
    "ProjectName": "Stark, Kling and Roob",
    "AssociateFullName": "Evelyn Botsford PhD",
    "Description": "Ameliorated neutral challenge",
    "Status": "Lost",
    "WeightedAmount": 22802.984,
    "ProjectId": 504,
    "EarningPercent": 22006.948,
    "Earning": 26287.992,
    "ContactId": 553,
    "AssociateId": 229,
    "PersonId": 592,
    "SaleTypeId": 589,
    "SaleTypeName": "Champlin Group",
    "PersonFullName": "Osbaldo Steuber",
    "Completed": "Completed",
    "ActiveErpLinks": 723,
    "NextDueDate": "1999-12-10T16:48:28.9419265+01:00",
    "Number": "514984",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 48
      }
    }
  },
  "Ticket": {
    "TicketId": 110,
    "Title": "et",
    "CreatedAt": "2004-09-30T16:48:28.9419265+02:00",
    "LastChanged": "2018-04-13T16:48:28.9419265+02:00",
    "ReadByOwner": "2006-03-12T16:48:28.9419265+01:00",
    "ReadByCustomer": "2004-05-23T16:48:28.9419265+02:00",
    "FirstReadByUser": "2015-04-30T16:48:28.9419265+02:00",
    "Activate": "1994-08-04T16:48:28.9419265+02:00",
    "ClosedAt": "2014-05-10T16:48:28.9419265+02:00",
    "RepliedAt": "2018-12-20T16:48:28.9419265+01:00",
    "AlertTimeout": "2003-12-06T16:48:28.9419265+01:00",
    "Deadline": "2010-09-14T16:48:28.9419265+02:00",
    "CreatedBy": 854,
    "CreatedByName": "Watsica Group",
    "Author": "nobis",
    "OwnedBy": 708,
    "OwnedByName": "Wolff-Renner",
    "Category": 977,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 186,
    "BaseStatus": "Active",
    "TicketStatus": 88,
    "Origin": "AutoGenerated",
    "CustId": 689,
    "CustFirstname": "Melyssa",
    "CustMiddleName": "Schumm-Kling",
    "CustLastname": "Medhurst",
    "AlertLevel": 447,
    "ConnectId": 689,
    "ReadStatus": "Green",
    "TimeToReply": 484,
    "RealTimeToReply": 40,
    "TimeToClose": 684,
    "RealTimeToClose": 913,
    "TimeSpentInternally": 902,
    "TimeSpentExternally": 476,
    "TimeSpentQueue": 699,
    "RealTimeSpentInternally": 225,
    "RealTimeSpentExternally": 775,
    "RealTimeSpentQueue": 871,
    "HasAttachment": false,
    "NumReplies": 578,
    "NumMessages": 97,
    "FromAddress": "veritatis",
    "CustFullname": "iure",
    "TicketStatusDisplayValue": "nam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 179
      }
    }
  },
  "TransferTo": {
    "AssociateId": 530,
    "Name": "Graham, Lind and Parisian",
    "PersonId": 816,
    "Rank": 930,
    "Tooltip": "similique",
    "Type": "AnonymousAssociate",
    "GroupIdx": 287,
    "FullName": "Lulu Bailey",
    "FormalName": "Blick, Gaylord and Gorczany",
    "Deleted": true,
    "EjUserId": 412,
    "UserName": "Hammes-Weber",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 614
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
      "FieldLength": 561
    }
  }
}
```