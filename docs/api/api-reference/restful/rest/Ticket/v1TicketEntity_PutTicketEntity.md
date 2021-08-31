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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 114,
  "Title": "quo",
  "CreatedAt": "2010-07-18T15:05:42.8416652+02:00",
  "LastChanged": "1997-04-18T15:05:42.8416652+02:00",
  "ReadByOwner": "2018-05-29T15:05:42.8416652+02:00",
  "ReadByCustomer": "2016-01-03T15:05:42.8416652+01:00",
  "FirstReadByUser": "2000-11-03T15:05:42.8416652+01:00",
  "Activate": "2012-02-28T15:05:42.8416652+01:00",
  "ClosedAt": "1998-06-09T15:05:42.8416652+02:00",
  "RepliedAt": "2011-09-29T15:05:42.8416652+02:00",
  "AlertTimeout": "2013-02-01T15:05:42.8416652+01:00",
  "Deadline": "2020-01-23T15:05:42.8416652+01:00",
  "CreatedBy": {
    "AssociateId": 696,
    "Name": "Balistreri, Schmitt and Vandervort",
    "PersonId": 777,
    "Rank": 917,
    "Tooltip": "odit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 640,
    "FullName": "Annabel Schmeler MD",
    "FormalName": "Roob, Medhurst and Rempel",
    "Deleted": false,
    "EjUserId": 650,
    "UserName": "Schroeder LLC"
  },
  "Author": "voluptatibus",
  "OwnedBy": {
    "AssociateId": 340,
    "Name": "Armstrong-Gutmann",
    "PersonId": 941,
    "Rank": 421,
    "Tooltip": "corrupti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 764,
    "FullName": "Vince Stark",
    "FormalName": "Kiehn LLC",
    "Deleted": true,
    "EjUserId": 66,
    "UserName": "Crona Group"
  },
  "Category": {
    "TicketCategoryId": 322,
    "ParentId": 534,
    "Name": "McLaughlin, Gaylord and Nader",
    "Fullname": "velit",
    "CategoryMaster": 546,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Ward-Kerluke",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 804,
    "ReplyTemplate": 388,
    "NotificationEmail": "lavada@sengerveum.co.uk",
    "ExtraFields": {
      "ExtraFields1": "quod",
      "ExtraFields2": "sequi"
    },
    "CustomFields": {
      "CustomFields1": "ratione",
      "CustomFields2": "voluptatem"
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 160,
    "Name": "Boyer Inc and Sons",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 788,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 925,
    "MonStart": "2003-06-24T15:05:42.8426631+02:00",
    "MonStop": "2017-04-29T15:05:42.8426631+02:00",
    "TueStart": "2007-03-23T15:05:42.8426631+01:00",
    "TueStop": "2016-02-22T15:05:42.8426631+01:00",
    "WedStart": "2003-02-06T15:05:42.8426631+01:00",
    "WedStop": "1994-11-15T15:05:42.8426631+01:00",
    "ThuStart": "2006-04-30T15:05:42.8426631+02:00",
    "ThuStop": "2014-12-20T15:05:42.8426631+01:00",
    "FriStart": "2008-01-25T15:05:42.8426631+01:00",
    "FriStop": "2004-09-01T15:05:42.8426631+02:00",
    "SatStart": "1997-06-18T15:05:42.8426631+02:00",
    "SatStop": "1999-10-20T15:05:42.8426631+02:00",
    "SunStart": "2007-08-02T15:05:42.8426631+02:00",
    "SunStop": "2021-07-16T15:05:42.8426631+02:00",
    "NonDates": [
      "quis",
      "ipsum"
    ]
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 115,
    "Name": "Johns, Dickens and Bednar",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": true
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "reprehenderit",
    "PersonId": 69,
    "Mrmrs": "non",
    "Firstname": "Rebecca",
    "Lastname": "Windler",
    "MiddleName": "Lakin, Welch and Bernhard",
    "Title": "nihil",
    "Description": "Universal incremental info-mediaries",
    "Email": "tavares@sauer.biz",
    "FullName": "Miss Queenie Konopelski",
    "DirectPhone": "284.184.8604",
    "FormalName": "McKenzie, Powlowski and Bauch",
    "CountryId": 562,
    "ContactId": 863,
    "ContactName": "Brakus-Ankunding",
    "Retired": 410,
    "Rank": 858,
    "ActiveInterests": 899,
    "ContactDepartment": "",
    "ContactCountryId": 915,
    "ContactOrgNr": "707372",
    "FaxPhone": "(273)316-5600 x7067",
    "MobilePhone": "382.246.7755",
    "ContactPhone": "023.258.3858 x6167",
    "AssociateName": "Hammes LLC",
    "AssociateId": 824,
    "UsePersonAddress": false,
    "ContactFax": "ad",
    "Kanafname": "nobis",
    "Kanalname": "temporibus",
    "Post1": "pariatur",
    "Post2": "voluptates",
    "Post3": "tenetur",
    "EmailName": "retta.parisian@hillsrutherford.uk",
    "ContactFullName": "Lysanne Sporer",
    "ActiveErpLinks": 179,
    "TicketPriorityId": 229,
    "SupportLanguageId": 677,
    "SupportAssociateId": 765,
    "CategoryName": "VIP Customer"
  },
  "SecondaryPersons": [
    {
      "Position": "deleniti",
      "PersonId": 444,
      "Mrmrs": "nostrum",
      "Firstname": "Alaina",
      "Lastname": "Wilderman",
      "MiddleName": "Langworth-Klein",
      "Title": "accusamus",
      "Description": "Multi-lateral transitional archive",
      "Email": "wyatt@yundt.us",
      "FullName": "Catharine Olson",
      "DirectPhone": "636.333.4700 x35418",
      "FormalName": "Gislason, Toy and Fadel",
      "CountryId": 759,
      "ContactId": 503,
      "ContactName": "Mayert Group",
      "Retired": 268,
      "Rank": 859,
      "ActiveInterests": 8,
      "ContactDepartment": "",
      "ContactCountryId": 719,
      "ContactOrgNr": "723919",
      "FaxPhone": "1-744-611-0010",
      "MobilePhone": "766-400-1038 x844",
      "ContactPhone": "805.310.5707 x0525",
      "AssociateName": "Schneider Inc and Sons",
      "AssociateId": 605,
      "UsePersonAddress": true,
      "ContactFax": "possimus",
      "Kanafname": "et",
      "Kanalname": "alias",
      "Post1": "deserunt",
      "Post2": "voluptates",
      "Post3": "debitis",
      "EmailName": "ardith@greenholt.ca",
      "ContactFullName": "Wilford Smitham",
      "ActiveErpLinks": 40,
      "TicketPriorityId": 660,
      "SupportLanguageId": 932,
      "SupportAssociateId": 474,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 370,
  "ConnectId": 805,
  "ReadStatus": "Green",
  "TimeToReply": 6,
  "RealTimeToReply": 584,
  "TimeToClose": 745,
  "RealTimeToClose": 302,
  "TimeSpentInternally": 16,
  "TimeSpentExternally": 583,
  "TimeSpentQueue": 5,
  "RealTimeSpentInternally": 843,
  "RealTimeSpentExternally": 596,
  "RealTimeSpentQueue": 213,
  "HasAttachment": true,
  "NumReplies": 38,
  "NumMessages": 497,
  "FromAddress": "debitis",
  "Messages": [
    {
      "TicketMessageId": 693,
      "CreatedAt": "1995-05-20T15:05:42.8456626+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "ipsam",
      "PersonId": 962,
      "PersonFullName": "Laura Orn",
      "ContactId": 459,
      "ContactName": "Raynor LLC",
      "ContactDepartment": "",
      "NumAttachments": 890,
      "EmailHeader": "general.herman@muller.co.uk",
      "MessageHeaders": [
        {},
        {}
      ]
    }
  ],
  "Tags": [
    {
      "Id": 496,
      "Name": "Klein, Lakin and Gutkowski",
      "ToolTip": "Eveniet atque mollitia."
    },
    {
      "Id": 496,
      "Name": "Klein, Lakin and Gutkowski",
      "ToolTip": "Eveniet atque mollitia."
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "delectus",
    "ExtraFields2": "laudantium"
  },
  "CustomFields": {
    "CustomFields1": "rem",
    "CustomFields2": "ipsa"
  }
}
```

```http_
HTTP/1.1 200 TicketEntity updated.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 559,
  "Title": "sit",
  "CreatedAt": "2012-03-24T15:05:42.8526626+01:00",
  "LastChanged": "2009-01-22T15:05:42.8526626+01:00",
  "ReadByOwner": "2014-08-27T15:05:42.8526626+02:00",
  "ReadByCustomer": "2021-07-14T15:05:42.8526626+02:00",
  "FirstReadByUser": "2014-09-03T15:05:42.8526626+02:00",
  "Activate": "1994-07-25T15:05:42.8526626+02:00",
  "ClosedAt": "2020-05-29T15:05:42.8526626+02:00",
  "RepliedAt": "1995-10-25T15:05:42.8526626+02:00",
  "AlertTimeout": "2013-12-04T15:05:42.8526626+01:00",
  "Deadline": "1997-08-08T15:05:42.8526626+02:00",
  "CreatedBy": {
    "AssociateId": 707,
    "Name": "Lockman Group",
    "PersonId": 485,
    "Rank": 930,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 593,
    "FullName": "Kamryn Muller",
    "FormalName": "Klocko Group",
    "Deleted": false,
    "EjUserId": 332,
    "UserName": "Borer, Runolfsdottir and Lebsack",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 551
      }
    }
  },
  "Author": "aut",
  "OwnedBy": {
    "AssociateId": 443,
    "Name": "Nader-Strosin",
    "PersonId": 177,
    "Rank": 450,
    "Tooltip": "dolorum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 23,
    "FullName": "Idella Gottlieb",
    "FormalName": "Kreiger, Schimmel and Ruecker",
    "Deleted": false,
    "EjUserId": 836,
    "UserName": "Littel, Koelpin and Jacobs",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 116
      }
    }
  },
  "Category": {
    "TicketCategoryId": 183,
    "ParentId": 481,
    "Name": "Hamill, Watsica and Green",
    "Fullname": "voluptatem",
    "CategoryMaster": 454,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Daugherty-Green",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 567,
    "ReplyTemplate": 921,
    "NotificationEmail": "raleigh@bayer.biz",
    "ExtraFields": {
      "ExtraFields1": "expedita",
      "ExtraFields2": "reiciendis"
    },
    "CustomFields": {
      "CustomFields1": "sint",
      "CustomFields2": "voluptatibus"
    },
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
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 478,
    "Name": "Mohr Group",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 378,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 798,
    "MonStart": "2006-01-09T15:05:42.8536622+01:00",
    "MonStop": "2011-03-03T15:05:42.8536622+01:00",
    "TueStart": "2012-05-07T15:05:42.8536622+02:00",
    "TueStop": "2017-11-25T15:05:42.8536622+01:00",
    "WedStart": "2004-11-11T15:05:42.8536622+01:00",
    "WedStop": "2019-07-21T15:05:42.8536622+02:00",
    "ThuStart": "2005-02-15T15:05:42.8536622+01:00",
    "ThuStop": "2015-08-27T15:05:42.8536622+02:00",
    "FriStart": "2004-05-06T15:05:42.8536622+02:00",
    "FriStop": "2018-09-28T15:05:42.8536622+02:00",
    "SatStart": "2012-05-11T15:05:42.8536622+02:00",
    "SatStop": "2015-05-21T15:05:42.8536622+02:00",
    "SunStart": "2020-08-22T15:05:42.8536622+02:00",
    "SunStop": "2006-07-08T15:05:42.8536622+02:00",
    "NonDates": [
      "voluptas",
      "eligendi"
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 318
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 103,
    "Name": "Balistreri LLC",
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
        "FieldLength": 124
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "asperiores",
    "PersonId": 667,
    "Mrmrs": "autem",
    "Firstname": "Ayana",
    "Lastname": "Gaylord",
    "MiddleName": "Kuphal-Harris",
    "Title": "et",
    "Description": "Stand-alone 6th generation protocol",
    "Email": "adriel@wizaherman.us",
    "FullName": "Dawn Carter V",
    "DirectPhone": "216.277.8277 x712",
    "FormalName": "Dibbert, Schmeler and Price",
    "CountryId": 769,
    "ContactId": 222,
    "ContactName": "O'Keefe Inc and Sons",
    "Retired": 245,
    "Rank": 762,
    "ActiveInterests": 842,
    "ContactDepartment": "synergize integrated synergies",
    "ContactCountryId": 418,
    "ContactOrgNr": "1300587",
    "FaxPhone": "1-160-724-8742 x83701",
    "MobilePhone": "444.838.0883",
    "ContactPhone": "(312)302-2180 x8422",
    "AssociateName": "Casper-Wiegand",
    "AssociateId": 281,
    "UsePersonAddress": true,
    "ContactFax": "quia",
    "Kanafname": "animi",
    "Kanalname": "non",
    "Post1": "est",
    "Post2": "magnam",
    "Post3": "dolor",
    "EmailName": "roger_larson@frami.co.uk",
    "ContactFullName": "Skye Emard",
    "ActiveErpLinks": 78,
    "TicketPriorityId": 510,
    "SupportLanguageId": 38,
    "SupportAssociateId": 201,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 155
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "provident",
      "PersonId": 422,
      "Mrmrs": "incidunt",
      "Firstname": "Kariane",
      "Lastname": "Rice",
      "MiddleName": "Schulist-Muller",
      "Title": "aut",
      "Description": "Function-based uniform ability",
      "Email": "jamar_miller@beahan.us",
      "FullName": "Winona Lebsack Jr.",
      "DirectPhone": "(005)344-3322 x14404",
      "FormalName": "Anderson, Towne and Cruickshank",
      "CountryId": 506,
      "ContactId": 429,
      "ContactName": "Tillman, Johnson and Weimann",
      "Retired": 107,
      "Rank": 229,
      "ActiveInterests": 268,
      "ContactDepartment": "",
      "ContactCountryId": 342,
      "ContactOrgNr": "264209",
      "FaxPhone": "(465)047-3512 x4335",
      "MobilePhone": "731.034.4311",
      "ContactPhone": "(321)380-1782 x785",
      "AssociateName": "Schaden Group",
      "AssociateId": 239,
      "UsePersonAddress": false,
      "ContactFax": "sit",
      "Kanafname": "cupiditate",
      "Kanalname": "corrupti",
      "Post1": "quia",
      "Post2": "expedita",
      "Post3": "architecto",
      "EmailName": "jarvis@will.uk",
      "ContactFullName": "Erich Johns",
      "ActiveErpLinks": 223,
      "TicketPriorityId": 554,
      "SupportLanguageId": 657,
      "SupportAssociateId": 29,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 23
        }
      }
    }
  ],
  "AlertLevel": 578,
  "ConnectId": 623,
  "ReadStatus": "Green",
  "TimeToReply": 841,
  "RealTimeToReply": 711,
  "TimeToClose": 126,
  "RealTimeToClose": 924,
  "TimeSpentInternally": 886,
  "TimeSpentExternally": 440,
  "TimeSpentQueue": 662,
  "RealTimeSpentInternally": 682,
  "RealTimeSpentExternally": 777,
  "RealTimeSpentQueue": 894,
  "HasAttachment": false,
  "NumReplies": 662,
  "NumMessages": 854,
  "FromAddress": "in",
  "Messages": [
    {
      "TicketMessageId": 979,
      "CreatedAt": "2005-02-28T15:05:42.8566622+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "voluptate",
      "PersonId": 185,
      "PersonFullName": "Miss Aiden Stroman",
      "ContactId": 846,
      "ContactName": "Emard-Kohler",
      "ContactDepartment": "optimize back-end applications",
      "NumAttachments": 543,
      "EmailHeader": "raina.leannon@sauercormier.ca",
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
          "FieldLength": 805
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 83,
      "Name": "Kuhic-Becker",
      "ToolTip": "At ratione qui expedita.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 18
        }
      }
    },
    {
      "Id": 83,
      "Name": "Kuhic-Becker",
      "ToolTip": "At ratione qui expedita.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 18
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "beatae",
    "ExtraFields2": "nemo"
  },
  "CustomFields": {
    "CustomFields1": "dignissimos",
    "CustomFields2": "aut"
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
      "FieldLength": 96
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```