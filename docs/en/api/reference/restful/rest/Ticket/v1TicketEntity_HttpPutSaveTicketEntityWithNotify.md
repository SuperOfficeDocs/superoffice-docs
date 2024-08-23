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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketId": 478,
  "Title": "veritatis",
  "CreatedAt": "2010-03-06T13:28:32.3198544+01:00",
  "LastChanged": "1999-04-27T13:28:32.3198544+02:00",
  "ReadByOwner": "2018-07-06T13:28:32.3198544+02:00",
  "ReadByCustomer": "2019-11-16T13:28:32.3198544+01:00",
  "FirstReadByOwner": "2007-05-14T13:28:32.3198544+02:00",
  "FirstReadByUser": "2024-07-20T13:28:32.3198544+02:00",
  "Activate": "2002-01-24T13:28:32.3198544+01:00",
  "ClosedAt": "2022-02-20T13:28:32.3198544+01:00",
  "RepliedAt": "2023-07-23T13:28:32.3198544+02:00",
  "AlertTimeout": "2020-06-23T13:28:32.3198544+02:00",
  "Deadline": "2009-04-01T13:28:32.3198544+02:00",
  "CreatedBy": null,
  "Author": "vel",
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
      "Position": "eum",
      "PersonId": 203,
      "Mrmrs": "et",
      "Firstname": "Johanna",
      "Lastname": "Robel",
      "MiddleName": "Volkman Inc and Sons",
      "Title": "ut",
      "Description": "Sharable fresh-thinking intranet",
      "Email": "tess_lakin@bartolettikshlerin.co.uk",
      "FullName": "Gregg Vinnie Stracke Jr.",
      "DirectPhone": "(150)573-8052 x5361",
      "FormalName": "Murray, Haag and Lebsack",
      "CountryId": 498,
      "ContactId": 636,
      "ContactName": "Heller, Shields and Kunze",
      "Retired": 777,
      "Rank": 728,
      "ActiveInterests": 479,
      "ContactDepartment": "",
      "ContactCountryId": 428,
      "ContactOrgNr": "463366",
      "FaxPhone": "1-444-203-6122 x95671",
      "MobilePhone": "(926)723-9354 x7912",
      "ContactPhone": "902-172-3175 x855",
      "AssociateName": "Nader-Tremblay",
      "AssociateId": 537,
      "UsePersonAddress": false,
      "ContactFax": "dicta",
      "Kanafname": "aut",
      "Kanalname": "corrupti",
      "Post1": "culpa",
      "Post2": "veniam",
      "Post3": "voluptatem",
      "EmailName": "sheila@vonruedenhilpert.us",
      "ContactFullName": "Gus Champlin",
      "ActiveErpLinks": 392,
      "TicketPriorityId": 303,
      "SupportLanguageId": 591,
      "SupportAssociateId": 523,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 317,
  "ConnectId": 50,
  "ReadStatus": "Green",
  "TimeToReply": 9,
  "RealTimeToReply": 946,
  "TimeToClose": 203,
  "RealTimeToClose": 54,
  "TimeSpentInternally": 257,
  "TimeSpentExternally": 25,
  "TimeSpentQueue": 855,
  "RealTimeSpentInternally": 465,
  "RealTimeSpentExternally": 633,
  "RealTimeSpentQueue": 922,
  "TimeSpent": 5,
  "HasAttachment": false,
  "NumReplies": 958,
  "NumMessages": 724,
  "FromAddress": "quia",
  "Messages": [
    {
      "TicketMessageId": 440,
      "CreatedAt": "2000-07-23T13:28:32.3198544+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "reprehenderit",
      "PersonId": 886,
      "PersonFullName": "Annamae Kunde",
      "ContactId": 815,
      "ContactName": "Bergnaum, Feil and Stanton",
      "ContactDepartment": "",
      "NumAttachments": 66,
      "EmailHeader": "ada.spinka@schultz.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "esse",
      "Sentiment": 362,
      "SentimentConfidence": 245,
      "CreatedBy": 430,
      "ChangedAt": "2002-03-21T13:28:32.3198544+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 211,
      "Name": "Larson, Runolfsdottir and Rippin",
      "ToolTip": "Quia aut."
    },
    {
      "Id": 211,
      "Name": "Larson, Runolfsdottir and Rippin",
      "ToolTip": "Quia aut."
    }
  ],
  "Language": "suscipit",
  "Sentiment": 533,
  "SentimentConfidence": 899,
  "SuggestedCategoryId": 808,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 940,
  "IconHint": "quam",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 620,
  "ExtraFields": {
    "ExtraFields1": "inventore",
    "ExtraFields2": "distinctio"
  },
  "CustomFields": {
    "CustomFields1": "eos",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 710,
  "Title": "est",
  "CreatedAt": "2023-06-08T13:28:32.3198544+02:00",
  "LastChanged": "2018-04-16T13:28:32.3198544+02:00",
  "ReadByOwner": "2001-12-05T13:28:32.3198544+01:00",
  "ReadByCustomer": "1999-09-23T13:28:32.3198544+02:00",
  "FirstReadByOwner": "1998-05-26T13:28:32.3198544+02:00",
  "FirstReadByUser": "2021-10-04T13:28:32.3198544+02:00",
  "Activate": "2011-12-02T13:28:32.3354749+01:00",
  "ClosedAt": "1998-09-07T13:28:32.3354749+02:00",
  "RepliedAt": "2023-04-24T13:28:32.3354749+02:00",
  "AlertTimeout": "2010-09-13T13:28:32.3354749+02:00",
  "Deadline": "2020-08-23T13:28:32.3354749+02:00",
  "CreatedBy": null,
  "Author": "sit",
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
      "Position": "laudantium",
      "PersonId": 114,
      "Mrmrs": "accusamus",
      "Firstname": "Emery",
      "Lastname": "Pagac",
      "MiddleName": "Goodwin, Will and Marquardt",
      "Title": "impedit",
      "Description": "Persistent systemic secured line",
      "Email": "lew@brakushuels.info",
      "FullName": "Alberta Hills",
      "DirectPhone": "090-462-5063 x686",
      "FormalName": "Koepp, Balistreri and Zulauf",
      "CountryId": 513,
      "ContactId": 756,
      "ContactName": "Pollich Group",
      "Retired": 887,
      "Rank": 504,
      "ActiveInterests": 346,
      "ContactDepartment": "",
      "ContactCountryId": 802,
      "ContactOrgNr": "1313229",
      "FaxPhone": "577-460-7899 x41338",
      "MobilePhone": "(470)764-4412",
      "ContactPhone": "(950)952-9024",
      "AssociateName": "Bailey, Wiza and Dach",
      "AssociateId": 968,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "autem",
      "Kanalname": "vero",
      "Post1": "voluptatem",
      "Post2": "repudiandae",
      "Post3": "quidem",
      "EmailName": "alford@bartell.uk",
      "ContactFullName": "Isaiah Conroy",
      "ActiveErpLinks": 919,
      "TicketPriorityId": 842,
      "SupportLanguageId": 861,
      "SupportAssociateId": 312,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 683
        }
      }
    }
  ],
  "AlertLevel": 183,
  "ConnectId": 392,
  "ReadStatus": "Green",
  "TimeToReply": 792,
  "RealTimeToReply": 821,
  "TimeToClose": 821,
  "RealTimeToClose": 845,
  "TimeSpentInternally": 142,
  "TimeSpentExternally": 820,
  "TimeSpentQueue": 250,
  "RealTimeSpentInternally": 695,
  "RealTimeSpentExternally": 265,
  "RealTimeSpentQueue": 143,
  "TimeSpent": 55,
  "HasAttachment": false,
  "NumReplies": 432,
  "NumMessages": 232,
  "FromAddress": "at",
  "Messages": [
    {
      "TicketMessageId": 350,
      "CreatedAt": "2006-10-10T13:28:32.3354749+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "rem",
      "PersonId": 992,
      "PersonFullName": "Emily Borer",
      "ContactId": 654,
      "ContactName": "McGlynn, Mitchell and Schoen",
      "ContactDepartment": "",
      "NumAttachments": 648,
      "EmailHeader": "rosemarie@jenkins.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "unde",
      "Sentiment": 982,
      "SentimentConfidence": 441,
      "CreatedBy": 933,
      "ChangedAt": "2013-12-10T13:28:32.3354749+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 831
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 898,
      "Name": "Gislason, Cronin and Harvey",
      "ToolTip": "Vero molestiae ea.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 100
        }
      }
    },
    {
      "Id": 898,
      "Name": "Gislason, Cronin and Harvey",
      "ToolTip": "Vero molestiae ea.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 100
        }
      }
    }
  ],
  "Language": "recusandae",
  "Sentiment": 580,
  "SentimentConfidence": 907,
  "SuggestedCategoryId": 496,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 694,
  "IconHint": "ipsa",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 179,
  "ExtraFields": {
    "ExtraFields1": "laborum",
    "ExtraFields2": "ea"
  },
  "CustomFields": {
    "CustomFields1": "nobis",
    "CustomFields2": "occaecati"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 566
    }
  }
}
```