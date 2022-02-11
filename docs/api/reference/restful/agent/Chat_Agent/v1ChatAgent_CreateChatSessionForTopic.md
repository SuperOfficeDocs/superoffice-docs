---
title: POST Agents/Chat/CreateChatSessionForTopic
id: v1ChatAgent_CreateChatSessionForTopic
---

# POST Agents/Chat/CreateChatSessionForTopic

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
  "ChatTopicId": 310
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 911,
  "TopicId": 795,
  "User": {
    "AssociateId": 357,
    "Name": "Gislason-Legros",
    "PersonId": 475,
    "Rank": 364,
    "Tooltip": "accusantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 805,
    "FullName": "Jovan Cartwright",
    "FormalName": "Leffler, Larkin and Ondricka",
    "Deleted": true,
    "EjUserId": 324,
    "UserName": "Koch-Littel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 157
      }
    }
  },
  "Person": {
    "Position": "nam",
    "PersonId": 376,
    "Mrmrs": "iusto",
    "Firstname": "Keaton",
    "Lastname": "Kulas",
    "MiddleName": "Watsica, Morissette and Douglas",
    "Title": "qui",
    "Description": "Visionary multimedia synergy",
    "Email": "carleton.jones@konopelski.name",
    "FullName": "Mr. Kayli Harris",
    "DirectPhone": "385-268-5038 x03782",
    "FormalName": "Wintheiser-Hartmann",
    "CountryId": 710,
    "ContactId": 544,
    "ContactName": "Abbott, Ernser and Legros",
    "Retired": 266,
    "Rank": 177,
    "ActiveInterests": 985,
    "ContactDepartment": "",
    "ContactCountryId": 606,
    "ContactOrgNr": "952174",
    "FaxPhone": "1-312-247-2626 x71346",
    "MobilePhone": "020.677.0360 x0485",
    "ContactPhone": "(830)856-0110 x820",
    "AssociateName": "Bruen Inc and Sons",
    "AssociateId": 729,
    "UsePersonAddress": true,
    "ContactFax": "quae",
    "Kanafname": "consequatur",
    "Kanalname": "sunt",
    "Post1": "inventore",
    "Post2": "corrupti",
    "Post3": "assumenda",
    "EmailName": "percy_glover@parker.co.uk",
    "ContactFullName": "Dr. Angie Veum",
    "ActiveErpLinks": 632,
    "TicketPriorityId": 869,
    "SupportLanguageId": 517,
    "SupportAssociateId": 57,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 328
      }
    }
  },
  "CustomerAlias": "quisquam",
  "CustomerHost": "sed",
  "CustomerName": "McGlynn-Zieme",
  "CustomerEmail": "leonard@mertz.us",
  "CustomerPhone": "563.370.4112",
  "CustomerConsented": true,
  "CustomerCompanyName": "Ernser Inc and Sons",
  "Status": "Closed",
  "FirstMessage": "at",
  "LastMessage": "dignissimos",
  "WhenRequested": "2003-03-05T18:28:48.3896525+01:00",
  "WhenStarted": "2019-11-17T18:28:48.3896525+01:00",
  "WhenEnded": "2018-09-23T18:28:48.3896525+02:00",
  "WhenIdle": "2017-10-04T18:28:48.3896525+02:00",
  "WhenFetched": "2014-09-18T18:28:48.3896525+02:00",
  "SessionKey": "enim",
  "InitialQueuePos": 344,
  "AlertLevel": 406,
  "Rank": 292,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 269,
    "Name": "Gulgowski-Parker",
    "OrgNr": "1224370",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "dicta",
    "DirectPhone": "553-713-6150",
    "AssociateId": 747,
    "CountryId": 305,
    "EmailAddress": "luz.kuhlman@breitenbergharris.ca",
    "Kananame": "beatae",
    "EmailAddressName": "percival.vandervort@leuschke.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Gudrun Farrell",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "laudantium",
    "FullName": "Emanuel Collins",
    "IsOwnerContact": false,
    "ActiveErpLinks": 539,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 583
      }
    }
  },
  "Project": {
    "ProjectId": 966,
    "Name": "O'Conner-Marks",
    "Description": "Managed object-oriented open architecture",
    "URL": "http://www.example.com/",
    "Type": "in",
    "AssociateId": 450,
    "AssociateFullName": "Pansy Nicolas",
    "TypeId": 826,
    "Updated": "2015-12-29T18:28:48.3906539+01:00",
    "StatusId": 468,
    "Status": "non",
    "TextId": 922,
    "PublishTo": "2016-03-02T18:28:48.3906539+01:00",
    "PublishFrom": "2019-03-06T18:28:48.3906539+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1223191",
    "ActiveErpLinks": 647,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 615
      }
    }
  },
  "Sale": {
    "ContactName": "Marquardt, Goyette and Nikolaus",
    "SaleDate": "2016-01-28T18:28:48.3906539+01:00",
    "SaleId": 50,
    "Probability": 292,
    "Title": "ut",
    "Amount": 25009.32,
    "Currency": "non",
    "ProjectName": "Shanahan, Sauer and Murray",
    "AssociateFullName": "Alyson Kuhlman",
    "Description": "Up-sized dedicated encryption",
    "Status": "Lost",
    "WeightedAmount": 27472.644,
    "ProjectId": 972,
    "EarningPercent": 15118.416,
    "Earning": 2033.966,
    "ContactId": 926,
    "AssociateId": 125,
    "PersonId": 927,
    "SaleTypeId": 616,
    "SaleTypeName": "Reichel-Gerhold",
    "PersonFullName": "Selena DuBuque",
    "Completed": "Completed",
    "ActiveErpLinks": 426,
    "NextDueDate": "2000-09-02T18:28:48.3916525+02:00",
    "Number": "1132166",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "productize rich e-services"
        },
        "FieldType": "System.Int32",
        "FieldLength": 916
      }
    }
  },
  "Ticket": {
    "TicketId": 897,
    "Title": "possimus",
    "CreatedAt": "2000-05-17T18:28:48.3916525+02:00",
    "LastChanged": "2020-07-23T18:28:48.3916525+02:00",
    "ReadByOwner": "2011-12-25T18:28:48.3916525+01:00",
    "ReadByCustomer": "2003-07-06T18:28:48.3916525+02:00",
    "FirstReadByUser": "2013-07-07T18:28:48.3916525+02:00",
    "Activate": "2010-11-02T18:28:48.3916525+01:00",
    "ClosedAt": "2003-07-20T18:28:48.3916525+02:00",
    "RepliedAt": "2001-11-26T18:28:48.3916525+01:00",
    "AlertTimeout": "1994-12-19T18:28:48.3916525+01:00",
    "Deadline": "2011-11-18T18:28:48.3916525+01:00",
    "CreatedBy": 138,
    "CreatedByName": "Denesik LLC",
    "Author": "excepturi",
    "OwnedBy": 225,
    "OwnedByName": "Jones, Lehner and Mueller",
    "Category": 716,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 46,
    "PriorityName": "Collins Group",
    "BaseStatus": "Active",
    "TicketStatus": 157,
    "TicketStatusDisplayValue": "aut",
    "Origin": "AutoGenerated",
    "CustId": 959,
    "PersonFirstname": "Russell",
    "PersonMiddleName": "Osinski-Treutel",
    "PersonLastname": "Waters",
    "PersonFullname": "et",
    "AlertLevel": 477,
    "ConnectId": 695,
    "ReadStatus": "Green",
    "TimeToReply": 561,
    "RealTimeToReply": 72,
    "TimeToClose": 225,
    "RealTimeToClose": 949,
    "TimeSpentInternally": 445,
    "TimeSpentExternally": 511,
    "TimeSpentQueue": 816,
    "RealTimeSpentInternally": 852,
    "RealTimeSpentExternally": 11,
    "RealTimeSpentQueue": 472,
    "HasAttachment": true,
    "NumReplies": 136,
    "NumMessages": 73,
    "FromAddress": "voluptatem",
    "ContactId": 637,
    "ContactName": "Kshlerin Group",
    "OwnedByAssociateId": 577,
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
  "TransferTo": {
    "AssociateId": 329,
    "Name": "Schumm, Morar and Greenfelder",
    "PersonId": 336,
    "Rank": 625,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 438,
    "FullName": "Ransom Dibbert",
    "FormalName": "Koelpin-Hayes",
    "Deleted": true,
    "EjUserId": 2,
    "UserName": "Leannon, Reichert and McLaughlin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 400
      }
    }
  },
  "ChatbotIsActive": true,
  "TableRight": {
    "Mask": "Delete",
    "Reason": "extend sticky initiatives"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 693
    }
  }
}
```