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
  "TicketId": 126,
  "Title": "ea",
  "CreatedAt": "2017-06-29T03:45:24.0298098+02:00",
  "LastChanged": "2020-06-22T03:45:24.0298098+02:00",
  "ReadByOwner": "2014-12-30T03:45:24.0298098+01:00",
  "ReadByCustomer": "2019-12-21T03:45:24.0298098+01:00",
  "FirstReadByOwner": "2003-02-18T03:45:24.0298098+01:00",
  "FirstReadByUser": "2017-06-17T03:45:24.0298098+02:00",
  "Activate": "2015-08-21T03:45:24.0298098+02:00",
  "ClosedAt": "2015-11-09T03:45:24.0298098+01:00",
  "RepliedAt": "2006-11-11T03:45:24.0298098+01:00",
  "AlertTimeout": "2004-08-28T03:45:24.0298098+02:00",
  "Deadline": "1999-10-13T03:45:24.0298098+02:00",
  "CreatedBy": null,
  "Author": "officiis",
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
      "Position": "quis",
      "PersonId": 47,
      "Mrmrs": "ut",
      "Firstname": "Clair",
      "Lastname": "Smitham",
      "MiddleName": "Kris Group",
      "Title": "sunt",
      "Description": "De-engineered human-resource leverage",
      "Email": "anibal@schroeder.biz",
      "FullName": "Mr. Agnes Doyle I",
      "DirectPhone": "678.624.0027 x3312",
      "FormalName": "Strosin Inc and Sons",
      "CountryId": 129,
      "ContactId": 873,
      "ContactName": "Koepp, Gleichner and Powlowski",
      "Retired": 652,
      "Rank": 393,
      "ActiveInterests": 259,
      "ContactDepartment": "",
      "ContactCountryId": 62,
      "ContactOrgNr": "1519716",
      "FaxPhone": "720.394.6749 x64918",
      "MobilePhone": "709-523-3607",
      "ContactPhone": "1-323-083-4254 x302",
      "AssociateName": "Collier-Ratke",
      "AssociateId": 472,
      "UsePersonAddress": false,
      "ContactFax": "dignissimos",
      "Kanafname": "ut",
      "Kanalname": "quaerat",
      "Post1": "assumenda",
      "Post2": "odio",
      "Post3": "eveniet",
      "EmailName": "jany.carter@monahan.uk",
      "ContactFullName": "Mrs. Issac Langosh IV",
      "ActiveErpLinks": 472,
      "TicketPriorityId": 935,
      "SupportLanguageId": 977,
      "SupportAssociateId": 620,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1048974"
    }
  ],
  "AlertLevel": 40,
  "ConnectId": 840,
  "ReadStatus": "Green",
  "TimeToReply": 401,
  "RealTimeToReply": 317,
  "TimeToClose": 2,
  "RealTimeToClose": 2,
  "TimeSpentInternally": 355,
  "TimeSpentExternally": 708,
  "TimeSpentQueue": 663,
  "RealTimeSpentInternally": 716,
  "RealTimeSpentExternally": 732,
  "RealTimeSpentQueue": 153,
  "TimeSpent": 765,
  "HasAttachment": false,
  "NumReplies": 458,
  "NumMessages": 204,
  "FromAddress": "ut",
  "Messages": [
    {
      "TicketMessageId": 707,
      "CreatedAt": "2007-02-26T03:45:24.0298098+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "dolorem",
      "PersonId": 312,
      "PersonFullName": "Ms. Lonny Cale Schoen",
      "ContactId": 729,
      "ContactName": "Keebler-Russel",
      "ContactDepartment": "",
      "NumAttachments": 132,
      "EmailHeader": "kelley@dach.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "sint",
      "Sentiment": 81,
      "SentimentConfidence": 459,
      "CreatedBy": 592,
      "ChangedAt": "2009-04-07T03:45:24.0298098+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 829,
      "Name": "Herman LLC",
      "ToolTip": "Fugit ut."
    },
    {
      "Id": 829,
      "Name": "Herman LLC",
      "ToolTip": "Fugit ut."
    }
  ],
  "Language": "enim",
  "Sentiment": 428,
  "SentimentConfidence": 997,
  "SuggestedCategoryId": 724,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 250,
  "IconHint": "eos",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 587,
  "ExtraFields": {
    "ExtraFields1": "voluptates",
    "ExtraFields2": "sunt"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "quia"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 132,
  "Title": "incidunt",
  "CreatedAt": "2009-10-18T03:45:24.0298098+02:00",
  "LastChanged": "2003-06-18T03:45:24.0298098+02:00",
  "ReadByOwner": "2024-04-14T03:45:24.0298098+02:00",
  "ReadByCustomer": "2010-11-22T03:45:24.0298098+01:00",
  "FirstReadByOwner": "2005-09-06T03:45:24.0298098+02:00",
  "FirstReadByUser": "2003-10-12T03:45:24.0298098+02:00",
  "Activate": "2018-04-29T03:45:24.0298098+02:00",
  "ClosedAt": "2015-02-18T03:45:24.0298098+01:00",
  "RepliedAt": "2024-01-10T03:45:24.0298098+01:00",
  "AlertTimeout": "2013-12-07T03:45:24.0298098+01:00",
  "Deadline": "2021-04-26T03:45:24.0298098+02:00",
  "CreatedBy": null,
  "Author": "voluptas",
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
      "Position": "autem",
      "PersonId": 920,
      "Mrmrs": "est",
      "Firstname": "Khalid",
      "Lastname": "Swaniawski",
      "MiddleName": "Auer Group",
      "Title": "qui",
      "Description": "Re-contextualized holistic complexity",
      "Email": "victoria.bergstrom@dickigutkowski.uk",
      "FullName": "Layne Grady",
      "DirectPhone": "301-810-8469 x8384",
      "FormalName": "Dickinson-Kerluke",
      "CountryId": 745,
      "ContactId": 32,
      "ContactName": "Daniel, Kilback and Abshire",
      "Retired": 224,
      "Rank": 699,
      "ActiveInterests": 782,
      "ContactDepartment": "",
      "ContactCountryId": 988,
      "ContactOrgNr": "912319",
      "FaxPhone": "890.499.7724 x466",
      "MobilePhone": "844.023.1069 x3549",
      "ContactPhone": "(099)923-3043 x411",
      "AssociateName": "Herzog, Reilly and Rolfson",
      "AssociateId": 638,
      "UsePersonAddress": true,
      "ContactFax": "voluptas",
      "Kanafname": "id",
      "Kanalname": "animi",
      "Post1": "necessitatibus",
      "Post2": "in",
      "Post3": "error",
      "EmailName": "darian_fritsch@grimes.ca",
      "ContactFullName": "Coty Price",
      "ActiveErpLinks": 785,
      "TicketPriorityId": 207,
      "SupportLanguageId": 712,
      "SupportAssociateId": 7,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1064181",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 139
        }
      }
    }
  ],
  "AlertLevel": 440,
  "ConnectId": 637,
  "ReadStatus": "Green",
  "TimeToReply": 912,
  "RealTimeToReply": 146,
  "TimeToClose": 246,
  "RealTimeToClose": 906,
  "TimeSpentInternally": 693,
  "TimeSpentExternally": 769,
  "TimeSpentQueue": 923,
  "RealTimeSpentInternally": 726,
  "RealTimeSpentExternally": 718,
  "RealTimeSpentQueue": 489,
  "TimeSpent": 927,
  "HasAttachment": false,
  "NumReplies": 340,
  "NumMessages": 581,
  "FromAddress": "mollitia",
  "Messages": [
    {
      "TicketMessageId": 652,
      "CreatedAt": "1999-12-25T03:45:24.0298098+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "molestias",
      "PersonId": 168,
      "PersonFullName": "Rahsaan Nolan",
      "ContactId": 991,
      "ContactName": "Jenkins Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 188,
      "EmailHeader": "david@gleason.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "similique",
      "Sentiment": 858,
      "SentimentConfidence": 594,
      "CreatedBy": 768,
      "ChangedAt": "2005-09-03T03:45:24.0298098+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 166
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 486,
      "Name": "Wehner Inc and Sons",
      "ToolTip": "Architecto natus nulla distinctio quas tempore.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 132
        }
      }
    },
    {
      "Id": 486,
      "Name": "Wehner Inc and Sons",
      "ToolTip": "Architecto natus nulla distinctio quas tempore.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 132
        }
      }
    }
  ],
  "Language": "facere",
  "Sentiment": 894,
  "SentimentConfidence": 157,
  "SuggestedCategoryId": 991,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 757,
  "IconHint": "enim",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 871,
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "porro"
  },
  "CustomFields": {
    "CustomFields1": "occaecati",
    "CustomFields2": "quia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 836
    }
  }
}
```