---
title: POST Agents/Ticket/MergeTickets
uid: v1TicketAgent_MergeTickets
generated: true
content_type: reference
---

# POST Agents/Ticket/MergeTickets

```http
POST /api/v1/Agents/Ticket/MergeTickets
```

Merge one or more tickets into one primary ticket







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/MergeTickets?$select=name,department,category/id
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

MergedTicketEntity, SecondaryTicketIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MergedTicketEntity | TicketEntity | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| SecondaryTicketIds | Array |  |

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
POST /api/v1/Agents/Ticket/MergeTickets
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "MergedTicketEntity": null,
  "SecondaryTicketIds": [
    952,
    271
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 199,
  "Title": "quis",
  "CreatedAt": "2016-04-30T03:41:54.2619521+02:00",
  "LastChanged": "2013-01-12T03:41:54.2619521+01:00",
  "ReadByOwner": "2003-12-04T03:41:54.2619521+01:00",
  "ReadByCustomer": "2017-04-20T03:41:54.2619521+02:00",
  "FirstReadByOwner": "2002-03-24T03:41:54.2619521+01:00",
  "FirstReadByUser": "2013-07-14T03:41:54.2619521+02:00",
  "Activate": "2018-07-21T03:41:54.2619521+02:00",
  "ClosedAt": "2000-10-27T03:41:54.2619521+02:00",
  "RepliedAt": "2010-01-17T03:41:54.2619521+01:00",
  "AlertTimeout": "2017-11-28T03:41:54.2619521+01:00",
  "Deadline": "2000-04-18T03:41:54.2619521+02:00",
  "CreatedBy": null,
  "Author": "voluptates",
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
      "Position": "est",
      "PersonId": 683,
      "Mrmrs": "suscipit",
      "Firstname": "Anissa",
      "Lastname": "Medhurst",
      "MiddleName": "Tillman-Johns",
      "Title": "rerum",
      "Description": "Virtual incremental emulation",
      "Email": "rubye@jakubowskibernier.ca",
      "FullName": "Randi Lakin",
      "DirectPhone": "115-127-1678",
      "FormalName": "Murphy LLC",
      "CountryId": 314,
      "ContactId": 13,
      "ContactName": "Schumm, Mann and Schoen",
      "Retired": 939,
      "Rank": 719,
      "ActiveInterests": 723,
      "ContactDepartment": "",
      "ContactCountryId": 51,
      "ContactOrgNr": "477570",
      "FaxPhone": "911-422-0574",
      "MobilePhone": "1-136-199-4343 x76978",
      "ContactPhone": "505-946-1819 x71634",
      "AssociateName": "Lindgren LLC",
      "AssociateId": 208,
      "UsePersonAddress": false,
      "ContactFax": "dolorem",
      "Kanafname": "odio",
      "Kanalname": "dolore",
      "Post1": "qui",
      "Post2": "consequatur",
      "Post3": "dolorem",
      "EmailName": "art@senger.ca",
      "ContactFullName": "Gilda Zemlak",
      "ActiveErpLinks": 957,
      "TicketPriorityId": 575,
      "SupportLanguageId": 493,
      "SupportAssociateId": 465,
      "CategoryName": "VIP Customer",
      "PersonNumber": "911349",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 13
        }
      }
    }
  ],
  "AlertLevel": 281,
  "ConnectId": 386,
  "ReadStatus": "Green",
  "TimeToReply": 731,
  "RealTimeToReply": 145,
  "TimeToClose": 146,
  "RealTimeToClose": 200,
  "TimeSpentInternally": 78,
  "TimeSpentExternally": 569,
  "TimeSpentQueue": 538,
  "RealTimeSpentInternally": 608,
  "RealTimeSpentExternally": 739,
  "RealTimeSpentQueue": 932,
  "TimeSpent": 538,
  "HasAttachment": true,
  "NumReplies": 501,
  "NumMessages": 592,
  "FromAddress": "ipsum",
  "Messages": [
    {
      "TicketMessageId": 602,
      "CreatedAt": "2020-10-11T03:41:54.2619521+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "mollitia",
      "PersonId": 141,
      "PersonFullName": "Leora Boyle",
      "ContactId": 56,
      "ContactName": "Hickle Inc and Sons",
      "ContactDepartment": "mesh cutting-edge e-tailers",
      "NumAttachments": 577,
      "EmailHeader": "raoul.oconner@hickle.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "sint",
      "Sentiment": 52,
      "SentimentConfidence": 311,
      "CreatedBy": 705,
      "ChangedAt": "2011-07-06T03:41:54.2619521+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 500
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 994,
      "Name": "McKenzie, Hickle and Kling",
      "ToolTip": "Ut necessitatibus laudantium enim repudiandae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 571
        }
      }
    },
    {
      "Id": 994,
      "Name": "McKenzie, Hickle and Kling",
      "ToolTip": "Ut necessitatibus laudantium enim repudiandae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 571
        }
      }
    }
  ],
  "Language": "reprehenderit",
  "Sentiment": 831,
  "SentimentConfidence": 140,
  "SuggestedCategoryId": 547,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 471,
  "IconHint": "ut",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 305,
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "iure"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "culpa"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 535
    }
  }
}
```