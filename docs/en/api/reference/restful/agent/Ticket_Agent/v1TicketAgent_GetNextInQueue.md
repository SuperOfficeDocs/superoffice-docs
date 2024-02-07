---
title: POST Agents/Ticket/GetNextInQueue
uid: v1TicketAgent_GetNextInQueue
generated: true
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
  "TicketId": 271,
  "Title": "velit",
  "CreatedAt": "1999-11-10T16:54:56.4966498+01:00",
  "LastChanged": "2000-07-23T16:54:56.4966498+02:00",
  "ReadByOwner": "2018-07-07T16:54:56.4966498+02:00",
  "ReadByCustomer": "2009-08-29T16:54:56.4966498+02:00",
  "FirstReadByOwner": "2001-04-27T16:54:56.4966498+02:00",
  "FirstReadByUser": "2023-02-05T16:54:56.4966498+01:00",
  "Activate": "2015-02-27T16:54:56.4966498+01:00",
  "ClosedAt": "2016-08-11T16:54:56.4966498+02:00",
  "RepliedAt": "2005-04-16T16:54:56.4966498+02:00",
  "AlertTimeout": "2022-08-01T16:54:56.4966498+02:00",
  "Deadline": "2007-09-23T16:54:56.4966498+02:00",
  "CreatedBy": null,
  "Author": "et",
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
      "Position": "aliquam",
      "PersonId": 97,
      "Mrmrs": "temporibus",
      "Firstname": "Sonia",
      "Lastname": "Dooley",
      "MiddleName": "Oberbrunner-Leuschke",
      "Title": "architecto",
      "Description": "Universal full-range protocol",
      "Email": "obie@senger.uk",
      "FullName": "Mr. Mateo Mayer III",
      "DirectPhone": "(273)267-7304 x77971",
      "FormalName": "Buckridge, Medhurst and Bradtke",
      "CountryId": 678,
      "ContactId": 791,
      "ContactName": "Murazik-Rohan",
      "Retired": 889,
      "Rank": 336,
      "ActiveInterests": 944,
      "ContactDepartment": "generate rich portals",
      "ContactCountryId": 912,
      "ContactOrgNr": "942633",
      "FaxPhone": "821.993.4874",
      "MobilePhone": "1-821-819-5555",
      "ContactPhone": "875-452-4072",
      "AssociateName": "Sporer, Ortiz and Bednar",
      "AssociateId": 807,
      "UsePersonAddress": false,
      "ContactFax": "dolores",
      "Kanafname": "totam",
      "Kanalname": "blanditiis",
      "Post1": "facere",
      "Post2": "quia",
      "Post3": "aspernatur",
      "EmailName": "ricky@gleichner.biz",
      "ContactFullName": "Dr. Emelie Kayley Lindgren DVM",
      "ActiveErpLinks": 396,
      "TicketPriorityId": 381,
      "SupportLanguageId": 443,
      "SupportAssociateId": 175,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 655
        }
      }
    }
  ],
  "AlertLevel": 873,
  "ConnectId": 919,
  "ReadStatus": "Green",
  "TimeToReply": 571,
  "RealTimeToReply": 526,
  "TimeToClose": 369,
  "RealTimeToClose": 317,
  "TimeSpentInternally": 473,
  "TimeSpentExternally": 235,
  "TimeSpentQueue": 362,
  "RealTimeSpentInternally": 271,
  "RealTimeSpentExternally": 880,
  "RealTimeSpentQueue": 269,
  "TimeSpent": 132,
  "HasAttachment": true,
  "NumReplies": 494,
  "NumMessages": 189,
  "FromAddress": "iusto",
  "Messages": [
    {
      "TicketMessageId": 261,
      "CreatedAt": "2015-12-25T16:54:56.4996505+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "et",
      "PersonId": 952,
      "PersonFullName": "Destinee D'Amore",
      "ContactId": 85,
      "ContactName": "Grant, Huels and Haag",
      "ContactDepartment": "",
      "NumAttachments": 756,
      "EmailHeader": "jesse@schulistziemann.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "sapiente",
      "Sentiment": 246,
      "SentimentConfidence": 857,
      "CreatedBy": 132,
      "ChangedAt": "2000-02-16T16:54:56.4996505+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 10
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 835,
      "Name": "Bernier, Mosciski and Bartoletti",
      "ToolTip": "Eum vel magnam non autem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 859
        }
      }
    },
    {
      "Id": 835,
      "Name": "Bernier, Mosciski and Bartoletti",
      "ToolTip": "Eum vel magnam non autem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 859
        }
      }
    }
  ],
  "Language": "libero",
  "Sentiment": 664,
  "SentimentConfidence": 342,
  "SuggestedCategoryId": 913,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 844,
  "IconHint": "sint",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 96,
  "ExtraFields": {
    "ExtraFields1": "cupiditate",
    "ExtraFields2": "ab"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 48
    }
  }
}
```