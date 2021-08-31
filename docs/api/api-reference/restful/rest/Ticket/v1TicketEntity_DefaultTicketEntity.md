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
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 729,
  "Title": "praesentium",
  "CreatedAt": "2002-04-29T15:05:42.8106622+02:00",
  "LastChanged": "1996-05-20T15:05:42.8106622+02:00",
  "ReadByOwner": "2021-04-17T15:05:42.8106622+02:00",
  "ReadByCustomer": "2019-11-26T15:05:42.8106622+01:00",
  "FirstReadByUser": "1999-10-01T15:05:42.8106622+02:00",
  "Activate": "2008-08-17T15:05:42.8106622+02:00",
  "ClosedAt": "2015-06-22T15:05:42.8106622+02:00",
  "RepliedAt": "2001-01-19T15:05:42.8106622+01:00",
  "AlertTimeout": "2003-04-22T15:05:42.8106622+02:00",
  "Deadline": "2004-12-14T15:05:42.8106622+01:00",
  "CreatedBy": {
    "AssociateId": 998,
    "Name": "O'Connell Group",
    "PersonId": 497,
    "Rank": 208,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 417,
    "FullName": "Freeman Prohaska Sr.",
    "FormalName": "Williamson, Eichmann and Heathcote",
    "Deleted": true,
    "EjUserId": 181,
    "UserName": "Hartmann, King and Kassulke",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "reinvent cross-media platforms"
        },
        "FieldType": "System.String",
        "FieldLength": 251
      }
    }
  },
  "Author": "sit",
  "OwnedBy": {
    "AssociateId": 58,
    "Name": "Corwin-Orn",
    "PersonId": 315,
    "Rank": 121,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 471,
    "FullName": "Ernie Hauck",
    "FormalName": "Tromp LLC",
    "Deleted": false,
    "EjUserId": 263,
    "UserName": "Jakubowski, Kuhlman and Treutel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 328
      }
    }
  },
  "Category": {
    "TicketCategoryId": 391,
    "ParentId": 9,
    "Name": "Kuvalis, Reichel and Cummerata",
    "Fullname": "eaque",
    "CategoryMaster": 647,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Turcotte Inc and Sons",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 557,
    "ReplyTemplate": 867,
    "NotificationEmail": "autumn.tillman@heathcote.us",
    "ExtraFields": {
      "ExtraFields1": "vel",
      "ExtraFields2": "nesciunt"
    },
    "CustomFields": {
      "CustomFields1": "cupiditate",
      "CustomFields2": "maiores"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 653
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 380,
    "Name": "Gutkowski-Marvin",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 551,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 720,
    "MonStart": "2018-03-06T15:05:42.8116628+01:00",
    "MonStop": "2019-04-05T15:05:42.8116628+02:00",
    "TueStart": "2007-10-25T15:05:42.8116628+02:00",
    "TueStop": "2002-04-20T15:05:42.8116628+02:00",
    "WedStart": "2005-06-09T15:05:42.8116628+02:00",
    "WedStop": "2016-02-18T15:05:42.8116628+01:00",
    "ThuStart": "2009-07-12T15:05:42.8116628+02:00",
    "ThuStop": "1999-10-27T15:05:42.8116628+02:00",
    "FriStart": "2018-11-23T15:05:42.8116628+01:00",
    "FriStop": "2016-04-25T15:05:42.8116628+02:00",
    "SatStart": "2008-05-04T15:05:42.8116628+02:00",
    "SatStop": "2009-03-30T15:05:42.8116628+02:00",
    "SunStart": "2020-08-02T15:05:42.8116628+02:00",
    "SunStop": "1998-06-02T15:05:42.8116628+02:00",
    "NonDates": [
      "dolores",
      "officiis"
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "synthesize cross-platform experiences"
        },
        "FieldType": "System.Int32",
        "FieldLength": 855
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 756,
    "Name": "Quitzon, Funk and Jaskolski",
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
        "FieldLength": 788
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "nemo",
    "PersonId": 582,
    "Mrmrs": "odit",
    "Firstname": "Asia",
    "Lastname": "Zemlak",
    "MiddleName": "Price, Kihn and Crooks",
    "Title": "iste",
    "Description": "Mandatory national collaboration",
    "Email": "camren@stehr.uk",
    "FullName": "Ashley Stamm",
    "DirectPhone": "622.402.5247 x8371",
    "FormalName": "Schultz, Bednar and Konopelski",
    "CountryId": 550,
    "ContactId": 50,
    "ContactName": "Hodkiewicz, Larson and Morar",
    "Retired": 870,
    "Rank": 749,
    "ActiveInterests": 27,
    "ContactDepartment": "",
    "ContactCountryId": 560,
    "ContactOrgNr": "780736",
    "FaxPhone": "(423)641-3852 x872",
    "MobilePhone": "(288)130-4782",
    "ContactPhone": "1-552-256-4048 x4712",
    "AssociateName": "Batz, O'Kon and Jast",
    "AssociateId": 578,
    "UsePersonAddress": true,
    "ContactFax": "quis",
    "Kanafname": "molestiae",
    "Kanalname": "itaque",
    "Post1": "est",
    "Post2": "tenetur",
    "Post3": "eum",
    "EmailName": "adella@kuphal.co.uk",
    "ContactFullName": "Juston Spinka",
    "ActiveErpLinks": 793,
    "TicketPriorityId": 188,
    "SupportLanguageId": 812,
    "SupportAssociateId": 181,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 20
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "iure",
      "PersonId": 361,
      "Mrmrs": "vitae",
      "Firstname": "Della",
      "Lastname": "Thompson",
      "MiddleName": "Dooley, Powlowski and Homenick",
      "Title": "enim",
      "Description": "Object-based contextually-based benchmark",
      "Email": "bernard.howe@ankunding.info",
      "FullName": "Kody Metz",
      "DirectPhone": "703-060-2028 x5524",
      "FormalName": "Cummerata Group",
      "CountryId": 535,
      "ContactId": 293,
      "ContactName": "Parker, Lakin and Runolfsdottir",
      "Retired": 504,
      "Rank": 118,
      "ActiveInterests": 142,
      "ContactDepartment": "",
      "ContactCountryId": 986,
      "ContactOrgNr": "364074",
      "FaxPhone": "(622)258-6538",
      "MobilePhone": "1-316-655-0712",
      "ContactPhone": "(583)288-5126",
      "AssociateName": "O'Conner Group",
      "AssociateId": 341,
      "UsePersonAddress": true,
      "ContactFax": "soluta",
      "Kanafname": "hic",
      "Kanalname": "eos",
      "Post1": "culpa",
      "Post2": "qui",
      "Post3": "aliquid",
      "EmailName": "elias_konopelski@abshire.us",
      "ContactFullName": "Erna Balistreri",
      "ActiveErpLinks": 750,
      "TicketPriorityId": 47,
      "SupportLanguageId": 225,
      "SupportAssociateId": 654,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 789
        }
      }
    }
  ],
  "AlertLevel": 428,
  "ConnectId": 466,
  "ReadStatus": "Green",
  "TimeToReply": 415,
  "RealTimeToReply": 650,
  "TimeToClose": 227,
  "RealTimeToClose": 348,
  "TimeSpentInternally": 425,
  "TimeSpentExternally": 632,
  "TimeSpentQueue": 356,
  "RealTimeSpentInternally": 290,
  "RealTimeSpentExternally": 717,
  "RealTimeSpentQueue": 190,
  "HasAttachment": false,
  "NumReplies": 981,
  "NumMessages": 907,
  "FromAddress": "modi",
  "Messages": [
    {
      "TicketMessageId": 345,
      "CreatedAt": "2003-12-17T15:05:42.8156627+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "dolores",
      "PersonId": 354,
      "PersonFullName": "Collin Thompson MD",
      "ContactId": 359,
      "ContactName": "Simonis Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 925,
      "EmailHeader": "roma@schustermurray.biz",
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
          "FieldLength": 687
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 614,
      "Name": "Brown, Bergstrom and Halvorson",
      "ToolTip": "Consectetur eveniet aut.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 323
        }
      }
    },
    {
      "Id": 614,
      "Name": "Brown, Bergstrom and Halvorson",
      "ToolTip": "Consectetur eveniet aut.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 323
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "praesentium",
    "ExtraFields2": "laudantium"
  },
  "CustomFields": {
    "CustomFields1": "ad",
    "CustomFields2": "praesentium"
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
      "FieldLength": 930
    }
  }
}
```