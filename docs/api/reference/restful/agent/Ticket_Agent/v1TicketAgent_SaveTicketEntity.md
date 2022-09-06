---
title: POST Agents/Ticket/SaveTicketEntity
uid: v1TicketAgent_SaveTicketEntity
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
| TicketId | int32 | The primary key (auto-incremented) |
| Title | string | The title of the ticket. |
| CreatedAt | date-time | When the ticket was created. |
| LastChanged | date-time | The last time the ticket was modified. |
| ReadByOwner | date-time | The datetime for when the ticket last was read by the owner. |
| ReadByCustomer | date-time | The datetime for when the ticket was read by the customer. |
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

## Response

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
POST /api/v1/Agents/Ticket/SaveTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 388,
  "Title": "harum",
  "CreatedAt": "2016-06-22T11:10:28.2016935+02:00",
  "LastChanged": "1996-04-16T11:10:28.2016935+02:00",
  "ReadByOwner": "2001-08-17T11:10:28.2016935+02:00",
  "ReadByCustomer": "2017-12-25T11:10:28.2016935+01:00",
  "FirstReadByUser": "2016-05-24T11:10:28.2016935+02:00",
  "Activate": "2001-08-17T11:10:28.2016935+02:00",
  "ClosedAt": "2019-12-09T11:10:28.2016935+01:00",
  "RepliedAt": "2004-08-20T11:10:28.2016935+02:00",
  "AlertTimeout": "1997-09-14T11:10:28.2016935+02:00",
  "Deadline": "1999-06-28T11:10:28.2016935+02:00",
  "CreatedBy": null,
  "Author": "consequuntur",
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
      "Position": "quae",
      "PersonId": 504,
      "Mrmrs": "harum",
      "Firstname": "Brain",
      "Lastname": "Boehm",
      "MiddleName": "Ullrich-Kuhic",
      "Title": "ratione",
      "Description": "Polarised local help-desk",
      "Email": "janice.predovic@jewess.us",
      "FullName": "Mr. Hattie Keeling",
      "DirectPhone": "981.002.7898",
      "FormalName": "Lesch-Bednar",
      "CountryId": 439,
      "ContactId": 66,
      "ContactName": "Deckow-Kohler",
      "Retired": 930,
      "Rank": 340,
      "ActiveInterests": 979,
      "ContactDepartment": "",
      "ContactCountryId": 933,
      "ContactOrgNr": "996101",
      "FaxPhone": "023-117-2727 x95587",
      "MobilePhone": "1-782-209-1107 x3540",
      "ContactPhone": "1-531-004-8863",
      "AssociateName": "Walker-Murray",
      "AssociateId": 559,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "ullam",
      "Kanalname": "nihil",
      "Post1": "tempora",
      "Post2": "tenetur",
      "Post3": "rem",
      "EmailName": "lucius@kirlin.name",
      "ContactFullName": "Hilbert Tremblay",
      "ActiveErpLinks": 361,
      "TicketPriorityId": 46,
      "SupportLanguageId": 38,
      "SupportAssociateId": 761,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 359,
  "ConnectId": 968,
  "ReadStatus": "Green",
  "TimeToReply": 705,
  "RealTimeToReply": 236,
  "TimeToClose": 897,
  "RealTimeToClose": 804,
  "TimeSpentInternally": 80,
  "TimeSpentExternally": 364,
  "TimeSpentQueue": 302,
  "RealTimeSpentInternally": 223,
  "RealTimeSpentExternally": 526,
  "RealTimeSpentQueue": 533,
  "HasAttachment": false,
  "NumReplies": 143,
  "NumMessages": 99,
  "FromAddress": "debitis",
  "Messages": [
    {
      "TicketMessageId": 825,
      "CreatedAt": "2004-11-11T11:10:28.2056935+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "doloribus",
      "PersonId": 591,
      "PersonFullName": "Efrain Turner",
      "ContactId": 976,
      "ContactName": "Effertz-Kerluke",
      "ContactDepartment": "envisioneer robust initiatives",
      "NumAttachments": 449,
      "EmailHeader": "maud.kemmer@johns.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "minus",
      "Sentiment": 609,
      "SentimentConfidence": 557,
      "CreatedBy": 517
    }
  ],
  "Tags": [
    {
      "Id": 948,
      "Name": "Torphy, Simonis and Braun",
      "ToolTip": "Quae aut."
    },
    {
      "Id": 948,
      "Name": "Torphy, Simonis and Braun",
      "ToolTip": "Quae aut."
    }
  ],
  "Language": "ex",
  "Sentiment": 522,
  "SentimentConfidence": 544,
  "SuggestedCategoryId": 432,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 726,
  "IconHint": "saepe",
  "ExtraFields": {
    "ExtraFields1": "dignissimos",
    "ExtraFields2": "ipsum"
  },
  "CustomFields": {
    "CustomFields1": "sint",
    "CustomFields2": "assumenda"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 553,
  "Title": "perferendis",
  "CreatedAt": "2020-01-06T11:10:28.2126935+01:00",
  "LastChanged": "2019-04-13T11:10:28.2126935+02:00",
  "ReadByOwner": "2019-03-29T11:10:28.2126935+01:00",
  "ReadByCustomer": "1996-10-23T11:10:28.2126935+02:00",
  "FirstReadByUser": "2018-06-03T11:10:28.2126935+02:00",
  "Activate": "2001-01-01T11:10:28.2126935+01:00",
  "ClosedAt": "1999-06-03T11:10:28.2126935+02:00",
  "RepliedAt": "2019-11-07T11:10:28.2126935+01:00",
  "AlertTimeout": "1998-09-02T11:10:28.2126935+02:00",
  "Deadline": "1997-07-26T11:10:28.2126935+02:00",
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
      "Position": "velit",
      "PersonId": 693,
      "Mrmrs": "deleniti",
      "Firstname": "Edna",
      "Lastname": "Strosin",
      "MiddleName": "Botsford LLC",
      "Title": "illum",
      "Description": "Team-oriented assymetric budgetary management",
      "Email": "pietro@wolf.co.uk",
      "FullName": "Rylan Bruen",
      "DirectPhone": "755.244.4227 x2125",
      "FormalName": "Gerlach Inc and Sons",
      "CountryId": 239,
      "ContactId": 803,
      "ContactName": "Mosciski-Schumm",
      "Retired": 248,
      "Rank": 550,
      "ActiveInterests": 836,
      "ContactDepartment": "",
      "ContactCountryId": 975,
      "ContactOrgNr": "1540626",
      "FaxPhone": "1-742-053-1808 x80268",
      "MobilePhone": "306-354-9536 x55660",
      "ContactPhone": "(789)191-4091",
      "AssociateName": "Gulgowski-Thiel",
      "AssociateId": 990,
      "UsePersonAddress": false,
      "ContactFax": "officia",
      "Kanafname": "sed",
      "Kanalname": "quam",
      "Post1": "voluptatem",
      "Post2": "vel",
      "Post3": "unde",
      "EmailName": "myrl@sipes.uk",
      "ContactFullName": "Cathy Stanton",
      "ActiveErpLinks": 354,
      "TicketPriorityId": 780,
      "SupportLanguageId": 5,
      "SupportAssociateId": 794,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 358
        }
      }
    }
  ],
  "AlertLevel": 875,
  "ConnectId": 440,
  "ReadStatus": "Green",
  "TimeToReply": 204,
  "RealTimeToReply": 315,
  "TimeToClose": 18,
  "RealTimeToClose": 44,
  "TimeSpentInternally": 631,
  "TimeSpentExternally": 316,
  "TimeSpentQueue": 462,
  "RealTimeSpentInternally": 275,
  "RealTimeSpentExternally": 533,
  "RealTimeSpentQueue": 23,
  "HasAttachment": true,
  "NumReplies": 666,
  "NumMessages": 111,
  "FromAddress": "ut",
  "Messages": [
    {
      "TicketMessageId": 472,
      "CreatedAt": "2012-12-21T11:10:28.215693+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "est",
      "PersonId": 19,
      "PersonFullName": "Maryjane Christiansen",
      "ContactId": 434,
      "ContactName": "Lebsack-Pollich",
      "ContactDepartment": "disintermediate value-added interfaces",
      "NumAttachments": 760,
      "EmailHeader": "aliya@kassulkesteuber.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "nisi",
      "Sentiment": 610,
      "SentimentConfidence": 508,
      "CreatedBy": 746,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 630
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 699,
      "Name": "Klocko, Parker and Hegmann",
      "ToolTip": "Dolore minima.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 794
        }
      }
    },
    {
      "Id": 699,
      "Name": "Klocko, Parker and Hegmann",
      "ToolTip": "Dolore minima.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 794
        }
      }
    }
  ],
  "Language": "voluptatem",
  "Sentiment": 191,
  "SentimentConfidence": 329,
  "SuggestedCategoryId": 761,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 437,
  "IconHint": "aliquid",
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "voluptas"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 19
    }
  }
}
```
