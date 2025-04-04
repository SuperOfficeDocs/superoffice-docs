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
  "TicketId": 542,
  "Title": "facere",
  "CreatedAt": "2013-06-28T13:14:01.4256794+02:00",
  "LastChanged": "2024-07-28T13:14:01.4256794+02:00",
  "ReadByOwner": "2024-02-28T13:14:01.4256794+01:00",
  "ReadByCustomer": "2014-11-20T13:14:01.4256794+01:00",
  "FirstReadByOwner": "1997-12-26T13:14:01.4256794+01:00",
  "FirstReadByUser": "2015-06-19T13:14:01.4256794+02:00",
  "Activate": "2004-03-14T13:14:01.4256794+01:00",
  "ClosedAt": "2025-01-20T13:14:01.4256794+01:00",
  "RepliedAt": "2002-01-15T13:14:01.4256794+01:00",
  "AlertTimeout": "2017-10-21T13:14:01.4256794+02:00",
  "Deadline": "2011-02-24T13:14:01.4256794+01:00",
  "CreatedBy": null,
  "Author": "quia",
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
      "Position": "magni",
      "PersonId": 617,
      "Mrmrs": "praesentium",
      "Firstname": "Elsa",
      "Lastname": "Hoeger",
      "MiddleName": "Dicki-Kuphal",
      "Title": "totam",
      "Description": "Progressive systemic monitoring",
      "Email": "zachariah@kuphal.uk",
      "FullName": "Prof. Dayne Wiegand",
      "DirectPhone": "1-733-191-5650 x91384",
      "FormalName": "Gerhold-Padberg",
      "CountryId": 277,
      "ContactId": 850,
      "ContactName": "Bergnaum Inc and Sons",
      "Retired": 66,
      "Rank": 685,
      "ActiveInterests": 905,
      "ContactDepartment": "",
      "ContactCountryId": 526,
      "ContactOrgNr": "1202792",
      "FaxPhone": "1-920-300-9226",
      "MobilePhone": "1-956-206-4639 x32267",
      "ContactPhone": "(926)510-3573 x640",
      "AssociateName": "Hamill, Farrell and Willms",
      "AssociateId": 705,
      "UsePersonAddress": false,
      "ContactFax": "ut",
      "Kanafname": "ea",
      "Kanalname": "aspernatur",
      "Post1": "explicabo",
      "Post2": "itaque",
      "Post3": "cupiditate",
      "EmailName": "ashley@smithpaucek.uk",
      "ContactFullName": "Mr. Terence Little",
      "ActiveErpLinks": 470,
      "TicketPriorityId": 425,
      "SupportLanguageId": 67,
      "SupportAssociateId": 538,
      "CategoryName": "VIP Customer",
      "PersonNumber": "689463"
    }
  ],
  "AlertLevel": 474,
  "ConnectId": 933,
  "ReadStatus": "Green",
  "TimeToReply": 116,
  "RealTimeToReply": 570,
  "TimeToClose": 849,
  "RealTimeToClose": 228,
  "TimeSpentInternally": 448,
  "TimeSpentExternally": 807,
  "TimeSpentQueue": 480,
  "RealTimeSpentInternally": 564,
  "RealTimeSpentExternally": 234,
  "RealTimeSpentQueue": 131,
  "TimeSpent": 185,
  "HasAttachment": false,
  "NumReplies": 464,
  "NumMessages": 438,
  "FromAddress": "omnis",
  "Messages": [
    {
      "TicketMessageId": 851,
      "CreatedAt": "2006-08-21T13:14:01.4256794+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "est",
      "PersonId": 146,
      "PersonFullName": "Keven Wyman IV",
      "ContactId": 655,
      "ContactName": "Ferry LLC",
      "ContactDepartment": "",
      "NumAttachments": 630,
      "EmailHeader": "jacey_bartoletti@yost.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "reiciendis",
      "Sentiment": 357,
      "SentimentConfidence": 802,
      "CreatedBy": 942,
      "ChangedAt": "1999-05-30T13:14:01.4256794+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 19,
      "Name": "Beier, Kuphal and Raynor",
      "ToolTip": "Excepturi iure ipsa unde."
    },
    {
      "Id": 19,
      "Name": "Beier, Kuphal and Raynor",
      "ToolTip": "Excepturi iure ipsa unde."
    }
  ],
  "Language": "ab",
  "Sentiment": 918,
  "SentimentConfidence": 551,
  "SuggestedCategoryId": 346,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 940,
  "IconHint": "consequatur",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 501,
  "ExtraFields": {
    "ExtraFields1": "possimus",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "autem"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 728,
  "Title": "porro",
  "CreatedAt": "2023-10-01T13:14:01.4413053+02:00",
  "LastChanged": "1999-05-19T13:14:01.4413053+02:00",
  "ReadByOwner": "2015-01-17T13:14:01.4413053+01:00",
  "ReadByCustomer": "2011-06-29T13:14:01.4413053+02:00",
  "FirstReadByOwner": "2004-05-03T13:14:01.4413053+02:00",
  "FirstReadByUser": "2002-08-28T13:14:01.4413053+02:00",
  "Activate": "2003-11-25T13:14:01.4413053+01:00",
  "ClosedAt": "2010-07-15T13:14:01.4413053+02:00",
  "RepliedAt": "2008-04-08T13:14:01.4413053+02:00",
  "AlertTimeout": "2003-09-28T13:14:01.4413053+02:00",
  "Deadline": "2005-04-28T13:14:01.4413053+02:00",
  "CreatedBy": null,
  "Author": "fugiat",
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
      "Position": "eos",
      "PersonId": 967,
      "Mrmrs": "sit",
      "Firstname": "Cody",
      "Lastname": "Zboncak",
      "MiddleName": "Greenholt-Kub",
      "Title": "qui",
      "Description": "Polarised mobile challenge",
      "Email": "efren.feeney@tremblay.name",
      "FullName": "Rosemary Marquardt",
      "DirectPhone": "(792)245-0252 x6110",
      "FormalName": "Wilderman, Kiehn and Rogahn",
      "CountryId": 924,
      "ContactId": 25,
      "ContactName": "Kuhlman LLC",
      "Retired": 585,
      "Rank": 511,
      "ActiveInterests": 861,
      "ContactDepartment": "",
      "ContactCountryId": 432,
      "ContactOrgNr": "1235710",
      "FaxPhone": "257-381-9198 x9974",
      "MobilePhone": "249.961.3951 x42189",
      "ContactPhone": "1-770-144-9184",
      "AssociateName": "Larson, Towne and Berge",
      "AssociateId": 986,
      "UsePersonAddress": true,
      "ContactFax": "qui",
      "Kanafname": "reprehenderit",
      "Kanalname": "nam",
      "Post1": "consequuntur",
      "Post2": "quia",
      "Post3": "molestias",
      "EmailName": "yolanda@jewess.ca",
      "ContactFullName": "Mr. Edythe Considine",
      "ActiveErpLinks": 280,
      "TicketPriorityId": 498,
      "SupportLanguageId": 665,
      "SupportAssociateId": 97,
      "CategoryName": "VIP Customer",
      "PersonNumber": "353597",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 557
        }
      }
    }
  ],
  "AlertLevel": 185,
  "ConnectId": 664,
  "ReadStatus": "Green",
  "TimeToReply": 183,
  "RealTimeToReply": 761,
  "TimeToClose": 110,
  "RealTimeToClose": 692,
  "TimeSpentInternally": 295,
  "TimeSpentExternally": 859,
  "TimeSpentQueue": 242,
  "RealTimeSpentInternally": 301,
  "RealTimeSpentExternally": 877,
  "RealTimeSpentQueue": 200,
  "TimeSpent": 88,
  "HasAttachment": true,
  "NumReplies": 564,
  "NumMessages": 624,
  "FromAddress": "magnam",
  "Messages": [
    {
      "TicketMessageId": 565,
      "CreatedAt": "2021-09-07T13:14:01.4413053+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "ad",
      "PersonId": 281,
      "PersonFullName": "Mr. Hallie Ruthe Schiller",
      "ContactId": 665,
      "ContactName": "Carroll-Nikolaus",
      "ContactDepartment": "",
      "NumAttachments": 330,
      "EmailHeader": "mackenzie@connbode.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "fuga",
      "Sentiment": 130,
      "SentimentConfidence": 881,
      "CreatedBy": 1002,
      "ChangedAt": "2012-12-24T13:14:01.4413053+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 449
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 321,
      "Name": "Bergnaum-Graham",
      "ToolTip": "Autem dolorem quia.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 11
        }
      }
    },
    {
      "Id": 321,
      "Name": "Bergnaum-Graham",
      "ToolTip": "Autem dolorem quia.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 11
        }
      }
    }
  ],
  "Language": "facere",
  "Sentiment": 583,
  "SentimentConfidence": 212,
  "SuggestedCategoryId": 985,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 674,
  "IconHint": "nulla",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 554,
  "ExtraFields": {
    "ExtraFields1": "consequuntur",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 611
    }
  }
}
```