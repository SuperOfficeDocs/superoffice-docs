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
  "SourceTicketEntityId": 554,
  "SourceTicketEntityStatusId": 207,
  "SourceTicketEntityActivate": "2017-11-16T11:06:35.5689978+01:00",
  "TransferMessageIds": [
    306,
    999
  ],
  "NewTicketEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 784,
  "Title": "iure",
  "CreatedAt": "2014-03-06T11:06:35.5689978+01:00",
  "LastChanged": "2005-02-24T11:06:35.5689978+01:00",
  "ReadByOwner": "2020-03-09T11:06:35.5689978+01:00",
  "ReadByCustomer": "2011-08-01T11:06:35.5689978+02:00",
  "FirstReadByOwner": "2018-05-18T11:06:35.5689978+02:00",
  "FirstReadByUser": "1998-03-25T11:06:35.5689978+01:00",
  "Activate": "2000-12-14T11:06:35.5689978+01:00",
  "ClosedAt": "2010-12-13T11:06:35.5689978+01:00",
  "RepliedAt": "1999-05-25T11:06:35.5689978+02:00",
  "AlertTimeout": "2014-04-18T11:06:35.5689978+02:00",
  "Deadline": "2016-02-19T11:06:35.5689978+01:00",
  "CreatedBy": null,
  "Author": "ea",
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
      "Position": "quia",
      "PersonId": 549,
      "Mrmrs": "dolorem",
      "Firstname": "Christelle",
      "Lastname": "Durgan",
      "MiddleName": "Johnston LLC",
      "Title": "recusandae",
      "Description": "Adaptive coherent artificial intelligence",
      "Email": "myrna_schoen@daniel.com",
      "FullName": "Ms. Diego Shea Heller DVM",
      "DirectPhone": "(265)091-3316",
      "FormalName": "Powlowski-Funk",
      "CountryId": 760,
      "ContactId": 679,
      "ContactName": "Kris, Mueller and Breitenberg",
      "Retired": 595,
      "Rank": 4,
      "ActiveInterests": 72,
      "ContactDepartment": "",
      "ContactCountryId": 396,
      "ContactOrgNr": "835488",
      "FaxPhone": "1-728-649-4880 x4367",
      "MobilePhone": "1-929-294-2448 x04986",
      "ContactPhone": "652-049-1733 x37500",
      "AssociateName": "Brown Group",
      "AssociateId": 555,
      "UsePersonAddress": true,
      "ContactFax": "explicabo",
      "Kanafname": "ea",
      "Kanalname": "fugit",
      "Post1": "delectus",
      "Post2": "accusamus",
      "Post3": "officiis",
      "EmailName": "gus.price@dickens.biz",
      "ContactFullName": "Scarlett Lemke Sr.",
      "ActiveErpLinks": 785,
      "TicketPriorityId": 367,
      "SupportLanguageId": 798,
      "SupportAssociateId": 382,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 121
        }
      }
    }
  ],
  "AlertLevel": 22,
  "ConnectId": 574,
  "ReadStatus": "Green",
  "TimeToReply": 445,
  "RealTimeToReply": 201,
  "TimeToClose": 87,
  "RealTimeToClose": 925,
  "TimeSpentInternally": 402,
  "TimeSpentExternally": 895,
  "TimeSpentQueue": 619,
  "RealTimeSpentInternally": 241,
  "RealTimeSpentExternally": 758,
  "RealTimeSpentQueue": 860,
  "TimeSpent": 965,
  "HasAttachment": true,
  "NumReplies": 190,
  "NumMessages": 482,
  "FromAddress": "quia",
  "Messages": [
    {
      "TicketMessageId": 268,
      "CreatedAt": "1998-11-06T11:06:35.5689978+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "distinctio",
      "PersonId": 996,
      "PersonFullName": "Miss Afton Orion Mueller IV",
      "ContactId": 244,
      "ContactName": "Rohan Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 100,
      "EmailHeader": "melvin_waters@hilll.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "et",
      "Sentiment": 973,
      "SentimentConfidence": 423,
      "CreatedBy": 201,
      "ChangedAt": "2010-12-26T11:06:35.5689978+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 445
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 736,
      "Name": "Parker, Borer and Goldner",
      "ToolTip": "Debitis voluptates aut accusantium totam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 97
        }
      }
    },
    {
      "Id": 736,
      "Name": "Parker, Borer and Goldner",
      "ToolTip": "Debitis voluptates aut accusantium totam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 97
        }
      }
    }
  ],
  "Language": "excepturi",
  "Sentiment": 100,
  "SentimentConfidence": 25,
  "SuggestedCategoryId": 77,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 351,
  "IconHint": "delectus",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "deserunt",
    "ExtraFields2": "modi"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "rerum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 447
    }
  }
}
```