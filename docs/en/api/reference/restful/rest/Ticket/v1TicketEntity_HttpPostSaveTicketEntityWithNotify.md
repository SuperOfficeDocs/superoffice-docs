---
title: POST Ticket
uid: v1TicketEntity_HttpPostSaveTicketEntityWithNotify
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
POST /api/v1/Ticket?notify=True
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
| Sale | Sale | The sale that this ticket is connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket is connected to  <para>Use MDO List name "project" to get list items.</para> |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
  "TicketId": 349,
  "Title": "ut",
  "CreatedAt": "2001-03-28T03:51:34.052187+02:00",
  "LastChanged": "2010-01-01T03:51:34.052187+01:00",
  "ReadByOwner": "2002-01-02T03:51:34.052187+01:00",
  "ReadByCustomer": "1999-06-22T03:51:34.052187+02:00",
  "FirstReadByOwner": "2002-08-27T03:51:34.052187+02:00",
  "FirstReadByUser": "2015-07-20T03:51:34.052187+02:00",
  "Activate": "2007-07-23T03:51:34.052187+02:00",
  "ClosedAt": "2011-04-30T03:51:34.052187+02:00",
  "RepliedAt": "2012-01-07T03:51:34.052187+01:00",
  "AlertTimeout": "2015-01-02T03:51:34.052187+01:00",
  "Deadline": "2020-03-06T03:51:34.052187+01:00",
  "CreatedBy": null,
  "Author": "eos",
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
      "Position": "autem",
      "PersonId": 630,
      "Mrmrs": "dolor",
      "Firstname": "Claire",
      "Lastname": "Rosenbaum",
      "MiddleName": "Borer-Brown",
      "Title": "quidem",
      "Description": "Ameliorated upward-trending middleware",
      "Email": "juvenal.medhurst@leuschke.uk",
      "FullName": "Kelley Ricardo Pacocha PhD",
      "DirectPhone": "830-869-7890",
      "FormalName": "Runolfsdottir-Crona",
      "CountryId": 921,
      "ContactId": 954,
      "ContactName": "Schamberger-West",
      "Retired": 46,
      "Rank": 797,
      "ActiveInterests": 557,
      "ContactDepartment": "",
      "ContactCountryId": 481,
      "ContactOrgNr": "452379",
      "FaxPhone": "(753)203-8373 x37236",
      "MobilePhone": "1-907-465-5595 x47652",
      "ContactPhone": "088-876-4317 x0397",
      "AssociateName": "Johnston, Davis and Aufderhar",
      "AssociateId": 899,
      "UsePersonAddress": true,
      "ContactFax": "sit",
      "Kanafname": "suscipit",
      "Kanalname": "et",
      "Post1": "accusamus",
      "Post2": "non",
      "Post3": "at",
      "EmailName": "austin@prohaska.name",
      "ContactFullName": "Freddy Lindgren",
      "ActiveErpLinks": 656,
      "TicketPriorityId": 836,
      "SupportLanguageId": 495,
      "SupportAssociateId": 840,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 673,
  "ConnectId": 611,
  "ReadStatus": "Green",
  "TimeToReply": 866,
  "RealTimeToReply": 913,
  "TimeToClose": 825,
  "RealTimeToClose": 820,
  "TimeSpentInternally": 393,
  "TimeSpentExternally": 405,
  "TimeSpentQueue": 821,
  "RealTimeSpentInternally": 820,
  "RealTimeSpentExternally": 284,
  "RealTimeSpentQueue": 468,
  "HasAttachment": false,
  "NumReplies": 707,
  "NumMessages": 737,
  "FromAddress": "vitae",
  "Messages": [
    {
      "TicketMessageId": 986,
      "CreatedAt": "2012-08-05T03:51:34.052187+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "dolor",
      "PersonId": 361,
      "PersonFullName": "Kaci Rolfson",
      "ContactId": 769,
      "ContactName": "Dare LLC",
      "ContactDepartment": "",
      "NumAttachments": 300,
      "EmailHeader": "toni@casperconroy.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "veniam",
      "Sentiment": 49,
      "SentimentConfidence": 239,
      "CreatedBy": 997,
      "ChangedAt": "2021-11-24T03:51:34.052187+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 354,
      "Name": "Leannon Inc and Sons",
      "ToolTip": "Numquam enim illo debitis possimus et ex."
    },
    {
      "Id": 354,
      "Name": "Leannon Inc and Sons",
      "ToolTip": "Numquam enim illo debitis possimus et ex."
    }
  ],
  "Language": "consectetur",
  "Sentiment": 742,
  "SentimentConfidence": 117,
  "SuggestedCategoryId": 948,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 537,
  "IconHint": "consequatur",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "soluta",
    "CustomFields2": "iusto"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 413,
  "Title": "neque",
  "CreatedAt": "2003-08-05T03:51:34.0678657+02:00",
  "LastChanged": "2002-03-08T03:51:34.0678657+01:00",
  "ReadByOwner": "2016-07-29T03:51:34.0678657+02:00",
  "ReadByCustomer": "1998-02-18T03:51:34.0678657+01:00",
  "FirstReadByOwner": "1996-05-11T03:51:34.0678657+02:00",
  "FirstReadByUser": "2004-09-15T03:51:34.0678657+02:00",
  "Activate": "2007-06-22T03:51:34.0678657+02:00",
  "ClosedAt": "2014-11-07T03:51:34.0678657+01:00",
  "RepliedAt": "2012-10-22T03:51:34.0678657+02:00",
  "AlertTimeout": "2022-07-04T03:51:34.0678657+02:00",
  "Deadline": "1998-05-11T03:51:34.0678657+02:00",
  "CreatedBy": null,
  "Author": "voluptatem",
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
      "Position": "consequatur",
      "PersonId": 881,
      "Mrmrs": "officia",
      "Firstname": "Kamron",
      "Lastname": "Ebert",
      "MiddleName": "Feest, Skiles and Schoen",
      "Title": "qui",
      "Description": "Exclusive incremental intranet",
      "Email": "jackeline@hickle.info",
      "FullName": "Steve Gleason DVM",
      "DirectPhone": "014.991.4139 x9227",
      "FormalName": "Parker-Ryan",
      "CountryId": 653,
      "ContactId": 339,
      "ContactName": "Schmitt LLC",
      "Retired": 744,
      "Rank": 755,
      "ActiveInterests": 408,
      "ContactDepartment": "",
      "ContactCountryId": 944,
      "ContactOrgNr": "1147739",
      "FaxPhone": "941.243.4910",
      "MobilePhone": "1-699-643-2326",
      "ContactPhone": "512.158.4152",
      "AssociateName": "Ortiz-Skiles",
      "AssociateId": 545,
      "UsePersonAddress": true,
      "ContactFax": "delectus",
      "Kanafname": "repudiandae",
      "Kanalname": "molestias",
      "Post1": "iste",
      "Post2": "et",
      "Post3": "cumque",
      "EmailName": "rozella_dubuque@kerluke.info",
      "ContactFullName": "Shanny Corkery",
      "ActiveErpLinks": 401,
      "TicketPriorityId": 627,
      "SupportLanguageId": 358,
      "SupportAssociateId": 484,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 730
        }
      }
    }
  ],
  "AlertLevel": 932,
  "ConnectId": 44,
  "ReadStatus": "Green",
  "TimeToReply": 867,
  "RealTimeToReply": 241,
  "TimeToClose": 59,
  "RealTimeToClose": 399,
  "TimeSpentInternally": 559,
  "TimeSpentExternally": 637,
  "TimeSpentQueue": 714,
  "RealTimeSpentInternally": 890,
  "RealTimeSpentExternally": 724,
  "RealTimeSpentQueue": 918,
  "HasAttachment": false,
  "NumReplies": 64,
  "NumMessages": 357,
  "FromAddress": "amet",
  "Messages": [
    {
      "TicketMessageId": 923,
      "CreatedAt": "2005-01-14T03:51:34.0678657+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "voluptas",
      "PersonId": 130,
      "PersonFullName": "Bailey Dietrich",
      "ContactId": 847,
      "ContactName": "Volkman-Moore",
      "ContactDepartment": "",
      "NumAttachments": 326,
      "EmailHeader": "crystel.fadel@mayertgibson.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "illo",
      "Sentiment": 787,
      "SentimentConfidence": 992,
      "CreatedBy": 181,
      "ChangedAt": "1997-02-19T03:51:34.0678657+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 805
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 857,
      "Name": "Koelpin, Schmidt and Hand",
      "ToolTip": "Eius voluptas temporibus porro nihil neque molestiae dolor.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 897
        }
      }
    },
    {
      "Id": 857,
      "Name": "Koelpin, Schmidt and Hand",
      "ToolTip": "Eius voluptas temporibus porro nihil neque molestiae dolor.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 897
        }
      }
    }
  ],
  "Language": "deleniti",
  "Sentiment": 365,
  "SentimentConfidence": 98,
  "SuggestedCategoryId": 236,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 40,
  "IconHint": "suscipit",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "odit",
    "ExtraFields2": "labore"
  },
  "CustomFields": {
    "CustomFields1": "assumenda",
    "CustomFields2": "deleniti"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 954
    }
  }
}
```