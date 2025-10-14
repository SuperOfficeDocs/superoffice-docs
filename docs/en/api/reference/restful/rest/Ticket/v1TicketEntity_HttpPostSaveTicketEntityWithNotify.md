---
title: POST Ticket
uid: v1TicketEntity_HttpPostSaveTicketEntityWithNotify
generated: true
content_type: reference
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 102,
  "Title": "sint",
  "CreatedAt": "2011-02-08T03:40:56.320343+01:00",
  "LastChanged": "1999-12-09T03:40:56.320343+01:00",
  "ReadByOwner": "2015-03-16T03:40:56.320343+01:00",
  "ReadByCustomer": "2018-05-15T03:40:56.320343+02:00",
  "FirstReadByOwner": "2017-08-21T03:40:56.320343+02:00",
  "FirstReadByUser": "2016-08-07T03:40:56.320343+02:00",
  "Activate": "2018-10-16T03:40:56.320343+02:00",
  "ClosedAt": "2021-01-24T03:40:56.320343+01:00",
  "RepliedAt": "2023-07-26T03:40:56.320343+02:00",
  "AlertTimeout": "2009-04-02T03:40:56.320343+02:00",
  "Deadline": "2024-05-23T03:40:56.320343+02:00",
  "CreatedBy": null,
  "Author": "asperiores",
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
      "Position": "ea",
      "PersonId": 580,
      "Mrmrs": "mollitia",
      "Firstname": "Lennie",
      "Lastname": "Herman",
      "MiddleName": "Mayer LLC",
      "Title": "ipsam",
      "Description": "Innovative fault-tolerant extranet",
      "Email": "agustina.price@gutkowski.ca",
      "FullName": "Damion Brakus",
      "DirectPhone": "1-772-890-9294",
      "FormalName": "Schuppe-Schimmel",
      "CountryId": 893,
      "ContactId": 44,
      "ContactName": "Dibbert Group",
      "Retired": 762,
      "Rank": 147,
      "ActiveInterests": 900,
      "ContactDepartment": "",
      "ContactCountryId": 473,
      "ContactOrgNr": "714662",
      "FaxPhone": "933.708.9233 x7777",
      "MobilePhone": "1-786-944-1266",
      "ContactPhone": "(915)499-0010",
      "AssociateName": "Schiller Inc and Sons",
      "AssociateId": 717,
      "UsePersonAddress": false,
      "ContactFax": "rerum",
      "Kanafname": "ex",
      "Kanalname": "dolorem",
      "Post1": "officiis",
      "Post2": "reprehenderit",
      "Post3": "fugiat",
      "EmailName": "tyler.paucek@lindgren.biz",
      "ContactFullName": "Lenny Bode",
      "ActiveErpLinks": 476,
      "TicketPriorityId": 1001,
      "SupportLanguageId": 127,
      "SupportAssociateId": 939,
      "CategoryName": "VIP Customer",
      "PersonNumber": "919067"
    }
  ],
  "AlertLevel": 595,
  "ConnectId": 703,
  "ReadStatus": "Green",
  "TimeToReply": 141,
  "RealTimeToReply": 51,
  "TimeToClose": 933,
  "RealTimeToClose": 431,
  "TimeSpentInternally": 735,
  "TimeSpentExternally": 390,
  "TimeSpentQueue": 854,
  "RealTimeSpentInternally": 683,
  "RealTimeSpentExternally": 915,
  "RealTimeSpentQueue": 241,
  "TimeSpent": 603,
  "HasAttachment": true,
  "NumReplies": 173,
  "NumMessages": 748,
  "FromAddress": "suscipit",
  "Messages": [
    {
      "TicketMessageId": 294,
      "CreatedAt": "2018-06-08T03:40:56.320343+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "eos",
      "PersonId": 285,
      "PersonFullName": "Conner Padberg",
      "ContactId": 417,
      "ContactName": "Schumm-Barton",
      "ContactDepartment": "",
      "NumAttachments": 876,
      "EmailHeader": "jacynthe_kutch@howell.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "beatae",
      "Sentiment": 495,
      "SentimentConfidence": 395,
      "CreatedBy": 902,
      "ChangedAt": "2023-04-12T03:40:56.320343+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 521,
      "Name": "Legros, Kovacek and Waters",
      "ToolTip": "Recusandae nisi quia velit."
    },
    {
      "Id": 521,
      "Name": "Legros, Kovacek and Waters",
      "ToolTip": "Recusandae nisi quia velit."
    }
  ],
  "Language": "commodi",
  "Sentiment": 763,
  "SentimentConfidence": 939,
  "SuggestedCategoryId": 397,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 942,
  "IconHint": "molestiae",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 382,
  "ExtraFields": {
    "ExtraFields1": "aliquam",
    "ExtraFields2": "minima"
  },
  "CustomFields": {
    "CustomFields1": "culpa",
    "CustomFields2": "accusantium"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 639,
  "Title": "mollitia",
  "CreatedAt": "2004-10-24T03:40:56.335969+02:00",
  "LastChanged": "2000-12-10T03:40:56.335969+01:00",
  "ReadByOwner": "2020-12-04T03:40:56.335969+01:00",
  "ReadByCustomer": "2016-07-16T03:40:56.335969+02:00",
  "FirstReadByOwner": "2008-04-24T03:40:56.335969+02:00",
  "FirstReadByUser": "2025-04-11T03:40:56.335969+02:00",
  "Activate": "2013-06-21T03:40:56.335969+02:00",
  "ClosedAt": "2010-01-07T03:40:56.335969+01:00",
  "RepliedAt": "2020-01-23T03:40:56.335969+01:00",
  "AlertTimeout": "2009-08-25T03:40:56.335969+02:00",
  "Deadline": "2016-05-31T03:40:56.335969+02:00",
  "CreatedBy": null,
  "Author": "dolorem",
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
      "Position": "temporibus",
      "PersonId": 40,
      "Mrmrs": "consectetur",
      "Firstname": "Marcia",
      "Lastname": "Daugherty",
      "MiddleName": "Gutmann-Hagenes",
      "Title": "officia",
      "Description": "Reverse-engineered human-resource process improvement",
      "Email": "helene@kuhn.biz",
      "FullName": "Mrs. Justice Monserrat Witting DDS",
      "DirectPhone": "444-376-8805",
      "FormalName": "Ryan-Feeney",
      "CountryId": 550,
      "ContactId": 862,
      "ContactName": "Paucek, Greenholt and Johnston",
      "Retired": 214,
      "Rank": 762,
      "ActiveInterests": 72,
      "ContactDepartment": "",
      "ContactCountryId": 86,
      "ContactOrgNr": "1613376",
      "FaxPhone": "859.248.1984 x10062",
      "MobilePhone": "(551)724-2328",
      "ContactPhone": "1-973-948-1565",
      "AssociateName": "Monahan-Pfeffer",
      "AssociateId": 823,
      "UsePersonAddress": true,
      "ContactFax": "saepe",
      "Kanafname": "vel",
      "Kanalname": "ducimus",
      "Post1": "aliquam",
      "Post2": "officiis",
      "Post3": "ad",
      "EmailName": "devante@stroman.us",
      "ContactFullName": "Prof. Zita Leannon",
      "ActiveErpLinks": 396,
      "TicketPriorityId": 514,
      "SupportLanguageId": 542,
      "SupportAssociateId": 127,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1002529",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 473
        }
      }
    }
  ],
  "AlertLevel": 688,
  "ConnectId": 864,
  "ReadStatus": "Green",
  "TimeToReply": 799,
  "RealTimeToReply": 329,
  "TimeToClose": 669,
  "RealTimeToClose": 713,
  "TimeSpentInternally": 247,
  "TimeSpentExternally": 167,
  "TimeSpentQueue": 943,
  "RealTimeSpentInternally": 940,
  "RealTimeSpentExternally": 195,
  "RealTimeSpentQueue": 228,
  "TimeSpent": 958,
  "HasAttachment": true,
  "NumReplies": 667,
  "NumMessages": 990,
  "FromAddress": "aliquam",
  "Messages": [
    {
      "TicketMessageId": 390,
      "CreatedAt": "2001-09-08T03:40:56.335969+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "quam",
      "PersonId": 956,
      "PersonFullName": "Cydney Keebler",
      "ContactId": 557,
      "ContactName": "Douglas, Rodriguez and Gutmann",
      "ContactDepartment": "",
      "NumAttachments": 509,
      "EmailHeader": "dewitt.funk@dare.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "illo",
      "Sentiment": 296,
      "SentimentConfidence": 773,
      "CreatedBy": 849,
      "ChangedAt": "2008-12-11T03:40:56.335969+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 837
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 367,
      "Name": "Roberts-Jenkins",
      "ToolTip": "Consectetur eaque.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 947
        }
      }
    },
    {
      "Id": 367,
      "Name": "Roberts-Jenkins",
      "ToolTip": "Consectetur eaque.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 947
        }
      }
    }
  ],
  "Language": "vel",
  "Sentiment": 508,
  "SentimentConfidence": 289,
  "SuggestedCategoryId": 225,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 801,
  "IconHint": "tenetur",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 693,
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "facilis"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "reprehenderit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 379
    }
  }
}
```