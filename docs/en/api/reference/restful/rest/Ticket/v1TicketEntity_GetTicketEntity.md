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
  "TicketId": 207,
  "Title": "perferendis",
  "CreatedAt": "2007-02-05T04:22:35.5022347+01:00",
  "LastChanged": "2021-11-27T04:22:35.5022347+01:00",
  "ReadByOwner": "2017-08-06T04:22:35.5022347+02:00",
  "ReadByCustomer": "2020-11-25T04:22:35.5022347+01:00",
  "FirstReadByOwner": "2017-06-05T04:22:35.5022347+02:00",
  "FirstReadByUser": "2012-12-06T04:22:35.5022347+01:00",
  "Activate": "2008-08-25T04:22:35.5022347+02:00",
  "ClosedAt": "1998-02-09T04:22:35.5022347+01:00",
  "RepliedAt": "2002-05-26T04:22:35.5022347+02:00",
  "AlertTimeout": "2015-12-24T04:22:35.5022347+01:00",
  "Deadline": "2002-10-01T04:22:35.5022347+02:00",
  "CreatedBy": null,
  "Author": "culpa",
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
      "Position": "repudiandae",
      "PersonId": 175,
      "Mrmrs": "magnam",
      "Firstname": "Rigoberto",
      "Lastname": "Connelly",
      "MiddleName": "Swift, Turner and Dicki",
      "Title": "rerum",
      "Description": "Re-engineered demand-driven frame",
      "Email": "garland@nitzsche.ca",
      "FullName": "Brant Lemke",
      "DirectPhone": "1-195-873-7098",
      "FormalName": "Collins-Murazik",
      "CountryId": 282,
      "ContactId": 26,
      "ContactName": "Rowe Inc and Sons",
      "Retired": 276,
      "Rank": 676,
      "ActiveInterests": 349,
      "ContactDepartment": "",
      "ContactCountryId": 850,
      "ContactOrgNr": "1037485",
      "FaxPhone": "(634)060-5987",
      "MobilePhone": "1-818-716-0357 x464",
      "ContactPhone": "(358)310-3447 x43962",
      "AssociateName": "Walker, Bechtelar and Mertz",
      "AssociateId": 679,
      "UsePersonAddress": false,
      "ContactFax": "repellat",
      "Kanafname": "praesentium",
      "Kanalname": "voluptas",
      "Post1": "libero",
      "Post2": "aut",
      "Post3": "et",
      "EmailName": "devin@windler.uk",
      "ContactFullName": "Melany Gerlach",
      "ActiveErpLinks": 414,
      "TicketPriorityId": 165,
      "SupportLanguageId": 5,
      "SupportAssociateId": 729,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 330
        }
      }
    }
  ],
  "AlertLevel": 495,
  "ConnectId": 395,
  "ReadStatus": "Green",
  "TimeToReply": 177,
  "RealTimeToReply": 649,
  "TimeToClose": 787,
  "RealTimeToClose": 198,
  "TimeSpentInternally": 852,
  "TimeSpentExternally": 791,
  "TimeSpentQueue": 496,
  "RealTimeSpentInternally": 696,
  "RealTimeSpentExternally": 815,
  "RealTimeSpentQueue": 625,
  "TimeSpent": 509,
  "HasAttachment": false,
  "NumReplies": 748,
  "NumMessages": 602,
  "FromAddress": "quis",
  "Messages": [
    {
      "TicketMessageId": 43,
      "CreatedAt": "1997-07-12T04:22:35.5022347+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "impedit",
      "PersonId": 937,
      "PersonFullName": "Frederique Kailyn Hermiston DDS",
      "ContactId": 989,
      "ContactName": "Carter, Medhurst and Jakubowski",
      "ContactDepartment": "",
      "NumAttachments": 11,
      "EmailHeader": "dorothy@konopelski.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "facilis",
      "Sentiment": 36,
      "SentimentConfidence": 742,
      "CreatedBy": 511,
      "ChangedAt": "2006-11-12T04:22:35.5022347+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 812
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 236,
      "Name": "Breitenberg, Gusikowski and O'Conner",
      "ToolTip": "Qui voluptatum nobis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 918
        }
      }
    },
    {
      "Id": 236,
      "Name": "Breitenberg, Gusikowski and O'Conner",
      "ToolTip": "Qui voluptatum nobis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 918
        }
      }
    }
  ],
  "Language": "cumque",
  "Sentiment": 748,
  "SentimentConfidence": 805,
  "SuggestedCategoryId": 597,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 756,
  "IconHint": "ea",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 40,
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "tenetur",
    "CustomFields2": "earum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 470
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```