---
title: POST Agents/Ticket/MergeTickets
uid: v1TicketAgent_MergeTickets
generated: true
content_type: reference
---

# POST Agents/Ticket/MergeTickets

```http
POST /api/v1/Agents/Ticket/MergeTickets
```

Merge one or more tickets into one primary ticket


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/MergeTickets?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

MergedTicketEntity, SecondaryTicketIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MergedTicketEntity | TicketEntity | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| SecondaryTicketIds | Array |  |

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
POST /api/v1/Agents/Ticket/MergeTickets
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "MergedTicketEntity": null,
  "SecondaryTicketIds": [
    161,
    916
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 269,
  "Title": "et",
  "CreatedAt": "2004-07-20T03:40:48.0629879+02:00",
  "LastChanged": "2014-04-30T03:40:48.0629879+02:00",
  "ReadByOwner": "2004-11-01T03:40:48.0629879+01:00",
  "ReadByCustomer": "2025-01-17T03:40:48.0629879+01:00",
  "FirstReadByOwner": "2006-12-12T03:40:48.0629879+01:00",
  "FirstReadByUser": "1999-01-15T03:40:48.0629879+01:00",
  "Activate": "2002-01-21T03:40:48.0629879+01:00",
  "ClosedAt": "2002-02-28T03:40:48.0629879+01:00",
  "RepliedAt": "2003-06-15T03:40:48.0629879+02:00",
  "AlertTimeout": "2005-02-12T03:40:48.0629879+01:00",
  "Deadline": "2008-04-02T03:40:48.0629879+02:00",
  "CreatedBy": null,
  "Author": "illum",
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
      "Position": "dolorem",
      "PersonId": 634,
      "Mrmrs": "explicabo",
      "Firstname": "Adelbert",
      "Lastname": "Dietrich",
      "MiddleName": "Murray, White and Jewess",
      "Title": "suscipit",
      "Description": "Fully-configurable didactic function",
      "Email": "johan@emard.info",
      "FullName": "Ms. Carmel Yolanda Padberg II",
      "DirectPhone": "021-038-0607 x58231",
      "FormalName": "Moen Group",
      "CountryId": 107,
      "ContactId": 989,
      "ContactName": "Schaden Group",
      "Retired": 735,
      "Rank": 493,
      "ActiveInterests": 657,
      "ContactDepartment": "",
      "ContactCountryId": 265,
      "ContactOrgNr": "1094906",
      "FaxPhone": "774.680.3156 x96022",
      "MobilePhone": "157-661-3019",
      "ContactPhone": "(816)584-8509",
      "AssociateName": "O'Hara Group",
      "AssociateId": 642,
      "UsePersonAddress": true,
      "ContactFax": "est",
      "Kanafname": "et",
      "Kanalname": "illo",
      "Post1": "deserunt",
      "Post2": "sunt",
      "Post3": "maiores",
      "EmailName": "keagan.goldner@hermiston.us",
      "ContactFullName": "Araceli Bechtelar",
      "ActiveErpLinks": 83,
      "TicketPriorityId": 194,
      "SupportLanguageId": 551,
      "SupportAssociateId": 7,
      "CategoryName": "VIP Customer",
      "PersonNumber": "879969",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 793
        }
      }
    }
  ],
  "AlertLevel": 872,
  "ConnectId": 646,
  "ReadStatus": "Green",
  "TimeToReply": 707,
  "RealTimeToReply": 612,
  "TimeToClose": 160,
  "RealTimeToClose": 202,
  "TimeSpentInternally": 711,
  "TimeSpentExternally": 992,
  "TimeSpentQueue": 350,
  "RealTimeSpentInternally": 229,
  "RealTimeSpentExternally": 431,
  "RealTimeSpentQueue": 948,
  "TimeSpent": 650,
  "HasAttachment": false,
  "NumReplies": 52,
  "NumMessages": 838,
  "FromAddress": "quisquam",
  "Messages": [
    {
      "TicketMessageId": 233,
      "CreatedAt": "2017-03-12T03:40:48.0629879+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "eum",
      "PersonId": 208,
      "PersonFullName": "Miss Jeramie Price DVM",
      "ContactId": 63,
      "ContactName": "Hahn LLC",
      "ContactDepartment": "",
      "NumAttachments": 801,
      "EmailHeader": "jack_lebsack@strosin.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "iusto",
      "Sentiment": 698,
      "SentimentConfidence": 690,
      "CreatedBy": 638,
      "ChangedAt": "2016-02-19T03:40:48.0629879+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 206
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 438,
      "Name": "Conroy-Mante",
      "ToolTip": "Quis voluptas.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 943
        }
      }
    },
    {
      "Id": 438,
      "Name": "Conroy-Mante",
      "ToolTip": "Quis voluptas.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 943
        }
      }
    }
  ],
  "Language": "quo",
  "Sentiment": 485,
  "SentimentConfidence": 13,
  "SuggestedCategoryId": 643,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 814,
  "IconHint": "praesentium",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 499,
  "ExtraFields": {
    "ExtraFields1": "id",
    "ExtraFields2": "illum"
  },
  "CustomFields": {
    "CustomFields1": "consequuntur",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 720
    }
  }
}
```