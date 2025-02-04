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
  "TicketId": 561,
  "Title": "perferendis",
  "CreatedAt": "2013-10-07T13:13:32.3705187+02:00",
  "LastChanged": "1999-04-26T13:13:32.3705187+02:00",
  "ReadByOwner": "2015-07-03T13:13:32.3705187+02:00",
  "ReadByCustomer": "2021-10-23T13:13:32.3705187+02:00",
  "FirstReadByOwner": "2013-03-30T13:13:32.3705187+01:00",
  "FirstReadByUser": "2001-09-23T13:13:32.3705187+02:00",
  "Activate": "2021-08-31T13:13:32.3705187+02:00",
  "ClosedAt": "2024-08-25T13:13:32.3705187+02:00",
  "RepliedAt": "2014-06-05T13:13:32.3705187+02:00",
  "AlertTimeout": "2022-02-28T13:13:32.3705187+01:00",
  "Deadline": "2002-04-19T13:13:32.3705187+02:00",
  "CreatedBy": null,
  "Author": "architecto",
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
      "Position": "incidunt",
      "PersonId": 604,
      "Mrmrs": "nisi",
      "Firstname": "Wallace",
      "Lastname": "Kozey",
      "MiddleName": "Hoeger, Jacobson and Mosciski",
      "Title": "eos",
      "Description": "Up-sized value-added circuit",
      "Email": "jerel@hyatt.co.uk",
      "FullName": "Vidal Hessel",
      "DirectPhone": "1-092-063-4469",
      "FormalName": "Kautzer, Abshire and Corwin",
      "CountryId": 511,
      "ContactId": 897,
      "ContactName": "Bruen, Hand and Bode",
      "Retired": 833,
      "Rank": 730,
      "ActiveInterests": 312,
      "ContactDepartment": "",
      "ContactCountryId": 213,
      "ContactOrgNr": "579160",
      "FaxPhone": "780-378-1549 x7867",
      "MobilePhone": "339-708-8167 x6943",
      "ContactPhone": "(972)722-2193",
      "AssociateName": "Mohr, Cartwright and Crona",
      "AssociateId": 899,
      "UsePersonAddress": false,
      "ContactFax": "autem",
      "Kanafname": "dolor",
      "Kanalname": "rerum",
      "Post1": "beatae",
      "Post2": "eaque",
      "Post3": "vitae",
      "EmailName": "idella_greenholt@gleason.biz",
      "ContactFullName": "Dusty Deckow",
      "ActiveErpLinks": 492,
      "TicketPriorityId": 666,
      "SupportLanguageId": 65,
      "SupportAssociateId": 430,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 651,
  "ConnectId": 464,
  "ReadStatus": "Green",
  "TimeToReply": 718,
  "RealTimeToReply": 195,
  "TimeToClose": 414,
  "RealTimeToClose": 52,
  "TimeSpentInternally": 676,
  "TimeSpentExternally": 349,
  "TimeSpentQueue": 174,
  "RealTimeSpentInternally": 741,
  "RealTimeSpentExternally": 869,
  "RealTimeSpentQueue": 452,
  "TimeSpent": 835,
  "HasAttachment": false,
  "NumReplies": 330,
  "NumMessages": 264,
  "FromAddress": "repellat",
  "Messages": [
    {
      "TicketMessageId": 5,
      "CreatedAt": "2003-05-23T13:13:32.3705187+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "minus",
      "PersonId": 842,
      "PersonFullName": "Tyrell Cierra Smitham III",
      "ContactId": 277,
      "ContactName": "Schneider-Kuhlman",
      "ContactDepartment": "",
      "NumAttachments": 934,
      "EmailHeader": "kristina.raynor@sawayngutmann.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "sit",
      "Sentiment": 941,
      "SentimentConfidence": 20,
      "CreatedBy": 595,
      "ChangedAt": "2019-02-21T13:13:32.3705187+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 540,
      "Name": "Hane, Adams and Buckridge",
      "ToolTip": "Iste aut laudantium adipisci nulla quis."
    },
    {
      "Id": 540,
      "Name": "Hane, Adams and Buckridge",
      "ToolTip": "Iste aut laudantium adipisci nulla quis."
    }
  ],
  "Language": "iusto",
  "Sentiment": 489,
  "SentimentConfidence": 462,
  "SuggestedCategoryId": 714,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 646,
  "IconHint": "repellendus",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 800,
  "ExtraFields": {
    "ExtraFields1": "molestiae",
    "ExtraFields2": "unde"
  },
  "CustomFields": {
    "CustomFields1": "odio",
    "CustomFields2": "quaerat"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 452,
  "Title": "assumenda",
  "CreatedAt": "2009-07-22T13:13:32.3705187+02:00",
  "LastChanged": "2023-12-29T13:13:32.3705187+01:00",
  "ReadByOwner": "2000-08-02T13:13:32.3705187+02:00",
  "ReadByCustomer": "2015-04-11T13:13:32.3705187+02:00",
  "FirstReadByOwner": "2013-10-18T13:13:32.3705187+02:00",
  "FirstReadByUser": "2009-11-24T13:13:32.3705187+01:00",
  "Activate": "2007-02-17T13:13:32.3705187+01:00",
  "ClosedAt": "2022-06-26T13:13:32.3705187+02:00",
  "RepliedAt": "2020-02-24T13:13:32.3705187+01:00",
  "AlertTimeout": "1997-11-15T13:13:32.3705187+01:00",
  "Deadline": "2002-09-21T13:13:32.3705187+02:00",
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
      "Position": "itaque",
      "PersonId": 38,
      "Mrmrs": "ipsa",
      "Firstname": "Abel",
      "Lastname": "Sauer",
      "MiddleName": "Pfannerstill, Moen and Mertz",
      "Title": "quia",
      "Description": "Down-sized well-modulated website",
      "Email": "enrico.kessler@kohler.us",
      "FullName": "Rafaela Gaylord",
      "DirectPhone": "911.770.2289 x145",
      "FormalName": "Okuneva, Frami and Wilderman",
      "CountryId": 357,
      "ContactId": 267,
      "ContactName": "Rutherford-Jenkins",
      "Retired": 750,
      "Rank": 509,
      "ActiveInterests": 820,
      "ContactDepartment": "",
      "ContactCountryId": 421,
      "ContactOrgNr": "976697",
      "FaxPhone": "691-010-9883",
      "MobilePhone": "056-512-7073 x1610",
      "ContactPhone": "920-470-7984 x490",
      "AssociateName": "Goyette-Braun",
      "AssociateId": 907,
      "UsePersonAddress": true,
      "ContactFax": "asperiores",
      "Kanafname": "quos",
      "Kanalname": "vitae",
      "Post1": "quia",
      "Post2": "vitae",
      "Post3": "voluptas",
      "EmailName": "alexys@turcotte.ca",
      "ContactFullName": "Prof. Maritza Heathcote",
      "ActiveErpLinks": 422,
      "TicketPriorityId": 297,
      "SupportLanguageId": 915,
      "SupportAssociateId": 980,
      "CategoryName": "VIP Customer",
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
  "AlertLevel": 811,
  "ConnectId": 430,
  "ReadStatus": "Green",
  "TimeToReply": 599,
  "RealTimeToReply": 950,
  "TimeToClose": 943,
  "RealTimeToClose": 452,
  "TimeSpentInternally": 210,
  "TimeSpentExternally": 997,
  "TimeSpentQueue": 572,
  "RealTimeSpentInternally": 705,
  "RealTimeSpentExternally": 604,
  "RealTimeSpentQueue": 977,
  "TimeSpent": 928,
  "HasAttachment": false,
  "NumReplies": 217,
  "NumMessages": 317,
  "FromAddress": "nesciunt",
  "Messages": [
    {
      "TicketMessageId": 715,
      "CreatedAt": "2016-12-04T13:13:32.3861399+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "unde",
      "PersonId": 230,
      "PersonFullName": "Jocelyn Haag",
      "ContactId": 618,
      "ContactName": "Champlin-Boehm",
      "ContactDepartment": "",
      "NumAttachments": 771,
      "EmailHeader": "rodrigo@bashirianchristiansen.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "eligendi",
      "Sentiment": 314,
      "SentimentConfidence": 368,
      "CreatedBy": 9,
      "ChangedAt": "2020-05-10T13:13:32.3861399+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 974
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 39,
      "Name": "Okuneva, Hessel and Armstrong",
      "ToolTip": "A non aut et molestiae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 856
        }
      }
    },
    {
      "Id": 39,
      "Name": "Okuneva, Hessel and Armstrong",
      "ToolTip": "A non aut et molestiae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 856
        }
      }
    }
  ],
  "Language": "non",
  "Sentiment": 741,
  "SentimentConfidence": 338,
  "SuggestedCategoryId": 567,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 794,
  "IconHint": "velit",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 519,
  "ExtraFields": {
    "ExtraFields1": "numquam",
    "ExtraFields2": "explicabo"
  },
  "CustomFields": {
    "CustomFields1": "quaerat",
    "CustomFields2": "consequatur"
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