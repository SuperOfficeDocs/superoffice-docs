---
title: SetTicketReadByOwner
id: v1TicketAgent_SetTicketReadByOwner
---

# SetTicketReadByOwner

```http
POST /api/v1/Agents/Ticket/SetTicketReadByOwner
```

Set the ReadByOwner status for a ticket.

It will only have an effect if the calling user is the same as the owner of the ticket





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/SetTicketReadByOwner?$select=name,department,category/id
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

TicketEntityId, ReadStatus, CheckEscalating 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketEntityId | int32 |  |
| ReadStatus | string |  |
| CheckEscalating | bool |  |


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
POST /api/v1/Agents/Ticket/SetTicketReadByOwner
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 779,
  "ReadStatus": "Green",
  "CheckEscalating": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 397,
  "Title": "in",
  "CreatedAt": "1996-12-02T14:58:05.3906235+01:00",
  "LastChanged": "2002-11-28T14:58:05.3906235+01:00",
  "ReadByOwner": "2018-05-10T14:58:05.3906235+02:00",
  "ReadByCustomer": "2007-04-04T14:58:05.3906235+02:00",
  "FirstReadByUser": "2014-04-20T14:58:05.3906235+02:00",
  "Activate": "1995-02-28T14:58:05.3906235+01:00",
  "ClosedAt": "2005-12-07T14:58:05.3906235+01:00",
  "RepliedAt": "2011-05-24T14:58:05.3906235+02:00",
  "AlertTimeout": "1997-07-22T14:58:05.3906235+02:00",
  "Deadline": "2000-04-08T14:58:05.3906235+02:00",
  "CreatedBy": {
    "AssociateId": 666,
    "Name": "Reichert-Bergnaum",
    "PersonId": 345,
    "Rank": 160,
    "Tooltip": "repudiandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 894,
    "FullName": "Teagan Koch DDS",
    "FormalName": "Wolff, Monahan and Walsh",
    "Deleted": true,
    "EjUserId": 206,
    "UserName": "Kuhlman LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 763
      }
    }
  },
  "Author": "eum",
  "OwnedBy": {
    "AssociateId": 841,
    "Name": "Shanahan-Botsford",
    "PersonId": 943,
    "Rank": 425,
    "Tooltip": "voluptatum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 715,
    "FullName": "Zaria Kutch",
    "FormalName": "Hane, Heller and Yundt",
    "Deleted": true,
    "EjUserId": 359,
    "UserName": "Green-Hermiston",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 687
      }
    }
  },
  "Category": {
    "TicketCategoryId": 175,
    "ParentId": 958,
    "Name": "Farrell LLC",
    "Fullname": "voluptas",
    "CategoryMaster": 84,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Schuster-Larson",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 503,
    "ReplyTemplate": 33,
    "NotificationEmail": "kevin@mclaughlin.com",
    "ExtraFields": {
      "ExtraFields1": "pariatur",
      "ExtraFields2": "ea"
    },
    "CustomFields": {
      "CustomFields1": "ut",
      "CustomFields2": "porro"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 251
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 286,
    "Name": "Breitenberg-Jenkins",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 982,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 791,
    "MonStart": "2012-09-25T14:58:05.3916229+02:00",
    "MonStop": "2009-09-17T14:58:05.3916229+02:00",
    "TueStart": "2009-12-26T14:58:05.3916229+01:00",
    "TueStop": "2008-11-19T14:58:05.3916229+01:00",
    "WedStart": "2019-02-16T14:58:05.3916229+01:00",
    "WedStop": "2009-04-16T14:58:05.3916229+02:00",
    "ThuStart": "2001-01-23T14:58:05.3916229+01:00",
    "ThuStop": "2021-04-19T14:58:05.3916229+02:00",
    "FriStart": "2011-04-15T14:58:05.3916229+02:00",
    "FriStop": "2019-02-16T14:58:05.3916229+01:00",
    "SatStart": "1994-06-21T14:58:05.3916229+02:00",
    "SatStop": "2002-07-23T14:58:05.3916229+02:00",
    "SunStart": "2006-10-30T14:58:05.3916229+01:00",
    "SunStop": "2013-04-13T14:58:05.3916229+02:00",
    "NonDates": [
      "sunt",
      "voluptatem"
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 681
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 159,
    "Name": "D'Amore, Robel and Jacobson",
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
        "FieldLength": 157
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "hic",
    "PersonId": 165,
    "Mrmrs": "vel",
    "Firstname": "Donato",
    "Lastname": "Witting",
    "MiddleName": "Johns LLC",
    "Title": "tempore",
    "Description": "Visionary exuding process improvement",
    "Email": "tillman@marquardt.us",
    "FullName": "Theo Rath",
    "DirectPhone": "1-762-527-1414",
    "FormalName": "Greenfelder LLC",
    "CountryId": 948,
    "ContactId": 709,
    "ContactName": "Ritchie LLC",
    "Retired": 293,
    "Rank": 68,
    "ActiveInterests": 416,
    "ContactDepartment": "",
    "ContactCountryId": 923,
    "ContactOrgNr": "832703",
    "FaxPhone": "148-142-0042 x671",
    "MobilePhone": "(441)235-5582",
    "ContactPhone": "1-055-886-8185 x550",
    "AssociateName": "Stokes, Durgan and Hane",
    "AssociateId": 463,
    "UsePersonAddress": true,
    "ContactFax": "molestiae",
    "Kanafname": "sed",
    "Kanalname": "a",
    "Post1": "laborum",
    "Post2": "dolorem",
    "Post3": "iste",
    "EmailName": "melvin_jones@kesslerboyle.ca",
    "ContactFullName": "Retta Ondricka",
    "ActiveErpLinks": 293,
    "TicketPriorityId": 480,
    "SupportLanguageId": 883,
    "SupportAssociateId": 877,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 428
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "neque",
      "PersonId": 509,
      "Mrmrs": "id",
      "Firstname": "Penelope",
      "Lastname": "Kassulke",
      "MiddleName": "Wolff Inc and Sons",
      "Title": "accusamus",
      "Description": "Function-based attitude-oriented analyzer",
      "Email": "schuyler@maggiofranecki.info",
      "FullName": "Tavares Ward IV",
      "DirectPhone": "(865)042-5343",
      "FormalName": "Shields Group",
      "CountryId": 633,
      "ContactId": 186,
      "ContactName": "Cartwright-Flatley",
      "Retired": 343,
      "Rank": 956,
      "ActiveInterests": 342,
      "ContactDepartment": "",
      "ContactCountryId": 425,
      "ContactOrgNr": "811435",
      "FaxPhone": "1-625-025-3376 x3877",
      "MobilePhone": "1-855-003-8030",
      "ContactPhone": "(558)627-0643 x6414",
      "AssociateName": "Olson-Schamberger",
      "AssociateId": 483,
      "UsePersonAddress": false,
      "ContactFax": "in",
      "Kanafname": "est",
      "Kanalname": "dolorum",
      "Post1": "et",
      "Post2": "enim",
      "Post3": "neque",
      "EmailName": "troy@yundtrunolfsdottir.uk",
      "ContactFullName": "Ms. Lacy Schultz",
      "ActiveErpLinks": 132,
      "TicketPriorityId": 321,
      "SupportLanguageId": 972,
      "SupportAssociateId": 189,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 562
        }
      }
    }
  ],
  "AlertLevel": 774,
  "ConnectId": 144,
  "ReadStatus": "Green",
  "TimeToReply": 527,
  "RealTimeToReply": 883,
  "TimeToClose": 275,
  "RealTimeToClose": 111,
  "TimeSpentInternally": 934,
  "TimeSpentExternally": 509,
  "TimeSpentQueue": 144,
  "RealTimeSpentInternally": 544,
  "RealTimeSpentExternally": 53,
  "RealTimeSpentQueue": 123,
  "HasAttachment": true,
  "NumReplies": 725,
  "NumMessages": 176,
  "FromAddress": "perspiciatis",
  "Messages": [
    {
      "TicketMessageId": 565,
      "CreatedAt": "2008-01-19T14:58:05.3936229+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "beatae",
      "PersonId": 313,
      "PersonFullName": "Domenica Cronin",
      "ContactId": 679,
      "ContactName": "Lind Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 398,
      "EmailHeader": "mariano_quitzon@gutmann.info",
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
          "FieldLength": 538
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 695,
      "Name": "Mertz, Schinner and Pfannerstill",
      "ToolTip": "Sapiente accusantium voluptas non molestiae.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 6
        }
      }
    },
    {
      "Id": 695,
      "Name": "Mertz, Schinner and Pfannerstill",
      "ToolTip": "Sapiente accusantium voluptas non molestiae.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 6
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "aliquam",
    "ExtraFields2": "animi"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "et"
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
      "FieldLength": 620
    }
  }
}
```