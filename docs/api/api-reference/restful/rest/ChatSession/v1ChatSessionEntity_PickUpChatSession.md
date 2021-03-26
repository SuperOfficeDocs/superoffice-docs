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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/ChatSession/{chatSessionId}/Pickup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 506,
  "TopicId": 141,
  "User": {
    "AssociateId": 170,
    "Name": "Leannon-Cummings",
    "PersonId": 953,
    "Rank": 724,
    "Tooltip": "cupiditate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 242,
    "FullName": "Arianna Wiza III",
    "FormalName": "Mueller-Schowalter",
    "Deleted": false,
    "EjUserId": 915,
    "UserName": "Rodriguez LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 282
      }
    }
  },
  "Person": {
    "Position": "est",
    "PersonId": 122,
    "Mrmrs": "eos",
    "Firstname": "Josiah",
    "Lastname": "Mueller",
    "MiddleName": "Kautzer-Botsford",
    "Title": "ea",
    "Description": "Self-enabling bifurcated moderator",
    "Email": "pablo_tillman@gerlach.uk",
    "FullName": "Jeff Hudson",
    "DirectPhone": "375.616.6637",
    "FormalName": "Mueller-Klein",
    "CountryId": 610,
    "ContactId": 994,
    "ContactName": "Gottlieb-Jaskolski",
    "Retired": 988,
    "Rank": 773,
    "ActiveInterests": 461,
    "ContactDepartment": "",
    "ContactCountryId": 585,
    "ContactOrgNr": "1227267",
    "FaxPhone": "(038)653-1285",
    "MobilePhone": "511-483-0222 x562",
    "ContactPhone": "245.841.3785",
    "AssociateName": "Streich Group",
    "AssociateId": 193,
    "UsePersonAddress": true,
    "ContactFax": "modi",
    "Kanafname": "commodi",
    "Kanalname": "expedita",
    "Post1": "pariatur",
    "Post2": "natus",
    "Post3": "in",
    "EmailName": "mae.hilll@mosciski.info",
    "ContactFullName": "Eliezer Kuhlman",
    "ActiveErpLinks": 415,
    "TicketPriorityId": 96,
    "SupportLanguageId": 822,
    "SupportAssociateId": 317,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "utilize cross-media schemas"
        },
        "FieldType": "System.Int32",
        "FieldLength": 766
      }
    }
  },
  "CustomerAlias": "sit",
  "CustomerHost": "ratione",
  "CustomerName": "Block-O'Conner",
  "CustomerEmail": "fritz@nienow.com",
  "CustomerPhone": "(252)271-8818 x07731",
  "CustomerConsented": false,
  "CustomerCompanyName": "Runolfsdottir, Pfannerstill and Trantow",
  "Status": "Closed",
  "FirstMessage": "eum",
  "LastMessage": "voluptatibus",
  "WhenRequested": "2014-09-07T09:40:58.8073791+02:00",
  "WhenStarted": "2015-03-06T09:40:58.8073791+01:00",
  "WhenEnded": "2015-07-05T09:40:58.8073791+02:00",
  "WhenIdle": "1995-10-20T09:40:58.8073791+02:00",
  "WhenFetched": "2007-10-22T09:40:58.8073791+02:00",
  "SessionKey": "maxime",
  "InitialQueuePos": 677,
  "AlertLevel": 467,
  "Rank": 207,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 788,
    "Name": "Wehner-Daniel",
    "OrgNr": "862624",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "sed",
    "DirectPhone": "(120)717-5278 x2625",
    "AssociateId": 914,
    "CountryId": 783,
    "EmailAddress": "madalyn.graham@jenkins.biz",
    "Kananame": "voluptatem",
    "EmailAddressName": "jolie.white@baileyherman.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Dr. Boris Borer",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ut",
    "FullName": "Ms. Macey Gottlieb",
    "IsOwnerContact": true,
    "ActiveErpLinks": 15,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 995
      }
    }
  },
  "Project": {
    "ProjectId": 93,
    "Name": "Denesik Group",
    "Description": "Open-architected regional benchmark",
    "URL": "http://www.example.com/",
    "Type": "explicabo",
    "AssociateId": 903,
    "AssociateFullName": "Mr. Brennon Streich",
    "TypeId": 448,
    "Updated": "2014-11-02T09:40:58.8073791+01:00",
    "StatusId": 422,
    "Status": "mollitia",
    "TextId": 979,
    "PublishTo": "2003-03-15T09:40:58.8073791+01:00",
    "PublishFrom": "1996-05-21T09:40:58.8073791+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "479517",
    "ActiveErpLinks": 738,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 732
      }
    }
  },
  "Sale": {
    "ContactName": "Leannon Inc and Sons",
    "SaleDate": "2017-10-21T09:40:58.8083722+02:00",
    "SaleId": 858,
    "Probability": 264,
    "Title": "occaecati",
    "Amount": 24539.219999999998,
    "Currency": "consequatur",
    "ProjectName": "Zemlak, Hills and Steuber",
    "AssociateFullName": "Einar Schaden",
    "Description": "Streamlined zero defect matrices",
    "Status": "Lost",
    "WeightedAmount": 22129.174,
    "ProjectId": 285,
    "EarningPercent": 10495.766,
    "Earning": 5769.6939999999995,
    "ContactId": 837,
    "AssociateId": 913,
    "PersonId": 628,
    "SaleTypeId": 785,
    "SaleTypeName": "Frami Group",
    "PersonFullName": "Pearlie Lebsack",
    "Completed": "Completed",
    "ActiveErpLinks": 9,
    "NextDueDate": "2020-12-21T09:40:58.8083722+01:00",
    "Number": "576429",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 170
      }
    }
  },
  "Ticket": {
    "TicketId": 886,
    "Title": "perferendis",
    "CreatedAt": "2009-10-27T09:40:58.8083722+01:00",
    "LastChanged": "2013-07-14T09:40:58.8083722+02:00",
    "ReadByOwner": "2009-01-18T09:40:58.8083722+01:00",
    "ReadByCustomer": "1994-07-14T09:40:58.8083722+02:00",
    "FirstReadByUser": "2019-12-07T09:40:58.8083722+01:00",
    "Activate": "2006-05-09T09:40:58.8083722+02:00",
    "ClosedAt": "2017-06-24T09:40:58.8083722+02:00",
    "RepliedAt": "1997-12-31T09:40:58.8083722+01:00",
    "AlertTimeout": "1998-11-17T09:40:58.8083722+01:00",
    "Deadline": "1994-10-02T09:40:58.8083722+02:00",
    "CreatedBy": 792,
    "CreatedByName": "Kassulke, Ward and Trantow",
    "Author": "eius",
    "OwnedBy": 564,
    "OwnedByName": "Muller, Mayer and Harris",
    "Category": 26,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 777,
    "BaseStatus": "Active",
    "TicketStatus": 589,
    "Origin": "AutoGenerated",
    "CustId": 94,
    "CustFirstname": "Fletcher",
    "CustMiddleName": "King Inc and Sons",
    "CustLastname": "Schuster",
    "AlertLevel": 496,
    "ConnectId": 347,
    "ReadStatus": "Green",
    "TimeToReply": 56,
    "RealTimeToReply": 200,
    "TimeToClose": 283,
    "RealTimeToClose": 231,
    "TimeSpentInternally": 946,
    "TimeSpentExternally": 709,
    "TimeSpentQueue": 936,
    "RealTimeSpentInternally": 219,
    "RealTimeSpentExternally": 339,
    "RealTimeSpentQueue": 758,
    "HasAttachment": true,
    "NumReplies": 10,
    "NumMessages": 169,
    "FromAddress": "id",
    "CustFullname": "quis",
    "TicketStatusDisplayValue": "dicta",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "reinvent 24/365 web services"
        },
        "FieldType": "System.Int32",
        "FieldLength": 758
      }
    }
  },
  "TransferTo": {
    "AssociateId": 461,
    "Name": "Hauck, Jacobs and Mitchell",
    "PersonId": 436,
    "Rank": 549,
    "Tooltip": "dolorem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 670,
    "FullName": "Lonny Mueller",
    "FormalName": "Bergstrom LLC",
    "Deleted": false,
    "EjUserId": 126,
    "UserName": "Walsh, Fahey and Lakin",
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
      "FieldLength": 785
    }
  }
}
```