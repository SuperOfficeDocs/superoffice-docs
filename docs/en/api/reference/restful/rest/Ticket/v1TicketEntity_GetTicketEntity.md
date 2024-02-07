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
  "TicketId": 94,
  "Title": "non",
  "CreatedAt": "2002-08-06T16:55:30.1920652+02:00",
  "LastChanged": "2007-08-14T16:55:30.1920652+02:00",
  "ReadByOwner": "2017-01-29T16:55:30.1920652+01:00",
  "ReadByCustomer": "2008-06-03T16:55:30.1920652+02:00",
  "FirstReadByOwner": "2020-06-02T16:55:30.1920652+02:00",
  "FirstReadByUser": "2018-03-03T16:55:30.1920652+01:00",
  "Activate": "2019-06-19T16:55:30.1920652+02:00",
  "ClosedAt": "1999-01-03T16:55:30.1920652+01:00",
  "RepliedAt": "2006-10-09T16:55:30.1920652+02:00",
  "AlertTimeout": "1997-07-29T16:55:30.1920652+02:00",
  "Deadline": "2013-07-01T16:55:30.1920652+02:00",
  "CreatedBy": null,
  "Author": "quis",
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
      "Position": "deleniti",
      "PersonId": 145,
      "Mrmrs": "excepturi",
      "Firstname": "Leif",
      "Lastname": "Grady",
      "MiddleName": "Crona-Roob",
      "Title": "et",
      "Description": "Focused fresh-thinking orchestration",
      "Email": "ewald_stracke@kossreilly.co.uk",
      "FullName": "Maci Rau",
      "DirectPhone": "1-926-143-5846 x919",
      "FormalName": "Heaney LLC",
      "CountryId": 329,
      "ContactId": 633,
      "ContactName": "Wuckert Group",
      "Retired": 485,
      "Rank": 781,
      "ActiveInterests": 841,
      "ContactDepartment": "",
      "ContactCountryId": 308,
      "ContactOrgNr": "1530113",
      "FaxPhone": "(337)655-1899",
      "MobilePhone": "(165)476-8615 x2517",
      "ContactPhone": "1-474-588-4710",
      "AssociateName": "McClure, Predovic and Wuckert",
      "AssociateId": 620,
      "UsePersonAddress": false,
      "ContactFax": "sed",
      "Kanafname": "repellendus",
      "Kanalname": "reiciendis",
      "Post1": "quia",
      "Post2": "ipsum",
      "Post3": "autem",
      "EmailName": "valentina.wehner@robel.co.uk",
      "ContactFullName": "Juliana Homenick",
      "ActiveErpLinks": 403,
      "TicketPriorityId": 588,
      "SupportLanguageId": 928,
      "SupportAssociateId": 684,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 571
        }
      }
    }
  ],
  "AlertLevel": 274,
  "ConnectId": 651,
  "ReadStatus": "Green",
  "TimeToReply": 50,
  "RealTimeToReply": 44,
  "TimeToClose": 996,
  "RealTimeToClose": 440,
  "TimeSpentInternally": 624,
  "TimeSpentExternally": 58,
  "TimeSpentQueue": 366,
  "RealTimeSpentInternally": 674,
  "RealTimeSpentExternally": 881,
  "RealTimeSpentQueue": 858,
  "TimeSpent": 761,
  "HasAttachment": false,
  "NumReplies": 504,
  "NumMessages": 737,
  "FromAddress": "sed",
  "Messages": [
    {
      "TicketMessageId": 196,
      "CreatedAt": "2006-06-26T16:55:30.1959099+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "voluptatem",
      "PersonId": 45,
      "PersonFullName": "Kelley Bernier",
      "ContactId": 919,
      "ContactName": "Moen, Bayer and Schimmel",
      "ContactDepartment": "",
      "NumAttachments": 956,
      "EmailHeader": "lou.schuppe@oreilly.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "non",
      "Sentiment": 971,
      "SentimentConfidence": 632,
      "CreatedBy": 847,
      "ChangedAt": "2004-05-11T16:55:30.1959099+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 770
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 856,
      "Name": "Ebert, Kuhic and Kirlin",
      "ToolTip": "Sed et perspiciatis fuga modi.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 682
        }
      }
    },
    {
      "Id": 856,
      "Name": "Ebert, Kuhic and Kirlin",
      "ToolTip": "Sed et perspiciatis fuga modi.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 682
        }
      }
    }
  ],
  "Language": "maxime",
  "Sentiment": 939,
  "SentimentConfidence": 936,
  "SuggestedCategoryId": 155,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 568,
  "IconHint": "non",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 139,
  "ExtraFields": {
    "ExtraFields1": "fuga",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 322
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```