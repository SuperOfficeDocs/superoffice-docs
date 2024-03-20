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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 828,
  "Title": "esse",
  "CreatedAt": "2021-04-01T12:19:46.4451211+02:00",
  "LastChanged": "2000-08-07T12:19:46.4451211+02:00",
  "ReadByOwner": "2004-02-04T12:19:46.4451211+01:00",
  "ReadByCustomer": "2010-07-06T12:19:46.4451211+02:00",
  "FirstReadByOwner": "2011-11-25T12:19:46.4451211+01:00",
  "FirstReadByUser": "2002-10-06T12:19:46.4451211+02:00",
  "Activate": "2021-01-08T12:19:46.4451211+01:00",
  "ClosedAt": "2017-05-04T12:19:46.4451211+02:00",
  "RepliedAt": "2004-12-22T12:19:46.4451211+01:00",
  "AlertTimeout": "2019-03-18T12:19:46.4451211+01:00",
  "Deadline": "2002-01-31T12:19:46.4451211+01:00",
  "CreatedBy": null,
  "Author": "et",
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
      "Position": "repellat",
      "PersonId": 711,
      "Mrmrs": "harum",
      "Firstname": "Trevor",
      "Lastname": "Kessler",
      "MiddleName": "Smith-Reichert",
      "Title": "voluptatem",
      "Description": "Proactive scalable focus group",
      "Email": "elbert.pollich@corwin.co.uk",
      "FullName": "Katherine Herzog",
      "DirectPhone": "1-436-286-7874",
      "FormalName": "Wisoky-Marvin",
      "CountryId": 890,
      "ContactId": 289,
      "ContactName": "Reilly Inc and Sons",
      "Retired": 670,
      "Rank": 50,
      "ActiveInterests": 834,
      "ContactDepartment": "",
      "ContactCountryId": 715,
      "ContactOrgNr": "826844",
      "FaxPhone": "828.667.8420 x91806",
      "MobilePhone": "455.379.5520",
      "ContactPhone": "(112)486-3883 x7470",
      "AssociateName": "Corwin-Abshire",
      "AssociateId": 309,
      "UsePersonAddress": true,
      "ContactFax": "voluptatibus",
      "Kanafname": "exercitationem",
      "Kanalname": "porro",
      "Post1": "alias",
      "Post2": "accusamus",
      "Post3": "recusandae",
      "EmailName": "ruby@dicki.name",
      "ContactFullName": "Loraine Keebler",
      "ActiveErpLinks": 938,
      "TicketPriorityId": 328,
      "SupportLanguageId": 112,
      "SupportAssociateId": 871,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 3
        }
      }
    }
  ],
  "AlertLevel": 75,
  "ConnectId": 468,
  "ReadStatus": "Green",
  "TimeToReply": 16,
  "RealTimeToReply": 311,
  "TimeToClose": 328,
  "RealTimeToClose": 693,
  "TimeSpentInternally": 755,
  "TimeSpentExternally": 633,
  "TimeSpentQueue": 655,
  "RealTimeSpentInternally": 350,
  "RealTimeSpentExternally": 57,
  "RealTimeSpentQueue": 179,
  "TimeSpent": 754,
  "HasAttachment": true,
  "NumReplies": 650,
  "NumMessages": 779,
  "FromAddress": "est",
  "Messages": [
    {
      "TicketMessageId": 625,
      "CreatedAt": "2004-05-07T12:19:46.4451211+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "autem",
      "PersonId": 57,
      "PersonFullName": "Mrs. Kyler Fritsch Sr.",
      "ContactId": 808,
      "ContactName": "Cruickshank-Denesik",
      "ContactDepartment": "",
      "NumAttachments": 171,
      "EmailHeader": "ismael.dooley@bayer.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "perferendis",
      "Sentiment": 871,
      "SentimentConfidence": 892,
      "CreatedBy": 749,
      "ChangedAt": "2006-05-10T12:19:46.4451211+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 932
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 378,
      "Name": "Osinski LLC",
      "ToolTip": "Aspernatur atque et quibusdam sit natus ut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 833
        }
      }
    },
    {
      "Id": 378,
      "Name": "Osinski LLC",
      "ToolTip": "Aspernatur atque et quibusdam sit natus ut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 833
        }
      }
    }
  ],
  "Language": "ducimus",
  "Sentiment": 810,
  "SentimentConfidence": 388,
  "SuggestedCategoryId": 571,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 911,
  "IconHint": "sapiente",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 213,
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "voluptates",
    "CustomFields2": "quia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 988
    }
  }
}
```