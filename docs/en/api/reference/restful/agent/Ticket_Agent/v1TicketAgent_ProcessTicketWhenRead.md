---
title: POST Agents/Ticket/ProcessTicketWhenRead
uid: v1TicketAgent_ProcessTicketWhenRead
---

# POST Agents/Ticket/ProcessTicketWhenRead

```http
POST /api/v1/Agents/Ticket/ProcessTicketWhenRead
```

When a user view/read a ticket, a number of action should be performed: set read status, escalation handling, remove notifications, etc.


Which actions will be performed depends on owner, caller and configuration






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/ProcessTicketWhenRead?$select=name,department,category/id
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

TicketEntityId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketEntityId | Integer |  |

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
POST /api/v1/Agents/Ticket/ProcessTicketWhenRead
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 282
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 200,
  "Title": "velit",
  "CreatedAt": "2014-12-22T03:51:28.3495774+01:00",
  "LastChanged": "2005-06-17T03:51:28.3495774+02:00",
  "ReadByOwner": "2009-02-23T03:51:28.3495774+01:00",
  "ReadByCustomer": "1998-12-01T03:51:28.3495774+01:00",
  "FirstReadByOwner": "2002-10-30T03:51:28.3495774+01:00",
  "FirstReadByUser": "2013-10-14T03:51:28.3495774+02:00",
  "Activate": "2004-10-28T03:51:28.3495774+02:00",
  "ClosedAt": "2000-01-08T03:51:28.3495774+01:00",
  "RepliedAt": "1996-08-25T03:51:28.3495774+02:00",
  "AlertTimeout": "2004-11-17T03:51:28.3495774+01:00",
  "Deadline": "1998-05-25T03:51:28.3495774+02:00",
  "CreatedBy": null,
  "Author": "vero",
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
      "Position": "explicabo",
      "PersonId": 283,
      "Mrmrs": "sunt",
      "Firstname": "Alva",
      "Lastname": "Will",
      "MiddleName": "Windler-Pacocha",
      "Title": "et",
      "Description": "Implemented even-keeled groupware",
      "Email": "maribel_pacocha@rodriguezrosenbaum.name",
      "FullName": "Prof. Cornelius Johnson",
      "DirectPhone": "263-137-8297",
      "FormalName": "O'Keefe Group",
      "CountryId": 988,
      "ContactId": 248,
      "ContactName": "Cormier Inc and Sons",
      "Retired": 948,
      "Rank": 988,
      "ActiveInterests": 984,
      "ContactDepartment": "productize enterprise mindshare",
      "ContactCountryId": 766,
      "ContactOrgNr": "1034929",
      "FaxPhone": "(080)748-3893 x72668",
      "MobilePhone": "947.020.2649",
      "ContactPhone": "1-835-102-6888",
      "AssociateName": "Anderson, Kulas and Grant",
      "AssociateId": 329,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "repellendus",
      "Kanalname": "ex",
      "Post1": "excepturi",
      "Post2": "amet",
      "Post3": "nihil",
      "EmailName": "jamar.osinski@bernier.co.uk",
      "ContactFullName": "Carter Champlin",
      "ActiveErpLinks": 940,
      "TicketPriorityId": 322,
      "SupportLanguageId": 62,
      "SupportAssociateId": 593,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 797
        }
      }
    }
  ],
  "AlertLevel": 910,
  "ConnectId": 461,
  "ReadStatus": "Green",
  "TimeToReply": 568,
  "RealTimeToReply": 92,
  "TimeToClose": 371,
  "RealTimeToClose": 450,
  "TimeSpentInternally": 634,
  "TimeSpentExternally": 918,
  "TimeSpentQueue": 167,
  "RealTimeSpentInternally": 550,
  "RealTimeSpentExternally": 670,
  "RealTimeSpentQueue": 760,
  "HasAttachment": true,
  "NumReplies": 480,
  "NumMessages": 412,
  "FromAddress": "et",
  "Messages": [
    {
      "TicketMessageId": 523,
      "CreatedAt": "2004-01-04T03:51:28.3652065+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "sit",
      "PersonId": 565,
      "PersonFullName": "Annamae Flatley",
      "ContactId": 289,
      "ContactName": "Veum, Langworth and Gleason",
      "ContactDepartment": "",
      "NumAttachments": 191,
      "EmailHeader": "alessandra@green.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "voluptas",
      "Sentiment": 311,
      "SentimentConfidence": 163,
      "CreatedBy": 91,
      "ChangedAt": "2011-04-01T03:51:28.3652065+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 333
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 324,
      "Name": "Kassulke, Hintz and Mann",
      "ToolTip": "Nesciunt blanditiis ut alias reprehenderit qui blanditiis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 685
        }
      }
    },
    {
      "Id": 324,
      "Name": "Kassulke, Hintz and Mann",
      "ToolTip": "Nesciunt blanditiis ut alias reprehenderit qui blanditiis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 685
        }
      }
    }
  ],
  "Language": "ullam",
  "Sentiment": 346,
  "SentimentConfidence": 741,
  "SuggestedCategoryId": 931,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 259,
  "IconHint": "repellat",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "quaerat",
    "ExtraFields2": "cum"
  },
  "CustomFields": {
    "CustomFields1": "quidem",
    "CustomFields2": "saepe"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 263
    }
  }
}
```