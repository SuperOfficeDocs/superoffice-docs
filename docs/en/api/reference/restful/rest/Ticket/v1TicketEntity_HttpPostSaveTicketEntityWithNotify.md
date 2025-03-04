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
POST /api/v1/Ticket?notify=False
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 101,
  "Title": "fugit",
  "CreatedAt": "2004-05-12T14:13:49.2899631+02:00",
  "LastChanged": "2006-08-22T14:13:49.2899631+02:00",
  "ReadByOwner": "2007-05-19T14:13:49.2899631+02:00",
  "ReadByCustomer": "2010-05-11T14:13:49.2899631+02:00",
  "FirstReadByOwner": "2005-04-03T14:13:49.2899631+02:00",
  "FirstReadByUser": "1999-05-11T14:13:49.2899631+02:00",
  "Activate": "2024-01-08T14:13:49.2899631+01:00",
  "ClosedAt": "2000-04-17T14:13:49.2899631+02:00",
  "RepliedAt": "2000-12-16T14:13:49.2899631+01:00",
  "AlertTimeout": "2004-09-04T14:13:49.2899631+02:00",
  "Deadline": "2016-11-07T14:13:49.2899631+01:00",
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
      "Position": "est",
      "PersonId": 208,
      "Mrmrs": "ut",
      "Firstname": "Christine",
      "Lastname": "Berge",
      "MiddleName": "Kunze, Konopelski and Willms",
      "Title": "sapiente",
      "Description": "Centralized scalable matrices",
      "Email": "tyree@schiller.uk",
      "FullName": "Mr. Rhianna Gorczany MD",
      "DirectPhone": "(815)110-3248",
      "FormalName": "Parisian Inc and Sons",
      "CountryId": 213,
      "ContactId": 581,
      "ContactName": "Murray, Bauch and Bergstrom",
      "Retired": 446,
      "Rank": 584,
      "ActiveInterests": 753,
      "ContactDepartment": "",
      "ContactCountryId": 576,
      "ContactOrgNr": "259581",
      "FaxPhone": "(046)510-2705 x88495",
      "MobilePhone": "986.005.8041",
      "ContactPhone": "855.461.1255 x96822",
      "AssociateName": "Morissette LLC",
      "AssociateId": 833,
      "UsePersonAddress": true,
      "ContactFax": "quos",
      "Kanafname": "animi",
      "Kanalname": "sed",
      "Post1": "expedita",
      "Post2": "corporis",
      "Post3": "similique",
      "EmailName": "jerad@howellwilderman.co.uk",
      "ContactFullName": "Rafaela Riley Prohaska DDS",
      "ActiveErpLinks": 790,
      "TicketPriorityId": 995,
      "SupportLanguageId": 760,
      "SupportAssociateId": 11,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1191958"
    }
  ],
  "AlertLevel": 13,
  "ConnectId": 497,
  "ReadStatus": "Green",
  "TimeToReply": 23,
  "RealTimeToReply": 331,
  "TimeToClose": 733,
  "RealTimeToClose": 871,
  "TimeSpentInternally": 597,
  "TimeSpentExternally": 735,
  "TimeSpentQueue": 827,
  "RealTimeSpentInternally": 510,
  "RealTimeSpentExternally": 412,
  "RealTimeSpentQueue": 174,
  "TimeSpent": 236,
  "HasAttachment": true,
  "NumReplies": 309,
  "NumMessages": 626,
  "FromAddress": "culpa",
  "Messages": [
    {
      "TicketMessageId": 198,
      "CreatedAt": "2021-06-22T14:13:49.2899631+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "consectetur",
      "PersonId": 904,
      "PersonFullName": "Malvina Morar",
      "ContactId": 323,
      "ContactName": "Legros LLC",
      "ContactDepartment": "",
      "NumAttachments": 528,
      "EmailHeader": "jeanette@stroman.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "rem",
      "Sentiment": 682,
      "SentimentConfidence": 720,
      "CreatedBy": 819,
      "ChangedAt": "1999-05-16T14:13:49.2899631+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 942,
      "Name": "Bednar-Weber",
      "ToolTip": "Nihil id consequatur cumque rerum cumque porro."
    },
    {
      "Id": 942,
      "Name": "Bednar-Weber",
      "ToolTip": "Nihil id consequatur cumque rerum cumque porro."
    }
  ],
  "Language": "aliquid",
  "Sentiment": 196,
  "SentimentConfidence": 672,
  "SuggestedCategoryId": 445,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 878,
  "IconHint": "veritatis",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 700,
  "ExtraFields": {
    "ExtraFields1": "dignissimos",
    "ExtraFields2": "numquam"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 105,
  "Title": "in",
  "CreatedAt": "1999-03-25T14:13:49.3055851+01:00",
  "LastChanged": "2023-02-11T14:13:49.3055851+01:00",
  "ReadByOwner": "1998-07-18T14:13:49.3055851+02:00",
  "ReadByCustomer": "2009-05-12T14:13:49.3055851+02:00",
  "FirstReadByOwner": "2000-04-30T14:13:49.3055851+02:00",
  "FirstReadByUser": "2016-03-11T14:13:49.3055851+01:00",
  "Activate": "2015-03-09T14:13:49.3055851+01:00",
  "ClosedAt": "2007-01-06T14:13:49.3055851+01:00",
  "RepliedAt": "2022-04-10T14:13:49.3055851+02:00",
  "AlertTimeout": "2008-04-11T14:13:49.3055851+02:00",
  "Deadline": "2009-09-02T14:13:49.3055851+02:00",
  "CreatedBy": null,
  "Author": "debitis",
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
      "Position": "rerum",
      "PersonId": 799,
      "Mrmrs": "sit",
      "Firstname": "Aaron",
      "Lastname": "Fay",
      "MiddleName": "Feest, Bernhard and Johns",
      "Title": "voluptatem",
      "Description": "Switchable national initiative",
      "Email": "kallie_dibbert@robelbeahan.ca",
      "FullName": "Jan Hegmann",
      "DirectPhone": "1-404-966-9802 x585",
      "FormalName": "Cassin Inc and Sons",
      "CountryId": 283,
      "ContactId": 358,
      "ContactName": "Greenfelder LLC",
      "Retired": 702,
      "Rank": 662,
      "ActiveInterests": 268,
      "ContactDepartment": "",
      "ContactCountryId": 630,
      "ContactOrgNr": "1899306",
      "FaxPhone": "945.418.4055",
      "MobilePhone": "(408)789-8495",
      "ContactPhone": "1-298-154-8287",
      "AssociateName": "Morar-Satterfield",
      "AssociateId": 131,
      "UsePersonAddress": false,
      "ContactFax": "consequatur",
      "Kanafname": "unde",
      "Kanalname": "earum",
      "Post1": "voluptates",
      "Post2": "ut",
      "Post3": "corporis",
      "EmailName": "torrance_rath@lemkehackett.co.uk",
      "ContactFullName": "Elva O'Conner",
      "ActiveErpLinks": 317,
      "TicketPriorityId": 740,
      "SupportLanguageId": 696,
      "SupportAssociateId": 730,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1367001",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 953
        }
      }
    }
  ],
  "AlertLevel": 974,
  "ConnectId": 409,
  "ReadStatus": "Green",
  "TimeToReply": 159,
  "RealTimeToReply": 196,
  "TimeToClose": 381,
  "RealTimeToClose": 430,
  "TimeSpentInternally": 729,
  "TimeSpentExternally": 161,
  "TimeSpentQueue": 842,
  "RealTimeSpentInternally": 210,
  "RealTimeSpentExternally": 722,
  "RealTimeSpentQueue": 681,
  "TimeSpent": 857,
  "HasAttachment": true,
  "NumReplies": 472,
  "NumMessages": 142,
  "FromAddress": "exercitationem",
  "Messages": [
    {
      "TicketMessageId": 253,
      "CreatedAt": "2023-09-29T14:13:49.3055851+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "ut",
      "PersonId": 878,
      "PersonFullName": "Napoleon White",
      "ContactId": 25,
      "ContactName": "Bins-Senger",
      "ContactDepartment": "",
      "NumAttachments": 278,
      "EmailHeader": "arnold@sipes.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "exercitationem",
      "Sentiment": 579,
      "SentimentConfidence": 205,
      "CreatedBy": 807,
      "ChangedAt": "2010-08-21T14:13:49.3055851+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 78
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 640,
      "Name": "McClure, Green and Kilback",
      "ToolTip": "Aperiam vero aut eum quas.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 120
        }
      }
    },
    {
      "Id": 640,
      "Name": "McClure, Green and Kilback",
      "ToolTip": "Aperiam vero aut eum quas.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 120
        }
      }
    }
  ],
  "Language": "libero",
  "Sentiment": 323,
  "SentimentConfidence": 676,
  "SuggestedCategoryId": 798,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 464,
  "IconHint": "totam",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 288,
  "ExtraFields": {
    "ExtraFields1": "velit",
    "ExtraFields2": "doloremque"
  },
  "CustomFields": {
    "CustomFields1": "suscipit",
    "CustomFields2": "quasi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 525
    }
  }
}
```