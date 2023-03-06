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
  "TicketId": 858,
  "Title": "quas",
  "CreatedAt": "2019-06-28T14:19:10.8029779+02:00",
  "LastChanged": "2006-07-16T14:19:10.8029779+02:00",
  "ReadByOwner": "1999-10-26T14:19:10.8029779+02:00",
  "ReadByCustomer": "2009-01-26T14:19:10.8029779+01:00",
  "FirstReadByOwner": "2014-11-14T14:19:10.8029779+01:00",
  "FirstReadByUser": "2017-04-06T14:19:10.8029779+02:00",
  "Activate": "2004-04-05T14:19:10.8029779+02:00",
  "ClosedAt": "2004-06-13T14:19:10.8029779+02:00",
  "RepliedAt": "2018-12-20T14:19:10.8029779+01:00",
  "AlertTimeout": "2014-07-18T14:19:10.8029779+02:00",
  "Deadline": "2017-12-24T14:19:10.8029779+01:00",
  "CreatedBy": null,
  "Author": "eaque",
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
      "Position": "eum",
      "PersonId": 9,
      "Mrmrs": "veritatis",
      "Firstname": "Chance",
      "Lastname": "Sawayn",
      "MiddleName": "Bergstrom, Bauch and Ondricka",
      "Title": "illo",
      "Description": "Ameliorated homogeneous hierarchy",
      "Email": "woodrow@swift.com",
      "FullName": "Marie Denesik",
      "DirectPhone": "(017)152-2635 x81012",
      "FormalName": "Maggio-Ruecker",
      "CountryId": 491,
      "ContactId": 968,
      "ContactName": "Beatty, Baumbach and Moen",
      "Retired": 184,
      "Rank": 356,
      "ActiveInterests": 255,
      "ContactDepartment": "",
      "ContactCountryId": 249,
      "ContactOrgNr": "193183",
      "FaxPhone": "980.702.1866",
      "MobilePhone": "773.833.1195 x838",
      "ContactPhone": "(259)577-0499 x72089",
      "AssociateName": "Huel-Lehner",
      "AssociateId": 481,
      "UsePersonAddress": true,
      "ContactFax": "magni",
      "Kanafname": "earum",
      "Kanalname": "culpa",
      "Post1": "velit",
      "Post2": "pariatur",
      "Post3": "est",
      "EmailName": "israel_labadie@hermannlangosh.biz",
      "ContactFullName": "Rudy Huel",
      "ActiveErpLinks": 416,
      "TicketPriorityId": 717,
      "SupportLanguageId": 260,
      "SupportAssociateId": 932,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 840
        }
      }
    }
  ],
  "AlertLevel": 506,
  "ConnectId": 826,
  "ReadStatus": "Green",
  "TimeToReply": 653,
  "RealTimeToReply": 960,
  "TimeToClose": 892,
  "RealTimeToClose": 366,
  "TimeSpentInternally": 282,
  "TimeSpentExternally": 882,
  "TimeSpentQueue": 371,
  "RealTimeSpentInternally": 873,
  "RealTimeSpentExternally": 894,
  "RealTimeSpentQueue": 228,
  "HasAttachment": false,
  "NumReplies": 657,
  "NumMessages": 824,
  "FromAddress": "sapiente",
  "Messages": [
    {
      "TicketMessageId": 692,
      "CreatedAt": "2019-07-16T14:19:10.8029779+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "delectus",
      "PersonId": 692,
      "PersonFullName": "Prof. Marquis Letitia Yundt II",
      "ContactId": 865,
      "ContactName": "Considine Group",
      "ContactDepartment": "",
      "NumAttachments": 731,
      "EmailHeader": "miller.weimann@greenholtklocko.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "non",
      "Sentiment": 704,
      "SentimentConfidence": 958,
      "CreatedBy": 591,
      "ChangedAt": "2007-11-08T14:19:10.8029779+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 92
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 325,
      "Name": "Nitzsche, Gerlach and Zieme",
      "ToolTip": "Nihil vitae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 140
        }
      }
    },
    {
      "Id": 325,
      "Name": "Nitzsche, Gerlach and Zieme",
      "ToolTip": "Nihil vitae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 140
        }
      }
    }
  ],
  "Language": "quia",
  "Sentiment": 530,
  "SentimentConfidence": 814,
  "SuggestedCategoryId": 297,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 328,
  "IconHint": "impedit",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "repellendus",
    "ExtraFields2": "natus"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 260
    }
  }
}
```