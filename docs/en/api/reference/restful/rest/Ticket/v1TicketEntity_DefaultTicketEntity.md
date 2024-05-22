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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 899,
  "Title": "dolore",
  "CreatedAt": "2009-01-26T12:57:42.8387917+01:00",
  "LastChanged": "2023-05-21T12:57:42.8387917+02:00",
  "ReadByOwner": "2004-02-17T12:57:42.8387917+01:00",
  "ReadByCustomer": "2012-09-23T12:57:42.8387917+02:00",
  "FirstReadByOwner": "2005-05-01T12:57:42.8387917+02:00",
  "FirstReadByUser": "2011-09-25T12:57:42.8387917+02:00",
  "Activate": "2014-03-13T12:57:42.8387917+01:00",
  "ClosedAt": "2020-09-24T12:57:42.8387917+02:00",
  "RepliedAt": "2018-04-24T12:57:42.8387917+02:00",
  "AlertTimeout": "1999-10-23T12:57:42.8387917+02:00",
  "Deadline": "2003-08-17T12:57:42.8387917+02:00",
  "CreatedBy": null,
  "Author": "eius",
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
      "Position": "quis",
      "PersonId": 142,
      "Mrmrs": "quia",
      "Firstname": "Anne",
      "Lastname": "Schaden",
      "MiddleName": "Hills Group",
      "Title": "voluptates",
      "Description": "Front-line dynamic analyzer",
      "Email": "neva@renner.co.uk",
      "FullName": "Rocio Padberg II",
      "DirectPhone": "1-107-767-4849",
      "FormalName": "Quitzon Inc and Sons",
      "CountryId": 871,
      "ContactId": 916,
      "ContactName": "Cremin Inc and Sons",
      "Retired": 351,
      "Rank": 307,
      "ActiveInterests": 589,
      "ContactDepartment": "",
      "ContactCountryId": 522,
      "ContactOrgNr": "685017",
      "FaxPhone": "597.242.2313 x65998",
      "MobilePhone": "016.889.1219 x205",
      "ContactPhone": "1-879-360-3569",
      "AssociateName": "Torp, Cole and Willms",
      "AssociateId": 413,
      "UsePersonAddress": false,
      "ContactFax": "doloremque",
      "Kanafname": "officia",
      "Kanalname": "dolorem",
      "Post1": "voluptatem",
      "Post2": "quia",
      "Post3": "voluptate",
      "EmailName": "mabel@bogisich.uk",
      "ContactFullName": "Miss Mina Ankunding II",
      "ActiveErpLinks": 988,
      "TicketPriorityId": 919,
      "SupportLanguageId": 945,
      "SupportAssociateId": 890,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 873
        }
      }
    }
  ],
  "AlertLevel": 254,
  "ConnectId": 626,
  "ReadStatus": "Green",
  "TimeToReply": 458,
  "RealTimeToReply": 295,
  "TimeToClose": 648,
  "RealTimeToClose": 388,
  "TimeSpentInternally": 526,
  "TimeSpentExternally": 66,
  "TimeSpentQueue": 597,
  "RealTimeSpentInternally": 700,
  "RealTimeSpentExternally": 212,
  "RealTimeSpentQueue": 144,
  "TimeSpent": 410,
  "HasAttachment": false,
  "NumReplies": 300,
  "NumMessages": 774,
  "FromAddress": "voluptatem",
  "Messages": [
    {
      "TicketMessageId": 802,
      "CreatedAt": "2000-02-25T12:57:42.8387917+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "ratione",
      "PersonId": 990,
      "PersonFullName": "Emile Abbott DDS",
      "ContactId": 356,
      "ContactName": "Becker-Barrows",
      "ContactDepartment": "",
      "NumAttachments": 308,
      "EmailHeader": "sonny@langworth.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "sunt",
      "Sentiment": 154,
      "SentimentConfidence": 134,
      "CreatedBy": 586,
      "ChangedAt": "2020-04-03T12:57:42.8387917+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 447
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 737,
      "Name": "Dicki Inc and Sons",
      "ToolTip": "Est quia nulla.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 408
        }
      }
    },
    {
      "Id": 737,
      "Name": "Dicki Inc and Sons",
      "ToolTip": "Est quia nulla.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 408
        }
      }
    }
  ],
  "Language": "est",
  "Sentiment": 574,
  "SentimentConfidence": 56,
  "SuggestedCategoryId": 518,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 128,
  "IconHint": "eligendi",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 782,
  "ExtraFields": {
    "ExtraFields1": "expedita",
    "ExtraFields2": "rem"
  },
  "CustomFields": {
    "CustomFields1": "alias",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 854
    }
  }
}
```