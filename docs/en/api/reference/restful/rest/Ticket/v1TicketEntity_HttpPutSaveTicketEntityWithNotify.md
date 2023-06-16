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
PUT /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketId": 971,
  "Title": "quis",
  "CreatedAt": "2016-05-08T16:00:48.5083897+02:00",
  "LastChanged": "2003-07-13T16:00:48.5083897+02:00",
  "ReadByOwner": "2001-12-09T16:00:48.5083897+01:00",
  "ReadByCustomer": "1999-05-28T16:00:48.5083897+02:00",
  "FirstReadByOwner": "2013-09-24T16:00:48.5083897+02:00",
  "FirstReadByUser": "1997-12-09T16:00:48.5083897+01:00",
  "Activate": "2019-05-25T16:00:48.5083897+02:00",
  "ClosedAt": "2010-03-30T16:00:48.5083897+02:00",
  "RepliedAt": "2000-12-14T16:00:48.5083897+01:00",
  "AlertTimeout": "2004-09-05T16:00:48.5083897+02:00",
  "Deadline": "2001-05-23T16:00:48.5083897+02:00",
  "CreatedBy": null,
  "Author": "eos",
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
      "Position": "dolor",
      "PersonId": 777,
      "Mrmrs": "accusantium",
      "Firstname": "Modesta",
      "Lastname": "Thiel",
      "MiddleName": "Ledner, Okuneva and Batz",
      "Title": "temporibus",
      "Description": "Open-architected global workforce",
      "Email": "meagan@bode.us",
      "FullName": "Prof. Kadin Kilback",
      "DirectPhone": "109-549-0478 x423",
      "FormalName": "Kiehn LLC",
      "CountryId": 662,
      "ContactId": 420,
      "ContactName": "Adams, Goodwin and Lowe",
      "Retired": 809,
      "Rank": 186,
      "ActiveInterests": 875,
      "ContactDepartment": "",
      "ContactCountryId": 123,
      "ContactOrgNr": "1152607",
      "FaxPhone": "(064)486-8663 x8994",
      "MobilePhone": "698-875-6706 x1129",
      "ContactPhone": "820.983.7391 x910",
      "AssociateName": "Bartoletti, Schumm and Ortiz",
      "AssociateId": 108,
      "UsePersonAddress": false,
      "ContactFax": "debitis",
      "Kanafname": "et",
      "Kanalname": "quae",
      "Post1": "quas",
      "Post2": "asperiores",
      "Post3": "architecto",
      "EmailName": "daija_lang@hicklehessel.info",
      "ContactFullName": "Mrs. Flavio Jaskolski III",
      "ActiveErpLinks": 568,
      "TicketPriorityId": 812,
      "SupportLanguageId": 239,
      "SupportAssociateId": 8,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 712,
  "ConnectId": 947,
  "ReadStatus": "Green",
  "TimeToReply": 784,
  "RealTimeToReply": 319,
  "TimeToClose": 391,
  "RealTimeToClose": 870,
  "TimeSpentInternally": 843,
  "TimeSpentExternally": 5,
  "TimeSpentQueue": 598,
  "RealTimeSpentInternally": 921,
  "RealTimeSpentExternally": 119,
  "RealTimeSpentQueue": 158,
  "HasAttachment": true,
  "NumReplies": 174,
  "NumMessages": 210,
  "FromAddress": "enim",
  "Messages": [
    {
      "TicketMessageId": 41,
      "CreatedAt": "2002-06-17T16:00:48.5240126+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "sit",
      "PersonId": 605,
      "PersonFullName": "Gloria Block DDS",
      "ContactId": 26,
      "ContactName": "Rohan, Pacocha and Schuster",
      "ContactDepartment": "redefine intuitive interfaces",
      "NumAttachments": 424,
      "EmailHeader": "benny.auer@wisoky.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quaerat",
      "Sentiment": 40,
      "SentimentConfidence": 990,
      "CreatedBy": 910,
      "ChangedAt": "2000-10-09T16:00:48.5240126+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 287,
      "Name": "Satterfield-Rau",
      "ToolTip": "Dolorem eligendi cum optio assumenda omnis."
    },
    {
      "Id": 287,
      "Name": "Satterfield-Rau",
      "ToolTip": "Dolorem eligendi cum optio assumenda omnis."
    }
  ],
  "Language": "est",
  "Sentiment": 122,
  "SentimentConfidence": 992,
  "SuggestedCategoryId": 653,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 376,
  "IconHint": "sit",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "odit",
    "ExtraFields2": "adipisci"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "enim"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 830,
  "Title": "nobis",
  "CreatedAt": "1999-10-12T16:00:48.5240126+02:00",
  "LastChanged": "2018-11-14T16:00:48.5240126+01:00",
  "ReadByOwner": "2015-09-04T16:00:48.5240126+02:00",
  "ReadByCustomer": "2001-10-14T16:00:48.5240126+02:00",
  "FirstReadByOwner": "2004-04-03T16:00:48.5240126+02:00",
  "FirstReadByUser": "2007-12-16T16:00:48.5240126+01:00",
  "Activate": "2021-06-28T16:00:48.5240126+02:00",
  "ClosedAt": "1999-01-12T16:00:48.5240126+01:00",
  "RepliedAt": "1999-05-25T16:00:48.5240126+02:00",
  "AlertTimeout": "2010-01-30T16:00:48.5240126+01:00",
  "Deadline": "2020-08-03T16:00:48.5240126+02:00",
  "CreatedBy": null,
  "Author": "vitae",
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
      "Position": "aut",
      "PersonId": 989,
      "Mrmrs": "corporis",
      "Firstname": "Kristina",
      "Lastname": "Ankunding",
      "MiddleName": "Hyatt Group",
      "Title": "rerum",
      "Description": "Synchronised multi-state protocol",
      "Email": "al.schneider@grimes.name",
      "FullName": "Eve Okuneva",
      "DirectPhone": "(278)540-3203 x76523",
      "FormalName": "Simonis, Shields and Wisoky",
      "CountryId": 985,
      "ContactId": 888,
      "ContactName": "Miller, Morissette and O'Keefe",
      "Retired": 936,
      "Rank": 300,
      "ActiveInterests": 918,
      "ContactDepartment": "",
      "ContactCountryId": 6,
      "ContactOrgNr": "1182970",
      "FaxPhone": "606.451.6281 x055",
      "MobilePhone": "087-378-8882",
      "ContactPhone": "992.399.8587 x9660",
      "AssociateName": "Buckridge-Kuhlman",
      "AssociateId": 682,
      "UsePersonAddress": true,
      "ContactFax": "veritatis",
      "Kanafname": "sit",
      "Kanalname": "et",
      "Post1": "voluptas",
      "Post2": "deserunt",
      "Post3": "sed",
      "EmailName": "sven.kautzer@durgan.uk",
      "ContactFullName": "Valentina Kautzer",
      "ActiveErpLinks": 620,
      "TicketPriorityId": 175,
      "SupportLanguageId": 675,
      "SupportAssociateId": 361,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 263
        }
      }
    }
  ],
  "AlertLevel": 684,
  "ConnectId": 126,
  "ReadStatus": "Green",
  "TimeToReply": 853,
  "RealTimeToReply": 208,
  "TimeToClose": 930,
  "RealTimeToClose": 14,
  "TimeSpentInternally": 573,
  "TimeSpentExternally": 934,
  "TimeSpentQueue": 88,
  "RealTimeSpentInternally": 168,
  "RealTimeSpentExternally": 780,
  "RealTimeSpentQueue": 230,
  "HasAttachment": true,
  "NumReplies": 75,
  "NumMessages": 456,
  "FromAddress": "modi",
  "Messages": [
    {
      "TicketMessageId": 334,
      "CreatedAt": "2005-05-12T16:00:48.5396389+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "maxime",
      "PersonId": 490,
      "PersonFullName": "Jeremy Brooke Langosh Jr.",
      "ContactId": 575,
      "ContactName": "Parker-Smith",
      "ContactDepartment": "",
      "NumAttachments": 705,
      "EmailHeader": "mckenzie_dietrich@huel.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "nulla",
      "Sentiment": 25,
      "SentimentConfidence": 211,
      "CreatedBy": 435,
      "ChangedAt": "2015-11-02T16:00:48.5396389+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 992
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 11,
      "Name": "Feil-Parker",
      "ToolTip": "Quam nulla quasi error a est at id.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 293
        }
      }
    },
    {
      "Id": 11,
      "Name": "Feil-Parker",
      "ToolTip": "Quam nulla quasi error a est at id.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 293
        }
      }
    }
  ],
  "Language": "repudiandae",
  "Sentiment": 1000,
  "SentimentConfidence": 997,
  "SuggestedCategoryId": 237,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 4,
  "IconHint": "voluptatem",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "amet",
    "ExtraFields2": "repellendus"
  },
  "CustomFields": {
    "CustomFields1": "commodi",
    "CustomFields2": "architecto"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 195
    }
  }
}
```