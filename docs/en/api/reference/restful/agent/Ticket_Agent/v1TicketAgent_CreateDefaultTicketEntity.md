---
title: POST Agents/Ticket/CreateDefaultTicketEntity
uid: v1TicketAgent_CreateDefaultTicketEntity
generated: true
content_type: reference
---

# POST Agents/Ticket/CreateDefaultTicketEntity

```http
POST /api/v1/Agents/Ticket/CreateDefaultTicketEntity
```

Loading default values into a new TicketEntity.


NsApiSlow threshold: 2000 ms.







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
POST /api/v1/Agents/Ticket/CreateDefaultTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 314,
  "Title": "doloremque",
  "CreatedAt": "2005-08-13T03:40:47.9223542+02:00",
  "LastChanged": "2009-03-02T03:40:47.9223542+01:00",
  "ReadByOwner": "2016-04-06T03:40:47.9223542+02:00",
  "ReadByCustomer": "2010-05-10T03:40:47.9223542+02:00",
  "FirstReadByOwner": "2003-09-20T03:40:47.9223542+02:00",
  "FirstReadByUser": "2007-04-24T03:40:47.9223542+02:00",
  "Activate": "2001-06-06T03:40:47.9223542+02:00",
  "ClosedAt": "2005-12-10T03:40:47.9223542+01:00",
  "RepliedAt": "2021-06-01T03:40:47.9223542+02:00",
  "AlertTimeout": "2007-12-05T03:40:47.9223542+01:00",
  "Deadline": "2017-01-01T03:40:47.9223542+01:00",
  "CreatedBy": null,
  "Author": "dolorem",
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
      "Position": "sequi",
      "PersonId": 518,
      "Mrmrs": "ratione",
      "Firstname": "Bernhard",
      "Lastname": "Reichel",
      "MiddleName": "Lindgren-Sporer",
      "Title": "voluptatem",
      "Description": "Automated tertiary product",
      "Email": "thaddeus@daughertykuhlman.com",
      "FullName": "Mrs. Danny Lockman",
      "DirectPhone": "1-003-106-1636 x463",
      "FormalName": "Hickle-Walker",
      "CountryId": 593,
      "ContactId": 135,
      "ContactName": "Hills, Padberg and Hoppe",
      "Retired": 272,
      "Rank": 463,
      "ActiveInterests": 188,
      "ContactDepartment": "redefine one-to-one e-commerce",
      "ContactCountryId": 484,
      "ContactOrgNr": "963196",
      "FaxPhone": "(051)759-5248 x4620",
      "MobilePhone": "(646)350-5135 x7117",
      "ContactPhone": "(624)563-3309 x61756",
      "AssociateName": "Bradtke-Rath",
      "AssociateId": 360,
      "UsePersonAddress": false,
      "ContactFax": "ut",
      "Kanafname": "asperiores",
      "Kanalname": "dolores",
      "Post1": "corporis",
      "Post2": "aliquam",
      "Post3": "sed",
      "EmailName": "parker@mann.us",
      "ContactFullName": "Sallie Cormier",
      "ActiveErpLinks": 737,
      "TicketPriorityId": 842,
      "SupportLanguageId": 732,
      "SupportAssociateId": 746,
      "CategoryName": "VIP Customer",
      "PersonNumber": "633490",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 75
        }
      }
    }
  ],
  "AlertLevel": 893,
  "ConnectId": 269,
  "ReadStatus": "Green",
  "TimeToReply": 514,
  "RealTimeToReply": 408,
  "TimeToClose": 97,
  "RealTimeToClose": 541,
  "TimeSpentInternally": 427,
  "TimeSpentExternally": 802,
  "TimeSpentQueue": 505,
  "RealTimeSpentInternally": 738,
  "RealTimeSpentExternally": 825,
  "RealTimeSpentQueue": 232,
  "TimeSpent": 231,
  "HasAttachment": true,
  "NumReplies": 400,
  "NumMessages": 201,
  "FromAddress": "totam",
  "Messages": [
    {
      "TicketMessageId": 573,
      "CreatedAt": "2022-09-01T03:40:47.9223542+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "et",
      "PersonId": 426,
      "PersonFullName": "Miss Katarina Graham",
      "ContactId": 84,
      "ContactName": "Deckow, Turcotte and Ullrich",
      "ContactDepartment": "",
      "NumAttachments": 832,
      "EmailHeader": "katrina@grimesschinner.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "et",
      "Sentiment": 706,
      "SentimentConfidence": 191,
      "CreatedBy": 887,
      "ChangedAt": "2010-08-07T03:40:47.9223542+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 301
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 148,
      "Name": "Jacobson LLC",
      "ToolTip": "Dicta quis ut iusto.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 809
        }
      }
    },
    {
      "Id": 148,
      "Name": "Jacobson LLC",
      "ToolTip": "Dicta quis ut iusto.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 809
        }
      }
    }
  ],
  "Language": "sed",
  "Sentiment": 165,
  "SentimentConfidence": 984,
  "SuggestedCategoryId": 759,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 726,
  "IconHint": "quam",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 232,
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "numquam"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "explicabo"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 611
    }
  }
}
```