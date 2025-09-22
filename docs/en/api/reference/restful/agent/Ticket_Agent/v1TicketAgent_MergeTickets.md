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
    528,
    870
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 651,
  "Title": "corporis",
  "CreatedAt": "2003-04-10T11:24:48.7813718+02:00",
  "LastChanged": "2010-03-30T11:24:48.7813718+02:00",
  "ReadByOwner": "2015-06-02T11:24:48.7813718+02:00",
  "ReadByCustomer": "2012-05-22T11:24:48.7813718+02:00",
  "FirstReadByOwner": "2020-09-09T11:24:48.7813718+02:00",
  "FirstReadByUser": "2015-09-15T11:24:48.7813718+02:00",
  "Activate": "2013-04-04T11:24:48.7813718+02:00",
  "ClosedAt": "2025-01-08T11:24:48.7813718+01:00",
  "RepliedAt": "2020-05-20T11:24:48.7813718+02:00",
  "AlertTimeout": "2010-06-21T11:24:48.7813718+02:00",
  "Deadline": "2006-01-13T11:24:48.7813718+01:00",
  "CreatedBy": null,
  "Author": "accusamus",
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
      "Position": "eius",
      "PersonId": 240,
      "Mrmrs": "fugiat",
      "Firstname": "Jose",
      "Lastname": "Ratke",
      "MiddleName": "McGlynn-Metz",
      "Title": "nemo",
      "Description": "Enhanced interactive projection",
      "Email": "bernadine@mosciskidavis.ca",
      "FullName": "Joel Earnest Kuhn V",
      "DirectPhone": "(630)691-7919",
      "FormalName": "Spinka, Cummings and Macejkovic",
      "CountryId": 904,
      "ContactId": 587,
      "ContactName": "Powlowski LLC",
      "Retired": 127,
      "Rank": 368,
      "ActiveInterests": 414,
      "ContactDepartment": "",
      "ContactCountryId": 880,
      "ContactOrgNr": "1093587",
      "FaxPhone": "(174)631-9368 x34044",
      "MobilePhone": "998.448.8812 x841",
      "ContactPhone": "(891)160-4731 x1854",
      "AssociateName": "Feest-Hauck",
      "AssociateId": 19,
      "UsePersonAddress": false,
      "ContactFax": "qui",
      "Kanafname": "repudiandae",
      "Kanalname": "a",
      "Post1": "et",
      "Post2": "quia",
      "Post3": "consequatur",
      "EmailName": "jaqueline@dibbertbalistreri.info",
      "ContactFullName": "Reggie Langworth",
      "ActiveErpLinks": 277,
      "TicketPriorityId": 535,
      "SupportLanguageId": 969,
      "SupportAssociateId": 202,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1026966",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 265
        }
      }
    }
  ],
  "AlertLevel": 426,
  "ConnectId": 381,
  "ReadStatus": "Green",
  "TimeToReply": 267,
  "RealTimeToReply": 676,
  "TimeToClose": 8,
  "RealTimeToClose": 407,
  "TimeSpentInternally": 615,
  "TimeSpentExternally": 398,
  "TimeSpentQueue": 323,
  "RealTimeSpentInternally": 200,
  "RealTimeSpentExternally": 720,
  "RealTimeSpentQueue": 978,
  "TimeSpent": 117,
  "HasAttachment": false,
  "NumReplies": 902,
  "NumMessages": 82,
  "FromAddress": "necessitatibus",
  "Messages": [
    {
      "TicketMessageId": 656,
      "CreatedAt": "2015-02-04T11:24:48.7813718+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "ratione",
      "PersonId": 107,
      "PersonFullName": "Edgar Powlowski",
      "ContactId": 34,
      "ContactName": "Rath Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 514,
      "EmailHeader": "orin@harvey.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "eveniet",
      "Sentiment": 932,
      "SentimentConfidence": 174,
      "CreatedBy": 81,
      "ChangedAt": "2008-01-06T11:24:48.7813718+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 149
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 552,
      "Name": "Ratke, Franecki and O'Kon",
      "ToolTip": "Eum sit mollitia et assumenda est voluptas hic.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 314
        }
      }
    },
    {
      "Id": 552,
      "Name": "Ratke, Franecki and O'Kon",
      "ToolTip": "Eum sit mollitia et assumenda est voluptas hic.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 314
        }
      }
    }
  ],
  "Language": "necessitatibus",
  "Sentiment": 149,
  "SentimentConfidence": 13,
  "SuggestedCategoryId": 217,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 580,
  "IconHint": "quibusdam",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 657,
  "ExtraFields": {
    "ExtraFields1": "ipsum",
    "ExtraFields2": "sunt"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "rerum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 762
    }
  }
}
```