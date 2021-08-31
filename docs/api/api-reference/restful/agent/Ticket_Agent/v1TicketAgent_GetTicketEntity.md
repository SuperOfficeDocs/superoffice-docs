---
title: GetTicketEntity
id: v1TicketAgent_GetTicketEntity
---

# GetTicketEntity

```http
POST /api/v1/Agents/Ticket/GetTicketEntity
```

Gets a TicketEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ticketEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=267
POST /api/v1/Agents/Ticket/GetTicketEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Ticket/GetTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 415,
  "Title": "est",
  "CreatedAt": "2020-08-05T14:58:05.3765969+02:00",
  "LastChanged": "2012-03-24T14:58:05.3765969+01:00",
  "ReadByOwner": "2017-10-23T14:58:05.3765969+02:00",
  "ReadByCustomer": "2011-11-16T14:58:05.3765969+01:00",
  "FirstReadByUser": "2011-04-18T14:58:05.3765969+02:00",
  "Activate": "2020-04-11T14:58:05.3765969+02:00",
  "ClosedAt": "2006-06-26T14:58:05.3765969+02:00",
  "RepliedAt": "2020-12-18T14:58:05.3765969+01:00",
  "AlertTimeout": "2004-01-25T14:58:05.3765969+01:00",
  "Deadline": "2017-07-19T14:58:05.3765969+02:00",
  "CreatedBy": {
    "AssociateId": 411,
    "Name": "Kuhn-Kub",
    "PersonId": 43,
    "Rank": 207,
    "Tooltip": "natus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 527,
    "FullName": "Cassie Jewess",
    "FormalName": "Abernathy-Greenfelder",
    "Deleted": false,
    "EjUserId": 909,
    "UserName": "Schaefer-Macejkovic",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "benchmark interactive e-business"
        },
        "FieldType": "System.String",
        "FieldLength": 184
      }
    }
  },
  "Author": "quia",
  "OwnedBy": {
    "AssociateId": 44,
    "Name": "Hodkiewicz Inc and Sons",
    "PersonId": 555,
    "Rank": 332,
    "Tooltip": "commodi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 523,
    "FullName": "Chyna Rutherford",
    "FormalName": "VonRueden, Swaniawski and Ward",
    "Deleted": false,
    "EjUserId": 356,
    "UserName": "Cummings LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 432
      }
    }
  },
  "Category": {
    "TicketCategoryId": 478,
    "ParentId": 863,
    "Name": "Corwin LLC",
    "Fullname": "vero",
    "CategoryMaster": 319,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Ferry, Abernathy and Pacocha",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 781,
    "ReplyTemplate": 16,
    "NotificationEmail": "garth@douglas.ca",
    "ExtraFields": {
      "ExtraFields1": "ad",
      "ExtraFields2": "et"
    },
    "CustomFields": {
      "CustomFields1": "qui",
      "CustomFields2": "cupiditate"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "exploit proactive action-items"
        },
        "FieldType": "System.String",
        "FieldLength": 177
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 332,
    "Name": "Kertzmann-Hagenes",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 581,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 212,
    "MonStart": "2015-07-15T14:58:05.3785956+02:00",
    "MonStop": "2014-02-20T14:58:05.3785956+01:00",
    "TueStart": "2017-07-21T14:58:05.3785956+02:00",
    "TueStop": "2010-11-10T14:58:05.3785956+01:00",
    "WedStart": "2016-06-15T14:58:05.3785956+02:00",
    "WedStop": "2019-09-22T14:58:05.3785956+02:00",
    "ThuStart": "1995-10-10T14:58:05.3785956+02:00",
    "ThuStop": "2015-03-02T14:58:05.3785956+01:00",
    "FriStart": "2017-03-23T14:58:05.3785956+01:00",
    "FriStop": "2019-04-02T14:58:05.3785956+02:00",
    "SatStart": "1997-01-17T14:58:05.3785956+01:00",
    "SatStop": "2014-06-12T14:58:05.3785956+02:00",
    "SunStart": "2003-10-30T14:58:05.3785956+01:00",
    "SunStop": "1997-07-20T14:58:05.3785956+02:00",
    "NonDates": [
      "suscipit",
      "et"
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 753
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 402,
    "Name": "Glover-Powlowski",
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
        "FieldLength": 379
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "eveniet",
    "PersonId": 968,
    "Mrmrs": "aut",
    "Firstname": "Susana",
    "Lastname": "Botsford",
    "MiddleName": "Heller LLC",
    "Title": "eaque",
    "Description": "Quality-focused systemic framework",
    "Email": "anissa@homenickcummerata.uk",
    "FullName": "Nels Strosin",
    "DirectPhone": "1-372-555-3282 x31063",
    "FormalName": "Klocko, Jast and Yundt",
    "CountryId": 703,
    "ContactId": 236,
    "ContactName": "Graham, Lind and Anderson",
    "Retired": 466,
    "Rank": 598,
    "ActiveInterests": 447,
    "ContactDepartment": "",
    "ContactCountryId": 428,
    "ContactOrgNr": "213197",
    "FaxPhone": "(760)657-6366",
    "MobilePhone": "820-881-0061 x6347",
    "ContactPhone": "008-041-2010 x2175",
    "AssociateName": "Haley LLC",
    "AssociateId": 281,
    "UsePersonAddress": false,
    "ContactFax": "impedit",
    "Kanafname": "eligendi",
    "Kanalname": "repellat",
    "Post1": "sapiente",
    "Post2": "molestiae",
    "Post3": "aliquid",
    "EmailName": "wilma_predovic@hyatt.uk",
    "ContactFullName": "Coralie Tromp",
    "ActiveErpLinks": 898,
    "TicketPriorityId": 682,
    "SupportLanguageId": 30,
    "SupportAssociateId": 192,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 213
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "pariatur",
      "PersonId": 181,
      "Mrmrs": "cum",
      "Firstname": "Garrett",
      "Lastname": "Leannon",
      "MiddleName": "Conroy Inc and Sons",
      "Title": "ipsum",
      "Description": "Versatile multi-state orchestration",
      "Email": "rigoberto@mann.co.uk",
      "FullName": "Verona Kutch IV",
      "DirectPhone": "782.470.8267 x0027",
      "FormalName": "Aufderhar-Feeney",
      "CountryId": 746,
      "ContactId": 39,
      "ContactName": "Fisher, Wolf and Shanahan",
      "Retired": 359,
      "Rank": 566,
      "ActiveInterests": 953,
      "ContactDepartment": "",
      "ContactCountryId": 443,
      "ContactOrgNr": "1610903",
      "FaxPhone": "315-608-6008",
      "MobilePhone": "836-820-1081 x455",
      "ContactPhone": "178-814-2155 x76140",
      "AssociateName": "Quitzon-Weimann",
      "AssociateId": 947,
      "UsePersonAddress": false,
      "ContactFax": "molestiae",
      "Kanafname": "distinctio",
      "Kanalname": "saepe",
      "Post1": "aut",
      "Post2": "consequatur",
      "Post3": "culpa",
      "EmailName": "tianna@becker.name",
      "ContactFullName": "Brendan Spinka",
      "ActiveErpLinks": 818,
      "TicketPriorityId": 155,
      "SupportLanguageId": 47,
      "SupportAssociateId": 543,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 490
        }
      }
    }
  ],
  "AlertLevel": 506,
  "ConnectId": 527,
  "ReadStatus": "Green",
  "TimeToReply": 721,
  "RealTimeToReply": 794,
  "TimeToClose": 718,
  "RealTimeToClose": 285,
  "TimeSpentInternally": 253,
  "TimeSpentExternally": 231,
  "TimeSpentQueue": 241,
  "RealTimeSpentInternally": 221,
  "RealTimeSpentExternally": 389,
  "RealTimeSpentQueue": 472,
  "HasAttachment": false,
  "NumReplies": 657,
  "NumMessages": 281,
  "FromAddress": "numquam",
  "Messages": [
    {
      "TicketMessageId": 607,
      "CreatedAt": "2020-05-09T14:58:05.381623+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "corrupti",
      "PersonId": 708,
      "PersonFullName": "Leora Kautzer V",
      "ContactId": 146,
      "ContactName": "Renner, Torphy and Crona",
      "ContactDepartment": "",
      "NumAttachments": 443,
      "EmailHeader": "elise.farrell@marquardt.com",
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
          "FieldLength": 499
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 767,
      "Name": "Pfeffer, Wiza and White",
      "ToolTip": "Repudiandae unde voluptatem perferendis et aut.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 248
        }
      }
    },
    {
      "Id": 767,
      "Name": "Pfeffer, Wiza and White",
      "ToolTip": "Repudiandae unde voluptatem perferendis et aut.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 248
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "quasi"
  },
  "CustomFields": {
    "CustomFields1": "laboriosam",
    "CustomFields2": "vitae"
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
      "FieldLength": 249
    }
  }
}
```