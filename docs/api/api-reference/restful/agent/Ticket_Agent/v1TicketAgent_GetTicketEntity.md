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
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=44
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
POST /api/v1/Agents/Ticket/GetTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 407,
  "Title": "nihil",
  "CreatedAt": "2014-12-05T16:48:30.8119354+01:00",
  "LastChanged": "2009-02-05T16:48:30.8119354+01:00",
  "ReadByOwner": "2017-06-26T16:48:30.8119354+02:00",
  "ReadByCustomer": "2015-08-24T16:48:30.8119354+02:00",
  "FirstReadByUser": "2017-04-22T16:48:30.8119354+02:00",
  "Activate": "2014-07-10T16:48:30.8119354+02:00",
  "ClosedAt": "1996-04-18T16:48:30.8119354+02:00",
  "RepliedAt": "2020-02-12T16:48:30.8119354+01:00",
  "AlertTimeout": "2017-08-05T16:48:30.8119354+02:00",
  "Deadline": "2003-11-24T16:48:30.8119354+01:00",
  "CreatedBy": {
    "AssociateId": 973,
    "Name": "O'Kon, Heathcote and Ankunding",
    "PersonId": 361,
    "Rank": 518,
    "Tooltip": "quae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 573,
    "FullName": "Cletus Legros",
    "FormalName": "VonRueden, Kessler and McLaughlin",
    "Deleted": false,
    "EjUserId": 593,
    "UserName": "Watsica, Kerluke and Jewess",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 233
      }
    }
  },
  "Author": "non",
  "OwnedBy": {
    "AssociateId": 654,
    "Name": "Hyatt-Price",
    "PersonId": 105,
    "Rank": 965,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 383,
    "FullName": "Ursula Herzog II",
    "FormalName": "Kirlin, Franecki and Moen",
    "Deleted": false,
    "EjUserId": 227,
    "UserName": "Hamill, Fahey and Lind",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 243
      }
    }
  },
  "Category": {
    "TicketCategoryId": 359,
    "ParentId": 973,
    "Name": "Graham, Ankunding and Larkin",
    "Fullname": "velit",
    "CategoryMaster": 381,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Hermiston, Heller and Yundt",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 819,
    "ReplyTemplate": 575,
    "NotificationEmail": "kelvin@schinnerspinka.biz",
    "ExtraFields": {
      "ExtraFields1": "est",
      "ExtraFields2": "qui"
    },
    "CustomFields": {
      "CustomFields1": "fugiat",
      "CustomFields2": "quisquam"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 473
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 937,
    "Name": "Homenick, O'Hara and Bins",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 814,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 466,
    "MonStart": "2017-12-07T16:48:30.8129378+01:00",
    "MonStop": "2002-08-27T16:48:30.8129378+02:00",
    "TueStart": "1998-09-19T16:48:30.8129378+02:00",
    "TueStop": "2016-05-30T16:48:30.8129378+02:00",
    "WedStart": "2019-05-29T16:48:30.8129378+02:00",
    "WedStop": "2005-05-08T16:48:30.8129378+02:00",
    "ThuStart": "2011-12-01T16:48:30.8129378+01:00",
    "ThuStop": "1999-07-23T16:48:30.8129378+02:00",
    "FriStart": "2004-10-13T16:48:30.8129378+02:00",
    "FriStop": "2019-09-05T16:48:30.8129378+02:00",
    "SatStart": "2006-12-13T16:48:30.8129378+01:00",
    "SatStop": "2003-02-18T16:48:30.8129378+01:00",
    "SunStart": "2011-05-07T16:48:30.8129378+02:00",
    "SunStop": "1994-01-26T16:48:30.8129378+01:00",
    "NonDates": [
      "et",
      "sapiente"
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 739
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 463,
    "Name": "Olson Group",
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
        "FieldLength": 602
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "repudiandae",
    "PersonId": 456,
    "Mrmrs": "suscipit",
    "Firstname": "Laurianne",
    "Lastname": "Bechtelar",
    "MiddleName": "Mertz, Lowe and Bosco",
    "Title": "qui",
    "Description": "Streamlined stable utilisation",
    "Email": "marcos.reynolds@runolfssonherzog.com",
    "FullName": "Marques Lemke",
    "DirectPhone": "1-567-763-3684 x126",
    "FormalName": "Haley, Vandervort and Wilderman",
    "CountryId": 844,
    "ContactId": 75,
    "ContactName": "Kerluke, Bartell and Langosh",
    "Retired": 39,
    "Rank": 622,
    "ActiveInterests": 868,
    "ContactDepartment": "",
    "ContactCountryId": 875,
    "ContactOrgNr": "873037",
    "FaxPhone": "504-176-1033",
    "MobilePhone": "1-024-703-4415",
    "ContactPhone": "505-162-8141 x5442",
    "AssociateName": "Russel LLC",
    "AssociateId": 172,
    "UsePersonAddress": false,
    "ContactFax": "facilis",
    "Kanafname": "nemo",
    "Kanalname": "incidunt",
    "Post1": "quod",
    "Post2": "autem",
    "Post3": "aut",
    "EmailName": "icie@kunde.ca",
    "ContactFullName": "Viola Windler",
    "ActiveErpLinks": 167,
    "TicketPriorityId": 260,
    "SupportLanguageId": 914,
    "SupportAssociateId": 982,
    "CategoryName": "VIP Customer",
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
  "SecondaryPersons": [
    {
      "Position": "expedita",
      "PersonId": 24,
      "Mrmrs": "dignissimos",
      "Firstname": "Orland",
      "Lastname": "Wisozk",
      "MiddleName": "Ryan LLC",
      "Title": "voluptatem",
      "Description": "Open-architected assymetric function",
      "Email": "amelie@buckridgekoch.biz",
      "FullName": "Candelario Rippin",
      "DirectPhone": "653-524-4408",
      "FormalName": "Jacobi Group",
      "CountryId": 699,
      "ContactId": 662,
      "ContactName": "Kovacek Group",
      "Retired": 18,
      "Rank": 730,
      "ActiveInterests": 701,
      "ContactDepartment": "",
      "ContactCountryId": 87,
      "ContactOrgNr": "1689797",
      "FaxPhone": "1-055-814-2061 x53414",
      "MobilePhone": "312.626.4320 x1042",
      "ContactPhone": "1-473-388-1651 x604",
      "AssociateName": "Blanda-Farrell",
      "AssociateId": 900,
      "UsePersonAddress": true,
      "ContactFax": "doloremque",
      "Kanafname": "harum",
      "Kanalname": "optio",
      "Post1": "nesciunt",
      "Post2": "libero",
      "Post3": "consequatur",
      "EmailName": "kennith@murazikblick.ca",
      "ContactFullName": "Miss Kellie Swift",
      "ActiveErpLinks": 254,
      "TicketPriorityId": 483,
      "SupportLanguageId": 618,
      "SupportAssociateId": 587,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 918
        }
      }
    }
  ],
  "AlertLevel": 181,
  "ConnectId": 787,
  "ReadStatus": "Green",
  "TimeToReply": 740,
  "RealTimeToReply": 594,
  "TimeToClose": 293,
  "RealTimeToClose": 623,
  "TimeSpentInternally": 877,
  "TimeSpentExternally": 704,
  "TimeSpentQueue": 699,
  "RealTimeSpentInternally": 150,
  "RealTimeSpentExternally": 739,
  "RealTimeSpentQueue": 739,
  "HasAttachment": false,
  "NumReplies": 496,
  "NumMessages": 264,
  "FromAddress": "sit",
  "Messages": [
    {
      "TicketMessageId": 681,
      "CreatedAt": "1997-05-04T16:48:30.8149351+02:00",
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
          "FieldLength": 40
        }
      }
    },
    {
      "TicketMessageId": 681,
      "CreatedAt": "1997-05-04T16:48:30.8149351+02:00",
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
          "FieldLength": 40
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 780,
      "Name": "Armstrong-Lebsack",
      "ToolTip": "In sed aliquam.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 538
        }
      }
    },
    {
      "Id": 780,
      "Name": "Armstrong-Lebsack",
      "ToolTip": "In sed aliquam.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 538
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "illo",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "ex",
    "CustomFields2": "dolorem"
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
      "FieldLength": 304
    }
  }
}
```