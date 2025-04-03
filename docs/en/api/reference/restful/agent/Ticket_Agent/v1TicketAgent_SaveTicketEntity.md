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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 487,
  "Title": "nobis",
  "CreatedAt": "2019-04-20T14:28:22.5553721+02:00",
  "LastChanged": "2019-12-15T14:28:22.5553721+01:00",
  "ReadByOwner": "2010-12-04T14:28:22.5553721+01:00",
  "ReadByCustomer": "2006-06-24T14:28:22.5553721+02:00",
  "FirstReadByOwner": "2023-10-07T14:28:22.5553721+02:00",
  "FirstReadByUser": "2003-07-01T14:28:22.5553721+02:00",
  "Activate": "2007-12-22T14:28:22.5553721+01:00",
  "ClosedAt": "2024-05-20T14:28:22.5553721+02:00",
  "RepliedAt": "2003-06-02T14:28:22.5553721+02:00",
  "AlertTimeout": "1999-09-07T14:28:22.5553721+02:00",
  "Deadline": "2001-01-24T14:28:22.5553721+01:00",
  "CreatedBy": null,
  "Author": "ut",
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
      "Position": "qui",
      "PersonId": 358,
      "Mrmrs": "repudiandae",
      "Firstname": "Isadore",
      "Lastname": "Witting",
      "MiddleName": "Kemmer, Hilpert and Dare",
      "Title": "non",
      "Description": "Diverse tertiary utilisation",
      "Email": "myrtis@simoniscruickshank.co.uk",
      "FullName": "Prof. Lee Dylan D'Amore DVM",
      "DirectPhone": "883-404-8409 x623",
      "FormalName": "Renner LLC",
      "CountryId": 189,
      "ContactId": 853,
      "ContactName": "Considine, Harris and Schinner",
      "Retired": 262,
      "Rank": 383,
      "ActiveInterests": 551,
      "ContactDepartment": "",
      "ContactCountryId": 13,
      "ContactOrgNr": "1003086",
      "FaxPhone": "657-936-4685",
      "MobilePhone": "(008)242-6341",
      "ContactPhone": "(182)463-2114 x63875",
      "AssociateName": "Renner-Franecki",
      "AssociateId": 383,
      "UsePersonAddress": false,
      "ContactFax": "sit",
      "Kanafname": "voluptatem",
      "Kanalname": "recusandae",
      "Post1": "fuga",
      "Post2": "molestias",
      "Post3": "quisquam",
      "EmailName": "raina.predovic@rodriguezfadel.uk",
      "ContactFullName": "Jessie Volkman",
      "ActiveErpLinks": 892,
      "TicketPriorityId": 314,
      "SupportLanguageId": 709,
      "SupportAssociateId": 561,
      "CategoryName": "VIP Customer",
      "PersonNumber": "768690"
    }
  ],
  "AlertLevel": 9,
  "ConnectId": 729,
  "ReadStatus": "Green",
  "TimeToReply": 109,
  "RealTimeToReply": 119,
  "TimeToClose": 35,
  "RealTimeToClose": 242,
  "TimeSpentInternally": 76,
  "TimeSpentExternally": 545,
  "TimeSpentQueue": 711,
  "RealTimeSpentInternally": 26,
  "RealTimeSpentExternally": 237,
  "RealTimeSpentQueue": 240,
  "TimeSpent": 998,
  "HasAttachment": true,
  "NumReplies": 722,
  "NumMessages": 2,
  "FromAddress": "architecto",
  "Messages": [
    {
      "TicketMessageId": 744,
      "CreatedAt": "2001-11-18T14:28:22.5553721+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "dolores",
      "PersonId": 813,
      "PersonFullName": "Alexys Mayer",
      "ContactId": 588,
      "ContactName": "Graham LLC",
      "ContactDepartment": "",
      "NumAttachments": 666,
      "EmailHeader": "martina@cruickshank.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "id",
      "Sentiment": 80,
      "SentimentConfidence": 729,
      "CreatedBy": 965,
      "ChangedAt": "2009-10-06T14:28:22.5553721+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 22,
      "Name": "Kuhic LLC",
      "ToolTip": "Numquam vero."
    },
    {
      "Id": 22,
      "Name": "Kuhic LLC",
      "ToolTip": "Numquam vero."
    }
  ],
  "Language": "pariatur",
  "Sentiment": 519,
  "SentimentConfidence": 274,
  "SuggestedCategoryId": 917,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 563,
  "IconHint": "cum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 353,
  "ExtraFields": {
    "ExtraFields1": "exercitationem",
    "ExtraFields2": "reiciendis"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "ea"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 658,
  "Title": "ad",
  "CreatedAt": "2008-07-14T14:28:22.5553721+02:00",
  "LastChanged": "2014-05-15T14:28:22.5553721+02:00",
  "ReadByOwner": "2009-05-14T14:28:22.5553721+02:00",
  "ReadByCustomer": "2023-08-30T14:28:22.5553721+02:00",
  "FirstReadByOwner": "2004-10-11T14:28:22.5553721+02:00",
  "FirstReadByUser": "2008-12-02T14:28:22.5553721+01:00",
  "Activate": "2000-11-23T14:28:22.5553721+01:00",
  "ClosedAt": "2021-05-07T14:28:22.5553721+02:00",
  "RepliedAt": "2019-02-24T14:28:22.5553721+01:00",
  "AlertTimeout": "2016-01-19T14:28:22.5553721+01:00",
  "Deadline": "2001-10-27T14:28:22.5553721+02:00",
  "CreatedBy": null,
  "Author": "hic",
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
      "Position": "qui",
      "PersonId": 142,
      "Mrmrs": "provident",
      "Firstname": "Kaelyn",
      "Lastname": "Hegmann",
      "MiddleName": "Goldner LLC",
      "Title": "ab",
      "Description": "Mandatory fault-tolerant intranet",
      "Email": "berneice_bahringer@conn.name",
      "FullName": "Zachariah Koelpin",
      "DirectPhone": "1-192-181-6575 x45626",
      "FormalName": "Deckow-Huel",
      "CountryId": 214,
      "ContactId": 277,
      "ContactName": "Howell LLC",
      "Retired": 907,
      "Rank": 17,
      "ActiveInterests": 997,
      "ContactDepartment": "",
      "ContactCountryId": 17,
      "ContactOrgNr": "991058",
      "FaxPhone": "1-924-388-3446",
      "MobilePhone": "1-875-230-4841 x421",
      "ContactPhone": "1-661-715-0501 x1458",
      "AssociateName": "Koelpin, Cremin and Lueilwitz",
      "AssociateId": 657,
      "UsePersonAddress": false,
      "ContactFax": "minima",
      "Kanafname": "vero",
      "Kanalname": "sit",
      "Post1": "non",
      "Post2": "numquam",
      "Post3": "ab",
      "EmailName": "layne.ledner@erdmanmiller.co.uk",
      "ContactFullName": "Dr. Ahmad Harris",
      "ActiveErpLinks": 619,
      "TicketPriorityId": 513,
      "SupportLanguageId": 553,
      "SupportAssociateId": 511,
      "CategoryName": "VIP Customer",
      "PersonNumber": "975272",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 803
        }
      }
    }
  ],
  "AlertLevel": 263,
  "ConnectId": 20,
  "ReadStatus": "Green",
  "TimeToReply": 626,
  "RealTimeToReply": 136,
  "TimeToClose": 720,
  "RealTimeToClose": 877,
  "TimeSpentInternally": 541,
  "TimeSpentExternally": 903,
  "TimeSpentQueue": 571,
  "RealTimeSpentInternally": 310,
  "RealTimeSpentExternally": 927,
  "RealTimeSpentQueue": 530,
  "TimeSpent": 747,
  "HasAttachment": true,
  "NumReplies": 434,
  "NumMessages": 444,
  "FromAddress": "et",
  "Messages": [
    {
      "TicketMessageId": 99,
      "CreatedAt": "2018-05-31T14:28:22.5553721+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "dignissimos",
      "PersonId": 794,
      "PersonFullName": "Mallie Herzog",
      "ContactId": 367,
      "ContactName": "Collins-Donnelly",
      "ContactDepartment": "syndicate intuitive users",
      "NumAttachments": 536,
      "EmailHeader": "gretchen_hermiston@beckermarquardt.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "similique",
      "Sentiment": 241,
      "SentimentConfidence": 931,
      "CreatedBy": 634,
      "ChangedAt": "2017-08-26T14:28:22.5553721+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 269
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 316,
      "Name": "Lueilwitz-Predovic",
      "ToolTip": "Et ut deserunt unde nam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 391
        }
      }
    },
    {
      "Id": 316,
      "Name": "Lueilwitz-Predovic",
      "ToolTip": "Et ut deserunt unde nam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 391
        }
      }
    }
  ],
  "Language": "voluptatem",
  "Sentiment": 348,
  "SentimentConfidence": 336,
  "SuggestedCategoryId": 861,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 10,
  "IconHint": "quia",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 801,
  "ExtraFields": {
    "ExtraFields1": "ducimus",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "sequi",
    "CustomFields2": "doloribus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 208
    }
  }
}
```