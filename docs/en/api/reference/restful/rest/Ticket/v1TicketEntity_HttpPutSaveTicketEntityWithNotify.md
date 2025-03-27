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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 633,
  "Title": "inventore",
  "CreatedAt": "2014-12-15T02:38:26.4641552+01:00",
  "LastChanged": "2004-05-26T02:38:26.4641552+02:00",
  "ReadByOwner": "2001-01-07T02:38:26.4641552+01:00",
  "ReadByCustomer": "2012-10-14T02:38:26.4641552+02:00",
  "FirstReadByOwner": "2023-02-27T02:38:26.4641552+01:00",
  "FirstReadByUser": "2017-11-16T02:38:26.4641552+01:00",
  "Activate": "2011-06-26T02:38:26.4641552+02:00",
  "ClosedAt": "2018-08-15T02:38:26.4641552+02:00",
  "RepliedAt": "2019-05-24T02:38:26.4641552+02:00",
  "AlertTimeout": "2004-02-14T02:38:26.4641552+01:00",
  "Deadline": "2006-09-07T02:38:26.4641552+02:00",
  "CreatedBy": null,
  "Author": "molestiae",
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
      "Position": "possimus",
      "PersonId": 549,
      "Mrmrs": "debitis",
      "Firstname": "Jaycee",
      "Lastname": "Gutmann",
      "MiddleName": "Barrows, Jenkins and Ebert",
      "Title": "magni",
      "Description": "Ergonomic empowering archive",
      "Email": "jessica.schmeler@hansen.biz",
      "FullName": "Lamont Roob",
      "DirectPhone": "743-106-9888",
      "FormalName": "Flatley-Ryan",
      "CountryId": 257,
      "ContactId": 174,
      "ContactName": "Gerhold-Schamberger",
      "Retired": 834,
      "Rank": 268,
      "ActiveInterests": 950,
      "ContactDepartment": "",
      "ContactCountryId": 466,
      "ContactOrgNr": "987643",
      "FaxPhone": "304-059-9569 x17207",
      "MobilePhone": "1-944-395-7174",
      "ContactPhone": "1-830-233-6962 x74384",
      "AssociateName": "Schoen Group",
      "AssociateId": 333,
      "UsePersonAddress": true,
      "ContactFax": "aperiam",
      "Kanafname": "maiores",
      "Kanalname": "libero",
      "Post1": "voluptatibus",
      "Post2": "quae",
      "Post3": "ea",
      "EmailName": "alfonso@mcdermott.ca",
      "ContactFullName": "Jett Walter I",
      "ActiveErpLinks": 237,
      "TicketPriorityId": 767,
      "SupportLanguageId": 250,
      "SupportAssociateId": 722,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1314715"
    }
  ],
  "AlertLevel": 244,
  "ConnectId": 414,
  "ReadStatus": "Green",
  "TimeToReply": 323,
  "RealTimeToReply": 591,
  "TimeToClose": 146,
  "RealTimeToClose": 997,
  "TimeSpentInternally": 283,
  "TimeSpentExternally": 853,
  "TimeSpentQueue": 220,
  "RealTimeSpentInternally": 705,
  "RealTimeSpentExternally": 980,
  "RealTimeSpentQueue": 988,
  "TimeSpent": 75,
  "HasAttachment": false,
  "NumReplies": 941,
  "NumMessages": 481,
  "FromAddress": "quis",
  "Messages": [
    {
      "TicketMessageId": 189,
      "CreatedAt": "2000-07-03T02:38:26.4641552+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "libero",
      "PersonId": 720,
      "PersonFullName": "Enos Kessler Sr.",
      "ContactId": 682,
      "ContactName": "Auer, Langworth and Bode",
      "ContactDepartment": "",
      "NumAttachments": 24,
      "EmailHeader": "gabriella_douglas@casper.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "eos",
      "Sentiment": 893,
      "SentimentConfidence": 318,
      "CreatedBy": 12,
      "ChangedAt": "2008-07-21T02:38:26.4641552+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 170,
      "Name": "Champlin-Roberts",
      "ToolTip": "Ad aut esse ad voluptates."
    },
    {
      "Id": 170,
      "Name": "Champlin-Roberts",
      "ToolTip": "Ad aut esse ad voluptates."
    }
  ],
  "Language": "quis",
  "Sentiment": 206,
  "SentimentConfidence": 410,
  "SuggestedCategoryId": 786,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 260,
  "IconHint": "aut",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 500,
  "ExtraFields": {
    "ExtraFields1": "officia",
    "ExtraFields2": "temporibus"
  },
  "CustomFields": {
    "CustomFields1": "praesentium",
    "CustomFields2": "vel"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 93,
  "Title": "numquam",
  "CreatedAt": "2017-10-20T02:38:26.4641552+02:00",
  "LastChanged": "2009-03-12T02:38:26.4641552+01:00",
  "ReadByOwner": "2002-11-16T02:38:26.4641552+01:00",
  "ReadByCustomer": "2020-03-21T02:38:26.4641552+01:00",
  "FirstReadByOwner": "2019-11-11T02:38:26.4641552+01:00",
  "FirstReadByUser": "2016-09-01T02:38:26.4641552+02:00",
  "Activate": "2009-10-28T02:38:26.4641552+01:00",
  "ClosedAt": "2002-07-25T02:38:26.4641552+02:00",
  "RepliedAt": "2020-02-09T02:38:26.4641552+01:00",
  "AlertTimeout": "2018-04-23T02:38:26.4641552+02:00",
  "Deadline": "2009-12-23T02:38:26.4641552+01:00",
  "CreatedBy": null,
  "Author": "quam",
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
      "Position": "sit",
      "PersonId": 923,
      "Mrmrs": "vero",
      "Firstname": "Cathrine",
      "Lastname": "Heaney",
      "MiddleName": "Jacobs, Cremin and Daugherty",
      "Title": "voluptates",
      "Description": "Polarised tertiary budgetary management",
      "Email": "amelie@hand.co.uk",
      "FullName": "Mrs. Izaiah Raleigh Terry III",
      "DirectPhone": "894-999-3592 x82931",
      "FormalName": "Deckow Inc and Sons",
      "CountryId": 443,
      "ContactId": 860,
      "ContactName": "Boehm, Johnson and Weimann",
      "Retired": 248,
      "Rank": 745,
      "ActiveInterests": 658,
      "ContactDepartment": "",
      "ContactCountryId": 545,
      "ContactOrgNr": "1751593",
      "FaxPhone": "(519)079-9929 x0513",
      "MobilePhone": "515-322-0545",
      "ContactPhone": "235-927-7384",
      "AssociateName": "Jakubowski, Lubowitz and Moen",
      "AssociateId": 911,
      "UsePersonAddress": true,
      "ContactFax": "distinctio",
      "Kanafname": "nulla",
      "Kanalname": "quo",
      "Post1": "architecto",
      "Post2": "illum",
      "Post3": "rerum",
      "EmailName": "lonzo@feeneytillman.com",
      "ContactFullName": "Prof. Lue Jast Jr.",
      "ActiveErpLinks": 400,
      "TicketPriorityId": 378,
      "SupportLanguageId": 302,
      "SupportAssociateId": 991,
      "CategoryName": "VIP Customer",
      "PersonNumber": "432392",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 722
        }
      }
    }
  ],
  "AlertLevel": 993,
  "ConnectId": 666,
  "ReadStatus": "Green",
  "TimeToReply": 80,
  "RealTimeToReply": 149,
  "TimeToClose": 433,
  "RealTimeToClose": 516,
  "TimeSpentInternally": 721,
  "TimeSpentExternally": 45,
  "TimeSpentQueue": 910,
  "RealTimeSpentInternally": 548,
  "RealTimeSpentExternally": 8,
  "RealTimeSpentQueue": 631,
  "TimeSpent": 50,
  "HasAttachment": true,
  "NumReplies": 158,
  "NumMessages": 69,
  "FromAddress": "perspiciatis",
  "Messages": [
    {
      "TicketMessageId": 759,
      "CreatedAt": "2005-05-21T02:38:26.4641552+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "natus",
      "PersonId": 453,
      "PersonFullName": "Matilda Rodriguez",
      "ContactId": 142,
      "ContactName": "Bode-Blick",
      "ContactDepartment": "",
      "NumAttachments": 444,
      "EmailHeader": "lowell@weimann.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quos",
      "Sentiment": 901,
      "SentimentConfidence": 179,
      "CreatedBy": 102,
      "ChangedAt": "2022-06-13T02:38:26.4641552+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 262
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 468,
      "Name": "Hand-Cassin",
      "ToolTip": "Vitae excepturi minima accusamus quidem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 686
        }
      }
    },
    {
      "Id": 468,
      "Name": "Hand-Cassin",
      "ToolTip": "Vitae excepturi minima accusamus quidem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 686
        }
      }
    }
  ],
  "Language": "ad",
  "Sentiment": 385,
  "SentimentConfidence": 48,
  "SuggestedCategoryId": 124,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 837,
  "IconHint": "eos",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 16,
  "ExtraFields": {
    "ExtraFields1": "quam",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "vero",
    "CustomFields2": "voluptas"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 831
    }
  }
}
```