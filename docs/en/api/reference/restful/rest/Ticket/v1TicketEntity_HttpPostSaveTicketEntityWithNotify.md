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
  "TicketId": 638,
  "Title": "in",
  "CreatedAt": "2005-02-18T10:30:32.5281261+01:00",
  "LastChanged": "2005-05-23T10:30:32.5281261+02:00",
  "ReadByOwner": "2021-11-04T10:30:32.5281261+01:00",
  "ReadByCustomer": "2000-08-02T10:30:32.5281261+02:00",
  "FirstReadByOwner": "2014-05-04T10:30:32.5281261+02:00",
  "FirstReadByUser": "2012-02-28T10:30:32.5281261+01:00",
  "Activate": "2003-11-28T10:30:32.5281261+01:00",
  "ClosedAt": "2015-03-01T10:30:32.5281261+01:00",
  "RepliedAt": "2023-01-06T10:30:32.5281261+01:00",
  "AlertTimeout": "1997-09-24T10:30:32.5281261+02:00",
  "Deadline": "2000-10-29T10:30:32.5281261+01:00",
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
      "Position": "iusto",
      "PersonId": 105,
      "Mrmrs": "voluptate",
      "Firstname": "Jadon",
      "Lastname": "Nitzsche",
      "MiddleName": "Denesik, Turner and Stehr",
      "Title": "molestiae",
      "Description": "Diverse value-added secured line",
      "Email": "lexus@bahringer.ca",
      "FullName": "Mrs. Mitchell Farrell V",
      "DirectPhone": "363.997.0033 x1561",
      "FormalName": "Rowe, Bernhard and Fisher",
      "CountryId": 989,
      "ContactId": 629,
      "ContactName": "Bosco, Mertz and Predovic",
      "Retired": 395,
      "Rank": 728,
      "ActiveInterests": 499,
      "ContactDepartment": "",
      "ContactCountryId": 533,
      "ContactOrgNr": "581778",
      "FaxPhone": "348.838.7117",
      "MobilePhone": "1-014-787-3680 x57800",
      "ContactPhone": "(526)358-8220",
      "AssociateName": "Feeney, Fadel and Welch",
      "AssociateId": 200,
      "UsePersonAddress": true,
      "ContactFax": "voluptas",
      "Kanafname": "expedita",
      "Kanalname": "a",
      "Post1": "explicabo",
      "Post2": "atque",
      "Post3": "eveniet",
      "EmailName": "alycia@borer.uk",
      "ContactFullName": "Savanah Bruen",
      "ActiveErpLinks": 960,
      "TicketPriorityId": 355,
      "SupportLanguageId": 350,
      "SupportAssociateId": 421,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 940,
  "ConnectId": 934,
  "ReadStatus": "Green",
  "TimeToReply": 944,
  "RealTimeToReply": 792,
  "TimeToClose": 849,
  "RealTimeToClose": 128,
  "TimeSpentInternally": 727,
  "TimeSpentExternally": 367,
  "TimeSpentQueue": 482,
  "RealTimeSpentInternally": 426,
  "RealTimeSpentExternally": 50,
  "RealTimeSpentQueue": 819,
  "TimeSpent": 217,
  "HasAttachment": false,
  "NumReplies": 330,
  "NumMessages": 952,
  "FromAddress": "rem",
  "Messages": [
    {
      "TicketMessageId": 78,
      "CreatedAt": "2000-04-28T10:30:32.5437518+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "suscipit",
      "PersonId": 884,
      "PersonFullName": "Prof. Reagan Weimann",
      "ContactId": 621,
      "ContactName": "Torp LLC",
      "ContactDepartment": "",
      "NumAttachments": 530,
      "EmailHeader": "rahul@dach.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quo",
      "Sentiment": 549,
      "SentimentConfidence": 213,
      "CreatedBy": 719,
      "ChangedAt": "2000-07-22T10:30:32.5437518+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 587,
      "Name": "Hartmann Inc and Sons",
      "ToolTip": "Labore ad quos."
    },
    {
      "Id": 587,
      "Name": "Hartmann Inc and Sons",
      "ToolTip": "Labore ad quos."
    }
  ],
  "Language": "corrupti",
  "Sentiment": 979,
  "SentimentConfidence": 667,
  "SuggestedCategoryId": 261,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 422,
  "IconHint": "harum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 349,
  "ExtraFields": {
    "ExtraFields1": "mollitia",
    "ExtraFields2": "officiis"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "consequatur"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 973,
  "Title": "odit",
  "CreatedAt": "2013-02-19T10:30:32.5437518+01:00",
  "LastChanged": "2001-12-15T10:30:32.5437518+01:00",
  "ReadByOwner": "2013-06-07T10:30:32.5437518+02:00",
  "ReadByCustomer": "1999-06-16T10:30:32.5437518+02:00",
  "FirstReadByOwner": "1996-12-19T10:30:32.5437518+01:00",
  "FirstReadByUser": "2001-01-09T10:30:32.5437518+01:00",
  "Activate": "1997-09-17T10:30:32.5437518+02:00",
  "ClosedAt": "2008-12-11T10:30:32.5437518+01:00",
  "RepliedAt": "2015-09-10T10:30:32.5437518+02:00",
  "AlertTimeout": "2017-08-16T10:30:32.5437518+02:00",
  "Deadline": "2009-06-30T10:30:32.5437518+02:00",
  "CreatedBy": null,
  "Author": "ratione",
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
      "Position": "excepturi",
      "PersonId": 45,
      "Mrmrs": "dignissimos",
      "Firstname": "Florian",
      "Lastname": "Koepp",
      "MiddleName": "Ortiz-Rodriguez",
      "Title": "esse",
      "Description": "Extended clear-thinking encoding",
      "Email": "jacinto@hirthe.ca",
      "FullName": "Willie Mante",
      "DirectPhone": "1-838-963-0999 x83079",
      "FormalName": "Windler LLC",
      "CountryId": 559,
      "ContactId": 139,
      "ContactName": "Rice, Russel and Willms",
      "Retired": 353,
      "Rank": 69,
      "ActiveInterests": 610,
      "ContactDepartment": "disintermediate B2C markets",
      "ContactCountryId": 980,
      "ContactOrgNr": "524633",
      "FaxPhone": "839-354-4926 x289",
      "MobilePhone": "544-035-9994 x8364",
      "ContactPhone": "1-286-233-0514 x959",
      "AssociateName": "Monahan-Hansen",
      "AssociateId": 542,
      "UsePersonAddress": false,
      "ContactFax": "ipsum",
      "Kanafname": "dolorum",
      "Kanalname": "odio",
      "Post1": "nam",
      "Post2": "illum",
      "Post3": "sequi",
      "EmailName": "missouri@boyer.biz",
      "ContactFullName": "Waldo McLaughlin",
      "ActiveErpLinks": 347,
      "TicketPriorityId": 966,
      "SupportLanguageId": 349,
      "SupportAssociateId": 452,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 768
        }
      }
    }
  ],
  "AlertLevel": 29,
  "ConnectId": 214,
  "ReadStatus": "Green",
  "TimeToReply": 260,
  "RealTimeToReply": 295,
  "TimeToClose": 361,
  "RealTimeToClose": 168,
  "TimeSpentInternally": 409,
  "TimeSpentExternally": 812,
  "TimeSpentQueue": 447,
  "RealTimeSpentInternally": 659,
  "RealTimeSpentExternally": 685,
  "RealTimeSpentQueue": 13,
  "TimeSpent": 629,
  "HasAttachment": false,
  "NumReplies": 255,
  "NumMessages": 71,
  "FromAddress": "voluptate",
  "Messages": [
    {
      "TicketMessageId": 758,
      "CreatedAt": "2013-02-06T10:30:32.5437518+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "debitis",
      "PersonId": 25,
      "PersonFullName": "Sigmund Rowan Nolan DVM",
      "ContactId": 549,
      "ContactName": "Davis Group",
      "ContactDepartment": "",
      "NumAttachments": 214,
      "EmailHeader": "hulda.strosin@white.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ipsam",
      "Sentiment": 817,
      "SentimentConfidence": 162,
      "CreatedBy": 340,
      "ChangedAt": "2006-05-06T10:30:32.5437518+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 413
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 831,
      "Name": "Bins, Breitenberg and Watsica",
      "ToolTip": "Repudiandae optio nostrum rerum quae asperiores.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 229
        }
      }
    },
    {
      "Id": 831,
      "Name": "Bins, Breitenberg and Watsica",
      "ToolTip": "Repudiandae optio nostrum rerum quae asperiores.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 229
        }
      }
    }
  ],
  "Language": "molestias",
  "Sentiment": 320,
  "SentimentConfidence": 290,
  "SuggestedCategoryId": 823,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 264,
  "IconHint": "dolor",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 130,
  "ExtraFields": {
    "ExtraFields1": "eius",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "deleniti"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 713
    }
  }
}
```