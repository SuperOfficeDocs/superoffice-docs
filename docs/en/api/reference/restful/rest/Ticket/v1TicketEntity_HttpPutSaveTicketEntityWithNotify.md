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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 396,
  "Title": "aut",
  "CreatedAt": "2002-09-22T16:32:48.1650644+02:00",
  "LastChanged": "2015-12-22T16:32:48.1650644+01:00",
  "ReadByOwner": "2004-08-07T16:32:48.1650644+02:00",
  "ReadByCustomer": "2011-03-13T16:32:48.1650644+01:00",
  "FirstReadByOwner": "2001-11-27T16:32:48.1650644+01:00",
  "FirstReadByUser": "2007-04-27T16:32:48.1650644+02:00",
  "Activate": "2000-06-21T16:32:48.1650644+02:00",
  "ClosedAt": "2002-12-01T16:32:48.1650644+01:00",
  "RepliedAt": "2019-10-12T16:32:48.1650644+02:00",
  "AlertTimeout": "2003-05-26T16:32:48.1650644+02:00",
  "Deadline": "2017-08-31T16:32:48.1650644+02:00",
  "CreatedBy": null,
  "Author": "a",
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
      "Position": "consequatur",
      "PersonId": 443,
      "Mrmrs": "sit",
      "Firstname": "Norwood",
      "Lastname": "Spinka",
      "MiddleName": "Walker-Kub",
      "Title": "mollitia",
      "Description": "Team-oriented dedicated pricing structure",
      "Email": "golda@jewessdibbert.co.uk",
      "FullName": "Alyson Spinka",
      "DirectPhone": "258.611.1174",
      "FormalName": "Mueller, Satterfield and Tremblay",
      "CountryId": 816,
      "ContactId": 312,
      "ContactName": "Klein, Schuppe and Gerhold",
      "Retired": 18,
      "Rank": 810,
      "ActiveInterests": 991,
      "ContactDepartment": "",
      "ContactCountryId": 264,
      "ContactOrgNr": "1013195",
      "FaxPhone": "(181)578-1517",
      "MobilePhone": "(592)273-4489",
      "ContactPhone": "149-605-3781",
      "AssociateName": "Kunde, Lebsack and Gulgowski",
      "AssociateId": 935,
      "UsePersonAddress": false,
      "ContactFax": "qui",
      "Kanafname": "voluptatum",
      "Kanalname": "praesentium",
      "Post1": "nesciunt",
      "Post2": "provident",
      "Post3": "quia",
      "EmailName": "julio@gorczanybins.com",
      "ContactFullName": "Erling Frami",
      "ActiveErpLinks": 716,
      "TicketPriorityId": 388,
      "SupportLanguageId": 620,
      "SupportAssociateId": 548,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1445272"
    }
  ],
  "AlertLevel": 967,
  "ConnectId": 906,
  "ReadStatus": "Green",
  "TimeToReply": 828,
  "RealTimeToReply": 765,
  "TimeToClose": 299,
  "RealTimeToClose": 153,
  "TimeSpentInternally": 22,
  "TimeSpentExternally": 404,
  "TimeSpentQueue": 213,
  "RealTimeSpentInternally": 125,
  "RealTimeSpentExternally": 289,
  "RealTimeSpentQueue": 998,
  "TimeSpent": 436,
  "HasAttachment": true,
  "NumReplies": 493,
  "NumMessages": 559,
  "FromAddress": "et",
  "Messages": [
    {
      "TicketMessageId": 381,
      "CreatedAt": "2004-03-16T16:32:48.1650644+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "et",
      "PersonId": 780,
      "PersonFullName": "Miss Gracie Herbert Harvey",
      "ContactId": 101,
      "ContactName": "Breitenberg-Kulas",
      "ContactDepartment": "",
      "NumAttachments": 150,
      "EmailHeader": "maxwell_zemlak@kinganderson.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "reprehenderit",
      "Sentiment": 496,
      "SentimentConfidence": 918,
      "CreatedBy": 138,
      "ChangedAt": "2019-03-09T16:32:48.1650644+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 490,
      "Name": "Cartwright, Pollich and Gerlach",
      "ToolTip": "Placeat repudiandae debitis officiis sed corporis quia laborum."
    },
    {
      "Id": 490,
      "Name": "Cartwright, Pollich and Gerlach",
      "ToolTip": "Placeat repudiandae debitis officiis sed corporis quia laborum."
    }
  ],
  "Language": "deserunt",
  "Sentiment": 221,
  "SentimentConfidence": 132,
  "SuggestedCategoryId": 739,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 890,
  "IconHint": "soluta",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 705,
  "ExtraFields": {
    "ExtraFields1": "vero",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "ex"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 751,
  "Title": "ducimus",
  "CreatedAt": "2024-12-06T16:32:48.1806835+01:00",
  "LastChanged": "2014-10-30T16:32:48.1806835+01:00",
  "ReadByOwner": "2005-10-10T16:32:48.1806835+02:00",
  "ReadByCustomer": "2002-07-14T16:32:48.1806835+02:00",
  "FirstReadByOwner": "2002-08-10T16:32:48.1806835+02:00",
  "FirstReadByUser": "2000-12-24T16:32:48.1806835+01:00",
  "Activate": "2007-04-18T16:32:48.1806835+02:00",
  "ClosedAt": "2011-09-11T16:32:48.1806835+02:00",
  "RepliedAt": "2020-12-12T16:32:48.1806835+01:00",
  "AlertTimeout": "2018-08-24T16:32:48.1806835+02:00",
  "Deadline": "2017-03-18T16:32:48.1806835+01:00",
  "CreatedBy": null,
  "Author": "esse",
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
      "Position": "dignissimos",
      "PersonId": 469,
      "Mrmrs": "deleniti",
      "Firstname": "Krystel",
      "Lastname": "Kshlerin",
      "MiddleName": "Fadel, Howe and Beahan",
      "Title": "qui",
      "Description": "Team-oriented web-enabled system engine",
      "Email": "bernadine.schmeler@simonis.info",
      "FullName": "Emmanuelle Nicolas",
      "DirectPhone": "976.945.4258",
      "FormalName": "O'Kon Group",
      "CountryId": 459,
      "ContactId": 499,
      "ContactName": "Torphy-Labadie",
      "Retired": 970,
      "Rank": 783,
      "ActiveInterests": 486,
      "ContactDepartment": "",
      "ContactCountryId": 858,
      "ContactOrgNr": "977546",
      "FaxPhone": "032.177.9133",
      "MobilePhone": "221-185-4972",
      "ContactPhone": "(762)915-0494 x1769",
      "AssociateName": "Fadel LLC",
      "AssociateId": 995,
      "UsePersonAddress": false,
      "ContactFax": "commodi",
      "Kanafname": "quia",
      "Kanalname": "voluptatem",
      "Post1": "ducimus",
      "Post2": "enim",
      "Post3": "recusandae",
      "EmailName": "bridget.waters@koss.us",
      "ContactFullName": "Maxie Roberts",
      "ActiveErpLinks": 108,
      "TicketPriorityId": 308,
      "SupportLanguageId": 305,
      "SupportAssociateId": 992,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1690866",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 90
        }
      }
    }
  ],
  "AlertLevel": 217,
  "ConnectId": 945,
  "ReadStatus": "Green",
  "TimeToReply": 33,
  "RealTimeToReply": 505,
  "TimeToClose": 467,
  "RealTimeToClose": 836,
  "TimeSpentInternally": 852,
  "TimeSpentExternally": 950,
  "TimeSpentQueue": 893,
  "RealTimeSpentInternally": 94,
  "RealTimeSpentExternally": 298,
  "RealTimeSpentQueue": 938,
  "TimeSpent": 749,
  "HasAttachment": false,
  "NumReplies": 148,
  "NumMessages": 324,
  "FromAddress": "suscipit",
  "Messages": [
    {
      "TicketMessageId": 297,
      "CreatedAt": "2018-12-18T16:32:48.1806835+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "earum",
      "PersonId": 137,
      "PersonFullName": "Dr. Camron Octavia Cremin",
      "ContactId": 753,
      "ContactName": "Hagenes Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 186,
      "EmailHeader": "velva_weimann@durgan.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "libero",
      "Sentiment": 356,
      "SentimentConfidence": 191,
      "CreatedBy": 34,
      "ChangedAt": "2004-01-08T16:32:48.1806835+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 289
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 897,
      "Name": "Flatley, Crist and Waters",
      "ToolTip": "Quos vitae fugit adipisci ullam iusto ut possimus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 513
        }
      }
    },
    {
      "Id": 897,
      "Name": "Flatley, Crist and Waters",
      "ToolTip": "Quos vitae fugit adipisci ullam iusto ut possimus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 513
        }
      }
    }
  ],
  "Language": "qui",
  "Sentiment": 345,
  "SentimentConfidence": 584,
  "SuggestedCategoryId": 400,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 999,
  "IconHint": "sed",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 206,
  "ExtraFields": {
    "ExtraFields1": "amet",
    "ExtraFields2": "illum"
  },
  "CustomFields": {
    "CustomFields1": "sunt",
    "CustomFields2": "autem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 992
    }
  }
}
```