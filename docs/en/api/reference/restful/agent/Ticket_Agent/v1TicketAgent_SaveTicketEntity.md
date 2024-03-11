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
  "TicketId": 926,
  "Title": "officia",
  "CreatedAt": "2014-12-01T14:23:47.519255+01:00",
  "LastChanged": "2011-06-12T14:23:47.519255+02:00",
  "ReadByOwner": "2000-02-29T14:23:47.519255+01:00",
  "ReadByCustomer": "2014-07-22T14:23:47.519255+02:00",
  "FirstReadByOwner": "2000-07-15T14:23:47.519255+02:00",
  "FirstReadByUser": "2009-02-19T14:23:47.519255+01:00",
  "Activate": "2008-07-01T14:23:47.519255+02:00",
  "ClosedAt": "1998-08-21T14:23:47.519255+02:00",
  "RepliedAt": "1997-02-24T14:23:47.519255+01:00",
  "AlertTimeout": "2021-06-28T14:23:47.519255+02:00",
  "Deadline": "2020-08-05T14:23:47.519255+02:00",
  "CreatedBy": null,
  "Author": "placeat",
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
      "Position": "perferendis",
      "PersonId": 974,
      "Mrmrs": "inventore",
      "Firstname": "Mckayla",
      "Lastname": "Braun",
      "MiddleName": "Graham Inc and Sons",
      "Title": "magni",
      "Description": "Self-enabling multi-state portal",
      "Email": "avis@funkkuhlman.uk",
      "FullName": "Silas Gislason",
      "DirectPhone": "627-494-7930 x689",
      "FormalName": "Walker-Quigley",
      "CountryId": 999,
      "ContactId": 4,
      "ContactName": "Donnelly, Ratke and Collier",
      "Retired": 143,
      "Rank": 141,
      "ActiveInterests": 105,
      "ContactDepartment": "repurpose scalable paradigms",
      "ContactCountryId": 540,
      "ContactOrgNr": "1744864",
      "FaxPhone": "(804)887-7076 x08385",
      "MobilePhone": "552.127.2606 x250",
      "ContactPhone": "1-016-350-0299 x227",
      "AssociateName": "Hessel Inc and Sons",
      "AssociateId": 72,
      "UsePersonAddress": false,
      "ContactFax": "velit",
      "Kanafname": "doloremque",
      "Kanalname": "aut",
      "Post1": "voluptas",
      "Post2": "similique",
      "Post3": "voluptate",
      "EmailName": "adelbert.vandervort@ullrichklocko.us",
      "ContactFullName": "Mrs. Marjorie Lilliana Leannon MD",
      "ActiveErpLinks": 561,
      "TicketPriorityId": 328,
      "SupportLanguageId": 299,
      "SupportAssociateId": 603,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 719,
  "ConnectId": 553,
  "ReadStatus": "Green",
  "TimeToReply": 974,
  "RealTimeToReply": 994,
  "TimeToClose": 343,
  "RealTimeToClose": 420,
  "TimeSpentInternally": 805,
  "TimeSpentExternally": 871,
  "TimeSpentQueue": 323,
  "RealTimeSpentInternally": 13,
  "RealTimeSpentExternally": 639,
  "RealTimeSpentQueue": 82,
  "TimeSpent": 593,
  "HasAttachment": true,
  "NumReplies": 941,
  "NumMessages": 592,
  "FromAddress": "sit",
  "Messages": [
    {
      "TicketMessageId": 504,
      "CreatedAt": "1998-04-20T14:23:47.519255+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "voluptatem",
      "PersonId": 312,
      "PersonFullName": "Jerel Koss",
      "ContactId": 121,
      "ContactName": "Feest-Hodkiewicz",
      "ContactDepartment": "",
      "NumAttachments": 613,
      "EmailHeader": "fleta.jenkins@wilderman.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "nostrum",
      "Sentiment": 369,
      "SentimentConfidence": 874,
      "CreatedBy": 656,
      "ChangedAt": "2019-08-30T14:23:47.519255+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 568,
      "Name": "Goldner Group",
      "ToolTip": "Aut quos consequatur."
    },
    {
      "Id": 568,
      "Name": "Goldner Group",
      "ToolTip": "Aut quos consequatur."
    }
  ],
  "Language": "explicabo",
  "Sentiment": 825,
  "SentimentConfidence": 506,
  "SuggestedCategoryId": 870,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 274,
  "IconHint": "maiores",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 661,
  "ExtraFields": {
    "ExtraFields1": "libero",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "harum",
    "CustomFields2": "explicabo"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 584,
  "Title": "ut",
  "CreatedAt": "2023-08-14T14:23:47.519255+02:00",
  "LastChanged": "1999-01-11T14:23:47.519255+01:00",
  "ReadByOwner": "2019-12-11T14:23:47.519255+01:00",
  "ReadByCustomer": "1998-04-12T14:23:47.519255+02:00",
  "FirstReadByOwner": "2010-12-13T14:23:47.519255+01:00",
  "FirstReadByUser": "2012-01-27T14:23:47.519255+01:00",
  "Activate": "1996-10-28T14:23:47.519255+01:00",
  "ClosedAt": "2017-10-25T14:23:47.519255+02:00",
  "RepliedAt": "2005-10-08T14:23:47.519255+02:00",
  "AlertTimeout": "2022-05-22T14:23:47.519255+02:00",
  "Deadline": "2017-09-29T14:23:47.519255+02:00",
  "CreatedBy": null,
  "Author": "aut",
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
      "PersonId": 519,
      "Mrmrs": "molestiae",
      "Firstname": "Zachery",
      "Lastname": "Heller",
      "MiddleName": "Predovic-Balistreri",
      "Title": "qui",
      "Description": "Reactive background orchestration",
      "Email": "ellen@schultz.name",
      "FullName": "Amiya Anderson I",
      "DirectPhone": "975-720-8481 x3086",
      "FormalName": "Deckow-Zboncak",
      "CountryId": 363,
      "ContactId": 159,
      "ContactName": "Mohr, Funk and Eichmann",
      "Retired": 815,
      "Rank": 380,
      "ActiveInterests": 204,
      "ContactDepartment": "",
      "ContactCountryId": 170,
      "ContactOrgNr": "997811",
      "FaxPhone": "464.980.2589 x615",
      "MobilePhone": "332.340.1313 x7904",
      "ContactPhone": "(612)700-9017 x3016",
      "AssociateName": "Buckridge-Johns",
      "AssociateId": 25,
      "UsePersonAddress": false,
      "ContactFax": "quibusdam",
      "Kanafname": "dignissimos",
      "Kanalname": "eaque",
      "Post1": "quia",
      "Post2": "quos",
      "Post3": "necessitatibus",
      "EmailName": "lamont@stracke.ca",
      "ContactFullName": "Eloy Bauch",
      "ActiveErpLinks": 125,
      "TicketPriorityId": 209,
      "SupportLanguageId": 783,
      "SupportAssociateId": 887,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 273
        }
      }
    }
  ],
  "AlertLevel": 376,
  "ConnectId": 27,
  "ReadStatus": "Green",
  "TimeToReply": 696,
  "RealTimeToReply": 312,
  "TimeToClose": 217,
  "RealTimeToClose": 433,
  "TimeSpentInternally": 607,
  "TimeSpentExternally": 332,
  "TimeSpentQueue": 350,
  "RealTimeSpentInternally": 339,
  "RealTimeSpentExternally": 107,
  "RealTimeSpentQueue": 654,
  "TimeSpent": 416,
  "HasAttachment": false,
  "NumReplies": 640,
  "NumMessages": 973,
  "FromAddress": "ut",
  "Messages": [
    {
      "TicketMessageId": 325,
      "CreatedAt": "2012-05-17T14:23:47.5348781+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "impedit",
      "PersonId": 509,
      "PersonFullName": "Maverick Deckow",
      "ContactId": 23,
      "ContactName": "Bernier, Wyman and McKenzie",
      "ContactDepartment": "visualize cross-platform communities",
      "NumAttachments": 74,
      "EmailHeader": "bennie@gottlieb.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "aperiam",
      "Sentiment": 51,
      "SentimentConfidence": 387,
      "CreatedBy": 115,
      "ChangedAt": "2022-10-08T14:23:47.5348781+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 87
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 935,
      "Name": "Stokes-Grant",
      "ToolTip": "Consequatur nostrum ipsam fugiat molestiae vero consectetur.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 449
        }
      }
    },
    {
      "Id": 935,
      "Name": "Stokes-Grant",
      "ToolTip": "Consequatur nostrum ipsam fugiat molestiae vero consectetur.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 449
        }
      }
    }
  ],
  "Language": "nisi",
  "Sentiment": 107,
  "SentimentConfidence": 97,
  "SuggestedCategoryId": 214,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 304,
  "IconHint": "excepturi",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 352,
  "ExtraFields": {
    "ExtraFields1": "eveniet",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "soluta",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 312
    }
  }
}
```