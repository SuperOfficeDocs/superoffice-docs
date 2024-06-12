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
  "TicketId": 365,
  "Title": "expedita",
  "CreatedAt": "2006-05-25T04:22:27.8338748+02:00",
  "LastChanged": "2021-12-18T04:22:27.8338748+01:00",
  "ReadByOwner": "2012-10-23T04:22:27.8338748+02:00",
  "ReadByCustomer": "2023-10-20T04:22:27.8338748+02:00",
  "FirstReadByOwner": "2009-09-03T04:22:27.8338748+02:00",
  "FirstReadByUser": "2005-12-11T04:22:27.8338748+01:00",
  "Activate": "2005-05-01T04:22:27.8338748+02:00",
  "ClosedAt": "2005-01-18T04:22:27.8338748+01:00",
  "RepliedAt": "1998-03-13T04:22:27.8338748+01:00",
  "AlertTimeout": "2011-12-18T04:22:27.8338748+01:00",
  "Deadline": "1999-12-23T04:22:27.8338748+01:00",
  "CreatedBy": null,
  "Author": "veritatis",
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
      "Position": "natus",
      "PersonId": 280,
      "Mrmrs": "ipsum",
      "Firstname": "Johann",
      "Lastname": "Jewess",
      "MiddleName": "Dare, Quigley and Huel",
      "Title": "omnis",
      "Description": "Persistent cohesive adapter",
      "Email": "delphia@miller.info",
      "FullName": "Breanne Kling II",
      "DirectPhone": "586.756.1217 x788",
      "FormalName": "Ankunding-Morissette",
      "CountryId": 27,
      "ContactId": 962,
      "ContactName": "Bergnaum, Weissnat and Parisian",
      "Retired": 529,
      "Rank": 395,
      "ActiveInterests": 372,
      "ContactDepartment": "",
      "ContactCountryId": 161,
      "ContactOrgNr": "510431",
      "FaxPhone": "560.365.7007",
      "MobilePhone": "(428)308-7957 x5337",
      "ContactPhone": "1-517-079-1186 x292",
      "AssociateName": "Metz, Metz and Conn",
      "AssociateId": 413,
      "UsePersonAddress": true,
      "ContactFax": "eum",
      "Kanafname": "et",
      "Kanalname": "repellat",
      "Post1": "ad",
      "Post2": "ratione",
      "Post3": "dignissimos",
      "EmailName": "lukas_krajcik@hettinger.com",
      "ContactFullName": "Miss Anita Johnson",
      "ActiveErpLinks": 857,
      "TicketPriorityId": 422,
      "SupportLanguageId": 160,
      "SupportAssociateId": 26,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 824,
  "ConnectId": 796,
  "ReadStatus": "Green",
  "TimeToReply": 262,
  "RealTimeToReply": 216,
  "TimeToClose": 843,
  "RealTimeToClose": 237,
  "TimeSpentInternally": 860,
  "TimeSpentExternally": 853,
  "TimeSpentQueue": 756,
  "RealTimeSpentInternally": 700,
  "RealTimeSpentExternally": 55,
  "RealTimeSpentQueue": 221,
  "TimeSpent": 814,
  "HasAttachment": false,
  "NumReplies": 687,
  "NumMessages": 380,
  "FromAddress": "id",
  "Messages": [
    {
      "TicketMessageId": 296,
      "CreatedAt": "2003-03-23T04:22:27.8494982+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "minus",
      "PersonId": 988,
      "PersonFullName": "Camryn Frida Schowalter Sr.",
      "ContactId": 569,
      "ContactName": "Schmidt, Kirlin and Pouros",
      "ContactDepartment": "",
      "NumAttachments": 7,
      "EmailHeader": "ole@glover.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "et",
      "Sentiment": 94,
      "SentimentConfidence": 272,
      "CreatedBy": 75,
      "ChangedAt": "2021-12-30T04:22:27.8494982+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 904,
      "Name": "Schaefer Inc and Sons",
      "ToolTip": "Nihil neque alias."
    },
    {
      "Id": 904,
      "Name": "Schaefer Inc and Sons",
      "ToolTip": "Nihil neque alias."
    }
  ],
  "Language": "debitis",
  "Sentiment": 6,
  "SentimentConfidence": 974,
  "SuggestedCategoryId": 731,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 491,
  "IconHint": "dolore",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 715,
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "explicabo"
  },
  "CustomFields": {
    "CustomFields1": "fuga",
    "CustomFields2": "laudantium"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 669,
  "Title": "voluptatem",
  "CreatedAt": "2023-05-11T04:22:27.8494982+02:00",
  "LastChanged": "2024-01-12T04:22:27.8494982+01:00",
  "ReadByOwner": "2010-09-21T04:22:27.8494982+02:00",
  "ReadByCustomer": "2021-11-05T04:22:27.8494982+01:00",
  "FirstReadByOwner": "2004-11-19T04:22:27.8494982+01:00",
  "FirstReadByUser": "1997-10-11T04:22:27.8494982+02:00",
  "Activate": "2009-07-24T04:22:27.8494982+02:00",
  "ClosedAt": "2004-11-15T04:22:27.8494982+01:00",
  "RepliedAt": "2018-03-29T04:22:27.8494982+02:00",
  "AlertTimeout": "2024-02-26T04:22:27.8494982+01:00",
  "Deadline": "1998-09-27T04:22:27.8494982+02:00",
  "CreatedBy": null,
  "Author": "dolor",
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
      "PersonId": 337,
      "Mrmrs": "quia",
      "Firstname": "Katharina",
      "Lastname": "Kiehn",
      "MiddleName": "Altenwerth, Wunsch and Ebert",
      "Title": "perferendis",
      "Description": "Integrated content-based parallelism",
      "Email": "bart_cruickshank@langosh.com",
      "FullName": "Eulalia Ziemann",
      "DirectPhone": "044.716.8543",
      "FormalName": "Conn, Dickinson and Feest",
      "CountryId": 447,
      "ContactId": 673,
      "ContactName": "Ryan Group",
      "Retired": 523,
      "Rank": 551,
      "ActiveInterests": 637,
      "ContactDepartment": "",
      "ContactCountryId": 673,
      "ContactOrgNr": "872018",
      "FaxPhone": "1-776-729-5289",
      "MobilePhone": "509.990.0998",
      "ContactPhone": "1-552-643-2521 x141",
      "AssociateName": "Baumbach LLC",
      "AssociateId": 383,
      "UsePersonAddress": false,
      "ContactFax": "itaque",
      "Kanafname": "iusto",
      "Kanalname": "sit",
      "Post1": "quis",
      "Post2": "culpa",
      "Post3": "in",
      "EmailName": "rhea_baumbach@kubfeil.us",
      "ContactFullName": "Concepcion Bogan",
      "ActiveErpLinks": 546,
      "TicketPriorityId": 306,
      "SupportLanguageId": 258,
      "SupportAssociateId": 764,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 792
        }
      }
    }
  ],
  "AlertLevel": 746,
  "ConnectId": 498,
  "ReadStatus": "Green",
  "TimeToReply": 618,
  "RealTimeToReply": 420,
  "TimeToClose": 377,
  "RealTimeToClose": 363,
  "TimeSpentInternally": 361,
  "TimeSpentExternally": 110,
  "TimeSpentQueue": 908,
  "RealTimeSpentInternally": 275,
  "RealTimeSpentExternally": 737,
  "RealTimeSpentQueue": 407,
  "TimeSpent": 119,
  "HasAttachment": false,
  "NumReplies": 60,
  "NumMessages": 589,
  "FromAddress": "eius",
  "Messages": [
    {
      "TicketMessageId": 252,
      "CreatedAt": "2000-02-03T04:22:27.8494982+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "in",
      "PersonId": 240,
      "PersonFullName": "Amara O'Keefe",
      "ContactId": 626,
      "ContactName": "Beahan-O'Reilly",
      "ContactDepartment": "",
      "NumAttachments": 815,
      "EmailHeader": "griffin.jenkins@altenwerth.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "aperiam",
      "Sentiment": 720,
      "SentimentConfidence": 729,
      "CreatedBy": 706,
      "ChangedAt": "2006-01-28T04:22:27.8494982+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 865
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 306,
      "Name": "Zboncak-Rodriguez",
      "ToolTip": "Rerum quis et repellat amet.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 407
        }
      }
    },
    {
      "Id": 306,
      "Name": "Zboncak-Rodriguez",
      "ToolTip": "Rerum quis et repellat amet.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 407
        }
      }
    }
  ],
  "Language": "iure",
  "Sentiment": 459,
  "SentimentConfidence": 606,
  "SuggestedCategoryId": 661,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 366,
  "IconHint": "corporis",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 820,
  "ExtraFields": {
    "ExtraFields1": "mollitia",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "eum",
    "CustomFields2": "explicabo"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 925
    }
  }
}
```