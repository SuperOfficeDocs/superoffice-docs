---
title: PUT Ticket/{id}
uid: v1TicketEntity_HttpPutSaveTicketEntityWithNotify
generated: true
---

# PUT Ticket/{id}

```http
PUT /api/v1/Ticket/{id}
```

Saves a ticket and performs any user notifications






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The TicketEntity id to update **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| notify | bool |  If true, then the notifications will be sent |

```http
PUT /api/v1/Ticket/{id}?notify=False
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
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 122,
  "Title": "quia",
  "CreatedAt": "2017-11-21T13:13:32.4017612+01:00",
  "LastChanged": "2002-07-11T13:13:32.4017612+02:00",
  "ReadByOwner": "2021-07-15T13:13:32.4017612+02:00",
  "ReadByCustomer": "2003-12-20T13:13:32.4017612+01:00",
  "FirstReadByOwner": "2000-08-23T13:13:32.4017612+02:00",
  "FirstReadByUser": "2020-02-02T13:13:32.4017612+01:00",
  "Activate": "2022-03-15T13:13:32.4017612+01:00",
  "ClosedAt": "2005-02-19T13:13:32.4017612+01:00",
  "RepliedAt": "2018-08-18T13:13:32.4017612+02:00",
  "AlertTimeout": "2013-07-14T13:13:32.4017612+02:00",
  "Deadline": "2020-09-04T13:13:32.4017612+02:00",
  "CreatedBy": null,
  "Author": "quam",
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
      "Position": "dignissimos",
      "PersonId": 99,
      "Mrmrs": "quia",
      "Firstname": "Judge",
      "Lastname": "Gottlieb",
      "MiddleName": "Botsford, Grant and Quitzon",
      "Title": "et",
      "Description": "Innovative mission-critical parallelism",
      "Email": "bonnie.keebler@torphykonopelski.name",
      "FullName": "Talia Windler",
      "DirectPhone": "727-429-7203",
      "FormalName": "Schamberger-Ernser",
      "CountryId": 25,
      "ContactId": 736,
      "ContactName": "Welch, Koss and Roberts",
      "Retired": 321,
      "Rank": 836,
      "ActiveInterests": 547,
      "ContactDepartment": "",
      "ContactCountryId": 267,
      "ContactOrgNr": "1249818",
      "FaxPhone": "(433)090-2554 x96560",
      "MobilePhone": "286.790.8625 x2937",
      "ContactPhone": "021.043.9039 x260",
      "AssociateName": "Stanton, Franecki and McKenzie",
      "AssociateId": 701,
      "UsePersonAddress": false,
      "ContactFax": "modi",
      "Kanafname": "quia",
      "Kanalname": "laudantium",
      "Post1": "quaerat",
      "Post2": "et",
      "Post3": "quo",
      "EmailName": "raul@fayhaley.uk",
      "ContactFullName": "Alana Glover",
      "ActiveErpLinks": 347,
      "TicketPriorityId": 560,
      "SupportLanguageId": 427,
      "SupportAssociateId": 72,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 634,
  "ConnectId": 174,
  "ReadStatus": "Green",
  "TimeToReply": 709,
  "RealTimeToReply": 291,
  "TimeToClose": 902,
  "RealTimeToClose": 533,
  "TimeSpentInternally": 835,
  "TimeSpentExternally": 277,
  "TimeSpentQueue": 875,
  "RealTimeSpentInternally": 320,
  "RealTimeSpentExternally": 813,
  "RealTimeSpentQueue": 849,
  "TimeSpent": 397,
  "HasAttachment": true,
  "NumReplies": 235,
  "NumMessages": 747,
  "FromAddress": "praesentium",
  "Messages": [
    {
      "TicketMessageId": 809,
      "CreatedAt": "2017-11-05T13:13:32.4017612+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "et",
      "PersonId": 588,
      "PersonFullName": "Dovie Carroll",
      "ContactId": 932,
      "ContactName": "Weissnat, Klein and Breitenberg",
      "ContactDepartment": "",
      "NumAttachments": 108,
      "EmailHeader": "friedrich@rice.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "harum",
      "Sentiment": 285,
      "SentimentConfidence": 554,
      "CreatedBy": 184,
      "ChangedAt": "1999-03-18T13:13:32.4017612+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 525,
      "Name": "Schmitt LLC",
      "ToolTip": "Officia ipsum aut accusamus et deleniti."
    },
    {
      "Id": 525,
      "Name": "Schmitt LLC",
      "ToolTip": "Officia ipsum aut accusamus et deleniti."
    }
  ],
  "Language": "est",
  "Sentiment": 708,
  "SentimentConfidence": 13,
  "SuggestedCategoryId": 604,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 552,
  "IconHint": "excepturi",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 216,
  "ExtraFields": {
    "ExtraFields1": "sapiente",
    "ExtraFields2": "id"
  },
  "CustomFields": {
    "CustomFields1": "eum",
    "CustomFields2": "sit"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 1002,
  "Title": "hic",
  "CreatedAt": "2002-02-27T13:13:32.4173821+01:00",
  "LastChanged": "2024-06-10T13:13:32.4173821+02:00",
  "ReadByOwner": "2006-07-18T13:13:32.4173821+02:00",
  "ReadByCustomer": "2004-06-12T13:13:32.4173821+02:00",
  "FirstReadByOwner": "2001-01-24T13:13:32.4173821+01:00",
  "FirstReadByUser": "2003-04-07T13:13:32.4173821+02:00",
  "Activate": "2021-01-27T13:13:32.4173821+01:00",
  "ClosedAt": "2021-08-14T13:13:32.4173821+02:00",
  "RepliedAt": "2018-04-06T13:13:32.4173821+02:00",
  "AlertTimeout": "2007-11-28T13:13:32.4173821+01:00",
  "Deadline": "2011-03-16T13:13:32.4173821+01:00",
  "CreatedBy": null,
  "Author": "sapiente",
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
      "Position": "quam",
      "PersonId": 686,
      "Mrmrs": "atque",
      "Firstname": "Cristobal",
      "Lastname": "Stiedemann",
      "MiddleName": "Mills, Wilkinson and Borer",
      "Title": "provident",
      "Description": "Operative empowering array",
      "Email": "bart_mcclure@schaeferkemmer.biz",
      "FullName": "Kaleigh Fadel",
      "DirectPhone": "1-565-578-2465 x559",
      "FormalName": "Bailey, Schaden and Marks",
      "CountryId": 379,
      "ContactId": 174,
      "ContactName": "Kuphal Inc and Sons",
      "Retired": 869,
      "Rank": 9,
      "ActiveInterests": 805,
      "ContactDepartment": "",
      "ContactCountryId": 415,
      "ContactOrgNr": "1285582",
      "FaxPhone": "1-249-942-8651 x5156",
      "MobilePhone": "(702)152-6355 x11348",
      "ContactPhone": "1-349-899-0101",
      "AssociateName": "Kilback-Ritchie",
      "AssociateId": 508,
      "UsePersonAddress": true,
      "ContactFax": "accusantium",
      "Kanafname": "ut",
      "Kanalname": "occaecati",
      "Post1": "beatae",
      "Post2": "magni",
      "Post3": "necessitatibus",
      "EmailName": "alysson@bartell.uk",
      "ContactFullName": "Adrienne Jacynthe Mann MD",
      "ActiveErpLinks": 541,
      "TicketPriorityId": 185,
      "SupportLanguageId": 233,
      "SupportAssociateId": 98,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 979
        }
      }
    }
  ],
  "AlertLevel": 311,
  "ConnectId": 759,
  "ReadStatus": "Green",
  "TimeToReply": 743,
  "RealTimeToReply": 634,
  "TimeToClose": 553,
  "RealTimeToClose": 94,
  "TimeSpentInternally": 479,
  "TimeSpentExternally": 560,
  "TimeSpentQueue": 620,
  "RealTimeSpentInternally": 985,
  "RealTimeSpentExternally": 277,
  "RealTimeSpentQueue": 532,
  "TimeSpent": 2,
  "HasAttachment": true,
  "NumReplies": 227,
  "NumMessages": 583,
  "FromAddress": "corporis",
  "Messages": [
    {
      "TicketMessageId": 350,
      "CreatedAt": "2024-01-22T13:13:32.4173821+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "ut",
      "PersonId": 983,
      "PersonFullName": "Dudley Welch",
      "ContactId": 263,
      "ContactName": "Daniel-Funk",
      "ContactDepartment": "",
      "NumAttachments": 596,
      "EmailHeader": "dawn_frami@rogahn.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "aut",
      "Sentiment": 903,
      "SentimentConfidence": 124,
      "CreatedBy": 386,
      "ChangedAt": "2022-09-17T13:13:32.4173821+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 741
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 573,
      "Name": "Hand, Bradtke and Nolan",
      "ToolTip": "Eius aliquid molestiae et iste nobis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 353
        }
      }
    },
    {
      "Id": 573,
      "Name": "Hand, Bradtke and Nolan",
      "ToolTip": "Eius aliquid molestiae et iste nobis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 353
        }
      }
    }
  ],
  "Language": "ut",
  "Sentiment": 726,
  "SentimentConfidence": 866,
  "SuggestedCategoryId": 330,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 459,
  "IconHint": "aut",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 132,
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "nemo"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "laborum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 412
    }
  }
}
```