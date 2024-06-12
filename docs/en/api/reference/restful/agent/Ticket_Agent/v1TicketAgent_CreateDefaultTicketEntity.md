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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 247,
  "Title": "aspernatur",
  "CreatedAt": "2000-03-07T04:22:27.8338748+01:00",
  "LastChanged": "1999-07-21T04:22:27.8338748+02:00",
  "ReadByOwner": "2007-01-09T04:22:27.8338748+01:00",
  "ReadByCustomer": "2002-02-11T04:22:27.8338748+01:00",
  "FirstReadByOwner": "2023-04-17T04:22:27.8338748+02:00",
  "FirstReadByUser": "2009-07-21T04:22:27.8338748+02:00",
  "Activate": "2007-03-01T04:22:27.8338748+01:00",
  "ClosedAt": "2015-02-03T04:22:27.8338748+01:00",
  "RepliedAt": "2018-01-27T04:22:27.8338748+01:00",
  "AlertTimeout": "2020-06-07T04:22:27.8338748+02:00",
  "Deadline": "2002-04-03T04:22:27.8338748+02:00",
  "CreatedBy": null,
  "Author": "illum",
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
      "Position": "facere",
      "PersonId": 598,
      "Mrmrs": "ut",
      "Firstname": "Nona",
      "Lastname": "Goodwin",
      "MiddleName": "Nicolas, Pacocha and Leuschke",
      "Title": "optio",
      "Description": "Fully-configurable real-time encryption",
      "Email": "emilia.haag@schulist.com",
      "FullName": "Mrs. Candice Loren Effertz",
      "DirectPhone": "658-716-3529 x51928",
      "FormalName": "Glover, Prohaska and Hamill",
      "CountryId": 38,
      "ContactId": 781,
      "ContactName": "Reichert Group",
      "Retired": 516,
      "Rank": 440,
      "ActiveInterests": 591,
      "ContactDepartment": "",
      "ContactCountryId": 205,
      "ContactOrgNr": "1864795",
      "FaxPhone": "013-811-6003",
      "MobilePhone": "(707)103-1457 x8913",
      "ContactPhone": "1-893-926-7255 x151",
      "AssociateName": "Mayert-Olson",
      "AssociateId": 947,
      "UsePersonAddress": false,
      "ContactFax": "doloremque",
      "Kanafname": "velit",
      "Kanalname": "alias",
      "Post1": "voluptas",
      "Post2": "deleniti",
      "Post3": "temporibus",
      "EmailName": "jasen.hudson@hackett.info",
      "ContactFullName": "Estella Witting",
      "ActiveErpLinks": 217,
      "TicketPriorityId": 986,
      "SupportLanguageId": 814,
      "SupportAssociateId": 115,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 107
        }
      }
    }
  ],
  "AlertLevel": 327,
  "ConnectId": 675,
  "ReadStatus": "Green",
  "TimeToReply": 42,
  "RealTimeToReply": 185,
  "TimeToClose": 997,
  "RealTimeToClose": 178,
  "TimeSpentInternally": 791,
  "TimeSpentExternally": 104,
  "TimeSpentQueue": 80,
  "RealTimeSpentInternally": 44,
  "RealTimeSpentExternally": 993,
  "RealTimeSpentQueue": 135,
  "TimeSpent": 185,
  "HasAttachment": false,
  "NumReplies": 634,
  "NumMessages": 682,
  "FromAddress": "modi",
  "Messages": [
    {
      "TicketMessageId": 892,
      "CreatedAt": "2017-07-08T04:22:27.8338748+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "error",
      "PersonId": 6,
      "PersonFullName": "Lesly Jayme Stracke PhD",
      "ContactId": 934,
      "ContactName": "Prosacco Group",
      "ContactDepartment": "",
      "NumAttachments": 409,
      "EmailHeader": "aryanna_douglas@hoppe.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "inventore",
      "Sentiment": 639,
      "SentimentConfidence": 947,
      "CreatedBy": 30,
      "ChangedAt": "1998-05-24T04:22:27.8338748+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 459
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 15,
      "Name": "Blick, Mueller and Lang",
      "ToolTip": "Voluptatem repellat aut placeat et.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 404
        }
      }
    },
    {
      "Id": 15,
      "Name": "Blick, Mueller and Lang",
      "ToolTip": "Voluptatem repellat aut placeat et.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 404
        }
      }
    }
  ],
  "Language": "ut",
  "Sentiment": 147,
  "SentimentConfidence": 601,
  "SuggestedCategoryId": 6,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 425,
  "IconHint": "et",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 80,
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "deserunt"
  },
  "CustomFields": {
    "CustomFields1": "reiciendis",
    "CustomFields2": "ratione"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 505
    }
  }
}
```