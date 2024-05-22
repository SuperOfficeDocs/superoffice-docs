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
  "SourceTicketEntityId": 554,
  "SourceTicketEntityStatusId": 247,
  "SourceTicketEntityActivate": "2012-02-28T12:57:35.148908+01:00",
  "TransferMessageIds": [
    136,
    472
  ],
  "NewTicketEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 542,
  "Title": "vero",
  "CreatedAt": "2017-07-27T12:57:35.148908+02:00",
  "LastChanged": "2014-08-02T12:57:35.148908+02:00",
  "ReadByOwner": "1997-12-08T12:57:35.148908+01:00",
  "ReadByCustomer": "2018-09-30T12:57:35.148908+02:00",
  "FirstReadByOwner": "2015-08-01T12:57:35.148908+02:00",
  "FirstReadByUser": "2016-08-10T12:57:35.148908+02:00",
  "Activate": "2022-03-29T12:57:35.148908+02:00",
  "ClosedAt": "2006-10-29T12:57:35.148908+01:00",
  "RepliedAt": "2010-08-03T12:57:35.148908+02:00",
  "AlertTimeout": "1998-03-23T12:57:35.148908+01:00",
  "Deadline": "2007-12-03T12:57:35.148908+01:00",
  "CreatedBy": null,
  "Author": "architecto",
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
      "Position": "vel",
      "PersonId": 812,
      "Mrmrs": "dolores",
      "Firstname": "Douglas",
      "Lastname": "Okuneva",
      "MiddleName": "Ritchie Inc and Sons",
      "Title": "aut",
      "Description": "Cross-platform user-facing emulation",
      "Email": "lavina@brekke.uk",
      "FullName": "Miss Beulah Corkery IV",
      "DirectPhone": "976.238.0250 x1738",
      "FormalName": "Zboncak, Funk and Bogan",
      "CountryId": 82,
      "ContactId": 503,
      "ContactName": "Veum, Yundt and Reynolds",
      "Retired": 931,
      "Rank": 422,
      "ActiveInterests": 992,
      "ContactDepartment": "",
      "ContactCountryId": 433,
      "ContactOrgNr": "691736",
      "FaxPhone": "470.581.5879 x41915",
      "MobilePhone": "1-284-667-4697 x1741",
      "ContactPhone": "(322)179-3495",
      "AssociateName": "Dicki LLC",
      "AssociateId": 33,
      "UsePersonAddress": false,
      "ContactFax": "explicabo",
      "Kanafname": "similique",
      "Kanalname": "ut",
      "Post1": "fuga",
      "Post2": "esse",
      "Post3": "reprehenderit",
      "EmailName": "darrick@howe.ca",
      "ContactFullName": "Brian Mckenzie VonRueden PhD",
      "ActiveErpLinks": 329,
      "TicketPriorityId": 833,
      "SupportLanguageId": 625,
      "SupportAssociateId": 243,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 188
        }
      }
    }
  ],
  "AlertLevel": 437,
  "ConnectId": 74,
  "ReadStatus": "Green",
  "TimeToReply": 835,
  "RealTimeToReply": 508,
  "TimeToClose": 673,
  "RealTimeToClose": 518,
  "TimeSpentInternally": 119,
  "TimeSpentExternally": 147,
  "TimeSpentQueue": 676,
  "RealTimeSpentInternally": 918,
  "RealTimeSpentExternally": 456,
  "RealTimeSpentQueue": 383,
  "TimeSpent": 94,
  "HasAttachment": false,
  "NumReplies": 356,
  "NumMessages": 333,
  "FromAddress": "quam",
  "Messages": [
    {
      "TicketMessageId": 893,
      "CreatedAt": "1998-07-18T12:57:35.1645294+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "rerum",
      "PersonId": 191,
      "PersonFullName": "Stacy Ankunding",
      "ContactId": 358,
      "ContactName": "Anderson, Adams and Tromp",
      "ContactDepartment": "",
      "NumAttachments": 356,
      "EmailHeader": "jaunita@barrows.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "odit",
      "Sentiment": 132,
      "SentimentConfidence": 340,
      "CreatedBy": 708,
      "ChangedAt": "2019-02-10T12:57:35.1645294+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 363
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 705,
      "Name": "Wiza, Denesik and Leannon",
      "ToolTip": "Itaque beatae eligendi aut nam et porro.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 79
        }
      }
    },
    {
      "Id": 705,
      "Name": "Wiza, Denesik and Leannon",
      "ToolTip": "Itaque beatae eligendi aut nam et porro.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 79
        }
      }
    }
  ],
  "Language": "quo",
  "Sentiment": 491,
  "SentimentConfidence": 243,
  "SuggestedCategoryId": 356,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 88,
  "IconHint": "expedita",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 330,
  "ExtraFields": {
    "ExtraFields1": "illum",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "pariatur",
    "CustomFields2": "laborum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 717
    }
  }
}
```