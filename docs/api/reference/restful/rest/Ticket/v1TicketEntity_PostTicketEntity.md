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
  "TicketId": 123,
  "Title": "sequi",
  "CreatedAt": "1994-08-21T18:25:51.1389097+02:00",
  "LastChanged": "2012-11-08T18:25:51.1389097+01:00",
  "ReadByOwner": "2018-07-19T18:25:51.1389097+02:00",
  "ReadByCustomer": "2021-04-05T18:25:51.1389097+02:00",
  "FirstReadByUser": "2013-08-15T18:25:51.1389097+02:00",
  "Activate": "2000-03-24T18:25:51.1389097+01:00",
  "ClosedAt": "2019-01-14T18:25:51.1389097+01:00",
  "RepliedAt": "2012-07-07T18:25:51.1389097+02:00",
  "AlertTimeout": "2017-04-07T18:25:51.1389097+02:00",
  "Deadline": "2010-04-16T18:25:51.1389097+02:00",
  "CreatedBy": {
    "AssociateId": 402,
    "Name": "Ritchie Inc and Sons",
    "PersonId": 104,
    "Rank": 71,
    "Tooltip": "cum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 230,
    "FullName": "Mrs. Morris Pfannerstill",
    "FormalName": "Steuber, Bartoletti and Balistreri",
    "Deleted": false,
    "EjUserId": 730,
    "UserName": "Spinka, Bruen and Gleichner"
  },
  "Author": "est",
  "OwnedBy": {
    "AssociateId": 103,
    "Name": "McDermott-Bernhard",
    "PersonId": 437,
    "Rank": 677,
    "Tooltip": "quae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 845,
    "FullName": "Alia Kling",
    "FormalName": "Goldner Inc and Sons",
    "Deleted": true,
    "EjUserId": 211,
    "UserName": "Rodriguez LLC"
  },
  "Category": {
    "TicketCategoryId": 437,
    "ParentId": 66,
    "Name": "Rosenbaum-Block",
    "Fullname": "odio",
    "CategoryMaster": 503,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Ondricka-Harber",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 91,
    "ReplyTemplate": 665,
    "NotificationEmail": "fritz.paucek@buckridge.ca",
    "DefaultTicketStatus": {},
    "DefaultMessageStatus": {},
    "ExtraFields": {
      "ExtraFields1": "blanditiis",
      "ExtraFields2": "qui"
    },
    "CustomFields": {
      "CustomFields1": "nesciunt",
      "CustomFields2": "ipsum"
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 391,
    "Name": "Hackett LLC",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 547,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 173,
    "MonStart": "2017-09-02T18:25:51.1419099+02:00",
    "MonStop": "2002-01-05T18:25:51.1419099+01:00",
    "TueStart": "2010-07-01T18:25:51.1419099+02:00",
    "TueStop": "2001-08-18T18:25:51.1419099+02:00",
    "WedStart": "2006-03-02T18:25:51.1419099+01:00",
    "WedStop": "1996-10-29T18:25:51.1419099+01:00",
    "ThuStart": "2006-10-21T18:25:51.1419099+02:00",
    "ThuStop": "1995-11-22T18:25:51.1419099+01:00",
    "FriStart": "1994-08-01T18:25:51.1419099+02:00",
    "FriStop": "2001-01-06T18:25:51.1419099+01:00",
    "SatStart": "2007-11-22T18:25:51.1419099+01:00",
    "SatStop": "2021-09-02T18:25:51.1419099+02:00",
    "SunStart": "1994-12-08T18:25:51.1419099+01:00",
    "SunStop": "1999-05-17T18:25:51.1419099+02:00",
    "NonDates": [
      "repellat",
      "hic"
    ],
    "EscalationLevels": [
      {},
      {}
    ]
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 304,
    "Name": "Wiegand, Herman and Kemmer",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": true,
    "IsDefault": false,
    "UsedInQueue": true
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "odio",
    "PersonId": 186,
    "Mrmrs": "cupiditate",
    "Firstname": "Monica",
    "Lastname": "Kub",
    "MiddleName": "Connelly-Gaylord",
    "Title": "odio",
    "Description": "Customizable intermediate software",
    "Email": "macy@conroy.uk",
    "FullName": "Aletha Koch",
    "DirectPhone": "384-068-6410",
    "FormalName": "Price, Gulgowski and Hirthe",
    "CountryId": 514,
    "ContactId": 897,
    "ContactName": "Turcotte, Dickens and Glover",
    "Retired": 810,
    "Rank": 807,
    "ActiveInterests": 593,
    "ContactDepartment": "",
    "ContactCountryId": 882,
    "ContactOrgNr": "913028",
    "FaxPhone": "814-172-3480",
    "MobilePhone": "(155)362-8363 x650",
    "ContactPhone": "135-341-3345 x85678",
    "AssociateName": "Abshire Group",
    "AssociateId": 708,
    "UsePersonAddress": true,
    "ContactFax": "est",
    "Kanafname": "in",
    "Kanalname": "possimus",
    "Post1": "asperiores",
    "Post2": "et",
    "Post3": "in",
    "EmailName": "emanuel@walkerschaefer.co.uk",
    "ContactFullName": "Trisha Carter",
    "ActiveErpLinks": 787,
    "TicketPriorityId": 119,
    "SupportLanguageId": 67,
    "SupportAssociateId": 464,
    "CategoryName": "VIP Customer"
  },
  "SecondaryPersons": [
    {
      "Position": "est",
      "PersonId": 78,
      "Mrmrs": "maxime",
      "Firstname": "Herbert",
      "Lastname": "Reinger",
      "MiddleName": "Nolan, Stehr and Mayert",
      "Title": "dolorem",
      "Description": "Organic needs-based core",
      "Email": "markus@kassulke.us",
      "FullName": "Amy Feest PhD",
      "DirectPhone": "1-621-408-5074 x833",
      "FormalName": "Rosenbaum-Klocko",
      "CountryId": 59,
      "ContactId": 680,
      "ContactName": "Lockman-Runolfsdottir",
      "Retired": 710,
      "Rank": 751,
      "ActiveInterests": 103,
      "ContactDepartment": "",
      "ContactCountryId": 640,
      "ContactOrgNr": "1069854",
      "FaxPhone": "(734)411-3501",
      "MobilePhone": "853-763-8638",
      "ContactPhone": "353.704.0147",
      "AssociateName": "Schultz, Ankunding and Crona",
      "AssociateId": 481,
      "UsePersonAddress": false,
      "ContactFax": "occaecati",
      "Kanafname": "aut",
      "Kanalname": "occaecati",
      "Post1": "et",
      "Post2": "voluptas",
      "Post3": "ea",
      "EmailName": "macey@lemkehyatt.biz",
      "ContactFullName": "Dr. Coby Huel",
      "ActiveErpLinks": 88,
      "TicketPriorityId": 788,
      "SupportLanguageId": 555,
      "SupportAssociateId": 968,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 713,
  "ConnectId": 390,
  "ReadStatus": "Green",
  "TimeToReply": 763,
  "RealTimeToReply": 367,
  "TimeToClose": 668,
  "RealTimeToClose": 218,
  "TimeSpentInternally": 531,
  "TimeSpentExternally": 727,
  "TimeSpentQueue": 182,
  "RealTimeSpentInternally": 24,
  "RealTimeSpentExternally": 90,
  "RealTimeSpentQueue": 212,
  "HasAttachment": false,
  "NumReplies": 228,
  "NumMessages": 712,
  "FromAddress": "qui",
  "Messages": [
    {
      "TicketMessageId": 629,
      "CreatedAt": "2002-11-21T18:25:51.1449473+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "eos",
      "PersonId": 421,
      "PersonFullName": "Brycen McDermott",
      "ContactId": 641,
      "ContactName": "Kemmer, Murphy and Funk",
      "ContactDepartment": "",
      "NumAttachments": 809,
      "EmailHeader": "gaston@windlergerlach.com",
      "MessageHeaders": [
        {},
        {}
      ]
    }
  ],
  "Tags": [
    {
      "Id": 475,
      "Name": "Eichmann, Lang and Hackett",
      "ToolTip": "Sequi libero corrupti autem."
    },
    {
      "Id": 475,
      "Name": "Eichmann, Lang and Hackett",
      "ToolTip": "Sequi libero corrupti autem."
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "nesciunt",
    "ExtraFields2": "pariatur"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "nisi"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 360,
  "Title": "doloribus",
  "CreatedAt": "2020-07-11T18:25:51.151949+02:00",
  "LastChanged": "1999-12-10T18:25:51.151949+01:00",
  "ReadByOwner": "2019-09-11T18:25:51.151949+02:00",
  "ReadByCustomer": "2005-09-11T18:25:51.151949+02:00",
  "FirstReadByUser": "2019-04-02T18:25:51.151949+02:00",
  "Activate": "2018-12-29T18:25:51.151949+01:00",
  "ClosedAt": "2013-05-17T18:25:51.151949+02:00",
  "RepliedAt": "2016-07-25T18:25:51.151949+02:00",
  "AlertTimeout": "2020-08-30T18:25:51.151949+02:00",
  "Deadline": "2010-12-26T18:25:51.151949+01:00",
  "CreatedBy": {
    "AssociateId": 135,
    "Name": "Mante Group",
    "PersonId": 23,
    "Rank": 320,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 6,
    "FullName": "Rosa Ziemann",
    "FormalName": "Kunze Inc and Sons",
    "Deleted": true,
    "EjUserId": 616,
    "UserName": "Ward-Hand",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 832
      }
    }
  },
  "Author": "et",
  "OwnedBy": {
    "AssociateId": 766,
    "Name": "Reynolds LLC",
    "PersonId": 696,
    "Rank": 127,
    "Tooltip": "maiores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 744,
    "FullName": "Lois Murphy",
    "FormalName": "Huel LLC",
    "Deleted": true,
    "EjUserId": 496,
    "UserName": "Schoen Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 698
      }
    }
  },
  "Category": {
    "TicketCategoryId": 825,
    "ParentId": 117,
    "Name": "Schamberger Group",
    "Fullname": "rerum",
    "CategoryMaster": 144,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Batz LLC",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 155,
    "ReplyTemplate": 66,
    "NotificationEmail": "filiberto@yostrobel.biz",
    "DefaultTicketStatus": {},
    "DefaultMessageStatus": {},
    "ExtraFields": {
      "ExtraFields1": "possimus",
      "ExtraFields2": "repudiandae"
    },
    "CustomFields": {
      "CustomFields1": "quasi",
      "CustomFields2": "tempore"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 873
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 768,
    "Name": "Mraz LLC",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 944,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 656,
    "MonStart": "1995-06-14T18:25:51.1529448+02:00",
    "MonStop": "2019-07-31T18:25:51.1529448+02:00",
    "TueStart": "2004-03-29T18:25:51.1529448+02:00",
    "TueStop": "2019-10-02T18:25:51.1529448+02:00",
    "WedStart": "2002-06-10T18:25:51.1529448+02:00",
    "WedStop": "2019-08-26T18:25:51.1529448+02:00",
    "ThuStart": "2011-01-16T18:25:51.1529448+01:00",
    "ThuStop": "2017-12-28T18:25:51.1529448+01:00",
    "FriStart": "2021-01-01T18:25:51.1529448+01:00",
    "FriStop": "1999-02-21T18:25:51.1529448+01:00",
    "SatStart": "2015-02-09T18:25:51.1529448+01:00",
    "SatStop": "2013-01-12T18:25:51.1529448+01:00",
    "SunStart": "2019-12-18T18:25:51.1529448+01:00",
    "SunStop": "2019-06-19T18:25:51.1529448+02:00",
    "NonDates": [
      "dolor",
      "iure"
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
        "FieldLength": 871
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 774,
    "Name": "Kunze, Schmeler and Reinger",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": true,
    "IsDefault": true,
    "UsedInQueue": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 627
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "temporibus",
    "PersonId": 615,
    "Mrmrs": "neque",
    "Firstname": "Pattie",
    "Lastname": "Hartmann",
    "MiddleName": "Jewess-Stehr",
    "Title": "natus",
    "Description": "Open-source homogeneous process improvement",
    "Email": "dolly.predovic@feeney.biz",
    "FullName": "Renee O'Kon",
    "DirectPhone": "154-810-1106",
    "FormalName": "Mertz, Kerluke and Hilpert",
    "CountryId": 84,
    "ContactId": 947,
    "ContactName": "Bartell Group",
    "Retired": 698,
    "Rank": 451,
    "ActiveInterests": 355,
    "ContactDepartment": "deliver visionary deliverables",
    "ContactCountryId": 702,
    "ContactOrgNr": "544551",
    "FaxPhone": "1-031-226-3433 x35643",
    "MobilePhone": "1-371-334-1857",
    "ContactPhone": "1-803-305-1634 x102",
    "AssociateName": "Schmeler-Muller",
    "AssociateId": 260,
    "UsePersonAddress": true,
    "ContactFax": "libero",
    "Kanafname": "voluptatem",
    "Kanalname": "voluptatem",
    "Post1": "voluptates",
    "Post2": "iste",
    "Post3": "sed",
    "EmailName": "misael@gerlachkreiger.uk",
    "ContactFullName": "Mr. Dejon Zieme",
    "ActiveErpLinks": 536,
    "TicketPriorityId": 814,
    "SupportLanguageId": 21,
    "SupportAssociateId": 639,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 792
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "eveniet",
      "PersonId": 878,
      "Mrmrs": "omnis",
      "Firstname": "Cayla",
      "Lastname": "Steuber",
      "MiddleName": "Graham, Bogan and Lowe",
      "Title": "laudantium",
      "Description": "Persistent bifurcated challenge",
      "Email": "hannah@beerbernhard.uk",
      "FullName": "Dallas Brekke",
      "DirectPhone": "171-100-0385 x25823",
      "FormalName": "Cassin, Von and Kub",
      "CountryId": 60,
      "ContactId": 532,
      "ContactName": "Ortiz, Steuber and Heathcote",
      "Retired": 890,
      "Rank": 131,
      "ActiveInterests": 753,
      "ContactDepartment": "",
      "ContactCountryId": 203,
      "ContactOrgNr": "928107",
      "FaxPhone": "(800)510-4005 x476",
      "MobilePhone": "353-266-0211 x271",
      "ContactPhone": "1-356-360-0230 x87083",
      "AssociateName": "Deckow Inc and Sons",
      "AssociateId": 620,
      "UsePersonAddress": true,
      "ContactFax": "aspernatur",
      "Kanafname": "earum",
      "Kanalname": "et",
      "Post1": "rerum",
      "Post2": "vero",
      "Post3": "sit",
      "EmailName": "karine_keebler@breitenberg.uk",
      "ContactFullName": "Mrs. Einar Gleichner",
      "ActiveErpLinks": 857,
      "TicketPriorityId": 732,
      "SupportLanguageId": 82,
      "SupportAssociateId": 853,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 186
        }
      }
    }
  ],
  "AlertLevel": 689,
  "ConnectId": 176,
  "ReadStatus": "Green",
  "TimeToReply": 295,
  "RealTimeToReply": 826,
  "TimeToClose": 815,
  "RealTimeToClose": 753,
  "TimeSpentInternally": 624,
  "TimeSpentExternally": 390,
  "TimeSpentQueue": 400,
  "RealTimeSpentInternally": 530,
  "RealTimeSpentExternally": 703,
  "RealTimeSpentQueue": 660,
  "HasAttachment": false,
  "NumReplies": 461,
  "NumMessages": 234,
  "FromAddress": "ducimus",
  "Messages": [
    {
      "TicketMessageId": 79,
      "CreatedAt": "1998-07-07T18:25:51.1569412+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "eum",
      "PersonId": 73,
      "PersonFullName": "Merle Dicki",
      "ContactId": 367,
      "ContactName": "Willms, Terry and Brown",
      "ContactDepartment": "incentivize dynamic supply-chains",
      "NumAttachments": 141,
      "EmailHeader": "elaina@bartonbartell.biz",
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
          "FieldLength": 947
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 273,
      "Name": "Spencer, Keeling and Turner",
      "ToolTip": "Modi libero provident quam.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "transform efficient ROI"
          },
          "FieldType": "System.String",
          "FieldLength": 440
        }
      }
    },
    {
      "Id": 273,
      "Name": "Spencer, Keeling and Turner",
      "ToolTip": "Modi libero provident quam.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "transform efficient ROI"
          },
          "FieldType": "System.String",
          "FieldLength": 440
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "officia",
    "ExtraFields2": "expedita"
  },
  "CustomFields": {
    "CustomFields1": "maxime",
    "CustomFields2": "velit"
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
      "FieldLength": 94
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```