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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 TicketEntity found.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 124,
  "Title": "necessitatibus",
  "CreatedAt": "2003-04-28T15:29:30.676987+02:00",
  "LastChanged": "2003-12-19T15:29:30.676987+01:00",
  "ReadByOwner": "1998-03-29T15:29:30.676987+02:00",
  "ReadByCustomer": "2016-12-14T15:29:30.676987+01:00",
  "FirstReadByOwner": "2008-07-25T15:29:30.676987+02:00",
  "FirstReadByUser": "2017-01-09T15:29:30.676987+01:00",
  "Activate": "2013-08-22T15:29:30.676987+02:00",
  "ClosedAt": "2000-01-05T15:29:30.676987+01:00",
  "RepliedAt": "2021-08-22T15:29:30.676987+02:00",
  "AlertTimeout": "2017-06-09T15:29:30.676987+02:00",
  "Deadline": "2020-06-22T15:29:30.676987+02:00",
  "CreatedBy": null,
  "Author": "et",
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
      "Position": "voluptates",
      "PersonId": 744,
      "Mrmrs": "ex",
      "Firstname": "Irwin",
      "Lastname": "McDermott",
      "MiddleName": "O'Reilly, Hermann and Schumm",
      "Title": "voluptas",
      "Description": "Quality-focused asynchronous standardization",
      "Email": "ali@kesslerhowell.name",
      "FullName": "Ray Von",
      "DirectPhone": "652-755-4961 x0950",
      "FormalName": "Spinka-Wisozk",
      "CountryId": 192,
      "ContactId": 485,
      "ContactName": "Brown, Jast and Funk",
      "Retired": 989,
      "Rank": 97,
      "ActiveInterests": 756,
      "ContactDepartment": "",
      "ContactCountryId": 117,
      "ContactOrgNr": "1716376",
      "FaxPhone": "(761)600-9162 x1978",
      "MobilePhone": "123.514.7436",
      "ContactPhone": "(129)384-2322",
      "AssociateName": "Runolfsson Inc and Sons",
      "AssociateId": 960,
      "UsePersonAddress": true,
      "ContactFax": "minus",
      "Kanafname": "corporis",
      "Kanalname": "omnis",
      "Post1": "pariatur",
      "Post2": "enim",
      "Post3": "optio",
      "EmailName": "sydni.runolfsdottir@bins.biz",
      "ContactFullName": "Dr. Edison Jake Morar",
      "ActiveErpLinks": 896,
      "TicketPriorityId": 503,
      "SupportLanguageId": 59,
      "SupportAssociateId": 332,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 36
        }
      }
    }
  ],
  "AlertLevel": 11,
  "ConnectId": 70,
  "ReadStatus": "Green",
  "TimeToReply": 772,
  "RealTimeToReply": 551,
  "TimeToClose": 242,
  "RealTimeToClose": 18,
  "TimeSpentInternally": 851,
  "TimeSpentExternally": 236,
  "TimeSpentQueue": 535,
  "RealTimeSpentInternally": 892,
  "RealTimeSpentExternally": 959,
  "RealTimeSpentQueue": 498,
  "HasAttachment": false,
  "NumReplies": 456,
  "NumMessages": 112,
  "FromAddress": "eveniet",
  "Messages": [
    {
      "TicketMessageId": 19,
      "CreatedAt": "2004-10-12T15:29:30.6819871+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "sint",
      "PersonId": 799,
      "PersonFullName": "Dan Breitenberg",
      "ContactId": 695,
      "ContactName": "Barton Group",
      "ContactDepartment": "",
      "NumAttachments": 842,
      "EmailHeader": "prince@parkerreinger.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "soluta",
      "Sentiment": 115,
      "SentimentConfidence": 319,
      "CreatedBy": 735,
      "ChangedAt": "2013-08-01T15:29:30.6819871+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 985
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 680,
      "Name": "Kris Inc and Sons",
      "ToolTip": "Deserunt vitae provident.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 148
        }
      }
    },
    {
      "Id": 680,
      "Name": "Kris Inc and Sons",
      "ToolTip": "Deserunt vitae provident.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 148
        }
      }
    }
  ],
  "Language": "sapiente",
  "Sentiment": 860,
  "SentimentConfidence": 623,
  "SuggestedCategoryId": 862,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 469,
  "IconHint": "possimus",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "non",
    "ExtraFields2": "aperiam"
  },
  "CustomFields": {
    "CustomFields1": "maxime",
    "CustomFields2": "quaerat"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 952
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```