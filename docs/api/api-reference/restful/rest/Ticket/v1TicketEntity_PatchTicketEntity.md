---
title: PATCH Ticket/{id}
id: v1TicketEntity_PatchTicketEntity
---

# PATCH Ticket/{id}

```http
PATCH /api/v1/Ticket/{id}
```

Update a TicketEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.ITicketAgent} service SaveTicketEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The TicketEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Ticket/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes string 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | string | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | string | The property names to modify.  "/users/0/email", "/users/-", |
| value | object | New/Replaced value - string or object. |


## Response: object

The ticket entity is used for representing a service ticket



TicketEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | TicketEntity  updated. |
| 404 | TicketEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because TicketEntity has changed since the requested If-Unmodified-Since timestamp. |

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
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "consequuntur",
    "value": {
      "value1": {
        "PrimaryKey": 643,
        "EntityName": "person",
        "personId": 643,
        "fullName": "Aric Reinger"
      },
      "value2": {
        "PrimaryKey": 4139,
        "EntityName": "person",
        "personId": 4139,
        "fullName": "Dandre Howe"
      }
    }
  },
  {
    "op": "add",
    "path": "consequuntur",
    "value": {
      "value1": {
        "PrimaryKey": 643,
        "EntityName": "person",
        "personId": 643,
        "fullName": "Aric Reinger"
      },
      "value2": {
        "PrimaryKey": 4139,
        "EntityName": "person",
        "personId": 4139,
        "fullName": "Dandre Howe"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 TicketEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 877,
  "Title": "velit",
  "CreatedAt": "2013-08-21T15:05:42.8636621+02:00",
  "LastChanged": "2017-11-24T15:05:42.8636621+01:00",
  "ReadByOwner": "2004-09-08T15:05:42.8636621+02:00",
  "ReadByCustomer": "2013-05-03T15:05:42.8636621+02:00",
  "FirstReadByUser": "2003-04-27T15:05:42.8636621+02:00",
  "Activate": "2001-08-30T15:05:42.8636621+02:00",
  "ClosedAt": "2015-10-27T15:05:42.8636621+01:00",
  "RepliedAt": "2020-04-21T15:05:42.8636621+02:00",
  "AlertTimeout": "2013-04-25T15:05:42.8636621+02:00",
  "Deadline": "2006-12-19T15:05:42.8636621+01:00",
  "CreatedBy": {
    "AssociateId": 201,
    "Name": "Quigley Group",
    "PersonId": 65,
    "Rank": 802,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 158,
    "FullName": "Miss Ivory Greenfelder",
    "FormalName": "Sanford-Sanford",
    "Deleted": false,
    "EjUserId": 897,
    "UserName": "Padberg, Schoen and Fisher",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "iterate customized web-readiness"
        },
        "FieldType": "System.Int32",
        "FieldLength": 690
      }
    }
  },
  "Author": "laborum",
  "OwnedBy": {
    "AssociateId": 381,
    "Name": "Hodkiewicz Group",
    "PersonId": 191,
    "Rank": 807,
    "Tooltip": "velit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 882,
    "FullName": "Clara Daniel",
    "FormalName": "Pfannerstill-Hansen",
    "Deleted": false,
    "EjUserId": 894,
    "UserName": "Frami, Cremin and Murphy",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 634
      }
    }
  },
  "Category": {
    "TicketCategoryId": 787,
    "ParentId": 163,
    "Name": "Bode, Deckow and Hudson",
    "Fullname": "voluptate",
    "CategoryMaster": 364,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "McGlynn-Wiza",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 103,
    "ReplyTemplate": 797,
    "NotificationEmail": "amelie@mitchell.co.uk",
    "ExtraFields": {
      "ExtraFields1": "id",
      "ExtraFields2": "praesentium"
    },
    "CustomFields": {
      "CustomFields1": "adipisci",
      "CustomFields2": "non"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 506
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 699,
    "Name": "Jacobi-Runolfsdottir",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 417,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 66,
    "MonStart": "2011-03-18T15:05:42.8646649+01:00",
    "MonStop": "2001-04-13T15:05:42.8646649+02:00",
    "TueStart": "2001-08-18T15:05:42.8646649+02:00",
    "TueStop": "2016-09-22T15:05:42.8646649+02:00",
    "WedStart": "1995-10-09T15:05:42.8646649+02:00",
    "WedStop": "2012-05-18T15:05:42.8646649+02:00",
    "ThuStart": "1994-12-21T15:05:42.8646649+01:00",
    "ThuStop": "2001-09-25T15:05:42.8646649+02:00",
    "FriStart": "2003-09-29T15:05:42.8646649+02:00",
    "FriStop": "2003-05-26T15:05:42.8646649+02:00",
    "SatStart": "1995-09-07T15:05:42.8646649+02:00",
    "SatStop": "2004-11-18T15:05:42.8646649+01:00",
    "SunStart": "2016-03-10T15:05:42.8646649+01:00",
    "SunStop": "1996-03-28T15:05:42.8646649+01:00",
    "NonDates": [
      "doloremque",
      "ratione"
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 608
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 137,
    "Name": "Walsh-Corwin",
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
        "FieldLength": 132
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "dolorem",
    "PersonId": 841,
    "Mrmrs": "dolorem",
    "Firstname": "Josefa",
    "Lastname": "Wisozk",
    "MiddleName": "Reynolds, Schumm and Mayer",
    "Title": "corrupti",
    "Description": "Optimized didactic adapter",
    "Email": "marshall_wisoky@botsford.co.uk",
    "FullName": "Brody Mayert PhD",
    "DirectPhone": "1-130-241-1670",
    "FormalName": "Steuber Group",
    "CountryId": 320,
    "ContactId": 840,
    "ContactName": "Ondricka, Grant and Swift",
    "Retired": 732,
    "Rank": 732,
    "ActiveInterests": 106,
    "ContactDepartment": "",
    "ContactCountryId": 166,
    "ContactOrgNr": "918458",
    "FaxPhone": "038-337-3510",
    "MobilePhone": "008.777.7812",
    "ContactPhone": "1-147-615-0084 x48037",
    "AssociateName": "Ritchie, Abernathy and Kunze",
    "AssociateId": 661,
    "UsePersonAddress": false,
    "ContactFax": "quas",
    "Kanafname": "aut",
    "Kanalname": "officiis",
    "Post1": "voluptatum",
    "Post2": "voluptates",
    "Post3": "hic",
    "EmailName": "charlotte@lednerpfannerstill.biz",
    "ContactFullName": "Lenna Botsford",
    "ActiveErpLinks": 117,
    "TicketPriorityId": 664,
    "SupportLanguageId": 561,
    "SupportAssociateId": 92,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 112
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "sint",
      "PersonId": 679,
      "Mrmrs": "enim",
      "Firstname": "Gabriella",
      "Lastname": "Bahringer",
      "MiddleName": "Tremblay-Heller",
      "Title": "qui",
      "Description": "Polarised logistical matrices",
      "Email": "alek_fadel@dickensbechtelar.us",
      "FullName": "America Lynch",
      "DirectPhone": "(766)831-3282 x2773",
      "FormalName": "Schamberger, Hartmann and Cartwright",
      "CountryId": 788,
      "ContactId": 482,
      "ContactName": "Bernier-Balistreri",
      "Retired": 64,
      "Rank": 984,
      "ActiveInterests": 234,
      "ContactDepartment": "",
      "ContactCountryId": 924,
      "ContactOrgNr": "643896",
      "FaxPhone": "566-171-3252",
      "MobilePhone": "526.038.2284",
      "ContactPhone": "(016)658-1431",
      "AssociateName": "Fadel-Runolfsdottir",
      "AssociateId": 162,
      "UsePersonAddress": true,
      "ContactFax": "aut",
      "Kanafname": "molestiae",
      "Kanalname": "neque",
      "Post1": "amet",
      "Post2": "qui",
      "Post3": "delectus",
      "EmailName": "matteo_schaden@kohlergusikowski.biz",
      "ContactFullName": "Haleigh Corwin",
      "ActiveErpLinks": 527,
      "TicketPriorityId": 448,
      "SupportLanguageId": 115,
      "SupportAssociateId": 75,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 73
        }
      }
    }
  ],
  "AlertLevel": 934,
  "ConnectId": 858,
  "ReadStatus": "Green",
  "TimeToReply": 705,
  "RealTimeToReply": 120,
  "TimeToClose": 651,
  "RealTimeToClose": 59,
  "TimeSpentInternally": 723,
  "TimeSpentExternally": 104,
  "TimeSpentQueue": 848,
  "RealTimeSpentInternally": 978,
  "RealTimeSpentExternally": 299,
  "RealTimeSpentQueue": 968,
  "HasAttachment": true,
  "NumReplies": 998,
  "NumMessages": 371,
  "FromAddress": "placeat",
  "Messages": [
    {
      "TicketMessageId": 396,
      "CreatedAt": "2000-03-27T15:05:42.8686347+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "fuga",
      "PersonId": 843,
      "PersonFullName": "Arvilla Kreiger",
      "ContactId": 712,
      "ContactName": "Kassulke Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 660,
      "EmailHeader": "bernadette@zboncakmarvin.com",
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
          "FieldLength": 790
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 535,
      "Name": "Deckow Inc and Sons",
      "ToolTip": "Maxime eius illo est.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 332
        }
      }
    },
    {
      "Id": 535,
      "Name": "Deckow Inc and Sons",
      "ToolTip": "Maxime eius illo est.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 332
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "error"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "quam"
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
      "FieldLength": 841
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```