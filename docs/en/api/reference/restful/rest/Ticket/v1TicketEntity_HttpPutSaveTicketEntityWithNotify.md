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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 590,
  "Title": "suscipit",
  "CreatedAt": "2019-09-17T11:24:53.6093075+02:00",
  "LastChanged": "2002-01-26T11:24:53.6093075+01:00",
  "ReadByOwner": "2016-03-29T11:24:53.6093075+02:00",
  "ReadByCustomer": "2005-10-15T11:24:53.6093075+02:00",
  "FirstReadByOwner": "2018-04-22T11:24:53.6093075+02:00",
  "FirstReadByUser": "2008-10-23T11:24:53.6093075+02:00",
  "Activate": "2000-05-12T11:24:53.6093075+02:00",
  "ClosedAt": "2001-03-27T11:24:53.6093075+02:00",
  "RepliedAt": "2005-06-23T11:24:53.6093075+02:00",
  "AlertTimeout": "2015-01-29T11:24:53.6093075+01:00",
  "Deadline": "2017-09-23T11:24:53.6093075+02:00",
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
      "Position": "ducimus",
      "PersonId": 392,
      "Mrmrs": "sint",
      "Firstname": "Ciara",
      "Lastname": "Fritsch",
      "MiddleName": "Haag Group",
      "Title": "cupiditate",
      "Description": "Secured demand-driven synergy",
      "Email": "lionel_oconnell@haleyrogahn.info",
      "FullName": "Cathrine Marvin",
      "DirectPhone": "(556)400-7777 x66062",
      "FormalName": "Kohler, Wuckert and Little",
      "CountryId": 48,
      "ContactId": 749,
      "ContactName": "Cremin-Deckow",
      "Retired": 61,
      "Rank": 396,
      "ActiveInterests": 58,
      "ContactDepartment": "",
      "ContactCountryId": 320,
      "ContactOrgNr": "1169463",
      "FaxPhone": "040.344.4624 x6299",
      "MobilePhone": "1-184-365-5784",
      "ContactPhone": "416-124-7644 x77981",
      "AssociateName": "Cassin Group",
      "AssociateId": 126,
      "UsePersonAddress": false,
      "ContactFax": "consequatur",
      "Kanafname": "quos",
      "Kanalname": "similique",
      "Post1": "qui",
      "Post2": "sit",
      "Post3": "non",
      "EmailName": "gaetano@blanda.info",
      "ContactFullName": "Korey Jacobs",
      "ActiveErpLinks": 633,
      "TicketPriorityId": 552,
      "SupportLanguageId": 640,
      "SupportAssociateId": 833,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1448964"
    }
  ],
  "AlertLevel": 370,
  "ConnectId": 128,
  "ReadStatus": "Green",
  "TimeToReply": 9,
  "RealTimeToReply": 29,
  "TimeToClose": 688,
  "RealTimeToClose": 294,
  "TimeSpentInternally": 200,
  "TimeSpentExternally": 579,
  "TimeSpentQueue": 967,
  "RealTimeSpentInternally": 100,
  "RealTimeSpentExternally": 17,
  "RealTimeSpentQueue": 591,
  "TimeSpent": 416,
  "HasAttachment": false,
  "NumReplies": 466,
  "NumMessages": 753,
  "FromAddress": "blanditiis",
  "Messages": [
    {
      "TicketMessageId": 147,
      "CreatedAt": "2020-10-21T11:24:53.6093075+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "rerum",
      "PersonId": 750,
      "PersonFullName": "Joshua Moen III",
      "ContactId": 201,
      "ContactName": "Russel LLC",
      "ContactDepartment": "",
      "NumAttachments": 111,
      "EmailHeader": "juanita_oconner@marksboyer.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "qui",
      "Sentiment": 12,
      "SentimentConfidence": 256,
      "CreatedBy": 865,
      "ChangedAt": "2017-05-04T11:24:53.6093075+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 801,
      "Name": "Yundt Inc and Sons",
      "ToolTip": "Mollitia et numquam provident nam consequuntur."
    },
    {
      "Id": 801,
      "Name": "Yundt Inc and Sons",
      "ToolTip": "Mollitia et numquam provident nam consequuntur."
    }
  ],
  "Language": "in",
  "Sentiment": 804,
  "SentimentConfidence": 825,
  "SuggestedCategoryId": 199,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 92,
  "IconHint": "quis",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 676,
  "ExtraFields": {
    "ExtraFields1": "itaque",
    "ExtraFields2": "dicta"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "molestiae"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 703,
  "Title": "iste",
  "CreatedAt": "2011-12-15T11:24:53.6249318+01:00",
  "LastChanged": "2016-09-27T11:24:53.6249318+02:00",
  "ReadByOwner": "2025-03-28T11:24:53.6249318+01:00",
  "ReadByCustomer": "2012-04-02T11:24:53.6249318+02:00",
  "FirstReadByOwner": "2015-12-21T11:24:53.6249318+01:00",
  "FirstReadByUser": "2003-02-22T11:24:53.6249318+01:00",
  "Activate": "2023-05-24T11:24:53.6249318+02:00",
  "ClosedAt": "2007-10-24T11:24:53.6249318+02:00",
  "RepliedAt": "2014-12-27T11:24:53.6249318+01:00",
  "AlertTimeout": "2012-02-15T11:24:53.6249318+01:00",
  "Deadline": "2024-11-06T11:24:53.6249318+01:00",
  "CreatedBy": null,
  "Author": "eaque",
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
      "Position": "nam",
      "PersonId": 543,
      "Mrmrs": "incidunt",
      "Firstname": "Roslyn",
      "Lastname": "Volkman",
      "MiddleName": "Altenwerth, Jacobson and Zboncak",
      "Title": "sed",
      "Description": "Multi-lateral heuristic architecture",
      "Email": "jessika.stokes@ondrickabarton.biz",
      "FullName": "Carroll Cordia Trantow III",
      "DirectPhone": "933.071.3406",
      "FormalName": "Eichmann, Hudson and Cartwright",
      "CountryId": 889,
      "ContactId": 60,
      "ContactName": "Barrows, Cormier and Stiedemann",
      "Retired": 107,
      "Rank": 498,
      "ActiveInterests": 761,
      "ContactDepartment": "",
      "ContactCountryId": 289,
      "ContactOrgNr": "709870",
      "FaxPhone": "930-035-9418",
      "MobilePhone": "125-677-8236 x74085",
      "ContactPhone": "684-334-1358",
      "AssociateName": "Leannon-Prosacco",
      "AssociateId": 815,
      "UsePersonAddress": false,
      "ContactFax": "odit",
      "Kanafname": "voluptatem",
      "Kanalname": "sequi",
      "Post1": "laboriosam",
      "Post2": "ipsam",
      "Post3": "et",
      "EmailName": "cooper@schroederokeefe.co.uk",
      "ContactFullName": "Maribel Kertzmann",
      "ActiveErpLinks": 181,
      "TicketPriorityId": 479,
      "SupportLanguageId": 410,
      "SupportAssociateId": 428,
      "CategoryName": "VIP Customer",
      "PersonNumber": "474824",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 258
        }
      }
    }
  ],
  "AlertLevel": 12,
  "ConnectId": 682,
  "ReadStatus": "Green",
  "TimeToReply": 17,
  "RealTimeToReply": 449,
  "TimeToClose": 926,
  "RealTimeToClose": 293,
  "TimeSpentInternally": 241,
  "TimeSpentExternally": 550,
  "TimeSpentQueue": 640,
  "RealTimeSpentInternally": 955,
  "RealTimeSpentExternally": 569,
  "RealTimeSpentQueue": 284,
  "TimeSpent": 126,
  "HasAttachment": false,
  "NumReplies": 546,
  "NumMessages": 649,
  "FromAddress": "quis",
  "Messages": [
    {
      "TicketMessageId": 239,
      "CreatedAt": "2018-08-31T11:24:53.6249318+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "optio",
      "PersonId": 544,
      "PersonFullName": "Ms. Ryan Kuhlman Sr.",
      "ContactId": 492,
      "ContactName": "McLaughlin Group",
      "ContactDepartment": "",
      "NumAttachments": 709,
      "EmailHeader": "elena.hauck@mitchellkub.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "iure",
      "Sentiment": 275,
      "SentimentConfidence": 656,
      "CreatedBy": 718,
      "ChangedAt": "2018-10-14T11:24:53.6249318+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 660
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 300,
      "Name": "Leannon-Hermann",
      "ToolTip": "Sint sit nulla.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 260
        }
      }
    },
    {
      "Id": 300,
      "Name": "Leannon-Hermann",
      "ToolTip": "Sint sit nulla.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 260
        }
      }
    }
  ],
  "Language": "quis",
  "Sentiment": 880,
  "SentimentConfidence": 182,
  "SuggestedCategoryId": 441,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 832,
  "IconHint": "accusantium",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 904,
  "ExtraFields": {
    "ExtraFields1": "explicabo",
    "ExtraFields2": "beatae"
  },
  "CustomFields": {
    "CustomFields1": "sapiente",
    "CustomFields2": "voluptatem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 606
    }
  }
}
```