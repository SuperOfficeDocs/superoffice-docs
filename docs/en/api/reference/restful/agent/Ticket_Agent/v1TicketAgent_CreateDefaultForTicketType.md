---
title: POST Agents/Ticket/CreateDefaultForTicketType
uid: v1TicketAgent_CreateDefaultForTicketType
generated: true
---

# POST Agents/Ticket/CreateDefaultForTicketType

```http
POST /api/v1/Agents/Ticket/CreateDefaultForTicketType
```

Create default ticket entity for particular TicketType







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/CreateDefaultForTicketType?$select=name,department,category/id
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

TicketTypeId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketTypeId | Integer |  |

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
POST /api/v1/Agents/Ticket/CreateDefaultForTicketType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketTypeId": 172
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 273,
  "Title": "maiores",
  "CreatedAt": "2008-08-27T13:14:01.5975646+02:00",
  "LastChanged": "2006-06-12T13:14:01.5975646+02:00",
  "ReadByOwner": "1998-03-27T13:14:01.5975646+01:00",
  "ReadByCustomer": "2008-03-01T13:14:01.5975646+01:00",
  "FirstReadByOwner": "2002-10-08T13:14:01.5975646+02:00",
  "FirstReadByUser": "2008-10-01T13:14:01.5975646+02:00",
  "Activate": "1997-12-08T13:14:01.5975646+01:00",
  "ClosedAt": "1999-10-18T13:14:01.5975646+02:00",
  "RepliedAt": "2025-02-11T13:14:01.5975646+01:00",
  "AlertTimeout": "1998-10-27T13:14:01.5975646+01:00",
  "Deadline": "2006-04-28T13:14:01.5975646+02:00",
  "CreatedBy": null,
  "Author": "cumque",
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
      "Position": "nostrum",
      "PersonId": 976,
      "Mrmrs": "blanditiis",
      "Firstname": "Maribel",
      "Lastname": "Lind",
      "MiddleName": "Thompson Group",
      "Title": "suscipit",
      "Description": "Proactive upward-trending parallelism",
      "Email": "matt_cronin@willms.uk",
      "FullName": "Abdullah Olaf Bartoletti DVM",
      "DirectPhone": "896-261-6640",
      "FormalName": "Dibbert-Bode",
      "CountryId": 977,
      "ContactId": 566,
      "ContactName": "McDermott, Pollich and Von",
      "Retired": 990,
      "Rank": 929,
      "ActiveInterests": 87,
      "ContactDepartment": "",
      "ContactCountryId": 134,
      "ContactOrgNr": "952202",
      "FaxPhone": "379.202.3878 x143",
      "MobilePhone": "634-590-5710",
      "ContactPhone": "1-607-993-1136 x94008",
      "AssociateName": "Crist, Schaefer and Moore",
      "AssociateId": 521,
      "UsePersonAddress": false,
      "ContactFax": "quis",
      "Kanafname": "quidem",
      "Kanalname": "et",
      "Post1": "necessitatibus",
      "Post2": "quod",
      "Post3": "deserunt",
      "EmailName": "nikita@labadie.ca",
      "ContactFullName": "Lauren Bauch",
      "ActiveErpLinks": 233,
      "TicketPriorityId": 455,
      "SupportLanguageId": 982,
      "SupportAssociateId": 197,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1215648",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 366
        }
      }
    }
  ],
  "AlertLevel": 391,
  "ConnectId": 915,
  "ReadStatus": "Green",
  "TimeToReply": 86,
  "RealTimeToReply": 869,
  "TimeToClose": 325,
  "RealTimeToClose": 109,
  "TimeSpentInternally": 836,
  "TimeSpentExternally": 651,
  "TimeSpentQueue": 614,
  "RealTimeSpentInternally": 467,
  "RealTimeSpentExternally": 269,
  "RealTimeSpentQueue": 567,
  "TimeSpent": 209,
  "HasAttachment": true,
  "NumReplies": 438,
  "NumMessages": 216,
  "FromAddress": "sequi",
  "Messages": [
    {
      "TicketMessageId": 500,
      "CreatedAt": "2023-03-03T13:14:01.5975646+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "reprehenderit",
      "PersonId": 832,
      "PersonFullName": "Howell Bahringer I",
      "ContactId": 313,
      "ContactName": "Ledner-Boyle",
      "ContactDepartment": "",
      "NumAttachments": 87,
      "EmailHeader": "anna@jacobsjewess.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "est",
      "Sentiment": 118,
      "SentimentConfidence": 808,
      "CreatedBy": 85,
      "ChangedAt": "2015-02-18T13:14:01.5975646+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 527
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 66,
      "Name": "Zieme LLC",
      "ToolTip": "Qui minus aut recusandae adipisci reprehenderit asperiores.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 457
        }
      }
    },
    {
      "Id": 66,
      "Name": "Zieme LLC",
      "ToolTip": "Qui minus aut recusandae adipisci reprehenderit asperiores.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 457
        }
      }
    }
  ],
  "Language": "deserunt",
  "Sentiment": 14,
  "SentimentConfidence": 869,
  "SuggestedCategoryId": 350,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 957,
  "IconHint": "ipsam",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 354,
  "ExtraFields": {
    "ExtraFields1": "perferendis",
    "ExtraFields2": "dolorem"
  },
  "CustomFields": {
    "CustomFields1": "consectetur",
    "CustomFields2": "eveniet"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 726
    }
  }
}
```