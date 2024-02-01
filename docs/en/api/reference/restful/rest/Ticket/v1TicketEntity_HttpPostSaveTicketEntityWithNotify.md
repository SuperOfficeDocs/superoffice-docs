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
POST /api/v1/Ticket?notify=True
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
POST /api/v1/Ticket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 230,
  "Title": "quisquam",
  "CreatedAt": "2022-12-23T23:04:04.8340088+01:00",
  "LastChanged": "2002-02-05T23:04:04.8340088+01:00",
  "ReadByOwner": "2000-02-26T23:04:04.8340088+01:00",
  "ReadByCustomer": "2008-02-23T23:04:04.8340088+01:00",
  "FirstReadByOwner": "2000-09-20T23:04:04.8340088+02:00",
  "FirstReadByUser": "2023-09-15T23:04:04.8340088+02:00",
  "Activate": "1996-10-18T23:04:04.8340088+02:00",
  "ClosedAt": "2016-06-22T23:04:04.8340088+02:00",
  "RepliedAt": "2012-12-18T23:04:04.8340088+01:00",
  "AlertTimeout": "2023-01-10T23:04:04.8340088+01:00",
  "Deadline": "2007-06-25T23:04:04.8340088+02:00",
  "CreatedBy": null,
  "Author": "molestias",
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
      "PersonId": 836,
      "Mrmrs": "quas",
      "Firstname": "Thad",
      "Lastname": "McClure",
      "MiddleName": "Mueller, Goldner and Jenkins",
      "Title": "vel",
      "Description": "Optional transitional matrices",
      "Email": "crystal_schultz@deckow.biz",
      "FullName": "Gerson Ratke",
      "DirectPhone": "478-087-5756 x715",
      "FormalName": "Jakubowski-Nader",
      "CountryId": 12,
      "ContactId": 980,
      "ContactName": "Rau, Mraz and Schulist",
      "Retired": 765,
      "Rank": 652,
      "ActiveInterests": 630,
      "ContactDepartment": "",
      "ContactCountryId": 173,
      "ContactOrgNr": "825241",
      "FaxPhone": "1-918-555-3229 x464",
      "MobilePhone": "(022)682-2385 x1500",
      "ContactPhone": "1-839-110-8541 x05668",
      "AssociateName": "Windler-Carter",
      "AssociateId": 254,
      "UsePersonAddress": false,
      "ContactFax": "nemo",
      "Kanafname": "ea",
      "Kanalname": "error",
      "Post1": "sed",
      "Post2": "eveniet",
      "Post3": "vitae",
      "EmailName": "brent@runolfsson.us",
      "ContactFullName": "Rosamond Hyatt",
      "ActiveErpLinks": 922,
      "TicketPriorityId": 922,
      "SupportLanguageId": 402,
      "SupportAssociateId": 903,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 987,
  "ConnectId": 578,
  "ReadStatus": "Green",
  "TimeToReply": 710,
  "RealTimeToReply": 601,
  "TimeToClose": 783,
  "RealTimeToClose": 384,
  "TimeSpentInternally": 745,
  "TimeSpentExternally": 663,
  "TimeSpentQueue": 522,
  "RealTimeSpentInternally": 601,
  "RealTimeSpentExternally": 946,
  "RealTimeSpentQueue": 72,
  "TimeSpent": 572,
  "HasAttachment": false,
  "NumReplies": 202,
  "NumMessages": 15,
  "FromAddress": "et",
  "Messages": [
    {
      "TicketMessageId": 905,
      "CreatedAt": "2000-01-30T23:04:04.8395084+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "at",
      "PersonId": 244,
      "PersonFullName": "Julian Metz",
      "ContactId": 982,
      "ContactName": "Jast, Wilderman and Nienow",
      "ContactDepartment": "",
      "NumAttachments": 771,
      "EmailHeader": "skylar_mraz@daniel.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "similique",
      "Sentiment": 290,
      "SentimentConfidence": 754,
      "CreatedBy": 993,
      "ChangedAt": "2008-02-11T23:04:04.8400097+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 285,
      "Name": "Monahan LLC",
      "ToolTip": "Et iure quibusdam provident dolores tenetur."
    },
    {
      "Id": 285,
      "Name": "Monahan LLC",
      "ToolTip": "Et iure quibusdam provident dolores tenetur."
    }
  ],
  "Language": "blanditiis",
  "Sentiment": 44,
  "SentimentConfidence": 56,
  "SuggestedCategoryId": 533,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 279,
  "IconHint": "nam",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 594,
  "ExtraFields": {
    "ExtraFields1": "ex",
    "ExtraFields2": "in"
  },
  "CustomFields": {
    "CustomFields1": "veritatis",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 118,
  "Title": "beatae",
  "CreatedAt": "2018-04-09T23:04:04.8490081+02:00",
  "LastChanged": "2016-01-29T23:04:04.8490081+01:00",
  "ReadByOwner": "2005-09-20T23:04:04.8490081+02:00",
  "ReadByCustomer": "2012-12-24T23:04:04.8490081+01:00",
  "FirstReadByOwner": "1997-03-05T23:04:04.8490081+01:00",
  "FirstReadByUser": "2015-02-19T23:04:04.8490081+01:00",
  "Activate": "2016-07-22T23:04:04.8490081+02:00",
  "ClosedAt": "2020-10-02T23:04:04.8490081+02:00",
  "RepliedAt": "2000-08-10T23:04:04.8490081+02:00",
  "AlertTimeout": "2017-01-31T23:04:04.8490081+01:00",
  "Deadline": "2018-08-29T23:04:04.8490081+02:00",
  "CreatedBy": null,
  "Author": "est",
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
      "Position": "non",
      "PersonId": 124,
      "Mrmrs": "non",
      "Firstname": "Russel",
      "Lastname": "O'Reilly",
      "MiddleName": "Sporer, Ledner and Zboncak",
      "Title": "enim",
      "Description": "Progressive didactic focus group",
      "Email": "adelbert@gottlieb.name",
      "FullName": "Ms. Sabrina John Waters I",
      "DirectPhone": "(901)986-4772 x3859",
      "FormalName": "Armstrong, Mills and Schulist",
      "CountryId": 532,
      "ContactId": 931,
      "ContactName": "Daugherty, Boyer and Dietrich",
      "Retired": 533,
      "Rank": 95,
      "ActiveInterests": 457,
      "ContactDepartment": "",
      "ContactCountryId": 38,
      "ContactOrgNr": "271010",
      "FaxPhone": "(936)844-3720 x9768",
      "MobilePhone": "313.038.3583 x565",
      "ContactPhone": "1-366-038-9318",
      "AssociateName": "Bogan, O'Kon and Kunze",
      "AssociateId": 679,
      "UsePersonAddress": true,
      "ContactFax": "rerum",
      "Kanafname": "quos",
      "Kanalname": "dolores",
      "Post1": "nam",
      "Post2": "similique",
      "Post3": "at",
      "EmailName": "mathias@zemlak.us",
      "ContactFullName": "Malachi Kozey",
      "ActiveErpLinks": 393,
      "TicketPriorityId": 94,
      "SupportLanguageId": 773,
      "SupportAssociateId": 565,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 650
        }
      }
    }
  ],
  "AlertLevel": 418,
  "ConnectId": 772,
  "ReadStatus": "Green",
  "TimeToReply": 416,
  "RealTimeToReply": 597,
  "TimeToClose": 843,
  "RealTimeToClose": 394,
  "TimeSpentInternally": 120,
  "TimeSpentExternally": 578,
  "TimeSpentQueue": 642,
  "RealTimeSpentInternally": 463,
  "RealTimeSpentExternally": 132,
  "RealTimeSpentQueue": 888,
  "TimeSpent": 489,
  "HasAttachment": true,
  "NumReplies": 874,
  "NumMessages": 819,
  "FromAddress": "aut",
  "Messages": [
    {
      "TicketMessageId": 889,
      "CreatedAt": "2001-01-10T23:04:04.8535089+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "minima",
      "PersonId": 894,
      "PersonFullName": "Brandon McGlynn",
      "ContactId": 252,
      "ContactName": "Kilback-Murray",
      "ContactDepartment": "",
      "NumAttachments": 635,
      "EmailHeader": "stacey@graham.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "cum",
      "Sentiment": 708,
      "SentimentConfidence": 269,
      "CreatedBy": 154,
      "ChangedAt": "2013-02-07T23:04:04.8540083+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 295
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 913,
      "Name": "Ziemann, Schultz and O'Kon",
      "ToolTip": "Occaecati dolor quo culpa doloribus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 323
        }
      }
    },
    {
      "Id": 913,
      "Name": "Ziemann, Schultz and O'Kon",
      "ToolTip": "Occaecati dolor quo culpa doloribus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 323
        }
      }
    }
  ],
  "Language": "illo",
  "Sentiment": 24,
  "SentimentConfidence": 279,
  "SuggestedCategoryId": 243,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 768,
  "IconHint": "voluptate",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 796,
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "similique"
  },
  "CustomFields": {
    "CustomFields1": "quidem",
    "CustomFields2": "officia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 81
    }
  }
}
```