---
title: POST Agents/Ticket/CreateDefaultTicketEntity
uid: v1TicketAgent_CreateDefaultTicketEntity
generated: true
---

# POST Agents/Ticket/CreateDefaultTicketEntity

```http
POST /api/v1/Agents/Ticket/CreateDefaultTicketEntity
```

Set default values into a new TicketEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
  "TicketId": 389,
  "Title": "et",
  "CreatedAt": "2018-02-13T12:57:35.0239366+01:00",
  "LastChanged": "2006-09-02T12:57:35.0239366+02:00",
  "ReadByOwner": "2015-04-06T12:57:35.0239366+02:00",
  "ReadByCustomer": "2010-07-05T12:57:35.0239366+02:00",
  "FirstReadByOwner": "2023-07-30T12:57:35.0239366+02:00",
  "FirstReadByUser": "2023-05-25T12:57:35.0239366+02:00",
  "Activate": "2014-10-14T12:57:35.0239366+02:00",
  "ClosedAt": "2009-04-19T12:57:35.0239366+02:00",
  "RepliedAt": "2017-08-31T12:57:35.0239366+02:00",
  "AlertTimeout": "2013-01-21T12:57:35.0239366+01:00",
  "Deadline": "2011-09-04T12:57:35.0239366+02:00",
  "CreatedBy": null,
  "Author": "unde",
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
      "Position": "eum",
      "PersonId": 784,
      "Mrmrs": "et",
      "Firstname": "Joanie",
      "Lastname": "Kuvalis",
      "MiddleName": "Nienow, Morissette and Moore",
      "Title": "similique",
      "Description": "Future-proofed system-worthy contingency",
      "Email": "derick.konopelski@emard.com",
      "FullName": "Daisha Gulgowski",
      "DirectPhone": "070.204.8232 x0163",
      "FormalName": "Wilderman, Veum and Gibson",
      "CountryId": 793,
      "ContactId": 88,
      "ContactName": "Boehm, Greenholt and D'Amore",
      "Retired": 796,
      "Rank": 115,
      "ActiveInterests": 43,
      "ContactDepartment": "",
      "ContactCountryId": 384,
      "ContactOrgNr": "1079906",
      "FaxPhone": "1-321-967-4355",
      "MobilePhone": "(178)579-9292 x9525",
      "ContactPhone": "253-646-4880 x2665",
      "AssociateName": "Smith Inc and Sons",
      "AssociateId": 251,
      "UsePersonAddress": false,
      "ContactFax": "quia",
      "Kanafname": "non",
      "Kanalname": "numquam",
      "Post1": "eligendi",
      "Post2": "ut",
      "Post3": "neque",
      "EmailName": "salma@kautzer.us",
      "ContactFullName": "Ms. Sean Altenwerth MD",
      "ActiveErpLinks": 405,
      "TicketPriorityId": 246,
      "SupportLanguageId": 307,
      "SupportAssociateId": 797,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 256
        }
      }
    }
  ],
  "AlertLevel": 200,
  "ConnectId": 842,
  "ReadStatus": "Green",
  "TimeToReply": 708,
  "RealTimeToReply": 138,
  "TimeToClose": 360,
  "RealTimeToClose": 757,
  "TimeSpentInternally": 791,
  "TimeSpentExternally": 557,
  "TimeSpentQueue": 491,
  "RealTimeSpentInternally": 669,
  "RealTimeSpentExternally": 670,
  "RealTimeSpentQueue": 806,
  "TimeSpent": 95,
  "HasAttachment": false,
  "NumReplies": 708,
  "NumMessages": 312,
  "FromAddress": "sequi",
  "Messages": [
    {
      "TicketMessageId": 251,
      "CreatedAt": "2000-11-01T12:57:35.0395582+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "vel",
      "PersonId": 210,
      "PersonFullName": "Katlyn Hegmann",
      "ContactId": 507,
      "ContactName": "Howe-Haley",
      "ContactDepartment": "expedite global users",
      "NumAttachments": 900,
      "EmailHeader": "sallie_hilll@reichel.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "velit",
      "Sentiment": 762,
      "SentimentConfidence": 351,
      "CreatedBy": 876,
      "ChangedAt": "1999-04-02T12:57:35.0395582+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 541
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 480,
      "Name": "Sawayn Inc and Sons",
      "ToolTip": "Quasi unde dolorem eveniet accusantium a non repellat.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 329
        }
      }
    },
    {
      "Id": 480,
      "Name": "Sawayn Inc and Sons",
      "ToolTip": "Quasi unde dolorem eveniet accusantium a non repellat.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 329
        }
      }
    }
  ],
  "Language": "autem",
  "Sentiment": 472,
  "SentimentConfidence": 380,
  "SuggestedCategoryId": 48,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 711,
  "IconHint": "qui",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 771,
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "quis"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 422
    }
  }
}
```