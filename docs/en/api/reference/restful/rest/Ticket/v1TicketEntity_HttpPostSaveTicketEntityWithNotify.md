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
  "TicketId": 117,
  "Title": "et",
  "CreatedAt": "2017-10-14T16:55:30.1660257+02:00",
  "LastChanged": "2014-09-07T16:55:30.1660257+02:00",
  "ReadByOwner": "2015-01-09T16:55:30.1660257+01:00",
  "ReadByCustomer": "2002-11-19T16:55:30.1660257+01:00",
  "FirstReadByOwner": "2007-05-08T16:55:30.1660257+02:00",
  "FirstReadByUser": "2004-05-06T16:55:30.1660257+02:00",
  "Activate": "2007-03-06T16:55:30.1660257+01:00",
  "ClosedAt": "2001-04-20T16:55:30.1660257+02:00",
  "RepliedAt": "2008-04-22T16:55:30.1660257+02:00",
  "AlertTimeout": "2012-10-07T16:55:30.1660257+02:00",
  "Deadline": "2017-01-13T16:55:30.1660257+01:00",
  "CreatedBy": null,
  "Author": "repellendus",
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
      "Position": "omnis",
      "PersonId": 887,
      "Mrmrs": "exercitationem",
      "Firstname": "Makenna",
      "Lastname": "Sipes",
      "MiddleName": "Corkery-Hyatt",
      "Title": "vero",
      "Description": "Universal empowering website",
      "Email": "carmella@stanton.name",
      "FullName": "Ms. Abdiel White Sr.",
      "DirectPhone": "486-790-2510 x909",
      "FormalName": "Cole, Bechtelar and Wintheiser",
      "CountryId": 66,
      "ContactId": 803,
      "ContactName": "Kuhic LLC",
      "Retired": 94,
      "Rank": 776,
      "ActiveInterests": 678,
      "ContactDepartment": "",
      "ContactCountryId": 980,
      "ContactOrgNr": "1081353",
      "FaxPhone": "(899)430-8620",
      "MobilePhone": "850.355.7266",
      "ContactPhone": "122-534-2488 x10682",
      "AssociateName": "Connelly Inc and Sons",
      "AssociateId": 345,
      "UsePersonAddress": false,
      "ContactFax": "voluptatem",
      "Kanafname": "sed",
      "Kanalname": "quis",
      "Post1": "et",
      "Post2": "quia",
      "Post3": "impedit",
      "EmailName": "marilyne.hermann@schinner.info",
      "ContactFullName": "Mrs. Kurt Blick",
      "ActiveErpLinks": 20,
      "TicketPriorityId": 649,
      "SupportLanguageId": 71,
      "SupportAssociateId": 256,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 983,
  "ConnectId": 396,
  "ReadStatus": "Green",
  "TimeToReply": 939,
  "RealTimeToReply": 351,
  "TimeToClose": 628,
  "RealTimeToClose": 647,
  "TimeSpentInternally": 824,
  "TimeSpentExternally": 887,
  "TimeSpentQueue": 690,
  "RealTimeSpentInternally": 632,
  "RealTimeSpentExternally": 800,
  "RealTimeSpentQueue": 871,
  "TimeSpent": 273,
  "HasAttachment": false,
  "NumReplies": 551,
  "NumMessages": 504,
  "FromAddress": "praesentium",
  "Messages": [
    {
      "TicketMessageId": 598,
      "CreatedAt": "2005-08-24T16:55:30.1710207+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "dolore",
      "PersonId": 962,
      "PersonFullName": "Dr. Adrain Romaguera DVM",
      "ContactId": 667,
      "ContactName": "Marvin LLC",
      "ContactDepartment": "",
      "NumAttachments": 437,
      "EmailHeader": "hermann@huelsoconner.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ipsa",
      "Sentiment": 364,
      "SentimentConfidence": 738,
      "CreatedBy": 928,
      "ChangedAt": "2002-05-05T16:55:30.1720201+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 372,
      "Name": "Vandervort-Will",
      "ToolTip": "Sint autem."
    },
    {
      "Id": 372,
      "Name": "Vandervort-Will",
      "ToolTip": "Sint autem."
    }
  ],
  "Language": "dicta",
  "Sentiment": 339,
  "SentimentConfidence": 338,
  "SuggestedCategoryId": 782,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 634,
  "IconHint": "eius",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 286,
  "ExtraFields": {
    "ExtraFields1": "dignissimos",
    "ExtraFields2": "magnam"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "vitae"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 808,
  "Title": "inventore",
  "CreatedAt": "2012-07-17T16:55:30.1790454+02:00",
  "LastChanged": "2017-04-18T16:55:30.1790454+02:00",
  "ReadByOwner": "2000-06-29T16:55:30.1790454+02:00",
  "ReadByCustomer": "2020-08-29T16:55:30.1790454+02:00",
  "FirstReadByOwner": "2011-01-11T16:55:30.1790454+01:00",
  "FirstReadByUser": "2001-11-21T16:55:30.1790454+01:00",
  "Activate": "2013-09-26T16:55:30.1790454+02:00",
  "ClosedAt": "1997-10-26T16:55:30.1790454+01:00",
  "RepliedAt": "1998-11-30T16:55:30.1790454+01:00",
  "AlertTimeout": "2020-06-22T16:55:30.1790454+02:00",
  "Deadline": "2012-06-07T16:55:30.1790454+02:00",
  "CreatedBy": null,
  "Author": "libero",
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
      "Position": "veniam",
      "PersonId": 997,
      "Mrmrs": "deserunt",
      "Firstname": "Evelyn",
      "Lastname": "Schaefer",
      "MiddleName": "Aufderhar, Hessel and West",
      "Title": "illum",
      "Description": "Automated 6th generation throughput",
      "Email": "beth_greenholt@nitzsche.info",
      "FullName": "Lew Kessler",
      "DirectPhone": "297-853-7353 x721",
      "FormalName": "Gleason Group",
      "CountryId": 63,
      "ContactId": 549,
      "ContactName": "Hartmann-Ebert",
      "Retired": 202,
      "Rank": 138,
      "ActiveInterests": 610,
      "ContactDepartment": "",
      "ContactCountryId": 198,
      "ContactOrgNr": "601891",
      "FaxPhone": "717.246.4355 x11982",
      "MobilePhone": "875.576.4807 x5077",
      "ContactPhone": "051-191-7317",
      "AssociateName": "Swift, Zboncak and Bailey",
      "AssociateId": 890,
      "UsePersonAddress": false,
      "ContactFax": "molestias",
      "Kanafname": "reprehenderit",
      "Kanalname": "atque",
      "Post1": "animi",
      "Post2": "molestiae",
      "Post3": "minus",
      "EmailName": "jarrod.harris@vandervort.co.uk",
      "ContactFullName": "Fermin Aufderhar V",
      "ActiveErpLinks": 626,
      "TicketPriorityId": 568,
      "SupportLanguageId": 169,
      "SupportAssociateId": 802,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 58
        }
      }
    }
  ],
  "AlertLevel": 578,
  "ConnectId": 179,
  "ReadStatus": "Green",
  "TimeToReply": 744,
  "RealTimeToReply": 567,
  "TimeToClose": 418,
  "RealTimeToClose": 928,
  "TimeSpentInternally": 653,
  "TimeSpentExternally": 944,
  "TimeSpentQueue": 930,
  "RealTimeSpentInternally": 170,
  "RealTimeSpentExternally": 138,
  "RealTimeSpentQueue": 508,
  "TimeSpent": 585,
  "HasAttachment": true,
  "NumReplies": 785,
  "NumMessages": 954,
  "FromAddress": "sunt",
  "Messages": [
    {
      "TicketMessageId": 781,
      "CreatedAt": "2022-04-09T16:55:30.1830462+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "quia",
      "PersonId": 576,
      "PersonFullName": "Ms. Zack Rashawn Kreiger",
      "ContactId": 583,
      "ContactName": "Anderson, Cummings and Bauch",
      "ContactDepartment": "syndicate best-of-breed e-commerce",
      "NumAttachments": 839,
      "EmailHeader": "beaulah@nitzscheblock.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "aut",
      "Sentiment": 221,
      "SentimentConfidence": 946,
      "CreatedBy": 636,
      "ChangedAt": "2002-03-29T16:55:30.1830462+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 403
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 917,
      "Name": "Bauch, Kertzmann and Welch",
      "ToolTip": "Nemo ut non rerum ducimus est.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 849
        }
      }
    },
    {
      "Id": 917,
      "Name": "Bauch, Kertzmann and Welch",
      "ToolTip": "Nemo ut non rerum ducimus est.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 849
        }
      }
    }
  ],
  "Language": "id",
  "Sentiment": 226,
  "SentimentConfidence": 379,
  "SuggestedCategoryId": 107,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 908,
  "IconHint": "fugit",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 100,
  "ExtraFields": {
    "ExtraFields1": "eaque",
    "ExtraFields2": "id"
  },
  "CustomFields": {
    "CustomFields1": "occaecati",
    "CustomFields2": "sapiente"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 143
    }
  }
}
```