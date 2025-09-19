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
  "TicketId": 659,
  "Title": "doloribus",
  "CreatedAt": "2008-01-21T03:41:59.0273773+01:00",
  "LastChanged": "2008-12-21T03:41:59.0273773+01:00",
  "ReadByOwner": "2017-05-06T03:41:59.0273773+02:00",
  "ReadByCustomer": "2017-02-15T03:41:59.0273773+01:00",
  "FirstReadByOwner": "2005-06-23T03:41:59.0273773+02:00",
  "FirstReadByUser": "2005-10-06T03:41:59.0273773+02:00",
  "Activate": "2020-05-31T03:41:59.0273773+02:00",
  "ClosedAt": "2022-12-13T03:41:59.0273773+01:00",
  "RepliedAt": "2020-06-24T03:41:59.0273773+02:00",
  "AlertTimeout": "2017-01-05T03:41:59.0273773+01:00",
  "Deadline": "2013-07-27T03:41:59.0273773+02:00",
  "CreatedBy": null,
  "Author": "voluptas",
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
      "Position": "incidunt",
      "PersonId": 467,
      "Mrmrs": "natus",
      "Firstname": "Stuart",
      "Lastname": "Fritsch",
      "MiddleName": "Glover, Powlowski and McLaughlin",
      "Title": "quisquam",
      "Description": "Focused zero administration collaboration",
      "Email": "jadon@marvin.com",
      "FullName": "Drew Veum",
      "DirectPhone": "(031)740-0718",
      "FormalName": "Kunde-Willms",
      "CountryId": 32,
      "ContactId": 311,
      "ContactName": "Lueilwitz, Hills and Kuvalis",
      "Retired": 473,
      "Rank": 389,
      "ActiveInterests": 828,
      "ContactDepartment": "",
      "ContactCountryId": 469,
      "ContactOrgNr": "1328511",
      "FaxPhone": "402.685.6058",
      "MobilePhone": "(291)118-5664 x906",
      "ContactPhone": "441.458.8736",
      "AssociateName": "Hudson-Sipes",
      "AssociateId": 289,
      "UsePersonAddress": false,
      "ContactFax": "odit",
      "Kanafname": "aut",
      "Kanalname": "nam",
      "Post1": "nobis",
      "Post2": "et",
      "Post3": "ipsa",
      "EmailName": "andre.towne@kertzmann.biz",
      "ContactFullName": "Desiree Erdman",
      "ActiveErpLinks": 172,
      "TicketPriorityId": 415,
      "SupportLanguageId": 394,
      "SupportAssociateId": 368,
      "CategoryName": "VIP Customer",
      "PersonNumber": "626004"
    }
  ],
  "AlertLevel": 108,
  "ConnectId": 744,
  "ReadStatus": "Green",
  "TimeToReply": 266,
  "RealTimeToReply": 603,
  "TimeToClose": 987,
  "RealTimeToClose": 935,
  "TimeSpentInternally": 622,
  "TimeSpentExternally": 173,
  "TimeSpentQueue": 477,
  "RealTimeSpentInternally": 971,
  "RealTimeSpentExternally": 369,
  "RealTimeSpentQueue": 316,
  "TimeSpent": 495,
  "HasAttachment": true,
  "NumReplies": 514,
  "NumMessages": 478,
  "FromAddress": "sit",
  "Messages": [
    {
      "TicketMessageId": 264,
      "CreatedAt": "2010-01-16T03:41:59.0430023+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "ipsa",
      "PersonId": 583,
      "PersonFullName": "Zelma Sauer",
      "ContactId": 631,
      "ContactName": "Pollich, McLaughlin and Torphy",
      "ContactDepartment": "",
      "NumAttachments": 60,
      "EmailHeader": "ulises@harris.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "et",
      "Sentiment": 909,
      "SentimentConfidence": 127,
      "CreatedBy": 568,
      "ChangedAt": "2014-10-10T03:41:59.0430023+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 801,
      "Name": "Eichmann Group",
      "ToolTip": "Corrupti dolorum culpa sed accusamus."
    },
    {
      "Id": 801,
      "Name": "Eichmann Group",
      "ToolTip": "Corrupti dolorum culpa sed accusamus."
    }
  ],
  "Language": "pariatur",
  "Sentiment": 69,
  "SentimentConfidence": 576,
  "SuggestedCategoryId": 507,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 682,
  "IconHint": "recusandae",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 604,
  "ExtraFields": {
    "ExtraFields1": "fuga",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "velit",
    "CustomFields2": "nulla"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 735,
  "Title": "dolores",
  "CreatedAt": "2003-08-10T03:41:59.1057287+02:00",
  "LastChanged": "2021-10-03T03:41:59.1057287+02:00",
  "ReadByOwner": "2001-12-28T03:41:59.1057287+01:00",
  "ReadByCustomer": "2022-10-23T03:41:59.1057287+02:00",
  "FirstReadByOwner": "2013-12-12T03:41:59.1057287+01:00",
  "FirstReadByUser": "2023-10-22T03:41:59.1057287+02:00",
  "Activate": "2009-04-17T03:41:59.1057287+02:00",
  "ClosedAt": "2001-12-24T03:41:59.1057287+01:00",
  "RepliedAt": "2011-09-19T03:41:59.1057287+02:00",
  "AlertTimeout": "2003-12-02T03:41:59.1057287+01:00",
  "Deadline": "2002-08-13T03:41:59.1057287+02:00",
  "CreatedBy": null,
  "Author": "aut",
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
      "Position": "ullam",
      "PersonId": 576,
      "Mrmrs": "sunt",
      "Firstname": "Bettye",
      "Lastname": "Harvey",
      "MiddleName": "Emard, Spinka and Bergstrom",
      "Title": "cumque",
      "Description": "Devolved maximized benchmark",
      "Email": "gussie@brakus.com",
      "FullName": "Nathan Fadel",
      "DirectPhone": "1-348-483-2534 x8952",
      "FormalName": "Russel Inc and Sons",
      "CountryId": 884,
      "ContactId": 707,
      "ContactName": "O'Keefe, Mayert and Romaguera",
      "Retired": 509,
      "Rank": 526,
      "ActiveInterests": 737,
      "ContactDepartment": "maximize customized partnerships",
      "ContactCountryId": 703,
      "ContactOrgNr": "800976",
      "FaxPhone": "1-499-507-1720 x8465",
      "MobilePhone": "1-400-336-1953 x9426",
      "ContactPhone": "(322)619-6097 x880",
      "AssociateName": "Watsica, Rempel and Altenwerth",
      "AssociateId": 82,
      "UsePersonAddress": false,
      "ContactFax": "sunt",
      "Kanafname": "et",
      "Kanalname": "a",
      "Post1": "occaecati",
      "Post2": "totam",
      "Post3": "ab",
      "EmailName": "angelica@reynolds.uk",
      "ContactFullName": "Paris Denesik",
      "ActiveErpLinks": 517,
      "TicketPriorityId": 77,
      "SupportLanguageId": 183,
      "SupportAssociateId": 755,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1358739",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 819
        }
      }
    }
  ],
  "AlertLevel": 406,
  "ConnectId": 300,
  "ReadStatus": "Green",
  "TimeToReply": 622,
  "RealTimeToReply": 103,
  "TimeToClose": 994,
  "RealTimeToClose": 814,
  "TimeSpentInternally": 324,
  "TimeSpentExternally": 639,
  "TimeSpentQueue": 971,
  "RealTimeSpentInternally": 246,
  "RealTimeSpentExternally": 833,
  "RealTimeSpentQueue": 505,
  "TimeSpent": 230,
  "HasAttachment": false,
  "NumReplies": 626,
  "NumMessages": 801,
  "FromAddress": "est",
  "Messages": [
    {
      "TicketMessageId": 956,
      "CreatedAt": "2006-08-13T03:41:59.1057287+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "sint",
      "PersonId": 256,
      "PersonFullName": "Mrs. Thelma Rolfson",
      "ContactId": 496,
      "ContactName": "Schiller LLC",
      "ContactDepartment": "",
      "NumAttachments": 916,
      "EmailHeader": "velva@ernsermoore.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "aut",
      "Sentiment": 461,
      "SentimentConfidence": 854,
      "CreatedBy": 692,
      "ChangedAt": "2003-08-07T03:41:59.1057287+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 199
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 23,
      "Name": "Wehner-Champlin",
      "ToolTip": "Velit vel quas.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 448
        }
      }
    },
    {
      "Id": 23,
      "Name": "Wehner-Champlin",
      "ToolTip": "Velit vel quas.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 448
        }
      }
    }
  ],
  "Language": "nihil",
  "Sentiment": 887,
  "SentimentConfidence": 837,
  "SuggestedCategoryId": 796,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 320,
  "IconHint": "eveniet",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 114,
  "ExtraFields": {
    "ExtraFields1": "asperiores",
    "ExtraFields2": "ex"
  },
  "CustomFields": {
    "CustomFields1": "molestias",
    "CustomFields2": "enim"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 422
    }
  }
}
```