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
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=694
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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Ticket/GetTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 179,
  "Title": "delectus",
  "CreatedAt": "2019-08-11T11:22:39.4300722+02:00",
  "LastChanged": "2009-11-01T11:22:39.4300722+01:00",
  "ReadByOwner": "2005-11-04T11:22:39.4300722+01:00",
  "ReadByCustomer": "1997-10-24T11:22:39.4300722+02:00",
  "FirstReadByOwner": "2000-10-09T11:22:39.4300722+02:00",
  "FirstReadByUser": "2022-02-26T11:22:39.4300722+01:00",
  "Activate": "1997-04-26T11:22:39.4300722+02:00",
  "ClosedAt": "2008-06-12T11:22:39.4300722+02:00",
  "RepliedAt": "2014-09-01T11:22:39.4300722+02:00",
  "AlertTimeout": "2016-09-09T11:22:39.4300722+02:00",
  "Deadline": "2018-03-20T11:22:39.4300722+01:00",
  "CreatedBy": null,
  "Author": "ipsa",
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
      "Position": "dolorum",
      "PersonId": 600,
      "Mrmrs": "temporibus",
      "Firstname": "Jasen",
      "Lastname": "Torp",
      "MiddleName": "Bergstrom Group",
      "Title": "qui",
      "Description": "Ergonomic analyzing protocol",
      "Email": "ivah@prohaskaflatley.info",
      "FullName": "Ms. Ken Spencer Jr.",
      "DirectPhone": "620-159-0427 x887",
      "FormalName": "Mills-Roob",
      "CountryId": 464,
      "ContactId": 842,
      "ContactName": "Christiansen, Stiedemann and Hahn",
      "Retired": 150,
      "Rank": 158,
      "ActiveInterests": 153,
      "ContactDepartment": "",
      "ContactCountryId": 263,
      "ContactOrgNr": "1297309",
      "FaxPhone": "1-525-942-0265",
      "MobilePhone": "1-049-062-6266",
      "ContactPhone": "755.986.4488 x0083",
      "AssociateName": "Huel-Hartmann",
      "AssociateId": 358,
      "UsePersonAddress": true,
      "ContactFax": "error",
      "Kanafname": "aut",
      "Kanalname": "est",
      "Post1": "incidunt",
      "Post2": "eos",
      "Post3": "repellendus",
      "EmailName": "adolphus@brakus.name",
      "ContactFullName": "Haven Schneider",
      "ActiveErpLinks": 961,
      "TicketPriorityId": 562,
      "SupportLanguageId": 553,
      "SupportAssociateId": 378,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 836
        }
      }
    }
  ],
  "AlertLevel": 198,
  "ConnectId": 96,
  "ReadStatus": "Green",
  "TimeToReply": 33,
  "RealTimeToReply": 271,
  "TimeToClose": 718,
  "RealTimeToClose": 527,
  "TimeSpentInternally": 410,
  "TimeSpentExternally": 981,
  "TimeSpentQueue": 728,
  "RealTimeSpentInternally": 865,
  "RealTimeSpentExternally": 115,
  "RealTimeSpentQueue": 556,
  "HasAttachment": true,
  "NumReplies": 185,
  "NumMessages": 509,
  "FromAddress": "voluptatem",
  "Messages": [
    {
      "TicketMessageId": 280,
      "CreatedAt": "2002-08-22T11:22:39.4300722+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "reprehenderit",
      "PersonId": 601,
      "PersonFullName": "Brisa McLaughlin",
      "ContactId": 95,
      "ContactName": "Mante, Reinger and Cummings",
      "ContactDepartment": "",
      "NumAttachments": 905,
      "EmailHeader": "stacey@swaniawski.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "vel",
      "Sentiment": 561,
      "SentimentConfidence": 278,
      "CreatedBy": 884,
      "ChangedAt": "2008-06-12T11:22:39.4300722+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 276
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 266,
      "Name": "Grant-Robel",
      "ToolTip": "Illo non voluptatem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 302
        }
      }
    },
    {
      "Id": 266,
      "Name": "Grant-Robel",
      "ToolTip": "Illo non voluptatem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 302
        }
      }
    }
  ],
  "Language": "et",
  "Sentiment": 578,
  "SentimentConfidence": 282,
  "SuggestedCategoryId": 103,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 427,
  "IconHint": "ut",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "temporibus",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "sunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 873
    }
  }
}
```