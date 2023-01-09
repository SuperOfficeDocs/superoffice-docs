---
title: PUT Ticket/{id}
uid: v1TicketEntity_HttpPutSaveTicketEntityWithNotify
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
PUT /api/v1/Ticket/{id}?notify=True
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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
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
| OwnedBy | Associate | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category | TicketCategoryEntity | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority | TicketPriorityEntity | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status | TicketStatusEntity | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person | Person | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
| SecondaryPersons | array | The secondary persons this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketId": 626,
  "Title": "eligendi",
  "CreatedAt": "2015-10-31T17:37:39.282304+01:00",
  "LastChanged": "1996-04-26T17:37:39.282304+02:00",
  "ReadByOwner": "2000-07-14T17:37:39.282304+02:00",
  "ReadByCustomer": "2002-05-10T17:37:39.282304+02:00",
  "FirstReadByOwner": "2018-07-17T17:37:39.282304+02:00",
  "FirstReadByUser": "2001-12-18T17:37:39.282304+01:00",
  "Activate": "2017-12-18T17:37:39.282304+01:00",
  "ClosedAt": "1998-04-27T17:37:39.282304+02:00",
  "RepliedAt": "2009-11-06T17:37:39.282304+01:00",
  "AlertTimeout": "2001-01-04T17:37:39.282304+01:00",
  "Deadline": "2006-12-06T17:37:39.282304+01:00",
  "CreatedBy": null,
  "Author": "maxime",
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
      "Position": "et",
      "PersonId": 366,
      "Mrmrs": "quia",
      "Firstname": "Barrett",
      "Lastname": "Witting",
      "MiddleName": "Blanda LLC",
      "Title": "animi",
      "Description": "Right-sized encompassing approach",
      "Email": "julius.spinka@botsford.com",
      "FullName": "Mylene Schumm",
      "DirectPhone": "(830)249-7463 x3876",
      "FormalName": "Feil Group",
      "CountryId": 901,
      "ContactId": 302,
      "ContactName": "Frami-West",
      "Retired": 939,
      "Rank": 570,
      "ActiveInterests": 957,
      "ContactDepartment": "",
      "ContactCountryId": 893,
      "ContactOrgNr": "1313401",
      "FaxPhone": "(326)218-5780 x859",
      "MobilePhone": "051-583-0232 x422",
      "ContactPhone": "1-804-805-1952",
      "AssociateName": "Monahan Inc and Sons",
      "AssociateId": 177,
      "UsePersonAddress": false,
      "ContactFax": "officiis",
      "Kanafname": "illo",
      "Kanalname": "ipsa",
      "Post1": "porro",
      "Post2": "dignissimos",
      "Post3": "sunt",
      "EmailName": "aric@champlin.biz",
      "ContactFullName": "Kaycee Windler",
      "ActiveErpLinks": 574,
      "TicketPriorityId": 259,
      "SupportLanguageId": 568,
      "SupportAssociateId": 883,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 117,
  "ConnectId": 395,
  "ReadStatus": "Green",
  "TimeToReply": 67,
  "RealTimeToReply": 924,
  "TimeToClose": 957,
  "RealTimeToClose": 940,
  "TimeSpentInternally": 924,
  "TimeSpentExternally": 191,
  "TimeSpentQueue": 764,
  "RealTimeSpentInternally": 653,
  "RealTimeSpentExternally": 737,
  "RealTimeSpentQueue": 227,
  "HasAttachment": false,
  "NumReplies": 508,
  "NumMessages": 895,
  "FromAddress": "qui",
  "Messages": [
    {
      "TicketMessageId": 78,
      "CreatedAt": "2015-11-22T17:37:39.287306+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "rem",
      "PersonId": 707,
      "PersonFullName": "Norene Gulgowski",
      "ContactId": 376,
      "ContactName": "Schmeler-Wolff",
      "ContactDepartment": "",
      "NumAttachments": 576,
      "EmailHeader": "gail@hand.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "et",
      "Sentiment": 563,
      "SentimentConfidence": 686,
      "CreatedBy": 581,
      "ChangedAt": "2020-08-30T17:37:39.287306+02:00"
    }
  ],
  "Tags": [
    {
      "Id": 180,
      "Name": "Homenick-DuBuque",
      "ToolTip": "Magnam rerum praesentium officia nobis sapiente."
    },
    {
      "Id": 180,
      "Name": "Homenick-DuBuque",
      "ToolTip": "Magnam rerum praesentium officia nobis sapiente."
    }
  ],
  "Language": "perspiciatis",
  "Sentiment": 420,
  "SentimentConfidence": 270,
  "SuggestedCategoryId": 886,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 13,
  "IconHint": "soluta",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "ullam",
    "CustomFields2": "omnis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 389,
  "Title": "et",
  "CreatedAt": "2003-03-31T17:37:39.2953072+02:00",
  "LastChanged": "2018-05-08T17:37:39.2953072+02:00",
  "ReadByOwner": "2003-12-28T17:37:39.2953072+01:00",
  "ReadByCustomer": "2021-03-13T17:37:39.2953072+01:00",
  "FirstReadByOwner": "2004-11-06T17:37:39.2953072+01:00",
  "FirstReadByUser": "2008-01-24T17:37:39.2953072+01:00",
  "Activate": "2006-07-07T17:37:39.2953072+02:00",
  "ClosedAt": "1998-09-30T17:37:39.2953072+02:00",
  "RepliedAt": "1998-12-20T17:37:39.2953072+01:00",
  "AlertTimeout": "2004-01-30T17:37:39.2953072+01:00",
  "Deadline": "2011-02-02T17:37:39.2953072+01:00",
  "CreatedBy": null,
  "Author": "officiis",
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
      "Position": "velit",
      "PersonId": 356,
      "Mrmrs": "aut",
      "Firstname": "Maya",
      "Lastname": "Mosciski",
      "MiddleName": "Jewess Group",
      "Title": "est",
      "Description": "Future-proofed actuating projection",
      "Email": "stone_rosenbaum@schaden.co.uk",
      "FullName": "Miss Miguel Russel",
      "DirectPhone": "100.973.6996 x7305",
      "FormalName": "Metz, Okuneva and Auer",
      "CountryId": 933,
      "ContactId": 595,
      "ContactName": "Considine-Dare",
      "Retired": 649,
      "Rank": 275,
      "ActiveInterests": 529,
      "ContactDepartment": "",
      "ContactCountryId": 618,
      "ContactOrgNr": "1373156",
      "FaxPhone": "630.074.2240 x75476",
      "MobilePhone": "201-541-7083 x687",
      "ContactPhone": "1-524-805-3626 x796",
      "AssociateName": "Bartell Inc and Sons",
      "AssociateId": 553,
      "UsePersonAddress": false,
      "ContactFax": "asperiores",
      "Kanafname": "suscipit",
      "Kanalname": "nulla",
      "Post1": "nostrum",
      "Post2": "culpa",
      "Post3": "et",
      "EmailName": "johnathan_hoeger@smith.us",
      "ContactFullName": "Alvena Gislason",
      "ActiveErpLinks": 722,
      "TicketPriorityId": 894,
      "SupportLanguageId": 574,
      "SupportAssociateId": 656,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 556
        }
      }
    }
  ],
  "AlertLevel": 454,
  "ConnectId": 932,
  "ReadStatus": "Green",
  "TimeToReply": 849,
  "RealTimeToReply": 489,
  "TimeToClose": 515,
  "RealTimeToClose": 211,
  "TimeSpentInternally": 906,
  "TimeSpentExternally": 532,
  "TimeSpentQueue": 467,
  "RealTimeSpentInternally": 545,
  "RealTimeSpentExternally": 896,
  "RealTimeSpentQueue": 336,
  "HasAttachment": false,
  "NumReplies": 50,
  "NumMessages": 619,
  "FromAddress": "sit",
  "Messages": [
    {
      "TicketMessageId": 358,
      "CreatedAt": "1999-10-27T17:37:39.2993034+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "sit",
      "PersonId": 497,
      "PersonFullName": "Beverly Flatley",
      "ContactId": 529,
      "ContactName": "Prosacco Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 818,
      "EmailHeader": "lenna_borer@medhurstruecker.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "vel",
      "Sentiment": 656,
      "SentimentConfidence": 74,
      "CreatedBy": 113,
      "ChangedAt": "2016-05-18T17:37:39.300304+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 143
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 772,
      "Name": "Langworth, Ullrich and Bogan",
      "ToolTip": "Debitis et aperiam exercitationem et praesentium.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 165
        }
      }
    },
    {
      "Id": 772,
      "Name": "Langworth, Ullrich and Bogan",
      "ToolTip": "Debitis et aperiam exercitationem et praesentium.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 165
        }
      }
    }
  ],
  "Language": "sit",
  "Sentiment": 628,
  "SentimentConfidence": 656,
  "SuggestedCategoryId": 943,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 265,
  "IconHint": "voluptas",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "in",
    "ExtraFields2": "ipsam"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "veniam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 532
    }
  }
}
```