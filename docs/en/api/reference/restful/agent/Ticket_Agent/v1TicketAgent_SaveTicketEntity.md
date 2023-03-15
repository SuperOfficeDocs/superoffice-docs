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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Ticket/SaveTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 450,
  "Title": "deleniti",
  "CreatedAt": "2010-03-06T12:15:20.2687349+01:00",
  "LastChanged": "2001-02-24T12:15:20.2687349+01:00",
  "ReadByOwner": "2022-06-25T12:15:20.2687349+02:00",
  "ReadByCustomer": "2012-08-08T12:15:20.2687349+02:00",
  "FirstReadByOwner": "2011-02-10T12:15:20.2687349+01:00",
  "FirstReadByUser": "2009-03-27T12:15:20.2687349+01:00",
  "Activate": "2017-01-25T12:15:20.2687349+01:00",
  "ClosedAt": "2014-11-06T12:15:20.2687349+01:00",
  "RepliedAt": "2012-05-14T12:15:20.2687349+02:00",
  "AlertTimeout": "2021-09-09T12:15:20.2687349+02:00",
  "Deadline": "2006-11-23T12:15:20.2687349+01:00",
  "CreatedBy": null,
  "Author": "sed",
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
      "Position": "magni",
      "PersonId": 353,
      "Mrmrs": "asperiores",
      "Firstname": "Lenna",
      "Lastname": "Jaskolski",
      "MiddleName": "Schinner-Rodriguez",
      "Title": "non",
      "Description": "Sharable didactic ability",
      "Email": "isaac_stoltenberg@kuhic.name",
      "FullName": "Elnora Bartell",
      "DirectPhone": "1-811-057-8694",
      "FormalName": "Dietrich, Ledner and Gulgowski",
      "CountryId": 221,
      "ContactId": 254,
      "ContactName": "Bednar LLC",
      "Retired": 51,
      "Rank": 379,
      "ActiveInterests": 926,
      "ContactDepartment": "",
      "ContactCountryId": 457,
      "ContactOrgNr": "306758",
      "FaxPhone": "(207)795-6359 x356",
      "MobilePhone": "326-130-3002 x1890",
      "ContactPhone": "1-549-214-0829",
      "AssociateName": "Jewess, Murazik and Conroy",
      "AssociateId": 499,
      "UsePersonAddress": true,
      "ContactFax": "illo",
      "Kanafname": "enim",
      "Kanalname": "itaque",
      "Post1": "aut",
      "Post2": "doloribus",
      "Post3": "et",
      "EmailName": "jerrell.lebsack@shieldsbins.com",
      "ContactFullName": "Aliya Bogisich",
      "ActiveErpLinks": 521,
      "TicketPriorityId": 797,
      "SupportLanguageId": 944,
      "SupportAssociateId": 484,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 187,
  "ConnectId": 590,
  "ReadStatus": "Green",
  "TimeToReply": 371,
  "RealTimeToReply": 396,
  "TimeToClose": 489,
  "RealTimeToClose": 860,
  "TimeSpentInternally": 407,
  "TimeSpentExternally": 1000,
  "TimeSpentQueue": 72,
  "RealTimeSpentInternally": 767,
  "RealTimeSpentExternally": 797,
  "RealTimeSpentQueue": 654,
  "HasAttachment": false,
  "NumReplies": 673,
  "NumMessages": 110,
  "FromAddress": "tempora",
  "Messages": [
    {
      "TicketMessageId": 801,
      "CreatedAt": "1997-01-16T12:15:20.2747326+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "molestiae",
      "PersonId": 817,
      "PersonFullName": "Russel Kihn",
      "ContactId": 910,
      "ContactName": "Pollich, Wehner and Hoeger",
      "ContactDepartment": "",
      "NumAttachments": 954,
      "EmailHeader": "lilian@lynch.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "sunt",
      "Sentiment": 551,
      "SentimentConfidence": 79,
      "CreatedBy": 830,
      "ChangedAt": "2011-09-08T12:15:20.2747326+02:00"
    }
  ],
  "Tags": [
    {
      "Id": 616,
      "Name": "Fadel Group",
      "ToolTip": "Dolores aut pariatur in saepe."
    },
    {
      "Id": 616,
      "Name": "Fadel Group",
      "ToolTip": "Dolores aut pariatur in saepe."
    }
  ],
  "Language": "iste",
  "Sentiment": 779,
  "SentimentConfidence": 854,
  "SuggestedCategoryId": 118,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 518,
  "IconHint": "et",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "libero",
    "ExtraFields2": "quae"
  },
  "CustomFields": {
    "CustomFields1": "assumenda",
    "CustomFields2": "maxime"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 813,
  "Title": "quasi",
  "CreatedAt": "2013-08-10T12:15:20.2837356+02:00",
  "LastChanged": "2021-02-26T12:15:20.2837356+01:00",
  "ReadByOwner": "2014-08-31T12:15:20.2837356+02:00",
  "ReadByCustomer": "2012-01-19T12:15:20.2837356+01:00",
  "FirstReadByOwner": "2006-10-08T12:15:20.2837356+02:00",
  "FirstReadByUser": "2013-12-09T12:15:20.2837356+01:00",
  "Activate": "2003-10-15T12:15:20.2837356+02:00",
  "ClosedAt": "2001-01-30T12:15:20.2837356+01:00",
  "RepliedAt": "2008-07-30T12:15:20.2837356+02:00",
  "AlertTimeout": "2014-04-15T12:15:20.2837356+02:00",
  "Deadline": "2013-03-11T12:15:20.2837356+01:00",
  "CreatedBy": null,
  "Author": "quo",
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
      "Position": "tenetur",
      "PersonId": 746,
      "Mrmrs": "ea",
      "Firstname": "Aletha",
      "Lastname": "McGlynn",
      "MiddleName": "Predovic Group",
      "Title": "rem",
      "Description": "Progressive tertiary superstructure",
      "Email": "marian_zboncak@parkerkihn.uk",
      "FullName": "Kyler Yundt",
      "DirectPhone": "1-396-841-8210 x8212",
      "FormalName": "Tromp Group",
      "CountryId": 894,
      "ContactId": 88,
      "ContactName": "Buckridge-Shanahan",
      "Retired": 517,
      "Rank": 342,
      "ActiveInterests": 561,
      "ContactDepartment": "",
      "ContactCountryId": 269,
      "ContactOrgNr": "535782",
      "FaxPhone": "196-536-3409",
      "MobilePhone": "(190)925-7017 x31800",
      "ContactPhone": "(905)144-6435 x1903",
      "AssociateName": "Towne LLC",
      "AssociateId": 785,
      "UsePersonAddress": false,
      "ContactFax": "dolore",
      "Kanafname": "adipisci",
      "Kanalname": "sed",
      "Post1": "cumque",
      "Post2": "corrupti",
      "Post3": "autem",
      "EmailName": "salvador_considine@schaeferglover.co.uk",
      "ContactFullName": "Keshawn Armstrong",
      "ActiveErpLinks": 836,
      "TicketPriorityId": 333,
      "SupportLanguageId": 696,
      "SupportAssociateId": 380,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 753
        }
      }
    }
  ],
  "AlertLevel": 989,
  "ConnectId": 329,
  "ReadStatus": "Green",
  "TimeToReply": 94,
  "RealTimeToReply": 871,
  "TimeToClose": 991,
  "RealTimeToClose": 344,
  "TimeSpentInternally": 932,
  "TimeSpentExternally": 51,
  "TimeSpentQueue": 17,
  "RealTimeSpentInternally": 351,
  "RealTimeSpentExternally": 375,
  "RealTimeSpentQueue": 62,
  "HasAttachment": true,
  "NumReplies": 860,
  "NumMessages": 983,
  "FromAddress": "numquam",
  "Messages": [
    {
      "TicketMessageId": 411,
      "CreatedAt": "2022-10-14T12:15:20.2887325+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "inventore",
      "PersonId": 543,
      "PersonFullName": "Ross Marks",
      "ContactId": 463,
      "ContactName": "Sauer LLC",
      "ContactDepartment": "",
      "NumAttachments": 535,
      "EmailHeader": "danny@kub.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "earum",
      "Sentiment": 47,
      "SentimentConfidence": 391,
      "CreatedBy": 754,
      "ChangedAt": "2007-04-19T12:15:20.2887325+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 688
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 515,
      "Name": "Kris, Jones and Schulist",
      "ToolTip": "Error et qui.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 304
        }
      }
    },
    {
      "Id": 515,
      "Name": "Kris, Jones and Schulist",
      "ToolTip": "Error et qui.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 304
        }
      }
    }
  ],
  "Language": "explicabo",
  "Sentiment": 193,
  "SentimentConfidence": 591,
  "SuggestedCategoryId": 426,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 488,
  "IconHint": "corrupti",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "saepe",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "officia",
    "CustomFields2": "cupiditate"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 723
    }
  }
}
```