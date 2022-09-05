---
title: GET Ticket/default
uid: v1TicketEntity_DefaultTicketEntity
---

# GET Ticket/default

```http
GET /api/v1/Ticket/default
```

Set default values into a new TicketEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Ticket agent service CreateDefaultTicketEntity.







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
GET /api/v1/Ticket/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 740,
  "Title": "tenetur",
  "CreatedAt": "2012-04-03T11:10:53.5431448+02:00",
  "LastChanged": "1995-05-12T11:10:53.5431448+02:00",
  "ReadByOwner": "2017-04-21T11:10:53.5431448+02:00",
  "ReadByCustomer": "2008-02-29T11:10:53.5431448+01:00",
  "FirstReadByUser": "2016-01-12T11:10:53.5431448+01:00",
  "Activate": "2012-08-18T11:10:53.5431448+02:00",
  "ClosedAt": "2000-01-18T11:10:53.5431448+01:00",
  "RepliedAt": "2017-04-29T11:10:53.5431448+02:00",
  "AlertTimeout": "2002-04-03T11:10:53.5431448+02:00",
  "Deadline": "2001-01-07T11:10:53.5431448+01:00",
  "CreatedBy": null,
  "Author": "sint",
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
      "PersonId": 119,
      "Mrmrs": "rerum",
      "Firstname": "Evans",
      "Lastname": "Crona",
      "MiddleName": "Mayert Inc and Sons",
      "Title": "ut",
      "Description": "Cross-group system-worthy migration",
      "Email": "colton@white.biz",
      "FullName": "Prof. Maye Rolfson Sr.",
      "DirectPhone": "1-800-762-0980",
      "FormalName": "Runolfsdottir Group",
      "CountryId": 57,
      "ContactId": 3,
      "ContactName": "McCullough Inc and Sons",
      "Retired": 961,
      "Rank": 768,
      "ActiveInterests": 617,
      "ContactDepartment": "",
      "ContactCountryId": 663,
      "ContactOrgNr": "745163",
      "FaxPhone": "1-319-466-1972",
      "MobilePhone": "1-942-932-0196 x65187",
      "ContactPhone": "(120)419-7787",
      "AssociateName": "Braun-DuBuque",
      "AssociateId": 128,
      "UsePersonAddress": false,
      "ContactFax": "sit",
      "Kanafname": "maxime",
      "Kanalname": "ipsum",
      "Post1": "voluptates",
      "Post2": "id",
      "Post3": "quia",
      "EmailName": "gavin_morar@vandervort.us",
      "ContactFullName": "Faustino Watsica",
      "ActiveErpLinks": 1002,
      "TicketPriorityId": 184,
      "SupportLanguageId": 159,
      "SupportAssociateId": 671,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 164
        }
      }
    }
  ],
  "AlertLevel": 660,
  "ConnectId": 905,
  "ReadStatus": "Green",
  "TimeToReply": 376,
  "RealTimeToReply": 840,
  "TimeToClose": 39,
  "RealTimeToClose": 155,
  "TimeSpentInternally": 449,
  "TimeSpentExternally": 720,
  "TimeSpentQueue": 558,
  "RealTimeSpentInternally": 342,
  "RealTimeSpentExternally": 928,
  "RealTimeSpentQueue": 143,
  "HasAttachment": false,
  "NumReplies": 512,
  "NumMessages": 701,
  "FromAddress": "optio",
  "Messages": [
    {
      "TicketMessageId": 254,
      "CreatedAt": "2003-08-30T11:10:53.5481822+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "laboriosam",
      "PersonId": 9,
      "PersonFullName": "Fausto Sauer",
      "ContactId": 571,
      "ContactName": "Windler Group",
      "ContactDepartment": "",
      "NumAttachments": 525,
      "EmailHeader": "meaghan.west@braun.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "provident",
      "Sentiment": 318,
      "SentimentConfidence": 434,
      "CreatedBy": 512,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 78
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 336,
      "Name": "Boehm, Yundt and Runolfsson",
      "ToolTip": "Ipsam ut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 327
        }
      }
    },
    {
      "Id": 336,
      "Name": "Boehm, Yundt and Runolfsson",
      "ToolTip": "Ipsam ut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 327
        }
      }
    }
  ],
  "Language": "et",
  "Sentiment": 354,
  "SentimentConfidence": 507,
  "SuggestedCategoryId": 715,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 383,
  "IconHint": "eaque",
  "ExtraFields": {
    "ExtraFields1": "atque",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "nulla",
    "CustomFields2": "itaque"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 462
    }
  }
}
```