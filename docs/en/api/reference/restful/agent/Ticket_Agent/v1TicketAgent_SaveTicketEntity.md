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
POST /api/v1/Agents/Ticket/SaveTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 174,
  "Title": "quos",
  "CreatedAt": "2010-02-15T12:57:35.0395582+01:00",
  "LastChanged": "2005-02-21T12:57:35.0395582+01:00",
  "ReadByOwner": "2002-11-03T12:57:35.0395582+01:00",
  "ReadByCustomer": "2017-02-05T12:57:35.0395582+01:00",
  "FirstReadByOwner": "2007-04-12T12:57:35.0395582+02:00",
  "FirstReadByUser": "2009-02-08T12:57:35.0395582+01:00",
  "Activate": "2005-02-19T12:57:35.0395582+01:00",
  "ClosedAt": "1998-10-20T12:57:35.0395582+02:00",
  "RepliedAt": "2023-03-24T12:57:35.0395582+01:00",
  "AlertTimeout": "2007-06-25T12:57:35.0395582+02:00",
  "Deadline": "1999-01-27T12:57:35.0395582+01:00",
  "CreatedBy": null,
  "Author": "sed",
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
      "Position": "veritatis",
      "PersonId": 40,
      "Mrmrs": "molestias",
      "Firstname": "Enrique",
      "Lastname": "Nader",
      "MiddleName": "Blanda Inc and Sons",
      "Title": "quisquam",
      "Description": "De-engineered incremental database",
      "Email": "terrell_kovacek@white.us",
      "FullName": "Diego Bergstrom I",
      "DirectPhone": "069-361-3126 x84765",
      "FormalName": "Kassulke-Schimmel",
      "CountryId": 83,
      "ContactId": 884,
      "ContactName": "Robel LLC",
      "Retired": 898,
      "Rank": 344,
      "ActiveInterests": 246,
      "ContactDepartment": "",
      "ContactCountryId": 358,
      "ContactOrgNr": "903080",
      "FaxPhone": "1-603-902-2140 x38534",
      "MobilePhone": "592-690-8078 x823",
      "ContactPhone": "211.857.6255",
      "AssociateName": "Cruickshank, Hodkiewicz and Nolan",
      "AssociateId": 339,
      "UsePersonAddress": false,
      "ContactFax": "aut",
      "Kanafname": "qui",
      "Kanalname": "inventore",
      "Post1": "quis",
      "Post2": "numquam",
      "Post3": "numquam",
      "EmailName": "haley@abbottwisoky.ca",
      "ContactFullName": "Mr. Ava Hintz",
      "ActiveErpLinks": 507,
      "TicketPriorityId": 953,
      "SupportLanguageId": 448,
      "SupportAssociateId": 313,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 934,
  "ConnectId": 538,
  "ReadStatus": "Green",
  "TimeToReply": 72,
  "RealTimeToReply": 774,
  "TimeToClose": 419,
  "RealTimeToClose": 777,
  "TimeSpentInternally": 245,
  "TimeSpentExternally": 517,
  "TimeSpentQueue": 540,
  "RealTimeSpentInternally": 465,
  "RealTimeSpentExternally": 517,
  "RealTimeSpentQueue": 494,
  "TimeSpent": 333,
  "HasAttachment": false,
  "NumReplies": 12,
  "NumMessages": 837,
  "FromAddress": "est",
  "Messages": [
    {
      "TicketMessageId": 178,
      "CreatedAt": "2006-06-28T12:57:35.0395582+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "qui",
      "PersonId": 249,
      "PersonFullName": "Adrianna Breitenberg",
      "ContactId": 877,
      "ContactName": "Fritsch, Leffler and Hilll",
      "ContactDepartment": "",
      "NumAttachments": 49,
      "EmailHeader": "marietta@cartwrightmcdermott.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "et",
      "Sentiment": 149,
      "SentimentConfidence": 838,
      "CreatedBy": 941,
      "ChangedAt": "2003-12-08T12:57:35.0395582+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 79,
      "Name": "Goodwin, Welch and Hand",
      "ToolTip": "Veniam expedita ut molestiae omnis eos libero."
    },
    {
      "Id": 79,
      "Name": "Goodwin, Welch and Hand",
      "ToolTip": "Veniam expedita ut molestiae omnis eos libero."
    }
  ],
  "Language": "minus",
  "Sentiment": 43,
  "SentimentConfidence": 380,
  "SuggestedCategoryId": 553,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 961,
  "IconHint": "corporis",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 544,
  "ExtraFields": {
    "ExtraFields1": "nisi",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "architecto",
    "CustomFields2": "labore"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 275,
  "Title": "suscipit",
  "CreatedAt": "2018-02-06T12:57:35.0395582+01:00",
  "LastChanged": "2012-02-22T12:57:35.0395582+01:00",
  "ReadByOwner": "2009-06-24T12:57:35.0395582+02:00",
  "ReadByCustomer": "2003-06-29T12:57:35.0395582+02:00",
  "FirstReadByOwner": "2010-11-14T12:57:35.0395582+01:00",
  "FirstReadByUser": "2021-07-16T12:57:35.0395582+02:00",
  "Activate": "2013-01-10T12:57:35.0395582+01:00",
  "ClosedAt": "2007-11-04T12:57:35.0395582+01:00",
  "RepliedAt": "2009-07-14T12:57:35.0395582+02:00",
  "AlertTimeout": "2003-02-13T12:57:35.0395582+01:00",
  "Deadline": "2015-06-20T12:57:35.0395582+02:00",
  "CreatedBy": null,
  "Author": "magnam",
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
      "Position": "consectetur",
      "PersonId": 148,
      "Mrmrs": "voluptatem",
      "Firstname": "Mazie",
      "Lastname": "Zboncak",
      "MiddleName": "Baumbach-Macejkovic",
      "Title": "tenetur",
      "Description": "Re-contextualized systematic algorithm",
      "Email": "cynthia.batz@cruickshankswaniawski.us",
      "FullName": "Ayden Ritchie",
      "DirectPhone": "(228)219-4654 x27497",
      "FormalName": "Waters Group",
      "CountryId": 550,
      "ContactId": 738,
      "ContactName": "Turcotte Inc and Sons",
      "Retired": 942,
      "Rank": 524,
      "ActiveInterests": 948,
      "ContactDepartment": "",
      "ContactCountryId": 417,
      "ContactOrgNr": "542414",
      "FaxPhone": "690.051.2937",
      "MobilePhone": "1-574-133-9765 x2831",
      "ContactPhone": "1-504-990-9872 x34467",
      "AssociateName": "Zieme Inc and Sons",
      "AssociateId": 516,
      "UsePersonAddress": true,
      "ContactFax": "non",
      "Kanafname": "cumque",
      "Kanalname": "nemo",
      "Post1": "qui",
      "Post2": "et",
      "Post3": "esse",
      "EmailName": "dulce.mills@weimann.us",
      "ContactFullName": "Raheem Schultz",
      "ActiveErpLinks": 594,
      "TicketPriorityId": 502,
      "SupportLanguageId": 830,
      "SupportAssociateId": 289,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 928
        }
      }
    }
  ],
  "AlertLevel": 587,
  "ConnectId": 860,
  "ReadStatus": "Green",
  "TimeToReply": 219,
  "RealTimeToReply": 199,
  "TimeToClose": 430,
  "RealTimeToClose": 202,
  "TimeSpentInternally": 8,
  "TimeSpentExternally": 716,
  "TimeSpentQueue": 502,
  "RealTimeSpentInternally": 163,
  "RealTimeSpentExternally": 377,
  "RealTimeSpentQueue": 258,
  "TimeSpent": 196,
  "HasAttachment": false,
  "NumReplies": 957,
  "NumMessages": 537,
  "FromAddress": "ea",
  "Messages": [
    {
      "TicketMessageId": 846,
      "CreatedAt": "2005-11-07T12:57:35.0551794+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "labore",
      "PersonId": 932,
      "PersonFullName": "Dr. Helen Daphne Bins DVM",
      "ContactId": 529,
      "ContactName": "Kautzer, Kutch and Gleason",
      "ContactDepartment": "",
      "NumAttachments": 943,
      "EmailHeader": "betsy@stokes.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "nulla",
      "Sentiment": 635,
      "SentimentConfidence": 360,
      "CreatedBy": 569,
      "ChangedAt": "2003-09-01T12:57:35.0551794+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 557
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 247,
      "Name": "Price Group",
      "ToolTip": "Nulla impedit architecto laudantium repudiandae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 338
        }
      }
    },
    {
      "Id": 247,
      "Name": "Price Group",
      "ToolTip": "Nulla impedit architecto laudantium repudiandae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 338
        }
      }
    }
  ],
  "Language": "magni",
  "Sentiment": 87,
  "SentimentConfidence": 402,
  "SuggestedCategoryId": 336,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 158,
  "IconHint": "consequatur",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 755,
  "ExtraFields": {
    "ExtraFields1": "autem",
    "ExtraFields2": "vel"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "illum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 129
    }
  }
}
```