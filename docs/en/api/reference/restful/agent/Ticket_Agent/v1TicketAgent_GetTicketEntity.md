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


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ticketEntityId | int32 | **Required** The identifier of the TicketEntity object |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=552
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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 167,
  "Title": "necessitatibus",
  "CreatedAt": "2016-12-15T02:30:47.8975637+01:00",
  "LastChanged": "2009-02-27T02:30:47.8975637+01:00",
  "ReadByOwner": "2002-09-01T02:30:47.8975637+02:00",
  "ReadByCustomer": "2001-03-20T02:30:47.8975637+01:00",
  "FirstReadByOwner": "2024-03-13T02:30:47.8975637+01:00",
  "FirstReadByUser": "2000-01-13T02:30:47.8975637+01:00",
  "Activate": "2003-10-20T02:30:47.8975637+02:00",
  "ClosedAt": "2023-07-24T02:30:47.8975637+02:00",
  "RepliedAt": "2005-01-03T02:30:47.8975637+01:00",
  "AlertTimeout": "2021-05-23T02:30:47.8975637+02:00",
  "Deadline": "1998-11-26T02:30:47.8975637+01:00",
  "CreatedBy": null,
  "Author": "aut",
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
      "Position": "ut",
      "PersonId": 485,
      "Mrmrs": "necessitatibus",
      "Firstname": "Meredith",
      "Lastname": "Reichert",
      "MiddleName": "Zieme-Yost",
      "Title": "laborum",
      "Description": "Triple-buffered leading edge matrix",
      "Email": "lydia@lemkeblock.us",
      "FullName": "Unique Lakin",
      "DirectPhone": "1-128-436-4244 x061",
      "FormalName": "Kilback-Hessel",
      "CountryId": 581,
      "ContactId": 903,
      "ContactName": "Hammes, Heidenreich and Lynch",
      "Retired": 272,
      "Rank": 899,
      "ActiveInterests": 34,
      "ContactDepartment": "",
      "ContactCountryId": 174,
      "ContactOrgNr": "951590",
      "FaxPhone": "168.985.3738",
      "MobilePhone": "285-786-6660 x34852",
      "ContactPhone": "605-333-0427 x1858",
      "AssociateName": "Langworth, Okuneva and Huel",
      "AssociateId": 430,
      "UsePersonAddress": true,
      "ContactFax": "aspernatur",
      "Kanafname": "hic",
      "Kanalname": "necessitatibus",
      "Post1": "magnam",
      "Post2": "quia",
      "Post3": "hic",
      "EmailName": "genesis@carter.us",
      "ContactFullName": "Kimberly Towne",
      "ActiveErpLinks": 191,
      "TicketPriorityId": 557,
      "SupportLanguageId": 978,
      "SupportAssociateId": 831,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1162456",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 599
        }
      }
    }
  ],
  "AlertLevel": 710,
  "ConnectId": 245,
  "ReadStatus": "Green",
  "TimeToReply": 156,
  "RealTimeToReply": 529,
  "TimeToClose": 479,
  "RealTimeToClose": 697,
  "TimeSpentInternally": 541,
  "TimeSpentExternally": 455,
  "TimeSpentQueue": 169,
  "RealTimeSpentInternally": 475,
  "RealTimeSpentExternally": 646,
  "RealTimeSpentQueue": 224,
  "TimeSpent": 41,
  "HasAttachment": false,
  "NumReplies": 894,
  "NumMessages": 208,
  "FromAddress": "autem",
  "Messages": [
    {
      "TicketMessageId": 572,
      "CreatedAt": "2002-11-15T02:30:47.8975637+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "esse",
      "PersonId": 109,
      "PersonFullName": "Miss Weston Aurore Dickinson PhD",
      "ContactId": 928,
      "ContactName": "Mante-Rodriguez",
      "ContactDepartment": "",
      "NumAttachments": 878,
      "EmailHeader": "elroy@ebert.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "deserunt",
      "Sentiment": 186,
      "SentimentConfidence": 438,
      "CreatedBy": 330,
      "ChangedAt": "2022-03-28T02:30:47.9131881+02:00",
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
      "Id": 611,
      "Name": "McKenzie, Ondricka and Kuhlman",
      "ToolTip": "Modi quia.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 419
        }
      }
    },
    {
      "Id": 611,
      "Name": "McKenzie, Ondricka and Kuhlman",
      "ToolTip": "Modi quia.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 419
        }
      }
    }
  ],
  "Language": "id",
  "Sentiment": 388,
  "SentimentConfidence": 17,
  "SuggestedCategoryId": 972,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 811,
  "IconHint": "facere",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 595,
  "ExtraFields": {
    "ExtraFields1": "explicabo",
    "ExtraFields2": "autem"
  },
  "CustomFields": {
    "CustomFields1": "praesentium",
    "CustomFields2": "corporis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 64
    }
  }
}
```