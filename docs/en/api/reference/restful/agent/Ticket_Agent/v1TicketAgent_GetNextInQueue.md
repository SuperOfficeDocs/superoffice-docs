---
title: POST Agents/Ticket/GetNextInQueue
uid: v1TicketAgent_GetNextInQueue
---

# POST Agents/Ticket/GetNextInQueue

```http
POST /api/v1/Agents/Ticket/GetNextInQueue
```

Assign a ticket to the caller based on intelligent queue system







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetNextInQueue?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
POST /api/v1/Agents/Ticket/GetNextInQueue
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 398,
  "Title": "mollitia",
  "CreatedAt": "1998-02-19T12:15:20.3827306+01:00",
  "LastChanged": "2011-04-21T12:15:20.3827306+02:00",
  "ReadByOwner": "2000-03-11T12:15:20.3827306+01:00",
  "ReadByCustomer": "2013-02-04T12:15:20.3827306+01:00",
  "FirstReadByOwner": "2010-02-26T12:15:20.3827306+01:00",
  "FirstReadByUser": "2013-12-28T12:15:20.3827306+01:00",
  "Activate": "2015-07-19T12:15:20.3827306+02:00",
  "ClosedAt": "2006-11-29T12:15:20.3827306+01:00",
  "RepliedAt": "2019-08-19T12:15:20.3827306+02:00",
  "AlertTimeout": "2011-03-10T12:15:20.3827306+01:00",
  "Deadline": "2016-06-10T12:15:20.3827306+02:00",
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
      "Position": "beatae",
      "PersonId": 903,
      "Mrmrs": "non",
      "Firstname": "Cyrus",
      "Lastname": "Ankunding",
      "MiddleName": "Williamson-Fisher",
      "Title": "sed",
      "Description": "Enterprise-wide modular capability",
      "Email": "audreanne_murphy@windler.ca",
      "FullName": "Ms. Dino Bins I",
      "DirectPhone": "649.359.2848 x4392",
      "FormalName": "Heidenreich, Paucek and Reichert",
      "CountryId": 972,
      "ContactId": 630,
      "ContactName": "Balistreri-Keebler",
      "Retired": 75,
      "Rank": 618,
      "ActiveInterests": 30,
      "ContactDepartment": "",
      "ContactCountryId": 375,
      "ContactOrgNr": "1699151",
      "FaxPhone": "1-273-788-2437",
      "MobilePhone": "(736)289-7324 x666",
      "ContactPhone": "1-712-764-6918 x50219",
      "AssociateName": "Kunze, Barrows and Jewess",
      "AssociateId": 30,
      "UsePersonAddress": false,
      "ContactFax": "aut",
      "Kanafname": "reprehenderit",
      "Kanalname": "cum",
      "Post1": "rem",
      "Post2": "aut",
      "Post3": "illum",
      "EmailName": "georgette@borerwalker.info",
      "ContactFullName": "Mrs. Fanny Jeanette Hermann Sr.",
      "ActiveErpLinks": 196,
      "TicketPriorityId": 685,
      "SupportLanguageId": 992,
      "SupportAssociateId": 678,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 179
        }
      }
    }
  ],
  "AlertLevel": 265,
  "ConnectId": 260,
  "ReadStatus": "Green",
  "TimeToReply": 277,
  "RealTimeToReply": 394,
  "TimeToClose": 243,
  "RealTimeToClose": 150,
  "TimeSpentInternally": 347,
  "TimeSpentExternally": 143,
  "TimeSpentQueue": 785,
  "RealTimeSpentInternally": 553,
  "RealTimeSpentExternally": 212,
  "RealTimeSpentQueue": 499,
  "HasAttachment": true,
  "NumReplies": 729,
  "NumMessages": 761,
  "FromAddress": "vero",
  "Messages": [
    {
      "TicketMessageId": 969,
      "CreatedAt": "2001-04-13T12:15:20.3877336+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "repellendus",
      "PersonId": 312,
      "PersonFullName": "Elyse Ebert",
      "ContactId": 16,
      "ContactName": "Willms, Dach and Gleason",
      "ContactDepartment": "",
      "NumAttachments": 686,
      "EmailHeader": "maegan@jewess.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "enim",
      "Sentiment": 539,
      "SentimentConfidence": 842,
      "CreatedBy": 598,
      "ChangedAt": "2016-05-30T12:15:20.3877336+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 236
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 672,
      "Name": "Waelchi LLC",
      "ToolTip": "Quidem rerum earum ipsum cumque.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 622
        }
      }
    },
    {
      "Id": 672,
      "Name": "Waelchi LLC",
      "ToolTip": "Quidem rerum earum ipsum cumque.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 622
        }
      }
    }
  ],
  "Language": "sit",
  "Sentiment": 456,
  "SentimentConfidence": 309,
  "SuggestedCategoryId": 872,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 531,
  "IconHint": "omnis",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "ipsa",
    "ExtraFields2": "nesciunt"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "dolorum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 706
    }
  }
}
```