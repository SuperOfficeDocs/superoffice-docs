---
title: POST Agents/Ticket/SaveTicketEntity
uid: v1TicketAgent_SaveTicketEntity
---

# POST Agents/Ticket/SaveTicketEntity

```http
POST /api/v1/Agents/Ticket/SaveTicketEntity
```

Updates the existing TicketEntity or creates a new TicketEntity if the id parameter is empty








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

The TicketEntity to be saved. 

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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Ticket/SaveTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 839,
  "Title": "quidem",
  "CreatedAt": "2015-12-26T11:22:39.3988363+01:00",
  "LastChanged": "1998-12-30T11:22:39.3988363+01:00",
  "ReadByOwner": "2005-12-04T11:22:39.3988363+01:00",
  "ReadByCustomer": "2014-04-09T11:22:39.3988363+02:00",
  "FirstReadByOwner": "2020-03-14T11:22:39.3988363+01:00",
  "FirstReadByUser": "1997-11-25T11:22:39.3988363+01:00",
  "Activate": "2016-04-03T11:22:39.3988363+02:00",
  "ClosedAt": "1996-06-04T11:22:39.3988363+02:00",
  "RepliedAt": "2000-06-02T11:22:39.3988363+02:00",
  "AlertTimeout": "2003-01-07T11:22:39.3988363+01:00",
  "Deadline": "2010-07-01T11:22:39.3988363+02:00",
  "CreatedBy": null,
  "Author": "repudiandae",
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
      "Position": "doloribus",
      "PersonId": 147,
      "Mrmrs": "et",
      "Firstname": "Brant",
      "Lastname": "Abernathy",
      "MiddleName": "Bergstrom Group",
      "Title": "sed",
      "Description": "Ergonomic user-facing support",
      "Email": "jonatan@willms.name",
      "FullName": "Christina Hammes",
      "DirectPhone": "809-303-0340",
      "FormalName": "Hessel, Beer and Schinner",
      "CountryId": 830,
      "ContactId": 154,
      "ContactName": "Morissette, Daugherty and Gottlieb",
      "Retired": 975,
      "Rank": 487,
      "ActiveInterests": 988,
      "ContactDepartment": "architect compelling architectures",
      "ContactCountryId": 781,
      "ContactOrgNr": "429203",
      "FaxPhone": "701-429-1978 x4154",
      "MobilePhone": "1-945-868-8357 x979",
      "ContactPhone": "147.992.2528 x457",
      "AssociateName": "Blick Inc and Sons",
      "AssociateId": 459,
      "UsePersonAddress": false,
      "ContactFax": "libero",
      "Kanafname": "similique",
      "Kanalname": "voluptate",
      "Post1": "quis",
      "Post2": "excepturi",
      "Post3": "cum",
      "EmailName": "hilma_ebert@crooks.co.uk",
      "ContactFullName": "Ms. Dewitt Maggio Sr.",
      "ActiveErpLinks": 539,
      "TicketPriorityId": 890,
      "SupportLanguageId": 498,
      "SupportAssociateId": 493,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 664,
  "ConnectId": 943,
  "ReadStatus": "Green",
  "TimeToReply": 475,
  "RealTimeToReply": 362,
  "TimeToClose": 793,
  "RealTimeToClose": 410,
  "TimeSpentInternally": 966,
  "TimeSpentExternally": 748,
  "TimeSpentQueue": 228,
  "RealTimeSpentInternally": 624,
  "RealTimeSpentExternally": 87,
  "RealTimeSpentQueue": 965,
  "HasAttachment": false,
  "NumReplies": 766,
  "NumMessages": 706,
  "FromAddress": "molestiae",
  "Messages": [
    {
      "TicketMessageId": 786,
      "CreatedAt": "2006-01-12T11:22:39.3988363+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "sit",
      "PersonId": 855,
      "PersonFullName": "Vilma Predovic",
      "ContactId": 65,
      "ContactName": "Grant, Funk and O'Conner",
      "ContactDepartment": "",
      "NumAttachments": 895,
      "EmailHeader": "brandi@klocko.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "animi",
      "Sentiment": 859,
      "SentimentConfidence": 74,
      "CreatedBy": 49,
      "ChangedAt": "2002-10-12T11:22:39.3988363+02:00"
    }
  ],
  "Tags": [
    {
      "Id": 164,
      "Name": "Gorczany LLC",
      "ToolTip": "Vel voluptatem est et aut quisquam pariatur."
    },
    {
      "Id": 164,
      "Name": "Gorczany LLC",
      "ToolTip": "Vel voluptatem est et aut quisquam pariatur."
    }
  ],
  "Language": "modi",
  "Sentiment": 411,
  "SentimentConfidence": 762,
  "SuggestedCategoryId": 683,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 428,
  "IconHint": "et",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "delectus",
    "ExtraFields2": "aspernatur"
  },
  "CustomFields": {
    "CustomFields1": "nam",
    "CustomFields2": "ipsa"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 397,
  "Title": "ut",
  "CreatedAt": "1996-09-21T11:22:39.3988363+02:00",
  "LastChanged": "2017-01-25T11:22:39.3988363+01:00",
  "ReadByOwner": "2013-12-26T11:22:39.3988363+01:00",
  "ReadByCustomer": "2009-05-10T11:22:39.3988363+02:00",
  "FirstReadByOwner": "2021-02-12T11:22:39.3988363+01:00",
  "FirstReadByUser": "1996-04-14T11:22:39.3988363+02:00",
  "Activate": "1999-04-18T11:22:39.3988363+02:00",
  "ClosedAt": "2004-06-07T11:22:39.3988363+02:00",
  "RepliedAt": "2002-12-21T11:22:39.3988363+01:00",
  "AlertTimeout": "2002-09-30T11:22:39.3988363+02:00",
  "Deadline": "2017-03-16T11:22:39.3988363+01:00",
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
      "Position": "pariatur",
      "PersonId": 415,
      "Mrmrs": "esse",
      "Firstname": "Jimmie",
      "Lastname": "Brekke",
      "MiddleName": "Batz Inc and Sons",
      "Title": "sequi",
      "Description": "Enhanced multi-state portal",
      "Email": "nora@mayert.us",
      "FullName": "Ms. Eda Lukas Bernhard II",
      "DirectPhone": "(288)705-3644 x0097",
      "FormalName": "Koepp-Huel",
      "CountryId": 88,
      "ContactId": 354,
      "ContactName": "Herman LLC",
      "Retired": 336,
      "Rank": 557,
      "ActiveInterests": 551,
      "ContactDepartment": "",
      "ContactCountryId": 158,
      "ContactOrgNr": "1272715",
      "FaxPhone": "569.621.7889 x54939",
      "MobilePhone": "438.777.8733",
      "ContactPhone": "1-862-094-6961 x4727",
      "AssociateName": "Koss-Schneider",
      "AssociateId": 530,
      "UsePersonAddress": false,
      "ContactFax": "reprehenderit",
      "Kanafname": "eum",
      "Kanalname": "voluptatibus",
      "Post1": "animi",
      "Post2": "atque",
      "Post3": "nihil",
      "EmailName": "will.nader@bogisich.us",
      "ContactFullName": "Orlando Hamill",
      "ActiveErpLinks": 105,
      "TicketPriorityId": 462,
      "SupportLanguageId": 881,
      "SupportAssociateId": 90,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 960
        }
      }
    }
  ],
  "AlertLevel": 274,
  "ConnectId": 918,
  "ReadStatus": "Green",
  "TimeToReply": 270,
  "RealTimeToReply": 516,
  "TimeToClose": 957,
  "RealTimeToClose": 821,
  "TimeSpentInternally": 791,
  "TimeSpentExternally": 529,
  "TimeSpentQueue": 157,
  "RealTimeSpentInternally": 974,
  "RealTimeSpentExternally": 444,
  "RealTimeSpentQueue": 284,
  "HasAttachment": true,
  "NumReplies": 153,
  "NumMessages": 110,
  "FromAddress": "inventore",
  "Messages": [
    {
      "TicketMessageId": 34,
      "CreatedAt": "2003-06-10T11:22:39.3988363+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "minus",
      "PersonId": 502,
      "PersonFullName": "Johnnie Bradtke I",
      "ContactId": 390,
      "ContactName": "O'Reilly LLC",
      "ContactDepartment": "",
      "NumAttachments": 601,
      "EmailHeader": "zelda_doyle@murazikgleason.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "eveniet",
      "Sentiment": 958,
      "SentimentConfidence": 761,
      "CreatedBy": 799,
      "ChangedAt": "2004-12-22T11:22:39.3988363+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 562
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 266,
      "Name": "Rau, Altenwerth and Greenfelder",
      "ToolTip": "Eum eaque deleniti.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 398
        }
      }
    },
    {
      "Id": 266,
      "Name": "Rau, Altenwerth and Greenfelder",
      "ToolTip": "Eum eaque deleniti.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 398
        }
      }
    }
  ],
  "Language": "asperiores",
  "Sentiment": 784,
  "SentimentConfidence": 331,
  "SuggestedCategoryId": 786,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 998,
  "IconHint": "ut",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "consequuntur"
  },
  "CustomFields": {
    "CustomFields1": "corporis",
    "CustomFields2": "sapiente"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 768
    }
  }
}
```