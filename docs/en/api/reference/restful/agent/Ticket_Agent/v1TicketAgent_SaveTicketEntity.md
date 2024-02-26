---
title: POST Agents/Ticket/SaveTicketEntity
uid: v1TicketAgent_SaveTicketEntity
generated: true
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
| TimeSpent | Integer | The total time (minutes). Aggregated time spent from ticket&amp;apos;s messages. Read-only for external use. |
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
| Sale | Sale | The sale that this ticket is connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket is connected to  <para>Use MDO List name "project" to get list items.</para> |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| TicketType | TicketType | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
| ActiveStatusMonitorId | Integer | Active status monitor identity for related contact. This is a read-only property and is ignored on Save |
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
| OwnedBy | Associate | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  Use MDO List name "associate" to get list items. |
| Category | TicketCategoryEntity | The ticket category entity which this ticket is connected to  Use MDO List name "ejcategory" to get list items. |
| Slevel | string | The securitylevel of the ticket. |
| Priority | TicketPriorityEntity | The ticket priority entity which this ticket is connected to  Use MDO List name "ticketpriority" to get list items. |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  Use MDO List name "ticketstatus" to get list items. |
| Status | TicketStatusEntity | The ticket status entity which this ticket is connected to  Use MDO List name "ticketstatus" to get list items. |
| Origin | string | What is the origin of this ticket |
| Person | Person | The primary person that this ticket is connected to  Use MDO List name "person_new" to get list items. |
| SecondaryPersons | array | The secondary persons this ticket is connected to  Use MDO List name "person_new" to get list items. |
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
| TimeSpent | int32 | The total time (minutes). Aggregated time spent from ticket&amp;apos;s messages. Read-only for external use. |
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
| Sale | Sale | The sale that this ticket is connected to  Use MDO List name "sale" to get list items. |
| Project | Project | The project that this ticket is connected to  Use MDO List name "project" to get list items. |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| TicketType | TicketType | Type of the Request  Use MDO List name "TicketType" to get list items. |
| ActiveStatusMonitorId | int32 | Active status monitor identity for related contact. This is a read-only property and is ignored on Save |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
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
  "TicketId": 917,
  "Title": "facilis",
  "CreatedAt": "2016-08-16T10:30:24.7642118+02:00",
  "LastChanged": "1998-08-15T10:30:24.7642118+02:00",
  "ReadByOwner": "2006-03-08T10:30:24.7642118+01:00",
  "ReadByCustomer": "1999-02-19T10:30:24.7642118+01:00",
  "FirstReadByOwner": "2003-01-14T10:30:24.7642118+01:00",
  "FirstReadByUser": "2009-10-18T10:30:24.7642118+02:00",
  "Activate": "2022-07-16T10:30:24.7642118+02:00",
  "ClosedAt": "2003-12-31T10:30:24.7642118+01:00",
  "RepliedAt": "2015-07-13T10:30:24.7642118+02:00",
  "AlertTimeout": "1996-12-07T10:30:24.7642118+01:00",
  "Deadline": "2013-01-10T10:30:24.7642118+01:00",
  "CreatedBy": null,
  "Author": "iure",
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
      "Position": "facilis",
      "PersonId": 819,
      "Mrmrs": "quaerat",
      "Firstname": "Tiffany",
      "Lastname": "Mosciski",
      "MiddleName": "Bosco-Langworth",
      "Title": "aut",
      "Description": "Integrated uniform time-frame",
      "Email": "efren.kulas@jast.info",
      "FullName": "Kenneth Funk",
      "DirectPhone": "(064)954-7048 x74148",
      "FormalName": "Nitzsche-Balistreri",
      "CountryId": 831,
      "ContactId": 231,
      "ContactName": "Larkin LLC",
      "Retired": 124,
      "Rank": 198,
      "ActiveInterests": 517,
      "ContactDepartment": "",
      "ContactCountryId": 41,
      "ContactOrgNr": "1560603",
      "FaxPhone": "539.402.4015 x89625",
      "MobilePhone": "(328)720-5226",
      "ContactPhone": "938-013-0520 x483",
      "AssociateName": "Torp Inc and Sons",
      "AssociateId": 269,
      "UsePersonAddress": true,
      "ContactFax": "voluptatem",
      "Kanafname": "quaerat",
      "Kanalname": "nihil",
      "Post1": "et",
      "Post2": "recusandae",
      "Post3": "possimus",
      "EmailName": "florine_stanton@maggio.name",
      "ContactFullName": "Caroline Swift",
      "ActiveErpLinks": 443,
      "TicketPriorityId": 150,
      "SupportLanguageId": 288,
      "SupportAssociateId": 113,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 99,
  "ConnectId": 815,
  "ReadStatus": "Green",
  "TimeToReply": 593,
  "RealTimeToReply": 267,
  "TimeToClose": 548,
  "RealTimeToClose": 418,
  "TimeSpentInternally": 734,
  "TimeSpentExternally": 943,
  "TimeSpentQueue": 707,
  "RealTimeSpentInternally": 750,
  "RealTimeSpentExternally": 290,
  "RealTimeSpentQueue": 161,
  "TimeSpent": 840,
  "HasAttachment": false,
  "NumReplies": 314,
  "NumMessages": 797,
  "FromAddress": "nobis",
  "Messages": [
    {
      "TicketMessageId": 80,
      "CreatedAt": "2006-07-26T10:30:24.7798374+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "iusto",
      "PersonId": 538,
      "PersonFullName": "Dixie Parker",
      "ContactId": 380,
      "ContactName": "Erdman-Hettinger",
      "ContactDepartment": "",
      "NumAttachments": 276,
      "EmailHeader": "may@king.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "autem",
      "Sentiment": 96,
      "SentimentConfidence": 518,
      "CreatedBy": 921,
      "ChangedAt": "2007-03-25T10:30:24.7798374+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 39,
      "Name": "Kozey-Romaguera",
      "ToolTip": "Veritatis ex illo tempora neque corrupti neque omnis."
    },
    {
      "Id": 39,
      "Name": "Kozey-Romaguera",
      "ToolTip": "Veritatis ex illo tempora neque corrupti neque omnis."
    }
  ],
  "Language": "et",
  "Sentiment": 790,
  "SentimentConfidence": 810,
  "SuggestedCategoryId": 992,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 711,
  "IconHint": "esse",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 529,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "sunt"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "quasi"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 691,
  "Title": "sit",
  "CreatedAt": "2006-03-25T10:30:24.7798374+01:00",
  "LastChanged": "2002-05-25T10:30:24.7798374+02:00",
  "ReadByOwner": "2006-12-21T10:30:24.7798374+01:00",
  "ReadByCustomer": "2016-04-17T10:30:24.7798374+02:00",
  "FirstReadByOwner": "2013-01-11T10:30:24.7798374+01:00",
  "FirstReadByUser": "2009-10-11T10:30:24.7798374+02:00",
  "Activate": "2005-05-08T10:30:24.7798374+02:00",
  "ClosedAt": "1999-01-30T10:30:24.7798374+01:00",
  "RepliedAt": "2023-10-06T10:30:24.7798374+02:00",
  "AlertTimeout": "2015-01-29T10:30:24.7798374+01:00",
  "Deadline": "2010-11-30T10:30:24.7798374+01:00",
  "CreatedBy": null,
  "Author": "quasi",
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
      "Position": "sed",
      "PersonId": 673,
      "Mrmrs": "amet",
      "Firstname": "Danial",
      "Lastname": "Cruickshank",
      "MiddleName": "Kutch LLC",
      "Title": "quia",
      "Description": "Down-sized global throughput",
      "Email": "tommie@gerlachhahn.info",
      "FullName": "Ms. Jaeden Rasheed Bruen V",
      "DirectPhone": "1-428-512-0284 x471",
      "FormalName": "Ritchie-Predovic",
      "CountryId": 651,
      "ContactId": 822,
      "ContactName": "Satterfield, Turner and O'Conner",
      "Retired": 783,
      "Rank": 954,
      "ActiveInterests": 357,
      "ContactDepartment": "",
      "ContactCountryId": 952,
      "ContactOrgNr": "863411",
      "FaxPhone": "1-739-277-1455",
      "MobilePhone": "659-078-9112",
      "ContactPhone": "1-903-717-4224",
      "AssociateName": "Heaney Inc and Sons",
      "AssociateId": 583,
      "UsePersonAddress": false,
      "ContactFax": "tempora",
      "Kanafname": "est",
      "Kanalname": "architecto",
      "Post1": "in",
      "Post2": "nam",
      "Post3": "est",
      "EmailName": "nikolas@stoltenberg.name",
      "ContactFullName": "Trudie Satterfield",
      "ActiveErpLinks": 14,
      "TicketPriorityId": 127,
      "SupportLanguageId": 945,
      "SupportAssociateId": 932,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 95
        }
      }
    }
  ],
  "AlertLevel": 1000,
  "ConnectId": 9,
  "ReadStatus": "Green",
  "TimeToReply": 875,
  "RealTimeToReply": 892,
  "TimeToClose": 250,
  "RealTimeToClose": 30,
  "TimeSpentInternally": 521,
  "TimeSpentExternally": 65,
  "TimeSpentQueue": 528,
  "RealTimeSpentInternally": 210,
  "RealTimeSpentExternally": 845,
  "RealTimeSpentQueue": 427,
  "TimeSpent": 301,
  "HasAttachment": false,
  "NumReplies": 930,
  "NumMessages": 903,
  "FromAddress": "laboriosam",
  "Messages": [
    {
      "TicketMessageId": 820,
      "CreatedAt": "2016-04-22T10:30:24.7798374+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "ut",
      "PersonId": 908,
      "PersonFullName": "Okey Keeling",
      "ContactId": 864,
      "ContactName": "Beatty-Herzog",
      "ContactDepartment": "",
      "NumAttachments": 90,
      "EmailHeader": "columbus@lind.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "impedit",
      "Sentiment": 167,
      "SentimentConfidence": 864,
      "CreatedBy": 130,
      "ChangedAt": "2018-04-29T10:30:24.7798374+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 901
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 26,
      "Name": "Stark, Graham and Krajcik",
      "ToolTip": "Expedita nihil quibusdam quia voluptate veniam et sit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 270
        }
      }
    },
    {
      "Id": 26,
      "Name": "Stark, Graham and Krajcik",
      "ToolTip": "Expedita nihil quibusdam quia voluptate veniam et sit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 270
        }
      }
    }
  ],
  "Language": "voluptatibus",
  "Sentiment": 550,
  "SentimentConfidence": 978,
  "SuggestedCategoryId": 286,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 514,
  "IconHint": "in",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 722,
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "necessitatibus"
  },
  "CustomFields": {
    "CustomFields1": "vel",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 35
    }
  }
}
```