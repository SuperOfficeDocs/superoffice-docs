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
  "TicketEntityId": 833,
  "ReadStatus": "Green",
  "CheckEscalating": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 656,
  "Title": "quas",
  "CreatedAt": "1996-10-29T13:57:13.3802187+01:00",
  "LastChanged": "1998-05-05T13:57:13.3802187+02:00",
  "ReadByOwner": "1999-04-13T13:57:13.3802187+02:00",
  "ReadByCustomer": "2011-04-01T13:57:13.3802187+02:00",
  "FirstReadByOwner": "2004-07-09T13:57:13.3802187+02:00",
  "FirstReadByUser": "2013-07-12T13:57:13.3802187+02:00",
  "Activate": "2007-09-24T13:57:13.3802187+02:00",
  "ClosedAt": "1998-02-24T13:57:13.3802187+01:00",
  "RepliedAt": "2017-09-18T13:57:13.3802187+02:00",
  "AlertTimeout": "2020-01-14T13:57:13.3802187+01:00",
  "Deadline": "2000-03-20T13:57:13.3802187+01:00",
  "CreatedBy": null,
  "Author": "sed",
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
      "Position": "aspernatur",
      "PersonId": 878,
      "Mrmrs": "omnis",
      "Firstname": "Johnathan",
      "Lastname": "Homenick",
      "MiddleName": "Wiza Inc and Sons",
      "Title": "perspiciatis",
      "Description": "Function-based grid-enabled leverage",
      "Email": "fern_sipes@collier.co.uk",
      "FullName": "Maryse Goldner",
      "DirectPhone": "1-066-189-6242 x8255",
      "FormalName": "Kertzmann, Keeling and Boyer",
      "CountryId": 723,
      "ContactId": 577,
      "ContactName": "Torp LLC",
      "Retired": 901,
      "Rank": 121,
      "ActiveInterests": 790,
      "ContactDepartment": "exploit collaborative synergies",
      "ContactCountryId": 680,
      "ContactOrgNr": "899976",
      "FaxPhone": "254.369.9079 x76375",
      "MobilePhone": "364-345-9948",
      "ContactPhone": "1-062-081-0955 x722",
      "AssociateName": "Marvin LLC",
      "AssociateId": 277,
      "UsePersonAddress": true,
      "ContactFax": "minima",
      "Kanafname": "error",
      "Kanalname": "ex",
      "Post1": "aut",
      "Post2": "molestias",
      "Post3": "reprehenderit",
      "EmailName": "madelynn_feeney@witting.ca",
      "ContactFullName": "Prof. Deja Klein DVM",
      "ActiveErpLinks": 388,
      "TicketPriorityId": 753,
      "SupportLanguageId": 20,
      "SupportAssociateId": 319,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 214
        }
      }
    }
  ],
  "AlertLevel": 445,
  "ConnectId": 990,
  "ReadStatus": "Green",
  "TimeToReply": 68,
  "RealTimeToReply": 295,
  "TimeToClose": 186,
  "RealTimeToClose": 404,
  "TimeSpentInternally": 537,
  "TimeSpentExternally": 309,
  "TimeSpentQueue": 276,
  "RealTimeSpentInternally": 535,
  "RealTimeSpentExternally": 305,
  "RealTimeSpentQueue": 686,
  "TimeSpent": 476,
  "HasAttachment": true,
  "NumReplies": 859,
  "NumMessages": 382,
  "FromAddress": "veritatis",
  "Messages": [
    {
      "TicketMessageId": 650,
      "CreatedAt": "2006-07-24T13:57:13.3802187+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "qui",
      "PersonId": 190,
      "PersonFullName": "Esmeralda Cooper Bechtelar DVM",
      "ContactId": 796,
      "ContactName": "Lockman Group",
      "ContactDepartment": "",
      "NumAttachments": 200,
      "EmailHeader": "fannie.daniel@bode.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "accusamus",
      "Sentiment": 535,
      "SentimentConfidence": 288,
      "CreatedBy": 813,
      "ChangedAt": "2006-10-10T13:57:13.3802187+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 162
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 465,
      "Name": "Stroman LLC",
      "ToolTip": "Ratione distinctio voluptatem velit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 228
        }
      }
    },
    {
      "Id": 465,
      "Name": "Stroman LLC",
      "ToolTip": "Ratione distinctio voluptatem velit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 228
        }
      }
    }
  ],
  "Language": "nemo",
  "Sentiment": 887,
  "SentimentConfidence": 88,
  "SuggestedCategoryId": 445,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 200,
  "IconHint": "error",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "ad",
    "ExtraFields2": "quisquam"
  },
  "CustomFields": {
    "CustomFields1": "sunt",
    "CustomFields2": "ullam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 979
    }
  }
}
```