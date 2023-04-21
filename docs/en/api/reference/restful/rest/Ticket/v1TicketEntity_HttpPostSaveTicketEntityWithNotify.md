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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
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
  "TicketId": 236,
  "Title": "ut",
  "CreatedAt": "2016-01-31T15:29:30.6494904+01:00",
  "LastChanged": "2013-08-18T15:29:30.6494904+02:00",
  "ReadByOwner": "2021-08-31T15:29:30.6494904+02:00",
  "ReadByCustomer": "2022-02-19T15:29:30.6494904+01:00",
  "FirstReadByOwner": "2023-03-03T15:29:30.6494904+01:00",
  "FirstReadByUser": "2007-08-16T15:29:30.6494904+02:00",
  "Activate": "2009-08-22T15:29:30.6494904+02:00",
  "ClosedAt": "2011-05-21T15:29:30.6494904+02:00",
  "RepliedAt": "2012-11-02T15:29:30.6494904+01:00",
  "AlertTimeout": "2011-08-10T15:29:30.6494904+02:00",
  "Deadline": "2007-02-15T15:29:30.6494904+01:00",
  "CreatedBy": null,
  "Author": "eos",
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
      "PersonId": 395,
      "Mrmrs": "excepturi",
      "Firstname": "Sigrid",
      "Lastname": "Satterfield",
      "MiddleName": "Bahringer, Mante and Ward",
      "Title": "sed",
      "Description": "Focused high-level array",
      "Email": "haleigh_kilback@zboncaklarson.us",
      "FullName": "Cathryn Schroeder",
      "DirectPhone": "1-332-849-7073",
      "FormalName": "Orn, Hirthe and Weimann",
      "CountryId": 684,
      "ContactId": 210,
      "ContactName": "Zboncak-Hills",
      "Retired": 657,
      "Rank": 883,
      "ActiveInterests": 918,
      "ContactDepartment": "",
      "ContactCountryId": 40,
      "ContactOrgNr": "998421",
      "FaxPhone": "1-491-313-3416",
      "MobilePhone": "(490)478-1635 x879",
      "ContactPhone": "664.751.8229 x669",
      "AssociateName": "O'Hara, Conn and Stark",
      "AssociateId": 88,
      "UsePersonAddress": false,
      "ContactFax": "dolore",
      "Kanafname": "tempore",
      "Kanalname": "laborum",
      "Post1": "numquam",
      "Post2": "voluptatem",
      "Post3": "voluptas",
      "EmailName": "loraine_shields@berge.biz",
      "ContactFullName": "Santiago Kozey",
      "ActiveErpLinks": 603,
      "TicketPriorityId": 265,
      "SupportLanguageId": 685,
      "SupportAssociateId": 723,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 448,
  "ConnectId": 848,
  "ReadStatus": "Green",
  "TimeToReply": 622,
  "RealTimeToReply": 255,
  "TimeToClose": 179,
  "RealTimeToClose": 830,
  "TimeSpentInternally": 455,
  "TimeSpentExternally": 503,
  "TimeSpentQueue": 647,
  "RealTimeSpentInternally": 8,
  "RealTimeSpentExternally": 894,
  "RealTimeSpentQueue": 11,
  "HasAttachment": false,
  "NumReplies": 757,
  "NumMessages": 511,
  "FromAddress": "sapiente",
  "Messages": [
    {
      "TicketMessageId": 181,
      "CreatedAt": "1998-01-31T15:29:30.6549901+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "et",
      "PersonId": 80,
      "PersonFullName": "Damon Walter",
      "ContactId": 439,
      "ContactName": "Schowalter LLC",
      "ContactDepartment": "",
      "NumAttachments": 984,
      "EmailHeader": "maiya@luettgen.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "perspiciatis",
      "Sentiment": 540,
      "SentimentConfidence": 827,
      "CreatedBy": 924,
      "ChangedAt": "2010-01-17T15:29:30.6549901+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 358,
      "Name": "Flatley, Aufderhar and Streich",
      "ToolTip": "Perferendis aut."
    },
    {
      "Id": 358,
      "Name": "Flatley, Aufderhar and Streich",
      "ToolTip": "Perferendis aut."
    }
  ],
  "Language": "beatae",
  "Sentiment": 492,
  "SentimentConfidence": 868,
  "SuggestedCategoryId": 951,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 494,
  "IconHint": "qui",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "beatae",
    "CustomFields2": "corporis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 75,
  "Title": "aut",
  "CreatedAt": "2012-04-22T15:29:30.662487+02:00",
  "LastChanged": "1996-03-10T15:29:30.662487+01:00",
  "ReadByOwner": "2008-03-16T15:29:30.662487+01:00",
  "ReadByCustomer": "2007-11-23T15:29:30.662487+01:00",
  "FirstReadByOwner": "2016-10-06T15:29:30.662487+02:00",
  "FirstReadByUser": "1998-08-18T15:29:30.662487+02:00",
  "Activate": "2004-06-28T15:29:30.662487+02:00",
  "ClosedAt": "2011-05-18T15:29:30.662487+02:00",
  "RepliedAt": "2000-06-16T15:29:30.662487+02:00",
  "AlertTimeout": "2008-04-28T15:29:30.662487+02:00",
  "Deadline": "2020-05-01T15:29:30.662487+02:00",
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
      "Position": "aut",
      "PersonId": 999,
      "Mrmrs": "distinctio",
      "Firstname": "Marion",
      "Lastname": "Windler",
      "MiddleName": "Green-Mohr",
      "Title": "voluptatem",
      "Description": "Down-sized incremental alliance",
      "Email": "houston@haley.uk",
      "FullName": "Helen Gaylord Sr.",
      "DirectPhone": "233.385.0595 x3475",
      "FormalName": "Toy, Stark and Windler",
      "CountryId": 876,
      "ContactId": 848,
      "ContactName": "Hudson Group",
      "Retired": 341,
      "Rank": 861,
      "ActiveInterests": 875,
      "ContactDepartment": "",
      "ContactCountryId": 659,
      "ContactOrgNr": "1401230",
      "FaxPhone": "897-467-3679 x438",
      "MobilePhone": "(293)189-7863",
      "ContactPhone": "713.740.5927",
      "AssociateName": "Bayer-O'Reilly",
      "AssociateId": 170,
      "UsePersonAddress": false,
      "ContactFax": "corporis",
      "Kanafname": "reiciendis",
      "Kanalname": "sit",
      "Post1": "aut",
      "Post2": "illo",
      "Post3": "fugiat",
      "EmailName": "danial_fahey@jastconnelly.name",
      "ContactFullName": "Ms. Percy Colby Willms Jr.",
      "ActiveErpLinks": 529,
      "TicketPriorityId": 371,
      "SupportLanguageId": 67,
      "SupportAssociateId": 114,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 896
        }
      }
    }
  ],
  "AlertLevel": 570,
  "ConnectId": 116,
  "ReadStatus": "Green",
  "TimeToReply": 792,
  "RealTimeToReply": 231,
  "TimeToClose": 73,
  "RealTimeToClose": 486,
  "TimeSpentInternally": 347,
  "TimeSpentExternally": 418,
  "TimeSpentQueue": 64,
  "RealTimeSpentInternally": 972,
  "RealTimeSpentExternally": 594,
  "RealTimeSpentQueue": 48,
  "HasAttachment": false,
  "NumReplies": 787,
  "NumMessages": 565,
  "FromAddress": "quas",
  "Messages": [
    {
      "TicketMessageId": 707,
      "CreatedAt": "2014-03-10T15:29:30.6664927+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "iusto",
      "PersonId": 680,
      "PersonFullName": "Mrs. Trevion Stamm III",
      "ContactId": 794,
      "ContactName": "Torp, Ritchie and Herzog",
      "ContactDepartment": "",
      "NumAttachments": 550,
      "EmailHeader": "marilyne.moore@greenfelder.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "amet",
      "Sentiment": 174,
      "SentimentConfidence": 450,
      "CreatedBy": 979,
      "ChangedAt": "2013-07-10T15:29:30.666987+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 505
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 778,
      "Name": "Nicolas LLC",
      "ToolTip": "Et ad eos.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 868
        }
      }
    },
    {
      "Id": 778,
      "Name": "Nicolas LLC",
      "ToolTip": "Et ad eos.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 868
        }
      }
    }
  ],
  "Language": "omnis",
  "Sentiment": 513,
  "SentimentConfidence": 146,
  "SuggestedCategoryId": 807,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 537,
  "IconHint": "id",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "culpa",
    "ExtraFields2": "maiores"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "assumenda"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 863
    }
  }
}
```