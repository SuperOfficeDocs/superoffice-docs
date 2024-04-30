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
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=800
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
  "TicketId": 980,
  "Title": "ut",
  "CreatedAt": "2008-10-12T11:16:09.8822214+02:00",
  "LastChanged": "2006-03-11T11:16:09.8822214+01:00",
  "ReadByOwner": "2012-11-24T11:16:09.8822214+01:00",
  "ReadByCustomer": "2009-06-10T11:16:09.8822214+02:00",
  "FirstReadByOwner": "2021-12-04T11:16:09.8822214+01:00",
  "FirstReadByUser": "2011-03-02T11:16:09.8822214+01:00",
  "Activate": "2010-02-13T11:16:09.8822214+01:00",
  "ClosedAt": "2001-06-27T11:16:09.8822214+02:00",
  "RepliedAt": "2017-04-06T11:16:09.8822214+02:00",
  "AlertTimeout": "2001-07-18T11:16:09.8822214+02:00",
  "Deadline": "2017-07-09T11:16:09.8822214+02:00",
  "CreatedBy": null,
  "Author": "consequatur",
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
      "Position": "nam",
      "PersonId": 486,
      "Mrmrs": "voluptatum",
      "Firstname": "Richmond",
      "Lastname": "Rempel",
      "MiddleName": "Wisoky, Wilderman and Wolf",
      "Title": "dolore",
      "Description": "Polarised real-time adapter",
      "Email": "briana@greenfelder.name",
      "FullName": "Ebba O'Hara",
      "DirectPhone": "634-411-3593 x800",
      "FormalName": "Bogisich-Smitham",
      "CountryId": 95,
      "ContactId": 723,
      "ContactName": "Schultz LLC",
      "Retired": 1001,
      "Rank": 718,
      "ActiveInterests": 363,
      "ContactDepartment": "",
      "ContactCountryId": 782,
      "ContactOrgNr": "196903",
      "FaxPhone": "913.451.8690",
      "MobilePhone": "1-611-844-4758",
      "ContactPhone": "590.638.9694",
      "AssociateName": "Kuphal Group",
      "AssociateId": 379,
      "UsePersonAddress": false,
      "ContactFax": "qui",
      "Kanafname": "rem",
      "Kanalname": "rerum",
      "Post1": "consequatur",
      "Post2": "sapiente",
      "Post3": "fugiat",
      "EmailName": "mae@schumm.info",
      "ContactFullName": "Mina Kulas",
      "ActiveErpLinks": 305,
      "TicketPriorityId": 71,
      "SupportLanguageId": 65,
      "SupportAssociateId": 314,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 461
        }
      }
    }
  ],
  "AlertLevel": 907,
  "ConnectId": 112,
  "ReadStatus": "Green",
  "TimeToReply": 510,
  "RealTimeToReply": 174,
  "TimeToClose": 65,
  "RealTimeToClose": 20,
  "TimeSpentInternally": 212,
  "TimeSpentExternally": 444,
  "TimeSpentQueue": 938,
  "RealTimeSpentInternally": 107,
  "RealTimeSpentExternally": 250,
  "RealTimeSpentQueue": 411,
  "TimeSpent": 19,
  "HasAttachment": false,
  "NumReplies": 182,
  "NumMessages": 272,
  "FromAddress": "voluptas",
  "Messages": [
    {
      "TicketMessageId": 328,
      "CreatedAt": "2013-12-18T11:16:09.8985748+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "cumque",
      "PersonId": 681,
      "PersonFullName": "Salma Treutel",
      "ContactId": 76,
      "ContactName": "Ruecker, Effertz and Bergnaum",
      "ContactDepartment": "",
      "NumAttachments": 983,
      "EmailHeader": "geovanni@gerholdyost.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ratione",
      "Sentiment": 401,
      "SentimentConfidence": 239,
      "CreatedBy": 532,
      "ChangedAt": "2013-03-28T11:16:09.8985748+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 35
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 878,
      "Name": "Mohr-Funk",
      "ToolTip": "Amet enim non corrupti praesentium.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 117
        }
      }
    },
    {
      "Id": 878,
      "Name": "Mohr-Funk",
      "ToolTip": "Amet enim non corrupti praesentium.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 117
        }
      }
    }
  ],
  "Language": "eum",
  "Sentiment": 57,
  "SentimentConfidence": 343,
  "SuggestedCategoryId": 862,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 384,
  "IconHint": "error",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 189,
  "ExtraFields": {
    "ExtraFields1": "dicta",
    "ExtraFields2": "occaecati"
  },
  "CustomFields": {
    "CustomFields1": "nemo",
    "CustomFields2": "neque"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 673
    }
  }
}
```