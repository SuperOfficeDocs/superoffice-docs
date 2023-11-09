---
title: POST Agents/Ticket/SaveTicketEntity
uid: v1TicketAgent_SaveTicketEntity
generated: true
---

# POST Agents/Ticket/SaveTicketEntity

```http
POST /api/v1/Agents/Ticket/SaveTicketEntity
```

Updates the existing TicketEntity or creates a new TicketEntity if the id parameter is empty








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

The TicketEntity to be saved. 

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
POST /api/v1/Agents/Ticket/SaveTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketId": 919,
  "Title": "quas",
  "CreatedAt": "2019-09-29T11:06:35.4583188+02:00",
  "LastChanged": "2005-07-08T11:06:35.4583188+02:00",
  "ReadByOwner": "2012-06-01T11:06:35.4583188+02:00",
  "ReadByCustomer": "2010-06-22T11:06:35.4583188+02:00",
  "FirstReadByOwner": "2021-09-01T11:06:35.4583188+02:00",
  "FirstReadByUser": "2020-08-10T11:06:35.4583188+02:00",
  "Activate": "1998-05-30T11:06:35.4583188+02:00",
  "ClosedAt": "2000-08-15T11:06:35.4583188+02:00",
  "RepliedAt": "2007-04-01T11:06:35.4583188+02:00",
  "AlertTimeout": "2016-07-12T11:06:35.4583188+02:00",
  "Deadline": "2021-01-18T11:06:35.4583188+01:00",
  "CreatedBy": null,
  "Author": "perspiciatis",
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
      "Position": "velit",
      "PersonId": 348,
      "Mrmrs": "molestias",
      "Firstname": "Rey",
      "Lastname": "Champlin",
      "MiddleName": "Tromp, Leuschke and Ernser",
      "Title": "doloribus",
      "Description": "Object-based reciprocal knowledge base",
      "Email": "franco_kling@murray.us",
      "FullName": "Dr. Morris Anabelle Champlin Jr.",
      "DirectPhone": "674-080-6741 x9997",
      "FormalName": "Stracke-Schuster",
      "CountryId": 788,
      "ContactId": 175,
      "ContactName": "Johnson LLC",
      "Retired": 492,
      "Rank": 738,
      "ActiveInterests": 806,
      "ContactDepartment": "",
      "ContactCountryId": 186,
      "ContactOrgNr": "987645",
      "FaxPhone": "021-189-4116 x4074",
      "MobilePhone": "320-022-1490",
      "ContactPhone": "1-695-009-5466",
      "AssociateName": "Mayert, West and Haley",
      "AssociateId": 242,
      "UsePersonAddress": true,
      "ContactFax": "pariatur",
      "Kanafname": "voluptas",
      "Kanalname": "hic",
      "Post1": "corrupti",
      "Post2": "odit",
      "Post3": "voluptates",
      "EmailName": "lura@bashirian.name",
      "ContactFullName": "Geovanni Homenick",
      "ActiveErpLinks": 196,
      "TicketPriorityId": 441,
      "SupportLanguageId": 928,
      "SupportAssociateId": 187,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 537,
  "ConnectId": 11,
  "ReadStatus": "Green",
  "TimeToReply": 210,
  "RealTimeToReply": 138,
  "TimeToClose": 910,
  "RealTimeToClose": 310,
  "TimeSpentInternally": 263,
  "TimeSpentExternally": 23,
  "TimeSpentQueue": 976,
  "RealTimeSpentInternally": 847,
  "RealTimeSpentExternally": 546,
  "RealTimeSpentQueue": 550,
  "TimeSpent": 606,
  "HasAttachment": false,
  "NumReplies": 992,
  "NumMessages": 767,
  "FromAddress": "consectetur",
  "Messages": [
    {
      "TicketMessageId": 943,
      "CreatedAt": "2011-11-25T11:06:35.4583188+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "suscipit",
      "PersonId": 259,
      "PersonFullName": "Schuyler Fritsch",
      "ContactId": 107,
      "ContactName": "Bins Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 699,
      "EmailHeader": "kaitlin.bruen@schultz.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "autem",
      "Sentiment": 709,
      "SentimentConfidence": 669,
      "CreatedBy": 96,
      "ChangedAt": "2021-07-15T11:06:35.4583188+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 835,
      "Name": "Marks Group",
      "ToolTip": "Nihil vel velit quaerat debitis."
    },
    {
      "Id": 835,
      "Name": "Marks Group",
      "ToolTip": "Nihil vel velit quaerat debitis."
    }
  ],
  "Language": "est",
  "Sentiment": 72,
  "SentimentConfidence": 529,
  "SuggestedCategoryId": 335,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 366,
  "IconHint": "provident",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "tenetur",
    "ExtraFields2": "quis"
  },
  "CustomFields": {
    "CustomFields1": "nisi",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 770,
  "Title": "sunt",
  "CreatedAt": "2014-12-18T11:06:35.4739443+01:00",
  "LastChanged": "2003-10-14T11:06:35.4739443+02:00",
  "ReadByOwner": "2007-10-05T11:06:35.4739443+02:00",
  "ReadByCustomer": "2001-01-22T11:06:35.4739443+01:00",
  "FirstReadByOwner": "2020-12-10T11:06:35.4739443+01:00",
  "FirstReadByUser": "2020-05-24T11:06:35.4739443+02:00",
  "Activate": "2018-05-29T11:06:35.4739443+02:00",
  "ClosedAt": "2014-07-08T11:06:35.4739443+02:00",
  "RepliedAt": "2020-10-16T11:06:35.4739443+02:00",
  "AlertTimeout": "2014-06-16T11:06:35.4739443+02:00",
  "Deadline": "2015-10-15T11:06:35.4739443+02:00",
  "CreatedBy": null,
  "Author": "facilis",
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
      "Position": "officiis",
      "PersonId": 220,
      "Mrmrs": "suscipit",
      "Firstname": "Franz",
      "Lastname": "Runolfsson",
      "MiddleName": "Hane Inc and Sons",
      "Title": "officiis",
      "Description": "Compatible context-sensitive artificial intelligence",
      "Email": "weston.schuster@swift.biz",
      "FullName": "Miss Tevin Ferry",
      "DirectPhone": "(647)673-0497",
      "FormalName": "Emmerich-Barton",
      "CountryId": 407,
      "ContactId": 639,
      "ContactName": "Greenholt-Beier",
      "Retired": 654,
      "Rank": 636,
      "ActiveInterests": 91,
      "ContactDepartment": "",
      "ContactCountryId": 378,
      "ContactOrgNr": "1236842",
      "FaxPhone": "174-236-6186 x6644",
      "MobilePhone": "1-839-423-2996 x974",
      "ContactPhone": "1-449-925-9489 x761",
      "AssociateName": "Kessler, Deckow and Price",
      "AssociateId": 587,
      "UsePersonAddress": false,
      "ContactFax": "assumenda",
      "Kanafname": "cum",
      "Kanalname": "autem",
      "Post1": "sed",
      "Post2": "enim",
      "Post3": "voluptatem",
      "EmailName": "marcia_feeney@conroy.name",
      "ContactFullName": "Russell Genesis Turcotte Sr.",
      "ActiveErpLinks": 255,
      "TicketPriorityId": 216,
      "SupportLanguageId": 100,
      "SupportAssociateId": 734,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 484
        }
      }
    }
  ],
  "AlertLevel": 690,
  "ConnectId": 59,
  "ReadStatus": "Green",
  "TimeToReply": 397,
  "RealTimeToReply": 522,
  "TimeToClose": 381,
  "RealTimeToClose": 342,
  "TimeSpentInternally": 975,
  "TimeSpentExternally": 202,
  "TimeSpentQueue": 317,
  "RealTimeSpentInternally": 736,
  "RealTimeSpentExternally": 410,
  "RealTimeSpentQueue": 175,
  "TimeSpent": 142,
  "HasAttachment": false,
  "NumReplies": 445,
  "NumMessages": 496,
  "FromAddress": "dolorem",
  "Messages": [
    {
      "TicketMessageId": 539,
      "CreatedAt": "2022-02-11T11:06:35.4739443+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "ducimus",
      "PersonId": 344,
      "PersonFullName": "Miss Nayeli Fadel V",
      "ContactId": 185,
      "ContactName": "Herman, West and Hudson",
      "ContactDepartment": "",
      "NumAttachments": 216,
      "EmailHeader": "liana.larson@fadel.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "rerum",
      "Sentiment": 462,
      "SentimentConfidence": 528,
      "CreatedBy": 111,
      "ChangedAt": "2012-06-30T11:06:35.4739443+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 139
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 529,
      "Name": "Jewess-Hartmann",
      "ToolTip": "Quis nihil esse est et.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    },
    {
      "Id": 529,
      "Name": "Jewess-Hartmann",
      "ToolTip": "Quis nihil esse est et.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    }
  ],
  "Language": "corrupti",
  "Sentiment": 172,
  "SentimentConfidence": 866,
  "SuggestedCategoryId": 133,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 473,
  "IconHint": "et",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "modi",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
    "CustomFields2": "provident"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 49
    }
  }
}
```