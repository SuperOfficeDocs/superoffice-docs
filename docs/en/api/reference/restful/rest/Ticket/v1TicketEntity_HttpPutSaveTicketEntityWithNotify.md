---
title: PUT Ticket/{id}
uid: v1TicketEntity_HttpPutSaveTicketEntityWithNotify
generated: true
---

# PUT Ticket/{id}

```http
PUT /api/v1/Ticket/{id}
```

Saves a ticket and performs any user notifications






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The TicketEntity id to update **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| notify | bool |  If true, then the notifications will be sent |

```http
PUT /api/v1/Ticket/{id}?notify=False
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

## Request Body: entity 

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
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 520,
  "Title": "enim",
  "CreatedAt": "2022-11-23T12:19:53.9929096+01:00",
  "LastChanged": "2007-10-23T12:19:53.9929096+02:00",
  "ReadByOwner": "2019-04-20T12:19:53.9929096+02:00",
  "ReadByCustomer": "2022-06-30T12:19:53.9929096+02:00",
  "FirstReadByOwner": "2005-10-25T12:19:53.9929096+02:00",
  "FirstReadByUser": "2003-04-29T12:19:53.9929096+02:00",
  "Activate": "2006-04-15T12:19:53.9929096+02:00",
  "ClosedAt": "2016-04-24T12:19:53.9929096+02:00",
  "RepliedAt": "2009-06-27T12:19:53.9929096+02:00",
  "AlertTimeout": "2006-10-05T12:19:53.9929096+02:00",
  "Deadline": "2023-01-12T12:19:53.9929096+01:00",
  "CreatedBy": null,
  "Author": "ab",
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
      "Position": "omnis",
      "PersonId": 576,
      "Mrmrs": "et",
      "Firstname": "Jedidiah",
      "Lastname": "Eichmann",
      "MiddleName": "Fahey, Altenwerth and Rempel",
      "Title": "soluta",
      "Description": "Streamlined eco-centric projection",
      "Email": "edgar@weber.co.uk",
      "FullName": "Bailee Beer",
      "DirectPhone": "232.180.0053 x960",
      "FormalName": "Wilderman-White",
      "CountryId": 856,
      "ContactId": 440,
      "ContactName": "Stark Group",
      "Retired": 894,
      "Rank": 69,
      "ActiveInterests": 105,
      "ContactDepartment": "",
      "ContactCountryId": 211,
      "ContactOrgNr": "228314",
      "FaxPhone": "075.410.5772",
      "MobilePhone": "(429)798-6768 x817",
      "ContactPhone": "(049)911-0545",
      "AssociateName": "Homenick LLC",
      "AssociateId": 509,
      "UsePersonAddress": true,
      "ContactFax": "porro",
      "Kanafname": "delectus",
      "Kanalname": "odio",
      "Post1": "qui",
      "Post2": "autem",
      "Post3": "ut",
      "EmailName": "cassandra@hoegerleffler.name",
      "ContactFullName": "Bettie Leuschke",
      "ActiveErpLinks": 874,
      "TicketPriorityId": 965,
      "SupportLanguageId": 329,
      "SupportAssociateId": 992,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 959,
  "ConnectId": 326,
  "ReadStatus": "Green",
  "TimeToReply": 74,
  "RealTimeToReply": 134,
  "TimeToClose": 760,
  "RealTimeToClose": 541,
  "TimeSpentInternally": 632,
  "TimeSpentExternally": 635,
  "TimeSpentQueue": 591,
  "RealTimeSpentInternally": 86,
  "RealTimeSpentExternally": 357,
  "RealTimeSpentQueue": 908,
  "TimeSpent": 388,
  "HasAttachment": true,
  "NumReplies": 600,
  "NumMessages": 581,
  "FromAddress": "illum",
  "Messages": [
    {
      "TicketMessageId": 135,
      "CreatedAt": "2009-02-28T12:19:53.9929096+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "aut",
      "PersonId": 499,
      "PersonFullName": "Zechariah Crona",
      "ContactId": 779,
      "ContactName": "Spencer, Windler and Sauer",
      "ContactDepartment": "",
      "NumAttachments": 410,
      "EmailHeader": "lura@schaeferwintheiser.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "minima",
      "Sentiment": 241,
      "SentimentConfidence": 446,
      "CreatedBy": 86,
      "ChangedAt": "2020-05-23T12:19:53.9929096+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 373,
      "Name": "Dach Inc and Sons",
      "ToolTip": "Sapiente enim."
    },
    {
      "Id": 373,
      "Name": "Dach Inc and Sons",
      "ToolTip": "Sapiente enim."
    }
  ],
  "Language": "labore",
  "Sentiment": 947,
  "SentimentConfidence": 519,
  "SuggestedCategoryId": 130,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 566,
  "IconHint": "eum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 861,
  "ExtraFields": {
    "ExtraFields1": "quod",
    "ExtraFields2": "accusamus"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "maiores"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 405,
  "Title": "molestiae",
  "CreatedAt": "1997-06-05T12:19:53.9929096+02:00",
  "LastChanged": "2009-11-10T12:19:53.9929096+01:00",
  "ReadByOwner": "2011-04-22T12:19:53.9929096+02:00",
  "ReadByCustomer": "1998-04-01T12:19:53.9929096+02:00",
  "FirstReadByOwner": "2008-12-26T12:19:53.9929096+01:00",
  "FirstReadByUser": "1999-11-10T12:19:53.9929096+01:00",
  "Activate": "2005-08-26T12:19:53.9929096+02:00",
  "ClosedAt": "2022-05-09T12:19:53.9929096+02:00",
  "RepliedAt": "2010-10-24T12:19:53.9929096+02:00",
  "AlertTimeout": "2014-05-15T12:19:53.9929096+02:00",
  "Deadline": "2020-04-16T12:19:53.9929096+02:00",
  "CreatedBy": null,
  "Author": "perferendis",
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
      "Position": "unde",
      "PersonId": 963,
      "Mrmrs": "consequatur",
      "Firstname": "Brooke",
      "Lastname": "Dicki",
      "MiddleName": "Turcotte Group",
      "Title": "labore",
      "Description": "Distributed global frame",
      "Email": "nikko.orn@quitzon.ca",
      "FullName": "Mr. Tressie Issac Braun",
      "DirectPhone": "1-829-091-8434 x5841",
      "FormalName": "Hoeger, Kshlerin and Stark",
      "CountryId": 112,
      "ContactId": 493,
      "ContactName": "Kozey Group",
      "Retired": 320,
      "Rank": 212,
      "ActiveInterests": 388,
      "ContactDepartment": "",
      "ContactCountryId": 214,
      "ContactOrgNr": "857430",
      "FaxPhone": "165-608-6685 x0509",
      "MobilePhone": "483-395-8827 x12949",
      "ContactPhone": "(682)466-7014 x89375",
      "AssociateName": "Schuster, Corwin and Spencer",
      "AssociateId": 932,
      "UsePersonAddress": true,
      "ContactFax": "alias",
      "Kanafname": "ut",
      "Kanalname": "nostrum",
      "Post1": "et",
      "Post2": "ullam",
      "Post3": "voluptatum",
      "EmailName": "kaylah_conroy@bruen.co.uk",
      "ContactFullName": "Pattie Howe",
      "ActiveErpLinks": 935,
      "TicketPriorityId": 856,
      "SupportLanguageId": 885,
      "SupportAssociateId": 61,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 606
        }
      }
    }
  ],
  "AlertLevel": 407,
  "ConnectId": 616,
  "ReadStatus": "Green",
  "TimeToReply": 997,
  "RealTimeToReply": 474,
  "TimeToClose": 919,
  "RealTimeToClose": 521,
  "TimeSpentInternally": 743,
  "TimeSpentExternally": 646,
  "TimeSpentQueue": 650,
  "RealTimeSpentInternally": 72,
  "RealTimeSpentExternally": 533,
  "RealTimeSpentQueue": 687,
  "TimeSpent": 758,
  "HasAttachment": false,
  "NumReplies": 449,
  "NumMessages": 475,
  "FromAddress": "fuga",
  "Messages": [
    {
      "TicketMessageId": 478,
      "CreatedAt": "2023-04-29T12:19:54.0085294+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "vel",
      "PersonId": 19,
      "PersonFullName": "Harmony Lynch",
      "ContactId": 146,
      "ContactName": "Mayert, Wyman and Shanahan",
      "ContactDepartment": "",
      "NumAttachments": 409,
      "EmailHeader": "rosendo@pollich.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "odio",
      "Sentiment": 493,
      "SentimentConfidence": 426,
      "CreatedBy": 950,
      "ChangedAt": "2008-07-09T12:19:54.0085294+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 894
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 176,
      "Name": "Trantow, Corkery and Kshlerin",
      "ToolTip": "Asperiores aspernatur.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 712
        }
      }
    },
    {
      "Id": 176,
      "Name": "Trantow, Corkery and Kshlerin",
      "ToolTip": "Asperiores aspernatur.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 712
        }
      }
    }
  ],
  "Language": "error",
  "Sentiment": 588,
  "SentimentConfidence": 185,
  "SuggestedCategoryId": 418,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 731,
  "IconHint": "facere",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 492,
  "ExtraFields": {
    "ExtraFields1": "laboriosam",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "dolore",
    "CustomFields2": "excepturi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 892
    }
  }
}
```