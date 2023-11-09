---
title: POST Ticket
uid: v1TicketEntity_HttpPostSaveTicketEntityWithNotify
generated: true
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
| TicketType | TicketTypeEntity | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
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
| Sale | Sale | The sale that this ticket is connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket is connected to  <para>Use MDO List name "project" to get list items.</para> |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| TicketType | TicketTypeEntity | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Ticket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketId": 109,
  "Title": "et",
  "CreatedAt": "2020-04-01T11:06:42.2541028+02:00",
  "LastChanged": "2001-03-31T11:06:42.2541028+02:00",
  "ReadByOwner": "2004-11-13T11:06:42.2541028+01:00",
  "ReadByCustomer": "2015-09-04T11:06:42.2541028+02:00",
  "FirstReadByOwner": "2002-11-11T11:06:42.2541028+01:00",
  "FirstReadByUser": "2021-10-15T11:06:42.2541028+02:00",
  "Activate": "2011-06-16T11:06:42.2541028+02:00",
  "ClosedAt": "2022-07-22T11:06:42.2541028+02:00",
  "RepliedAt": "2019-10-14T11:06:42.2541028+02:00",
  "AlertTimeout": "2009-12-27T11:06:42.2541028+01:00",
  "Deadline": "2004-06-02T11:06:42.2541028+02:00",
  "CreatedBy": null,
  "Author": "fugit",
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
      "Position": "vitae",
      "PersonId": 990,
      "Mrmrs": "mollitia",
      "Firstname": "Ole",
      "Lastname": "Funk",
      "MiddleName": "Marks, Pouros and Padberg",
      "Title": "qui",
      "Description": "Cross-group upward-trending policy",
      "Email": "maritza.ortiz@buckridge.name",
      "FullName": "Sven Larson",
      "DirectPhone": "908-782-5149 x097",
      "FormalName": "Heller, Russel and Medhurst",
      "CountryId": 757,
      "ContactId": 826,
      "ContactName": "Brown-McGlynn",
      "Retired": 931,
      "Rank": 219,
      "ActiveInterests": 957,
      "ContactDepartment": "",
      "ContactCountryId": 890,
      "ContactOrgNr": "951552",
      "FaxPhone": "304-758-0863",
      "MobilePhone": "185-927-8814",
      "ContactPhone": "(944)013-0511 x68041",
      "AssociateName": "Tromp LLC",
      "AssociateId": 659,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "optio",
      "Kanalname": "at",
      "Post1": "laudantium",
      "Post2": "quia",
      "Post3": "quod",
      "EmailName": "meda_kirlin@flatley.name",
      "ContactFullName": "Allene Grimes",
      "ActiveErpLinks": 496,
      "TicketPriorityId": 435,
      "SupportLanguageId": 702,
      "SupportAssociateId": 150,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 752,
  "ConnectId": 583,
  "ReadStatus": "Green",
  "TimeToReply": 543,
  "RealTimeToReply": 277,
  "TimeToClose": 743,
  "RealTimeToClose": 645,
  "TimeSpentInternally": 507,
  "TimeSpentExternally": 405,
  "TimeSpentQueue": 932,
  "RealTimeSpentInternally": 244,
  "RealTimeSpentExternally": 706,
  "RealTimeSpentQueue": 871,
  "TimeSpent": 59,
  "HasAttachment": true,
  "NumReplies": 984,
  "NumMessages": 397,
  "FromAddress": "cumque",
  "Messages": [
    {
      "TicketMessageId": 494,
      "CreatedAt": "2020-04-17T11:06:42.2541028+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "voluptates",
      "PersonId": 948,
      "PersonFullName": "Miss Jadon Melba Hayes",
      "ContactId": 467,
      "ContactName": "Waelchi-Lakin",
      "ContactDepartment": "",
      "NumAttachments": 462,
      "EmailHeader": "tommie.bechtelar@mraz.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "consequatur",
      "Sentiment": 743,
      "SentimentConfidence": 6,
      "CreatedBy": 102,
      "ChangedAt": "2023-09-14T11:06:42.2541028+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 297,
      "Name": "Gottlieb LLC",
      "ToolTip": "Iusto eos maiores."
    },
    {
      "Id": 297,
      "Name": "Gottlieb LLC",
      "ToolTip": "Iusto eos maiores."
    }
  ],
  "Language": "doloribus",
  "Sentiment": 89,
  "SentimentConfidence": 486,
  "SuggestedCategoryId": 714,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 803,
  "IconHint": "similique",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "alias"
  },
  "CustomFields": {
    "CustomFields1": "libero",
    "CustomFields2": "maxime"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 109,
  "Title": "assumenda",
  "CreatedAt": "2004-06-10T11:06:42.2541028+02:00",
  "LastChanged": "2007-05-30T11:06:42.2541028+02:00",
  "ReadByOwner": "2004-12-16T11:06:42.2541028+01:00",
  "ReadByCustomer": "2015-01-23T11:06:42.2541028+01:00",
  "FirstReadByOwner": "2003-01-29T11:06:42.2541028+01:00",
  "FirstReadByUser": "2011-03-14T11:06:42.2541028+01:00",
  "Activate": "1996-10-19T11:06:42.2541028+02:00",
  "ClosedAt": "2008-02-03T11:06:42.2541028+01:00",
  "RepliedAt": "2017-06-01T11:06:42.2541028+02:00",
  "AlertTimeout": "2022-07-19T11:06:42.2541028+02:00",
  "Deadline": "2018-05-09T11:06:42.2541028+02:00",
  "CreatedBy": null,
  "Author": "beatae",
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
      "PersonId": 998,
      "Mrmrs": "illo",
      "Firstname": "Justus",
      "Lastname": "Corwin",
      "MiddleName": "Von-White",
      "Title": "vel",
      "Description": "Balanced grid-enabled knowledge base",
      "Email": "bernardo@collier.us",
      "FullName": "Dr. Emery Weber",
      "DirectPhone": "1-475-080-9185 x1837",
      "FormalName": "Stiedemann-Hyatt",
      "CountryId": 303,
      "ContactId": 816,
      "ContactName": "Kuhlman Group",
      "Retired": 968,
      "Rank": 212,
      "ActiveInterests": 83,
      "ContactDepartment": "",
      "ContactCountryId": 982,
      "ContactOrgNr": "1374267",
      "FaxPhone": "301.089.5976",
      "MobilePhone": "1-420-732-5304",
      "ContactPhone": "(513)276-3793",
      "AssociateName": "Brakus, Shanahan and Walker",
      "AssociateId": 292,
      "UsePersonAddress": false,
      "ContactFax": "ad",
      "Kanafname": "laboriosam",
      "Kanalname": "porro",
      "Post1": "delectus",
      "Post2": "consequatur",
      "Post3": "ad",
      "EmailName": "malika.walsh@mclaughlin.us",
      "ContactFullName": "Ashleigh Smitham",
      "ActiveErpLinks": 40,
      "TicketPriorityId": 656,
      "SupportLanguageId": 73,
      "SupportAssociateId": 521,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 991
        }
      }
    }
  ],
  "AlertLevel": 312,
  "ConnectId": 685,
  "ReadStatus": "Green",
  "TimeToReply": 401,
  "RealTimeToReply": 880,
  "TimeToClose": 425,
  "RealTimeToClose": 128,
  "TimeSpentInternally": 260,
  "TimeSpentExternally": 325,
  "TimeSpentQueue": 224,
  "RealTimeSpentInternally": 686,
  "RealTimeSpentExternally": 45,
  "RealTimeSpentQueue": 508,
  "TimeSpent": 889,
  "HasAttachment": true,
  "NumReplies": 909,
  "NumMessages": 672,
  "FromAddress": "sint",
  "Messages": [
    {
      "TicketMessageId": 123,
      "CreatedAt": "2014-07-08T11:06:42.2697279+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "sed",
      "PersonId": 351,
      "PersonFullName": "Hobart Schamberger",
      "ContactId": 974,
      "ContactName": "Pfeffer, Trantow and Terry",
      "ContactDepartment": "",
      "NumAttachments": 998,
      "EmailHeader": "arch_graham@lubowitz.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "mollitia",
      "Sentiment": 458,
      "SentimentConfidence": 832,
      "CreatedBy": 714,
      "ChangedAt": "2008-12-28T11:06:42.2697279+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 155
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 457,
      "Name": "Goodwin Inc and Sons",
      "ToolTip": "Eum qui aperiam occaecati.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 419
        }
      }
    },
    {
      "Id": 457,
      "Name": "Goodwin Inc and Sons",
      "ToolTip": "Eum qui aperiam occaecati.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 419
        }
      }
    }
  ],
  "Language": "doloremque",
  "Sentiment": 628,
  "SentimentConfidence": 7,
  "SuggestedCategoryId": 461,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 862,
  "IconHint": "reprehenderit",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "autem"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "non"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 375
    }
  }
}
```