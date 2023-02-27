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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketId": 106,
  "Title": "porro",
  "CreatedAt": "1998-02-22T14:19:10.8342293+01:00",
  "LastChanged": "2013-08-27T14:19:10.8342293+02:00",
  "ReadByOwner": "2005-12-25T14:19:10.8342293+01:00",
  "ReadByCustomer": "2010-08-19T14:19:10.8342293+02:00",
  "FirstReadByOwner": "1996-12-17T14:19:10.8342293+01:00",
  "FirstReadByUser": "2008-12-19T14:19:10.8342293+01:00",
  "Activate": "2013-02-15T14:19:10.8342293+01:00",
  "ClosedAt": "2021-04-15T14:19:10.8342293+02:00",
  "RepliedAt": "1995-12-22T14:19:10.8342293+01:00",
  "AlertTimeout": "2016-10-17T14:19:10.8342293+02:00",
  "Deadline": "2021-07-14T14:19:10.8342293+02:00",
  "CreatedBy": null,
  "Author": "maxime",
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
      "Position": "ratione",
      "PersonId": 120,
      "Mrmrs": "dolorum",
      "Firstname": "Dorcas",
      "Lastname": "Kub",
      "MiddleName": "Jast-Hermann",
      "Title": "aliquid",
      "Description": "Re-engineered object-oriented orchestration",
      "Email": "bart@jenkins.com",
      "FullName": "Madeline Tillman",
      "DirectPhone": "886.938.5141 x5826",
      "FormalName": "Little-Spinka",
      "CountryId": 488,
      "ContactId": 57,
      "ContactName": "Pfannerstill-Connelly",
      "Retired": 247,
      "Rank": 193,
      "ActiveInterests": 976,
      "ContactDepartment": "",
      "ContactCountryId": 236,
      "ContactOrgNr": "686274",
      "FaxPhone": "955.793.1116",
      "MobilePhone": "220-412-5251",
      "ContactPhone": "1-007-054-3753",
      "AssociateName": "Tromp Group",
      "AssociateId": 618,
      "UsePersonAddress": false,
      "ContactFax": "distinctio",
      "Kanafname": "consequatur",
      "Kanalname": "aut",
      "Post1": "maxime",
      "Post2": "similique",
      "Post3": "eos",
      "EmailName": "mathias_kuphal@pacochaward.biz",
      "ContactFullName": "Prof. Dena Ernser III",
      "ActiveErpLinks": 689,
      "TicketPriorityId": 641,
      "SupportLanguageId": 971,
      "SupportAssociateId": 16,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 634,
  "ConnectId": 140,
  "ReadStatus": "Green",
  "TimeToReply": 306,
  "RealTimeToReply": 901,
  "TimeToClose": 381,
  "RealTimeToClose": 425,
  "TimeSpentInternally": 333,
  "TimeSpentExternally": 842,
  "TimeSpentQueue": 364,
  "RealTimeSpentInternally": 768,
  "RealTimeSpentExternally": 189,
  "RealTimeSpentQueue": 982,
  "HasAttachment": true,
  "NumReplies": 464,
  "NumMessages": 458,
  "FromAddress": "nam",
  "Messages": [
    {
      "TicketMessageId": 680,
      "CreatedAt": "2021-09-12T14:19:10.8342293+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "quis",
      "PersonId": 857,
      "PersonFullName": "Marley Littel",
      "ContactId": 724,
      "ContactName": "Schumm LLC",
      "ContactDepartment": "",
      "NumAttachments": 287,
      "EmailHeader": "janice_ullrich@krajcik.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "mollitia",
      "Sentiment": 632,
      "SentimentConfidence": 998,
      "CreatedBy": 706,
      "ChangedAt": "1998-01-14T14:19:10.8342293+01:00"
    }
  ],
  "Tags": [
    {
      "Id": 943,
      "Name": "Kulas, Johns and Lubowitz",
      "ToolTip": "Accusantium non."
    },
    {
      "Id": 943,
      "Name": "Kulas, Johns and Lubowitz",
      "ToolTip": "Accusantium non."
    }
  ],
  "Language": "impedit",
  "Sentiment": 219,
  "SentimentConfidence": 696,
  "SuggestedCategoryId": 438,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 136,
  "IconHint": "nisi",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "soluta",
    "ExtraFields2": "itaque"
  },
  "CustomFields": {
    "CustomFields1": "pariatur",
    "CustomFields2": "ea"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 361,
  "Title": "ullam",
  "CreatedAt": "1998-10-02T14:19:10.8342293+02:00",
  "LastChanged": "2005-01-27T14:19:10.8342293+01:00",
  "ReadByOwner": "1998-06-23T14:19:10.8342293+02:00",
  "ReadByCustomer": "2016-05-19T14:19:10.8342293+02:00",
  "FirstReadByOwner": "2020-04-21T14:19:10.8342293+02:00",
  "FirstReadByUser": "2021-09-13T14:19:10.8342293+02:00",
  "Activate": "2016-04-25T14:19:10.8342293+02:00",
  "ClosedAt": "2006-01-15T14:19:10.8342293+01:00",
  "RepliedAt": "2000-04-20T14:19:10.8342293+02:00",
  "AlertTimeout": "1996-12-05T14:19:10.8342293+01:00",
  "Deadline": "1999-05-17T14:19:10.8342293+02:00",
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
      "Position": "quis",
      "PersonId": 98,
      "Mrmrs": "et",
      "Firstname": "Carolyne",
      "Lastname": "Denesik",
      "MiddleName": "Bode Inc and Sons",
      "Title": "qui",
      "Description": "Profit-focused systematic array",
      "Email": "nova_stiedemann@mueller.us",
      "FullName": "Madisyn King",
      "DirectPhone": "1-267-062-7738 x7748",
      "FormalName": "Hodkiewicz, Hyatt and Veum",
      "CountryId": 961,
      "ContactId": 3,
      "ContactName": "Hodkiewicz-Sauer",
      "Retired": 978,
      "Rank": 786,
      "ActiveInterests": 59,
      "ContactDepartment": "",
      "ContactCountryId": 393,
      "ContactOrgNr": "756096",
      "FaxPhone": "1-433-495-0988",
      "MobilePhone": "540.715.8777 x96374",
      "ContactPhone": "1-451-118-3074 x502",
      "AssociateName": "Spinka-Mills",
      "AssociateId": 694,
      "UsePersonAddress": false,
      "ContactFax": "sit",
      "Kanafname": "mollitia",
      "Kanalname": "eius",
      "Post1": "repellat",
      "Post2": "commodi",
      "Post3": "tenetur",
      "EmailName": "viviane_hodkiewicz@donnelly.ca",
      "ContactFullName": "Bradly Ryan I",
      "ActiveErpLinks": 816,
      "TicketPriorityId": 109,
      "SupportLanguageId": 500,
      "SupportAssociateId": 1000,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 459
        }
      }
    }
  ],
  "AlertLevel": 159,
  "ConnectId": 304,
  "ReadStatus": "Green",
  "TimeToReply": 752,
  "RealTimeToReply": 758,
  "TimeToClose": 843,
  "RealTimeToClose": 726,
  "TimeSpentInternally": 591,
  "TimeSpentExternally": 94,
  "TimeSpentQueue": 127,
  "RealTimeSpentInternally": 464,
  "RealTimeSpentExternally": 221,
  "RealTimeSpentQueue": 88,
  "HasAttachment": true,
  "NumReplies": 942,
  "NumMessages": 912,
  "FromAddress": "qui",
  "Messages": [
    {
      "TicketMessageId": 364,
      "CreatedAt": "2007-03-04T14:19:10.8498543+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "esse",
      "PersonId": 948,
      "PersonFullName": "Susan Farrell",
      "ContactId": 113,
      "ContactName": "Braun-Stehr",
      "ContactDepartment": "",
      "NumAttachments": 892,
      "EmailHeader": "karine.boehm@rohan.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quis",
      "Sentiment": 401,
      "SentimentConfidence": 492,
      "CreatedBy": 587,
      "ChangedAt": "2011-09-10T14:19:10.8498543+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 602
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 287,
      "Name": "Bosco-Bashirian",
      "ToolTip": "Voluptas sint aliquid cum exercitationem accusantium excepturi dignissimos.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 311
        }
      }
    },
    {
      "Id": 287,
      "Name": "Bosco-Bashirian",
      "ToolTip": "Voluptas sint aliquid cum exercitationem accusantium excepturi dignissimos.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 311
        }
      }
    }
  ],
  "Language": "dicta",
  "Sentiment": 657,
  "SentimentConfidence": 49,
  "SuggestedCategoryId": 350,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 967,
  "IconHint": "quo",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "recusandae",
    "ExtraFields2": "culpa"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "iure"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 644
    }
  }
}
```