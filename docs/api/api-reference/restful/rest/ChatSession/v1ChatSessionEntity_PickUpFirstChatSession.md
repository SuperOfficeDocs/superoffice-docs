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
| ChatbotIsActive | bool | Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/ChatSession/Pickup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 589,
  "TopicId": 297,
  "User": {
    "AssociateId": 1000,
    "Name": "Orn-Streich",
    "PersonId": 599,
    "Rank": 821,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 613,
    "FullName": "Dessie Koepp",
    "FormalName": "Reichel Group",
    "Deleted": false,
    "EjUserId": 742,
    "UserName": "Hammes-Christiansen",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 345
      }
    }
  },
  "Person": {
    "Position": "enim",
    "PersonId": 642,
    "Mrmrs": "veritatis",
    "Firstname": "Cydney",
    "Lastname": "Hoeger",
    "MiddleName": "Oberbrunner Inc and Sons",
    "Title": "adipisci",
    "Description": "Self-enabling maximized internet solution",
    "Email": "jocelyn.senger@nolan.name",
    "FullName": "Leopoldo Lang",
    "DirectPhone": "1-121-712-4044 x36350",
    "FormalName": "Sipes, Dickens and O'Connell",
    "CountryId": 888,
    "ContactId": 157,
    "ContactName": "Schinner LLC",
    "Retired": 773,
    "Rank": 594,
    "ActiveInterests": 245,
    "ContactDepartment": "",
    "ContactCountryId": 908,
    "ContactOrgNr": "396768",
    "FaxPhone": "(422)844-3725",
    "MobilePhone": "016.344.7038 x56044",
    "ContactPhone": "(507)114-0103",
    "AssociateName": "Harvey LLC",
    "AssociateId": 839,
    "UsePersonAddress": false,
    "ContactFax": "deserunt",
    "Kanafname": "facere",
    "Kanalname": "ab",
    "Post1": "quod",
    "Post2": "illo",
    "Post3": "mollitia",
    "EmailName": "therese@erdmankeebler.name",
    "ContactFullName": "Nova Schuppe",
    "ActiveErpLinks": 463,
    "TicketPriorityId": 451,
    "SupportLanguageId": 814,
    "SupportAssociateId": 587,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 156
      }
    }
  },
  "CustomerAlias": "sint",
  "CustomerHost": "officia",
  "CustomerName": "Bailey Inc and Sons",
  "CustomerEmail": "michael.abernathy@handpadberg.co.uk",
  "CustomerPhone": "(771)416-3808 x11213",
  "CustomerConsented": true,
  "CustomerCompanyName": "McGlynn, Schaefer and Lesch",
  "Status": "Closed",
  "FirstMessage": "dicta",
  "LastMessage": "vel",
  "WhenRequested": "2014-11-14T18:25:50.1416246+01:00",
  "WhenStarted": "2002-04-20T18:25:50.1416246+02:00",
  "WhenEnded": "1998-06-10T18:25:50.1416246+02:00",
  "WhenIdle": "2011-03-13T18:25:50.1416246+01:00",
  "WhenFetched": "2012-07-04T18:25:50.1416246+02:00",
  "SessionKey": "repellendus",
  "InitialQueuePos": 390,
  "AlertLevel": 944,
  "Rank": 727,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 380,
    "Name": "Balistreri, Mertz and Carroll",
    "OrgNr": "1210494",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "accusantium",
    "DirectPhone": "(464)567-4276 x2170",
    "AssociateId": 543,
    "CountryId": 599,
    "EmailAddress": "isabelle.rolfson@kiehn.co.uk",
    "Kananame": "natus",
    "EmailAddressName": "helena@kulas.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Cecil Cruickshank",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "maxime",
    "FullName": "Sophie Streich",
    "IsOwnerContact": false,
    "ActiveErpLinks": 877,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 158
      }
    }
  },
  "Project": {
    "ProjectId": 549,
    "Name": "Boyer-Schaden",
    "Description": "Self-enabling intangible definition",
    "URL": "http://www.example.com/",
    "Type": "aut",
    "AssociateId": 576,
    "AssociateFullName": "Kenneth Daugherty",
    "TypeId": 695,
    "Updated": "2019-02-09T18:25:50.1446243+01:00",
    "StatusId": 322,
    "Status": "rerum",
    "TextId": 297,
    "PublishTo": "1999-09-28T18:25:50.1446243+02:00",
    "PublishFrom": "2013-06-22T18:25:50.1446243+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1127863",
    "ActiveErpLinks": 985,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 635
      }
    }
  },
  "Sale": {
    "ContactName": "Mante-Armstrong",
    "SaleDate": "2010-12-05T18:25:50.1446243+01:00",
    "SaleId": 404,
    "Probability": 648,
    "Title": "eum",
    "Amount": 22173.05,
    "Currency": "corrupti",
    "ProjectName": "Dietrich Inc and Sons",
    "AssociateFullName": "Giovanna Davis",
    "Description": "Persevering cohesive process improvement",
    "Status": "Lost",
    "WeightedAmount": 16265.46,
    "ProjectId": 667,
    "EarningPercent": 24203.881999999998,
    "Earning": 25717.604,
    "ContactId": 851,
    "AssociateId": 672,
    "PersonId": 197,
    "SaleTypeId": 350,
    "SaleTypeName": "Cartwright, Bernhard and Hoppe",
    "PersonFullName": "Kade Abshire",
    "Completed": "Completed",
    "ActiveErpLinks": 167,
    "NextDueDate": "2000-09-04T18:25:50.1446243+02:00",
    "Number": "303357",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 809
      }
    }
  },
  "Ticket": {
    "TicketId": 728,
    "Title": "consequatur",
    "CreatedAt": "2000-03-29T18:25:50.1446243+02:00",
    "LastChanged": "2012-02-09T18:25:50.1446243+01:00",
    "ReadByOwner": "1999-11-22T18:25:50.1446243+01:00",
    "ReadByCustomer": "2019-01-11T18:25:50.1446243+01:00",
    "FirstReadByUser": "2014-11-19T18:25:50.1446243+01:00",
    "Activate": "2018-07-09T18:25:50.1446243+02:00",
    "ClosedAt": "2014-10-26T18:25:50.1446243+01:00",
    "RepliedAt": "2020-07-20T18:25:50.1446243+02:00",
    "AlertTimeout": "1997-02-26T18:25:50.1446243+01:00",
    "Deadline": "2015-03-31T18:25:50.1446243+02:00",
    "CreatedBy": 582,
    "CreatedByName": "Wolf-O'Conner",
    "Author": "et",
    "OwnedBy": 903,
    "OwnedByName": "Price-Koelpin",
    "Category": 536,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 949,
    "PriorityName": "Schoen Inc and Sons",
    "BaseStatus": "Active",
    "TicketStatus": 887,
    "TicketStatusDisplayValue": "aut",
    "Origin": "AutoGenerated",
    "CustId": 96,
    "PersonFirstname": "Myra",
    "PersonMiddleName": "Jacobson, Zboncak and Zulauf",
    "PersonLastname": "Auer",
    "PersonFullname": "voluptatem",
    "AlertLevel": 476,
    "ConnectId": 486,
    "ReadStatus": "Green",
    "TimeToReply": 201,
    "RealTimeToReply": 587,
    "TimeToClose": 223,
    "RealTimeToClose": 73,
    "TimeSpentInternally": 606,
    "TimeSpentExternally": 8,
    "TimeSpentQueue": 746,
    "RealTimeSpentInternally": 962,
    "RealTimeSpentExternally": 391,
    "RealTimeSpentQueue": 29,
    "HasAttachment": false,
    "NumReplies": 277,
    "NumMessages": 209,
    "FromAddress": "temporibus",
    "ContactId": 299,
    "ContactName": "Morar LLC",
    "OwnedByAssociateId": 180,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 818
      }
    }
  },
  "TransferTo": {
    "AssociateId": 117,
    "Name": "Kuhn Group",
    "PersonId": 885,
    "Rank": 608,
    "Tooltip": "maiores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 483,
    "FullName": "Hilbert McDermott",
    "FormalName": "Turner Group",
    "Deleted": true,
    "EjUserId": 844,
    "UserName": "Bergstrom-Bogisich",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 211
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
      "FieldLength": 923
    }
  }
}
```