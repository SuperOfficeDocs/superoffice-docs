---
title: POST Agents/Ticket/SetTicketReadByOwner
uid: v1TicketAgent_SetTicketReadByOwner
generated: true
---

# POST Agents/Ticket/SetTicketReadByOwner

```http
POST /api/v1/Agents/Ticket/SetTicketReadByOwner
```

Set the ReadByOwner status for a ticket.


It will only have an effect if the calling user is the same as the owner of the ticket






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/SetTicketReadByOwner?$select=name,department,category/id
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

TicketEntityId, ReadStatus, CheckEscalating 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketEntityId | Integer |  |
| ReadStatus | String |  |
| CheckEscalating | Boolean |  |

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
POST /api/v1/Agents/Ticket/SetTicketReadByOwner
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 915,
  "ReadStatus": "Green",
  "CheckEscalating": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 899,
  "Title": "labore",
  "CreatedAt": "2023-10-13T10:17:56.2072006+02:00",
  "LastChanged": "2010-12-21T10:17:56.2072006+01:00",
  "ReadByOwner": "2008-06-09T10:17:56.2072006+02:00",
  "ReadByCustomer": "2007-12-15T10:17:56.2072006+01:00",
  "FirstReadByOwner": "2011-04-12T10:17:56.2072006+02:00",
  "FirstReadByUser": "2011-05-08T10:17:56.2072006+02:00",
  "Activate": "2024-04-09T10:17:56.2072006+02:00",
  "ClosedAt": "2017-08-04T10:17:56.2072006+02:00",
  "RepliedAt": "2004-01-07T10:17:56.2072006+01:00",
  "AlertTimeout": "2003-09-23T10:17:56.2072006+02:00",
  "Deadline": "2012-01-31T10:17:56.2072006+01:00",
  "CreatedBy": null,
  "Author": "quisquam",
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
      "Position": "magni",
      "PersonId": 423,
      "Mrmrs": "consequuntur",
      "Firstname": "Ian",
      "Lastname": "Brekke",
      "MiddleName": "Balistreri, Douglas and Moen",
      "Title": "quos",
      "Description": "Reactive stable Graphic Interface",
      "Email": "nathanial@tremblay.name",
      "FullName": "Regan Considine",
      "DirectPhone": "889-458-2135",
      "FormalName": "Keeling Group",
      "CountryId": 684,
      "ContactId": 129,
      "ContactName": "Schmidt-Labadie",
      "Retired": 172,
      "Rank": 128,
      "ActiveInterests": 875,
      "ContactDepartment": "",
      "ContactCountryId": 184,
      "ContactOrgNr": "1154966",
      "FaxPhone": "029.071.5068 x313",
      "MobilePhone": "506-042-4270 x582",
      "ContactPhone": "1-283-337-1023",
      "AssociateName": "Corkery, Tromp and Daniel",
      "AssociateId": 161,
      "UsePersonAddress": false,
      "ContactFax": "unde",
      "Kanafname": "voluptatem",
      "Kanalname": "animi",
      "Post1": "delectus",
      "Post2": "non",
      "Post3": "officiis",
      "EmailName": "marlin@gerlach.info",
      "ContactFullName": "Miss Lyda Nina Murphy IV",
      "ActiveErpLinks": 151,
      "TicketPriorityId": 982,
      "SupportLanguageId": 332,
      "SupportAssociateId": 256,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 587
        }
      }
    }
  ],
  "AlertLevel": 321,
  "ConnectId": 998,
  "ReadStatus": "Green",
  "TimeToReply": 660,
  "RealTimeToReply": 542,
  "TimeToClose": 600,
  "RealTimeToClose": 317,
  "TimeSpentInternally": 741,
  "TimeSpentExternally": 119,
  "TimeSpentQueue": 383,
  "RealTimeSpentInternally": 799,
  "RealTimeSpentExternally": 343,
  "RealTimeSpentQueue": 960,
  "TimeSpent": 448,
  "HasAttachment": true,
  "NumReplies": 504,
  "NumMessages": 391,
  "FromAddress": "nobis",
  "Messages": [
    {
      "TicketMessageId": 965,
      "CreatedAt": "2008-10-23T10:17:56.2228266+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "mollitia",
      "PersonId": 341,
      "PersonFullName": "Miss Sydni Jacobi",
      "ContactId": 679,
      "ContactName": "Ernser-Hintz",
      "ContactDepartment": "",
      "NumAttachments": 253,
      "EmailHeader": "jonas@goodwinbuckridge.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "dolor",
      "Sentiment": 420,
      "SentimentConfidence": 260,
      "CreatedBy": 569,
      "ChangedAt": "2015-03-06T10:17:56.2228266+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 512
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 698,
      "Name": "Schaden, McClure and Upton",
      "ToolTip": "Qui earum est aut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 566
        }
      }
    },
    {
      "Id": 698,
      "Name": "Schaden, McClure and Upton",
      "ToolTip": "Qui earum est aut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 566
        }
      }
    }
  ],
  "Language": "et",
  "Sentiment": 109,
  "SentimentConfidence": 236,
  "SuggestedCategoryId": 957,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 418,
  "IconHint": "quia",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 645,
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "natus",
    "CustomFields2": "sint"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 866
    }
  }
}
```