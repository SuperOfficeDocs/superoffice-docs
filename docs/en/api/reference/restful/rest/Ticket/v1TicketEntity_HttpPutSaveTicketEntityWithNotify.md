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
PUT /api/v1/Ticket/{id}?notify=False
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
  "TicketId": 388,
  "Title": "velit",
  "CreatedAt": "2014-06-15T14:45:13.3024614+02:00",
  "LastChanged": "2004-01-17T14:45:13.3024614+01:00",
  "ReadByOwner": "2005-07-21T14:45:13.3024614+02:00",
  "ReadByCustomer": "1998-01-23T14:45:13.3024614+01:00",
  "FirstReadByOwner": "2004-03-23T14:45:13.3024614+01:00",
  "FirstReadByUser": "2006-12-02T14:45:13.3024614+01:00",
  "Activate": "2006-03-11T14:45:13.3024614+01:00",
  "ClosedAt": "2007-01-28T14:45:13.3024614+01:00",
  "RepliedAt": "2005-06-22T14:45:13.3024614+02:00",
  "AlertTimeout": "2008-12-13T14:45:13.3024614+01:00",
  "Deadline": "2024-02-26T14:45:13.3024614+01:00",
  "CreatedBy": null,
  "Author": "aliquam",
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
      "Position": "illo",
      "PersonId": 566,
      "Mrmrs": "iste",
      "Firstname": "Yasmin",
      "Lastname": "Haag",
      "MiddleName": "Walker-Purdy",
      "Title": "praesentium",
      "Description": "Re-contextualized grid-enabled array",
      "Email": "gus@mcdermott.ca",
      "FullName": "Kira Eichmann",
      "DirectPhone": "1-987-032-9186",
      "FormalName": "Larkin, Nolan and Parisian",
      "CountryId": 532,
      "ContactId": 666,
      "ContactName": "Brekke-Cormier",
      "Retired": 432,
      "Rank": 874,
      "ActiveInterests": 728,
      "ContactDepartment": "",
      "ContactCountryId": 99,
      "ContactOrgNr": "1713160",
      "FaxPhone": "856-171-0070",
      "MobilePhone": "790-139-0347 x6791",
      "ContactPhone": "775-694-9115 x15105",
      "AssociateName": "Volkman, Keebler and Collins",
      "AssociateId": 967,
      "UsePersonAddress": true,
      "ContactFax": "quis",
      "Kanafname": "velit",
      "Kanalname": "recusandae",
      "Post1": "occaecati",
      "Post2": "quia",
      "Post3": "asperiores",
      "EmailName": "graciela@reicheltreutel.name",
      "ContactFullName": "Mr. Mossie Bryana Boyer",
      "ActiveErpLinks": 250,
      "TicketPriorityId": 139,
      "SupportLanguageId": 419,
      "SupportAssociateId": 879,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 328,
  "ConnectId": 684,
  "ReadStatus": "Green",
  "TimeToReply": 99,
  "RealTimeToReply": 392,
  "TimeToClose": 201,
  "RealTimeToClose": 323,
  "TimeSpentInternally": 253,
  "TimeSpentExternally": 116,
  "TimeSpentQueue": 638,
  "RealTimeSpentInternally": 195,
  "RealTimeSpentExternally": 733,
  "RealTimeSpentQueue": 221,
  "TimeSpent": 813,
  "HasAttachment": true,
  "NumReplies": 637,
  "NumMessages": 987,
  "FromAddress": "tenetur",
  "Messages": [
    {
      "TicketMessageId": 697,
      "CreatedAt": "2000-09-05T14:45:13.3024614+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "quod",
      "PersonId": 316,
      "PersonFullName": "Elfrieda Littel DDS",
      "ContactId": 844,
      "ContactName": "Dickens, Barrows and Rohan",
      "ContactDepartment": "",
      "NumAttachments": 770,
      "EmailHeader": "adrain_renner@rowegorczany.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "consequatur",
      "Sentiment": 51,
      "SentimentConfidence": 263,
      "CreatedBy": 861,
      "ChangedAt": "2020-10-29T14:45:13.3024614+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 295,
      "Name": "Littel Inc and Sons",
      "ToolTip": "Optio libero et sit."
    },
    {
      "Id": 295,
      "Name": "Littel Inc and Sons",
      "ToolTip": "Optio libero et sit."
    }
  ],
  "Language": "vel",
  "Sentiment": 393,
  "SentimentConfidence": 680,
  "SuggestedCategoryId": 321,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 734,
  "IconHint": "nesciunt",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 896,
  "ExtraFields": {
    "ExtraFields1": "corporis",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "veritatis",
    "CustomFields2": "minima"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 518,
  "Title": "a",
  "CreatedAt": "2014-10-09T14:45:13.3024614+02:00",
  "LastChanged": "2018-01-14T14:45:13.3024614+01:00",
  "ReadByOwner": "2007-06-17T14:45:13.3024614+02:00",
  "ReadByCustomer": "2020-11-05T14:45:13.3024614+01:00",
  "FirstReadByOwner": "2017-02-09T14:45:13.3024614+01:00",
  "FirstReadByUser": "2005-12-08T14:45:13.3024614+01:00",
  "Activate": "2013-04-19T14:45:13.3024614+02:00",
  "ClosedAt": "1997-12-17T14:45:13.3024614+01:00",
  "RepliedAt": "2005-12-20T14:45:13.3024614+01:00",
  "AlertTimeout": "2022-05-01T14:45:13.3024614+02:00",
  "Deadline": "2023-05-11T14:45:13.3024614+02:00",
  "CreatedBy": null,
  "Author": "omnis",
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
      "PersonId": 858,
      "Mrmrs": "fugiat",
      "Firstname": "Albert",
      "Lastname": "Medhurst",
      "MiddleName": "Bernhard Inc and Sons",
      "Title": "adipisci",
      "Description": "Enhanced eco-centric adapter",
      "Email": "nestor@beahan.biz",
      "FullName": "Joannie Salvatore Stamm DVM",
      "DirectPhone": "(999)944-4309 x58975",
      "FormalName": "Ryan Group",
      "CountryId": 270,
      "ContactId": 361,
      "ContactName": "Kozey-D'Amore",
      "Retired": 886,
      "Rank": 776,
      "ActiveInterests": 744,
      "ContactDepartment": "",
      "ContactCountryId": 754,
      "ContactOrgNr": "1158905",
      "FaxPhone": "272-505-4584",
      "MobilePhone": "(084)167-1459",
      "ContactPhone": "860-679-4866",
      "AssociateName": "Kohler, Gaylord and Moore",
      "AssociateId": 640,
      "UsePersonAddress": false,
      "ContactFax": "perferendis",
      "Kanafname": "hic",
      "Kanalname": "qui",
      "Post1": "odit",
      "Post2": "optio",
      "Post3": "et",
      "EmailName": "jacklyn@funk.uk",
      "ContactFullName": "Mr. Kelsie Dagmar Lynch IV",
      "ActiveErpLinks": 760,
      "TicketPriorityId": 330,
      "SupportLanguageId": 126,
      "SupportAssociateId": 797,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 947
        }
      }
    }
  ],
  "AlertLevel": 498,
  "ConnectId": 23,
  "ReadStatus": "Green",
  "TimeToReply": 383,
  "RealTimeToReply": 214,
  "TimeToClose": 827,
  "RealTimeToClose": 68,
  "TimeSpentInternally": 488,
  "TimeSpentExternally": 234,
  "TimeSpentQueue": 461,
  "RealTimeSpentInternally": 666,
  "RealTimeSpentExternally": 211,
  "RealTimeSpentQueue": 445,
  "TimeSpent": 933,
  "HasAttachment": true,
  "NumReplies": 751,
  "NumMessages": 309,
  "FromAddress": "vel",
  "Messages": [
    {
      "TicketMessageId": 109,
      "CreatedAt": "2016-06-06T14:45:13.3024614+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "molestias",
      "PersonId": 93,
      "PersonFullName": "Nola Monahan",
      "ContactId": 742,
      "ContactName": "Gulgowski-Senger",
      "ContactDepartment": "",
      "NumAttachments": 447,
      "EmailHeader": "rhianna_bauch@kiehn.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "debitis",
      "Sentiment": 666,
      "SentimentConfidence": 715,
      "CreatedBy": 128,
      "ChangedAt": "2012-04-22T14:45:13.3024614+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 946
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 515,
      "Name": "Vandervort LLC",
      "ToolTip": "Rerum aut et.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 363
        }
      }
    },
    {
      "Id": 515,
      "Name": "Vandervort LLC",
      "ToolTip": "Rerum aut et.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 363
        }
      }
    }
  ],
  "Language": "quidem",
  "Sentiment": 391,
  "SentimentConfidence": 672,
  "SuggestedCategoryId": 116,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 102,
  "IconHint": "pariatur",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 968,
  "ExtraFields": {
    "ExtraFields1": "unde",
    "ExtraFields2": "dolore"
  },
  "CustomFields": {
    "CustomFields1": "quis",
    "CustomFields2": "mollitia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 100
    }
  }
}
```