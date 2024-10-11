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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketId": 409,
  "Title": "eius",
  "CreatedAt": "1999-06-10T03:44:57.6250008+02:00",
  "LastChanged": "2016-09-10T03:44:57.6250008+02:00",
  "ReadByOwner": "2016-11-07T03:44:57.6250008+01:00",
  "ReadByCustomer": "2016-12-26T03:44:57.6250008+01:00",
  "FirstReadByOwner": "2007-07-29T03:44:57.6250008+02:00",
  "FirstReadByUser": "2017-11-25T03:44:57.6250008+01:00",
  "Activate": "2023-06-03T03:44:57.6250008+02:00",
  "ClosedAt": "2004-05-20T03:44:57.6250008+02:00",
  "RepliedAt": "2007-08-07T03:44:57.6250008+02:00",
  "AlertTimeout": "2020-01-15T03:44:57.6250008+01:00",
  "Deadline": "2007-12-12T03:44:57.6250008+01:00",
  "CreatedBy": null,
  "Author": "qui",
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
      "Position": "inventore",
      "PersonId": 981,
      "Mrmrs": "explicabo",
      "Firstname": "Colton",
      "Lastname": "Feeney",
      "MiddleName": "Nienow, Tillman and Bayer",
      "Title": "perspiciatis",
      "Description": "Customer-focused bi-directional migration",
      "Email": "max_kiehn@marquardt.co.uk",
      "FullName": "Dr. Ottilie Wisozk",
      "DirectPhone": "364-024-8612",
      "FormalName": "Skiles, Effertz and Simonis",
      "CountryId": 53,
      "ContactId": 671,
      "ContactName": "Trantow LLC",
      "Retired": 322,
      "Rank": 431,
      "ActiveInterests": 265,
      "ContactDepartment": "",
      "ContactCountryId": 527,
      "ContactOrgNr": "854732",
      "FaxPhone": "468.512.9543",
      "MobilePhone": "1-554-603-3685 x4785",
      "ContactPhone": "1-758-214-1211",
      "AssociateName": "Kihn-Dooley",
      "AssociateId": 337,
      "UsePersonAddress": false,
      "ContactFax": "sit",
      "Kanafname": "et",
      "Kanalname": "pariatur",
      "Post1": "sunt",
      "Post2": "voluptate",
      "Post3": "suscipit",
      "EmailName": "janelle@ernser.ca",
      "ContactFullName": "Ms. Art Clay Veum DVM",
      "ActiveErpLinks": 34,
      "TicketPriorityId": 523,
      "SupportLanguageId": 874,
      "SupportAssociateId": 696,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 362,
  "ConnectId": 29,
  "ReadStatus": "Green",
  "TimeToReply": 868,
  "RealTimeToReply": 461,
  "TimeToClose": 759,
  "RealTimeToClose": 783,
  "TimeSpentInternally": 880,
  "TimeSpentExternally": 713,
  "TimeSpentQueue": 420,
  "RealTimeSpentInternally": 862,
  "RealTimeSpentExternally": 997,
  "RealTimeSpentQueue": 231,
  "TimeSpent": 800,
  "HasAttachment": false,
  "NumReplies": 179,
  "NumMessages": 177,
  "FromAddress": "et",
  "Messages": [
    {
      "TicketMessageId": 663,
      "CreatedAt": "2019-11-12T03:44:57.6250008+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "in",
      "PersonId": 222,
      "PersonFullName": "Mrs. Eileen Verda Stiedemann",
      "ContactId": 472,
      "ContactName": "Bergnaum, Leffler and Collins",
      "ContactDepartment": "",
      "NumAttachments": 204,
      "EmailHeader": "raquel@barrows.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "nesciunt",
      "Sentiment": 18,
      "SentimentConfidence": 368,
      "CreatedBy": 64,
      "ChangedAt": "2006-10-09T03:44:57.6250008+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 802,
      "Name": "Howe Inc and Sons",
      "ToolTip": "Eveniet quia."
    },
    {
      "Id": 802,
      "Name": "Howe Inc and Sons",
      "ToolTip": "Eveniet quia."
    }
  ],
  "Language": "repellat",
  "Sentiment": 316,
  "SentimentConfidence": 223,
  "SuggestedCategoryId": 371,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 650,
  "IconHint": "ut",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 178,
  "ExtraFields": {
    "ExtraFields1": "iure",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "reprehenderit",
    "CustomFields2": "perspiciatis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 299,
  "Title": "omnis",
  "CreatedAt": "2021-04-04T03:44:57.6250008+02:00",
  "LastChanged": "2009-06-04T03:44:57.6250008+02:00",
  "ReadByOwner": "1998-08-04T03:44:57.6250008+02:00",
  "ReadByCustomer": "2004-06-02T03:44:57.6250008+02:00",
  "FirstReadByOwner": "1998-07-20T03:44:57.6250008+02:00",
  "FirstReadByUser": "2021-02-25T03:44:57.6250008+01:00",
  "Activate": "2020-05-13T03:44:57.6250008+02:00",
  "ClosedAt": "2020-02-08T03:44:57.6250008+01:00",
  "RepliedAt": "2004-01-14T03:44:57.6250008+01:00",
  "AlertTimeout": "2020-11-30T03:44:57.6250008+01:00",
  "Deadline": "2006-07-03T03:44:57.6250008+02:00",
  "CreatedBy": null,
  "Author": "sint",
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
      "Position": "eum",
      "PersonId": 944,
      "Mrmrs": "voluptas",
      "Firstname": "Nichole",
      "Lastname": "White",
      "MiddleName": "Daugherty, Stoltenberg and Kuhn",
      "Title": "corrupti",
      "Description": "Balanced modular complexity",
      "Email": "cheyanne_sipes@weimannkuhic.info",
      "FullName": "Justen Little",
      "DirectPhone": "1-590-984-3669 x0343",
      "FormalName": "Dicki-Kemmer",
      "CountryId": 230,
      "ContactId": 125,
      "ContactName": "Weber, Gusikowski and Rodriguez",
      "Retired": 991,
      "Rank": 364,
      "ActiveInterests": 210,
      "ContactDepartment": "",
      "ContactCountryId": 680,
      "ContactOrgNr": "769804",
      "FaxPhone": "569-058-6558 x239",
      "MobilePhone": "1-495-996-3219",
      "ContactPhone": "073.337.7654 x9592",
      "AssociateName": "Kautzer Group",
      "AssociateId": 782,
      "UsePersonAddress": true,
      "ContactFax": "dolor",
      "Kanafname": "animi",
      "Kanalname": "quis",
      "Post1": "ut",
      "Post2": "asperiores",
      "Post3": "aut",
      "EmailName": "retta.schaden@crona.co.uk",
      "ContactFullName": "Sedrick Mills",
      "ActiveErpLinks": 589,
      "TicketPriorityId": 265,
      "SupportLanguageId": 290,
      "SupportAssociateId": 569,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 867
        }
      }
    }
  ],
  "AlertLevel": 204,
  "ConnectId": 424,
  "ReadStatus": "Green",
  "TimeToReply": 725,
  "RealTimeToReply": 470,
  "TimeToClose": 153,
  "RealTimeToClose": 381,
  "TimeSpentInternally": 156,
  "TimeSpentExternally": 860,
  "TimeSpentQueue": 875,
  "RealTimeSpentInternally": 770,
  "RealTimeSpentExternally": 385,
  "RealTimeSpentQueue": 457,
  "TimeSpent": 353,
  "HasAttachment": true,
  "NumReplies": 550,
  "NumMessages": 956,
  "FromAddress": "perferendis",
  "Messages": [
    {
      "TicketMessageId": 263,
      "CreatedAt": "2003-07-24T03:44:57.6250008+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "eligendi",
      "PersonId": 922,
      "PersonFullName": "Kaleigh Nolan",
      "ContactId": 40,
      "ContactName": "Kihn Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 130,
      "EmailHeader": "ward@sipes.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "veritatis",
      "Sentiment": 879,
      "SentimentConfidence": 85,
      "CreatedBy": 453,
      "ChangedAt": "2001-11-06T03:44:57.640624+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 72
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 429,
      "Name": "Wilderman, Denesik and Homenick",
      "ToolTip": "Vel est.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 162
        }
      }
    },
    {
      "Id": 429,
      "Name": "Wilderman, Denesik and Homenick",
      "ToolTip": "Vel est.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 162
        }
      }
    }
  ],
  "Language": "omnis",
  "Sentiment": 209,
  "SentimentConfidence": 598,
  "SuggestedCategoryId": 615,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 628,
  "IconHint": "asperiores",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 802,
  "ExtraFields": {
    "ExtraFields1": "veritatis",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "ipsam",
    "CustomFields2": "sed"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 238
    }
  }
}
```