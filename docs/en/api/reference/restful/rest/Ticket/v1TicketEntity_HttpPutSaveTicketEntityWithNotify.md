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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 59,
  "Title": "reprehenderit",
  "CreatedAt": "2008-01-12T11:06:42.2697279+01:00",
  "LastChanged": "2000-12-04T11:06:42.2697279+01:00",
  "ReadByOwner": "2014-04-18T11:06:42.2697279+02:00",
  "ReadByCustomer": "1999-10-23T11:06:42.2697279+02:00",
  "FirstReadByOwner": "2021-01-24T11:06:42.2697279+01:00",
  "FirstReadByUser": "1998-07-18T11:06:42.2697279+02:00",
  "Activate": "1997-08-20T11:06:42.2697279+02:00",
  "ClosedAt": "1997-07-29T11:06:42.2697279+02:00",
  "RepliedAt": "2001-03-28T11:06:42.2697279+02:00",
  "AlertTimeout": "2023-10-18T11:06:42.2697279+02:00",
  "Deadline": "2002-11-01T11:06:42.2697279+01:00",
  "CreatedBy": null,
  "Author": "eum",
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
      "Position": "qui",
      "PersonId": 179,
      "Mrmrs": "aut",
      "Firstname": "Brooklyn",
      "Lastname": "Maggio",
      "MiddleName": "Carter-Bednar",
      "Title": "rem",
      "Description": "Robust upward-trending workforce",
      "Email": "verlie@durgan.us",
      "FullName": "Jeffry Waelchi",
      "DirectPhone": "315.729.7325",
      "FormalName": "Considine-Blanda",
      "CountryId": 80,
      "ContactId": 973,
      "ContactName": "Schneider Inc and Sons",
      "Retired": 460,
      "Rank": 342,
      "ActiveInterests": 839,
      "ContactDepartment": "",
      "ContactCountryId": 942,
      "ContactOrgNr": "1085120",
      "FaxPhone": "637.173.1432",
      "MobilePhone": "1-042-596-2995",
      "ContactPhone": "(548)334-9604 x8205",
      "AssociateName": "Bernier, Schmeler and Barton",
      "AssociateId": 611,
      "UsePersonAddress": false,
      "ContactFax": "perferendis",
      "Kanafname": "voluptatem",
      "Kanalname": "enim",
      "Post1": "facilis",
      "Post2": "aspernatur",
      "Post3": "odio",
      "EmailName": "isai.sawayn@lockman.us",
      "ContactFullName": "Esther Tremblay",
      "ActiveErpLinks": 274,
      "TicketPriorityId": 670,
      "SupportLanguageId": 217,
      "SupportAssociateId": 248,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 146,
  "ConnectId": 687,
  "ReadStatus": "Green",
  "TimeToReply": 305,
  "RealTimeToReply": 101,
  "TimeToClose": 388,
  "RealTimeToClose": 822,
  "TimeSpentInternally": 82,
  "TimeSpentExternally": 632,
  "TimeSpentQueue": 596,
  "RealTimeSpentInternally": 768,
  "RealTimeSpentExternally": 223,
  "RealTimeSpentQueue": 181,
  "TimeSpent": 500,
  "HasAttachment": false,
  "NumReplies": 253,
  "NumMessages": 119,
  "FromAddress": "rerum",
  "Messages": [
    {
      "TicketMessageId": 944,
      "CreatedAt": "1997-01-01T11:06:42.2853539+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "enim",
      "PersonId": 411,
      "PersonFullName": "Marianne Bartoletti",
      "ContactId": 152,
      "ContactName": "Hoppe-Bogisich",
      "ContactDepartment": "",
      "NumAttachments": 652,
      "EmailHeader": "brielle@durgan.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "amet",
      "Sentiment": 424,
      "SentimentConfidence": 809,
      "CreatedBy": 285,
      "ChangedAt": "2008-09-02T11:06:42.2853539+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 740,
      "Name": "Johns LLC",
      "ToolTip": "Repellat consectetur fugiat autem et itaque nihil."
    },
    {
      "Id": 740,
      "Name": "Johns LLC",
      "ToolTip": "Repellat consectetur fugiat autem et itaque nihil."
    }
  ],
  "Language": "fugiat",
  "Sentiment": 320,
  "SentimentConfidence": 125,
  "SuggestedCategoryId": 933,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 360,
  "IconHint": "est",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "ullam",
    "ExtraFields2": "sequi"
  },
  "CustomFields": {
    "CustomFields1": "quisquam",
    "CustomFields2": "ipsum"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 5,
  "Title": "quidem",
  "CreatedAt": "2020-03-21T11:06:42.2853539+01:00",
  "LastChanged": "2011-01-13T11:06:42.2853539+01:00",
  "ReadByOwner": "2005-01-11T11:06:42.2853539+01:00",
  "ReadByCustomer": "2007-07-04T11:06:42.2853539+02:00",
  "FirstReadByOwner": "2009-12-22T11:06:42.2853539+01:00",
  "FirstReadByUser": "2016-05-27T11:06:42.2853539+02:00",
  "Activate": "2003-09-23T11:06:42.2853539+02:00",
  "ClosedAt": "2010-02-22T11:06:42.2853539+01:00",
  "RepliedAt": "2022-06-11T11:06:42.2853539+02:00",
  "AlertTimeout": "2023-05-13T11:06:42.2853539+02:00",
  "Deadline": "2008-07-29T11:06:42.2853539+02:00",
  "CreatedBy": null,
  "Author": "dignissimos",
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
      "Position": "dolorem",
      "PersonId": 199,
      "Mrmrs": "qui",
      "Firstname": "Reid",
      "Lastname": "Johnson",
      "MiddleName": "Harvey, Smitham and Walker",
      "Title": "ut",
      "Description": "Operative object-oriented function",
      "Email": "nakia@nikolausauer.ca",
      "FullName": "Miss Cathy Stamm III",
      "DirectPhone": "(806)679-2434 x86182",
      "FormalName": "Berge-Cummerata",
      "CountryId": 783,
      "ContactId": 645,
      "ContactName": "Connelly Group",
      "Retired": 12,
      "Rank": 168,
      "ActiveInterests": 22,
      "ContactDepartment": "",
      "ContactCountryId": 230,
      "ContactOrgNr": "583294",
      "FaxPhone": "032-058-2430",
      "MobilePhone": "(244)441-1567",
      "ContactPhone": "(405)995-8639",
      "AssociateName": "Morissette, McLaughlin and Kassulke",
      "AssociateId": 257,
      "UsePersonAddress": false,
      "ContactFax": "voluptas",
      "Kanafname": "qui",
      "Kanalname": "perspiciatis",
      "Post1": "atque",
      "Post2": "exercitationem",
      "Post3": "repellendus",
      "EmailName": "bryon@rohan.info",
      "ContactFullName": "Miss Alek Russel I",
      "ActiveErpLinks": 707,
      "TicketPriorityId": 330,
      "SupportLanguageId": 668,
      "SupportAssociateId": 246,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 618
        }
      }
    }
  ],
  "AlertLevel": 271,
  "ConnectId": 374,
  "ReadStatus": "Green",
  "TimeToReply": 681,
  "RealTimeToReply": 331,
  "TimeToClose": 255,
  "RealTimeToClose": 125,
  "TimeSpentInternally": 819,
  "TimeSpentExternally": 140,
  "TimeSpentQueue": 670,
  "RealTimeSpentInternally": 450,
  "RealTimeSpentExternally": 242,
  "RealTimeSpentQueue": 412,
  "TimeSpent": 193,
  "HasAttachment": false,
  "NumReplies": 721,
  "NumMessages": 486,
  "FromAddress": "reprehenderit",
  "Messages": [
    {
      "TicketMessageId": 422,
      "CreatedAt": "2016-04-26T11:06:42.2853539+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "necessitatibus",
      "PersonId": 155,
      "PersonFullName": "Vickie Bettie Bergnaum II",
      "ContactId": 751,
      "ContactName": "Schuster-Wilkinson",
      "ContactDepartment": "",
      "NumAttachments": 389,
      "EmailHeader": "trisha@gerlach.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "et",
      "Sentiment": 509,
      "SentimentConfidence": 622,
      "CreatedBy": 322,
      "ChangedAt": "1998-07-21T11:06:42.2853539+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 134
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 553,
      "Name": "Schuppe LLC",
      "ToolTip": "Et excepturi.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 339
        }
      }
    },
    {
      "Id": 553,
      "Name": "Schuppe LLC",
      "ToolTip": "Et excepturi.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 339
        }
      }
    }
  ],
  "Language": "laudantium",
  "Sentiment": 293,
  "SentimentConfidence": 705,
  "SuggestedCategoryId": 463,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 455,
  "IconHint": "nemo",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "explicabo",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "a",
    "CustomFields2": "quasi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 959
    }
  }
}
```