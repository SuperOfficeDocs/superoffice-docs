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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 877
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 754,
  "Title": "et",
  "CreatedAt": "2011-12-27T10:17:56.2384453+01:00",
  "LastChanged": "2020-11-03T10:17:56.2384453+01:00",
  "ReadByOwner": "2009-10-12T10:17:56.2384453+02:00",
  "ReadByCustomer": "2010-06-26T10:17:56.2384453+02:00",
  "FirstReadByOwner": "2016-04-24T10:17:56.2384453+02:00",
  "FirstReadByUser": "2003-02-16T10:17:56.2384453+01:00",
  "Activate": "2002-12-26T10:17:56.2384453+01:00",
  "ClosedAt": "2020-07-26T10:17:56.2384453+02:00",
  "RepliedAt": "2009-04-19T10:17:56.2384453+02:00",
  "AlertTimeout": "1997-11-30T10:17:56.2384453+01:00",
  "Deadline": "2024-06-07T10:17:56.2384453+02:00",
  "CreatedBy": null,
  "Author": "dolor",
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
      "Position": "ipsam",
      "PersonId": 48,
      "Mrmrs": "corporis",
      "Firstname": "Leopoldo",
      "Lastname": "Carroll",
      "MiddleName": "Kohler-Schmidt",
      "Title": "aut",
      "Description": "Open-source value-added initiative",
      "Email": "laila_gerlach@muller.co.uk",
      "FullName": "Taurean Witting",
      "DirectPhone": "(982)350-0103 x75964",
      "FormalName": "Conroy, Murray and Walker",
      "CountryId": 971,
      "ContactId": 708,
      "ContactName": "Senger Inc and Sons",
      "Retired": 516,
      "Rank": 313,
      "ActiveInterests": 949,
      "ContactDepartment": "",
      "ContactCountryId": 841,
      "ContactOrgNr": "910325",
      "FaxPhone": "690-614-6716 x306",
      "MobilePhone": "593-579-4268 x55643",
      "ContactPhone": "262.771.9122 x36427",
      "AssociateName": "Sauer-Nolan",
      "AssociateId": 394,
      "UsePersonAddress": true,
      "ContactFax": "soluta",
      "Kanafname": "placeat",
      "Kanalname": "aut",
      "Post1": "ullam",
      "Post2": "necessitatibus",
      "Post3": "consectetur",
      "EmailName": "cleveland@jerde.uk",
      "ContactFullName": "Miss Adah Alfreda Kuvalis DDS",
      "ActiveErpLinks": 263,
      "TicketPriorityId": 439,
      "SupportLanguageId": 731,
      "SupportAssociateId": 63,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 917
        }
      }
    }
  ],
  "AlertLevel": 894,
  "ConnectId": 159,
  "ReadStatus": "Green",
  "TimeToReply": 537,
  "RealTimeToReply": 262,
  "TimeToClose": 323,
  "RealTimeToClose": 518,
  "TimeSpentInternally": 453,
  "TimeSpentExternally": 561,
  "TimeSpentQueue": 733,
  "RealTimeSpentInternally": 500,
  "RealTimeSpentExternally": 499,
  "RealTimeSpentQueue": 68,
  "TimeSpent": 476,
  "HasAttachment": false,
  "NumReplies": 568,
  "NumMessages": 410,
  "FromAddress": "similique",
  "Messages": [
    {
      "TicketMessageId": 97,
      "CreatedAt": "2020-02-02T10:17:56.2384453+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "distinctio",
      "PersonId": 742,
      "PersonFullName": "Mara Monahan",
      "ContactId": 559,
      "ContactName": "Volkman LLC",
      "ContactDepartment": "",
      "NumAttachments": 459,
      "EmailHeader": "kane@mosciski.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "culpa",
      "Sentiment": 380,
      "SentimentConfidence": 224,
      "CreatedBy": 667,
      "ChangedAt": "2021-07-22T10:17:56.2384453+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 294
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 699,
      "Name": "Littel Group",
      "ToolTip": "Culpa et rerum doloremque ut vel et quis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 45
        }
      }
    },
    {
      "Id": 699,
      "Name": "Littel Group",
      "ToolTip": "Culpa et rerum doloremque ut vel et quis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 45
        }
      }
    }
  ],
  "Language": "dolor",
  "Sentiment": 33,
  "SentimentConfidence": 429,
  "SuggestedCategoryId": 918,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 745,
  "IconHint": "voluptatem",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 824,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "pariatur"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "in"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 732
    }
  }
}
```