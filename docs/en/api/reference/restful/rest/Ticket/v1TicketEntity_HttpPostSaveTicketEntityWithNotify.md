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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Ticket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 583,
  "Title": "saepe",
  "CreatedAt": "1999-03-14T14:19:10.8029779+01:00",
  "LastChanged": "1998-08-19T14:19:10.8029779+02:00",
  "ReadByOwner": "2007-03-19T14:19:10.8029779+01:00",
  "ReadByCustomer": "2017-09-15T14:19:10.8029779+02:00",
  "FirstReadByOwner": "2004-12-30T14:19:10.8029779+01:00",
  "FirstReadByUser": "2004-11-11T14:19:10.8029779+01:00",
  "Activate": "1997-05-02T14:19:10.8029779+02:00",
  "ClosedAt": "2012-03-27T14:19:10.8029779+02:00",
  "RepliedAt": "1997-03-03T14:19:10.8029779+01:00",
  "AlertTimeout": "2014-03-30T14:19:10.8029779+02:00",
  "Deadline": "2002-02-24T14:19:10.8029779+01:00",
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
      "Position": "sint",
      "PersonId": 542,
      "Mrmrs": "quidem",
      "Firstname": "Taurean",
      "Lastname": "Farrell",
      "MiddleName": "Rowe-Turner",
      "Title": "quia",
      "Description": "Function-based cohesive focus group",
      "Email": "myrl.erdman@littlerunolfsson.name",
      "FullName": "Chaya Feeney",
      "DirectPhone": "(370)570-9899",
      "FormalName": "Crist-Hirthe",
      "CountryId": 763,
      "ContactId": 742,
      "ContactName": "Christiansen, Jenkins and Borer",
      "Retired": 940,
      "Rank": 205,
      "ActiveInterests": 344,
      "ContactDepartment": "",
      "ContactCountryId": 129,
      "ContactOrgNr": "180699",
      "FaxPhone": "162-730-7997 x50982",
      "MobilePhone": "(098)733-9892",
      "ContactPhone": "(797)673-3347",
      "AssociateName": "Franecki LLC",
      "AssociateId": 16,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "voluptatem",
      "Kanalname": "aut",
      "Post1": "distinctio",
      "Post2": "minima",
      "Post3": "quis",
      "EmailName": "dayne@sipes.uk",
      "ContactFullName": "Malvina Cassidy Lemke V",
      "ActiveErpLinks": 375,
      "TicketPriorityId": 442,
      "SupportLanguageId": 711,
      "SupportAssociateId": 655,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 324,
  "ConnectId": 966,
  "ReadStatus": "Green",
  "TimeToReply": 64,
  "RealTimeToReply": 889,
  "TimeToClose": 255,
  "RealTimeToClose": 934,
  "TimeSpentInternally": 870,
  "TimeSpentExternally": 728,
  "TimeSpentQueue": 413,
  "RealTimeSpentInternally": 317,
  "RealTimeSpentExternally": 573,
  "RealTimeSpentQueue": 255,
  "HasAttachment": false,
  "NumReplies": 529,
  "NumMessages": 884,
  "FromAddress": "nihil",
  "Messages": [
    {
      "TicketMessageId": 871,
      "CreatedAt": "2010-07-07T14:19:10.8029779+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "est",
      "PersonId": 661,
      "PersonFullName": "Hollie Gibson",
      "ContactId": 638,
      "ContactName": "Hermann-Blanda",
      "ContactDepartment": "",
      "NumAttachments": 959,
      "EmailHeader": "april.frami@osinski.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "explicabo",
      "Sentiment": 63,
      "SentimentConfidence": 10,
      "CreatedBy": 907,
      "ChangedAt": "2021-09-30T14:19:10.8029779+02:00"
    }
  ],
  "Tags": [
    {
      "Id": 234,
      "Name": "Hoppe, Lakin and Feil",
      "ToolTip": "Ut esse quasi incidunt."
    },
    {
      "Id": 234,
      "Name": "Hoppe, Lakin and Feil",
      "ToolTip": "Ut esse quasi incidunt."
    }
  ],
  "Language": "eveniet",
  "Sentiment": 243,
  "SentimentConfidence": 171,
  "SuggestedCategoryId": 543,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 86,
  "IconHint": "in",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "voluptate",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "illo",
    "CustomFields2": "distinctio"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 778,
  "Title": "numquam",
  "CreatedAt": "1999-07-23T14:19:10.8186049+02:00",
  "LastChanged": "2003-12-08T14:19:10.8186049+01:00",
  "ReadByOwner": "2000-08-31T14:19:10.8186049+02:00",
  "ReadByCustomer": "2017-05-09T14:19:10.8186049+02:00",
  "FirstReadByOwner": "1997-10-23T14:19:10.8186049+02:00",
  "FirstReadByUser": "2006-05-13T14:19:10.8186049+02:00",
  "Activate": "2017-01-13T14:19:10.8186049+01:00",
  "ClosedAt": "2011-06-28T14:19:10.8186049+02:00",
  "RepliedAt": "2021-06-16T14:19:10.8186049+02:00",
  "AlertTimeout": "2007-06-06T14:19:10.8186049+02:00",
  "Deadline": "2009-11-30T14:19:10.8186049+01:00",
  "CreatedBy": null,
  "Author": "doloribus",
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
      "Position": "quod",
      "PersonId": 317,
      "Mrmrs": "atque",
      "Firstname": "Clementine",
      "Lastname": "Reichel",
      "MiddleName": "Wehner, Davis and Lueilwitz",
      "Title": "nostrum",
      "Description": "Down-sized incremental pricing structure",
      "Email": "lamont@jakubowski.com",
      "FullName": "Ryan Koepp",
      "DirectPhone": "496-263-7494 x414",
      "FormalName": "Lemke LLC",
      "CountryId": 874,
      "ContactId": 899,
      "ContactName": "Schamberger, Franecki and Lebsack",
      "Retired": 883,
      "Rank": 52,
      "ActiveInterests": 858,
      "ContactDepartment": "",
      "ContactCountryId": 310,
      "ContactOrgNr": "535875",
      "FaxPhone": "645-389-9689",
      "MobilePhone": "(816)640-0453 x78987",
      "ContactPhone": "(527)379-8279 x07398",
      "AssociateName": "Heller, Brekke and Dickens",
      "AssociateId": 703,
      "UsePersonAddress": false,
      "ContactFax": "repellat",
      "Kanafname": "aspernatur",
      "Kanalname": "sit",
      "Post1": "inventore",
      "Post2": "veniam",
      "Post3": "quia",
      "EmailName": "jerrod@lakinhuel.com",
      "ContactFullName": "Scotty Kiley Hilll IV",
      "ActiveErpLinks": 303,
      "TicketPriorityId": 680,
      "SupportLanguageId": 494,
      "SupportAssociateId": 864,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 827
        }
      }
    }
  ],
  "AlertLevel": 780,
  "ConnectId": 175,
  "ReadStatus": "Green",
  "TimeToReply": 812,
  "RealTimeToReply": 222,
  "TimeToClose": 8,
  "RealTimeToClose": 723,
  "TimeSpentInternally": 109,
  "TimeSpentExternally": 849,
  "TimeSpentQueue": 270,
  "RealTimeSpentInternally": 869,
  "RealTimeSpentExternally": 414,
  "RealTimeSpentQueue": 394,
  "HasAttachment": false,
  "NumReplies": 929,
  "NumMessages": 417,
  "FromAddress": "in",
  "Messages": [
    {
      "TicketMessageId": 714,
      "CreatedAt": "2010-08-28T14:19:10.8186049+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "reprehenderit",
      "PersonId": 537,
      "PersonFullName": "Mrs. Name Jake Kshlerin",
      "ContactId": 795,
      "ContactName": "Prohaska Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 144,
      "EmailHeader": "tyreek_beer@marvin.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "voluptatum",
      "Sentiment": 377,
      "SentimentConfidence": 106,
      "CreatedBy": 832,
      "ChangedAt": "2010-04-19T14:19:10.8186049+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 831
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 204,
      "Name": "Zulauf, Hilll and Auer",
      "ToolTip": "Eaque sed consequatur asperiores molestias tempore illum.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 257
        }
      }
    },
    {
      "Id": 204,
      "Name": "Zulauf, Hilll and Auer",
      "ToolTip": "Eaque sed consequatur asperiores molestias tempore illum.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 257
        }
      }
    }
  ],
  "Language": "dolores",
  "Sentiment": 145,
  "SentimentConfidence": 883,
  "SuggestedCategoryId": 132,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 195,
  "IconHint": "nam",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "sapiente",
    "ExtraFields2": "beatae"
  },
  "CustomFields": {
    "CustomFields1": "in",
    "CustomFields2": "doloribus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 6
    }
  }
}
```