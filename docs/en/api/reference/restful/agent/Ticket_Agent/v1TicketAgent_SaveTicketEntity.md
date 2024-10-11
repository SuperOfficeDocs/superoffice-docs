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
  "TicketId": 543,
  "Title": "molestiae",
  "CreatedAt": "2023-05-19T03:44:53.2310227+02:00",
  "LastChanged": "2002-09-20T03:44:53.2310227+02:00",
  "ReadByOwner": "2022-07-25T03:44:53.2310227+02:00",
  "ReadByCustomer": "2001-09-17T03:44:53.2310227+02:00",
  "FirstReadByOwner": "2015-08-30T03:44:53.2310227+02:00",
  "FirstReadByUser": "1998-12-04T03:44:53.2310227+01:00",
  "Activate": "2022-03-16T03:44:53.2310227+01:00",
  "ClosedAt": "1997-09-13T03:44:53.2310227+02:00",
  "RepliedAt": "2020-11-08T03:44:53.2310227+01:00",
  "AlertTimeout": "2012-01-06T03:44:53.2310227+01:00",
  "Deadline": "2022-05-05T03:44:53.2310227+02:00",
  "CreatedBy": null,
  "Author": "pariatur",
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
      "Position": "quod",
      "PersonId": 550,
      "Mrmrs": "perspiciatis",
      "Firstname": "Isom",
      "Lastname": "Grimes",
      "MiddleName": "Ward Inc and Sons",
      "Title": "ab",
      "Description": "Down-sized web-enabled collaboration",
      "Email": "marlin.bahringer@corwin.info",
      "FullName": "Abner Nitzsche",
      "DirectPhone": "066.516.4853",
      "FormalName": "Schuster Group",
      "CountryId": 87,
      "ContactId": 260,
      "ContactName": "Romaguera, Waelchi and Goldner",
      "Retired": 646,
      "Rank": 346,
      "ActiveInterests": 424,
      "ContactDepartment": "",
      "ContactCountryId": 463,
      "ContactOrgNr": "1172734",
      "FaxPhone": "278-193-1480",
      "MobilePhone": "762-991-0243",
      "ContactPhone": "838-320-0518 x5390",
      "AssociateName": "Rutherford, Corkery and Gaylord",
      "AssociateId": 74,
      "UsePersonAddress": false,
      "ContactFax": "repudiandae",
      "Kanafname": "delectus",
      "Kanalname": "quibusdam",
      "Post1": "voluptatem",
      "Post2": "fugiat",
      "Post3": "iste",
      "EmailName": "carley@schillersteuber.uk",
      "ContactFullName": "Bella Pagac PhD",
      "ActiveErpLinks": 987,
      "TicketPriorityId": 690,
      "SupportLanguageId": 315,
      "SupportAssociateId": 196,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 107,
  "ConnectId": 923,
  "ReadStatus": "Green",
  "TimeToReply": 61,
  "RealTimeToReply": 424,
  "TimeToClose": 663,
  "RealTimeToClose": 859,
  "TimeSpentInternally": 756,
  "TimeSpentExternally": 650,
  "TimeSpentQueue": 354,
  "RealTimeSpentInternally": 158,
  "RealTimeSpentExternally": 281,
  "RealTimeSpentQueue": 95,
  "TimeSpent": 633,
  "HasAttachment": false,
  "NumReplies": 863,
  "NumMessages": 995,
  "FromAddress": "amet",
  "Messages": [
    {
      "TicketMessageId": 279,
      "CreatedAt": "2013-06-14T03:44:53.2466467+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "rem",
      "PersonId": 341,
      "PersonFullName": "Cheyanne Bashirian",
      "ContactId": 24,
      "ContactName": "Daugherty, Monahan and Farrell",
      "ContactDepartment": "",
      "NumAttachments": 856,
      "EmailHeader": "carlo.hodkiewicz@armstrong.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quis",
      "Sentiment": 884,
      "SentimentConfidence": 126,
      "CreatedBy": 798,
      "ChangedAt": "2018-02-21T03:44:53.2466467+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 895,
      "Name": "Boyer-Hoeger",
      "ToolTip": "Illum omnis dolor doloremque."
    },
    {
      "Id": 895,
      "Name": "Boyer-Hoeger",
      "ToolTip": "Illum omnis dolor doloremque."
    }
  ],
  "Language": "quo",
  "Sentiment": 455,
  "SentimentConfidence": 436,
  "SuggestedCategoryId": 322,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 661,
  "IconHint": "eius",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 824,
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "mollitia"
  },
  "CustomFields": {
    "CustomFields1": "itaque",
    "CustomFields2": "iusto"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 88,
  "Title": "aut",
  "CreatedAt": "2002-11-11T03:44:53.2466467+01:00",
  "LastChanged": "2005-06-24T03:44:53.2466467+02:00",
  "ReadByOwner": "2013-12-02T03:44:53.2466467+01:00",
  "ReadByCustomer": "2015-03-29T03:44:53.2466467+02:00",
  "FirstReadByOwner": "2013-11-21T03:44:53.2466467+01:00",
  "FirstReadByUser": "1998-02-21T03:44:53.2466467+01:00",
  "Activate": "2021-06-02T03:44:53.2466467+02:00",
  "ClosedAt": "2004-09-05T03:44:53.2466467+02:00",
  "RepliedAt": "2023-02-22T03:44:53.2466467+01:00",
  "AlertTimeout": "2010-06-15T03:44:53.2466467+02:00",
  "Deadline": "2010-08-06T03:44:53.2466467+02:00",
  "CreatedBy": null,
  "Author": "aut",
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
      "PersonId": 127,
      "Mrmrs": "ducimus",
      "Firstname": "Anderson",
      "Lastname": "Mitchell",
      "MiddleName": "Lebsack-Abbott",
      "Title": "quos",
      "Description": "Progressive radical software",
      "Email": "amanda.mccullough@vandervort.info",
      "FullName": "Natalia Zemlak",
      "DirectPhone": "513.099.6716 x7411",
      "FormalName": "Braun-Hyatt",
      "CountryId": 839,
      "ContactId": 222,
      "ContactName": "Powlowski, Braun and Gottlieb",
      "Retired": 311,
      "Rank": 180,
      "ActiveInterests": 832,
      "ContactDepartment": "",
      "ContactCountryId": 757,
      "ContactOrgNr": "128166",
      "FaxPhone": "(779)187-4158 x757",
      "MobilePhone": "424.269.1289 x131",
      "ContactPhone": "103.430.8646 x1220",
      "AssociateName": "Reichel, McClure and Brown",
      "AssociateId": 981,
      "UsePersonAddress": true,
      "ContactFax": "deleniti",
      "Kanafname": "illum",
      "Kanalname": "sint",
      "Post1": "similique",
      "Post2": "ut",
      "Post3": "excepturi",
      "EmailName": "oleta_gutkowski@schroederankunding.ca",
      "ContactFullName": "Dr. Alvis Marisol Ullrich",
      "ActiveErpLinks": 179,
      "TicketPriorityId": 301,
      "SupportLanguageId": 190,
      "SupportAssociateId": 39,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 877
        }
      }
    }
  ],
  "AlertLevel": 373,
  "ConnectId": 378,
  "ReadStatus": "Green",
  "TimeToReply": 159,
  "RealTimeToReply": 918,
  "TimeToClose": 328,
  "RealTimeToClose": 734,
  "TimeSpentInternally": 198,
  "TimeSpentExternally": 29,
  "TimeSpentQueue": 291,
  "RealTimeSpentInternally": 418,
  "RealTimeSpentExternally": 457,
  "RealTimeSpentQueue": 208,
  "TimeSpent": 279,
  "HasAttachment": true,
  "NumReplies": 461,
  "NumMessages": 861,
  "FromAddress": "dicta",
  "Messages": [
    {
      "TicketMessageId": 355,
      "CreatedAt": "1999-05-02T03:44:53.2466467+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "quam",
      "PersonId": 839,
      "PersonFullName": "Amanda Raphaelle Beier PhD",
      "ContactId": 593,
      "ContactName": "Bashirian Group",
      "ContactDepartment": "",
      "NumAttachments": 828,
      "EmailHeader": "else_terry@kutchtowne.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "sed",
      "Sentiment": 285,
      "SentimentConfidence": 413,
      "CreatedBy": 423,
      "ChangedAt": "2007-12-17T03:44:53.2466467+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 203
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 37,
      "Name": "Buckridge, Blick and Ledner",
      "ToolTip": "Voluptates iure.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 96
        }
      }
    },
    {
      "Id": 37,
      "Name": "Buckridge, Blick and Ledner",
      "ToolTip": "Voluptates iure.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 96
        }
      }
    }
  ],
  "Language": "eos",
  "Sentiment": 223,
  "SentimentConfidence": 969,
  "SuggestedCategoryId": 761,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 733,
  "IconHint": "fugiat",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 865,
  "ExtraFields": {
    "ExtraFields1": "iste",
    "ExtraFields2": "quae"
  },
  "CustomFields": {
    "CustomFields1": "quod",
    "CustomFields2": "ab"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 931
    }
  }
}
```