---
title: POST Agents/Ticket/GetTicketEntity
uid: v1TicketAgent_GetTicketEntity
generated: true
---

# POST Agents/Ticket/GetTicketEntity

```http
POST /api/v1/Agents/Ticket/GetTicketEntity
```

Gets a TicketEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ticketEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=597
POST /api/v1/Agents/Ticket/GetTicketEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Ticket/GetTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 514,
  "Title": "esse",
  "CreatedAt": "2001-02-27T12:01:28.4159512+01:00",
  "LastChanged": "2017-01-03T12:01:28.4159512+01:00",
  "ReadByOwner": "2002-03-10T12:01:28.4159512+01:00",
  "ReadByCustomer": "2002-06-30T12:01:28.4159512+02:00",
  "FirstReadByOwner": "2022-01-29T12:01:28.4159512+01:00",
  "FirstReadByUser": "2014-03-10T12:01:28.4159512+01:00",
  "Activate": "2020-09-30T12:01:28.4159512+02:00",
  "ClosedAt": "2018-03-24T12:01:28.4159512+01:00",
  "RepliedAt": "2008-08-04T12:01:28.4159512+02:00",
  "AlertTimeout": "2001-02-08T12:01:28.4159512+01:00",
  "Deadline": "2005-09-18T12:01:28.4159512+02:00",
  "CreatedBy": null,
  "Author": "ratione",
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
      "Position": "quod",
      "PersonId": 284,
      "Mrmrs": "aperiam",
      "Firstname": "Hortense",
      "Lastname": "Auer",
      "MiddleName": "Beier-Kuvalis",
      "Title": "est",
      "Description": "Upgradable static knowledge base",
      "Email": "chelsey@kertzmann.name",
      "FullName": "Alexzander Lindgren",
      "DirectPhone": "702-323-5825 x25745",
      "FormalName": "Lubowitz LLC",
      "CountryId": 611,
      "ContactId": 322,
      "ContactName": "Bartoletti-Beier",
      "Retired": 427,
      "Rank": 93,
      "ActiveInterests": 132,
      "ContactDepartment": "",
      "ContactCountryId": 747,
      "ContactOrgNr": "1045606",
      "FaxPhone": "353-713-1838",
      "MobilePhone": "1-043-084-3993",
      "ContactPhone": "314-327-3747",
      "AssociateName": "Koepp, Kuvalis and Friesen",
      "AssociateId": 238,
      "UsePersonAddress": false,
      "ContactFax": "quia",
      "Kanafname": "quae",
      "Kanalname": "dolorem",
      "Post1": "id",
      "Post2": "ullam",
      "Post3": "laudantium",
      "EmailName": "ova@hilpert.name",
      "ContactFullName": "Rylee Stroman",
      "ActiveErpLinks": 256,
      "TicketPriorityId": 252,
      "SupportLanguageId": 582,
      "SupportAssociateId": 307,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1059665",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 955
        }
      }
    }
  ],
  "AlertLevel": 491,
  "ConnectId": 666,
  "ReadStatus": "Green",
  "TimeToReply": 573,
  "RealTimeToReply": 444,
  "TimeToClose": 126,
  "RealTimeToClose": 868,
  "TimeSpentInternally": 34,
  "TimeSpentExternally": 44,
  "TimeSpentQueue": 133,
  "RealTimeSpentInternally": 609,
  "RealTimeSpentExternally": 534,
  "RealTimeSpentQueue": 520,
  "TimeSpent": 988,
  "HasAttachment": false,
  "NumReplies": 760,
  "NumMessages": 655,
  "FromAddress": "aut",
  "Messages": [
    {
      "TicketMessageId": 810,
      "CreatedAt": "2007-04-06T12:01:28.4784544+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "facilis",
      "PersonId": 340,
      "PersonFullName": "Miss Geraldine Cronin",
      "ContactId": 686,
      "ContactName": "Hane Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 357,
      "EmailHeader": "amber@keelingmueller.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "dignissimos",
      "Sentiment": 467,
      "SentimentConfidence": 944,
      "CreatedBy": 964,
      "ChangedAt": "2007-11-11T12:01:28.4784544+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 105
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 823,
      "Name": "Blick LLC",
      "ToolTip": "Exercitationem error fugit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 796
        }
      }
    },
    {
      "Id": 823,
      "Name": "Blick LLC",
      "ToolTip": "Exercitationem error fugit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 796
        }
      }
    }
  ],
  "Language": "illo",
  "Sentiment": 204,
  "SentimentConfidence": 516,
  "SuggestedCategoryId": 123,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 719,
  "IconHint": "dicta",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 94,
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "modi"
  },
  "CustomFields": {
    "CustomFields1": "fugit",
    "CustomFields2": "animi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 897
    }
  }
}
```