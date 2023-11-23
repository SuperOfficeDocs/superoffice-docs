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
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=570
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
  "TicketId": 249,
  "Title": "quis",
  "CreatedAt": "2003-02-13T13:38:14.2178238+01:00",
  "LastChanged": "2022-05-30T13:38:14.2178238+02:00",
  "ReadByOwner": "2007-09-25T13:38:14.2178238+02:00",
  "ReadByCustomer": "2008-10-22T13:38:14.2178238+02:00",
  "FirstReadByOwner": "2004-04-15T13:38:14.2178238+02:00",
  "FirstReadByUser": "2013-12-21T13:38:14.2178238+01:00",
  "Activate": "2021-06-06T13:38:14.2178238+02:00",
  "ClosedAt": "2010-08-26T13:38:14.2178238+02:00",
  "RepliedAt": "2007-11-20T13:38:14.2178238+01:00",
  "AlertTimeout": "2004-04-01T13:38:14.2178238+02:00",
  "Deadline": "2000-06-11T13:38:14.2178238+02:00",
  "CreatedBy": null,
  "Author": "est",
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
      "Position": "aut",
      "PersonId": 938,
      "Mrmrs": "non",
      "Firstname": "Salvatore",
      "Lastname": "Denesik",
      "MiddleName": "Schmidt-Roberts",
      "Title": "quod",
      "Description": "Sharable fault-tolerant Graphic Interface",
      "Email": "kristopher_hintz@reinger.co.uk",
      "FullName": "Rico Leuschke",
      "DirectPhone": "728-426-0927",
      "FormalName": "Weber-Walsh",
      "CountryId": 936,
      "ContactId": 9,
      "ContactName": "Fay, Monahan and Turner",
      "Retired": 887,
      "Rank": 770,
      "ActiveInterests": 567,
      "ContactDepartment": "iterate rich partnerships",
      "ContactCountryId": 590,
      "ContactOrgNr": "1424956",
      "FaxPhone": "1-324-585-2803 x729",
      "MobilePhone": "1-405-375-5980 x8129",
      "ContactPhone": "425-605-4093 x07845",
      "AssociateName": "Cummerata Group",
      "AssociateId": 275,
      "UsePersonAddress": true,
      "ContactFax": "pariatur",
      "Kanafname": "est",
      "Kanalname": "ut",
      "Post1": "rerum",
      "Post2": "dolorem",
      "Post3": "qui",
      "EmailName": "lizeth@schamberger.uk",
      "ContactFullName": "Lionel Hoeger",
      "ActiveErpLinks": 989,
      "TicketPriorityId": 764,
      "SupportLanguageId": 874,
      "SupportAssociateId": 499,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 705
        }
      }
    }
  ],
  "AlertLevel": 280,
  "ConnectId": 149,
  "ReadStatus": "Green",
  "TimeToReply": 949,
  "RealTimeToReply": 326,
  "TimeToClose": 865,
  "RealTimeToClose": 977,
  "TimeSpentInternally": 208,
  "TimeSpentExternally": 635,
  "TimeSpentQueue": 669,
  "RealTimeSpentInternally": 689,
  "RealTimeSpentExternally": 100,
  "RealTimeSpentQueue": 847,
  "TimeSpent": 365,
  "HasAttachment": true,
  "NumReplies": 9,
  "NumMessages": 572,
  "FromAddress": "nostrum",
  "Messages": [
    {
      "TicketMessageId": 475,
      "CreatedAt": "2009-03-12T13:38:14.2334357+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "libero",
      "PersonId": 878,
      "PersonFullName": "Mellie Homenick",
      "ContactId": 616,
      "ContactName": "O'Reilly-Smitham",
      "ContactDepartment": "",
      "NumAttachments": 402,
      "EmailHeader": "brannon@shields.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quia",
      "Sentiment": 574,
      "SentimentConfidence": 186,
      "CreatedBy": 888,
      "ChangedAt": "1996-07-11T13:38:14.2334357+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 11
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 996,
      "Name": "Greenholt-Donnelly",
      "ToolTip": "Dicta aspernatur sunt.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 667
        }
      }
    },
    {
      "Id": 996,
      "Name": "Greenholt-Donnelly",
      "ToolTip": "Dicta aspernatur sunt.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 667
        }
      }
    }
  ],
  "Language": "atque",
  "Sentiment": 126,
  "SentimentConfidence": 655,
  "SuggestedCategoryId": 504,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 242,
  "IconHint": "quia",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "quis",
    "ExtraFields2": "expedita"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "error"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 505
    }
  }
}
```