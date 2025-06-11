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
  "TicketId": 134,
  "Title": "harum",
  "CreatedAt": "2005-05-02T17:54:08.5699413+02:00",
  "LastChanged": "1998-07-25T17:54:08.5699413+02:00",
  "ReadByOwner": "2004-05-15T17:54:08.5699413+02:00",
  "ReadByCustomer": "2018-03-31T17:54:08.5699413+02:00",
  "FirstReadByOwner": "1999-08-26T17:54:08.5699413+02:00",
  "FirstReadByUser": "2003-07-18T17:54:08.5699413+02:00",
  "Activate": "2009-02-13T17:54:08.5699413+01:00",
  "ClosedAt": "1999-02-15T17:54:08.5699413+01:00",
  "RepliedAt": "2001-01-14T17:54:08.5699413+01:00",
  "AlertTimeout": "2001-03-16T17:54:08.5699413+01:00",
  "Deadline": "2017-08-27T17:54:08.5699413+02:00",
  "CreatedBy": null,
  "Author": "illo",
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
      "Position": "tenetur",
      "PersonId": 127,
      "Mrmrs": "maxime",
      "Firstname": "Kenna",
      "Lastname": "Collier",
      "MiddleName": "Miller-Marquardt",
      "Title": "nam",
      "Description": "User-friendly modular alliance",
      "Email": "tania@bogisich.us",
      "FullName": "Mr. Mellie Gerda Bruen DDS",
      "DirectPhone": "111.059.0284 x53473",
      "FormalName": "Davis, Reichel and Rohan",
      "CountryId": 30,
      "ContactId": 223,
      "ContactName": "Becker-Okuneva",
      "Retired": 318,
      "Rank": 274,
      "ActiveInterests": 348,
      "ContactDepartment": "",
      "ContactCountryId": 435,
      "ContactOrgNr": "352317",
      "FaxPhone": "(685)019-1564",
      "MobilePhone": "469.395.9735",
      "ContactPhone": "(261)374-9654",
      "AssociateName": "Lehner Inc and Sons",
      "AssociateId": 25,
      "UsePersonAddress": false,
      "ContactFax": "sed",
      "Kanafname": "laboriosam",
      "Kanalname": "in",
      "Post1": "est",
      "Post2": "laboriosam",
      "Post3": "occaecati",
      "EmailName": "gregory@schuster.com",
      "ContactFullName": "Brittany Medhurst",
      "ActiveErpLinks": 218,
      "TicketPriorityId": 346,
      "SupportLanguageId": 338,
      "SupportAssociateId": 292,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1885727"
    }
  ],
  "AlertLevel": 974,
  "ConnectId": 190,
  "ReadStatus": "Green",
  "TimeToReply": 246,
  "RealTimeToReply": 760,
  "TimeToClose": 684,
  "RealTimeToClose": 280,
  "TimeSpentInternally": 821,
  "TimeSpentExternally": 597,
  "TimeSpentQueue": 987,
  "RealTimeSpentInternally": 495,
  "RealTimeSpentExternally": 343,
  "RealTimeSpentQueue": 133,
  "TimeSpent": 641,
  "HasAttachment": false,
  "NumReplies": 617,
  "NumMessages": 429,
  "FromAddress": "hic",
  "Messages": [
    {
      "TicketMessageId": 510,
      "CreatedAt": "2006-04-08T17:54:08.5699413+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "velit",
      "PersonId": 511,
      "PersonFullName": "Brendon Huels",
      "ContactId": 789,
      "ContactName": "Jones, Morissette and Deckow",
      "ContactDepartment": "",
      "NumAttachments": 865,
      "EmailHeader": "elmer@cartwright.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "eum",
      "Sentiment": 383,
      "SentimentConfidence": 515,
      "CreatedBy": 734,
      "ChangedAt": "2001-03-11T17:54:08.5855648+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 516,
      "Name": "Dickens, Rath and Runolfsdottir",
      "ToolTip": "Aspernatur ab voluptatibus est."
    },
    {
      "Id": 516,
      "Name": "Dickens, Rath and Runolfsdottir",
      "ToolTip": "Aspernatur ab voluptatibus est."
    }
  ],
  "Language": "nihil",
  "Sentiment": 172,
  "SentimentConfidence": 859,
  "SuggestedCategoryId": 367,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 760,
  "IconHint": "voluptatem",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 728,
  "ExtraFields": {
    "ExtraFields1": "eum",
    "ExtraFields2": "dicta"
  },
  "CustomFields": {
    "CustomFields1": "placeat",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 378,
  "Title": "officiis",
  "CreatedAt": "2015-02-12T17:54:08.5855648+01:00",
  "LastChanged": "2002-08-09T17:54:08.5855648+02:00",
  "ReadByOwner": "2018-07-04T17:54:08.5855648+02:00",
  "ReadByCustomer": "2005-11-05T17:54:08.5855648+01:00",
  "FirstReadByOwner": "1998-06-06T17:54:08.5855648+02:00",
  "FirstReadByUser": "2015-08-28T17:54:08.5855648+02:00",
  "Activate": "2024-09-27T17:54:08.5855648+02:00",
  "ClosedAt": "2002-06-30T17:54:08.5855648+02:00",
  "RepliedAt": "2019-12-19T17:54:08.5855648+01:00",
  "AlertTimeout": "2019-06-10T17:54:08.5855648+02:00",
  "Deadline": "2003-04-19T17:54:08.5855648+02:00",
  "CreatedBy": null,
  "Author": "occaecati",
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
      "Position": "dolorem",
      "PersonId": 164,
      "Mrmrs": "sint",
      "Firstname": "Taya",
      "Lastname": "Glover",
      "MiddleName": "Sanford, Stokes and Kiehn",
      "Title": "laboriosam",
      "Description": "Persevering zero tolerance Graphical User Interface",
      "Email": "timmothy.hane@carter.uk",
      "FullName": "Daisy Lucile Beer DVM",
      "DirectPhone": "(310)085-2056",
      "FormalName": "Powlowski-Schulist",
      "CountryId": 27,
      "ContactId": 212,
      "ContactName": "Cartwright, Kerluke and Stoltenberg",
      "Retired": 195,
      "Rank": 375,
      "ActiveInterests": 214,
      "ContactDepartment": "",
      "ContactCountryId": 90,
      "ContactOrgNr": "1577970",
      "FaxPhone": "844-650-5276 x97122",
      "MobilePhone": "910-221-4553",
      "ContactPhone": "1-180-396-5077 x90480",
      "AssociateName": "Lindgren-Nicolas",
      "AssociateId": 366,
      "UsePersonAddress": false,
      "ContactFax": "modi",
      "Kanafname": "quod",
      "Kanalname": "exercitationem",
      "Post1": "magni",
      "Post2": "aut",
      "Post3": "expedita",
      "EmailName": "geoffrey_weber@goyetteboehm.co.uk",
      "ContactFullName": "Vance Hagenes Jr.",
      "ActiveErpLinks": 960,
      "TicketPriorityId": 672,
      "SupportLanguageId": 925,
      "SupportAssociateId": 551,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1249367",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 318
        }
      }
    }
  ],
  "AlertLevel": 249,
  "ConnectId": 194,
  "ReadStatus": "Green",
  "TimeToReply": 928,
  "RealTimeToReply": 446,
  "TimeToClose": 20,
  "RealTimeToClose": 460,
  "TimeSpentInternally": 981,
  "TimeSpentExternally": 221,
  "TimeSpentQueue": 556,
  "RealTimeSpentInternally": 638,
  "RealTimeSpentExternally": 91,
  "RealTimeSpentQueue": 274,
  "TimeSpent": 687,
  "HasAttachment": false,
  "NumReplies": 177,
  "NumMessages": 520,
  "FromAddress": "suscipit",
  "Messages": [
    {
      "TicketMessageId": 273,
      "CreatedAt": "2016-05-16T17:54:08.5855648+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "amet",
      "PersonId": 375,
      "PersonFullName": "Esta Jarod Schmeler II",
      "ContactId": 575,
      "ContactName": "Hegmann Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 222,
      "EmailHeader": "brisa@christiansenking.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "consectetur",
      "Sentiment": 208,
      "SentimentConfidence": 79,
      "CreatedBy": 23,
      "ChangedAt": "2000-11-29T17:54:08.5855648+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 55
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 176,
      "Name": "Corwin, Klocko and Schamberger",
      "ToolTip": "Molestiae assumenda eum perferendis est ut nesciunt.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 38
        }
      }
    },
    {
      "Id": 176,
      "Name": "Corwin, Klocko and Schamberger",
      "ToolTip": "Molestiae assumenda eum perferendis est ut nesciunt.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 38
        }
      }
    }
  ],
  "Language": "officiis",
  "Sentiment": 528,
  "SentimentConfidence": 539,
  "SuggestedCategoryId": 291,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 885,
  "IconHint": "aut",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 879,
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "in"
  },
  "CustomFields": {
    "CustomFields1": "quas",
    "CustomFields2": "ea"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 519
    }
  }
}
```