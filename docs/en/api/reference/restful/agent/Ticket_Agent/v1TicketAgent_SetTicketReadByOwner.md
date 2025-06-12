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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 786,
  "ReadStatus": "Green",
  "CheckEscalating": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 238,
  "Title": "optio",
  "CreatedAt": "2000-09-18T17:54:03.7733092+02:00",
  "LastChanged": "2021-07-13T17:54:03.7733092+02:00",
  "ReadByOwner": "2006-12-20T17:54:03.7733092+01:00",
  "ReadByCustomer": "2012-08-31T17:54:03.7733092+02:00",
  "FirstReadByOwner": "1999-02-10T17:54:03.7733092+01:00",
  "FirstReadByUser": "2013-10-22T17:54:03.7733092+02:00",
  "Activate": "2019-07-18T17:54:03.7733092+02:00",
  "ClosedAt": "2002-12-12T17:54:03.7733092+01:00",
  "RepliedAt": "2011-11-28T17:54:03.7733092+01:00",
  "AlertTimeout": "2001-12-01T17:54:03.7733092+01:00",
  "Deadline": "2002-01-29T17:54:03.7733092+01:00",
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
      "Position": "quisquam",
      "PersonId": 813,
      "Mrmrs": "occaecati",
      "Firstname": "Fritz",
      "Lastname": "Rippin",
      "MiddleName": "Grant, McKenzie and Tromp",
      "Title": "et",
      "Description": "Progressive user-facing Graphical User Interface",
      "Email": "alek_gulgowski@grimesschuster.info",
      "FullName": "Nicole Lowe",
      "DirectPhone": "1-071-978-2316",
      "FormalName": "Littel, Fisher and Walsh",
      "CountryId": 622,
      "ContactId": 816,
      "ContactName": "Bartoletti-Stroman",
      "Retired": 879,
      "Rank": 804,
      "ActiveInterests": 519,
      "ContactDepartment": "",
      "ContactCountryId": 518,
      "ContactOrgNr": "226263",
      "FaxPhone": "706.670.8060 x1743",
      "MobilePhone": "890-027-6922 x560",
      "ContactPhone": "(587)191-4762 x36870",
      "AssociateName": "Jacobs, Anderson and Bogisich",
      "AssociateId": 389,
      "UsePersonAddress": false,
      "ContactFax": "nam",
      "Kanafname": "porro",
      "Kanalname": "beatae",
      "Post1": "ducimus",
      "Post2": "veniam",
      "Post3": "atque",
      "EmailName": "alverta@parkerfisher.us",
      "ContactFullName": "Britney Cletus Barton DVM",
      "ActiveErpLinks": 597,
      "TicketPriorityId": 130,
      "SupportLanguageId": 883,
      "SupportAssociateId": 236,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1714896",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 474
        }
      }
    }
  ],
  "AlertLevel": 295,
  "ConnectId": 966,
  "ReadStatus": "Green",
  "TimeToReply": 599,
  "RealTimeToReply": 389,
  "TimeToClose": 806,
  "RealTimeToClose": 565,
  "TimeSpentInternally": 792,
  "TimeSpentExternally": 356,
  "TimeSpentQueue": 664,
  "RealTimeSpentInternally": 358,
  "RealTimeSpentExternally": 207,
  "RealTimeSpentQueue": 132,
  "TimeSpent": 158,
  "HasAttachment": false,
  "NumReplies": 172,
  "NumMessages": 974,
  "FromAddress": "iste",
  "Messages": [
    {
      "TicketMessageId": 219,
      "CreatedAt": "2000-10-28T17:54:03.7733092+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "necessitatibus",
      "PersonId": 93,
      "PersonFullName": "Lorenz Krajcik",
      "ContactId": 155,
      "ContactName": "Roob, Volkman and O'Hara",
      "ContactDepartment": "",
      "NumAttachments": 808,
      "EmailHeader": "robyn_goyette@reingerrogahn.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "explicabo",
      "Sentiment": 521,
      "SentimentConfidence": 539,
      "CreatedBy": 683,
      "ChangedAt": "2001-10-19T17:54:03.7733092+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 173
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 803,
      "Name": "Hodkiewicz LLC",
      "ToolTip": "Aspernatur vel.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 860
        }
      }
    },
    {
      "Id": 803,
      "Name": "Hodkiewicz LLC",
      "ToolTip": "Aspernatur vel.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 860
        }
      }
    }
  ],
  "Language": "enim",
  "Sentiment": 833,
  "SentimentConfidence": 414,
  "SuggestedCategoryId": 962,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 218,
  "IconHint": "voluptas",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 322,
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "placeat"
  },
  "CustomFields": {
    "CustomFields1": "voluptates",
    "CustomFields2": "fugit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 888
    }
  }
}
```