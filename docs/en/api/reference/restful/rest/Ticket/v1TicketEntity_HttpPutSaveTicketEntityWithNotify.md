---
title: PUT Ticket/{id}
uid: v1TicketEntity_HttpPutSaveTicketEntityWithNotify
generated: true
content_type: reference
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
  "TicketId": 658,
  "Title": "vitae",
  "CreatedAt": "2003-03-13T03:41:59.1211332+01:00",
  "LastChanged": "2008-08-13T03:41:59.1211332+02:00",
  "ReadByOwner": "2012-05-28T03:41:59.1211332+02:00",
  "ReadByCustomer": "2021-12-01T03:41:59.1211332+01:00",
  "FirstReadByOwner": "2020-12-03T03:41:59.1211332+01:00",
  "FirstReadByUser": "2023-09-08T03:41:59.1211332+02:00",
  "Activate": "2007-02-26T03:41:59.1211332+01:00",
  "ClosedAt": "2023-12-29T03:41:59.1211332+01:00",
  "RepliedAt": "2008-04-28T03:41:59.1211332+02:00",
  "AlertTimeout": "2004-06-14T03:41:59.1211332+02:00",
  "Deadline": "2013-03-03T03:41:59.1211332+01:00",
  "CreatedBy": null,
  "Author": "ab",
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
      "Position": "nemo",
      "PersonId": 376,
      "Mrmrs": "et",
      "Firstname": "Shaylee",
      "Lastname": "Bashirian",
      "MiddleName": "Thompson Group",
      "Title": "animi",
      "Description": "Self-enabling bifurcated collaboration",
      "Email": "lenna@heathcote.co.uk",
      "FullName": "Trevion McCullough",
      "DirectPhone": "960-589-4064",
      "FormalName": "Crona-Dach",
      "CountryId": 310,
      "ContactId": 279,
      "ContactName": "Crooks, Hoppe and Rippin",
      "Retired": 868,
      "Rank": 358,
      "ActiveInterests": 985,
      "ContactDepartment": "",
      "ContactCountryId": 11,
      "ContactOrgNr": "942999",
      "FaxPhone": "038.257.0904 x62571",
      "MobilePhone": "1-684-125-3463 x0241",
      "ContactPhone": "745.195.7086 x45803",
      "AssociateName": "O'Hara, Kris and Paucek",
      "AssociateId": 693,
      "UsePersonAddress": false,
      "ContactFax": "voluptas",
      "Kanafname": "itaque",
      "Kanalname": "vel",
      "Post1": "quasi",
      "Post2": "commodi",
      "Post3": "nobis",
      "EmailName": "rhett.cole@cummings.name",
      "ContactFullName": "Wilbert Christa Pollich I",
      "ActiveErpLinks": 139,
      "TicketPriorityId": 577,
      "SupportLanguageId": 679,
      "SupportAssociateId": 140,
      "CategoryName": "VIP Customer",
      "PersonNumber": "559525"
    }
  ],
  "AlertLevel": 791,
  "ConnectId": 659,
  "ReadStatus": "Green",
  "TimeToReply": 142,
  "RealTimeToReply": 464,
  "TimeToClose": 153,
  "RealTimeToClose": 40,
  "TimeSpentInternally": 297,
  "TimeSpentExternally": 149,
  "TimeSpentQueue": 194,
  "RealTimeSpentInternally": 396,
  "RealTimeSpentExternally": 247,
  "RealTimeSpentQueue": 236,
  "TimeSpent": 80,
  "HasAttachment": false,
  "NumReplies": 928,
  "NumMessages": 334,
  "FromAddress": "quis",
  "Messages": [
    {
      "TicketMessageId": 395,
      "CreatedAt": "2021-02-02T03:41:59.1211332+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "sed",
      "PersonId": 800,
      "PersonFullName": "Prof. Jacquelyn Sterling Senger",
      "ContactId": 805,
      "ContactName": "Gutkowski Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 588,
      "EmailHeader": "michaela@macejkovicsmith.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "veniam",
      "Sentiment": 345,
      "SentimentConfidence": 3,
      "CreatedBy": 279,
      "ChangedAt": "2010-05-03T03:41:59.1211332+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 187,
      "Name": "Kohler-Keeling",
      "ToolTip": "Aspernatur voluptates aspernatur minus modi commodi est."
    },
    {
      "Id": 187,
      "Name": "Kohler-Keeling",
      "ToolTip": "Aspernatur voluptates aspernatur minus modi commodi est."
    }
  ],
  "Language": "sed",
  "Sentiment": 823,
  "SentimentConfidence": 761,
  "SuggestedCategoryId": 462,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 686,
  "IconHint": "nesciunt",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 709,
  "ExtraFields": {
    "ExtraFields1": "beatae",
    "ExtraFields2": "dolores"
  },
  "CustomFields": {
    "CustomFields1": "ipsa",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 575,
  "Title": "accusantium",
  "CreatedAt": "2020-04-18T03:41:59.1211332+02:00",
  "LastChanged": "2024-06-02T03:41:59.1211332+02:00",
  "ReadByOwner": "2005-04-06T03:41:59.1211332+02:00",
  "ReadByCustomer": "2014-04-30T03:41:59.1211332+02:00",
  "FirstReadByOwner": "1999-10-29T03:41:59.1211332+02:00",
  "FirstReadByUser": "2017-09-05T03:41:59.1211332+02:00",
  "Activate": "2022-09-27T03:41:59.1211332+02:00",
  "ClosedAt": "2014-07-31T03:41:59.1211332+02:00",
  "RepliedAt": "2010-09-10T03:41:59.1211332+02:00",
  "AlertTimeout": "2025-06-18T03:41:59.1211332+02:00",
  "Deadline": "2013-10-02T03:41:59.1211332+02:00",
  "CreatedBy": null,
  "Author": "omnis",
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
      "Position": "eos",
      "PersonId": 419,
      "Mrmrs": "dicta",
      "Firstname": "Grayce",
      "Lastname": "Hilll",
      "MiddleName": "Rodriguez, Lynch and Effertz",
      "Title": "recusandae",
      "Description": "De-engineered holistic flexibility",
      "Email": "wilbert@harvey.name",
      "FullName": "Mr. Garnet Amya Leuschke II",
      "DirectPhone": "(008)681-0950 x543",
      "FormalName": "Zemlak, Predovic and O'Keefe",
      "CountryId": 85,
      "ContactId": 439,
      "ContactName": "Kessler-Witting",
      "Retired": 320,
      "Rank": 297,
      "ActiveInterests": 487,
      "ContactDepartment": "",
      "ContactCountryId": 705,
      "ContactOrgNr": "519450",
      "FaxPhone": "1-950-906-8796",
      "MobilePhone": "(541)121-1080",
      "ContactPhone": "660.909.4980 x59025",
      "AssociateName": "Kling, Runolfsdottir and Leffler",
      "AssociateId": 69,
      "UsePersonAddress": false,
      "ContactFax": "facilis",
      "Kanafname": "ullam",
      "Kanalname": "voluptatem",
      "Post1": "dolor",
      "Post2": "quia",
      "Post3": "necessitatibus",
      "EmailName": "eino@grimes.ca",
      "ContactFullName": "Dr. Citlalli Devon Lakin DDS",
      "ActiveErpLinks": 536,
      "TicketPriorityId": 455,
      "SupportLanguageId": 571,
      "SupportAssociateId": 304,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1701095",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 283
        }
      }
    }
  ],
  "AlertLevel": 695,
  "ConnectId": 267,
  "ReadStatus": "Green",
  "TimeToReply": 100,
  "RealTimeToReply": 142,
  "TimeToClose": 657,
  "RealTimeToClose": 853,
  "TimeSpentInternally": 901,
  "TimeSpentExternally": 971,
  "TimeSpentQueue": 506,
  "RealTimeSpentInternally": 811,
  "RealTimeSpentExternally": 716,
  "RealTimeSpentQueue": 458,
  "TimeSpent": 440,
  "HasAttachment": false,
  "NumReplies": 41,
  "NumMessages": 252,
  "FromAddress": "reiciendis",
  "Messages": [
    {
      "TicketMessageId": 102,
      "CreatedAt": "2001-06-03T03:41:59.1211332+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "veritatis",
      "PersonId": 411,
      "PersonFullName": "Paige Mueller",
      "ContactId": 359,
      "ContactName": "Vandervort-Grimes",
      "ContactDepartment": "",
      "NumAttachments": 434,
      "EmailHeader": "sammy.rau@predovic.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "rerum",
      "Sentiment": 103,
      "SentimentConfidence": 817,
      "CreatedBy": 507,
      "ChangedAt": "2018-04-06T03:41:59.1211332+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 505
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 493,
      "Name": "Runolfsdottir-Turner",
      "ToolTip": "Modi autem porro voluptates.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    },
    {
      "Id": 493,
      "Name": "Runolfsdottir-Turner",
      "ToolTip": "Modi autem porro voluptates.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    }
  ],
  "Language": "maxime",
  "Sentiment": 239,
  "SentimentConfidence": 405,
  "SuggestedCategoryId": 135,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 608,
  "IconHint": "qui",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 702,
  "ExtraFields": {
    "ExtraFields1": "optio",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "excepturi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 118
    }
  }
}
```