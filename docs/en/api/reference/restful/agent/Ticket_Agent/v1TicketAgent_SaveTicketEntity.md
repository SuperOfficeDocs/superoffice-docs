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
POST /api/v1/Agents/Ticket/SaveTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 673,
  "Title": "odio",
  "CreatedAt": "2007-11-24T13:57:13.3009039+01:00",
  "LastChanged": "2013-05-14T13:57:13.3009039+02:00",
  "ReadByOwner": "1999-03-18T13:57:13.3009039+01:00",
  "ReadByCustomer": "1999-08-23T13:57:13.3009039+02:00",
  "FirstReadByOwner": "2006-01-08T13:57:13.3009039+01:00",
  "FirstReadByUser": "2010-03-12T13:57:13.3009039+01:00",
  "Activate": "2014-03-09T13:57:13.3009039+01:00",
  "ClosedAt": "2001-09-20T13:57:13.3009039+02:00",
  "RepliedAt": "2021-05-12T13:57:13.3009039+02:00",
  "AlertTimeout": "2015-12-27T13:57:13.3009039+01:00",
  "Deadline": "2014-06-07T13:57:13.3009039+02:00",
  "CreatedBy": null,
  "Author": "eum",
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
      "Position": "consequatur",
      "PersonId": 983,
      "Mrmrs": "sunt",
      "Firstname": "Beulah",
      "Lastname": "Schamberger",
      "MiddleName": "Waelchi Group",
      "Title": "nemo",
      "Description": "Visionary multi-state encryption",
      "Email": "estelle@kilbackwill.uk",
      "FullName": "Mr. Meaghan Corkery",
      "DirectPhone": "(378)904-6332",
      "FormalName": "Ruecker-Kihn",
      "CountryId": 513,
      "ContactId": 72,
      "ContactName": "Hudson-Reinger",
      "Retired": 399,
      "Rank": 675,
      "ActiveInterests": 429,
      "ContactDepartment": "",
      "ContactCountryId": 206,
      "ContactOrgNr": "1683056",
      "FaxPhone": "456.044.6009 x8035",
      "MobilePhone": "560-708-7939 x0970",
      "ContactPhone": "756.239.3023",
      "AssociateName": "Zieme, Nikolaus and Goyette",
      "AssociateId": 222,
      "UsePersonAddress": false,
      "ContactFax": "voluptatem",
      "Kanafname": "sit",
      "Kanalname": "quam",
      "Post1": "aperiam",
      "Post2": "neque",
      "Post3": "consequatur",
      "EmailName": "alda@bernier.ca",
      "ContactFullName": "Mrs. Amber Bo Pagac PhD",
      "ActiveErpLinks": 481,
      "TicketPriorityId": 353,
      "SupportLanguageId": 333,
      "SupportAssociateId": 535,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 175,
  "ConnectId": 120,
  "ReadStatus": "Green",
  "TimeToReply": 19,
  "RealTimeToReply": 952,
  "TimeToClose": 187,
  "RealTimeToClose": 673,
  "TimeSpentInternally": 513,
  "TimeSpentExternally": 248,
  "TimeSpentQueue": 1002,
  "RealTimeSpentInternally": 137,
  "RealTimeSpentExternally": 563,
  "RealTimeSpentQueue": 532,
  "TimeSpent": 690,
  "HasAttachment": false,
  "NumReplies": 270,
  "NumMessages": 446,
  "FromAddress": "omnis",
  "Messages": [
    {
      "TicketMessageId": 280,
      "CreatedAt": "2005-03-20T13:57:13.3176761+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "quia",
      "PersonId": 777,
      "PersonFullName": "Miss Ansley Payton Lynch MD",
      "ContactId": 227,
      "ContactName": "Harris-Fahey",
      "ContactDepartment": "aggregate out-of-the-box schemas",
      "NumAttachments": 652,
      "EmailHeader": "maiya_beahan@emmerich.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "dolorem",
      "Sentiment": 393,
      "SentimentConfidence": 125,
      "CreatedBy": 297,
      "ChangedAt": "1997-08-14T13:57:13.3176761+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 38,
      "Name": "Cole, Wiza and Bradtke",
      "ToolTip": "Placeat quia aut et iste magni qui ut."
    },
    {
      "Id": 38,
      "Name": "Cole, Wiza and Bradtke",
      "ToolTip": "Placeat quia aut et iste magni qui ut."
    }
  ],
  "Language": "praesentium",
  "Sentiment": 656,
  "SentimentConfidence": 322,
  "SuggestedCategoryId": 760,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 979,
  "IconHint": "porro",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "voluptatum",
    "ExtraFields2": "illum"
  },
  "CustomFields": {
    "CustomFields1": "ipsam",
    "CustomFields2": "provident"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 620,
  "Title": "fugiat",
  "CreatedAt": "2016-01-24T13:57:13.3176761+01:00",
  "LastChanged": "2001-05-07T13:57:13.3176761+02:00",
  "ReadByOwner": "2001-04-12T13:57:13.3176761+02:00",
  "ReadByCustomer": "2020-09-20T13:57:13.3176761+02:00",
  "FirstReadByOwner": "2004-11-06T13:57:13.3176761+01:00",
  "FirstReadByUser": "2000-05-24T13:57:13.3176761+02:00",
  "Activate": "2006-07-18T13:57:13.3176761+02:00",
  "ClosedAt": "2004-12-01T13:57:13.3176761+01:00",
  "RepliedAt": "1998-09-23T13:57:13.3176761+02:00",
  "AlertTimeout": "2018-09-05T13:57:13.3176761+02:00",
  "Deadline": "2011-04-17T13:57:13.3176761+02:00",
  "CreatedBy": null,
  "Author": "sapiente",
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
      "Position": "quibusdam",
      "PersonId": 746,
      "Mrmrs": "exercitationem",
      "Firstname": "Lambert",
      "Lastname": "Nader",
      "MiddleName": "Daugherty Inc and Sons",
      "Title": "dolores",
      "Description": "Profit-focused hybrid solution",
      "Email": "sid.mckenzie@dickinson.biz",
      "FullName": "River Greenholt Sr.",
      "DirectPhone": "1-890-963-9741",
      "FormalName": "Hills, Franecki and Pouros",
      "CountryId": 697,
      "ContactId": 82,
      "ContactName": "Hyatt-Hartmann",
      "Retired": 432,
      "Rank": 420,
      "ActiveInterests": 500,
      "ContactDepartment": "",
      "ContactCountryId": 451,
      "ContactOrgNr": "1088348",
      "FaxPhone": "(816)610-8156 x99466",
      "MobilePhone": "1-588-856-3716 x228",
      "ContactPhone": "985.243.7687 x6212",
      "AssociateName": "Hermiston LLC",
      "AssociateId": 441,
      "UsePersonAddress": true,
      "ContactFax": "cupiditate",
      "Kanafname": "debitis",
      "Kanalname": "ut",
      "Post1": "sit",
      "Post2": "dignissimos",
      "Post3": "non",
      "EmailName": "garnett@bartoletti.us",
      "ContactFullName": "Mrs. Concepcion Hartmann",
      "ActiveErpLinks": 612,
      "TicketPriorityId": 181,
      "SupportLanguageId": 347,
      "SupportAssociateId": 137,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 2
        }
      }
    }
  ],
  "AlertLevel": 480,
  "ConnectId": 179,
  "ReadStatus": "Green",
  "TimeToReply": 389,
  "RealTimeToReply": 996,
  "TimeToClose": 736,
  "RealTimeToClose": 361,
  "TimeSpentInternally": 760,
  "TimeSpentExternally": 324,
  "TimeSpentQueue": 259,
  "RealTimeSpentInternally": 956,
  "RealTimeSpentExternally": 31,
  "RealTimeSpentQueue": 835,
  "TimeSpent": 772,
  "HasAttachment": true,
  "NumReplies": 448,
  "NumMessages": 462,
  "FromAddress": "et",
  "Messages": [
    {
      "TicketMessageId": 871,
      "CreatedAt": "1997-09-17T13:57:13.3176761+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "facilis",
      "PersonId": 930,
      "PersonFullName": "Oren Hamill DDS",
      "ContactId": 545,
      "ContactName": "Kassulke LLC",
      "ContactDepartment": "",
      "NumAttachments": 609,
      "EmailHeader": "lexi@mraz.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quae",
      "Sentiment": 505,
      "SentimentConfidence": 663,
      "CreatedBy": 22,
      "ChangedAt": "2021-01-30T13:57:13.3176761+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 455
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 430,
      "Name": "Runolfsson-Barrows",
      "ToolTip": "Sed nam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 63
        }
      }
    },
    {
      "Id": 430,
      "Name": "Runolfsson-Barrows",
      "ToolTip": "Sed nam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 63
        }
      }
    }
  ],
  "Language": "atque",
  "Sentiment": 206,
  "SentimentConfidence": 116,
  "SuggestedCategoryId": 1002,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 77,
  "IconHint": "enim",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "dicta",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "nulla",
    "CustomFields2": "fugiat"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 727
    }
  }
}
```