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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Ticket/GetForRmUi
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 814
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 815,
  "Title": "eligendi",
  "CreatedAt": "1997-12-06T14:19:04.4234506+01:00",
  "LastChanged": "2014-08-27T14:19:04.4234506+02:00",
  "ReadByOwner": "1997-07-05T14:19:04.4234506+02:00",
  "ReadByCustomer": "2018-01-29T14:19:04.4234506+01:00",
  "FirstReadByOwner": "2016-02-01T14:19:04.4234506+01:00",
  "FirstReadByUser": "2019-05-22T14:19:04.4234506+02:00",
  "Activate": "1998-10-29T14:19:04.4234506+01:00",
  "ClosedAt": "1999-06-04T14:19:04.4234506+02:00",
  "RepliedAt": "2022-02-01T14:19:04.4234506+01:00",
  "AlertTimeout": "2000-09-07T14:19:04.4234506+02:00",
  "Deadline": "1996-11-06T14:19:04.4234506+01:00",
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
      "Position": "provident",
      "PersonId": 172,
      "Mrmrs": "quia",
      "Firstname": "Aglae",
      "Lastname": "King",
      "MiddleName": "Davis Group",
      "Title": "ducimus",
      "Description": "Re-contextualized radical framework",
      "Email": "moshe_abshire@rice.co.uk",
      "FullName": "Trevion Will III",
      "DirectPhone": "116.056.3051",
      "FormalName": "Rice, Hudson and Larkin",
      "CountryId": 118,
      "ContactId": 308,
      "ContactName": "Ruecker, Gorczany and Grady",
      "Retired": 942,
      "Rank": 382,
      "ActiveInterests": 932,
      "ContactDepartment": "",
      "ContactCountryId": 746,
      "ContactOrgNr": "648137",
      "FaxPhone": "1-571-435-6093",
      "MobilePhone": "1-287-029-9273 x312",
      "ContactPhone": "1-217-013-8560 x558",
      "AssociateName": "Schinner, Murazik and Thiel",
      "AssociateId": 327,
      "UsePersonAddress": false,
      "ContactFax": "ut",
      "Kanafname": "nobis",
      "Kanalname": "pariatur",
      "Post1": "non",
      "Post2": "nemo",
      "Post3": "officia",
      "EmailName": "angie@dach.name",
      "ContactFullName": "Adrienne Stroman",
      "ActiveErpLinks": 240,
      "TicketPriorityId": 358,
      "SupportLanguageId": 551,
      "SupportAssociateId": 208,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 458
        }
      }
    }
  ],
  "AlertLevel": 454,
  "ConnectId": 537,
  "ReadStatus": "Green",
  "TimeToReply": 567,
  "RealTimeToReply": 889,
  "TimeToClose": 505,
  "RealTimeToClose": 414,
  "TimeSpentInternally": 709,
  "TimeSpentExternally": 13,
  "TimeSpentQueue": 932,
  "RealTimeSpentInternally": 515,
  "RealTimeSpentExternally": 885,
  "RealTimeSpentQueue": 798,
  "HasAttachment": false,
  "NumReplies": 636,
  "NumMessages": 282,
  "FromAddress": "dolorum",
  "Messages": [
    {
      "TicketMessageId": 36,
      "CreatedAt": "2018-04-04T14:19:04.4234506+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "excepturi",
      "PersonId": 423,
      "PersonFullName": "Angeline Wuckert",
      "ContactId": 515,
      "ContactName": "Morissette Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 451,
      "EmailHeader": "celia@frami.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ex",
      "Sentiment": 119,
      "SentimentConfidence": 74,
      "CreatedBy": 592,
      "ChangedAt": "2007-01-15T14:19:04.4234506+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 695
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 92,
      "Name": "O'Connell-Doyle",
      "ToolTip": "Dolor velit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 83
        }
      }
    },
    {
      "Id": 92,
      "Name": "O'Connell-Doyle",
      "ToolTip": "Dolor velit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 83
        }
      }
    }
  ],
  "Language": "cum",
  "Sentiment": 36,
  "SentimentConfidence": 131,
  "SuggestedCategoryId": 429,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 687,
  "IconHint": "voluptas",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "exercitationem"
  },
  "CustomFields": {
    "CustomFields1": "eaque",
    "CustomFields2": "pariatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 845
    }
  }
}
```