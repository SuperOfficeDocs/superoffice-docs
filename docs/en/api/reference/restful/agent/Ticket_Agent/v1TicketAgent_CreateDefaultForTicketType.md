---
title: POST Agents/Ticket/CreateDefaultForTicketType
uid: v1TicketAgent_CreateDefaultForTicketType
generated: true
---

# POST Agents/Ticket/CreateDefaultForTicketType

```http
POST /api/v1/Agents/Ticket/CreateDefaultForTicketType
```

Create default ticket entity for particular TicketType







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/CreateDefaultForTicketType?$select=name,department,category/id
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

TicketTypeId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketTypeId | Integer |  |

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
POST /api/v1/Agents/Ticket/CreateDefaultForTicketType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketTypeId": 77
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 344,
  "Title": "nobis",
  "CreatedAt": "2023-05-15T14:32:04.1865597+02:00",
  "LastChanged": "2013-09-08T14:32:04.1865597+02:00",
  "ReadByOwner": "2021-01-28T14:32:04.1865597+01:00",
  "ReadByCustomer": "2020-03-13T14:32:04.1865597+01:00",
  "FirstReadByOwner": "2020-03-06T14:32:04.1865597+01:00",
  "FirstReadByUser": "2013-07-16T14:32:04.1865597+02:00",
  "Activate": "2009-03-14T14:32:04.1865597+01:00",
  "ClosedAt": "2006-03-23T14:32:04.1865597+01:00",
  "RepliedAt": "2021-01-27T14:32:04.1865597+01:00",
  "AlertTimeout": "2023-08-09T14:32:04.1865597+02:00",
  "Deadline": "2019-03-12T14:32:04.1865597+01:00",
  "CreatedBy": null,
  "Author": "atque",
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
      "Position": "voluptatem",
      "PersonId": 356,
      "Mrmrs": "ipsa",
      "Firstname": "Wayne",
      "Lastname": "Connelly",
      "MiddleName": "Beahan-Bernier",
      "Title": "architecto",
      "Description": "Business-focused 6th generation capacity",
      "Email": "dexter@hackettkris.co.uk",
      "FullName": "Ms. Evalyn Dexter Kuhic DVM",
      "DirectPhone": "(545)444-0182",
      "FormalName": "Wilkinson-Keeling",
      "CountryId": 618,
      "ContactId": 794,
      "ContactName": "Schuppe, Gibson and Runte",
      "Retired": 606,
      "Rank": 85,
      "ActiveInterests": 313,
      "ContactDepartment": "",
      "ContactCountryId": 377,
      "ContactOrgNr": "466790",
      "FaxPhone": "880-085-0372 x2962",
      "MobilePhone": "(272)526-9341 x03006",
      "ContactPhone": "(114)074-4203 x33314",
      "AssociateName": "Fritsch, Schroeder and Erdman",
      "AssociateId": 656,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "ea",
      "Kanalname": "sint",
      "Post1": "asperiores",
      "Post2": "illo",
      "Post3": "beatae",
      "EmailName": "brad@hamillstiedemann.ca",
      "ContactFullName": "Ms. Kian Turner IV",
      "ActiveErpLinks": 867,
      "TicketPriorityId": 108,
      "SupportLanguageId": 50,
      "SupportAssociateId": 648,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1006836",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 762
        }
      }
    }
  ],
  "AlertLevel": 744,
  "ConnectId": 878,
  "ReadStatus": "Green",
  "TimeToReply": 161,
  "RealTimeToReply": 755,
  "TimeToClose": 413,
  "RealTimeToClose": 277,
  "TimeSpentInternally": 754,
  "TimeSpentExternally": 109,
  "TimeSpentQueue": 938,
  "RealTimeSpentInternally": 22,
  "RealTimeSpentExternally": 501,
  "RealTimeSpentQueue": 290,
  "TimeSpent": 742,
  "HasAttachment": true,
  "NumReplies": 482,
  "NumMessages": 381,
  "FromAddress": "praesentium",
  "Messages": [
    {
      "TicketMessageId": 664,
      "CreatedAt": "2011-02-10T14:32:04.2021813+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "voluptas",
      "PersonId": 49,
      "PersonFullName": "Dr. Amani Torphy IV",
      "ContactId": 25,
      "ContactName": "Grady, Goodwin and Spencer",
      "ContactDepartment": "",
      "NumAttachments": 909,
      "EmailHeader": "myrtice@jerde.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "nulla",
      "Sentiment": 559,
      "SentimentConfidence": 662,
      "CreatedBy": 214,
      "ChangedAt": "2013-04-01T14:32:04.2021813+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 847
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 786,
      "Name": "Klein LLC",
      "ToolTip": "Et facere quia reprehenderit quia quis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 63
        }
      }
    },
    {
      "Id": 786,
      "Name": "Klein LLC",
      "ToolTip": "Et facere quia reprehenderit quia quis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 63
        }
      }
    }
  ],
  "Language": "veritatis",
  "Sentiment": 909,
  "SentimentConfidence": 217,
  "SuggestedCategoryId": 700,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 543,
  "IconHint": "laboriosam",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 429,
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "veniam"
  },
  "CustomFields": {
    "CustomFields1": "quaerat",
    "CustomFields2": "labore"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 137
    }
  }
}
```