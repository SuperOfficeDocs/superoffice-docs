---
title: POST Agents/Ticket/GetTicketEntity
uid: v1TicketAgent_GetTicketEntity
generated: true
---

# POST Agents/Ticket/GetTicketEntity

```http
POST /api/v1/Agents/Ticket/GetTicketEntity
```

Gets a TicketEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ticketEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=58
POST /api/v1/Agents/Ticket/GetTicketEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Ticket/GetTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 962,
  "Title": "alias",
  "CreatedAt": "2017-07-01T16:00:42.1018977+02:00",
  "LastChanged": "2002-07-06T16:00:42.1018977+02:00",
  "ReadByOwner": "2022-10-03T16:00:42.1018977+02:00",
  "ReadByCustomer": "2007-05-15T16:00:42.1018977+02:00",
  "FirstReadByOwner": "2013-09-14T16:00:42.1018977+02:00",
  "FirstReadByUser": "2008-12-11T16:00:42.1018977+01:00",
  "Activate": "1997-10-02T16:00:42.1018977+02:00",
  "ClosedAt": "1998-12-15T16:00:42.1018977+01:00",
  "RepliedAt": "1999-04-06T16:00:42.1018977+02:00",
  "AlertTimeout": "2009-10-18T16:00:42.1018977+02:00",
  "Deadline": "1996-06-17T16:00:42.1018977+02:00",
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
      "Position": "excepturi",
      "PersonId": 116,
      "Mrmrs": "consequatur",
      "Firstname": "Alessandro",
      "Lastname": "Brown",
      "MiddleName": "Anderson, Sawayn and Willms",
      "Title": "sed",
      "Description": "Virtual context-sensitive infrastructure",
      "Email": "quentin.rosenbaum@prosacco.uk",
      "FullName": "Sally Goldner Sr.",
      "DirectPhone": "1-780-041-0034 x051",
      "FormalName": "Schinner-Nitzsche",
      "CountryId": 832,
      "ContactId": 180,
      "ContactName": "Casper-Graham",
      "Retired": 618,
      "Rank": 634,
      "ActiveInterests": 111,
      "ContactDepartment": "",
      "ContactCountryId": 137,
      "ContactOrgNr": "1130866",
      "FaxPhone": "1-765-702-7735 x867",
      "MobilePhone": "918.909.7134 x07487",
      "ContactPhone": "1-610-318-2132",
      "AssociateName": "Halvorson Inc and Sons",
      "AssociateId": 263,
      "UsePersonAddress": true,
      "ContactFax": "iure",
      "Kanafname": "sint",
      "Kanalname": "mollitia",
      "Post1": "ut",
      "Post2": "excepturi",
      "Post3": "molestiae",
      "EmailName": "quinn.rohan@schoen.ca",
      "ContactFullName": "Ms. Elwin Paucek",
      "ActiveErpLinks": 434,
      "TicketPriorityId": 519,
      "SupportLanguageId": 361,
      "SupportAssociateId": 432,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 492
        }
      }
    }
  ],
  "AlertLevel": 643,
  "ConnectId": 191,
  "ReadStatus": "Green",
  "TimeToReply": 160,
  "RealTimeToReply": 826,
  "TimeToClose": 433,
  "RealTimeToClose": 468,
  "TimeSpentInternally": 29,
  "TimeSpentExternally": 56,
  "TimeSpentQueue": 847,
  "RealTimeSpentInternally": 697,
  "RealTimeSpentExternally": 609,
  "RealTimeSpentQueue": 158,
  "HasAttachment": false,
  "NumReplies": 594,
  "NumMessages": 649,
  "FromAddress": "vel",
  "Messages": [
    {
      "TicketMessageId": 6,
      "CreatedAt": "2013-03-18T16:00:42.1175153+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "sint",
      "PersonId": 184,
      "PersonFullName": "Meaghan Raynor",
      "ContactId": 504,
      "ContactName": "Lesch, Gibson and Beahan",
      "ContactDepartment": "",
      "NumAttachments": 500,
      "EmailHeader": "lucius.lowe@borergutmann.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "tenetur",
      "Sentiment": 535,
      "SentimentConfidence": 183,
      "CreatedBy": 34,
      "ChangedAt": "2023-03-27T16:00:42.1175153+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 16
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 274,
      "Name": "Langosh Inc and Sons",
      "ToolTip": "In non molestias nobis deserunt.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 121
        }
      }
    },
    {
      "Id": 274,
      "Name": "Langosh Inc and Sons",
      "ToolTip": "In non molestias nobis deserunt.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 121
        }
      }
    }
  ],
  "Language": "totam",
  "Sentiment": 261,
  "SentimentConfidence": 241,
  "SuggestedCategoryId": 230,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 656,
  "IconHint": "et",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "delectus",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "dolorem",
    "CustomFields2": "ratione"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 373
    }
  }
}
```