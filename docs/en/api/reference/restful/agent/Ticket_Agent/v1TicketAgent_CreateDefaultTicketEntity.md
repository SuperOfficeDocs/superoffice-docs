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
| OwnedBy | Associate | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category | TicketCategoryEntity | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority | TicketPriorityEntity | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status | TicketStatusEntity | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person | Person | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
| SecondaryPersons | array | The secondary persons this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
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
| Sale | Sale | The sale that this ticket is connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket is connected to  <para>Use MDO List name "project" to get list items.</para> |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Ticket/CreateDefaultTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 365,
  "Title": "ea",
  "CreatedAt": "2007-10-12T16:00:41.9456639+02:00",
  "LastChanged": "2017-10-05T16:00:41.9456639+02:00",
  "ReadByOwner": "2001-04-18T16:00:41.9456639+02:00",
  "ReadByCustomer": "2011-02-24T16:00:41.9456639+01:00",
  "FirstReadByOwner": "2015-04-06T16:00:41.9456639+02:00",
  "FirstReadByUser": "2001-09-29T16:00:41.9456639+02:00",
  "Activate": "2004-01-08T16:00:41.9456639+01:00",
  "ClosedAt": "2002-01-16T16:00:41.9456639+01:00",
  "RepliedAt": "1998-09-06T16:00:41.9456639+02:00",
  "AlertTimeout": "1998-12-08T16:00:41.9456639+01:00",
  "Deadline": "2015-10-11T16:00:41.9456639+02:00",
  "CreatedBy": null,
  "Author": "sequi",
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
      "Position": "ullam",
      "PersonId": 467,
      "Mrmrs": "quaerat",
      "Firstname": "Opal",
      "Lastname": "Koepp",
      "MiddleName": "Macejkovic LLC",
      "Title": "rerum",
      "Description": "Right-sized encompassing approach",
      "Email": "vernie@gislasonkling.ca",
      "FullName": "Crystal Krajcik",
      "DirectPhone": "(436)343-5675 x504",
      "FormalName": "Abernathy Group",
      "CountryId": 533,
      "ContactId": 629,
      "ContactName": "Ryan Inc and Sons",
      "Retired": 442,
      "Rank": 643,
      "ActiveInterests": 877,
      "ContactDepartment": "",
      "ContactCountryId": 873,
      "ContactOrgNr": "1077184",
      "FaxPhone": "374.365.9429",
      "MobilePhone": "1-064-062-2290 x3945",
      "ContactPhone": "628-616-8588 x452",
      "AssociateName": "Cruickshank Group",
      "AssociateId": 538,
      "UsePersonAddress": false,
      "ContactFax": "dolor",
      "Kanafname": "saepe",
      "Kanalname": "quia",
      "Post1": "similique",
      "Post2": "voluptatem",
      "Post3": "nihil",
      "EmailName": "lacey@predovic.uk",
      "ContactFullName": "Isai Brody Bernhard PhD",
      "ActiveErpLinks": 299,
      "TicketPriorityId": 72,
      "SupportLanguageId": 593,
      "SupportAssociateId": 600,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 566
        }
      }
    }
  ],
  "AlertLevel": 921,
  "ConnectId": 481,
  "ReadStatus": "Green",
  "TimeToReply": 102,
  "RealTimeToReply": 487,
  "TimeToClose": 657,
  "RealTimeToClose": 96,
  "TimeSpentInternally": 8,
  "TimeSpentExternally": 623,
  "TimeSpentQueue": 114,
  "RealTimeSpentInternally": 908,
  "RealTimeSpentExternally": 394,
  "RealTimeSpentQueue": 813,
  "HasAttachment": true,
  "NumReplies": 161,
  "NumMessages": 55,
  "FromAddress": "tenetur",
  "Messages": [
    {
      "TicketMessageId": 647,
      "CreatedAt": "2000-11-06T16:00:41.9456639+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "consequuntur",
      "PersonId": 806,
      "PersonFullName": "Miss Camila Pansy Ward",
      "ContactId": 353,
      "ContactName": "Heathcote-Dietrich",
      "ContactDepartment": "",
      "NumAttachments": 472,
      "EmailHeader": "aniyah@hintz.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "nihil",
      "Sentiment": 525,
      "SentimentConfidence": 56,
      "CreatedBy": 800,
      "ChangedAt": "2006-09-08T16:00:41.9456639+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 456
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 262,
      "Name": "Brekke LLC",
      "ToolTip": "Ducimus quo ea vel error et dolor mollitia.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 924
        }
      }
    },
    {
      "Id": 262,
      "Name": "Brekke LLC",
      "ToolTip": "Ducimus quo ea vel error et dolor mollitia.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 924
        }
      }
    }
  ],
  "Language": "eveniet",
  "Sentiment": 517,
  "SentimentConfidence": 383,
  "SuggestedCategoryId": 351,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 92,
  "IconHint": "cum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "porro"
  },
  "CustomFields": {
    "CustomFields1": "iure",
    "CustomFields2": "aspernatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 335
    }
  }
}
```