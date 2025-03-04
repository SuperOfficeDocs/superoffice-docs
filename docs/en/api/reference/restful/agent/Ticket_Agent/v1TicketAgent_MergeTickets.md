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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "MergedTicketEntity": null,
  "SecondaryTicketIds": [
    642,
    469
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 283,
  "Title": "laborum",
  "CreatedAt": "2011-03-15T14:13:41.5477755+01:00",
  "LastChanged": "2005-08-01T14:13:41.5477755+02:00",
  "ReadByOwner": "2017-09-30T14:13:41.5477755+02:00",
  "ReadByCustomer": "2001-10-28T14:13:41.5477755+01:00",
  "FirstReadByOwner": "2014-06-23T14:13:41.5477755+02:00",
  "FirstReadByUser": "2003-10-11T14:13:41.5477755+02:00",
  "Activate": "2001-08-13T14:13:41.5477755+02:00",
  "ClosedAt": "2010-12-14T14:13:41.5477755+01:00",
  "RepliedAt": "2019-12-06T14:13:41.5477755+01:00",
  "AlertTimeout": "1997-11-08T14:13:41.5477755+01:00",
  "Deadline": "2015-10-28T14:13:41.5477755+01:00",
  "CreatedBy": null,
  "Author": "est",
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
      "Position": "rem",
      "PersonId": 588,
      "Mrmrs": "et",
      "Firstname": "Jettie",
      "Lastname": "Keebler",
      "MiddleName": "Goldner, Kertzmann and Gorczany",
      "Title": "voluptatem",
      "Description": "Enhanced national focus group",
      "Email": "marcelle@parker.name",
      "FullName": "Aditya Toy",
      "DirectPhone": "285-713-0001",
      "FormalName": "Schamberger-Gottlieb",
      "CountryId": 953,
      "ContactId": 92,
      "ContactName": "Larkin, Pacocha and Grimes",
      "Retired": 112,
      "Rank": 547,
      "ActiveInterests": 314,
      "ContactDepartment": "",
      "ContactCountryId": 540,
      "ContactOrgNr": "1522862",
      "FaxPhone": "028-390-7553 x23956",
      "MobilePhone": "889-674-4745 x5464",
      "ContactPhone": "273-561-0551 x1751",
      "AssociateName": "Krajcik-Pfannerstill",
      "AssociateId": 788,
      "UsePersonAddress": false,
      "ContactFax": "quod",
      "Kanafname": "corporis",
      "Kanalname": "dolore",
      "Post1": "non",
      "Post2": "corrupti",
      "Post3": "dolor",
      "EmailName": "taurean.predovic@parker.ca",
      "ContactFullName": "Mrs. Wellington Zelda O'Connell",
      "ActiveErpLinks": 264,
      "TicketPriorityId": 436,
      "SupportLanguageId": 34,
      "SupportAssociateId": 651,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1286288",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 657
        }
      }
    }
  ],
  "AlertLevel": 893,
  "ConnectId": 832,
  "ReadStatus": "Green",
  "TimeToReply": 225,
  "RealTimeToReply": 236,
  "TimeToClose": 538,
  "RealTimeToClose": 614,
  "TimeSpentInternally": 961,
  "TimeSpentExternally": 960,
  "TimeSpentQueue": 838,
  "RealTimeSpentInternally": 84,
  "RealTimeSpentExternally": 56,
  "RealTimeSpentQueue": 682,
  "TimeSpent": 372,
  "HasAttachment": true,
  "NumReplies": 515,
  "NumMessages": 865,
  "FromAddress": "dolore",
  "Messages": [
    {
      "TicketMessageId": 249,
      "CreatedAt": "2011-12-21T14:13:41.5633969+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "non",
      "PersonId": 130,
      "PersonFullName": "Isaias Hermiston",
      "ContactId": 592,
      "ContactName": "Stroman-Adams",
      "ContactDepartment": "",
      "NumAttachments": 227,
      "EmailHeader": "sabina.halvorson@jonesnicolas.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "consectetur",
      "Sentiment": 992,
      "SentimentConfidence": 440,
      "CreatedBy": 763,
      "ChangedAt": "2013-01-16T14:13:41.5633969+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 924
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 642,
      "Name": "Jast Inc and Sons",
      "ToolTip": "Placeat id debitis error.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 264
        }
      }
    },
    {
      "Id": 642,
      "Name": "Jast Inc and Sons",
      "ToolTip": "Placeat id debitis error.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 264
        }
      }
    }
  ],
  "Language": "ipsam",
  "Sentiment": 788,
  "SentimentConfidence": 957,
  "SuggestedCategoryId": 379,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 834,
  "IconHint": "voluptatum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 986,
  "ExtraFields": {
    "ExtraFields1": "cumque",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "cumque",
    "CustomFields2": "provident"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 62
    }
  }
}
```