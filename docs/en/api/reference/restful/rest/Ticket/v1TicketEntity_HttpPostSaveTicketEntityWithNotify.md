---
title: POST Ticket
uid: v1TicketEntity_HttpPostSaveTicketEntityWithNotify
generated: true
---

# POST Ticket

```http
POST /api/v1/Ticket
```

Saves a ticket and performs any user notifications







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| notify | bool |  If true, then the notifications will be sent |

```http
POST /api/v1/Ticket?notify=False
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

The ticket to save 

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
POST /api/v1/Ticket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 609,
  "Title": "necessitatibus",
  "CreatedAt": "2003-06-05T14:28:27.2739309+02:00",
  "LastChanged": "2009-11-12T14:28:27.2739309+01:00",
  "ReadByOwner": "2003-04-29T14:28:27.2739309+02:00",
  "ReadByCustomer": "2019-07-30T14:28:27.2739309+02:00",
  "FirstReadByOwner": "2016-03-25T14:28:27.2739309+01:00",
  "FirstReadByUser": "2008-08-10T14:28:27.2739309+02:00",
  "Activate": "2001-12-21T14:28:27.2739309+01:00",
  "ClosedAt": "2019-06-30T14:28:27.2739309+02:00",
  "RepliedAt": "2009-04-17T14:28:27.2739309+02:00",
  "AlertTimeout": "2006-01-14T14:28:27.2739309+01:00",
  "Deadline": "2000-12-30T14:28:27.2739309+01:00",
  "CreatedBy": null,
  "Author": "magni",
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
      "Position": "perspiciatis",
      "PersonId": 148,
      "Mrmrs": "dignissimos",
      "Firstname": "Obie",
      "Lastname": "Homenick",
      "MiddleName": "Gerlach Inc and Sons",
      "Title": "ratione",
      "Description": "Exclusive motivating solution",
      "Email": "shad.tillman@borer.ca",
      "FullName": "Yoshiko Pfannerstill",
      "DirectPhone": "1-023-832-6384 x37119",
      "FormalName": "O'Hara-Crooks",
      "CountryId": 830,
      "ContactId": 867,
      "ContactName": "Morar-Windler",
      "Retired": 325,
      "Rank": 380,
      "ActiveInterests": 91,
      "ContactDepartment": "",
      "ContactCountryId": 81,
      "ContactOrgNr": "1472736",
      "FaxPhone": "(847)216-4069",
      "MobilePhone": "606-947-6163 x740",
      "ContactPhone": "073-259-6091",
      "AssociateName": "Hodkiewicz-Olson",
      "AssociateId": 489,
      "UsePersonAddress": false,
      "ContactFax": "culpa",
      "Kanafname": "ut",
      "Kanalname": "necessitatibus",
      "Post1": "libero",
      "Post2": "consequatur",
      "Post3": "accusantium",
      "EmailName": "herta@hartmann.ca",
      "ContactFullName": "Mr. Coty Deshawn Lebsack",
      "ActiveErpLinks": 972,
      "TicketPriorityId": 921,
      "SupportLanguageId": 940,
      "SupportAssociateId": 89,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1180639"
    }
  ],
  "AlertLevel": 297,
  "ConnectId": 621,
  "ReadStatus": "Green",
  "TimeToReply": 647,
  "RealTimeToReply": 13,
  "TimeToClose": 374,
  "RealTimeToClose": 200,
  "TimeSpentInternally": 406,
  "TimeSpentExternally": 375,
  "TimeSpentQueue": 707,
  "RealTimeSpentInternally": 198,
  "RealTimeSpentExternally": 592,
  "RealTimeSpentQueue": 697,
  "TimeSpent": 439,
  "HasAttachment": false,
  "NumReplies": 348,
  "NumMessages": 151,
  "FromAddress": "explicabo",
  "Messages": [
    {
      "TicketMessageId": 312,
      "CreatedAt": "2008-11-23T14:28:27.2739309+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "rerum",
      "PersonId": 888,
      "PersonFullName": "Jamar Russel",
      "ContactId": 396,
      "ContactName": "Boyle, Doyle and Murray",
      "ContactDepartment": "",
      "NumAttachments": 763,
      "EmailHeader": "leslie_lindgren@white.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "et",
      "Sentiment": 678,
      "SentimentConfidence": 831,
      "CreatedBy": 442,
      "ChangedAt": "1999-04-03T14:28:27.2739309+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 346,
      "Name": "Prohaska-Smith",
      "ToolTip": "Aperiam sint harum."
    },
    {
      "Id": 346,
      "Name": "Prohaska-Smith",
      "ToolTip": "Aperiam sint harum."
    }
  ],
  "Language": "et",
  "Sentiment": 951,
  "SentimentConfidence": 421,
  "SuggestedCategoryId": 403,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 368,
  "IconHint": "voluptates",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 700,
  "ExtraFields": {
    "ExtraFields1": "voluptates",
    "ExtraFields2": "veniam"
  },
  "CustomFields": {
    "CustomFields1": "vitae",
    "CustomFields2": "esse"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 980,
  "Title": "consequuntur",
  "CreatedAt": "2009-04-01T14:28:27.2739309+02:00",
  "LastChanged": "2016-08-08T14:28:27.2739309+02:00",
  "ReadByOwner": "2001-04-27T14:28:27.2739309+02:00",
  "ReadByCustomer": "2010-04-11T14:28:27.2739309+02:00",
  "FirstReadByOwner": "2006-10-29T14:28:27.2739309+01:00",
  "FirstReadByUser": "2001-04-30T14:28:27.2739309+02:00",
  "Activate": "2025-03-06T14:28:27.2739309+01:00",
  "ClosedAt": "2014-03-22T14:28:27.2739309+01:00",
  "RepliedAt": "2010-01-11T14:28:27.2739309+01:00",
  "AlertTimeout": "2024-08-28T14:28:27.2739309+02:00",
  "Deadline": "2011-07-29T14:28:27.2739309+02:00",
  "CreatedBy": null,
  "Author": "rerum",
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
      "Position": "accusamus",
      "PersonId": 446,
      "Mrmrs": "corrupti",
      "Firstname": "Dedrick",
      "Lastname": "Torp",
      "MiddleName": "Lowe LLC",
      "Title": "accusantium",
      "Description": "Adaptive maximized capacity",
      "Email": "janessa@carter.ca",
      "FullName": "Dameon Doyle",
      "DirectPhone": "1-444-575-2529 x25531",
      "FormalName": "Crona-Gulgowski",
      "CountryId": 203,
      "ContactId": 366,
      "ContactName": "Morar, Eichmann and Bashirian",
      "Retired": 991,
      "Rank": 874,
      "ActiveInterests": 937,
      "ContactDepartment": "",
      "ContactCountryId": 787,
      "ContactOrgNr": "1260154",
      "FaxPhone": "595.380.3262",
      "MobilePhone": "885-493-5018 x250",
      "ContactPhone": "109-529-5036 x99439",
      "AssociateName": "Koelpin, Collier and Weimann",
      "AssociateId": 867,
      "UsePersonAddress": false,
      "ContactFax": "velit",
      "Kanafname": "est",
      "Kanalname": "consectetur",
      "Post1": "impedit",
      "Post2": "soluta",
      "Post3": "expedita",
      "EmailName": "jana_sauer@bernier.info",
      "ContactFullName": "Ryan Gino Rath PhD",
      "ActiveErpLinks": 1000,
      "TicketPriorityId": 108,
      "SupportLanguageId": 709,
      "SupportAssociateId": 68,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1251036",
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
  "AlertLevel": 897,
  "ConnectId": 608,
  "ReadStatus": "Green",
  "TimeToReply": 105,
  "RealTimeToReply": 482,
  "TimeToClose": 388,
  "RealTimeToClose": 446,
  "TimeSpentInternally": 240,
  "TimeSpentExternally": 865,
  "TimeSpentQueue": 355,
  "RealTimeSpentInternally": 483,
  "RealTimeSpentExternally": 203,
  "RealTimeSpentQueue": 701,
  "TimeSpent": 607,
  "HasAttachment": false,
  "NumReplies": 110,
  "NumMessages": 884,
  "FromAddress": "aut",
  "Messages": [
    {
      "TicketMessageId": 406,
      "CreatedAt": "2010-03-06T14:28:27.2739309+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "et",
      "PersonId": 9,
      "PersonFullName": "Mr. Joshua Skiles Jr.",
      "ContactId": 509,
      "ContactName": "Treutel LLC",
      "ContactDepartment": "",
      "NumAttachments": 793,
      "EmailHeader": "hulda@legros.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "a",
      "Sentiment": 871,
      "SentimentConfidence": 869,
      "CreatedBy": 557,
      "ChangedAt": "2007-02-01T14:28:27.2739309+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 578
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 236,
      "Name": "Schmitt-Carroll",
      "ToolTip": "Fugit repudiandae tempore eos neque veniam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 138
        }
      }
    },
    {
      "Id": 236,
      "Name": "Schmitt-Carroll",
      "ToolTip": "Fugit repudiandae tempore eos neque veniam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 138
        }
      }
    }
  ],
  "Language": "qui",
  "Sentiment": 325,
  "SentimentConfidence": 138,
  "SuggestedCategoryId": 325,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 644,
  "IconHint": "dolores",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 352,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "quidem"
  },
  "CustomFields": {
    "CustomFields1": "magnam",
    "CustomFields2": "ipsam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 794
    }
  }
}
```