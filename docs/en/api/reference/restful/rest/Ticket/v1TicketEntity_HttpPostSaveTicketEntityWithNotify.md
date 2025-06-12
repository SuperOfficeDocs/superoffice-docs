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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 266,
  "Title": "consequatur",
  "CreatedAt": "2003-07-05T17:54:08.5543174+02:00",
  "LastChanged": "2012-01-25T17:54:08.5543174+01:00",
  "ReadByOwner": "2019-03-25T17:54:08.5543174+01:00",
  "ReadByCustomer": "2000-09-20T17:54:08.5543174+02:00",
  "FirstReadByOwner": "2013-02-24T17:54:08.5543174+01:00",
  "FirstReadByUser": "2015-01-09T17:54:08.5543174+01:00",
  "Activate": "2013-03-26T17:54:08.5543174+01:00",
  "ClosedAt": "2001-11-10T17:54:08.5543174+01:00",
  "RepliedAt": "2015-07-05T17:54:08.5543174+02:00",
  "AlertTimeout": "2013-08-19T17:54:08.5543174+02:00",
  "Deadline": "2004-07-12T17:54:08.5543174+02:00",
  "CreatedBy": null,
  "Author": "quis",
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
      "Position": "tenetur",
      "PersonId": 190,
      "Mrmrs": "ut",
      "Firstname": "Meaghan",
      "Lastname": "Kirlin",
      "MiddleName": "Robel-O'Reilly",
      "Title": "sed",
      "Description": "Right-sized 24 hour product",
      "Email": "chaim@stanton.biz",
      "FullName": "Haylie Harris",
      "DirectPhone": "(629)738-6049",
      "FormalName": "Kuhic, Orn and Kub",
      "CountryId": 837,
      "ContactId": 950,
      "ContactName": "Gleichner, Konopelski and Denesik",
      "Retired": 660,
      "Rank": 904,
      "ActiveInterests": 859,
      "ContactDepartment": "",
      "ContactCountryId": 224,
      "ContactOrgNr": "907161",
      "FaxPhone": "049-769-3954",
      "MobilePhone": "716.015.7525",
      "ContactPhone": "548.982.2203 x64139",
      "AssociateName": "Altenwerth Inc and Sons",
      "AssociateId": 951,
      "UsePersonAddress": false,
      "ContactFax": "magnam",
      "Kanafname": "et",
      "Kanalname": "laudantium",
      "Post1": "unde",
      "Post2": "a",
      "Post3": "neque",
      "EmailName": "sarah@kerluke.us",
      "ContactFullName": "Dr. Louvenia Lindgren PhD",
      "ActiveErpLinks": 896,
      "TicketPriorityId": 420,
      "SupportLanguageId": 601,
      "SupportAssociateId": 148,
      "CategoryName": "VIP Customer",
      "PersonNumber": "576590"
    }
  ],
  "AlertLevel": 152,
  "ConnectId": 643,
  "ReadStatus": "Green",
  "TimeToReply": 714,
  "RealTimeToReply": 422,
  "TimeToClose": 710,
  "RealTimeToClose": 405,
  "TimeSpentInternally": 14,
  "TimeSpentExternally": 932,
  "TimeSpentQueue": 730,
  "RealTimeSpentInternally": 333,
  "RealTimeSpentExternally": 562,
  "RealTimeSpentQueue": 812,
  "TimeSpent": 981,
  "HasAttachment": false,
  "NumReplies": 712,
  "NumMessages": 716,
  "FromAddress": "dolores",
  "Messages": [
    {
      "TicketMessageId": 297,
      "CreatedAt": "2003-10-13T17:54:08.5543174+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "illum",
      "PersonId": 716,
      "PersonFullName": "Marianne Ross Ziemann II",
      "ContactId": 797,
      "ContactName": "Bechtelar, Homenick and Pfannerstill",
      "ContactDepartment": "engage interactive initiatives",
      "NumAttachments": 467,
      "EmailHeader": "madalyn@halvorsonaltenwerth.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "est",
      "Sentiment": 266,
      "SentimentConfidence": 621,
      "CreatedBy": 650,
      "ChangedAt": "2021-11-11T17:54:08.5543174+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 496,
      "Name": "Schoen, Walter and Grady",
      "ToolTip": "Voluptatum doloremque quisquam repellendus non nemo."
    },
    {
      "Id": 496,
      "Name": "Schoen, Walter and Grady",
      "ToolTip": "Voluptatum doloremque quisquam repellendus non nemo."
    }
  ],
  "Language": "blanditiis",
  "Sentiment": 346,
  "SentimentConfidence": 317,
  "SuggestedCategoryId": 676,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 11,
  "IconHint": "et",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 369,
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "quo"
  },
  "CustomFields": {
    "CustomFields1": "nulla",
    "CustomFields2": "explicabo"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 638,
  "Title": "corrupti",
  "CreatedAt": "2020-11-12T17:54:08.5699413+01:00",
  "LastChanged": "2008-07-04T17:54:08.5699413+02:00",
  "ReadByOwner": "2009-03-20T17:54:08.5699413+01:00",
  "ReadByCustomer": "2012-10-16T17:54:08.5699413+02:00",
  "FirstReadByOwner": "2001-01-24T17:54:08.5699413+01:00",
  "FirstReadByUser": "1999-05-29T17:54:08.5699413+02:00",
  "Activate": "2001-09-23T17:54:08.5699413+02:00",
  "ClosedAt": "2022-02-18T17:54:08.5699413+01:00",
  "RepliedAt": "2006-04-04T17:54:08.5699413+02:00",
  "AlertTimeout": "2008-06-17T17:54:08.5699413+02:00",
  "Deadline": "2008-09-01T17:54:08.5699413+02:00",
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
      "Position": "rerum",
      "PersonId": 619,
      "Mrmrs": "dolore",
      "Firstname": "Paul",
      "Lastname": "O'Hara",
      "MiddleName": "Kirlin, Tromp and Beahan",
      "Title": "ullam",
      "Description": "Down-sized executive task-force",
      "Email": "abner@christiansen.ca",
      "FullName": "Estefania Hyatt",
      "DirectPhone": "1-380-846-1597 x95475",
      "FormalName": "Lowe Inc and Sons",
      "CountryId": 362,
      "ContactId": 211,
      "ContactName": "Boyer Inc and Sons",
      "Retired": 986,
      "Rank": 320,
      "ActiveInterests": 59,
      "ContactDepartment": "",
      "ContactCountryId": 638,
      "ContactOrgNr": "427029",
      "FaxPhone": "1-849-825-9799",
      "MobilePhone": "1-634-689-4789 x3133",
      "ContactPhone": "(796)702-5064 x92476",
      "AssociateName": "Schneider, Leuschke and Klocko",
      "AssociateId": 25,
      "UsePersonAddress": false,
      "ContactFax": "quis",
      "Kanafname": "quia",
      "Kanalname": "inventore",
      "Post1": "cupiditate",
      "Post2": "non",
      "Post3": "doloribus",
      "EmailName": "mertie@grant.ca",
      "ContactFullName": "Prof. Ezequiel Hodkiewicz PhD",
      "ActiveErpLinks": 856,
      "TicketPriorityId": 172,
      "SupportLanguageId": 379,
      "SupportAssociateId": 175,
      "CategoryName": "VIP Customer",
      "PersonNumber": "920826",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 191
        }
      }
    }
  ],
  "AlertLevel": 4,
  "ConnectId": 593,
  "ReadStatus": "Green",
  "TimeToReply": 418,
  "RealTimeToReply": 289,
  "TimeToClose": 62,
  "RealTimeToClose": 430,
  "TimeSpentInternally": 202,
  "TimeSpentExternally": 65,
  "TimeSpentQueue": 797,
  "RealTimeSpentInternally": 148,
  "RealTimeSpentExternally": 670,
  "RealTimeSpentQueue": 929,
  "TimeSpent": 49,
  "HasAttachment": true,
  "NumReplies": 820,
  "NumMessages": 211,
  "FromAddress": "excepturi",
  "Messages": [
    {
      "TicketMessageId": 918,
      "CreatedAt": "2013-04-16T17:54:08.5699413+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "aut",
      "PersonId": 469,
      "PersonFullName": "Rosendo Toy",
      "ContactId": 261,
      "ContactName": "Swift, Littel and Mante",
      "ContactDepartment": "",
      "NumAttachments": 938,
      "EmailHeader": "lera@bahringer.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "iste",
      "Sentiment": 93,
      "SentimentConfidence": 164,
      "CreatedBy": 504,
      "ChangedAt": "2019-07-31T17:54:08.5699413+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 737
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 869,
      "Name": "Will LLC",
      "ToolTip": "Dolorem possimus est ut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 590
        }
      }
    },
    {
      "Id": 869,
      "Name": "Will LLC",
      "ToolTip": "Dolorem possimus est ut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 590
        }
      }
    }
  ],
  "Language": "eum",
  "Sentiment": 253,
  "SentimentConfidence": 642,
  "SuggestedCategoryId": 238,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 381,
  "IconHint": "sed",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 549,
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "cum"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
    "CustomFields2": "est"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 871
    }
  }
}
```