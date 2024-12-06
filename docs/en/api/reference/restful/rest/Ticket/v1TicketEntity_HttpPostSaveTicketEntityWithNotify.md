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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 632,
  "Title": "placeat",
  "CreatedAt": "2002-09-13T10:18:00.7387241+02:00",
  "LastChanged": "2016-07-09T10:18:00.7387241+02:00",
  "ReadByOwner": "2024-02-01T10:18:00.7387241+01:00",
  "ReadByCustomer": "1999-09-12T10:18:00.7387241+02:00",
  "FirstReadByOwner": "2018-12-05T10:18:00.7387241+01:00",
  "FirstReadByUser": "2011-02-25T10:18:00.7387241+01:00",
  "Activate": "2017-04-08T10:18:00.7387241+02:00",
  "ClosedAt": "2020-06-12T10:18:00.7387241+02:00",
  "RepliedAt": "2020-07-25T10:18:00.7387241+02:00",
  "AlertTimeout": "2014-02-24T10:18:00.7387241+01:00",
  "Deadline": "2001-01-13T10:18:00.7387241+01:00",
  "CreatedBy": null,
  "Author": "provident",
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
      "Position": "repudiandae",
      "PersonId": 392,
      "Mrmrs": "dolor",
      "Firstname": "Vicente",
      "Lastname": "Cruickshank",
      "MiddleName": "Schneider, McDermott and Jacobson",
      "Title": "voluptate",
      "Description": "Organic full-range neural-net",
      "Email": "andy_williamson@lueilwitz.uk",
      "FullName": "Mrs. Cynthia Botsford Jr.",
      "DirectPhone": "1-935-430-8570 x2124",
      "FormalName": "Schiller, Kub and Hauck",
      "CountryId": 196,
      "ContactId": 95,
      "ContactName": "McGlynn, Wolf and Hahn",
      "Retired": 304,
      "Rank": 39,
      "ActiveInterests": 729,
      "ContactDepartment": "",
      "ContactCountryId": 350,
      "ContactOrgNr": "1003504",
      "FaxPhone": "1-139-936-0216",
      "MobilePhone": "(838)666-9229",
      "ContactPhone": "1-158-010-8382",
      "AssociateName": "Hamill, Rippin and Hessel",
      "AssociateId": 378,
      "UsePersonAddress": false,
      "ContactFax": "quis",
      "Kanafname": "sit",
      "Kanalname": "non",
      "Post1": "voluptatem",
      "Post2": "odio",
      "Post3": "itaque",
      "EmailName": "loy.denesik@bednardavis.ca",
      "ContactFullName": "Geovanni Hertha Kirlin Sr.",
      "ActiveErpLinks": 162,
      "TicketPriorityId": 533,
      "SupportLanguageId": 881,
      "SupportAssociateId": 879,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 228,
  "ConnectId": 466,
  "ReadStatus": "Green",
  "TimeToReply": 998,
  "RealTimeToReply": 731,
  "TimeToClose": 157,
  "RealTimeToClose": 545,
  "TimeSpentInternally": 790,
  "TimeSpentExternally": 96,
  "TimeSpentQueue": 663,
  "RealTimeSpentInternally": 442,
  "RealTimeSpentExternally": 249,
  "RealTimeSpentQueue": 859,
  "TimeSpent": 784,
  "HasAttachment": false,
  "NumReplies": 51,
  "NumMessages": 585,
  "FromAddress": "atque",
  "Messages": [
    {
      "TicketMessageId": 860,
      "CreatedAt": "2007-06-26T10:18:00.7387241+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "fugit",
      "PersonId": 784,
      "PersonFullName": "Deron Mittie Nicolas IV",
      "ContactId": 150,
      "ContactName": "Carroll, Wolf and Luettgen",
      "ContactDepartment": "",
      "NumAttachments": 58,
      "EmailHeader": "araceli.carter@rueckerreynolds.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ut",
      "Sentiment": 336,
      "SentimentConfidence": 933,
      "CreatedBy": 888,
      "ChangedAt": "2011-04-30T10:18:00.7387241+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 433,
      "Name": "Ebert, Johnson and Johnson",
      "ToolTip": "Et laudantium."
    },
    {
      "Id": 433,
      "Name": "Ebert, Johnson and Johnson",
      "ToolTip": "Et laudantium."
    }
  ],
  "Language": "commodi",
  "Sentiment": 486,
  "SentimentConfidence": 695,
  "SuggestedCategoryId": 347,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 53,
  "IconHint": "ducimus",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 828,
  "ExtraFields": {
    "ExtraFields1": "placeat",
    "ExtraFields2": "molestiae"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "asperiores"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 696,
  "Title": "eaque",
  "CreatedAt": "2020-08-04T10:18:00.7387241+02:00",
  "LastChanged": "2005-01-19T10:18:00.7387241+01:00",
  "ReadByOwner": "2007-03-22T10:18:00.7387241+01:00",
  "ReadByCustomer": "2010-07-25T10:18:00.7387241+02:00",
  "FirstReadByOwner": "2020-12-21T10:18:00.7387241+01:00",
  "FirstReadByUser": "2017-03-18T10:18:00.7387241+01:00",
  "Activate": "2010-05-22T10:18:00.7387241+02:00",
  "ClosedAt": "2009-11-28T10:18:00.7387241+01:00",
  "RepliedAt": "2015-03-20T10:18:00.7387241+01:00",
  "AlertTimeout": "2011-03-23T10:18:00.7387241+01:00",
  "Deadline": "2005-12-11T10:18:00.7387241+01:00",
  "CreatedBy": null,
  "Author": "voluptatem",
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
      "Position": "ducimus",
      "PersonId": 923,
      "Mrmrs": "odio",
      "Firstname": "Torrance",
      "Lastname": "Brown",
      "MiddleName": "Konopelski, Johns and Crooks",
      "Title": "dolor",
      "Description": "Assimilated systematic success",
      "Email": "mustafa_krajcik@bruen.us",
      "FullName": "Jacinthe Volkman",
      "DirectPhone": "221-607-1644 x8205",
      "FormalName": "Okuneva LLC",
      "CountryId": 548,
      "ContactId": 128,
      "ContactName": "Tillman, Stoltenberg and Stracke",
      "Retired": 854,
      "Rank": 990,
      "ActiveInterests": 796,
      "ContactDepartment": "",
      "ContactCountryId": 879,
      "ContactOrgNr": "1566494",
      "FaxPhone": "129.459.4374 x44619",
      "MobilePhone": "1-806-992-4335",
      "ContactPhone": "(674)310-4350 x0105",
      "AssociateName": "Leuschke, Effertz and Sipes",
      "AssociateId": 107,
      "UsePersonAddress": false,
      "ContactFax": "error",
      "Kanafname": "facilis",
      "Kanalname": "vero",
      "Post1": "corrupti",
      "Post2": "iure",
      "Post3": "nulla",
      "EmailName": "lafayette.nolan@dickinson.co.uk",
      "ContactFullName": "Mattie Muller",
      "ActiveErpLinks": 747,
      "TicketPriorityId": 672,
      "SupportLanguageId": 731,
      "SupportAssociateId": 31,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 506
        }
      }
    }
  ],
  "AlertLevel": 370,
  "ConnectId": 777,
  "ReadStatus": "Green",
  "TimeToReply": 704,
  "RealTimeToReply": 148,
  "TimeToClose": 387,
  "RealTimeToClose": 854,
  "TimeSpentInternally": 277,
  "TimeSpentExternally": 397,
  "TimeSpentQueue": 885,
  "RealTimeSpentInternally": 259,
  "RealTimeSpentExternally": 91,
  "RealTimeSpentQueue": 753,
  "TimeSpent": 915,
  "HasAttachment": false,
  "NumReplies": 688,
  "NumMessages": 389,
  "FromAddress": "sunt",
  "Messages": [
    {
      "TicketMessageId": 497,
      "CreatedAt": "1997-07-26T10:18:00.7387241+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "atque",
      "PersonId": 100,
      "PersonFullName": "Ronny Carter",
      "ContactId": 229,
      "ContactName": "Grady, Schaefer and Bartell",
      "ContactDepartment": "",
      "NumAttachments": 87,
      "EmailHeader": "mandy.hintz@lockman.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "voluptatem",
      "Sentiment": 996,
      "SentimentConfidence": 741,
      "CreatedBy": 148,
      "ChangedAt": "2011-09-12T10:18:00.7387241+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 46
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 308,
      "Name": "Gislason LLC",
      "ToolTip": "Officiis occaecati qui non.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 457
        }
      }
    },
    {
      "Id": 308,
      "Name": "Gislason LLC",
      "ToolTip": "Officiis occaecati qui non.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 457
        }
      }
    }
  ],
  "Language": "quidem",
  "Sentiment": 141,
  "SentimentConfidence": 662,
  "SuggestedCategoryId": 562,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 246,
  "IconHint": "eveniet",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 761,
  "ExtraFields": {
    "ExtraFields1": "unde",
    "ExtraFields2": "aliquam"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "placeat"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 345
    }
  }
}
```