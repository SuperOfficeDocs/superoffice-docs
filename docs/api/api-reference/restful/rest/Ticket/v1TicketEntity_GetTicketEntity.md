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
GET /api/v1/Ticket/{id}?fk=False
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
| OwnedBy |  | The associate who owns this ticket  <para>Use MDO List name "associate" to get list items.</para> |
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
  "TicketId": 90,
  "Title": "corrupti",
  "CreatedAt": "2002-04-11T09:40:59.7980409+02:00",
  "LastChanged": "2014-03-05T09:40:59.7980409+01:00",
  "ReadByOwner": "2011-07-21T09:40:59.7980409+02:00",
  "ReadByCustomer": "2018-01-19T09:40:59.7980409+01:00",
  "FirstReadByUser": "1998-12-09T09:40:59.7980409+01:00",
  "Activate": "1995-10-28T09:40:59.7980409+02:00",
  "ClosedAt": "1997-04-25T09:40:59.7980409+02:00",
  "RepliedAt": "2013-06-07T09:40:59.7980409+02:00",
  "AlertTimeout": "2018-12-12T09:40:59.7980409+01:00",
  "Deadline": "2001-11-20T09:40:59.7980409+01:00",
  "CreatedBy": {
    "AssociateId": 610,
    "Name": "Rowe, D'Amore and Keeling",
    "PersonId": 104,
    "Rank": 648,
    "Tooltip": "nihil",
    "Type": "AnonymousAssociate",
    "GroupIdx": 283,
    "FullName": "Doyle Rath",
    "FormalName": "Welch, Carter and VonRueden",
    "Deleted": false,
    "EjUserId": 630,
    "UserName": "Nader, Wintheiser and Ziemann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 652
      }
    }
  },
  "Author": "et",
  "OwnedBy": {
    "AssociateId": 820,
    "Name": "Carroll-Boyle",
    "PersonId": 608,
    "Rank": 179,
    "Tooltip": "aliquid",
    "Type": "AnonymousAssociate",
    "GroupIdx": 761,
    "FullName": "Mrs. Geovanni Dicki",
    "FormalName": "Becker Group",
    "Deleted": false,
    "EjUserId": 444,
    "UserName": "Schoen, Wilkinson and Rutherford",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 743
      }
    }
  },
  "Category": {
    "TicketCategoryId": 767,
    "ParentId": 693,
    "Name": "Dibbert-Zieme",
    "Fullname": "dicta",
    "CategoryMaster": 923,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Breitenberg LLC",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 772,
    "ReplyTemplate": 753,
    "NotificationEmail": "katelyn.rutherford@kassulke.com",
    "ExtraFields": {
      "ExtraFields1": "consequatur",
      "ExtraFields2": "animi"
    },
    "CustomFields": {
      "CustomFields1": "minima",
      "CustomFields2": "iusto"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 575
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 711,
    "Name": "Gleichner Inc and Sons",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 537,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 273,
    "MonStart": "2001-05-23T09:40:59.8000646+02:00",
    "MonStop": "1994-09-28T09:40:59.8000646+02:00",
    "TueStart": "1994-06-02T09:40:59.8000646+02:00",
    "TueStop": "2014-01-14T09:40:59.8000646+01:00",
    "WedStart": "2001-12-09T09:40:59.8000646+01:00",
    "WedStop": "1996-04-07T09:40:59.8000646+02:00",
    "ThuStart": "1999-09-03T09:40:59.8000646+02:00",
    "ThuStop": "1997-05-03T09:40:59.8000646+02:00",
    "FriStart": "2013-08-19T09:40:59.8000646+02:00",
    "FriStop": "2019-08-20T09:40:59.8000646+02:00",
    "SatStart": "2012-10-24T09:40:59.8000646+02:00",
    "SatStop": "1997-09-12T09:40:59.8000646+02:00",
    "SunStart": "1996-08-02T09:40:59.8000646+02:00",
    "SunStop": "2008-03-30T09:40:59.8000646+02:00",
    "NonDates": [
      "delectus",
      "sed"
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 958
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 487,
    "Name": "Bernier, Ritchie and Gibson",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 908
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "qui",
    "PersonId": 866,
    "Mrmrs": "minima",
    "Firstname": "Rocky",
    "Lastname": "Auer",
    "MiddleName": "Zemlak Group",
    "Title": "veritatis",
    "Description": "Team-oriented empowering system engine",
    "Email": "rosalyn.keebler@koelpin.biz",
    "FullName": "Jude Jerde IV",
    "DirectPhone": "608.553.6341",
    "FormalName": "Weimann Inc and Sons",
    "CountryId": 493,
    "ContactId": 227,
    "ContactName": "Pagac LLC",
    "Retired": 130,
    "Rank": 845,
    "ActiveInterests": 696,
    "ContactDepartment": "",
    "ContactCountryId": 384,
    "ContactOrgNr": "713442",
    "FaxPhone": "102-463-4725",
    "MobilePhone": "428-152-1371",
    "ContactPhone": "144-125-6862",
    "AssociateName": "McGlynn-Ebert",
    "AssociateId": 684,
    "UsePersonAddress": true,
    "ContactFax": "laudantium",
    "Kanafname": "molestiae",
    "Kanalname": "tempora",
    "Post1": "neque",
    "Post2": "dicta",
    "Post3": "et",
    "EmailName": "gudrun@corkery.info",
    "ContactFullName": "Sigurd Runte DVM",
    "ActiveErpLinks": 611,
    "TicketPriorityId": 139,
    "SupportLanguageId": 852,
    "SupportAssociateId": 146,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 66
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "dolor",
      "PersonId": 535,
      "Mrmrs": "ullam",
      "Firstname": "Melvin",
      "Lastname": "Stanton",
      "MiddleName": "Quigley-Rutherford",
      "Title": "corporis",
      "Description": "Fully-configurable actuating capability",
      "Email": "luciano@kuhndamore.co.uk",
      "FullName": "Arlene Schamberger",
      "DirectPhone": "1-073-528-6413",
      "FormalName": "Boyer-Kutch",
      "CountryId": 105,
      "ContactId": 503,
      "ContactName": "Upton Inc and Sons",
      "Retired": 358,
      "Rank": 392,
      "ActiveInterests": 467,
      "ContactDepartment": "",
      "ContactCountryId": 549,
      "ContactOrgNr": "1809504",
      "FaxPhone": "1-634-886-6127 x373",
      "MobilePhone": "671-678-1487 x15637",
      "ContactPhone": "246.723.8135",
      "AssociateName": "Grimes-Smitham",
      "AssociateId": 648,
      "UsePersonAddress": false,
      "ContactFax": "quod",
      "Kanafname": "est",
      "Kanalname": "corrupti",
      "Post1": "quia",
      "Post2": "consequatur",
      "Post3": "in",
      "EmailName": "mose.wolf@harveyupton.ca",
      "ContactFullName": "Anika Mayer",
      "ActiveErpLinks": 515,
      "TicketPriorityId": 377,
      "SupportLanguageId": 884,
      "SupportAssociateId": 19,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "incubate next-generation systems"
          },
          "FieldType": "System.Int32",
          "FieldLength": 984
        }
      }
    }
  ],
  "AlertLevel": 129,
  "ConnectId": 885,
  "ReadStatus": "Green",
  "TimeToReply": 754,
  "RealTimeToReply": 239,
  "TimeToClose": 870,
  "RealTimeToClose": 443,
  "TimeSpentInternally": 245,
  "TimeSpentExternally": 881,
  "TimeSpentQueue": 445,
  "RealTimeSpentInternally": 120,
  "RealTimeSpentExternally": 970,
  "RealTimeSpentQueue": 307,
  "HasAttachment": true,
  "NumReplies": 92,
  "NumMessages": 686,
  "FromAddress": "sapiente",
  "Messages": [
    {
      "TicketMessageId": 933,
      "CreatedAt": "2018-07-30T09:40:59.8030642+02:00",
      "Slevel": "External",
      "Important": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 751
        }
      }
    },
    {
      "TicketMessageId": 933,
      "CreatedAt": "2018-07-30T09:40:59.8030642+02:00",
      "Slevel": "External",
      "Important": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 751
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 471,
      "Name": "Boehm-Grimes",
      "ToolTip": "Cupiditate illo distinctio id ducimus.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 41
        }
      }
    },
    {
      "Id": 471,
      "Name": "Boehm-Grimes",
      "ToolTip": "Cupiditate illo distinctio id ducimus.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 41
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "dolores"
  },
  "CustomFields": {
    "CustomFields1": "voluptate",
    "CustomFields2": "in"
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
      "FieldLength": 250
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```