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
| TicketId | int32 | The primary key (auto-incremented) |
| Title | string | The title of the ticket. |
| CreatedAt | date-time | When the ticket was created. |
| LastChanged | date-time | The last time the ticket was modified. |
| ReadByOwner | date-time | The datetime for when the ticket last was read by the owner. |
| ReadByCustomer | date-time | The datetime for when the ticket was read by the customer. |
| FirstReadByUser | date-time | The datetime for when the ticket first was read by a user. |
| Activate | date-time | When the ticket should be activated, if it is postponed. |
| ClosedAt | date-time | When the ticket was closed. |
| RepliedAt | date-time | The datetime for when the ticket was replied to. I.e. the first external message added to the ticket. |
| AlertTimeout | date-time | The datetime for when the ticket should jump to the next alert_level. |
| Deadline | date-time | Deadline for ticket. |
| CreatedBy |  | The associate who created this ticket |
| Author | string | A string representing the author of the ticket (same as author of first message). |
| OwnedBy |  | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category |  | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority |  | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status |  | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person |  | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 400 | Bad request. Entity to save is not in request body. |

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | int32 | The primary key (auto-incremented) |
| Title | string | The title of the ticket. |
| CreatedAt | date-time | When the ticket was created. |
| LastChanged | date-time | The last time the ticket was modified. |
| ReadByOwner | date-time | The datetime for when the ticket last was read by the owner. |
| ReadByCustomer | date-time | The datetime for when the ticket was read by the customer. |
| FirstReadByUser | date-time | The datetime for when the ticket first was read by a user. |
| Activate | date-time | When the ticket should be activated, if it is postponed. |
| ClosedAt | date-time | When the ticket was closed. |
| RepliedAt | date-time | The datetime for when the ticket was replied to. I.e. the first external message added to the ticket. |
| AlertTimeout | date-time | The datetime for when the ticket should jump to the next alert_level. |
| Deadline | date-time | Deadline for ticket. |
| CreatedBy |  | The associate who created this ticket |
| Author | string | A string representing the author of the ticket (same as author of first message). |
| OwnedBy |  | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category |  | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority |  | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status |  | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person |  | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 437,
  "Title": "corporis",
  "CreatedAt": "2014-05-22T11:10:53.5822141+02:00",
  "LastChanged": "1999-09-01T11:10:53.5822141+02:00",
  "ReadByOwner": "1995-05-08T11:10:53.5822141+02:00",
  "ReadByCustomer": "2015-07-05T11:10:53.5822141+02:00",
  "FirstReadByUser": "1997-01-26T11:10:53.5822141+01:00",
  "Activate": "2006-09-21T11:10:53.5822141+02:00",
  "ClosedAt": "2002-12-11T11:10:53.5822141+01:00",
  "RepliedAt": "2002-09-06T11:10:53.5822141+02:00",
  "AlertTimeout": "2009-12-27T11:10:53.5822141+01:00",
  "Deadline": "2022-04-26T11:10:53.5822141+02:00",
  "CreatedBy": null,
  "Author": "et",
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
      "PersonId": 725,
      "Mrmrs": "eligendi",
      "Firstname": "Autumn",
      "Lastname": "Gislason",
      "MiddleName": "Osinski-Stiedemann",
      "Title": "dolorem",
      "Description": "Fundamental attitude-oriented budgetary management",
      "Email": "gussie@kulas.uk",
      "FullName": "Dylan Kuvalis",
      "DirectPhone": "(920)075-5804 x3014",
      "FormalName": "Prohaska-Parker",
      "CountryId": 244,
      "ContactId": 355,
      "ContactName": "Hermiston LLC",
      "Retired": 60,
      "Rank": 83,
      "ActiveInterests": 774,
      "ContactDepartment": "",
      "ContactCountryId": 465,
      "ContactOrgNr": "865931",
      "FaxPhone": "841.889.3047",
      "MobilePhone": "446.947.8123 x40052",
      "ContactPhone": "017.899.1372 x414",
      "AssociateName": "McDermott-Schultz",
      "AssociateId": 44,
      "UsePersonAddress": false,
      "ContactFax": "impedit",
      "Kanafname": "vel",
      "Kanalname": "aut",
      "Post1": "dolores",
      "Post2": "quas",
      "Post3": "odit",
      "EmailName": "jarrod@rippin.biz",
      "ContactFullName": "Amelie Kuhn",
      "ActiveErpLinks": 518,
      "TicketPriorityId": 145,
      "SupportLanguageId": 705,
      "SupportAssociateId": 936,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 227,
  "ConnectId": 257,
  "ReadStatus": "Green",
  "TimeToReply": 25,
  "RealTimeToReply": 75,
  "TimeToClose": 982,
  "RealTimeToClose": 735,
  "TimeSpentInternally": 379,
  "TimeSpentExternally": 491,
  "TimeSpentQueue": 917,
  "RealTimeSpentInternally": 225,
  "RealTimeSpentExternally": 692,
  "RealTimeSpentQueue": 969,
  "HasAttachment": false,
  "NumReplies": 461,
  "NumMessages": 685,
  "FromAddress": "ad",
  "Messages": [
    {
      "TicketMessageId": 692,
      "CreatedAt": "2011-08-12T11:10:53.5872198+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "quisquam",
      "PersonId": 554,
      "PersonFullName": "Miss Alfred Hilll",
      "ContactId": 279,
      "ContactName": "Spencer LLC",
      "ContactDepartment": "",
      "NumAttachments": 240,
      "EmailHeader": "otha@bernierfritsch.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "iusto",
      "Sentiment": 131,
      "SentimentConfidence": 137,
      "CreatedBy": 249
    }
  ],
  "Tags": [
    {
      "Id": 890,
      "Name": "Kutch, Casper and Ernser",
      "ToolTip": "Facilis distinctio."
    },
    {
      "Id": 890,
      "Name": "Kutch, Casper and Ernser",
      "ToolTip": "Facilis distinctio."
    }
  ],
  "Language": "dolorem",
  "Sentiment": 657,
  "SentimentConfidence": 74,
  "SuggestedCategoryId": 947,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 123,
  "IconHint": "voluptas",
  "ExtraFields": {
    "ExtraFields1": "quasi",
    "ExtraFields2": "voluptate"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "reiciendis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 780,
  "Title": "deserunt",
  "CreatedAt": "2015-07-22T11:10:53.5932126+02:00",
  "LastChanged": "2017-06-18T11:10:53.5932126+02:00",
  "ReadByOwner": "2018-02-18T11:10:53.5932126+01:00",
  "ReadByCustomer": "2000-03-08T11:10:53.5932126+01:00",
  "FirstReadByUser": "2012-08-09T11:10:53.5932126+02:00",
  "Activate": "2015-03-06T11:10:53.5932126+01:00",
  "ClosedAt": "2020-05-24T11:10:53.5932126+02:00",
  "RepliedAt": "2003-08-28T11:10:53.5932126+02:00",
  "AlertTimeout": "1996-09-18T11:10:53.5932126+02:00",
  "Deadline": "2016-11-26T11:10:53.5932126+01:00",
  "CreatedBy": null,
  "Author": "excepturi",
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
      "Position": "vitae",
      "PersonId": 192,
      "Mrmrs": "distinctio",
      "Firstname": "Abigale",
      "Lastname": "Dickens",
      "MiddleName": "Collier LLC",
      "Title": "fugit",
      "Description": "Face to face intermediate utilisation",
      "Email": "marilou@jacobsonondricka.biz",
      "FullName": "Gregory Skiles",
      "DirectPhone": "1-382-692-6590",
      "FormalName": "Marquardt, Hyatt and Hamill",
      "CountryId": 971,
      "ContactId": 397,
      "ContactName": "Block LLC",
      "Retired": 605,
      "Rank": 85,
      "ActiveInterests": 849,
      "ContactDepartment": "",
      "ContactCountryId": 487,
      "ContactOrgNr": "789214",
      "FaxPhone": "(807)195-3706 x698",
      "MobilePhone": "364.208.0554 x573",
      "ContactPhone": "(949)701-1138 x049",
      "AssociateName": "Trantow LLC",
      "AssociateId": 616,
      "UsePersonAddress": false,
      "ContactFax": "aut",
      "Kanafname": "adipisci",
      "Kanalname": "voluptatem",
      "Post1": "aut",
      "Post2": "in",
      "Post3": "ducimus",
      "EmailName": "alexane.kerluke@kilback.co.uk",
      "ContactFullName": "Randall Strosin",
      "ActiveErpLinks": 906,
      "TicketPriorityId": 503,
      "SupportLanguageId": 327,
      "SupportAssociateId": 928,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 659
        }
      }
    }
  ],
  "AlertLevel": 909,
  "ConnectId": 650,
  "ReadStatus": "Green",
  "TimeToReply": 802,
  "RealTimeToReply": 125,
  "TimeToClose": 752,
  "RealTimeToClose": 259,
  "TimeSpentInternally": 221,
  "TimeSpentExternally": 337,
  "TimeSpentQueue": 39,
  "RealTimeSpentInternally": 125,
  "RealTimeSpentExternally": 749,
  "RealTimeSpentQueue": 596,
  "HasAttachment": false,
  "NumReplies": 595,
  "NumMessages": 956,
  "FromAddress": "aut",
  "Messages": [
    {
      "TicketMessageId": 539,
      "CreatedAt": "2017-10-08T11:10:53.5962121+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "ea",
      "PersonId": 568,
      "PersonFullName": "Miss Mallie Eliseo Harber III",
      "ContactId": 461,
      "ContactName": "Schamberger Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 773,
      "EmailHeader": "dominic@kilback.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "voluptatem",
      "Sentiment": 440,
      "SentimentConfidence": 816,
      "CreatedBy": 414,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 279
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 422,
      "Name": "Langosh, Reichel and Hane",
      "ToolTip": "Odit vel id nam in.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 280
        }
      }
    },
    {
      "Id": 422,
      "Name": "Langosh, Reichel and Hane",
      "ToolTip": "Odit vel id nam in.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 280
        }
      }
    }
  ],
  "Language": "et",
  "Sentiment": 543,
  "SentimentConfidence": 618,
  "SuggestedCategoryId": 725,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 292,
  "IconHint": "eius",
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "hic",
    "CustomFields2": "iure"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 381
    }
  }
}
```