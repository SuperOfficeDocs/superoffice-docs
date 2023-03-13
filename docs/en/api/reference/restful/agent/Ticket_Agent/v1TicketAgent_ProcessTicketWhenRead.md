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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Ticket/ProcessTicketWhenRead
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 697
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 210,
  "Title": "id",
  "CreatedAt": "2015-10-19T12:15:20.3977336+02:00",
  "LastChanged": "2012-10-14T12:15:20.3977336+02:00",
  "ReadByOwner": "2008-05-03T12:15:20.3977336+02:00",
  "ReadByCustomer": "2014-05-15T12:15:20.3977336+02:00",
  "FirstReadByOwner": "2016-07-08T12:15:20.3977336+02:00",
  "FirstReadByUser": "2008-12-27T12:15:20.3977336+01:00",
  "Activate": "2010-07-18T12:15:20.3977336+02:00",
  "ClosedAt": "2012-12-02T12:15:20.3977336+01:00",
  "RepliedAt": "2022-05-28T12:15:20.3977336+02:00",
  "AlertTimeout": "2009-04-05T12:15:20.3977336+02:00",
  "Deadline": "2012-02-23T12:15:20.3977336+01:00",
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
      "Position": "ut",
      "PersonId": 133,
      "Mrmrs": "voluptatem",
      "Firstname": "Breana",
      "Lastname": "Kutch",
      "MiddleName": "Kris-Wunsch",
      "Title": "et",
      "Description": "Multi-channelled solution-oriented circuit",
      "Email": "jett@manndare.com",
      "FullName": "Mrs. Allison Trey Hoeger DDS",
      "DirectPhone": "718.673.4551 x0207",
      "FormalName": "Baumbach, Lynch and Anderson",
      "CountryId": 391,
      "ContactId": 95,
      "ContactName": "Parker Group",
      "Retired": 979,
      "Rank": 729,
      "ActiveInterests": 283,
      "ContactDepartment": "",
      "ContactCountryId": 226,
      "ContactOrgNr": "1176227",
      "FaxPhone": "(746)924-7685 x953",
      "MobilePhone": "(344)548-0026",
      "ContactPhone": "(256)968-8530",
      "AssociateName": "McKenzie-Nitzsche",
      "AssociateId": 102,
      "UsePersonAddress": false,
      "ContactFax": "ea",
      "Kanafname": "qui",
      "Kanalname": "quo",
      "Post1": "est",
      "Post2": "et",
      "Post3": "assumenda",
      "EmailName": "trenton@bradtke.biz",
      "ContactFullName": "Adelbert Gerhold",
      "ActiveErpLinks": 452,
      "TicketPriorityId": 987,
      "SupportLanguageId": 620,
      "SupportAssociateId": 412,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 343
        }
      }
    }
  ],
  "AlertLevel": 237,
  "ConnectId": 220,
  "ReadStatus": "Green",
  "TimeToReply": 666,
  "RealTimeToReply": 840,
  "TimeToClose": 923,
  "RealTimeToClose": 711,
  "TimeSpentInternally": 113,
  "TimeSpentExternally": 327,
  "TimeSpentQueue": 974,
  "RealTimeSpentInternally": 5,
  "RealTimeSpentExternally": 8,
  "RealTimeSpentQueue": 678,
  "HasAttachment": false,
  "NumReplies": 307,
  "NumMessages": 164,
  "FromAddress": "suscipit",
  "Messages": [
    {
      "TicketMessageId": 175,
      "CreatedAt": "2001-01-25T12:15:20.4017338+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "temporibus",
      "PersonId": 225,
      "PersonFullName": "Ms. Tiffany Tremblay",
      "ContactId": 121,
      "ContactName": "Keeling-Skiles",
      "ContactDepartment": "",
      "NumAttachments": 947,
      "EmailHeader": "zoila.heller@dickens.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "aut",
      "Sentiment": 918,
      "SentimentConfidence": 829,
      "CreatedBy": 856,
      "ChangedAt": "2006-05-15T12:15:20.402731+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 271
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 68,
      "Name": "Hane Group",
      "ToolTip": "Cupiditate dolor est alias qui.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 519
        }
      }
    },
    {
      "Id": 68,
      "Name": "Hane Group",
      "ToolTip": "Cupiditate dolor est alias qui.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 519
        }
      }
    }
  ],
  "Language": "ducimus",
  "Sentiment": 904,
  "SentimentConfidence": 480,
  "SuggestedCategoryId": 105,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 401,
  "IconHint": "sed",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "sint",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "accusamus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 684
    }
  }
}
```