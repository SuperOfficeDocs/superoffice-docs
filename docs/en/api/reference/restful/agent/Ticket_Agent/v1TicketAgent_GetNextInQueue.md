---
title: POST Agents/Ticket/GetNextInQueue
uid: v1TicketAgent_GetNextInQueue
generated: true
content_type: reference
---

# POST Agents/Ticket/GetNextInQueue

```http
POST /api/v1/Agents/Ticket/GetNextInQueue
```

Assign a ticket to the caller based on intelligent queue system







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetNextInQueue?$select=name,department,category/id
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
POST /api/v1/Agents/Ticket/GetNextInQueue
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 417,
  "Title": "earum",
  "CreatedAt": "2005-09-12T03:41:54.2307033+02:00",
  "LastChanged": "2012-08-23T03:41:54.2307033+02:00",
  "ReadByOwner": "2015-01-15T03:41:54.2307033+01:00",
  "ReadByCustomer": "2013-04-13T03:41:54.2307033+02:00",
  "FirstReadByOwner": "2002-07-17T03:41:54.2307033+02:00",
  "FirstReadByUser": "2003-04-17T03:41:54.2307033+02:00",
  "Activate": "2018-05-09T03:41:54.2307033+02:00",
  "ClosedAt": "2004-08-06T03:41:54.2307033+02:00",
  "RepliedAt": "2013-11-08T03:41:54.2307033+01:00",
  "AlertTimeout": "2018-01-27T03:41:54.2307033+01:00",
  "Deadline": "2021-10-22T03:41:54.2307033+02:00",
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
      "Position": "et",
      "PersonId": 851,
      "Mrmrs": "sunt",
      "Firstname": "Kaitlyn",
      "Lastname": "Kerluke",
      "MiddleName": "Hamill, Zboncak and Becker",
      "Title": "ducimus",
      "Description": "Proactive uniform moderator",
      "Email": "cletus.boyer@barrows.biz",
      "FullName": "Hugh Hermann Nikolaus DDS",
      "DirectPhone": "1-617-912-3414 x368",
      "FormalName": "Cassin, Stoltenberg and Pollich",
      "CountryId": 748,
      "ContactId": 602,
      "ContactName": "Altenwerth-Morar",
      "Retired": 304,
      "Rank": 519,
      "ActiveInterests": 943,
      "ContactDepartment": "",
      "ContactCountryId": 584,
      "ContactOrgNr": "1809282",
      "FaxPhone": "(830)003-3502 x1289",
      "MobilePhone": "668.712.8627",
      "ContactPhone": "656-953-4033",
      "AssociateName": "Considine Inc and Sons",
      "AssociateId": 461,
      "UsePersonAddress": false,
      "ContactFax": "rerum",
      "Kanafname": "quia",
      "Kanalname": "dolores",
      "Post1": "possimus",
      "Post2": "quis",
      "Post3": "non",
      "EmailName": "rosie.little@littel.name",
      "ContactFullName": "Unique Zboncak MD",
      "ActiveErpLinks": 215,
      "TicketPriorityId": 110,
      "SupportLanguageId": 894,
      "SupportAssociateId": 418,
      "CategoryName": "VIP Customer",
      "PersonNumber": "187995",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 328
        }
      }
    }
  ],
  "AlertLevel": 41,
  "ConnectId": 336,
  "ReadStatus": "Green",
  "TimeToReply": 374,
  "RealTimeToReply": 953,
  "TimeToClose": 32,
  "RealTimeToClose": 579,
  "TimeSpentInternally": 667,
  "TimeSpentExternally": 682,
  "TimeSpentQueue": 963,
  "RealTimeSpentInternally": 365,
  "RealTimeSpentExternally": 699,
  "RealTimeSpentQueue": 594,
  "TimeSpent": 406,
  "HasAttachment": false,
  "NumReplies": 63,
  "NumMessages": 877,
  "FromAddress": "maxime",
  "Messages": [
    {
      "TicketMessageId": 762,
      "CreatedAt": "2010-01-03T03:41:54.2307033+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "sed",
      "PersonId": 267,
      "PersonFullName": "Diana Nolan",
      "ContactId": 326,
      "ContactName": "Leffler, Feil and Bruen",
      "ContactDepartment": "",
      "NumAttachments": 44,
      "EmailHeader": "martin@reichert.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "omnis",
      "Sentiment": 502,
      "SentimentConfidence": 391,
      "CreatedBy": 685,
      "ChangedAt": "2017-08-17T03:41:54.2307033+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 684
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 797,
      "Name": "Towne-Lubowitz",
      "ToolTip": "Cupiditate alias harum et.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 762
        }
      }
    },
    {
      "Id": 797,
      "Name": "Towne-Lubowitz",
      "ToolTip": "Cupiditate alias harum et.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 762
        }
      }
    }
  ],
  "Language": "mollitia",
  "Sentiment": 899,
  "SentimentConfidence": 687,
  "SuggestedCategoryId": 252,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 541,
  "IconHint": "eius",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 838,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "quis",
    "CustomFields2": "delectus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 280
    }
  }
}
```