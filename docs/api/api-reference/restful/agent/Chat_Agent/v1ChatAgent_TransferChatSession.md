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
| ChatbotIsActive | bool | Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Chat/TransferChatSession
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 582,
  "ToAssociate": "quo"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 124,
  "TopicId": 430,
  "User": {
    "AssociateId": 395,
    "Name": "Schultz Inc and Sons",
    "PersonId": 42,
    "Rank": 954,
    "Tooltip": "similique",
    "Type": "AnonymousAssociate",
    "GroupIdx": 565,
    "FullName": "Mrs. Caleigh Grimes",
    "FormalName": "Cassin LLC",
    "Deleted": true,
    "EjUserId": 976,
    "UserName": "Predovic Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 766
      }
    }
  },
  "Person": {
    "Position": "id",
    "PersonId": 73,
    "Mrmrs": "ipsum",
    "Firstname": "Aditya",
    "Lastname": "Trantow",
    "MiddleName": "Schultz Inc and Sons",
    "Title": "magnam",
    "Description": "Optional executive initiative",
    "Email": "matilde.gutmann@rutherford.biz",
    "FullName": "Margret Volkman",
    "DirectPhone": "656-512-2244",
    "FormalName": "Aufderhar-Hickle",
    "CountryId": 828,
    "ContactId": 483,
    "ContactName": "Smitham Inc and Sons",
    "Retired": 923,
    "Rank": 619,
    "ActiveInterests": 623,
    "ContactDepartment": "",
    "ContactCountryId": 62,
    "ContactOrgNr": "1311402",
    "FaxPhone": "865.314.0751",
    "MobilePhone": "602.021.2523",
    "ContactPhone": "1-488-362-3552 x58255",
    "AssociateName": "Heathcote Group",
    "AssociateId": 923,
    "UsePersonAddress": true,
    "ContactFax": "nemo",
    "Kanafname": "quia",
    "Kanalname": "facilis",
    "Post1": "in",
    "Post2": "dolorem",
    "Post3": "expedita",
    "EmailName": "alta.renner@rueckerroberts.info",
    "ContactFullName": "Tiffany Medhurst",
    "ActiveErpLinks": 44,
    "TicketPriorityId": 96,
    "SupportLanguageId": 85,
    "SupportAssociateId": 995,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 894
      }
    }
  },
  "CustomerAlias": "commodi",
  "CustomerHost": "quo",
  "CustomerName": "Carter Group",
  "CustomerEmail": "berneice@wyman.ca",
  "CustomerPhone": "123.865.1182 x66005",
  "CustomerConsented": true,
  "CustomerCompanyName": "Williamson, Waters and Wilkinson",
  "Status": "Closed",
  "FirstMessage": "sit",
  "LastMessage": "laborum",
  "WhenRequested": "2003-08-28T18:28:48.2742582+02:00",
  "WhenStarted": "2006-12-25T18:28:48.2742582+01:00",
  "WhenEnded": "2004-07-06T18:28:48.2742582+02:00",
  "WhenIdle": "2020-09-14T18:28:48.2742582+02:00",
  "WhenFetched": "2007-09-01T18:28:48.2742582+02:00",
  "SessionKey": "quo",
  "InitialQueuePos": 427,
  "AlertLevel": 129,
  "Rank": 893,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 179,
    "Name": "Fritsch, Hagenes and Mohr",
    "OrgNr": "1186505",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "commodi",
    "DirectPhone": "1-146-167-5628 x2200",
    "AssociateId": 517,
    "CountryId": 78,
    "EmailAddress": "betsy@harber.name",
    "Kananame": "aspernatur",
    "EmailAddressName": "lilla.beahan@ward.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Charles Hagenes",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quam",
    "FullName": "Miss Jabari McClure",
    "IsOwnerContact": false,
    "ActiveErpLinks": 900,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 94
      }
    }
  },
  "Project": {
    "ProjectId": 169,
    "Name": "Grant-McDermott",
    "Description": "Assimilated static access",
    "URL": "http://www.example.com/",
    "Type": "aut",
    "AssociateId": 90,
    "AssociateFullName": "Mrs. Emelie Murazik",
    "TypeId": 372,
    "Updated": "1995-01-30T18:28:48.2752863+01:00",
    "StatusId": 686,
    "Status": "dolores",
    "TextId": 666,
    "PublishTo": "2012-08-11T18:28:48.2752863+02:00",
    "PublishFrom": "2000-12-18T18:28:48.2752863+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1558253",
    "ActiveErpLinks": 568,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 952
      }
    }
  },
  "Sale": {
    "ContactName": "Lang, Hegmann and Funk",
    "SaleDate": "1997-10-20T18:28:48.2752863+02:00",
    "SaleId": 452,
    "Probability": 644,
    "Title": "numquam",
    "Amount": 2209.47,
    "Currency": "et",
    "ProjectName": "Frami-Hermann",
    "AssociateFullName": "Isidro Shanahan",
    "Description": "Diverse systemic conglomeration",
    "Status": "Lost",
    "WeightedAmount": 1921.1419999999998,
    "ProjectId": 611,
    "EarningPercent": 23599.02,
    "Earning": 12626.886,
    "ContactId": 373,
    "AssociateId": 595,
    "PersonId": 723,
    "SaleTypeId": 468,
    "SaleTypeName": "Kiehn-Kutch",
    "PersonFullName": "Hanna Lubowitz",
    "Completed": "Completed",
    "ActiveErpLinks": 61,
    "NextDueDate": "2001-06-15T18:28:48.2752863+02:00",
    "Number": "1257528",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 311
      }
    }
  },
  "Ticket": {
    "TicketId": 724,
    "Title": "accusamus",
    "CreatedAt": "2012-08-30T18:28:48.2752863+02:00",
    "LastChanged": "2020-04-18T18:28:48.2752863+02:00",
    "ReadByOwner": "2018-08-31T18:28:48.2752863+02:00",
    "ReadByCustomer": "2004-12-01T18:28:48.2752863+01:00",
    "FirstReadByUser": "2011-12-05T18:28:48.2752863+01:00",
    "Activate": "2016-08-02T18:28:48.2752863+02:00",
    "ClosedAt": "2001-09-18T18:28:48.2752863+02:00",
    "RepliedAt": "2013-11-25T18:28:48.2752863+01:00",
    "AlertTimeout": "2009-08-05T18:28:48.2752863+02:00",
    "Deadline": "2001-09-22T18:28:48.2752863+02:00",
    "CreatedBy": 504,
    "CreatedByName": "Block-Beahan",
    "Author": "maxime",
    "OwnedBy": 670,
    "OwnedByName": "Bruen, Kunde and Skiles",
    "Category": 803,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 391,
    "PriorityName": "Green LLC",
    "BaseStatus": "Active",
    "TicketStatus": 564,
    "TicketStatusDisplayValue": "ullam",
    "Origin": "AutoGenerated",
    "CustId": 69,
    "PersonFirstname": "Jesus",
    "PersonMiddleName": "Ondricka LLC",
    "PersonLastname": "Sauer",
    "PersonFullname": "nemo",
    "AlertLevel": 197,
    "ConnectId": 121,
    "ReadStatus": "Green",
    "TimeToReply": 123,
    "RealTimeToReply": 559,
    "TimeToClose": 271,
    "RealTimeToClose": 842,
    "TimeSpentInternally": 290,
    "TimeSpentExternally": 390,
    "TimeSpentQueue": 77,
    "RealTimeSpentInternally": 398,
    "RealTimeSpentExternally": 399,
    "RealTimeSpentQueue": 610,
    "HasAttachment": false,
    "NumReplies": 37,
    "NumMessages": 537,
    "FromAddress": "qui",
    "ContactId": 542,
    "ContactName": "Orn Inc and Sons",
    "OwnedByAssociateId": 731,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 411
      }
    }
  },
  "TransferTo": {
    "AssociateId": 581,
    "Name": "Muller, Hyatt and Torphy",
    "PersonId": 834,
    "Rank": 806,
    "Tooltip": "porro",
    "Type": "AnonymousAssociate",
    "GroupIdx": 828,
    "FullName": "Ralph Kilback",
    "FormalName": "Cormier LLC",
    "Deleted": false,
    "EjUserId": 904,
    "UserName": "Farrell-Koepp",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 242
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
      "FieldLength": 87
    }
  }
}
```