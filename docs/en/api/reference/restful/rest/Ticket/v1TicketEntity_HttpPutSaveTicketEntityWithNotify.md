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
PUT /api/v1/Ticket/{id}?notify=True
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketId": 291,
  "Title": "perferendis",
  "CreatedAt": "2002-12-06T03:45:28.6859307+01:00",
  "LastChanged": "2012-08-16T03:45:28.6859307+02:00",
  "ReadByOwner": "2017-08-13T03:45:28.6859307+02:00",
  "ReadByCustomer": "2011-05-28T03:45:28.6859307+02:00",
  "FirstReadByOwner": "2009-03-26T03:45:28.6859307+01:00",
  "FirstReadByUser": "1999-11-17T03:45:28.6859307+01:00",
  "Activate": "2009-06-22T03:45:28.6859307+02:00",
  "ClosedAt": "2015-07-25T03:45:28.6859307+02:00",
  "RepliedAt": "2017-05-08T03:45:28.6859307+02:00",
  "AlertTimeout": "2009-06-30T03:45:28.6859307+02:00",
  "Deadline": "2007-04-27T03:45:28.6859307+02:00",
  "CreatedBy": null,
  "Author": "ad",
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
      "Position": "voluptatibus",
      "PersonId": 27,
      "Mrmrs": "corrupti",
      "Firstname": "Lon",
      "Lastname": "Ruecker",
      "MiddleName": "Davis LLC",
      "Title": "et",
      "Description": "Open-source multi-state website",
      "Email": "wilfred@carterparisian.name",
      "FullName": "Kailyn Schowalter",
      "DirectPhone": "545-888-7818",
      "FormalName": "Leuschke, Lubowitz and Herman",
      "CountryId": 922,
      "ContactId": 826,
      "ContactName": "Kiehn-Crooks",
      "Retired": 742,
      "Rank": 75,
      "ActiveInterests": 619,
      "ContactDepartment": "",
      "ContactCountryId": 875,
      "ContactOrgNr": "1118113",
      "FaxPhone": "1-544-751-6089 x6210",
      "MobilePhone": "1-873-747-9015 x457",
      "ContactPhone": "(705)167-6408 x6474",
      "AssociateName": "Wiegand LLC",
      "AssociateId": 554,
      "UsePersonAddress": true,
      "ContactFax": "excepturi",
      "Kanafname": "rerum",
      "Kanalname": "rerum",
      "Post1": "nihil",
      "Post2": "consectetur",
      "Post3": "aut",
      "EmailName": "sabryna.schiller@kunde.biz",
      "ContactFullName": "Ms. Jolie Gusikowski",
      "ActiveErpLinks": 521,
      "TicketPriorityId": 257,
      "SupportLanguageId": 64,
      "SupportAssociateId": 672,
      "CategoryName": "VIP Customer",
      "PersonNumber": "835005"
    }
  ],
  "AlertLevel": 749,
  "ConnectId": 246,
  "ReadStatus": "Green",
  "TimeToReply": 579,
  "RealTimeToReply": 175,
  "TimeToClose": 988,
  "RealTimeToClose": 566,
  "TimeSpentInternally": 314,
  "TimeSpentExternally": 274,
  "TimeSpentQueue": 521,
  "RealTimeSpentInternally": 628,
  "RealTimeSpentExternally": 24,
  "RealTimeSpentQueue": 140,
  "TimeSpent": 145,
  "HasAttachment": false,
  "NumReplies": 852,
  "NumMessages": 483,
  "FromAddress": "ipsa",
  "Messages": [
    {
      "TicketMessageId": 439,
      "CreatedAt": "2004-04-29T03:45:28.6859307+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "velit",
      "PersonId": 58,
      "PersonFullName": "Katrine Medhurst",
      "ContactId": 222,
      "ContactName": "Crist Group",
      "ContactDepartment": "",
      "NumAttachments": 287,
      "EmailHeader": "ansley@stokes.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "vel",
      "Sentiment": 12,
      "SentimentConfidence": 539,
      "CreatedBy": 472,
      "ChangedAt": "2005-03-08T03:45:28.6859307+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 118,
      "Name": "Mitchell-Auer",
      "ToolTip": "Magnam nesciunt ab unde non."
    },
    {
      "Id": 118,
      "Name": "Mitchell-Auer",
      "ToolTip": "Magnam nesciunt ab unde non."
    }
  ],
  "Language": "voluptas",
  "Sentiment": 901,
  "SentimentConfidence": 413,
  "SuggestedCategoryId": 232,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 217,
  "IconHint": "corporis",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 262,
  "ExtraFields": {
    "ExtraFields1": "ad",
    "ExtraFields2": "ipsum"
  },
  "CustomFields": {
    "CustomFields1": "quod",
    "CustomFields2": "praesentium"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 634,
  "Title": "sed",
  "CreatedAt": "2024-09-24T03:45:28.7328048+02:00",
  "LastChanged": "2020-07-11T03:45:28.7328048+02:00",
  "ReadByOwner": "2014-09-02T03:45:28.7328048+02:00",
  "ReadByCustomer": "2012-02-13T03:45:28.7328048+01:00",
  "FirstReadByOwner": "2012-08-08T03:45:28.7328048+02:00",
  "FirstReadByUser": "2018-08-26T03:45:28.7328048+02:00",
  "Activate": "2000-01-27T03:45:28.7328048+01:00",
  "ClosedAt": "2025-03-17T03:45:28.7328048+01:00",
  "RepliedAt": "2005-05-22T03:45:28.7328048+02:00",
  "AlertTimeout": "2011-03-23T03:45:28.7328048+01:00",
  "Deadline": "2005-01-24T03:45:28.7328048+01:00",
  "CreatedBy": null,
  "Author": "commodi",
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
      "Position": "quis",
      "PersonId": 194,
      "Mrmrs": "nesciunt",
      "Firstname": "Jabari",
      "Lastname": "Strosin",
      "MiddleName": "Parker-Torp",
      "Title": "autem",
      "Description": "Synergized transitional architecture",
      "Email": "reina.lakin@gutkowski.info",
      "FullName": "Ned Senger",
      "DirectPhone": "1-751-757-6729 x93115",
      "FormalName": "Rowe-Haley",
      "CountryId": 387,
      "ContactId": 561,
      "ContactName": "Smitham Inc and Sons",
      "Retired": 117,
      "Rank": 146,
      "ActiveInterests": 913,
      "ContactDepartment": "",
      "ContactCountryId": 196,
      "ContactOrgNr": "1185470",
      "FaxPhone": "1-180-096-9953 x54608",
      "MobilePhone": "1-395-186-1545 x68941",
      "ContactPhone": "1-071-809-2789 x5231",
      "AssociateName": "Homenick LLC",
      "AssociateId": 337,
      "UsePersonAddress": false,
      "ContactFax": "ut",
      "Kanafname": "eveniet",
      "Kanalname": "eum",
      "Post1": "quod",
      "Post2": "in",
      "Post3": "illum",
      "EmailName": "garnett.larkin@jakubowski.biz",
      "ContactFullName": "Prof. Jerrod Rudolph O'Keefe",
      "ActiveErpLinks": 926,
      "TicketPriorityId": 860,
      "SupportLanguageId": 594,
      "SupportAssociateId": 774,
      "CategoryName": "VIP Customer",
      "PersonNumber": "987850",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 592
        }
      }
    }
  ],
  "AlertLevel": 627,
  "ConnectId": 463,
  "ReadStatus": "Green",
  "TimeToReply": 727,
  "RealTimeToReply": 148,
  "TimeToClose": 854,
  "RealTimeToClose": 75,
  "TimeSpentInternally": 289,
  "TimeSpentExternally": 528,
  "TimeSpentQueue": 396,
  "RealTimeSpentInternally": 77,
  "RealTimeSpentExternally": 136,
  "RealTimeSpentQueue": 527,
  "TimeSpent": 706,
  "HasAttachment": false,
  "NumReplies": 275,
  "NumMessages": 263,
  "FromAddress": "blanditiis",
  "Messages": [
    {
      "TicketMessageId": 406,
      "CreatedAt": "2025-04-19T03:45:28.7484296+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "dolore",
      "PersonId": 136,
      "PersonFullName": "Prof. Nathanael Jazmyne Morissette",
      "ContactId": 970,
      "ContactName": "Moen-Weber",
      "ContactDepartment": "",
      "NumAttachments": 880,
      "EmailHeader": "kim@bashirianbahringer.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "recusandae",
      "Sentiment": 385,
      "SentimentConfidence": 761,
      "CreatedBy": 631,
      "ChangedAt": "2001-04-05T03:45:28.7484296+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 732
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 603,
      "Name": "Bins Group",
      "ToolTip": "Officia consequatur fugit natus non excepturi.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 326
        }
      }
    },
    {
      "Id": 603,
      "Name": "Bins Group",
      "ToolTip": "Officia consequatur fugit natus non excepturi.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 326
        }
      }
    }
  ],
  "Language": "ex",
  "Sentiment": 420,
  "SentimentConfidence": 356,
  "SuggestedCategoryId": 476,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 668,
  "IconHint": "amet",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 112,
  "ExtraFields": {
    "ExtraFields1": "autem",
    "ExtraFields2": "occaecati"
  },
  "CustomFields": {
    "CustomFields1": "quisquam",
    "CustomFields2": "quaerat"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 798
    }
  }
}
```