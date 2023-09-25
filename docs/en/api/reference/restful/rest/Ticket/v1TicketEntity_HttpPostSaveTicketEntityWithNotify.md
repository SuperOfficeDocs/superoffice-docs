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
POST /api/v1/Ticket?notify=True
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 851,
  "Title": "iusto",
  "CreatedAt": "2021-06-08T03:24:51.943244+02:00",
  "LastChanged": "2020-03-30T03:24:51.943244+02:00",
  "ReadByOwner": "2005-07-09T03:24:51.943244+02:00",
  "ReadByCustomer": "2015-09-11T03:24:51.943244+02:00",
  "FirstReadByOwner": "1997-06-28T03:24:51.943244+02:00",
  "FirstReadByUser": "1997-11-22T03:24:51.943244+01:00",
  "Activate": "1997-04-28T03:24:51.943244+02:00",
  "ClosedAt": "2001-11-01T03:24:51.943244+01:00",
  "RepliedAt": "2004-10-27T03:24:51.943244+02:00",
  "AlertTimeout": "2014-09-27T03:24:51.943244+02:00",
  "Deadline": "1998-04-03T03:24:51.943244+02:00",
  "CreatedBy": null,
  "Author": "atque",
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
      "Position": "quo",
      "PersonId": 784,
      "Mrmrs": "voluptates",
      "Firstname": "Abbey",
      "Lastname": "Gutkowski",
      "MiddleName": "Schowalter Inc and Sons",
      "Title": "voluptatem",
      "Description": "Re-contextualized methodical migration",
      "Email": "matt@klein.co.uk",
      "FullName": "Marlee Corkery",
      "DirectPhone": "(968)379-7612",
      "FormalName": "Kutch-Gottlieb",
      "CountryId": 262,
      "ContactId": 293,
      "ContactName": "Sanford-Hayes",
      "Retired": 717,
      "Rank": 617,
      "ActiveInterests": 597,
      "ContactDepartment": "",
      "ContactCountryId": 329,
      "ContactOrgNr": "1665791",
      "FaxPhone": "974.931.1584 x62915",
      "MobilePhone": "1-801-771-1508",
      "ContactPhone": "252.613.5065 x6385",
      "AssociateName": "Heidenreich Inc and Sons",
      "AssociateId": 502,
      "UsePersonAddress": false,
      "ContactFax": "culpa",
      "Kanafname": "cum",
      "Kanalname": "in",
      "Post1": "qui",
      "Post2": "et",
      "Post3": "molestiae",
      "EmailName": "erwin.osinski@hilpert.name",
      "ContactFullName": "Fernando Mayert",
      "ActiveErpLinks": 295,
      "TicketPriorityId": 370,
      "SupportLanguageId": 640,
      "SupportAssociateId": 377,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 137,
  "ConnectId": 883,
  "ReadStatus": "Green",
  "TimeToReply": 305,
  "RealTimeToReply": 662,
  "TimeToClose": 186,
  "RealTimeToClose": 467,
  "TimeSpentInternally": 682,
  "TimeSpentExternally": 83,
  "TimeSpentQueue": 173,
  "RealTimeSpentInternally": 145,
  "RealTimeSpentExternally": 259,
  "RealTimeSpentQueue": 352,
  "TimeSpent": 181,
  "HasAttachment": true,
  "NumReplies": 806,
  "NumMessages": 46,
  "FromAddress": "dolorum",
  "Messages": [
    {
      "TicketMessageId": 500,
      "CreatedAt": "1996-05-12T03:24:51.943244+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "voluptas",
      "PersonId": 381,
      "PersonFullName": "Alexandrea Larkin",
      "ContactId": 166,
      "ContactName": "Kessler-Lockman",
      "ContactDepartment": "",
      "NumAttachments": 134,
      "EmailHeader": "raegan@hahn.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "explicabo",
      "Sentiment": 533,
      "SentimentConfidence": 697,
      "CreatedBy": 731,
      "ChangedAt": "2002-05-05T03:24:51.943244+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 638,
      "Name": "Volkman-Wehner",
      "ToolTip": "Occaecati ut soluta nostrum corporis deleniti modi et."
    },
    {
      "Id": 638,
      "Name": "Volkman-Wehner",
      "ToolTip": "Occaecati ut soluta nostrum corporis deleniti modi et."
    }
  ],
  "Language": "quidem",
  "Sentiment": 416,
  "SentimentConfidence": 18,
  "SuggestedCategoryId": 417,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 24,
  "IconHint": "possimus",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "iste"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "sint"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 978,
  "Title": "explicabo",
  "CreatedAt": "2022-04-22T03:24:51.943244+02:00",
  "LastChanged": "2012-05-31T03:24:51.943244+02:00",
  "ReadByOwner": "2014-05-26T03:24:51.943244+02:00",
  "ReadByCustomer": "2010-08-01T03:24:51.943244+02:00",
  "FirstReadByOwner": "2003-03-14T03:24:51.943244+01:00",
  "FirstReadByUser": "1996-07-04T03:24:51.943244+02:00",
  "Activate": "2008-07-07T03:24:51.943244+02:00",
  "ClosedAt": "2011-04-16T03:24:51.943244+02:00",
  "RepliedAt": "2020-04-18T03:24:51.943244+02:00",
  "AlertTimeout": "2006-08-19T03:24:51.943244+02:00",
  "Deadline": "2004-09-09T03:24:51.943244+02:00",
  "CreatedBy": null,
  "Author": "eligendi",
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
      "PersonId": 670,
      "Mrmrs": "blanditiis",
      "Firstname": "Elijah",
      "Lastname": "O'Keefe",
      "MiddleName": "Maggio Group",
      "Title": "et",
      "Description": "Virtual intangible encryption",
      "Email": "lourdes@bosco.ca",
      "FullName": "Bernadette Padberg",
      "DirectPhone": "1-190-553-6536 x2300",
      "FormalName": "Marquardt Inc and Sons",
      "CountryId": 58,
      "ContactId": 731,
      "ContactName": "Keebler, Lowe and Tromp",
      "Retired": 430,
      "Rank": 926,
      "ActiveInterests": 961,
      "ContactDepartment": "",
      "ContactCountryId": 676,
      "ContactOrgNr": "695092",
      "FaxPhone": "(979)578-2348 x242",
      "MobilePhone": "077-716-7417",
      "ContactPhone": "1-651-645-4533 x45778",
      "AssociateName": "Rolfson, Champlin and Dibbert",
      "AssociateId": 649,
      "UsePersonAddress": false,
      "ContactFax": "qui",
      "Kanafname": "occaecati",
      "Kanalname": "quod",
      "Post1": "quia",
      "Post2": "ipsum",
      "Post3": "possimus",
      "EmailName": "verona_stiedemann@armstrong.co.uk",
      "ContactFullName": "Dr. Kimberly Jacklyn Schuster DVM",
      "ActiveErpLinks": 490,
      "TicketPriorityId": 323,
      "SupportLanguageId": 136,
      "SupportAssociateId": 929,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 916
        }
      }
    }
  ],
  "AlertLevel": 779,
  "ConnectId": 672,
  "ReadStatus": "Green",
  "TimeToReply": 232,
  "RealTimeToReply": 102,
  "TimeToClose": 523,
  "RealTimeToClose": 975,
  "TimeSpentInternally": 798,
  "TimeSpentExternally": 620,
  "TimeSpentQueue": 435,
  "RealTimeSpentInternally": 577,
  "RealTimeSpentExternally": 221,
  "RealTimeSpentQueue": 688,
  "TimeSpent": 448,
  "HasAttachment": false,
  "NumReplies": 405,
  "NumMessages": 427,
  "FromAddress": "ipsam",
  "Messages": [
    {
      "TicketMessageId": 558,
      "CreatedAt": "2016-11-09T03:24:51.9588682+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "ipsum",
      "PersonId": 297,
      "PersonFullName": "Onie Walsh",
      "ContactId": 966,
      "ContactName": "Pagac LLC",
      "ContactDepartment": "visualize distributed schemas",
      "NumAttachments": 277,
      "EmailHeader": "karianne@nader.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "qui",
      "Sentiment": 423,
      "SentimentConfidence": 159,
      "CreatedBy": 933,
      "ChangedAt": "2019-10-17T03:24:51.9588682+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 16
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 422,
      "Name": "Wolf LLC",
      "ToolTip": "Laudantium repellat quidem ipsam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 484
        }
      }
    },
    {
      "Id": 422,
      "Name": "Wolf LLC",
      "ToolTip": "Laudantium repellat quidem ipsam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 484
        }
      }
    }
  ],
  "Language": "repudiandae",
  "Sentiment": 872,
  "SentimentConfidence": 734,
  "SuggestedCategoryId": 319,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 290,
  "IconHint": "iste",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "recusandae"
  },
  "CustomFields": {
    "CustomFields1": "quibusdam",
    "CustomFields2": "placeat"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 288
    }
  }
}
```