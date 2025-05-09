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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketId": 818,
  "Title": "praesentium",
  "CreatedAt": "2001-06-18T16:32:48.1338203+02:00",
  "LastChanged": "2009-09-30T16:32:48.1338203+02:00",
  "ReadByOwner": "2023-05-05T16:32:48.1338203+02:00",
  "ReadByCustomer": "2007-03-11T16:32:48.1338203+01:00",
  "FirstReadByOwner": "2006-12-12T16:32:48.1338203+01:00",
  "FirstReadByUser": "2010-09-14T16:32:48.1338203+02:00",
  "Activate": "2013-09-10T16:32:48.1338203+02:00",
  "ClosedAt": "2001-09-27T16:32:48.1338203+02:00",
  "RepliedAt": "2006-01-23T16:32:48.1338203+01:00",
  "AlertTimeout": "2011-03-22T16:32:48.1338203+01:00",
  "Deadline": "2023-08-28T16:32:48.1338203+02:00",
  "CreatedBy": null,
  "Author": "dolorum",
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
      "Position": "ab",
      "PersonId": 391,
      "Mrmrs": "illum",
      "Firstname": "Triston",
      "Lastname": "Stanton",
      "MiddleName": "Ebert-Cremin",
      "Title": "minus",
      "Description": "Mandatory 6th generation interface",
      "Email": "forest@mohrcassin.com",
      "FullName": "Miss Heloise Tracey Thiel I",
      "DirectPhone": "874.495.7676",
      "FormalName": "Legros Group",
      "CountryId": 53,
      "ContactId": 931,
      "ContactName": "Prosacco Inc and Sons",
      "Retired": 586,
      "Rank": 347,
      "ActiveInterests": 765,
      "ContactDepartment": "",
      "ContactCountryId": 842,
      "ContactOrgNr": "1315476",
      "FaxPhone": "960-332-0097 x151",
      "MobilePhone": "294-824-1568",
      "ContactPhone": "602-506-1824 x614",
      "AssociateName": "Ruecker Group",
      "AssociateId": 3,
      "UsePersonAddress": true,
      "ContactFax": "voluptatem",
      "Kanafname": "commodi",
      "Kanalname": "quam",
      "Post1": "et",
      "Post2": "beatae",
      "Post3": "rerum",
      "EmailName": "onie@kuvalisjast.us",
      "ContactFullName": "Nikko Hamill",
      "ActiveErpLinks": 278,
      "TicketPriorityId": 688,
      "SupportLanguageId": 559,
      "SupportAssociateId": 868,
      "CategoryName": "VIP Customer",
      "PersonNumber": "884700"
    }
  ],
  "AlertLevel": 444,
  "ConnectId": 984,
  "ReadStatus": "Green",
  "TimeToReply": 826,
  "RealTimeToReply": 527,
  "TimeToClose": 493,
  "RealTimeToClose": 814,
  "TimeSpentInternally": 5,
  "TimeSpentExternally": 168,
  "TimeSpentQueue": 969,
  "RealTimeSpentInternally": 561,
  "RealTimeSpentExternally": 211,
  "RealTimeSpentQueue": 378,
  "TimeSpent": 394,
  "HasAttachment": false,
  "NumReplies": 35,
  "NumMessages": 18,
  "FromAddress": "quas",
  "Messages": [
    {
      "TicketMessageId": 598,
      "CreatedAt": "2011-02-01T16:32:48.1338203+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "dolores",
      "PersonId": 992,
      "PersonFullName": "Dereck Russell Wilkinson IV",
      "ContactId": 567,
      "ContactName": "Reichel, Osinski and Feest",
      "ContactDepartment": "",
      "NumAttachments": 941,
      "EmailHeader": "mikayla@tromproberts.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "iure",
      "Sentiment": 253,
      "SentimentConfidence": 977,
      "CreatedBy": 833,
      "ChangedAt": "2018-02-04T16:32:48.1338203+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 496,
      "Name": "Ruecker-Schaden",
      "ToolTip": "Nemo atque et veritatis."
    },
    {
      "Id": 496,
      "Name": "Ruecker-Schaden",
      "ToolTip": "Nemo atque et veritatis."
    }
  ],
  "Language": "ad",
  "Sentiment": 548,
  "SentimentConfidence": 321,
  "SuggestedCategoryId": 45,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 709,
  "IconHint": "non",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 371,
  "ExtraFields": {
    "ExtraFields1": "ipsam",
    "ExtraFields2": "eveniet"
  },
  "CustomFields": {
    "CustomFields1": "asperiores",
    "CustomFields2": "ullam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 877,
  "Title": "quibusdam",
  "CreatedAt": "2016-11-18T16:32:48.1494403+01:00",
  "LastChanged": "2019-12-15T16:32:48.1494403+01:00",
  "ReadByOwner": "2019-07-20T16:32:48.1494403+02:00",
  "ReadByCustomer": "2017-10-03T16:32:48.1494403+02:00",
  "FirstReadByOwner": "2011-01-17T16:32:48.1494403+01:00",
  "FirstReadByUser": "2009-03-01T16:32:48.1494403+01:00",
  "Activate": "2022-08-04T16:32:48.1494403+02:00",
  "ClosedAt": "2011-10-10T16:32:48.1494403+02:00",
  "RepliedAt": "2000-02-17T16:32:48.1494403+01:00",
  "AlertTimeout": "2007-06-21T16:32:48.1494403+02:00",
  "Deadline": "2013-09-12T16:32:48.1494403+02:00",
  "CreatedBy": null,
  "Author": "ullam",
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
      "Position": "soluta",
      "PersonId": 749,
      "Mrmrs": "natus",
      "Firstname": "Jerad",
      "Lastname": "Carter",
      "MiddleName": "Stiedemann, Kassulke and Kunze",
      "Title": "rerum",
      "Description": "Digitized maximized focus group",
      "Email": "margaret_bradtke@reichellebsack.info",
      "FullName": "Sebastian Kuhlman",
      "DirectPhone": "1-245-840-2925",
      "FormalName": "Bayer, White and Hegmann",
      "CountryId": 748,
      "ContactId": 352,
      "ContactName": "Pfeffer, Bechtelar and O'Keefe",
      "Retired": 686,
      "Rank": 837,
      "ActiveInterests": 718,
      "ContactDepartment": "",
      "ContactCountryId": 147,
      "ContactOrgNr": "1094490",
      "FaxPhone": "1-719-578-0863",
      "MobilePhone": "1-226-025-0555 x89591",
      "ContactPhone": "1-129-440-5183",
      "AssociateName": "Veum-Murazik",
      "AssociateId": 359,
      "UsePersonAddress": false,
      "ContactFax": "quo",
      "Kanafname": "dignissimos",
      "Kanalname": "aut",
      "Post1": "deserunt",
      "Post2": "aperiam",
      "Post3": "recusandae",
      "EmailName": "ruthie@parkerquitzon.uk",
      "ContactFullName": "Yazmin Breitenberg",
      "ActiveErpLinks": 497,
      "TicketPriorityId": 792,
      "SupportLanguageId": 29,
      "SupportAssociateId": 33,
      "CategoryName": "VIP Customer",
      "PersonNumber": "206737",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    }
  ],
  "AlertLevel": 331,
  "ConnectId": 462,
  "ReadStatus": "Green",
  "TimeToReply": 285,
  "RealTimeToReply": 211,
  "TimeToClose": 363,
  "RealTimeToClose": 9,
  "TimeSpentInternally": 715,
  "TimeSpentExternally": 686,
  "TimeSpentQueue": 763,
  "RealTimeSpentInternally": 501,
  "RealTimeSpentExternally": 13,
  "RealTimeSpentQueue": 532,
  "TimeSpent": 371,
  "HasAttachment": false,
  "NumReplies": 436,
  "NumMessages": 326,
  "FromAddress": "nesciunt",
  "Messages": [
    {
      "TicketMessageId": 715,
      "CreatedAt": "2024-12-30T16:32:48.1494403+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "labore",
      "PersonId": 542,
      "PersonFullName": "Boyd Greenfelder",
      "ContactId": 217,
      "ContactName": "Crooks-Funk",
      "ContactDepartment": "",
      "NumAttachments": 881,
      "EmailHeader": "lily_rutherford@rosenbaum.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "non",
      "Sentiment": 103,
      "SentimentConfidence": 946,
      "CreatedBy": 398,
      "ChangedAt": "2003-06-03T16:32:48.1494403+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 671
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 713,
      "Name": "Shanahan Group",
      "ToolTip": "Rerum incidunt ex nemo et consequuntur quo in.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 222
        }
      }
    },
    {
      "Id": 713,
      "Name": "Shanahan Group",
      "ToolTip": "Rerum incidunt ex nemo et consequuntur quo in.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 222
        }
      }
    }
  ],
  "Language": "voluptatibus",
  "Sentiment": 249,
  "SentimentConfidence": 69,
  "SuggestedCategoryId": 41,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 602,
  "IconHint": "officia",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 532,
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "aspernatur"
  },
  "CustomFields": {
    "CustomFields1": "cupiditate",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 886
    }
  }
}
```