---
title: CreateChatSessionForTopic
id: v1ChatAgent_CreateChatSessionForTopic
---

# CreateChatSessionForTopic

```http
POST /api/v1/Agents/Chat/CreateChatSessionForTopic
```

Create a new session on a chat topic







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/CreateChatSessionForTopic?$select=name,department,category/id
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

ChatTopicId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatTopicId | int32 |  |


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
POST /api/v1/Agents/Chat/CreateChatSessionForTopic
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 741
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 378,
  "TopicId": 249,
  "User": {
    "AssociateId": 717,
    "Name": "Cronin, Walter and D'Amore",
    "PersonId": 884,
    "Rank": 245,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 479,
    "FullName": "Pauline Prosacco",
    "FormalName": "Bosco, Klein and O'Conner",
    "Deleted": false,
    "EjUserId": 967,
    "UserName": "Klein-Hintz",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 612
      }
    }
  },
  "Person": {
    "Position": "voluptatem",
    "PersonId": 137,
    "Mrmrs": "natus",
    "Firstname": "Braulio",
    "Lastname": "Homenick",
    "MiddleName": "Stoltenberg-Rogahn",
    "Title": "numquam",
    "Description": "Object-based 4th generation Graphic Interface",
    "Email": "emmalee.auer@kirlin.ca",
    "FullName": "Mr. Hallie Turner",
    "DirectPhone": "(466)523-0648",
    "FormalName": "Jaskolski, Bogisich and Walsh",
    "CountryId": 347,
    "ContactId": 813,
    "ContactName": "Gaylord-Waters",
    "Retired": 949,
    "Rank": 810,
    "ActiveInterests": 57,
    "ContactDepartment": "",
    "ContactCountryId": 181,
    "ContactOrgNr": "773276",
    "FaxPhone": "354.564.3308 x52628",
    "MobilePhone": "124.384.6664 x8432",
    "ContactPhone": "013.618.3086 x428",
    "AssociateName": "Barrows, Gerhold and Mueller",
    "AssociateId": 872,
    "UsePersonAddress": true,
    "ContactFax": "repudiandae",
    "Kanafname": "quibusdam",
    "Kanalname": "accusamus",
    "Post1": "officiis",
    "Post2": "labore",
    "Post3": "ut",
    "EmailName": "owen.maggio@gottlieb.info",
    "ContactFullName": "Rae Farrell",
    "ActiveErpLinks": 592,
    "TicketPriorityId": 631,
    "SupportLanguageId": 445,
    "SupportAssociateId": 191,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 223
      }
    }
  },
  "CustomerAlias": "culpa",
  "CustomerHost": "ipsa",
  "CustomerName": "Waelchi-Halvorson",
  "CustomerEmail": "sandrine@brakus.info",
  "CustomerPhone": "754-428-8004 x364",
  "CustomerConsented": true,
  "CustomerCompanyName": "Pagac-Auer",
  "Status": "Closed",
  "FirstMessage": "perferendis",
  "LastMessage": "voluptatem",
  "WhenRequested": "1999-09-18T14:58:03.3992424+02:00",
  "WhenStarted": "2001-04-24T14:58:03.3992424+02:00",
  "WhenEnded": "2001-11-04T14:58:03.3992424+01:00",
  "WhenIdle": "2004-01-25T14:58:03.3992424+01:00",
  "WhenFetched": "1999-10-23T14:58:03.3992424+02:00",
  "SessionKey": "quisquam",
  "InitialQueuePos": 556,
  "AlertLevel": 713,
  "Rank": 272,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 188,
    "Name": "Stoltenberg, Powlowski and Gulgowski",
    "OrgNr": "1339919",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "provident",
    "DirectPhone": "1-583-171-2037 x1476",
    "AssociateId": 815,
    "CountryId": 646,
    "EmailAddress": "benny@kulas.com",
    "Kananame": "voluptatem",
    "EmailAddressName": "marielle@raynor.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Patricia Boyer",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "est",
    "FullName": "Luther Abshire IV",
    "IsOwnerContact": true,
    "ActiveErpLinks": 658,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 289
      }
    }
  },
  "Project": {
    "ProjectId": 82,
    "Name": "Kshlerin, Trantow and Pfannerstill",
    "Description": "Customer-focused zero defect algorithm",
    "URL": "http://www.example.com/",
    "Type": "ducimus",
    "AssociateId": 699,
    "AssociateFullName": "Miss Cierra DuBuque",
    "TypeId": 531,
    "Updated": "2006-09-15T14:58:03.4002416+02:00",
    "StatusId": 131,
    "Status": "quia",
    "TextId": 723,
    "PublishTo": "2002-11-25T14:58:03.4002416+01:00",
    "PublishFrom": "2004-10-14T14:58:03.4002416+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "886316",
    "ActiveErpLinks": 104,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 325
      }
    }
  },
  "Sale": {
    "ContactName": "Heathcote-Bode",
    "SaleDate": "2005-04-12T14:58:03.4002416+02:00",
    "SaleId": 41,
    "Probability": 235,
    "Title": "et",
    "Amount": 19935.374,
    "Currency": "facere",
    "ProjectName": "Pfannerstill Inc and Sons",
    "AssociateFullName": "Sam Schumm II",
    "Description": "Robust background orchestration",
    "Status": "Lost",
    "WeightedAmount": 20408.608,
    "ProjectId": 568,
    "EarningPercent": 12391.836,
    "Earning": 10282.654,
    "ContactId": 445,
    "AssociateId": 476,
    "PersonId": 221,
    "SaleTypeId": 36,
    "SaleTypeName": "Stamm Group",
    "PersonFullName": "Mr. Nicklaus Prohaska",
    "Completed": "Completed",
    "ActiveErpLinks": 167,
    "NextDueDate": "2013-07-23T14:58:03.4002416+02:00",
    "Number": "1445341",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 559
      }
    }
  },
  "Ticket": {
    "TicketId": 932,
    "Title": "nostrum",
    "CreatedAt": "2005-02-27T14:58:03.4002416+01:00",
    "LastChanged": "2013-11-09T14:58:03.4002416+01:00",
    "ReadByOwner": "2009-04-01T14:58:03.4002416+02:00",
    "ReadByCustomer": "2010-05-30T14:58:03.4002416+02:00",
    "FirstReadByUser": "1995-01-23T14:58:03.4002416+01:00",
    "Activate": "2004-11-03T14:58:03.4002416+01:00",
    "ClosedAt": "1995-04-01T14:58:03.4002416+02:00",
    "RepliedAt": "2002-09-07T14:58:03.4002416+02:00",
    "AlertTimeout": "2007-07-31T14:58:03.4002416+02:00",
    "Deadline": "2016-02-08T14:58:03.4002416+01:00",
    "CreatedBy": 712,
    "CreatedByName": "Connelly, Huels and Mills",
    "Author": "et",
    "OwnedBy": 244,
    "OwnedByName": "Wunsch-Hilpert",
    "Category": 164,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 163,
    "PriorityName": "Daugherty-Dietrich",
    "BaseStatus": "Active",
    "TicketStatus": 236,
    "TicketStatusDisplayValue": "quo",
    "Origin": "AutoGenerated",
    "CustId": 478,
    "PersonFirstname": "Christa",
    "PersonMiddleName": "Rohan-Rolfson",
    "PersonLastname": "Kemmer",
    "PersonFullname": "excepturi",
    "AlertLevel": 130,
    "ConnectId": 62,
    "ReadStatus": "Green",
    "TimeToReply": 388,
    "RealTimeToReply": 456,
    "TimeToClose": 508,
    "RealTimeToClose": 792,
    "TimeSpentInternally": 119,
    "TimeSpentExternally": 773,
    "TimeSpentQueue": 717,
    "RealTimeSpentInternally": 62,
    "RealTimeSpentExternally": 317,
    "RealTimeSpentQueue": 371,
    "HasAttachment": false,
    "NumReplies": 920,
    "NumMessages": 442,
    "FromAddress": "nostrum",
    "ContactId": 931,
    "ContactName": "Johnson, Price and Klocko",
    "OwnedByAssociateId": 917,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 959
      }
    }
  },
  "TransferTo": {
    "AssociateId": 782,
    "Name": "Wiegand, Koss and Hansen",
    "PersonId": 52,
    "Rank": 854,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 709,
    "FullName": "Gilberto Blick",
    "FormalName": "Larson-Leuschke",
    "Deleted": false,
    "EjUserId": 29,
    "UserName": "Gislason-Dare",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 123
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
      "FieldLength": 194
    }
  }
}
```