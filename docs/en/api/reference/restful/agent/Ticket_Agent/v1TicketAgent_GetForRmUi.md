---
title: POST Agents/Ticket/GetForRmUi
uid: v1TicketAgent_GetForRmUi
---

# POST Agents/Ticket/GetForRmUi

```http
POST /api/v1/Agents/Ticket/GetForRmUi
```

Get a ticket entity, adapted to the specific needs of the Request Management UI.


WARNING: This endpoint is not guaranteed to be stable/compatible between versions






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetForRmUi?$select=name,department,category/id
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

TicketId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | Integer |  |

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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Ticket/GetForRmUi
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketId": 910
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 331,
  "Title": "culpa",
  "CreatedAt": "1998-09-20T15:29:23.1122568+02:00",
  "LastChanged": "2003-12-04T15:29:23.1122568+01:00",
  "ReadByOwner": "2012-12-10T15:29:23.1122568+01:00",
  "ReadByCustomer": "2008-01-31T15:29:23.1122568+01:00",
  "FirstReadByOwner": "2011-03-31T15:29:23.1122568+02:00",
  "FirstReadByUser": "2007-08-16T15:29:23.1122568+02:00",
  "Activate": "2021-12-19T15:29:23.1122568+01:00",
  "ClosedAt": "2010-07-14T15:29:23.1122568+02:00",
  "RepliedAt": "1996-08-07T15:29:23.1122568+02:00",
  "AlertTimeout": "2000-10-08T15:29:23.1122568+02:00",
  "Deadline": "2019-03-12T15:29:23.1122568+01:00",
  "CreatedBy": null,
  "Author": "dignissimos",
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
      "Position": "et",
      "PersonId": 471,
      "Mrmrs": "in",
      "Firstname": "Hipolito",
      "Lastname": "Von",
      "MiddleName": "Dickens LLC",
      "Title": "et",
      "Description": "Synergistic dedicated frame",
      "Email": "durward@quigleyroberts.name",
      "FullName": "Neil Ebert",
      "DirectPhone": "888-424-5481 x52470",
      "FormalName": "Quigley LLC",
      "CountryId": 461,
      "ContactId": 763,
      "ContactName": "Abbott LLC",
      "Retired": 131,
      "Rank": 538,
      "ActiveInterests": 25,
      "ContactDepartment": "",
      "ContactCountryId": 786,
      "ContactOrgNr": "1246877",
      "FaxPhone": "765.049.1726",
      "MobilePhone": "(252)706-5594 x2820",
      "ContactPhone": "772.126.2368 x9347",
      "AssociateName": "Macejkovic Inc and Sons",
      "AssociateId": 958,
      "UsePersonAddress": false,
      "ContactFax": "fugit",
      "Kanafname": "incidunt",
      "Kanalname": "quia",
      "Post1": "ut",
      "Post2": "omnis",
      "Post3": "suscipit",
      "EmailName": "hugh.turcotte@turner.biz",
      "ContactFullName": "Prof. Tito Roel Monahan",
      "ActiveErpLinks": 932,
      "TicketPriorityId": 735,
      "SupportLanguageId": 815,
      "SupportAssociateId": 827,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 32
        }
      }
    }
  ],
  "AlertLevel": 871,
  "ConnectId": 175,
  "ReadStatus": "Green",
  "TimeToReply": 294,
  "RealTimeToReply": 640,
  "TimeToClose": 794,
  "RealTimeToClose": 385,
  "TimeSpentInternally": 220,
  "TimeSpentExternally": 94,
  "TimeSpentQueue": 558,
  "RealTimeSpentInternally": 187,
  "RealTimeSpentExternally": 871,
  "RealTimeSpentQueue": 347,
  "HasAttachment": false,
  "NumReplies": 452,
  "NumMessages": 550,
  "FromAddress": "tenetur",
  "Messages": [
    {
      "TicketMessageId": 446,
      "CreatedAt": "1998-01-08T15:29:23.1167572+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "minima",
      "PersonId": 231,
      "PersonFullName": "Heaven Bauch",
      "ContactId": 498,
      "ContactName": "Swaniawski Group",
      "ContactDepartment": "",
      "NumAttachments": 119,
      "EmailHeader": "holden.turcotte@stark.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quis",
      "Sentiment": 23,
      "SentimentConfidence": 767,
      "CreatedBy": 720,
      "ChangedAt": "2011-11-03T15:29:23.1172564+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 138
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 651,
      "Name": "Lubowitz Group",
      "ToolTip": "Distinctio dignissimos incidunt explicabo vitae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 844
        }
      }
    },
    {
      "Id": 651,
      "Name": "Lubowitz Group",
      "ToolTip": "Distinctio dignissimos incidunt explicabo vitae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 844
        }
      }
    }
  ],
  "Language": "consequatur",
  "Sentiment": 138,
  "SentimentConfidence": 938,
  "SuggestedCategoryId": 774,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 179,
  "IconHint": "doloremque",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "repudiandae"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "consequatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 398
    }
  }
}
```