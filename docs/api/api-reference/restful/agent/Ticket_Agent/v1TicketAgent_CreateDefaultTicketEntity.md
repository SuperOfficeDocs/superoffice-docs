---
title: POST Agents/Ticket/CreateDefaultTicketEntity
id: v1TicketAgent_CreateDefaultTicketEntity
---

# POST Agents/Ticket/CreateDefaultTicketEntity

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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 547,
  "Title": "veniam",
  "CreatedAt": "1995-07-24T18:28:50.2774483+02:00",
  "LastChanged": "2007-02-06T18:28:50.2774483+01:00",
  "ReadByOwner": "2018-07-12T18:28:50.2774483+02:00",
  "ReadByCustomer": "1997-09-22T18:28:50.2774483+02:00",
  "FirstReadByUser": "2020-11-14T18:28:50.2774483+01:00",
  "Activate": "2014-01-19T18:28:50.2774483+01:00",
  "ClosedAt": "2003-12-09T18:28:50.2774483+01:00",
  "RepliedAt": "2016-11-12T18:28:50.2774483+01:00",
  "AlertTimeout": "2020-03-13T18:28:50.2774483+01:00",
  "Deadline": "2012-07-12T18:28:50.2774483+02:00",
  "CreatedBy": {
    "AssociateId": 457,
    "Name": "Haley, Bashirian and Wyman",
    "PersonId": 490,
    "Rank": 545,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 116,
    "FullName": "Dr. Percival Predovic",
    "FormalName": "Schulist Group",
    "Deleted": true,
    "EjUserId": 809,
    "UserName": "Dare, Leannon and Stokes",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 97
      }
    }
  },
  "Author": "sit",
  "OwnedBy": {
    "AssociateId": 162,
    "Name": "Armstrong Group",
    "PersonId": 531,
    "Rank": 219,
    "Tooltip": "saepe",
    "Type": "AnonymousAssociate",
    "GroupIdx": 272,
    "FullName": "Brennan Emmerich Jr.",
    "FormalName": "Steuber LLC",
    "Deleted": true,
    "EjUserId": 188,
    "UserName": "Kovacek, Walter and Wehner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 382
      }
    }
  },
  "Category": {
    "TicketCategoryId": 458,
    "ParentId": 999,
    "Name": "Parisian-Kilback",
    "Fullname": "ratione",
    "CategoryMaster": 440,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Gislason LLC",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 861,
    "ReplyTemplate": 976,
    "NotificationEmail": "marcelo_kulas@deckow.name",
    "DefaultTicketStatus": {},
    "DefaultMessageStatus": {},
    "ExtraFields": {
      "ExtraFields1": "impedit",
      "ExtraFields2": "non"
    },
    "CustomFields": {
      "CustomFields1": "aliquam",
      "CustomFields2": "quo"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 592
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 504,
    "Name": "McKenzie Inc and Sons",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 65,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 872,
    "MonStart": "2013-01-17T18:28:50.2804137+01:00",
    "MonStop": "1997-08-17T18:28:50.2804137+02:00",
    "TueStart": "2000-12-09T18:28:50.2804137+01:00",
    "TueStop": "1999-08-09T18:28:50.2804137+02:00",
    "WedStart": "1997-08-02T18:28:50.2804137+02:00",
    "WedStop": "2016-06-04T18:28:50.2804137+02:00",
    "ThuStart": "2007-02-10T18:28:50.2804137+01:00",
    "ThuStop": "2010-02-11T18:28:50.2804137+01:00",
    "FriStart": "2009-12-19T18:28:50.2804137+01:00",
    "FriStop": "2016-04-11T18:28:50.2804137+02:00",
    "SatStart": "2001-04-30T18:28:50.2804137+02:00",
    "SatStop": "2012-11-18T18:28:50.2804137+01:00",
    "SunStart": "1996-04-22T18:28:50.2804137+02:00",
    "SunStop": "2021-06-23T18:28:50.2804137+02:00",
    "NonDates": [
      "cum",
      "est"
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
        "FieldType": "System.Int32",
        "FieldLength": 884
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 487,
    "Name": "Jaskolski-Jewess",
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
        "FieldType": "System.String",
        "FieldLength": 952
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "quia",
    "PersonId": 392,
    "Mrmrs": "quasi",
    "Firstname": "Lowell",
    "Lastname": "Hoppe",
    "MiddleName": "Kerluke-Kassulke",
    "Title": "et",
    "Description": "Inverse intangible Graphical User Interface",
    "Email": "marcella_kertzmann@gottlieb.info",
    "FullName": "Enola Gottlieb",
    "DirectPhone": "414-063-8286",
    "FormalName": "Frami LLC",
    "CountryId": 33,
    "ContactId": 982,
    "ContactName": "Hilll, Collier and Pollich",
    "Retired": 630,
    "Rank": 750,
    "ActiveInterests": 671,
    "ContactDepartment": "",
    "ContactCountryId": 685,
    "ContactOrgNr": "1453965",
    "FaxPhone": "675.763.3827 x83050",
    "MobilePhone": "851.423.4315 x527",
    "ContactPhone": "(756)324-3837 x1060",
    "AssociateName": "Rowe-Ortiz",
    "AssociateId": 45,
    "UsePersonAddress": false,
    "ContactFax": "qui",
    "Kanafname": "nostrum",
    "Kanalname": "placeat",
    "Post1": "nisi",
    "Post2": "fuga",
    "Post3": "nihil",
    "EmailName": "blair@ankundinghermann.biz",
    "ContactFullName": "Erich Mills",
    "ActiveErpLinks": 201,
    "TicketPriorityId": 966,
    "SupportLanguageId": 260,
    "SupportAssociateId": 311,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 400
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "dignissimos",
      "PersonId": 964,
      "Mrmrs": "harum",
      "Firstname": "Nelle",
      "Lastname": "Breitenberg",
      "MiddleName": "Hahn, Emard and Oberbrunner",
      "Title": "ratione",
      "Description": "Distributed dynamic core",
      "Email": "brad@cormier.co.uk",
      "FullName": "Miss Andre Tillman",
      "DirectPhone": "781-558-1110 x3342",
      "FormalName": "Keeling Group",
      "CountryId": 336,
      "ContactId": 458,
      "ContactName": "O'Hara Inc and Sons",
      "Retired": 131,
      "Rank": 165,
      "ActiveInterests": 211,
      "ContactDepartment": "",
      "ContactCountryId": 314,
      "ContactOrgNr": "1286905",
      "FaxPhone": "1-857-482-8031 x01006",
      "MobilePhone": "670.603.5787 x703",
      "ContactPhone": "527-217-4826",
      "AssociateName": "Volkman-Vandervort",
      "AssociateId": 257,
      "UsePersonAddress": false,
      "ContactFax": "hic",
      "Kanafname": "praesentium",
      "Kanalname": "et",
      "Post1": "itaque",
      "Post2": "pariatur",
      "Post3": "ut",
      "EmailName": "joyce.kris@pouros.info",
      "ContactFullName": "Rosalee Swift",
      "ActiveErpLinks": 856,
      "TicketPriorityId": 87,
      "SupportLanguageId": 710,
      "SupportAssociateId": 604,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 473
        }
      }
    }
  ],
  "AlertLevel": 347,
  "ConnectId": 881,
  "ReadStatus": "Green",
  "TimeToReply": 844,
  "RealTimeToReply": 804,
  "TimeToClose": 597,
  "RealTimeToClose": 754,
  "TimeSpentInternally": 155,
  "TimeSpentExternally": 180,
  "TimeSpentQueue": 298,
  "RealTimeSpentInternally": 186,
  "RealTimeSpentExternally": 386,
  "RealTimeSpentQueue": 699,
  "HasAttachment": false,
  "NumReplies": 520,
  "NumMessages": 455,
  "FromAddress": "tempora",
  "Messages": [
    {
      "TicketMessageId": 499,
      "CreatedAt": "2015-11-03T18:28:50.2824417+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "labore",
      "PersonId": 107,
      "PersonFullName": "Lelia Lehner Sr.",
      "ContactId": 852,
      "ContactName": "Jones-Price",
      "ContactDepartment": "",
      "NumAttachments": 627,
      "EmailHeader": "armando@parisianheathcote.name",
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
          "FieldLength": 100
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 461,
      "Name": "Wuckert LLC",
      "ToolTip": "Cupiditate beatae quod.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 653
        }
      }
    },
    {
      "Id": 461,
      "Name": "Wuckert LLC",
      "ToolTip": "Cupiditate beatae quod.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 653
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "id",
    "ExtraFields2": "doloribus"
  },
  "CustomFields": {
    "CustomFields1": "repellat",
    "CustomFields2": "nam"
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
      "FieldLength": 374
    }
  }
}
```