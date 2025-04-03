---
title: POST Agents/Ticket/CreateDefaultTicketEntity
uid: v1TicketAgent_CreateDefaultTicketEntity
generated: true
---

# POST Agents/Ticket/CreateDefaultTicketEntity

```http
POST /api/v1/Agents/Ticket/CreateDefaultTicketEntity
```

Set default values into a new TicketEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
  "TicketId": 403,
  "Title": "dignissimos",
  "CreatedAt": "2000-02-04T14:28:22.5553721+01:00",
  "LastChanged": "1998-02-22T14:28:22.5553721+01:00",
  "ReadByOwner": "2002-01-30T14:28:22.5553721+01:00",
  "ReadByCustomer": "2005-08-16T14:28:22.5553721+02:00",
  "FirstReadByOwner": "2011-10-04T14:28:22.5553721+02:00",
  "FirstReadByUser": "2015-01-02T14:28:22.5553721+01:00",
  "Activate": "2007-04-27T14:28:22.5553721+02:00",
  "ClosedAt": "2013-02-11T14:28:22.5553721+01:00",
  "RepliedAt": "2006-03-27T14:28:22.5553721+02:00",
  "AlertTimeout": "2001-05-24T14:28:22.5553721+02:00",
  "Deadline": "2017-02-01T14:28:22.5553721+01:00",
  "CreatedBy": null,
  "Author": "quas",
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
      "Position": "ab",
      "PersonId": 797,
      "Mrmrs": "est",
      "Firstname": "Holly",
      "Lastname": "Tromp",
      "MiddleName": "Koss, Hauck and Kunde",
      "Title": "nobis",
      "Description": "Focused human-resource hierarchy",
      "Email": "raymundo.bechtelar@gleasonhuel.uk",
      "FullName": "Miss Christian Hauck Sr.",
      "DirectPhone": "1-255-668-0362",
      "FormalName": "Kerluke-Turner",
      "CountryId": 692,
      "ContactId": 343,
      "ContactName": "Kshlerin-Lynch",
      "Retired": 461,
      "Rank": 302,
      "ActiveInterests": 829,
      "ContactDepartment": "",
      "ContactCountryId": 119,
      "ContactOrgNr": "1655691",
      "FaxPhone": "337-531-9655",
      "MobilePhone": "848.172.3082 x161",
      "ContactPhone": "318.938.2110",
      "AssociateName": "Roberts-Kassulke",
      "AssociateId": 753,
      "UsePersonAddress": true,
      "ContactFax": "accusamus",
      "Kanafname": "cum",
      "Kanalname": "quod",
      "Post1": "sit",
      "Post2": "voluptatum",
      "Post3": "quidem",
      "EmailName": "marley.littel@halvorsonharvey.biz",
      "ContactFullName": "Elian Welch",
      "ActiveErpLinks": 298,
      "TicketPriorityId": 182,
      "SupportLanguageId": 52,
      "SupportAssociateId": 154,
      "CategoryName": "VIP Customer",
      "PersonNumber": "457353",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 611
        }
      }
    }
  ],
  "AlertLevel": 105,
  "ConnectId": 904,
  "ReadStatus": "Green",
  "TimeToReply": 612,
  "RealTimeToReply": 954,
  "TimeToClose": 965,
  "RealTimeToClose": 794,
  "TimeSpentInternally": 439,
  "TimeSpentExternally": 587,
  "TimeSpentQueue": 268,
  "RealTimeSpentInternally": 757,
  "RealTimeSpentExternally": 440,
  "RealTimeSpentQueue": 816,
  "TimeSpent": 390,
  "HasAttachment": true,
  "NumReplies": 445,
  "NumMessages": 859,
  "FromAddress": "commodi",
  "Messages": [
    {
      "TicketMessageId": 270,
      "CreatedAt": "2017-11-02T14:28:22.5553721+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "eum",
      "PersonId": 811,
      "PersonFullName": "Janis Ruby Spinka IV",
      "ContactId": 153,
      "ContactName": "Grady Group",
      "ContactDepartment": "",
      "NumAttachments": 792,
      "EmailHeader": "sven@durgan.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "similique",
      "Sentiment": 405,
      "SentimentConfidence": 979,
      "CreatedBy": 243,
      "ChangedAt": "2023-11-24T14:28:22.5553721+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 418
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 68,
      "Name": "Halvorson, Davis and Kemmer",
      "ToolTip": "Delectus ea nam error dolorum rerum.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 353
        }
      }
    },
    {
      "Id": 68,
      "Name": "Halvorson, Davis and Kemmer",
      "ToolTip": "Delectus ea nam error dolorum rerum.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 353
        }
      }
    }
  ],
  "Language": "voluptatem",
  "Sentiment": 753,
  "SentimentConfidence": 361,
  "SuggestedCategoryId": 870,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 703,
  "IconHint": "voluptas",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 452,
  "ExtraFields": {
    "ExtraFields1": "exercitationem",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "eum",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 136
    }
  }
}
```