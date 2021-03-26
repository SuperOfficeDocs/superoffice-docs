---
title: POST Agents/Ticket/SaveTicketEntity
id: v1TicketAgent_SaveTicketEntity
---

# POST Agents/Ticket/SaveTicketEntity

```http
POST /api/v1/Agents/Ticket/SaveTicketEntity
```

Updates the existing TicketEntity or creates a new TicketEntity if the id parameter is empty








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
POST /api/v1/Agents/Ticket/SaveTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 4,
  "Title": "harum",
  "CreatedAt": "2003-05-23T16:48:30.7749355+02:00",
  "LastChanged": "1994-02-07T16:48:30.7749355+01:00",
  "ReadByOwner": "2008-06-28T16:48:30.7749355+02:00",
  "ReadByCustomer": "2003-05-16T16:48:30.7749355+02:00",
  "FirstReadByUser": "2009-08-16T16:48:30.7749355+02:00",
  "Activate": "2017-08-23T16:48:30.7749355+02:00",
  "ClosedAt": "2008-11-05T16:48:30.7749355+01:00",
  "RepliedAt": "2002-11-16T16:48:30.7749355+01:00",
  "AlertTimeout": "2004-11-27T16:48:30.7749355+01:00",
  "Deadline": "1999-04-12T16:48:30.7749355+02:00",
  "CreatedBy": {
    "AssociateId": 551,
    "Name": "Robel, Krajcik and D'Amore",
    "PersonId": 283,
    "Rank": 33,
    "Tooltip": "quod",
    "Type": "AnonymousAssociate",
    "GroupIdx": 778,
    "FullName": "Samson Donnelly IV",
    "FormalName": "Wisozk, Weissnat and Kshlerin",
    "Deleted": false,
    "EjUserId": 433,
    "UserName": "Reichert LLC"
  },
  "Author": "totam",
  "OwnedBy": {
    "AssociateId": 608,
    "Name": "Walter-Zboncak",
    "PersonId": 245,
    "Rank": 673,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 546,
    "FullName": "Efrain Davis",
    "FormalName": "Pacocha Inc and Sons",
    "Deleted": true,
    "EjUserId": 474,
    "UserName": "Johnston, Casper and Gleichner"
  },
  "Category": {
    "TicketCategoryId": 118,
    "ParentId": 537,
    "Name": "Lakin Inc and Sons",
    "Fullname": "quis",
    "CategoryMaster": 349,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Prosacco, Padberg and Morar",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 669,
    "ReplyTemplate": 107,
    "NotificationEmail": "xander_zboncak@parisianruecker.us",
    "ExtraFields": {
      "ExtraFields1": "quia",
      "ExtraFields2": "magnam"
    },
    "CustomFields": {
      "CustomFields1": "non",
      "CustomFields2": "laboriosam"
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 392,
    "Name": "Reynolds, Kub and Wiegand",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 555,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 509,
    "MonStart": "1999-03-13T16:48:30.7759346+01:00",
    "MonStop": "2000-08-20T16:48:30.7759346+02:00",
    "TueStart": "1997-11-10T16:48:30.7759346+01:00",
    "TueStop": "2017-06-29T16:48:30.7759346+02:00",
    "WedStart": "2005-02-13T16:48:30.7759346+01:00",
    "WedStop": "2017-10-21T16:48:30.7759346+02:00",
    "ThuStart": "2017-10-21T16:48:30.7759346+02:00",
    "ThuStop": "2008-01-25T16:48:30.7759346+01:00",
    "FriStart": "2000-10-06T16:48:30.7759346+02:00",
    "FriStop": "1995-11-02T16:48:30.7759346+01:00",
    "SatStart": "2007-09-23T16:48:30.7759346+02:00",
    "SatStop": "2016-10-21T16:48:30.7759346+02:00",
    "SunStart": "2010-02-15T16:48:30.7759346+01:00",
    "SunStop": "2000-12-03T16:48:30.7759346+01:00",
    "NonDates": [
      "harum",
      "laboriosam"
    ]
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 844,
    "Name": "Watsica, Mosciski and Mosciski",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": true
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "quis",
    "PersonId": 707,
    "Mrmrs": "eius",
    "Firstname": "Hosea",
    "Lastname": "Kiehn",
    "MiddleName": "Hermiston, Durgan and Rohan",
    "Title": "ut",
    "Description": "Future-proofed zero defect knowledge base",
    "Email": "fatima@schroeder.co.uk",
    "FullName": "Napoleon Cormier V",
    "DirectPhone": "(125)060-2413 x88242",
    "FormalName": "McGlynn Inc and Sons",
    "CountryId": 579,
    "ContactId": 577,
    "ContactName": "Beier, Crooks and Christiansen",
    "Retired": 751,
    "Rank": 627,
    "ActiveInterests": 201,
    "ContactDepartment": "",
    "ContactCountryId": 171,
    "ContactOrgNr": "906201",
    "FaxPhone": "(757)146-4204",
    "MobilePhone": "1-137-434-8555",
    "ContactPhone": "800-420-7726",
    "AssociateName": "Swift, Cartwright and Reilly",
    "AssociateId": 613,
    "UsePersonAddress": true,
    "ContactFax": "repudiandae",
    "Kanafname": "ut",
    "Kanalname": "nihil",
    "Post1": "eaque",
    "Post2": "a",
    "Post3": "omnis",
    "EmailName": "constantin_schulist@spinkaoconner.info",
    "ContactFullName": "Mr. Fabian Jones",
    "ActiveErpLinks": 396,
    "TicketPriorityId": 270,
    "SupportLanguageId": 234,
    "SupportAssociateId": 609,
    "CategoryName": "VIP Customer"
  },
  "SecondaryPersons": [
    {
      "Position": "provident",
      "PersonId": 673,
      "Mrmrs": "dolorem",
      "Firstname": "Gilda",
      "Lastname": "Hessel",
      "MiddleName": "West, Fadel and Legros",
      "Title": "aliquid",
      "Description": "Assimilated scalable framework",
      "Email": "anya_bogan@brekke.co.uk",
      "FullName": "Belle McCullough",
      "DirectPhone": "281.117.1228 x471",
      "FormalName": "Goodwin, Hagenes and Corwin",
      "CountryId": 422,
      "ContactId": 13,
      "ContactName": "Wolff LLC",
      "Retired": 323,
      "Rank": 316,
      "ActiveInterests": 148,
      "ContactDepartment": "",
      "ContactCountryId": 93,
      "ContactOrgNr": "550166",
      "FaxPhone": "1-827-162-2221 x5051",
      "MobilePhone": "(262)088-3035 x658",
      "ContactPhone": "360-858-1001",
      "AssociateName": "Yost Group",
      "AssociateId": 189,
      "UsePersonAddress": false,
      "ContactFax": "saepe",
      "Kanafname": "sit",
      "Kanalname": "et",
      "Post1": "at",
      "Post2": "molestiae",
      "Post3": "error",
      "EmailName": "hardy@williamsonnikolaus.uk",
      "ContactFullName": "Rylee Kilback",
      "ActiveErpLinks": 571,
      "TicketPriorityId": 191,
      "SupportLanguageId": 31,
      "SupportAssociateId": 187,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 266,
  "ConnectId": 178,
  "ReadStatus": "Green",
  "TimeToReply": 88,
  "RealTimeToReply": 97,
  "TimeToClose": 980,
  "RealTimeToClose": 79,
  "TimeSpentInternally": 236,
  "TimeSpentExternally": 279,
  "TimeSpentQueue": 760,
  "RealTimeSpentInternally": 698,
  "RealTimeSpentExternally": 916,
  "RealTimeSpentQueue": 449,
  "HasAttachment": true,
  "NumReplies": 141,
  "NumMessages": 342,
  "FromAddress": "voluptatibus",
  "Messages": [
    {
      "TicketMessageId": 465,
      "CreatedAt": "1999-03-12T16:48:30.7799354+01:00",
      "Slevel": "External",
      "Important": true
    },
    {
      "TicketMessageId": 465,
      "CreatedAt": "1999-03-12T16:48:30.7799354+01:00",
      "Slevel": "External",
      "Important": true
    }
  ],
  "Tags": [
    {
      "Id": 654,
      "Name": "Dietrich-Hettinger",
      "ToolTip": "Culpa voluptas consequatur eaque nihil."
    },
    {
      "Id": 654,
      "Name": "Dietrich-Hettinger",
      "ToolTip": "Culpa voluptas consequatur eaque nihil."
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "repellat",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "qui"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 466,
  "Title": "quae",
  "CreatedAt": "2003-02-14T16:48:30.7849353+01:00",
  "LastChanged": "2013-10-03T16:48:30.7849353+02:00",
  "ReadByOwner": "2005-12-14T16:48:30.7849353+01:00",
  "ReadByCustomer": "2017-07-07T16:48:30.7849353+02:00",
  "FirstReadByUser": "2009-03-19T16:48:30.7849353+01:00",
  "Activate": "1998-10-06T16:48:30.7849353+02:00",
  "ClosedAt": "1998-11-28T16:48:30.7849353+01:00",
  "RepliedAt": "2020-12-24T16:48:30.7849353+01:00",
  "AlertTimeout": "2018-06-09T16:48:30.7849353+02:00",
  "Deadline": "2004-08-17T16:48:30.7849353+02:00",
  "CreatedBy": {
    "AssociateId": 13,
    "Name": "Shields, Goyette and Hand",
    "PersonId": 776,
    "Rank": 314,
    "Tooltip": "voluptatibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 271,
    "FullName": "Sonny O'Conner",
    "FormalName": "Feeney-Jewess",
    "Deleted": false,
    "EjUserId": 383,
    "UserName": "Bartell Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "integrate out-of-the-box markets"
        },
        "FieldType": "System.Int32",
        "FieldLength": 627
      }
    }
  },
  "Author": "magni",
  "OwnedBy": {
    "AssociateId": 465,
    "Name": "Douglas Group",
    "PersonId": 22,
    "Rank": 389,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 635,
    "FullName": "Jaylin Cole DDS",
    "FormalName": "Hirthe, Ullrich and Osinski",
    "Deleted": true,
    "EjUserId": 405,
    "UserName": "Murazik Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 699
      }
    }
  },
  "Category": {
    "TicketCategoryId": 240,
    "ParentId": 577,
    "Name": "Casper, Kessler and Carter",
    "Fullname": "aut",
    "CategoryMaster": 692,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Stamm-Eichmann",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 669,
    "ReplyTemplate": 836,
    "NotificationEmail": "lonnie.casper@daniellangworth.uk",
    "ExtraFields": {
      "ExtraFields1": "et",
      "ExtraFields2": "magnam"
    },
    "CustomFields": {
      "CustomFields1": "repellat",
      "CustomFields2": "est"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 511
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 366,
    "Name": "Witting-Farrell",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 230,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 378,
    "MonStart": "2005-10-03T16:48:30.7859383+02:00",
    "MonStop": "2011-10-23T16:48:30.7859383+02:00",
    "TueStart": "2018-02-11T16:48:30.7859383+01:00",
    "TueStop": "2015-08-04T16:48:30.7859383+02:00",
    "WedStart": "2007-01-04T16:48:30.7859383+01:00",
    "WedStop": "2004-08-07T16:48:30.7859383+02:00",
    "ThuStart": "2020-08-25T16:48:30.7859383+02:00",
    "ThuStop": "2003-03-22T16:48:30.7859383+01:00",
    "FriStart": "1999-11-16T16:48:30.7859383+01:00",
    "FriStop": "1994-08-27T16:48:30.7859383+02:00",
    "SatStart": "2009-02-28T16:48:30.7859383+01:00",
    "SatStop": "2019-04-19T16:48:30.7859383+02:00",
    "SunStart": "2002-01-11T16:48:30.7859383+01:00",
    "SunStop": "2004-04-01T16:48:30.7859383+02:00",
    "NonDates": [
      "magnam",
      "omnis"
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 205
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 897,
    "Name": "Wisoky, Grant and Berge",
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
        "FieldType": "System.String",
        "FieldLength": 259
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "labore",
    "PersonId": 445,
    "Mrmrs": "minus",
    "Firstname": "Meghan",
    "Lastname": "O'Connell",
    "MiddleName": "Schaefer, Monahan and Kuvalis",
    "Title": "sed",
    "Description": "Upgradable homogeneous budgetary management",
    "Email": "magnus.hessel@emmerich.us",
    "FullName": "German Kreiger",
    "DirectPhone": "210-373-8223",
    "FormalName": "Lueilwitz-Homenick",
    "CountryId": 108,
    "ContactId": 78,
    "ContactName": "Pagac-Stokes",
    "Retired": 336,
    "Rank": 818,
    "ActiveInterests": 791,
    "ContactDepartment": "architect bleeding-edge e-business",
    "ContactCountryId": 385,
    "ContactOrgNr": "1352956",
    "FaxPhone": "(562)184-3323 x45762",
    "MobilePhone": "(751)305-0052 x1854",
    "ContactPhone": "613-651-3355 x034",
    "AssociateName": "Fay, Wintheiser and Johns",
    "AssociateId": 909,
    "UsePersonAddress": false,
    "ContactFax": "aut",
    "Kanafname": "minima",
    "Kanalname": "earum",
    "Post1": "enim",
    "Post2": "quo",
    "Post3": "praesentium",
    "EmailName": "orville_runolfsdottir@hyattbeahan.biz",
    "ContactFullName": "Heidi Crist",
    "ActiveErpLinks": 470,
    "TicketPriorityId": 792,
    "SupportLanguageId": 51,
    "SupportAssociateId": 209,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 285
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "inventore",
      "PersonId": 829,
      "Mrmrs": "dolorum",
      "Firstname": "Demetris",
      "Lastname": "Treutel",
      "MiddleName": "Renner-Tromp",
      "Title": "aut",
      "Description": "Realigned executive collaboration",
      "Email": "macy@bartolettischuster.ca",
      "FullName": "Cassie Hamill",
      "DirectPhone": "(504)660-0034 x3833",
      "FormalName": "Lang-Sanford",
      "CountryId": 319,
      "ContactId": 843,
      "ContactName": "Leuschke-Kiehn",
      "Retired": 105,
      "Rank": 600,
      "ActiveInterests": 814,
      "ContactDepartment": "",
      "ContactCountryId": 120,
      "ContactOrgNr": "828469",
      "FaxPhone": "1-384-681-3787 x8727",
      "MobilePhone": "221.427.0261 x1888",
      "ContactPhone": "874.614.4632",
      "AssociateName": "Vandervort Inc and Sons",
      "AssociateId": 988,
      "UsePersonAddress": false,
      "ContactFax": "neque",
      "Kanafname": "consequatur",
      "Kanalname": "corporis",
      "Post1": "optio",
      "Post2": "molestiae",
      "Post3": "error",
      "EmailName": "kolby_funk@walkerschultz.name",
      "ContactFullName": "Mrs. Khalid Ritchie",
      "ActiveErpLinks": 278,
      "TicketPriorityId": 795,
      "SupportLanguageId": 557,
      "SupportAssociateId": 807,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 733
        }
      }
    }
  ],
  "AlertLevel": 340,
  "ConnectId": 97,
  "ReadStatus": "Green",
  "TimeToReply": 48,
  "RealTimeToReply": 699,
  "TimeToClose": 82,
  "RealTimeToClose": 393,
  "TimeSpentInternally": 877,
  "TimeSpentExternally": 983,
  "TimeSpentQueue": 103,
  "RealTimeSpentInternally": 164,
  "RealTimeSpentExternally": 789,
  "RealTimeSpentQueue": 773,
  "HasAttachment": false,
  "NumReplies": 723,
  "NumMessages": 117,
  "FromAddress": "inventore",
  "Messages": [
    {
      "TicketMessageId": 586,
      "CreatedAt": "1994-03-19T16:48:30.7889348+01:00",
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
          "FieldLength": 513
        }
      }
    },
    {
      "TicketMessageId": 586,
      "CreatedAt": "1994-03-19T16:48:30.7889348+01:00",
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
          "FieldLength": 513
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 535,
      "Name": "Rohan, Connelly and Kuhn",
      "ToolTip": "Ipsa laborum.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 718
        }
      }
    },
    {
      "Id": 535,
      "Name": "Rohan, Connelly and Kuhn",
      "ToolTip": "Ipsa laborum.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 718
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "iusto",
    "ExtraFields2": "earum"
  },
  "CustomFields": {
    "CustomFields1": "asperiores",
    "CustomFields2": "repellendus"
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
      "FieldLength": 147
    }
  }
}
```