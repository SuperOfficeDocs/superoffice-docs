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
GET /api/v1/Ticket/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 86,
  "Title": "ea",
  "CreatedAt": "2018-08-08T09:40:59.7720648+02:00",
  "LastChanged": "2011-11-07T09:40:59.7720648+01:00",
  "ReadByOwner": "2009-10-03T09:40:59.7720648+02:00",
  "ReadByCustomer": "2011-10-15T09:40:59.7720648+02:00",
  "FirstReadByUser": "1994-01-21T09:40:59.7720648+01:00",
  "Activate": "1998-09-19T09:40:59.7720648+02:00",
  "ClosedAt": "2013-03-09T09:40:59.7720648+01:00",
  "RepliedAt": "2004-07-20T09:40:59.7720648+02:00",
  "AlertTimeout": "2020-04-13T09:40:59.7720648+02:00",
  "Deadline": "1999-01-10T09:40:59.7720648+01:00",
  "CreatedBy": {
    "AssociateId": 880,
    "Name": "VonRueden, Walter and O'Connell",
    "PersonId": 798,
    "Rank": 543,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 714,
    "FullName": "Nia Doyle PhD",
    "FormalName": "Kuphal, Pacocha and Berge",
    "Deleted": true,
    "EjUserId": 9,
    "UserName": "McGlynn Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 417
      }
    }
  },
  "Author": "error",
  "OwnedBy": {
    "AssociateId": 95,
    "Name": "Roob Group",
    "PersonId": 149,
    "Rank": 322,
    "Tooltip": "occaecati",
    "Type": "AnonymousAssociate",
    "GroupIdx": 775,
    "FullName": "Freda Cummings",
    "FormalName": "Oberbrunner Group",
    "Deleted": false,
    "EjUserId": 217,
    "UserName": "Bogan-Hammes",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 805
      }
    }
  },
  "Category": {
    "TicketCategoryId": 748,
    "ParentId": 103,
    "Name": "Stokes Inc and Sons",
    "Fullname": "consequuntur",
    "CategoryMaster": 395,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Kilback-Schmidt",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 181,
    "ReplyTemplate": 983,
    "NotificationEmail": "edythe@nitzsche.com",
    "ExtraFields": {
      "ExtraFields1": "repellendus",
      "ExtraFields2": "hic"
    },
    "CustomFields": {
      "CustomFields1": "labore",
      "CustomFields2": "omnis"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "synergize one-to-one e-markets"
        },
        "FieldType": "System.String",
        "FieldLength": 250
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 231,
    "Name": "Schulist, Jerde and Gerlach",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 162,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 163,
    "MonStart": "1999-11-01T09:40:59.7730648+01:00",
    "MonStop": "1998-06-20T09:40:59.7730648+02:00",
    "TueStart": "1993-12-20T09:40:59.7730648+01:00",
    "TueStop": "2002-07-13T09:40:59.7730648+02:00",
    "WedStart": "2007-10-04T09:40:59.7730648+02:00",
    "WedStop": "1998-01-04T09:40:59.7740653+01:00",
    "ThuStart": "2016-05-15T09:40:59.7740653+02:00",
    "ThuStop": "1998-08-11T09:40:59.7740653+02:00",
    "FriStart": "2018-02-11T09:40:59.7740653+01:00",
    "FriStop": "2009-06-17T09:40:59.7740653+02:00",
    "SatStart": "2004-07-14T09:40:59.7740653+02:00",
    "SatStop": "2003-06-04T09:40:59.7740653+02:00",
    "SunStart": "2003-06-01T09:40:59.7740653+02:00",
    "SunStop": "2003-04-29T09:40:59.7740653+02:00",
    "NonDates": [
      "officia",
      "ut"
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 154
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 880,
    "Name": "Zemlak, Purdy and Bauch",
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
        "FieldType": "System.String",
        "FieldLength": 622
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "reiciendis",
    "PersonId": 758,
    "Mrmrs": "ab",
    "Firstname": "Burley",
    "Lastname": "Price",
    "MiddleName": "O'Conner, Schimmel and Connelly",
    "Title": "similique",
    "Description": "Fully-configurable 24/7 local area network",
    "Email": "nedra@murphywolf.co.uk",
    "FullName": "Jessy Conroy",
    "DirectPhone": "1-113-005-0883",
    "FormalName": "Aufderhar LLC",
    "CountryId": 527,
    "ContactId": 455,
    "ContactName": "Farrell, Wehner and Stehr",
    "Retired": 202,
    "Rank": 474,
    "ActiveInterests": 343,
    "ContactDepartment": "",
    "ContactCountryId": 433,
    "ContactOrgNr": "1306896",
    "FaxPhone": "(834)020-8845 x564",
    "MobilePhone": "(526)302-8107 x058",
    "ContactPhone": "(728)521-0442 x7844",
    "AssociateName": "Hahn, Orn and Feest",
    "AssociateId": 378,
    "UsePersonAddress": false,
    "ContactFax": "perferendis",
    "Kanafname": "consequatur",
    "Kanalname": "quas",
    "Post1": "vel",
    "Post2": "deserunt",
    "Post3": "laborum",
    "EmailName": "demetrius@crist.name",
    "ContactFullName": "Elsa Kautzer",
    "ActiveErpLinks": 74,
    "TicketPriorityId": 822,
    "SupportLanguageId": 357,
    "SupportAssociateId": 542,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 210
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "modi",
      "PersonId": 779,
      "Mrmrs": "numquam",
      "Firstname": "Rachael",
      "Lastname": "Schroeder",
      "MiddleName": "Zboncak Inc and Sons",
      "Title": "quidem",
      "Description": "Enhanced contextually-based synergy",
      "Email": "dorris@glover.info",
      "FullName": "Ransom Bergstrom",
      "DirectPhone": "(717)436-0543",
      "FormalName": "Hayes Group",
      "CountryId": 447,
      "ContactId": 348,
      "ContactName": "Marks Group",
      "Retired": 649,
      "Rank": 674,
      "ActiveInterests": 201,
      "ContactDepartment": "",
      "ContactCountryId": 904,
      "ContactOrgNr": "314811",
      "FaxPhone": "403-048-1805",
      "MobilePhone": "(460)456-4088",
      "ContactPhone": "071-713-0827 x11101",
      "AssociateName": "Stanton-Glover",
      "AssociateId": 141,
      "UsePersonAddress": true,
      "ContactFax": "qui",
      "Kanafname": "quae",
      "Kanalname": "officia",
      "Post1": "in",
      "Post2": "ex",
      "Post3": "sit",
      "EmailName": "marshall@morissette.info",
      "ContactFullName": "Raoul Bins",
      "ActiveErpLinks": 330,
      "TicketPriorityId": 465,
      "SupportLanguageId": 330,
      "SupportAssociateId": 473,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 240
        }
      }
    }
  ],
  "AlertLevel": 700,
  "ConnectId": 802,
  "ReadStatus": "Green",
  "TimeToReply": 909,
  "RealTimeToReply": 403,
  "TimeToClose": 316,
  "RealTimeToClose": 15,
  "TimeSpentInternally": 138,
  "TimeSpentExternally": 649,
  "TimeSpentQueue": 578,
  "RealTimeSpentInternally": 249,
  "RealTimeSpentExternally": 525,
  "RealTimeSpentQueue": 830,
  "HasAttachment": false,
  "NumReplies": 828,
  "NumMessages": 867,
  "FromAddress": "sint",
  "Messages": [
    {
      "TicketMessageId": 89,
      "CreatedAt": "2005-01-09T09:40:59.7770652+01:00",
      "Slevel": "External",
      "Important": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 353
        }
      }
    },
    {
      "TicketMessageId": 89,
      "CreatedAt": "2005-01-09T09:40:59.7770652+01:00",
      "Slevel": "External",
      "Important": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 353
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 400,
      "Name": "Rau Group",
      "ToolTip": "Cumque neque aut expedita dolor ut.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 605
        }
      }
    },
    {
      "Id": 400,
      "Name": "Rau Group",
      "ToolTip": "Cumque neque aut expedita dolor ut.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 605
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "aperiam",
    "ExtraFields2": "natus"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "quidem"
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
      "FieldLength": 617
    }
  }
}
```