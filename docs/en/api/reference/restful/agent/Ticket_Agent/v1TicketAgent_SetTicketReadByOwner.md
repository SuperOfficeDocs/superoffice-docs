---
title: POST Agents/Ticket/SetTicketReadByOwner
uid: v1TicketAgent_SetTicketReadByOwner
generated: true
---

# POST Agents/Ticket/SetTicketReadByOwner

```http
POST /api/v1/Agents/Ticket/SetTicketReadByOwner
```

Set the ReadByOwner status for a ticket.


It will only have an effect if the calling user is the same as the owner of the ticket






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/SetTicketReadByOwner?$select=name,department,category/id
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

TicketEntityId, ReadStatus, CheckEscalating 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketEntityId | Integer |  |
| ReadStatus | String |  |
| CheckEscalating | Boolean |  |

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
POST /api/v1/Agents/Ticket/SetTicketReadByOwner
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 174,
  "ReadStatus": "Green",
  "CheckEscalating": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 496,
  "Title": "illum",
  "CreatedAt": "2007-11-06T11:06:35.5220863+01:00",
  "LastChanged": "2013-03-21T11:06:35.5220863+01:00",
  "ReadByOwner": "2015-11-02T11:06:35.5220863+01:00",
  "ReadByCustomer": "2002-08-08T11:06:35.5220863+02:00",
  "FirstReadByOwner": "2014-01-11T11:06:35.5220863+01:00",
  "FirstReadByUser": "2021-03-14T11:06:35.5220863+01:00",
  "Activate": "2007-04-10T11:06:35.5220863+02:00",
  "ClosedAt": "2021-09-17T11:06:35.5220863+02:00",
  "RepliedAt": "2002-11-15T11:06:35.5220863+01:00",
  "AlertTimeout": "2011-03-25T11:06:35.5220863+01:00",
  "Deadline": "2013-06-14T11:06:35.5220863+02:00",
  "CreatedBy": null,
  "Author": "adipisci",
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
      "Position": "sed",
      "PersonId": 763,
      "Mrmrs": "debitis",
      "Firstname": "Alison",
      "Lastname": "Hayes",
      "MiddleName": "Eichmann Inc and Sons",
      "Title": "itaque",
      "Description": "Open-architected secondary frame",
      "Email": "telly_boyle@greenfelder.biz",
      "FullName": "Serena Wilderman",
      "DirectPhone": "887.096.1010 x17329",
      "FormalName": "Kozey-Casper",
      "CountryId": 623,
      "ContactId": 665,
      "ContactName": "Beier Group",
      "Retired": 730,
      "Rank": 496,
      "ActiveInterests": 983,
      "ContactDepartment": "",
      "ContactCountryId": 786,
      "ContactOrgNr": "1157445",
      "FaxPhone": "(327)206-9101",
      "MobilePhone": "082-420-0907 x679",
      "ContactPhone": "422.609.1572 x018",
      "AssociateName": "Bode, Vandervort and Kovacek",
      "AssociateId": 106,
      "UsePersonAddress": false,
      "ContactFax": "dolorem",
      "Kanafname": "veniam",
      "Kanalname": "omnis",
      "Post1": "eos",
      "Post2": "autem",
      "Post3": "et",
      "EmailName": "delta_gutmann@monahan.com",
      "ContactFullName": "Blake Ryan II",
      "ActiveErpLinks": 518,
      "TicketPriorityId": 233,
      "SupportLanguageId": 233,
      "SupportAssociateId": 383,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 329
        }
      }
    }
  ],
  "AlertLevel": 175,
  "ConnectId": 975,
  "ReadStatus": "Green",
  "TimeToReply": 465,
  "RealTimeToReply": 276,
  "TimeToClose": 133,
  "RealTimeToClose": 218,
  "TimeSpentInternally": 815,
  "TimeSpentExternally": 965,
  "TimeSpentQueue": 592,
  "RealTimeSpentInternally": 422,
  "RealTimeSpentExternally": 497,
  "RealTimeSpentQueue": 79,
  "TimeSpent": 364,
  "HasAttachment": true,
  "NumReplies": 384,
  "NumMessages": 502,
  "FromAddress": "et",
  "Messages": [
    {
      "TicketMessageId": 755,
      "CreatedAt": "2010-02-15T11:06:35.5220863+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "nihil",
      "PersonId": 243,
      "PersonFullName": "General Sporer",
      "ContactId": 542,
      "ContactName": "Glover, Schinner and Mayer",
      "ContactDepartment": "",
      "NumAttachments": 733,
      "EmailHeader": "carleton@harveyrodriguez.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "impedit",
      "Sentiment": 263,
      "SentimentConfidence": 847,
      "CreatedBy": 849,
      "ChangedAt": "2002-05-28T11:06:35.5220863+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 622
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 139,
      "Name": "Rath Inc and Sons",
      "ToolTip": "Odit non expedita incidunt numquam sit provident.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 310
        }
      }
    },
    {
      "Id": 139,
      "Name": "Rath Inc and Sons",
      "ToolTip": "Odit non expedita incidunt numquam sit provident.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 310
        }
      }
    }
  ],
  "Language": "itaque",
  "Sentiment": 228,
  "SentimentConfidence": 314,
  "SuggestedCategoryId": 524,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 847,
  "IconHint": "commodi",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "at",
    "ExtraFields2": "distinctio"
  },
  "CustomFields": {
    "CustomFields1": "itaque",
    "CustomFields2": "consequatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 794
    }
  }
}
```