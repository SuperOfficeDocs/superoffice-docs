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
  "TicketId": 495,
  "Title": "id",
  "CreatedAt": "2016-10-05T04:22:35.4709806+02:00",
  "LastChanged": "2009-09-06T04:22:35.4709806+02:00",
  "ReadByOwner": "2015-08-11T04:22:35.4709806+02:00",
  "ReadByCustomer": "2000-11-03T04:22:35.4709806+01:00",
  "FirstReadByOwner": "2019-11-10T04:22:35.4709806+01:00",
  "FirstReadByUser": "2002-05-14T04:22:35.4709806+02:00",
  "Activate": "2017-11-14T04:22:35.4709806+01:00",
  "ClosedAt": "2013-10-19T04:22:35.4709806+02:00",
  "RepliedAt": "2012-11-23T04:22:35.4709806+01:00",
  "AlertTimeout": "2021-06-30T04:22:35.4709806+02:00",
  "Deadline": "2014-04-03T04:22:35.4709806+02:00",
  "CreatedBy": null,
  "Author": "ducimus",
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
      "Position": "voluptate",
      "PersonId": 690,
      "Mrmrs": "et",
      "Firstname": "Ruthie",
      "Lastname": "Mann",
      "MiddleName": "Carter-Schiller",
      "Title": "sint",
      "Description": "Devolved explicit utilisation",
      "Email": "trent.paucek@gleasonreichert.com",
      "FullName": "Crawford Jerde II",
      "DirectPhone": "(243)873-9616 x37614",
      "FormalName": "Spencer LLC",
      "CountryId": 309,
      "ContactId": 722,
      "ContactName": "Rolfson Group",
      "Retired": 979,
      "Rank": 320,
      "ActiveInterests": 295,
      "ContactDepartment": "",
      "ContactCountryId": 346,
      "ContactOrgNr": "857551",
      "FaxPhone": "268-829-1625 x0211",
      "MobilePhone": "376-181-1752 x22680",
      "ContactPhone": "1-680-225-4022",
      "AssociateName": "Leuschke, Parker and Brakus",
      "AssociateId": 679,
      "UsePersonAddress": false,
      "ContactFax": "dignissimos",
      "Kanafname": "perferendis",
      "Kanalname": "ea",
      "Post1": "possimus",
      "Post2": "quisquam",
      "Post3": "non",
      "EmailName": "jarred_oconner@tillmanernser.us",
      "ContactFullName": "Ms. Kenyatta Weber",
      "ActiveErpLinks": 956,
      "TicketPriorityId": 591,
      "SupportLanguageId": 631,
      "SupportAssociateId": 948,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 409,
  "ConnectId": 460,
  "ReadStatus": "Green",
  "TimeToReply": 860,
  "RealTimeToReply": 393,
  "TimeToClose": 199,
  "RealTimeToClose": 259,
  "TimeSpentInternally": 352,
  "TimeSpentExternally": 228,
  "TimeSpentQueue": 272,
  "RealTimeSpentInternally": 371,
  "RealTimeSpentExternally": 711,
  "RealTimeSpentQueue": 955,
  "TimeSpent": 861,
  "HasAttachment": false,
  "NumReplies": 542,
  "NumMessages": 614,
  "FromAddress": "minus",
  "Messages": [
    {
      "TicketMessageId": 77,
      "CreatedAt": "2000-07-30T04:22:35.4866071+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "sunt",
      "PersonId": 692,
      "PersonFullName": "Hudson Ryan IV",
      "ContactId": 212,
      "ContactName": "Padberg Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 216,
      "EmailHeader": "alysa@johnson.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "corporis",
      "Sentiment": 647,
      "SentimentConfidence": 380,
      "CreatedBy": 914,
      "ChangedAt": "2016-01-14T04:22:35.4866071+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 801,
      "Name": "Wiza, Stamm and Stroman",
      "ToolTip": "At velit quidem molestias."
    },
    {
      "Id": 801,
      "Name": "Wiza, Stamm and Stroman",
      "ToolTip": "At velit quidem molestias."
    }
  ],
  "Language": "in",
  "Sentiment": 491,
  "SentimentConfidence": 250,
  "SuggestedCategoryId": 15,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 789,
  "IconHint": "impedit",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 106,
  "ExtraFields": {
    "ExtraFields1": "dolorem",
    "ExtraFields2": "dolorem"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "delectus"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 367,
  "Title": "laudantium",
  "CreatedAt": "2008-05-18T04:22:35.4866071+02:00",
  "LastChanged": "2008-11-19T04:22:35.4866071+01:00",
  "ReadByOwner": "2024-03-09T04:22:35.4866071+01:00",
  "ReadByCustomer": "2002-05-14T04:22:35.4866071+02:00",
  "FirstReadByOwner": "2018-12-22T04:22:35.4866071+01:00",
  "FirstReadByUser": "2014-07-01T04:22:35.4866071+02:00",
  "Activate": "2021-10-04T04:22:35.4866071+02:00",
  "ClosedAt": "2021-01-10T04:22:35.4866071+01:00",
  "RepliedAt": "2004-03-22T04:22:35.4866071+01:00",
  "AlertTimeout": "2014-04-01T04:22:35.4866071+02:00",
  "Deadline": "2014-02-08T04:22:35.4866071+01:00",
  "CreatedBy": null,
  "Author": "reprehenderit",
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
      "PersonId": 447,
      "Mrmrs": "reprehenderit",
      "Firstname": "Muriel",
      "Lastname": "Jewess",
      "MiddleName": "Collier LLC",
      "Title": "esse",
      "Description": "Organized encompassing solution",
      "Email": "clint.gerlach@kulas.name",
      "FullName": "Mrs. Mireya Brady Metz DVM",
      "DirectPhone": "1-752-986-1049 x090",
      "FormalName": "Mills-Bernhard",
      "CountryId": 876,
      "ContactId": 106,
      "ContactName": "Weimann Inc and Sons",
      "Retired": 435,
      "Rank": 265,
      "ActiveInterests": 263,
      "ContactDepartment": "",
      "ContactCountryId": 223,
      "ContactOrgNr": "1652418",
      "FaxPhone": "(620)930-1493 x30005",
      "MobilePhone": "260-284-9845",
      "ContactPhone": "1-871-537-1713",
      "AssociateName": "Kirlin Group",
      "AssociateId": 954,
      "UsePersonAddress": false,
      "ContactFax": "cupiditate",
      "Kanafname": "ipsum",
      "Kanalname": "esse",
      "Post1": "dignissimos",
      "Post2": "est",
      "Post3": "sit",
      "EmailName": "kelvin@mertzleannon.ca",
      "ContactFullName": "Carmelo Eichmann",
      "ActiveErpLinks": 623,
      "TicketPriorityId": 726,
      "SupportLanguageId": 220,
      "SupportAssociateId": 38,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 821
        }
      }
    }
  ],
  "AlertLevel": 861,
  "ConnectId": 822,
  "ReadStatus": "Green",
  "TimeToReply": 699,
  "RealTimeToReply": 703,
  "TimeToClose": 810,
  "RealTimeToClose": 641,
  "TimeSpentInternally": 30,
  "TimeSpentExternally": 49,
  "TimeSpentQueue": 204,
  "RealTimeSpentInternally": 99,
  "RealTimeSpentExternally": 571,
  "RealTimeSpentQueue": 136,
  "TimeSpent": 827,
  "HasAttachment": false,
  "NumReplies": 369,
  "NumMessages": 119,
  "FromAddress": "nesciunt",
  "Messages": [
    {
      "TicketMessageId": 659,
      "CreatedAt": "2015-02-27T04:22:35.4866071+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "sit",
      "PersonId": 563,
      "PersonFullName": "Mrs. Miller Amira Hackett",
      "ContactId": 383,
      "ContactName": "Rice-Macejkovic",
      "ContactDepartment": "",
      "NumAttachments": 333,
      "EmailHeader": "jeramy.konopelski@feest.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "incidunt",
      "Sentiment": 433,
      "SentimentConfidence": 632,
      "CreatedBy": 265,
      "ChangedAt": "2007-09-17T04:22:35.4866071+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 149
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 25,
      "Name": "Rutherford-Wilderman",
      "ToolTip": "Minus vel earum et.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 715
        }
      }
    },
    {
      "Id": 25,
      "Name": "Rutherford-Wilderman",
      "ToolTip": "Minus vel earum et.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 715
        }
      }
    }
  ],
  "Language": "quo",
  "Sentiment": 302,
  "SentimentConfidence": 55,
  "SuggestedCategoryId": 447,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 345,
  "IconHint": "est",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 1002,
  "ExtraFields": {
    "ExtraFields1": "fuga",
    "ExtraFields2": "ratione"
  },
  "CustomFields": {
    "CustomFields1": "sequi",
    "CustomFields2": "blanditiis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 19
    }
  }
}
```