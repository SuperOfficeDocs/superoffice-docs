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

## Sample Request

```http!
POST /api/v1/Agents/Ticket/CreateDefaultTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 179,
  "Title": "perferendis",
  "CreatedAt": "2004-11-23T16:48:30.7709345+01:00",
  "LastChanged": "1995-04-07T16:48:30.7709345+02:00",
  "ReadByOwner": "2017-06-21T16:48:30.7709345+02:00",
  "ReadByCustomer": "2017-11-08T16:48:30.7709345+01:00",
  "FirstReadByUser": "1993-11-09T16:48:30.7709345+01:00",
  "Activate": "1999-03-07T16:48:30.7709345+01:00",
  "ClosedAt": "2017-03-18T16:48:30.7709345+01:00",
  "RepliedAt": "2019-05-28T16:48:30.7709345+02:00",
  "AlertTimeout": "2013-03-21T16:48:30.7709345+01:00",
  "Deadline": "2016-11-24T16:48:30.7709345+01:00",
  "CreatedBy": {
    "AssociateId": 458,
    "Name": "Kohler-Gerhold",
    "PersonId": 806,
    "Rank": 193,
    "Tooltip": "labore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 393,
    "FullName": "Ena Hirthe",
    "FormalName": "Ferry LLC",
    "Deleted": true,
    "EjUserId": 248,
    "UserName": "Ebert-Schmeler",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 777
      }
    }
  },
  "Author": "occaecati",
  "OwnedBy": {
    "AssociateId": 144,
    "Name": "Rolfson Group",
    "PersonId": 144,
    "Rank": 424,
    "Tooltip": "nobis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 399,
    "FullName": "Anabelle Barton",
    "FormalName": "Labadie-Monahan",
    "Deleted": true,
    "EjUserId": 396,
    "UserName": "Marks Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 902
      }
    }
  },
  "Category": {
    "TicketCategoryId": 714,
    "ParentId": 85,
    "Name": "McLaughlin-Bogisich",
    "Fullname": "deleniti",
    "CategoryMaster": 122,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Schulist LLC",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 915,
    "ReplyTemplate": 494,
    "NotificationEmail": "aiyana@dicki.info",
    "ExtraFields": {
      "ExtraFields1": "aliquam",
      "ExtraFields2": "et"
    },
    "CustomFields": {
      "CustomFields1": "fugit",
      "CustomFields2": "quaerat"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "exploit killer e-services"
        },
        "FieldType": "System.Int32",
        "FieldLength": 96
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 826,
    "Name": "Weber-Hessel",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 797,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 563,
    "MonStart": "2007-06-27T16:48:30.7719328+02:00",
    "MonStop": "2001-10-11T16:48:30.7719328+02:00",
    "TueStart": "2010-06-27T16:48:30.7719328+02:00",
    "TueStop": "2014-06-03T16:48:30.7719328+02:00",
    "WedStart": "2019-05-24T16:48:30.7719328+02:00",
    "WedStop": "2012-01-11T16:48:30.7719328+01:00",
    "ThuStart": "2016-08-13T16:48:30.7719328+02:00",
    "ThuStop": "2019-03-27T16:48:30.7719328+01:00",
    "FriStart": "1994-05-18T16:48:30.7719328+02:00",
    "FriStop": "2021-01-12T16:48:30.7719328+01:00",
    "SatStart": "2018-03-04T16:48:30.7719328+01:00",
    "SatStop": "2004-09-11T16:48:30.7719328+02:00",
    "SunStart": "2009-12-17T16:48:30.7719328+01:00",
    "SunStop": "2001-04-26T16:48:30.7719328+02:00",
    "NonDates": [
      "quae",
      "consequatur"
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 672
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 960,
    "Name": "Schuppe LLC",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "target proactive interfaces"
        },
        "FieldType": "System.Int32",
        "FieldLength": 39
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "possimus",
    "PersonId": 869,
    "Mrmrs": "excepturi",
    "Firstname": "Tina",
    "Lastname": "Friesen",
    "MiddleName": "Beier, Bernhard and Aufderhar",
    "Title": "vel",
    "Description": "Switchable actuating open architecture",
    "Email": "ricky@keelingwalsh.com",
    "FullName": "Ali Kuhlman",
    "DirectPhone": "(400)315-0465 x13126",
    "FormalName": "Rosenbaum-Hudson",
    "CountryId": 114,
    "ContactId": 715,
    "ContactName": "Mohr Inc and Sons",
    "Retired": 809,
    "Rank": 696,
    "ActiveInterests": 755,
    "ContactDepartment": "",
    "ContactCountryId": 605,
    "ContactOrgNr": "955349",
    "FaxPhone": "(725)327-6837 x30348",
    "MobilePhone": "(164)448-6488 x2538",
    "ContactPhone": "286-314-8450 x467",
    "AssociateName": "Lemke, Metz and Harvey",
    "AssociateId": 773,
    "UsePersonAddress": true,
    "ContactFax": "debitis",
    "Kanafname": "corporis",
    "Kanalname": "et",
    "Post1": "fugit",
    "Post2": "et",
    "Post3": "illo",
    "EmailName": "jarred.bauch@ortiz.biz",
    "ContactFullName": "Chloe Franecki PhD",
    "ActiveErpLinks": 440,
    "TicketPriorityId": 23,
    "SupportLanguageId": 214,
    "SupportAssociateId": 924,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 969
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "enim",
      "PersonId": 363,
      "Mrmrs": "facilis",
      "Firstname": "Marisa",
      "Lastname": "Hessel",
      "MiddleName": "Powlowski-Howe",
      "Title": "ut",
      "Description": "Cross-platform zero tolerance system engine",
      "Email": "green@kiehn.co.uk",
      "FullName": "Georgiana Murphy",
      "DirectPhone": "736.540.7412 x1833",
      "FormalName": "Mohr Inc and Sons",
      "CountryId": 789,
      "ContactId": 670,
      "ContactName": "Roob LLC",
      "Retired": 94,
      "Rank": 977,
      "ActiveInterests": 525,
      "ContactDepartment": "",
      "ContactCountryId": 965,
      "ContactOrgNr": "1183823",
      "FaxPhone": "(388)778-7174 x35761",
      "MobilePhone": "(405)581-6503 x260",
      "ContactPhone": "(037)271-0452 x78815",
      "AssociateName": "Morar LLC",
      "AssociateId": 853,
      "UsePersonAddress": true,
      "ContactFax": "non",
      "Kanafname": "beatae",
      "Kanalname": "quis",
      "Post1": "veniam",
      "Post2": "in",
      "Post3": "quasi",
      "EmailName": "wava@zulaufschmeler.ca",
      "ContactFullName": "Yasmin Kiehn",
      "ActiveErpLinks": 8,
      "TicketPriorityId": 447,
      "SupportLanguageId": 299,
      "SupportAssociateId": 819,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 987
        }
      }
    }
  ],
  "AlertLevel": 865,
  "ConnectId": 807,
  "ReadStatus": "Green",
  "TimeToReply": 867,
  "RealTimeToReply": 991,
  "TimeToClose": 755,
  "RealTimeToClose": 137,
  "TimeSpentInternally": 541,
  "TimeSpentExternally": 728,
  "TimeSpentQueue": 447,
  "RealTimeSpentInternally": 533,
  "RealTimeSpentExternally": 870,
  "RealTimeSpentQueue": 750,
  "HasAttachment": false,
  "NumReplies": 192,
  "NumMessages": 617,
  "FromAddress": "illum",
  "Messages": [
    {
      "TicketMessageId": 963,
      "CreatedAt": "2000-05-09T16:48:30.7749355+02:00",
      "Slevel": "External",
      "Important": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 608
        }
      }
    },
    {
      "TicketMessageId": 963,
      "CreatedAt": "2000-05-09T16:48:30.7749355+02:00",
      "Slevel": "External",
      "Important": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 608
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 120,
      "Name": "Lockman-Gerlach",
      "ToolTip": "Odit id exercitationem asperiores deserunt vel.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "architect B2B vortals"
          },
          "FieldType": "System.Int32",
          "FieldLength": 70
        }
      }
    },
    {
      "Id": 120,
      "Name": "Lockman-Gerlach",
      "ToolTip": "Odit id exercitationem asperiores deserunt vel.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "architect B2B vortals"
          },
          "FieldType": "System.Int32",
          "FieldLength": 70
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "nisi"
  },
  "CustomFields": {
    "CustomFields1": "soluta",
    "CustomFields2": "quaerat"
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
      "FieldLength": 384
    }
  }
}
```