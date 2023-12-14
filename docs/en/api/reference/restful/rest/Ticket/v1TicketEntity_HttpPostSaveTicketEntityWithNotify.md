---
title: POST Ticket
uid: v1TicketEntity_HttpPostSaveTicketEntityWithNotify
generated: true
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
POST /api/v1/Ticket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketId": 785,
  "Title": "repellat",
  "CreatedAt": "2012-11-02T13:57:19.297149+01:00",
  "LastChanged": "2019-08-01T13:57:19.297149+02:00",
  "ReadByOwner": "2007-07-15T13:57:19.297149+02:00",
  "ReadByCustomer": "2004-02-24T13:57:19.297149+01:00",
  "FirstReadByOwner": "1996-11-06T13:57:19.297149+01:00",
  "FirstReadByUser": "2013-10-03T13:57:19.297149+02:00",
  "Activate": "2002-06-17T13:57:19.297149+02:00",
  "ClosedAt": "2010-06-21T13:57:19.297149+02:00",
  "RepliedAt": "2000-09-12T13:57:19.297149+02:00",
  "AlertTimeout": "2013-06-29T13:57:19.297149+02:00",
  "Deadline": "2010-06-16T13:57:19.297149+02:00",
  "CreatedBy": null,
  "Author": "rem",
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
      "Position": "rerum",
      "PersonId": 539,
      "Mrmrs": "maxime",
      "Firstname": "Eliza",
      "Lastname": "Bernhard",
      "MiddleName": "Kuhlman, Donnelly and Pouros",
      "Title": "ut",
      "Description": "Synergistic empowering open architecture",
      "Email": "tiara@blanda.uk",
      "FullName": "Freddie Sipes",
      "DirectPhone": "(347)506-6244",
      "FormalName": "Howell-Cronin",
      "CountryId": 255,
      "ContactId": 23,
      "ContactName": "Fay-Feest",
      "Retired": 550,
      "Rank": 133,
      "ActiveInterests": 534,
      "ContactDepartment": "",
      "ContactCountryId": 251,
      "ContactOrgNr": "937186",
      "FaxPhone": "1-394-350-3125",
      "MobilePhone": "(723)081-9874 x2785",
      "ContactPhone": "380.445.5048 x39083",
      "AssociateName": "Upton LLC",
      "AssociateId": 763,
      "UsePersonAddress": false,
      "ContactFax": "deleniti",
      "Kanafname": "aspernatur",
      "Kanalname": "eos",
      "Post1": "esse",
      "Post2": "culpa",
      "Post3": "dicta",
      "EmailName": "makenzie@willdooley.com",
      "ContactFullName": "Mrs. Bradly Erwin Armstrong",
      "ActiveErpLinks": 559,
      "TicketPriorityId": 249,
      "SupportLanguageId": 366,
      "SupportAssociateId": 728,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 271,
  "ConnectId": 802,
  "ReadStatus": "Green",
  "TimeToReply": 270,
  "RealTimeToReply": 519,
  "TimeToClose": 702,
  "RealTimeToClose": 546,
  "TimeSpentInternally": 859,
  "TimeSpentExternally": 423,
  "TimeSpentQueue": 726,
  "RealTimeSpentInternally": 878,
  "RealTimeSpentExternally": 227,
  "RealTimeSpentQueue": 488,
  "TimeSpent": 702,
  "HasAttachment": false,
  "NumReplies": 647,
  "NumMessages": 824,
  "FromAddress": "est",
  "Messages": [
    {
      "TicketMessageId": 337,
      "CreatedAt": "2019-08-03T13:57:19.3127731+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "nihil",
      "PersonId": 664,
      "PersonFullName": "Mr. Dane Boyer",
      "ContactId": 298,
      "ContactName": "Wunsch-Nienow",
      "ContactDepartment": "",
      "NumAttachments": 928,
      "EmailHeader": "drake_stehr@schmitt.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "eligendi",
      "Sentiment": 866,
      "SentimentConfidence": 831,
      "CreatedBy": 532,
      "ChangedAt": "2013-08-05T13:57:19.3127731+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 965,
      "Name": "Carroll Group",
      "ToolTip": "Esse accusantium nostrum adipisci veritatis pariatur in."
    },
    {
      "Id": 965,
      "Name": "Carroll Group",
      "ToolTip": "Esse accusantium nostrum adipisci veritatis pariatur in."
    }
  ],
  "Language": "fugit",
  "Sentiment": 473,
  "SentimentConfidence": 537,
  "SuggestedCategoryId": 266,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 462,
  "IconHint": "aut",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "dolor",
    "ExtraFields2": "laborum"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "blanditiis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 301,
  "Title": "numquam",
  "CreatedAt": "1998-02-18T13:57:19.3127731+01:00",
  "LastChanged": "2003-12-06T13:57:19.3127731+01:00",
  "ReadByOwner": "2019-07-03T13:57:19.3127731+02:00",
  "ReadByCustomer": "1997-11-17T13:57:19.3127731+01:00",
  "FirstReadByOwner": "2008-06-08T13:57:19.3127731+02:00",
  "FirstReadByUser": "2013-07-22T13:57:19.3127731+02:00",
  "Activate": "1997-09-30T13:57:19.3127731+02:00",
  "ClosedAt": "2023-08-24T13:57:19.3127731+02:00",
  "RepliedAt": "2018-12-06T13:57:19.3127731+01:00",
  "AlertTimeout": "2023-01-30T13:57:19.3127731+01:00",
  "Deadline": "2006-08-21T13:57:19.3127731+02:00",
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
      "Position": "expedita",
      "PersonId": 438,
      "Mrmrs": "quo",
      "Firstname": "Lance",
      "Lastname": "Goldner",
      "MiddleName": "Kihn Inc and Sons",
      "Title": "dolor",
      "Description": "User-friendly multi-state data-warehouse",
      "Email": "amparo@hauck.com",
      "FullName": "Dr. Dejah Halie Jacobson Jr.",
      "DirectPhone": "(296)527-5719",
      "FormalName": "Feeney Group",
      "CountryId": 67,
      "ContactId": 742,
      "ContactName": "Mills-Bogisich",
      "Retired": 58,
      "Rank": 726,
      "ActiveInterests": 29,
      "ContactDepartment": "",
      "ContactCountryId": 272,
      "ContactOrgNr": "886321",
      "FaxPhone": "1-200-072-2715",
      "MobilePhone": "977.490.3070",
      "ContactPhone": "200.088.9621",
      "AssociateName": "Nienow Inc and Sons",
      "AssociateId": 630,
      "UsePersonAddress": false,
      "ContactFax": "aut",
      "Kanafname": "dolore",
      "Kanalname": "eaque",
      "Post1": "est",
      "Post2": "mollitia",
      "Post3": "alias",
      "EmailName": "shania@welch.info",
      "ContactFullName": "Adriel Mraz Sr.",
      "ActiveErpLinks": 740,
      "TicketPriorityId": 911,
      "SupportLanguageId": 388,
      "SupportAssociateId": 283,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 661
        }
      }
    }
  ],
  "AlertLevel": 271,
  "ConnectId": 212,
  "ReadStatus": "Green",
  "TimeToReply": 431,
  "RealTimeToReply": 223,
  "TimeToClose": 825,
  "RealTimeToClose": 719,
  "TimeSpentInternally": 123,
  "TimeSpentExternally": 973,
  "TimeSpentQueue": 514,
  "RealTimeSpentInternally": 651,
  "RealTimeSpentExternally": 551,
  "RealTimeSpentQueue": 931,
  "TimeSpent": 536,
  "HasAttachment": false,
  "NumReplies": 601,
  "NumMessages": 754,
  "FromAddress": "excepturi",
  "Messages": [
    {
      "TicketMessageId": 252,
      "CreatedAt": "2019-11-28T13:57:19.3127731+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "aut",
      "PersonId": 721,
      "PersonFullName": "Miss Fritz Damaris Mraz",
      "ContactId": 847,
      "ContactName": "Pollich Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 359,
      "EmailHeader": "guido@morar.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quod",
      "Sentiment": 353,
      "SentimentConfidence": 53,
      "CreatedBy": 365,
      "ChangedAt": "2018-11-15T13:57:19.3127731+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 987
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 397,
      "Name": "Feest Group",
      "ToolTip": "Voluptatem error quidem temporibus quae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 76
        }
      }
    },
    {
      "Id": 397,
      "Name": "Feest Group",
      "ToolTip": "Voluptatem error quidem temporibus quae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 76
        }
      }
    }
  ],
  "Language": "fugit",
  "Sentiment": 838,
  "SentimentConfidence": 347,
  "SuggestedCategoryId": 619,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 859,
  "IconHint": "quas",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "saepe",
    "ExtraFields2": "eligendi"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "consectetur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 434
    }
  }
}
```