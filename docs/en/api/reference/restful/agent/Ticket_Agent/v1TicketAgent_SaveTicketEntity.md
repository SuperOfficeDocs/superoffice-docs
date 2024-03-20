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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketId": 178,
  "Title": "sit",
  "CreatedAt": "2006-11-14T12:19:46.3513961+01:00",
  "LastChanged": "2006-03-13T12:19:46.3513961+01:00",
  "ReadByOwner": "2020-06-05T12:19:46.3513961+02:00",
  "ReadByCustomer": "2006-10-24T12:19:46.3513961+02:00",
  "FirstReadByOwner": "2003-02-13T12:19:46.3513961+01:00",
  "FirstReadByUser": "2019-03-26T12:19:46.3513961+01:00",
  "Activate": "2020-04-15T12:19:46.3513961+02:00",
  "ClosedAt": "2009-04-03T12:19:46.3513961+02:00",
  "RepliedAt": "2021-02-12T12:19:46.3513961+01:00",
  "AlertTimeout": "2001-07-27T12:19:46.3513961+02:00",
  "Deadline": "2007-08-03T12:19:46.3513961+02:00",
  "CreatedBy": null,
  "Author": "molestiae",
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
      "PersonId": 264,
      "Mrmrs": "sint",
      "Firstname": "Renee",
      "Lastname": "Hilpert",
      "MiddleName": "Carter-Schaden",
      "Title": "vel",
      "Description": "Progressive bottom-line ability",
      "Email": "hadley@haley.name",
      "FullName": "Ms. Boris Lucinda Kozey DDS",
      "DirectPhone": "570-163-8024 x7905",
      "FormalName": "Powlowski-Towne",
      "CountryId": 584,
      "ContactId": 818,
      "ContactName": "Corkery, Feil and Cronin",
      "Retired": 374,
      "Rank": 926,
      "ActiveInterests": 87,
      "ContactDepartment": "",
      "ContactCountryId": 736,
      "ContactOrgNr": "1915431",
      "FaxPhone": "(757)193-0184",
      "MobilePhone": "1-627-548-4870 x87269",
      "ContactPhone": "(238)320-2323 x155",
      "AssociateName": "Dickens, Kutch and Abernathy",
      "AssociateId": 982,
      "UsePersonAddress": false,
      "ContactFax": "voluptatem",
      "Kanafname": "aut",
      "Kanalname": "rerum",
      "Post1": "molestias",
      "Post2": "omnis",
      "Post3": "ea",
      "EmailName": "samson_douglas@pfeffer.info",
      "ContactFullName": "Dr. Philip Rachael Morar Sr.",
      "ActiveErpLinks": 112,
      "TicketPriorityId": 362,
      "SupportLanguageId": 255,
      "SupportAssociateId": 114,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 823,
  "ConnectId": 169,
  "ReadStatus": "Green",
  "TimeToReply": 124,
  "RealTimeToReply": 659,
  "TimeToClose": 187,
  "RealTimeToClose": 336,
  "TimeSpentInternally": 202,
  "TimeSpentExternally": 671,
  "TimeSpentQueue": 469,
  "RealTimeSpentInternally": 682,
  "RealTimeSpentExternally": 840,
  "RealTimeSpentQueue": 600,
  "TimeSpent": 242,
  "HasAttachment": true,
  "NumReplies": 905,
  "NumMessages": 96,
  "FromAddress": "molestias",
  "Messages": [
    {
      "TicketMessageId": 427,
      "CreatedAt": "2005-05-04T12:19:46.3513961+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "aut",
      "PersonId": 743,
      "PersonFullName": "Mr. Jaida Rutherford",
      "ContactId": 619,
      "ContactName": "Welch-Ortiz",
      "ContactDepartment": "",
      "NumAttachments": 587,
      "EmailHeader": "garnett.bins@brekkelarkin.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "dignissimos",
      "Sentiment": 211,
      "SentimentConfidence": 281,
      "CreatedBy": 652,
      "ChangedAt": "2019-05-20T12:19:46.3513961+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 956,
      "Name": "Beer Group",
      "ToolTip": "Rerum minus."
    },
    {
      "Id": 956,
      "Name": "Beer Group",
      "ToolTip": "Rerum minus."
    }
  ],
  "Language": "perspiciatis",
  "Sentiment": 896,
  "SentimentConfidence": 161,
  "SuggestedCategoryId": 290,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 362,
  "IconHint": "doloribus",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 309,
  "ExtraFields": {
    "ExtraFields1": "itaque",
    "ExtraFields2": "corporis"
  },
  "CustomFields": {
    "CustomFields1": "dignissimos",
    "CustomFields2": "quisquam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 762,
  "Title": "dolores",
  "CreatedAt": "2011-06-04T12:19:46.3670151+02:00",
  "LastChanged": "1998-03-15T12:19:46.3670151+01:00",
  "ReadByOwner": "2022-04-24T12:19:46.3670151+02:00",
  "ReadByCustomer": "2020-11-26T12:19:46.3670151+01:00",
  "FirstReadByOwner": "2019-12-08T12:19:46.3670151+01:00",
  "FirstReadByUser": "2002-09-13T12:19:46.3670151+02:00",
  "Activate": "2024-01-19T12:19:46.3670151+01:00",
  "ClosedAt": "2016-10-07T12:19:46.3670151+02:00",
  "RepliedAt": "2021-05-13T12:19:46.3670151+02:00",
  "AlertTimeout": "2002-03-14T12:19:46.3670151+01:00",
  "Deadline": "2003-07-11T12:19:46.3670151+02:00",
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
      "Position": "dolor",
      "PersonId": 220,
      "Mrmrs": "natus",
      "Firstname": "Adrien",
      "Lastname": "Funk",
      "MiddleName": "Abernathy-Blanda",
      "Title": "deleniti",
      "Description": "Public-key reciprocal product",
      "Email": "javier.weissnat@hansen.us",
      "FullName": "Mrs. Edgar Chad Fahey",
      "DirectPhone": "308.126.6914 x0051",
      "FormalName": "Walter Group",
      "CountryId": 909,
      "ContactId": 839,
      "ContactName": "Dicki-Hauck",
      "Retired": 635,
      "Rank": 349,
      "ActiveInterests": 154,
      "ContactDepartment": "orchestrate synergistic users",
      "ContactCountryId": 827,
      "ContactOrgNr": "966910",
      "FaxPhone": "(609)227-6506 x867",
      "MobilePhone": "1-845-193-7868 x91525",
      "ContactPhone": "(716)643-7119",
      "AssociateName": "Williamson Group",
      "AssociateId": 788,
      "UsePersonAddress": false,
      "ContactFax": "at",
      "Kanafname": "doloremque",
      "Kanalname": "hic",
      "Post1": "aut",
      "Post2": "sint",
      "Post3": "non",
      "EmailName": "danyka_mosciski@kihn.com",
      "ContactFullName": "Waldo Wilderman",
      "ActiveErpLinks": 938,
      "TicketPriorityId": 631,
      "SupportLanguageId": 332,
      "SupportAssociateId": 332,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 760
        }
      }
    }
  ],
  "AlertLevel": 629,
  "ConnectId": 233,
  "ReadStatus": "Green",
  "TimeToReply": 385,
  "RealTimeToReply": 672,
  "TimeToClose": 441,
  "RealTimeToClose": 586,
  "TimeSpentInternally": 187,
  "TimeSpentExternally": 827,
  "TimeSpentQueue": 174,
  "RealTimeSpentInternally": 688,
  "RealTimeSpentExternally": 855,
  "RealTimeSpentQueue": 776,
  "TimeSpent": 9,
  "HasAttachment": false,
  "NumReplies": 228,
  "NumMessages": 641,
  "FromAddress": "tempore",
  "Messages": [
    {
      "TicketMessageId": 29,
      "CreatedAt": "2007-02-17T12:19:46.3670151+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "rerum",
      "PersonId": 457,
      "PersonFullName": "Savion Erdman",
      "ContactId": 86,
      "ContactName": "Gibson Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 578,
      "EmailHeader": "roselyn@reynolds.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ut",
      "Sentiment": 757,
      "SentimentConfidence": 395,
      "CreatedBy": 510,
      "ChangedAt": "2003-08-24T12:19:46.3670151+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 553
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 413,
      "Name": "Lindgren-Klocko",
      "ToolTip": "Maxime vel sunt reprehenderit voluptatum quam ipsam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 785
        }
      }
    },
    {
      "Id": 413,
      "Name": "Lindgren-Klocko",
      "ToolTip": "Maxime vel sunt reprehenderit voluptatum quam ipsam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 785
        }
      }
    }
  ],
  "Language": "fugit",
  "Sentiment": 81,
  "SentimentConfidence": 230,
  "SuggestedCategoryId": 191,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 256,
  "IconHint": "porro",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 826,
  "ExtraFields": {
    "ExtraFields1": "corrupti",
    "ExtraFields2": "cum"
  },
  "CustomFields": {
    "CustomFields1": "provident",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 413
    }
  }
}
```