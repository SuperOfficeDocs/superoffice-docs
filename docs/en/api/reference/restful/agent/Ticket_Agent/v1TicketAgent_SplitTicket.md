---
title: POST Agents/Ticket/SplitTicket
uid: v1TicketAgent_SplitTicket
generated: true
content_type: reference
---

# POST Agents/Ticket/SplitTicket

```http
POST /api/v1/Agents/Ticket/SplitTicket
```

Save new ticket and move/copy data from existing ticket in a single request.


Specified messages will be moved.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/SplitTicket?$select=name,department,category/id
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

SourceTicketEntityId, SourceTicketEntityStatusId, SourceTicketEntityActivate, TransferMessageIds, NewTicketEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourceTicketEntityId | Integer |  |
| SourceTicketEntityStatusId | Integer |  |
| SourceTicketEntityActivate | String |  |
| TransferMessageIds | Array |  |
| NewTicketEntity | TicketEntity | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |

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
POST /api/v1/Agents/Ticket/SplitTicket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SourceTicketEntityId": 74,
  "SourceTicketEntityStatusId": 313,
  "SourceTicketEntityActivate": "2025-03-07T03:46:55.4882311+01:00",
  "TransferMessageIds": [
    876,
    14
  ],
  "NewTicketEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 897,
  "Title": "omnis",
  "CreatedAt": "2014-12-12T03:46:55.5038556+01:00",
  "LastChanged": "2001-12-24T03:46:55.5038556+01:00",
  "ReadByOwner": "2001-12-16T03:46:55.5038556+01:00",
  "ReadByCustomer": "2006-09-22T03:46:55.5038556+02:00",
  "FirstReadByOwner": "2018-01-01T03:46:55.5038556+01:00",
  "FirstReadByUser": "2012-04-30T03:46:55.5038556+02:00",
  "Activate": "1999-03-30T03:46:55.5038556+02:00",
  "ClosedAt": "1999-11-22T03:46:55.5038556+01:00",
  "RepliedAt": "2025-08-30T03:46:55.5038556+02:00",
  "AlertTimeout": "2014-01-11T03:46:55.5038556+01:00",
  "Deadline": "2001-01-15T03:46:55.5038556+01:00",
  "CreatedBy": null,
  "Author": "voluptatem",
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
      "Position": "optio",
      "PersonId": 887,
      "Mrmrs": "nemo",
      "Firstname": "Marc",
      "Lastname": "Hoeger",
      "MiddleName": "Bergstrom-O'Hara",
      "Title": "alias",
      "Description": "Robust tertiary structure",
      "Email": "candido@funk.name",
      "FullName": "Brycen Koch DVM",
      "DirectPhone": "229.469.1319 x62366",
      "FormalName": "Feil-McCullough",
      "CountryId": 726,
      "ContactId": 487,
      "ContactName": "Bayer-Waters",
      "Retired": 349,
      "Rank": 886,
      "ActiveInterests": 662,
      "ContactDepartment": "",
      "ContactCountryId": 816,
      "ContactOrgNr": "1473292",
      "FaxPhone": "1-238-947-1797",
      "MobilePhone": "313-951-7032 x3614",
      "ContactPhone": "504.996.2815 x659",
      "AssociateName": "Sipes Group",
      "AssociateId": 785,
      "UsePersonAddress": false,
      "ContactFax": "laborum",
      "Kanafname": "porro",
      "Kanalname": "sit",
      "Post1": "natus",
      "Post2": "corporis",
      "Post3": "voluptates",
      "EmailName": "wilford_fay@turcotte.us",
      "ContactFullName": "Hollis Sauer I",
      "ActiveErpLinks": 100,
      "TicketPriorityId": 643,
      "SupportLanguageId": 596,
      "SupportAssociateId": 493,
      "CategoryName": "VIP Customer",
      "PersonNumber": "844197",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 348
        }
      }
    }
  ],
  "AlertLevel": 755,
  "ConnectId": 93,
  "ReadStatus": "Green",
  "TimeToReply": 348,
  "RealTimeToReply": 563,
  "TimeToClose": 328,
  "RealTimeToClose": 728,
  "TimeSpentInternally": 778,
  "TimeSpentExternally": 639,
  "TimeSpentQueue": 414,
  "RealTimeSpentInternally": 163,
  "RealTimeSpentExternally": 210,
  "RealTimeSpentQueue": 947,
  "TimeSpent": 645,
  "HasAttachment": false,
  "NumReplies": 860,
  "NumMessages": 869,
  "FromAddress": "est",
  "Messages": [
    {
      "TicketMessageId": 493,
      "CreatedAt": "2011-04-29T03:46:55.5038556+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "mollitia",
      "PersonId": 865,
      "PersonFullName": "Devonte Zemlak",
      "ContactId": 973,
      "ContactName": "Howell Group",
      "ContactDepartment": "",
      "NumAttachments": 401,
      "EmailHeader": "margarett@roob.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ullam",
      "Sentiment": 36,
      "SentimentConfidence": 281,
      "CreatedBy": 499,
      "ChangedAt": "2019-04-20T03:46:55.5038556+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 452
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 542,
      "Name": "Hirthe-Considine",
      "ToolTip": "Totam aut deleniti.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 516
        }
      }
    },
    {
      "Id": 542,
      "Name": "Hirthe-Considine",
      "ToolTip": "Totam aut deleniti.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 516
        }
      }
    }
  ],
  "Language": "exercitationem",
  "Sentiment": 122,
  "SentimentConfidence": 581,
  "SuggestedCategoryId": 908,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 786,
  "IconHint": "sunt",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 295,
  "ExtraFields": {
    "ExtraFields1": "dolores",
    "ExtraFields2": "asperiores"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "laudantium"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 668
    }
  }
}
```