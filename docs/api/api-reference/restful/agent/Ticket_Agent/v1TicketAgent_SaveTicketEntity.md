---
title: SaveTicketEntity
id: v1TicketAgent_SaveTicketEntity
---

# SaveTicketEntity

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

## Sample Request

```http!
POST /api/v1/Agents/Ticket/SaveTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 791,
  "Title": "nesciunt",
  "CreatedAt": "2005-02-25T14:58:05.3366297+01:00",
  "LastChanged": "1998-04-16T14:58:05.3366297+02:00",
  "ReadByOwner": "1997-10-04T14:58:05.3366297+02:00",
  "ReadByCustomer": "2019-06-22T14:58:05.3366297+02:00",
  "FirstReadByUser": "1997-04-09T14:58:05.3366297+02:00",
  "Activate": "2012-04-04T14:58:05.3366297+02:00",
  "ClosedAt": "2005-10-23T14:58:05.3366297+02:00",
  "RepliedAt": "2005-04-13T14:58:05.3366297+02:00",
  "AlertTimeout": "2007-05-30T14:58:05.3366297+02:00",
  "Deadline": "2018-12-10T14:58:05.3366297+01:00",
  "CreatedBy": {
    "AssociateId": 992,
    "Name": "Ziemann-Hammes",
    "PersonId": 400,
    "Rank": 275,
    "Tooltip": "molestiae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 323,
    "FullName": "Lacey Fritsch",
    "FormalName": "Boyer LLC",
    "Deleted": true,
    "EjUserId": 987,
    "UserName": "Haley-Veum"
  },
  "Author": "aut",
  "OwnedBy": {
    "AssociateId": 284,
    "Name": "Renner Group",
    "PersonId": 44,
    "Rank": 160,
    "Tooltip": "aperiam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 826,
    "FullName": "Elena Ruecker",
    "FormalName": "Gutkowski-Keeling",
    "Deleted": false,
    "EjUserId": 768,
    "UserName": "Buckridge-Swaniawski"
  },
  "Category": {
    "TicketCategoryId": 806,
    "ParentId": 17,
    "Name": "Rippin-Wyman",
    "Fullname": "nostrum",
    "CategoryMaster": 595,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Rolfson LLC",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 670,
    "ReplyTemplate": 296,
    "NotificationEmail": "nyasia_graham@rueckertorp.info",
    "ExtraFields": {
      "ExtraFields1": "aut",
      "ExtraFields2": "omnis"
    },
    "CustomFields": {
      "CustomFields1": "unde",
      "CustomFields2": "quia"
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 480,
    "Name": "Christiansen Inc and Sons",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 595,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 835,
    "MonStart": "2020-08-05T14:58:05.3376284+02:00",
    "MonStop": "2000-09-21T14:58:05.3376284+02:00",
    "TueStart": "2010-08-16T14:58:05.3376284+02:00",
    "TueStop": "1996-06-06T14:58:05.3376284+02:00",
    "WedStart": "2003-09-25T14:58:05.3376284+02:00",
    "WedStop": "2012-10-09T14:58:05.3376284+02:00",
    "ThuStart": "2005-08-19T14:58:05.3376284+02:00",
    "ThuStop": "2017-09-06T14:58:05.3376284+02:00",
    "FriStart": "2014-10-06T14:58:05.3376284+02:00",
    "FriStop": "2002-01-13T14:58:05.3376284+01:00",
    "SatStart": "1997-02-02T14:58:05.3376284+01:00",
    "SatStop": "2003-11-14T14:58:05.3376284+01:00",
    "SunStart": "2005-10-03T14:58:05.3376284+02:00",
    "SunStop": "2006-10-05T14:58:05.3376284+02:00",
    "NonDates": [
      "neque",
      "optio"
    ]
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 165,
    "Name": "Erdman LLC",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": true
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "asperiores",
    "PersonId": 146,
    "Mrmrs": "exercitationem",
    "Firstname": "Wanda",
    "Lastname": "Beatty",
    "MiddleName": "Schaefer, Koepp and Murazik",
    "Title": "quibusdam",
    "Description": "Profound empowering project",
    "Email": "everett@bruenbeatty.uk",
    "FullName": "Vida Kub",
    "DirectPhone": "1-157-231-5161 x00564",
    "FormalName": "Funk, Predovic and Bartell",
    "CountryId": 861,
    "ContactId": 832,
    "ContactName": "Tromp-Kautzer",
    "Retired": 129,
    "Rank": 712,
    "ActiveInterests": 378,
    "ContactDepartment": "",
    "ContactCountryId": 148,
    "ContactOrgNr": "931346",
    "FaxPhone": "136.485.1426",
    "MobilePhone": "1-163-665-1178 x50663",
    "ContactPhone": "(565)825-8718",
    "AssociateName": "Welch Group",
    "AssociateId": 582,
    "UsePersonAddress": false,
    "ContactFax": "nesciunt",
    "Kanafname": "quisquam",
    "Kanalname": "minus",
    "Post1": "facilis",
    "Post2": "recusandae",
    "Post3": "soluta",
    "EmailName": "kyra@bogan.uk",
    "ContactFullName": "Jasen Renner",
    "ActiveErpLinks": 629,
    "TicketPriorityId": 688,
    "SupportLanguageId": 613,
    "SupportAssociateId": 518,
    "CategoryName": "VIP Customer"
  },
  "SecondaryPersons": [
    {
      "Position": "mollitia",
      "PersonId": 527,
      "Mrmrs": "et",
      "Firstname": "Domingo",
      "Lastname": "Kling",
      "MiddleName": "Hudson Inc and Sons",
      "Title": "sunt",
      "Description": "Virtual multimedia framework",
      "Email": "bessie.bechtelar@wunsch.com",
      "FullName": "Rebeca Harris",
      "DirectPhone": "207-848-1813 x775",
      "FormalName": "Klein, Stokes and Mann",
      "CountryId": 378,
      "ContactId": 998,
      "ContactName": "Stehr, Boyle and Schneider",
      "Retired": 620,
      "Rank": 379,
      "ActiveInterests": 637,
      "ContactDepartment": "",
      "ContactCountryId": 536,
      "ContactOrgNr": "468946",
      "FaxPhone": "017-215-0406 x5222",
      "MobilePhone": "314.754.7551",
      "ContactPhone": "(157)368-6776",
      "AssociateName": "Moen, Harber and Gorczany",
      "AssociateId": 525,
      "UsePersonAddress": false,
      "ContactFax": "asperiores",
      "Kanafname": "et",
      "Kanalname": "quia",
      "Post1": "dolore",
      "Post2": "consequatur",
      "Post3": "id",
      "EmailName": "cielo@farrellbrakus.info",
      "ContactFullName": "Ignatius Monahan",
      "ActiveErpLinks": 724,
      "TicketPriorityId": 108,
      "SupportLanguageId": 759,
      "SupportAssociateId": 484,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 395,
  "ConnectId": 486,
  "ReadStatus": "Green",
  "TimeToReply": 551,
  "RealTimeToReply": 562,
  "TimeToClose": 198,
  "RealTimeToClose": 538,
  "TimeSpentInternally": 124,
  "TimeSpentExternally": 616,
  "TimeSpentQueue": 929,
  "RealTimeSpentInternally": 571,
  "RealTimeSpentExternally": 401,
  "RealTimeSpentQueue": 264,
  "HasAttachment": false,
  "NumReplies": 868,
  "NumMessages": 600,
  "FromAddress": "earum",
  "Messages": [
    {
      "TicketMessageId": 664,
      "CreatedAt": "2004-05-24T14:58:05.3396285+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "aut",
      "PersonId": 611,
      "PersonFullName": "Joanny Torp",
      "ContactId": 84,
      "ContactName": "D'Amore Group",
      "ContactDepartment": "",
      "NumAttachments": 385,
      "EmailHeader": "roel@predovicthiel.info",
      "MessageHeaders": [
        {},
        {}
      ]
    }
  ],
  "Tags": [
    {
      "Id": 736,
      "Name": "King-Gerlach",
      "ToolTip": "Eum quo."
    },
    {
      "Id": 736,
      "Name": "King-Gerlach",
      "ToolTip": "Eum quo."
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "cupiditate",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "dignissimos",
    "CustomFields2": "rem"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 434,
  "Title": "qui",
  "CreatedAt": "2011-05-19T14:58:05.3456274+02:00",
  "LastChanged": "2002-08-03T14:58:05.3456274+02:00",
  "ReadByOwner": "1996-02-14T14:58:05.3466309+01:00",
  "ReadByCustomer": "2001-10-23T14:58:05.3466309+02:00",
  "FirstReadByUser": "2000-03-12T14:58:05.3466309+01:00",
  "Activate": "2001-04-17T14:58:05.3466309+02:00",
  "ClosedAt": "2008-08-02T14:58:05.3466309+02:00",
  "RepliedAt": "2000-01-31T14:58:05.3466309+01:00",
  "AlertTimeout": "2020-05-25T14:58:05.3466309+02:00",
  "Deadline": "2002-01-21T14:58:05.3466309+01:00",
  "CreatedBy": {
    "AssociateId": 722,
    "Name": "Lebsack-Jenkins",
    "PersonId": 326,
    "Rank": 514,
    "Tooltip": "suscipit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 124,
    "FullName": "Erik Bernier",
    "FormalName": "Hackett LLC",
    "Deleted": true,
    "EjUserId": 560,
    "UserName": "Schroeder, Zulauf and Simonis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "transform transparent web services"
        },
        "FieldType": "System.Int32",
        "FieldLength": 488
      }
    }
  },
  "Author": "animi",
  "OwnedBy": {
    "AssociateId": 860,
    "Name": "Ward LLC",
    "PersonId": 97,
    "Rank": 970,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 769,
    "FullName": "Kelley Schultz",
    "FormalName": "Beatty LLC",
    "Deleted": false,
    "EjUserId": 418,
    "UserName": "Lakin Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 890
      }
    }
  },
  "Category": {
    "TicketCategoryId": 784,
    "ParentId": 373,
    "Name": "Kuvalis LLC",
    "Fullname": "pariatur",
    "CategoryMaster": 505,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Connelly LLC",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 692,
    "ReplyTemplate": 468,
    "NotificationEmail": "alva@gleichneryundt.co.uk",
    "ExtraFields": {
      "ExtraFields1": "consectetur",
      "ExtraFields2": "possimus"
    },
    "CustomFields": {
      "CustomFields1": "vero",
      "CustomFields2": "eveniet"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 315
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 246,
    "Name": "Connelly-Baumbach",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 293,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 821,
    "MonStart": "2009-04-04T14:58:05.3476278+02:00",
    "MonStop": "1999-05-07T14:58:05.3476278+02:00",
    "TueStart": "2016-06-07T14:58:05.3476278+02:00",
    "TueStop": "2017-02-24T14:58:05.3476278+01:00",
    "WedStart": "2004-09-20T14:58:05.3476278+02:00",
    "WedStop": "1999-12-16T14:58:05.3476278+01:00",
    "ThuStart": "2013-01-14T14:58:05.3476278+01:00",
    "ThuStop": "2015-04-04T14:58:05.3476278+02:00",
    "FriStart": "2013-01-23T14:58:05.3476278+01:00",
    "FriStop": "2008-02-21T14:58:05.3476278+01:00",
    "SatStart": "1995-04-06T14:58:05.3476278+02:00",
    "SatStop": "2006-08-26T14:58:05.3476278+02:00",
    "SunStart": "2004-01-06T14:58:05.3476278+01:00",
    "SunStop": "1998-08-07T14:58:05.3476278+02:00",
    "NonDates": [
      "nesciunt",
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
        "FieldLength": 882
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 2,
    "Name": "Effertz, Predovic and McKenzie",
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
        "FieldLength": 229
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "quae",
    "PersonId": 53,
    "Mrmrs": "veniam",
    "Firstname": "Adell",
    "Lastname": "Glover",
    "MiddleName": "Block-Beahan",
    "Title": "ducimus",
    "Description": "Re-engineered real-time knowledge user",
    "Email": "ellsworth_hilpert@schoendicki.com",
    "FullName": "Austin Reinger",
    "DirectPhone": "(583)755-5376",
    "FormalName": "Rohan-Kemmer",
    "CountryId": 610,
    "ContactId": 364,
    "ContactName": "Upton, Schmeler and Franecki",
    "Retired": 857,
    "Rank": 377,
    "ActiveInterests": 151,
    "ContactDepartment": "",
    "ContactCountryId": 252,
    "ContactOrgNr": "888538",
    "FaxPhone": "(257)535-8566 x2770",
    "MobilePhone": "688.688.4225",
    "ContactPhone": "764-015-8837 x00814",
    "AssociateName": "Nolan, Friesen and Ondricka",
    "AssociateId": 993,
    "UsePersonAddress": true,
    "ContactFax": "doloribus",
    "Kanafname": "necessitatibus",
    "Kanalname": "qui",
    "Post1": "eligendi",
    "Post2": "ipsam",
    "Post3": "eaque",
    "EmailName": "marlen.doyle@langondricka.info",
    "ContactFullName": "Maynard McGlynn",
    "ActiveErpLinks": 630,
    "TicketPriorityId": 896,
    "SupportLanguageId": 976,
    "SupportAssociateId": 578,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 22
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "et",
      "PersonId": 434,
      "Mrmrs": "est",
      "Firstname": "Wilmer",
      "Lastname": "Dach",
      "MiddleName": "Christiansen, Effertz and Glover",
      "Title": "atque",
      "Description": "Object-based 5th generation framework",
      "Email": "emily_yost@abbott.co.uk",
      "FullName": "Roselyn Zieme",
      "DirectPhone": "1-726-028-3154",
      "FormalName": "Kuhic Group",
      "CountryId": 537,
      "ContactId": 657,
      "ContactName": "Corwin-Breitenberg",
      "Retired": 125,
      "Rank": 851,
      "ActiveInterests": 602,
      "ContactDepartment": "",
      "ContactCountryId": 102,
      "ContactOrgNr": "1091371",
      "FaxPhone": "(548)021-1428",
      "MobilePhone": "415.528.7440 x448",
      "ContactPhone": "1-261-671-3102 x82510",
      "AssociateName": "Dicki Inc and Sons",
      "AssociateId": 755,
      "UsePersonAddress": true,
      "ContactFax": "sint",
      "Kanafname": "modi",
      "Kanalname": "qui",
      "Post1": "facere",
      "Post2": "eius",
      "Post3": "accusantium",
      "EmailName": "berenice.jenkins@rippin.biz",
      "ContactFullName": "Emery Daniel II",
      "ActiveErpLinks": 700,
      "TicketPriorityId": 975,
      "SupportLanguageId": 364,
      "SupportAssociateId": 698,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 187
        }
      }
    }
  ],
  "AlertLevel": 716,
  "ConnectId": 935,
  "ReadStatus": "Green",
  "TimeToReply": 381,
  "RealTimeToReply": 204,
  "TimeToClose": 924,
  "RealTimeToClose": 378,
  "TimeSpentInternally": 666,
  "TimeSpentExternally": 954,
  "TimeSpentQueue": 646,
  "RealTimeSpentInternally": 893,
  "RealTimeSpentExternally": 794,
  "RealTimeSpentQueue": 102,
  "HasAttachment": false,
  "NumReplies": 304,
  "NumMessages": 454,
  "FromAddress": "tempore",
  "Messages": [
    {
      "TicketMessageId": 289,
      "CreatedAt": "2009-03-28T14:58:05.3496274+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "enim",
      "PersonId": 745,
      "PersonFullName": "Julian Hyatt DDS",
      "ContactId": 561,
      "ContactName": "Collier LLC",
      "ContactDepartment": "",
      "NumAttachments": 312,
      "EmailHeader": "rashawn@ebertbraun.us",
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
          "FieldLength": 425
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 384,
      "Name": "Schinner Group",
      "ToolTip": "Sunt voluptas eveniet esse aliquid expedita consequuntur.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 398
        }
      }
    },
    {
      "Id": 384,
      "Name": "Schinner Group",
      "ToolTip": "Sunt voluptas eveniet esse aliquid expedita consequuntur.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 398
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "dignissimos",
    "CustomFields2": "deserunt"
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
      "FieldLength": 95
    }
  }
}
```