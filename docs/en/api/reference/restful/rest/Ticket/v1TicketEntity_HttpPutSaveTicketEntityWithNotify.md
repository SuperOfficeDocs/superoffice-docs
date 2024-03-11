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
  "TicketId": 661,
  "Title": "eos",
  "CreatedAt": "2007-09-28T14:23:55.6658646+02:00",
  "LastChanged": "2002-02-11T14:23:55.6658646+01:00",
  "ReadByOwner": "2017-10-07T14:23:55.6658646+02:00",
  "ReadByCustomer": "2002-07-09T14:23:55.6658646+02:00",
  "FirstReadByOwner": "2002-02-28T14:23:55.6658646+01:00",
  "FirstReadByUser": "2013-07-18T14:23:55.6658646+02:00",
  "Activate": "1998-03-27T14:23:55.6658646+01:00",
  "ClosedAt": "2012-10-29T14:23:55.6658646+01:00",
  "RepliedAt": "1999-08-22T14:23:55.6658646+02:00",
  "AlertTimeout": "2017-08-10T14:23:55.6658646+02:00",
  "Deadline": "2005-02-18T14:23:55.6658646+01:00",
  "CreatedBy": null,
  "Author": "eius",
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
      "Position": "non",
      "PersonId": 938,
      "Mrmrs": "vero",
      "Firstname": "Beryl",
      "Lastname": "Von",
      "MiddleName": "Rodriguez, Wehner and Kling",
      "Title": "consequatur",
      "Description": "Assimilated bifurcated secured line",
      "Email": "marcus@yundtlesch.co.uk",
      "FullName": "Lilyan Murphy",
      "DirectPhone": "1-974-136-7795 x587",
      "FormalName": "Stehr-Mante",
      "CountryId": 831,
      "ContactId": 100,
      "ContactName": "Altenwerth-Nader",
      "Retired": 565,
      "Rank": 949,
      "ActiveInterests": 871,
      "ContactDepartment": "",
      "ContactCountryId": 963,
      "ContactOrgNr": "802739",
      "FaxPhone": "619-377-6356",
      "MobilePhone": "1-851-997-3308",
      "ContactPhone": "968-292-0979",
      "AssociateName": "Keebler, Watsica and Von",
      "AssociateId": 104,
      "UsePersonAddress": false,
      "ContactFax": "sed",
      "Kanafname": "tenetur",
      "Kanalname": "facilis",
      "Post1": "aut",
      "Post2": "recusandae",
      "Post3": "magni",
      "EmailName": "meghan_jacobson@jacobs.info",
      "ContactFullName": "Russel Terry",
      "ActiveErpLinks": 852,
      "TicketPriorityId": 245,
      "SupportLanguageId": 220,
      "SupportAssociateId": 287,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 468,
  "ConnectId": 154,
  "ReadStatus": "Green",
  "TimeToReply": 585,
  "RealTimeToReply": 407,
  "TimeToClose": 282,
  "RealTimeToClose": 663,
  "TimeSpentInternally": 719,
  "TimeSpentExternally": 800,
  "TimeSpentQueue": 198,
  "RealTimeSpentInternally": 769,
  "RealTimeSpentExternally": 156,
  "RealTimeSpentQueue": 460,
  "TimeSpent": 979,
  "HasAttachment": false,
  "NumReplies": 960,
  "NumMessages": 401,
  "FromAddress": "reiciendis",
  "Messages": [
    {
      "TicketMessageId": 804,
      "CreatedAt": "2011-04-06T14:23:55.6658646+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "sit",
      "PersonId": 300,
      "PersonFullName": "Dr. Neva Weber",
      "ContactId": 276,
      "ContactName": "Schumm, Stroman and Schulist",
      "ContactDepartment": "",
      "NumAttachments": 674,
      "EmailHeader": "karley_walter@crist.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "blanditiis",
      "Sentiment": 819,
      "SentimentConfidence": 332,
      "CreatedBy": 424,
      "ChangedAt": "2021-04-08T14:23:55.6658646+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 347,
      "Name": "O'Reilly, Wolf and Blanda",
      "ToolTip": "Voluptatem quasi sunt."
    },
    {
      "Id": 347,
      "Name": "O'Reilly, Wolf and Blanda",
      "ToolTip": "Voluptatem quasi sunt."
    }
  ],
  "Language": "exercitationem",
  "Sentiment": 582,
  "SentimentConfidence": 136,
  "SuggestedCategoryId": 963,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 604,
  "IconHint": "dolor",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 816,
  "ExtraFields": {
    "ExtraFields1": "tempore",
    "ExtraFields2": "quaerat"
  },
  "CustomFields": {
    "CustomFields1": "culpa",
    "CustomFields2": "neque"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 437,
  "Title": "consequuntur",
  "CreatedAt": "2021-09-13T14:23:55.6814556+02:00",
  "LastChanged": "1999-09-01T14:23:55.6814556+02:00",
  "ReadByOwner": "2012-10-26T14:23:55.6814556+02:00",
  "ReadByCustomer": "2018-12-02T14:23:55.6814556+01:00",
  "FirstReadByOwner": "2003-09-12T14:23:55.6814556+02:00",
  "FirstReadByUser": "2003-12-16T14:23:55.6814556+01:00",
  "Activate": "2020-02-02T14:23:55.6814556+01:00",
  "ClosedAt": "2013-03-13T14:23:55.6814556+01:00",
  "RepliedAt": "2004-12-14T14:23:55.6814556+01:00",
  "AlertTimeout": "2000-03-23T14:23:55.6814556+01:00",
  "Deadline": "2021-06-21T14:23:55.6814556+02:00",
  "CreatedBy": null,
  "Author": "sunt",
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
      "PersonId": 254,
      "Mrmrs": "eum",
      "Firstname": "Sunny",
      "Lastname": "Christiansen",
      "MiddleName": "McDermott LLC",
      "Title": "aliquid",
      "Description": "Enterprise-wide modular artificial intelligence",
      "Email": "brandi@reilly.biz",
      "FullName": "Jeffry Klein",
      "DirectPhone": "1-686-241-7661",
      "FormalName": "Glover Inc and Sons",
      "CountryId": 811,
      "ContactId": 733,
      "ContactName": "Dietrich Inc and Sons",
      "Retired": 337,
      "Rank": 457,
      "ActiveInterests": 412,
      "ContactDepartment": "",
      "ContactCountryId": 394,
      "ContactOrgNr": "1009142",
      "FaxPhone": "856.293.0593 x5992",
      "MobilePhone": "207-572-5567",
      "ContactPhone": "752.417.9306",
      "AssociateName": "Stanton, Becker and Lind",
      "AssociateId": 431,
      "UsePersonAddress": true,
      "ContactFax": "aut",
      "Kanafname": "mollitia",
      "Kanalname": "quo",
      "Post1": "velit",
      "Post2": "illo",
      "Post3": "vel",
      "EmailName": "shakira.stanton@hayes.uk",
      "ContactFullName": "Jamil Ortiz",
      "ActiveErpLinks": 369,
      "TicketPriorityId": 289,
      "SupportLanguageId": 202,
      "SupportAssociateId": 368,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 17
        }
      }
    }
  ],
  "AlertLevel": 244,
  "ConnectId": 926,
  "ReadStatus": "Green",
  "TimeToReply": 657,
  "RealTimeToReply": 602,
  "TimeToClose": 176,
  "RealTimeToClose": 189,
  "TimeSpentInternally": 880,
  "TimeSpentExternally": 972,
  "TimeSpentQueue": 66,
  "RealTimeSpentInternally": 547,
  "RealTimeSpentExternally": 91,
  "RealTimeSpentQueue": 552,
  "TimeSpent": 639,
  "HasAttachment": true,
  "NumReplies": 239,
  "NumMessages": 351,
  "FromAddress": "saepe",
  "Messages": [
    {
      "TicketMessageId": 68,
      "CreatedAt": "2019-10-21T14:23:55.6814556+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "nemo",
      "PersonId": 445,
      "PersonFullName": "Mrs. Raina Labadie V",
      "ContactId": 565,
      "ContactName": "Wolff Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 938,
      "EmailHeader": "nora@corkery.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quae",
      "Sentiment": 181,
      "SentimentConfidence": 171,
      "CreatedBy": 962,
      "ChangedAt": "2015-02-20T14:23:55.6814556+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 568
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 653,
      "Name": "Russel LLC",
      "ToolTip": "Pariatur adipisci voluptatum explicabo optio eaque non.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 103
        }
      }
    },
    {
      "Id": 653,
      "Name": "Russel LLC",
      "ToolTip": "Pariatur adipisci voluptatum explicabo optio eaque non.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 103
        }
      }
    }
  ],
  "Language": "labore",
  "Sentiment": 218,
  "SentimentConfidence": 630,
  "SuggestedCategoryId": 361,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 40,
  "IconHint": "ut",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 740,
  "ExtraFields": {
    "ExtraFields1": "ratione",
    "ExtraFields2": "facere"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "sint"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 224
    }
  }
}
```