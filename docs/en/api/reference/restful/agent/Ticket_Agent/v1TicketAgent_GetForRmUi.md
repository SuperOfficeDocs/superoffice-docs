---
title: POST Agents/Ticket/GetForRmUi
uid: v1TicketAgent_GetForRmUi
generated: true
content_type: reference
---

# POST Agents/Ticket/GetForRmUi

```http
POST /api/v1/Agents/Ticket/GetForRmUi
```

Get a ticket entity, adapted to the specific needs of the Request Management UI.


WARNING: This endpoint is not guaranteed to be stable/compatible between versions
NsApiSlow threshold: 2000 ms.






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
  "TicketId": 124
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 597,
  "Title": "nulla",
  "CreatedAt": "2020-01-28T03:40:47.9692321+01:00",
  "LastChanged": "2022-04-16T03:40:47.9692321+02:00",
  "ReadByOwner": "2024-11-03T03:40:47.9692321+01:00",
  "ReadByCustomer": "2023-01-29T03:40:47.9692321+01:00",
  "FirstReadByOwner": "2015-03-20T03:40:47.9692321+01:00",
  "FirstReadByUser": "2024-03-12T03:40:47.9692321+01:00",
  "Activate": "2011-04-04T03:40:47.9692321+02:00",
  "ClosedAt": "2006-02-08T03:40:47.9692321+01:00",
  "RepliedAt": "2001-08-13T03:40:47.9692321+02:00",
  "AlertTimeout": "2014-03-01T03:40:47.9692321+01:00",
  "Deadline": "2010-09-21T03:40:47.9692321+02:00",
  "CreatedBy": null,
  "Author": "est",
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
      "Position": "necessitatibus",
      "PersonId": 978,
      "Mrmrs": "nobis",
      "Firstname": "Marge",
      "Lastname": "Gaylord",
      "MiddleName": "Beatty, DuBuque and Gutkowski",
      "Title": "odio",
      "Description": "Streamlined full-range support",
      "Email": "glennie_stanton@kshlerin.uk",
      "FullName": "Mr. Dion Evie Dietrich PhD",
      "DirectPhone": "228.382.2468",
      "FormalName": "Kub Group",
      "CountryId": 949,
      "ContactId": 779,
      "ContactName": "Metz LLC",
      "Retired": 680,
      "Rank": 823,
      "ActiveInterests": 259,
      "ContactDepartment": "",
      "ContactCountryId": 442,
      "ContactOrgNr": "1506975",
      "FaxPhone": "757-972-8040 x04190",
      "MobilePhone": "024-263-5900 x1331",
      "ContactPhone": "(302)987-1423 x34758",
      "AssociateName": "Barrows, Blick and Herzog",
      "AssociateId": 993,
      "UsePersonAddress": true,
      "ContactFax": "doloremque",
      "Kanafname": "suscipit",
      "Kanalname": "rem",
      "Post1": "voluptas",
      "Post2": "quo",
      "Post3": "soluta",
      "EmailName": "harrison@nicolas.uk",
      "ContactFullName": "Payton McGlynn",
      "ActiveErpLinks": 827,
      "TicketPriorityId": 742,
      "SupportLanguageId": 564,
      "SupportAssociateId": 267,
      "CategoryName": "VIP Customer",
      "PersonNumber": "468661",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 855
        }
      }
    }
  ],
  "AlertLevel": 512,
  "ConnectId": 554,
  "ReadStatus": "Green",
  "TimeToReply": 633,
  "RealTimeToReply": 243,
  "TimeToClose": 44,
  "RealTimeToClose": 873,
  "TimeSpentInternally": 312,
  "TimeSpentExternally": 178,
  "TimeSpentQueue": 623,
  "RealTimeSpentInternally": 942,
  "RealTimeSpentExternally": 564,
  "RealTimeSpentQueue": 594,
  "TimeSpent": 619,
  "HasAttachment": true,
  "NumReplies": 383,
  "NumMessages": 823,
  "FromAddress": "incidunt",
  "Messages": [
    {
      "TicketMessageId": 426,
      "CreatedAt": "2001-03-19T03:40:47.9692321+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "veniam",
      "PersonId": 994,
      "PersonFullName": "Naomi Hills DVM",
      "ContactId": 783,
      "ContactName": "Moen-Dickinson",
      "ContactDepartment": "",
      "NumAttachments": 30,
      "EmailHeader": "kyla@wehnerondricka.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "facilis",
      "Sentiment": 281,
      "SentimentConfidence": 776,
      "CreatedBy": 543,
      "ChangedAt": "2025-04-16T03:40:47.9692321+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 434
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 960,
      "Name": "Heathcote-Doyle",
      "ToolTip": "Amet dolore unde.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 862
        }
      }
    },
    {
      "Id": 960,
      "Name": "Heathcote-Doyle",
      "ToolTip": "Amet dolore unde.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 862
        }
      }
    }
  ],
  "Language": "atque",
  "Sentiment": 302,
  "SentimentConfidence": 339,
  "SuggestedCategoryId": 315,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 483,
  "IconHint": "maxime",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 987,
  "ExtraFields": {
    "ExtraFields1": "quos",
    "ExtraFields2": "quod"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "porro"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 488
    }
  }
}
```