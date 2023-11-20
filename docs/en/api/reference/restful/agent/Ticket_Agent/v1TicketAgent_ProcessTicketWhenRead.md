---
title: POST Agents/Ticket/ProcessTicketWhenRead
uid: v1TicketAgent_ProcessTicketWhenRead
generated: true
---

# POST Agents/Ticket/ProcessTicketWhenRead

```http
POST /api/v1/Agents/Ticket/ProcessTicketWhenRead
```

When a user view/read a ticket, a number of action should be performed: set read status, escalation handling, remove notifications, etc.


Which actions will be performed depends on owner, caller and configuration






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/ProcessTicketWhenRead?$select=name,department,category/id
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

TicketEntityId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketEntityId | Integer |  |

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
| Sale | Sale | The sale that this ticket is connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket is connected to  <para>Use MDO List name "project" to get list items.</para> |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| TicketType | TicketTypeEntity | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Ticket/ProcessTicketWhenRead
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 663
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 327,
  "Title": "sequi",
  "CreatedAt": "2006-08-20T13:38:14.2646807+02:00",
  "LastChanged": "2009-01-13T13:38:14.2646807+01:00",
  "ReadByOwner": "2020-08-20T13:38:14.2646807+02:00",
  "ReadByCustomer": "2015-02-26T13:38:14.2646807+01:00",
  "FirstReadByOwner": "1998-11-09T13:38:14.2646807+01:00",
  "FirstReadByUser": "2021-09-17T13:38:14.2646807+02:00",
  "Activate": "2023-07-05T13:38:14.2646807+02:00",
  "ClosedAt": "2016-06-21T13:38:14.2646807+02:00",
  "RepliedAt": "2014-09-03T13:38:14.2646807+02:00",
  "AlertTimeout": "2019-01-16T13:38:14.2646807+01:00",
  "Deadline": "2019-07-31T13:38:14.2646807+02:00",
  "CreatedBy": null,
  "Author": "porro",
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
      "Position": "harum",
      "PersonId": 336,
      "Mrmrs": "tempore",
      "Firstname": "Raphaelle",
      "Lastname": "Bosco",
      "MiddleName": "Bartoletti Inc and Sons",
      "Title": "beatae",
      "Description": "Multi-lateral real-time neural-net",
      "Email": "bartholome.torphy@reichel.ca",
      "FullName": "Judge Dickens",
      "DirectPhone": "373-479-5495 x8311",
      "FormalName": "Hilll LLC",
      "CountryId": 554,
      "ContactId": 794,
      "ContactName": "Jast, Schuster and McLaughlin",
      "Retired": 879,
      "Rank": 977,
      "ActiveInterests": 401,
      "ContactDepartment": "recontextualize B2B partnerships",
      "ContactCountryId": 832,
      "ContactOrgNr": "1326576",
      "FaxPhone": "419.324.3979 x5243",
      "MobilePhone": "498.263.8695",
      "ContactPhone": "1-870-022-8290 x478",
      "AssociateName": "Schowalter Inc and Sons",
      "AssociateId": 264,
      "UsePersonAddress": false,
      "ContactFax": "veritatis",
      "Kanafname": "nihil",
      "Kanalname": "necessitatibus",
      "Post1": "ut",
      "Post2": "voluptas",
      "Post3": "quam",
      "EmailName": "zetta@kassulkeosinski.uk",
      "ContactFullName": "Angel Taylor Grant Sr.",
      "ActiveErpLinks": 669,
      "TicketPriorityId": 594,
      "SupportLanguageId": 182,
      "SupportAssociateId": 794,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 81
        }
      }
    }
  ],
  "AlertLevel": 707,
  "ConnectId": 270,
  "ReadStatus": "Green",
  "TimeToReply": 311,
  "RealTimeToReply": 1002,
  "TimeToClose": 513,
  "RealTimeToClose": 649,
  "TimeSpentInternally": 440,
  "TimeSpentExternally": 184,
  "TimeSpentQueue": 789,
  "RealTimeSpentInternally": 49,
  "RealTimeSpentExternally": 316,
  "RealTimeSpentQueue": 582,
  "TimeSpent": 437,
  "HasAttachment": false,
  "NumReplies": 959,
  "NumMessages": 462,
  "FromAddress": "ad",
  "Messages": [
    {
      "TicketMessageId": 492,
      "CreatedAt": "2022-09-21T13:38:14.2646807+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "quia",
      "PersonId": 683,
      "PersonFullName": "Prof. Kelli Maribel Romaguera II",
      "ContactId": 169,
      "ContactName": "Bashirian Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 848,
      "EmailHeader": "nash.daniel@lakin.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "illum",
      "Sentiment": 75,
      "SentimentConfidence": 339,
      "CreatedBy": 271,
      "ChangedAt": "2015-06-03T13:38:14.2646807+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 254
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 812,
      "Name": "Lang-Funk",
      "ToolTip": "Et quia magnam dolor impedit vel.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 593
        }
      }
    },
    {
      "Id": 812,
      "Name": "Lang-Funk",
      "ToolTip": "Et quia magnam dolor impedit vel.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 593
        }
      }
    }
  ],
  "Language": "aut",
  "Sentiment": 519,
  "SentimentConfidence": 974,
  "SuggestedCategoryId": 953,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 839,
  "IconHint": "dolorem",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "dolorem"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "non"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 659
    }
  }
}
```