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
GET /api/v1/Ticket/{id}?fk=False
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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 TicketEntity found.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 221,
  "Title": "sed",
  "CreatedAt": "2013-12-13T17:54:08.5699413+01:00",
  "LastChanged": "1999-07-15T17:54:08.5699413+02:00",
  "ReadByOwner": "2020-03-30T17:54:08.5699413+02:00",
  "ReadByCustomer": "2012-12-15T17:54:08.5699413+01:00",
  "FirstReadByOwner": "2013-04-15T17:54:08.5699413+02:00",
  "FirstReadByUser": "2011-03-24T17:54:08.5699413+01:00",
  "Activate": "2008-09-22T17:54:08.5699413+02:00",
  "ClosedAt": "2017-10-05T17:54:08.5699413+02:00",
  "RepliedAt": "1999-01-14T17:54:08.5699413+01:00",
  "AlertTimeout": "2009-01-23T17:54:08.5699413+01:00",
  "Deadline": "2011-03-30T17:54:08.5699413+02:00",
  "CreatedBy": null,
  "Author": "occaecati",
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
      "Position": "illum",
      "PersonId": 471,
      "Mrmrs": "temporibus",
      "Firstname": "Benton",
      "Lastname": "Cruickshank",
      "MiddleName": "Zboncak LLC",
      "Title": "hic",
      "Description": "Business-focused systemic time-frame",
      "Email": "laisha@hellerhammes.info",
      "FullName": "Mr. Akeem Schimmel",
      "DirectPhone": "1-929-136-5088 x121",
      "FormalName": "Franecki, Zieme and Tremblay",
      "CountryId": 191,
      "ContactId": 873,
      "ContactName": "Blick-Mertz",
      "Retired": 320,
      "Rank": 487,
      "ActiveInterests": 62,
      "ContactDepartment": "",
      "ContactCountryId": 597,
      "ContactOrgNr": "1355694",
      "FaxPhone": "264-902-0051 x85152",
      "MobilePhone": "873.335.7848",
      "ContactPhone": "421.854.4649 x103",
      "AssociateName": "Dickens-Brown",
      "AssociateId": 351,
      "UsePersonAddress": true,
      "ContactFax": "omnis",
      "Kanafname": "consequuntur",
      "Kanalname": "et",
      "Post1": "sequi",
      "Post2": "perferendis",
      "Post3": "et",
      "EmailName": "ben.murray@huels.biz",
      "ContactFullName": "Mark Hane Jr.",
      "ActiveErpLinks": 680,
      "TicketPriorityId": 658,
      "SupportLanguageId": 175,
      "SupportAssociateId": 849,
      "CategoryName": "VIP Customer",
      "PersonNumber": "971191",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 252
        }
      }
    }
  ],
  "AlertLevel": 629,
  "ConnectId": 835,
  "ReadStatus": "Green",
  "TimeToReply": 885,
  "RealTimeToReply": 213,
  "TimeToClose": 690,
  "RealTimeToClose": 394,
  "TimeSpentInternally": 282,
  "TimeSpentExternally": 916,
  "TimeSpentQueue": 854,
  "RealTimeSpentInternally": 340,
  "RealTimeSpentExternally": 530,
  "RealTimeSpentQueue": 604,
  "TimeSpent": 520,
  "HasAttachment": false,
  "NumReplies": 276,
  "NumMessages": 538,
  "FromAddress": "ut",
  "Messages": [
    {
      "TicketMessageId": 170,
      "CreatedAt": "2016-02-01T17:54:08.5699413+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "quaerat",
      "PersonId": 505,
      "PersonFullName": "Lily Shaina Schowalter DVM",
      "ContactId": 314,
      "ContactName": "Senger, Sauer and Kshlerin",
      "ContactDepartment": "",
      "NumAttachments": 39,
      "EmailHeader": "lizzie@jakubowski.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "labore",
      "Sentiment": 613,
      "SentimentConfidence": 642,
      "CreatedBy": 952,
      "ChangedAt": "2009-09-11T17:54:08.5699413+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 994
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 611,
      "Name": "Schultz-Zieme",
      "ToolTip": "Laudantium modi saepe provident est.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 209
        }
      }
    },
    {
      "Id": 611,
      "Name": "Schultz-Zieme",
      "ToolTip": "Laudantium modi saepe provident est.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 209
        }
      }
    }
  ],
  "Language": "est",
  "Sentiment": 938,
  "SentimentConfidence": 140,
  "SuggestedCategoryId": 878,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 852,
  "IconHint": "numquam",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 18,
  "ExtraFields": {
    "ExtraFields1": "aperiam",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "ex",
    "CustomFields2": "quibusdam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 360
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```