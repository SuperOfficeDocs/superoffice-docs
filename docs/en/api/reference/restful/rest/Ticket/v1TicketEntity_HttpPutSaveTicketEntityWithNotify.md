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
PUT /api/v1/Ticket/{id}?notify=True
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
  "TicketId": 859,
  "Title": "aspernatur",
  "CreatedAt": "2002-09-28T12:01:33.2457098+02:00",
  "LastChanged": "2006-04-06T12:01:33.2457098+02:00",
  "ReadByOwner": "2024-04-27T12:01:33.2457098+02:00",
  "ReadByCustomer": "2003-07-05T12:01:33.2457098+02:00",
  "FirstReadByOwner": "2005-05-04T12:01:33.2457098+02:00",
  "FirstReadByUser": "2007-05-10T12:01:33.2457098+02:00",
  "Activate": "2007-03-26T12:01:33.2457098+02:00",
  "ClosedAt": "2003-04-29T12:01:33.2457098+02:00",
  "RepliedAt": "2005-07-25T12:01:33.2457098+02:00",
  "AlertTimeout": "2004-07-16T12:01:33.2457098+02:00",
  "Deadline": "2023-12-29T12:01:33.2457098+01:00",
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
      "Position": "voluptates",
      "PersonId": 784,
      "Mrmrs": "quos",
      "Firstname": "Jeromy",
      "Lastname": "Brown",
      "MiddleName": "Beer-O'Reilly",
      "Title": "harum",
      "Description": "Robust high-level toolset",
      "Email": "alfred@wisozk.info",
      "FullName": "Ashly Herzog",
      "DirectPhone": "1-972-221-4028 x71914",
      "FormalName": "Bins, Bednar and Olson",
      "CountryId": 237,
      "ContactId": 822,
      "ContactName": "McDermott-Shields",
      "Retired": 670,
      "Rank": 768,
      "ActiveInterests": 876,
      "ContactDepartment": "",
      "ContactCountryId": 190,
      "ContactOrgNr": "600580",
      "FaxPhone": "971-087-2484",
      "MobilePhone": "(026)332-0019 x15949",
      "ContactPhone": "543.729.0554 x5158",
      "AssociateName": "Waters LLC",
      "AssociateId": 636,
      "UsePersonAddress": true,
      "ContactFax": "est",
      "Kanafname": "in",
      "Kanalname": "sed",
      "Post1": "est",
      "Post2": "ad",
      "Post3": "delectus",
      "EmailName": "tyreek.rempel@romaguerawilkinson.uk",
      "ContactFullName": "Foster Macejkovic",
      "ActiveErpLinks": 37,
      "TicketPriorityId": 34,
      "SupportLanguageId": 167,
      "SupportAssociateId": 82,
      "CategoryName": "VIP Customer",
      "PersonNumber": "577965"
    }
  ],
  "AlertLevel": 154,
  "ConnectId": 468,
  "ReadStatus": "Green",
  "TimeToReply": 576,
  "RealTimeToReply": 153,
  "TimeToClose": 684,
  "RealTimeToClose": 619,
  "TimeSpentInternally": 285,
  "TimeSpentExternally": 789,
  "TimeSpentQueue": 127,
  "RealTimeSpentInternally": 166,
  "RealTimeSpentExternally": 862,
  "RealTimeSpentQueue": 931,
  "TimeSpent": 103,
  "HasAttachment": false,
  "NumReplies": 486,
  "NumMessages": 374,
  "FromAddress": "iste",
  "Messages": [
    {
      "TicketMessageId": 531,
      "CreatedAt": "2006-10-17T12:01:33.2457098+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "quod",
      "PersonId": 666,
      "PersonFullName": "Lonzo Bashirian",
      "ContactId": 747,
      "ContactName": "Graham, Waters and Sauer",
      "ContactDepartment": "",
      "NumAttachments": 225,
      "EmailHeader": "cristal@waters.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "sequi",
      "Sentiment": 493,
      "SentimentConfidence": 235,
      "CreatedBy": 383,
      "ChangedAt": "2003-03-13T12:01:33.2457098+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 616,
      "Name": "Bayer-Denesik",
      "ToolTip": "Nemo temporibus."
    },
    {
      "Id": 616,
      "Name": "Bayer-Denesik",
      "ToolTip": "Nemo temporibus."
    }
  ],
  "Language": "ab",
  "Sentiment": 83,
  "SentimentConfidence": 617,
  "SuggestedCategoryId": 437,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 537,
  "IconHint": "quia",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 477,
  "ExtraFields": {
    "ExtraFields1": "voluptates",
    "ExtraFields2": "ipsum"
  },
  "CustomFields": {
    "CustomFields1": "cum",
    "CustomFields2": "ut"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 294,
  "Title": "alias",
  "CreatedAt": "2009-03-05T12:01:33.2457098+01:00",
  "LastChanged": "2019-11-05T12:01:33.2457098+01:00",
  "ReadByOwner": "2020-08-29T12:01:33.2457098+02:00",
  "ReadByCustomer": "1999-10-27T12:01:33.2457098+02:00",
  "FirstReadByOwner": "2003-03-18T12:01:33.2457098+01:00",
  "FirstReadByUser": "2009-07-28T12:01:33.2457098+02:00",
  "Activate": "2000-10-26T12:01:33.2457098+02:00",
  "ClosedAt": "2018-12-08T12:01:33.2457098+01:00",
  "RepliedAt": "2014-11-26T12:01:33.2457098+01:00",
  "AlertTimeout": "2014-01-27T12:01:33.2457098+01:00",
  "Deadline": "2000-09-01T12:01:33.2457098+02:00",
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
      "Position": "dolor",
      "PersonId": 298,
      "Mrmrs": "natus",
      "Firstname": "Leanne",
      "Lastname": "Oberbrunner",
      "MiddleName": "Kub, Connelly and Rodriguez",
      "Title": "suscipit",
      "Description": "Extended global orchestration",
      "Email": "monserrat@lehner.co.uk",
      "FullName": "Prof. Kitty McLaughlin",
      "DirectPhone": "572-108-0865",
      "FormalName": "Schoen-Powlowski",
      "CountryId": 105,
      "ContactId": 21,
      "ContactName": "Vandervort, Goodwin and Reilly",
      "Retired": 660,
      "Rank": 689,
      "ActiveInterests": 833,
      "ContactDepartment": "",
      "ContactCountryId": 422,
      "ContactOrgNr": "1245879",
      "FaxPhone": "280-795-1053 x46664",
      "MobilePhone": "847.972.3678",
      "ContactPhone": "277-377-8287 x368",
      "AssociateName": "Spinka-Casper",
      "AssociateId": 423,
      "UsePersonAddress": false,
      "ContactFax": "consequatur",
      "Kanafname": "ullam",
      "Kanalname": "et",
      "Post1": "ratione",
      "Post2": "labore",
      "Post3": "vel",
      "EmailName": "keaton@schaden.ca",
      "ContactFullName": "Tyrel West",
      "ActiveErpLinks": 40,
      "TicketPriorityId": 132,
      "SupportLanguageId": 51,
      "SupportAssociateId": 107,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1140655",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 169
        }
      }
    }
  ],
  "AlertLevel": 344,
  "ConnectId": 263,
  "ReadStatus": "Green",
  "TimeToReply": 611,
  "RealTimeToReply": 718,
  "TimeToClose": 689,
  "RealTimeToClose": 411,
  "TimeSpentInternally": 815,
  "TimeSpentExternally": 863,
  "TimeSpentQueue": 692,
  "RealTimeSpentInternally": 541,
  "RealTimeSpentExternally": 112,
  "RealTimeSpentQueue": 85,
  "TimeSpent": 873,
  "HasAttachment": false,
  "NumReplies": 394,
  "NumMessages": 236,
  "FromAddress": "quae",
  "Messages": [
    {
      "TicketMessageId": 878,
      "CreatedAt": "2022-08-26T12:01:33.2457098+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "eius",
      "PersonId": 234,
      "PersonFullName": "Miss Elinore Weissnat",
      "ContactId": 46,
      "ContactName": "Nader Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 161,
      "EmailHeader": "timmothy_carter@wisoky.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "aliquam",
      "Sentiment": 361,
      "SentimentConfidence": 506,
      "CreatedBy": 664,
      "ChangedAt": "2001-01-05T12:01:33.2457098+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 951
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 755,
      "Name": "O'Keefe, Will and Cormier",
      "ToolTip": "Dolorem error autem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 906
        }
      }
    },
    {
      "Id": 755,
      "Name": "O'Keefe, Will and Cormier",
      "ToolTip": "Dolorem error autem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 906
        }
      }
    }
  ],
  "Language": "eos",
  "Sentiment": 873,
  "SentimentConfidence": 272,
  "SuggestedCategoryId": 849,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 741,
  "IconHint": "aliquam",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 604,
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "vel"
  },
  "CustomFields": {
    "CustomFields1": "eum",
    "CustomFields2": "quia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 620
    }
  }
}
```