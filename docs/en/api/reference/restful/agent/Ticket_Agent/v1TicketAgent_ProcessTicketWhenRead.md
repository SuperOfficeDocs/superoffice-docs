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
POST /api/v1/Agents/Ticket/ProcessTicketWhenRead
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 424
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 784,
  "Title": "id",
  "CreatedAt": "2007-03-28T16:54:56.5076463+02:00",
  "LastChanged": "2010-09-09T16:54:56.5076463+02:00",
  "ReadByOwner": "2017-02-01T16:54:56.5076463+01:00",
  "ReadByCustomer": "2002-07-22T16:54:56.5076463+02:00",
  "FirstReadByOwner": "2012-09-22T16:54:56.5076463+02:00",
  "FirstReadByUser": "1997-07-21T16:54:56.5076463+02:00",
  "Activate": "2020-04-02T16:54:56.5076463+02:00",
  "ClosedAt": "2016-01-30T16:54:56.5076463+01:00",
  "RepliedAt": "2018-03-29T16:54:56.5076463+02:00",
  "AlertTimeout": "2015-02-09T16:54:56.5076463+01:00",
  "Deadline": "2010-08-05T16:54:56.5076463+02:00",
  "CreatedBy": null,
  "Author": "consequatur",
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
      "Position": "reiciendis",
      "PersonId": 454,
      "Mrmrs": "eos",
      "Firstname": "Corine",
      "Lastname": "Towne",
      "MiddleName": "Marvin Inc and Sons",
      "Title": "accusantium",
      "Description": "Right-sized stable forecast",
      "Email": "theresa@lueilwitz.name",
      "FullName": "Marianne Strosin",
      "DirectPhone": "646-894-6558 x170",
      "FormalName": "Larkin Group",
      "CountryId": 662,
      "ContactId": 412,
      "ContactName": "Daniel-Dibbert",
      "Retired": 74,
      "Rank": 481,
      "ActiveInterests": 702,
      "ContactDepartment": "",
      "ContactCountryId": 564,
      "ContactOrgNr": "749260",
      "FaxPhone": "506.895.5636",
      "MobilePhone": "1-864-146-9680 x6223",
      "ContactPhone": "(628)268-7191",
      "AssociateName": "Senger Inc and Sons",
      "AssociateId": 89,
      "UsePersonAddress": false,
      "ContactFax": "vero",
      "Kanafname": "explicabo",
      "Kanalname": "qui",
      "Post1": "accusamus",
      "Post2": "assumenda",
      "Post3": "incidunt",
      "EmailName": "ashlynn@smitham.ca",
      "ContactFullName": "Johanna Stoltenberg",
      "ActiveErpLinks": 143,
      "TicketPriorityId": 364,
      "SupportLanguageId": 719,
      "SupportAssociateId": 728,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 213
        }
      }
    }
  ],
  "AlertLevel": 695,
  "ConnectId": 63,
  "ReadStatus": "Green",
  "TimeToReply": 910,
  "RealTimeToReply": 871,
  "TimeToClose": 564,
  "RealTimeToClose": 723,
  "TimeSpentInternally": 132,
  "TimeSpentExternally": 925,
  "TimeSpentQueue": 55,
  "RealTimeSpentInternally": 770,
  "RealTimeSpentExternally": 432,
  "RealTimeSpentQueue": 613,
  "TimeSpent": 390,
  "HasAttachment": true,
  "NumReplies": 257,
  "NumMessages": 623,
  "FromAddress": "dignissimos",
  "Messages": [
    {
      "TicketMessageId": 585,
      "CreatedAt": "2020-05-25T16:54:56.5116462+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "saepe",
      "PersonId": 71,
      "PersonFullName": "Eldon Feeney",
      "ContactId": 312,
      "ContactName": "Stamm LLC",
      "ContactDepartment": "",
      "NumAttachments": 510,
      "EmailHeader": "nikita.hintz@hilpert.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ipsa",
      "Sentiment": 197,
      "SentimentConfidence": 56,
      "CreatedBy": 415,
      "ChangedAt": "2014-07-13T16:54:56.5116462+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 266
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 281,
      "Name": "Pouros-Cartwright",
      "ToolTip": "Omnis temporibus quibusdam molestias possimus officia.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 221
        }
      }
    },
    {
      "Id": 281,
      "Name": "Pouros-Cartwright",
      "ToolTip": "Omnis temporibus quibusdam molestias possimus officia.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 221
        }
      }
    }
  ],
  "Language": "nihil",
  "Sentiment": 250,
  "SentimentConfidence": 469,
  "SuggestedCategoryId": 954,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 334,
  "IconHint": "vel",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 830,
  "ExtraFields": {
    "ExtraFields1": "sapiente",
    "ExtraFields2": "fugit"
  },
  "CustomFields": {
    "CustomFields1": "eum",
    "CustomFields2": "debitis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 990
    }
  }
}
```