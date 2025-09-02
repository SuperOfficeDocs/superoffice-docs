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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 274,
  "Title": "a",
  "CreatedAt": "2021-01-05T03:47:00.3318094+01:00",
  "LastChanged": "2010-12-03T03:47:00.3318094+01:00",
  "ReadByOwner": "2019-09-16T03:47:00.3318094+02:00",
  "ReadByCustomer": "2010-07-01T03:47:00.3318094+02:00",
  "FirstReadByOwner": "2019-01-27T03:47:00.3318094+01:00",
  "FirstReadByUser": "2012-02-11T03:47:00.3318094+01:00",
  "Activate": "2015-03-03T03:47:00.3318094+01:00",
  "ClosedAt": "2021-09-17T03:47:00.3318094+02:00",
  "RepliedAt": "2024-06-04T03:47:00.3318094+02:00",
  "AlertTimeout": "2003-05-11T03:47:00.3318094+02:00",
  "Deadline": "2009-05-18T03:47:00.3318094+02:00",
  "CreatedBy": null,
  "Author": "sit",
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
      "Position": "ducimus",
      "PersonId": 642,
      "Mrmrs": "omnis",
      "Firstname": "Jared",
      "Lastname": "O'Kon",
      "MiddleName": "Hand, Pagac and Miller",
      "Title": "aut",
      "Description": "Re-contextualized object-oriented projection",
      "Email": "alicia.jacobson@rohan.us",
      "FullName": "Dr. Robyn Rutherford V",
      "DirectPhone": "1-628-232-0921 x85243",
      "FormalName": "Corwin-Lemke",
      "CountryId": 739,
      "ContactId": 993,
      "ContactName": "Beatty-Russel",
      "Retired": 16,
      "Rank": 525,
      "ActiveInterests": 212,
      "ContactDepartment": "leverage out-of-the-box paradigms",
      "ContactCountryId": 256,
      "ContactOrgNr": "858093",
      "FaxPhone": "1-827-302-5688",
      "MobilePhone": "230.574.8939 x50990",
      "ContactPhone": "790-923-6435 x4042",
      "AssociateName": "Schmeler-Stiedemann",
      "AssociateId": 652,
      "UsePersonAddress": true,
      "ContactFax": "aut",
      "Kanafname": "et",
      "Kanalname": "cupiditate",
      "Post1": "placeat",
      "Post2": "reiciendis",
      "Post3": "placeat",
      "EmailName": "colleen@wizabosco.name",
      "ContactFullName": "Braulio Huels",
      "ActiveErpLinks": 693,
      "TicketPriorityId": 141,
      "SupportLanguageId": 67,
      "SupportAssociateId": 470,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1276634"
    }
  ],
  "AlertLevel": 59,
  "ConnectId": 211,
  "ReadStatus": "Green",
  "TimeToReply": 587,
  "RealTimeToReply": 435,
  "TimeToClose": 51,
  "RealTimeToClose": 203,
  "TimeSpentInternally": 994,
  "TimeSpentExternally": 240,
  "TimeSpentQueue": 468,
  "RealTimeSpentInternally": 222,
  "RealTimeSpentExternally": 861,
  "RealTimeSpentQueue": 120,
  "TimeSpent": 986,
  "HasAttachment": false,
  "NumReplies": 394,
  "NumMessages": 573,
  "FromAddress": "et",
  "Messages": [
    {
      "TicketMessageId": 480,
      "CreatedAt": "2016-04-28T03:47:00.3318094+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "nulla",
      "PersonId": 502,
      "PersonFullName": "Jamey Moore",
      "ContactId": 405,
      "ContactName": "Brekke Group",
      "ContactDepartment": "",
      "NumAttachments": 312,
      "EmailHeader": "aidan@funknolan.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "pariatur",
      "Sentiment": 960,
      "SentimentConfidence": 370,
      "CreatedBy": 235,
      "ChangedAt": "2015-09-24T03:47:00.3318094+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 913,
      "Name": "Walsh-Legros",
      "ToolTip": "Dolores recusandae sint ea."
    },
    {
      "Id": 913,
      "Name": "Walsh-Legros",
      "ToolTip": "Dolores recusandae sint ea."
    }
  ],
  "Language": "expedita",
  "Sentiment": 380,
  "SentimentConfidence": 248,
  "SuggestedCategoryId": 226,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 621,
  "IconHint": "vel",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 256,
  "ExtraFields": {
    "ExtraFields1": "eligendi",
    "ExtraFields2": "earum"
  },
  "CustomFields": {
    "CustomFields1": "itaque",
    "CustomFields2": "aut"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 785,
  "Title": "esse",
  "CreatedAt": "2017-03-17T03:47:00.347434+01:00",
  "LastChanged": "2003-09-10T03:47:00.347434+02:00",
  "ReadByOwner": "2005-11-09T03:47:00.347434+01:00",
  "ReadByCustomer": "2005-07-19T03:47:00.347434+02:00",
  "FirstReadByOwner": "2025-04-08T03:47:00.347434+02:00",
  "FirstReadByUser": "2010-07-21T03:47:00.347434+02:00",
  "Activate": "2017-05-15T03:47:00.347434+02:00",
  "ClosedAt": "2018-12-16T03:47:00.347434+01:00",
  "RepliedAt": "2011-07-20T03:47:00.347434+02:00",
  "AlertTimeout": "2016-01-14T03:47:00.347434+01:00",
  "Deadline": "2023-08-03T03:47:00.347434+02:00",
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
      "Position": "est",
      "PersonId": 923,
      "Mrmrs": "veniam",
      "Firstname": "Clarissa",
      "Lastname": "Champlin",
      "MiddleName": "Price-Thiel",
      "Title": "sed",
      "Description": "Networked local projection",
      "Email": "claude@fisher.com",
      "FullName": "Anibal Schulist III",
      "DirectPhone": "1-324-740-4765 x804",
      "FormalName": "Zemlak-Parker",
      "CountryId": 619,
      "ContactId": 133,
      "ContactName": "Abbott, Legros and Hilll",
      "Retired": 960,
      "Rank": 855,
      "ActiveInterests": 552,
      "ContactDepartment": "",
      "ContactCountryId": 99,
      "ContactOrgNr": "826879",
      "FaxPhone": "209.060.9048 x4041",
      "MobilePhone": "(933)013-5490 x2892",
      "ContactPhone": "509.153.0471",
      "AssociateName": "Huel, Kuhn and Rice",
      "AssociateId": 580,
      "UsePersonAddress": false,
      "ContactFax": "nostrum",
      "Kanafname": "necessitatibus",
      "Kanalname": "et",
      "Post1": "sunt",
      "Post2": "harum",
      "Post3": "provident",
      "EmailName": "gunnar@hagenes.ca",
      "ContactFullName": "Gonzalo Rath II",
      "ActiveErpLinks": 273,
      "TicketPriorityId": 240,
      "SupportLanguageId": 162,
      "SupportAssociateId": 961,
      "CategoryName": "VIP Customer",
      "PersonNumber": "892027",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 65
        }
      }
    }
  ],
  "AlertLevel": 35,
  "ConnectId": 751,
  "ReadStatus": "Green",
  "TimeToReply": 782,
  "RealTimeToReply": 779,
  "TimeToClose": 261,
  "RealTimeToClose": 261,
  "TimeSpentInternally": 659,
  "TimeSpentExternally": 18,
  "TimeSpentQueue": 43,
  "RealTimeSpentInternally": 400,
  "RealTimeSpentExternally": 818,
  "RealTimeSpentQueue": 782,
  "TimeSpent": 27,
  "HasAttachment": false,
  "NumReplies": 527,
  "NumMessages": 569,
  "FromAddress": "voluptas",
  "Messages": [
    {
      "TicketMessageId": 813,
      "CreatedAt": "2012-10-02T03:47:00.347434+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "beatae",
      "PersonId": 601,
      "PersonFullName": "Lauriane Conroy",
      "ContactId": 412,
      "ContactName": "Skiles Group",
      "ContactDepartment": "",
      "NumAttachments": 396,
      "EmailHeader": "frida.gulgowski@goodwin.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "rerum",
      "Sentiment": 260,
      "SentimentConfidence": 430,
      "CreatedBy": 24,
      "ChangedAt": "2011-05-30T03:47:00.347434+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 141
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 462,
      "Name": "O'Conner, Bashirian and Romaguera",
      "ToolTip": "Facilis sed assumenda facere.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 506
        }
      }
    },
    {
      "Id": 462,
      "Name": "O'Conner, Bashirian and Romaguera",
      "ToolTip": "Facilis sed assumenda facere.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 506
        }
      }
    }
  ],
  "Language": "porro",
  "Sentiment": 557,
  "SentimentConfidence": 551,
  "SuggestedCategoryId": 982,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 952,
  "IconHint": "recusandae",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 283,
  "ExtraFields": {
    "ExtraFields1": "dignissimos",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "nam",
    "CustomFields2": "totam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 272
    }
  }
}
```