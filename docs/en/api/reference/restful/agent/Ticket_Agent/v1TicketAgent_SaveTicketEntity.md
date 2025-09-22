---
title: POST Agents/Ticket/SaveTicketEntity
uid: v1TicketAgent_SaveTicketEntity
generated: true
content_type: reference
---

# POST Agents/Ticket/SaveTicketEntity

```http
POST /api/v1/Agents/Ticket/SaveTicketEntity
```

Updates the existing TicketEntity or creates a new TicketEntity if the id parameter is 0.


Does not notify users of save.







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

## Request Body: ticketEntity 

The TicketEntity that is saved 

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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketId": 154,
  "Title": "eos",
  "CreatedAt": "2018-02-24T11:24:48.7032506+01:00",
  "LastChanged": "2003-04-02T11:24:48.7032506+02:00",
  "ReadByOwner": "2001-02-15T11:24:48.7032506+01:00",
  "ReadByCustomer": "2025-06-03T11:24:48.7032506+02:00",
  "FirstReadByOwner": "2012-01-25T11:24:48.7032506+01:00",
  "FirstReadByUser": "2016-06-10T11:24:48.7032506+02:00",
  "Activate": "2001-06-26T11:24:48.7032506+02:00",
  "ClosedAt": "2025-01-27T11:24:48.7032506+01:00",
  "RepliedAt": "2017-10-09T11:24:48.7032506+02:00",
  "AlertTimeout": "2012-04-06T11:24:48.7032506+02:00",
  "Deadline": "2011-09-06T11:24:48.7032506+02:00",
  "CreatedBy": null,
  "Author": "at",
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
      "Position": "corporis",
      "PersonId": 787,
      "Mrmrs": "non",
      "Firstname": "Alexanne",
      "Lastname": "Waelchi",
      "MiddleName": "Dach, Herman and Mertz",
      "Title": "pariatur",
      "Description": "Devolved 24/7 synergy",
      "Email": "orlando.bradtke@schimmel.uk",
      "FullName": "Justyn Beahan MD",
      "DirectPhone": "666-506-4361 x85138",
      "FormalName": "Ziemann-Franecki",
      "CountryId": 76,
      "ContactId": 148,
      "ContactName": "Stark-Greenfelder",
      "Retired": 758,
      "Rank": 317,
      "ActiveInterests": 144,
      "ContactDepartment": "",
      "ContactCountryId": 249,
      "ContactOrgNr": "1637084",
      "FaxPhone": "1-749-486-0070 x9304",
      "MobilePhone": "(981)593-6617",
      "ContactPhone": "251.014.2021",
      "AssociateName": "Heidenreich LLC",
      "AssociateId": 646,
      "UsePersonAddress": false,
      "ContactFax": "dignissimos",
      "Kanafname": "non",
      "Kanalname": "tempore",
      "Post1": "non",
      "Post2": "quo",
      "Post3": "doloribus",
      "EmailName": "meta_hermiston@bashirianhoppe.us",
      "ContactFullName": "Lizeth Konopelski Sr.",
      "ActiveErpLinks": 194,
      "TicketPriorityId": 122,
      "SupportLanguageId": 10,
      "SupportAssociateId": 987,
      "CategoryName": "VIP Customer",
      "PersonNumber": "839336"
    }
  ],
  "AlertLevel": 533,
  "ConnectId": 279,
  "ReadStatus": "Green",
  "TimeToReply": 130,
  "RealTimeToReply": 62,
  "TimeToClose": 559,
  "RealTimeToClose": 372,
  "TimeSpentInternally": 683,
  "TimeSpentExternally": 137,
  "TimeSpentQueue": 858,
  "RealTimeSpentInternally": 461,
  "RealTimeSpentExternally": 590,
  "RealTimeSpentQueue": 22,
  "TimeSpent": 91,
  "HasAttachment": true,
  "NumReplies": 280,
  "NumMessages": 335,
  "FromAddress": "iste",
  "Messages": [
    {
      "TicketMessageId": 975,
      "CreatedAt": "2001-01-14T11:24:48.7032506+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "culpa",
      "PersonId": 32,
      "PersonFullName": "Miss Armando Stan Kuhic",
      "ContactId": 553,
      "ContactName": "Strosin-Jacobs",
      "ContactDepartment": "",
      "NumAttachments": 539,
      "EmailHeader": "madaline_swaniawski@grimes.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "veniam",
      "Sentiment": 329,
      "SentimentConfidence": 530,
      "CreatedBy": 512,
      "ChangedAt": "1999-07-02T11:24:48.7032506+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 578,
      "Name": "Marvin LLC",
      "ToolTip": "In magnam."
    },
    {
      "Id": 578,
      "Name": "Marvin LLC",
      "ToolTip": "In magnam."
    }
  ],
  "Language": "omnis",
  "Sentiment": 653,
  "SentimentConfidence": 58,
  "SuggestedCategoryId": 215,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 694,
  "IconHint": "commodi",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 349,
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "provident",
    "CustomFields2": "iusto"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 923,
  "Title": "sit",
  "CreatedAt": "2014-07-29T11:24:48.7032506+02:00",
  "LastChanged": "2018-04-12T11:24:48.7032506+02:00",
  "ReadByOwner": "2017-04-07T11:24:48.7032506+02:00",
  "ReadByCustomer": "2024-08-04T11:24:48.7032506+02:00",
  "FirstReadByOwner": "2006-07-14T11:24:48.7032506+02:00",
  "FirstReadByUser": "2007-03-29T11:24:48.7032506+02:00",
  "Activate": "2012-05-02T11:24:48.7032506+02:00",
  "ClosedAt": "2000-11-26T11:24:48.7032506+01:00",
  "RepliedAt": "2010-02-01T11:24:48.7032506+01:00",
  "AlertTimeout": "2023-12-17T11:24:48.7032506+01:00",
  "Deadline": "2014-08-19T11:24:48.7032506+02:00",
  "CreatedBy": null,
  "Author": "optio",
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
      "PersonId": 902,
      "Mrmrs": "velit",
      "Firstname": "Kiley",
      "Lastname": "Feil",
      "MiddleName": "Welch Group",
      "Title": "omnis",
      "Description": "Triple-buffered executive structure",
      "Email": "alaina@mccluremertz.uk",
      "FullName": "Miss Benjamin Jacquelyn Homenick",
      "DirectPhone": "741-766-4896",
      "FormalName": "Littel-Collier",
      "CountryId": 726,
      "ContactId": 45,
      "ContactName": "Koelpin, Mante and Hintz",
      "Retired": 934,
      "Rank": 734,
      "ActiveInterests": 428,
      "ContactDepartment": "",
      "ContactCountryId": 544,
      "ContactOrgNr": "601114",
      "FaxPhone": "043.588.9113 x497",
      "MobilePhone": "(145)838-9914 x56954",
      "ContactPhone": "(138)803-6355",
      "AssociateName": "Bosco LLC",
      "AssociateId": 442,
      "UsePersonAddress": false,
      "ContactFax": "dolor",
      "Kanafname": "quibusdam",
      "Kanalname": "rerum",
      "Post1": "ut",
      "Post2": "odio",
      "Post3": "nihil",
      "EmailName": "randi@rohan.com",
      "ContactFullName": "Annetta Armstrong",
      "ActiveErpLinks": 52,
      "TicketPriorityId": 246,
      "SupportLanguageId": 477,
      "SupportAssociateId": 213,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1518222",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 487
        }
      }
    }
  ],
  "AlertLevel": 736,
  "ConnectId": 974,
  "ReadStatus": "Green",
  "TimeToReply": 715,
  "RealTimeToReply": 314,
  "TimeToClose": 281,
  "RealTimeToClose": 980,
  "TimeSpentInternally": 418,
  "TimeSpentExternally": 370,
  "TimeSpentQueue": 906,
  "RealTimeSpentInternally": 34,
  "RealTimeSpentExternally": 850,
  "RealTimeSpentQueue": 135,
  "TimeSpent": 984,
  "HasAttachment": false,
  "NumReplies": 226,
  "NumMessages": 240,
  "FromAddress": "voluptatem",
  "Messages": [
    {
      "TicketMessageId": 519,
      "CreatedAt": "2014-12-26T11:24:48.7032506+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "molestias",
      "PersonId": 783,
      "PersonFullName": "Miss Oleta Margie Cummings",
      "ContactId": 66,
      "ContactName": "Bailey-Prohaska",
      "ContactDepartment": "",
      "NumAttachments": 509,
      "EmailHeader": "ardella.gleichner@quitzonbernhard.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "sed",
      "Sentiment": 980,
      "SentimentConfidence": 985,
      "CreatedBy": 456,
      "ChangedAt": "2013-10-18T11:24:48.7032506+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 588
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 52,
      "Name": "Zulauf-White",
      "ToolTip": "Ab repellendus et cum qui.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 13
        }
      }
    },
    {
      "Id": 52,
      "Name": "Zulauf-White",
      "ToolTip": "Ab repellendus et cum qui.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 13
        }
      }
    }
  ],
  "Language": "ea",
  "Sentiment": 680,
  "SentimentConfidence": 254,
  "SuggestedCategoryId": 995,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 636,
  "IconHint": "voluptatibus",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 165,
  "ExtraFields": {
    "ExtraFields1": "doloribus",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "minima"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 455
    }
  }
}
```