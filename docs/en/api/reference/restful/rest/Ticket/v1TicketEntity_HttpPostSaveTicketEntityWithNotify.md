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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 366,
  "Title": "eaque",
  "CreatedAt": "2002-01-17T12:19:53.9616602+01:00",
  "LastChanged": "2020-11-12T12:19:53.9616602+01:00",
  "ReadByOwner": "1997-04-17T12:19:53.9616602+02:00",
  "ReadByCustomer": "2015-10-13T12:19:53.9616602+02:00",
  "FirstReadByOwner": "2007-04-10T12:19:53.9616602+02:00",
  "FirstReadByUser": "1998-11-15T12:19:53.9616602+01:00",
  "Activate": "1997-11-23T12:19:53.9616602+01:00",
  "ClosedAt": "2009-02-04T12:19:53.9616602+01:00",
  "RepliedAt": "1999-02-26T12:19:53.9616602+01:00",
  "AlertTimeout": "2003-12-31T12:19:53.9616602+01:00",
  "Deadline": "2016-06-07T12:19:53.9616602+02:00",
  "CreatedBy": null,
  "Author": "repellat",
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
      "Position": "et",
      "PersonId": 526,
      "Mrmrs": "animi",
      "Firstname": "Horacio",
      "Lastname": "Gleason",
      "MiddleName": "Walsh, Fay and Dach",
      "Title": "sunt",
      "Description": "Decentralized tertiary initiative",
      "Email": "curt_lindgren@greenfelder.name",
      "FullName": "Prof. Chaz Vince Quigley II",
      "DirectPhone": "(527)540-7943",
      "FormalName": "Torphy LLC",
      "CountryId": 576,
      "ContactId": 42,
      "ContactName": "Russel, Herzog and Trantow",
      "Retired": 379,
      "Rank": 736,
      "ActiveInterests": 70,
      "ContactDepartment": "evolve virtual infomediaries",
      "ContactCountryId": 705,
      "ContactOrgNr": "1673620",
      "FaxPhone": "1-576-404-6843 x5088",
      "MobilePhone": "(035)560-9064",
      "ContactPhone": "296-102-4678 x74182",
      "AssociateName": "Bergnaum, Heathcote and Ortiz",
      "AssociateId": 91,
      "UsePersonAddress": false,
      "ContactFax": "consequatur",
      "Kanafname": "et",
      "Kanalname": "voluptatem",
      "Post1": "rerum",
      "Post2": "autem",
      "Post3": "illum",
      "EmailName": "kristoffer_wunsch@donnellysenger.co.uk",
      "ContactFullName": "Dr. Frederique Nicole Borer I",
      "ActiveErpLinks": 833,
      "TicketPriorityId": 651,
      "SupportLanguageId": 665,
      "SupportAssociateId": 576,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 316,
  "ConnectId": 518,
  "ReadStatus": "Green",
  "TimeToReply": 103,
  "RealTimeToReply": 105,
  "TimeToClose": 470,
  "RealTimeToClose": 373,
  "TimeSpentInternally": 480,
  "TimeSpentExternally": 62,
  "TimeSpentQueue": 764,
  "RealTimeSpentInternally": 938,
  "RealTimeSpentExternally": 611,
  "RealTimeSpentQueue": 975,
  "TimeSpent": 717,
  "HasAttachment": false,
  "NumReplies": 391,
  "NumMessages": 62,
  "FromAddress": "qui",
  "Messages": [
    {
      "TicketMessageId": 306,
      "CreatedAt": "2004-10-05T12:19:53.9616602+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "laborum",
      "PersonId": 84,
      "PersonFullName": "Keeley Jones",
      "ContactId": 36,
      "ContactName": "Oberbrunner, Nienow and Klocko",
      "ContactDepartment": "",
      "NumAttachments": 61,
      "EmailHeader": "lucienne@davis.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ipsum",
      "Sentiment": 447,
      "SentimentConfidence": 115,
      "CreatedBy": 175,
      "ChangedAt": "2016-04-22T12:19:53.9616602+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 648,
      "Name": "Howell, Leannon and Pollich",
      "ToolTip": "Cupiditate ab dolorem ea saepe."
    },
    {
      "Id": 648,
      "Name": "Howell, Leannon and Pollich",
      "ToolTip": "Cupiditate ab dolorem ea saepe."
    }
  ],
  "Language": "omnis",
  "Sentiment": 938,
  "SentimentConfidence": 306,
  "SuggestedCategoryId": 128,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 9,
  "IconHint": "et",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 472,
  "ExtraFields": {
    "ExtraFields1": "soluta",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "perferendis",
    "CustomFields2": "ut"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 782,
  "Title": "qui",
  "CreatedAt": "1998-02-17T12:19:53.9773001+01:00",
  "LastChanged": "1998-01-21T12:19:53.9773001+01:00",
  "ReadByOwner": "2009-09-08T12:19:53.9773001+02:00",
  "ReadByCustomer": "1998-06-30T12:19:53.9773001+02:00",
  "FirstReadByOwner": "2023-09-18T12:19:53.9773001+02:00",
  "FirstReadByUser": "2019-04-25T12:19:53.9773001+02:00",
  "Activate": "2002-11-10T12:19:53.9773001+01:00",
  "ClosedAt": "2022-02-20T12:19:53.9773001+01:00",
  "RepliedAt": "2013-11-29T12:19:53.9773001+01:00",
  "AlertTimeout": "2005-08-27T12:19:53.9773001+02:00",
  "Deadline": "2006-01-11T12:19:53.9773001+01:00",
  "CreatedBy": null,
  "Author": "ipsam",
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
      "Position": "nihil",
      "PersonId": 267,
      "Mrmrs": "sed",
      "Firstname": "Andy",
      "Lastname": "Koelpin",
      "MiddleName": "Murazik LLC",
      "Title": "blanditiis",
      "Description": "Re-contextualized non-volatile policy",
      "Email": "tate_kub@jakubowski.com",
      "FullName": "Prof. Jena Patricia Beer DDS",
      "DirectPhone": "968-954-9066 x7563",
      "FormalName": "Goodwin, Trantow and Reichel",
      "CountryId": 628,
      "ContactId": 345,
      "ContactName": "Altenwerth LLC",
      "Retired": 161,
      "Rank": 486,
      "ActiveInterests": 68,
      "ContactDepartment": "",
      "ContactCountryId": 198,
      "ContactOrgNr": "1879577",
      "FaxPhone": "286.793.5694 x725",
      "MobilePhone": "1-399-388-2677 x902",
      "ContactPhone": "(232)608-7177 x09176",
      "AssociateName": "Friesen-Buckridge",
      "AssociateId": 907,
      "UsePersonAddress": true,
      "ContactFax": "sed",
      "Kanafname": "quas",
      "Kanalname": "commodi",
      "Post1": "delectus",
      "Post2": "iure",
      "Post3": "provident",
      "EmailName": "hillard.wolff@kulasmarvin.name",
      "ContactFullName": "Dr. Audreanne Huels Sr.",
      "ActiveErpLinks": 346,
      "TicketPriorityId": 619,
      "SupportLanguageId": 769,
      "SupportAssociateId": 954,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 832
        }
      }
    }
  ],
  "AlertLevel": 78,
  "ConnectId": 803,
  "ReadStatus": "Green",
  "TimeToReply": 437,
  "RealTimeToReply": 799,
  "TimeToClose": 289,
  "RealTimeToClose": 512,
  "TimeSpentInternally": 360,
  "TimeSpentExternally": 698,
  "TimeSpentQueue": 918,
  "RealTimeSpentInternally": 597,
  "RealTimeSpentExternally": 320,
  "RealTimeSpentQueue": 15,
  "TimeSpent": 15,
  "HasAttachment": false,
  "NumReplies": 802,
  "NumMessages": 72,
  "FromAddress": "et",
  "Messages": [
    {
      "TicketMessageId": 29,
      "CreatedAt": "2015-01-21T12:19:53.9773001+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "nulla",
      "PersonId": 117,
      "PersonFullName": "Miss Cayla Wisozk Sr.",
      "ContactId": 684,
      "ContactName": "Schumm Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 374,
      "EmailHeader": "susie@conn.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "eaque",
      "Sentiment": 602,
      "SentimentConfidence": 808,
      "CreatedBy": 193,
      "ChangedAt": "2000-05-19T12:19:53.9773001+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 430
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 997,
      "Name": "Walter-Gleichner",
      "ToolTip": "Sapiente ratione eum rerum ab.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 585
        }
      }
    },
    {
      "Id": 997,
      "Name": "Walter-Gleichner",
      "ToolTip": "Sapiente ratione eum rerum ab.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 585
        }
      }
    }
  ],
  "Language": "temporibus",
  "Sentiment": 61,
  "SentimentConfidence": 116,
  "SuggestedCategoryId": 601,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 19,
  "IconHint": "natus",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 728,
  "ExtraFields": {
    "ExtraFields1": "veniam",
    "ExtraFields2": "eligendi"
  },
  "CustomFields": {
    "CustomFields1": "at",
    "CustomFields2": "assumenda"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 703
    }
  }
}
```