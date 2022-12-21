---
title: POST Ticket
uid: v1TicketEntity_HttpPostSaveTicketEntityWithNotify
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
| CreatedBy |  | The associate who created this ticket |
| Author | string | A string representing the author of the ticket (same as author of first message). |
| OwnedBy |  | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category |  | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority |  | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status |  | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person |  | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| CreatedBy |  | The associate who created this ticket |
| Author | string | A string representing the author of the ticket (same as author of first message). |
| OwnedBy |  | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category |  | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority |  | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status |  | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person |  | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Ticket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketId": 967,
  "Title": "aut",
  "CreatedAt": "2013-04-01T02:49:51.5675591+02:00",
  "LastChanged": "1999-08-03T02:49:51.5675591+02:00",
  "ReadByOwner": "1999-08-14T02:49:51.5675591+02:00",
  "ReadByCustomer": "2007-10-20T02:49:51.5675591+02:00",
  "FirstReadByOwner": "2007-05-07T02:49:51.5675591+02:00",
  "FirstReadByUser": "2003-02-14T02:49:51.5675591+01:00",
  "Activate": "2007-03-28T02:49:51.5675591+02:00",
  "ClosedAt": "2007-01-16T02:49:51.5675591+01:00",
  "RepliedAt": "2016-02-14T02:49:51.5675591+01:00",
  "AlertTimeout": "2013-04-05T02:49:51.5675591+02:00",
  "Deadline": "2010-07-15T02:49:51.5675591+02:00",
  "CreatedBy": null,
  "Author": "numquam",
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
      "Position": "aut",
      "PersonId": 480,
      "Mrmrs": "quas",
      "Firstname": "Polly",
      "Lastname": "Ebert",
      "MiddleName": "Daniel, Reynolds and Zieme",
      "Title": "tempore",
      "Description": "Centralized scalable website",
      "Email": "kaylah_reichel@starkking.ca",
      "FullName": "Mustafa Stokes MD",
      "DirectPhone": "823.531.3248 x8119",
      "FormalName": "Stiedemann, Bahringer and Wehner",
      "CountryId": 139,
      "ContactId": 745,
      "ContactName": "O'Kon-Kohler",
      "Retired": 170,
      "Rank": 845,
      "ActiveInterests": 30,
      "ContactDepartment": "",
      "ContactCountryId": 140,
      "ContactOrgNr": "1670487",
      "FaxPhone": "(726)765-9289",
      "MobilePhone": "(139)024-2001 x0653",
      "ContactPhone": "976-695-8605",
      "AssociateName": "Hermiston, Ankunding and McKenzie",
      "AssociateId": 49,
      "UsePersonAddress": false,
      "ContactFax": "enim",
      "Kanafname": "ullam",
      "Kanalname": "nihil",
      "Post1": "dolore",
      "Post2": "ab",
      "Post3": "quaerat",
      "EmailName": "gracie.carroll@pagacschroeder.biz",
      "ContactFullName": "Leonel Herman",
      "ActiveErpLinks": 97,
      "TicketPriorityId": 931,
      "SupportLanguageId": 252,
      "SupportAssociateId": 421,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 213,
  "ConnectId": 103,
  "ReadStatus": "Green",
  "TimeToReply": 822,
  "RealTimeToReply": 961,
  "TimeToClose": 345,
  "RealTimeToClose": 286,
  "TimeSpentInternally": 16,
  "TimeSpentExternally": 287,
  "TimeSpentQueue": 177,
  "RealTimeSpentInternally": 649,
  "RealTimeSpentExternally": 618,
  "RealTimeSpentQueue": 294,
  "HasAttachment": false,
  "NumReplies": 471,
  "NumMessages": 91,
  "FromAddress": "laudantium",
  "Messages": [
    {
      "TicketMessageId": 594,
      "CreatedAt": "2017-10-16T02:49:51.5675591+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "qui",
      "PersonId": 784,
      "PersonFullName": "Rosina Stroman",
      "ContactId": 112,
      "ContactName": "Fisher LLC",
      "ContactDepartment": "",
      "NumAttachments": 556,
      "EmailHeader": "gunner_little@vandervort.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "hic",
      "Sentiment": 381,
      "SentimentConfidence": 838,
      "CreatedBy": 817,
      "ChangedAt": "2006-09-16T02:49:51.5675591+02:00"
    }
  ],
  "Tags": [
    {
      "Id": 114,
      "Name": "Hoeger-Konopelski",
      "ToolTip": "Fugit officia eos et rerum."
    },
    {
      "Id": 114,
      "Name": "Hoeger-Konopelski",
      "ToolTip": "Fugit officia eos et rerum."
    }
  ],
  "Language": "occaecati",
  "Sentiment": 573,
  "SentimentConfidence": 619,
  "SuggestedCategoryId": 11,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 938,
  "IconHint": "delectus",
  "ExtraFields": {
    "ExtraFields1": "eius",
    "ExtraFields2": "eligendi"
  },
  "CustomFields": {
    "CustomFields1": "ducimus",
    "CustomFields2": "dolor"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 787,
  "Title": "pariatur",
  "CreatedAt": "2015-04-30T02:49:51.5675591+02:00",
  "LastChanged": "2013-10-25T02:49:51.5675591+02:00",
  "ReadByOwner": "2011-11-23T02:49:51.5675591+01:00",
  "ReadByCustomer": "1995-10-06T02:49:51.5675591+02:00",
  "FirstReadByOwner": "1998-09-01T02:49:51.5675591+02:00",
  "FirstReadByUser": "2011-07-17T02:49:51.5675591+02:00",
  "Activate": "1995-11-20T02:49:51.5675591+01:00",
  "ClosedAt": "2008-08-15T02:49:51.5675591+02:00",
  "RepliedAt": "2020-01-24T02:49:51.5675591+01:00",
  "AlertTimeout": "2000-04-13T02:49:51.5675591+02:00",
  "Deadline": "1995-10-31T02:49:51.5675591+01:00",
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
      "Position": "debitis",
      "PersonId": 809,
      "Mrmrs": "dolore",
      "Firstname": "Dahlia",
      "Lastname": "Dare",
      "MiddleName": "Ernser, Gibson and Hermiston",
      "Title": "quis",
      "Description": "Universal uniform monitoring",
      "Email": "beryl@greenfelderzulauf.uk",
      "FullName": "Alia Durgan",
      "DirectPhone": "529.900.4005",
      "FormalName": "Graham, Heaney and O'Reilly",
      "CountryId": 966,
      "ContactId": 774,
      "ContactName": "Quigley-Jakubowski",
      "Retired": 362,
      "Rank": 853,
      "ActiveInterests": 572,
      "ContactDepartment": "",
      "ContactCountryId": 298,
      "ContactOrgNr": "665998",
      "FaxPhone": "1-616-484-9883",
      "MobilePhone": "216-629-2243 x60918",
      "ContactPhone": "(769)493-5233",
      "AssociateName": "Towne-Haag",
      "AssociateId": 442,
      "UsePersonAddress": false,
      "ContactFax": "omnis",
      "Kanafname": "rerum",
      "Kanalname": "iure",
      "Post1": "voluptatem",
      "Post2": "enim",
      "Post3": "amet",
      "EmailName": "daron@gleason.biz",
      "ContactFullName": "Cesar Reilly",
      "ActiveErpLinks": 257,
      "TicketPriorityId": 225,
      "SupportLanguageId": 912,
      "SupportAssociateId": 731,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 394
        }
      }
    }
  ],
  "AlertLevel": 728,
  "ConnectId": 115,
  "ReadStatus": "Green",
  "TimeToReply": 919,
  "RealTimeToReply": 414,
  "TimeToClose": 792,
  "RealTimeToClose": 447,
  "TimeSpentInternally": 95,
  "TimeSpentExternally": 182,
  "TimeSpentQueue": 479,
  "RealTimeSpentInternally": 825,
  "RealTimeSpentExternally": 540,
  "RealTimeSpentQueue": 646,
  "HasAttachment": false,
  "NumReplies": 431,
  "NumMessages": 348,
  "FromAddress": "voluptas",
  "Messages": [
    {
      "TicketMessageId": 459,
      "CreatedAt": "2005-05-24T02:49:51.5831853+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "qui",
      "PersonId": 837,
      "PersonFullName": "Brent Ondricka",
      "ContactId": 18,
      "ContactName": "Schaden, Luettgen and Kovacek",
      "ContactDepartment": "",
      "NumAttachments": 493,
      "EmailHeader": "icie_cummerata@nolan.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "et",
      "Sentiment": 818,
      "SentimentConfidence": 79,
      "CreatedBy": 376,
      "ChangedAt": "2012-04-05T02:49:51.5831853+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 202
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 2,
      "Name": "Gerlach-Wolff",
      "ToolTip": "Unde quis quibusdam nihil aut mollitia sunt.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 752
        }
      }
    },
    {
      "Id": 2,
      "Name": "Gerlach-Wolff",
      "ToolTip": "Unde quis quibusdam nihil aut mollitia sunt.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 752
        }
      }
    }
  ],
  "Language": "aut",
  "Sentiment": 258,
  "SentimentConfidence": 112,
  "SuggestedCategoryId": 71,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 893,
  "IconHint": "a",
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "illo",
    "CustomFields2": "quis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 457
    }
  }
}
```