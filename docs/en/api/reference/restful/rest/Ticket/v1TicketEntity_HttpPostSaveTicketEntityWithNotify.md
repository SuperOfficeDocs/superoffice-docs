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
  "TicketId": 317,
  "Title": "quo",
  "CreatedAt": "2012-09-21T14:45:13.2712164+02:00",
  "LastChanged": "2018-03-08T14:45:13.2712164+01:00",
  "ReadByOwner": "2001-09-26T14:45:13.2712164+02:00",
  "ReadByCustomer": "2001-11-10T14:45:13.2712164+01:00",
  "FirstReadByOwner": "2018-02-23T14:45:13.2712164+01:00",
  "FirstReadByUser": "1999-02-07T14:45:13.2712164+01:00",
  "Activate": "2012-01-16T14:45:13.2712164+01:00",
  "ClosedAt": "1998-03-02T14:45:13.2712164+01:00",
  "RepliedAt": "2014-04-21T14:45:13.2712164+02:00",
  "AlertTimeout": "2006-10-20T14:45:13.2712164+02:00",
  "Deadline": "2009-12-01T14:45:13.2712164+01:00",
  "CreatedBy": null,
  "Author": "adipisci",
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
      "Position": "molestias",
      "PersonId": 812,
      "Mrmrs": "id",
      "Firstname": "Nona",
      "Lastname": "Wintheiser",
      "MiddleName": "Heidenreich, Batz and Grimes",
      "Title": "illo",
      "Description": "Decentralized stable productivity",
      "Email": "justyn@lind.com",
      "FullName": "Jerod Arely Runolfsson IV",
      "DirectPhone": "022.596.0788",
      "FormalName": "Gottlieb, Sauer and Bode",
      "CountryId": 472,
      "ContactId": 197,
      "ContactName": "Bruen LLC",
      "Retired": 706,
      "Rank": 385,
      "ActiveInterests": 207,
      "ContactDepartment": "",
      "ContactCountryId": 665,
      "ContactOrgNr": "1049116",
      "FaxPhone": "071-800-9814 x715",
      "MobilePhone": "(429)114-2163",
      "ContactPhone": "146.258.6769 x6408",
      "AssociateName": "Flatley Inc and Sons",
      "AssociateId": 905,
      "UsePersonAddress": false,
      "ContactFax": "dolor",
      "Kanafname": "et",
      "Kanalname": "et",
      "Post1": "velit",
      "Post2": "repellat",
      "Post3": "voluptatibus",
      "EmailName": "gonzalo_greenfelder@watsicaconroy.uk",
      "ContactFullName": "Aylin Kutch",
      "ActiveErpLinks": 687,
      "TicketPriorityId": 875,
      "SupportLanguageId": 154,
      "SupportAssociateId": 733,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 982,
  "ConnectId": 772,
  "ReadStatus": "Green",
  "TimeToReply": 527,
  "RealTimeToReply": 174,
  "TimeToClose": 241,
  "RealTimeToClose": 260,
  "TimeSpentInternally": 786,
  "TimeSpentExternally": 123,
  "TimeSpentQueue": 412,
  "RealTimeSpentInternally": 50,
  "RealTimeSpentExternally": 243,
  "RealTimeSpentQueue": 390,
  "TimeSpent": 572,
  "HasAttachment": false,
  "NumReplies": 682,
  "NumMessages": 380,
  "FromAddress": "iure",
  "Messages": [
    {
      "TicketMessageId": 325,
      "CreatedAt": "2013-01-20T14:45:13.2712164+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "veniam",
      "PersonId": 266,
      "PersonFullName": "Rudy Howe",
      "ContactId": 960,
      "ContactName": "Lesch-Kuhic",
      "ContactDepartment": "",
      "NumAttachments": 225,
      "EmailHeader": "patience@predovic.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "et",
      "Sentiment": 574,
      "SentimentConfidence": 846,
      "CreatedBy": 62,
      "ChangedAt": "2009-04-25T14:45:13.2712164+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 301,
      "Name": "Feest, Blick and Murray",
      "ToolTip": "Officia quia ut."
    },
    {
      "Id": 301,
      "Name": "Feest, Blick and Murray",
      "ToolTip": "Officia quia ut."
    }
  ],
  "Language": "et",
  "Sentiment": 204,
  "SentimentConfidence": 676,
  "SuggestedCategoryId": 511,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 905,
  "IconHint": "ut",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 15,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "beatae"
  },
  "CustomFields": {
    "CustomFields1": "officiis",
    "CustomFields2": "neque"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 898,
  "Title": "iure",
  "CreatedAt": "2023-11-05T14:45:13.2868392+01:00",
  "LastChanged": "2011-03-26T14:45:13.2868392+01:00",
  "ReadByOwner": "2006-08-05T14:45:13.2868392+02:00",
  "ReadByCustomer": "2011-07-26T14:45:13.2868392+02:00",
  "FirstReadByOwner": "2010-01-26T14:45:13.2868392+01:00",
  "FirstReadByUser": "2023-12-11T14:45:13.2868392+01:00",
  "Activate": "2013-08-14T14:45:13.2868392+02:00",
  "ClosedAt": "2022-04-21T14:45:13.2868392+02:00",
  "RepliedAt": "2000-09-17T14:45:13.2868392+02:00",
  "AlertTimeout": "1997-08-26T14:45:13.2868392+02:00",
  "Deadline": "2016-05-14T14:45:13.2868392+02:00",
  "CreatedBy": null,
  "Author": "odit",
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
      "Position": "animi",
      "PersonId": 222,
      "Mrmrs": "voluptatem",
      "Firstname": "Kamron",
      "Lastname": "Dibbert",
      "MiddleName": "Batz LLC",
      "Title": "distinctio",
      "Description": "Ergonomic analyzing internet solution",
      "Email": "lottie_treutel@hermiston.uk",
      "FullName": "Kellen Batz",
      "DirectPhone": "737.447.8017",
      "FormalName": "Braun, Carroll and Dickinson",
      "CountryId": 356,
      "ContactId": 312,
      "ContactName": "Stark Inc and Sons",
      "Retired": 302,
      "Rank": 250,
      "ActiveInterests": 319,
      "ContactDepartment": "",
      "ContactCountryId": 644,
      "ContactOrgNr": "926936",
      "FaxPhone": "183.236.3277",
      "MobilePhone": "576-623-2401 x58145",
      "ContactPhone": "(267)686-1338 x03809",
      "AssociateName": "Purdy, Green and Gusikowski",
      "AssociateId": 365,
      "UsePersonAddress": true,
      "ContactFax": "hic",
      "Kanafname": "ad",
      "Kanalname": "minus",
      "Post1": "modi",
      "Post2": "temporibus",
      "Post3": "qui",
      "EmailName": "otha_osinski@lemkemoore.ca",
      "ContactFullName": "Prof. Reta Elfrieda Dare III",
      "ActiveErpLinks": 71,
      "TicketPriorityId": 434,
      "SupportLanguageId": 291,
      "SupportAssociateId": 437,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 289
        }
      }
    }
  ],
  "AlertLevel": 875,
  "ConnectId": 516,
  "ReadStatus": "Green",
  "TimeToReply": 454,
  "RealTimeToReply": 468,
  "TimeToClose": 104,
  "RealTimeToClose": 321,
  "TimeSpentInternally": 375,
  "TimeSpentExternally": 885,
  "TimeSpentQueue": 395,
  "RealTimeSpentInternally": 12,
  "RealTimeSpentExternally": 187,
  "RealTimeSpentQueue": 209,
  "TimeSpent": 637,
  "HasAttachment": true,
  "NumReplies": 514,
  "NumMessages": 764,
  "FromAddress": "aliquam",
  "Messages": [
    {
      "TicketMessageId": 427,
      "CreatedAt": "1998-08-07T14:45:13.2868392+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "veritatis",
      "PersonId": 857,
      "PersonFullName": "Geo Ruecker",
      "ContactId": 105,
      "ContactName": "Lindgren-Kozey",
      "ContactDepartment": "",
      "NumAttachments": 607,
      "EmailHeader": "dixie.blanda@daniel.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quo",
      "Sentiment": 57,
      "SentimentConfidence": 649,
      "CreatedBy": 785,
      "ChangedAt": "2024-01-11T14:45:13.2868392+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 427
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 417,
      "Name": "Mosciski, Altenwerth and Simonis",
      "ToolTip": "Modi aut vitae maxime quaerat.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 932
        }
      }
    },
    {
      "Id": 417,
      "Name": "Mosciski, Altenwerth and Simonis",
      "ToolTip": "Modi aut vitae maxime quaerat.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 932
        }
      }
    }
  ],
  "Language": "nihil",
  "Sentiment": 546,
  "SentimentConfidence": 721,
  "SuggestedCategoryId": 718,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 435,
  "IconHint": "adipisci",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 871,
  "ExtraFields": {
    "ExtraFields1": "maiores",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "voluptatum",
    "CustomFields2": "esse"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 801
    }
  }
}
```