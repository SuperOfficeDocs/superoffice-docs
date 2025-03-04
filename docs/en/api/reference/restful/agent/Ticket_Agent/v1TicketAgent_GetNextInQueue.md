---
title: POST Agents/Ticket/GetNextInQueue
uid: v1TicketAgent_GetNextInQueue
generated: true
---

# POST Agents/Ticket/GetNextInQueue

```http
POST /api/v1/Agents/Ticket/GetNextInQueue
```

Assign a ticket to the caller based on intelligent queue system







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetNextInQueue?$select=name,department,category/id
```


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
POST /api/v1/Agents/Ticket/GetNextInQueue
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 587,
  "Title": "amet",
  "CreatedAt": "2005-09-15T14:13:41.5008042+02:00",
  "LastChanged": "2017-02-20T14:13:41.5008042+01:00",
  "ReadByOwner": "2006-04-22T14:13:41.5008042+02:00",
  "ReadByCustomer": "2006-12-19T14:13:41.5008042+01:00",
  "FirstReadByOwner": "1997-10-31T14:13:41.5008042+01:00",
  "FirstReadByUser": "2000-03-10T14:13:41.5008042+01:00",
  "Activate": "2009-08-25T14:13:41.5008042+02:00",
  "ClosedAt": "2012-04-28T14:13:41.5008042+02:00",
  "RepliedAt": "2008-12-06T14:13:41.5008042+01:00",
  "AlertTimeout": "2016-05-31T14:13:41.5008042+02:00",
  "Deadline": "2023-06-27T14:13:41.5008042+02:00",
  "CreatedBy": null,
  "Author": "maiores",
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
      "Position": "quos",
      "PersonId": 255,
      "Mrmrs": "accusantium",
      "Firstname": "Evie",
      "Lastname": "Kulas",
      "MiddleName": "Anderson Group",
      "Title": "consequatur",
      "Description": "Cross-group context-sensitive architecture",
      "Email": "kolby@moore.us",
      "FullName": "Angel Powlowski",
      "DirectPhone": "340.616.0834",
      "FormalName": "Veum-Russel",
      "CountryId": 866,
      "ContactId": 415,
      "ContactName": "Dickens-Roob",
      "Retired": 159,
      "Rank": 119,
      "ActiveInterests": 474,
      "ContactDepartment": "",
      "ContactCountryId": 687,
      "ContactOrgNr": "717391",
      "FaxPhone": "(737)188-9281 x7215",
      "MobilePhone": "901-096-2132 x29288",
      "ContactPhone": "(727)019-5401",
      "AssociateName": "Pollich, Bednar and Huel",
      "AssociateId": 344,
      "UsePersonAddress": false,
      "ContactFax": "voluptatem",
      "Kanafname": "rerum",
      "Kanalname": "recusandae",
      "Post1": "quis",
      "Post2": "beatae",
      "Post3": "unde",
      "EmailName": "domenic@medhurstrodriguez.uk",
      "ContactFullName": "Dr. Randi Hilpert Jr.",
      "ActiveErpLinks": 884,
      "TicketPriorityId": 970,
      "SupportLanguageId": 228,
      "SupportAssociateId": 981,
      "CategoryName": "VIP Customer",
      "PersonNumber": "752001",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 657
        }
      }
    }
  ],
  "AlertLevel": 92,
  "ConnectId": 635,
  "ReadStatus": "Green",
  "TimeToReply": 292,
  "RealTimeToReply": 368,
  "TimeToClose": 187,
  "RealTimeToClose": 13,
  "TimeSpentInternally": 186,
  "TimeSpentExternally": 287,
  "TimeSpentQueue": 247,
  "RealTimeSpentInternally": 527,
  "RealTimeSpentExternally": 136,
  "RealTimeSpentQueue": 73,
  "TimeSpent": 870,
  "HasAttachment": true,
  "NumReplies": 534,
  "NumMessages": 181,
  "FromAddress": "dolorem",
  "Messages": [
    {
      "TicketMessageId": 414,
      "CreatedAt": "2011-01-19T14:13:41.5008042+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "quo",
      "PersonId": 360,
      "PersonFullName": "Francisca Goyette",
      "ContactId": 674,
      "ContactName": "Douglas-Rosenbaum",
      "ContactDepartment": "",
      "NumAttachments": 179,
      "EmailHeader": "rene@harris.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "blanditiis",
      "Sentiment": 435,
      "SentimentConfidence": 224,
      "CreatedBy": 366,
      "ChangedAt": "2019-09-02T14:13:41.5008042+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 656
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 706,
      "Name": "Gottlieb Inc and Sons",
      "ToolTip": "Nemo architecto sit doloribus amet.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 46
        }
      }
    },
    {
      "Id": 706,
      "Name": "Gottlieb Inc and Sons",
      "ToolTip": "Nemo architecto sit doloribus amet.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 46
        }
      }
    }
  ],
  "Language": "aut",
  "Sentiment": 538,
  "SentimentConfidence": 886,
  "SuggestedCategoryId": 273,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 153,
  "IconHint": "odio",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 417,
  "ExtraFields": {
    "ExtraFields1": "placeat",
    "ExtraFields2": "ipsum"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "non"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 626
    }
  }
}
```