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
  "TicketId": 454,
  "Title": "dolor",
  "CreatedAt": "2009-08-25T10:30:32.5281261+02:00",
  "LastChanged": "2017-02-10T10:30:32.5281261+01:00",
  "ReadByOwner": "2014-09-13T10:30:32.5281261+02:00",
  "ReadByCustomer": "1999-06-10T10:30:32.5281261+02:00",
  "FirstReadByOwner": "2022-09-20T10:30:32.5281261+02:00",
  "FirstReadByUser": "2022-01-31T10:30:32.5281261+01:00",
  "Activate": "1998-08-25T10:30:32.5281261+02:00",
  "ClosedAt": "2001-02-24T10:30:32.5281261+01:00",
  "RepliedAt": "2004-08-24T10:30:32.5281261+02:00",
  "AlertTimeout": "2021-09-13T10:30:32.5281261+02:00",
  "Deadline": "2000-05-15T10:30:32.5281261+02:00",
  "CreatedBy": null,
  "Author": "est",
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
      "Position": "eius",
      "PersonId": 806,
      "Mrmrs": "illo",
      "Firstname": "Brandt",
      "Lastname": "Mann",
      "MiddleName": "Mayer, Ziemann and Sporer",
      "Title": "voluptates",
      "Description": "Seamless regional implementation",
      "Email": "johnson@mccullough.uk",
      "FullName": "Prof. Halle Nicolas MD",
      "DirectPhone": "189-399-3255 x87196",
      "FormalName": "Heidenreich-Bernhard",
      "CountryId": 10,
      "ContactId": 473,
      "ContactName": "Skiles, Connelly and Gerlach",
      "Retired": 70,
      "Rank": 176,
      "ActiveInterests": 556,
      "ContactDepartment": "",
      "ContactCountryId": 663,
      "ContactOrgNr": "168278",
      "FaxPhone": "936.246.1840 x974",
      "MobilePhone": "1-874-840-1220 x4361",
      "ContactPhone": "(211)506-9073 x41238",
      "AssociateName": "Kuhlman, Ritchie and Friesen",
      "AssociateId": 800,
      "UsePersonAddress": false,
      "ContactFax": "facere",
      "Kanafname": "et",
      "Kanalname": "consectetur",
      "Post1": "omnis",
      "Post2": "illo",
      "Post3": "corporis",
      "EmailName": "charlotte.hickle@crist.co.uk",
      "ContactFullName": "Ms. Corbin Lyda Hyatt",
      "ActiveErpLinks": 668,
      "TicketPriorityId": 88,
      "SupportLanguageId": 875,
      "SupportAssociateId": 972,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 604
        }
      }
    }
  ],
  "AlertLevel": 709,
  "ConnectId": 120,
  "ReadStatus": "Green",
  "TimeToReply": 21,
  "RealTimeToReply": 98,
  "TimeToClose": 822,
  "RealTimeToClose": 538,
  "TimeSpentInternally": 737,
  "TimeSpentExternally": 461,
  "TimeSpentQueue": 865,
  "RealTimeSpentInternally": 432,
  "RealTimeSpentExternally": 176,
  "RealTimeSpentQueue": 767,
  "TimeSpent": 781,
  "HasAttachment": false,
  "NumReplies": 864,
  "NumMessages": 95,
  "FromAddress": "consequatur",
  "Messages": [
    {
      "TicketMessageId": 419,
      "CreatedAt": "2023-01-29T10:30:32.5281261+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "molestiae",
      "PersonId": 32,
      "PersonFullName": "Gerry Pfannerstill Jr.",
      "ContactId": 659,
      "ContactName": "Spinka, Volkman and Sanford",
      "ContactDepartment": "",
      "NumAttachments": 603,
      "EmailHeader": "laney.nolan@morar.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ut",
      "Sentiment": 196,
      "SentimentConfidence": 209,
      "CreatedBy": 734,
      "ChangedAt": "2009-05-20T10:30:32.5281261+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 179
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 437,
      "Name": "Kerluke-Monahan",
      "ToolTip": "Voluptatem tenetur hic quia molestias debitis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 356
        }
      }
    },
    {
      "Id": 437,
      "Name": "Kerluke-Monahan",
      "ToolTip": "Voluptatem tenetur hic quia molestias debitis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 356
        }
      }
    }
  ],
  "Language": "sequi",
  "Sentiment": 73,
  "SentimentConfidence": 187,
  "SuggestedCategoryId": 748,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 100,
  "IconHint": "est",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 801,
  "ExtraFields": {
    "ExtraFields1": "sint",
    "ExtraFields2": "dicta"
  },
  "CustomFields": {
    "CustomFields1": "id",
    "CustomFields2": "eos"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 771
    }
  }
}
```