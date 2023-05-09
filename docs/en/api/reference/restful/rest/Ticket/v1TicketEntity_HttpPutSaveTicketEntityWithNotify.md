---
title: PUT Ticket/{id}
uid: v1TicketEntity_HttpPutSaveTicketEntityWithNotify
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
PUT /api/v1/Ticket/{id}?notify=False
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketId": 819,
  "Title": "fugiat",
  "CreatedAt": "2019-04-23T03:51:34.0834893+02:00",
  "LastChanged": "2023-03-30T03:51:34.0834893+02:00",
  "ReadByOwner": "2016-10-22T03:51:34.0834893+02:00",
  "ReadByCustomer": "2017-06-13T03:51:34.0834893+02:00",
  "FirstReadByOwner": "2002-08-13T03:51:34.0834893+02:00",
  "FirstReadByUser": "2020-01-08T03:51:34.0834893+01:00",
  "Activate": "1996-06-09T03:51:34.0834893+02:00",
  "ClosedAt": "2005-01-06T03:51:34.0834893+01:00",
  "RepliedAt": "2013-09-01T03:51:34.0834893+02:00",
  "AlertTimeout": "2022-12-17T03:51:34.0834893+01:00",
  "Deadline": "2020-01-05T03:51:34.0834893+01:00",
  "CreatedBy": null,
  "Author": "omnis",
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
      "Position": "culpa",
      "PersonId": 729,
      "Mrmrs": "odit",
      "Firstname": "Joey",
      "Lastname": "Larson",
      "MiddleName": "Schuster, Wehner and Kovacek",
      "Title": "nulla",
      "Description": "Function-based motivating productivity",
      "Email": "georgiana@anderson.co.uk",
      "FullName": "Mrs. Destany Reichert I",
      "DirectPhone": "418.124.4762 x05824",
      "FormalName": "Little-Schneider",
      "CountryId": 935,
      "ContactId": 659,
      "ContactName": "Koepp LLC",
      "Retired": 465,
      "Rank": 85,
      "ActiveInterests": 857,
      "ContactDepartment": "",
      "ContactCountryId": 872,
      "ContactOrgNr": "1618419",
      "FaxPhone": "1-632-081-2051",
      "MobilePhone": "918-136-4519",
      "ContactPhone": "1-785-106-0382",
      "AssociateName": "Gorczany, Shields and Zieme",
      "AssociateId": 459,
      "UsePersonAddress": false,
      "ContactFax": "ut",
      "Kanafname": "repudiandae",
      "Kanalname": "consequatur",
      "Post1": "quisquam",
      "Post2": "sapiente",
      "Post3": "nobis",
      "EmailName": "bennett@white.co.uk",
      "ContactFullName": "Mavis Spencer",
      "ActiveErpLinks": 475,
      "TicketPriorityId": 517,
      "SupportLanguageId": 985,
      "SupportAssociateId": 432,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 512,
  "ConnectId": 468,
  "ReadStatus": "Green",
  "TimeToReply": 952,
  "RealTimeToReply": 176,
  "TimeToClose": 79,
  "RealTimeToClose": 821,
  "TimeSpentInternally": 24,
  "TimeSpentExternally": 771,
  "TimeSpentQueue": 211,
  "RealTimeSpentInternally": 216,
  "RealTimeSpentExternally": 657,
  "RealTimeSpentQueue": 667,
  "HasAttachment": false,
  "NumReplies": 874,
  "NumMessages": 482,
  "FromAddress": "voluptatem",
  "Messages": [
    {
      "TicketMessageId": 425,
      "CreatedAt": "2006-12-07T03:51:34.0834893+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "at",
      "PersonId": 937,
      "PersonFullName": "Ruthe Ofelia Turner DVM",
      "ContactId": 152,
      "ContactName": "Gerlach, Hegmann and Hamill",
      "ContactDepartment": "",
      "NumAttachments": 935,
      "EmailHeader": "clint_jones@strackefisher.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quia",
      "Sentiment": 748,
      "SentimentConfidence": 118,
      "CreatedBy": 943,
      "ChangedAt": "2021-09-14T03:51:34.0834893+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 933,
      "Name": "Ward, O'Connell and Olson",
      "ToolTip": "Voluptates vero officia dolor sequi sint iusto."
    },
    {
      "Id": 933,
      "Name": "Ward, O'Connell and Olson",
      "ToolTip": "Voluptates vero officia dolor sequi sint iusto."
    }
  ],
  "Language": "in",
  "Sentiment": 105,
  "SentimentConfidence": 374,
  "SuggestedCategoryId": 488,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 188,
  "IconHint": "fuga",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "minus",
    "ExtraFields2": "numquam"
  },
  "CustomFields": {
    "CustomFields1": "repellendus",
    "CustomFields2": "odit"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 582,
  "Title": "consequatur",
  "CreatedAt": "2010-02-12T03:51:34.0834893+01:00",
  "LastChanged": "2021-09-18T03:51:34.0834893+02:00",
  "ReadByOwner": "2017-04-16T03:51:34.0834893+02:00",
  "ReadByCustomer": "2002-05-03T03:51:34.0834893+02:00",
  "FirstReadByOwner": "2010-04-23T03:51:34.0834893+02:00",
  "FirstReadByUser": "2016-11-12T03:51:34.0834893+01:00",
  "Activate": "2017-04-26T03:51:34.0834893+02:00",
  "ClosedAt": "2008-08-13T03:51:34.0834893+02:00",
  "RepliedAt": "2004-11-21T03:51:34.0834893+01:00",
  "AlertTimeout": "2016-03-26T03:51:34.0834893+01:00",
  "Deadline": "2016-11-12T03:51:34.0834893+01:00",
  "CreatedBy": null,
  "Author": "minima",
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
      "PersonId": 812,
      "Mrmrs": "nobis",
      "Firstname": "Fred",
      "Lastname": "Turcotte",
      "MiddleName": "Ankunding, White and Brekke",
      "Title": "et",
      "Description": "Business-focused coherent product",
      "Email": "meda_sanford@klein.ca",
      "FullName": "Raymond Huels",
      "DirectPhone": "1-836-154-3611 x11983",
      "FormalName": "Bernhard-Moore",
      "CountryId": 192,
      "ContactId": 978,
      "ContactName": "Metz, McKenzie and Block",
      "Retired": 892,
      "Rank": 622,
      "ActiveInterests": 894,
      "ContactDepartment": "",
      "ContactCountryId": 460,
      "ContactOrgNr": "721903",
      "FaxPhone": "1-563-150-9625 x5476",
      "MobilePhone": "(933)593-1151 x53178",
      "ContactPhone": "032-306-1028 x445",
      "AssociateName": "Lind-Hansen",
      "AssociateId": 476,
      "UsePersonAddress": false,
      "ContactFax": "ut",
      "Kanafname": "qui",
      "Kanalname": "vero",
      "Post1": "in",
      "Post2": "consequuntur",
      "Post3": "quia",
      "EmailName": "bartholome.hodkiewicz@ziemesmith.ca",
      "ContactFullName": "Caleb Olson",
      "ActiveErpLinks": 163,
      "TicketPriorityId": 259,
      "SupportLanguageId": 116,
      "SupportAssociateId": 242,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 935
        }
      }
    }
  ],
  "AlertLevel": 621,
  "ConnectId": 293,
  "ReadStatus": "Green",
  "TimeToReply": 998,
  "RealTimeToReply": 723,
  "TimeToClose": 492,
  "RealTimeToClose": 536,
  "TimeSpentInternally": 199,
  "TimeSpentExternally": 159,
  "TimeSpentQueue": 969,
  "RealTimeSpentInternally": 734,
  "RealTimeSpentExternally": 732,
  "RealTimeSpentQueue": 105,
  "HasAttachment": false,
  "NumReplies": 69,
  "NumMessages": 90,
  "FromAddress": "voluptatem",
  "Messages": [
    {
      "TicketMessageId": 490,
      "CreatedAt": "2011-04-14T03:51:34.0834893+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "ex",
      "PersonId": 425,
      "PersonFullName": "Miss Aileen Beth Braun Sr.",
      "ContactId": 943,
      "ContactName": "Hauck Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 991,
      "EmailHeader": "kira_spencer@oconner.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ut",
      "Sentiment": 681,
      "SentimentConfidence": 131,
      "CreatedBy": 132,
      "ChangedAt": "2008-05-04T03:51:34.0991005+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 543
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 666,
      "Name": "Paucek Group",
      "ToolTip": "Sed et necessitatibus maiores adipisci sit nisi consequuntur.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 508
        }
      }
    },
    {
      "Id": 666,
      "Name": "Paucek Group",
      "ToolTip": "Sed et necessitatibus maiores adipisci sit nisi consequuntur.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 508
        }
      }
    }
  ],
  "Language": "fuga",
  "Sentiment": 689,
  "SentimentConfidence": 116,
  "SuggestedCategoryId": 371,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 800,
  "IconHint": "sit",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "dolor",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "deserunt",
    "CustomFields2": "soluta"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 751
    }
  }
}
```