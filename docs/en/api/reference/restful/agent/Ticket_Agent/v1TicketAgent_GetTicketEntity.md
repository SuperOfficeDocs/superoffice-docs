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
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=779
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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 375,
  "Title": "eaque",
  "CreatedAt": "2019-02-25T03:44:53.2623023+01:00",
  "LastChanged": "2002-02-24T03:44:53.2623023+01:00",
  "ReadByOwner": "2008-12-22T03:44:53.2623023+01:00",
  "ReadByCustomer": "2018-06-04T03:44:53.2623023+02:00",
  "FirstReadByOwner": "2020-07-21T03:44:53.2623023+02:00",
  "FirstReadByUser": "1998-09-18T03:44:53.2623023+02:00",
  "Activate": "2007-09-15T03:44:53.2623023+02:00",
  "ClosedAt": "2010-09-01T03:44:53.2623023+02:00",
  "RepliedAt": "1999-03-31T03:44:53.2623023+02:00",
  "AlertTimeout": "2024-07-30T03:44:53.2623023+02:00",
  "Deadline": "1997-05-31T03:44:53.2623023+02:00",
  "CreatedBy": null,
  "Author": "suscipit",
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
      "Position": "qui",
      "PersonId": 372,
      "Mrmrs": "temporibus",
      "Firstname": "Allan",
      "Lastname": "DuBuque",
      "MiddleName": "Sporer LLC",
      "Title": "odio",
      "Description": "Quality-focused solution-oriented neural-net",
      "Email": "andy_lueilwitz@harvey.uk",
      "FullName": "Ms. Nat McKenzie Jr.",
      "DirectPhone": "1-535-573-5735 x681",
      "FormalName": "Balistreri Group",
      "CountryId": 480,
      "ContactId": 370,
      "ContactName": "Schuster, Reynolds and Schmitt",
      "Retired": 781,
      "Rank": 563,
      "ActiveInterests": 341,
      "ContactDepartment": "",
      "ContactCountryId": 826,
      "ContactOrgNr": "1360372",
      "FaxPhone": "(213)494-0118 x6570",
      "MobilePhone": "674.948.9889 x586",
      "ContactPhone": "1-361-421-9745 x45813",
      "AssociateName": "Yundt-Pfeffer",
      "AssociateId": 4,
      "UsePersonAddress": false,
      "ContactFax": "consequuntur",
      "Kanafname": "illum",
      "Kanalname": "nobis",
      "Post1": "sit",
      "Post2": "natus",
      "Post3": "eveniet",
      "EmailName": "adrienne.bernhard@monahan.info",
      "ContactFullName": "Peggie DuBuque",
      "ActiveErpLinks": 422,
      "TicketPriorityId": 722,
      "SupportLanguageId": 353,
      "SupportAssociateId": 690,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 39
        }
      }
    }
  ],
  "AlertLevel": 498,
  "ConnectId": 633,
  "ReadStatus": "Green",
  "TimeToReply": 234,
  "RealTimeToReply": 608,
  "TimeToClose": 292,
  "RealTimeToClose": 767,
  "TimeSpentInternally": 757,
  "TimeSpentExternally": 109,
  "TimeSpentQueue": 157,
  "RealTimeSpentInternally": 334,
  "RealTimeSpentExternally": 455,
  "RealTimeSpentQueue": 145,
  "TimeSpent": 864,
  "HasAttachment": true,
  "NumReplies": 276,
  "NumMessages": 422,
  "FromAddress": "et",
  "Messages": [
    {
      "TicketMessageId": 956,
      "CreatedAt": "2007-05-23T03:44:53.2623023+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "sunt",
      "PersonId": 646,
      "PersonFullName": "Devyn Donnelly",
      "ContactId": 31,
      "ContactName": "Funk, Considine and Mills",
      "ContactDepartment": "",
      "NumAttachments": 333,
      "EmailHeader": "clotilde_cronin@hammes.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quam",
      "Sentiment": 223,
      "SentimentConfidence": 982,
      "CreatedBy": 592,
      "ChangedAt": "2007-11-03T03:44:53.2623023+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 283
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 5,
      "Name": "Ullrich-McClure",
      "ToolTip": "Laborum perferendis dolorem nobis dolorem aut accusantium.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 814
        }
      }
    },
    {
      "Id": 5,
      "Name": "Ullrich-McClure",
      "ToolTip": "Laborum perferendis dolorem nobis dolorem aut accusantium.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 814
        }
      }
    }
  ],
  "Language": "reiciendis",
  "Sentiment": 793,
  "SentimentConfidence": 98,
  "SuggestedCategoryId": 647,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 442,
  "IconHint": "temporibus",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 187,
  "ExtraFields": {
    "ExtraFields1": "ipsam",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "totam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 740
    }
  }
}
```