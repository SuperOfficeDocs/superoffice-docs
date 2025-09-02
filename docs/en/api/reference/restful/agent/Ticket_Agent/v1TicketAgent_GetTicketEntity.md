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
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=148
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
  "TicketId": 389,
  "Title": "ut",
  "CreatedAt": "2017-12-24T03:46:55.4569825+01:00",
  "LastChanged": "2012-02-17T03:46:55.4569825+01:00",
  "ReadByOwner": "2019-04-02T03:46:55.4569825+02:00",
  "ReadByCustomer": "2003-06-26T03:46:55.4569825+02:00",
  "FirstReadByOwner": "2013-01-22T03:46:55.4569825+01:00",
  "FirstReadByUser": "2013-07-14T03:46:55.4569825+02:00",
  "Activate": "2002-01-03T03:46:55.4569825+01:00",
  "ClosedAt": "2016-04-28T03:46:55.4569825+02:00",
  "RepliedAt": "1998-12-27T03:46:55.4569825+01:00",
  "AlertTimeout": "2008-10-27T03:46:55.4569825+01:00",
  "Deadline": "2000-09-28T03:46:55.4569825+02:00",
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
      "Position": "asperiores",
      "PersonId": 643,
      "Mrmrs": "aut",
      "Firstname": "Shane",
      "Lastname": "Ankunding",
      "MiddleName": "Kerluke, Pfeffer and Casper",
      "Title": "consequuntur",
      "Description": "Exclusive national customer loyalty",
      "Email": "amani_osinski@daughertyratke.co.uk",
      "FullName": "Prof. Marques Wuckert DDS",
      "DirectPhone": "610.906.3199",
      "FormalName": "Pacocha-McKenzie",
      "CountryId": 351,
      "ContactId": 44,
      "ContactName": "McCullough, Altenwerth and Greenfelder",
      "Retired": 147,
      "Rank": 409,
      "ActiveInterests": 190,
      "ContactDepartment": "",
      "ContactCountryId": 903,
      "ContactOrgNr": "1287254",
      "FaxPhone": "013.331.5991",
      "MobilePhone": "1-155-782-1723 x469",
      "ContactPhone": "495-284-4609 x89035",
      "AssociateName": "Pagac-Jenkins",
      "AssociateId": 778,
      "UsePersonAddress": false,
      "ContactFax": "fugit",
      "Kanafname": "quidem",
      "Kanalname": "velit",
      "Post1": "beatae",
      "Post2": "tenetur",
      "Post3": "facere",
      "EmailName": "charlotte.zieme@goyettecronin.name",
      "ContactFullName": "Mr. Treva Annabel Jerde",
      "ActiveErpLinks": 684,
      "TicketPriorityId": 720,
      "SupportLanguageId": 603,
      "SupportAssociateId": 964,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1279783",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 195
        }
      }
    }
  ],
  "AlertLevel": 51,
  "ConnectId": 165,
  "ReadStatus": "Green",
  "TimeToReply": 355,
  "RealTimeToReply": 654,
  "TimeToClose": 860,
  "RealTimeToClose": 680,
  "TimeSpentInternally": 556,
  "TimeSpentExternally": 21,
  "TimeSpentQueue": 750,
  "RealTimeSpentInternally": 991,
  "RealTimeSpentExternally": 862,
  "RealTimeSpentQueue": 301,
  "TimeSpent": 310,
  "HasAttachment": true,
  "NumReplies": 254,
  "NumMessages": 224,
  "FromAddress": "nulla",
  "Messages": [
    {
      "TicketMessageId": 529,
      "CreatedAt": "2017-10-31T03:46:55.4569825+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "quod",
      "PersonId": 559,
      "PersonFullName": "Miss Daniela Fernando Streich",
      "ContactId": 255,
      "ContactName": "Glover Group",
      "ContactDepartment": "",
      "NumAttachments": 353,
      "EmailHeader": "delfina_reilly@ohara.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "consequatur",
      "Sentiment": 396,
      "SentimentConfidence": 875,
      "CreatedBy": 139,
      "ChangedAt": "2005-07-03T03:46:55.4569825+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 886
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 208,
      "Name": "Schumm-Barton",
      "ToolTip": "Et laboriosam minima.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 731
        }
      }
    },
    {
      "Id": 208,
      "Name": "Schumm-Barton",
      "ToolTip": "Et laboriosam minima.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 731
        }
      }
    }
  ],
  "Language": "dolores",
  "Sentiment": 332,
  "SentimentConfidence": 785,
  "SuggestedCategoryId": 830,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 143,
  "IconHint": "enim",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 757,
  "ExtraFields": {
    "ExtraFields1": "maxime",
    "ExtraFields2": "numquam"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 87
    }
  }
}
```