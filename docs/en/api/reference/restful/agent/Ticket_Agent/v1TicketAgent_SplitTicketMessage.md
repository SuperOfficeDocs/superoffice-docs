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


NsApiSlow threshold: 2000 ms.






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
    38,
    318
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 28,
  "Title": "reiciendis",
  "CreatedAt": "2002-05-08T03:40:48.0473619+02:00",
  "LastChanged": "2025-05-21T03:40:48.0473619+02:00",
  "ReadByOwner": "2017-02-17T03:40:48.0473619+01:00",
  "ReadByCustomer": "2017-07-06T03:40:48.0473619+02:00",
  "FirstReadByOwner": "1999-09-29T03:40:48.0473619+02:00",
  "FirstReadByUser": "2006-02-28T03:40:48.0473619+01:00",
  "Activate": "2011-05-29T03:40:48.0473619+02:00",
  "ClosedAt": "2013-02-23T03:40:48.0473619+01:00",
  "RepliedAt": "2018-05-25T03:40:48.0473619+02:00",
  "AlertTimeout": "2011-04-10T03:40:48.0473619+02:00",
  "Deadline": "2014-12-30T03:40:48.0473619+01:00",
  "CreatedBy": null,
  "Author": "officiis",
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
      "Position": "ea",
      "PersonId": 475,
      "Mrmrs": "quia",
      "Firstname": "Luther",
      "Lastname": "Mann",
      "MiddleName": "Leuschke, Ebert and Wiza",
      "Title": "quod",
      "Description": "Vision-oriented discrete parallelism",
      "Email": "davion@white.biz",
      "FullName": "Ms. Pearl Jazmyne Franecki V",
      "DirectPhone": "793-014-7911 x890",
      "FormalName": "Mante, Cronin and Fisher",
      "CountryId": 400,
      "ContactId": 48,
      "ContactName": "Champlin Inc and Sons",
      "Retired": 193,
      "Rank": 472,
      "ActiveInterests": 385,
      "ContactDepartment": "",
      "ContactCountryId": 860,
      "ContactOrgNr": "1539326",
      "FaxPhone": "075-574-4845",
      "MobilePhone": "1-636-178-8985",
      "ContactPhone": "1-162-330-3715",
      "AssociateName": "Zemlak LLC",
      "AssociateId": 327,
      "UsePersonAddress": false,
      "ContactFax": "nesciunt",
      "Kanafname": "maiores",
      "Kanalname": "quia",
      "Post1": "voluptatem",
      "Post2": "voluptas",
      "Post3": "quisquam",
      "EmailName": "myrl_rippin@nolan.us",
      "ContactFullName": "Mr. Ford Willms I",
      "ActiveErpLinks": 802,
      "TicketPriorityId": 607,
      "SupportLanguageId": 49,
      "SupportAssociateId": 898,
      "CategoryName": "VIP Customer",
      "PersonNumber": "450532",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 999
        }
      }
    }
  ],
  "AlertLevel": 48,
  "ConnectId": 707,
  "ReadStatus": "Green",
  "TimeToReply": 374,
  "RealTimeToReply": 370,
  "TimeToClose": 537,
  "RealTimeToClose": 513,
  "TimeSpentInternally": 670,
  "TimeSpentExternally": 67,
  "TimeSpentQueue": 254,
  "RealTimeSpentInternally": 460,
  "RealTimeSpentExternally": 276,
  "RealTimeSpentQueue": 415,
  "TimeSpent": 442,
  "HasAttachment": false,
  "NumReplies": 737,
  "NumMessages": 865,
  "FromAddress": "laudantium",
  "Messages": [
    {
      "TicketMessageId": 509,
      "CreatedAt": "2007-12-04T03:40:48.0473619+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "et",
      "PersonId": 738,
      "PersonFullName": "Terence Legros",
      "ContactId": 127,
      "ContactName": "Walter, Kuhic and Balistreri",
      "ContactDepartment": "",
      "NumAttachments": 281,
      "EmailHeader": "karolann_johnson@grant.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "blanditiis",
      "Sentiment": 556,
      "SentimentConfidence": 806,
      "CreatedBy": 618,
      "ChangedAt": "2011-05-20T03:40:48.0473619+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 907
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 853,
      "Name": "Dibbert-Kassulke",
      "ToolTip": "Sed quas dicta officiis occaecati eligendi.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 214
        }
      }
    },
    {
      "Id": 853,
      "Name": "Dibbert-Kassulke",
      "ToolTip": "Sed quas dicta officiis occaecati eligendi.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 214
        }
      }
    }
  ],
  "Language": "delectus",
  "Sentiment": 508,
  "SentimentConfidence": 541,
  "SuggestedCategoryId": 852,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 879,
  "IconHint": "sed",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 56,
  "ExtraFields": {
    "ExtraFields1": "molestiae",
    "ExtraFields2": "temporibus"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "asperiores"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 220
    }
  }
}
```