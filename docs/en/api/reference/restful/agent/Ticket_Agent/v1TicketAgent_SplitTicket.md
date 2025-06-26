---
title: POST Agents/Ticket/SplitTicket
uid: v1TicketAgent_SplitTicket
generated: true
---

# POST Agents/Ticket/SplitTicket

```http
POST /api/v1/Agents/Ticket/SplitTicket
```

Save new ticket and move/copy data from existing ticket in a single request.


Specified messages will be moved.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/SplitTicket?$select=name,department,category/id
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

SourceTicketEntityId, SourceTicketEntityStatusId, SourceTicketEntityActivate, TransferMessageIds, NewTicketEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourceTicketEntityId | Integer |  |
| SourceTicketEntityStatusId | Integer |  |
| SourceTicketEntityActivate | String |  |
| TransferMessageIds | Array |  |
| NewTicketEntity | TicketEntity | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |

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
POST /api/v1/Agents/Ticket/SplitTicket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SourceTicketEntityId": 300,
  "SourceTicketEntityStatusId": 130,
  "SourceTicketEntityActivate": "2018-01-13T03:45:24.0923083+01:00",
  "TransferMessageIds": [
    648,
    881
  ],
  "NewTicketEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 479,
  "Title": "deserunt",
  "CreatedAt": "2020-11-06T03:45:24.0923083+01:00",
  "LastChanged": "2001-07-02T03:45:24.0923083+02:00",
  "ReadByOwner": "2008-10-03T03:45:24.0923083+02:00",
  "ReadByCustomer": "2015-07-14T03:45:24.0923083+02:00",
  "FirstReadByOwner": "2005-06-19T03:45:24.0923083+02:00",
  "FirstReadByUser": "1998-06-26T03:45:24.0923083+02:00",
  "Activate": "2024-05-20T03:45:24.0923083+02:00",
  "ClosedAt": "2019-03-21T03:45:24.0923083+01:00",
  "RepliedAt": "2018-03-29T03:45:24.0923083+02:00",
  "AlertTimeout": "1999-11-24T03:45:24.0923083+01:00",
  "Deadline": "1999-03-18T03:45:24.0923083+01:00",
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
      "Position": "omnis",
      "PersonId": 773,
      "Mrmrs": "magni",
      "Firstname": "Cecil",
      "Lastname": "Stoltenberg",
      "MiddleName": "Simonis Inc and Sons",
      "Title": "eum",
      "Description": "Devolved motivating policy",
      "Email": "marquise.carter@mitchellwill.uk",
      "FullName": "Justus Waters",
      "DirectPhone": "1-775-273-0744 x637",
      "FormalName": "Kreiger Group",
      "CountryId": 524,
      "ContactId": 59,
      "ContactName": "Wintheiser, Dietrich and Beatty",
      "Retired": 693,
      "Rank": 609,
      "ActiveInterests": 464,
      "ContactDepartment": "",
      "ContactCountryId": 733,
      "ContactOrgNr": "807013",
      "FaxPhone": "1-012-747-3736",
      "MobilePhone": "530-317-6260 x34982",
      "ContactPhone": "(368)318-0012",
      "AssociateName": "Hilll Inc and Sons",
      "AssociateId": 37,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "in",
      "Kanalname": "debitis",
      "Post1": "fugiat",
      "Post2": "et",
      "Post3": "quos",
      "EmailName": "abdullah@white.ca",
      "ContactFullName": "Miss Javon McLaughlin I",
      "ActiveErpLinks": 910,
      "TicketPriorityId": 89,
      "SupportLanguageId": 821,
      "SupportAssociateId": 826,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1409080",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 536
        }
      }
    }
  ],
  "AlertLevel": 865,
  "ConnectId": 485,
  "ReadStatus": "Green",
  "TimeToReply": 762,
  "RealTimeToReply": 490,
  "TimeToClose": 34,
  "RealTimeToClose": 929,
  "TimeSpentInternally": 104,
  "TimeSpentExternally": 852,
  "TimeSpentQueue": 338,
  "RealTimeSpentInternally": 408,
  "RealTimeSpentExternally": 556,
  "RealTimeSpentQueue": 103,
  "TimeSpent": 122,
  "HasAttachment": false,
  "NumReplies": 665,
  "NumMessages": 787,
  "FromAddress": "nihil",
  "Messages": [
    {
      "TicketMessageId": 206,
      "CreatedAt": "2012-09-10T03:45:24.0923083+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "ut",
      "PersonId": 234,
      "PersonFullName": "Berry Zemlak",
      "ContactId": 824,
      "ContactName": "Cummerata-Homenick",
      "ContactDepartment": "",
      "NumAttachments": 689,
      "EmailHeader": "maximo@mayertbergstrom.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "magnam",
      "Sentiment": 537,
      "SentimentConfidence": 333,
      "CreatedBy": 536,
      "ChangedAt": "2010-09-19T03:45:24.0923083+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 93
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 725,
      "Name": "Metz, Metz and Schmidt",
      "ToolTip": "Tenetur quaerat ut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 182
        }
      }
    },
    {
      "Id": 725,
      "Name": "Metz, Metz and Schmidt",
      "ToolTip": "Tenetur quaerat ut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 182
        }
      }
    }
  ],
  "Language": "sed",
  "Sentiment": 533,
  "SentimentConfidence": 242,
  "SuggestedCategoryId": 748,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 520,
  "IconHint": "molestiae",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 597,
  "ExtraFields": {
    "ExtraFields1": "minima",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "reiciendis",
    "CustomFields2": "tenetur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 597
    }
  }
}
```