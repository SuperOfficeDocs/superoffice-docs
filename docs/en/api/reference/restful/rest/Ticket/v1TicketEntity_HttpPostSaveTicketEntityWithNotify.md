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
POST /api/v1/Ticket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 263,
  "Title": "enim",
  "CreatedAt": "2021-04-09T03:45:28.670306+02:00",
  "LastChanged": "2004-03-29T03:45:28.670306+02:00",
  "ReadByOwner": "2013-01-24T03:45:28.670306+01:00",
  "ReadByCustomer": "1998-12-11T03:45:28.670306+01:00",
  "FirstReadByOwner": "2010-06-02T03:45:28.670306+02:00",
  "FirstReadByUser": "2015-07-29T03:45:28.670306+02:00",
  "Activate": "2014-06-20T03:45:28.670306+02:00",
  "ClosedAt": "2019-02-03T03:45:28.670306+01:00",
  "RepliedAt": "1999-03-01T03:45:28.670306+01:00",
  "AlertTimeout": "2018-04-26T03:45:28.670306+02:00",
  "Deadline": "2023-03-14T03:45:28.670306+01:00",
  "CreatedBy": null,
  "Author": "error",
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
      "Position": "sint",
      "PersonId": 434,
      "Mrmrs": "id",
      "Firstname": "Aletha",
      "Lastname": "Rowe",
      "MiddleName": "Satterfield LLC",
      "Title": "sint",
      "Description": "Multi-lateral 3rd generation open system",
      "Email": "jillian_waters@purdypadberg.uk",
      "FullName": "Celestine Willms",
      "DirectPhone": "054.126.7530 x803",
      "FormalName": "Fisher-Volkman",
      "CountryId": 256,
      "ContactId": 434,
      "ContactName": "Botsford-Kutch",
      "Retired": 919,
      "Rank": 225,
      "ActiveInterests": 232,
      "ContactDepartment": "",
      "ContactCountryId": 462,
      "ContactOrgNr": "972722",
      "FaxPhone": "282.843.4731 x148",
      "MobilePhone": "(296)770-0246 x4967",
      "ContactPhone": "958-664-5745 x008",
      "AssociateName": "Mante, McLaughlin and Rutherford",
      "AssociateId": 429,
      "UsePersonAddress": false,
      "ContactFax": "officiis",
      "Kanafname": "est",
      "Kanalname": "nemo",
      "Post1": "et",
      "Post2": "eius",
      "Post3": "vero",
      "EmailName": "carmelo_conroy@boyer.us",
      "ContactFullName": "Al Renner",
      "ActiveErpLinks": 820,
      "TicketPriorityId": 805,
      "SupportLanguageId": 703,
      "SupportAssociateId": 893,
      "CategoryName": "VIP Customer",
      "PersonNumber": "652224"
    }
  ],
  "AlertLevel": 79,
  "ConnectId": 279,
  "ReadStatus": "Green",
  "TimeToReply": 594,
  "RealTimeToReply": 922,
  "TimeToClose": 673,
  "RealTimeToClose": 867,
  "TimeSpentInternally": 343,
  "TimeSpentExternally": 479,
  "TimeSpentQueue": 701,
  "RealTimeSpentInternally": 602,
  "RealTimeSpentExternally": 378,
  "RealTimeSpentQueue": 903,
  "TimeSpent": 284,
  "HasAttachment": false,
  "NumReplies": 233,
  "NumMessages": 618,
  "FromAddress": "at",
  "Messages": [
    {
      "TicketMessageId": 347,
      "CreatedAt": "2000-07-10T03:45:28.670306+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "nesciunt",
      "PersonId": 508,
      "PersonFullName": "Ms. Gonzalo Gerhold",
      "ContactId": 859,
      "ContactName": "Lueilwitz-Ebert",
      "ContactDepartment": "",
      "NumAttachments": 293,
      "EmailHeader": "henry_parisian@green.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "commodi",
      "Sentiment": 927,
      "SentimentConfidence": 466,
      "CreatedBy": 722,
      "ChangedAt": "2023-09-05T03:45:28.670306+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 660,
      "Name": "Pouros-Brown",
      "ToolTip": "Explicabo praesentium non voluptas qui id."
    },
    {
      "Id": 660,
      "Name": "Pouros-Brown",
      "ToolTip": "Explicabo praesentium non voluptas qui id."
    }
  ],
  "Language": "molestias",
  "Sentiment": 690,
  "SentimentConfidence": 88,
  "SuggestedCategoryId": 917,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 592,
  "IconHint": "aut",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 455,
  "ExtraFields": {
    "ExtraFields1": "tempora",
    "ExtraFields2": "ipsa"
  },
  "CustomFields": {
    "CustomFields1": "eum",
    "CustomFields2": "voluptas"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 352,
  "Title": "suscipit",
  "CreatedAt": "1999-06-08T03:45:28.670306+02:00",
  "LastChanged": "2014-01-01T03:45:28.670306+01:00",
  "ReadByOwner": "2002-03-03T03:45:28.670306+01:00",
  "ReadByCustomer": "2017-11-12T03:45:28.670306+01:00",
  "FirstReadByOwner": "1999-04-02T03:45:28.670306+02:00",
  "FirstReadByUser": "2021-09-29T03:45:28.670306+02:00",
  "Activate": "2013-03-25T03:45:28.670306+01:00",
  "ClosedAt": "1998-12-02T03:45:28.670306+01:00",
  "RepliedAt": "2003-02-05T03:45:28.670306+01:00",
  "AlertTimeout": "2003-11-13T03:45:28.670306+01:00",
  "Deadline": "2021-04-03T03:45:28.670306+02:00",
  "CreatedBy": null,
  "Author": "voluptatem",
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
      "Position": "voluptas",
      "PersonId": 542,
      "Mrmrs": "voluptatem",
      "Firstname": "Larue",
      "Lastname": "Kilback",
      "MiddleName": "Harvey LLC",
      "Title": "ut",
      "Description": "Assimilated uniform model",
      "Email": "lue@dooleyschamberger.co.uk",
      "FullName": "Willard Gaylord",
      "DirectPhone": "(812)083-3585 x94383",
      "FormalName": "Larkin-Bogan",
      "CountryId": 165,
      "ContactId": 194,
      "ContactName": "Koss Inc and Sons",
      "Retired": 718,
      "Rank": 305,
      "ActiveInterests": 12,
      "ContactDepartment": "",
      "ContactCountryId": 741,
      "ContactOrgNr": "1455329",
      "FaxPhone": "(795)538-6744 x268",
      "MobilePhone": "315-115-2206",
      "ContactPhone": "776-782-8110 x904",
      "AssociateName": "Kertzmann, Gleichner and Runte",
      "AssociateId": 64,
      "UsePersonAddress": true,
      "ContactFax": "assumenda",
      "Kanafname": "accusamus",
      "Kanalname": "rerum",
      "Post1": "non",
      "Post2": "doloribus",
      "Post3": "qui",
      "EmailName": "roger@johnstonstroman.co.uk",
      "ContactFullName": "Edwardo Hammes",
      "ActiveErpLinks": 745,
      "TicketPriorityId": 806,
      "SupportLanguageId": 991,
      "SupportAssociateId": 633,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1138472",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 570
        }
      }
    }
  ],
  "AlertLevel": 475,
  "ConnectId": 298,
  "ReadStatus": "Green",
  "TimeToReply": 690,
  "RealTimeToReply": 678,
  "TimeToClose": 770,
  "RealTimeToClose": 979,
  "TimeSpentInternally": 691,
  "TimeSpentExternally": 359,
  "TimeSpentQueue": 605,
  "RealTimeSpentInternally": 208,
  "RealTimeSpentExternally": 847,
  "RealTimeSpentQueue": 287,
  "TimeSpent": 379,
  "HasAttachment": true,
  "NumReplies": 515,
  "NumMessages": 202,
  "FromAddress": "dolor",
  "Messages": [
    {
      "TicketMessageId": 129,
      "CreatedAt": "2015-07-19T03:45:28.670306+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "delectus",
      "PersonId": 788,
      "PersonFullName": "Alex Carter",
      "ContactId": 373,
      "ContactName": "Glover, Hackett and Farrell",
      "ContactDepartment": "",
      "NumAttachments": 129,
      "EmailHeader": "seth@langworth.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "vero",
      "Sentiment": 908,
      "SentimentConfidence": 597,
      "CreatedBy": 722,
      "ChangedAt": "2010-01-21T03:45:28.670306+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 677
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 470,
      "Name": "Ritchie-Langosh",
      "ToolTip": "Qui et nemo architecto.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 219
        }
      }
    },
    {
      "Id": 470,
      "Name": "Ritchie-Langosh",
      "ToolTip": "Qui et nemo architecto.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 219
        }
      }
    }
  ],
  "Language": "vitae",
  "Sentiment": 127,
  "SentimentConfidence": 708,
  "SuggestedCategoryId": 188,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 230,
  "IconHint": "totam",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 481,
  "ExtraFields": {
    "ExtraFields1": "consectetur",
    "ExtraFields2": "id"
  },
  "CustomFields": {
    "CustomFields1": "culpa",
    "CustomFields2": "libero"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 568
    }
  }
}
```