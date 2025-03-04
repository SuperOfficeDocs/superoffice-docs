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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SourceTicketEntityId": 630,
  "SourceTicketEntityStatusId": 251,
  "SourceTicketEntityActivate": "2022-11-17T14:13:41.5176467+01:00",
  "TransferMessageIds": [
    967,
    337
  ],
  "NewTicketEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 901,
  "Title": "est",
  "CreatedAt": "2020-04-11T14:13:41.5321506+02:00",
  "LastChanged": "2003-10-07T14:13:41.5321506+02:00",
  "ReadByOwner": "2000-02-06T14:13:41.5321506+01:00",
  "ReadByCustomer": "2023-02-08T14:13:41.5321506+01:00",
  "FirstReadByOwner": "2001-08-31T14:13:41.5321506+02:00",
  "FirstReadByUser": "2013-12-30T14:13:41.5321506+01:00",
  "Activate": "2015-05-26T14:13:41.5321506+02:00",
  "ClosedAt": "2013-05-21T14:13:41.5321506+02:00",
  "RepliedAt": "2015-12-15T14:13:41.5321506+01:00",
  "AlertTimeout": "2010-04-29T14:13:41.5321506+02:00",
  "Deadline": "2000-10-19T14:13:41.5321506+02:00",
  "CreatedBy": null,
  "Author": "totam",
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
      "Position": "ut",
      "PersonId": 517,
      "Mrmrs": "velit",
      "Firstname": "Zion",
      "Lastname": "Orn",
      "MiddleName": "Willms Group",
      "Title": "sint",
      "Description": "Horizontal explicit analyzer",
      "Email": "hilbert.ledner@bradtke.us",
      "FullName": "Mr. Jarrell Feil",
      "DirectPhone": "(951)659-6007 x4120",
      "FormalName": "Mosciski Group",
      "CountryId": 428,
      "ContactId": 161,
      "ContactName": "Paucek-Kunde",
      "Retired": 533,
      "Rank": 705,
      "ActiveInterests": 982,
      "ContactDepartment": "",
      "ContactCountryId": 271,
      "ContactOrgNr": "1338125",
      "FaxPhone": "108-909-0086 x726",
      "MobilePhone": "(178)684-0735",
      "ContactPhone": "(579)963-3215 x878",
      "AssociateName": "Mraz-O'Conner",
      "AssociateId": 754,
      "UsePersonAddress": false,
      "ContactFax": "impedit",
      "Kanafname": "nihil",
      "Kanalname": "molestias",
      "Post1": "in",
      "Post2": "ea",
      "Post3": "molestiae",
      "EmailName": "greyson@treutel.co.uk",
      "ContactFullName": "Dr. Lexie Van Auer",
      "ActiveErpLinks": 828,
      "TicketPriorityId": 592,
      "SupportLanguageId": 345,
      "SupportAssociateId": 200,
      "CategoryName": "VIP Customer",
      "PersonNumber": "724464",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 460
        }
      }
    }
  ],
  "AlertLevel": 145,
  "ConnectId": 836,
  "ReadStatus": "Green",
  "TimeToReply": 153,
  "RealTimeToReply": 426,
  "TimeToClose": 99,
  "RealTimeToClose": 346,
  "TimeSpentInternally": 809,
  "TimeSpentExternally": 848,
  "TimeSpentQueue": 778,
  "RealTimeSpentInternally": 352,
  "RealTimeSpentExternally": 973,
  "RealTimeSpentQueue": 519,
  "TimeSpent": 370,
  "HasAttachment": false,
  "NumReplies": 907,
  "NumMessages": 359,
  "FromAddress": "occaecati",
  "Messages": [
    {
      "TicketMessageId": 728,
      "CreatedAt": "1999-06-07T14:13:41.5321506+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "enim",
      "PersonId": 364,
      "PersonFullName": "Camila Durgan",
      "ContactId": 270,
      "ContactName": "Ebert, Renner and Stark",
      "ContactDepartment": "",
      "NumAttachments": 241,
      "EmailHeader": "cole@hermiston.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "rerum",
      "Sentiment": 182,
      "SentimentConfidence": 818,
      "CreatedBy": 411,
      "ChangedAt": "2016-07-20T14:13:41.5321506+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 926
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 905,
      "Name": "Feil, Mohr and Durgan",
      "ToolTip": "Quia iusto quod beatae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 423
        }
      }
    },
    {
      "Id": 905,
      "Name": "Feil, Mohr and Durgan",
      "ToolTip": "Quia iusto quod beatae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 423
        }
      }
    }
  ],
  "Language": "commodi",
  "Sentiment": 128,
  "SentimentConfidence": 590,
  "SuggestedCategoryId": 444,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 602,
  "IconHint": "expedita",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 633,
  "ExtraFields": {
    "ExtraFields1": "numquam",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "nesciunt",
    "CustomFields2": "ea"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 202
    }
  }
}
```