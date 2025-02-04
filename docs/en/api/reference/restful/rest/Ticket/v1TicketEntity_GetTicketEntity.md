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
  "TicketId": 646,
  "Title": "necessitatibus",
  "CreatedAt": "2003-01-12T13:13:32.3861399+01:00",
  "LastChanged": "2003-07-10T13:13:32.3861399+02:00",
  "ReadByOwner": "2008-07-05T13:13:32.3861399+02:00",
  "ReadByCustomer": "2002-11-27T13:13:32.3861399+01:00",
  "FirstReadByOwner": "2019-09-25T13:13:32.3861399+02:00",
  "FirstReadByUser": "2018-09-06T13:13:32.3861399+02:00",
  "Activate": "2024-06-22T13:13:32.3861399+02:00",
  "ClosedAt": "2020-08-29T13:13:32.3861399+02:00",
  "RepliedAt": "2002-09-30T13:13:32.3861399+02:00",
  "AlertTimeout": "2019-09-17T13:13:32.3861399+02:00",
  "Deadline": "2000-06-18T13:13:32.3861399+02:00",
  "CreatedBy": null,
  "Author": "vitae",
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
      "Position": "et",
      "PersonId": 97,
      "Mrmrs": "eum",
      "Firstname": "Erwin",
      "Lastname": "Windler",
      "MiddleName": "Walker, Lubowitz and Pacocha",
      "Title": "fuga",
      "Description": "Quality-focused next generation open system",
      "Email": "cathryn@wisozk.co.uk",
      "FullName": "Mrs. Estevan Francesco Kirlin",
      "DirectPhone": "(846)994-0250 x803",
      "FormalName": "Lynch LLC",
      "CountryId": 86,
      "ContactId": 637,
      "ContactName": "Schmidt-Reichert",
      "Retired": 968,
      "Rank": 574,
      "ActiveInterests": 113,
      "ContactDepartment": "",
      "ContactCountryId": 457,
      "ContactOrgNr": "515089",
      "FaxPhone": "1-125-928-4601 x575",
      "MobilePhone": "1-521-726-7094 x3754",
      "ContactPhone": "(910)814-7565 x450",
      "AssociateName": "Hudson-Farrell",
      "AssociateId": 153,
      "UsePersonAddress": false,
      "ContactFax": "ratione",
      "Kanafname": "aliquid",
      "Kanalname": "eos",
      "Post1": "quam",
      "Post2": "nostrum",
      "Post3": "qui",
      "EmailName": "willis_kozey@okunevacrooks.us",
      "ContactFullName": "Jayne McKenzie",
      "ActiveErpLinks": 274,
      "TicketPriorityId": 882,
      "SupportLanguageId": 557,
      "SupportAssociateId": 471,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 757
        }
      }
    }
  ],
  "AlertLevel": 272,
  "ConnectId": 431,
  "ReadStatus": "Green",
  "TimeToReply": 679,
  "RealTimeToReply": 680,
  "TimeToClose": 251,
  "RealTimeToClose": 76,
  "TimeSpentInternally": 57,
  "TimeSpentExternally": 568,
  "TimeSpentQueue": 544,
  "RealTimeSpentInternally": 262,
  "RealTimeSpentExternally": 426,
  "RealTimeSpentQueue": 813,
  "TimeSpent": 367,
  "HasAttachment": true,
  "NumReplies": 853,
  "NumMessages": 468,
  "FromAddress": "nihil",
  "Messages": [
    {
      "TicketMessageId": 271,
      "CreatedAt": "2002-12-16T13:13:32.4017612+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "et",
      "PersonId": 448,
      "PersonFullName": "Julianne Shields Sr.",
      "ContactId": 811,
      "ContactName": "Osinski LLC",
      "ContactDepartment": "",
      "NumAttachments": 198,
      "EmailHeader": "mandy@auerfranecki.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "illo",
      "Sentiment": 357,
      "SentimentConfidence": 211,
      "CreatedBy": 605,
      "ChangedAt": "2012-10-23T13:13:32.4017612+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 969
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 410,
      "Name": "Renner, Dietrich and Bauch",
      "ToolTip": "Praesentium consequatur voluptas animi corrupti quo earum.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 592
        }
      }
    },
    {
      "Id": 410,
      "Name": "Renner, Dietrich and Bauch",
      "ToolTip": "Praesentium consequatur voluptas animi corrupti quo earum.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 592
        }
      }
    }
  ],
  "Language": "rerum",
  "Sentiment": 144,
  "SentimentConfidence": 878,
  "SuggestedCategoryId": 97,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 926,
  "IconHint": "nam",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 973,
  "ExtraFields": {
    "ExtraFields1": "placeat",
    "ExtraFields2": "cumque"
  },
  "CustomFields": {
    "CustomFields1": "velit",
    "CustomFields2": "in"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 419
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```