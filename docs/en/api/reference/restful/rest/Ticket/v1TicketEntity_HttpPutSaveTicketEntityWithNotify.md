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
  "TicketId": 678,
  "Title": "recusandae",
  "CreatedAt": "2012-08-18T13:14:11.1329328+02:00",
  "LastChanged": "2018-11-13T13:14:11.1329328+01:00",
  "ReadByOwner": "2016-07-01T13:14:11.1329328+02:00",
  "ReadByCustomer": "1997-10-11T13:14:11.1329328+02:00",
  "FirstReadByOwner": "2022-04-07T13:14:11.1329328+02:00",
  "FirstReadByUser": "2021-10-21T13:14:11.1329328+02:00",
  "Activate": "1999-08-15T13:14:11.1329328+02:00",
  "ClosedAt": "2010-05-08T13:14:11.1329328+02:00",
  "RepliedAt": "2019-10-02T13:14:11.1329328+02:00",
  "AlertTimeout": "2011-09-11T13:14:11.1329328+02:00",
  "Deadline": "2004-02-29T13:14:11.1329328+01:00",
  "CreatedBy": null,
  "Author": "aperiam",
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
      "Position": "quia",
      "PersonId": 967,
      "Mrmrs": "officia",
      "Firstname": "Hermann",
      "Lastname": "Reichel",
      "MiddleName": "Mosciski Group",
      "Title": "nam",
      "Description": "Programmable executive projection",
      "Email": "kobe@metz.uk",
      "FullName": "Emilie Hilpert",
      "DirectPhone": "015.094.6423 x76634",
      "FormalName": "Bogisich-Miller",
      "CountryId": 567,
      "ContactId": 511,
      "ContactName": "Feil Group",
      "Retired": 259,
      "Rank": 393,
      "ActiveInterests": 878,
      "ContactDepartment": "",
      "ContactCountryId": 661,
      "ContactOrgNr": "1502460",
      "FaxPhone": "(466)303-2182 x757",
      "MobilePhone": "1-301-353-1466 x19115",
      "ContactPhone": "785.984.0735 x03699",
      "AssociateName": "Smith-Leuschke",
      "AssociateId": 956,
      "UsePersonAddress": false,
      "ContactFax": "delectus",
      "Kanafname": "cumque",
      "Kanalname": "sed",
      "Post1": "velit",
      "Post2": "enim",
      "Post3": "velit",
      "EmailName": "salma@dubuque.ca",
      "ContactFullName": "Mina Okuneva",
      "ActiveErpLinks": 990,
      "TicketPriorityId": 220,
      "SupportLanguageId": 519,
      "SupportAssociateId": 181,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 647,
  "ConnectId": 534,
  "ReadStatus": "Green",
  "TimeToReply": 497,
  "RealTimeToReply": 476,
  "TimeToClose": 626,
  "RealTimeToClose": 481,
  "TimeSpentInternally": 116,
  "TimeSpentExternally": 368,
  "TimeSpentQueue": 129,
  "RealTimeSpentInternally": 480,
  "RealTimeSpentExternally": 792,
  "RealTimeSpentQueue": 876,
  "TimeSpent": 598,
  "HasAttachment": true,
  "NumReplies": 254,
  "NumMessages": 586,
  "FromAddress": "voluptas",
  "Messages": [
    {
      "TicketMessageId": 419,
      "CreatedAt": "2009-06-03T13:14:11.1485585+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "doloremque",
      "PersonId": 421,
      "PersonFullName": "Giovani Abbott",
      "ContactId": 566,
      "ContactName": "Gibson, Friesen and Ortiz",
      "ContactDepartment": "",
      "NumAttachments": 289,
      "EmailHeader": "vernice_nolan@tremblay.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "beatae",
      "Sentiment": 688,
      "SentimentConfidence": 739,
      "CreatedBy": 162,
      "ChangedAt": "2020-12-06T13:14:11.1485585+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 681,
      "Name": "Okuneva-Torp",
      "ToolTip": "Aut optio cupiditate."
    },
    {
      "Id": 681,
      "Name": "Okuneva-Torp",
      "ToolTip": "Aut optio cupiditate."
    }
  ],
  "Language": "quo",
  "Sentiment": 257,
  "SentimentConfidence": 55,
  "SuggestedCategoryId": 137,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 732,
  "IconHint": "quam",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 546,
  "ExtraFields": {
    "ExtraFields1": "ex",
    "ExtraFields2": "perferendis"
  },
  "CustomFields": {
    "CustomFields1": "sequi",
    "CustomFields2": "asperiores"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 161,
  "Title": "quo",
  "CreatedAt": "2019-07-18T13:14:11.1485585+02:00",
  "LastChanged": "2023-03-10T13:14:11.1485585+01:00",
  "ReadByOwner": "2024-10-01T13:14:11.1485585+02:00",
  "ReadByCustomer": "2002-08-12T13:14:11.1485585+02:00",
  "FirstReadByOwner": "2011-01-16T13:14:11.1485585+01:00",
  "FirstReadByUser": "1999-02-24T13:14:11.1485585+01:00",
  "Activate": "2005-08-06T13:14:11.1485585+02:00",
  "ClosedAt": "2019-10-14T13:14:11.1485585+02:00",
  "RepliedAt": "2016-12-23T13:14:11.1485585+01:00",
  "AlertTimeout": "2017-03-30T13:14:11.1485585+02:00",
  "Deadline": "2000-01-04T13:14:11.1485585+01:00",
  "CreatedBy": null,
  "Author": "nihil",
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
      "Position": "autem",
      "PersonId": 993,
      "Mrmrs": "nostrum",
      "Firstname": "Doyle",
      "Lastname": "Bergstrom",
      "MiddleName": "Wisozk, Heller and Kerluke",
      "Title": "ipsa",
      "Description": "Open-architected multi-state framework",
      "Email": "troy@boehm.biz",
      "FullName": "Darrin Adolph Nolan MD",
      "DirectPhone": "529-604-3927",
      "FormalName": "Kulas-Senger",
      "CountryId": 572,
      "ContactId": 471,
      "ContactName": "Corwin-Conn",
      "Retired": 107,
      "Rank": 549,
      "ActiveInterests": 930,
      "ContactDepartment": "",
      "ContactCountryId": 653,
      "ContactOrgNr": "985516",
      "FaxPhone": "790-190-6039",
      "MobilePhone": "(245)566-5769 x8294",
      "ContactPhone": "(246)184-7575 x406",
      "AssociateName": "Sanford Inc and Sons",
      "AssociateId": 941,
      "UsePersonAddress": true,
      "ContactFax": "rem",
      "Kanafname": "repellendus",
      "Kanalname": "velit",
      "Post1": "enim",
      "Post2": "consequatur",
      "Post3": "error",
      "EmailName": "silas_glover@ernser.com",
      "ContactFullName": "Nichole Hills",
      "ActiveErpLinks": 962,
      "TicketPriorityId": 885,
      "SupportLanguageId": 692,
      "SupportAssociateId": 231,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 934
        }
      }
    }
  ],
  "AlertLevel": 521,
  "ConnectId": 298,
  "ReadStatus": "Green",
  "TimeToReply": 709,
  "RealTimeToReply": 613,
  "TimeToClose": 841,
  "RealTimeToClose": 218,
  "TimeSpentInternally": 975,
  "TimeSpentExternally": 469,
  "TimeSpentQueue": 2,
  "RealTimeSpentInternally": 200,
  "RealTimeSpentExternally": 479,
  "RealTimeSpentQueue": 240,
  "TimeSpent": 241,
  "HasAttachment": false,
  "NumReplies": 701,
  "NumMessages": 715,
  "FromAddress": "illum",
  "Messages": [
    {
      "TicketMessageId": 627,
      "CreatedAt": "2021-02-28T13:14:11.1485585+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "labore",
      "PersonId": 847,
      "PersonFullName": "Carole Lesch",
      "ContactId": 464,
      "ContactName": "Pouros, Lubowitz and White",
      "ContactDepartment": "",
      "NumAttachments": 65,
      "EmailHeader": "kayleigh_sporer@oberbrunnerdurgan.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "beatae",
      "Sentiment": 422,
      "SentimentConfidence": 429,
      "CreatedBy": 141,
      "ChangedAt": "2003-10-28T13:14:11.1485585+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 119
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 226,
      "Name": "Ryan-Oberbrunner",
      "ToolTip": "Quasi expedita inventore nesciunt incidunt eum quia.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 981
        }
      }
    },
    {
      "Id": 226,
      "Name": "Ryan-Oberbrunner",
      "ToolTip": "Quasi expedita inventore nesciunt incidunt eum quia.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 981
        }
      }
    }
  ],
  "Language": "exercitationem",
  "Sentiment": 621,
  "SentimentConfidence": 594,
  "SuggestedCategoryId": 434,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 83,
  "IconHint": "rerum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 476,
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "rerum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 716
    }
  }
}
```