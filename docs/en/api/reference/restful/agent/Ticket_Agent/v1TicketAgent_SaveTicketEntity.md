---
title: POST Agents/Ticket/SaveTicketEntity
uid: v1TicketAgent_SaveTicketEntity
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
| TicketId | Integer | The primary key (auto-incremented) |
| Title | String | The title of the ticket. |
| CreatedAt | String | When the ticket was created. |
| LastChanged | String | The last time the ticket was modified. |
| ReadByOwner | String | The datetime for when the ticket last was read by the owner. |
| ReadByCustomer | String | The datetime for when the ticket was read by the customer. |
| FirstReadByOwner | String | The datetime for when the ticket first was read by the current owner. |
| FirstReadByUser | String | The datetime for when the ticket first was read by a user. |
| Activate | String | When the ticket should be activated, if it is postponed. |
| ClosedAt | String | When the ticket was closed. |
| RepliedAt | String | The datetime for when the ticket was replied to. I.e. the first external message added to the ticket. |
| AlertTimeout | String | The datetime for when the ticket should jump to the next alert_level. |
| Deadline | String | Deadline for ticket. |
| CreatedBy | Associate | The associate who created this ticket |
| Author | String | A string representing the author of the ticket (same as author of first message). |
| OwnedBy | Associate | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category | TicketCategoryEntity | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | String | The securitylevel of the ticket. |
| Priority | TicketPriorityEntity | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | String | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status | TicketStatusEntity | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | String | What is the origin of this ticket |
| Person | Person | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
| SecondaryPersons | Array | The secondary persons this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
| AlertLevel | Integer | The alert level for the ticket. Matches the level value of the ticket_alert table. |
| ConnectId | Integer | If a ticket is connected to another ticket, this field is set to the id of the &amp;apos;master&amp;apos; ticket. |
| ReadStatus | String | Whether the owner has read the ticket or not (red, yellow, green). |
| TimeToReply | Integer | The time (minutes) between when the ticket was created and when it was replied to. Calculated based on priority&amp;apos;s timeframe. |
| RealTimeToReply | Integer | Same as time_to_reply, but not calculated based on priority. |
| TimeToClose | Integer | The time (minutes) between when the ticket was created and when it was closed. Calculated based on priority&amp;apos;s timeframe. |
| RealTimeToClose | Integer | Same as time_to_close, but not calculated based on priority. |
| TimeSpentInternally | Integer | The total time (seconds) within the priority's office hours the ticket has been in an open status (configurable), not including current state |
| TimeSpentExternally | Integer | The total time (seconds) within the priority's office hours the ticket has been in a external waiting status (configurable), not including current state |
| TimeSpentQueue | Integer | The total time (seconds) within the priority's office hours the ticket has been in a queue status, not including current state |
| RealTimeSpentInternally | Integer | The total time (seconds) within 24x7 the ticket has been in an open status (configurable), not including current state |
| RealTimeSpentExternally | Integer | The total time (seconds) within 24x7 the ticket has been in a external waiting status (configurable), not including current state |
| RealTimeSpentQueue | Integer | The total time (seconds) within 24x7 hours the ticket has been in a queue status, not including current state |
| HasAttachment | Boolean | Boolean indicating if this ticket has one or more attachments. |
| NumReplies | Integer | The number of replies (messages) to the customer for this request. |
| NumMessages | Integer | The total number of messages for this request. |
| FromAddress | String | The from-address used when this ticket got created, e.g. by email |
| Messages | Array | TicketMessageId,CreatedAt,SLevel and Important for all the messages connected to this ticket. For message body see the TicketMessageEntity or the TicketMessage archive. |
| Tags | Array | An array containing the tags assigned to this request |
| Language | String | The language of the first external message |
| Sentiment | Integer | The sentiment index of the last external message |
| SentimentConfidence | Integer | The sentiment confidence of the last external message |
| SuggestedCategoryId | Integer | Suggestion for categorization, based on the text of the message (AI) |
| SuggestedCategoryName | String | Suggested category from AI |
| OrigHumanCategoryId | Integer | Will contain the category id selected by the user, when having the choice of using the suggested category or manually selecting a category |
| IconHint | String | Icon representing ticket's state |
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TicketEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | int32 | The primary key (auto-incremented) |
| Title | string | The title of the ticket. |
| CreatedAt | date-time | When the ticket was created. |
| LastChanged | date-time | The last time the ticket was modified. |
| ReadByOwner | date-time | The datetime for when the ticket last was read by the owner. |
| ReadByCustomer | date-time | The datetime for when the ticket was read by the customer. |
| FirstReadByOwner | date-time | The datetime for when the ticket first was read by the current owner. |
| FirstReadByUser | date-time | The datetime for when the ticket first was read by a user. |
| Activate | date-time | When the ticket should be activated, if it is postponed. |
| ClosedAt | date-time | When the ticket was closed. |
| RepliedAt | date-time | The datetime for when the ticket was replied to. I.e. the first external message added to the ticket. |
| AlertTimeout | date-time | The datetime for when the ticket should jump to the next alert_level. |
| Deadline | date-time | Deadline for ticket. |
| CreatedBy | Associate | The associate who created this ticket |
| Author | string | A string representing the author of the ticket (same as author of first message). |
| OwnedBy | Associate | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category | TicketCategoryEntity | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority | TicketPriorityEntity | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status | TicketStatusEntity | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person | Person | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
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
| Language | string | The language of the first external message |
| Sentiment | int32 | The sentiment index of the last external message |
| SentimentConfidence | int32 | The sentiment confidence of the last external message |
| SuggestedCategoryId | int32 | Suggestion for categorization, based on the text of the message (AI) |
| SuggestedCategoryName | string | Suggested category from AI |
| OrigHumanCategoryId | int32 | Will contain the category id selected by the user, when having the choice of using the suggested category or manually selecting a category |
| IconHint | string | Icon representing ticket's state |
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Ticket/SaveTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 666,
  "Title": "inventore",
  "CreatedAt": "2015-06-20T15:29:23.0452587+02:00",
  "LastChanged": "1999-11-20T15:29:23.0452587+01:00",
  "ReadByOwner": "2021-02-26T15:29:23.0452587+01:00",
  "ReadByCustomer": "2016-10-10T15:29:23.0452587+02:00",
  "FirstReadByOwner": "2011-12-25T15:29:23.0452587+01:00",
  "FirstReadByUser": "2017-06-23T15:29:23.0452587+02:00",
  "Activate": "2004-06-13T15:29:23.0452587+02:00",
  "ClosedAt": "2004-10-05T15:29:23.0452587+02:00",
  "RepliedAt": "2012-08-12T15:29:23.0452587+02:00",
  "AlertTimeout": "2002-01-23T15:29:23.0452587+01:00",
  "Deadline": "2000-09-03T15:29:23.0452587+02:00",
  "CreatedBy": null,
  "Author": "est",
  "OwnedBy": null,
  "Category": null,
  "Slevel": "External",
  "Priority": null,
  "BaseStatus": "Active",
  "Status": null,
  "Origin": "AutoGenerated",
  "Person": null,
  "SecondaryPersons": [
    {
      "Position": "quod",
      "PersonId": 867,
      "Mrmrs": "minima",
      "Firstname": "Julio",
      "Lastname": "Hartmann",
      "MiddleName": "Leuschke Group",
      "Title": "aut",
      "Description": "Proactive upward-trending customer loyalty",
      "Email": "rosendo@reichelcasper.info",
      "FullName": "Oma Dietrich",
      "DirectPhone": "1-069-111-0537",
      "FormalName": "Padberg, Emmerich and Gusikowski",
      "CountryId": 571,
      "ContactId": 739,
      "ContactName": "Ernser Group",
      "Retired": 853,
      "Rank": 542,
      "ActiveInterests": 802,
      "ContactDepartment": "",
      "ContactCountryId": 116,
      "ContactOrgNr": "1607236",
      "FaxPhone": "588-175-9080 x8007",
      "MobilePhone": "037.830.1233 x650",
      "ContactPhone": "(064)147-9446 x96557",
      "AssociateName": "Douglas-Hoppe",
      "AssociateId": 657,
      "UsePersonAddress": true,
      "ContactFax": "velit",
      "Kanafname": "exercitationem",
      "Kanalname": "iste",
      "Post1": "nobis",
      "Post2": "consequatur",
      "Post3": "aliquam",
      "EmailName": "raegan_jast@mraz.info",
      "ContactFullName": "Jaunita Rempel",
      "ActiveErpLinks": 718,
      "TicketPriorityId": 347,
      "SupportLanguageId": 541,
      "SupportAssociateId": 376,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 92,
  "ConnectId": 623,
  "ReadStatus": "Green",
  "TimeToReply": 535,
  "RealTimeToReply": 7,
  "TimeToClose": 984,
  "RealTimeToClose": 379,
  "TimeSpentInternally": 696,
  "TimeSpentExternally": 359,
  "TimeSpentQueue": 240,
  "RealTimeSpentInternally": 489,
  "RealTimeSpentExternally": 151,
  "RealTimeSpentQueue": 353,
  "HasAttachment": false,
  "NumReplies": 371,
  "NumMessages": 550,
  "FromAddress": "voluptatum",
  "Messages": [
    {
      "TicketMessageId": 897,
      "CreatedAt": "1996-10-26T15:29:23.0512586+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "non",
      "PersonId": 288,
      "PersonFullName": "Dr. Waldo O'Connell V",
      "ContactId": 358,
      "ContactName": "Leannon-Mueller",
      "ContactDepartment": "",
      "NumAttachments": 355,
      "EmailHeader": "leonard_roberts@jast.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "facere",
      "Sentiment": 193,
      "SentimentConfidence": 563,
      "CreatedBy": 63,
      "ChangedAt": "2016-07-29T15:29:23.0517576+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 904,
      "Name": "Stamm-Glover",
      "ToolTip": "Sed quasi."
    },
    {
      "Id": 904,
      "Name": "Stamm-Glover",
      "ToolTip": "Sed quasi."
    }
  ],
  "Language": "vitae",
  "Sentiment": 119,
  "SentimentConfidence": 497,
  "SuggestedCategoryId": 218,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 628,
  "IconHint": "placeat",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "cum",
    "ExtraFields2": "autem"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "deleniti"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 276,
  "Title": "est",
  "CreatedAt": "2008-01-08T15:29:23.0592584+01:00",
  "LastChanged": "1996-04-17T15:29:23.0592584+02:00",
  "ReadByOwner": "2001-01-07T15:29:23.0592584+01:00",
  "ReadByCustomer": "2015-10-19T15:29:23.0592584+02:00",
  "FirstReadByOwner": "2002-12-06T15:29:23.0592584+01:00",
  "FirstReadByUser": "2020-05-07T15:29:23.0592584+02:00",
  "Activate": "2023-02-18T15:29:23.0592584+01:00",
  "ClosedAt": "2022-04-28T15:29:23.0592584+02:00",
  "RepliedAt": "2017-07-28T15:29:23.0592584+02:00",
  "AlertTimeout": "2015-08-30T15:29:23.0592584+02:00",
  "Deadline": "1997-12-26T15:29:23.0592584+01:00",
  "CreatedBy": null,
  "Author": "consequatur",
  "OwnedBy": null,
  "Category": null,
  "Slevel": "External",
  "Priority": null,
  "BaseStatus": "Active",
  "Status": null,
  "Origin": "AutoGenerated",
  "Person": null,
  "SecondaryPersons": [
    {
      "Position": "aut",
      "PersonId": 679,
      "Mrmrs": "ut",
      "Firstname": "Eva",
      "Lastname": "Schroeder",
      "MiddleName": "Feeney Inc and Sons",
      "Title": "quod",
      "Description": "Public-key background extranet",
      "Email": "sydni.leffler@rohan.uk",
      "FullName": "Ms. Jaleel Trevion Collier",
      "DirectPhone": "025-913-7120 x36741",
      "FormalName": "Dach, Metz and Bergstrom",
      "CountryId": 635,
      "ContactId": 102,
      "ContactName": "O'Conner-Raynor",
      "Retired": 893,
      "Rank": 507,
      "ActiveInterests": 72,
      "ContactDepartment": "",
      "ContactCountryId": 685,
      "ContactOrgNr": "932759",
      "FaxPhone": "1-538-391-2085 x6934",
      "MobilePhone": "300-329-6648 x7036",
      "ContactPhone": "1-438-593-5466 x592",
      "AssociateName": "Lueilwitz-Kuhlman",
      "AssociateId": 666,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "est",
      "Kanalname": "omnis",
      "Post1": "voluptatum",
      "Post2": "quo",
      "Post3": "blanditiis",
      "EmailName": "eunice@lebsackboyle.co.uk",
      "ContactFullName": "Prof. Judy O'Connell IV",
      "ActiveErpLinks": 569,
      "TicketPriorityId": 384,
      "SupportLanguageId": 103,
      "SupportAssociateId": 291,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 912
        }
      }
    }
  ],
  "AlertLevel": 777,
  "ConnectId": 579,
  "ReadStatus": "Green",
  "TimeToReply": 520,
  "RealTimeToReply": 784,
  "TimeToClose": 287,
  "RealTimeToClose": 15,
  "TimeSpentInternally": 261,
  "TimeSpentExternally": 507,
  "TimeSpentQueue": 960,
  "RealTimeSpentInternally": 291,
  "RealTimeSpentExternally": 479,
  "RealTimeSpentQueue": 74,
  "HasAttachment": false,
  "NumReplies": 55,
  "NumMessages": 69,
  "FromAddress": "dolor",
  "Messages": [
    {
      "TicketMessageId": 486,
      "CreatedAt": "2011-09-17T15:29:23.0637581+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "in",
      "PersonId": 133,
      "PersonFullName": "Shemar Champlin",
      "ContactId": 432,
      "ContactName": "Gusikowski Inc and Sons",
      "ContactDepartment": "incubate clicks-and-mortar content",
      "NumAttachments": 648,
      "EmailHeader": "katelyn_rice@considine.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "laboriosam",
      "Sentiment": 20,
      "SentimentConfidence": 804,
      "CreatedBy": 78,
      "ChangedAt": "2012-01-20T15:29:23.0642572+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 731
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 666,
      "Name": "Williamson, Lehner and Towne",
      "ToolTip": "Qui maxime et cumque.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 458
        }
      }
    },
    {
      "Id": 666,
      "Name": "Williamson, Lehner and Towne",
      "ToolTip": "Qui maxime et cumque.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 458
        }
      }
    }
  ],
  "Language": "reiciendis",
  "Sentiment": 496,
  "SentimentConfidence": 849,
  "SuggestedCategoryId": 321,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 863,
  "IconHint": "consequatur",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "veritatis",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "expedita",
    "CustomFields2": "ratione"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 308
    }
  }
}
```