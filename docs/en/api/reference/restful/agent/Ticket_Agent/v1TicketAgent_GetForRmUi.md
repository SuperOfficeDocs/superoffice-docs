---
title: POST Agents/Ticket/GetForRmUi
uid: v1TicketAgent_GetForRmUi
generated: true
---

# POST Agents/Ticket/GetForRmUi

```http
POST /api/v1/Agents/Ticket/GetForRmUi
```

Get a ticket entity, adapted to the specific needs of the Request Management UI.


WARNING: This endpoint is not guaranteed to be stable/compatible between versions






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetForRmUi?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

TicketId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | Integer |  |

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
POST /api/v1/Agents/Ticket/GetForRmUi
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 184
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 177,
  "Title": "quia",
  "CreatedAt": "1999-01-27T16:32:40.2426321+01:00",
  "LastChanged": "2007-03-22T16:32:40.2426321+01:00",
  "ReadByOwner": "1998-03-20T16:32:40.2426321+01:00",
  "ReadByCustomer": "1998-06-14T16:32:40.2426321+02:00",
  "FirstReadByOwner": "2005-09-23T16:32:40.2426321+02:00",
  "FirstReadByUser": "1999-04-15T16:32:40.2426321+02:00",
  "Activate": "2022-06-07T16:32:40.2426321+02:00",
  "ClosedAt": "2005-02-04T16:32:40.2426321+01:00",
  "RepliedAt": "2003-09-11T16:32:40.2426321+02:00",
  "AlertTimeout": "2000-09-26T16:32:40.2426321+02:00",
  "Deadline": "2023-06-12T16:32:40.2426321+02:00",
  "CreatedBy": null,
  "Author": "consectetur",
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
      "Position": "omnis",
      "PersonId": 105,
      "Mrmrs": "officiis",
      "Firstname": "Nelda",
      "Lastname": "Maggio",
      "MiddleName": "Cole, Zieme and Legros",
      "Title": "mollitia",
      "Description": "Configurable mission-critical algorithm",
      "Email": "kaela_walter@reinger.com",
      "FullName": "Isabelle Jarrett Kiehn PhD",
      "DirectPhone": "(304)212-2701 x563",
      "FormalName": "Pouros LLC",
      "CountryId": 687,
      "ContactId": 604,
      "ContactName": "McGlynn Group",
      "Retired": 187,
      "Rank": 449,
      "ActiveInterests": 920,
      "ContactDepartment": "",
      "ContactCountryId": 289,
      "ContactOrgNr": "1267849",
      "FaxPhone": "1-995-611-2589",
      "MobilePhone": "1-447-189-0544 x25330",
      "ContactPhone": "382.408.9684 x2886",
      "AssociateName": "Reichel, Durgan and Barrows",
      "AssociateId": 639,
      "UsePersonAddress": false,
      "ContactFax": "suscipit",
      "Kanafname": "aspernatur",
      "Kanalname": "qui",
      "Post1": "facere",
      "Post2": "quae",
      "Post3": "perferendis",
      "EmailName": "tatum@schowalterkulas.uk",
      "ContactFullName": "Mr. Marilou Vernie Deckow",
      "ActiveErpLinks": 732,
      "TicketPriorityId": 533,
      "SupportLanguageId": 757,
      "SupportAssociateId": 62,
      "CategoryName": "VIP Customer",
      "PersonNumber": "988916",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 392
        }
      }
    }
  ],
  "AlertLevel": 612,
  "ConnectId": 191,
  "ReadStatus": "Green",
  "TimeToReply": 379,
  "RealTimeToReply": 63,
  "TimeToClose": 797,
  "RealTimeToClose": 551,
  "TimeSpentInternally": 897,
  "TimeSpentExternally": 233,
  "TimeSpentQueue": 51,
  "RealTimeSpentInternally": 155,
  "RealTimeSpentExternally": 699,
  "RealTimeSpentQueue": 940,
  "TimeSpent": 222,
  "HasAttachment": false,
  "NumReplies": 625,
  "NumMessages": 39,
  "FromAddress": "dolor",
  "Messages": [
    {
      "TicketMessageId": 720,
      "CreatedAt": "2000-06-01T16:32:40.2582537+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "aliquid",
      "PersonId": 556,
      "PersonFullName": "Andrew Wolff",
      "ContactId": 838,
      "ContactName": "Goyette, Skiles and Purdy",
      "ContactDepartment": "",
      "NumAttachments": 279,
      "EmailHeader": "carole@stracke.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "non",
      "Sentiment": 24,
      "SentimentConfidence": 665,
      "CreatedBy": 309,
      "ChangedAt": "2013-03-04T16:32:40.2582537+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 297
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 889,
      "Name": "Terry, Keebler and Fay",
      "ToolTip": "Accusamus eius ea iusto omnis voluptatum.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 917
        }
      }
    },
    {
      "Id": 889,
      "Name": "Terry, Keebler and Fay",
      "ToolTip": "Accusamus eius ea iusto omnis voluptatum.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 917
        }
      }
    }
  ],
  "Language": "ipsa",
  "Sentiment": 721,
  "SentimentConfidence": 257,
  "SuggestedCategoryId": 206,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 196,
  "IconHint": "porro",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 376,
  "ExtraFields": {
    "ExtraFields1": "laborum",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "rem",
    "CustomFields2": "sequi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 133
    }
  }
}
```