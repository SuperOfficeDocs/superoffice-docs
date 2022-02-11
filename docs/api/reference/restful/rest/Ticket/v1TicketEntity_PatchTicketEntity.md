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
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "et",
    "value": {
      "value1": {
        "PrimaryKey": 6301,
        "EntityName": "person",
        "personId": 6301,
        "fullName": "Abel Morissette"
      },
      "value2": {
        "PrimaryKey": 9837,
        "EntityName": "person",
        "personId": 9837,
        "fullName": "Haley Gibson"
      }
    }
  },
  {
    "op": "add",
    "path": "et",
    "value": {
      "value1": {
        "PrimaryKey": 6301,
        "EntityName": "person",
        "personId": 6301,
        "fullName": "Abel Morissette"
      },
      "value2": {
        "PrimaryKey": 9837,
        "EntityName": "person",
        "personId": 9837,
        "fullName": "Haley Gibson"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 TicketEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 900,
  "Title": "suscipit",
  "CreatedAt": "2009-12-14T18:25:51.2209411+01:00",
  "LastChanged": "2012-09-07T18:25:51.2209411+02:00",
  "ReadByOwner": "2013-05-31T18:25:51.2209411+02:00",
  "ReadByCustomer": "2019-05-21T18:25:51.2209411+02:00",
  "FirstReadByUser": "2003-05-07T18:25:51.2209411+02:00",
  "Activate": "2000-12-24T18:25:51.2209411+01:00",
  "ClosedAt": "2012-09-27T18:25:51.2209411+02:00",
  "RepliedAt": "2010-04-09T18:25:51.2209411+02:00",
  "AlertTimeout": "2012-11-04T18:25:51.2209411+01:00",
  "Deadline": "2000-01-24T18:25:51.2209411+01:00",
  "CreatedBy": {
    "AssociateId": 884,
    "Name": "Schmitt LLC",
    "PersonId": 893,
    "Rank": 269,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 93,
    "FullName": "Marcos Beatty",
    "FormalName": "Veum-Jacobs",
    "Deleted": false,
    "EjUserId": 542,
    "UserName": "Brown LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 198
      }
    }
  },
  "Author": "est",
  "OwnedBy": {
    "AssociateId": 819,
    "Name": "Hagenes Inc and Sons",
    "PersonId": 445,
    "Rank": 768,
    "Tooltip": "ipsam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 486,
    "FullName": "Stan Turcotte",
    "FormalName": "Ryan Inc and Sons",
    "Deleted": false,
    "EjUserId": 66,
    "UserName": "Grant, Okuneva and Daugherty",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 267
      }
    }
  },
  "Category": {
    "TicketCategoryId": 222,
    "ParentId": 431,
    "Name": "Keebler Group",
    "Fullname": "ut",
    "CategoryMaster": 494,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Zboncak-Shields",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 336,
    "ReplyTemplate": 76,
    "NotificationEmail": "josefina_gerhold@medhurst.info",
    "DefaultTicketStatus": {},
    "DefaultMessageStatus": {},
    "ExtraFields": {
      "ExtraFields1": "quidem",
      "ExtraFields2": "rerum"
    },
    "CustomFields": {
      "CustomFields1": "deleniti",
      "CustomFields2": "dolor"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 409
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 259,
    "Name": "Jast, Davis and Leuschke",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 238,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 154,
    "MonStart": "2021-09-15T18:25:51.22194+02:00",
    "MonStop": "2011-10-29T18:25:51.22194+02:00",
    "TueStart": "1998-12-31T18:25:51.22194+01:00",
    "TueStop": "2013-08-14T18:25:51.22194+02:00",
    "WedStart": "2009-01-07T18:25:51.22194+01:00",
    "WedStop": "2019-02-09T18:25:51.22194+01:00",
    "ThuStart": "2001-12-12T18:25:51.22194+01:00",
    "ThuStop": "2012-10-10T18:25:51.22194+02:00",
    "FriStart": "2011-08-02T18:25:51.22194+02:00",
    "FriStop": "2009-11-19T18:25:51.22194+01:00",
    "SatStart": "2011-04-09T18:25:51.22194+02:00",
    "SatStop": "2019-06-07T18:25:51.22194+02:00",
    "SunStart": "2003-03-01T18:25:51.22194+01:00",
    "SunStop": "2004-02-16T18:25:51.22194+01:00",
    "NonDates": [
      "expedita",
      "libero"
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
        "FieldLength": 850
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 56,
    "Name": "Aufderhar-McClure",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": false,
    "IsDefault": false,
    "UsedInQueue": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "leverage e-business systems"
        },
        "FieldType": "System.String",
        "FieldLength": 939
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "mollitia",
    "PersonId": 34,
    "Mrmrs": "voluptatem",
    "Firstname": "Filiberto",
    "Lastname": "Gaylord",
    "MiddleName": "Kutch-Kulas",
    "Title": "iusto",
    "Description": "Adaptive 6th generation help-desk",
    "Email": "mauricio@wintheiser.com",
    "FullName": "Kylee Turner",
    "DirectPhone": "(844)101-6861 x78886",
    "FormalName": "Bernhard, Zboncak and Mante",
    "CountryId": 99,
    "ContactId": 489,
    "ContactName": "Ratke Inc and Sons",
    "Retired": 484,
    "Rank": 866,
    "ActiveInterests": 966,
    "ContactDepartment": "",
    "ContactCountryId": 943,
    "ContactOrgNr": "1118669",
    "FaxPhone": "723-602-4061 x223",
    "MobilePhone": "786.407.0737 x7461",
    "ContactPhone": "283-330-5407",
    "AssociateName": "Kuvalis, Larson and Howell",
    "AssociateId": 376,
    "UsePersonAddress": false,
    "ContactFax": "tempore",
    "Kanafname": "maiores",
    "Kanalname": "et",
    "Post1": "minima",
    "Post2": "molestiae",
    "Post3": "nulla",
    "EmailName": "sylvan_muller@smithamkoepp.com",
    "ContactFullName": "Vena Witting",
    "ActiveErpLinks": 675,
    "TicketPriorityId": 227,
    "SupportLanguageId": 435,
    "SupportAssociateId": 648,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 500
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "aperiam",
      "PersonId": 6,
      "Mrmrs": "autem",
      "Firstname": "William",
      "Lastname": "Crona",
      "MiddleName": "Kertzmann LLC",
      "Title": "voluptatum",
      "Description": "User-centric actuating projection",
      "Email": "breanna.carter@parisian.com",
      "FullName": "Hubert Price",
      "DirectPhone": "641-684-8575",
      "FormalName": "Stehr-Nolan",
      "CountryId": 185,
      "ContactId": 613,
      "ContactName": "Murray Group",
      "Retired": 479,
      "Rank": 33,
      "ActiveInterests": 615,
      "ContactDepartment": "",
      "ContactCountryId": 518,
      "ContactOrgNr": "925805",
      "FaxPhone": "174-718-0836",
      "MobilePhone": "(618)048-2534",
      "ContactPhone": "085.886.3305 x36311",
      "AssociateName": "Koch, Kuhn and Rowe",
      "AssociateId": 706,
      "UsePersonAddress": false,
      "ContactFax": "quod",
      "Kanafname": "qui",
      "Kanalname": "voluptatem",
      "Post1": "nihil",
      "Post2": "accusamus",
      "Post3": "facere",
      "EmailName": "nels@franeckidoyle.co.uk",
      "ContactFullName": "Johnathan Beatty",
      "ActiveErpLinks": 650,
      "TicketPriorityId": 648,
      "SupportLanguageId": 409,
      "SupportAssociateId": 444,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 14
        }
      }
    }
  ],
  "AlertLevel": 830,
  "ConnectId": 155,
  "ReadStatus": "Green",
  "TimeToReply": 772,
  "RealTimeToReply": 195,
  "TimeToClose": 138,
  "RealTimeToClose": 161,
  "TimeSpentInternally": 714,
  "TimeSpentExternally": 235,
  "TimeSpentQueue": 418,
  "RealTimeSpentInternally": 649,
  "RealTimeSpentExternally": 263,
  "RealTimeSpentQueue": 924,
  "HasAttachment": false,
  "NumReplies": 771,
  "NumMessages": 333,
  "FromAddress": "voluptatem",
  "Messages": [
    {
      "TicketMessageId": 364,
      "CreatedAt": "2007-05-16T18:25:51.2249405+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "suscipit",
      "PersonId": 196,
      "PersonFullName": "Ed Bosco",
      "ContactId": 459,
      "ContactName": "Williamson Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 411,
      "EmailHeader": "micheal@wunschanderson.ca",
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
          "FieldLength": 616
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 779,
      "Name": "Champlin Group",
      "ToolTip": "Beatae corrupti et sed autem ad similique.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 457
        }
      }
    },
    {
      "Id": 779,
      "Name": "Champlin Group",
      "ToolTip": "Beatae corrupti et sed autem ad similique.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 457
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "cupiditate",
    "CustomFields2": "excepturi"
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
      "FieldLength": 751
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```