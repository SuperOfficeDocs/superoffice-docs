---
title: GET Ticket/default
uid: v1TicketEntity_DefaultTicketEntity
---

# GET Ticket/default

```http
GET /api/v1/Ticket/default
```

Set default values into a new TicketEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Ticket agent service CreateDefaultTicketEntity.







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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/Ticket/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 657,
  "Title": "odio",
  "CreatedAt": "2003-06-29T12:15:27.4196336+02:00",
  "LastChanged": "2003-10-30T12:15:27.4196336+01:00",
  "ReadByOwner": "2011-10-23T12:15:27.4196336+02:00",
  "ReadByCustomer": "2002-10-14T12:15:27.4196336+02:00",
  "FirstReadByOwner": "2009-08-28T12:15:27.4196336+02:00",
  "FirstReadByUser": "2004-08-10T12:15:27.4196336+02:00",
  "Activate": "2016-12-27T12:15:27.4196336+01:00",
  "ClosedAt": "2022-08-21T12:15:27.4196336+02:00",
  "RepliedAt": "2003-06-30T12:15:27.4196336+02:00",
  "AlertTimeout": "2019-08-22T12:15:27.4196336+02:00",
  "Deadline": "2013-02-04T12:15:27.4196336+01:00",
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
      "Position": "natus",
      "PersonId": 580,
      "Mrmrs": "ut",
      "Firstname": "Tania",
      "Lastname": "Mueller",
      "MiddleName": "Lang-Simonis",
      "Title": "velit",
      "Description": "Assimilated national attitude",
      "Email": "elinore@vandervort.biz",
      "FullName": "Jayme Christiansen",
      "DirectPhone": "(317)478-2259",
      "FormalName": "Blick, Halvorson and Halvorson",
      "CountryId": 596,
      "ContactId": 799,
      "ContactName": "Bergstrom, Murphy and Mitchell",
      "Retired": 629,
      "Rank": 36,
      "ActiveInterests": 289,
      "ContactDepartment": "benchmark revolutionary e-tailers",
      "ContactCountryId": 506,
      "ContactOrgNr": "1040559",
      "FaxPhone": "693-787-7317 x4764",
      "MobilePhone": "1-796-388-4833",
      "ContactPhone": "1-069-456-1878 x1086",
      "AssociateName": "Greenholt-Hansen",
      "AssociateId": 162,
      "UsePersonAddress": false,
      "ContactFax": "magnam",
      "Kanafname": "et",
      "Kanalname": "dolorum",
      "Post1": "et",
      "Post2": "et",
      "Post3": "et",
      "EmailName": "carolina@wildermanfunk.uk",
      "ContactFullName": "Hermann Bruen",
      "ActiveErpLinks": 114,
      "TicketPriorityId": 434,
      "SupportLanguageId": 606,
      "SupportAssociateId": 120,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 28
        }
      }
    }
  ],
  "AlertLevel": 561,
  "ConnectId": 671,
  "ReadStatus": "Green",
  "TimeToReply": 618,
  "RealTimeToReply": 165,
  "TimeToClose": 981,
  "RealTimeToClose": 14,
  "TimeSpentInternally": 508,
  "TimeSpentExternally": 178,
  "TimeSpentQueue": 498,
  "RealTimeSpentInternally": 637,
  "RealTimeSpentExternally": 157,
  "RealTimeSpentQueue": 509,
  "HasAttachment": false,
  "NumReplies": 478,
  "NumMessages": 792,
  "FromAddress": "pariatur",
  "Messages": [
    {
      "TicketMessageId": 77,
      "CreatedAt": "2020-09-15T12:15:27.4246289+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "non",
      "PersonId": 529,
      "PersonFullName": "Nelda Reinger",
      "ContactId": 806,
      "ContactName": "Donnelly LLC",
      "ContactDepartment": "",
      "NumAttachments": 999,
      "EmailHeader": "beatrice_hettinger@mante.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "dolores",
      "Sentiment": 801,
      "SentimentConfidence": 708,
      "CreatedBy": 83,
      "ChangedAt": "2012-05-31T12:15:27.4246289+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 663
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 897,
      "Name": "McClure, Gutkowski and Kling",
      "ToolTip": "Velit dicta quaerat perspiciatis non voluptatem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 432
        }
      }
    },
    {
      "Id": 897,
      "Name": "McClure, Gutkowski and Kling",
      "ToolTip": "Velit dicta quaerat perspiciatis non voluptatem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 432
        }
      }
    }
  ],
  "Language": "quia",
  "Sentiment": 260,
  "SentimentConfidence": 913,
  "SuggestedCategoryId": 563,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 353,
  "IconHint": "repudiandae",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "numquam",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 209
    }
  }
}
```