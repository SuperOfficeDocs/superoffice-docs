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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 539,
  "Title": "iure",
  "CreatedAt": "2003-03-14T11:44:42.6013776+01:00",
  "LastChanged": "2020-08-10T11:44:42.6013776+02:00",
  "ReadByOwner": "2002-02-21T11:44:42.6013776+01:00",
  "ReadByCustomer": "2008-06-12T11:44:42.6013776+02:00",
  "FirstReadByOwner": "2006-03-05T11:44:42.6013776+01:00",
  "FirstReadByUser": "2010-03-22T11:44:42.6013776+01:00",
  "Activate": "1997-05-30T11:44:42.6013776+02:00",
  "ClosedAt": "2016-11-19T11:44:42.6013776+01:00",
  "RepliedAt": "2018-05-24T11:44:42.6013776+02:00",
  "AlertTimeout": "1997-03-02T11:44:42.6013776+01:00",
  "Deadline": "2006-07-21T11:44:42.6013776+02:00",
  "CreatedBy": null,
  "Author": "est",
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
      "Position": "cumque",
      "PersonId": 40,
      "Mrmrs": "quis",
      "Firstname": "Loyce",
      "Lastname": "Auer",
      "MiddleName": "King-Anderson",
      "Title": "reprehenderit",
      "Description": "User-friendly mobile interface",
      "Email": "shakira@effertzspencer.uk",
      "FullName": "Bud Quitzon",
      "DirectPhone": "394-788-0348",
      "FormalName": "Weimann LLC",
      "CountryId": 63,
      "ContactId": 103,
      "ContactName": "Lakin LLC",
      "Retired": 653,
      "Rank": 372,
      "ActiveInterests": 924,
      "ContactDepartment": "",
      "ContactCountryId": 70,
      "ContactOrgNr": "899688",
      "FaxPhone": "654.078.5357",
      "MobilePhone": "817-176-2259 x188",
      "ContactPhone": "1-904-971-1103",
      "AssociateName": "Upton Inc and Sons",
      "AssociateId": 650,
      "UsePersonAddress": false,
      "ContactFax": "est",
      "Kanafname": "cumque",
      "Kanalname": "vel",
      "Post1": "qui",
      "Post2": "aut",
      "Post3": "consequatur",
      "EmailName": "king_rath@lynchraynor.name",
      "ContactFullName": "Mr. Madie Zackary Smitham III",
      "ActiveErpLinks": 392,
      "TicketPriorityId": 734,
      "SupportLanguageId": 432,
      "SupportAssociateId": 967,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 498,
  "ConnectId": 939,
  "ReadStatus": "Green",
  "TimeToReply": 412,
  "RealTimeToReply": 21,
  "TimeToClose": 746,
  "RealTimeToClose": 152,
  "TimeSpentInternally": 505,
  "TimeSpentExternally": 196,
  "TimeSpentQueue": 882,
  "RealTimeSpentInternally": 452,
  "RealTimeSpentExternally": 149,
  "RealTimeSpentQueue": 767,
  "TimeSpent": 337,
  "HasAttachment": false,
  "NumReplies": 335,
  "NumMessages": 243,
  "FromAddress": "ut",
  "Messages": [
    {
      "TicketMessageId": 763,
      "CreatedAt": "2000-01-17T11:44:42.6013776+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "consequatur",
      "PersonId": 614,
      "PersonFullName": "Mr. Candido Dion Lockman Sr.",
      "ContactId": 582,
      "ContactName": "Beer-Wyman",
      "ContactDepartment": "unleash killer relationships",
      "NumAttachments": 187,
      "EmailHeader": "dianna@yost.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "rerum",
      "Sentiment": 188,
      "SentimentConfidence": 707,
      "CreatedBy": 980,
      "ChangedAt": "2022-06-04T11:44:42.6013776+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 439,
      "Name": "Hansen, Abbott and Gleason",
      "ToolTip": "Velit ea et veritatis impedit ut fugiat error."
    },
    {
      "Id": 439,
      "Name": "Hansen, Abbott and Gleason",
      "ToolTip": "Velit ea et veritatis impedit ut fugiat error."
    }
  ],
  "Language": "dolor",
  "Sentiment": 470,
  "SentimentConfidence": 612,
  "SuggestedCategoryId": 938,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 886,
  "IconHint": "quae",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 506,
  "ExtraFields": {
    "ExtraFields1": "repudiandae",
    "ExtraFields2": "impedit"
  },
  "CustomFields": {
    "CustomFields1": "accusantium",
    "CustomFields2": "quibusdam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 205,
  "Title": "qui",
  "CreatedAt": "1997-03-07T11:44:42.6170062+01:00",
  "LastChanged": "2007-06-16T11:44:42.6170062+02:00",
  "ReadByOwner": "2012-05-20T11:44:42.6170062+02:00",
  "ReadByCustomer": "2008-09-05T11:44:42.6170062+02:00",
  "FirstReadByOwner": "2002-10-04T11:44:42.6170062+02:00",
  "FirstReadByUser": "2011-07-28T11:44:42.6170062+02:00",
  "Activate": "1998-03-03T11:44:42.6170062+01:00",
  "ClosedAt": "2020-12-28T11:44:42.6170062+01:00",
  "RepliedAt": "2009-09-28T11:44:42.6170062+02:00",
  "AlertTimeout": "2022-05-02T11:44:42.6170062+02:00",
  "Deadline": "1999-09-04T11:44:42.6170062+02:00",
  "CreatedBy": null,
  "Author": "laboriosam",
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
      "PersonId": 305,
      "Mrmrs": "suscipit",
      "Firstname": "Jean",
      "Lastname": "Nikolaus",
      "MiddleName": "Jaskolski, Ledner and Weissnat",
      "Title": "quia",
      "Description": "Programmable national archive",
      "Email": "gonzalo_ward@cormierbernhard.biz",
      "FullName": "Dr. Donnie Goodwin III",
      "DirectPhone": "(932)628-7772 x795",
      "FormalName": "Bartell, Nolan and Rau",
      "CountryId": 175,
      "ContactId": 270,
      "ContactName": "Lubowitz-Mosciski",
      "Retired": 904,
      "Rank": 641,
      "ActiveInterests": 764,
      "ContactDepartment": "",
      "ContactCountryId": 613,
      "ContactOrgNr": "215002",
      "FaxPhone": "(903)433-1094",
      "MobilePhone": "399.377.0322 x3467",
      "ContactPhone": "(224)636-3606 x0604",
      "AssociateName": "Kris-Hirthe",
      "AssociateId": 741,
      "UsePersonAddress": true,
      "ContactFax": "ut",
      "Kanafname": "sit",
      "Kanalname": "quis",
      "Post1": "dolorem",
      "Post2": "quia",
      "Post3": "officia",
      "EmailName": "delia@graham.co.uk",
      "ContactFullName": "Rodger Mertie Haley PhD",
      "ActiveErpLinks": 588,
      "TicketPriorityId": 619,
      "SupportLanguageId": 40,
      "SupportAssociateId": 903,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 7
        }
      }
    }
  ],
  "AlertLevel": 627,
  "ConnectId": 588,
  "ReadStatus": "Green",
  "TimeToReply": 896,
  "RealTimeToReply": 429,
  "TimeToClose": 587,
  "RealTimeToClose": 145,
  "TimeSpentInternally": 815,
  "TimeSpentExternally": 884,
  "TimeSpentQueue": 307,
  "RealTimeSpentInternally": 54,
  "RealTimeSpentExternally": 968,
  "RealTimeSpentQueue": 166,
  "TimeSpent": 101,
  "HasAttachment": true,
  "NumReplies": 324,
  "NumMessages": 862,
  "FromAddress": "eius",
  "Messages": [
    {
      "TicketMessageId": 518,
      "CreatedAt": "2020-12-26T11:44:42.6170062+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "aspernatur",
      "PersonId": 186,
      "PersonFullName": "Jeffrey Schmitt",
      "ContactId": 729,
      "ContactName": "Kuhn Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 760,
      "EmailHeader": "breanne@wisozklemke.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "corrupti",
      "Sentiment": 307,
      "SentimentConfidence": 352,
      "CreatedBy": 296,
      "ChangedAt": "2009-12-13T11:44:42.6170062+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 325
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 297,
      "Name": "Hartmann, West and Dicki",
      "ToolTip": "Quisquam cum accusamus asperiores omnis sed.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 325
        }
      }
    },
    {
      "Id": 297,
      "Name": "Hartmann, West and Dicki",
      "ToolTip": "Quisquam cum accusamus asperiores omnis sed.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 325
        }
      }
    }
  ],
  "Language": "sequi",
  "Sentiment": 437,
  "SentimentConfidence": 703,
  "SuggestedCategoryId": 283,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 45,
  "IconHint": "ad",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 124,
  "ExtraFields": {
    "ExtraFields1": "eveniet",
    "ExtraFields2": "iste"
  },
  "CustomFields": {
    "CustomFields1": "quos",
    "CustomFields2": "mollitia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 215
    }
  }
}
```