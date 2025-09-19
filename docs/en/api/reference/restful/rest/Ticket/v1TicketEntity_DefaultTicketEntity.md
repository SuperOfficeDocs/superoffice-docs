---
title: GET Ticket/default
uid: v1TicketEntity_DefaultTicketEntity
generated: true
content_type: reference
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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 255,
  "Title": "quo",
  "CreatedAt": "2024-01-23T03:41:59.0273773+01:00",
  "LastChanged": "2012-03-09T03:41:59.0273773+01:00",
  "ReadByOwner": "2019-03-07T03:41:59.0273773+01:00",
  "ReadByCustomer": "2002-06-30T03:41:59.0273773+02:00",
  "FirstReadByOwner": "2007-01-25T03:41:59.0273773+01:00",
  "FirstReadByUser": "2025-02-27T03:41:59.0273773+01:00",
  "Activate": "2011-03-04T03:41:59.0273773+01:00",
  "ClosedAt": "2009-04-20T03:41:59.0273773+02:00",
  "RepliedAt": "2021-07-23T03:41:59.0273773+02:00",
  "AlertTimeout": "2025-04-13T03:41:59.0273773+02:00",
  "Deadline": "2021-05-02T03:41:59.0273773+02:00",
  "CreatedBy": null,
  "Author": "neque",
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
      "Position": "libero",
      "PersonId": 948,
      "Mrmrs": "rerum",
      "Firstname": "Peter",
      "Lastname": "Emard",
      "MiddleName": "Grimes, Schuster and Johnson",
      "Title": "cum",
      "Description": "Proactive mobile flexibility",
      "Email": "sincere@zemlak.name",
      "FullName": "Kavon Brown",
      "DirectPhone": "(669)806-3348 x462",
      "FormalName": "Osinski, Schiller and Waelchi",
      "CountryId": 488,
      "ContactId": 882,
      "ContactName": "Blanda-Reynolds",
      "Retired": 809,
      "Rank": 487,
      "ActiveInterests": 53,
      "ContactDepartment": "utilize B2B schemas",
      "ContactCountryId": 692,
      "ContactOrgNr": "667621",
      "FaxPhone": "784.053.3691 x740",
      "MobilePhone": "(266)990-0122 x87824",
      "ContactPhone": "(229)554-7484 x9030",
      "AssociateName": "Zboncak Group",
      "AssociateId": 363,
      "UsePersonAddress": false,
      "ContactFax": "quod",
      "Kanafname": "rerum",
      "Kanalname": "voluptatem",
      "Post1": "maiores",
      "Post2": "ab",
      "Post3": "natus",
      "EmailName": "hayley@mclaughlin.biz",
      "ContactFullName": "Maurine Ken Abernathy III",
      "ActiveErpLinks": 831,
      "TicketPriorityId": 876,
      "SupportLanguageId": 227,
      "SupportAssociateId": 565,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1076464",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 34
        }
      }
    }
  ],
  "AlertLevel": 566,
  "ConnectId": 252,
  "ReadStatus": "Green",
  "TimeToReply": 165,
  "RealTimeToReply": 568,
  "TimeToClose": 477,
  "RealTimeToClose": 513,
  "TimeSpentInternally": 638,
  "TimeSpentExternally": 589,
  "TimeSpentQueue": 589,
  "RealTimeSpentInternally": 293,
  "RealTimeSpentExternally": 576,
  "RealTimeSpentQueue": 159,
  "TimeSpent": 933,
  "HasAttachment": false,
  "NumReplies": 828,
  "NumMessages": 384,
  "FromAddress": "ipsa",
  "Messages": [
    {
      "TicketMessageId": 184,
      "CreatedAt": "2019-07-30T03:41:59.0273773+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "dolorem",
      "PersonId": 496,
      "PersonFullName": "Tony Corkery",
      "ContactId": 182,
      "ContactName": "Lowe-Rowe",
      "ContactDepartment": "",
      "NumAttachments": 647,
      "EmailHeader": "jarrett_fay@schillerlindgren.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "consectetur",
      "Sentiment": 411,
      "SentimentConfidence": 721,
      "CreatedBy": 516,
      "ChangedAt": "1998-11-03T03:41:59.0273773+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 434
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 398,
      "Name": "Pouros Inc and Sons",
      "ToolTip": "Minima libero fuga ut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 216
        }
      }
    },
    {
      "Id": 398,
      "Name": "Pouros Inc and Sons",
      "ToolTip": "Minima libero fuga ut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 216
        }
      }
    }
  ],
  "Language": "voluptatum",
  "Sentiment": 518,
  "SentimentConfidence": 460,
  "SuggestedCategoryId": 188,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 829,
  "IconHint": "adipisci",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 44,
  "ExtraFields": {
    "ExtraFields1": "deleniti",
    "ExtraFields2": "vel"
  },
  "CustomFields": {
    "CustomFields1": "vero",
    "CustomFields2": "aspernatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 733
    }
  }
}
```