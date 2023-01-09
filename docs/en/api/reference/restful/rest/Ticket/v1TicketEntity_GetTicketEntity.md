---
title: GET Ticket/{id}
uid: v1TicketEntity_GetTicketEntity
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
| OwnedBy | Associate | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category | TicketCategoryEntity | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority | TicketPriorityEntity | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status | TicketStatusEntity | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person | Person | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
| SecondaryPersons | array | The secondary persons this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 TicketEntity found.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 834,
  "Title": "cumque",
  "CreatedAt": "1998-04-21T17:37:39.2763037+02:00",
  "LastChanged": "2020-03-26T17:37:39.2763037+01:00",
  "ReadByOwner": "2004-12-03T17:37:39.2763037+01:00",
  "ReadByCustomer": "2015-10-06T17:37:39.2763037+02:00",
  "FirstReadByOwner": "2015-05-03T17:37:39.2763037+02:00",
  "FirstReadByUser": "2000-06-06T17:37:39.2763037+02:00",
  "Activate": "2002-10-02T17:37:39.2763037+02:00",
  "ClosedAt": "2005-07-05T17:37:39.2763037+02:00",
  "RepliedAt": "2002-04-25T17:37:39.2763037+02:00",
  "AlertTimeout": "2015-05-04T17:37:39.2763037+02:00",
  "Deadline": "2012-07-08T17:37:39.2763037+02:00",
  "CreatedBy": null,
  "Author": "esse",
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
      "Position": "ab",
      "PersonId": 828,
      "Mrmrs": "est",
      "Firstname": "Kara",
      "Lastname": "Schmidt",
      "MiddleName": "Bernier, Metz and Okuneva",
      "Title": "omnis",
      "Description": "Expanded uniform parallelism",
      "Email": "torrey@berge.com",
      "FullName": "Mr. Leonardo Bernadine Jacobi DVM",
      "DirectPhone": "339-357-7880 x1928",
      "FormalName": "McLaughlin-Gleason",
      "CountryId": 264,
      "ContactId": 637,
      "ContactName": "Langworth, Kemmer and Balistreri",
      "Retired": 848,
      "Rank": 901,
      "ActiveInterests": 506,
      "ContactDepartment": "",
      "ContactCountryId": 655,
      "ContactOrgNr": "1631973",
      "FaxPhone": "(542)796-0867 x2830",
      "MobilePhone": "430.710.9725 x139",
      "ContactPhone": "210-450-1179 x01556",
      "AssociateName": "Grimes-Jacobs",
      "AssociateId": 123,
      "UsePersonAddress": false,
      "ContactFax": "laudantium",
      "Kanafname": "omnis",
      "Kanalname": "minus",
      "Post1": "repellendus",
      "Post2": "blanditiis",
      "Post3": "a",
      "EmailName": "aliza@rosenbaum.uk",
      "ContactFullName": "Barrett Hills",
      "ActiveErpLinks": 639,
      "TicketPriorityId": 986,
      "SupportLanguageId": 463,
      "SupportAssociateId": 534,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 526
        }
      }
    }
  ],
  "AlertLevel": 38,
  "ConnectId": 80,
  "ReadStatus": "Green",
  "TimeToReply": 861,
  "RealTimeToReply": 122,
  "TimeToClose": 985,
  "RealTimeToClose": 213,
  "TimeSpentInternally": 806,
  "TimeSpentExternally": 748,
  "TimeSpentQueue": 839,
  "RealTimeSpentInternally": 279,
  "RealTimeSpentExternally": 789,
  "RealTimeSpentQueue": 848,
  "HasAttachment": false,
  "NumReplies": 120,
  "NumMessages": 553,
  "FromAddress": "et",
  "Messages": [
    {
      "TicketMessageId": 586,
      "CreatedAt": "2016-04-12T17:37:39.2803037+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "voluptatem",
      "PersonId": 100,
      "PersonFullName": "Mr. Justen Ada Mitchell II",
      "ContactId": 483,
      "ContactName": "Rohan LLC",
      "ContactDepartment": "",
      "NumAttachments": 818,
      "EmailHeader": "kole@walker.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "et",
      "Sentiment": 447,
      "SentimentConfidence": 938,
      "CreatedBy": 493,
      "ChangedAt": "2004-07-07T17:37:39.2803037+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 586
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 12,
      "Name": "O'Reilly-Terry",
      "ToolTip": "Labore in est velit rerum impedit tenetur.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 877
        }
      }
    },
    {
      "Id": 12,
      "Name": "O'Reilly-Terry",
      "ToolTip": "Labore in est velit rerum impedit tenetur.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 877
        }
      }
    }
  ],
  "Language": "porro",
  "Sentiment": 799,
  "SentimentConfidence": 474,
  "SuggestedCategoryId": 277,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 178,
  "IconHint": "assumenda",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "praesentium"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
    "CustomFields2": "doloremque"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 59
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```