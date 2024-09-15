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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 379,
  "Title": "alias",
  "CreatedAt": "2020-06-04T04:02:02.378623+02:00",
  "LastChanged": "2014-06-01T04:02:02.378623+02:00",
  "ReadByOwner": "2004-06-14T04:02:02.378623+02:00",
  "ReadByCustomer": "2024-05-03T04:02:02.378623+02:00",
  "FirstReadByOwner": "2019-03-08T04:02:02.378623+01:00",
  "FirstReadByUser": "2009-03-14T04:02:02.378623+01:00",
  "Activate": "2014-06-09T04:02:02.378623+02:00",
  "ClosedAt": "2017-08-04T04:02:02.378623+02:00",
  "RepliedAt": "2006-04-04T04:02:02.378623+02:00",
  "AlertTimeout": "2003-05-10T04:02:02.378623+02:00",
  "Deadline": "2012-12-05T04:02:02.378623+01:00",
  "CreatedBy": null,
  "Author": "culpa",
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
      "Position": "voluptatem",
      "PersonId": 162,
      "Mrmrs": "repellendus",
      "Firstname": "Jammie",
      "Lastname": "Pfannerstill",
      "MiddleName": "Swaniawski-Jones",
      "Title": "quo",
      "Description": "Optimized transitional system engine",
      "Email": "rupert_fay@keeling.biz",
      "FullName": "Miss Drake Schinner",
      "DirectPhone": "272-601-1495",
      "FormalName": "Hermiston-Christiansen",
      "CountryId": 110,
      "ContactId": 431,
      "ContactName": "Russel-Jacobi",
      "Retired": 652,
      "Rank": 407,
      "ActiveInterests": 941,
      "ContactDepartment": "",
      "ContactCountryId": 112,
      "ContactOrgNr": "156048",
      "FaxPhone": "611.273.6302",
      "MobilePhone": "049.810.1111 x231",
      "ContactPhone": "1-388-225-8629",
      "AssociateName": "Erdman, Streich and Auer",
      "AssociateId": 376,
      "UsePersonAddress": false,
      "ContactFax": "non",
      "Kanafname": "quia",
      "Kanalname": "est",
      "Post1": "qui",
      "Post2": "provident",
      "Post3": "rem",
      "EmailName": "bernice@harberritchie.biz",
      "ContactFullName": "Prof. Idella Quigley",
      "ActiveErpLinks": 960,
      "TicketPriorityId": 845,
      "SupportLanguageId": 775,
      "SupportAssociateId": 707,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 988,
  "ConnectId": 8,
  "ReadStatus": "Green",
  "TimeToReply": 948,
  "RealTimeToReply": 483,
  "TimeToClose": 695,
  "RealTimeToClose": 226,
  "TimeSpentInternally": 148,
  "TimeSpentExternally": 135,
  "TimeSpentQueue": 774,
  "RealTimeSpentInternally": 91,
  "RealTimeSpentExternally": 541,
  "RealTimeSpentQueue": 368,
  "TimeSpent": 74,
  "HasAttachment": false,
  "NumReplies": 790,
  "NumMessages": 212,
  "FromAddress": "sit",
  "Messages": [
    {
      "TicketMessageId": 409,
      "CreatedAt": "2020-10-11T04:02:02.378623+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "laboriosam",
      "PersonId": 74,
      "PersonFullName": "Andy Welch",
      "ContactId": 522,
      "ContactName": "Walter Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 668,
      "EmailHeader": "angel@johnston.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "pariatur",
      "Sentiment": 676,
      "SentimentConfidence": 457,
      "CreatedBy": 666,
      "ChangedAt": "1998-06-21T04:02:02.378623+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 26,
      "Name": "Heathcote LLC",
      "ToolTip": "Sed id corrupti."
    },
    {
      "Id": 26,
      "Name": "Heathcote LLC",
      "ToolTip": "Sed id corrupti."
    }
  ],
  "Language": "aut",
  "Sentiment": 738,
  "SentimentConfidence": 39,
  "SuggestedCategoryId": 123,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 267,
  "IconHint": "numquam",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 944,
  "ExtraFields": {
    "ExtraFields1": "recusandae",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "veritatis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 716,
  "Title": "libero",
  "CreatedAt": "2002-02-03T04:02:02.378623+01:00",
  "LastChanged": "2001-07-24T04:02:02.378623+02:00",
  "ReadByOwner": "2000-12-15T04:02:02.378623+01:00",
  "ReadByCustomer": "2001-05-13T04:02:02.378623+02:00",
  "FirstReadByOwner": "2000-04-16T04:02:02.378623+02:00",
  "FirstReadByUser": "2016-04-02T04:02:02.378623+02:00",
  "Activate": "2005-11-09T04:02:02.378623+01:00",
  "ClosedAt": "2003-08-30T04:02:02.378623+02:00",
  "RepliedAt": "1998-03-08T04:02:02.378623+01:00",
  "AlertTimeout": "2019-09-30T04:02:02.378623+02:00",
  "Deadline": "2004-09-26T04:02:02.378623+02:00",
  "CreatedBy": null,
  "Author": "totam",
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
      "Position": "earum",
      "PersonId": 574,
      "Mrmrs": "est",
      "Firstname": "Gunnar",
      "Lastname": "Bartoletti",
      "MiddleName": "Terry Inc and Sons",
      "Title": "qui",
      "Description": "Team-oriented incremental collaboration",
      "Email": "alexys_fay@west.us",
      "FullName": "Orion Bailey",
      "DirectPhone": "772.551.3635",
      "FormalName": "Vandervort LLC",
      "CountryId": 893,
      "ContactId": 575,
      "ContactName": "Denesik, Marks and Stokes",
      "Retired": 885,
      "Rank": 124,
      "ActiveInterests": 910,
      "ContactDepartment": "",
      "ContactCountryId": 108,
      "ContactOrgNr": "857643",
      "FaxPhone": "767.652.8816",
      "MobilePhone": "029-268-9812 x8159",
      "ContactPhone": "753-943-7715 x457",
      "AssociateName": "Reinger, Krajcik and Rogahn",
      "AssociateId": 602,
      "UsePersonAddress": false,
      "ContactFax": "in",
      "Kanafname": "et",
      "Kanalname": "dolorem",
      "Post1": "sed",
      "Post2": "magnam",
      "Post3": "corporis",
      "EmailName": "keara_greenholt@cummings.us",
      "ContactFullName": "Zander Moen",
      "ActiveErpLinks": 376,
      "TicketPriorityId": 496,
      "SupportLanguageId": 383,
      "SupportAssociateId": 65,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 654
        }
      }
    }
  ],
  "AlertLevel": 98,
  "ConnectId": 758,
  "ReadStatus": "Green",
  "TimeToReply": 755,
  "RealTimeToReply": 780,
  "TimeToClose": 599,
  "RealTimeToClose": 357,
  "TimeSpentInternally": 584,
  "TimeSpentExternally": 165,
  "TimeSpentQueue": 547,
  "RealTimeSpentInternally": 331,
  "RealTimeSpentExternally": 349,
  "RealTimeSpentQueue": 181,
  "TimeSpent": 318,
  "HasAttachment": false,
  "NumReplies": 356,
  "NumMessages": 179,
  "FromAddress": "aliquam",
  "Messages": [
    {
      "TicketMessageId": 420,
      "CreatedAt": "2003-11-28T04:02:02.3942465+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "magnam",
      "PersonId": 194,
      "PersonFullName": "Mrs. Duncan Rusty Bartell V",
      "ContactId": 237,
      "ContactName": "Gislason-Considine",
      "ContactDepartment": "",
      "NumAttachments": 533,
      "EmailHeader": "laverne_hoppe@skiles.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "sint",
      "Sentiment": 821,
      "SentimentConfidence": 169,
      "CreatedBy": 347,
      "ChangedAt": "2007-05-26T04:02:02.3942465+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 581
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 226,
      "Name": "Prosacco LLC",
      "ToolTip": "Necessitatibus corrupti.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 59
        }
      }
    },
    {
      "Id": 226,
      "Name": "Prosacco LLC",
      "ToolTip": "Necessitatibus corrupti.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 59
        }
      }
    }
  ],
  "Language": "dicta",
  "Sentiment": 89,
  "SentimentConfidence": 216,
  "SuggestedCategoryId": 254,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 111,
  "IconHint": "et",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 823,
  "ExtraFields": {
    "ExtraFields1": "ad",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "est"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 488
    }
  }
}
```