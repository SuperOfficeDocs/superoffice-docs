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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 TicketEntity found.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 781,
  "Title": "nihil",
  "CreatedAt": "1998-09-13T13:14:11.1329328+02:00",
  "LastChanged": "2012-01-28T13:14:11.1329328+01:00",
  "ReadByOwner": "2017-04-24T13:14:11.1329328+02:00",
  "ReadByCustomer": "2008-06-28T13:14:11.1329328+02:00",
  "FirstReadByOwner": "2014-01-20T13:14:11.1329328+01:00",
  "FirstReadByUser": "2000-07-02T13:14:11.1329328+02:00",
  "Activate": "1997-08-31T13:14:11.1329328+02:00",
  "ClosedAt": "2020-01-08T13:14:11.1329328+01:00",
  "RepliedAt": "2011-06-04T13:14:11.1329328+02:00",
  "AlertTimeout": "2018-02-18T13:14:11.1329328+01:00",
  "Deadline": "2022-07-24T13:14:11.1329328+02:00",
  "CreatedBy": null,
  "Author": "voluptates",
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
      "Position": "distinctio",
      "PersonId": 728,
      "Mrmrs": "unde",
      "Firstname": "Braulio",
      "Lastname": "Trantow",
      "MiddleName": "Kutch Group",
      "Title": "voluptas",
      "Description": "Triple-buffered object-oriented info-mediaries",
      "Email": "abdul@hessel.ca",
      "FullName": "Dr. Hellen Morissette",
      "DirectPhone": "1-600-189-6811 x1357",
      "FormalName": "Welch-Keebler",
      "CountryId": 601,
      "ContactId": 109,
      "ContactName": "Hyatt Group",
      "Retired": 704,
      "Rank": 361,
      "ActiveInterests": 144,
      "ContactDepartment": "",
      "ContactCountryId": 584,
      "ContactOrgNr": "826636",
      "FaxPhone": "265.853.8628 x604",
      "MobilePhone": "1-108-206-2003 x719",
      "ContactPhone": "902.006.9940 x95820",
      "AssociateName": "Lemke-Reichel",
      "AssociateId": 640,
      "UsePersonAddress": false,
      "ContactFax": "pariatur",
      "Kanafname": "reprehenderit",
      "Kanalname": "molestiae",
      "Post1": "repellendus",
      "Post2": "et",
      "Post3": "doloribus",
      "EmailName": "norval_glover@carter.info",
      "ContactFullName": "Emanuel Renner DDS",
      "ActiveErpLinks": 534,
      "TicketPriorityId": 736,
      "SupportLanguageId": 143,
      "SupportAssociateId": 711,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 53
        }
      }
    }
  ],
  "AlertLevel": 529,
  "ConnectId": 902,
  "ReadStatus": "Green",
  "TimeToReply": 518,
  "RealTimeToReply": 237,
  "TimeToClose": 703,
  "RealTimeToClose": 17,
  "TimeSpentInternally": 678,
  "TimeSpentExternally": 802,
  "TimeSpentQueue": 426,
  "RealTimeSpentInternally": 295,
  "RealTimeSpentExternally": 582,
  "RealTimeSpentQueue": 239,
  "TimeSpent": 776,
  "HasAttachment": false,
  "NumReplies": 345,
  "NumMessages": 82,
  "FromAddress": "optio",
  "Messages": [
    {
      "TicketMessageId": 750,
      "CreatedAt": "2015-10-14T13:14:11.1329328+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "dolores",
      "PersonId": 404,
      "PersonFullName": "Theresa Schmidt",
      "ContactId": 480,
      "ContactName": "Johnson-Schinner",
      "ContactDepartment": "",
      "NumAttachments": 605,
      "EmailHeader": "maiya_runolfsson@spencer.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "blanditiis",
      "Sentiment": 215,
      "SentimentConfidence": 755,
      "CreatedBy": 968,
      "ChangedAt": "2011-04-12T13:14:11.1329328+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 734
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 426,
      "Name": "Quigley-Trantow",
      "ToolTip": "Enim est quam commodi dolore ut aspernatur.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 325
        }
      }
    },
    {
      "Id": 426,
      "Name": "Quigley-Trantow",
      "ToolTip": "Enim est quam commodi dolore ut aspernatur.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 325
        }
      }
    }
  ],
  "Language": "quidem",
  "Sentiment": 574,
  "SentimentConfidence": 2,
  "SuggestedCategoryId": 347,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 614,
  "IconHint": "ut",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 545,
  "ExtraFields": {
    "ExtraFields1": "assumenda",
    "ExtraFields2": "praesentium"
  },
  "CustomFields": {
    "CustomFields1": "optio",
    "CustomFields2": "labore"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 892
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```