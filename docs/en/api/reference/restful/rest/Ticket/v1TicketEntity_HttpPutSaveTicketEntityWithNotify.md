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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 843,
  "Title": "laboriosam",
  "CreatedAt": "2011-08-02T16:55:30.1980405+02:00",
  "LastChanged": "2017-09-27T16:55:30.1980405+02:00",
  "ReadByOwner": "2007-07-15T16:55:30.1980405+02:00",
  "ReadByCustomer": "2011-08-23T16:55:30.1980405+02:00",
  "FirstReadByOwner": "2014-02-14T16:55:30.1980405+01:00",
  "FirstReadByUser": "2015-02-14T16:55:30.1980405+01:00",
  "Activate": "2002-10-15T16:55:30.1980405+02:00",
  "ClosedAt": "2003-01-05T16:55:30.1980405+01:00",
  "RepliedAt": "2005-04-29T16:55:30.1980405+02:00",
  "AlertTimeout": "2017-10-05T16:55:30.1980405+02:00",
  "Deadline": "2006-09-01T16:55:30.1980405+02:00",
  "CreatedBy": null,
  "Author": "et",
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
      "PersonId": 517,
      "Mrmrs": "dolores",
      "Firstname": "Timmothy",
      "Lastname": "Miller",
      "MiddleName": "Russel LLC",
      "Title": "nisi",
      "Description": "Up-sized maximized Graphic Interface",
      "Email": "margarete.bode@herman.uk",
      "FullName": "Miss Rachael Toney Parisian III",
      "DirectPhone": "138.789.6770",
      "FormalName": "Mann-Lynch",
      "CountryId": 19,
      "ContactId": 79,
      "ContactName": "Padberg-O'Hara",
      "Retired": 977,
      "Rank": 921,
      "ActiveInterests": 439,
      "ContactDepartment": "",
      "ContactCountryId": 555,
      "ContactOrgNr": "1339741",
      "FaxPhone": "825.248.4096 x51622",
      "MobilePhone": "617-977-2552 x302",
      "ContactPhone": "1-310-606-1110",
      "AssociateName": "Ryan Group",
      "AssociateId": 758,
      "UsePersonAddress": false,
      "ContactFax": "suscipit",
      "Kanafname": "est",
      "Kanalname": "qui",
      "Post1": "dicta",
      "Post2": "consectetur",
      "Post3": "eum",
      "EmailName": "joshua@weissnatschmidt.us",
      "ContactFullName": "Miss Lenny Osinski DVM",
      "ActiveErpLinks": 15,
      "TicketPriorityId": 334,
      "SupportLanguageId": 777,
      "SupportAssociateId": 772,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 418,
  "ConnectId": 555,
  "ReadStatus": "Green",
  "TimeToReply": 945,
  "RealTimeToReply": 472,
  "TimeToClose": 208,
  "RealTimeToClose": 78,
  "TimeSpentInternally": 672,
  "TimeSpentExternally": 67,
  "TimeSpentQueue": 224,
  "RealTimeSpentInternally": 804,
  "RealTimeSpentExternally": 656,
  "RealTimeSpentQueue": 65,
  "TimeSpent": 779,
  "HasAttachment": false,
  "NumReplies": 694,
  "NumMessages": 177,
  "FromAddress": "autem",
  "Messages": [
    {
      "TicketMessageId": 672,
      "CreatedAt": "2000-10-26T16:55:30.2030465+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "corporis",
      "PersonId": 929,
      "PersonFullName": "Mr. Arnulfo Bednar MD",
      "ContactId": 420,
      "ContactName": "Nikolaus, Skiles and Heaney",
      "ContactDepartment": "",
      "NumAttachments": 418,
      "EmailHeader": "eloisa.aufderhar@hagenes.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "impedit",
      "Sentiment": 714,
      "SentimentConfidence": 95,
      "CreatedBy": 512,
      "ChangedAt": "2013-07-20T16:55:30.2030465+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 943,
      "Name": "Cruickshank-Romaguera",
      "ToolTip": "Corrupti blanditiis labore numquam rerum mollitia."
    },
    {
      "Id": 943,
      "Name": "Cruickshank-Romaguera",
      "ToolTip": "Corrupti blanditiis labore numquam rerum mollitia."
    }
  ],
  "Language": "ut",
  "Sentiment": 72,
  "SentimentConfidence": 291,
  "SuggestedCategoryId": 278,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 127,
  "IconHint": "soluta",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 325,
  "ExtraFields": {
    "ExtraFields1": "iusto",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "eos"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 807,
  "Title": "aspernatur",
  "CreatedAt": "2001-01-18T16:55:30.2110453+01:00",
  "LastChanged": "2004-01-07T16:55:30.2110453+01:00",
  "ReadByOwner": "2012-12-31T16:55:30.2110453+01:00",
  "ReadByCustomer": "1997-12-25T16:55:30.2110453+01:00",
  "FirstReadByOwner": "1997-09-01T16:55:30.2110453+02:00",
  "FirstReadByUser": "2021-08-26T16:55:30.2110453+02:00",
  "Activate": "2011-01-30T16:55:30.2110453+01:00",
  "ClosedAt": "2011-11-27T16:55:30.2110453+01:00",
  "RepliedAt": "2013-03-05T16:55:30.2110453+01:00",
  "AlertTimeout": "2000-05-09T16:55:30.2110453+02:00",
  "Deadline": "2023-11-27T16:55:30.2110453+01:00",
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
      "Position": "molestiae",
      "PersonId": 251,
      "Mrmrs": "qui",
      "Firstname": "Isabella",
      "Lastname": "Parisian",
      "MiddleName": "Quitzon-Hammes",
      "Title": "nulla",
      "Description": "Reverse-engineered regional methodology",
      "Email": "elijah_veum@kunde.uk",
      "FullName": "Dr. Pierce Eriberto Murazik",
      "DirectPhone": "1-029-247-0933",
      "FormalName": "Wyman, Muller and Runte",
      "CountryId": 164,
      "ContactId": 880,
      "ContactName": "Goyette-Treutel",
      "Retired": 957,
      "Rank": 774,
      "ActiveInterests": 471,
      "ContactDepartment": "",
      "ContactCountryId": 17,
      "ContactOrgNr": "1000627",
      "FaxPhone": "(190)920-0493 x507",
      "MobilePhone": "841-222-6239",
      "ContactPhone": "(663)616-4287",
      "AssociateName": "O'Keefe LLC",
      "AssociateId": 925,
      "UsePersonAddress": true,
      "ContactFax": "porro",
      "Kanafname": "voluptatem",
      "Kanalname": "laboriosam",
      "Post1": "temporibus",
      "Post2": "officiis",
      "Post3": "dolor",
      "EmailName": "abagail_towne@ortiz.uk",
      "ContactFullName": "Johann Dietrich",
      "ActiveErpLinks": 416,
      "TicketPriorityId": 572,
      "SupportLanguageId": 193,
      "SupportAssociateId": 531,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 995
        }
      }
    }
  ],
  "AlertLevel": 111,
  "ConnectId": 72,
  "ReadStatus": "Green",
  "TimeToReply": 154,
  "RealTimeToReply": 920,
  "TimeToClose": 670,
  "RealTimeToClose": 708,
  "TimeSpentInternally": 26,
  "TimeSpentExternally": 482,
  "TimeSpentQueue": 258,
  "RealTimeSpentInternally": 323,
  "RealTimeSpentExternally": 563,
  "RealTimeSpentQueue": 419,
  "TimeSpent": 254,
  "HasAttachment": false,
  "NumReplies": 13,
  "NumMessages": 724,
  "FromAddress": "incidunt",
  "Messages": [
    {
      "TicketMessageId": 213,
      "CreatedAt": "2022-06-15T16:55:30.2150504+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "error",
      "PersonId": 12,
      "PersonFullName": "Arlie Block",
      "ContactId": 906,
      "ContactName": "Larkin, Beatty and O'Reilly",
      "ContactDepartment": "",
      "NumAttachments": 48,
      "EmailHeader": "fiona@schumm.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "temporibus",
      "Sentiment": 191,
      "SentimentConfidence": 824,
      "CreatedBy": 850,
      "ChangedAt": "2008-04-12T16:55:30.2160488+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 356
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 726,
      "Name": "Barrows-Kling",
      "ToolTip": "Vel temporibus ullam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 750
        }
      }
    },
    {
      "Id": 726,
      "Name": "Barrows-Kling",
      "ToolTip": "Vel temporibus ullam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 750
        }
      }
    }
  ],
  "Language": "voluptatem",
  "Sentiment": 136,
  "SentimentConfidence": 204,
  "SuggestedCategoryId": 754,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 738,
  "IconHint": "natus",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 88,
  "ExtraFields": {
    "ExtraFields1": "tempore",
    "ExtraFields2": "deserunt"
  },
  "CustomFields": {
    "CustomFields1": "temporibus",
    "CustomFields2": "doloremque"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 570
    }
  }
}
```