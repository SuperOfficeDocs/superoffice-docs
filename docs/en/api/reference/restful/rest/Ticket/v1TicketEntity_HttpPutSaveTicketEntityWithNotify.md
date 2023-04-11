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
  "TicketId": 468,
  "Title": "doloribus",
  "CreatedAt": "1998-11-18T15:29:30.6844882+01:00",
  "LastChanged": "2021-03-29T15:29:30.6844882+02:00",
  "ReadByOwner": "2021-12-26T15:29:30.6844882+01:00",
  "ReadByCustomer": "2019-02-13T15:29:30.6844882+01:00",
  "FirstReadByOwner": "1996-05-15T15:29:30.6844882+02:00",
  "FirstReadByUser": "2003-06-02T15:29:30.6844882+02:00",
  "Activate": "2021-01-01T15:29:30.6844882+01:00",
  "ClosedAt": "2003-02-10T15:29:30.6844882+01:00",
  "RepliedAt": "2010-04-25T15:29:30.6844882+02:00",
  "AlertTimeout": "2009-04-09T15:29:30.6844882+02:00",
  "Deadline": "2009-04-20T15:29:30.6844882+02:00",
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
      "Position": "suscipit",
      "PersonId": 910,
      "Mrmrs": "omnis",
      "Firstname": "Connie",
      "Lastname": "Lueilwitz",
      "MiddleName": "Bechtelar-Mraz",
      "Title": "quos",
      "Description": "Profound motivating hub",
      "Email": "olga@hegmanngoodwin.biz",
      "FullName": "Leann Trantow",
      "DirectPhone": "(138)405-5736 x63235",
      "FormalName": "Windler-Koepp",
      "CountryId": 873,
      "ContactId": 671,
      "ContactName": "Douglas, Weber and Price",
      "Retired": 314,
      "Rank": 298,
      "ActiveInterests": 140,
      "ContactDepartment": "",
      "ContactCountryId": 530,
      "ContactOrgNr": "1050311",
      "FaxPhone": "091.708.0995 x120",
      "MobilePhone": "1-610-159-1828",
      "ContactPhone": "177-753-4307",
      "AssociateName": "Harris-Davis",
      "AssociateId": 618,
      "UsePersonAddress": false,
      "ContactFax": "quos",
      "Kanafname": "voluptatum",
      "Kanalname": "reprehenderit",
      "Post1": "et",
      "Post2": "nesciunt",
      "Post3": "voluptas",
      "EmailName": "bethel@strackerussel.us",
      "ContactFullName": "Thalia Klocko",
      "ActiveErpLinks": 422,
      "TicketPriorityId": 788,
      "SupportLanguageId": 40,
      "SupportAssociateId": 215,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 827,
  "ConnectId": 309,
  "ReadStatus": "Green",
  "TimeToReply": 217,
  "RealTimeToReply": 112,
  "TimeToClose": 356,
  "RealTimeToClose": 278,
  "TimeSpentInternally": 333,
  "TimeSpentExternally": 704,
  "TimeSpentQueue": 320,
  "RealTimeSpentInternally": 94,
  "RealTimeSpentExternally": 68,
  "RealTimeSpentQueue": 47,
  "HasAttachment": false,
  "NumReplies": 131,
  "NumMessages": 240,
  "FromAddress": "totam",
  "Messages": [
    {
      "TicketMessageId": 235,
      "CreatedAt": "2002-09-05T15:29:30.6889863+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "at",
      "PersonId": 804,
      "PersonFullName": "Vincenza Veum",
      "ContactId": 673,
      "ContactName": "Wilderman, Sanford and Kuphal",
      "ContactDepartment": "",
      "NumAttachments": 414,
      "EmailHeader": "marcella.king@bradtke.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "harum",
      "Sentiment": 647,
      "SentimentConfidence": 185,
      "CreatedBy": 526,
      "ChangedAt": "2015-10-06T15:29:30.6904862+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 269,
      "Name": "Zemlak-Windler",
      "ToolTip": "Placeat et velit vitae provident dolor quo et."
    },
    {
      "Id": 269,
      "Name": "Zemlak-Windler",
      "ToolTip": "Placeat et velit vitae provident dolor quo et."
    }
  ],
  "Language": "incidunt",
  "Sentiment": 489,
  "SentimentConfidence": 655,
  "SuggestedCategoryId": 21,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 384,
  "IconHint": "ut",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "libero",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "reiciendis",
    "CustomFields2": "asperiores"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 573,
  "Title": "dignissimos",
  "CreatedAt": "2014-06-26T15:29:30.6974864+02:00",
  "LastChanged": "2013-08-08T15:29:30.6974864+02:00",
  "ReadByOwner": "2022-04-02T15:29:30.6974864+02:00",
  "ReadByCustomer": "2002-03-03T15:29:30.6974864+01:00",
  "FirstReadByOwner": "2015-07-03T15:29:30.6974864+02:00",
  "FirstReadByUser": "2000-09-14T15:29:30.6974864+02:00",
  "Activate": "2011-09-17T15:29:30.6974864+02:00",
  "ClosedAt": "2016-03-28T15:29:30.6974864+02:00",
  "RepliedAt": "2016-09-02T15:29:30.6974864+02:00",
  "AlertTimeout": "2013-10-25T15:29:30.6974864+02:00",
  "Deadline": "2014-06-21T15:29:30.6974864+02:00",
  "CreatedBy": null,
  "Author": "minima",
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
      "Position": "tempore",
      "PersonId": 878,
      "Mrmrs": "praesentium",
      "Firstname": "Andy",
      "Lastname": "Witting",
      "MiddleName": "Heaney Group",
      "Title": "ut",
      "Description": "Function-based impactful structure",
      "Email": "ted@rempel.name",
      "FullName": "Ms. Leanne Kshlerin V",
      "DirectPhone": "1-936-355-6422",
      "FormalName": "Ziemann, Reichel and Lesch",
      "CountryId": 581,
      "ContactId": 129,
      "ContactName": "D'Amore LLC",
      "Retired": 678,
      "Rank": 566,
      "ActiveInterests": 135,
      "ContactDepartment": "repurpose wireless users",
      "ContactCountryId": 87,
      "ContactOrgNr": "948766",
      "FaxPhone": "417-366-9509 x0812",
      "MobilePhone": "359.365.6717",
      "ContactPhone": "1-479-787-5352 x502",
      "AssociateName": "Glover, Rowe and Sauer",
      "AssociateId": 806,
      "UsePersonAddress": false,
      "ContactFax": "ut",
      "Kanafname": "quae",
      "Kanalname": "qui",
      "Post1": "quis",
      "Post2": "rem",
      "Post3": "qui",
      "EmailName": "carmela.goldner@labadieheathcote.biz",
      "ContactFullName": "Weldon Cummings",
      "ActiveErpLinks": 577,
      "TicketPriorityId": 766,
      "SupportLanguageId": 992,
      "SupportAssociateId": 772,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 50
        }
      }
    }
  ],
  "AlertLevel": 259,
  "ConnectId": 781,
  "ReadStatus": "Green",
  "TimeToReply": 700,
  "RealTimeToReply": 977,
  "TimeToClose": 140,
  "RealTimeToClose": 570,
  "TimeSpentInternally": 414,
  "TimeSpentExternally": 49,
  "TimeSpentQueue": 123,
  "RealTimeSpentInternally": 550,
  "RealTimeSpentExternally": 402,
  "RealTimeSpentQueue": 854,
  "HasAttachment": true,
  "NumReplies": 984,
  "NumMessages": 376,
  "FromAddress": "culpa",
  "Messages": [
    {
      "TicketMessageId": 371,
      "CreatedAt": "2017-10-25T15:29:30.7019897+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "dolor",
      "PersonId": 888,
      "PersonFullName": "Mohamed Pfeffer",
      "ContactId": 231,
      "ContactName": "Herzog-Leuschke",
      "ContactDepartment": "",
      "NumAttachments": 507,
      "EmailHeader": "reggie_haley@ortiz.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "aut",
      "Sentiment": 738,
      "SentimentConfidence": 522,
      "CreatedBy": 290,
      "ChangedAt": "2003-01-25T15:29:30.7024864+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 282
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 339,
      "Name": "Abbott LLC",
      "ToolTip": "Veniam rerum aut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 863
        }
      }
    },
    {
      "Id": 339,
      "Name": "Abbott LLC",
      "ToolTip": "Veniam rerum aut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 863
        }
      }
    }
  ],
  "Language": "similique",
  "Sentiment": 777,
  "SentimentConfidence": 391,
  "SuggestedCategoryId": 547,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 770,
  "IconHint": "tempora",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "consequuntur"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "consectetur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 789
    }
  }
}
```