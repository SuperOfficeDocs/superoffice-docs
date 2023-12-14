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
| OwnedBy | Associate | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category | TicketCategoryEntity | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority | TicketPriorityEntity | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status | TicketStatusEntity | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person | Person | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
| SecondaryPersons | array | The secondary persons this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
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
| Sale | Sale | The sale that this ticket is connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket is connected to  <para>Use MDO List name "project" to get list items.</para> |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| TicketType | TicketTypeEntity | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Ticket/SplitTicket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SourceTicketEntityId": 263,
  "SourceTicketEntityStatusId": 163,
  "SourceTicketEntityActivate": "2021-01-07T13:57:13.411477+01:00",
  "TransferMessageIds": [
    907,
    236
  ],
  "NewTicketEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 587,
  "Title": "aliquam",
  "CreatedAt": "2015-11-19T13:57:13.411477+01:00",
  "LastChanged": "2003-11-21T13:57:13.411477+01:00",
  "ReadByOwner": "2022-11-15T13:57:13.411477+01:00",
  "ReadByCustomer": "2016-01-04T13:57:13.411477+01:00",
  "FirstReadByOwner": "2017-05-18T13:57:13.411477+02:00",
  "FirstReadByUser": "2014-02-16T13:57:13.411477+01:00",
  "Activate": "2003-04-27T13:57:13.411477+02:00",
  "ClosedAt": "2019-03-01T13:57:13.411477+01:00",
  "RepliedAt": "2002-06-11T13:57:13.411477+02:00",
  "AlertTimeout": "2022-11-01T13:57:13.411477+01:00",
  "Deadline": "2015-07-23T13:57:13.411477+02:00",
  "CreatedBy": null,
  "Author": "quidem",
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
      "Position": "ea",
      "PersonId": 50,
      "Mrmrs": "voluptatem",
      "Firstname": "Elvera",
      "Lastname": "Auer",
      "MiddleName": "Tremblay Group",
      "Title": "autem",
      "Description": "Persistent national forecast",
      "Email": "gerson_altenwerth@tromp.com",
      "FullName": "Emilie Towne",
      "DirectPhone": "1-323-379-4183 x4420",
      "FormalName": "Blanda Group",
      "CountryId": 44,
      "ContactId": 970,
      "ContactName": "Price Inc and Sons",
      "Retired": 153,
      "Rank": 981,
      "ActiveInterests": 48,
      "ContactDepartment": "",
      "ContactCountryId": 210,
      "ContactOrgNr": "923549",
      "FaxPhone": "(432)559-9096",
      "MobilePhone": "200.870.9003 x73097",
      "ContactPhone": "1-264-002-9968 x0818",
      "AssociateName": "Goyette Inc and Sons",
      "AssociateId": 78,
      "UsePersonAddress": false,
      "ContactFax": "doloribus",
      "Kanafname": "consequatur",
      "Kanalname": "aliquam",
      "Post1": "non",
      "Post2": "officiis",
      "Post3": "id",
      "EmailName": "lucio_lockman@blandarau.info",
      "ContactFullName": "Bart Ritchie",
      "ActiveErpLinks": 349,
      "TicketPriorityId": 166,
      "SupportLanguageId": 522,
      "SupportAssociateId": 520,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 519
        }
      }
    }
  ],
  "AlertLevel": 630,
  "ConnectId": 984,
  "ReadStatus": "Green",
  "TimeToReply": 48,
  "RealTimeToReply": 375,
  "TimeToClose": 74,
  "RealTimeToClose": 368,
  "TimeSpentInternally": 232,
  "TimeSpentExternally": 803,
  "TimeSpentQueue": 324,
  "RealTimeSpentInternally": 173,
  "RealTimeSpentExternally": 906,
  "RealTimeSpentQueue": 910,
  "TimeSpent": 899,
  "HasAttachment": false,
  "NumReplies": 478,
  "NumMessages": 551,
  "FromAddress": "enim",
  "Messages": [
    {
      "TicketMessageId": 114,
      "CreatedAt": "2000-09-19T13:57:13.4270928+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "aut",
      "PersonId": 701,
      "PersonFullName": "Jacey Ruecker",
      "ContactId": 890,
      "ContactName": "Kutch, Nolan and Gulgowski",
      "ContactDepartment": "",
      "NumAttachments": 104,
      "EmailHeader": "henriette_gislason@kuhic.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "non",
      "Sentiment": 57,
      "SentimentConfidence": 322,
      "CreatedBy": 416,
      "ChangedAt": "2016-06-30T13:57:13.4270928+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 460
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 837,
      "Name": "Stoltenberg Group",
      "ToolTip": "Laudantium numquam dolor provident quo alias veniam est.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 17
        }
      }
    },
    {
      "Id": 837,
      "Name": "Stoltenberg Group",
      "ToolTip": "Laudantium numquam dolor provident quo alias veniam est.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 17
        }
      }
    }
  ],
  "Language": "iusto",
  "Sentiment": 417,
  "SentimentConfidence": 764,
  "SuggestedCategoryId": 706,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 993,
  "IconHint": "quis",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "nihil",
    "ExtraFields2": "beatae"
  },
  "CustomFields": {
    "CustomFields1": "maxime",
    "CustomFields2": "esse"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 634
    }
  }
}
```