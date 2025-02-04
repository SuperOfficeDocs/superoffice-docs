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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketId": 997,
  "Title": "qui",
  "CreatedAt": "2012-09-28T13:13:24.087242+02:00",
  "LastChanged": "2012-07-18T13:13:24.087242+02:00",
  "ReadByOwner": "2003-09-24T13:13:24.087242+02:00",
  "ReadByCustomer": "2007-01-28T13:13:24.087242+01:00",
  "FirstReadByOwner": "2023-07-17T13:13:24.087242+02:00",
  "FirstReadByUser": "2013-05-07T13:13:24.087242+02:00",
  "Activate": "2009-12-05T13:13:24.087242+01:00",
  "ClosedAt": "2006-07-17T13:13:24.087242+02:00",
  "RepliedAt": "2007-09-13T13:13:24.087242+02:00",
  "AlertTimeout": "2017-12-04T13:13:24.087242+01:00",
  "Deadline": "2019-11-10T13:13:24.087242+01:00",
  "CreatedBy": null,
  "Author": "cumque",
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
      "Position": "quibusdam",
      "PersonId": 300,
      "Mrmrs": "eum",
      "Firstname": "Amelia",
      "Lastname": "Mueller",
      "MiddleName": "Jakubowski Inc and Sons",
      "Title": "assumenda",
      "Description": "Open-architected cohesive framework",
      "Email": "keyon@blanda.biz",
      "FullName": "Lonzo Pfeffer",
      "DirectPhone": "856.172.0211",
      "FormalName": "Labadie LLC",
      "CountryId": 296,
      "ContactId": 10,
      "ContactName": "Ferry Group",
      "Retired": 875,
      "Rank": 150,
      "ActiveInterests": 600,
      "ContactDepartment": "",
      "ContactCountryId": 336,
      "ContactOrgNr": "770035",
      "FaxPhone": "355.357.1968 x6779",
      "MobilePhone": "1-507-750-6266 x1096",
      "ContactPhone": "935.039.1676 x9598",
      "AssociateName": "Wiza Inc and Sons",
      "AssociateId": 249,
      "UsePersonAddress": true,
      "ContactFax": "autem",
      "Kanafname": "nihil",
      "Kanalname": "officia",
      "Post1": "architecto",
      "Post2": "molestiae",
      "Post3": "facilis",
      "EmailName": "emily@conroy.name",
      "ContactFullName": "Cyrus Murazik Jr.",
      "ActiveErpLinks": 725,
      "TicketPriorityId": 811,
      "SupportLanguageId": 380,
      "SupportAssociateId": 780,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 121,
  "ConnectId": 967,
  "ReadStatus": "Green",
  "TimeToReply": 123,
  "RealTimeToReply": 324,
  "TimeToClose": 20,
  "RealTimeToClose": 929,
  "TimeSpentInternally": 863,
  "TimeSpentExternally": 301,
  "TimeSpentQueue": 945,
  "RealTimeSpentInternally": 860,
  "RealTimeSpentExternally": 478,
  "RealTimeSpentQueue": 468,
  "TimeSpent": 459,
  "HasAttachment": false,
  "NumReplies": 801,
  "NumMessages": 433,
  "FromAddress": "cumque",
  "Messages": [
    {
      "TicketMessageId": 666,
      "CreatedAt": "2003-07-19T13:13:24.1497311+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "vero",
      "PersonId": 127,
      "PersonFullName": "Jayson Satterfield",
      "ContactId": 504,
      "ContactName": "Friesen-Moen",
      "ContactDepartment": "",
      "NumAttachments": 129,
      "EmailHeader": "freda@gerlachkohler.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ab",
      "Sentiment": 600,
      "SentimentConfidence": 983,
      "CreatedBy": 536,
      "ChangedAt": "2022-07-30T13:13:24.1653529+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 731,
      "Name": "Tillman-Reichel",
      "ToolTip": "Ad corrupti eos."
    },
    {
      "Id": 731,
      "Name": "Tillman-Reichel",
      "ToolTip": "Ad corrupti eos."
    }
  ],
  "Language": "aut",
  "Sentiment": 653,
  "SentimentConfidence": 280,
  "SuggestedCategoryId": 829,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 810,
  "IconHint": "tempore",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 364,
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "quo"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 727,
  "Title": "error",
  "CreatedAt": "2020-04-07T13:13:24.2121622+02:00",
  "LastChanged": "2023-03-02T13:13:24.2121622+01:00",
  "ReadByOwner": "2014-09-11T13:13:24.2121622+02:00",
  "ReadByCustomer": "2016-03-23T13:13:24.2121622+01:00",
  "FirstReadByOwner": "2010-07-14T13:13:24.2121622+02:00",
  "FirstReadByUser": "2017-08-29T13:13:24.2121622+02:00",
  "Activate": "2009-10-21T13:13:24.2121622+02:00",
  "ClosedAt": "2017-03-20T13:13:24.2121622+01:00",
  "RepliedAt": "2006-03-03T13:13:24.2121622+01:00",
  "AlertTimeout": "2009-11-10T13:13:24.2121622+01:00",
  "Deadline": "2001-12-09T13:13:24.2121622+01:00",
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
      "Position": "recusandae",
      "PersonId": 617,
      "Mrmrs": "corporis",
      "Firstname": "Virginia",
      "Lastname": "Medhurst",
      "MiddleName": "Halvorson Inc and Sons",
      "Title": "illo",
      "Description": "Front-line optimal project",
      "Email": "victoria.kautzer@denesik.co.uk",
      "FullName": "Daniella D'Amore DDS",
      "DirectPhone": "043.124.5469 x40163",
      "FormalName": "Jakubowski-Daniel",
      "CountryId": 223,
      "ContactId": 135,
      "ContactName": "Emmerich-Yundt",
      "Retired": 915,
      "Rank": 971,
      "ActiveInterests": 504,
      "ContactDepartment": "",
      "ContactCountryId": 684,
      "ContactOrgNr": "1612951",
      "FaxPhone": "1-194-973-2808",
      "MobilePhone": "(915)594-4136",
      "ContactPhone": "883.691.8047 x54031",
      "AssociateName": "Bergstrom, Treutel and Jaskolski",
      "AssociateId": 442,
      "UsePersonAddress": true,
      "ContactFax": "sed",
      "Kanafname": "quisquam",
      "Kanalname": "facere",
      "Post1": "veniam",
      "Post2": "nostrum",
      "Post3": "vitae",
      "EmailName": "desmond.borer@nikolauscrist.us",
      "ContactFullName": "Donnie Marjory Heidenreich MD",
      "ActiveErpLinks": 418,
      "TicketPriorityId": 927,
      "SupportLanguageId": 965,
      "SupportAssociateId": 328,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 151
        }
      }
    }
  ],
  "AlertLevel": 831,
  "ConnectId": 749,
  "ReadStatus": "Green",
  "TimeToReply": 31,
  "RealTimeToReply": 85,
  "TimeToClose": 505,
  "RealTimeToClose": 901,
  "TimeSpentInternally": 24,
  "TimeSpentExternally": 513,
  "TimeSpentQueue": 539,
  "RealTimeSpentInternally": 44,
  "RealTimeSpentExternally": 144,
  "RealTimeSpentQueue": 503,
  "TimeSpent": 948,
  "HasAttachment": false,
  "NumReplies": 286,
  "NumMessages": 415,
  "FromAddress": "repellendus",
  "Messages": [
    {
      "TicketMessageId": 400,
      "CreatedAt": "2008-12-23T13:13:24.2121622+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "et",
      "PersonId": 456,
      "PersonFullName": "Jamaal Orn I",
      "ContactId": 806,
      "ContactName": "Hettinger-Bradtke",
      "ContactDepartment": "",
      "NumAttachments": 461,
      "EmailHeader": "ettie@feil.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "dolores",
      "Sentiment": 614,
      "SentimentConfidence": 638,
      "CreatedBy": 898,
      "ChangedAt": "2005-06-06T13:13:24.2121622+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 981
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 587,
      "Name": "McLaughlin, Baumbach and Ortiz",
      "ToolTip": "Voluptatem rerum et nemo odio.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 918
        }
      }
    },
    {
      "Id": 587,
      "Name": "McLaughlin, Baumbach and Ortiz",
      "ToolTip": "Voluptatem rerum et nemo odio.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 918
        }
      }
    }
  ],
  "Language": "aut",
  "Sentiment": 7,
  "SentimentConfidence": 763,
  "SuggestedCategoryId": 88,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 473,
  "IconHint": "excepturi",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 616,
  "ExtraFields": {
    "ExtraFields1": "possimus",
    "ExtraFields2": "fugit"
  },
  "CustomFields": {
    "CustomFields1": "sunt",
    "CustomFields2": "repellat"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 579
    }
  }
}
```