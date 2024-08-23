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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 611,
  "Title": "possimus",
  "CreatedAt": "2020-04-05T13:28:32.2729888+02:00",
  "LastChanged": "2019-05-26T13:28:32.2729888+02:00",
  "ReadByOwner": "2013-12-09T13:28:32.2729888+01:00",
  "ReadByCustomer": "2017-11-19T13:28:32.2729888+01:00",
  "FirstReadByOwner": "2005-09-09T13:28:32.2729888+02:00",
  "FirstReadByUser": "2005-02-19T13:28:32.2729888+01:00",
  "Activate": "2000-03-20T13:28:32.2729888+01:00",
  "ClosedAt": "1999-03-03T13:28:32.2729888+01:00",
  "RepliedAt": "2000-01-12T13:28:32.2729888+01:00",
  "AlertTimeout": "1998-12-30T13:28:32.2729888+01:00",
  "Deadline": "2003-01-28T13:28:32.2729888+01:00",
  "CreatedBy": null,
  "Author": "sint",
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
      "Position": "et",
      "PersonId": 325,
      "Mrmrs": "eum",
      "Firstname": "Xavier",
      "Lastname": "Kutch",
      "MiddleName": "Hudson Inc and Sons",
      "Title": "dolor",
      "Description": "Stand-alone user-facing open architecture",
      "Email": "ana@von.uk",
      "FullName": "Stevie Walsh",
      "DirectPhone": "850-353-5252 x73040",
      "FormalName": "Lind LLC",
      "CountryId": 284,
      "ContactId": 669,
      "ContactName": "Leannon LLC",
      "Retired": 752,
      "Rank": 604,
      "ActiveInterests": 960,
      "ContactDepartment": "extend front-end content",
      "ContactCountryId": 757,
      "ContactOrgNr": "624949",
      "FaxPhone": "1-799-056-6783",
      "MobilePhone": "352.589.3670 x17756",
      "ContactPhone": "(319)109-4059",
      "AssociateName": "Will, Parisian and Hegmann",
      "AssociateId": 190,
      "UsePersonAddress": true,
      "ContactFax": "neque",
      "Kanafname": "repudiandae",
      "Kanalname": "veritatis",
      "Post1": "assumenda",
      "Post2": "quo",
      "Post3": "odit",
      "EmailName": "reggie@keeling.info",
      "ContactFullName": "Dr. Jane Liliana Ferry",
      "ActiveErpLinks": 62,
      "TicketPriorityId": 876,
      "SupportLanguageId": 69,
      "SupportAssociateId": 409,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 903,
  "ConnectId": 29,
  "ReadStatus": "Green",
  "TimeToReply": 364,
  "RealTimeToReply": 601,
  "TimeToClose": 303,
  "RealTimeToClose": 285,
  "TimeSpentInternally": 656,
  "TimeSpentExternally": 455,
  "TimeSpentQueue": 685,
  "RealTimeSpentInternally": 647,
  "RealTimeSpentExternally": 877,
  "RealTimeSpentQueue": 328,
  "TimeSpent": 551,
  "HasAttachment": true,
  "NumReplies": 271,
  "NumMessages": 377,
  "FromAddress": "quia",
  "Messages": [
    {
      "TicketMessageId": 370,
      "CreatedAt": "2021-08-31T13:28:32.2886082+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "aut",
      "PersonId": 332,
      "PersonFullName": "Prof. Mertie Maynard Stokes PhD",
      "ContactId": 919,
      "ContactName": "Wunsch-Spencer",
      "ContactDepartment": "",
      "NumAttachments": 814,
      "EmailHeader": "roma@bahringer.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "eos",
      "Sentiment": 755,
      "SentimentConfidence": 700,
      "CreatedBy": 895,
      "ChangedAt": "2020-03-30T13:28:32.2886082+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 175,
      "Name": "McGlynn-Frami",
      "ToolTip": "Repudiandae voluptatem fuga corrupti consequatur non nihil et."
    },
    {
      "Id": 175,
      "Name": "McGlynn-Frami",
      "ToolTip": "Repudiandae voluptatem fuga corrupti consequatur non nihil et."
    }
  ],
  "Language": "et",
  "Sentiment": 502,
  "SentimentConfidence": 696,
  "SuggestedCategoryId": 806,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 805,
  "IconHint": "dolor",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 995,
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "veritatis"
  },
  "CustomFields": {
    "CustomFields1": "incidunt",
    "CustomFields2": "est"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 282,
  "Title": "distinctio",
  "CreatedAt": "2014-11-03T13:28:32.2886082+01:00",
  "LastChanged": "2001-08-07T13:28:32.2886082+02:00",
  "ReadByOwner": "2023-09-08T13:28:32.2886082+02:00",
  "ReadByCustomer": "2023-03-03T13:28:32.2886082+01:00",
  "FirstReadByOwner": "2016-01-23T13:28:32.2886082+01:00",
  "FirstReadByUser": "2003-09-10T13:28:32.2886082+02:00",
  "Activate": "2017-04-26T13:28:32.2886082+02:00",
  "ClosedAt": "2013-08-12T13:28:32.2886082+02:00",
  "RepliedAt": "2001-04-10T13:28:32.2886082+02:00",
  "AlertTimeout": "2001-04-04T13:28:32.2886082+02:00",
  "Deadline": "2007-05-18T13:28:32.2886082+02:00",
  "CreatedBy": null,
  "Author": "suscipit",
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
      "PersonId": 246,
      "Mrmrs": "sed",
      "Firstname": "Georgianna",
      "Lastname": "Harvey",
      "MiddleName": "Hauck, Nicolas and Lebsack",
      "Title": "voluptates",
      "Description": "Adaptive multi-tasking definition",
      "Email": "dennis.wehner@rogahn.uk",
      "FullName": "Miss Providenci Franco Metz II",
      "DirectPhone": "1-173-809-3794 x186",
      "FormalName": "Waelchi-Schuster",
      "CountryId": 278,
      "ContactId": 126,
      "ContactName": "Morar Group",
      "Retired": 411,
      "Rank": 910,
      "ActiveInterests": 141,
      "ContactDepartment": "disintermediate mission-critical markets",
      "ContactCountryId": 15,
      "ContactOrgNr": "1149310",
      "FaxPhone": "880-006-8955",
      "MobilePhone": "(900)892-3644",
      "ContactPhone": "030.570.8545",
      "AssociateName": "Hettinger-Jerde",
      "AssociateId": 216,
      "UsePersonAddress": false,
      "ContactFax": "assumenda",
      "Kanafname": "at",
      "Kanalname": "laboriosam",
      "Post1": "voluptas",
      "Post2": "ratione",
      "Post3": "eveniet",
      "EmailName": "steve_collier@hauck.biz",
      "ContactFullName": "Stephanie Johnny Anderson Sr.",
      "ActiveErpLinks": 554,
      "TicketPriorityId": 861,
      "SupportLanguageId": 92,
      "SupportAssociateId": 344,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 374
        }
      }
    }
  ],
  "AlertLevel": 533,
  "ConnectId": 110,
  "ReadStatus": "Green",
  "TimeToReply": 17,
  "RealTimeToReply": 318,
  "TimeToClose": 117,
  "RealTimeToClose": 387,
  "TimeSpentInternally": 313,
  "TimeSpentExternally": 413,
  "TimeSpentQueue": 264,
  "RealTimeSpentInternally": 545,
  "RealTimeSpentExternally": 396,
  "RealTimeSpentQueue": 708,
  "TimeSpent": 879,
  "HasAttachment": false,
  "NumReplies": 743,
  "NumMessages": 720,
  "FromAddress": "dolores",
  "Messages": [
    {
      "TicketMessageId": 443,
      "CreatedAt": "1999-07-15T13:28:32.3042318+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "excepturi",
      "PersonId": 524,
      "PersonFullName": "Katelin Leuschke",
      "ContactId": 418,
      "ContactName": "Russel-Wisozk",
      "ContactDepartment": "",
      "NumAttachments": 36,
      "EmailHeader": "jany_mcclure@schmeler.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "sequi",
      "Sentiment": 833,
      "SentimentConfidence": 558,
      "CreatedBy": 110,
      "ChangedAt": "2021-02-18T13:28:32.3042318+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 18
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 413,
      "Name": "Schumm LLC",
      "ToolTip": "Architecto tenetur sint.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 11
        }
      }
    },
    {
      "Id": 413,
      "Name": "Schumm LLC",
      "ToolTip": "Architecto tenetur sint.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 11
        }
      }
    }
  ],
  "Language": "dolores",
  "Sentiment": 30,
  "SentimentConfidence": 568,
  "SuggestedCategoryId": 517,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 859,
  "IconHint": "quidem",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 437,
  "ExtraFields": {
    "ExtraFields1": "provident",
    "ExtraFields2": "harum"
  },
  "CustomFields": {
    "CustomFields1": "pariatur",
    "CustomFields2": "fuga"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 578
    }
  }
}
```