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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 421,
  "Title": "tempora",
  "CreatedAt": "2024-01-12T14:32:03.9991039+01:00",
  "LastChanged": "2006-02-15T14:32:03.9991039+01:00",
  "ReadByOwner": "2020-01-14T14:32:03.9991039+01:00",
  "ReadByCustomer": "2009-07-03T14:32:03.9991039+02:00",
  "FirstReadByOwner": "2020-06-05T14:32:03.9991039+02:00",
  "FirstReadByUser": "2009-02-13T14:32:03.9991039+01:00",
  "Activate": "2010-06-14T14:32:03.9991039+02:00",
  "ClosedAt": "2009-11-20T14:32:03.9991039+01:00",
  "RepliedAt": "1999-09-18T14:32:03.9991039+02:00",
  "AlertTimeout": "2016-02-06T14:32:03.9991039+01:00",
  "Deadline": "2001-04-28T14:32:03.9991039+02:00",
  "CreatedBy": null,
  "Author": "maxime",
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
      "Position": "sit",
      "PersonId": 945,
      "Mrmrs": "fugiat",
      "Firstname": "Augustus",
      "Lastname": "Hermiston",
      "MiddleName": "Gleason Group",
      "Title": "eos",
      "Description": "User-centric methodical portal",
      "Email": "tyreek@volkmanankunding.uk",
      "FullName": "Carter Smitham",
      "DirectPhone": "1-296-362-8073 x18460",
      "FormalName": "Morar-Braun",
      "CountryId": 147,
      "ContactId": 363,
      "ContactName": "Hauck-VonRueden",
      "Retired": 362,
      "Rank": 149,
      "ActiveInterests": 788,
      "ContactDepartment": "",
      "ContactCountryId": 728,
      "ContactOrgNr": "363132",
      "FaxPhone": "(456)814-7446 x212",
      "MobilePhone": "(139)480-2397 x554",
      "ContactPhone": "(572)288-0777 x083",
      "AssociateName": "Moore-Dibbert",
      "AssociateId": 941,
      "UsePersonAddress": true,
      "ContactFax": "molestiae",
      "Kanafname": "molestias",
      "Kanalname": "quia",
      "Post1": "assumenda",
      "Post2": "mollitia",
      "Post3": "et",
      "EmailName": "niko_eichmann@moenhand.uk",
      "ContactFullName": "Agustin Satterfield",
      "ActiveErpLinks": 555,
      "TicketPriorityId": 367,
      "SupportLanguageId": 228,
      "SupportAssociateId": 549,
      "CategoryName": "VIP Customer",
      "PersonNumber": "848710",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 318
        }
      }
    }
  ],
  "AlertLevel": 69,
  "ConnectId": 414,
  "ReadStatus": "Green",
  "TimeToReply": 856,
  "RealTimeToReply": 65,
  "TimeToClose": 800,
  "RealTimeToClose": 463,
  "TimeSpentInternally": 863,
  "TimeSpentExternally": 68,
  "TimeSpentQueue": 595,
  "RealTimeSpentInternally": 969,
  "RealTimeSpentExternally": 257,
  "RealTimeSpentQueue": 456,
  "TimeSpent": 678,
  "HasAttachment": false,
  "NumReplies": 822,
  "NumMessages": 450,
  "FromAddress": "accusantium",
  "Messages": [
    {
      "TicketMessageId": 698,
      "CreatedAt": "2012-06-27T14:32:03.9991039+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "eos",
      "PersonId": 578,
      "PersonFullName": "Margarette Kovacek",
      "ContactId": 132,
      "ContactName": "Hackett, Russel and Ledner",
      "ContactDepartment": "",
      "NumAttachments": 967,
      "EmailHeader": "weldon@hickle.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quidem",
      "Sentiment": 639,
      "SentimentConfidence": 361,
      "CreatedBy": 172,
      "ChangedAt": "2004-01-03T14:32:03.9991039+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 476
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 614,
      "Name": "Hermiston, Ziemann and Mueller",
      "ToolTip": "Illum qui voluptatem et hic.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 840
        }
      }
    },
    {
      "Id": 614,
      "Name": "Hermiston, Ziemann and Mueller",
      "ToolTip": "Illum qui voluptatem et hic.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 840
        }
      }
    }
  ],
  "Language": "ut",
  "Sentiment": 810,
  "SentimentConfidence": 763,
  "SuggestedCategoryId": 816,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 719,
  "IconHint": "est",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 45,
  "ExtraFields": {
    "ExtraFields1": "illo",
    "ExtraFields2": "vel"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "quisquam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 537
    }
  }
}
```