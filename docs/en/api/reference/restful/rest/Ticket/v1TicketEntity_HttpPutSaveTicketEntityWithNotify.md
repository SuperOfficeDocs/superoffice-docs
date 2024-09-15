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
  "TicketId": 303,
  "Title": "ut",
  "CreatedAt": "2010-04-06T04:02:06.8691214+02:00",
  "LastChanged": "2019-05-02T04:02:06.8691214+02:00",
  "ReadByOwner": "2017-07-08T04:02:06.8691214+02:00",
  "ReadByCustomer": "1998-06-30T04:02:06.8691214+02:00",
  "FirstReadByOwner": "1999-08-23T04:02:06.8691214+02:00",
  "FirstReadByUser": "2005-08-16T04:02:06.8691214+02:00",
  "Activate": "1999-12-22T04:02:06.8691214+01:00",
  "ClosedAt": "2011-10-09T04:02:06.8691214+02:00",
  "RepliedAt": "2004-07-05T04:02:06.8691214+02:00",
  "AlertTimeout": "2003-12-20T04:02:06.8691214+01:00",
  "Deadline": "2012-12-16T04:02:06.8691214+01:00",
  "CreatedBy": null,
  "Author": "neque",
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
      "Position": "provident",
      "PersonId": 897,
      "Mrmrs": "ex",
      "Firstname": "Cathrine",
      "Lastname": "Kuhic",
      "MiddleName": "Jacobi Group",
      "Title": "optio",
      "Description": "Vision-oriented local open architecture",
      "Email": "dovie.carter@stehr.co.uk",
      "FullName": "Jeff Ward",
      "DirectPhone": "(998)231-7026",
      "FormalName": "Williamson Group",
      "CountryId": 374,
      "ContactId": 308,
      "ContactName": "Conroy Inc and Sons",
      "Retired": 220,
      "Rank": 897,
      "ActiveInterests": 776,
      "ContactDepartment": "",
      "ContactCountryId": 313,
      "ContactOrgNr": "626407",
      "FaxPhone": "(483)110-7178 x78696",
      "MobilePhone": "(859)804-2545 x673",
      "ContactPhone": "1-472-762-8380 x4380",
      "AssociateName": "Gibson-Zboncak",
      "AssociateId": 90,
      "UsePersonAddress": false,
      "ContactFax": "pariatur",
      "Kanafname": "nobis",
      "Kanalname": "ab",
      "Post1": "sunt",
      "Post2": "repudiandae",
      "Post3": "ipsa",
      "EmailName": "yolanda.johnston@starkwaters.uk",
      "ContactFullName": "Miss Tom Dolly Hudson",
      "ActiveErpLinks": 204,
      "TicketPriorityId": 987,
      "SupportLanguageId": 844,
      "SupportAssociateId": 528,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 138,
  "ConnectId": 574,
  "ReadStatus": "Green",
  "TimeToReply": 543,
  "RealTimeToReply": 177,
  "TimeToClose": 79,
  "RealTimeToClose": 93,
  "TimeSpentInternally": 879,
  "TimeSpentExternally": 855,
  "TimeSpentQueue": 324,
  "RealTimeSpentInternally": 487,
  "RealTimeSpentExternally": 839,
  "RealTimeSpentQueue": 196,
  "TimeSpent": 789,
  "HasAttachment": true,
  "NumReplies": 156,
  "NumMessages": 37,
  "FromAddress": "consectetur",
  "Messages": [
    {
      "TicketMessageId": 433,
      "CreatedAt": "2004-04-28T04:02:06.8691214+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "et",
      "PersonId": 596,
      "PersonFullName": "Ryleigh Wilkinson",
      "ContactId": 577,
      "ContactName": "Turner, Veum and Ziemann",
      "ContactDepartment": "",
      "NumAttachments": 827,
      "EmailHeader": "devin.mann@hagenes.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "aut",
      "Sentiment": 491,
      "SentimentConfidence": 210,
      "CreatedBy": 359,
      "ChangedAt": "2001-02-08T04:02:06.8847446+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 605,
      "Name": "Kemmer Group",
      "ToolTip": "Maxime nostrum et perspiciatis a amet."
    },
    {
      "Id": 605,
      "Name": "Kemmer Group",
      "ToolTip": "Maxime nostrum et perspiciatis a amet."
    }
  ],
  "Language": "qui",
  "Sentiment": 769,
  "SentimentConfidence": 798,
  "SuggestedCategoryId": 786,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 20,
  "IconHint": "soluta",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 696,
  "ExtraFields": {
    "ExtraFields1": "amet",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "accusamus",
    "CustomFields2": "rerum"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 338,
  "Title": "quia",
  "CreatedAt": "2016-02-13T04:02:06.8847446+01:00",
  "LastChanged": "2009-10-22T04:02:06.8847446+02:00",
  "ReadByOwner": "1999-04-07T04:02:06.8847446+02:00",
  "ReadByCustomer": "2018-01-03T04:02:06.8847446+01:00",
  "FirstReadByOwner": "2008-09-13T04:02:06.8847446+02:00",
  "FirstReadByUser": "2013-05-24T04:02:06.8847446+02:00",
  "Activate": "2002-10-10T04:02:06.8847446+02:00",
  "ClosedAt": "2022-11-10T04:02:06.8847446+01:00",
  "RepliedAt": "2001-08-26T04:02:06.8847446+02:00",
  "AlertTimeout": "2010-12-29T04:02:06.8847446+01:00",
  "Deadline": "2001-11-25T04:02:06.8847446+01:00",
  "CreatedBy": null,
  "Author": "tenetur",
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
      "Position": "accusantium",
      "PersonId": 968,
      "Mrmrs": "est",
      "Firstname": "Assunta",
      "Lastname": "Medhurst",
      "MiddleName": "Pfeffer-Nikolaus",
      "Title": "commodi",
      "Description": "Open-architected motivating infrastructure",
      "Email": "judd_blanda@binsbauch.ca",
      "FullName": "Desiree Breitenberg",
      "DirectPhone": "1-514-577-1279",
      "FormalName": "Tromp-Maggio",
      "CountryId": 962,
      "ContactId": 885,
      "ContactName": "Leannon-O'Conner",
      "Retired": 644,
      "Rank": 234,
      "ActiveInterests": 846,
      "ContactDepartment": "",
      "ContactCountryId": 819,
      "ContactOrgNr": "1219354",
      "FaxPhone": "1-369-720-7710 x3049",
      "MobilePhone": "(677)079-9994 x8543",
      "ContactPhone": "612.739.6333 x3102",
      "AssociateName": "Grimes, Vandervort and Howe",
      "AssociateId": 37,
      "UsePersonAddress": true,
      "ContactFax": "earum",
      "Kanafname": "dolorem",
      "Kanalname": "provident",
      "Post1": "pariatur",
      "Post2": "sapiente",
      "Post3": "illo",
      "EmailName": "ethel@sipes.info",
      "ContactFullName": "Miss Evangeline Braulio Dicki Sr.",
      "ActiveErpLinks": 690,
      "TicketPriorityId": 796,
      "SupportLanguageId": 626,
      "SupportAssociateId": 905,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 640
        }
      }
    }
  ],
  "AlertLevel": 912,
  "ConnectId": 713,
  "ReadStatus": "Green",
  "TimeToReply": 766,
  "RealTimeToReply": 704,
  "TimeToClose": 496,
  "RealTimeToClose": 722,
  "TimeSpentInternally": 616,
  "TimeSpentExternally": 883,
  "TimeSpentQueue": 97,
  "RealTimeSpentInternally": 24,
  "RealTimeSpentExternally": 260,
  "RealTimeSpentQueue": 918,
  "TimeSpent": 681,
  "HasAttachment": false,
  "NumReplies": 441,
  "NumMessages": 677,
  "FromAddress": "est",
  "Messages": [
    {
      "TicketMessageId": 860,
      "CreatedAt": "2010-05-09T04:02:06.8847446+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "et",
      "PersonId": 171,
      "PersonFullName": "Emmanuel Kozey",
      "ContactId": 893,
      "ContactName": "Satterfield-Walker",
      "ContactDepartment": "",
      "NumAttachments": 209,
      "EmailHeader": "ramiro.oconnell@cormierbergnaum.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quaerat",
      "Sentiment": 373,
      "SentimentConfidence": 36,
      "CreatedBy": 330,
      "ChangedAt": "2015-05-19T04:02:06.8847446+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 27
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 678,
      "Name": "Bergstrom-Jenkins",
      "ToolTip": "Qui facilis id perferendis alias magni laborum omnis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 245
        }
      }
    },
    {
      "Id": 678,
      "Name": "Bergstrom-Jenkins",
      "ToolTip": "Qui facilis id perferendis alias magni laborum omnis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 245
        }
      }
    }
  ],
  "Language": "a",
  "Sentiment": 725,
  "SentimentConfidence": 284,
  "SuggestedCategoryId": 658,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 258,
  "IconHint": "dolores",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 503,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "aliquid"
  },
  "CustomFields": {
    "CustomFields1": "quod",
    "CustomFields2": "aliquid"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 915
    }
  }
}
```