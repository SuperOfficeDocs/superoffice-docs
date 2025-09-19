---
title: POST Agents/Ticket/GetTicketEntity
uid: v1TicketAgent_GetTicketEntity
generated: true
content_type: reference
---

# POST Agents/Ticket/GetTicketEntity

```http
POST /api/v1/Agents/Ticket/GetTicketEntity
```

Gets a TicketEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ticketEntityId | int32 | **Required** The identifier of the TicketEntity object |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=849
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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 361,
  "Title": "ut",
  "CreatedAt": "2024-01-27T03:41:54.1994545+01:00",
  "LastChanged": "2025-03-31T03:41:54.1994545+02:00",
  "ReadByOwner": "2011-03-12T03:41:54.1994545+01:00",
  "ReadByCustomer": "2013-06-17T03:41:54.1994545+02:00",
  "FirstReadByOwner": "2014-06-17T03:41:54.1994545+02:00",
  "FirstReadByUser": "2007-06-04T03:41:54.1994545+02:00",
  "Activate": "2020-07-06T03:41:54.1994545+02:00",
  "ClosedAt": "2002-08-10T03:41:54.1994545+02:00",
  "RepliedAt": "2020-12-26T03:41:54.1994545+01:00",
  "AlertTimeout": "2013-05-13T03:41:54.1994545+02:00",
  "Deadline": "2021-11-26T03:41:54.1994545+01:00",
  "CreatedBy": null,
  "Author": "dolorem",
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
      "PersonId": 815,
      "Mrmrs": "autem",
      "Firstname": "Christophe",
      "Lastname": "Ward",
      "MiddleName": "Jerde, Daugherty and Shields",
      "Title": "maiores",
      "Description": "Open-architected user-facing database",
      "Email": "verla_block@harber.biz",
      "FullName": "Prof. May Brakus I",
      "DirectPhone": "(881)979-9548",
      "FormalName": "Predovic LLC",
      "CountryId": 441,
      "ContactId": 136,
      "ContactName": "Konopelski Group",
      "Retired": 52,
      "Rank": 431,
      "ActiveInterests": 416,
      "ContactDepartment": "",
      "ContactCountryId": 338,
      "ContactOrgNr": "162755",
      "FaxPhone": "873.518.7573 x7511",
      "MobilePhone": "(334)890-4559 x96756",
      "ContactPhone": "303-423-3222 x3917",
      "AssociateName": "Abernathy LLC",
      "AssociateId": 651,
      "UsePersonAddress": false,
      "ContactFax": "vel",
      "Kanafname": "nulla",
      "Kanalname": "nihil",
      "Post1": "et",
      "Post2": "sapiente",
      "Post3": "ut",
      "EmailName": "estell@schmitt.us",
      "ContactFullName": "Prof. Angie Simonis DVM",
      "ActiveErpLinks": 263,
      "TicketPriorityId": 635,
      "SupportLanguageId": 148,
      "SupportAssociateId": 415,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1820160",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 426
        }
      }
    }
  ],
  "AlertLevel": 389,
  "ConnectId": 766,
  "ReadStatus": "Green",
  "TimeToReply": 136,
  "RealTimeToReply": 847,
  "TimeToClose": 181,
  "RealTimeToClose": 802,
  "TimeSpentInternally": 636,
  "TimeSpentExternally": 531,
  "TimeSpentQueue": 14,
  "RealTimeSpentInternally": 925,
  "RealTimeSpentExternally": 390,
  "RealTimeSpentQueue": 436,
  "TimeSpent": 35,
  "HasAttachment": true,
  "NumReplies": 798,
  "NumMessages": 648,
  "FromAddress": "corporis",
  "Messages": [
    {
      "TicketMessageId": 750,
      "CreatedAt": "2024-04-05T03:41:54.1994545+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "et",
      "PersonId": 256,
      "PersonFullName": "Prof. Katrina Cummerata",
      "ContactId": 492,
      "ContactName": "Medhurst-Kertzmann",
      "ContactDepartment": "",
      "NumAttachments": 873,
      "EmailHeader": "jacynthe@dach.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "magni",
      "Sentiment": 47,
      "SentimentConfidence": 176,
      "CreatedBy": 952,
      "ChangedAt": "2021-11-04T03:41:54.1994545+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 286
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 564,
      "Name": "Mosciski, Hoppe and Parker",
      "ToolTip": "Aspernatur nemo.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 750
        }
      }
    },
    {
      "Id": 564,
      "Name": "Mosciski, Hoppe and Parker",
      "ToolTip": "Aspernatur nemo.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 750
        }
      }
    }
  ],
  "Language": "temporibus",
  "Sentiment": 152,
  "SentimentConfidence": 573,
  "SuggestedCategoryId": 96,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 294,
  "IconHint": "molestias",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 862,
  "ExtraFields": {
    "ExtraFields1": "maxime",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "sunt",
    "CustomFields2": "nam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 156
    }
  }
}
```