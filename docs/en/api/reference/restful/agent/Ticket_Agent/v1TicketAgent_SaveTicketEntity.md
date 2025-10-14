---
title: POST Agents/Ticket/SaveTicketEntity
uid: v1TicketAgent_SaveTicketEntity
generated: true
content_type: reference
---

# POST Agents/Ticket/SaveTicketEntity

```http
POST /api/v1/Agents/Ticket/SaveTicketEntity
```

Updates the existing TicketEntity or creates a new TicketEntity if the id parameter is 0.


Does not notify users of save.
NsApiSlow threshold: 2000 ms.







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

## Request Body: ticketEntity 

The TicketEntity that is saved 

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
POST /api/v1/Agents/Ticket/SaveTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 920,
  "Title": "porro",
  "CreatedAt": "2018-01-26T03:40:47.9223542+01:00",
  "LastChanged": "2017-07-19T03:40:47.9223542+02:00",
  "ReadByOwner": "1998-06-01T03:40:47.9223542+02:00",
  "ReadByCustomer": "2002-10-27T03:40:47.9223542+01:00",
  "FirstReadByOwner": "2017-09-04T03:40:47.9223542+02:00",
  "FirstReadByUser": "2018-05-23T03:40:47.9223542+02:00",
  "Activate": "2007-12-14T03:40:47.9223542+01:00",
  "ClosedAt": "2002-08-21T03:40:47.9223542+02:00",
  "RepliedAt": "2020-12-18T03:40:47.9223542+01:00",
  "AlertTimeout": "2012-03-09T03:40:47.9223542+01:00",
  "Deadline": "2021-08-08T03:40:47.9223542+02:00",
  "CreatedBy": null,
  "Author": "sed",
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
      "Position": "ad",
      "PersonId": 339,
      "Mrmrs": "ex",
      "Firstname": "Travis",
      "Lastname": "Kovacek",
      "MiddleName": "Mosciski-Considine",
      "Title": "aut",
      "Description": "Extended attitude-oriented paradigm",
      "Email": "kade@davis.info",
      "FullName": "Lucius Medhurst",
      "DirectPhone": "413-357-0812 x0496",
      "FormalName": "Nolan, McCullough and Parker",
      "CountryId": 450,
      "ContactId": 8,
      "ContactName": "Daugherty-Dickens",
      "Retired": 783,
      "Rank": 685,
      "ActiveInterests": 706,
      "ContactDepartment": "",
      "ContactCountryId": 176,
      "ContactOrgNr": "1543612",
      "FaxPhone": "1-481-254-6673 x5994",
      "MobilePhone": "325.156.0288 x379",
      "ContactPhone": "1-420-428-1098",
      "AssociateName": "Kohler-Emard",
      "AssociateId": 704,
      "UsePersonAddress": false,
      "ContactFax": "repudiandae",
      "Kanafname": "et",
      "Kanalname": "quisquam",
      "Post1": "ipsam",
      "Post2": "quia",
      "Post3": "qui",
      "EmailName": "mallie.dietrich@goyette.ca",
      "ContactFullName": "Cathrine Beahan",
      "ActiveErpLinks": 787,
      "TicketPriorityId": 232,
      "SupportLanguageId": 62,
      "SupportAssociateId": 120,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1856379"
    }
  ],
  "AlertLevel": 183,
  "ConnectId": 923,
  "ReadStatus": "Green",
  "TimeToReply": 1002,
  "RealTimeToReply": 670,
  "TimeToClose": 108,
  "RealTimeToClose": 777,
  "TimeSpentInternally": 494,
  "TimeSpentExternally": 526,
  "TimeSpentQueue": 671,
  "RealTimeSpentInternally": 154,
  "RealTimeSpentExternally": 766,
  "RealTimeSpentQueue": 578,
  "TimeSpent": 603,
  "HasAttachment": false,
  "NumReplies": 233,
  "NumMessages": 436,
  "FromAddress": "facilis",
  "Messages": [
    {
      "TicketMessageId": 925,
      "CreatedAt": "2001-08-24T03:40:47.9379803+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "quidem",
      "PersonId": 151,
      "PersonFullName": "Mrs. Retha Anabelle Prosacco",
      "ContactId": 222,
      "ContactName": "Towne-Cruickshank",
      "ContactDepartment": "",
      "NumAttachments": 185,
      "EmailHeader": "meta@fay.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "sint",
      "Sentiment": 983,
      "SentimentConfidence": 118,
      "CreatedBy": 923,
      "ChangedAt": "2018-05-10T03:40:47.9379803+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 544,
      "Name": "Emard Group",
      "ToolTip": "Hic rerum animi facilis fugiat nulla."
    },
    {
      "Id": 544,
      "Name": "Emard Group",
      "ToolTip": "Hic rerum animi facilis fugiat nulla."
    }
  ],
  "Language": "accusantium",
  "Sentiment": 66,
  "SentimentConfidence": 593,
  "SuggestedCategoryId": 425,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 147,
  "IconHint": "assumenda",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 199,
  "ExtraFields": {
    "ExtraFields1": "doloribus",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "dolores",
    "CustomFields2": "omnis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 398,
  "Title": "minus",
  "CreatedAt": "1999-02-08T03:40:47.9379803+01:00",
  "LastChanged": "2012-02-28T03:40:47.9379803+01:00",
  "ReadByOwner": "1998-10-03T03:40:47.9379803+02:00",
  "ReadByCustomer": "2006-10-15T03:40:47.9379803+02:00",
  "FirstReadByOwner": "2023-02-17T03:40:47.9379803+01:00",
  "FirstReadByUser": "2007-02-03T03:40:47.9379803+01:00",
  "Activate": "2002-06-10T03:40:47.9379803+02:00",
  "ClosedAt": "2025-05-18T03:40:47.9379803+02:00",
  "RepliedAt": "2007-05-04T03:40:47.9379803+02:00",
  "AlertTimeout": "2012-01-12T03:40:47.9379803+01:00",
  "Deadline": "2013-08-17T03:40:47.9379803+02:00",
  "CreatedBy": null,
  "Author": "id",
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
      "PersonId": 627,
      "Mrmrs": "vel",
      "Firstname": "Uriel",
      "Lastname": "Hilpert",
      "MiddleName": "Kozey Group",
      "Title": "quos",
      "Description": "Down-sized eco-centric customer loyalty",
      "Email": "jack@blockcassin.uk",
      "FullName": "Jeffry Zula Schaefer IV",
      "DirectPhone": "238-266-7555 x391",
      "FormalName": "Orn-O'Kon",
      "CountryId": 204,
      "ContactId": 38,
      "ContactName": "Stamm LLC",
      "Retired": 939,
      "Rank": 893,
      "ActiveInterests": 542,
      "ContactDepartment": "",
      "ContactCountryId": 876,
      "ContactOrgNr": "1375859",
      "FaxPhone": "(575)782-7268",
      "MobilePhone": "387.191.4391",
      "ContactPhone": "099-513-3209 x8749",
      "AssociateName": "Robel Group",
      "AssociateId": 216,
      "UsePersonAddress": true,
      "ContactFax": "officiis",
      "Kanafname": "minus",
      "Kanalname": "molestiae",
      "Post1": "a",
      "Post2": "possimus",
      "Post3": "ducimus",
      "EmailName": "ken@kemmer.us",
      "ContactFullName": "Cathryn Prosacco",
      "ActiveErpLinks": 386,
      "TicketPriorityId": 712,
      "SupportLanguageId": 568,
      "SupportAssociateId": 215,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1175252",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 294
        }
      }
    }
  ],
  "AlertLevel": 958,
  "ConnectId": 917,
  "ReadStatus": "Green",
  "TimeToReply": 308,
  "RealTimeToReply": 378,
  "TimeToClose": 400,
  "RealTimeToClose": 99,
  "TimeSpentInternally": 501,
  "TimeSpentExternally": 577,
  "TimeSpentQueue": 401,
  "RealTimeSpentInternally": 437,
  "RealTimeSpentExternally": 132,
  "RealTimeSpentQueue": 965,
  "TimeSpent": 141,
  "HasAttachment": false,
  "NumReplies": 64,
  "NumMessages": 248,
  "FromAddress": "explicabo",
  "Messages": [
    {
      "TicketMessageId": 209,
      "CreatedAt": "2006-10-20T03:40:47.9379803+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "consectetur",
      "PersonId": 967,
      "PersonFullName": "Mortimer Ward",
      "ContactId": 147,
      "ContactName": "Nicolas, Kuhn and McLaughlin",
      "ContactDepartment": "",
      "NumAttachments": 460,
      "EmailHeader": "hobart@bashirian.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "enim",
      "Sentiment": 207,
      "SentimentConfidence": 509,
      "CreatedBy": 875,
      "ChangedAt": "2021-01-13T03:40:47.9536063+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 637
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 608,
      "Name": "Huel-D'Amore",
      "ToolTip": "Voluptatibus rerum recusandae iure qui totam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 914
        }
      }
    },
    {
      "Id": 608,
      "Name": "Huel-D'Amore",
      "ToolTip": "Voluptatibus rerum recusandae iure qui totam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 914
        }
      }
    }
  ],
  "Language": "architecto",
  "Sentiment": 263,
  "SentimentConfidence": 553,
  "SuggestedCategoryId": 433,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 437,
  "IconHint": "exercitationem",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 401,
  "ExtraFields": {
    "ExtraFields1": "sint",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "animi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 559
    }
  }
}
```