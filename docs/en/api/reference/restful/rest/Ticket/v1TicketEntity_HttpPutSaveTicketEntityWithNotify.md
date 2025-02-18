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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 500,
  "Title": "quis",
  "CreatedAt": "2023-02-17T14:32:12.1303056+01:00",
  "LastChanged": "2004-09-21T14:32:12.1303056+02:00",
  "ReadByOwner": "1999-11-22T14:32:12.1303056+01:00",
  "ReadByCustomer": "2020-08-22T14:32:12.1303056+02:00",
  "FirstReadByOwner": "2023-04-14T14:32:12.1303056+02:00",
  "FirstReadByUser": "2016-08-23T14:32:12.1303056+02:00",
  "Activate": "2017-04-13T14:32:12.1303056+02:00",
  "ClosedAt": "2019-04-28T14:32:12.1303056+02:00",
  "RepliedAt": "1998-10-05T14:32:12.1303056+02:00",
  "AlertTimeout": "2009-07-31T14:32:12.1303056+02:00",
  "Deadline": "2001-07-26T14:32:12.1303056+02:00",
  "CreatedBy": null,
  "Author": "dolore",
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
      "Position": "id",
      "PersonId": 48,
      "Mrmrs": "voluptates",
      "Firstname": "Arnoldo",
      "Lastname": "Quigley",
      "MiddleName": "Goyette-Wilderman",
      "Title": "deleniti",
      "Description": "Switchable eco-centric toolset",
      "Email": "cory.zulauf@feeney.ca",
      "FullName": "Miss Marta Welch Sr.",
      "DirectPhone": "(407)531-6430",
      "FormalName": "Treutel, Hammes and Stroman",
      "CountryId": 942,
      "ContactId": 473,
      "ContactName": "Stoltenberg-Brown",
      "Retired": 644,
      "Rank": 417,
      "ActiveInterests": 418,
      "ContactDepartment": "",
      "ContactCountryId": 672,
      "ContactOrgNr": "1266093",
      "FaxPhone": "(258)504-7776",
      "MobilePhone": "1-124-500-0647 x204",
      "ContactPhone": "958.969.9043",
      "AssociateName": "Wisozk, Beier and VonRueden",
      "AssociateId": 768,
      "UsePersonAddress": true,
      "ContactFax": "eos",
      "Kanafname": "sit",
      "Kanalname": "ducimus",
      "Post1": "magni",
      "Post2": "harum",
      "Post3": "est",
      "EmailName": "cullen@schmidtcummerata.us",
      "ContactFullName": "Lora Keebler",
      "ActiveErpLinks": 520,
      "TicketPriorityId": 466,
      "SupportLanguageId": 339,
      "SupportAssociateId": 301,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1488786"
    }
  ],
  "AlertLevel": 505,
  "ConnectId": 400,
  "ReadStatus": "Green",
  "TimeToReply": 497,
  "RealTimeToReply": 132,
  "TimeToClose": 786,
  "RealTimeToClose": 575,
  "TimeSpentInternally": 907,
  "TimeSpentExternally": 661,
  "TimeSpentQueue": 884,
  "RealTimeSpentInternally": 723,
  "RealTimeSpentExternally": 198,
  "RealTimeSpentQueue": 49,
  "TimeSpent": 5,
  "HasAttachment": false,
  "NumReplies": 696,
  "NumMessages": 276,
  "FromAddress": "sint",
  "Messages": [
    {
      "TicketMessageId": 308,
      "CreatedAt": "2021-11-16T14:32:12.1303056+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "libero",
      "PersonId": 272,
      "PersonFullName": "Josiah Hamill",
      "ContactId": 213,
      "ContactName": "Carroll-Quigley",
      "ContactDepartment": "",
      "NumAttachments": 596,
      "EmailHeader": "regan.reichert@vonhickle.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "rem",
      "Sentiment": 924,
      "SentimentConfidence": 202,
      "CreatedBy": 637,
      "ChangedAt": "2002-07-16T14:32:12.1303056+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 744,
      "Name": "Flatley-Kunze",
      "ToolTip": "Omnis minus soluta."
    },
    {
      "Id": 744,
      "Name": "Flatley-Kunze",
      "ToolTip": "Omnis minus soluta."
    }
  ],
  "Language": "ab",
  "Sentiment": 374,
  "SentimentConfidence": 12,
  "SuggestedCategoryId": 299,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 848,
  "IconHint": "consequatur",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 934,
  "ExtraFields": {
    "ExtraFields1": "quidem",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "neque",
    "CustomFields2": "ipsum"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 678,
  "Title": "molestiae",
  "CreatedAt": "2003-09-23T14:32:12.1303056+02:00",
  "LastChanged": "2020-04-20T14:32:12.1303056+02:00",
  "ReadByOwner": "2022-10-17T14:32:12.1303056+02:00",
  "ReadByCustomer": "2022-01-10T14:32:12.1303056+01:00",
  "FirstReadByOwner": "2004-09-23T14:32:12.1303056+02:00",
  "FirstReadByUser": "2014-09-27T14:32:12.1303056+02:00",
  "Activate": "2005-11-19T14:32:12.1303056+01:00",
  "ClosedAt": "2008-03-25T14:32:12.1303056+01:00",
  "RepliedAt": "2003-03-23T14:32:12.1303056+01:00",
  "AlertTimeout": "2023-02-04T14:32:12.1303056+01:00",
  "Deadline": "2017-03-02T14:32:12.1303056+01:00",
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
      "Position": "laborum",
      "PersonId": 791,
      "Mrmrs": "et",
      "Firstname": "Mohamed",
      "Lastname": "Howell",
      "MiddleName": "Roob-Runolfsson",
      "Title": "quasi",
      "Description": "Adaptive multimedia ability",
      "Email": "wilford_corkery@damorestoltenberg.com",
      "FullName": "Manuela Ortiz",
      "DirectPhone": "447-471-2254 x48740",
      "FormalName": "Weimann Inc and Sons",
      "CountryId": 819,
      "ContactId": 968,
      "ContactName": "Deckow Inc and Sons",
      "Retired": 34,
      "Rank": 806,
      "ActiveInterests": 900,
      "ContactDepartment": "",
      "ContactCountryId": 373,
      "ContactOrgNr": "855608",
      "FaxPhone": "(178)106-4659 x7745",
      "MobilePhone": "(232)609-7023",
      "ContactPhone": "109.991.1520",
      "AssociateName": "Runolfsson-Flatley",
      "AssociateId": 353,
      "UsePersonAddress": false,
      "ContactFax": "autem",
      "Kanafname": "reiciendis",
      "Kanalname": "velit",
      "Post1": "cumque",
      "Post2": "et",
      "Post3": "beatae",
      "EmailName": "fausto.harber@quigley.uk",
      "ContactFullName": "Marquise Considine",
      "ActiveErpLinks": 90,
      "TicketPriorityId": 504,
      "SupportLanguageId": 820,
      "SupportAssociateId": 18,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1457722",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 169
        }
      }
    }
  ],
  "AlertLevel": 948,
  "ConnectId": 643,
  "ReadStatus": "Green",
  "TimeToReply": 257,
  "RealTimeToReply": 197,
  "TimeToClose": 320,
  "RealTimeToClose": 414,
  "TimeSpentInternally": 226,
  "TimeSpentExternally": 497,
  "TimeSpentQueue": 549,
  "RealTimeSpentInternally": 597,
  "RealTimeSpentExternally": 880,
  "RealTimeSpentQueue": 272,
  "TimeSpent": 360,
  "HasAttachment": false,
  "NumReplies": 927,
  "NumMessages": 534,
  "FromAddress": "quos",
  "Messages": [
    {
      "TicketMessageId": 724,
      "CreatedAt": "2011-09-04T14:32:12.1459269+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "perspiciatis",
      "PersonId": 973,
      "PersonFullName": "Mr. Elza Ignatius Jaskolski IV",
      "ContactId": 177,
      "ContactName": "Williamson-Emmerich",
      "ContactDepartment": "",
      "NumAttachments": 799,
      "EmailHeader": "ramiro@rodriguez.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "suscipit",
      "Sentiment": 461,
      "SentimentConfidence": 565,
      "CreatedBy": 336,
      "ChangedAt": "1999-09-02T14:32:12.1459269+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 580
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 183,
      "Name": "Boyle LLC",
      "ToolTip": "A harum aspernatur.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 351
        }
      }
    },
    {
      "Id": 183,
      "Name": "Boyle LLC",
      "ToolTip": "A harum aspernatur.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 351
        }
      }
    }
  ],
  "Language": "et",
  "Sentiment": 793,
  "SentimentConfidence": 469,
  "SuggestedCategoryId": 833,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 448,
  "IconHint": "est",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 331,
  "ExtraFields": {
    "ExtraFields1": "at",
    "ExtraFields2": "architecto"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 303
    }
  }
}
```