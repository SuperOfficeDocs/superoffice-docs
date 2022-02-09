---
title: POST Agents/Ticket/GetTicketEntity
id: v1TicketAgent_GetTicketEntity
---

# POST Agents/Ticket/GetTicketEntity

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
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=902
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
  "TicketId": 174,
  "Title": "consequatur",
  "CreatedAt": "2011-03-04T18:28:50.3754121+01:00",
  "LastChanged": "2013-09-19T18:28:50.3754121+02:00",
  "ReadByOwner": "2016-08-12T18:28:50.3754121+02:00",
  "ReadByCustomer": "2019-01-09T18:28:50.3754121+01:00",
  "FirstReadByUser": "2021-08-04T18:28:50.3754121+02:00",
  "Activate": "2017-07-10T18:28:50.3754121+02:00",
  "ClosedAt": "2007-07-25T18:28:50.3754121+02:00",
  "RepliedAt": "2016-05-19T18:28:50.3754121+02:00",
  "AlertTimeout": "2017-03-27T18:28:50.3754121+02:00",
  "Deadline": "1998-01-01T18:28:50.3754121+01:00",
  "CreatedBy": {
    "AssociateId": 165,
    "Name": "Sauer Group",
    "PersonId": 103,
    "Rank": 501,
    "Tooltip": "veniam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 932,
    "FullName": "Alva Hickle",
    "FormalName": "Harris, Ryan and Willms",
    "Deleted": false,
    "EjUserId": 749,
    "UserName": "Morar-Hermann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 880
      }
    }
  },
  "Author": "in",
  "OwnedBy": {
    "AssociateId": 459,
    "Name": "Beatty-Schmidt",
    "PersonId": 466,
    "Rank": 418,
    "Tooltip": "vel",
    "Type": "AnonymousAssociate",
    "GroupIdx": 15,
    "FullName": "Andres Greenholt",
    "FormalName": "Abernathy, Kuhic and Larkin",
    "Deleted": true,
    "EjUserId": 934,
    "UserName": "Russel Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 548
      }
    }
  },
  "Category": {
    "TicketCategoryId": 260,
    "ParentId": 810,
    "Name": "Monahan Inc and Sons",
    "Fullname": "voluptate",
    "CategoryMaster": 930,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Kuhlman, Mayert and Wiegand",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 566,
    "ReplyTemplate": 948,
    "NotificationEmail": "martina.morissette@kulasohara.uk",
    "DefaultTicketStatus": {},
    "DefaultMessageStatus": {},
    "ExtraFields": {
      "ExtraFields1": "eum",
      "ExtraFields2": "eius"
    },
    "CustomFields": {
      "CustomFields1": "ratione",
      "CustomFields2": "sint"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 602
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 727,
    "Name": "Hickle-D'Amore",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 29,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 233,
    "MonStart": "2000-12-12T18:28:50.3774118+01:00",
    "MonStop": "2015-12-06T18:28:50.3774118+01:00",
    "TueStart": "2004-04-22T18:28:50.3774118+02:00",
    "TueStop": "2009-06-02T18:28:50.3774118+02:00",
    "WedStart": "1999-01-31T18:28:50.3774118+01:00",
    "WedStop": "1995-09-18T18:28:50.3774118+02:00",
    "ThuStart": "2004-05-31T18:28:50.3774118+02:00",
    "ThuStop": "2014-05-02T18:28:50.3774118+02:00",
    "FriStart": "2006-01-23T18:28:50.3774118+01:00",
    "FriStop": "2018-07-09T18:28:50.3774118+02:00",
    "SatStart": "2005-05-06T18:28:50.3774118+02:00",
    "SatStop": "2005-04-15T18:28:50.3774118+02:00",
    "SunStart": "2001-09-19T18:28:50.3774118+02:00",
    "SunStop": "2017-12-31T18:28:50.3774118+01:00",
    "NonDates": [
      "autem",
      "aperiam"
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
        "FieldLength": 39
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 445,
    "Name": "Towne LLC",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": true,
    "IsDefault": false,
    "UsedInQueue": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 701
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "et",
    "PersonId": 646,
    "Mrmrs": "ducimus",
    "Firstname": "Antonietta",
    "Lastname": "Flatley",
    "MiddleName": "Mohr-Stroman",
    "Title": "odit",
    "Description": "Distributed client-driven conglomeration",
    "Email": "elda.reinger@dooley.name",
    "FullName": "Aiden Hahn",
    "DirectPhone": "(506)758-2332",
    "FormalName": "Kunze-Wintheiser",
    "CountryId": 721,
    "ContactId": 877,
    "ContactName": "Bahringer-Robel",
    "Retired": 515,
    "Rank": 775,
    "ActiveInterests": 141,
    "ContactDepartment": "",
    "ContactCountryId": 841,
    "ContactOrgNr": "1264445",
    "FaxPhone": "(325)622-1764 x80218",
    "MobilePhone": "1-736-764-2785 x4412",
    "ContactPhone": "016-487-6023",
    "AssociateName": "Beahan LLC",
    "AssociateId": 602,
    "UsePersonAddress": false,
    "ContactFax": "consequatur",
    "Kanafname": "reprehenderit",
    "Kanalname": "qui",
    "Post1": "voluptas",
    "Post2": "voluptates",
    "Post3": "dolorem",
    "EmailName": "misty_mertz@keebler.info",
    "ContactFullName": "Litzy Wilderman",
    "ActiveErpLinks": 942,
    "TicketPriorityId": 172,
    "SupportLanguageId": 384,
    "SupportAssociateId": 401,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 960
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "rerum",
      "PersonId": 176,
      "Mrmrs": "soluta",
      "Firstname": "Myrtle",
      "Lastname": "Rohan",
      "MiddleName": "Bogisich, Herman and Monahan",
      "Title": "delectus",
      "Description": "Visionary tangible emulation",
      "Email": "nya@morissettebernier.biz",
      "FullName": "Percy Robel PhD",
      "DirectPhone": "204-343-0574 x688",
      "FormalName": "Leffler, Schmidt and Kulas",
      "CountryId": 11,
      "ContactId": 19,
      "ContactName": "Williamson, Graham and Boyle",
      "Retired": 944,
      "Rank": 660,
      "ActiveInterests": 108,
      "ContactDepartment": "",
      "ContactCountryId": 890,
      "ContactOrgNr": "1292275",
      "FaxPhone": "362.364.8118",
      "MobilePhone": "1-066-758-4857",
      "ContactPhone": "1-840-856-3411 x0121",
      "AssociateName": "Fritsch-Sipes",
      "AssociateId": 271,
      "UsePersonAddress": false,
      "ContactFax": "eum",
      "Kanafname": "et",
      "Kanalname": "commodi",
      "Post1": "consequatur",
      "Post2": "itaque",
      "Post3": "error",
      "EmailName": "lauren@stark.biz",
      "ContactFullName": "Chaz Reinger",
      "ActiveErpLinks": 642,
      "TicketPriorityId": 788,
      "SupportLanguageId": 178,
      "SupportAssociateId": 22,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 917
        }
      }
    }
  ],
  "AlertLevel": 685,
  "ConnectId": 711,
  "ReadStatus": "Green",
  "TimeToReply": 78,
  "RealTimeToReply": 893,
  "TimeToClose": 896,
  "RealTimeToClose": 870,
  "TimeSpentInternally": 875,
  "TimeSpentExternally": 791,
  "TimeSpentQueue": 607,
  "RealTimeSpentInternally": 442,
  "RealTimeSpentExternally": 951,
  "RealTimeSpentQueue": 843,
  "HasAttachment": false,
  "NumReplies": 800,
  "NumMessages": 604,
  "FromAddress": "in",
  "Messages": [
    {
      "TicketMessageId": 622,
      "CreatedAt": "2013-12-14T18:28:50.3794115+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "aliquid",
      "PersonId": 379,
      "PersonFullName": "Cindy Gleason III",
      "ContactId": 224,
      "ContactName": "Pouros, Bradtke and Murray",
      "ContactDepartment": "",
      "NumAttachments": 640,
      "EmailHeader": "bernard_sanford@walsh.uk",
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
          "FieldLength": 989
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 575,
      "Name": "Zemlak Group",
      "ToolTip": "Quasi eum id nostrum.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 604
        }
      }
    },
    {
      "Id": 575,
      "Name": "Zemlak Group",
      "ToolTip": "Quasi eum id nostrum.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 604
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "similique",
    "ExtraFields2": "maxime"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "nesciunt"
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
      "FieldLength": 920
    }
  }
}
```