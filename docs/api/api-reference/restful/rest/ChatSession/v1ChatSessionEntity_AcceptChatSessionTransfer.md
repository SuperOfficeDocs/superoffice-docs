---
title: POST ChatSession/{id}/AcceptTransfer
id: v1ChatSessionEntity_AcceptChatSessionTransfer
---

# POST ChatSession/{id}/AcceptTransfer

```http
POST /api/v1/ChatSession/{chatSessionId}/AcceptTransfer
```

Accept the transfer: assign the session to the user.

If the session is not being transferred, nothing happens.




| Path Part | Type | Description |
|-----------|------|-------------|
| chatSessionId | int32 | id of the chat session to send **Required** |



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
POST /api/v1/ChatSession/{chatSessionId}/AcceptTransfer
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 459,
  "TopicId": 74,
  "User": {
    "AssociateId": 579,
    "Name": "Morar-Tillman",
    "PersonId": 618,
    "Rank": 761,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 193,
    "FullName": "Ms. Maegan Koelpin",
    "FormalName": "Gottlieb LLC",
    "Deleted": true,
    "EjUserId": 953,
    "UserName": "Wiegand, Strosin and Reichel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 619
      }
    }
  },
  "Person": {
    "Position": "facilis",
    "PersonId": 314,
    "Mrmrs": "et",
    "Firstname": "Cullen",
    "Lastname": "Swift",
    "MiddleName": "Dach-Hermiston",
    "Title": "magnam",
    "Description": "Seamless client-server archive",
    "Email": "jayden@braun.uk",
    "FullName": "Antwan Gulgowski",
    "DirectPhone": "(616)620-1116 x48827",
    "FormalName": "Toy, Waelchi and Casper",
    "CountryId": 959,
    "ContactId": 163,
    "ContactName": "Stokes-Pagac",
    "Retired": 240,
    "Rank": 709,
    "ActiveInterests": 682,
    "ContactDepartment": "",
    "ContactCountryId": 187,
    "ContactOrgNr": "1277246",
    "FaxPhone": "814-664-1205",
    "MobilePhone": "264.676.3568 x36220",
    "ContactPhone": "432-887-2067 x023",
    "AssociateName": "Towne, Tromp and Langworth",
    "AssociateId": 533,
    "UsePersonAddress": false,
    "ContactFax": "porro",
    "Kanafname": "pariatur",
    "Kanalname": "maxime",
    "Post1": "tempora",
    "Post2": "deserunt",
    "Post3": "tempora",
    "EmailName": "myrna@mertz.info",
    "ContactFullName": "Baby Lowe",
    "ActiveErpLinks": 445,
    "TicketPriorityId": 498,
    "SupportLanguageId": 20,
    "SupportAssociateId": 20,
    "CategoryName": "VIP Customer",
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
  "CustomerAlias": "dignissimos",
  "CustomerHost": "cumque",
  "CustomerName": "Bayer, Reynolds and Lynch",
  "CustomerEmail": "ayana.dickinson@wintheiserkeeling.com",
  "CustomerPhone": "443.101.7384 x187",
  "CustomerConsented": true,
  "CustomerCompanyName": "Kunze-Goodwin",
  "Status": "Closed",
  "FirstMessage": "laboriosam",
  "LastMessage": "possimus",
  "WhenRequested": "2002-09-22T15:05:41.6910024+02:00",
  "WhenStarted": "2013-06-16T15:05:41.6910024+02:00",
  "WhenEnded": "2020-08-28T15:05:41.6910024+02:00",
  "WhenIdle": "2014-12-23T15:05:41.6910024+01:00",
  "WhenFetched": "2003-01-19T15:05:41.6910024+01:00",
  "SessionKey": "et",
  "InitialQueuePos": 996,
  "AlertLevel": 479,
  "Rank": 64,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 435,
    "Name": "Reinger Group",
    "OrgNr": "1733562",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "enim",
    "DirectPhone": "445.656.6262 x7077",
    "AssociateId": 77,
    "CountryId": 166,
    "EmailAddress": "iliana.ledner@beier.uk",
    "Kananame": "aut",
    "EmailAddressName": "jules.simonis@funk.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Joany Bergstrom",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "non",
    "FullName": "Naomi Sanford",
    "IsOwnerContact": false,
    "ActiveErpLinks": 373,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 587
      }
    }
  },
  "Project": {
    "ProjectId": 153,
    "Name": "Abshire, Roberts and Ryan",
    "Description": "Monitored even-keeled info-mediaries",
    "URL": "http://www.example.com/",
    "Type": "veniam",
    "AssociateId": 879,
    "AssociateFullName": "Miss Jennyfer Klein",
    "TypeId": 882,
    "Updated": "1999-07-23T15:05:41.6930027+02:00",
    "StatusId": 790,
    "Status": "quis",
    "TextId": 741,
    "PublishTo": "2012-09-19T15:05:41.6930027+02:00",
    "PublishFrom": "2011-05-25T15:05:41.6930027+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "585413",
    "ActiveErpLinks": 320,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 965
      }
    }
  },
  "Sale": {
    "ContactName": "Waters, Weimann and Botsford",
    "SaleDate": "1995-08-10T15:05:41.6940025+02:00",
    "SaleId": 982,
    "Probability": 513,
    "Title": "id",
    "Amount": 13538.88,
    "Currency": "neque",
    "ProjectName": "Waelchi, Dickens and Willms",
    "AssociateFullName": "Enos Bergstrom",
    "Description": "Organic logistical firmware",
    "Status": "Lost",
    "WeightedAmount": 26516.773999999998,
    "ProjectId": 826,
    "EarningPercent": 15754.617999999999,
    "Earning": 14278.503999999999,
    "ContactId": 426,
    "AssociateId": 509,
    "PersonId": 130,
    "SaleTypeId": 977,
    "SaleTypeName": "Halvorson Inc and Sons",
    "PersonFullName": "Mr. Rashawn Hyatt",
    "Completed": "Completed",
    "ActiveErpLinks": 901,
    "NextDueDate": "2013-07-22T15:05:41.7210021+02:00",
    "Number": "1439956",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 592
      }
    }
  },
  "Ticket": {
    "TicketId": 631,
    "Title": "nemo",
    "CreatedAt": "2019-10-16T15:05:41.7210021+02:00",
    "LastChanged": "2020-02-14T15:05:41.7210021+01:00",
    "ReadByOwner": "2018-04-26T15:05:41.7210021+02:00",
    "ReadByCustomer": "2009-01-13T15:05:41.7210021+01:00",
    "FirstReadByUser": "2011-02-25T15:05:41.7210021+01:00",
    "Activate": "2006-08-02T15:05:41.7210021+02:00",
    "ClosedAt": "2008-09-15T15:05:41.7210021+02:00",
    "RepliedAt": "2019-02-05T15:05:41.7210021+01:00",
    "AlertTimeout": "2014-04-23T15:05:41.7210021+02:00",
    "Deadline": "2009-05-16T15:05:41.7210021+02:00",
    "CreatedBy": 527,
    "CreatedByName": "Rau LLC",
    "Author": "expedita",
    "OwnedBy": 848,
    "OwnedByName": "Volkman-Bradtke",
    "Category": 147,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 822,
    "PriorityName": "Gleason Inc and Sons",
    "BaseStatus": "Active",
    "TicketStatus": 602,
    "TicketStatusDisplayValue": "distinctio",
    "Origin": "AutoGenerated",
    "CustId": 828,
    "PersonFirstname": "Elenor",
    "PersonMiddleName": "Beier Group",
    "PersonLastname": "Cummerata",
    "PersonFullname": "recusandae",
    "AlertLevel": 457,
    "ConnectId": 617,
    "ReadStatus": "Green",
    "TimeToReply": 130,
    "RealTimeToReply": 55,
    "TimeToClose": 376,
    "RealTimeToClose": 211,
    "TimeSpentInternally": 850,
    "TimeSpentExternally": 270,
    "TimeSpentQueue": 402,
    "RealTimeSpentInternally": 136,
    "RealTimeSpentExternally": 318,
    "RealTimeSpentQueue": 127,
    "HasAttachment": false,
    "NumReplies": 29,
    "NumMessages": 163,
    "FromAddress": "ut",
    "ContactId": 957,
    "ContactName": "Hills Inc and Sons",
    "OwnedByAssociateId": 875,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 700
      }
    }
  },
  "TransferTo": {
    "AssociateId": 792,
    "Name": "Little-Leuschke",
    "PersonId": 493,
    "Rank": 993,
    "Tooltip": "praesentium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 427,
    "FullName": "Nyasia Schiller",
    "FormalName": "Cummerata Inc and Sons",
    "Deleted": true,
    "EjUserId": 921,
    "UserName": "Schaden-Brown",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 684
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
      "FieldLength": 523
    }
  }
}
```