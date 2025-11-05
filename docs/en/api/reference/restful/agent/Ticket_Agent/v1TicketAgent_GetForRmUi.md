---
title: POST Agents/Ticket/GetForRmUi
uid: v1TicketAgent_GetForRmUi
generated: true
content_type: reference
---

# POST Agents/Ticket/GetForRmUi

```http
POST /api/v1/Agents/Ticket/GetForRmUi
```

Get a ticket entity, adapted to the specific needs of the Request Management UI.


WARNING: This endpoint is not guaranteed to be stable/compatible between versions
NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetForRmUi?$select=name,department,category/id
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

TicketId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | Integer |  |

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
POST /api/v1/Agents/Ticket/GetForRmUi
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 34
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 531,
  "Title": "tempora",
  "CreatedAt": "2014-11-08T02:30:47.9131881+01:00",
  "LastChanged": "2007-08-16T02:30:47.9131881+02:00",
  "ReadByOwner": "2012-05-09T02:30:47.9131881+02:00",
  "ReadByCustomer": "2020-03-30T02:30:47.9131881+02:00",
  "FirstReadByOwner": "2019-02-04T02:30:47.9131881+01:00",
  "FirstReadByUser": "2004-12-02T02:30:47.9131881+01:00",
  "Activate": "2022-03-20T02:30:47.9131881+01:00",
  "ClosedAt": "2020-08-11T02:30:47.9131881+02:00",
  "RepliedAt": "2011-08-10T02:30:47.9131881+02:00",
  "AlertTimeout": "2011-03-27T02:30:47.9131881+01:00",
  "Deadline": "2024-02-01T02:30:47.9131881+01:00",
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
      "Position": "eius",
      "PersonId": 865,
      "Mrmrs": "quibusdam",
      "Firstname": "Shane",
      "Lastname": "Sauer",
      "MiddleName": "Fadel Inc and Sons",
      "Title": "est",
      "Description": "Ergonomic global adapter",
      "Email": "kamille.romaguera@schinnerdeckow.com",
      "FullName": "Norbert Lehner",
      "DirectPhone": "(596)265-8076 x1372",
      "FormalName": "Leuschke LLC",
      "CountryId": 382,
      "ContactId": 312,
      "ContactName": "Littel-Langworth",
      "Retired": 93,
      "Rank": 181,
      "ActiveInterests": 213,
      "ContactDepartment": "",
      "ContactCountryId": 394,
      "ContactOrgNr": "1115911",
      "FaxPhone": "064-089-0003",
      "MobilePhone": "666.199.0325",
      "ContactPhone": "677-127-5453 x067",
      "AssociateName": "Schultz-Cummerata",
      "AssociateId": 647,
      "UsePersonAddress": true,
      "ContactFax": "repudiandae",
      "Kanafname": "ipsam",
      "Kanalname": "similique",
      "Post1": "laboriosam",
      "Post2": "omnis",
      "Post3": "ipsa",
      "EmailName": "muhammad.gutkowski@carrollsmitham.name",
      "ContactFullName": "Mrs. Ethel Gerson Friesen I",
      "ActiveErpLinks": 484,
      "TicketPriorityId": 561,
      "SupportLanguageId": 756,
      "SupportAssociateId": 338,
      "CategoryName": "VIP Customer",
      "PersonNumber": "833380",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 32
        }
      }
    }
  ],
  "AlertLevel": 906,
  "ConnectId": 338,
  "ReadStatus": "Green",
  "TimeToReply": 691,
  "RealTimeToReply": 631,
  "TimeToClose": 860,
  "RealTimeToClose": 755,
  "TimeSpentInternally": 933,
  "TimeSpentExternally": 128,
  "TimeSpentQueue": 113,
  "RealTimeSpentInternally": 823,
  "RealTimeSpentExternally": 334,
  "RealTimeSpentQueue": 167,
  "TimeSpent": 287,
  "HasAttachment": true,
  "NumReplies": 315,
  "NumMessages": 69,
  "FromAddress": "quia",
  "Messages": [
    {
      "TicketMessageId": 578,
      "CreatedAt": "2000-07-17T02:30:47.9131881+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "facere",
      "PersonId": 423,
      "PersonFullName": "Gwen Hudson Sr.",
      "ContactId": 27,
      "ContactName": "Stark, Christiansen and Cummerata",
      "ContactDepartment": "",
      "NumAttachments": 536,
      "EmailHeader": "maya_murazik@smitham.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "vero",
      "Sentiment": 957,
      "SentimentConfidence": 537,
      "CreatedBy": 671,
      "ChangedAt": "2007-10-23T02:30:47.9131881+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 948
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 319,
      "Name": "Schulist Inc and Sons",
      "ToolTip": "Enim adipisci doloribus ea a ut quia.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 106
        }
      }
    },
    {
      "Id": 319,
      "Name": "Schulist Inc and Sons",
      "ToolTip": "Enim adipisci doloribus ea a ut quia.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 106
        }
      }
    }
  ],
  "Language": "quia",
  "Sentiment": 590,
  "SentimentConfidence": 229,
  "SuggestedCategoryId": 392,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 281,
  "IconHint": "ipsum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 584,
  "ExtraFields": {
    "ExtraFields1": "distinctio",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "in",
    "CustomFields2": "ab"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 71
    }
  }
}
```