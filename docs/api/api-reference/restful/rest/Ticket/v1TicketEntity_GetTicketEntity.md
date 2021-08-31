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
  "TicketId": 242,
  "Title": "quo",
  "CreatedAt": "2016-04-12T15:05:42.8366618+02:00",
  "LastChanged": "2005-03-01T15:05:42.8366618+01:00",
  "ReadByOwner": "2020-09-14T15:05:42.8366618+02:00",
  "ReadByCustomer": "1994-08-06T15:05:42.8366618+02:00",
  "FirstReadByUser": "2012-10-25T15:05:42.8366618+02:00",
  "Activate": "2001-07-16T15:05:42.8366618+02:00",
  "ClosedAt": "2018-03-12T15:05:42.8366618+01:00",
  "RepliedAt": "2020-12-26T15:05:42.8366618+01:00",
  "AlertTimeout": "2011-04-15T15:05:42.8366618+02:00",
  "Deadline": "2003-02-14T15:05:42.8366618+01:00",
  "CreatedBy": {
    "AssociateId": 246,
    "Name": "Ratke, Littel and Sawayn",
    "PersonId": 80,
    "Rank": 293,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 16,
    "FullName": "Brook Tremblay DVM",
    "FormalName": "Reinger-Monahan",
    "Deleted": false,
    "EjUserId": 449,
    "UserName": "Waters, Gislason and Douglas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 44
      }
    }
  },
  "Author": "ab",
  "OwnedBy": {
    "AssociateId": 135,
    "Name": "Aufderhar-Langworth",
    "PersonId": 121,
    "Rank": 40,
    "Tooltip": "rem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 619,
    "FullName": "Nick O'Kon",
    "FormalName": "Schuster Inc and Sons",
    "Deleted": true,
    "EjUserId": 142,
    "UserName": "Price Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 766
      }
    }
  },
  "Category": {
    "TicketCategoryId": 315,
    "ParentId": 576,
    "Name": "Boehm-Harber",
    "Fullname": "dolore",
    "CategoryMaster": 348,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Cruickshank-Mueller",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 610,
    "ReplyTemplate": 254,
    "NotificationEmail": "stone.cronin@erdman.uk",
    "ExtraFields": {
      "ExtraFields1": "dolorem",
      "ExtraFields2": "nihil"
    },
    "CustomFields": {
      "CustomFields1": "et",
      "CustomFields2": "dicta"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 504
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 609,
    "Name": "Beier-Jaskolski",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 180,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 842,
    "MonStart": "2005-04-01T15:05:42.8386619+02:00",
    "MonStop": "1999-12-22T15:05:42.8386619+01:00",
    "TueStart": "2005-02-05T15:05:42.8386619+01:00",
    "TueStop": "2020-07-29T15:05:42.8386619+02:00",
    "WedStart": "2011-12-20T15:05:42.8386619+01:00",
    "WedStop": "2018-01-21T15:05:42.8386619+01:00",
    "ThuStart": "2004-03-31T15:05:42.8386619+02:00",
    "ThuStop": "2012-05-16T15:05:42.8386619+02:00",
    "FriStart": "2013-11-03T15:05:42.8386619+01:00",
    "FriStop": "2015-01-16T15:05:42.8386619+01:00",
    "SatStart": "2004-02-08T15:05:42.8386619+01:00",
    "SatStop": "2008-03-01T15:05:42.8386619+01:00",
    "SunStart": "2002-01-06T15:05:42.8386619+01:00",
    "SunStop": "2000-05-27T15:05:42.8386619+02:00",
    "NonDates": [
      "accusamus",
      "qui"
    ],
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
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 753,
    "Name": "Lang Inc and Sons",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 779
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "ratione",
    "PersonId": 768,
    "Mrmrs": "quis",
    "Firstname": "Nicklaus",
    "Lastname": "Gleason",
    "MiddleName": "Schumm Group",
    "Title": "doloribus",
    "Description": "Intuitive reciprocal toolset",
    "Email": "marcelino@trantow.biz",
    "FullName": "Sigurd Spinka",
    "DirectPhone": "1-017-301-8476 x13607",
    "FormalName": "Gibson Group",
    "CountryId": 519,
    "ContactId": 521,
    "ContactName": "Schuppe, Deckow and Bernhard",
    "Retired": 220,
    "Rank": 628,
    "ActiveInterests": 392,
    "ContactDepartment": "",
    "ContactCountryId": 68,
    "ContactOrgNr": "876290",
    "FaxPhone": "(236)034-6308 x82122",
    "MobilePhone": "804.732.1106 x1378",
    "ContactPhone": "132-023-6772 x048",
    "AssociateName": "Wehner, Terry and Toy",
    "AssociateId": 377,
    "UsePersonAddress": false,
    "ContactFax": "quae",
    "Kanafname": "nihil",
    "Kanalname": "earum",
    "Post1": "quos",
    "Post2": "rerum",
    "Post3": "suscipit",
    "EmailName": "bessie.schmidt@stoltenberg.uk",
    "ContactFullName": "Davin O'Conner",
    "ActiveErpLinks": 622,
    "TicketPriorityId": 280,
    "SupportLanguageId": 856,
    "SupportAssociateId": 224,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 247
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "numquam",
      "PersonId": 909,
      "Mrmrs": "et",
      "Firstname": "Abigayle",
      "Lastname": "Shields",
      "MiddleName": "Wyman Group",
      "Title": "qui",
      "Description": "Multi-layered uniform initiative",
      "Email": "jacques@cartwright.biz",
      "FullName": "Crawford Ryan",
      "DirectPhone": "471-000-0602 x31067",
      "FormalName": "Carroll Group",
      "CountryId": 490,
      "ContactId": 607,
      "ContactName": "Daugherty Group",
      "Retired": 789,
      "Rank": 500,
      "ActiveInterests": 767,
      "ContactDepartment": "",
      "ContactCountryId": 949,
      "ContactOrgNr": "1466420",
      "FaxPhone": "015-515-0875 x3350",
      "MobilePhone": "1-322-844-6162",
      "ContactPhone": "(352)608-4630",
      "AssociateName": "Cremin-Mohr",
      "AssociateId": 429,
      "UsePersonAddress": true,
      "ContactFax": "soluta",
      "Kanafname": "quo",
      "Kanalname": "odit",
      "Post1": "aliquid",
      "Post2": "sunt",
      "Post3": "aut",
      "EmailName": "carlos@willms.us",
      "ContactFullName": "Mr. Jacinthe Marquardt",
      "ActiveErpLinks": 95,
      "TicketPriorityId": 590,
      "SupportLanguageId": 486,
      "SupportAssociateId": 918,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 945
        }
      }
    }
  ],
  "AlertLevel": 136,
  "ConnectId": 706,
  "ReadStatus": "Green",
  "TimeToReply": 451,
  "RealTimeToReply": 375,
  "TimeToClose": 46,
  "RealTimeToClose": 211,
  "TimeSpentInternally": 4,
  "TimeSpentExternally": 521,
  "TimeSpentQueue": 993,
  "RealTimeSpentInternally": 752,
  "RealTimeSpentExternally": 242,
  "RealTimeSpentQueue": 964,
  "HasAttachment": false,
  "NumReplies": 423,
  "NumMessages": 20,
  "FromAddress": "perspiciatis",
  "Messages": [
    {
      "TicketMessageId": 111,
      "CreatedAt": "2018-07-27T15:05:42.8406622+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "aliquam",
      "PersonId": 622,
      "PersonFullName": "Kyler Hilpert",
      "ContactId": 228,
      "ContactName": "Doyle, Wisozk and Goodwin",
      "ContactDepartment": "",
      "NumAttachments": 958,
      "EmailHeader": "era_sawayn@rolfson.info",
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
          "FieldLength": 613
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 469,
      "Name": "Koepp LLC",
      "ToolTip": "Id sapiente ea voluptatem.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 874
        }
      }
    },
    {
      "Id": 469,
      "Name": "Koepp LLC",
      "ToolTip": "Id sapiente ea voluptatem.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 874
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "dolor",
    "CustomFields2": "perspiciatis"
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
      "FieldLength": 878
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```