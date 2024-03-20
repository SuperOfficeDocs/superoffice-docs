---
title: GET Ticket/default
uid: v1TicketEntity_DefaultTicketEntity
generated: true
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
  "TicketId": 143,
  "Title": "sit",
  "CreatedAt": "2024-03-12T12:19:53.9460405+01:00",
  "LastChanged": "2018-07-23T12:19:53.9460405+02:00",
  "ReadByOwner": "2020-09-06T12:19:53.9460405+02:00",
  "ReadByCustomer": "2023-03-23T12:19:53.9460405+01:00",
  "FirstReadByOwner": "2019-12-01T12:19:53.9460405+01:00",
  "FirstReadByUser": "2017-10-21T12:19:53.9460405+02:00",
  "Activate": "2021-09-25T12:19:53.9460405+02:00",
  "ClosedAt": "2018-03-31T12:19:53.9460405+02:00",
  "RepliedAt": "2011-09-04T12:19:53.9460405+02:00",
  "AlertTimeout": "2009-09-06T12:19:53.9460405+02:00",
  "Deadline": "2003-01-25T12:19:53.9460405+01:00",
  "CreatedBy": null,
  "Author": "veniam",
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
      "Position": "expedita",
      "PersonId": 979,
      "Mrmrs": "corrupti",
      "Firstname": "Destini",
      "Lastname": "Hickle",
      "MiddleName": "Konopelski-Stiedemann",
      "Title": "incidunt",
      "Description": "Profit-focused national project",
      "Email": "constantin_rippin@padberg.biz",
      "FullName": "Elouise Marks",
      "DirectPhone": "885-073-3381",
      "FormalName": "Monahan, Leannon and Conroy",
      "CountryId": 6,
      "ContactId": 289,
      "ContactName": "Fadel-Hahn",
      "Retired": 343,
      "Rank": 28,
      "ActiveInterests": 14,
      "ContactDepartment": "",
      "ContactCountryId": 151,
      "ContactOrgNr": "914911",
      "FaxPhone": "1-748-594-4764",
      "MobilePhone": "949-607-1274 x692",
      "ContactPhone": "431.416.8131",
      "AssociateName": "Huel, Grimes and Mosciski",
      "AssociateId": 743,
      "UsePersonAddress": true,
      "ContactFax": "quo",
      "Kanafname": "itaque",
      "Kanalname": "eum",
      "Post1": "id",
      "Post2": "voluptatibus",
      "Post3": "voluptas",
      "EmailName": "trever@schamberger.uk",
      "ContactFullName": "Mrs. Jedediah Holly Wisozk",
      "ActiveErpLinks": 151,
      "TicketPriorityId": 144,
      "SupportLanguageId": 156,
      "SupportAssociateId": 86,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 457
        }
      }
    }
  ],
  "AlertLevel": 722,
  "ConnectId": 750,
  "ReadStatus": "Green",
  "TimeToReply": 628,
  "RealTimeToReply": 153,
  "TimeToClose": 418,
  "RealTimeToClose": 479,
  "TimeSpentInternally": 326,
  "TimeSpentExternally": 443,
  "TimeSpentQueue": 451,
  "RealTimeSpentInternally": 702,
  "RealTimeSpentExternally": 806,
  "RealTimeSpentQueue": 581,
  "TimeSpent": 897,
  "HasAttachment": false,
  "NumReplies": 336,
  "NumMessages": 666,
  "FromAddress": "ut",
  "Messages": [
    {
      "TicketMessageId": 638,
      "CreatedAt": "2004-07-30T12:19:53.9616602+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "illo",
      "PersonId": 482,
      "PersonFullName": "Dr. Stephanie Nettie Yundt DDS",
      "ContactId": 103,
      "ContactName": "Cruickshank Group",
      "ContactDepartment": "",
      "NumAttachments": 83,
      "EmailHeader": "anabel@hagenes.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "veritatis",
      "Sentiment": 891,
      "SentimentConfidence": 183,
      "CreatedBy": 620,
      "ChangedAt": "1998-02-17T12:19:53.9616602+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 791
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 975,
      "Name": "Stark-Sanford",
      "ToolTip": "Beatae mollitia fuga qui ipsa corrupti minima ipsum.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 593
        }
      }
    },
    {
      "Id": 975,
      "Name": "Stark-Sanford",
      "ToolTip": "Beatae mollitia fuga qui ipsa corrupti minima ipsum.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 593
        }
      }
    }
  ],
  "Language": "a",
  "Sentiment": 374,
  "SentimentConfidence": 685,
  "SuggestedCategoryId": 490,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 677,
  "IconHint": "animi",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 805,
  "ExtraFields": {
    "ExtraFields1": "non",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "odit",
    "CustomFields2": "sunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 616
    }
  }
}
```