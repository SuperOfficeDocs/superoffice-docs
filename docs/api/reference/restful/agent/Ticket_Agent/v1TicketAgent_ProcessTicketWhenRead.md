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
| TicketEntityId | int32 |  |


## Response: 

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
POST /api/v1/Agents/Ticket/ProcessTicketWhenRead
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 492
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 218,
  "Title": "rem",
  "CreatedAt": "1996-03-12T11:10:28.2972069+01:00",
  "LastChanged": "2006-11-25T11:10:28.2972069+01:00",
  "ReadByOwner": "1995-12-21T11:10:28.2972069+01:00",
  "ReadByCustomer": "2020-08-11T11:10:28.2972069+02:00",
  "FirstReadByUser": "1996-11-12T11:10:28.2972069+01:00",
  "Activate": "1997-12-20T11:10:28.2972069+01:00",
  "ClosedAt": "2012-03-02T11:10:28.2972069+01:00",
  "RepliedAt": "2001-07-26T11:10:28.2972069+02:00",
  "AlertTimeout": "1995-06-08T11:10:28.2972069+02:00",
  "Deadline": "1996-12-22T11:10:28.2972069+01:00",
  "CreatedBy": null,
  "Author": "eos",
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
      "Position": "natus",
      "PersonId": 229,
      "Mrmrs": "ducimus",
      "Firstname": "Ursula",
      "Lastname": "Hessel",
      "MiddleName": "Gerhold Inc and Sons",
      "Title": "expedita",
      "Description": "Automated asynchronous circuit",
      "Email": "vicenta@oberbrunnerfeil.uk",
      "FullName": "Annabel Pacocha",
      "DirectPhone": "1-345-929-7877 x80827",
      "FormalName": "Brown-Keeling",
      "CountryId": 61,
      "ContactId": 346,
      "ContactName": "Zieme LLC",
      "Retired": 361,
      "Rank": 306,
      "ActiveInterests": 819,
      "ContactDepartment": "",
      "ContactCountryId": 551,
      "ContactOrgNr": "520611",
      "FaxPhone": "1-754-564-6878",
      "MobilePhone": "103-790-5060",
      "ContactPhone": "108.569.6174",
      "AssociateName": "Simonis-Koch",
      "AssociateId": 181,
      "UsePersonAddress": false,
      "ContactFax": "sed",
      "Kanafname": "eum",
      "Kanalname": "rem",
      "Post1": "esse",
      "Post2": "beatae",
      "Post3": "illum",
      "EmailName": "thad@schiller.uk",
      "ContactFullName": "Cecilia D'Amore",
      "ActiveErpLinks": 626,
      "TicketPriorityId": 111,
      "SupportLanguageId": 923,
      "SupportAssociateId": 386,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 1001
        }
      }
    }
  ],
  "AlertLevel": 420,
  "ConnectId": 974,
  "ReadStatus": "Green",
  "TimeToReply": 546,
  "RealTimeToReply": 921,
  "TimeToClose": 132,
  "RealTimeToClose": 823,
  "TimeSpentInternally": 937,
  "TimeSpentExternally": 433,
  "TimeSpentQueue": 58,
  "RealTimeSpentInternally": 210,
  "RealTimeSpentExternally": 662,
  "RealTimeSpentQueue": 254,
  "HasAttachment": false,
  "NumReplies": 714,
  "NumMessages": 985,
  "FromAddress": "nostrum",
  "Messages": [
    {
      "TicketMessageId": 934,
      "CreatedAt": "2010-11-01T11:10:28.3002068+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "nam",
      "PersonId": 125,
      "PersonFullName": "Nicolette Schowalter",
      "ContactId": 841,
      "ContactName": "Schuster LLC",
      "ContactDepartment": "",
      "NumAttachments": 882,
      "EmailHeader": "alessia.hansen@tromp.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "modi",
      "Sentiment": 395,
      "SentimentConfidence": 689,
      "CreatedBy": 981,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 602
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 533,
      "Name": "Schmitt-Kling",
      "ToolTip": "Sed dignissimos aut consequatur hic sapiente enim et.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 8
        }
      }
    },
    {
      "Id": 533,
      "Name": "Schmitt-Kling",
      "ToolTip": "Sed dignissimos aut consequatur hic sapiente enim et.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 8
        }
      }
    }
  ],
  "Language": "ea",
  "Sentiment": 839,
  "SentimentConfidence": 674,
  "SuggestedCategoryId": 234,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 841,
  "IconHint": "error",
  "ExtraFields": {
    "ExtraFields1": "eum",
    "ExtraFields2": "repellat"
  },
  "CustomFields": {
    "CustomFields1": "architecto",
    "CustomFields2": "quas"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 596
    }
  }
}
```