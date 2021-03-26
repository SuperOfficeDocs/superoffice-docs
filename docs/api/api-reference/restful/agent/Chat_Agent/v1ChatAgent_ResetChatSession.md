---
title: POST Agents/Chat/ResetChatSession
id: v1ChatAgent_ResetChatSession
---

# POST Agents/Chat/ResetChatSession

```http
POST /api/v1/Agents/Chat/ResetChatSession
```

Reset chat session, put it back on the queue for pickup.

Used by bots to hand off a session to human





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/ResetChatSession?$select=name,department,category/id
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
POST /api/v1/Agents/Chat/ResetChatSession
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 263
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 876,
  "TopicId": 599,
  "User": {
    "AssociateId": 57,
    "Name": "Stanton, Tremblay and Shields",
    "PersonId": 619,
    "Rank": 369,
    "Tooltip": "atque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 929,
    "FullName": "Shannon Reichert",
    "FormalName": "Gutkowski Inc and Sons",
    "Deleted": false,
    "EjUserId": 622,
    "UserName": "Welch, Denesik and Runolfsdottir",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "benchmark customized applications"
        },
        "FieldType": "System.Int32",
        "FieldLength": 341
      }
    }
  },
  "Person": {
    "Position": "ea",
    "PersonId": 166,
    "Mrmrs": "laboriosam",
    "Firstname": "Amani",
    "Lastname": "Kihn",
    "MiddleName": "McGlynn-Emard",
    "Title": "ea",
    "Description": "Customizable 6th generation capability",
    "Email": "gregorio@bednarrice.ca",
    "FullName": "David Towne",
    "DirectPhone": "(781)616-4010 x4353",
    "FormalName": "Steuber LLC",
    "CountryId": 62,
    "ContactId": 405,
    "ContactName": "McCullough Inc and Sons",
    "Retired": 715,
    "Rank": 558,
    "ActiveInterests": 71,
    "ContactDepartment": "",
    "ContactCountryId": 309,
    "ContactOrgNr": "1213488",
    "FaxPhone": "512-540-2634 x22805",
    "MobilePhone": "1-718-785-7607 x2568",
    "ContactPhone": "652-430-8805 x768",
    "AssociateName": "Grady, Baumbach and Quitzon",
    "AssociateId": 936,
    "UsePersonAddress": true,
    "ContactFax": "sunt",
    "Kanafname": "perspiciatis",
    "Kanalname": "repudiandae",
    "Post1": "culpa",
    "Post2": "rerum",
    "Post3": "impedit",
    "EmailName": "genoveva@lemke.biz",
    "ContactFullName": "Dion Orn",
    "ActiveErpLinks": 813,
    "TicketPriorityId": 303,
    "SupportLanguageId": 842,
    "SupportAssociateId": 326,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 776
      }
    }
  },
  "CustomerAlias": "repellendus",
  "CustomerHost": "expedita",
  "CustomerName": "Marvin-Hahn",
  "CustomerEmail": "audreanne.luettgen@kub.us",
  "CustomerPhone": "772-735-3166",
  "CustomerConsented": false,
  "CustomerCompanyName": "Beahan, Erdman and Tillman",
  "Status": "Closed",
  "FirstMessage": "aut",
  "LastMessage": "at",
  "WhenRequested": "2012-04-12T16:48:28.9989315+02:00",
  "WhenStarted": "2019-10-23T16:48:28.9989315+02:00",
  "WhenEnded": "2002-01-24T16:48:28.9989315+01:00",
  "WhenIdle": "1999-03-04T16:48:28.9989315+01:00",
  "WhenFetched": "1999-08-13T16:48:28.9989315+02:00",
  "SessionKey": "sunt",
  "InitialQueuePos": 302,
  "AlertLevel": 976,
  "Rank": 245,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 383,
    "Name": "Nienow LLC",
    "OrgNr": "896151",
    "Department": "disintermediate strategic technologies",
    "URL": "http://www.example.com/",
    "City": "doloribus",
    "DirectPhone": "(847)745-5653 x7714",
    "AssociateId": 8,
    "CountryId": 700,
    "EmailAddress": "amos@jones.com",
    "Kananame": "velit",
    "EmailAddressName": "maiya.gaylord@millerjohnson.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mr. Romaine Gleason",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "cumque",
    "FullName": "Fay Mosciski",
    "IsOwnerContact": false,
    "ActiveErpLinks": 720,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 103
      }
    }
  },
  "Project": {
    "ProjectId": 178,
    "Name": "Pollich Inc and Sons",
    "Description": "Implemented bottom-line knowledge base",
    "URL": "http://www.example.com/",
    "Type": "id",
    "AssociateId": 762,
    "AssociateFullName": "Brenda Spinka",
    "TypeId": 368,
    "Updated": "2011-02-27T16:48:28.9999244+01:00",
    "StatusId": 266,
    "Status": "repellat",
    "TextId": 903,
    "PublishTo": "2001-03-15T16:48:28.9999244+01:00",
    "PublishFrom": "2018-07-02T16:48:28.9999244+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1549350",
    "ActiveErpLinks": 351,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 985
      }
    }
  },
  "Sale": {
    "ContactName": "Crona-O'Connell",
    "SaleDate": "2019-08-14T16:48:28.9999244+02:00",
    "SaleId": 562,
    "Probability": 83,
    "Title": "est",
    "Amount": 15090.21,
    "Currency": "dolorem",
    "ProjectName": "Shanahan-Braun",
    "AssociateFullName": "Jessie Mante",
    "Description": "User-friendly zero defect database",
    "Status": "Lost",
    "WeightedAmount": 20524.566,
    "ProjectId": 608,
    "EarningPercent": 26946.131999999998,
    "Earning": 29807.474,
    "ContactId": 3,
    "AssociateId": 520,
    "PersonId": 396,
    "SaleTypeId": 882,
    "SaleTypeName": "Carter, Grimes and Rosenbaum",
    "PersonFullName": "Danielle Mitchell DDS",
    "Completed": "Completed",
    "ActiveErpLinks": 283,
    "NextDueDate": "2013-06-03T16:48:28.9999244+02:00",
    "Number": "783066",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 234
      }
    }
  },
  "Ticket": {
    "TicketId": 276,
    "Title": "ut",
    "CreatedAt": "2012-09-18T16:48:29.0009239+02:00",
    "LastChanged": "1999-11-07T16:48:29.0009239+01:00",
    "ReadByOwner": "2012-11-16T16:48:29.0009239+01:00",
    "ReadByCustomer": "1997-05-23T16:48:29.0009239+02:00",
    "FirstReadByUser": "2006-01-19T16:48:29.0009239+01:00",
    "Activate": "2000-10-28T16:48:29.0009239+02:00",
    "ClosedAt": "1997-10-29T16:48:29.0009239+01:00",
    "RepliedAt": "2006-03-06T16:48:29.0009239+01:00",
    "AlertTimeout": "1999-08-24T16:48:29.0009239+02:00",
    "Deadline": "2018-04-13T16:48:29.0009239+02:00",
    "CreatedBy": 561,
    "CreatedByName": "Rempel-Sporer",
    "Author": "molestiae",
    "OwnedBy": 531,
    "OwnedByName": "Moore, Terry and Tromp",
    "Category": 758,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 674,
    "BaseStatus": "Active",
    "TicketStatus": 8,
    "Origin": "AutoGenerated",
    "CustId": 75,
    "CustFirstname": "Mac",
    "CustMiddleName": "Raynor, Reinger and Wintheiser",
    "CustLastname": "Cronin",
    "AlertLevel": 571,
    "ConnectId": 990,
    "ReadStatus": "Green",
    "TimeToReply": 427,
    "RealTimeToReply": 206,
    "TimeToClose": 468,
    "RealTimeToClose": 374,
    "TimeSpentInternally": 56,
    "TimeSpentExternally": 955,
    "TimeSpentQueue": 966,
    "RealTimeSpentInternally": 723,
    "RealTimeSpentExternally": 724,
    "RealTimeSpentQueue": 518,
    "HasAttachment": false,
    "NumReplies": 871,
    "NumMessages": 31,
    "FromAddress": "quos",
    "CustFullname": "cum",
    "TicketStatusDisplayValue": "omnis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 550
      }
    }
  },
  "TransferTo": {
    "AssociateId": 47,
    "Name": "Tromp, Abshire and Howell",
    "PersonId": 834,
    "Rank": 600,
    "Tooltip": "ad",
    "Type": "AnonymousAssociate",
    "GroupIdx": 114,
    "FullName": "Ms. Cale Kuvalis",
    "FormalName": "Schmitt, Lehner and Wiegand",
    "Deleted": false,
    "EjUserId": 491,
    "UserName": "Doyle LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 290
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
      "FieldLength": 657
    }
  }
}
```