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
  "TicketId": 476,
  "Title": "omnis",
  "CreatedAt": "1997-03-29T16:55:30.1601408+01:00",
  "LastChanged": "2012-10-12T16:55:30.1601408+02:00",
  "ReadByOwner": "2005-07-26T16:55:30.1601408+02:00",
  "ReadByCustomer": "2010-05-13T16:55:30.1601408+02:00",
  "FirstReadByOwner": "2009-05-23T16:55:30.1601408+02:00",
  "FirstReadByUser": "2008-09-23T16:55:30.1601408+02:00",
  "Activate": "2000-10-07T16:55:30.1601408+02:00",
  "ClosedAt": "2004-11-30T16:55:30.1601408+01:00",
  "RepliedAt": "2013-02-28T16:55:30.1601408+01:00",
  "AlertTimeout": "2003-07-09T16:55:30.1601408+02:00",
  "Deadline": "2003-05-02T16:55:30.1601408+02:00",
  "CreatedBy": null,
  "Author": "sed",
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
      "Position": "magni",
      "PersonId": 805,
      "Mrmrs": "earum",
      "Firstname": "Carey",
      "Lastname": "Marquardt",
      "MiddleName": "Quigley, Schaden and Abbott",
      "Title": "dolorum",
      "Description": "Upgradable user-facing conglomeration",
      "Email": "jeremy@bergstrombernhard.com",
      "FullName": "Lottie Conn II",
      "DirectPhone": "127.586.5243",
      "FormalName": "Rippin Group",
      "CountryId": 83,
      "ContactId": 378,
      "ContactName": "Windler, Erdman and Conroy",
      "Retired": 46,
      "Rank": 750,
      "ActiveInterests": 634,
      "ContactDepartment": "",
      "ContactCountryId": 931,
      "ContactOrgNr": "1438862",
      "FaxPhone": "1-569-581-3738",
      "MobilePhone": "1-424-629-5794 x53078",
      "ContactPhone": "(419)502-4330",
      "AssociateName": "Cole, Doyle and Ullrich",
      "AssociateId": 259,
      "UsePersonAddress": false,
      "ContactFax": "aperiam",
      "Kanafname": "ducimus",
      "Kanalname": "voluptatem",
      "Post1": "excepturi",
      "Post2": "dolor",
      "Post3": "rerum",
      "EmailName": "abraham.jenkins@brown.info",
      "ContactFullName": "Khalid Rutherford",
      "ActiveErpLinks": 152,
      "TicketPriorityId": 138,
      "SupportLanguageId": 774,
      "SupportAssociateId": 587,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 237
        }
      }
    }
  ],
  "AlertLevel": 868,
  "ConnectId": 680,
  "ReadStatus": "Green",
  "TimeToReply": 117,
  "RealTimeToReply": 867,
  "TimeToClose": 494,
  "RealTimeToClose": 382,
  "TimeSpentInternally": 253,
  "TimeSpentExternally": 769,
  "TimeSpentQueue": 165,
  "RealTimeSpentInternally": 78,
  "RealTimeSpentExternally": 159,
  "RealTimeSpentQueue": 53,
  "TimeSpent": 973,
  "HasAttachment": false,
  "NumReplies": 492,
  "NumMessages": 289,
  "FromAddress": "sed",
  "Messages": [
    {
      "TicketMessageId": 102,
      "CreatedAt": "2009-02-28T16:55:30.1641152+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "rerum",
      "PersonId": 732,
      "PersonFullName": "Miss Karli Brakus IV",
      "ContactId": 898,
      "ContactName": "Rosenbaum, Zieme and Bernier",
      "ContactDepartment": "",
      "NumAttachments": 82,
      "EmailHeader": "coty@kautzerquitzon.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "in",
      "Sentiment": 511,
      "SentimentConfidence": 846,
      "CreatedBy": 969,
      "ChangedAt": "2009-10-12T16:55:30.1641152+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 83
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 665,
      "Name": "Hahn, Leuschke and Swaniawski",
      "ToolTip": "Consectetur natus enim harum consequatur illo molestiae maiores.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 60
        }
      }
    },
    {
      "Id": 665,
      "Name": "Hahn, Leuschke and Swaniawski",
      "ToolTip": "Consectetur natus enim harum consequatur illo molestiae maiores.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 60
        }
      }
    }
  ],
  "Language": "rem",
  "Sentiment": 631,
  "SentimentConfidence": 597,
  "SuggestedCategoryId": 500,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 461,
  "IconHint": "nihil",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 962,
  "ExtraFields": {
    "ExtraFields1": "corrupti",
    "ExtraFields2": "sapiente"
  },
  "CustomFields": {
    "CustomFields1": "itaque",
    "CustomFields2": "voluptatem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 327
    }
  }
}
```