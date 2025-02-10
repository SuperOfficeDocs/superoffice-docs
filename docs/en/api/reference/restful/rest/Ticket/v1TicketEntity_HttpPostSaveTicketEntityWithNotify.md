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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketId": 580,
  "Title": "non",
  "CreatedAt": "2009-06-09T12:01:33.2300837+02:00",
  "LastChanged": "2009-10-26T12:01:33.2300837+01:00",
  "ReadByOwner": "2008-05-03T12:01:33.2300837+02:00",
  "ReadByCustomer": "2000-02-18T12:01:33.2300837+01:00",
  "FirstReadByOwner": "2017-07-20T12:01:33.2300837+02:00",
  "FirstReadByUser": "2019-05-09T12:01:33.2300837+02:00",
  "Activate": "2016-06-10T12:01:33.2300837+02:00",
  "ClosedAt": "2021-07-01T12:01:33.2300837+02:00",
  "RepliedAt": "2011-11-23T12:01:33.2300837+01:00",
  "AlertTimeout": "2016-09-21T12:01:33.2300837+02:00",
  "Deadline": "2006-02-20T12:01:33.2300837+01:00",
  "CreatedBy": null,
  "Author": "maiores",
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
      "PersonId": 883,
      "Mrmrs": "eveniet",
      "Firstname": "Brad",
      "Lastname": "Wilderman",
      "MiddleName": "Collins-Terry",
      "Title": "voluptatibus",
      "Description": "Business-focused 3rd generation website",
      "Email": "sarina.bartell@conroy.name",
      "FullName": "Mr. Dario Oberbrunner",
      "DirectPhone": "(206)760-5986 x60583",
      "FormalName": "Roob-Hirthe",
      "CountryId": 525,
      "ContactId": 18,
      "ContactName": "Gusikowski, Bogan and Jast",
      "Retired": 93,
      "Rank": 767,
      "ActiveInterests": 420,
      "ContactDepartment": "",
      "ContactCountryId": 718,
      "ContactOrgNr": "1096143",
      "FaxPhone": "1-704-636-8108 x39774",
      "MobilePhone": "182.137.2945 x606",
      "ContactPhone": "(394)058-8675 x224",
      "AssociateName": "Kiehn-O'Conner",
      "AssociateId": 302,
      "UsePersonAddress": false,
      "ContactFax": "culpa",
      "Kanafname": "repellat",
      "Kanalname": "dolorem",
      "Post1": "quia",
      "Post2": "voluptates",
      "Post3": "rem",
      "EmailName": "pietro@rohandooley.co.uk",
      "ContactFullName": "Henriette Lehner",
      "ActiveErpLinks": 787,
      "TicketPriorityId": 604,
      "SupportLanguageId": 421,
      "SupportAssociateId": 262,
      "CategoryName": "VIP Customer",
      "PersonNumber": "367603"
    }
  ],
  "AlertLevel": 923,
  "ConnectId": 543,
  "ReadStatus": "Green",
  "TimeToReply": 377,
  "RealTimeToReply": 995,
  "TimeToClose": 316,
  "RealTimeToClose": 159,
  "TimeSpentInternally": 621,
  "TimeSpentExternally": 901,
  "TimeSpentQueue": 777,
  "RealTimeSpentInternally": 151,
  "RealTimeSpentExternally": 722,
  "RealTimeSpentQueue": 388,
  "TimeSpent": 90,
  "HasAttachment": false,
  "NumReplies": 993,
  "NumMessages": 412,
  "FromAddress": "facilis",
  "Messages": [
    {
      "TicketMessageId": 828,
      "CreatedAt": "2017-05-12T12:01:33.2300837+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "consequatur",
      "PersonId": 213,
      "PersonFullName": "Ms. Ubaldo Dallas Ledner DVM",
      "ContactId": 309,
      "ContactName": "Littel, Nolan and Mayer",
      "ContactDepartment": "",
      "NumAttachments": 461,
      "EmailHeader": "steve_koepp@walter.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "voluptatem",
      "Sentiment": 793,
      "SentimentConfidence": 681,
      "CreatedBy": 78,
      "ChangedAt": "2020-09-19T12:01:33.2300837+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 755,
      "Name": "Conroy, Windler and Krajcik",
      "ToolTip": "Sunt autem rerum placeat id officia dignissimos."
    },
    {
      "Id": 755,
      "Name": "Conroy, Windler and Krajcik",
      "ToolTip": "Sunt autem rerum placeat id officia dignissimos."
    }
  ],
  "Language": "mollitia",
  "Sentiment": 228,
  "SentimentConfidence": 877,
  "SuggestedCategoryId": 70,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 696,
  "IconHint": "fugit",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 515,
  "ExtraFields": {
    "ExtraFields1": "hic",
    "ExtraFields2": "dolorum"
  },
  "CustomFields": {
    "CustomFields1": "molestiae",
    "CustomFields2": "in"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 635,
  "Title": "dignissimos",
  "CreatedAt": "2017-05-23T12:01:33.2300837+02:00",
  "LastChanged": "2021-12-31T12:01:33.2300837+01:00",
  "ReadByOwner": "2008-05-07T12:01:33.2300837+02:00",
  "ReadByCustomer": "2001-06-26T12:01:33.2300837+02:00",
  "FirstReadByOwner": "2003-03-10T12:01:33.2300837+01:00",
  "FirstReadByUser": "2010-04-20T12:01:33.2300837+02:00",
  "Activate": "2007-07-10T12:01:33.2300837+02:00",
  "ClosedAt": "2011-09-25T12:01:33.2300837+02:00",
  "RepliedAt": "2006-01-03T12:01:33.2300837+01:00",
  "AlertTimeout": "2021-09-04T12:01:33.2300837+02:00",
  "Deadline": "2009-12-26T12:01:33.2300837+01:00",
  "CreatedBy": null,
  "Author": "et",
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
      "Position": "ipsam",
      "PersonId": 176,
      "Mrmrs": "voluptatem",
      "Firstname": "Rebekah",
      "Lastname": "Kiehn",
      "MiddleName": "Wolff-Hilpert",
      "Title": "eum",
      "Description": "Persevering 3rd generation Graphic Interface",
      "Email": "ruben@turnerblock.biz",
      "FullName": "Prof. Rosemarie Gleason",
      "DirectPhone": "772.629.8555 x35706",
      "FormalName": "Rice, Reichert and Mayert",
      "CountryId": 808,
      "ContactId": 826,
      "ContactName": "Wunsch Inc and Sons",
      "Retired": 937,
      "Rank": 414,
      "ActiveInterests": 860,
      "ContactDepartment": "monetize next-generation schemas",
      "ContactCountryId": 169,
      "ContactOrgNr": "1468407",
      "FaxPhone": "539.782.7718",
      "MobilePhone": "(867)021-1149",
      "ContactPhone": "743-220-1462 x3622",
      "AssociateName": "Blanda-Dibbert",
      "AssociateId": 349,
      "UsePersonAddress": false,
      "ContactFax": "assumenda",
      "Kanafname": "enim",
      "Kanalname": "rem",
      "Post1": "commodi",
      "Post2": "iusto",
      "Post3": "itaque",
      "EmailName": "aric@gorczanycremin.info",
      "ContactFullName": "Vaughn Leuschke",
      "ActiveErpLinks": 872,
      "TicketPriorityId": 102,
      "SupportLanguageId": 780,
      "SupportAssociateId": 905,
      "CategoryName": "VIP Customer",
      "PersonNumber": "567737",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 572
        }
      }
    }
  ],
  "AlertLevel": 73,
  "ConnectId": 393,
  "ReadStatus": "Green",
  "TimeToReply": 158,
  "RealTimeToReply": 943,
  "TimeToClose": 3,
  "RealTimeToClose": 828,
  "TimeSpentInternally": 934,
  "TimeSpentExternally": 406,
  "TimeSpentQueue": 903,
  "RealTimeSpentInternally": 39,
  "RealTimeSpentExternally": 753,
  "RealTimeSpentQueue": 542,
  "TimeSpent": 202,
  "HasAttachment": true,
  "NumReplies": 832,
  "NumMessages": 388,
  "FromAddress": "rem",
  "Messages": [
    {
      "TicketMessageId": 180,
      "CreatedAt": "2006-03-27T12:01:33.2300837+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "veniam",
      "PersonId": 849,
      "PersonFullName": "Brooks Dach",
      "ContactId": 286,
      "ContactName": "Graham-Bednar",
      "ContactDepartment": "",
      "NumAttachments": 956,
      "EmailHeader": "angie@brekkenader.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "voluptate",
      "Sentiment": 203,
      "SentimentConfidence": 977,
      "CreatedBy": 592,
      "ChangedAt": "2012-04-14T12:01:33.2300837+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 624
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 540,
      "Name": "Gulgowski, Olson and Dooley",
      "ToolTip": "Ut nostrum ad in tempora nulla.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 597
        }
      }
    },
    {
      "Id": 540,
      "Name": "Gulgowski, Olson and Dooley",
      "ToolTip": "Ut nostrum ad in tempora nulla.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 597
        }
      }
    }
  ],
  "Language": "deleniti",
  "Sentiment": 550,
  "SentimentConfidence": 370,
  "SuggestedCategoryId": 213,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 456,
  "IconHint": "quia",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 847,
  "ExtraFields": {
    "ExtraFields1": "quis",
    "ExtraFields2": "eos"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "consequatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 777
    }
  }
}
```