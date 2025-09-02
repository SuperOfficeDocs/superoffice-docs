---
title: POST Agents/Ticket/SplitTicketMessage
uid: v1TicketAgent_SplitTicketMessage
generated: true
content_type: reference
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
    859,
    418
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 655,
  "Title": "vel",
  "CreatedAt": "2017-03-17T03:46:55.5038556+01:00",
  "LastChanged": "2021-01-23T03:46:55.5038556+01:00",
  "ReadByOwner": "2018-03-15T03:46:55.5038556+01:00",
  "ReadByCustomer": "2005-11-19T03:46:55.5038556+01:00",
  "FirstReadByOwner": "1998-09-27T03:46:55.5038556+02:00",
  "FirstReadByUser": "2011-05-17T03:46:55.5038556+02:00",
  "Activate": "2002-07-03T03:46:55.5038556+02:00",
  "ClosedAt": "2023-05-13T03:46:55.5038556+02:00",
  "RepliedAt": "2002-03-25T03:46:55.5038556+01:00",
  "AlertTimeout": "2018-10-03T03:46:55.5038556+02:00",
  "Deadline": "1998-04-30T03:46:55.5038556+02:00",
  "CreatedBy": null,
  "Author": "ut",
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
      "Position": "ratione",
      "PersonId": 362,
      "Mrmrs": "et",
      "Firstname": "Talon",
      "Lastname": "Koch",
      "MiddleName": "Blanda-Quigley",
      "Title": "sit",
      "Description": "Enhanced heuristic pricing structure",
      "Email": "axel_wiza@stehr.uk",
      "FullName": "Dixie Jacobi Jr.",
      "DirectPhone": "934-386-3375 x5468",
      "FormalName": "Ledner, Pfannerstill and Robel",
      "CountryId": 962,
      "ContactId": 448,
      "ContactName": "Schmeler, Schinner and Keebler",
      "Retired": 377,
      "Rank": 593,
      "ActiveInterests": 608,
      "ContactDepartment": "implement rich niches",
      "ContactCountryId": 406,
      "ContactOrgNr": "376142",
      "FaxPhone": "1-245-631-6187",
      "MobilePhone": "453-718-3729 x86684",
      "ContactPhone": "564.450.2358",
      "AssociateName": "Stark-Waters",
      "AssociateId": 372,
      "UsePersonAddress": false,
      "ContactFax": "reiciendis",
      "Kanafname": "omnis",
      "Kanalname": "consequatur",
      "Post1": "nisi",
      "Post2": "aut",
      "Post3": "ab",
      "EmailName": "ignacio@ziemann.uk",
      "ContactFullName": "Prof. Ryley Bogan",
      "ActiveErpLinks": 846,
      "TicketPriorityId": 242,
      "SupportLanguageId": 694,
      "SupportAssociateId": 215,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1823339",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 890
        }
      }
    }
  ],
  "AlertLevel": 484,
  "ConnectId": 428,
  "ReadStatus": "Green",
  "TimeToReply": 563,
  "RealTimeToReply": 860,
  "TimeToClose": 500,
  "RealTimeToClose": 635,
  "TimeSpentInternally": 411,
  "TimeSpentExternally": 376,
  "TimeSpentQueue": 438,
  "RealTimeSpentInternally": 1002,
  "RealTimeSpentExternally": 924,
  "RealTimeSpentQueue": 143,
  "TimeSpent": 304,
  "HasAttachment": true,
  "NumReplies": 408,
  "NumMessages": 380,
  "FromAddress": "mollitia",
  "Messages": [
    {
      "TicketMessageId": 565,
      "CreatedAt": "2010-12-05T03:46:55.5038556+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "dolorem",
      "PersonId": 99,
      "PersonFullName": "Mr. Sam Wisoky",
      "ContactId": 456,
      "ContactName": "Gottlieb, Brakus and O'Kon",
      "ContactDepartment": "",
      "NumAttachments": 164,
      "EmailHeader": "gerardo.leannon@weber.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "voluptas",
      "Sentiment": 93,
      "SentimentConfidence": 734,
      "CreatedBy": 672,
      "ChangedAt": "2005-02-04T03:46:55.5038556+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 137
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 570,
      "Name": "Torp, Koepp and Bergnaum",
      "ToolTip": "Natus quis eaque facere.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 119
        }
      }
    },
    {
      "Id": 570,
      "Name": "Torp, Koepp and Bergnaum",
      "ToolTip": "Natus quis eaque facere.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 119
        }
      }
    }
  ],
  "Language": "non",
  "Sentiment": 658,
  "SentimentConfidence": 624,
  "SuggestedCategoryId": 252,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 493,
  "IconHint": "distinctio",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 259,
  "ExtraFields": {
    "ExtraFields1": "hic",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "sunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 769
    }
  }
}
```