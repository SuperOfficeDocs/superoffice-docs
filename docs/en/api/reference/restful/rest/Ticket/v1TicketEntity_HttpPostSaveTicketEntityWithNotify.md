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
POST /api/v1/Ticket?notify=True
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
POST /api/v1/Ticket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 332,
  "Title": "eaque",
  "CreatedAt": "2008-12-29T12:15:27.4276288+01:00",
  "LastChanged": "2020-01-31T12:15:27.4276288+01:00",
  "ReadByOwner": "2021-08-27T12:15:27.4276288+02:00",
  "ReadByCustomer": "2014-06-13T12:15:27.4276288+02:00",
  "FirstReadByOwner": "2014-12-31T12:15:27.4276288+01:00",
  "FirstReadByUser": "2018-06-27T12:15:27.4276288+02:00",
  "Activate": "2019-05-12T12:15:27.4276288+02:00",
  "ClosedAt": "2013-08-12T12:15:27.4276288+02:00",
  "RepliedAt": "2015-02-15T12:15:27.4276288+01:00",
  "AlertTimeout": "2010-04-03T12:15:27.4276288+02:00",
  "Deadline": "2019-08-03T12:15:27.4276288+02:00",
  "CreatedBy": null,
  "Author": "alias",
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
      "PersonId": 335,
      "Mrmrs": "nesciunt",
      "Firstname": "Kiana",
      "Lastname": "Pollich",
      "MiddleName": "Zieme Inc and Sons",
      "Title": "aut",
      "Description": "User-friendly disintermediate artificial intelligence",
      "Email": "braeden@cremin.uk",
      "FullName": "Yessenia Luna Krajcik DVM",
      "DirectPhone": "172.147.8948 x4203",
      "FormalName": "Wuckert, Klein and Bergstrom",
      "CountryId": 779,
      "ContactId": 192,
      "ContactName": "Spencer-Jenkins",
      "Retired": 963,
      "Rank": 650,
      "ActiveInterests": 245,
      "ContactDepartment": "",
      "ContactCountryId": 71,
      "ContactOrgNr": "880983",
      "FaxPhone": "(813)079-3530 x40132",
      "MobilePhone": "(252)964-2952",
      "ContactPhone": "1-686-826-9531 x498",
      "AssociateName": "Stokes Inc and Sons",
      "AssociateId": 552,
      "UsePersonAddress": false,
      "ContactFax": "impedit",
      "Kanafname": "aut",
      "Kanalname": "itaque",
      "Post1": "voluptates",
      "Post2": "adipisci",
      "Post3": "aut",
      "EmailName": "ludie@mcclure.com",
      "ContactFullName": "Miss Vida Lorna Denesik Jr.",
      "ActiveErpLinks": 379,
      "TicketPriorityId": 703,
      "SupportLanguageId": 235,
      "SupportAssociateId": 788,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 178,
  "ConnectId": 955,
  "ReadStatus": "Green",
  "TimeToReply": 196,
  "RealTimeToReply": 595,
  "TimeToClose": 695,
  "RealTimeToClose": 946,
  "TimeSpentInternally": 894,
  "TimeSpentExternally": 905,
  "TimeSpentQueue": 126,
  "RealTimeSpentInternally": 580,
  "RealTimeSpentExternally": 638,
  "RealTimeSpentQueue": 78,
  "HasAttachment": true,
  "NumReplies": 823,
  "NumMessages": 425,
  "FromAddress": "repudiandae",
  "Messages": [
    {
      "TicketMessageId": 210,
      "CreatedAt": "2012-07-06T12:15:27.4336287+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "sed",
      "PersonId": 443,
      "PersonFullName": "Ted Brown",
      "ContactId": 98,
      "ContactName": "Bradtke-Schmeler",
      "ContactDepartment": "",
      "NumAttachments": 715,
      "EmailHeader": "sarina.nicolas@langosh.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "blanditiis",
      "Sentiment": 219,
      "SentimentConfidence": 852,
      "CreatedBy": 826,
      "ChangedAt": "2014-12-16T12:15:27.4356263+01:00"
    }
  ],
  "Tags": [
    {
      "Id": 895,
      "Name": "Tromp, Nolan and Boyle",
      "ToolTip": "Non consequuntur dolores iste sit excepturi esse."
    },
    {
      "Id": 895,
      "Name": "Tromp, Nolan and Boyle",
      "ToolTip": "Non consequuntur dolores iste sit excepturi esse."
    }
  ],
  "Language": "nihil",
  "Sentiment": 874,
  "SentimentConfidence": 53,
  "SuggestedCategoryId": 80,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 454,
  "IconHint": "voluptas",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "molestias",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "velit"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 966,
  "Title": "commodi",
  "CreatedAt": "2017-11-15T12:15:27.4436293+01:00",
  "LastChanged": "2008-05-17T12:15:27.4436293+02:00",
  "ReadByOwner": "2008-03-18T12:15:27.4436293+01:00",
  "ReadByCustomer": "2021-11-11T12:15:27.4436293+01:00",
  "FirstReadByOwner": "2003-08-09T12:15:27.4436293+02:00",
  "FirstReadByUser": "2015-05-08T12:15:27.4436293+02:00",
  "Activate": "1998-09-07T12:15:27.4436293+02:00",
  "ClosedAt": "2022-11-10T12:15:27.4436293+01:00",
  "RepliedAt": "2008-03-16T12:15:27.4436293+01:00",
  "AlertTimeout": "2013-10-07T12:15:27.4436293+02:00",
  "Deadline": "1999-05-30T12:15:27.4436293+02:00",
  "CreatedBy": null,
  "Author": "expedita",
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
      "Position": "hic",
      "PersonId": 268,
      "Mrmrs": "voluptatem",
      "Firstname": "Isaac",
      "Lastname": "Green",
      "MiddleName": "Rogahn, Shields and Schaden",
      "Title": "quod",
      "Description": "Ergonomic bottom-line middleware",
      "Email": "tara_beer@rice.com",
      "FullName": "Dr. Ole Kraig Kozey Jr.",
      "DirectPhone": "(523)809-4902 x1855",
      "FormalName": "Batz Group",
      "CountryId": 819,
      "ContactId": 634,
      "ContactName": "Reinger LLC",
      "Retired": 389,
      "Rank": 89,
      "ActiveInterests": 645,
      "ContactDepartment": "",
      "ContactCountryId": 649,
      "ContactOrgNr": "1155549",
      "FaxPhone": "494-105-9306",
      "MobilePhone": "942.170.3509 x5798",
      "ContactPhone": "1-869-052-7485 x82014",
      "AssociateName": "Lockman-Aufderhar",
      "AssociateId": 915,
      "UsePersonAddress": true,
      "ContactFax": "sit",
      "Kanafname": "ut",
      "Kanalname": "sed",
      "Post1": "sed",
      "Post2": "reiciendis",
      "Post3": "voluptatem",
      "EmailName": "ally@bogisich.name",
      "ContactFullName": "Ora Walter",
      "ActiveErpLinks": 955,
      "TicketPriorityId": 600,
      "SupportLanguageId": 85,
      "SupportAssociateId": 450,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 150
        }
      }
    }
  ],
  "AlertLevel": 156,
  "ConnectId": 206,
  "ReadStatus": "Green",
  "TimeToReply": 225,
  "RealTimeToReply": 34,
  "TimeToClose": 232,
  "RealTimeToClose": 821,
  "TimeSpentInternally": 42,
  "TimeSpentExternally": 258,
  "TimeSpentQueue": 412,
  "RealTimeSpentInternally": 20,
  "RealTimeSpentExternally": 211,
  "RealTimeSpentQueue": 968,
  "HasAttachment": false,
  "NumReplies": 193,
  "NumMessages": 913,
  "FromAddress": "quo",
  "Messages": [
    {
      "TicketMessageId": 101,
      "CreatedAt": "2009-06-21T12:15:27.4486285+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "voluptatem",
      "PersonId": 364,
      "PersonFullName": "Jerad Chesley Walter II",
      "ContactId": 877,
      "ContactName": "Gorczany, Harber and Witting",
      "ContactDepartment": "",
      "NumAttachments": 74,
      "EmailHeader": "henriette.mayer@doyle.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "inventore",
      "Sentiment": 3,
      "SentimentConfidence": 848,
      "CreatedBy": 891,
      "ChangedAt": "2009-05-01T12:15:27.4496307+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 69
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 460,
      "Name": "Shields, Littel and Zboncak",
      "ToolTip": "Placeat et maiores qui dolorum temporibus ut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 261
        }
      }
    },
    {
      "Id": 460,
      "Name": "Shields, Littel and Zboncak",
      "ToolTip": "Placeat et maiores qui dolorum temporibus ut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 261
        }
      }
    }
  ],
  "Language": "itaque",
  "Sentiment": 15,
  "SentimentConfidence": 471,
  "SuggestedCategoryId": 22,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 799,
  "IconHint": "quos",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "optio",
    "ExtraFields2": "tempore"
  },
  "CustomFields": {
    "CustomFields1": "nulla",
    "CustomFields2": "consectetur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 647
    }
  }
}
```