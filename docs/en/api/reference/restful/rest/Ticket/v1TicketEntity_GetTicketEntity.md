---
title: GET Ticket/{id}
uid: v1TicketEntity_GetTicketEntity
generated: true
---

# GET Ticket/{id}

```http
GET /api/v1/Ticket/{id}
```

Gets a TicketEntity object.


Calls the Ticket agent service GetTicketEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the TicketEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Ticket/{id}?$select=name,department,category/id
GET /api/v1/Ticket/{id}?fk=True
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

TicketEntity found.

| Response | Description |
|----------------|-------------|
| 200 | TicketEntity found. |
| 404 | Not Found. |

### Response body: TicketEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 TicketEntity found.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 537,
  "Title": "culpa",
  "CreatedAt": "2004-10-23T12:19:53.9773001+02:00",
  "LastChanged": "2021-01-03T12:19:53.9773001+01:00",
  "ReadByOwner": "2015-04-14T12:19:53.9773001+02:00",
  "ReadByCustomer": "2003-04-29T12:19:53.9773001+02:00",
  "FirstReadByOwner": "2019-01-28T12:19:53.9773001+01:00",
  "FirstReadByUser": "2021-08-01T12:19:53.9773001+02:00",
  "Activate": "2001-11-02T12:19:53.9773001+01:00",
  "ClosedAt": "2000-05-16T12:19:53.9773001+02:00",
  "RepliedAt": "2008-03-06T12:19:53.9773001+01:00",
  "AlertTimeout": "2011-08-29T12:19:53.9773001+02:00",
  "Deadline": "2019-09-12T12:19:53.9773001+02:00",
  "CreatedBy": null,
  "Author": "eligendi",
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
      "PersonId": 93,
      "Mrmrs": "eaque",
      "Firstname": "Treva",
      "Lastname": "Halvorson",
      "MiddleName": "Klocko-Miller",
      "Title": "iusto",
      "Description": "Multi-layered well-modulated archive",
      "Email": "bradford@ernser.co.uk",
      "FullName": "Mr. Dudley Caleigh Kshlerin",
      "DirectPhone": "204-668-6344",
      "FormalName": "Heidenreich-Schiller",
      "CountryId": 697,
      "ContactId": 435,
      "ContactName": "Gleason-Stanton",
      "Retired": 25,
      "Rank": 158,
      "ActiveInterests": 823,
      "ContactDepartment": "",
      "ContactCountryId": 947,
      "ContactOrgNr": "1525753",
      "FaxPhone": "076.005.2014",
      "MobilePhone": "079-143-0115 x717",
      "ContactPhone": "(868)542-0034",
      "AssociateName": "Orn-Schowalter",
      "AssociateId": 377,
      "UsePersonAddress": false,
      "ContactFax": "molestias",
      "Kanafname": "quam",
      "Kanalname": "iure",
      "Post1": "culpa",
      "Post2": "id",
      "Post3": "blanditiis",
      "EmailName": "olaf_cartwright@klein.us",
      "ContactFullName": "Mrs. Madisen Kessler",
      "ActiveErpLinks": 657,
      "TicketPriorityId": 63,
      "SupportLanguageId": 597,
      "SupportAssociateId": 96,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 70
        }
      }
    }
  ],
  "AlertLevel": 188,
  "ConnectId": 72,
  "ReadStatus": "Green",
  "TimeToReply": 529,
  "RealTimeToReply": 374,
  "TimeToClose": 424,
  "RealTimeToClose": 145,
  "TimeSpentInternally": 129,
  "TimeSpentExternally": 385,
  "TimeSpentQueue": 627,
  "RealTimeSpentInternally": 910,
  "RealTimeSpentExternally": 443,
  "RealTimeSpentQueue": 73,
  "TimeSpent": 472,
  "HasAttachment": false,
  "NumReplies": 432,
  "NumMessages": 690,
  "FromAddress": "nam",
  "Messages": [
    {
      "TicketMessageId": 344,
      "CreatedAt": "1997-07-26T12:19:53.9929096+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "minima",
      "PersonId": 921,
      "PersonFullName": "Mrs. Destiney Jaden Luettgen Sr.",
      "ContactId": 949,
      "ContactName": "White-Bauch",
      "ContactDepartment": "",
      "NumAttachments": 63,
      "EmailHeader": "hayden.kuhlman@schadenmetz.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "consequatur",
      "Sentiment": 874,
      "SentimentConfidence": 130,
      "CreatedBy": 539,
      "ChangedAt": "2020-02-13T12:19:53.9929096+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 379
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 243,
      "Name": "Kshlerin, McKenzie and Rodriguez",
      "ToolTip": "Rem autem aperiam consectetur minus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 610
        }
      }
    },
    {
      "Id": 243,
      "Name": "Kshlerin, McKenzie and Rodriguez",
      "ToolTip": "Rem autem aperiam consectetur minus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 610
        }
      }
    }
  ],
  "Language": "nulla",
  "Sentiment": 817,
  "SentimentConfidence": 854,
  "SuggestedCategoryId": 540,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 559,
  "IconHint": "aut",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 630,
  "ExtraFields": {
    "ExtraFields1": "animi",
    "ExtraFields2": "modi"
  },
  "CustomFields": {
    "CustomFields1": "dicta",
    "CustomFields2": "dolorum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 68
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```