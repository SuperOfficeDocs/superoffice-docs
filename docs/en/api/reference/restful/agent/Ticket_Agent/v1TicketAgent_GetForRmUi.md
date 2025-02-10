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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketId": 217
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 689,
  "Title": "tempore",
  "CreatedAt": "2016-08-01T12:01:28.4784544+02:00",
  "LastChanged": "2019-02-14T12:01:28.4784544+01:00",
  "ReadByOwner": "2022-02-22T12:01:28.4784544+01:00",
  "ReadByCustomer": "2013-10-30T12:01:28.4784544+01:00",
  "FirstReadByOwner": "2017-07-01T12:01:28.4784544+02:00",
  "FirstReadByUser": "2014-09-30T12:01:28.4784544+02:00",
  "Activate": "2014-11-08T12:01:28.4784544+01:00",
  "ClosedAt": "2021-03-29T12:01:28.4784544+02:00",
  "RepliedAt": "2006-08-29T12:01:28.4784544+02:00",
  "AlertTimeout": "2003-08-03T12:01:28.4784544+02:00",
  "Deadline": "2003-03-29T12:01:28.4784544+01:00",
  "CreatedBy": null,
  "Author": "maxime",
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
      "Position": "modi",
      "PersonId": 327,
      "Mrmrs": "reiciendis",
      "Firstname": "Alda",
      "Lastname": "Roberts",
      "MiddleName": "Haley, Heller and Rempel",
      "Title": "voluptatem",
      "Description": "Front-line impactful knowledge base",
      "Email": "kendall@koch.name",
      "FullName": "Leonor Cheyanne Haag Jr.",
      "DirectPhone": "1-255-941-7071",
      "FormalName": "Torp-Lind",
      "CountryId": 932,
      "ContactId": 609,
      "ContactName": "Donnelly LLC",
      "Retired": 201,
      "Rank": 57,
      "ActiveInterests": 173,
      "ContactDepartment": "",
      "ContactCountryId": 3,
      "ContactOrgNr": "1189036",
      "FaxPhone": "681-308-3338 x31318",
      "MobilePhone": "1-387-587-3606",
      "ContactPhone": "(836)007-5619 x723",
      "AssociateName": "Schumm-Larson",
      "AssociateId": 45,
      "UsePersonAddress": false,
      "ContactFax": "laudantium",
      "Kanafname": "veniam",
      "Kanalname": "quidem",
      "Post1": "quia",
      "Post2": "ipsa",
      "Post3": "ex",
      "EmailName": "denis.sporer@muller.uk",
      "ContactFullName": "Mrs. Bonita Rempel MD",
      "ActiveErpLinks": 811,
      "TicketPriorityId": 534,
      "SupportLanguageId": 12,
      "SupportAssociateId": 340,
      "CategoryName": "VIP Customer",
      "PersonNumber": "840263",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 700
        }
      }
    }
  ],
  "AlertLevel": 373,
  "ConnectId": 663,
  "ReadStatus": "Green",
  "TimeToReply": 758,
  "RealTimeToReply": 941,
  "TimeToClose": 882,
  "RealTimeToClose": 638,
  "TimeSpentInternally": 686,
  "TimeSpentExternally": 141,
  "TimeSpentQueue": 919,
  "RealTimeSpentInternally": 362,
  "RealTimeSpentExternally": 3,
  "RealTimeSpentQueue": 747,
  "TimeSpent": 684,
  "HasAttachment": true,
  "NumReplies": 844,
  "NumMessages": 466,
  "FromAddress": "magnam",
  "Messages": [
    {
      "TicketMessageId": 951,
      "CreatedAt": "2023-11-19T12:01:28.4784544+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "doloribus",
      "PersonId": 603,
      "PersonFullName": "Mr. Madie Rodriguez Jr.",
      "ContactId": 871,
      "ContactName": "Volkman, Schultz and Miller",
      "ContactDepartment": "",
      "NumAttachments": 420,
      "EmailHeader": "clemens@brakus.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "officia",
      "Sentiment": 545,
      "SentimentConfidence": 347,
      "CreatedBy": 598,
      "ChangedAt": "2016-09-04T12:01:28.4784544+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 497
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 267,
      "Name": "Keebler-Weber",
      "ToolTip": "Officiis fugit et est.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 430
        }
      }
    },
    {
      "Id": 267,
      "Name": "Keebler-Weber",
      "ToolTip": "Officiis fugit et est.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 430
        }
      }
    }
  ],
  "Language": "dignissimos",
  "Sentiment": 53,
  "SentimentConfidence": 924,
  "SuggestedCategoryId": 774,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 366,
  "IconHint": "quis",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 755,
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "quidem",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 883
    }
  }
}
```