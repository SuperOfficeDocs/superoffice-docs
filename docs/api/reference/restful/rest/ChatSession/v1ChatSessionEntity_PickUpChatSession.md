---
title: POST ChatSession/{id}/Pickup
id: v1ChatSessionEntity_PickUpChatSession
---

# POST ChatSession/{id}/Pickup

```http
POST /api/v1/ChatSession/{chatSessionId}/Pickup
```

'answer' the session: assign the session to the user.

The welcome message is sent to the customer. Returns NULL if session was not in queue.




| Path Part | Type | Description |
|-----------|------|-------------|
| chatSessionId | int32 | id of the chat session to answer **Required** |



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
POST /api/v1/ChatSession/{chatSessionId}/Pickup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 138,
  "TopicId": 680,
  "User": {
    "AssociateId": 518,
    "Name": "Nikolaus-Sporer",
    "PersonId": 589,
    "Rank": 742,
    "Tooltip": "magnam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 802,
    "FullName": "Miss John Kemmer",
    "FormalName": "Armstrong, Pfeffer and Tromp",
    "Deleted": true,
    "EjUserId": 883,
    "UserName": "Muller Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 352
      }
    }
  },
  "Person": {
    "Position": "quisquam",
    "PersonId": 813,
    "Mrmrs": "culpa",
    "Firstname": "Cordell",
    "Lastname": "Collins",
    "MiddleName": "Jones, White and Hauck",
    "Title": "quidem",
    "Description": "Operative high-level flexibility",
    "Email": "mose@raynor.ca",
    "FullName": "Karson Ryan",
    "DirectPhone": "(384)471-3542",
    "FormalName": "Kautzer-Marks",
    "CountryId": 376,
    "ContactId": 480,
    "ContactName": "Bernhard LLC",
    "Retired": 425,
    "Rank": 497,
    "ActiveInterests": 348,
    "ContactDepartment": "",
    "ContactCountryId": 295,
    "ContactOrgNr": "841359",
    "FaxPhone": "678.125.7860",
    "MobilePhone": "(342)278-0722 x30541",
    "ContactPhone": "1-285-501-5456",
    "AssociateName": "Tromp-Weber",
    "AssociateId": 626,
    "UsePersonAddress": false,
    "ContactFax": "velit",
    "Kanafname": "libero",
    "Kanalname": "eos",
    "Post1": "rem",
    "Post2": "amet",
    "Post3": "inventore",
    "EmailName": "esteban_hamill@dickinsonlesch.ca",
    "ContactFullName": "Mr. Jana Schultz",
    "ActiveErpLinks": 211,
    "TicketPriorityId": 910,
    "SupportLanguageId": 769,
    "SupportAssociateId": 647,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 888
      }
    }
  },
  "CustomerAlias": "est",
  "CustomerHost": "tempore",
  "CustomerName": "Swaniawski Inc and Sons",
  "CustomerEmail": "alessia.prosacco@jakubowskicole.biz",
  "CustomerPhone": "837.630.5485",
  "CustomerConsented": true,
  "CustomerCompanyName": "Hilpert, Mitchell and Hahn",
  "Status": "Closed",
  "FirstMessage": "est",
  "LastMessage": "quis",
  "WhenRequested": "2004-09-26T18:25:50.1305954+02:00",
  "WhenStarted": "2020-12-14T18:25:50.1305954+01:00",
  "WhenEnded": "2018-02-18T18:25:50.1305954+01:00",
  "WhenIdle": "2002-11-04T18:25:50.1305954+01:00",
  "WhenFetched": "1997-09-20T18:25:50.1305954+02:00",
  "SessionKey": "dolores",
  "InitialQueuePos": 609,
  "AlertLevel": 450,
  "Rank": 59,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 79,
    "Name": "McCullough Group",
    "OrgNr": "1426876",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "culpa",
    "DirectPhone": "(164)335-3133",
    "AssociateId": 634,
    "CountryId": 755,
    "EmailAddress": "kayli@gerlach.info",
    "Kananame": "delectus",
    "EmailAddressName": "shayne@hoeger.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Kayleigh Powlowski",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quis",
    "FullName": "Cortney Jaskolski",
    "IsOwnerContact": true,
    "ActiveErpLinks": 586,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 74
      }
    }
  },
  "Project": {
    "ProjectId": 485,
    "Name": "Murphy Group",
    "Description": "Function-based solution-oriented adapter",
    "URL": "http://www.example.com/",
    "Type": "dolores",
    "AssociateId": 518,
    "AssociateFullName": "Lucio Wuckert",
    "TypeId": 112,
    "Updated": "2016-12-17T18:25:50.1315953+01:00",
    "StatusId": 846,
    "Status": "aperiam",
    "TextId": 705,
    "PublishTo": "1999-05-27T18:25:50.1315953+02:00",
    "PublishFrom": "2006-03-28T18:25:50.1315953+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1592184",
    "ActiveErpLinks": 349,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 556
      }
    }
  },
  "Sale": {
    "ContactName": "Strosin, Hartmann and Turcotte",
    "SaleDate": "2007-06-14T18:25:50.1315953+02:00",
    "SaleId": 482,
    "Probability": 931,
    "Title": "dignissimos",
    "Amount": 1811.452,
    "Currency": "omnis",
    "ProjectName": "Beier, Daugherty and Schmitt",
    "AssociateFullName": "Rebecca Bradtke",
    "Description": "Enhanced high-level database",
    "Status": "Lost",
    "WeightedAmount": 24598.766,
    "ProjectId": 123,
    "EarningPercent": 15679.402,
    "Earning": 28713.708,
    "ContactId": 466,
    "AssociateId": 683,
    "PersonId": 430,
    "SaleTypeId": 370,
    "SaleTypeName": "Thiel-Harvey",
    "PersonFullName": "Lura Heathcote",
    "Completed": "Completed",
    "ActiveErpLinks": 454,
    "NextDueDate": "2004-08-23T18:25:50.1325956+02:00",
    "Number": "838932",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 62
      }
    }
  },
  "Ticket": {
    "TicketId": 612,
    "Title": "laudantium",
    "CreatedAt": "2017-12-04T18:25:50.1325956+01:00",
    "LastChanged": "2002-08-19T18:25:50.1325956+02:00",
    "ReadByOwner": "2018-02-23T18:25:50.1325956+01:00",
    "ReadByCustomer": "2019-07-18T18:25:50.1325956+02:00",
    "FirstReadByUser": "1996-09-09T18:25:50.1325956+02:00",
    "Activate": "2019-05-08T18:25:50.1325956+02:00",
    "ClosedAt": "2010-03-17T18:25:50.1325956+01:00",
    "RepliedAt": "2004-11-27T18:25:50.1325956+01:00",
    "AlertTimeout": "2006-11-14T18:25:50.1325956+01:00",
    "Deadline": "2000-07-11T18:25:50.1325956+02:00",
    "CreatedBy": 29,
    "CreatedByName": "Koepp-Marvin",
    "Author": "est",
    "OwnedBy": 224,
    "OwnedByName": "Muller, Ferry and Lehner",
    "Category": 460,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 367,
    "PriorityName": "Wolff-Swaniawski",
    "BaseStatus": "Active",
    "TicketStatus": 277,
    "TicketStatusDisplayValue": "veritatis",
    "Origin": "AutoGenerated",
    "CustId": 409,
    "PersonFirstname": "Zoila",
    "PersonMiddleName": "Reilly-Fay",
    "PersonLastname": "Lueilwitz",
    "PersonFullname": "et",
    "AlertLevel": 394,
    "ConnectId": 27,
    "ReadStatus": "Green",
    "TimeToReply": 960,
    "RealTimeToReply": 427,
    "TimeToClose": 67,
    "RealTimeToClose": 787,
    "TimeSpentInternally": 15,
    "TimeSpentExternally": 878,
    "TimeSpentQueue": 287,
    "RealTimeSpentInternally": 619,
    "RealTimeSpentExternally": 180,
    "RealTimeSpentQueue": 987,
    "HasAttachment": true,
    "NumReplies": 935,
    "NumMessages": 688,
    "FromAddress": "est",
    "ContactId": 617,
    "ContactName": "Erdman, Bernhard and Heathcote",
    "OwnedByAssociateId": 606,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "orchestrate web-enabled web-readiness"
        },
        "FieldType": "System.Int32",
        "FieldLength": 459
      }
    }
  },
  "TransferTo": {
    "AssociateId": 669,
    "Name": "Hoeger, Stamm and Kuvalis",
    "PersonId": 665,
    "Rank": 948,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 861,
    "FullName": "Yesenia Hane",
    "FormalName": "Turner, Connelly and Bergnaum",
    "Deleted": false,
    "EjUserId": 927,
    "UserName": "Weimann-Ankunding",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 193
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
      "FieldLength": 829
    }
  }
}
```