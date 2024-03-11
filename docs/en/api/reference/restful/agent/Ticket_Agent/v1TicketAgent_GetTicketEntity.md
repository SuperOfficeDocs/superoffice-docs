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
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=201
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
  "TicketId": 2,
  "Title": "voluptatem",
  "CreatedAt": "2020-01-19T14:23:47.5505044+01:00",
  "LastChanged": "2010-10-09T14:23:47.5505044+02:00",
  "ReadByOwner": "2020-07-13T14:23:47.5505044+02:00",
  "ReadByCustomer": "1996-12-21T14:23:47.5505044+01:00",
  "FirstReadByOwner": "2005-06-10T14:23:47.5505044+02:00",
  "FirstReadByUser": "2022-07-10T14:23:47.5505044+02:00",
  "Activate": "2009-01-23T14:23:47.5505044+01:00",
  "ClosedAt": "2017-04-04T14:23:47.5505044+02:00",
  "RepliedAt": "2002-10-05T14:23:47.5505044+02:00",
  "AlertTimeout": "2009-01-28T14:23:47.5505044+01:00",
  "Deadline": "2006-06-13T14:23:47.5505044+02:00",
  "CreatedBy": null,
  "Author": "ex",
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
      "Position": "voluptatem",
      "PersonId": 889,
      "Mrmrs": "neque",
      "Firstname": "Onie",
      "Lastname": "West",
      "MiddleName": "Kiehn, Nitzsche and Tremblay",
      "Title": "quia",
      "Description": "Inverse tertiary moratorium",
      "Email": "alexandria.gutmann@gerhold.ca",
      "FullName": "Prof. Marco Makenzie Schumm",
      "DirectPhone": "142.198.7738 x9086",
      "FormalName": "Goldner-Gerlach",
      "CountryId": 289,
      "ContactId": 778,
      "ContactName": "Senger, Dickinson and Beatty",
      "Retired": 545,
      "Rank": 877,
      "ActiveInterests": 383,
      "ContactDepartment": "",
      "ContactCountryId": 168,
      "ContactOrgNr": "515434",
      "FaxPhone": "1-052-377-5927 x176",
      "MobilePhone": "1-709-678-3917",
      "ContactPhone": "(432)955-2614 x504",
      "AssociateName": "Kozey, Hermiston and Satterfield",
      "AssociateId": 364,
      "UsePersonAddress": false,
      "ContactFax": "eum",
      "Kanafname": "repellendus",
      "Kanalname": "necessitatibus",
      "Post1": "officiis",
      "Post2": "assumenda",
      "Post3": "reiciendis",
      "EmailName": "hertha@yundt.com",
      "ContactFullName": "Erna Crist",
      "ActiveErpLinks": 327,
      "TicketPriorityId": 676,
      "SupportLanguageId": 908,
      "SupportAssociateId": 84,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 352
        }
      }
    }
  ],
  "AlertLevel": 436,
  "ConnectId": 105,
  "ReadStatus": "Green",
  "TimeToReply": 415,
  "RealTimeToReply": 64,
  "TimeToClose": 104,
  "RealTimeToClose": 342,
  "TimeSpentInternally": 886,
  "TimeSpentExternally": 344,
  "TimeSpentQueue": 210,
  "RealTimeSpentInternally": 430,
  "RealTimeSpentExternally": 530,
  "RealTimeSpentQueue": 77,
  "TimeSpent": 126,
  "HasAttachment": false,
  "NumReplies": 550,
  "NumMessages": 95,
  "FromAddress": "esse",
  "Messages": [
    {
      "TicketMessageId": 67,
      "CreatedAt": "2001-12-25T14:23:47.5661283+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "recusandae",
      "PersonId": 853,
      "PersonFullName": "Ashleigh Glover",
      "ContactId": 485,
      "ContactName": "Williamson-Carter",
      "ContactDepartment": "",
      "NumAttachments": 173,
      "EmailHeader": "lacy@cartwrightupton.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "inventore",
      "Sentiment": 171,
      "SentimentConfidence": 479,
      "CreatedBy": 902,
      "ChangedAt": "2018-12-16T14:23:47.5661283+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 167
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 388,
      "Name": "Koepp-Berge",
      "ToolTip": "Aut minus aut cupiditate aut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 605
        }
      }
    },
    {
      "Id": 388,
      "Name": "Koepp-Berge",
      "ToolTip": "Aut minus aut cupiditate aut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 605
        }
      }
    }
  ],
  "Language": "quod",
  "Sentiment": 34,
  "SentimentConfidence": 979,
  "SuggestedCategoryId": 62,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 226,
  "IconHint": "nam",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 127,
  "ExtraFields": {
    "ExtraFields1": "quas",
    "ExtraFields2": "vel"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "voluptatem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 612
    }
  }
}
```