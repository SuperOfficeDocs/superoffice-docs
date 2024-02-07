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
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=925
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
  "TicketId": 644,
  "Title": "eos",
  "CreatedAt": "2012-08-12T16:54:56.443137+02:00",
  "LastChanged": "2010-01-04T16:54:56.443137+01:00",
  "ReadByOwner": "2005-05-28T16:54:56.443137+02:00",
  "ReadByCustomer": "2023-02-14T16:54:56.443137+01:00",
  "FirstReadByOwner": "1999-12-21T16:54:56.443137+01:00",
  "FirstReadByUser": "2020-08-24T16:54:56.443137+02:00",
  "Activate": "2013-09-24T16:54:56.443137+02:00",
  "ClosedAt": "2003-02-19T16:54:56.443137+01:00",
  "RepliedAt": "2011-06-30T16:54:56.443137+02:00",
  "AlertTimeout": "2001-07-10T16:54:56.443137+02:00",
  "Deadline": "2017-05-28T16:54:56.443137+02:00",
  "CreatedBy": null,
  "Author": "rerum",
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
      "Position": "soluta",
      "PersonId": 708,
      "Mrmrs": "facilis",
      "Firstname": "Francisco",
      "Lastname": "Ruecker",
      "MiddleName": "Brown, Daniel and Langosh",
      "Title": "ab",
      "Description": "Cross-group bifurcated throughput",
      "Email": "durward@schaefer.com",
      "FullName": "Oceane Satterfield",
      "DirectPhone": "(654)806-9721",
      "FormalName": "Reichert-Rowe",
      "CountryId": 942,
      "ContactId": 430,
      "ContactName": "Davis, Stark and O'Reilly",
      "Retired": 717,
      "Rank": 347,
      "ActiveInterests": 432,
      "ContactDepartment": "",
      "ContactCountryId": 776,
      "ContactOrgNr": "1765530",
      "FaxPhone": "1-697-017-5537 x00160",
      "MobilePhone": "(267)424-7159 x0219",
      "ContactPhone": "441-105-2949",
      "AssociateName": "Greenfelder LLC",
      "AssociateId": 664,
      "UsePersonAddress": true,
      "ContactFax": "odio",
      "Kanafname": "velit",
      "Kanalname": "ut",
      "Post1": "consequatur",
      "Post2": "quo",
      "Post3": "et",
      "EmailName": "kitty.krajcik@cronadickinson.co.uk",
      "ContactFullName": "Mervin Keebler",
      "ActiveErpLinks": 892,
      "TicketPriorityId": 1002,
      "SupportLanguageId": 197,
      "SupportAssociateId": 344,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    }
  ],
  "AlertLevel": 308,
  "ConnectId": 961,
  "ReadStatus": "Green",
  "TimeToReply": 182,
  "RealTimeToReply": 244,
  "TimeToClose": 321,
  "RealTimeToClose": 171,
  "TimeSpentInternally": 454,
  "TimeSpentExternally": 277,
  "TimeSpentQueue": 805,
  "RealTimeSpentInternally": 347,
  "RealTimeSpentExternally": 566,
  "RealTimeSpentQueue": 964,
  "TimeSpent": 878,
  "HasAttachment": false,
  "NumReplies": 312,
  "NumMessages": 541,
  "FromAddress": "quisquam",
  "Messages": [
    {
      "TicketMessageId": 51,
      "CreatedAt": "2010-08-31T16:54:56.447137+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "id",
      "PersonId": 608,
      "PersonFullName": "Mrs. Mallory Patsy Swift",
      "ContactId": 642,
      "ContactName": "Runolfsson, Prosacco and Daniel",
      "ContactDepartment": "seize cross-media deliverables",
      "NumAttachments": 487,
      "EmailHeader": "ciara@schulistbins.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "sunt",
      "Sentiment": 759,
      "SentimentConfidence": 381,
      "CreatedBy": 507,
      "ChangedAt": "2017-12-09T16:54:56.447137+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 940
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 599,
      "Name": "Muller, Kerluke and Orn",
      "ToolTip": "Adipisci ipsam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 62
        }
      }
    },
    {
      "Id": 599,
      "Name": "Muller, Kerluke and Orn",
      "ToolTip": "Adipisci ipsam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 62
        }
      }
    }
  ],
  "Language": "aut",
  "Sentiment": 432,
  "SentimentConfidence": 503,
  "SuggestedCategoryId": 23,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 906,
  "IconHint": "velit",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 803,
  "ExtraFields": {
    "ExtraFields1": "nam",
    "ExtraFields2": "facere"
  },
  "CustomFields": {
    "CustomFields1": "enim",
    "CustomFields2": "in"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 972
    }
  }
}
```