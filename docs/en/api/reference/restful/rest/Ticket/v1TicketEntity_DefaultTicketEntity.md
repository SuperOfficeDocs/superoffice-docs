---
title: GET Ticket/default
uid: v1TicketEntity_DefaultTicketEntity
generated: true
---

# GET Ticket/default

```http
GET /api/v1/Ticket/default
```

Set default values into a new TicketEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Ticket agent service CreateDefaultTicketEntity.







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
GET /api/v1/Ticket/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 37,
  "Title": "sunt",
  "CreatedAt": "2001-06-23T04:02:06.8534981+02:00",
  "LastChanged": "2005-03-18T04:02:06.8534981+01:00",
  "ReadByOwner": "2019-09-16T04:02:06.8534981+02:00",
  "ReadByCustomer": "2016-12-22T04:02:06.8534981+01:00",
  "FirstReadByOwner": "2015-01-17T04:02:06.8534981+01:00",
  "FirstReadByUser": "2001-05-12T04:02:06.8534981+02:00",
  "Activate": "2003-11-16T04:02:06.8534981+01:00",
  "ClosedAt": "2015-04-03T04:02:06.8534981+02:00",
  "RepliedAt": "2013-02-14T04:02:06.8534981+01:00",
  "AlertTimeout": "2003-07-15T04:02:06.8534981+02:00",
  "Deadline": "2005-09-01T04:02:06.8534981+02:00",
  "CreatedBy": null,
  "Author": "aliquam",
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
      "Position": "eaque",
      "PersonId": 259,
      "Mrmrs": "accusamus",
      "Firstname": "Raoul",
      "Lastname": "Fadel",
      "MiddleName": "Friesen-Mohr",
      "Title": "dolorem",
      "Description": "Open-architected radical project",
      "Email": "ervin.johnston@fadelschaden.co.uk",
      "FullName": "Mrs. Chadrick Moises Stehr V",
      "DirectPhone": "244.114.2345 x0012",
      "FormalName": "Sipes LLC",
      "CountryId": 303,
      "ContactId": 875,
      "ContactName": "Bednar LLC",
      "Retired": 69,
      "Rank": 597,
      "ActiveInterests": 253,
      "ContactDepartment": "",
      "ContactCountryId": 778,
      "ContactOrgNr": "1147299",
      "FaxPhone": "789.793.4526 x969",
      "MobilePhone": "939.794.3672",
      "ContactPhone": "1-165-025-3748 x5015",
      "AssociateName": "Bauch, Waters and Jewess",
      "AssociateId": 280,
      "UsePersonAddress": false,
      "ContactFax": "vel",
      "Kanafname": "nobis",
      "Kanalname": "est",
      "Post1": "sint",
      "Post2": "nihil",
      "Post3": "ut",
      "EmailName": "elenor_will@crooks.us",
      "ContactFullName": "Nikolas Rau",
      "ActiveErpLinks": 644,
      "TicketPriorityId": 639,
      "SupportLanguageId": 889,
      "SupportAssociateId": 207,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 458
        }
      }
    }
  ],
  "AlertLevel": 988,
  "ConnectId": 428,
  "ReadStatus": "Green",
  "TimeToReply": 535,
  "RealTimeToReply": 446,
  "TimeToClose": 74,
  "RealTimeToClose": 518,
  "TimeSpentInternally": 1000,
  "TimeSpentExternally": 118,
  "TimeSpentQueue": 898,
  "RealTimeSpentInternally": 452,
  "RealTimeSpentExternally": 970,
  "RealTimeSpentQueue": 655,
  "TimeSpent": 663,
  "HasAttachment": false,
  "NumReplies": 330,
  "NumMessages": 642,
  "FromAddress": "natus",
  "Messages": [
    {
      "TicketMessageId": 493,
      "CreatedAt": "2017-06-13T04:02:06.8534981+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "voluptas",
      "PersonId": 483,
      "PersonFullName": "Dr. Jarvis June Welch PhD",
      "ContactId": 261,
      "ContactName": "Upton, Cronin and Lehner",
      "ContactDepartment": "",
      "NumAttachments": 548,
      "EmailHeader": "zelma@johnston.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "vel",
      "Sentiment": 596,
      "SentimentConfidence": 25,
      "CreatedBy": 337,
      "ChangedAt": "2001-05-17T04:02:06.8534981+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 785
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 1000,
      "Name": "Lebsack LLC",
      "ToolTip": "Aliquam aut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 295
        }
      }
    },
    {
      "Id": 1000,
      "Name": "Lebsack LLC",
      "ToolTip": "Aliquam aut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 295
        }
      }
    }
  ],
  "Language": "porro",
  "Sentiment": 901,
  "SentimentConfidence": 261,
  "SuggestedCategoryId": 598,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 495,
  "IconHint": "ut",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 701,
  "ExtraFields": {
    "ExtraFields1": "deserunt",
    "ExtraFields2": "consequuntur"
  },
  "CustomFields": {
    "CustomFields1": "facilis",
    "CustomFields2": "architecto"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 103
    }
  }
}
```