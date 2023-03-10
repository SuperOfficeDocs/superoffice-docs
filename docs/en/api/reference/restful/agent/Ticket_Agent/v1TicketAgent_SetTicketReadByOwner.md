---
title: POST Agents/Ticket/SetTicketReadByOwner
uid: v1TicketAgent_SetTicketReadByOwner
---

# POST Agents/Ticket/SetTicketReadByOwner

```http
POST /api/v1/Agents/Ticket/SetTicketReadByOwner
```

Set the ReadByOwner status for a ticket.


It will only have an effect if the calling user is the same as the owner of the ticket






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/SetTicketReadByOwner?$select=name,department,category/id
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

TicketEntityId, ReadStatus, CheckEscalating 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketEntityId | Integer |  |
| ReadStatus | String |  |
| CheckEscalating | Boolean |  |

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
POST /api/v1/Agents/Ticket/SetTicketReadByOwner
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 77,
  "ReadStatus": "Green",
  "CheckEscalating": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 172,
  "Title": "nihil",
  "CreatedAt": "2022-09-05T12:15:20.353735+02:00",
  "LastChanged": "2016-06-19T12:15:20.353735+02:00",
  "ReadByOwner": "2022-09-07T12:15:20.353735+02:00",
  "ReadByCustomer": "2013-09-27T12:15:20.353735+02:00",
  "FirstReadByOwner": "2018-10-15T12:15:20.353735+02:00",
  "FirstReadByUser": "1997-05-05T12:15:20.353735+02:00",
  "Activate": "1997-02-22T12:15:20.353735+01:00",
  "ClosedAt": "2020-12-07T12:15:20.353735+01:00",
  "RepliedAt": "2011-04-09T12:15:20.353735+02:00",
  "AlertTimeout": "2001-05-02T12:15:20.353735+02:00",
  "Deadline": "2007-11-17T12:15:20.353735+01:00",
  "CreatedBy": null,
  "Author": "perspiciatis",
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
      "Position": "quidem",
      "PersonId": 619,
      "Mrmrs": "enim",
      "Firstname": "Terrell",
      "Lastname": "Hessel",
      "MiddleName": "Thiel LLC",
      "Title": "dolorem",
      "Description": "Realigned web-enabled orchestration",
      "Email": "marietta@tillman.uk",
      "FullName": "Tristian Kilback",
      "DirectPhone": "1-931-397-2567 x6104",
      "FormalName": "Volkman LLC",
      "CountryId": 1000,
      "ContactId": 426,
      "ContactName": "McLaughlin-Waters",
      "Retired": 394,
      "Rank": 844,
      "ActiveInterests": 576,
      "ContactDepartment": "",
      "ContactCountryId": 154,
      "ContactOrgNr": "522517",
      "FaxPhone": "(479)920-7694 x79020",
      "MobilePhone": "218.743.2650 x240",
      "ContactPhone": "151-080-2161 x07822",
      "AssociateName": "Trantow, Denesik and Prosacco",
      "AssociateId": 598,
      "UsePersonAddress": false,
      "ContactFax": "soluta",
      "Kanafname": "maxime",
      "Kanalname": "veritatis",
      "Post1": "cupiditate",
      "Post2": "nesciunt",
      "Post3": "rerum",
      "EmailName": "charlie_brekke@pouros.info",
      "ContactFullName": "Camren Haley",
      "ActiveErpLinks": 85,
      "TicketPriorityId": 833,
      "SupportLanguageId": 163,
      "SupportAssociateId": 522,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 885
        }
      }
    }
  ],
  "AlertLevel": 591,
  "ConnectId": 322,
  "ReadStatus": "Green",
  "TimeToReply": 559,
  "RealTimeToReply": 28,
  "TimeToClose": 151,
  "RealTimeToClose": 599,
  "TimeSpentInternally": 698,
  "TimeSpentExternally": 788,
  "TimeSpentQueue": 931,
  "RealTimeSpentInternally": 432,
  "RealTimeSpentExternally": 505,
  "RealTimeSpentQueue": 396,
  "HasAttachment": true,
  "NumReplies": 446,
  "NumMessages": 38,
  "FromAddress": "qui",
  "Messages": [
    {
      "TicketMessageId": 363,
      "CreatedAt": "2003-05-03T12:15:20.3577318+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "odit",
      "PersonId": 748,
      "PersonFullName": "Roma Kihn",
      "ContactId": 742,
      "ContactName": "Beer Group",
      "ContactDepartment": "",
      "NumAttachments": 16,
      "EmailHeader": "jarret_ryan@windlerbruen.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "error",
      "Sentiment": 364,
      "SentimentConfidence": 952,
      "CreatedBy": 943,
      "ChangedAt": "2000-05-17T12:15:20.3587313+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 994
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 392,
      "Name": "Wehner, Haley and Eichmann",
      "ToolTip": "Consequatur dicta doloribus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 954
        }
      }
    },
    {
      "Id": 392,
      "Name": "Wehner, Haley and Eichmann",
      "ToolTip": "Consequatur dicta doloribus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 954
        }
      }
    }
  ],
  "Language": "adipisci",
  "Sentiment": 965,
  "SentimentConfidence": 807,
  "SuggestedCategoryId": 63,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 480,
  "IconHint": "reprehenderit",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "nostrum",
    "ExtraFields2": "nostrum"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "reiciendis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 202
    }
  }
}
```