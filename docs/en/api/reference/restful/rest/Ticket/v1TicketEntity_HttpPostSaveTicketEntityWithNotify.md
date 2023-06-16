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
POST /api/v1/Ticket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 632,
  "Title": "consequuntur",
  "CreatedAt": "1998-11-11T16:00:48.492772+01:00",
  "LastChanged": "2015-04-17T16:00:48.492772+02:00",
  "ReadByOwner": "2011-04-07T16:00:48.492772+02:00",
  "ReadByCustomer": "2014-01-21T16:00:48.492772+01:00",
  "FirstReadByOwner": "2020-09-08T16:00:48.492772+02:00",
  "FirstReadByUser": "1999-10-16T16:00:48.492772+02:00",
  "Activate": "2022-09-04T16:00:48.492772+02:00",
  "ClosedAt": "2013-11-18T16:00:48.492772+01:00",
  "RepliedAt": "2019-12-19T16:00:48.492772+01:00",
  "AlertTimeout": "2010-08-23T16:00:48.492772+02:00",
  "Deadline": "2001-10-06T16:00:48.492772+02:00",
  "CreatedBy": null,
  "Author": "expedita",
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
      "Position": "facilis",
      "PersonId": 46,
      "Mrmrs": "officia",
      "Firstname": "Vickie",
      "Lastname": "Keeling",
      "MiddleName": "Marks LLC",
      "Title": "sequi",
      "Description": "Front-line scalable project",
      "Email": "abby_haag@schamberger.info",
      "FullName": "Olaf Tremayne Ratke V",
      "DirectPhone": "239.605.5849 x22413",
      "FormalName": "Oberbrunner-Harvey",
      "CountryId": 160,
      "ContactId": 287,
      "ContactName": "Carroll-Johnston",
      "Retired": 960,
      "Rank": 780,
      "ActiveInterests": 319,
      "ContactDepartment": "",
      "ContactCountryId": 141,
      "ContactOrgNr": "891760",
      "FaxPhone": "(941)104-3333",
      "MobilePhone": "1-298-025-3149 x944",
      "ContactPhone": "(184)065-9724",
      "AssociateName": "Farrell, Stanton and Bruen",
      "AssociateId": 173,
      "UsePersonAddress": false,
      "ContactFax": "omnis",
      "Kanafname": "cum",
      "Kanalname": "voluptas",
      "Post1": "voluptatem",
      "Post2": "occaecati",
      "Post3": "blanditiis",
      "EmailName": "davion_botsford@swaniawski.uk",
      "ContactFullName": "Kiara Schuppe",
      "ActiveErpLinks": 719,
      "TicketPriorityId": 1001,
      "SupportLanguageId": 666,
      "SupportAssociateId": 440,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 155,
  "ConnectId": 442,
  "ReadStatus": "Green",
  "TimeToReply": 459,
  "RealTimeToReply": 965,
  "TimeToClose": 208,
  "RealTimeToClose": 607,
  "TimeSpentInternally": 426,
  "TimeSpentExternally": 734,
  "TimeSpentQueue": 34,
  "RealTimeSpentInternally": 792,
  "RealTimeSpentExternally": 677,
  "RealTimeSpentQueue": 830,
  "HasAttachment": false,
  "NumReplies": 302,
  "NumMessages": 424,
  "FromAddress": "nemo",
  "Messages": [
    {
      "TicketMessageId": 171,
      "CreatedAt": "2015-12-13T16:00:48.492772+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "beatae",
      "PersonId": 570,
      "PersonFullName": "Edmund Will",
      "ContactId": 990,
      "ContactName": "Simonis, Daugherty and Watsica",
      "ContactDepartment": "",
      "NumAttachments": 99,
      "EmailHeader": "brandt@nikolaus.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "tenetur",
      "Sentiment": 81,
      "SentimentConfidence": 322,
      "CreatedBy": 783,
      "ChangedAt": "2019-03-21T16:00:48.492772+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 588,
      "Name": "Heidenreich, Langosh and Leffler",
      "ToolTip": "Officia dignissimos voluptate."
    },
    {
      "Id": 588,
      "Name": "Heidenreich, Langosh and Leffler",
      "ToolTip": "Officia dignissimos voluptate."
    }
  ],
  "Language": "voluptatem",
  "Sentiment": 217,
  "SentimentConfidence": 590,
  "SuggestedCategoryId": 668,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 801,
  "IconHint": "enim",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "porro",
    "ExtraFields2": "dolorem"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "neque"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 88,
  "Title": "voluptatem",
  "CreatedAt": "2014-05-16T16:00:48.492772+02:00",
  "LastChanged": "1999-10-21T16:00:48.492772+02:00",
  "ReadByOwner": "2012-03-04T16:00:48.492772+01:00",
  "ReadByCustomer": "2013-12-31T16:00:48.492772+01:00",
  "FirstReadByOwner": "2018-06-15T16:00:48.492772+02:00",
  "FirstReadByUser": "2020-06-05T16:00:48.492772+02:00",
  "Activate": "2010-05-28T16:00:48.492772+02:00",
  "ClosedAt": "2014-06-14T16:00:48.492772+02:00",
  "RepliedAt": "2014-07-22T16:00:48.492772+02:00",
  "AlertTimeout": "1999-10-13T16:00:48.492772+02:00",
  "Deadline": "2003-08-27T16:00:48.492772+02:00",
  "CreatedBy": null,
  "Author": "dolorem",
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
      "Position": "odit",
      "PersonId": 719,
      "Mrmrs": "ipsam",
      "Firstname": "Carmine",
      "Lastname": "Hammes",
      "MiddleName": "Parker Inc and Sons",
      "Title": "vitae",
      "Description": "Ameliorated uniform access",
      "Email": "raquel_borer@kreiger.ca",
      "FullName": "Dr. Dusty Gorczany DVM",
      "DirectPhone": "539-859-8989 x21949",
      "FormalName": "Botsford Group",
      "CountryId": 637,
      "ContactId": 262,
      "ContactName": "Rolfson-Kessler",
      "Retired": 138,
      "Rank": 824,
      "ActiveInterests": 469,
      "ContactDepartment": "",
      "ContactCountryId": 286,
      "ContactOrgNr": "1224083",
      "FaxPhone": "011-846-6699 x7578",
      "MobilePhone": "1-441-717-0901",
      "ContactPhone": "197.666.2000",
      "AssociateName": "Ziemann, Gislason and VonRueden",
      "AssociateId": 283,
      "UsePersonAddress": false,
      "ContactFax": "voluptatibus",
      "Kanafname": "est",
      "Kanalname": "delectus",
      "Post1": "dolor",
      "Post2": "accusantium",
      "Post3": "quia",
      "EmailName": "winfield@leffler.uk",
      "ContactFullName": "Lempi Trantow",
      "ActiveErpLinks": 950,
      "TicketPriorityId": 91,
      "SupportLanguageId": 327,
      "SupportAssociateId": 152,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 196
        }
      }
    }
  ],
  "AlertLevel": 653,
  "ConnectId": 53,
  "ReadStatus": "Green",
  "TimeToReply": 929,
  "RealTimeToReply": 161,
  "TimeToClose": 680,
  "RealTimeToClose": 447,
  "TimeSpentInternally": 868,
  "TimeSpentExternally": 111,
  "TimeSpentQueue": 289,
  "RealTimeSpentInternally": 241,
  "RealTimeSpentExternally": 589,
  "RealTimeSpentQueue": 346,
  "HasAttachment": false,
  "NumReplies": 945,
  "NumMessages": 244,
  "FromAddress": "qui",
  "Messages": [
    {
      "TicketMessageId": 380,
      "CreatedAt": "2014-10-24T16:00:48.5083897+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "modi",
      "PersonId": 986,
      "PersonFullName": "Eleazar Rodriguez",
      "ContactId": 280,
      "ContactName": "Ratke-Hintz",
      "ContactDepartment": "",
      "NumAttachments": 807,
      "EmailHeader": "delphine.weissnat@lakin.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "sit",
      "Sentiment": 435,
      "SentimentConfidence": 303,
      "CreatedBy": 950,
      "ChangedAt": "2020-04-07T16:00:48.5083897+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 272
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 275,
      "Name": "Cummerata, Green and Schuppe",
      "ToolTip": "Eum magnam vero.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 527
        }
      }
    },
    {
      "Id": 275,
      "Name": "Cummerata, Green and Schuppe",
      "ToolTip": "Eum magnam vero.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 527
        }
      }
    }
  ],
  "Language": "aut",
  "Sentiment": 267,
  "SentimentConfidence": 838,
  "SuggestedCategoryId": 713,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 136,
  "IconHint": "recusandae",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "autem",
    "ExtraFields2": "neque"
  },
  "CustomFields": {
    "CustomFields1": "molestias",
    "CustomFields2": "praesentium"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 534
    }
  }
}
```