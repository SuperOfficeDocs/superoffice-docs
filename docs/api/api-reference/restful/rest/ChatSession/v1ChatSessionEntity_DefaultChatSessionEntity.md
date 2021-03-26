---
title: GET ChatSession/default
id: v1ChatSessionEntity_DefaultChatSessionEntity
---

# GET ChatSession/default

```http
GET /api/v1/ChatSession/default
```

Set default values into a new ChatSessionEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Chat agent service CreateDefaultChatSessionEntity.






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
GET /api/v1/ChatSession/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 508,
  "TopicId": 296,
  "User": {
    "AssociateId": 861,
    "Name": "Schuppe Group",
    "PersonId": 823,
    "Rank": 700,
    "Tooltip": "libero",
    "Type": "AnonymousAssociate",
    "GroupIdx": 829,
    "FullName": "Ernie Bogisich",
    "FormalName": "Gulgowski-Okuneva",
    "Deleted": true,
    "EjUserId": 716,
    "UserName": "Fritsch LLC",
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
  "Person": {
    "Position": "nobis",
    "PersonId": 187,
    "Mrmrs": "doloribus",
    "Firstname": "Estevan",
    "Lastname": "Mayert",
    "MiddleName": "Haley, Stracke and Walker",
    "Title": "fugiat",
    "Description": "Configurable local productivity",
    "Email": "otilia.crooks@crona.name",
    "FullName": "Syble Mitchell",
    "DirectPhone": "(757)636-0534",
    "FormalName": "Schroeder-Koch",
    "CountryId": 774,
    "ContactId": 747,
    "ContactName": "Abbott-Konopelski",
    "Retired": 615,
    "Rank": 564,
    "ActiveInterests": 467,
    "ContactDepartment": "",
    "ContactCountryId": 441,
    "ContactOrgNr": "1034430",
    "FaxPhone": "812.313.8542 x0833",
    "MobilePhone": "122.631.3647 x320",
    "ContactPhone": "016.656.7283 x0772",
    "AssociateName": "Gottlieb-Becker",
    "AssociateId": 27,
    "UsePersonAddress": true,
    "ContactFax": "veniam",
    "Kanafname": "sequi",
    "Kanalname": "animi",
    "Post1": "animi",
    "Post2": "omnis",
    "Post3": "porro",
    "EmailName": "torey@jaskolski.com",
    "ContactFullName": "Molly Reichert",
    "ActiveErpLinks": 863,
    "TicketPriorityId": 265,
    "SupportLanguageId": 908,
    "SupportAssociateId": 677,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 244
      }
    }
  },
  "CustomerAlias": "dolorem",
  "CustomerHost": "aut",
  "CustomerName": "Kuvalis LLC",
  "CustomerEmail": "greg@bergnaum.uk",
  "CustomerPhone": "358.808.4871 x423",
  "CustomerConsented": true,
  "CustomerCompanyName": "Orn Inc and Sons",
  "Status": "Closed",
  "FirstMessage": "quia",
  "LastMessage": "porro",
  "WhenRequested": "2011-12-04T09:40:58.6723662+01:00",
  "WhenStarted": "2020-04-26T09:40:58.6723662+02:00",
  "WhenEnded": "1996-09-17T09:40:58.6723662+02:00",
  "WhenIdle": "2012-06-13T09:40:58.6723662+02:00",
  "WhenFetched": "1994-08-29T09:40:58.6723662+02:00",
  "SessionKey": "hic",
  "InitialQueuePos": 26,
  "AlertLevel": 758,
  "Rank": 632,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 306,
    "Name": "Frami, Roberts and Mohr",
    "OrgNr": "488440",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "a",
    "DirectPhone": "560.076.0752",
    "AssociateId": 39,
    "CountryId": 708,
    "EmailAddress": "stan@price.ca",
    "Kananame": "voluptas",
    "EmailAddressName": "roberto@carter.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Rosie Huels",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quia",
    "FullName": "Caterina Hyatt",
    "IsOwnerContact": true,
    "ActiveErpLinks": 241,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 950
      }
    }
  },
  "Project": {
    "ProjectId": 889,
    "Name": "Beier Inc and Sons",
    "Description": "Customer-focused upward-trending software",
    "URL": "http://www.example.com/",
    "Type": "est",
    "AssociateId": 197,
    "AssociateFullName": "Estel Buckridge MD",
    "TypeId": 802,
    "Updated": "1999-12-27T09:40:58.6733683+01:00",
    "StatusId": 964,
    "Status": "autem",
    "TextId": 808,
    "PublishTo": "2004-11-07T09:40:58.6733683+01:00",
    "PublishFrom": "2020-09-04T09:40:58.6733683+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1652393",
    "ActiveErpLinks": 949,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 460
      }
    }
  },
  "Sale": {
    "ContactName": "Hagenes Group",
    "SaleDate": "1996-10-07T09:40:58.6733683+02:00",
    "SaleId": 562,
    "Probability": 764,
    "Title": "at",
    "Amount": 11376.42,
    "Currency": "beatae",
    "ProjectName": "Douglas, Dooley and D'Amore",
    "AssociateFullName": "Lukas Kessler",
    "Description": "Persistent executive definition",
    "Status": "Lost",
    "WeightedAmount": 12532.866,
    "ProjectId": 415,
    "EarningPercent": 10984.67,
    "Earning": 27184.316,
    "ContactId": 912,
    "AssociateId": 240,
    "PersonId": 438,
    "SaleTypeId": 190,
    "SaleTypeName": "Heathcote, Reynolds and Dickens",
    "PersonFullName": "Dr. Kiana Erdman",
    "Completed": "Completed",
    "ActiveErpLinks": 40,
    "NextDueDate": "1997-10-05T09:40:58.6743685+02:00",
    "Number": "345116",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 820
      }
    }
  },
  "Ticket": {
    "TicketId": 964,
    "Title": "a",
    "CreatedAt": "2012-12-14T09:40:58.6743685+01:00",
    "LastChanged": "2001-10-04T09:40:58.6743685+02:00",
    "ReadByOwner": "1996-07-02T09:40:58.6743685+02:00",
    "ReadByCustomer": "2007-06-18T09:40:58.6743685+02:00",
    "FirstReadByUser": "2016-04-04T09:40:58.6743685+02:00",
    "Activate": "1999-06-04T09:40:58.6743685+02:00",
    "ClosedAt": "1996-04-04T09:40:58.6743685+02:00",
    "RepliedAt": "2011-09-18T09:40:58.6743685+02:00",
    "AlertTimeout": "2006-05-13T09:40:58.6743685+02:00",
    "Deadline": "2002-04-04T09:40:58.6743685+02:00",
    "CreatedBy": 853,
    "CreatedByName": "Jerde, Daniel and Haag",
    "Author": "ratione",
    "OwnedBy": 15,
    "OwnedByName": "Feest Inc and Sons",
    "Category": 426,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 560,
    "BaseStatus": "Active",
    "TicketStatus": 168,
    "Origin": "AutoGenerated",
    "CustId": 688,
    "CustFirstname": "Marlon",
    "CustMiddleName": "Beatty-White",
    "CustLastname": "McKenzie",
    "AlertLevel": 480,
    "ConnectId": 887,
    "ReadStatus": "Green",
    "TimeToReply": 444,
    "RealTimeToReply": 231,
    "TimeToClose": 8,
    "RealTimeToClose": 328,
    "TimeSpentInternally": 26,
    "TimeSpentExternally": 226,
    "TimeSpentQueue": 679,
    "RealTimeSpentInternally": 473,
    "RealTimeSpentExternally": 189,
    "RealTimeSpentQueue": 179,
    "HasAttachment": false,
    "NumReplies": 61,
    "NumMessages": 408,
    "FromAddress": "in",
    "CustFullname": "rerum",
    "TicketStatusDisplayValue": "expedita",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 997
      }
    }
  },
  "TransferTo": {
    "AssociateId": 16,
    "Name": "Fadel, Olson and Veum",
    "PersonId": 646,
    "Rank": 904,
    "Tooltip": "itaque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 248,
    "FullName": "Telly Adams",
    "FormalName": "Ebert, Blick and Rogahn",
    "Deleted": false,
    "EjUserId": 373,
    "UserName": "Koss Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 245
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
      "FieldType": "System.String",
      "FieldLength": 99
    }
  }
}
```