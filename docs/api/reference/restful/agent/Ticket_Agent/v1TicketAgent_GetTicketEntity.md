---
title: POST Agents/Ticket/GetTicketEntity
uid: v1TicketAgent_GetTicketEntity
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
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=612
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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | int32 | The primary key (auto-incremented) |
| Title | string | The title of the ticket. |
| CreatedAt | date-time | When the ticket was created. |
| LastChanged | date-time | The last time the ticket was modified. |
| ReadByOwner | date-time | The datetime for when the ticket last was read by the owner. |
| ReadByCustomer | date-time | The datetime for when the ticket was read by the customer. |
| FirstReadByUser | date-time | The datetime for when the ticket first was read by a user. |
| Activate | date-time | When the ticket should be activated, if it is postponed. |
| ClosedAt | date-time | When the ticket was closed. |
| RepliedAt | date-time | The datetime for when the ticket was replied to. I.e. the first external message added to the ticket. |
| AlertTimeout | date-time | The datetime for when the ticket should jump to the next alert_level. |
| Deadline | date-time | Deadline for ticket. |
| CreatedBy |  | The associate who created this ticket |
| Author | string | A string representing the author of the ticket (same as author of first message). |
| OwnedBy |  | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category |  | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority |  | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status |  | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person |  | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

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
  "TicketId": 427,
  "Title": "quia",
  "CreatedAt": "2003-09-24T11:10:28.2436933+02:00",
  "LastChanged": "2007-11-15T11:10:28.2436933+01:00",
  "ReadByOwner": "2000-12-05T11:10:28.2436933+01:00",
  "ReadByCustomer": "2019-03-20T11:10:28.2436933+01:00",
  "FirstReadByUser": "2009-01-03T11:10:28.2436933+01:00",
  "Activate": "1996-02-19T11:10:28.2436933+01:00",
  "ClosedAt": "2011-09-21T11:10:28.2436933+02:00",
  "RepliedAt": "1999-02-17T11:10:28.2436933+01:00",
  "AlertTimeout": "1996-08-02T11:10:28.2436933+02:00",
  "Deadline": "1995-12-16T11:10:28.2436933+01:00",
  "CreatedBy": null,
  "Author": "dolores",
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
      "Position": "voluptas",
      "PersonId": 823,
      "Mrmrs": "et",
      "Firstname": "Gus",
      "Lastname": "Yost",
      "MiddleName": "Herman Inc and Sons",
      "Title": "expedita",
      "Description": "Streamlined composite functionalities",
      "Email": "ernie.ondricka@stroman.biz",
      "FullName": "Ronny Laverna Altenwerth V",
      "DirectPhone": "(913)929-7734",
      "FormalName": "Lehner, West and Altenwerth",
      "CountryId": 346,
      "ContactId": 191,
      "ContactName": "Hermann, Hoeger and Breitenberg",
      "Retired": 333,
      "Rank": 635,
      "ActiveInterests": 508,
      "ContactDepartment": "",
      "ContactCountryId": 771,
      "ContactOrgNr": "1114697",
      "FaxPhone": "1-416-085-9519",
      "MobilePhone": "619-163-7989",
      "ContactPhone": "444-689-5782 x7975",
      "AssociateName": "Volkman, Kris and Romaguera",
      "AssociateId": 452,
      "UsePersonAddress": false,
      "ContactFax": "ea",
      "Kanafname": "a",
      "Kanalname": "dolorem",
      "Post1": "voluptates",
      "Post2": "possimus",
      "Post3": "rerum",
      "EmailName": "danial.halvorson@kriscarroll.co.uk",
      "ContactFullName": "Prof. Madeline Floyd Kreiger III",
      "ActiveErpLinks": 108,
      "TicketPriorityId": 576,
      "SupportLanguageId": 55,
      "SupportAssociateId": 527,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 316
        }
      }
    }
  ],
  "AlertLevel": 199,
  "ConnectId": 113,
  "ReadStatus": "Green",
  "TimeToReply": 730,
  "RealTimeToReply": 643,
  "TimeToClose": 10,
  "RealTimeToClose": 788,
  "TimeSpentInternally": 644,
  "TimeSpentExternally": 95,
  "TimeSpentQueue": 51,
  "RealTimeSpentInternally": 779,
  "RealTimeSpentExternally": 969,
  "RealTimeSpentQueue": 87,
  "HasAttachment": true,
  "NumReplies": 241,
  "NumMessages": 156,
  "FromAddress": "quis",
  "Messages": [
    {
      "TicketMessageId": 989,
      "CreatedAt": "2009-03-05T11:10:28.2486931+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "est",
      "PersonId": 1002,
      "PersonFullName": "Zetta Koepp",
      "ContactId": 648,
      "ContactName": "Jones-Sporer",
      "ContactDepartment": "",
      "NumAttachments": 335,
      "EmailHeader": "kristoffer_wilkinson@cassin.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "necessitatibus",
      "Sentiment": 792,
      "SentimentConfidence": 585,
      "CreatedBy": 17,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 600
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 287,
      "Name": "Konopelski-Jewess",
      "ToolTip": "Sunt voluptas consequatur aut incidunt.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 522
        }
      }
    },
    {
      "Id": 287,
      "Name": "Konopelski-Jewess",
      "ToolTip": "Sunt voluptas consequatur aut incidunt.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 522
        }
      }
    }
  ],
  "Language": "eligendi",
  "Sentiment": 385,
  "SentimentConfidence": 371,
  "SuggestedCategoryId": 128,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 754,
  "IconHint": "distinctio",
  "ExtraFields": {
    "ExtraFields1": "quis",
    "ExtraFields2": "recusandae"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "magnam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 668
    }
  }
}
```
