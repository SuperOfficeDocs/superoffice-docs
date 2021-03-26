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
POST /api/v1/Ticket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 266,
  "Title": "nulla",
  "CreatedAt": "2019-02-18T09:40:59.7780667+01:00",
  "LastChanged": "2002-02-24T09:40:59.7780667+01:00",
  "ReadByOwner": "2014-10-08T09:40:59.7780667+02:00",
  "ReadByCustomer": "2000-06-19T09:40:59.7780667+02:00",
  "FirstReadByUser": "1996-10-30T09:40:59.7780667+01:00",
  "Activate": "2013-01-09T09:40:59.7780667+01:00",
  "ClosedAt": "2018-05-06T09:40:59.7780667+02:00",
  "RepliedAt": "2010-11-09T09:40:59.7780667+01:00",
  "AlertTimeout": "2020-11-20T09:40:59.7780667+01:00",
  "Deadline": "1995-10-07T09:40:59.7780667+02:00",
  "CreatedBy": {
    "AssociateId": 298,
    "Name": "Yundt Inc and Sons",
    "PersonId": 135,
    "Rank": 111,
    "Tooltip": "fugiat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 403,
    "FullName": "Miss Reese Welch",
    "FormalName": "Beatty, Cummerata and Schoen",
    "Deleted": true,
    "EjUserId": 209,
    "UserName": "Parker Inc and Sons"
  },
  "Author": "magnam",
  "OwnedBy": {
    "AssociateId": 766,
    "Name": "O'Keefe, Boyer and Mitchell",
    "PersonId": 27,
    "Rank": 870,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 892,
    "FullName": "Blanca Zboncak",
    "FormalName": "Huel LLC",
    "Deleted": false,
    "EjUserId": 725,
    "UserName": "Howe, Terry and Greenfelder"
  },
  "Category": {
    "TicketCategoryId": 848,
    "ParentId": 844,
    "Name": "Gulgowski Group",
    "Fullname": "repudiandae",
    "CategoryMaster": 615,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Hilll, Carroll and Greenfelder",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 377,
    "ReplyTemplate": 215,
    "NotificationEmail": "rowland.bahringer@bayerschumm.com",
    "ExtraFields": {
      "ExtraFields1": "molestias",
      "ExtraFields2": "et"
    },
    "CustomFields": {
      "CustomFields1": "et",
      "CustomFields2": "cumque"
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 256,
    "Name": "Reinger-Weimann",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 198,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 774,
    "MonStart": "2009-01-11T09:40:59.7790645+01:00",
    "MonStop": "2011-09-16T09:40:59.7790645+02:00",
    "TueStart": "2006-02-22T09:40:59.7790645+01:00",
    "TueStop": "2008-10-09T09:40:59.7790645+02:00",
    "WedStart": "2020-07-11T09:40:59.7790645+02:00",
    "WedStop": "2016-11-05T09:40:59.7790645+01:00",
    "ThuStart": "1998-08-21T09:40:59.7790645+02:00",
    "ThuStop": "2008-05-19T09:40:59.7790645+02:00",
    "FriStart": "2018-10-11T09:40:59.7790645+02:00",
    "FriStop": "2008-01-13T09:40:59.7790645+01:00",
    "SatStart": "2000-05-16T09:40:59.7790645+02:00",
    "SatStop": "1994-02-17T09:40:59.7790645+01:00",
    "SunStart": "2010-02-19T09:40:59.7790645+01:00",
    "SunStop": "2008-01-04T09:40:59.7790645+01:00",
    "NonDates": [
      "ratione",
      "deleniti"
    ]
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 486,
    "Name": "Nienow-O'Connell",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": false
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "aut",
    "PersonId": 811,
    "Mrmrs": "repellat",
    "Firstname": "Michael",
    "Lastname": "Rice",
    "MiddleName": "Boehm, Kub and Jast",
    "Title": "ut",
    "Description": "Visionary regional function",
    "Email": "chauncey@oconner.us",
    "FullName": "Brody Rolfson V",
    "DirectPhone": "(762)422-6522",
    "FormalName": "Goodwin, Ortiz and Schmeler",
    "CountryId": 445,
    "ContactId": 662,
    "ContactName": "Mosciski-Swift",
    "Retired": 503,
    "Rank": 698,
    "ActiveInterests": 260,
    "ContactDepartment": "",
    "ContactCountryId": 96,
    "ContactOrgNr": "157398",
    "FaxPhone": "645-020-4731",
    "MobilePhone": "1-522-108-3688 x86547",
    "ContactPhone": "1-542-140-0006",
    "AssociateName": "Langworth Inc and Sons",
    "AssociateId": 227,
    "UsePersonAddress": false,
    "ContactFax": "qui",
    "Kanafname": "doloribus",
    "Kanalname": "aliquam",
    "Post1": "nesciunt",
    "Post2": "cum",
    "Post3": "neque",
    "EmailName": "misty@yost.name",
    "ContactFullName": "Erika Borer",
    "ActiveErpLinks": 27,
    "TicketPriorityId": 467,
    "SupportLanguageId": 548,
    "SupportAssociateId": 316,
    "CategoryName": "VIP Customer"
  },
  "SecondaryPersons": [
    {
      "Position": "voluptatem",
      "PersonId": 413,
      "Mrmrs": "ut",
      "Firstname": "Johnson",
      "Lastname": "Romaguera",
      "MiddleName": "Turcotte, Fay and Walter",
      "Title": "voluptatem",
      "Description": "Synchronised asynchronous functionalities",
      "Email": "joannie.waelchi@hansen.biz",
      "FullName": "Clemens Hintz V",
      "DirectPhone": "313.203.6677 x32750",
      "FormalName": "Bechtelar Inc and Sons",
      "CountryId": 758,
      "ContactId": 938,
      "ContactName": "Larson Inc and Sons",
      "Retired": 627,
      "Rank": 620,
      "ActiveInterests": 869,
      "ContactDepartment": "",
      "ContactCountryId": 712,
      "ContactOrgNr": "790643",
      "FaxPhone": "1-338-760-0765",
      "MobilePhone": "1-624-345-5600",
      "ContactPhone": "568-875-1306 x0408",
      "AssociateName": "Schuster, Hegmann and Von",
      "AssociateId": 978,
      "UsePersonAddress": true,
      "ContactFax": "exercitationem",
      "Kanafname": "autem",
      "Kanalname": "fugit",
      "Post1": "ea",
      "Post2": "quasi",
      "Post3": "distinctio",
      "EmailName": "nona@dubuque.us",
      "ContactFullName": "Lenny Hessel",
      "ActiveErpLinks": 608,
      "TicketPriorityId": 453,
      "SupportLanguageId": 705,
      "SupportAssociateId": 840,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 484,
  "ConnectId": 474,
  "ReadStatus": "Green",
  "TimeToReply": 745,
  "RealTimeToReply": 297,
  "TimeToClose": 774,
  "RealTimeToClose": 119,
  "TimeSpentInternally": 744,
  "TimeSpentExternally": 611,
  "TimeSpentQueue": 365,
  "RealTimeSpentInternally": 622,
  "RealTimeSpentExternally": 112,
  "RealTimeSpentQueue": 900,
  "HasAttachment": false,
  "NumReplies": 393,
  "NumMessages": 834,
  "FromAddress": "ut",
  "Messages": [
    {
      "TicketMessageId": 335,
      "CreatedAt": "2011-04-28T09:40:59.7830665+02:00",
      "Slevel": "External",
      "Important": true
    },
    {
      "TicketMessageId": 335,
      "CreatedAt": "2011-04-28T09:40:59.7830665+02:00",
      "Slevel": "External",
      "Important": true
    }
  ],
  "Tags": [
    {
      "Id": 170,
      "Name": "Waelchi, Leannon and Nitzsche",
      "ToolTip": "Porro est est expedita sunt."
    },
    {
      "Id": 170,
      "Name": "Waelchi, Leannon and Nitzsche",
      "ToolTip": "Porro est est expedita sunt."
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "harum",
    "ExtraFields2": "id"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "perspiciatis"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 143,
  "Title": "est",
  "CreatedAt": "2021-03-21T09:40:59.788065+01:00",
  "LastChanged": "1996-02-02T09:40:59.788065+01:00",
  "ReadByOwner": "2010-03-25T09:40:59.788065+01:00",
  "ReadByCustomer": "2009-03-23T09:40:59.788065+01:00",
  "FirstReadByUser": "2018-07-23T09:40:59.788065+02:00",
  "Activate": "2004-11-11T09:40:59.788065+01:00",
  "ClosedAt": "2016-11-28T09:40:59.788065+01:00",
  "RepliedAt": "2014-09-30T09:40:59.788065+02:00",
  "AlertTimeout": "2015-10-31T09:40:59.788065+01:00",
  "Deadline": "2014-09-19T09:40:59.788065+02:00",
  "CreatedBy": {
    "AssociateId": 436,
    "Name": "Brekke LLC",
    "PersonId": 78,
    "Rank": 894,
    "Tooltip": "consectetur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 257,
    "FullName": "Garrison Hickle",
    "FormalName": "Kuhic-Smith",
    "Deleted": false,
    "EjUserId": 627,
    "UserName": "Haag-Bosco",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 364
      }
    }
  },
  "Author": "iure",
  "OwnedBy": {
    "AssociateId": 836,
    "Name": "Christiansen-Ruecker",
    "PersonId": 403,
    "Rank": 357,
    "Tooltip": "distinctio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 199,
    "FullName": "Chauncey Schmeler",
    "FormalName": "Bernhard Group",
    "Deleted": false,
    "EjUserId": 109,
    "UserName": "Lowe-Tromp",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 534
      }
    }
  },
  "Category": {
    "TicketCategoryId": 686,
    "ParentId": 891,
    "Name": "Block Group",
    "Fullname": "qui",
    "CategoryMaster": 776,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Durgan-Kuhn",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 948,
    "ReplyTemplate": 843,
    "NotificationEmail": "lucie@kilback.us",
    "ExtraFields": {
      "ExtraFields1": "omnis",
      "ExtraFields2": "natus"
    },
    "CustomFields": {
      "CustomFields1": "placeat",
      "CustomFields2": "rerum"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 719
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 275,
    "Name": "Brakus-Roob",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 295,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 607,
    "MonStart": "2019-08-20T09:40:59.7890644+02:00",
    "MonStop": "2007-04-24T09:40:59.7890644+02:00",
    "TueStart": "2004-03-31T09:40:59.7890644+02:00",
    "TueStop": "2003-03-22T09:40:59.7890644+01:00",
    "WedStart": "2018-11-28T09:40:59.7890644+01:00",
    "WedStop": "1995-10-09T09:40:59.7890644+02:00",
    "ThuStart": "2004-05-07T09:40:59.7890644+02:00",
    "ThuStop": "2017-10-26T09:40:59.7890644+02:00",
    "FriStart": "2006-10-23T09:40:59.7890644+02:00",
    "FriStop": "2014-03-31T09:40:59.7890644+02:00",
    "SatStart": "1997-02-27T09:40:59.7890644+01:00",
    "SatStop": "2010-02-28T09:40:59.7890644+01:00",
    "SunStart": "2020-08-04T09:40:59.7890644+02:00",
    "SunStop": "2020-09-22T09:40:59.7890644+02:00",
    "NonDates": [
      "labore",
      "quaerat"
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 261
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 885,
    "Name": "Baumbach, Koch and Klocko",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "enable killer portals"
        },
        "FieldType": "System.String",
        "FieldLength": 613
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "pariatur",
    "PersonId": 150,
    "Mrmrs": "nulla",
    "Firstname": "Serena",
    "Lastname": "Yost",
    "MiddleName": "Goodwin-Kozey",
    "Title": "expedita",
    "Description": "Stand-alone mobile analyzer",
    "Email": "pinkie.rippin@bauch.ca",
    "FullName": "Madisyn Hand",
    "DirectPhone": "(758)421-5641",
    "FormalName": "Adams-Shanahan",
    "CountryId": 664,
    "ContactId": 188,
    "ContactName": "Green, Gutkowski and Runte",
    "Retired": 933,
    "Rank": 87,
    "ActiveInterests": 215,
    "ContactDepartment": "",
    "ContactCountryId": 210,
    "ContactOrgNr": "1754828",
    "FaxPhone": "1-265-414-6464",
    "MobilePhone": "1-260-335-6603 x2122",
    "ContactPhone": "(315)864-5020 x86240",
    "AssociateName": "Kuphal LLC",
    "AssociateId": 557,
    "UsePersonAddress": false,
    "ContactFax": "ut",
    "Kanafname": "aut",
    "Kanalname": "sed",
    "Post1": "maxime",
    "Post2": "eaque",
    "Post3": "ut",
    "EmailName": "elisabeth@lehner.biz",
    "ContactFullName": "Craig Runolfsson",
    "ActiveErpLinks": 708,
    "TicketPriorityId": 754,
    "SupportLanguageId": 329,
    "SupportAssociateId": 446,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 914
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "dolor",
      "PersonId": 707,
      "Mrmrs": "exercitationem",
      "Firstname": "Rod",
      "Lastname": "Kuhlman",
      "MiddleName": "Stokes-Walsh",
      "Title": "voluptatem",
      "Description": "Sharable directional core",
      "Email": "maverick@abshiregreenholt.ca",
      "FullName": "Oran Quigley",
      "DirectPhone": "1-131-331-1874",
      "FormalName": "Schulist LLC",
      "CountryId": 926,
      "ContactId": 465,
      "ContactName": "Bosco, Wolff and Schmeler",
      "Retired": 545,
      "Rank": 950,
      "ActiveInterests": 953,
      "ContactDepartment": "",
      "ContactCountryId": 515,
      "ContactOrgNr": "1578710",
      "FaxPhone": "383.808.3043",
      "MobilePhone": "460-287-8615",
      "ContactPhone": "1-543-813-2855 x567",
      "AssociateName": "Kunde LLC",
      "AssociateId": 251,
      "UsePersonAddress": false,
      "ContactFax": "fugiat",
      "Kanafname": "voluptas",
      "Kanalname": "deleniti",
      "Post1": "dolores",
      "Post2": "ut",
      "Post3": "non",
      "EmailName": "kirk@schuppe.ca",
      "ContactFullName": "Dr. Abdiel Smith",
      "ActiveErpLinks": 570,
      "TicketPriorityId": 707,
      "SupportLanguageId": 444,
      "SupportAssociateId": 886,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 489
        }
      }
    }
  ],
  "AlertLevel": 177,
  "ConnectId": 736,
  "ReadStatus": "Green",
  "TimeToReply": 44,
  "RealTimeToReply": 740,
  "TimeToClose": 571,
  "RealTimeToClose": 300,
  "TimeSpentInternally": 422,
  "TimeSpentExternally": 863,
  "TimeSpentQueue": 949,
  "RealTimeSpentInternally": 669,
  "RealTimeSpentExternally": 729,
  "RealTimeSpentQueue": 286,
  "HasAttachment": true,
  "NumReplies": 108,
  "NumMessages": 439,
  "FromAddress": "ut",
  "Messages": [
    {
      "TicketMessageId": 993,
      "CreatedAt": "2003-08-13T09:40:59.7920666+02:00",
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
          "FieldLength": 1000
        }
      }
    },
    {
      "TicketMessageId": 993,
      "CreatedAt": "2003-08-13T09:40:59.7920666+02:00",
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
          "FieldLength": 1000
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 406,
      "Name": "Mueller-Mertz",
      "ToolTip": "Quaerat eum.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 279
        }
      }
    },
    {
      "Id": 406,
      "Name": "Mueller-Mertz",
      "ToolTip": "Quaerat eum.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 279
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "inventore"
  },
  "CustomFields": {
    "CustomFields1": "optio",
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
      "FieldType": "System.Int32",
      "FieldLength": 849
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```