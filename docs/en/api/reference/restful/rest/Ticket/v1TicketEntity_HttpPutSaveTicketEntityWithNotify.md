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
| TicketType | TicketTypeEntity | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
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
| TicketType | TicketTypeEntity | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 69,
  "Title": "voluptatum",
  "CreatedAt": "2020-05-04T13:38:17.7024252+02:00",
  "LastChanged": "2017-11-30T13:38:17.7024252+01:00",
  "ReadByOwner": "2018-09-19T13:38:17.7024252+02:00",
  "ReadByCustomer": "1998-11-04T13:38:17.7024252+01:00",
  "FirstReadByOwner": "2007-02-13T13:38:17.7024252+01:00",
  "FirstReadByUser": "2011-01-13T13:38:17.7024252+01:00",
  "Activate": "2016-06-07T13:38:17.7024252+02:00",
  "ClosedAt": "2016-12-10T13:38:17.7024252+01:00",
  "RepliedAt": "2001-03-08T13:38:17.7024252+01:00",
  "AlertTimeout": "1997-06-16T13:38:17.7024252+02:00",
  "Deadline": "2004-05-16T13:38:17.7024252+02:00",
  "CreatedBy": null,
  "Author": "quos",
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
      "PersonId": 774,
      "Mrmrs": "aliquam",
      "Firstname": "Drew",
      "Lastname": "Bogisich",
      "MiddleName": "Tremblay Group",
      "Title": "explicabo",
      "Description": "Organized intangible emulation",
      "Email": "berenice_collier@williamson.us",
      "FullName": "Roxanne Ortiz",
      "DirectPhone": "1-955-303-5508 x012",
      "FormalName": "Spinka-Hoeger",
      "CountryId": 797,
      "ContactId": 109,
      "ContactName": "Boehm Group",
      "Retired": 432,
      "Rank": 786,
      "ActiveInterests": 589,
      "ContactDepartment": "",
      "ContactCountryId": 654,
      "ContactOrgNr": "1560724",
      "FaxPhone": "994.840.3373 x799",
      "MobilePhone": "524-063-3793",
      "ContactPhone": "1-896-257-0114 x06893",
      "AssociateName": "Marquardt-Bergnaum",
      "AssociateId": 993,
      "UsePersonAddress": true,
      "ContactFax": "rem",
      "Kanafname": "laudantium",
      "Kanalname": "perferendis",
      "Post1": "ut",
      "Post2": "voluptates",
      "Post3": "quia",
      "EmailName": "chase.legros@pagac.co.uk",
      "ContactFullName": "Rosella Lockman",
      "ActiveErpLinks": 1002,
      "TicketPriorityId": 591,
      "SupportLanguageId": 801,
      "SupportAssociateId": 565,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 979,
  "ConnectId": 81,
  "ReadStatus": "Green",
  "TimeToReply": 540,
  "RealTimeToReply": 747,
  "TimeToClose": 814,
  "RealTimeToClose": 910,
  "TimeSpentInternally": 198,
  "TimeSpentExternally": 645,
  "TimeSpentQueue": 376,
  "RealTimeSpentInternally": 850,
  "RealTimeSpentExternally": 829,
  "RealTimeSpentQueue": 458,
  "TimeSpent": 820,
  "HasAttachment": true,
  "NumReplies": 190,
  "NumMessages": 717,
  "FromAddress": "quibusdam",
  "Messages": [
    {
      "TicketMessageId": 449,
      "CreatedAt": "2018-06-17T13:38:17.7024252+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "perferendis",
      "PersonId": 296,
      "PersonFullName": "Miss Dorthy Kris MD",
      "ContactId": 681,
      "ContactName": "Jewess-Bosco",
      "ContactDepartment": "",
      "NumAttachments": 979,
      "EmailHeader": "jovany.herzog@dicki.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "omnis",
      "Sentiment": 753,
      "SentimentConfidence": 419,
      "CreatedBy": 867,
      "ChangedAt": "2015-09-26T13:38:17.7024252+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 833,
      "Name": "Lind Inc and Sons",
      "ToolTip": "Id tenetur qui."
    },
    {
      "Id": 833,
      "Name": "Lind Inc and Sons",
      "ToolTip": "Id tenetur qui."
    }
  ],
  "Language": "nihil",
  "Sentiment": 319,
  "SentimentConfidence": 521,
  "SuggestedCategoryId": 679,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 631,
  "IconHint": "omnis",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "accusantium",
    "ExtraFields2": "amet"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 367,
  "Title": "officia",
  "CreatedAt": "1997-11-26T13:38:17.7024252+01:00",
  "LastChanged": "1998-07-09T13:38:17.7024252+02:00",
  "ReadByOwner": "2023-07-22T13:38:17.7024252+02:00",
  "ReadByCustomer": "1997-11-14T13:38:17.7024252+01:00",
  "FirstReadByOwner": "2017-09-10T13:38:17.7024252+02:00",
  "FirstReadByUser": "2005-06-06T13:38:17.7024252+02:00",
  "Activate": "2008-12-23T13:38:17.7024252+01:00",
  "ClosedAt": "2004-03-27T13:38:17.7024252+01:00",
  "RepliedAt": "2014-04-20T13:38:17.7024252+02:00",
  "AlertTimeout": "2022-07-05T13:38:17.7024252+02:00",
  "Deadline": "2014-09-04T13:38:17.7024252+02:00",
  "CreatedBy": null,
  "Author": "id",
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
      "PersonId": 187,
      "Mrmrs": "error",
      "Firstname": "Reyna",
      "Lastname": "Johnston",
      "MiddleName": "Schultz, Beier and O'Keefe",
      "Title": "ex",
      "Description": "Pre-emptive multi-tasking orchestration",
      "Email": "rozella_collier@gulgowski.biz",
      "FullName": "Eleazar Maye Weissnat PhD",
      "DirectPhone": "(572)431-7266 x7405",
      "FormalName": "Thompson-Daugherty",
      "CountryId": 304,
      "ContactId": 93,
      "ContactName": "Howe, Harber and Kihn",
      "Retired": 47,
      "Rank": 252,
      "ActiveInterests": 224,
      "ContactDepartment": "",
      "ContactCountryId": 676,
      "ContactOrgNr": "1474887",
      "FaxPhone": "603.403.4637 x042",
      "MobilePhone": "(517)933-4931 x65985",
      "ContactPhone": "(022)913-5330 x5239",
      "AssociateName": "Heidenreich Inc and Sons",
      "AssociateId": 368,
      "UsePersonAddress": true,
      "ContactFax": "nihil",
      "Kanafname": "ut",
      "Kanalname": "cupiditate",
      "Post1": "pariatur",
      "Post2": "at",
      "Post3": "ipsum",
      "EmailName": "etha@gleichnerzboncak.ca",
      "ContactFullName": "Stephany Kshlerin III",
      "ActiveErpLinks": 147,
      "TicketPriorityId": 543,
      "SupportLanguageId": 603,
      "SupportAssociateId": 278,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 313
        }
      }
    }
  ],
  "AlertLevel": 333,
  "ConnectId": 557,
  "ReadStatus": "Green",
  "TimeToReply": 496,
  "RealTimeToReply": 637,
  "TimeToClose": 364,
  "RealTimeToClose": 3,
  "TimeSpentInternally": 811,
  "TimeSpentExternally": 628,
  "TimeSpentQueue": 768,
  "RealTimeSpentInternally": 729,
  "RealTimeSpentExternally": 192,
  "RealTimeSpentQueue": 847,
  "TimeSpent": 24,
  "HasAttachment": false,
  "NumReplies": 175,
  "NumMessages": 83,
  "FromAddress": "nam",
  "Messages": [
    {
      "TicketMessageId": 485,
      "CreatedAt": "2010-05-28T13:38:17.7180436+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "ipsum",
      "PersonId": 358,
      "PersonFullName": "Freddy Farrell DDS",
      "ContactId": 297,
      "ContactName": "Nienow Group",
      "ContactDepartment": "",
      "NumAttachments": 792,
      "EmailHeader": "delores_corwin@mclaughlin.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "repellat",
      "Sentiment": 794,
      "SentimentConfidence": 367,
      "CreatedBy": 194,
      "ChangedAt": "2000-06-04T13:38:17.7180436+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 935
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 972,
      "Name": "Conroy Inc and Sons",
      "ToolTip": "Sed officiis quibusdam magni est.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 861
        }
      }
    },
    {
      "Id": 972,
      "Name": "Conroy Inc and Sons",
      "ToolTip": "Sed officiis quibusdam magni est.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 861
        }
      }
    }
  ],
  "Language": "occaecati",
  "Sentiment": 655,
  "SentimentConfidence": 958,
  "SuggestedCategoryId": 490,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 323,
  "IconHint": "ut",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "aliquam",
    "ExtraFields2": "ipsum"
  },
  "CustomFields": {
    "CustomFields1": "natus",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 390
    }
  }
}
```