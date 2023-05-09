---
title: POST Agents/Ticket/GetNextInQueue
uid: v1TicketAgent_GetNextInQueue
---

# POST Agents/Ticket/GetNextInQueue

```http
POST /api/v1/Agents/Ticket/GetNextInQueue
```

Assign a ticket to the caller based on intelligent queue system







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetNextInQueue?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Ticket/GetNextInQueue
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 395,
  "Title": "sed",
  "CreatedAt": "2015-10-04T03:51:28.3495774+02:00",
  "LastChanged": "2006-02-05T03:51:28.3495774+01:00",
  "ReadByOwner": "2019-10-14T03:51:28.3495774+02:00",
  "ReadByCustomer": "2001-01-26T03:51:28.3495774+01:00",
  "FirstReadByOwner": "1996-03-23T03:51:28.3495774+01:00",
  "FirstReadByUser": "2006-03-23T03:51:28.3495774+01:00",
  "Activate": "2008-01-03T03:51:28.3495774+01:00",
  "ClosedAt": "2004-07-01T03:51:28.3495774+02:00",
  "RepliedAt": "2016-12-01T03:51:28.3495774+01:00",
  "AlertTimeout": "2015-12-11T03:51:28.3495774+01:00",
  "Deadline": "1998-06-26T03:51:28.3495774+02:00",
  "CreatedBy": null,
  "Author": "repudiandae",
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
      "Position": "alias",
      "PersonId": 426,
      "Mrmrs": "repellendus",
      "Firstname": "Cary",
      "Lastname": "Weimann",
      "MiddleName": "Stokes-Koch",
      "Title": "est",
      "Description": "Down-sized systemic database",
      "Email": "alfredo_metz@torp.uk",
      "FullName": "Enrico Rodriguez",
      "DirectPhone": "1-112-783-9878",
      "FormalName": "Kub, Sanford and Feil",
      "CountryId": 942,
      "ContactId": 662,
      "ContactName": "Kassulke, Legros and Rogahn",
      "Retired": 835,
      "Rank": 773,
      "ActiveInterests": 306,
      "ContactDepartment": "",
      "ContactCountryId": 534,
      "ContactOrgNr": "1816418",
      "FaxPhone": "097.743.3586 x619",
      "MobilePhone": "(239)639-5537",
      "ContactPhone": "1-563-787-8209 x65468",
      "AssociateName": "Shanahan Group",
      "AssociateId": 302,
      "UsePersonAddress": false,
      "ContactFax": "voluptatem",
      "Kanafname": "delectus",
      "Kanalname": "eaque",
      "Post1": "eum",
      "Post2": "qui",
      "Post3": "ut",
      "EmailName": "winona.erdman@heidenreich.co.uk",
      "ContactFullName": "Miss German Arjun Sauer",
      "ActiveErpLinks": 173,
      "TicketPriorityId": 421,
      "SupportLanguageId": 914,
      "SupportAssociateId": 223,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 60
        }
      }
    }
  ],
  "AlertLevel": 853,
  "ConnectId": 348,
  "ReadStatus": "Green",
  "TimeToReply": 418,
  "RealTimeToReply": 173,
  "TimeToClose": 317,
  "RealTimeToClose": 129,
  "TimeSpentInternally": 549,
  "TimeSpentExternally": 831,
  "TimeSpentQueue": 682,
  "RealTimeSpentInternally": 29,
  "RealTimeSpentExternally": 342,
  "RealTimeSpentQueue": 958,
  "HasAttachment": false,
  "NumReplies": 180,
  "NumMessages": 66,
  "FromAddress": "voluptas",
  "Messages": [
    {
      "TicketMessageId": 607,
      "CreatedAt": "2009-12-11T03:51:28.3495774+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "cumque",
      "PersonId": 943,
      "PersonFullName": "Mrs. Cierra Isabelle Mueller",
      "ContactId": 151,
      "ContactName": "Dickinson, Treutel and Farrell",
      "ContactDepartment": "",
      "NumAttachments": 103,
      "EmailHeader": "jerome.batz@kemmermcdermott.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "eum",
      "Sentiment": 900,
      "SentimentConfidence": 586,
      "CreatedBy": 18,
      "ChangedAt": "2019-04-07T03:51:28.3495774+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 76
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 747,
      "Name": "Eichmann-Runolfsson",
      "ToolTip": "Ut sed et.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 90
        }
      }
    },
    {
      "Id": 747,
      "Name": "Eichmann-Runolfsson",
      "ToolTip": "Ut sed et.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 90
        }
      }
    }
  ],
  "Language": "ut",
  "Sentiment": 995,
  "SentimentConfidence": 509,
  "SuggestedCategoryId": 319,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 893,
  "IconHint": "et",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "ad",
    "ExtraFields2": "animi"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "repudiandae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 857
    }
  }
}
```