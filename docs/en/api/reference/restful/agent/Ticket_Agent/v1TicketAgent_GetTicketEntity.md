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
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=299
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
  "TicketId": 158,
  "Title": "ut",
  "CreatedAt": "1998-04-02T14:19:04.4078252+02:00",
  "LastChanged": "2009-11-14T14:19:04.4078252+01:00",
  "ReadByOwner": "1997-08-19T14:19:04.4078252+02:00",
  "ReadByCustomer": "2013-12-21T14:19:04.4078252+01:00",
  "FirstReadByOwner": "2008-12-09T14:19:04.4078252+01:00",
  "FirstReadByUser": "2019-02-19T14:19:04.4078252+01:00",
  "Activate": "2013-06-22T14:19:04.4078252+02:00",
  "ClosedAt": "2018-08-23T14:19:04.4078252+02:00",
  "RepliedAt": "2018-01-13T14:19:04.4078252+01:00",
  "AlertTimeout": "2023-02-08T14:19:04.4078252+01:00",
  "Deadline": "2006-05-14T14:19:04.4078252+02:00",
  "CreatedBy": null,
  "Author": "officiis",
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
      "Position": "consequuntur",
      "PersonId": 539,
      "Mrmrs": "vel",
      "Firstname": "Pat",
      "Lastname": "Mitchell",
      "MiddleName": "Ryan, Hoeger and Lehner",
      "Title": "saepe",
      "Description": "Cross-group well-modulated concept",
      "Email": "julianne@robelgrady.biz",
      "FullName": "Prof. Alverta Olson DVM",
      "DirectPhone": "(782)860-3172",
      "FormalName": "Treutel, Miller and Cole",
      "CountryId": 860,
      "ContactId": 89,
      "ContactName": "Schuster-Konopelski",
      "Retired": 247,
      "Rank": 777,
      "ActiveInterests": 610,
      "ContactDepartment": "",
      "ContactCountryId": 207,
      "ContactOrgNr": "1399656",
      "FaxPhone": "978-174-4197 x19678",
      "MobilePhone": "279-342-7060",
      "ContactPhone": "555.814.4383",
      "AssociateName": "Koepp Inc and Sons",
      "AssociateId": 986,
      "UsePersonAddress": true,
      "ContactFax": "ut",
      "Kanafname": "soluta",
      "Kanalname": "sunt",
      "Post1": "nulla",
      "Post2": "omnis",
      "Post3": "voluptatem",
      "EmailName": "ramon@parisianfadel.uk",
      "ContactFullName": "Eldora Schulist I",
      "ActiveErpLinks": 960,
      "TicketPriorityId": 811,
      "SupportLanguageId": 688,
      "SupportAssociateId": 65,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 579
        }
      }
    }
  ],
  "AlertLevel": 32,
  "ConnectId": 311,
  "ReadStatus": "Green",
  "TimeToReply": 252,
  "RealTimeToReply": 145,
  "TimeToClose": 783,
  "RealTimeToClose": 663,
  "TimeSpentInternally": 676,
  "TimeSpentExternally": 438,
  "TimeSpentQueue": 167,
  "RealTimeSpentInternally": 394,
  "RealTimeSpentExternally": 872,
  "RealTimeSpentQueue": 774,
  "HasAttachment": false,
  "NumReplies": 250,
  "NumMessages": 158,
  "FromAddress": "ad",
  "Messages": [
    {
      "TicketMessageId": 922,
      "CreatedAt": "2011-11-19T14:19:04.4078252+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "necessitatibus",
      "PersonId": 797,
      "PersonFullName": "Pinkie O'Kon MD",
      "ContactId": 935,
      "ContactName": "Satterfield, Wisozk and Yundt",
      "ContactDepartment": "",
      "NumAttachments": 934,
      "EmailHeader": "ida_stark@lemke.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quia",
      "Sentiment": 977,
      "SentimentConfidence": 992,
      "CreatedBy": 587,
      "ChangedAt": "2016-07-07T14:19:04.4078252+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 672
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 471,
      "Name": "Sipes, Blanda and Bailey",
      "ToolTip": "Velit rerum voluptate.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 255
        }
      }
    },
    {
      "Id": 471,
      "Name": "Sipes, Blanda and Bailey",
      "ToolTip": "Velit rerum voluptate.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 255
        }
      }
    }
  ],
  "Language": "nostrum",
  "Sentiment": 420,
  "SentimentConfidence": 6,
  "SuggestedCategoryId": 533,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 111,
  "IconHint": "et",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "totam",
    "ExtraFields2": "ipsa"
  },
  "CustomFields": {
    "CustomFields1": "mollitia",
    "CustomFields2": "nisi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 446
    }
  }
}
```