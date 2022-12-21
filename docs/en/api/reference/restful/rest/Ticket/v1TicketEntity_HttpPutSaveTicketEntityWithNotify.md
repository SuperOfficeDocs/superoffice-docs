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
| CreatedBy |  | The associate who created this ticket |
| Author | string | A string representing the author of the ticket (same as author of first message). |
| OwnedBy |  | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category |  | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority |  | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status |  | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person |  | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 400 | Bad request. Entity to save is not in request body. |

Response body: 

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
| CreatedBy |  | The associate who created this ticket |
| Author | string | A string representing the author of the ticket (same as author of first message). |
| OwnedBy |  | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category |  | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority |  | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status |  | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person |  | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 988,
  "Title": "dolor",
  "CreatedAt": "2015-11-02T02:49:51.5831853+01:00",
  "LastChanged": "2014-03-28T02:49:51.5831853+01:00",
  "ReadByOwner": "2020-04-02T02:49:51.5831853+02:00",
  "ReadByCustomer": "2012-11-18T02:49:51.5831853+01:00",
  "FirstReadByOwner": "1996-01-14T02:49:51.5831853+01:00",
  "FirstReadByUser": "2002-04-16T02:49:51.5831853+02:00",
  "Activate": "2013-06-29T02:49:51.5831853+02:00",
  "ClosedAt": "2015-12-20T02:49:51.5831853+01:00",
  "RepliedAt": "2007-07-21T02:49:51.5831853+02:00",
  "AlertTimeout": "2003-08-31T02:49:51.5831853+02:00",
  "Deadline": "2012-12-01T02:49:51.5831853+01:00",
  "CreatedBy": null,
  "Author": "vitae",
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
      "Position": "eius",
      "PersonId": 865,
      "Mrmrs": "magnam",
      "Firstname": "Elinor",
      "Lastname": "Nitzsche",
      "MiddleName": "Rowe LLC",
      "Title": "consequatur",
      "Description": "Intuitive tangible success",
      "Email": "oswald_moen@aufderhar.biz",
      "FullName": "Guy Schuppe",
      "DirectPhone": "459.902.0602 x587",
      "FormalName": "West, Feest and Mueller",
      "CountryId": 255,
      "ContactId": 664,
      "ContactName": "Mills-Metz",
      "Retired": 294,
      "Rank": 953,
      "ActiveInterests": 101,
      "ContactDepartment": "",
      "ContactCountryId": 358,
      "ContactOrgNr": "1038612",
      "FaxPhone": "801-831-0605",
      "MobilePhone": "1-377-415-4879 x3887",
      "ContactPhone": "(434)590-5376",
      "AssociateName": "Wolff, Gerhold and Schneider",
      "AssociateId": 347,
      "UsePersonAddress": true,
      "ContactFax": "sapiente",
      "Kanafname": "aliquam",
      "Kanalname": "amet",
      "Post1": "fugiat",
      "Post2": "quae",
      "Post3": "et",
      "EmailName": "hailie@mcclure.uk",
      "ContactFullName": "Ms. Maggie Michel Hagenes DDS",
      "ActiveErpLinks": 696,
      "TicketPriorityId": 362,
      "SupportLanguageId": 744,
      "SupportAssociateId": 506,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 147,
  "ConnectId": 12,
  "ReadStatus": "Green",
  "TimeToReply": 576,
  "RealTimeToReply": 131,
  "TimeToClose": 255,
  "RealTimeToClose": 462,
  "TimeSpentInternally": 326,
  "TimeSpentExternally": 990,
  "TimeSpentQueue": 712,
  "RealTimeSpentInternally": 886,
  "RealTimeSpentExternally": 582,
  "RealTimeSpentQueue": 36,
  "HasAttachment": false,
  "NumReplies": 613,
  "NumMessages": 240,
  "FromAddress": "fugiat",
  "Messages": [
    {
      "TicketMessageId": 266,
      "CreatedAt": "2016-02-06T02:49:51.5831853+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "fuga",
      "PersonId": 859,
      "PersonFullName": "Dr. Dameon Mable Pfeffer",
      "ContactId": 640,
      "ContactName": "White, Jewess and Spinka",
      "ContactDepartment": "",
      "NumAttachments": 263,
      "EmailHeader": "dallin@johnston.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "dolores",
      "Sentiment": 6,
      "SentimentConfidence": 513,
      "CreatedBy": 309,
      "ChangedAt": "2007-04-12T02:49:51.5831853+02:00"
    }
  ],
  "Tags": [
    {
      "Id": 790,
      "Name": "Wilderman, Reichel and Gusikowski",
      "ToolTip": "Facere nobis quia numquam neque ullam quia."
    },
    {
      "Id": 790,
      "Name": "Wilderman, Reichel and Gusikowski",
      "ToolTip": "Facere nobis quia numquam neque ullam quia."
    }
  ],
  "Language": "reprehenderit",
  "Sentiment": 733,
  "SentimentConfidence": 305,
  "SuggestedCategoryId": 281,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 488,
  "IconHint": "rerum",
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "mollitia"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "ad"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 394,
  "Title": "sed",
  "CreatedAt": "2011-08-15T02:49:51.5988104+02:00",
  "LastChanged": "2014-02-09T02:49:51.5988104+01:00",
  "ReadByOwner": "2016-12-27T02:49:51.5988104+01:00",
  "ReadByCustomer": "2012-12-26T02:49:51.5988104+01:00",
  "FirstReadByOwner": "2015-11-20T02:49:51.5988104+01:00",
  "FirstReadByUser": "1999-06-12T02:49:51.5988104+02:00",
  "Activate": "2002-01-28T02:49:51.5988104+01:00",
  "ClosedAt": "2006-04-13T02:49:51.5988104+02:00",
  "RepliedAt": "2020-06-07T02:49:51.5988104+02:00",
  "AlertTimeout": "1995-07-30T02:49:51.5988104+02:00",
  "Deadline": "2017-06-21T02:49:51.5988104+02:00",
  "CreatedBy": null,
  "Author": "hic",
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
      "Position": "voluptas",
      "PersonId": 697,
      "Mrmrs": "omnis",
      "Firstname": "Donato",
      "Lastname": "Powlowski",
      "MiddleName": "Kihn-DuBuque",
      "Title": "doloremque",
      "Description": "Synergized multi-state focus group",
      "Email": "teresa@paucek.com",
      "FullName": "Brown Celine Stark DVM",
      "DirectPhone": "1-161-443-3796 x607",
      "FormalName": "Walter-Runte",
      "CountryId": 566,
      "ContactId": 594,
      "ContactName": "Erdman Group",
      "Retired": 74,
      "Rank": 924,
      "ActiveInterests": 436,
      "ContactDepartment": "",
      "ContactCountryId": 28,
      "ContactOrgNr": "1188761",
      "FaxPhone": "294.014.4953 x39056",
      "MobilePhone": "388-821-9303",
      "ContactPhone": "1-780-819-2862 x3314",
      "AssociateName": "Schinner, Stoltenberg and Collier",
      "AssociateId": 449,
      "UsePersonAddress": false,
      "ContactFax": "enim",
      "Kanafname": "ut",
      "Kanalname": "qui",
      "Post1": "alias",
      "Post2": "repudiandae",
      "Post3": "animi",
      "EmailName": "wyman@schulist.com",
      "ContactFullName": "Kade Zulauf II",
      "ActiveErpLinks": 829,
      "TicketPriorityId": 454,
      "SupportLanguageId": 296,
      "SupportAssociateId": 438,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 44
        }
      }
    }
  ],
  "AlertLevel": 225,
  "ConnectId": 129,
  "ReadStatus": "Green",
  "TimeToReply": 828,
  "RealTimeToReply": 563,
  "TimeToClose": 149,
  "RealTimeToClose": 834,
  "TimeSpentInternally": 915,
  "TimeSpentExternally": 490,
  "TimeSpentQueue": 128,
  "RealTimeSpentInternally": 777,
  "RealTimeSpentExternally": 733,
  "RealTimeSpentQueue": 719,
  "HasAttachment": false,
  "NumReplies": 495,
  "NumMessages": 685,
  "FromAddress": "autem",
  "Messages": [
    {
      "TicketMessageId": 196,
      "CreatedAt": "1996-04-01T02:49:51.5988104+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "praesentium",
      "PersonId": 783,
      "PersonFullName": "Prof. Stephan Aufderhar",
      "ContactId": 225,
      "ContactName": "Anderson-Nicolas",
      "ContactDepartment": "",
      "NumAttachments": 329,
      "EmailHeader": "elva@cronin.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quia",
      "Sentiment": 34,
      "SentimentConfidence": 535,
      "CreatedBy": 901,
      "ChangedAt": "2020-10-21T02:49:51.5988104+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 295
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 636,
      "Name": "Bechtelar-Conroy",
      "ToolTip": "Ad est molestiae quis optio.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 440
        }
      }
    },
    {
      "Id": 636,
      "Name": "Bechtelar-Conroy",
      "ToolTip": "Ad est molestiae quis optio.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 440
        }
      }
    }
  ],
  "Language": "consequatur",
  "Sentiment": 394,
  "SentimentConfidence": 72,
  "SuggestedCategoryId": 489,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 552,
  "IconHint": "quaerat",
  "ExtraFields": {
    "ExtraFields1": "illo",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "aperiam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 786
    }
  }
}
```