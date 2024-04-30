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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketId": 55,
  "Title": "ipsum",
  "CreatedAt": "2007-03-09T11:16:14.2617167+01:00",
  "LastChanged": "2020-06-29T11:16:14.2617167+02:00",
  "ReadByOwner": "2020-04-13T11:16:14.2617167+02:00",
  "ReadByCustomer": "2023-03-25T11:16:14.2617167+01:00",
  "FirstReadByOwner": "2016-05-09T11:16:14.2617167+02:00",
  "FirstReadByUser": "1998-03-24T11:16:14.2617167+01:00",
  "Activate": "2022-09-21T11:16:14.2617167+02:00",
  "ClosedAt": "2001-06-26T11:16:14.2617167+02:00",
  "RepliedAt": "2016-09-11T11:16:14.2617167+02:00",
  "AlertTimeout": "2006-11-11T11:16:14.2617167+01:00",
  "Deadline": "2006-10-01T11:16:14.2617167+02:00",
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
      "Position": "iusto",
      "PersonId": 841,
      "Mrmrs": "et",
      "Firstname": "Minnie",
      "Lastname": "Balistreri",
      "MiddleName": "Gulgowski, Wiegand and Rutherford",
      "Title": "aspernatur",
      "Description": "Innovative transitional info-mediaries",
      "Email": "mossie.zulauf@damoremacejkovic.ca",
      "FullName": "Ms. Adolph Bradley Reynolds",
      "DirectPhone": "1-116-185-2773 x7966",
      "FormalName": "Olson, Hagenes and Mayert",
      "CountryId": 746,
      "ContactId": 343,
      "ContactName": "Reilly, Ortiz and Altenwerth",
      "Retired": 575,
      "Rank": 354,
      "ActiveInterests": 402,
      "ContactDepartment": "",
      "ContactCountryId": 21,
      "ContactOrgNr": "1275067",
      "FaxPhone": "167.899.7253 x57844",
      "MobilePhone": "504.274.2652 x85569",
      "ContactPhone": "1-452-980-1534",
      "AssociateName": "Cormier-Corwin",
      "AssociateId": 355,
      "UsePersonAddress": true,
      "ContactFax": "officia",
      "Kanafname": "sed",
      "Kanalname": "officiis",
      "Post1": "nobis",
      "Post2": "non",
      "Post3": "quaerat",
      "EmailName": "lue@steuberlemke.co.uk",
      "ContactFullName": "Dr. Jayce Donna Schmeler MD",
      "ActiveErpLinks": 163,
      "TicketPriorityId": 843,
      "SupportLanguageId": 633,
      "SupportAssociateId": 983,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 697,
  "ConnectId": 536,
  "ReadStatus": "Green",
  "TimeToReply": 182,
  "RealTimeToReply": 784,
  "TimeToClose": 606,
  "RealTimeToClose": 696,
  "TimeSpentInternally": 375,
  "TimeSpentExternally": 401,
  "TimeSpentQueue": 122,
  "RealTimeSpentInternally": 212,
  "RealTimeSpentExternally": 507,
  "RealTimeSpentQueue": 478,
  "TimeSpent": 700,
  "HasAttachment": false,
  "NumReplies": 736,
  "NumMessages": 676,
  "FromAddress": "id",
  "Messages": [
    {
      "TicketMessageId": 815,
      "CreatedAt": "2012-08-02T11:16:14.2773363+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "blanditiis",
      "PersonId": 960,
      "PersonFullName": "Prof. Abby Aurelie Kerluke IV",
      "ContactId": 410,
      "ContactName": "Feeney LLC",
      "ContactDepartment": "",
      "NumAttachments": 337,
      "EmailHeader": "korbin@larkin.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "rerum",
      "Sentiment": 315,
      "SentimentConfidence": 30,
      "CreatedBy": 568,
      "ChangedAt": "2015-05-04T11:16:14.2773363+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 108,
      "Name": "Rosenbaum LLC",
      "ToolTip": "Neque eum voluptate voluptas possimus rerum non."
    },
    {
      "Id": 108,
      "Name": "Rosenbaum LLC",
      "ToolTip": "Neque eum voluptate voluptas possimus rerum non."
    }
  ],
  "Language": "voluptatem",
  "Sentiment": 779,
  "SentimentConfidence": 654,
  "SuggestedCategoryId": 292,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 395,
  "IconHint": "ipsum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 989,
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "quos"
  },
  "CustomFields": {
    "CustomFields1": "quasi",
    "CustomFields2": "consequatur"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 3,
  "Title": "asperiores",
  "CreatedAt": "2002-01-24T11:16:14.2773363+01:00",
  "LastChanged": "2006-01-22T11:16:14.2773363+01:00",
  "ReadByOwner": "2003-04-19T11:16:14.2773363+02:00",
  "ReadByCustomer": "2017-07-25T11:16:14.2773363+02:00",
  "FirstReadByOwner": "1999-07-12T11:16:14.2773363+02:00",
  "FirstReadByUser": "2000-02-12T11:16:14.2773363+01:00",
  "Activate": "2013-02-06T11:16:14.2773363+01:00",
  "ClosedAt": "2023-05-13T11:16:14.2773363+02:00",
  "RepliedAt": "2018-06-08T11:16:14.2773363+02:00",
  "AlertTimeout": "2021-10-21T11:16:14.2773363+02:00",
  "Deadline": "2000-11-15T11:16:14.2773363+01:00",
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
      "Position": "voluptatem",
      "PersonId": 909,
      "Mrmrs": "quo",
      "Firstname": "Prince",
      "Lastname": "Fadel",
      "MiddleName": "Heidenreich-Hettinger",
      "Title": "et",
      "Description": "Virtual foreground knowledge base",
      "Email": "annamae@doyle.com",
      "FullName": "Alejandrin Emmerich",
      "DirectPhone": "792.325.1216",
      "FormalName": "Ebert-Willms",
      "CountryId": 761,
      "ContactId": 425,
      "ContactName": "Bosco-Huel",
      "Retired": 802,
      "Rank": 224,
      "ActiveInterests": 683,
      "ContactDepartment": "",
      "ContactCountryId": 539,
      "ContactOrgNr": "840609",
      "FaxPhone": "(536)039-4033",
      "MobilePhone": "764.811.9916 x283",
      "ContactPhone": "844.763.9178",
      "AssociateName": "Johnson-Buckridge",
      "AssociateId": 255,
      "UsePersonAddress": false,
      "ContactFax": "eaque",
      "Kanafname": "nisi",
      "Kanalname": "perspiciatis",
      "Post1": "voluptatem",
      "Post2": "praesentium",
      "Post3": "autem",
      "EmailName": "bettie@white.ca",
      "ContactFullName": "Friedrich Eileen Champlin DDS",
      "ActiveErpLinks": 326,
      "TicketPriorityId": 143,
      "SupportLanguageId": 995,
      "SupportAssociateId": 105,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 615
        }
      }
    }
  ],
  "AlertLevel": 724,
  "ConnectId": 134,
  "ReadStatus": "Green",
  "TimeToReply": 716,
  "RealTimeToReply": 587,
  "TimeToClose": 731,
  "RealTimeToClose": 121,
  "TimeSpentInternally": 292,
  "TimeSpentExternally": 182,
  "TimeSpentQueue": 716,
  "RealTimeSpentInternally": 750,
  "RealTimeSpentExternally": 224,
  "RealTimeSpentQueue": 839,
  "TimeSpent": 655,
  "HasAttachment": false,
  "NumReplies": 451,
  "NumMessages": 254,
  "FromAddress": "quo",
  "Messages": [
    {
      "TicketMessageId": 738,
      "CreatedAt": "2009-07-06T11:16:14.2773363+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "officiis",
      "PersonId": 721,
      "PersonFullName": "Alfredo Murazik Jr.",
      "ContactId": 20,
      "ContactName": "Goodwin LLC",
      "ContactDepartment": "",
      "NumAttachments": 852,
      "EmailHeader": "alexandrea.white@brekke.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "minus",
      "Sentiment": 306,
      "SentimentConfidence": 919,
      "CreatedBy": 648,
      "ChangedAt": "2023-04-09T11:16:14.2773363+02:00",
      "Badge": "Comment",
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
  "Tags": [
    {
      "Id": 470,
      "Name": "Tromp-Strosin",
      "ToolTip": "Quis minima sequi dicta vitae fugiat natus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 725
        }
      }
    },
    {
      "Id": 470,
      "Name": "Tromp-Strosin",
      "ToolTip": "Quis minima sequi dicta vitae fugiat natus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 725
        }
      }
    }
  ],
  "Language": "doloremque",
  "Sentiment": 803,
  "SentimentConfidence": 873,
  "SuggestedCategoryId": 563,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 300,
  "IconHint": "ut",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 269,
  "ExtraFields": {
    "ExtraFields1": "possimus",
    "ExtraFields2": "harum"
  },
  "CustomFields": {
    "CustomFields1": "blanditiis",
    "CustomFields2": "in"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 558
    }
  }
}
```