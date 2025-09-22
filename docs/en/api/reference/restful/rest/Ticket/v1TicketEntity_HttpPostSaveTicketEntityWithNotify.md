---
title: POST Ticket
uid: v1TicketEntity_HttpPostSaveTicketEntityWithNotify
generated: true
content_type: reference
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
POST /api/v1/Ticket?notify=False
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketId": 303,
  "Title": "aspernatur",
  "CreatedAt": "2012-07-29T11:24:53.5936832+02:00",
  "LastChanged": "2014-01-13T11:24:53.5936832+01:00",
  "ReadByOwner": "2010-08-04T11:24:53.5936832+02:00",
  "ReadByCustomer": "2000-05-26T11:24:53.5936832+02:00",
  "FirstReadByOwner": "2020-07-31T11:24:53.5936832+02:00",
  "FirstReadByUser": "2010-04-16T11:24:53.5936832+02:00",
  "Activate": "2025-02-06T11:24:53.5936832+01:00",
  "ClosedAt": "2007-03-26T11:24:53.5936832+02:00",
  "RepliedAt": "2001-09-12T11:24:53.5936832+02:00",
  "AlertTimeout": "2005-12-28T11:24:53.5936832+01:00",
  "Deadline": "2024-09-21T11:24:53.5936832+02:00",
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
      "Position": "distinctio",
      "PersonId": 991,
      "Mrmrs": "iusto",
      "Firstname": "Alexis",
      "Lastname": "Gulgowski",
      "MiddleName": "Bernhard, Denesik and Bechtelar",
      "Title": "sunt",
      "Description": "Grass-roots didactic Graphic Interface",
      "Email": "alisha@konopelski.com",
      "FullName": "Marshall Upton",
      "DirectPhone": "(330)669-8304 x9584",
      "FormalName": "Upton-Hoppe",
      "CountryId": 193,
      "ContactId": 335,
      "ContactName": "Goldner LLC",
      "Retired": 430,
      "Rank": 754,
      "ActiveInterests": 715,
      "ContactDepartment": "",
      "ContactCountryId": 422,
      "ContactOrgNr": "1826673",
      "FaxPhone": "(759)737-9556 x10755",
      "MobilePhone": "1-832-679-9601",
      "ContactPhone": "147-036-8034 x49045",
      "AssociateName": "Barton, Leuschke and Ritchie",
      "AssociateId": 755,
      "UsePersonAddress": true,
      "ContactFax": "possimus",
      "Kanafname": "eos",
      "Kanalname": "qui",
      "Post1": "quia",
      "Post2": "laboriosam",
      "Post3": "explicabo",
      "EmailName": "johnpaul@muller.com",
      "ContactFullName": "Randy Smitham",
      "ActiveErpLinks": 795,
      "TicketPriorityId": 386,
      "SupportLanguageId": 759,
      "SupportAssociateId": 596,
      "CategoryName": "VIP Customer",
      "PersonNumber": "612776"
    }
  ],
  "AlertLevel": 746,
  "ConnectId": 706,
  "ReadStatus": "Green",
  "TimeToReply": 389,
  "RealTimeToReply": 768,
  "TimeToClose": 27,
  "RealTimeToClose": 834,
  "TimeSpentInternally": 930,
  "TimeSpentExternally": 163,
  "TimeSpentQueue": 950,
  "RealTimeSpentInternally": 729,
  "RealTimeSpentExternally": 12,
  "RealTimeSpentQueue": 481,
  "TimeSpent": 354,
  "HasAttachment": false,
  "NumReplies": 370,
  "NumMessages": 535,
  "FromAddress": "optio",
  "Messages": [
    {
      "TicketMessageId": 285,
      "CreatedAt": "2018-12-08T11:24:53.5936832+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "quia",
      "PersonId": 12,
      "PersonFullName": "Tamia Hagenes",
      "ContactId": 134,
      "ContactName": "Lynch-Kuphal",
      "ContactDepartment": "",
      "NumAttachments": 174,
      "EmailHeader": "schuyler@hermannfahey.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "nesciunt",
      "Sentiment": 38,
      "SentimentConfidence": 827,
      "CreatedBy": 902,
      "ChangedAt": "2016-04-05T11:24:53.5936832+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 677,
      "Name": "Koepp LLC",
      "ToolTip": "Dolores aut voluptate ut ut ratione."
    },
    {
      "Id": 677,
      "Name": "Koepp LLC",
      "ToolTip": "Dolores aut voluptate ut ut ratione."
    }
  ],
  "Language": "sapiente",
  "Sentiment": 52,
  "SentimentConfidence": 233,
  "SuggestedCategoryId": 638,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 656,
  "IconHint": "velit",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 773,
  "ExtraFields": {
    "ExtraFields1": "unde",
    "ExtraFields2": "nesciunt"
  },
  "CustomFields": {
    "CustomFields1": "repudiandae",
    "CustomFields2": "minus"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 266,
  "Title": "qui",
  "CreatedAt": "2004-11-24T11:24:53.6093075+01:00",
  "LastChanged": "2001-04-09T11:24:53.6093075+02:00",
  "ReadByOwner": "2004-05-13T11:24:53.6093075+02:00",
  "ReadByCustomer": "2013-02-20T11:24:53.6093075+01:00",
  "FirstReadByOwner": "2021-01-26T11:24:53.6093075+01:00",
  "FirstReadByUser": "2019-03-14T11:24:53.6093075+01:00",
  "Activate": "2002-03-11T11:24:53.6093075+01:00",
  "ClosedAt": "2017-08-22T11:24:53.6093075+02:00",
  "RepliedAt": "2001-08-08T11:24:53.6093075+02:00",
  "AlertTimeout": "2008-04-12T11:24:53.6093075+02:00",
  "Deadline": "1999-10-31T11:24:53.6093075+01:00",
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
      "Position": "sed",
      "PersonId": 26,
      "Mrmrs": "debitis",
      "Firstname": "Kelsi",
      "Lastname": "Mueller",
      "MiddleName": "Leffler, Abshire and Hartmann",
      "Title": "dolorem",
      "Description": "Self-enabling neutral neural-net",
      "Email": "layne_prosacco@haley.com",
      "FullName": "Carlos Schimmel PhD",
      "DirectPhone": "053.980.5909 x962",
      "FormalName": "Moore LLC",
      "CountryId": 812,
      "ContactId": 84,
      "ContactName": "Schowalter-Corwin",
      "Retired": 724,
      "Rank": 582,
      "ActiveInterests": 906,
      "ContactDepartment": "",
      "ContactCountryId": 217,
      "ContactOrgNr": "602389",
      "FaxPhone": "(475)590-0722",
      "MobilePhone": "(607)943-5184 x798",
      "ContactPhone": "(589)284-8175 x73814",
      "AssociateName": "McLaughlin Group",
      "AssociateId": 63,
      "UsePersonAddress": true,
      "ContactFax": "ut",
      "Kanafname": "sed",
      "Kanalname": "molestias",
      "Post1": "necessitatibus",
      "Post2": "accusamus",
      "Post3": "et",
      "EmailName": "pink.bernier@berge.ca",
      "ContactFullName": "Dane Ed Ziemann MD",
      "ActiveErpLinks": 222,
      "TicketPriorityId": 195,
      "SupportLanguageId": 983,
      "SupportAssociateId": 357,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1829076",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 850
        }
      }
    }
  ],
  "AlertLevel": 417,
  "ConnectId": 70,
  "ReadStatus": "Green",
  "TimeToReply": 707,
  "RealTimeToReply": 925,
  "TimeToClose": 912,
  "RealTimeToClose": 236,
  "TimeSpentInternally": 359,
  "TimeSpentExternally": 754,
  "TimeSpentQueue": 757,
  "RealTimeSpentInternally": 280,
  "RealTimeSpentExternally": 213,
  "RealTimeSpentQueue": 774,
  "TimeSpent": 305,
  "HasAttachment": false,
  "NumReplies": 860,
  "NumMessages": 110,
  "FromAddress": "recusandae",
  "Messages": [
    {
      "TicketMessageId": 770,
      "CreatedAt": "2021-02-24T11:24:53.6093075+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "officia",
      "PersonId": 321,
      "PersonFullName": "Destini Hills",
      "ContactId": 607,
      "ContactName": "Hickle, Wintheiser and Schimmel",
      "ContactDepartment": "",
      "NumAttachments": 469,
      "EmailHeader": "etha@beahan.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "in",
      "Sentiment": 670,
      "SentimentConfidence": 440,
      "CreatedBy": 552,
      "ChangedAt": "2003-09-30T11:24:53.6093075+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 921
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 654,
      "Name": "Adams-Huel",
      "ToolTip": "Rerum excepturi enim architecto molestias laudantium architecto totam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 197
        }
      }
    },
    {
      "Id": 654,
      "Name": "Adams-Huel",
      "ToolTip": "Rerum excepturi enim architecto molestias laudantium architecto totam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 197
        }
      }
    }
  ],
  "Language": "et",
  "Sentiment": 645,
  "SentimentConfidence": 344,
  "SuggestedCategoryId": 559,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 58,
  "IconHint": "quia",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 429,
  "ExtraFields": {
    "ExtraFields1": "nostrum",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "nemo",
    "CustomFields2": "nihil"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 338
    }
  }
}
```