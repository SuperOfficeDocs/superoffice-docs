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
    "path": "incidunt",
    "value": {
      "value1": {
        "PrimaryKey": 6651,
        "EntityName": "sale",
        "saleId": 6651,
        "contactId": 5814,
        "name": "Franecki Inc and Sons"
      },
      "value2": {
        "PrimaryKey": 8555,
        "EntityName": "person",
        "personId": 8555,
        "fullName": "Laurie Schiller"
      }
    }
  },
  {
    "op": "add",
    "path": "incidunt",
    "value": {
      "value1": {
        "PrimaryKey": 6651,
        "EntityName": "sale",
        "saleId": 6651,
        "contactId": 5814,
        "name": "Franecki Inc and Sons"
      },
      "value2": {
        "PrimaryKey": 8555,
        "EntityName": "person",
        "personId": 8555,
        "fullName": "Laurie Schiller"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 TicketEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 185,
  "Title": "culpa",
  "CreatedAt": "1998-05-12T09:40:59.8220655+02:00",
  "LastChanged": "1997-09-25T09:40:59.8220655+02:00",
  "ReadByOwner": "2019-12-24T09:40:59.8220655+01:00",
  "ReadByCustomer": "2018-07-30T09:40:59.8220655+02:00",
  "FirstReadByUser": "2016-08-13T09:40:59.8220655+02:00",
  "Activate": "2012-05-05T09:40:59.8220655+02:00",
  "ClosedAt": "2018-01-11T09:40:59.8220655+01:00",
  "RepliedAt": "2006-10-14T09:40:59.8220655+02:00",
  "AlertTimeout": "2014-01-02T09:40:59.8220655+01:00",
  "Deadline": "2015-11-09T09:40:59.8220655+01:00",
  "CreatedBy": {
    "AssociateId": 960,
    "Name": "Blanda Group",
    "PersonId": 977,
    "Rank": 617,
    "Tooltip": "minima",
    "Type": "AnonymousAssociate",
    "GroupIdx": 334,
    "FullName": "Sarina Herzog",
    "FormalName": "Barrows-Rohan",
    "Deleted": false,
    "EjUserId": 35,
    "UserName": "Spinka, Raynor and Hyatt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 277
      }
    }
  },
  "Author": "iusto",
  "OwnedBy": {
    "AssociateId": 374,
    "Name": "Ratke-Schneider",
    "PersonId": 508,
    "Rank": 204,
    "Tooltip": "eius",
    "Type": "AnonymousAssociate",
    "GroupIdx": 581,
    "FullName": "Lauryn Kulas",
    "FormalName": "Krajcik-Anderson",
    "Deleted": true,
    "EjUserId": 966,
    "UserName": "Nienow-Bergstrom",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 678
      }
    }
  },
  "Category": {
    "TicketCategoryId": 422,
    "ParentId": 480,
    "Name": "Schamberger-Nitzsche",
    "Fullname": "cumque",
    "CategoryMaster": 881,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Morissette LLC",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 236,
    "ReplyTemplate": 813,
    "NotificationEmail": "dejon.funk@collierwaelchi.ca",
    "ExtraFields": {
      "ExtraFields1": "dolores",
      "ExtraFields2": "aspernatur"
    },
    "CustomFields": {
      "CustomFields1": "tenetur",
      "CustomFields2": "harum"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "innovate seamless technologies"
        },
        "FieldType": "System.Int32",
        "FieldLength": 190
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 718,
    "Name": "Pagac LLC",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 602,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 423,
    "MonStart": "2019-04-14T09:40:59.8230649+02:00",
    "MonStop": "2011-10-08T09:40:59.8230649+02:00",
    "TueStart": "2003-10-04T09:40:59.8230649+02:00",
    "TueStop": "2013-11-30T09:40:59.8230649+01:00",
    "WedStart": "2006-12-10T09:40:59.8230649+01:00",
    "WedStop": "1996-09-20T09:40:59.8230649+02:00",
    "ThuStart": "1995-12-20T09:40:59.8230649+01:00",
    "ThuStop": "1999-10-28T09:40:59.8230649+02:00",
    "FriStart": "1996-02-20T09:40:59.8230649+01:00",
    "FriStop": "1995-03-02T09:40:59.8230649+01:00",
    "SatStart": "2019-08-31T09:40:59.8230649+02:00",
    "SatStop": "1994-03-22T09:40:59.8230649+01:00",
    "SunStart": "2012-01-08T09:40:59.8230649+01:00",
    "SunStop": "2013-08-11T09:40:59.8230649+02:00",
    "NonDates": [
      "dolorum",
      "autem"
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 141
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 577,
    "Name": "Gorczany Group",
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
        "FieldType": "System.Int32",
        "FieldLength": 710
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "reiciendis",
    "PersonId": 162,
    "Mrmrs": "exercitationem",
    "Firstname": "Van",
    "Lastname": "Weber",
    "MiddleName": "Reinger Inc and Sons",
    "Title": "molestias",
    "Description": "Function-based transitional productivity",
    "Email": "margie.batz@waters.com",
    "FullName": "Aaron Kub Jr.",
    "DirectPhone": "428-520-5216 x55762",
    "FormalName": "Runte, Marquardt and Leffler",
    "CountryId": 912,
    "ContactId": 241,
    "ContactName": "Mraz, Wisoky and Shanahan",
    "Retired": 84,
    "Rank": 488,
    "ActiveInterests": 915,
    "ContactDepartment": "",
    "ContactCountryId": 390,
    "ContactOrgNr": "757844",
    "FaxPhone": "420-370-7154 x33201",
    "MobilePhone": "343.815.5507 x1561",
    "ContactPhone": "416.342.2846 x6521",
    "AssociateName": "Littel-Zieme",
    "AssociateId": 324,
    "UsePersonAddress": true,
    "ContactFax": "repudiandae",
    "Kanafname": "quas",
    "Kanalname": "et",
    "Post1": "iusto",
    "Post2": "beatae",
    "Post3": "minima",
    "EmailName": "isaiah@wintheiser.biz",
    "ContactFullName": "Kali Christiansen",
    "ActiveErpLinks": 588,
    "TicketPriorityId": 915,
    "SupportLanguageId": 283,
    "SupportAssociateId": 408,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 453
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "amet",
      "PersonId": 249,
      "Mrmrs": "animi",
      "Firstname": "Sadie",
      "Lastname": "Mitchell",
      "MiddleName": "Bogan-Keeling",
      "Title": "et",
      "Description": "Synergized secondary model",
      "Email": "florence@lynch.us",
      "FullName": "Mrs. Lisandro Miller",
      "DirectPhone": "(282)282-0876 x077",
      "FormalName": "Hessel, Marvin and Kerluke",
      "CountryId": 297,
      "ContactId": 831,
      "ContactName": "Funk, Rutherford and Goodwin",
      "Retired": 887,
      "Rank": 51,
      "ActiveInterests": 836,
      "ContactDepartment": "",
      "ContactCountryId": 212,
      "ContactOrgNr": "364109",
      "FaxPhone": "1-581-453-7457 x88834",
      "MobilePhone": "(676)587-7146",
      "ContactPhone": "1-113-775-6376",
      "AssociateName": "Quitzon-Conn",
      "AssociateId": 620,
      "UsePersonAddress": false,
      "ContactFax": "itaque",
      "Kanafname": "dolor",
      "Kanalname": "cupiditate",
      "Post1": "ut",
      "Post2": "ex",
      "Post3": "et",
      "EmailName": "retta.vandervort@wolf.uk",
      "ContactFullName": "Abigail Blanda III",
      "ActiveErpLinks": 173,
      "TicketPriorityId": 952,
      "SupportLanguageId": 706,
      "SupportAssociateId": 575,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "maximize compelling initiatives"
          },
          "FieldType": "System.String",
          "FieldLength": 926
        }
      }
    }
  ],
  "AlertLevel": 877,
  "ConnectId": 773,
  "ReadStatus": "Green",
  "TimeToReply": 818,
  "RealTimeToReply": 703,
  "TimeToClose": 572,
  "RealTimeToClose": 330,
  "TimeSpentInternally": 441,
  "TimeSpentExternally": 456,
  "TimeSpentQueue": 933,
  "RealTimeSpentInternally": 827,
  "RealTimeSpentExternally": 589,
  "RealTimeSpentQueue": 706,
  "HasAttachment": false,
  "NumReplies": 358,
  "NumMessages": 737,
  "FromAddress": "perferendis",
  "Messages": [
    {
      "TicketMessageId": 434,
      "CreatedAt": "2020-06-16T09:40:59.8260666+02:00",
      "Slevel": "External",
      "Important": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "incubate wireless web services"
          },
          "FieldType": "System.String",
          "FieldLength": 208
        }
      }
    },
    {
      "TicketMessageId": 434,
      "CreatedAt": "2020-06-16T09:40:59.8260666+02:00",
      "Slevel": "External",
      "Important": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "incubate wireless web services"
          },
          "FieldType": "System.String",
          "FieldLength": 208
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 772,
      "Name": "Schaden, Feest and Doyle",
      "ToolTip": "Non et.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 851
        }
      }
    },
    {
      "Id": 772,
      "Name": "Schaden, Feest and Doyle",
      "ToolTip": "Non et.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 851
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "dolorum",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "alias",
    "CustomFields2": "maiores"
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
      "FieldLength": 991
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```