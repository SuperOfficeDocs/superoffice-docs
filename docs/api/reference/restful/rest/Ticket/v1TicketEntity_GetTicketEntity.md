---
title: GET Ticket/{id}
id: v1TicketEntity_GetTicketEntity
---

# GET Ticket/{id}

```http
GET /api/v1/Ticket/{id}
```

Gets a TicketEntity object.

Calls the Ticket agent service GetTicketEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the TicketEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Ticket/{id}?$select=name,department,category/id
GET /api/v1/Ticket/{id}?fk=True
```


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

The ticket entity is used for representing a service ticket



TicketEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | TicketEntity found. |
| 404 | Not Found. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | int32 | The primary key (auto-incremented) |
| Title | string | The title of the ticket. |
| CreatedAt | date-time | When the ticket was created. |
| LastChanged | date-time | The last time the ticket was modified. |
| ReadByOwner | date-time | The datetime for when the ticket last was read by the owner. |
| ReadByCustomer | date-time | The datetime for when the ticket was read by the customer. |
| FirstReadByUser | date-time | The datetime for when the ticket first was read by a user. |
| Activate | date-time | When the ticket should be activated, if it is postponed. |
| ClosedAt | date-time | When the ticket was closed. |
| RepliedAt | date-time | The datetime for when the ticket was replied to. I.e. the first external message added to the ticket. |
| AlertTimeout | date-time | The datetime for when the ticket should jump to the next alert_level. |
| Deadline | date-time | Deadline for ticket. |
| CreatedBy |  | The associate who created this ticket |
| Author | string | A string representing the author of the ticket (same as author of first message). |
| OwnedBy |  | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category |  | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority |  | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status |  | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person |  | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
| SecondaryPersons | array | The secondary persons this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
| AlertLevel | int32 | The alert level for the ticket. Matches the level value of the ticket_alert table. |
| ConnectId | int32 | If a ticket is connected to another ticket, this field is set to the id of the &amp;apos;master&amp;apos; ticket. |
| ReadStatus | string | Whether the owner has read the ticket or not (red, yellow, green). |
| TimeToReply | int32 | The time (minutes) between when the ticket was created and when it was replied to. Calculated based on priority&amp;apos;s timeframe. |
| RealTimeToReply | int32 | Same as time_to_reply, but not calculated based on priority. |
| TimeToClose | int32 | The time (minutes) between when the ticket was created and when it was closed. Calculated based on priority&amp;apos;s timeframe. |
| RealTimeToClose | int32 | Same as time_to_close, but not calculated based on priority. |
| TimeSpentInternally | int32 | The total time (seconds) within the priority's office hours the ticket has been in an open status (configurable), not including current state |
| TimeSpentExternally | int32 | The total time (seconds) within the priority's office hours the ticket has been in a external waiting status (configurable), not including current state |
| TimeSpentQueue | int32 | The total time (seconds) within the priority's office hours the ticket has been in a queue status, not including current state |
| RealTimeSpentInternally | int32 | The total time (seconds) within 24x7 the ticket has been in an open status (configurable), not including current state |
| RealTimeSpentExternally | int32 | The total time (seconds) within 24x7 the ticket has been in a external waiting status (configurable), not including current state |
| RealTimeSpentQueue | int32 | The total time (seconds) within 24x7 hours the ticket has been in a queue status, not including current state |
| HasAttachment | bool | Boolean indicating if this ticket has one or more attachments. |
| NumReplies | int32 | The number of replies (messages) to the customer for this request. |
| NumMessages | int32 | The total number of messages for this request. |
| FromAddress | string | The from-address used when this ticket got created, e.g. by email |
| Messages | array | TicketMessageId,CreatedAt,SLevel and Important for all the messages connected to this ticket. For message body see the TicketMessageEntity or the TicketMessage archive. |
| Tags | array | An array containing the tags assigned to this request |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
GET /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 TicketEntity found.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 760,
  "Title": "voluptates",
  "CreatedAt": "2000-05-10T18:25:51.1959398+02:00",
  "LastChanged": "2010-07-22T18:25:51.1959398+02:00",
  "ReadByOwner": "2019-03-18T18:25:51.1959398+01:00",
  "ReadByCustomer": "1995-01-30T18:25:51.1959398+01:00",
  "FirstReadByUser": "2002-04-11T18:25:51.1959398+02:00",
  "Activate": "2009-05-20T18:25:51.1959398+02:00",
  "ClosedAt": "1996-11-05T18:25:51.1959398+01:00",
  "RepliedAt": "1997-04-20T18:25:51.1959398+02:00",
  "AlertTimeout": "2013-11-18T18:25:51.1959398+01:00",
  "Deadline": "1995-11-27T18:25:51.1959398+01:00",
  "CreatedBy": {
    "AssociateId": 168,
    "Name": "Lebsack, Friesen and Ernser",
    "PersonId": 304,
    "Rank": 935,
    "Tooltip": "voluptate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 351,
    "FullName": "Otto Robel",
    "FormalName": "Kemmer LLC",
    "Deleted": false,
    "EjUserId": 904,
    "UserName": "Koelpin-Reinger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 960
      }
    }
  },
  "Author": "sed",
  "OwnedBy": {
    "AssociateId": 2,
    "Name": "Rath, McKenzie and Kreiger",
    "PersonId": 656,
    "Rank": 941,
    "Tooltip": "ullam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 915,
    "FullName": "Arianna Schultz",
    "FormalName": "Harris-Lynch",
    "Deleted": false,
    "EjUserId": 632,
    "UserName": "Waelchi-Gottlieb",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 845
      }
    }
  },
  "Category": {
    "TicketCategoryId": 488,
    "ParentId": 441,
    "Name": "Fisher-Renner",
    "Fullname": "quia",
    "CategoryMaster": 398,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Rowe, Kemmer and Christiansen",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 139,
    "ReplyTemplate": 459,
    "NotificationEmail": "asia.oberbrunner@andersonreichert.biz",
    "DefaultTicketStatus": {},
    "DefaultMessageStatus": {},
    "ExtraFields": {
      "ExtraFields1": "fuga",
      "ExtraFields2": "quisquam"
    },
    "CustomFields": {
      "CustomFields1": "facilis",
      "CustomFields2": "quidem"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 60
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 650,
    "Name": "Parker-Wintheiser",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 801,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 136,
    "MonStart": "1997-02-01T18:25:51.1969399+01:00",
    "MonStop": "2008-12-15T18:25:51.1969399+01:00",
    "TueStart": "1998-12-09T18:25:51.1969399+01:00",
    "TueStop": "2020-02-29T18:25:51.1969399+01:00",
    "WedStart": "2011-03-08T18:25:51.1969399+01:00",
    "WedStop": "2007-09-19T18:25:51.1969399+02:00",
    "ThuStart": "2019-08-09T18:25:51.1969399+02:00",
    "ThuStop": "1996-03-30T18:25:51.1969399+01:00",
    "FriStart": "2002-10-19T18:25:51.1969399+02:00",
    "FriStop": "2000-07-21T18:25:51.1969399+02:00",
    "SatStart": "2018-05-02T18:25:51.1969399+02:00",
    "SatStop": "2009-09-05T18:25:51.1969399+02:00",
    "SunStart": "2012-03-12T18:25:51.1969399+01:00",
    "SunStop": "2017-04-25T18:25:51.1969399+02:00",
    "NonDates": [
      "sapiente",
      "ut"
    ],
    "EscalationLevels": [
      {},
      {}
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "empower distributed infomediaries"
        },
        "FieldType": "System.String",
        "FieldLength": 476
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 925,
    "Name": "Shields Inc and Sons",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": false,
    "IsDefault": false,
    "UsedInQueue": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 454
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "quo",
    "PersonId": 796,
    "Mrmrs": "quo",
    "Firstname": "Jack",
    "Lastname": "Wuckert",
    "MiddleName": "Nienow-Leuschke",
    "Title": "eos",
    "Description": "Business-focused even-keeled solution",
    "Email": "otis@mckenzie.ca",
    "FullName": "Bernhard Murazik",
    "DirectPhone": "(487)455-7448",
    "FormalName": "Schmitt-Schaefer",
    "CountryId": 848,
    "ContactId": 21,
    "ContactName": "Green, Marks and Grant",
    "Retired": 820,
    "Rank": 371,
    "ActiveInterests": 514,
    "ContactDepartment": "reintermediate dynamic portals",
    "ContactCountryId": 174,
    "ContactOrgNr": "1586129",
    "FaxPhone": "1-351-524-1108 x35442",
    "MobilePhone": "1-825-022-7780 x710",
    "ContactPhone": "(407)548-5154",
    "AssociateName": "Conn-Mann",
    "AssociateId": 382,
    "UsePersonAddress": true,
    "ContactFax": "doloribus",
    "Kanafname": "vel",
    "Kanalname": "eum",
    "Post1": "minima",
    "Post2": "rerum",
    "Post3": "dolor",
    "EmailName": "moriah@renner.co.uk",
    "ContactFullName": "Isaias Hilll",
    "ActiveErpLinks": 847,
    "TicketPriorityId": 932,
    "SupportLanguageId": 895,
    "SupportAssociateId": 309,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 67
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "dolorem",
      "PersonId": 739,
      "Mrmrs": "vel",
      "Firstname": "Carey",
      "Lastname": "Bechtelar",
      "MiddleName": "Schoen Inc and Sons",
      "Title": "mollitia",
      "Description": "Re-engineered 6th generation time-frame",
      "Email": "clarabelle@jones.info",
      "FullName": "Ashton Schuppe",
      "DirectPhone": "1-080-700-4112 x42385",
      "FormalName": "O'Keefe Inc and Sons",
      "CountryId": 823,
      "ContactId": 878,
      "ContactName": "Murphy, Schaefer and Wolf",
      "Retired": 397,
      "Rank": 119,
      "ActiveInterests": 588,
      "ContactDepartment": "",
      "ContactCountryId": 424,
      "ContactOrgNr": "1134252",
      "FaxPhone": "(842)282-6224",
      "MobilePhone": "1-741-727-1142 x803",
      "ContactPhone": "1-038-316-8333",
      "AssociateName": "Ondricka, Hammes and Dietrich",
      "AssociateId": 394,
      "UsePersonAddress": true,
      "ContactFax": "unde",
      "Kanafname": "odit",
      "Kanalname": "dolores",
      "Post1": "ut",
      "Post2": "error",
      "Post3": "quia",
      "EmailName": "ramon@kassulke.name",
      "ContactFullName": "Oren Schmitt",
      "ActiveErpLinks": 198,
      "TicketPriorityId": 788,
      "SupportLanguageId": 605,
      "SupportAssociateId": 368,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 639
        }
      }
    }
  ],
  "AlertLevel": 529,
  "ConnectId": 941,
  "ReadStatus": "Green",
  "TimeToReply": 65,
  "RealTimeToReply": 670,
  "TimeToClose": 396,
  "RealTimeToClose": 710,
  "TimeSpentInternally": 330,
  "TimeSpentExternally": 116,
  "TimeSpentQueue": 587,
  "RealTimeSpentInternally": 208,
  "RealTimeSpentExternally": 690,
  "RealTimeSpentQueue": 136,
  "HasAttachment": false,
  "NumReplies": 406,
  "NumMessages": 747,
  "FromAddress": "qui",
  "Messages": [
    {
      "TicketMessageId": 424,
      "CreatedAt": "2010-10-30T18:25:51.1999373+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "unde",
      "PersonId": 634,
      "PersonFullName": "Felix McDermott",
      "ContactId": 502,
      "ContactName": "Jenkins-Kassulke",
      "ContactDepartment": "",
      "NumAttachments": 648,
      "EmailHeader": "fay@gutmannconroy.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 329
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 637,
      "Name": "Orn LLC",
      "ToolTip": "Vero enim dolores commodi.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 659
        }
      }
    },
    {
      "Id": 637,
      "Name": "Orn LLC",
      "ToolTip": "Vero enim dolores commodi.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 659
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "ipsa"
  },
  "CustomFields": {
    "CustomFields1": "eum",
    "CustomFields2": "ipsum"
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
      "FieldLength": 298
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```