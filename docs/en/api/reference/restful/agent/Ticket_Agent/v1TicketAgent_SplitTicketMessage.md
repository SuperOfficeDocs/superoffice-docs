---
title: POST Agents/Ticket/SplitTicketMessage
uid: v1TicketAgent_SplitTicketMessage
generated: true
---

# POST Agents/Ticket/SplitTicketMessage

```http
POST /api/v1/Agents/Ticket/SplitTicketMessage
```

Create new ticket and move/copy data from existing ticket in addition update old message and save new message in a single request.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/SplitTicketMessage?$select=name,department,category/id
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

SourceTicketMessage, NewTicketEntity, NewTicketMessage, TransferAttachmentsIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourceTicketMessage | TicketMessageEntity | The ticket messages are e-mails, SMS or other messages attached to a ticket (aka request). <para /> Carrier object for TicketMessageEntity. Services for the TicketMessageEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| NewTicketEntity | TicketEntity | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| NewTicketMessage | TicketMessageEntity | The ticket messages are e-mails, SMS or other messages attached to a ticket (aka request). <para /> Carrier object for TicketMessageEntity. Services for the TicketMessageEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| TransferAttachmentsIds | Array |  |

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
POST /api/v1/Agents/Ticket/SplitTicketMessage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SourceTicketMessage": null,
  "NewTicketEntity": null,
  "NewTicketMessage": null,
  "TransferAttachmentsIds": [
    107,
    712
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 154,
  "Title": "assumenda",
  "CreatedAt": "2012-10-19T10:17:56.2540709+02:00",
  "LastChanged": "2010-05-20T10:17:56.2540709+02:00",
  "ReadByOwner": "2013-05-12T10:17:56.2540709+02:00",
  "ReadByCustomer": "2001-02-06T10:17:56.2540709+01:00",
  "FirstReadByOwner": "2009-02-03T10:17:56.2540709+01:00",
  "FirstReadByUser": "2015-10-12T10:17:56.2540709+02:00",
  "Activate": "2021-07-14T10:17:56.2540709+02:00",
  "ClosedAt": "2016-05-19T10:17:56.2540709+02:00",
  "RepliedAt": "1998-01-27T10:17:56.2540709+01:00",
  "AlertTimeout": "1999-07-12T10:17:56.2540709+02:00",
  "Deadline": "2014-04-23T10:17:56.2540709+02:00",
  "CreatedBy": null,
  "Author": "quo",
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
      "PersonId": 94,
      "Mrmrs": "placeat",
      "Firstname": "Thelma",
      "Lastname": "Macejkovic",
      "MiddleName": "Willms, Harvey and Hudson",
      "Title": "voluptatem",
      "Description": "Seamless full-range frame",
      "Email": "adelle.casper@padberg.ca",
      "FullName": "Hans Abbott MD",
      "DirectPhone": "035-636-7348",
      "FormalName": "Kuhlman-Macejkovic",
      "CountryId": 482,
      "ContactId": 162,
      "ContactName": "Bosco, Sipes and Rolfson",
      "Retired": 919,
      "Rank": 662,
      "ActiveInterests": 292,
      "ContactDepartment": "",
      "ContactCountryId": 674,
      "ContactOrgNr": "667858",
      "FaxPhone": "439-464-4083 x456",
      "MobilePhone": "809-644-6605",
      "ContactPhone": "052.883.6628 x55999",
      "AssociateName": "Lubowitz Group",
      "AssociateId": 340,
      "UsePersonAddress": false,
      "ContactFax": "non",
      "Kanafname": "voluptas",
      "Kanalname": "dicta",
      "Post1": "laboriosam",
      "Post2": "tenetur",
      "Post3": "animi",
      "EmailName": "sonia@swaniawski.name",
      "ContactFullName": "Shane Hahn",
      "ActiveErpLinks": 103,
      "TicketPriorityId": 351,
      "SupportLanguageId": 316,
      "SupportAssociateId": 749,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 564
        }
      }
    }
  ],
  "AlertLevel": 708,
  "ConnectId": 638,
  "ReadStatus": "Green",
  "TimeToReply": 790,
  "RealTimeToReply": 769,
  "TimeToClose": 45,
  "RealTimeToClose": 188,
  "TimeSpentInternally": 406,
  "TimeSpentExternally": 811,
  "TimeSpentQueue": 502,
  "RealTimeSpentInternally": 387,
  "RealTimeSpentExternally": 449,
  "RealTimeSpentQueue": 840,
  "TimeSpent": 643,
  "HasAttachment": false,
  "NumReplies": 674,
  "NumMessages": 519,
  "FromAddress": "est",
  "Messages": [
    {
      "TicketMessageId": 953,
      "CreatedAt": "2017-11-26T10:17:56.2540709+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "rerum",
      "PersonId": 505,
      "PersonFullName": "Mr. Rose Loraine Predovic",
      "ContactId": 159,
      "ContactName": "Daniel-Towne",
      "ContactDepartment": "implement impactful methodologies",
      "NumAttachments": 326,
      "EmailHeader": "kieran_prosacco@pollichortiz.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quasi",
      "Sentiment": 165,
      "SentimentConfidence": 239,
      "CreatedBy": 333,
      "ChangedAt": "2003-06-23T10:17:56.2540709+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 566
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 887,
      "Name": "Jerde, Tromp and Jast",
      "ToolTip": "Aut quos quia voluptatem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 787
        }
      }
    },
    {
      "Id": 887,
      "Name": "Jerde, Tromp and Jast",
      "ToolTip": "Aut quos quia voluptatem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 787
        }
      }
    }
  ],
  "Language": "veniam",
  "Sentiment": 957,
  "SentimentConfidence": 715,
  "SuggestedCategoryId": 519,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 73,
  "IconHint": "suscipit",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 788,
  "ExtraFields": {
    "ExtraFields1": "possimus",
    "ExtraFields2": "autem"
  },
  "CustomFields": {
    "CustomFields1": "magni",
    "CustomFields2": "dolorum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 507
    }
  }
}
```