---
title: POST Agents/Ticket/SaveTicketEntity
uid: v1TicketAgent_SaveTicketEntity
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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Ticket/SaveTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 286,
  "Title": "ut",
  "CreatedAt": "2004-08-04T14:19:04.3765753+02:00",
  "LastChanged": "2020-09-19T14:19:04.3765753+02:00",
  "ReadByOwner": "2012-07-20T14:19:04.3765753+02:00",
  "ReadByCustomer": "2000-03-15T14:19:04.3765753+01:00",
  "FirstReadByOwner": "2020-08-18T14:19:04.3765753+02:00",
  "FirstReadByUser": "2000-08-23T14:19:04.3765753+02:00",
  "Activate": "2010-12-23T14:19:04.3765753+01:00",
  "ClosedAt": "1996-12-21T14:19:04.3765753+01:00",
  "RepliedAt": "2020-10-06T14:19:04.3765753+02:00",
  "AlertTimeout": "2023-02-12T14:19:04.3765753+01:00",
  "Deadline": "2000-10-16T14:19:04.3765753+02:00",
  "CreatedBy": null,
  "Author": "consequuntur",
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
      "PersonId": 41,
      "Mrmrs": "similique",
      "Firstname": "Ramona",
      "Lastname": "Kulas",
      "MiddleName": "Welch Group",
      "Title": "maiores",
      "Description": "Configurable 3rd generation open system",
      "Email": "ashtyn.shanahan@gulgowski.uk",
      "FullName": "Mr. Clementine Lang MD",
      "DirectPhone": "1-237-543-9466",
      "FormalName": "Will LLC",
      "CountryId": 998,
      "ContactId": 109,
      "ContactName": "Robel, Wolff and Wiegand",
      "Retired": 676,
      "Rank": 969,
      "ActiveInterests": 723,
      "ContactDepartment": "",
      "ContactCountryId": 77,
      "ContactOrgNr": "1317831",
      "FaxPhone": "127-048-8834 x53313",
      "MobilePhone": "1-936-007-2111",
      "ContactPhone": "1-900-387-5978",
      "AssociateName": "Turcotte Group",
      "AssociateId": 977,
      "UsePersonAddress": false,
      "ContactFax": "possimus",
      "Kanafname": "accusamus",
      "Kanalname": "aspernatur",
      "Post1": "similique",
      "Post2": "impedit",
      "Post3": "tempore",
      "EmailName": "nelson_lubowitz@bosco.co.uk",
      "ContactFullName": "Kayley Clara Jones IV",
      "ActiveErpLinks": 31,
      "TicketPriorityId": 942,
      "SupportLanguageId": 289,
      "SupportAssociateId": 280,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 497,
  "ConnectId": 333,
  "ReadStatus": "Green",
  "TimeToReply": 135,
  "RealTimeToReply": 75,
  "TimeToClose": 139,
  "RealTimeToClose": 281,
  "TimeSpentInternally": 474,
  "TimeSpentExternally": 238,
  "TimeSpentQueue": 894,
  "RealTimeSpentInternally": 57,
  "RealTimeSpentExternally": 535,
  "RealTimeSpentQueue": 716,
  "HasAttachment": false,
  "NumReplies": 758,
  "NumMessages": 109,
  "FromAddress": "rerum",
  "Messages": [
    {
      "TicketMessageId": 208,
      "CreatedAt": "2003-06-13T14:19:04.3765753+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "suscipit",
      "PersonId": 823,
      "PersonFullName": "Dr. Albin Lizeth Hauck Sr.",
      "ContactId": 569,
      "ContactName": "Hagenes, Auer and Boehm",
      "ContactDepartment": "",
      "NumAttachments": 999,
      "EmailHeader": "cathryn@sipes.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quia",
      "Sentiment": 425,
      "SentimentConfidence": 859,
      "CreatedBy": 433,
      "ChangedAt": "2004-05-17T14:19:04.3765753+02:00"
    }
  ],
  "Tags": [
    {
      "Id": 445,
      "Name": "Green, Langosh and Bins",
      "ToolTip": "Officiis quas vero delectus."
    },
    {
      "Id": 445,
      "Name": "Green, Langosh and Bins",
      "ToolTip": "Officiis quas vero delectus."
    }
  ],
  "Language": "voluptatem",
  "Sentiment": 295,
  "SentimentConfidence": 896,
  "SuggestedCategoryId": 995,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 30,
  "IconHint": "odio",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "cumque",
    "ExtraFields2": "deserunt"
  },
  "CustomFields": {
    "CustomFields1": "velit",
    "CustomFields2": "mollitia"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 584,
  "Title": "sunt",
  "CreatedAt": "2015-04-09T14:19:04.3765753+02:00",
  "LastChanged": "2019-12-10T14:19:04.3765753+01:00",
  "ReadByOwner": "2005-08-30T14:19:04.3765753+02:00",
  "ReadByCustomer": "1998-06-09T14:19:04.3765753+02:00",
  "FirstReadByOwner": "2007-05-25T14:19:04.3765753+02:00",
  "FirstReadByUser": "2011-09-08T14:19:04.3765753+02:00",
  "Activate": "2014-12-07T14:19:04.3765753+01:00",
  "ClosedAt": "2000-02-12T14:19:04.3765753+01:00",
  "RepliedAt": "2020-03-09T14:19:04.3765753+01:00",
  "AlertTimeout": "2021-01-17T14:19:04.3765753+01:00",
  "Deadline": "2010-04-22T14:19:04.3765753+02:00",
  "CreatedBy": null,
  "Author": "dignissimos",
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
      "PersonId": 732,
      "Mrmrs": "soluta",
      "Firstname": "Gussie",
      "Lastname": "Klocko",
      "MiddleName": "Barton Inc and Sons",
      "Title": "ab",
      "Description": "Front-line hybrid encoding",
      "Email": "marielle@bailey.biz",
      "FullName": "Lewis Leuschke",
      "DirectPhone": "662-340-8216",
      "FormalName": "Bergstrom, Romaguera and Hettinger",
      "CountryId": 575,
      "ContactId": 339,
      "ContactName": "Hartmann-Hane",
      "Retired": 204,
      "Rank": 597,
      "ActiveInterests": 366,
      "ContactDepartment": "",
      "ContactCountryId": 487,
      "ContactOrgNr": "808410",
      "FaxPhone": "037.166.1002",
      "MobilePhone": "379.167.5566 x88048",
      "ContactPhone": "435-353-5420 x18571",
      "AssociateName": "Harber, Gleichner and Connelly",
      "AssociateId": 921,
      "UsePersonAddress": true,
      "ContactFax": "consequatur",
      "Kanafname": "reprehenderit",
      "Kanalname": "ut",
      "Post1": "iusto",
      "Post2": "sint",
      "Post3": "id",
      "EmailName": "rudolph@prohaskasanford.uk",
      "ContactFullName": "Prof. Halle Ethyl Okuneva",
      "ActiveErpLinks": 346,
      "TicketPriorityId": 628,
      "SupportLanguageId": 252,
      "SupportAssociateId": 522,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 708
        }
      }
    }
  ],
  "AlertLevel": 319,
  "ConnectId": 915,
  "ReadStatus": "Green",
  "TimeToReply": 455,
  "RealTimeToReply": 736,
  "TimeToClose": 468,
  "RealTimeToClose": 325,
  "TimeSpentInternally": 2,
  "TimeSpentExternally": 24,
  "TimeSpentQueue": 470,
  "RealTimeSpentInternally": 881,
  "RealTimeSpentExternally": 674,
  "RealTimeSpentQueue": 869,
  "HasAttachment": true,
  "NumReplies": 912,
  "NumMessages": 923,
  "FromAddress": "dolores",
  "Messages": [
    {
      "TicketMessageId": 803,
      "CreatedAt": "2000-10-21T14:19:04.3922008+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "consequuntur",
      "PersonId": 715,
      "PersonFullName": "Regan Runte",
      "ContactId": 667,
      "ContactName": "Graham-Funk",
      "ContactDepartment": "",
      "NumAttachments": 932,
      "EmailHeader": "edmund.bechtelar@hilll.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "maxime",
      "Sentiment": 715,
      "SentimentConfidence": 915,
      "CreatedBy": 463,
      "ChangedAt": "2016-01-26T14:19:04.3922008+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 803
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 503,
      "Name": "Adams, Powlowski and Spencer",
      "ToolTip": "Odit voluptatem placeat.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 81
        }
      }
    },
    {
      "Id": 503,
      "Name": "Adams, Powlowski and Spencer",
      "ToolTip": "Odit voluptatem placeat.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 81
        }
      }
    }
  ],
  "Language": "hic",
  "Sentiment": 850,
  "SentimentConfidence": 323,
  "SuggestedCategoryId": 788,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 536,
  "IconHint": "dicta",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "nemo",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "unde"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 1001
    }
  }
}
```