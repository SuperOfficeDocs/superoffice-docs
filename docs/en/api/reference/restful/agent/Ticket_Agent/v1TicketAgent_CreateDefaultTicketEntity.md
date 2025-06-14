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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 821,
  "Title": "consequatur",
  "CreatedAt": "2010-09-26T17:54:03.7264456+02:00",
  "LastChanged": "2020-04-10T17:54:03.7264456+02:00",
  "ReadByOwner": "2019-03-08T17:54:03.7264456+01:00",
  "ReadByCustomer": "2007-06-28T17:54:03.7264456+02:00",
  "FirstReadByOwner": "2016-03-02T17:54:03.7264456+01:00",
  "FirstReadByUser": "2020-02-25T17:54:03.7264456+01:00",
  "Activate": "2001-07-12T17:54:03.7264456+02:00",
  "ClosedAt": "2010-03-25T17:54:03.7264456+01:00",
  "RepliedAt": "2001-09-14T17:54:03.7264456+02:00",
  "AlertTimeout": "2023-04-10T17:54:03.7264456+02:00",
  "Deadline": "2002-04-06T17:54:03.7264456+02:00",
  "CreatedBy": null,
  "Author": "fugit",
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
      "Position": "quia",
      "PersonId": 412,
      "Mrmrs": "voluptatum",
      "Firstname": "Caroline",
      "Lastname": "Farrell",
      "MiddleName": "Swaniawski LLC",
      "Title": "mollitia",
      "Description": "Versatile user-facing website",
      "Email": "xander_rogahn@hamill.name",
      "FullName": "Quinten Schmidt Jr.",
      "DirectPhone": "1-931-275-3879 x0980",
      "FormalName": "Purdy Group",
      "CountryId": 409,
      "ContactId": 996,
      "ContactName": "Luettgen Inc and Sons",
      "Retired": 16,
      "Rank": 209,
      "ActiveInterests": 808,
      "ContactDepartment": "",
      "ContactCountryId": 322,
      "ContactOrgNr": "1064946",
      "FaxPhone": "(623)039-2442",
      "MobilePhone": "1-888-266-8105",
      "ContactPhone": "(101)772-3461",
      "AssociateName": "O'Reilly Inc and Sons",
      "AssociateId": 123,
      "UsePersonAddress": true,
      "ContactFax": "placeat",
      "Kanafname": "asperiores",
      "Kanalname": "omnis",
      "Post1": "explicabo",
      "Post2": "sapiente",
      "Post3": "voluptas",
      "EmailName": "larissa_roob@eichmannkunze.info",
      "ContactFullName": "Tressie Zulauf",
      "ActiveErpLinks": 176,
      "TicketPriorityId": 1001,
      "SupportLanguageId": 802,
      "SupportAssociateId": 627,
      "CategoryName": "VIP Customer",
      "PersonNumber": "534145",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 150
        }
      }
    }
  ],
  "AlertLevel": 960,
  "ConnectId": 186,
  "ReadStatus": "Green",
  "TimeToReply": 747,
  "RealTimeToReply": 831,
  "TimeToClose": 716,
  "RealTimeToClose": 944,
  "TimeSpentInternally": 644,
  "TimeSpentExternally": 856,
  "TimeSpentQueue": 711,
  "RealTimeSpentInternally": 589,
  "RealTimeSpentExternally": 913,
  "RealTimeSpentQueue": 43,
  "TimeSpent": 708,
  "HasAttachment": false,
  "NumReplies": 688,
  "NumMessages": 252,
  "FromAddress": "sed",
  "Messages": [
    {
      "TicketMessageId": 115,
      "CreatedAt": "2011-03-17T17:54:03.7264456+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "ipsum",
      "PersonId": 962,
      "PersonFullName": "Miss Riley Johnston II",
      "ContactId": 800,
      "ContactName": "Crona, Davis and Heller",
      "ContactDepartment": "",
      "NumAttachments": 163,
      "EmailHeader": "justine@wiegandklein.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "aut",
      "Sentiment": 134,
      "SentimentConfidence": 398,
      "CreatedBy": 741,
      "ChangedAt": "2015-11-06T17:54:03.7264456+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 574
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 634,
      "Name": "Shanahan, Pagac and McLaughlin",
      "ToolTip": "Autem qui id vel.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 96
        }
      }
    },
    {
      "Id": 634,
      "Name": "Shanahan, Pagac and McLaughlin",
      "ToolTip": "Autem qui id vel.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 96
        }
      }
    }
  ],
  "Language": "aut",
  "Sentiment": 710,
  "SentimentConfidence": 617,
  "SuggestedCategoryId": 2,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 923,
  "IconHint": "tenetur",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 79,
  "ExtraFields": {
    "ExtraFields1": "quis",
    "ExtraFields2": "excepturi"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "sit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 8
    }
  }
}
```