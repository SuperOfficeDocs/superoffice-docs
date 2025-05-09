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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 272,
  "Title": "est",
  "CreatedAt": "2009-06-18T16:32:48.118198+02:00",
  "LastChanged": "2001-12-21T16:32:48.118198+01:00",
  "ReadByOwner": "2008-07-14T16:32:48.118198+02:00",
  "ReadByCustomer": "2001-03-07T16:32:48.118198+01:00",
  "FirstReadByOwner": "2021-10-20T16:32:48.118198+02:00",
  "FirstReadByUser": "2000-04-20T16:32:48.118198+02:00",
  "Activate": "2001-01-20T16:32:48.118198+01:00",
  "ClosedAt": "2002-05-02T16:32:48.118198+02:00",
  "RepliedAt": "2014-04-11T16:32:48.118198+02:00",
  "AlertTimeout": "2017-04-28T16:32:48.118198+02:00",
  "Deadline": "2003-10-31T16:32:48.118198+01:00",
  "CreatedBy": null,
  "Author": "velit",
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
      "Position": "id",
      "PersonId": 51,
      "Mrmrs": "libero",
      "Firstname": "Jamal",
      "Lastname": "Kautzer",
      "MiddleName": "Cremin LLC",
      "Title": "nisi",
      "Description": "Expanded contextually-based time-frame",
      "Email": "timmothy@koeppstamm.name",
      "FullName": "Mrs. Jamil Shannon Ebert MD",
      "DirectPhone": "(440)814-3630 x5672",
      "FormalName": "Hilll Group",
      "CountryId": 238,
      "ContactId": 668,
      "ContactName": "Gottlieb-Wilkinson",
      "Retired": 352,
      "Rank": 64,
      "ActiveInterests": 233,
      "ContactDepartment": "",
      "ContactCountryId": 526,
      "ContactOrgNr": "1218077",
      "FaxPhone": "672.508.4601 x047",
      "MobilePhone": "816.456.8001",
      "ContactPhone": "1-212-684-6783",
      "AssociateName": "Rippin Inc and Sons",
      "AssociateId": 925,
      "UsePersonAddress": false,
      "ContactFax": "consequuntur",
      "Kanafname": "qui",
      "Kanalname": "nesciunt",
      "Post1": "consequatur",
      "Post2": "aliquid",
      "Post3": "possimus",
      "EmailName": "ena@ortizhegmann.info",
      "ContactFullName": "Margaret Lebsack",
      "ActiveErpLinks": 191,
      "TicketPriorityId": 582,
      "SupportLanguageId": 548,
      "SupportAssociateId": 925,
      "CategoryName": "VIP Customer",
      "PersonNumber": "855401",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 413
        }
      }
    }
  ],
  "AlertLevel": 937,
  "ConnectId": 372,
  "ReadStatus": "Green",
  "TimeToReply": 94,
  "RealTimeToReply": 958,
  "TimeToClose": 675,
  "RealTimeToClose": 350,
  "TimeSpentInternally": 951,
  "TimeSpentExternally": 183,
  "TimeSpentQueue": 827,
  "RealTimeSpentInternally": 46,
  "RealTimeSpentExternally": 418,
  "RealTimeSpentQueue": 496,
  "TimeSpent": 208,
  "HasAttachment": true,
  "NumReplies": 692,
  "NumMessages": 177,
  "FromAddress": "eligendi",
  "Messages": [
    {
      "TicketMessageId": 372,
      "CreatedAt": "2007-03-27T16:32:48.118198+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "perspiciatis",
      "PersonId": 774,
      "PersonFullName": "Sydnie Medhurst",
      "ContactId": 960,
      "ContactName": "Armstrong, Mosciski and Hamill",
      "ContactDepartment": "",
      "NumAttachments": 807,
      "EmailHeader": "chad@kunde.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ad",
      "Sentiment": 342,
      "SentimentConfidence": 559,
      "CreatedBy": 848,
      "ChangedAt": "2018-07-13T16:32:48.1338203+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 673
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 487,
      "Name": "Haley, Schinner and Baumbach",
      "ToolTip": "Ea est necessitatibus assumenda at debitis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 416
        }
      }
    },
    {
      "Id": 487,
      "Name": "Haley, Schinner and Baumbach",
      "ToolTip": "Ea est necessitatibus assumenda at debitis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 416
        }
      }
    }
  ],
  "Language": "et",
  "Sentiment": 743,
  "SentimentConfidence": 700,
  "SuggestedCategoryId": 296,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 453,
  "IconHint": "nostrum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 210,
  "ExtraFields": {
    "ExtraFields1": "dolorem",
    "ExtraFields2": "vitae"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "quae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 535
    }
  }
}
```