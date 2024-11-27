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
  "TicketId": 732,
  "Title": "voluptatem",
  "CreatedAt": "2001-11-03T14:45:06.4280519+01:00",
  "LastChanged": "2012-07-31T14:45:06.4280519+02:00",
  "ReadByOwner": "2013-02-23T14:45:06.4280519+01:00",
  "ReadByCustomer": "2022-04-05T14:45:06.4280519+02:00",
  "FirstReadByOwner": "2022-04-02T14:45:06.4280519+02:00",
  "FirstReadByUser": "2004-06-03T14:45:06.4280519+02:00",
  "Activate": "2001-08-30T14:45:06.4280519+02:00",
  "ClosedAt": "2001-11-03T14:45:06.4280519+01:00",
  "RepliedAt": "2001-03-24T14:45:06.4280519+01:00",
  "AlertTimeout": "2024-04-13T14:45:06.4280519+02:00",
  "Deadline": "2013-09-19T14:45:06.4280519+02:00",
  "CreatedBy": null,
  "Author": "ut",
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
      "PersonId": 858,
      "Mrmrs": "iure",
      "Firstname": "Birdie",
      "Lastname": "King",
      "MiddleName": "Schaefer, Cassin and Jenkins",
      "Title": "temporibus",
      "Description": "Networked 4th generation forecast",
      "Email": "trycia@willmsauer.biz",
      "FullName": "Delbert Cronin",
      "DirectPhone": "781-641-5999 x805",
      "FormalName": "Gleichner, Stehr and Yost",
      "CountryId": 806,
      "ContactId": 723,
      "ContactName": "McGlynn-Zieme",
      "Retired": 534,
      "Rank": 997,
      "ActiveInterests": 494,
      "ContactDepartment": "",
      "ContactCountryId": 261,
      "ContactOrgNr": "1170889",
      "FaxPhone": "567-511-8514 x33168",
      "MobilePhone": "651.172.1855",
      "ContactPhone": "479.292.8521 x47350",
      "AssociateName": "Stanton-Mante",
      "AssociateId": 521,
      "UsePersonAddress": true,
      "ContactFax": "corrupti",
      "Kanafname": "id",
      "Kanalname": "deserunt",
      "Post1": "qui",
      "Post2": "qui",
      "Post3": "nihil",
      "EmailName": "emiliano_jacobi@damore.info",
      "ContactFullName": "Dr. Dolly Margie Torp",
      "ActiveErpLinks": 631,
      "TicketPriorityId": 648,
      "SupportLanguageId": 417,
      "SupportAssociateId": 636,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 785,
  "ConnectId": 636,
  "ReadStatus": "Green",
  "TimeToReply": 608,
  "RealTimeToReply": 952,
  "TimeToClose": 530,
  "RealTimeToClose": 272,
  "TimeSpentInternally": 366,
  "TimeSpentExternally": 364,
  "TimeSpentQueue": 917,
  "RealTimeSpentInternally": 481,
  "RealTimeSpentExternally": 840,
  "RealTimeSpentQueue": 421,
  "TimeSpent": 814,
  "HasAttachment": true,
  "NumReplies": 875,
  "NumMessages": 431,
  "FromAddress": "officiis",
  "Messages": [
    {
      "TicketMessageId": 87,
      "CreatedAt": "1998-11-06T14:45:06.4436775+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "id",
      "PersonId": 18,
      "PersonFullName": "Raven Reyna Krajcik IV",
      "ContactId": 798,
      "ContactName": "Bayer Inc and Sons",
      "ContactDepartment": "extend innovative vortals",
      "NumAttachments": 691,
      "EmailHeader": "hazel.schoen@kozey.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ex",
      "Sentiment": 690,
      "SentimentConfidence": 212,
      "CreatedBy": 268,
      "ChangedAt": "2006-08-14T14:45:06.4436775+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 152,
      "Name": "Kovacek Group",
      "ToolTip": "Et nam labore."
    },
    {
      "Id": 152,
      "Name": "Kovacek Group",
      "ToolTip": "Et nam labore."
    }
  ],
  "Language": "debitis",
  "Sentiment": 339,
  "SentimentConfidence": 28,
  "SuggestedCategoryId": 688,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 87,
  "IconHint": "quia",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 498,
  "ExtraFields": {
    "ExtraFields1": "velit",
    "ExtraFields2": "doloremque"
  },
  "CustomFields": {
    "CustomFields1": "alias",
    "CustomFields2": "dolores"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 543,
  "Title": "aliquam",
  "CreatedAt": "2016-05-03T14:45:06.4436775+02:00",
  "LastChanged": "2006-11-06T14:45:06.4436775+01:00",
  "ReadByOwner": "2014-08-04T14:45:06.4436775+02:00",
  "ReadByCustomer": "2011-03-15T14:45:06.4436775+01:00",
  "FirstReadByOwner": "1999-11-23T14:45:06.4436775+01:00",
  "FirstReadByUser": "1999-04-12T14:45:06.4436775+02:00",
  "Activate": "2011-08-18T14:45:06.4436775+02:00",
  "ClosedAt": "2016-04-17T14:45:06.4436775+02:00",
  "RepliedAt": "2014-09-09T14:45:06.4436775+02:00",
  "AlertTimeout": "2021-11-02T14:45:06.4436775+01:00",
  "Deadline": "1998-04-05T14:45:06.4436775+02:00",
  "CreatedBy": null,
  "Author": "autem",
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
      "Position": "reiciendis",
      "PersonId": 86,
      "Mrmrs": "aut",
      "Firstname": "Walter",
      "Lastname": "Altenwerth",
      "MiddleName": "Mills Group",
      "Title": "optio",
      "Description": "Networked holistic info-mediaries",
      "Email": "amaya@osinski.ca",
      "FullName": "Grayson Jast",
      "DirectPhone": "987-875-5242",
      "FormalName": "Denesik LLC",
      "CountryId": 463,
      "ContactId": 768,
      "ContactName": "Bartoletti-D'Amore",
      "Retired": 685,
      "Rank": 173,
      "ActiveInterests": 466,
      "ContactDepartment": "",
      "ContactCountryId": 635,
      "ContactOrgNr": "1116228",
      "FaxPhone": "088.726.6760 x61380",
      "MobilePhone": "820.322.2364 x108",
      "ContactPhone": "720.991.2829",
      "AssociateName": "Parisian LLC",
      "AssociateId": 18,
      "UsePersonAddress": true,
      "ContactFax": "alias",
      "Kanafname": "dolores",
      "Kanalname": "autem",
      "Post1": "voluptate",
      "Post2": "consequatur",
      "Post3": "vitae",
      "EmailName": "yessenia@koss.co.uk",
      "ContactFullName": "Ms. Alice Breitenberg",
      "ActiveErpLinks": 706,
      "TicketPriorityId": 181,
      "SupportLanguageId": 584,
      "SupportAssociateId": 757,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 615
        }
      }
    }
  ],
  "AlertLevel": 751,
  "ConnectId": 998,
  "ReadStatus": "Green",
  "TimeToReply": 285,
  "RealTimeToReply": 37,
  "TimeToClose": 754,
  "RealTimeToClose": 981,
  "TimeSpentInternally": 769,
  "TimeSpentExternally": 847,
  "TimeSpentQueue": 186,
  "RealTimeSpentInternally": 648,
  "RealTimeSpentExternally": 818,
  "RealTimeSpentQueue": 298,
  "TimeSpent": 438,
  "HasAttachment": false,
  "NumReplies": 569,
  "NumMessages": 923,
  "FromAddress": "inventore",
  "Messages": [
    {
      "TicketMessageId": 66,
      "CreatedAt": "2021-08-26T14:45:06.4436775+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "sint",
      "PersonId": 739,
      "PersonFullName": "Gilda Pfeffer",
      "ContactId": 667,
      "ContactName": "VonRueden, Schuppe and Ryan",
      "ContactDepartment": "engage innovative applications",
      "NumAttachments": 98,
      "EmailHeader": "roosevelt@okeefe.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "eum",
      "Sentiment": 684,
      "SentimentConfidence": 289,
      "CreatedBy": 637,
      "ChangedAt": "1999-11-12T14:45:06.4436775+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 270,
      "Name": "Deckow Group",
      "ToolTip": "Voluptas id amet necessitatibus qui in officia.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 832
        }
      }
    },
    {
      "Id": 270,
      "Name": "Deckow Group",
      "ToolTip": "Voluptas id amet necessitatibus qui in officia.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 832
        }
      }
    }
  ],
  "Language": "nisi",
  "Sentiment": 697,
  "SentimentConfidence": 83,
  "SuggestedCategoryId": 962,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 454,
  "IconHint": "neque",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 130,
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "eveniet"
  },
  "CustomFields": {
    "CustomFields1": "deleniti",
    "CustomFields2": "excepturi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 790
    }
  }
}
```