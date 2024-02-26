---
title: POST Agents/Ticket/CreateDefaultTicketEntity
uid: v1TicketAgent_CreateDefaultTicketEntity
generated: true
---

# POST Agents/Ticket/CreateDefaultTicketEntity

```http
POST /api/v1/Agents/Ticket/CreateDefaultTicketEntity
```

Set default values into a new TicketEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
POST /api/v1/Agents/Ticket/CreateDefaultTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 729,
  "Title": "ratione",
  "CreatedAt": "2007-05-18T10:30:24.7642118+02:00",
  "LastChanged": "2004-07-15T10:30:24.7642118+02:00",
  "ReadByOwner": "1996-09-30T10:30:24.7642118+02:00",
  "ReadByCustomer": "2019-10-11T10:30:24.7642118+02:00",
  "FirstReadByOwner": "2014-07-05T10:30:24.7642118+02:00",
  "FirstReadByUser": "2011-12-13T10:30:24.7642118+01:00",
  "Activate": "2011-10-24T10:30:24.7642118+02:00",
  "ClosedAt": "2013-10-02T10:30:24.7642118+02:00",
  "RepliedAt": "1998-10-31T10:30:24.7642118+01:00",
  "AlertTimeout": "2002-12-19T10:30:24.7642118+01:00",
  "Deadline": "2012-09-23T10:30:24.7642118+02:00",
  "CreatedBy": null,
  "Author": "nihil",
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
      "Position": "non",
      "PersonId": 86,
      "Mrmrs": "ab",
      "Firstname": "Ocie",
      "Lastname": "Wisoky",
      "MiddleName": "Jacobson Inc and Sons",
      "Title": "nihil",
      "Description": "Visionary maximized Graphic Interface",
      "Email": "glen.von@mclaughlin.biz",
      "FullName": "Emerald Moore",
      "DirectPhone": "557-376-7895 x2119",
      "FormalName": "Reichel, Gislason and Cormier",
      "CountryId": 397,
      "ContactId": 209,
      "ContactName": "Brekke, Vandervort and Daniel",
      "Retired": 314,
      "Rank": 893,
      "ActiveInterests": 564,
      "ContactDepartment": "",
      "ContactCountryId": 916,
      "ContactOrgNr": "1275918",
      "FaxPhone": "429.276.9217 x21277",
      "MobilePhone": "008-441-7445",
      "ContactPhone": "(915)472-3603 x90928",
      "AssociateName": "Kreiger, Beatty and Schamberger",
      "AssociateId": 527,
      "UsePersonAddress": false,
      "ContactFax": "voluptatem",
      "Kanafname": "architecto",
      "Kanalname": "labore",
      "Post1": "natus",
      "Post2": "eligendi",
      "Post3": "maiores",
      "EmailName": "rudolph@smith.info",
      "ContactFullName": "Leanna Yost",
      "ActiveErpLinks": 642,
      "TicketPriorityId": 873,
      "SupportLanguageId": 421,
      "SupportAssociateId": 575,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 866
        }
      }
    }
  ],
  "AlertLevel": 392,
  "ConnectId": 336,
  "ReadStatus": "Green",
  "TimeToReply": 835,
  "RealTimeToReply": 361,
  "TimeToClose": 335,
  "RealTimeToClose": 530,
  "TimeSpentInternally": 635,
  "TimeSpentExternally": 966,
  "TimeSpentQueue": 109,
  "RealTimeSpentInternally": 848,
  "RealTimeSpentExternally": 956,
  "RealTimeSpentQueue": 782,
  "TimeSpent": 831,
  "HasAttachment": false,
  "NumReplies": 557,
  "NumMessages": 173,
  "FromAddress": "aperiam",
  "Messages": [
    {
      "TicketMessageId": 585,
      "CreatedAt": "2003-09-28T10:30:24.7642118+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "omnis",
      "PersonId": 349,
      "PersonFullName": "Magnus Larkin II",
      "ContactId": 970,
      "ContactName": "Reynolds Group",
      "ContactDepartment": "",
      "NumAttachments": 350,
      "EmailHeader": "winnifred.luettgen@rolfson.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "asperiores",
      "Sentiment": 866,
      "SentimentConfidence": 779,
      "CreatedBy": 139,
      "ChangedAt": "2008-07-25T10:30:24.7642118+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 813
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 955,
      "Name": "Hickle, Metz and Wintheiser",
      "ToolTip": "Tenetur eum odio et possimus voluptate id est.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 603
        }
      }
    },
    {
      "Id": 955,
      "Name": "Hickle, Metz and Wintheiser",
      "ToolTip": "Tenetur eum odio et possimus voluptate id est.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 603
        }
      }
    }
  ],
  "Language": "repellendus",
  "Sentiment": 928,
  "SentimentConfidence": 290,
  "SuggestedCategoryId": 892,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 895,
  "IconHint": "perferendis",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 49,
  "ExtraFields": {
    "ExtraFields1": "sequi",
    "ExtraFields2": "laboriosam"
  },
  "CustomFields": {
    "CustomFields1": "incidunt",
    "CustomFields2": "sunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 917
    }
  }
}
```