---
title: POST Ticket
id: v1TicketEntity_PostTicketEntity
---

# POST Ticket

```http
POST /api/v1/Ticket
```

Creates a new TicketEntity

Calls the Ticket agent service SaveTicketEntity.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Ticket?$select=name,department,category/id
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

## Request Body: newEntity  

The TicketEntity to be saved. 

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


## Response: object

The ticket entity is used for representing a service ticket



TicketEntity entity with API _Links added.

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
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/Ticket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 254,
  "Title": "temporibus",
  "CreatedAt": "2016-08-08T15:05:42.817662+02:00",
  "LastChanged": "1997-03-13T15:05:42.817662+01:00",
  "ReadByOwner": "2006-05-21T15:05:42.817662+02:00",
  "ReadByCustomer": "2020-08-03T15:05:42.817662+02:00",
  "FirstReadByUser": "1999-10-13T15:05:42.817662+02:00",
  "Activate": "1997-10-28T15:05:42.817662+01:00",
  "ClosedAt": "2012-11-20T15:05:42.817662+01:00",
  "RepliedAt": "2018-08-26T15:05:42.817662+02:00",
  "AlertTimeout": "1996-02-21T15:05:42.817662+01:00",
  "Deadline": "2003-11-05T15:05:42.817662+01:00",
  "CreatedBy": {
    "AssociateId": 464,
    "Name": "Effertz LLC",
    "PersonId": 485,
    "Rank": 480,
    "Tooltip": "voluptate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 514,
    "FullName": "Mr. Percy Koch",
    "FormalName": "Buckridge, Fadel and Schaden",
    "Deleted": false,
    "EjUserId": 697,
    "UserName": "Bernhard-Schamberger"
  },
  "Author": "placeat",
  "OwnedBy": {
    "AssociateId": 283,
    "Name": "Crona LLC",
    "PersonId": 650,
    "Rank": 97,
    "Tooltip": "cum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 714,
    "FullName": "Kaleb Price",
    "FormalName": "Casper-Terry",
    "Deleted": false,
    "EjUserId": 708,
    "UserName": "Romaguera, Bode and Boyle"
  },
  "Category": {
    "TicketCategoryId": 99,
    "ParentId": 89,
    "Name": "Oberbrunner, Lemke and Hessel",
    "Fullname": "eaque",
    "CategoryMaster": 394,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Doyle, Gottlieb and Hettinger",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 419,
    "ReplyTemplate": 787,
    "NotificationEmail": "dennis@hodkiewicz.us",
    "ExtraFields": {
      "ExtraFields1": "illum",
      "ExtraFields2": "commodi"
    },
    "CustomFields": {
      "CustomFields1": "et",
      "CustomFields2": "sit"
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 70,
    "Name": "Abbott, Lynch and Toy",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 321,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 43,
    "MonStart": "1999-07-16T15:05:42.8186783+02:00",
    "MonStop": "2011-01-01T15:05:42.8186783+01:00",
    "TueStart": "1995-03-02T15:05:42.8186783+01:00",
    "TueStop": "2003-10-12T15:05:42.8186783+02:00",
    "WedStart": "1998-07-03T15:05:42.8186783+02:00",
    "WedStop": "2012-02-04T15:05:42.8186783+01:00",
    "ThuStart": "2002-03-24T15:05:42.8186783+01:00",
    "ThuStop": "2018-09-11T15:05:42.8186783+02:00",
    "FriStart": "2018-04-23T15:05:42.8186783+02:00",
    "FriStop": "2015-08-28T15:05:42.8186783+02:00",
    "SatStart": "2001-07-28T15:05:42.8186783+02:00",
    "SatStop": "2010-03-23T15:05:42.8186783+01:00",
    "SunStart": "2015-07-17T15:05:42.8186783+02:00",
    "SunStop": "2020-11-07T15:05:42.8186783+01:00",
    "NonDates": [
      "deserunt",
      "voluptatem"
    ]
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 296,
    "Name": "Tremblay, Stiedemann and Tremblay",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": true
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "animi",
    "PersonId": 49,
    "Mrmrs": "nemo",
    "Firstname": "Ona",
    "Lastname": "Lueilwitz",
    "MiddleName": "Koelpin-Ankunding",
    "Title": "facere",
    "Description": "Grass-roots systematic structure",
    "Email": "carlos@gottlieb.info",
    "FullName": "Ralph Franecki",
    "DirectPhone": "(128)405-0840 x4181",
    "FormalName": "Kozey-Schinner",
    "CountryId": 131,
    "ContactId": 100,
    "ContactName": "Johnston, Weber and Walker",
    "Retired": 19,
    "Rank": 517,
    "ActiveInterests": 739,
    "ContactDepartment": "",
    "ContactCountryId": 474,
    "ContactOrgNr": "506553",
    "FaxPhone": "1-771-045-0332",
    "MobilePhone": "773-118-7707 x65223",
    "ContactPhone": "(036)571-8637 x08766",
    "AssociateName": "Kiehn, McLaughlin and Brown",
    "AssociateId": 107,
    "UsePersonAddress": false,
    "ContactFax": "provident",
    "Kanafname": "facilis",
    "Kanalname": "ex",
    "Post1": "vitae",
    "Post2": "accusamus",
    "Post3": "sit",
    "EmailName": "althea.okeefe@beahanolson.name",
    "ContactFullName": "Pierre Hills",
    "ActiveErpLinks": 884,
    "TicketPriorityId": 898,
    "SupportLanguageId": 985,
    "SupportAssociateId": 280,
    "CategoryName": "VIP Customer"
  },
  "SecondaryPersons": [
    {
      "Position": "sapiente",
      "PersonId": 120,
      "Mrmrs": "ipsum",
      "Firstname": "Daphnee",
      "Lastname": "Feest",
      "MiddleName": "Schneider, Nader and Wuckert",
      "Title": "consequatur",
      "Description": "Optimized multimedia benchmark",
      "Email": "dakota_boehm@paucek.ca",
      "FullName": "Cicero Barrows",
      "DirectPhone": "1-116-302-1115 x843",
      "FormalName": "Aufderhar LLC",
      "CountryId": 591,
      "ContactId": 854,
      "ContactName": "Wyman-O'Reilly",
      "Retired": 408,
      "Rank": 664,
      "ActiveInterests": 148,
      "ContactDepartment": "",
      "ContactCountryId": 589,
      "ContactOrgNr": "1233439",
      "FaxPhone": "(060)115-4216",
      "MobilePhone": "406-575-2301",
      "ContactPhone": "570.764.5348 x27188",
      "AssociateName": "Friesen LLC",
      "AssociateId": 565,
      "UsePersonAddress": true,
      "ContactFax": "sed",
      "Kanafname": "blanditiis",
      "Kanalname": "distinctio",
      "Post1": "ut",
      "Post2": "ut",
      "Post3": "autem",
      "EmailName": "candice@feeney.com",
      "ContactFullName": "Trycia Nader",
      "ActiveErpLinks": 681,
      "TicketPriorityId": 249,
      "SupportLanguageId": 291,
      "SupportAssociateId": 281,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 188,
  "ConnectId": 634,
  "ReadStatus": "Green",
  "TimeToReply": 890,
  "RealTimeToReply": 265,
  "TimeToClose": 71,
  "RealTimeToClose": 828,
  "TimeSpentInternally": 513,
  "TimeSpentExternally": 789,
  "TimeSpentQueue": 487,
  "RealTimeSpentInternally": 480,
  "RealTimeSpentExternally": 665,
  "RealTimeSpentQueue": 592,
  "HasAttachment": true,
  "NumReplies": 93,
  "NumMessages": 440,
  "FromAddress": "aut",
  "Messages": [
    {
      "TicketMessageId": 220,
      "CreatedAt": "2021-05-12T15:05:42.8216669+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "repellendus",
      "PersonId": 678,
      "PersonFullName": "Addie Raynor V",
      "ContactId": 769,
      "ContactName": "Strosin, Steuber and Dare",
      "ContactDepartment": "",
      "NumAttachments": 31,
      "EmailHeader": "jadyn@dooley.us",
      "MessageHeaders": [
        {},
        {}
      ]
    }
  ],
  "Tags": [
    {
      "Id": 316,
      "Name": "O'Connell, Mante and Marquardt",
      "ToolTip": "Quibusdam quas."
    },
    {
      "Id": 316,
      "Name": "O'Connell, Mante and Marquardt",
      "ToolTip": "Quibusdam quas."
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "similique",
    "ExtraFields2": "minima"
  },
  "CustomFields": {
    "CustomFields1": "laudantium",
    "CustomFields2": "necessitatibus"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 708,
  "Title": "temporibus",
  "CreatedAt": "2014-11-13T15:05:42.8276624+01:00",
  "LastChanged": "2004-03-16T15:05:42.8276624+01:00",
  "ReadByOwner": "2018-10-29T15:05:42.8276624+01:00",
  "ReadByCustomer": "2018-05-02T15:05:42.8276624+02:00",
  "FirstReadByUser": "2006-11-10T15:05:42.8276624+01:00",
  "Activate": "2004-09-17T15:05:42.8276624+02:00",
  "ClosedAt": "2015-07-07T15:05:42.8276624+02:00",
  "RepliedAt": "1999-04-06T15:05:42.8276624+02:00",
  "AlertTimeout": "2009-04-01T15:05:42.8276624+02:00",
  "Deadline": "1995-05-19T15:05:42.8276624+02:00",
  "CreatedBy": {
    "AssociateId": 342,
    "Name": "Hammes-Cremin",
    "PersonId": 381,
    "Rank": 179,
    "Tooltip": "cum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 717,
    "FullName": "Mrs. Lucy Cartwright",
    "FormalName": "Swift, Heidenreich and Sawayn",
    "Deleted": true,
    "EjUserId": 765,
    "UserName": "Tremblay-Halvorson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 969
      }
    }
  },
  "Author": "id",
  "OwnedBy": {
    "AssociateId": 37,
    "Name": "Heller Group",
    "PersonId": 355,
    "Rank": 998,
    "Tooltip": "quidem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 395,
    "FullName": "Freddy Schaefer PhD",
    "FormalName": "Pacocha Inc and Sons",
    "Deleted": false,
    "EjUserId": 983,
    "UserName": "O'Reilly Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 441
      }
    }
  },
  "Category": {
    "TicketCategoryId": 447,
    "ParentId": 119,
    "Name": "Koelpin-Hintz",
    "Fullname": "labore",
    "CategoryMaster": 73,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Larson, Grant and Cassin",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 722,
    "ReplyTemplate": 392,
    "NotificationEmail": "graham@beatty.biz",
    "ExtraFields": {
      "ExtraFields1": "maiores",
      "ExtraFields2": "earum"
    },
    "CustomFields": {
      "CustomFields1": "et",
      "CustomFields2": "repellat"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 981
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 21,
    "Name": "Champlin Group",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 911,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 52,
    "MonStart": "2010-05-21T15:05:42.8286647+02:00",
    "MonStop": "2013-09-03T15:05:42.8286647+02:00",
    "TueStart": "2002-05-01T15:05:42.8286647+02:00",
    "TueStop": "2010-10-21T15:05:42.8286647+02:00",
    "WedStart": "2018-06-18T15:05:42.8286647+02:00",
    "WedStop": "2003-07-11T15:05:42.8286647+02:00",
    "ThuStart": "1999-06-25T15:05:42.8286647+02:00",
    "ThuStop": "2011-09-05T15:05:42.8286647+02:00",
    "FriStart": "2015-07-16T15:05:42.8286647+02:00",
    "FriStop": "1997-07-18T15:05:42.8286647+02:00",
    "SatStart": "2018-01-20T15:05:42.8286647+01:00",
    "SatStop": "2019-12-24T15:05:42.8286647+01:00",
    "SunStart": "2003-05-15T15:05:42.8286647+02:00",
    "SunStop": "1996-05-10T15:05:42.8286647+02:00",
    "NonDates": [
      "autem",
      "soluta"
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 99
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 19,
    "Name": "Crist Inc and Sons",
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
        "FieldLength": 754
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "quia",
    "PersonId": 156,
    "Mrmrs": "ipsam",
    "Firstname": "Fiona",
    "Lastname": "O'Keefe",
    "MiddleName": "Frami, McCullough and Williamson",
    "Title": "maiores",
    "Description": "Vision-oriented empowering emulation",
    "Email": "cassidy_pagac@bahringer.us",
    "FullName": "Kole Pagac",
    "DirectPhone": "(015)784-7137",
    "FormalName": "Dooley, Rau and Hammes",
    "CountryId": 26,
    "ContactId": 435,
    "ContactName": "Wolf Inc and Sons",
    "Retired": 136,
    "Rank": 973,
    "ActiveInterests": 849,
    "ContactDepartment": "",
    "ContactCountryId": 349,
    "ContactOrgNr": "289851",
    "FaxPhone": "1-647-866-5608",
    "MobilePhone": "1-241-171-2788",
    "ContactPhone": "228.440.2325 x73155",
    "AssociateName": "DuBuque, Larson and Casper",
    "AssociateId": 641,
    "UsePersonAddress": false,
    "ContactFax": "a",
    "Kanafname": "est",
    "Kanalname": "aut",
    "Post1": "est",
    "Post2": "quam",
    "Post3": "quia",
    "EmailName": "dillan.weissnat@collier.uk",
    "ContactFullName": "Mattie Krajcik",
    "ActiveErpLinks": 422,
    "TicketPriorityId": 108,
    "SupportLanguageId": 55,
    "SupportAssociateId": 519,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 278
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "aliquid",
      "PersonId": 76,
      "Mrmrs": "laboriosam",
      "Firstname": "Donavon",
      "Lastname": "Strosin",
      "MiddleName": "Grady-Gibson",
      "Title": "ratione",
      "Description": "Down-sized object-oriented data-warehouse",
      "Email": "geovanny@waelchi.uk",
      "FullName": "Columbus Cruickshank",
      "DirectPhone": "424.826.3012 x6541",
      "FormalName": "Howe, Lindgren and Emmerich",
      "CountryId": 176,
      "ContactId": 66,
      "ContactName": "Gibson-Pfeffer",
      "Retired": 849,
      "Rank": 614,
      "ActiveInterests": 136,
      "ContactDepartment": "facilitate robust e-business",
      "ContactCountryId": 219,
      "ContactOrgNr": "1061555",
      "FaxPhone": "783-684-2004",
      "MobilePhone": "(788)257-3002 x155",
      "ContactPhone": "(160)020-5642",
      "AssociateName": "Aufderhar, Stark and Fadel",
      "AssociateId": 669,
      "UsePersonAddress": false,
      "ContactFax": "consectetur",
      "Kanafname": "ex",
      "Kanalname": "incidunt",
      "Post1": "fugit",
      "Post2": "ab",
      "Post3": "quia",
      "EmailName": "ova_hills@jakubowski.us",
      "ContactFullName": "Dr. Griffin Swaniawski",
      "ActiveErpLinks": 126,
      "TicketPriorityId": 439,
      "SupportLanguageId": 705,
      "SupportAssociateId": 558,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 362
        }
      }
    }
  ],
  "AlertLevel": 366,
  "ConnectId": 723,
  "ReadStatus": "Green",
  "TimeToReply": 376,
  "RealTimeToReply": 302,
  "TimeToClose": 502,
  "RealTimeToClose": 927,
  "TimeSpentInternally": 583,
  "TimeSpentExternally": 889,
  "TimeSpentQueue": 524,
  "RealTimeSpentInternally": 203,
  "RealTimeSpentExternally": 242,
  "RealTimeSpentQueue": 498,
  "HasAttachment": false,
  "NumReplies": 684,
  "NumMessages": 656,
  "FromAddress": "enim",
  "Messages": [
    {
      "TicketMessageId": 447,
      "CreatedAt": "2011-02-15T15:05:42.8316619+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "consequatur",
      "PersonId": 830,
      "PersonFullName": "Maia Schiller",
      "ContactId": 387,
      "ContactName": "Wiza-Beer",
      "ContactDepartment": "",
      "NumAttachments": 762,
      "EmailHeader": "anibal@ziemejast.name",
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
          "FieldLength": 487
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 622,
      "Name": "Hirthe Inc and Sons",
      "ToolTip": "Ab ut tempora perspiciatis autem provident.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 547
        }
      }
    },
    {
      "Id": 622,
      "Name": "Hirthe Inc and Sons",
      "ToolTip": "Ab ut tempora perspiciatis autem provident.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 547
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "adipisci"
  },
  "CustomFields": {
    "CustomFields1": "unde",
    "CustomFields2": "id"
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
      "FieldLength": 902
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```