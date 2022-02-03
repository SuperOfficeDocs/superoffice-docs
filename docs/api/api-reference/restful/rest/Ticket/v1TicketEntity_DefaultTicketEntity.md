---
title: GET Ticket/default
id: v1TicketEntity_DefaultTicketEntity
---

# GET Ticket/default

```http
GET /api/v1/Ticket/default
```

Set default values into a new TicketEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Ticket agent service CreateDefaultTicketEntity.






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



Carrier object for TicketEntity.
Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

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

## Sample Request

```http!
GET /api/v1/Ticket/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 775,
  "Title": "aut",
  "CreatedAt": "1997-05-27T18:25:51.1319098+02:00",
  "LastChanged": "1994-10-27T18:25:51.1319098+02:00",
  "ReadByOwner": "2006-11-21T18:25:51.1319098+01:00",
  "ReadByCustomer": "2009-03-26T18:25:51.1319098+01:00",
  "FirstReadByUser": "2002-02-05T18:25:51.1319098+01:00",
  "Activate": "2021-03-20T18:25:51.1319098+01:00",
  "ClosedAt": "2001-01-19T18:25:51.1319098+01:00",
  "RepliedAt": "1997-11-03T18:25:51.1319098+01:00",
  "AlertTimeout": "1995-05-27T18:25:51.1319098+02:00",
  "Deadline": "2013-08-13T18:25:51.1319098+02:00",
  "CreatedBy": {
    "AssociateId": 870,
    "Name": "Gutmann-Ritchie",
    "PersonId": 985,
    "Rank": 386,
    "Tooltip": "quas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 533,
    "FullName": "Keenan Anderson",
    "FormalName": "Barrows-Bashirian",
    "Deleted": false,
    "EjUserId": 395,
    "UserName": "Barton Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 601
      }
    }
  },
  "Author": "vel",
  "OwnedBy": {
    "AssociateId": 475,
    "Name": "Wisozk, Kuhic and Koelpin",
    "PersonId": 161,
    "Rank": 484,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 634,
    "FullName": "Isaac Rempel",
    "FormalName": "Hackett-Rau",
    "Deleted": false,
    "EjUserId": 336,
    "UserName": "Ankunding, Keeling and Pfannerstill",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 934
      }
    }
  },
  "Category": {
    "TicketCategoryId": 528,
    "ParentId": 527,
    "Name": "Maggio Inc and Sons",
    "Fullname": "similique",
    "CategoryMaster": 995,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Weimann LLC",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 494,
    "ReplyTemplate": 99,
    "NotificationEmail": "shemar@haag.biz",
    "DefaultTicketStatus": {},
    "DefaultMessageStatus": {},
    "ExtraFields": {
      "ExtraFields1": "voluptatem",
      "ExtraFields2": "et"
    },
    "CustomFields": {
      "CustomFields1": "dolorem",
      "CustomFields2": "sed"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 305
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 377,
    "Name": "Heller-Terry",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 815,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 591,
    "MonStart": "1999-09-25T18:25:51.1329321+02:00",
    "MonStop": "2008-09-19T18:25:51.1329321+02:00",
    "TueStart": "2019-09-26T18:25:51.1329321+02:00",
    "TueStop": "2004-10-09T18:25:51.1329321+02:00",
    "WedStart": "2011-02-08T18:25:51.1329321+01:00",
    "WedStop": "2008-06-15T18:25:51.1329321+02:00",
    "ThuStart": "2009-08-08T18:25:51.1329321+02:00",
    "ThuStop": "2007-05-28T18:25:51.1329321+02:00",
    "FriStart": "1997-12-24T18:25:51.1329321+01:00",
    "FriStop": "2013-08-01T18:25:51.1329321+02:00",
    "SatStart": "2000-11-08T18:25:51.1329321+01:00",
    "SatStop": "1995-10-15T18:25:51.1329321+02:00",
    "SunStart": "2008-08-03T18:25:51.1329321+02:00",
    "SunStop": "2004-09-19T18:25:51.1329321+02:00",
    "NonDates": [
      "ut",
      "sunt"
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
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 799
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 803,
    "Name": "Conn-Erdman",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": true,
    "IsDefault": true,
    "UsedInQueue": true,
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
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "natus",
    "PersonId": 814,
    "Mrmrs": "nulla",
    "Firstname": "Liliane",
    "Lastname": "Beahan",
    "MiddleName": "Sauer LLC",
    "Title": "maxime",
    "Description": "Operative radical strategy",
    "Email": "samson_anderson@gorczany.us",
    "FullName": "Deven Lindgren",
    "DirectPhone": "1-278-525-5050 x71467",
    "FormalName": "Barton-Friesen",
    "CountryId": 738,
    "ContactId": 572,
    "ContactName": "McCullough-Feeney",
    "Retired": 710,
    "Rank": 47,
    "ActiveInterests": 693,
    "ContactDepartment": "",
    "ContactCountryId": 549,
    "ContactOrgNr": "848223",
    "FaxPhone": "1-501-785-5481 x726",
    "MobilePhone": "745.252.1483 x65145",
    "ContactPhone": "(060)520-3770",
    "AssociateName": "Schiller-Schowalter",
    "AssociateId": 385,
    "UsePersonAddress": false,
    "ContactFax": "totam",
    "Kanafname": "non",
    "Kanalname": "voluptas",
    "Post1": "nobis",
    "Post2": "ipsam",
    "Post3": "odit",
    "EmailName": "bridie.huels@stoltenberg.com",
    "ContactFullName": "Dominic Daugherty MD",
    "ActiveErpLinks": 737,
    "TicketPriorityId": 124,
    "SupportLanguageId": 722,
    "SupportAssociateId": 400,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 716
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "nihil",
      "PersonId": 429,
      "Mrmrs": "atque",
      "Firstname": "Elyssa",
      "Lastname": "Hickle",
      "MiddleName": "Robel-Aufderhar",
      "Title": "enim",
      "Description": "Enterprise-wide zero tolerance knowledge base",
      "Email": "keely_hand@collins.name",
      "FullName": "Aiden Kozey",
      "DirectPhone": "1-070-483-4061",
      "FormalName": "Satterfield, Kunde and Denesik",
      "CountryId": 421,
      "ContactId": 141,
      "ContactName": "Upton-Konopelski",
      "Retired": 743,
      "Rank": 563,
      "ActiveInterests": 995,
      "ContactDepartment": "",
      "ContactCountryId": 949,
      "ContactOrgNr": "974009",
      "FaxPhone": "313.747.2378 x237",
      "MobilePhone": "(403)643-8734 x346",
      "ContactPhone": "1-001-836-1722 x482",
      "AssociateName": "Maggio, Eichmann and Gleason",
      "AssociateId": 549,
      "UsePersonAddress": false,
      "ContactFax": "architecto",
      "Kanafname": "et",
      "Kanalname": "hic",
      "Post1": "et",
      "Post2": "eum",
      "Post3": "deleniti",
      "EmailName": "beaulah_hudson@ryan.co.uk",
      "ContactFullName": "Leslie Ritchie",
      "ActiveErpLinks": 121,
      "TicketPriorityId": 281,
      "SupportLanguageId": 603,
      "SupportAssociateId": 195,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 206
        }
      }
    }
  ],
  "AlertLevel": 836,
  "ConnectId": 965,
  "ReadStatus": "Green",
  "TimeToReply": 475,
  "RealTimeToReply": 77,
  "TimeToClose": 617,
  "RealTimeToClose": 930,
  "TimeSpentInternally": 40,
  "TimeSpentExternally": 385,
  "TimeSpentQueue": 143,
  "RealTimeSpentInternally": 591,
  "RealTimeSpentExternally": 45,
  "RealTimeSpentQueue": 320,
  "HasAttachment": false,
  "NumReplies": 535,
  "NumMessages": 840,
  "FromAddress": "aliquid",
  "Messages": [
    {
      "TicketMessageId": 758,
      "CreatedAt": "2009-11-15T18:25:51.1369099+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "itaque",
      "PersonId": 462,
      "PersonFullName": "Elvis Weissnat II",
      "ContactId": 854,
      "ContactName": "Hand-Pagac",
      "ContactDepartment": "",
      "NumAttachments": 647,
      "EmailHeader": "lorenz.halvorson@stamm.ca",
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
          "FieldType": "System.String",
          "FieldLength": 422
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 312,
      "Name": "Runolfsdottir, Ondricka and Stokes",
      "ToolTip": "Quo quia eius quos.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 306
        }
      }
    },
    {
      "Id": 312,
      "Name": "Runolfsdottir, Ondricka and Stokes",
      "ToolTip": "Quo quia eius quos.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 306
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "neque"
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
      "FieldLength": 593
    }
  }
}
```