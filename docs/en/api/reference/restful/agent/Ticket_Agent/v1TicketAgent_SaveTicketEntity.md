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
| TicketType | TicketType | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
| ActiveStatusMonitorId | int32 | Active status monitor identity for related contact. This is a read-only property and is ignored on Save |
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
  "TicketId": 952,
  "Title": "et",
  "CreatedAt": "2021-12-11T23:03:57.2361119+01:00",
  "LastChanged": "2005-02-01T23:03:57.2361119+01:00",
  "ReadByOwner": "2023-08-06T23:03:57.2361119+02:00",
  "ReadByCustomer": "1996-12-24T23:03:57.2361119+01:00",
  "FirstReadByOwner": "1999-06-25T23:03:57.2361119+02:00",
  "FirstReadByUser": "2018-09-07T23:03:57.2361119+02:00",
  "Activate": "1997-05-12T23:03:57.2361119+02:00",
  "ClosedAt": "2012-04-26T23:03:57.2361119+02:00",
  "RepliedAt": "2021-10-15T23:03:57.2361119+02:00",
  "AlertTimeout": "2001-01-18T23:03:57.2361119+01:00",
  "Deadline": "1997-04-02T23:03:57.2361119+02:00",
  "CreatedBy": null,
  "Author": "esse",
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
      "Position": "laudantium",
      "PersonId": 329,
      "Mrmrs": "odio",
      "Firstname": "Elmo",
      "Lastname": "Pollich",
      "MiddleName": "Crona-Blick",
      "Title": "impedit",
      "Description": "Versatile attitude-oriented alliance",
      "Email": "rene.schmidt@purdydeckow.uk",
      "FullName": "Milford Keebler",
      "DirectPhone": "537.434.3000",
      "FormalName": "Luettgen-Vandervort",
      "CountryId": 206,
      "ContactId": 745,
      "ContactName": "Green Group",
      "Retired": 517,
      "Rank": 880,
      "ActiveInterests": 210,
      "ContactDepartment": "",
      "ContactCountryId": 74,
      "ContactOrgNr": "898700",
      "FaxPhone": "283.601.8500 x88740",
      "MobilePhone": "659.166.8398",
      "ContactPhone": "483.407.9063 x00932",
      "AssociateName": "Feeney, Murazik and Willms",
      "AssociateId": 163,
      "UsePersonAddress": true,
      "ContactFax": "laborum",
      "Kanafname": "ad",
      "Kanalname": "quis",
      "Post1": "occaecati",
      "Post2": "commodi",
      "Post3": "odio",
      "EmailName": "aubrey.fisher@kshlerin.com",
      "ContactFullName": "Miss Israel Wilkinson",
      "ActiveErpLinks": 692,
      "TicketPriorityId": 320,
      "SupportLanguageId": 833,
      "SupportAssociateId": 171,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 17,
  "ConnectId": 31,
  "ReadStatus": "Green",
  "TimeToReply": 509,
  "RealTimeToReply": 59,
  "TimeToClose": 373,
  "RealTimeToClose": 110,
  "TimeSpentInternally": 982,
  "TimeSpentExternally": 680,
  "TimeSpentQueue": 946,
  "RealTimeSpentInternally": 617,
  "RealTimeSpentExternally": 911,
  "RealTimeSpentQueue": 959,
  "TimeSpent": 334,
  "HasAttachment": false,
  "NumReplies": 74,
  "NumMessages": 3,
  "FromAddress": "alias",
  "Messages": [
    {
      "TicketMessageId": 380,
      "CreatedAt": "2013-07-17T23:03:57.2421121+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "non",
      "PersonId": 311,
      "PersonFullName": "Ms. Jensen Beatty DDS",
      "ContactId": 58,
      "ContactName": "Smith, Kautzer and Yost",
      "ContactDepartment": "",
      "NumAttachments": 649,
      "EmailHeader": "doug_oreilly@huelhoeger.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "molestiae",
      "Sentiment": 36,
      "SentimentConfidence": 644,
      "CreatedBy": 730,
      "ChangedAt": "2005-01-05T23:03:57.2426182+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 974,
      "Name": "Russel-Champlin",
      "ToolTip": "Quia debitis dignissimos."
    },
    {
      "Id": 974,
      "Name": "Russel-Champlin",
      "ToolTip": "Quia debitis dignissimos."
    }
  ],
  "Language": "dolor",
  "Sentiment": 614,
  "SentimentConfidence": 382,
  "SuggestedCategoryId": 66,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 51,
  "IconHint": "est",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 730,
  "ExtraFields": {
    "ExtraFields1": "nulla",
    "ExtraFields2": "veniam"
  },
  "CustomFields": {
    "CustomFields1": "reiciendis",
    "CustomFields2": "animi"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 674,
  "Title": "qui",
  "CreatedAt": "2012-04-11T23:03:57.2506145+02:00",
  "LastChanged": "2003-12-08T23:03:57.2506145+01:00",
  "ReadByOwner": "2012-03-17T23:03:57.2506145+01:00",
  "ReadByCustomer": "2014-05-04T23:03:57.2506145+02:00",
  "FirstReadByOwner": "2003-03-22T23:03:57.2506145+01:00",
  "FirstReadByUser": "2010-12-16T23:03:57.2506145+01:00",
  "Activate": "2010-08-03T23:03:57.2506145+02:00",
  "ClosedAt": "2011-02-25T23:03:57.2506145+01:00",
  "RepliedAt": "2011-09-04T23:03:57.2506145+02:00",
  "AlertTimeout": "2023-04-20T23:03:57.2506145+02:00",
  "Deadline": "2021-03-22T23:03:57.2506145+01:00",
  "CreatedBy": null,
  "Author": "dolore",
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
      "Position": "ipsum",
      "PersonId": 708,
      "Mrmrs": "velit",
      "Firstname": "Antwan",
      "Lastname": "Davis",
      "MiddleName": "Daugherty, Hudson and Deckow",
      "Title": "maiores",
      "Description": "Quality-focused coherent knowledge base",
      "Email": "bo_turner@jast.com",
      "FullName": "Mohammad Raynor",
      "DirectPhone": "(585)221-9497",
      "FormalName": "Schinner Group",
      "CountryId": 259,
      "ContactId": 799,
      "ContactName": "Schuppe-Borer",
      "Retired": 940,
      "Rank": 31,
      "ActiveInterests": 638,
      "ContactDepartment": "",
      "ContactCountryId": 450,
      "ContactOrgNr": "490294",
      "FaxPhone": "(967)980-1693 x37787",
      "MobilePhone": "882.358.6114",
      "ContactPhone": "(357)859-7217 x997",
      "AssociateName": "Rice, Schiller and Schimmel",
      "AssociateId": 131,
      "UsePersonAddress": false,
      "ContactFax": "non",
      "Kanafname": "aut",
      "Kanalname": "eaque",
      "Post1": "id",
      "Post2": "molestias",
      "Post3": "illo",
      "EmailName": "sincere.harvey@dach.biz",
      "ContactFullName": "Mrs. Molly Lubowitz DDS",
      "ActiveErpLinks": 679,
      "TicketPriorityId": 54,
      "SupportLanguageId": 513,
      "SupportAssociateId": 555,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 226
        }
      }
    }
  ],
  "AlertLevel": 192,
  "ConnectId": 570,
  "ReadStatus": "Green",
  "TimeToReply": 510,
  "RealTimeToReply": 157,
  "TimeToClose": 157,
  "RealTimeToClose": 454,
  "TimeSpentInternally": 984,
  "TimeSpentExternally": 625,
  "TimeSpentQueue": 271,
  "RealTimeSpentInternally": 539,
  "RealTimeSpentExternally": 323,
  "RealTimeSpentQueue": 162,
  "TimeSpent": 408,
  "HasAttachment": false,
  "NumReplies": 875,
  "NumMessages": 367,
  "FromAddress": "quia",
  "Messages": [
    {
      "TicketMessageId": 580,
      "CreatedAt": "2008-08-29T23:03:57.2551111+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "et",
      "PersonId": 555,
      "PersonFullName": "Miss Gunnar Randall Ryan",
      "ContactId": 92,
      "ContactName": "Stracke Group",
      "ContactDepartment": "",
      "NumAttachments": 104,
      "EmailHeader": "roscoe@olson.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "et",
      "Sentiment": 175,
      "SentimentConfidence": 575,
      "CreatedBy": 729,
      "ChangedAt": "2013-02-04T23:03:57.2556114+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 954
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 78,
      "Name": "Welch-McClure",
      "ToolTip": "Voluptates cumque temporibus maiores.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 939
        }
      }
    },
    {
      "Id": 78,
      "Name": "Welch-McClure",
      "ToolTip": "Voluptates cumque temporibus maiores.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 939
        }
      }
    }
  ],
  "Language": "laborum",
  "Sentiment": 687,
  "SentimentConfidence": 792,
  "SuggestedCategoryId": 726,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 300,
  "IconHint": "autem",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 871,
  "ExtraFields": {
    "ExtraFields1": "pariatur",
    "ExtraFields2": "similique"
  },
  "CustomFields": {
    "CustomFields1": "deleniti",
    "CustomFields2": "nam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 125
    }
  }
}
```