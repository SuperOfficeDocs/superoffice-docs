---
title: PUT Ticket/{id}
id: v1TicketEntity_PutTicketEntity
---

# PUT Ticket/{id}

```http
PUT /api/v1/Ticket/{id}
```

Updates the existing TicketEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The TicketEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Ticket/{id}?$select=name,department,category/id
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

## Request Body: entity  

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
| 200 | TicketEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 723,
  "Title": "deleniti",
  "CreatedAt": "2007-11-14T09:40:59.8030642+01:00",
  "LastChanged": "2010-04-19T09:40:59.8030642+02:00",
  "ReadByOwner": "1998-05-15T09:40:59.8030642+02:00",
  "ReadByCustomer": "2016-11-16T09:40:59.8030642+01:00",
  "FirstReadByUser": "2005-04-12T09:40:59.8030642+02:00",
  "Activate": "1996-03-11T09:40:59.8030642+01:00",
  "ClosedAt": "2004-12-24T09:40:59.8030642+01:00",
  "RepliedAt": "1996-03-12T09:40:59.8030642+01:00",
  "AlertTimeout": "2003-08-17T09:40:59.8030642+02:00",
  "Deadline": "1998-04-02T09:40:59.8030642+02:00",
  "CreatedBy": {
    "AssociateId": 643,
    "Name": "Johnston, Stoltenberg and Toy",
    "PersonId": 990,
    "Rank": 228,
    "Tooltip": "doloremque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 867,
    "FullName": "Sofia Kerluke MD",
    "FormalName": "O'Connell, Schneider and Schoen",
    "Deleted": false,
    "EjUserId": 498,
    "UserName": "Olson, Brekke and Monahan"
  },
  "Author": "enim",
  "OwnedBy": {
    "AssociateId": 554,
    "Name": "Emmerich-Schmidt",
    "PersonId": 494,
    "Rank": 936,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 149,
    "FullName": "Dr. Destini Schuppe",
    "FormalName": "Pouros LLC",
    "Deleted": false,
    "EjUserId": 317,
    "UserName": "Hyatt-Langosh"
  },
  "Category": {
    "TicketCategoryId": 858,
    "ParentId": 267,
    "Name": "Brekke, Balistreri and Heaney",
    "Fullname": "modi",
    "CategoryMaster": 315,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Pacocha, Feest and Schroeder",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 239,
    "ReplyTemplate": 161,
    "NotificationEmail": "asia_murphy@little.co.uk",
    "ExtraFields": {
      "ExtraFields1": "dolores",
      "ExtraFields2": "dolores"
    },
    "CustomFields": {
      "CustomFields1": "eaque",
      "CustomFields2": "tenetur"
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 385,
    "Name": "Huel, Moore and Hartmann",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 579,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 80,
    "MonStart": "2011-10-07T09:40:59.8040636+02:00",
    "MonStop": "2007-12-01T09:40:59.8040636+01:00",
    "TueStart": "2009-08-09T09:40:59.8040636+02:00",
    "TueStop": "2013-08-14T09:40:59.8040636+02:00",
    "WedStart": "2003-11-05T09:40:59.8040636+01:00",
    "WedStop": "1998-12-15T09:40:59.8040636+01:00",
    "ThuStart": "2005-11-06T09:40:59.8040636+01:00",
    "ThuStop": "2014-12-22T09:40:59.8040636+01:00",
    "FriStart": "2018-01-17T09:40:59.8040636+01:00",
    "FriStop": "1997-03-10T09:40:59.8040636+01:00",
    "SatStart": "2019-07-08T09:40:59.8040636+02:00",
    "SatStop": "1998-10-29T09:40:59.8040636+01:00",
    "SunStart": "1995-01-25T09:40:59.8040636+01:00",
    "SunStop": "2018-01-18T09:40:59.8040636+01:00",
    "NonDates": [
      "quidem",
      "vero"
    ]
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 991,
    "Name": "Runolfsson Inc and Sons",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": false
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "et",
    "PersonId": 193,
    "Mrmrs": "dolores",
    "Firstname": "Derek",
    "Lastname": "Emard",
    "MiddleName": "Howell, Moore and Kohler",
    "Title": "velit",
    "Description": "Stand-alone national definition",
    "Email": "donato.schulist@prosaccolakin.ca",
    "FullName": "Dr. Demario Rohan",
    "DirectPhone": "164.635.5865 x562",
    "FormalName": "Bahringer-Bailey",
    "CountryId": 540,
    "ContactId": 630,
    "ContactName": "O'Connell LLC",
    "Retired": 564,
    "Rank": 486,
    "ActiveInterests": 730,
    "ContactDepartment": "",
    "ContactCountryId": 939,
    "ContactOrgNr": "443654",
    "FaxPhone": "150-411-8847 x2030",
    "MobilePhone": "1-401-244-4100 x0517",
    "ContactPhone": "1-423-258-5212 x0087",
    "AssociateName": "Littel, Conn and Lowe",
    "AssociateId": 780,
    "UsePersonAddress": true,
    "ContactFax": "et",
    "Kanafname": "expedita",
    "Kanalname": "rerum",
    "Post1": "et",
    "Post2": "quia",
    "Post3": "omnis",
    "EmailName": "reilly@abshire.co.uk",
    "ContactFullName": "Queenie Trantow",
    "ActiveErpLinks": 803,
    "TicketPriorityId": 20,
    "SupportLanguageId": 3,
    "SupportAssociateId": 411,
    "CategoryName": "VIP Customer"
  },
  "SecondaryPersons": [
    {
      "Position": "quos",
      "PersonId": 362,
      "Mrmrs": "iste",
      "Firstname": "Valerie",
      "Lastname": "Bins",
      "MiddleName": "Legros-Rogahn",
      "Title": "quia",
      "Description": "Robust bifurcated time-frame",
      "Email": "loy@ziemann.name",
      "FullName": "Kamryn Treutel PhD",
      "DirectPhone": "(183)170-2610",
      "FormalName": "Schulist, Dach and Kuphal",
      "CountryId": 354,
      "ContactId": 599,
      "ContactName": "Murphy Group",
      "Retired": 894,
      "Rank": 930,
      "ActiveInterests": 462,
      "ContactDepartment": "",
      "ContactCountryId": 256,
      "ContactOrgNr": "919437",
      "FaxPhone": "1-042-726-7831",
      "MobilePhone": "814.473.8071 x830",
      "ContactPhone": "1-081-651-2661 x27241",
      "AssociateName": "Mann Group",
      "AssociateId": 452,
      "UsePersonAddress": false,
      "ContactFax": "quidem",
      "Kanafname": "atque",
      "Kanalname": "aut",
      "Post1": "aut",
      "Post2": "voluptatem",
      "Post3": "aspernatur",
      "EmailName": "sydnie@predovic.us",
      "ContactFullName": "Aiden Greenholt",
      "ActiveErpLinks": 130,
      "TicketPriorityId": 439,
      "SupportLanguageId": 378,
      "SupportAssociateId": 208,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 976,
  "ConnectId": 73,
  "ReadStatus": "Green",
  "TimeToReply": 961,
  "RealTimeToReply": 545,
  "TimeToClose": 608,
  "RealTimeToClose": 46,
  "TimeSpentInternally": 917,
  "TimeSpentExternally": 600,
  "TimeSpentQueue": 172,
  "RealTimeSpentInternally": 465,
  "RealTimeSpentExternally": 622,
  "RealTimeSpentQueue": 651,
  "HasAttachment": true,
  "NumReplies": 607,
  "NumMessages": 771,
  "FromAddress": "error",
  "Messages": [
    {
      "TicketMessageId": 573,
      "CreatedAt": "2020-06-03T09:40:59.8090641+02:00",
      "Slevel": "External",
      "Important": false
    },
    {
      "TicketMessageId": 573,
      "CreatedAt": "2020-06-03T09:40:59.8090641+02:00",
      "Slevel": "External",
      "Important": false
    }
  ],
  "Tags": [
    {
      "Id": 371,
      "Name": "Kemmer LLC",
      "ToolTip": "Odit et quia."
    },
    {
      "Id": 371,
      "Name": "Kemmer LLC",
      "ToolTip": "Odit et quia."
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "velit",
    "ExtraFields2": "minima"
  },
  "CustomFields": {
    "CustomFields1": "itaque",
    "CustomFields2": "nulla"
  }
}
```

```http_
HTTP/1.1 200 TicketEntity updated.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 230,
  "Title": "tempora",
  "CreatedAt": "1997-10-20T09:40:59.8130638+02:00",
  "LastChanged": "1997-08-22T09:40:59.8130638+02:00",
  "ReadByOwner": "2015-11-27T09:40:59.8130638+01:00",
  "ReadByCustomer": "1999-02-25T09:40:59.8130638+01:00",
  "FirstReadByUser": "2004-11-05T09:40:59.8130638+01:00",
  "Activate": "2004-04-03T09:40:59.8130638+02:00",
  "ClosedAt": "2002-03-13T09:40:59.8130638+01:00",
  "RepliedAt": "2010-11-02T09:40:59.8130638+01:00",
  "AlertTimeout": "2013-01-16T09:40:59.8130638+01:00",
  "Deadline": "2020-11-20T09:40:59.8130638+01:00",
  "CreatedBy": {
    "AssociateId": 885,
    "Name": "Beier, Waters and O'Kon",
    "PersonId": 977,
    "Rank": 325,
    "Tooltip": "aperiam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 284,
    "FullName": "Hailee Jones",
    "FormalName": "Mayert-Terry",
    "Deleted": false,
    "EjUserId": 509,
    "UserName": "Koepp, Weber and Dietrich",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 862
      }
    }
  },
  "Author": "tempore",
  "OwnedBy": {
    "AssociateId": 573,
    "Name": "Jacobson-Considine",
    "PersonId": 600,
    "Rank": 95,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 460,
    "FullName": "Dayton Monahan",
    "FormalName": "Nienow Group",
    "Deleted": false,
    "EjUserId": 455,
    "UserName": "Kilback, Auer and Roberts",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 550
      }
    }
  },
  "Category": {
    "TicketCategoryId": 950,
    "ParentId": 609,
    "Name": "Ledner-Beier",
    "Fullname": "natus",
    "CategoryMaster": 436,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Champlin, Schowalter and Harber",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 402,
    "ReplyTemplate": 521,
    "NotificationEmail": "monte_ritchie@littleschuster.com",
    "ExtraFields": {
      "ExtraFields1": "enim",
      "ExtraFields2": "eum"
    },
    "CustomFields": {
      "CustomFields1": "provident",
      "CustomFields2": "ab"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 952
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 661,
    "Name": "Dare, Reynolds and Marvin",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 646,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 600,
    "MonStart": "2002-03-18T09:40:59.8140641+01:00",
    "MonStop": "2015-07-09T09:40:59.8140641+02:00",
    "TueStart": "2019-11-09T09:40:59.8140641+01:00",
    "TueStop": "2020-09-14T09:40:59.8140641+02:00",
    "WedStart": "2001-12-19T09:40:59.8140641+01:00",
    "WedStop": "1996-02-11T09:40:59.8140641+01:00",
    "ThuStart": "2020-07-18T09:40:59.8140641+02:00",
    "ThuStop": "2014-06-05T09:40:59.8140641+02:00",
    "FriStart": "1999-11-16T09:40:59.8140641+01:00",
    "FriStop": "2003-11-18T09:40:59.8140641+01:00",
    "SatStart": "2014-04-14T09:40:59.8140641+02:00",
    "SatStop": "2011-09-17T09:40:59.8140641+02:00",
    "SunStart": "2012-09-07T09:40:59.8140641+02:00",
    "SunStop": "2000-06-18T09:40:59.8140641+02:00",
    "NonDates": [
      "quo",
      "ducimus"
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 679
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 982,
    "Name": "Hilll-Kunze",
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
        "FieldLength": 219
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "delectus",
    "PersonId": 524,
    "Mrmrs": "deleniti",
    "Firstname": "Lorenzo",
    "Lastname": "Keebler",
    "MiddleName": "Bradtke-Hammes",
    "Title": "qui",
    "Description": "Team-oriented dedicated ability",
    "Email": "simone.bergstrom@auerdouglas.co.uk",
    "FullName": "Estrella Johns",
    "DirectPhone": "561.580.3263",
    "FormalName": "Nitzsche LLC",
    "CountryId": 619,
    "ContactId": 282,
    "ContactName": "Okuneva, Ruecker and Fahey",
    "Retired": 615,
    "Rank": 397,
    "ActiveInterests": 596,
    "ContactDepartment": "",
    "ContactCountryId": 595,
    "ContactOrgNr": "858320",
    "FaxPhone": "(368)880-2768 x6604",
    "MobilePhone": "216-358-6236",
    "ContactPhone": "1-780-140-5304",
    "AssociateName": "Johnston, Green and McClure",
    "AssociateId": 181,
    "UsePersonAddress": false,
    "ContactFax": "a",
    "Kanafname": "repellat",
    "Kanalname": "magni",
    "Post1": "laboriosam",
    "Post2": "et",
    "Post3": "optio",
    "EmailName": "lea.kuhic@schmitt.us",
    "ContactFullName": "Kara Hyatt",
    "ActiveErpLinks": 569,
    "TicketPriorityId": 134,
    "SupportLanguageId": 623,
    "SupportAssociateId": 421,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 400
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "ducimus",
      "PersonId": 94,
      "Mrmrs": "laboriosam",
      "Firstname": "Hilma",
      "Lastname": "Sanford",
      "MiddleName": "Pacocha, McKenzie and Reichel",
      "Title": "est",
      "Description": "Advanced user-facing open architecture",
      "Email": "antwon@eichmannkub.us",
      "FullName": "Billie Armstrong",
      "DirectPhone": "375.688.4422 x530",
      "FormalName": "Keebler Group",
      "CountryId": 586,
      "ContactId": 690,
      "ContactName": "Nienow Group",
      "Retired": 557,
      "Rank": 200,
      "ActiveInterests": 935,
      "ContactDepartment": "",
      "ContactCountryId": 419,
      "ContactOrgNr": "621614",
      "FaxPhone": "1-448-170-8386 x73166",
      "MobilePhone": "082-756-1137",
      "ContactPhone": "(656)478-5666 x22044",
      "AssociateName": "Zieme-Eichmann",
      "AssociateId": 226,
      "UsePersonAddress": false,
      "ContactFax": "excepturi",
      "Kanafname": "repudiandae",
      "Kanalname": "quod",
      "Post1": "ullam",
      "Post2": "laboriosam",
      "Post3": "temporibus",
      "EmailName": "carmen.rogahn@effertz.uk",
      "ContactFullName": "Amie Yost",
      "ActiveErpLinks": 374,
      "TicketPriorityId": 787,
      "SupportLanguageId": 648,
      "SupportAssociateId": 265,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "embrace one-to-one e-business"
          },
          "FieldType": "System.Int32",
          "FieldLength": 210
        }
      }
    }
  ],
  "AlertLevel": 71,
  "ConnectId": 158,
  "ReadStatus": "Green",
  "TimeToReply": 842,
  "RealTimeToReply": 35,
  "TimeToClose": 146,
  "RealTimeToClose": 120,
  "TimeSpentInternally": 296,
  "TimeSpentExternally": 924,
  "TimeSpentQueue": 363,
  "RealTimeSpentInternally": 813,
  "RealTimeSpentExternally": 471,
  "RealTimeSpentQueue": 357,
  "HasAttachment": false,
  "NumReplies": 285,
  "NumMessages": 756,
  "FromAddress": "repellendus",
  "Messages": [
    {
      "TicketMessageId": 315,
      "CreatedAt": "2001-05-28T09:40:59.8170653+02:00",
      "Slevel": "External",
      "Important": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 802
        }
      }
    },
    {
      "TicketMessageId": 315,
      "CreatedAt": "2001-05-28T09:40:59.8170653+02:00",
      "Slevel": "External",
      "Important": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 802
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 480,
      "Name": "Dickens-Pacocha",
      "ToolTip": "A harum.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "evolve value-added portals"
          },
          "FieldType": "System.Int32",
          "FieldLength": 758
        }
      }
    },
    {
      "Id": 480,
      "Name": "Dickens-Pacocha",
      "ToolTip": "A harum.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "evolve value-added portals"
          },
          "FieldType": "System.Int32",
          "FieldLength": 758
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "quaerat",
    "ExtraFields2": "fuga"
  },
  "CustomFields": {
    "CustomFields1": "ipsam",
    "CustomFields2": "eum"
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
      "FieldLength": 431
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```