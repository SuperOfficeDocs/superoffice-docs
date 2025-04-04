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
  "TicketId": 5,
  "Title": "qui",
  "CreatedAt": "2012-01-09T13:14:01.4256794+01:00",
  "LastChanged": "2022-07-30T13:14:01.4256794+02:00",
  "ReadByOwner": "2020-09-14T13:14:01.4256794+02:00",
  "ReadByCustomer": "2010-02-03T13:14:01.4256794+01:00",
  "FirstReadByOwner": "2017-07-03T13:14:01.4256794+02:00",
  "FirstReadByUser": "2023-06-22T13:14:01.4256794+02:00",
  "Activate": "2021-03-16T13:14:01.4256794+01:00",
  "ClosedAt": "2017-06-16T13:14:01.4256794+02:00",
  "RepliedAt": "2010-03-22T13:14:01.4256794+01:00",
  "AlertTimeout": "2006-04-02T13:14:01.4256794+02:00",
  "Deadline": "2011-10-14T13:14:01.4256794+02:00",
  "CreatedBy": null,
  "Author": "sunt",
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
      "Position": "molestias",
      "PersonId": 396,
      "Mrmrs": "sed",
      "Firstname": "Amelia",
      "Lastname": "Treutel",
      "MiddleName": "Wyman, Ryan and Price",
      "Title": "reiciendis",
      "Description": "Grass-roots transitional interface",
      "Email": "coralie@champlinhamill.biz",
      "FullName": "Kailee Robb Ratke Sr.",
      "DirectPhone": "070.076.9461 x9483",
      "FormalName": "Rosenbaum, Langosh and Hackett",
      "CountryId": 980,
      "ContactId": 844,
      "ContactName": "Kiehn-Greenholt",
      "Retired": 209,
      "Rank": 437,
      "ActiveInterests": 997,
      "ContactDepartment": "",
      "ContactCountryId": 53,
      "ContactOrgNr": "83059",
      "FaxPhone": "144-129-4908",
      "MobilePhone": "162-656-2747",
      "ContactPhone": "1-016-513-5031 x23475",
      "AssociateName": "Gaylord Inc and Sons",
      "AssociateId": 954,
      "UsePersonAddress": false,
      "ContactFax": "odio",
      "Kanafname": "in",
      "Kanalname": "rem",
      "Post1": "aliquam",
      "Post2": "placeat",
      "Post3": "aut",
      "EmailName": "johnny@padberglubowitz.info",
      "ContactFullName": "Litzy Fritsch",
      "ActiveErpLinks": 924,
      "TicketPriorityId": 99,
      "SupportLanguageId": 272,
      "SupportAssociateId": 517,
      "CategoryName": "VIP Customer",
      "PersonNumber": "457306",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 277
        }
      }
    }
  ],
  "AlertLevel": 251,
  "ConnectId": 352,
  "ReadStatus": "Green",
  "TimeToReply": 793,
  "RealTimeToReply": 799,
  "TimeToClose": 237,
  "RealTimeToClose": 682,
  "TimeSpentInternally": 796,
  "TimeSpentExternally": 285,
  "TimeSpentQueue": 563,
  "RealTimeSpentInternally": 922,
  "RealTimeSpentExternally": 596,
  "RealTimeSpentQueue": 603,
  "TimeSpent": 249,
  "HasAttachment": false,
  "NumReplies": 46,
  "NumMessages": 126,
  "FromAddress": "dolores",
  "Messages": [
    {
      "TicketMessageId": 299,
      "CreatedAt": "2004-08-12T13:14:01.4256794+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "dolor",
      "PersonId": 150,
      "PersonFullName": "Zella Brown",
      "ContactId": 331,
      "ContactName": "O'Kon, Zieme and Gusikowski",
      "ContactDepartment": "",
      "NumAttachments": 58,
      "EmailHeader": "trisha@ohara.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "consectetur",
      "Sentiment": 543,
      "SentimentConfidence": 351,
      "CreatedBy": 587,
      "ChangedAt": "2009-10-17T13:14:01.4256794+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 749
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 617,
      "Name": "Langosh-Veum",
      "ToolTip": "Ut quae molestias iste consequuntur sit consequatur impedit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 575
        }
      }
    },
    {
      "Id": 617,
      "Name": "Langosh-Veum",
      "ToolTip": "Ut quae molestias iste consequuntur sit consequatur impedit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 575
        }
      }
    }
  ],
  "Language": "quia",
  "Sentiment": 60,
  "SentimentConfidence": 355,
  "SuggestedCategoryId": 642,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 908,
  "IconHint": "distinctio",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 709,
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "distinctio"
  },
  "CustomFields": {
    "CustomFields1": "illum",
    "CustomFields2": "adipisci"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 965
    }
  }
}
```