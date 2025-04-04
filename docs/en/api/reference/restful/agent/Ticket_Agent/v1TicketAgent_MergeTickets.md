---
title: POST Agents/Ticket/MergeTickets
uid: v1TicketAgent_MergeTickets
generated: true
---

# POST Agents/Ticket/MergeTickets

```http
POST /api/v1/Agents/Ticket/MergeTickets
```

Merge one or more tickets into one primary ticket







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
    786,
    943
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 337,
  "Title": "qui",
  "CreatedAt": "2020-09-13T13:14:01.5819386+02:00",
  "LastChanged": "2022-05-18T13:14:01.5819386+02:00",
  "ReadByOwner": "2010-10-20T13:14:01.5819386+02:00",
  "ReadByCustomer": "2014-02-26T13:14:01.5819386+01:00",
  "FirstReadByOwner": "2002-06-01T13:14:01.5819386+02:00",
  "FirstReadByUser": "2006-11-16T13:14:01.5819386+01:00",
  "Activate": "2024-06-03T13:14:01.5819386+02:00",
  "ClosedAt": "1998-06-19T13:14:01.5819386+02:00",
  "RepliedAt": "2016-07-25T13:14:01.5819386+02:00",
  "AlertTimeout": "2014-01-05T13:14:01.5819386+01:00",
  "Deadline": "2000-11-03T13:14:01.5819386+01:00",
  "CreatedBy": null,
  "Author": "quo",
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
      "Position": "provident",
      "PersonId": 477,
      "Mrmrs": "voluptatem",
      "Firstname": "Ludwig",
      "Lastname": "Wolff",
      "MiddleName": "Cummerata Inc and Sons",
      "Title": "aut",
      "Description": "Pre-emptive zero administration paradigm",
      "Email": "alexandrea_durgan@denesik.info",
      "FullName": "Agnes Lynch",
      "DirectPhone": "(167)536-2022 x0093",
      "FormalName": "Lemke, King and Monahan",
      "CountryId": 895,
      "ContactId": 292,
      "ContactName": "Zboncak, Nader and Parisian",
      "Retired": 907,
      "Rank": 355,
      "ActiveInterests": 727,
      "ContactDepartment": "",
      "ContactCountryId": 862,
      "ContactOrgNr": "967458",
      "FaxPhone": "1-543-999-2836",
      "MobilePhone": "(082)203-6998",
      "ContactPhone": "(507)247-1805 x3901",
      "AssociateName": "Gaylord-Pfannerstill",
      "AssociateId": 837,
      "UsePersonAddress": false,
      "ContactFax": "modi",
      "Kanafname": "aliquam",
      "Kanalname": "voluptas",
      "Post1": "consectetur",
      "Post2": "aliquid",
      "Post3": "rerum",
      "EmailName": "amely_pfannerstill@abshire.uk",
      "ContactFullName": "Alejandra Reynolds",
      "ActiveErpLinks": 698,
      "TicketPriorityId": 388,
      "SupportLanguageId": 595,
      "SupportAssociateId": 415,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1157517",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 514
        }
      }
    }
  ],
  "AlertLevel": 762,
  "ConnectId": 271,
  "ReadStatus": "Green",
  "TimeToReply": 602,
  "RealTimeToReply": 347,
  "TimeToClose": 618,
  "RealTimeToClose": 506,
  "TimeSpentInternally": 800,
  "TimeSpentExternally": 856,
  "TimeSpentQueue": 495,
  "RealTimeSpentInternally": 804,
  "RealTimeSpentExternally": 668,
  "RealTimeSpentQueue": 73,
  "TimeSpent": 474,
  "HasAttachment": false,
  "NumReplies": 657,
  "NumMessages": 879,
  "FromAddress": "delectus",
  "Messages": [
    {
      "TicketMessageId": 833,
      "CreatedAt": "2006-10-13T13:14:01.5819386+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "eligendi",
      "PersonId": 544,
      "PersonFullName": "Cordell Jaskolski",
      "ContactId": 117,
      "ContactName": "Goodwin, Fay and Vandervort",
      "ContactDepartment": "",
      "NumAttachments": 843,
      "EmailHeader": "justen.sauer@powlowski.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "nihil",
      "Sentiment": 448,
      "SentimentConfidence": 519,
      "CreatedBy": 314,
      "ChangedAt": "2008-09-15T13:14:01.5819386+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 731
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 45,
      "Name": "Bernhard LLC",
      "ToolTip": "Dolores dolor.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 675
        }
      }
    },
    {
      "Id": 45,
      "Name": "Bernhard LLC",
      "ToolTip": "Dolores dolor.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 675
        }
      }
    }
  ],
  "Language": "quasi",
  "Sentiment": 787,
  "SentimentConfidence": 196,
  "SuggestedCategoryId": 599,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 200,
  "IconHint": "voluptate",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 35,
  "ExtraFields": {
    "ExtraFields1": "dolores",
    "ExtraFields2": "magni"
  },
  "CustomFields": {
    "CustomFields1": "incidunt",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 394
    }
  }
}
```