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
| Sale | Sale | The sale that this ticket is connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket is connected to  <para>Use MDO List name "project" to get list items.</para> |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| TicketType | TicketType | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
| ActiveStatusMonitorId | int32 | Active status monitor identity for related contact. This is a read-only property and is ignored on Save |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
  "TicketId": 502,
  "Title": "alias",
  "CreatedAt": "1999-12-12T23:04:04.8710084+01:00",
  "LastChanged": "2007-10-24T23:04:04.8710084+02:00",
  "ReadByOwner": "2020-06-18T23:04:04.8710084+02:00",
  "ReadByCustomer": "2017-06-10T23:04:04.8710084+02:00",
  "FirstReadByOwner": "1997-07-09T23:04:04.8710084+02:00",
  "FirstReadByUser": "1997-10-20T23:04:04.8710084+02:00",
  "Activate": "2004-02-12T23:04:04.8710084+01:00",
  "ClosedAt": "2013-02-23T23:04:04.8710084+01:00",
  "RepliedAt": "1998-02-24T23:04:04.8710084+01:00",
  "AlertTimeout": "2014-01-21T23:04:04.8710084+01:00",
  "Deadline": "2022-11-10T23:04:04.8710084+01:00",
  "CreatedBy": null,
  "Author": "hic",
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
      "PersonId": 177,
      "Mrmrs": "ut",
      "Firstname": "Loren",
      "Lastname": "Hayes",
      "MiddleName": "Conroy Group",
      "Title": "aliquid",
      "Description": "Visionary tertiary function",
      "Email": "jeremy@towne.name",
      "FullName": "Miss Cale Runolfsson",
      "DirectPhone": "(058)995-4706 x85726",
      "FormalName": "Gerhold Inc and Sons",
      "CountryId": 259,
      "ContactId": 251,
      "ContactName": "Vandervort-Nikolaus",
      "Retired": 455,
      "Rank": 262,
      "ActiveInterests": 429,
      "ContactDepartment": "",
      "ContactCountryId": 675,
      "ContactOrgNr": "315711",
      "FaxPhone": "1-854-580-2867",
      "MobilePhone": "(708)864-4692",
      "ContactPhone": "737.802.9510 x150",
      "AssociateName": "O'Reilly, Dicki and Jewess",
      "AssociateId": 373,
      "UsePersonAddress": false,
      "ContactFax": "corrupti",
      "Kanafname": "et",
      "Kanalname": "iusto",
      "Post1": "illo",
      "Post2": "est",
      "Post3": "unde",
      "EmailName": "josefa@aufderhar.name",
      "ContactFullName": "Alan Graham",
      "ActiveErpLinks": 189,
      "TicketPriorityId": 672,
      "SupportLanguageId": 352,
      "SupportAssociateId": 162,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 907,
  "ConnectId": 686,
  "ReadStatus": "Green",
  "TimeToReply": 686,
  "RealTimeToReply": 27,
  "TimeToClose": 370,
  "RealTimeToClose": 566,
  "TimeSpentInternally": 850,
  "TimeSpentExternally": 572,
  "TimeSpentQueue": 615,
  "RealTimeSpentInternally": 725,
  "RealTimeSpentExternally": 974,
  "RealTimeSpentQueue": 205,
  "TimeSpent": 456,
  "HasAttachment": true,
  "NumReplies": 359,
  "NumMessages": 883,
  "FromAddress": "deleniti",
  "Messages": [
    {
      "TicketMessageId": 397,
      "CreatedAt": "2013-08-20T23:04:04.8770073+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "est",
      "PersonId": 595,
      "PersonFullName": "Kristy Lubowitz",
      "ContactId": 866,
      "ContactName": "Gottlieb, Quitzon and Predovic",
      "ContactDepartment": "",
      "NumAttachments": 207,
      "EmailHeader": "oceane.shields@jaskolskipacocha.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "eum",
      "Sentiment": 76,
      "SentimentConfidence": 356,
      "CreatedBy": 455,
      "ChangedAt": "2007-04-22T23:04:04.8770073+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 24,
      "Name": "Baumbach Inc and Sons",
      "ToolTip": "Vero officia."
    },
    {
      "Id": 24,
      "Name": "Baumbach Inc and Sons",
      "ToolTip": "Vero officia."
    }
  ],
  "Language": "tenetur",
  "Sentiment": 974,
  "SentimentConfidence": 849,
  "SuggestedCategoryId": 816,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 84,
  "IconHint": "ratione",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 696,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "occaecati",
    "CustomFields2": "voluptatem"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 445,
  "Title": "rem",
  "CreatedAt": "2002-08-26T23:04:04.8860075+02:00",
  "LastChanged": "2010-02-08T23:04:04.8860075+01:00",
  "ReadByOwner": "2016-12-09T23:04:04.8860075+01:00",
  "ReadByCustomer": "2022-12-31T23:04:04.8860075+01:00",
  "FirstReadByOwner": "2014-11-22T23:04:04.8860075+01:00",
  "FirstReadByUser": "2020-07-12T23:04:04.8860075+02:00",
  "Activate": "2002-05-26T23:04:04.8860075+02:00",
  "ClosedAt": "2015-12-09T23:04:04.8860075+01:00",
  "RepliedAt": "2015-01-22T23:04:04.8860075+01:00",
  "AlertTimeout": "2005-10-21T23:04:04.8860075+02:00",
  "Deadline": "2019-01-30T23:04:04.8860075+01:00",
  "CreatedBy": null,
  "Author": "explicabo",
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
      "Position": "odit",
      "PersonId": 262,
      "Mrmrs": "quo",
      "Firstname": "Retha",
      "Lastname": "Wiza",
      "MiddleName": "Schiller, Goldner and Murazik",
      "Title": "veritatis",
      "Description": "Focused intermediate encoding",
      "Email": "alessandro.jewess@rolfson.name",
      "FullName": "Madelyn Kreiger",
      "DirectPhone": "588.127.8633",
      "FormalName": "Beier-Larkin",
      "CountryId": 700,
      "ContactId": 626,
      "ContactName": "Johns-Okuneva",
      "Retired": 918,
      "Rank": 548,
      "ActiveInterests": 289,
      "ContactDepartment": "",
      "ContactCountryId": 336,
      "ContactOrgNr": "999494",
      "FaxPhone": "186-067-4914",
      "MobilePhone": "1-709-322-5350 x380",
      "ContactPhone": "1-721-063-4832 x9522",
      "AssociateName": "McGlynn, Welch and Mraz",
      "AssociateId": 209,
      "UsePersonAddress": false,
      "ContactFax": "aut",
      "Kanafname": "laborum",
      "Kanalname": "quasi",
      "Post1": "veniam",
      "Post2": "qui",
      "Post3": "aut",
      "EmailName": "dee@wunschnicolas.name",
      "ContactFullName": "Regan Walker",
      "ActiveErpLinks": 873,
      "TicketPriorityId": 909,
      "SupportLanguageId": 666,
      "SupportAssociateId": 966,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 467
        }
      }
    }
  ],
  "AlertLevel": 1000,
  "ConnectId": 75,
  "ReadStatus": "Green",
  "TimeToReply": 195,
  "RealTimeToReply": 868,
  "TimeToClose": 526,
  "RealTimeToClose": 846,
  "TimeSpentInternally": 616,
  "TimeSpentExternally": 817,
  "TimeSpentQueue": 450,
  "RealTimeSpentInternally": 872,
  "RealTimeSpentExternally": 482,
  "RealTimeSpentQueue": 106,
  "TimeSpent": 229,
  "HasAttachment": false,
  "NumReplies": 41,
  "NumMessages": 290,
  "FromAddress": "voluptas",
  "Messages": [
    {
      "TicketMessageId": 793,
      "CreatedAt": "2003-11-24T23:04:04.891008+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "quasi",
      "PersonId": 893,
      "PersonFullName": "Jaquan Daugherty",
      "ContactId": 747,
      "ContactName": "Abernathy, Fritsch and Ferry",
      "ContactDepartment": "",
      "NumAttachments": 71,
      "EmailHeader": "kayden.johnson@turcotte.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "voluptas",
      "Sentiment": 341,
      "SentimentConfidence": 648,
      "CreatedBy": 8,
      "ChangedAt": "2007-07-03T23:04:04.8915087+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 503
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 726,
      "Name": "Bins LLC",
      "ToolTip": "In quas est commodi dolor dolore veniam suscipit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 770
        }
      }
    },
    {
      "Id": 726,
      "Name": "Bins LLC",
      "ToolTip": "In quas est commodi dolor dolore veniam suscipit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 770
        }
      }
    }
  ],
  "Language": "omnis",
  "Sentiment": 211,
  "SentimentConfidence": 950,
  "SuggestedCategoryId": 53,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 493,
  "IconHint": "id",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 226,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "dolores"
  },
  "CustomFields": {
    "CustomFields1": "consectetur",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 428
    }
  }
}
```