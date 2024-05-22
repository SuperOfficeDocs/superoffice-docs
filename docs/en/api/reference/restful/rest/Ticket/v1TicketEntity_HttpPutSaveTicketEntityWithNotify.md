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
  "TicketId": 375,
  "Title": "accusamus",
  "CreatedAt": "2021-02-24T12:57:42.8700346+01:00",
  "LastChanged": "2010-11-22T12:57:42.8700346+01:00",
  "ReadByOwner": "2011-10-04T12:57:42.8700346+02:00",
  "ReadByCustomer": "2000-05-01T12:57:42.8700346+02:00",
  "FirstReadByOwner": "2006-07-28T12:57:42.8700346+02:00",
  "FirstReadByUser": "2015-11-11T12:57:42.8700346+01:00",
  "Activate": "2005-09-18T12:57:42.8700346+02:00",
  "ClosedAt": "2011-12-21T12:57:42.8700346+01:00",
  "RepliedAt": "2008-09-21T12:57:42.8700346+02:00",
  "AlertTimeout": "2000-07-31T12:57:42.8700346+02:00",
  "Deadline": "2012-02-24T12:57:42.8700346+01:00",
  "CreatedBy": null,
  "Author": "ut",
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
      "Position": "nihil",
      "PersonId": 752,
      "Mrmrs": "sit",
      "Firstname": "Jacynthe",
      "Lastname": "Nicolas",
      "MiddleName": "Kerluke Inc and Sons",
      "Title": "et",
      "Description": "Persevering 5th generation customer loyalty",
      "Email": "gracie_langworth@weissnat.ca",
      "FullName": "Vallie Klocko DVM",
      "DirectPhone": "859.077.6554",
      "FormalName": "Graham-Flatley",
      "CountryId": 179,
      "ContactId": 913,
      "ContactName": "Schmeler, O'Connell and Kunze",
      "Retired": 40,
      "Rank": 174,
      "ActiveInterests": 672,
      "ContactDepartment": "",
      "ContactCountryId": 156,
      "ContactOrgNr": "471923",
      "FaxPhone": "1-418-674-4537",
      "MobilePhone": "261-334-2893 x1408",
      "ContactPhone": "(372)151-0636 x6882",
      "AssociateName": "Greenfelder, Torp and Simonis",
      "AssociateId": 603,
      "UsePersonAddress": false,
      "ContactFax": "deserunt",
      "Kanafname": "quasi",
      "Kanalname": "non",
      "Post1": "voluptatem",
      "Post2": "consequatur",
      "Post3": "voluptas",
      "EmailName": "amely.boyer@block.co.uk",
      "ContactFullName": "Loyce Lakin",
      "ActiveErpLinks": 858,
      "TicketPriorityId": 49,
      "SupportLanguageId": 9,
      "SupportAssociateId": 447,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 746,
  "ConnectId": 172,
  "ReadStatus": "Green",
  "TimeToReply": 167,
  "RealTimeToReply": 888,
  "TimeToClose": 847,
  "RealTimeToClose": 221,
  "TimeSpentInternally": 560,
  "TimeSpentExternally": 857,
  "TimeSpentQueue": 790,
  "RealTimeSpentInternally": 564,
  "RealTimeSpentExternally": 405,
  "RealTimeSpentQueue": 149,
  "TimeSpent": 190,
  "HasAttachment": false,
  "NumReplies": 536,
  "NumMessages": 24,
  "FromAddress": "enim",
  "Messages": [
    {
      "TicketMessageId": 810,
      "CreatedAt": "2007-12-26T12:57:42.8700346+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "vel",
      "PersonId": 959,
      "PersonFullName": "Yasmine Osinski",
      "ContactId": 184,
      "ContactName": "Bode, Huels and Roberts",
      "ContactDepartment": "",
      "NumAttachments": 527,
      "EmailHeader": "august@spinka.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "unde",
      "Sentiment": 923,
      "SentimentConfidence": 784,
      "CreatedBy": 213,
      "ChangedAt": "2012-05-17T12:57:42.8700346+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 549,
      "Name": "Emmerich-Little",
      "ToolTip": "Quis at id accusamus ut."
    },
    {
      "Id": 549,
      "Name": "Emmerich-Little",
      "ToolTip": "Quis at id accusamus ut."
    }
  ],
  "Language": "voluptatem",
  "Sentiment": 312,
  "SentimentConfidence": 640,
  "SuggestedCategoryId": 410,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 542,
  "IconHint": "id",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 160,
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "officia"
  },
  "CustomFields": {
    "CustomFields1": "dolorum",
    "CustomFields2": "ipsum"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 208,
  "Title": "veniam",
  "CreatedAt": "2017-09-11T12:57:42.885656+02:00",
  "LastChanged": "2010-08-20T12:57:42.885656+02:00",
  "ReadByOwner": "2019-05-26T12:57:42.885656+02:00",
  "ReadByCustomer": "1998-02-09T12:57:42.885656+01:00",
  "FirstReadByOwner": "2016-12-11T12:57:42.885656+01:00",
  "FirstReadByUser": "2006-11-11T12:57:42.885656+01:00",
  "Activate": "2016-07-11T12:57:42.885656+02:00",
  "ClosedAt": "2002-07-08T12:57:42.885656+02:00",
  "RepliedAt": "2021-07-30T12:57:42.885656+02:00",
  "AlertTimeout": "2009-10-26T12:57:42.885656+01:00",
  "Deadline": "2021-09-13T12:57:42.885656+02:00",
  "CreatedBy": null,
  "Author": "ut",
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
      "PersonId": 108,
      "Mrmrs": "quia",
      "Firstname": "Elody",
      "Lastname": "Corwin",
      "MiddleName": "Dooley Inc and Sons",
      "Title": "deleniti",
      "Description": "Cross-group 6th generation ability",
      "Email": "anastacio.rath@lynch.co.uk",
      "FullName": "Terry Abbott IV",
      "DirectPhone": "797-819-1280",
      "FormalName": "Pollich, Metz and Hessel",
      "CountryId": 887,
      "ContactId": 69,
      "ContactName": "Veum Group",
      "Retired": 708,
      "Rank": 558,
      "ActiveInterests": 769,
      "ContactDepartment": "",
      "ContactCountryId": 727,
      "ContactOrgNr": "965806",
      "FaxPhone": "1-677-398-7526",
      "MobilePhone": "1-285-632-5559 x016",
      "ContactPhone": "(959)634-6053",
      "AssociateName": "Legros Inc and Sons",
      "AssociateId": 415,
      "UsePersonAddress": false,
      "ContactFax": "aliquid",
      "Kanafname": "doloribus",
      "Kanalname": "aliquam",
      "Post1": "reiciendis",
      "Post2": "veniam",
      "Post3": "velit",
      "EmailName": "brown@littel.us",
      "ContactFullName": "Jamaal Daugherty",
      "ActiveErpLinks": 424,
      "TicketPriorityId": 481,
      "SupportLanguageId": 712,
      "SupportAssociateId": 677,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 470
        }
      }
    }
  ],
  "AlertLevel": 374,
  "ConnectId": 164,
  "ReadStatus": "Green",
  "TimeToReply": 846,
  "RealTimeToReply": 635,
  "TimeToClose": 203,
  "RealTimeToClose": 129,
  "TimeSpentInternally": 128,
  "TimeSpentExternally": 932,
  "TimeSpentQueue": 731,
  "RealTimeSpentInternally": 381,
  "RealTimeSpentExternally": 281,
  "RealTimeSpentQueue": 825,
  "TimeSpent": 739,
  "HasAttachment": false,
  "NumReplies": 529,
  "NumMessages": 582,
  "FromAddress": "voluptatem",
  "Messages": [
    {
      "TicketMessageId": 34,
      "CreatedAt": "2010-09-22T12:57:42.885656+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "occaecati",
      "PersonId": 369,
      "PersonFullName": "Evan Declan Brown I",
      "ContactId": 314,
      "ContactName": "Bernhard, McGlynn and VonRueden",
      "ContactDepartment": "e-enable granular relationships",
      "NumAttachments": 272,
      "EmailHeader": "zack@mayert.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "omnis",
      "Sentiment": 940,
      "SentimentConfidence": 484,
      "CreatedBy": 872,
      "ChangedAt": "2022-11-27T12:57:42.885656+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 56
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 345,
      "Name": "Marks-Ledner",
      "ToolTip": "Officia labore nihil quo quaerat tenetur quia.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 336
        }
      }
    },
    {
      "Id": 345,
      "Name": "Marks-Ledner",
      "ToolTip": "Officia labore nihil quo quaerat tenetur quia.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 336
        }
      }
    }
  ],
  "Language": "nam",
  "Sentiment": 497,
  "SentimentConfidence": 916,
  "SuggestedCategoryId": 155,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 168,
  "IconHint": "eum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 428,
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "iste",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 747
    }
  }
}
```