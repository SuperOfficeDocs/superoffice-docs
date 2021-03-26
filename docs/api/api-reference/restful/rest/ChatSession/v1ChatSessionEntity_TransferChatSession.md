---
title: POST ChatSession/{id}/TransferTo/{toAssociate}
id: v1ChatSessionEntity_TransferChatSession
---

# POST ChatSession/{id}/TransferTo/{toAssociate}

```http
POST /api/v1/ChatSession/{chatSessionId}/TransferTo/{toAssociate}
```

Request to send the session to another user.

If the session does not belong to the user, nothing happens.




| Path Part | Type | Description |
|-----------|------|-------------|
| chatSessionId | int32 | id of the chat session to send **Required** |
| toAssociate | string | Associate username or associate id to send session to. **Required** |



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
POST /api/v1/ChatSession/{chatSessionId}/TransferTo/{toAssociate}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 549,
  "TopicId": 819,
  "User": {
    "AssociateId": 945,
    "Name": "Emard-Feeney",
    "PersonId": 814,
    "Rank": 127,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 187,
    "FullName": "Thalia D'Amore",
    "FormalName": "Goodwin-Treutel",
    "Deleted": false,
    "EjUserId": 501,
    "UserName": "Douglas Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 88
      }
    }
  },
  "Person": {
    "Position": "in",
    "PersonId": 65,
    "Mrmrs": "doloremque",
    "Firstname": "Chloe",
    "Lastname": "Gutkowski",
    "MiddleName": "Will-Stoltenberg",
    "Title": "consequatur",
    "Description": "Cloned homogeneous superstructure",
    "Email": "santos@koelpin.name",
    "FullName": "Brionna Heller",
    "DirectPhone": "601-388-4412 x65100",
    "FormalName": "Kuhn Inc and Sons",
    "CountryId": 782,
    "ContactId": 259,
    "ContactName": "Runolfsdottir Inc and Sons",
    "Retired": 108,
    "Rank": 201,
    "ActiveInterests": 997,
    "ContactDepartment": "",
    "ContactCountryId": 405,
    "ContactOrgNr": "934113",
    "FaxPhone": "1-262-201-0084 x281",
    "MobilePhone": "361.473.6306",
    "ContactPhone": "1-001-800-6864 x77687",
    "AssociateName": "Effertz-Schowalter",
    "AssociateId": 749,
    "UsePersonAddress": false,
    "ContactFax": "pariatur",
    "Kanafname": "quibusdam",
    "Kanalname": "rerum",
    "Post1": "voluptates",
    "Post2": "et",
    "Post3": "et",
    "EmailName": "gay.cassin@beahan.ca",
    "ContactFullName": "Heber Quigley",
    "ActiveErpLinks": 515,
    "TicketPriorityId": 834,
    "SupportLanguageId": 529,
    "SupportAssociateId": 538,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 549
      }
    }
  },
  "CustomerAlias": "non",
  "CustomerHost": "tempora",
  "CustomerName": "Heidenreich Group",
  "CustomerEmail": "carol@gottlieb.us",
  "CustomerPhone": "286.417.3273",
  "CustomerConsented": true,
  "CustomerCompanyName": "Kessler Inc and Sons",
  "Status": "Closed",
  "FirstMessage": "nobis",
  "LastMessage": "ex",
  "WhenRequested": "2013-10-17T09:40:58.7473756+02:00",
  "WhenStarted": "2004-10-14T09:40:58.7473756+02:00",
  "WhenEnded": "2014-03-09T09:40:58.7473756+01:00",
  "WhenIdle": "1999-12-24T09:40:58.7473756+01:00",
  "WhenFetched": "2020-07-02T09:40:58.7473756+02:00",
  "SessionKey": "consequatur",
  "InitialQueuePos": 523,
  "AlertLevel": 247,
  "Rank": 712,
  "Flags": "CustomerIsTyping",
  "Contact": {
    "ContactId": 469,
    "Name": "Flatley LLC",
    "OrgNr": "844806",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "quis",
    "DirectPhone": "(062)770-2268 x5618",
    "AssociateId": 756,
    "CountryId": 46,
    "EmailAddress": "moriah@schinner.ca",
    "Kananame": "sapiente",
    "EmailAddressName": "aliya@torphy.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mathias Gleason",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "perferendis",
    "FullName": "Carlo Larson",
    "IsOwnerContact": true,
    "ActiveErpLinks": 230,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 783
      }
    }
  },
  "Project": {
    "ProjectId": 948,
    "Name": "Reichert Inc and Sons",
    "Description": "Multi-layered hybrid moratorium",
    "URL": "http://www.example.com/",
    "Type": "corporis",
    "AssociateId": 909,
    "AssociateFullName": "Alia Smith DDS",
    "TypeId": 27,
    "Updated": "2013-10-04T09:40:58.7483439+02:00",
    "StatusId": 408,
    "Status": "modi",
    "TextId": 471,
    "PublishTo": "1999-08-04T09:40:58.7483439+02:00",
    "PublishFrom": "2007-04-14T09:40:58.7483439+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "859185",
    "ActiveErpLinks": 166,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 135
      }
    }
  },
  "Sale": {
    "ContactName": "Rogahn-Collier",
    "SaleDate": "2016-04-18T09:40:58.7483439+02:00",
    "SaleId": 136,
    "Probability": 795,
    "Title": "nihil",
    "Amount": 9771.812,
    "Currency": "praesentium",
    "ProjectName": "Howell LLC",
    "AssociateFullName": "Werner Connelly",
    "Description": "Horizontal human-resource solution",
    "Status": "Lost",
    "WeightedAmount": 16685.416,
    "ProjectId": 576,
    "EarningPercent": 18929.36,
    "Earning": 31064.208,
    "ContactId": 439,
    "AssociateId": 517,
    "PersonId": 896,
    "SaleTypeId": 152,
    "SaleTypeName": "Walter Inc and Sons",
    "PersonFullName": "Ceasar Gutmann",
    "Completed": "Completed",
    "ActiveErpLinks": 905,
    "NextDueDate": "2003-04-01T09:40:58.7483439+02:00",
    "Number": "886985",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 36
      }
    }
  },
  "Ticket": {
    "TicketId": 11,
    "Title": "sed",
    "CreatedAt": "2011-02-09T09:40:58.7493748+01:00",
    "LastChanged": "2020-05-21T09:40:58.7493748+02:00",
    "ReadByOwner": "2019-09-23T09:40:58.7493748+02:00",
    "ReadByCustomer": "2020-07-27T09:40:58.7493748+02:00",
    "FirstReadByUser": "2015-08-01T09:40:58.7493748+02:00",
    "Activate": "1997-04-18T09:40:58.7493748+02:00",
    "ClosedAt": "1998-12-03T09:40:58.7493748+01:00",
    "RepliedAt": "2012-09-21T09:40:58.7493748+02:00",
    "AlertTimeout": "2019-04-26T09:40:58.7493748+02:00",
    "Deadline": "2016-06-18T09:40:58.7493748+02:00",
    "CreatedBy": 531,
    "CreatedByName": "Predovic Inc and Sons",
    "Author": "omnis",
    "OwnedBy": 1000,
    "OwnedByName": "Crooks LLC",
    "Category": 222,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 419,
    "BaseStatus": "Active",
    "TicketStatus": 485,
    "Origin": "AutoGenerated",
    "CustId": 264,
    "CustFirstname": "Retha",
    "CustMiddleName": "Tillman LLC",
    "CustLastname": "Medhurst",
    "AlertLevel": 523,
    "ConnectId": 319,
    "ReadStatus": "Green",
    "TimeToReply": 865,
    "RealTimeToReply": 97,
    "TimeToClose": 291,
    "RealTimeToClose": 722,
    "TimeSpentInternally": 425,
    "TimeSpentExternally": 91,
    "TimeSpentQueue": 860,
    "RealTimeSpentInternally": 236,
    "RealTimeSpentExternally": 208,
    "RealTimeSpentQueue": 376,
    "HasAttachment": true,
    "NumReplies": 960,
    "NumMessages": 956,
    "FromAddress": "ratione",
    "CustFullname": "est",
    "TicketStatusDisplayValue": "illo",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 984
      }
    }
  },
  "TransferTo": {
    "AssociateId": 542,
    "Name": "Monahan-Zboncak",
    "PersonId": 191,
    "Rank": 189,
    "Tooltip": "recusandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 381,
    "FullName": "Jayne Klocko MD",
    "FormalName": "Rippin-Hane",
    "Deleted": true,
    "EjUserId": 822,
    "UserName": "Predovic Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 975
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
      "FieldLength": 834
    }
  }
}
```