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
PUT /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketId": 843,
  "Title": "incidunt",
  "CreatedAt": "2017-09-12T18:25:51.2009397+02:00",
  "LastChanged": "1995-10-12T18:25:51.2009397+02:00",
  "ReadByOwner": "1996-11-12T18:25:51.2009397+01:00",
  "ReadByCustomer": "2007-01-06T18:25:51.2009397+01:00",
  "FirstReadByUser": "2018-05-23T18:25:51.2009397+02:00",
  "Activate": "2002-02-27T18:25:51.2009397+01:00",
  "ClosedAt": "2016-04-25T18:25:51.2009397+02:00",
  "RepliedAt": "2004-04-20T18:25:51.2009397+02:00",
  "AlertTimeout": "2013-02-28T18:25:51.2009397+01:00",
  "Deadline": "1996-10-25T18:25:51.2009397+02:00",
  "CreatedBy": {
    "AssociateId": 67,
    "Name": "Schiller-Pollich",
    "PersonId": 693,
    "Rank": 276,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 598,
    "FullName": "Kariane Crist",
    "FormalName": "O'Conner, Davis and Brakus",
    "Deleted": true,
    "EjUserId": 564,
    "UserName": "Becker-Larson"
  },
  "Author": "fuga",
  "OwnedBy": {
    "AssociateId": 195,
    "Name": "Gerlach, Torphy and Roberts",
    "PersonId": 323,
    "Rank": 920,
    "Tooltip": "dolorem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 715,
    "FullName": "Maurice Smitham",
    "FormalName": "Bahringer-Terry",
    "Deleted": true,
    "EjUserId": 305,
    "UserName": "Kuvalis LLC"
  },
  "Category": {
    "TicketCategoryId": 800,
    "ParentId": 59,
    "Name": "White, Mosciski and Thiel",
    "Fullname": "possimus",
    "CategoryMaster": 864,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Kunde Group",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 528,
    "ReplyTemplate": 219,
    "NotificationEmail": "kamille.tromp@stanton.us",
    "DefaultTicketStatus": {},
    "DefaultMessageStatus": {},
    "ExtraFields": {
      "ExtraFields1": "ut",
      "ExtraFields2": "aut"
    },
    "CustomFields": {
      "CustomFields1": "voluptas",
      "CustomFields2": "qui"
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 205,
    "Name": "Schinner, Prohaska and Bauch",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 394,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 894,
    "MonStart": "2004-03-09T18:25:51.2019428+01:00",
    "MonStop": "2019-07-18T18:25:51.2019428+02:00",
    "TueStart": "2010-09-02T18:25:51.2019428+02:00",
    "TueStop": "1995-06-17T18:25:51.2019428+02:00",
    "WedStart": "2015-07-20T18:25:51.2019428+02:00",
    "WedStop": "1997-04-24T18:25:51.2019428+02:00",
    "ThuStart": "1996-11-10T18:25:51.2019428+01:00",
    "ThuStop": "2020-09-10T18:25:51.2019428+02:00",
    "FriStart": "2009-03-08T18:25:51.2019428+01:00",
    "FriStop": "2012-02-22T18:25:51.2019428+01:00",
    "SatStart": "1996-10-26T18:25:51.2019428+02:00",
    "SatStop": "2007-02-06T18:25:51.2019428+01:00",
    "SunStart": "2019-11-05T18:25:51.2019428+01:00",
    "SunStop": "1994-12-25T18:25:51.2019428+01:00",
    "NonDates": [
      "accusamus",
      "repudiandae"
    ],
    "EscalationLevels": [
      {},
      {}
    ]
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 811,
    "Name": "Renner, Langworth and Nienow",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": false,
    "IsDefault": false,
    "UsedInQueue": false
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "qui",
    "PersonId": 533,
    "Mrmrs": "incidunt",
    "Firstname": "Brenden",
    "Lastname": "Kautzer",
    "MiddleName": "Heller Inc and Sons",
    "Title": "hic",
    "Description": "Fundamental encompassing attitude",
    "Email": "esmeralda.spencer@krajcik.us",
    "FullName": "Steve Von V",
    "DirectPhone": "423.824.3202 x6138",
    "FormalName": "Blanda-Larson",
    "CountryId": 41,
    "ContactId": 401,
    "ContactName": "Lang Group",
    "Retired": 642,
    "Rank": 99,
    "ActiveInterests": 135,
    "ContactDepartment": "",
    "ContactCountryId": 479,
    "ContactOrgNr": "784330",
    "FaxPhone": "1-725-550-5357",
    "MobilePhone": "1-740-557-5716 x74325",
    "ContactPhone": "276-080-6335 x7244",
    "AssociateName": "Hintz LLC",
    "AssociateId": 260,
    "UsePersonAddress": false,
    "ContactFax": "deserunt",
    "Kanafname": "corrupti",
    "Kanalname": "saepe",
    "Post1": "quasi",
    "Post2": "accusantium",
    "Post3": "nesciunt",
    "EmailName": "violet@handlindgren.name",
    "ContactFullName": "Vivianne Romaguera",
    "ActiveErpLinks": 878,
    "TicketPriorityId": 652,
    "SupportLanguageId": 227,
    "SupportAssociateId": 11,
    "CategoryName": "VIP Customer"
  },
  "SecondaryPersons": [
    {
      "Position": "nemo",
      "PersonId": 394,
      "Mrmrs": "molestias",
      "Firstname": "Jedidiah",
      "Lastname": "Wehner",
      "MiddleName": "Lind LLC",
      "Title": "at",
      "Description": "Fully-configurable 24 hour budgetary management",
      "Email": "viviane@hilpert.uk",
      "FullName": "Else Abbott",
      "DirectPhone": "1-547-283-8146",
      "FormalName": "Feest-Hackett",
      "CountryId": 147,
      "ContactId": 538,
      "ContactName": "Armstrong, Steuber and Mueller",
      "Retired": 447,
      "Rank": 471,
      "ActiveInterests": 229,
      "ContactDepartment": "",
      "ContactCountryId": 656,
      "ContactOrgNr": "1441025",
      "FaxPhone": "(254)583-5701 x75805",
      "MobilePhone": "240-577-6446 x45351",
      "ContactPhone": "155-581-5762 x4612",
      "AssociateName": "Hettinger, Shields and Hudson",
      "AssociateId": 644,
      "UsePersonAddress": true,
      "ContactFax": "consequuntur",
      "Kanafname": "dignissimos",
      "Kanalname": "quasi",
      "Post1": "enim",
      "Post2": "delectus",
      "Post3": "laudantium",
      "EmailName": "curt@hagenesjewess.co.uk",
      "ContactFullName": "Brigitte Williamson",
      "ActiveErpLinks": 237,
      "TicketPriorityId": 980,
      "SupportLanguageId": 615,
      "SupportAssociateId": 322,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 61,
  "ConnectId": 302,
  "ReadStatus": "Green",
  "TimeToReply": 962,
  "RealTimeToReply": 193,
  "TimeToClose": 837,
  "RealTimeToClose": 11,
  "TimeSpentInternally": 919,
  "TimeSpentExternally": 29,
  "TimeSpentQueue": 62,
  "RealTimeSpentInternally": 51,
  "RealTimeSpentExternally": 616,
  "RealTimeSpentQueue": 223,
  "HasAttachment": false,
  "NumReplies": 881,
  "NumMessages": 37,
  "FromAddress": "consequatur",
  "Messages": [
    {
      "TicketMessageId": 717,
      "CreatedAt": "2000-05-14T18:25:51.2049401+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "officiis",
      "PersonId": 415,
      "PersonFullName": "Rachelle Kutch",
      "ContactId": 507,
      "ContactName": "Hayes Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 124,
      "EmailHeader": "odell_herman@christiansenkonopelski.ca",
      "MessageHeaders": [
        {},
        {}
      ]
    }
  ],
  "Tags": [
    {
      "Id": 993,
      "Name": "Heller Group",
      "ToolTip": "Modi aut aut."
    },
    {
      "Id": 993,
      "Name": "Heller Group",
      "ToolTip": "Modi aut aut."
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "incidunt",
    "ExtraFields2": "dolorem"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "vel"
  }
}
```

```http_
HTTP/1.1 200 TicketEntity updated.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 59,
  "Title": "aspernatur",
  "CreatedAt": "2020-12-29T18:25:51.2099399+01:00",
  "LastChanged": "1997-12-09T18:25:51.2099399+01:00",
  "ReadByOwner": "1997-06-26T18:25:51.2099399+02:00",
  "ReadByCustomer": "2016-06-08T18:25:51.2099399+02:00",
  "FirstReadByUser": "2003-02-24T18:25:51.2099399+01:00",
  "Activate": "2015-12-31T18:25:51.2099399+01:00",
  "ClosedAt": "2011-05-11T18:25:51.2099399+02:00",
  "RepliedAt": "2016-10-27T18:25:51.2099399+02:00",
  "AlertTimeout": "2001-06-12T18:25:51.2099399+02:00",
  "Deadline": "2009-03-25T18:25:51.2099399+01:00",
  "CreatedBy": {
    "AssociateId": 723,
    "Name": "Abbott-Rempel",
    "PersonId": 612,
    "Rank": 811,
    "Tooltip": "reprehenderit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 437,
    "FullName": "Cathy Anderson",
    "FormalName": "Jacobs, O'Conner and Kerluke",
    "Deleted": true,
    "EjUserId": 617,
    "UserName": "Spinka LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "facilitate vertical platforms"
        },
        "FieldType": "System.String",
        "FieldLength": 156
      }
    }
  },
  "Author": "deserunt",
  "OwnedBy": {
    "AssociateId": 475,
    "Name": "Ledner Group",
    "PersonId": 221,
    "Rank": 49,
    "Tooltip": "nostrum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 228,
    "FullName": "Frederik Hansen",
    "FormalName": "Stracke, Stracke and Cronin",
    "Deleted": false,
    "EjUserId": 35,
    "UserName": "Windler, Marks and Marks",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 891
      }
    }
  },
  "Category": {
    "TicketCategoryId": 371,
    "ParentId": 568,
    "Name": "Willms, Feil and Schowalter",
    "Fullname": "et",
    "CategoryMaster": 33,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Mitchell Group",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 951,
    "ReplyTemplate": 956,
    "NotificationEmail": "salma@kulasdavis.name",
    "DefaultTicketStatus": {},
    "DefaultMessageStatus": {},
    "ExtraFields": {
      "ExtraFields1": "quia",
      "ExtraFields2": "harum"
    },
    "CustomFields": {
      "CustomFields1": "similique",
      "CustomFields2": "impedit"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "optimize bricks-and-clicks systems"
        },
        "FieldType": "System.Int32",
        "FieldLength": 652
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 489,
    "Name": "Sipes, Hodkiewicz and Doyle",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 789,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 484,
    "MonStart": "1997-12-16T18:25:51.2109397+01:00",
    "MonStop": "2011-05-03T18:25:51.2109397+02:00",
    "TueStart": "2003-02-01T18:25:51.2109397+01:00",
    "TueStop": "1999-09-09T18:25:51.2109397+02:00",
    "WedStart": "2018-09-18T18:25:51.2109397+02:00",
    "WedStop": "2002-08-18T18:25:51.2109397+02:00",
    "ThuStart": "2016-02-25T18:25:51.2109397+01:00",
    "ThuStop": "2021-06-03T18:25:51.2109397+02:00",
    "FriStart": "2009-03-02T18:25:51.2109397+01:00",
    "FriStop": "2006-02-05T18:25:51.2109397+01:00",
    "SatStart": "2015-03-02T18:25:51.2109397+01:00",
    "SatStop": "2012-09-21T18:25:51.2109397+02:00",
    "SunStart": "2009-09-01T18:25:51.2109397+02:00",
    "SunStop": "1996-11-27T18:25:51.2109397+01:00",
    "NonDates": [
      "rerum",
      "corporis"
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
        "FieldLength": 664
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 780,
    "Name": "Pouros-Halvorson",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": false,
    "IsDefault": true,
    "UsedInQueue": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 340
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "sed",
    "PersonId": 856,
    "Mrmrs": "voluptas",
    "Firstname": "Fredy",
    "Lastname": "Schmitt",
    "MiddleName": "Gottlieb, Wunsch and Swift",
    "Title": "harum",
    "Description": "Upgradable executive alliance",
    "Email": "ryder@mcdermott.us",
    "FullName": "Gerson Jast",
    "DirectPhone": "432.866.0626",
    "FormalName": "Boyle, Stiedemann and Greenholt",
    "CountryId": 1000,
    "ContactId": 822,
    "ContactName": "Quitzon LLC",
    "Retired": 377,
    "Rank": 996,
    "ActiveInterests": 9,
    "ContactDepartment": "",
    "ContactCountryId": 893,
    "ContactOrgNr": "1023971",
    "FaxPhone": "601.047.3745 x21138",
    "MobilePhone": "1-510-085-0068 x0344",
    "ContactPhone": "786-250-5324 x441",
    "AssociateName": "Kunze, Gorczany and Auer",
    "AssociateId": 38,
    "UsePersonAddress": true,
    "ContactFax": "est",
    "Kanafname": "vel",
    "Kanalname": "dolorem",
    "Post1": "sequi",
    "Post2": "cupiditate",
    "Post3": "voluptatibus",
    "EmailName": "adriana@kunde.uk",
    "ContactFullName": "Mrs. Madisen Waters",
    "ActiveErpLinks": 759,
    "TicketPriorityId": 804,
    "SupportLanguageId": 524,
    "SupportAssociateId": 472,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 216
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "perferendis",
      "PersonId": 359,
      "Mrmrs": "neque",
      "Firstname": "Matteo",
      "Lastname": "Morar",
      "MiddleName": "Nolan Inc and Sons",
      "Title": "eveniet",
      "Description": "Expanded tangible Graphic Interface",
      "Email": "bert@westkovacek.com",
      "FullName": "Weston Predovic",
      "DirectPhone": "383-251-0017 x7517",
      "FormalName": "Thompson-Carroll",
      "CountryId": 802,
      "ContactId": 896,
      "ContactName": "Roob, Orn and Swaniawski",
      "Retired": 406,
      "Rank": 28,
      "ActiveInterests": 361,
      "ContactDepartment": "",
      "ContactCountryId": 970,
      "ContactOrgNr": "1552245",
      "FaxPhone": "055-762-7005 x70057",
      "MobilePhone": "535.100.0760 x82250",
      "ContactPhone": "1-106-840-7526 x708",
      "AssociateName": "Sporer-Schuster",
      "AssociateId": 159,
      "UsePersonAddress": true,
      "ContactFax": "iste",
      "Kanafname": "nulla",
      "Kanalname": "a",
      "Post1": "nobis",
      "Post2": "et",
      "Post3": "culpa",
      "EmailName": "jalyn_grady@abshire.uk",
      "ContactFullName": "Lee Wilkinson",
      "ActiveErpLinks": 858,
      "TicketPriorityId": 275,
      "SupportLanguageId": 224,
      "SupportAssociateId": 920,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "incentivize intuitive partnerships"
          },
          "FieldType": "System.String",
          "FieldLength": 700
        }
      }
    }
  ],
  "AlertLevel": 529,
  "ConnectId": 529,
  "ReadStatus": "Green",
  "TimeToReply": 222,
  "RealTimeToReply": 821,
  "TimeToClose": 320,
  "RealTimeToClose": 867,
  "TimeSpentInternally": 936,
  "TimeSpentExternally": 179,
  "TimeSpentQueue": 362,
  "RealTimeSpentInternally": 692,
  "RealTimeSpentExternally": 959,
  "RealTimeSpentQueue": 397,
  "HasAttachment": false,
  "NumReplies": 673,
  "NumMessages": 723,
  "FromAddress": "sit",
  "Messages": [
    {
      "TicketMessageId": 257,
      "CreatedAt": "1996-06-02T18:25:51.2139436+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "maiores",
      "PersonId": 532,
      "PersonFullName": "Morris Roob",
      "ContactId": 12,
      "ContactName": "Cole-Koss",
      "ContactDepartment": "",
      "NumAttachments": 767,
      "EmailHeader": "nikita.sawayn@mccullough.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "envisioneer transparent e-services"
          },
          "FieldType": "System.Int32",
          "FieldLength": 382
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 414,
      "Name": "Stehr Group",
      "ToolTip": "Sunt quos vel est.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 925
        }
      }
    },
    {
      "Id": 414,
      "Name": "Stehr Group",
      "ToolTip": "Sunt quos vel est.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 925
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "incidunt",
    "ExtraFields2": "doloremque"
  },
  "CustomFields": {
    "CustomFields1": "mollitia",
    "CustomFields2": "modi"
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
      "FieldLength": 529
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```