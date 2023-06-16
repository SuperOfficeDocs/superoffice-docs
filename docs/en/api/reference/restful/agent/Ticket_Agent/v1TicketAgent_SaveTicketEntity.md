---
title: POST Agents/Ticket/SaveTicketEntity
uid: v1TicketAgent_SaveTicketEntity
generated: true
---

# POST Agents/Ticket/SaveTicketEntity

```http
POST /api/v1/Agents/Ticket/SaveTicketEntity
```

Updates the existing TicketEntity or creates a new TicketEntity if the id parameter is empty








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

The TicketEntity to be saved. 

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
| Sale | Sale | The sale that this ticket is connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket is connected to  <para>Use MDO List name "project" to get list items.</para> |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Ticket/SaveTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketId": 595,
  "Title": "quia",
  "CreatedAt": "2017-02-22T16:00:41.9456639+01:00",
  "LastChanged": "2017-08-10T16:00:41.9456639+02:00",
  "ReadByOwner": "2013-02-19T16:00:41.9456639+01:00",
  "ReadByCustomer": "2020-09-13T16:00:41.9456639+02:00",
  "FirstReadByOwner": "2014-04-25T16:00:41.9456639+02:00",
  "FirstReadByUser": "1996-11-04T16:00:41.9456639+01:00",
  "Activate": "2008-09-12T16:00:41.9456639+02:00",
  "ClosedAt": "2011-08-07T16:00:41.9456639+02:00",
  "RepliedAt": "2004-01-16T16:00:41.9456639+01:00",
  "AlertTimeout": "2005-03-13T16:00:41.9456639+01:00",
  "Deadline": "1998-08-21T16:00:41.9456639+02:00",
  "CreatedBy": null,
  "Author": "rerum",
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
      "Position": "error",
      "PersonId": 22,
      "Mrmrs": "ea",
      "Firstname": "Gilbert",
      "Lastname": "Lesch",
      "MiddleName": "Buckridge-Metz",
      "Title": "aut",
      "Description": "Total hybrid success",
      "Email": "trever@hillsschmidt.biz",
      "FullName": "Laisha Ronaldo Sawayn III",
      "DirectPhone": "508-352-7009 x135",
      "FormalName": "Stoltenberg-Leannon",
      "CountryId": 72,
      "ContactId": 698,
      "ContactName": "Dickinson Group",
      "Retired": 103,
      "Rank": 516,
      "ActiveInterests": 504,
      "ContactDepartment": "",
      "ContactCountryId": 263,
      "ContactOrgNr": "1811560",
      "FaxPhone": "548-133-2501 x21185",
      "MobilePhone": "(577)284-5724 x983",
      "ContactPhone": "(367)102-3243 x7087",
      "AssociateName": "Roberts Group",
      "AssociateId": 504,
      "UsePersonAddress": false,
      "ContactFax": "molestiae",
      "Kanafname": "qui",
      "Kanalname": "vel",
      "Post1": "magnam",
      "Post2": "earum",
      "Post3": "officia",
      "EmailName": "omer.emard@schimmel.co.uk",
      "ContactFullName": "Bryon Terry",
      "ActiveErpLinks": 749,
      "TicketPriorityId": 55,
      "SupportLanguageId": 667,
      "SupportAssociateId": 162,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 661,
  "ConnectId": 469,
  "ReadStatus": "Green",
  "TimeToReply": 542,
  "RealTimeToReply": 966,
  "TimeToClose": 678,
  "RealTimeToClose": 30,
  "TimeSpentInternally": 152,
  "TimeSpentExternally": 910,
  "TimeSpentQueue": 344,
  "RealTimeSpentInternally": 520,
  "RealTimeSpentExternally": 628,
  "RealTimeSpentQueue": 297,
  "HasAttachment": false,
  "NumReplies": 498,
  "NumMessages": 373,
  "FromAddress": "est",
  "Messages": [
    {
      "TicketMessageId": 910,
      "CreatedAt": "2022-03-20T16:00:41.9456639+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "et",
      "PersonId": 168,
      "PersonFullName": "Jeanne Hettinger MD",
      "ContactId": 673,
      "ContactName": "Fadel-Reichert",
      "ContactDepartment": "",
      "NumAttachments": 890,
      "EmailHeader": "germaine_ryan@leuschkehuel.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "repudiandae",
      "Sentiment": 869,
      "SentimentConfidence": 945,
      "CreatedBy": 923,
      "ChangedAt": "2015-09-20T16:00:41.9456639+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 967,
      "Name": "Kulas LLC",
      "ToolTip": "Repellat amet accusamus sint modi facilis earum qui."
    },
    {
      "Id": 967,
      "Name": "Kulas LLC",
      "ToolTip": "Repellat amet accusamus sint modi facilis earum qui."
    }
  ],
  "Language": "similique",
  "Sentiment": 959,
  "SentimentConfidence": 556,
  "SuggestedCategoryId": 664,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 737,
  "IconHint": "laboriosam",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "eius",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "perferendis",
    "CustomFields2": "adipisci"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 567,
  "Title": "nobis",
  "CreatedAt": "2020-06-28T16:00:41.9612938+02:00",
  "LastChanged": "2011-04-29T16:00:41.9612938+02:00",
  "ReadByOwner": "2007-09-26T16:00:41.9612938+02:00",
  "ReadByCustomer": "2012-06-09T16:00:41.9612938+02:00",
  "FirstReadByOwner": "2003-07-12T16:00:41.9612938+02:00",
  "FirstReadByUser": "2007-08-06T16:00:41.9612938+02:00",
  "Activate": "2008-04-21T16:00:41.9612938+02:00",
  "ClosedAt": "2014-03-05T16:00:41.9612938+01:00",
  "RepliedAt": "2010-08-06T16:00:41.9612938+02:00",
  "AlertTimeout": "2002-11-08T16:00:41.9612938+01:00",
  "Deadline": "2019-12-03T16:00:41.9612938+01:00",
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
      "Position": "consectetur",
      "PersonId": 784,
      "Mrmrs": "aut",
      "Firstname": "Burnice",
      "Lastname": "Thompson",
      "MiddleName": "Ankunding-Wiegand",
      "Title": "nihil",
      "Description": "Multi-channelled radical alliance",
      "Email": "florine.maggio@keeblerrobel.us",
      "FullName": "Jerad Wiza",
      "DirectPhone": "139.643.1686",
      "FormalName": "Rau Group",
      "CountryId": 137,
      "ContactId": 47,
      "ContactName": "Fadel Group",
      "Retired": 136,
      "Rank": 570,
      "ActiveInterests": 622,
      "ContactDepartment": "",
      "ContactCountryId": 101,
      "ContactOrgNr": "1040599",
      "FaxPhone": "728.989.2949 x875",
      "MobilePhone": "377.338.3954",
      "ContactPhone": "1-894-800-7826 x51996",
      "AssociateName": "Hills Group",
      "AssociateId": 788,
      "UsePersonAddress": false,
      "ContactFax": "autem",
      "Kanafname": "temporibus",
      "Kanalname": "qui",
      "Post1": "ad",
      "Post2": "voluptatem",
      "Post3": "ipsa",
      "EmailName": "bernice_okeefe@macejkovic.us",
      "ContactFullName": "Eloy Kuvalis Sr.",
      "ActiveErpLinks": 399,
      "TicketPriorityId": 594,
      "SupportLanguageId": 957,
      "SupportAssociateId": 18,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 679
        }
      }
    }
  ],
  "AlertLevel": 579,
  "ConnectId": 66,
  "ReadStatus": "Green",
  "TimeToReply": 950,
  "RealTimeToReply": 781,
  "TimeToClose": 439,
  "RealTimeToClose": 39,
  "TimeSpentInternally": 787,
  "TimeSpentExternally": 177,
  "TimeSpentQueue": 520,
  "RealTimeSpentInternally": 809,
  "RealTimeSpentExternally": 329,
  "RealTimeSpentQueue": 845,
  "HasAttachment": false,
  "NumReplies": 339,
  "NumMessages": 155,
  "FromAddress": "nemo",
  "Messages": [
    {
      "TicketMessageId": 55,
      "CreatedAt": "2014-09-10T16:00:41.9612938+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "veritatis",
      "PersonId": 526,
      "PersonFullName": "Jadyn Bergnaum",
      "ContactId": 553,
      "ContactName": "Pollich-Gleichner",
      "ContactDepartment": "",
      "NumAttachments": 128,
      "EmailHeader": "deja_emmerich@hammes.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "voluptatem",
      "Sentiment": 538,
      "SentimentConfidence": 428,
      "CreatedBy": 457,
      "ChangedAt": "2000-04-11T16:00:41.9612938+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 426
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 563,
      "Name": "Gutmann Group",
      "ToolTip": "Ab odio sunt nesciunt ut ducimus non eveniet.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 847
        }
      }
    },
    {
      "Id": 563,
      "Name": "Gutmann Group",
      "ToolTip": "Ab odio sunt nesciunt ut ducimus non eveniet.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 847
        }
      }
    }
  ],
  "Language": "aut",
  "Sentiment": 463,
  "SentimentConfidence": 845,
  "SuggestedCategoryId": 824,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 628,
  "IconHint": "officiis",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "accusamus",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "id",
    "CustomFields2": "id"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 476
    }
  }
}
```