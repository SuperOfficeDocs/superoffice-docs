---
title: POST Agents/Ticket/SetTicketReadByOwner
id: v1TicketAgent_SetTicketReadByOwner
---

# POST Agents/Ticket/SetTicketReadByOwner

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 549,
  "ReadStatus": "Green",
  "CheckEscalating": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 768,
  "Title": "totam",
  "CreatedAt": "2018-04-18T18:28:50.3864118+02:00",
  "LastChanged": "1998-10-23T18:28:50.3864118+02:00",
  "ReadByOwner": "2017-11-14T18:28:50.3864118+01:00",
  "ReadByCustomer": "2008-01-18T18:28:50.3864118+01:00",
  "FirstReadByUser": "1997-07-15T18:28:50.3864118+02:00",
  "Activate": "1995-10-23T18:28:50.3864118+02:00",
  "ClosedAt": "2005-09-16T18:28:50.3864118+02:00",
  "RepliedAt": "2001-06-03T18:28:50.3864118+02:00",
  "AlertTimeout": "1999-08-18T18:28:50.3864118+02:00",
  "Deadline": "2013-02-18T18:28:50.3864118+01:00",
  "CreatedBy": {
    "AssociateId": 495,
    "Name": "Crist Group",
    "PersonId": 533,
    "Rank": 171,
    "Tooltip": "ducimus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 353,
    "FullName": "Mrs. Denis Pfannerstill",
    "FormalName": "Jenkins, Gleichner and Thompson",
    "Deleted": false,
    "EjUserId": 731,
    "UserName": "Nader Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 679
      }
    }
  },
  "Author": "qui",
  "OwnedBy": {
    "AssociateId": 282,
    "Name": "Mitchell, Halvorson and DuBuque",
    "PersonId": 839,
    "Rank": 484,
    "Tooltip": "fugiat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 208,
    "FullName": "Martina Nader",
    "FormalName": "Kilback-Thompson",
    "Deleted": false,
    "EjUserId": 462,
    "UserName": "Krajcik, Paucek and Quitzon",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "enable cutting-edge communities"
        },
        "FieldType": "System.Int32",
        "FieldLength": 976
      }
    }
  },
  "Category": {
    "TicketCategoryId": 182,
    "ParentId": 493,
    "Name": "Muller-Stehr",
    "Fullname": "esse",
    "CategoryMaster": 936,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Welch-Kemmer",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 883,
    "ReplyTemplate": 486,
    "NotificationEmail": "george.wisoky@emmerich.ca",
    "DefaultTicketStatus": {},
    "DefaultMessageStatus": {},
    "ExtraFields": {
      "ExtraFields1": "perspiciatis",
      "ExtraFields2": "inventore"
    },
    "CustomFields": {
      "CustomFields1": "labore",
      "CustomFields2": "vero"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 64
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 163,
    "Name": "Welch LLC",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 534,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 864,
    "MonStart": "2000-05-13T18:28:50.3874119+02:00",
    "MonStop": "2021-09-11T18:28:50.3874119+02:00",
    "TueStart": "2010-06-03T18:28:50.3874119+02:00",
    "TueStop": "2014-05-25T18:28:50.3874119+02:00",
    "WedStart": "1996-03-17T18:28:50.3874119+01:00",
    "WedStop": "2014-03-17T18:28:50.3874119+01:00",
    "ThuStart": "2014-11-16T18:28:50.3874119+01:00",
    "ThuStop": "2014-04-15T18:28:50.3874119+02:00",
    "FriStart": "1998-01-15T18:28:50.3874119+01:00",
    "FriStop": "2002-09-12T18:28:50.3874119+02:00",
    "SatStart": "1994-11-11T18:28:50.3874119+01:00",
    "SatStop": "1998-01-10T18:28:50.3874119+01:00",
    "SunStart": "2018-12-19T18:28:50.3874119+01:00",
    "SunStop": "2002-01-25T18:28:50.3874119+01:00",
    "NonDates": [
      "numquam",
      "tempore"
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
        "FieldLength": 428
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 218,
    "Name": "Hilll-Schroeder",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": false,
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
        "FieldLength": 853
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "enim",
    "PersonId": 783,
    "Mrmrs": "aut",
    "Firstname": "Carolyne",
    "Lastname": "Flatley",
    "MiddleName": "Ritchie-Fadel",
    "Title": "tempore",
    "Description": "Operative secondary interface",
    "Email": "luella@herzogyost.com",
    "FullName": "Kevon Konopelski",
    "DirectPhone": "1-786-566-2682 x35632",
    "FormalName": "Okuneva, Streich and Conroy",
    "CountryId": 6,
    "ContactId": 675,
    "ContactName": "Considine, Kutch and Crona",
    "Retired": 473,
    "Rank": 736,
    "ActiveInterests": 76,
    "ContactDepartment": "",
    "ContactCountryId": 121,
    "ContactOrgNr": "1472638",
    "FaxPhone": "1-502-588-4485",
    "MobilePhone": "(158)201-4734 x286",
    "ContactPhone": "328.176.4620",
    "AssociateName": "Anderson Inc and Sons",
    "AssociateId": 695,
    "UsePersonAddress": false,
    "ContactFax": "corrupti",
    "Kanafname": "aliquam",
    "Kanalname": "vel",
    "Post1": "occaecati",
    "Post2": "reiciendis",
    "Post3": "in",
    "EmailName": "dorcas_hodkiewicz@kub.ca",
    "ContactFullName": "Jessie Gutkowski",
    "ActiveErpLinks": 90,
    "TicketPriorityId": 868,
    "SupportLanguageId": 942,
    "SupportAssociateId": 424,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 85
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "pariatur",
      "PersonId": 921,
      "Mrmrs": "reiciendis",
      "Firstname": "Johnathan",
      "Lastname": "Price",
      "MiddleName": "Schamberger Group",
      "Title": "similique",
      "Description": "Enterprise-wide cohesive complexity",
      "Email": "hillary.price@ledner.com",
      "FullName": "Camden Denesik MD",
      "DirectPhone": "682.538.5604",
      "FormalName": "Stroman, Homenick and Hintz",
      "CountryId": 619,
      "ContactId": 659,
      "ContactName": "Waters, Bergnaum and Torphy",
      "Retired": 670,
      "Rank": 360,
      "ActiveInterests": 994,
      "ContactDepartment": "",
      "ContactCountryId": 176,
      "ContactOrgNr": "1342623",
      "FaxPhone": "665-772-3751",
      "MobilePhone": "1-344-485-7711",
      "ContactPhone": "1-211-663-8445 x340",
      "AssociateName": "Streich Inc and Sons",
      "AssociateId": 997,
      "UsePersonAddress": true,
      "ContactFax": "repellendus",
      "Kanafname": "illum",
      "Kanalname": "quisquam",
      "Post1": "adipisci",
      "Post2": "inventore",
      "Post3": "nisi",
      "EmailName": "gwendolyn.dickens@jastpacocha.co.uk",
      "ContactFullName": "Alvena Strosin",
      "ActiveErpLinks": 103,
      "TicketPriorityId": 645,
      "SupportLanguageId": 505,
      "SupportAssociateId": 7,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 71
        }
      }
    }
  ],
  "AlertLevel": 535,
  "ConnectId": 837,
  "ReadStatus": "Green",
  "TimeToReply": 176,
  "RealTimeToReply": 397,
  "TimeToClose": 437,
  "RealTimeToClose": 436,
  "TimeSpentInternally": 432,
  "TimeSpentExternally": 400,
  "TimeSpentQueue": 411,
  "RealTimeSpentInternally": 524,
  "RealTimeSpentExternally": 529,
  "RealTimeSpentQueue": 907,
  "HasAttachment": true,
  "NumReplies": 131,
  "NumMessages": 694,
  "FromAddress": "quam",
  "Messages": [
    {
      "TicketMessageId": 848,
      "CreatedAt": "1999-01-24T18:28:50.3904117+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "voluptatum",
      "PersonId": 933,
      "PersonFullName": "Virgie Daniel",
      "ContactId": 286,
      "ContactName": "Fisher, Rosenbaum and Moore",
      "ContactDepartment": "",
      "NumAttachments": 653,
      "EmailHeader": "chaz.murray@beahan.biz",
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
          "FieldLength": 798
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 515,
      "Name": "Blick, Pagac and McKenzie",
      "ToolTip": "Et dolores sapiente nostrum.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 263
        }
      }
    },
    {
      "Id": 515,
      "Name": "Blick, Pagac and McKenzie",
      "ToolTip": "Et dolores sapiente nostrum.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 263
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "nobis",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "sint",
    "CustomFields2": "dolorum"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "extend web-enabled infrastructures"
      },
      "FieldType": "System.Int32",
      "FieldLength": 409
    }
  }
}
```