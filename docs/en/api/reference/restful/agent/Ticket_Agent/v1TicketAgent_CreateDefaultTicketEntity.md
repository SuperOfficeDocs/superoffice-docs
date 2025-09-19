---
title: POST Agents/Ticket/CreateDefaultTicketEntity
uid: v1TicketAgent_CreateDefaultTicketEntity
generated: true
content_type: reference
---

# POST Agents/Ticket/CreateDefaultTicketEntity

```http
POST /api/v1/Agents/Ticket/CreateDefaultTicketEntity
```

Loading default values into a new TicketEntity.








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
POST /api/v1/Agents/Ticket/CreateDefaultTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 946,
  "Title": "eos",
  "CreatedAt": "2009-11-25T03:41:54.1838303+01:00",
  "LastChanged": "2003-04-03T03:41:54.1838303+02:00",
  "ReadByOwner": "2015-11-16T03:41:54.1838303+01:00",
  "ReadByCustomer": "2000-08-20T03:41:54.1838303+02:00",
  "FirstReadByOwner": "2005-08-04T03:41:54.1838303+02:00",
  "FirstReadByUser": "2005-09-13T03:41:54.1838303+02:00",
  "Activate": "2010-04-08T03:41:54.1838303+02:00",
  "ClosedAt": "2016-02-18T03:41:54.1838303+01:00",
  "RepliedAt": "2023-12-03T03:41:54.1838303+01:00",
  "AlertTimeout": "2014-01-22T03:41:54.1838303+01:00",
  "Deadline": "2023-08-16T03:41:54.1838303+02:00",
  "CreatedBy": null,
  "Author": "laudantium",
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
      "Position": "officiis",
      "PersonId": 345,
      "Mrmrs": "autem",
      "Firstname": "Shannon",
      "Lastname": "Waters",
      "MiddleName": "Kuhn Group",
      "Title": "et",
      "Description": "Synchronised bandwidth-monitored utilisation",
      "Email": "chaya.bins@schuster.us",
      "FullName": "Alanis Lelah Dooley DVM",
      "DirectPhone": "976-163-5742",
      "FormalName": "Kessler Inc and Sons",
      "CountryId": 202,
      "ContactId": 63,
      "ContactName": "VonRueden LLC",
      "Retired": 338,
      "Rank": 793,
      "ActiveInterests": 602,
      "ContactDepartment": "",
      "ContactCountryId": 390,
      "ContactOrgNr": "1036949",
      "FaxPhone": "1-058-838-9530 x79839",
      "MobilePhone": "1-988-861-6605 x643",
      "ContactPhone": "1-784-279-4105",
      "AssociateName": "Walter, Parker and Daugherty",
      "AssociateId": 696,
      "UsePersonAddress": false,
      "ContactFax": "voluptatem",
      "Kanafname": "at",
      "Kanalname": "illum",
      "Post1": "nam",
      "Post2": "id",
      "Post3": "fugit",
      "EmailName": "hosea.kessler@hyatt.ca",
      "ContactFullName": "Ari Harber",
      "ActiveErpLinks": 710,
      "TicketPriorityId": 759,
      "SupportLanguageId": 594,
      "SupportAssociateId": 853,
      "CategoryName": "VIP Customer",
      "PersonNumber": "254959",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 830
        }
      }
    }
  ],
  "AlertLevel": 861,
  "ConnectId": 119,
  "ReadStatus": "Green",
  "TimeToReply": 760,
  "RealTimeToReply": 599,
  "TimeToClose": 299,
  "RealTimeToClose": 722,
  "TimeSpentInternally": 133,
  "TimeSpentExternally": 362,
  "TimeSpentQueue": 672,
  "RealTimeSpentInternally": 756,
  "RealTimeSpentExternally": 194,
  "RealTimeSpentQueue": 17,
  "TimeSpent": 783,
  "HasAttachment": false,
  "NumReplies": 650,
  "NumMessages": 752,
  "FromAddress": "aut",
  "Messages": [
    {
      "TicketMessageId": 40,
      "CreatedAt": "2011-07-27T03:41:54.1838303+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "quisquam",
      "PersonId": 894,
      "PersonFullName": "Ivory Johnston",
      "ContactId": 593,
      "ContactName": "Schaden LLC",
      "ContactDepartment": "",
      "NumAttachments": 703,
      "EmailHeader": "erling@towne.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "corrupti",
      "Sentiment": 43,
      "SentimentConfidence": 193,
      "CreatedBy": 356,
      "ChangedAt": "2008-05-18T03:41:54.1838303+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 9
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 836,
      "Name": "O'Connell, Hartmann and Jerde",
      "ToolTip": "Minima incidunt enim praesentium expedita architecto.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 781
        }
      }
    },
    {
      "Id": 836,
      "Name": "O'Connell, Hartmann and Jerde",
      "ToolTip": "Minima incidunt enim praesentium expedita architecto.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 781
        }
      }
    }
  ],
  "Language": "harum",
  "Sentiment": 350,
  "SentimentConfidence": 73,
  "SuggestedCategoryId": 810,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 454,
  "IconHint": "laudantium",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 845,
  "ExtraFields": {
    "ExtraFields1": "harum",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "officia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 614
    }
  }
}
```