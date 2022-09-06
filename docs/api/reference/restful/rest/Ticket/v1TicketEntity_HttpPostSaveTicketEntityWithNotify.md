---
title: POST Ticket
uid: v1TicketEntity_HttpPostSaveTicketEntityWithNotify
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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

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
POST /api/v1/Ticket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketId": 729,
  "Title": "dolores",
  "CreatedAt": "2013-12-07T11:10:53.5511837+01:00",
  "LastChanged": "2009-02-01T11:10:53.5511837+01:00",
  "ReadByOwner": "2003-03-27T11:10:53.5511837+01:00",
  "ReadByCustomer": "2013-09-26T11:10:53.5511837+02:00",
  "FirstReadByUser": "2015-12-31T11:10:53.5511837+01:00",
  "Activate": "2010-01-30T11:10:53.5511837+01:00",
  "ClosedAt": "2006-10-19T11:10:53.5511837+02:00",
  "RepliedAt": "2017-04-25T11:10:53.5511837+02:00",
  "AlertTimeout": "2002-07-10T11:10:53.5511837+02:00",
  "Deadline": "2014-09-09T11:10:53.5511837+02:00",
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
      "Position": "aut",
      "PersonId": 147,
      "Mrmrs": "et",
      "Firstname": "Ardella",
      "Lastname": "Ondricka",
      "MiddleName": "Kemmer, Wiegand and O'Conner",
      "Title": "tempora",
      "Description": "Extended bifurcated emulation",
      "Email": "eunice.johnston@hackett.ca",
      "FullName": "Sydnee Corkery IV",
      "DirectPhone": "210.685.1775 x0976",
      "FormalName": "Langosh, Rodriguez and Feil",
      "CountryId": 803,
      "ContactId": 513,
      "ContactName": "Lindgren LLC",
      "Retired": 12,
      "Rank": 427,
      "ActiveInterests": 316,
      "ContactDepartment": "",
      "ContactCountryId": 118,
      "ContactOrgNr": "800983",
      "FaxPhone": "(027)162-5164 x4293",
      "MobilePhone": "(669)424-2805 x00945",
      "ContactPhone": "147.421.4087",
      "AssociateName": "Romaguera-Baumbach",
      "AssociateId": 451,
      "UsePersonAddress": false,
      "ContactFax": "ratione",
      "Kanafname": "sint",
      "Kanalname": "sit",
      "Post1": "aut",
      "Post2": "quia",
      "Post3": "et",
      "EmailName": "douglas@mueller.biz",
      "ContactFullName": "Mario Blanda",
      "ActiveErpLinks": 585,
      "TicketPriorityId": 88,
      "SupportLanguageId": 966,
      "SupportAssociateId": 164,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 473,
  "ConnectId": 228,
  "ReadStatus": "Green",
  "TimeToReply": 36,
  "RealTimeToReply": 771,
  "TimeToClose": 133,
  "RealTimeToClose": 105,
  "TimeSpentInternally": 595,
  "TimeSpentExternally": 951,
  "TimeSpentQueue": 521,
  "RealTimeSpentInternally": 797,
  "RealTimeSpentExternally": 640,
  "RealTimeSpentQueue": 797,
  "HasAttachment": false,
  "NumReplies": 173,
  "NumMessages": 760,
  "FromAddress": "sapiente",
  "Messages": [
    {
      "TicketMessageId": 875,
      "CreatedAt": "2000-07-11T11:10:53.5592438+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "labore",
      "PersonId": 383,
      "PersonFullName": "Jeffery Shanahan",
      "ContactId": 577,
      "ContactName": "Wintheiser-Jacobson",
      "ContactDepartment": "",
      "NumAttachments": 857,
      "EmailHeader": "quincy@marks.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quasi",
      "Sentiment": 852,
      "SentimentConfidence": 73,
      "CreatedBy": 42
    }
  ],
  "Tags": [
    {
      "Id": 927,
      "Name": "Gibson Group",
      "ToolTip": "Quod ea dolores iure enim est perferendis consequuntur."
    },
    {
      "Id": 927,
      "Name": "Gibson Group",
      "ToolTip": "Quod ea dolores iure enim est perferendis consequuntur."
    }
  ],
  "Language": "similique",
  "Sentiment": 496,
  "SentimentConfidence": 786,
  "SuggestedCategoryId": 987,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 485,
  "IconHint": "porro",
  "ExtraFields": {
    "ExtraFields1": "exercitationem",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "corrupti",
    "CustomFields2": "optio"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 189,
  "Title": "et",
  "CreatedAt": "1995-12-28T11:10:53.5661841+01:00",
  "LastChanged": "1995-05-22T11:10:53.5661841+02:00",
  "ReadByOwner": "2001-02-18T11:10:53.5661841+01:00",
  "ReadByCustomer": "1996-11-24T11:10:53.5661841+01:00",
  "FirstReadByUser": "2002-03-29T11:10:53.5661841+01:00",
  "Activate": "2009-10-04T11:10:53.5661841+02:00",
  "ClosedAt": "2019-11-08T11:10:53.5661841+01:00",
  "RepliedAt": "2012-10-02T11:10:53.5661841+02:00",
  "AlertTimeout": "2005-12-16T11:10:53.5661841+01:00",
  "Deadline": "2003-10-28T11:10:53.5661841+01:00",
  "CreatedBy": null,
  "Author": "quibusdam",
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
      "PersonId": 947,
      "Mrmrs": "dignissimos",
      "Firstname": "Alejandra",
      "Lastname": "Russel",
      "MiddleName": "Hermiston, Moore and Veum",
      "Title": "consequuntur",
      "Description": "Pre-emptive explicit definition",
      "Email": "celestine.hilpert@mayer.co.uk",
      "FullName": "Dr. Jacinto Hahn",
      "DirectPhone": "1-395-021-9963 x02314",
      "FormalName": "Powlowski-Brakus",
      "CountryId": 202,
      "ContactId": 969,
      "ContactName": "Cummerata LLC",
      "Retired": 744,
      "Rank": 994,
      "ActiveInterests": 298,
      "ContactDepartment": "",
      "ContactCountryId": 139,
      "ContactOrgNr": "858389",
      "FaxPhone": "421.565.1551 x89231",
      "MobilePhone": "1-761-390-0473 x1786",
      "ContactPhone": "1-574-711-1990 x768",
      "AssociateName": "Predovic, Hoeger and Dicki",
      "AssociateId": 61,
      "UsePersonAddress": false,
      "ContactFax": "incidunt",
      "Kanafname": "sit",
      "Kanalname": "magni",
      "Post1": "accusamus",
      "Post2": "sed",
      "Post3": "non",
      "EmailName": "emily_considine@medhurstkrajcik.name",
      "ContactFullName": "Mr. Berenice Kuhic DVM",
      "ActiveErpLinks": 57,
      "TicketPriorityId": 72,
      "SupportLanguageId": 999,
      "SupportAssociateId": 714,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 913
        }
      }
    }
  ],
  "AlertLevel": 903,
  "ConnectId": 907,
  "ReadStatus": "Green",
  "TimeToReply": 249,
  "RealTimeToReply": 364,
  "TimeToClose": 553,
  "RealTimeToClose": 503,
  "TimeSpentInternally": 767,
  "TimeSpentExternally": 672,
  "TimeSpentQueue": 811,
  "RealTimeSpentInternally": 352,
  "RealTimeSpentExternally": 123,
  "RealTimeSpentQueue": 685,
  "HasAttachment": true,
  "NumReplies": 113,
  "NumMessages": 957,
  "FromAddress": "nulla",
  "Messages": [
    {
      "TicketMessageId": 912,
      "CreatedAt": "2019-12-28T11:10:53.5702129+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "sit",
      "PersonId": 936,
      "PersonFullName": "Mrs. Kathleen Ullrich III",
      "ContactId": 176,
      "ContactName": "Upton, Waelchi and McGlynn",
      "ContactDepartment": "deploy seamless niches",
      "NumAttachments": 388,
      "EmailHeader": "destany@boyerrussel.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "debitis",
      "Sentiment": 543,
      "SentimentConfidence": 773,
      "CreatedBy": 45,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 800
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 82,
      "Name": "Schaden, Yost and Spinka",
      "ToolTip": "Qui quia maiores nesciunt rerum sapiente expedita rem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 833
        }
      }
    },
    {
      "Id": 82,
      "Name": "Schaden, Yost and Spinka",
      "ToolTip": "Qui quia maiores nesciunt rerum sapiente expedita rem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 833
        }
      }
    }
  ],
  "Language": "ducimus",
  "Sentiment": 13,
  "SentimentConfidence": 97,
  "SuggestedCategoryId": 951,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 450,
  "IconHint": "dolores",
  "ExtraFields": {
    "ExtraFields1": "veniam",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "doloremque",
    "CustomFields2": "dolor"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 175
    }
  }
}
```
