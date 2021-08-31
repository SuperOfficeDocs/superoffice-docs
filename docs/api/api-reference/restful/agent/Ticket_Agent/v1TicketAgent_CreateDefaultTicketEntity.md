---
title: CreateDefaultTicketEntity
id: v1TicketAgent_CreateDefaultTicketEntity
---

# CreateDefaultTicketEntity

```http
POST /api/v1/Agents/Ticket/CreateDefaultTicketEntity
```

Set default values into a new TicketEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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
POST /api/v1/Agents/Ticket/CreateDefaultTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 31,
  "Title": "ut",
  "CreatedAt": "2020-12-28T14:58:05.331628+01:00",
  "LastChanged": "1995-09-20T14:58:05.331628+02:00",
  "ReadByOwner": "2014-04-25T14:58:05.331628+02:00",
  "ReadByCustomer": "2000-09-14T14:58:05.331628+02:00",
  "FirstReadByUser": "1998-05-22T14:58:05.331628+02:00",
  "Activate": "2004-02-23T14:58:05.331628+01:00",
  "ClosedAt": "2002-03-22T14:58:05.331628+01:00",
  "RepliedAt": "1994-09-18T14:58:05.331628+02:00",
  "AlertTimeout": "2019-09-18T14:58:05.331628+02:00",
  "Deadline": "2011-08-01T14:58:05.331628+02:00",
  "CreatedBy": {
    "AssociateId": 346,
    "Name": "Howe Inc and Sons",
    "PersonId": 547,
    "Rank": 886,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 618,
    "FullName": "Elvera Cruickshank",
    "FormalName": "Mayer, Monahan and Marks",
    "Deleted": false,
    "EjUserId": 893,
    "UserName": "Quigley-Sauer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 567
      }
    }
  },
  "Author": "facilis",
  "OwnedBy": {
    "AssociateId": 839,
    "Name": "Grimes, Gutmann and Dooley",
    "PersonId": 254,
    "Rank": 524,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 270,
    "FullName": "Miss Rory Simonis",
    "FormalName": "Dickinson-Ratke",
    "Deleted": false,
    "EjUserId": 411,
    "UserName": "Ferry Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "deliver world-class architectures"
        },
        "FieldType": "System.Int32",
        "FieldLength": 151
      }
    }
  },
  "Category": {
    "TicketCategoryId": 196,
    "ParentId": 982,
    "Name": "Torphy Group",
    "Fullname": "voluptatem",
    "CategoryMaster": 472,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "O'Connell-Nicolas",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 880,
    "ReplyTemplate": 741,
    "NotificationEmail": "vallie.bayer@satterfield.uk",
    "ExtraFields": {
      "ExtraFields1": "et",
      "ExtraFields2": "non"
    },
    "CustomFields": {
      "CustomFields1": "deserunt",
      "CustomFields2": "et"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "empower integrated e-business"
        },
        "FieldType": "System.String",
        "FieldLength": 621
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 725,
    "Name": "Swift-Bins",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 787,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 107,
    "MonStart": "1995-02-04T14:58:05.3326279+01:00",
    "MonStop": "2016-03-14T14:58:05.3326279+01:00",
    "TueStart": "1994-08-10T14:58:05.3326279+02:00",
    "TueStop": "2009-10-24T14:58:05.3326279+02:00",
    "WedStart": "2013-07-29T14:58:05.3326279+02:00",
    "WedStop": "2013-09-22T14:58:05.3326279+02:00",
    "ThuStart": "2017-12-19T14:58:05.3326279+01:00",
    "ThuStop": "2014-08-04T14:58:05.3326279+02:00",
    "FriStart": "2009-02-21T14:58:05.3326279+01:00",
    "FriStop": "2012-12-06T14:58:05.3326279+01:00",
    "SatStart": "2011-04-23T14:58:05.3326279+02:00",
    "SatStop": "2021-02-21T14:58:05.3326279+01:00",
    "SunStart": "1999-05-30T14:58:05.3326279+02:00",
    "SunStop": "2016-05-10T14:58:05.3326279+02:00",
    "NonDates": [
      "aspernatur",
      "repudiandae"
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 623
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 172,
    "Name": "Ziemann, Collier and Hyatt",
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
        "FieldType": "System.String",
        "FieldLength": 122
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "totam",
    "PersonId": 656,
    "Mrmrs": "perferendis",
    "Firstname": "Jamarcus",
    "Lastname": "Considine",
    "MiddleName": "Powlowski-Leannon",
    "Title": "deserunt",
    "Description": "Reduced background toolset",
    "Email": "earl_sawayn@greenholtschumm.ca",
    "FullName": "Carlee Rippin",
    "DirectPhone": "(540)300-8232",
    "FormalName": "Cummings Group",
    "CountryId": 477,
    "ContactId": 351,
    "ContactName": "Hudson-Doyle",
    "Retired": 545,
    "Rank": 654,
    "ActiveInterests": 881,
    "ContactDepartment": "",
    "ContactCountryId": 913,
    "ContactOrgNr": "943057",
    "FaxPhone": "1-678-831-2140 x51647",
    "MobilePhone": "552-587-8310 x50365",
    "ContactPhone": "412.123.8785 x82724",
    "AssociateName": "Stiedemann Inc and Sons",
    "AssociateId": 290,
    "UsePersonAddress": true,
    "ContactFax": "voluptatem",
    "Kanafname": "eveniet",
    "Kanalname": "quidem",
    "Post1": "aliquam",
    "Post2": "adipisci",
    "Post3": "aut",
    "EmailName": "matteo@lemke.uk",
    "ContactFullName": "Mikayla King DDS",
    "ActiveErpLinks": 278,
    "TicketPriorityId": 934,
    "SupportLanguageId": 628,
    "SupportAssociateId": 528,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 228
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "odio",
      "PersonId": 326,
      "Mrmrs": "eius",
      "Firstname": "Carey",
      "Lastname": "Jakubowski",
      "MiddleName": "Pouros LLC",
      "Title": "ut",
      "Description": "Quality-focused solution-oriented budgetary management",
      "Email": "bo_witting@emmerich.ca",
      "FullName": "Kade Rempel",
      "DirectPhone": "208.588.4304 x43737",
      "FormalName": "Bergnaum-Denesik",
      "CountryId": 33,
      "ContactId": 448,
      "ContactName": "Reinger, Jakubowski and Hickle",
      "Retired": 622,
      "Rank": 775,
      "ActiveInterests": 10,
      "ContactDepartment": "",
      "ContactCountryId": 318,
      "ContactOrgNr": "1598223",
      "FaxPhone": "(330)568-2626 x7505",
      "MobilePhone": "775-414-2146",
      "ContactPhone": "1-018-603-6783 x217",
      "AssociateName": "Tremblay Inc and Sons",
      "AssociateId": 126,
      "UsePersonAddress": true,
      "ContactFax": "quibusdam",
      "Kanafname": "doloremque",
      "Kanalname": "quia",
      "Post1": "quod",
      "Post2": "eligendi",
      "Post3": "qui",
      "EmailName": "kyleigh@crist.info",
      "ContactFullName": "Molly Kohler",
      "ActiveErpLinks": 942,
      "TicketPriorityId": 282,
      "SupportLanguageId": 635,
      "SupportAssociateId": 636,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 433
        }
      }
    }
  ],
  "AlertLevel": 257,
  "ConnectId": 199,
  "ReadStatus": "Green",
  "TimeToReply": 148,
  "RealTimeToReply": 578,
  "TimeToClose": 908,
  "RealTimeToClose": 250,
  "TimeSpentInternally": 13,
  "TimeSpentExternally": 434,
  "TimeSpentQueue": 837,
  "RealTimeSpentInternally": 830,
  "RealTimeSpentExternally": 306,
  "RealTimeSpentQueue": 94,
  "HasAttachment": false,
  "NumReplies": 608,
  "NumMessages": 817,
  "FromAddress": "nam",
  "Messages": [
    {
      "TicketMessageId": 325,
      "CreatedAt": "2002-08-10T14:58:05.3346337+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "in",
      "PersonId": 297,
      "PersonFullName": "Russell Auer",
      "ContactId": 399,
      "ContactName": "Kuhlman LLC",
      "ContactDepartment": "",
      "NumAttachments": 818,
      "EmailHeader": "wilma@cassin.name",
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
          "FieldLength": 722
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 424,
      "Name": "Wintheiser-Pacocha",
      "ToolTip": "Ut ut quaerat accusantium corporis dignissimos.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 124
        }
      }
    },
    {
      "Id": 424,
      "Name": "Wintheiser-Pacocha",
      "ToolTip": "Ut ut quaerat accusantium corporis dignissimos.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 124
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "incidunt",
    "ExtraFields2": "exercitationem"
  },
  "CustomFields": {
    "CustomFields1": "totam",
    "CustomFields2": "ad"
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
      "FieldLength": 349
    }
  }
}
```