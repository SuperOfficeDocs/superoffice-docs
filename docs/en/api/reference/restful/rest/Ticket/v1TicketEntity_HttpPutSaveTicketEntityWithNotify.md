---
title: PUT Ticket/{id}
uid: v1TicketEntity_HttpPutSaveTicketEntityWithNotify
generated: true
content_type: reference
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
  "TicketId": 335,
  "Title": "corporis",
  "CreatedAt": "2024-10-05T02:30:52.9599012+02:00",
  "LastChanged": "2018-04-23T02:30:52.9599012+02:00",
  "ReadByOwner": "2018-06-30T02:30:52.9599012+02:00",
  "ReadByCustomer": "2025-03-11T02:30:52.9599012+01:00",
  "FirstReadByOwner": "2009-05-15T02:30:52.9599012+02:00",
  "FirstReadByUser": "2018-12-26T02:30:52.9599012+01:00",
  "Activate": "2010-12-28T02:30:52.9599012+01:00",
  "ClosedAt": "2003-02-01T02:30:52.9599012+01:00",
  "RepliedAt": "2019-02-28T02:30:52.9599012+01:00",
  "AlertTimeout": "2006-12-02T02:30:52.9599012+01:00",
  "Deadline": "1999-07-01T02:30:52.9599012+02:00",
  "CreatedBy": null,
  "Author": "ab",
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
      "Position": "ipsa",
      "PersonId": 298,
      "Mrmrs": "molestiae",
      "Firstname": "Joanie",
      "Lastname": "Gleichner",
      "MiddleName": "Douglas-Jast",
      "Title": "omnis",
      "Description": "De-engineered zero defect encoding",
      "Email": "lucious.konopelski@zieme.ca",
      "FullName": "Tremaine Grant",
      "DirectPhone": "(738)599-2901",
      "FormalName": "Paucek Group",
      "CountryId": 135,
      "ContactId": 305,
      "ContactName": "Herzog Inc and Sons",
      "Retired": 585,
      "Rank": 831,
      "ActiveInterests": 20,
      "ContactDepartment": "",
      "ContactCountryId": 532,
      "ContactOrgNr": "1162532",
      "FaxPhone": "927.081.4537 x03105",
      "MobilePhone": "561-771-5814 x453",
      "ContactPhone": "(173)327-4513",
      "AssociateName": "Ledner-Gaylord",
      "AssociateId": 232,
      "UsePersonAddress": false,
      "ContactFax": "ipsam",
      "Kanafname": "soluta",
      "Kanalname": "explicabo",
      "Post1": "ullam",
      "Post2": "ea",
      "Post3": "repudiandae",
      "EmailName": "ali@bogisich.name",
      "ContactFullName": "Ms. Efrain Anderson V",
      "ActiveErpLinks": 603,
      "TicketPriorityId": 99,
      "SupportLanguageId": 80,
      "SupportAssociateId": 962,
      "CategoryName": "VIP Customer",
      "PersonNumber": "966979"
    }
  ],
  "AlertLevel": 608,
  "ConnectId": 924,
  "ReadStatus": "Green",
  "TimeToReply": 869,
  "RealTimeToReply": 216,
  "TimeToClose": 54,
  "RealTimeToClose": 415,
  "TimeSpentInternally": 38,
  "TimeSpentExternally": 562,
  "TimeSpentQueue": 880,
  "RealTimeSpentInternally": 200,
  "RealTimeSpentExternally": 245,
  "RealTimeSpentQueue": 904,
  "TimeSpent": 560,
  "HasAttachment": false,
  "NumReplies": 348,
  "NumMessages": 8,
  "FromAddress": "autem",
  "Messages": [
    {
      "TicketMessageId": 956,
      "CreatedAt": "2022-10-20T02:30:52.9755254+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "culpa",
      "PersonId": 611,
      "PersonFullName": "Kiley Auer",
      "ContactId": 362,
      "ContactName": "Rosenbaum-Nienow",
      "ContactDepartment": "",
      "NumAttachments": 215,
      "EmailHeader": "aglae@zboncak.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "possimus",
      "Sentiment": 785,
      "SentimentConfidence": 639,
      "CreatedBy": 316,
      "ChangedAt": "2015-01-01T02:30:52.9755254+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 505,
      "Name": "Wehner-Schaefer",
      "ToolTip": "Cumque repellat qui alias est a ullam aut."
    },
    {
      "Id": 505,
      "Name": "Wehner-Schaefer",
      "ToolTip": "Cumque repellat qui alias est a ullam aut."
    }
  ],
  "Language": "odio",
  "Sentiment": 196,
  "SentimentConfidence": 76,
  "SuggestedCategoryId": 305,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 261,
  "IconHint": "voluptate",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 164,
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "esse",
    "CustomFields2": "tenetur"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 726,
  "Title": "aliquam",
  "CreatedAt": "2015-06-04T02:30:52.9755254+02:00",
  "LastChanged": "2003-03-07T02:30:52.9755254+01:00",
  "ReadByOwner": "2003-11-11T02:30:52.9755254+01:00",
  "ReadByCustomer": "2013-10-08T02:30:52.9755254+02:00",
  "FirstReadByOwner": "2021-05-07T02:30:52.9755254+02:00",
  "FirstReadByUser": "2014-09-11T02:30:52.9755254+02:00",
  "Activate": "2008-01-20T02:30:52.9755254+01:00",
  "ClosedAt": "2020-01-25T02:30:52.9755254+01:00",
  "RepliedAt": "2013-07-20T02:30:52.9755254+02:00",
  "AlertTimeout": "2022-10-16T02:30:52.9755254+02:00",
  "Deadline": "2010-09-03T02:30:52.9755254+02:00",
  "CreatedBy": null,
  "Author": "veniam",
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
      "Position": "illum",
      "PersonId": 687,
      "Mrmrs": "adipisci",
      "Firstname": "Leonard",
      "Lastname": "Bosco",
      "MiddleName": "Abbott-Nader",
      "Title": "illo",
      "Description": "Advanced 5th generation time-frame",
      "Email": "jaylon@turcotte.co.uk",
      "FullName": "Alfonso Schaden",
      "DirectPhone": "636-929-9471",
      "FormalName": "Kris Group",
      "CountryId": 643,
      "ContactId": 295,
      "ContactName": "Haag-Pfannerstill",
      "Retired": 391,
      "Rank": 384,
      "ActiveInterests": 263,
      "ContactDepartment": "",
      "ContactCountryId": 640,
      "ContactOrgNr": "522164",
      "FaxPhone": "(331)468-8224 x292",
      "MobilePhone": "(494)198-2151 x05360",
      "ContactPhone": "435.113.3160 x13936",
      "AssociateName": "Lemke-Schinner",
      "AssociateId": 168,
      "UsePersonAddress": false,
      "ContactFax": "quam",
      "Kanafname": "delectus",
      "Kanalname": "qui",
      "Post1": "odio",
      "Post2": "velit",
      "Post3": "aut",
      "EmailName": "mohammad@rippin.biz",
      "ContactFullName": "Mrs. Aubree Santino Nienow V",
      "ActiveErpLinks": 820,
      "TicketPriorityId": 892,
      "SupportLanguageId": 661,
      "SupportAssociateId": 971,
      "CategoryName": "VIP Customer",
      "PersonNumber": "853191",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 9
        }
      }
    }
  ],
  "AlertLevel": 773,
  "ConnectId": 793,
  "ReadStatus": "Green",
  "TimeToReply": 360,
  "RealTimeToReply": 748,
  "TimeToClose": 966,
  "RealTimeToClose": 460,
  "TimeSpentInternally": 699,
  "TimeSpentExternally": 592,
  "TimeSpentQueue": 853,
  "RealTimeSpentInternally": 516,
  "RealTimeSpentExternally": 298,
  "RealTimeSpentQueue": 383,
  "TimeSpent": 936,
  "HasAttachment": false,
  "NumReplies": 577,
  "NumMessages": 726,
  "FromAddress": "ratione",
  "Messages": [
    {
      "TicketMessageId": 554,
      "CreatedAt": "2013-02-17T02:30:52.9755254+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "et",
      "PersonId": 454,
      "PersonFullName": "Mr. Jamison Baumbach",
      "ContactId": 119,
      "ContactName": "Crist, Kuhlman and Ryan",
      "ContactDepartment": "",
      "NumAttachments": 186,
      "EmailHeader": "kole@jacobsonwisozk.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "et",
      "Sentiment": 526,
      "SentimentConfidence": 181,
      "CreatedBy": 876,
      "ChangedAt": "2015-04-14T02:30:52.9755254+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 58
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 111,
      "Name": "Satterfield, Block and Jaskolski",
      "ToolTip": "Veniam quas consequatur id alias adipisci rem sit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 442
        }
      }
    },
    {
      "Id": 111,
      "Name": "Satterfield, Block and Jaskolski",
      "ToolTip": "Veniam quas consequatur id alias adipisci rem sit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 442
        }
      }
    }
  ],
  "Language": "amet",
  "Sentiment": 440,
  "SentimentConfidence": 138,
  "SuggestedCategoryId": 851,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 564,
  "IconHint": "possimus",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 755,
  "ExtraFields": {
    "ExtraFields1": "magnam",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "cum",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 515
    }
  }
}
```