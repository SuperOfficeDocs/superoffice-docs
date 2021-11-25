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
| ChatbotIsActive | bool | Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Chat/PickUpChatSession
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 70
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 542,
  "TopicId": 744,
  "User": {
    "AssociateId": 561,
    "Name": "Botsford, Ondricka and Botsford",
    "PersonId": 794,
    "Rank": 980,
    "Tooltip": "vitae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 223,
    "FullName": "Ike Conn",
    "FormalName": "Stiedemann-White",
    "Deleted": true,
    "EjUserId": 210,
    "UserName": "Luettgen-Hoppe",
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
  "Person": {
    "Position": "mollitia",
    "PersonId": 956,
    "Mrmrs": "at",
    "Firstname": "Leta",
    "Lastname": "Torphy",
    "MiddleName": "Shanahan-Wolff",
    "Title": "sed",
    "Description": "De-engineered content-based protocol",
    "Email": "elody_white@rogahn.uk",
    "FullName": "Kaley Nader",
    "DirectPhone": "117-384-2315",
    "FormalName": "Moen Inc and Sons",
    "CountryId": 109,
    "ContactId": 315,
    "ContactName": "Ortiz-Simonis",
    "Retired": 986,
    "Rank": 968,
    "ActiveInterests": 706,
    "ContactDepartment": "",
    "ContactCountryId": 80,
    "ContactOrgNr": "1331307",
    "FaxPhone": "(830)462-8715 x07168",
    "MobilePhone": "564-365-6868 x462",
    "ContactPhone": "(035)047-2676 x528",
    "AssociateName": "Kuphal-Spencer",
    "AssociateId": 664,
    "UsePersonAddress": true,
    "ContactFax": "minima",
    "Kanafname": "voluptas",
    "Kanalname": "ducimus",
    "Post1": "aliquam",
    "Post2": "non",
    "Post3": "qui",
    "EmailName": "emanuel_okon@rogahngerlach.co.uk",
    "ContactFullName": "Benjamin Corwin DVM",
    "ActiveErpLinks": 905,
    "TicketPriorityId": 845,
    "SupportLanguageId": 717,
    "SupportAssociateId": 499,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "disintermediate ubiquitous e-services"
        },
        "FieldType": "System.Int32",
        "FieldLength": 655
      }
    }
  },
  "CustomerAlias": "dignissimos",
  "CustomerHost": "laboriosam",
  "CustomerName": "Wehner Inc and Sons",
  "CustomerEmail": "angus@carroll.biz",
  "CustomerPhone": "1-065-508-1031",
  "CustomerConsented": false,
  "CustomerCompanyName": "Marquardt-Moore",
  "Status": "Closed",
  "FirstMessage": "velit",
  "LastMessage": "distinctio",
  "WhenRequested": "2008-05-04T18:28:48.3032861+02:00",
  "WhenStarted": "2016-01-21T18:28:48.3032861+01:00",
  "WhenEnded": "2000-04-15T18:28:48.3032861+02:00",
  "WhenIdle": "2010-09-10T18:28:48.3032861+02:00",
  "WhenFetched": "2018-02-09T18:28:48.3032861+01:00",
  "SessionKey": "accusamus",
  "InitialQueuePos": 959,
  "AlertLevel": 90,
  "Rank": 28,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 911,
    "Name": "Schimmel-Hoeger",
    "OrgNr": "1624123",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "adipisci",
    "DirectPhone": "1-833-132-6420 x6451",
    "AssociateId": 89,
    "CountryId": 318,
    "EmailAddress": "ila@farrellwiegand.co.uk",
    "Kananame": "rerum",
    "EmailAddressName": "erna@dickinson.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Drake Volkman",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "et",
    "FullName": "Daphne Rogahn",
    "IsOwnerContact": false,
    "ActiveErpLinks": 145,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 83
      }
    }
  },
  "Project": {
    "ProjectId": 448,
    "Name": "McGlynn, Greenfelder and Olson",
    "Description": "Front-line tertiary focus group",
    "URL": "http://www.example.com/",
    "Type": "quibusdam",
    "AssociateId": 878,
    "AssociateFullName": "Maya Ward",
    "TypeId": 64,
    "Updated": "2009-07-17T18:28:48.3042883+02:00",
    "StatusId": 535,
    "Status": "beatae",
    "TextId": 556,
    "PublishTo": "2020-09-02T18:28:48.3042883+02:00",
    "PublishFrom": "2016-10-22T18:28:48.3042883+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "849318",
    "ActiveErpLinks": 869,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 87
      }
    }
  },
  "Sale": {
    "ContactName": "Dooley-Buckridge",
    "SaleDate": "2006-08-20T18:28:48.3052869+02:00",
    "SaleId": 805,
    "Probability": 579,
    "Title": "eveniet",
    "Amount": 30493.82,
    "Currency": "dolorum",
    "ProjectName": "Hagenes Inc and Sons",
    "AssociateFullName": "Kyra Rogahn",
    "Description": "Focused needs-based groupware",
    "Status": "Lost",
    "WeightedAmount": 16390.82,
    "ProjectId": 762,
    "EarningPercent": 12564.206,
    "Earning": 1153.312,
    "ContactId": 262,
    "AssociateId": 15,
    "PersonId": 961,
    "SaleTypeId": 73,
    "SaleTypeName": "Dicki, Douglas and Schaefer",
    "PersonFullName": "Domenica Pagac",
    "Completed": "Completed",
    "ActiveErpLinks": 145,
    "NextDueDate": "2018-06-07T18:28:48.3052869+02:00",
    "Number": "678526",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 935
      }
    }
  },
  "Ticket": {
    "TicketId": 725,
    "Title": "dolorum",
    "CreatedAt": "1996-08-12T18:28:48.3052869+02:00",
    "LastChanged": "2004-07-12T18:28:48.3052869+02:00",
    "ReadByOwner": "2018-08-11T18:28:48.3052869+02:00",
    "ReadByCustomer": "1999-08-13T18:28:48.3052869+02:00",
    "FirstReadByUser": "2021-08-31T18:28:48.3052869+02:00",
    "Activate": "2018-01-02T18:28:48.3052869+01:00",
    "ClosedAt": "2008-11-22T18:28:48.3052869+01:00",
    "RepliedAt": "2021-10-11T18:28:48.3052869+02:00",
    "AlertTimeout": "2009-11-21T18:28:48.3052869+01:00",
    "Deadline": "2002-05-18T18:28:48.3052869+02:00",
    "CreatedBy": 522,
    "CreatedByName": "Maggio-Gulgowski",
    "Author": "dolor",
    "OwnedBy": 676,
    "OwnedByName": "Lemke-Keebler",
    "Category": 852,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 425,
    "PriorityName": "D'Amore-Dooley",
    "BaseStatus": "Active",
    "TicketStatus": 977,
    "TicketStatusDisplayValue": "perspiciatis",
    "Origin": "AutoGenerated",
    "CustId": 315,
    "PersonFirstname": "Gerry",
    "PersonMiddleName": "Bashirian-Kerluke",
    "PersonLastname": "Pacocha",
    "PersonFullname": "adipisci",
    "AlertLevel": 647,
    "ConnectId": 407,
    "ReadStatus": "Green",
    "TimeToReply": 240,
    "RealTimeToReply": 453,
    "TimeToClose": 624,
    "RealTimeToClose": 585,
    "TimeSpentInternally": 923,
    "TimeSpentExternally": 897,
    "TimeSpentQueue": 808,
    "RealTimeSpentInternally": 750,
    "RealTimeSpentExternally": 542,
    "RealTimeSpentQueue": 516,
    "HasAttachment": true,
    "NumReplies": 445,
    "NumMessages": 770,
    "FromAddress": "non",
    "ContactId": 518,
    "ContactName": "Schowalter-Walter",
    "OwnedByAssociateId": 501,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 209
      }
    }
  },
  "TransferTo": {
    "AssociateId": 159,
    "Name": "Gibson LLC",
    "PersonId": 506,
    "Rank": 298,
    "Tooltip": "necessitatibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 588,
    "FullName": "Warren Wuckert",
    "FormalName": "Gottlieb-Hamill",
    "Deleted": true,
    "EjUserId": 850,
    "UserName": "Wilderman Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 227
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
      "FieldType": "System.String",
      "FieldLength": 347
    }
  }
}
```