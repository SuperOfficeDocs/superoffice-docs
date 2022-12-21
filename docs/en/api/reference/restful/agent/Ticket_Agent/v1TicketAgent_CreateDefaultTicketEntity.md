---
title: POST Agents/Ticket/CreateDefaultTicketEntity
uid: v1TicketAgent_CreateDefaultTicketEntity
---

# POST Agents/Ticket/CreateDefaultTicketEntity

```http
POST /api/v1/Agents/Ticket/CreateDefaultTicketEntity
```

Set default values into a new TicketEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
| FirstReadByOwner | date-time | The datetime for when the ticket first was read by the current owner. |
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
POST /api/v1/Agents/Ticket/CreateDefaultTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 618,
  "Title": "delectus",
  "CreatedAt": "2020-09-29T02:49:45.4528435+02:00",
  "LastChanged": "2021-12-15T02:49:45.4528435+01:00",
  "ReadByOwner": "2012-10-20T02:49:45.4528435+02:00",
  "ReadByCustomer": "2014-04-25T02:49:45.4528435+02:00",
  "FirstReadByOwner": "2000-07-29T02:49:45.4528435+02:00",
  "FirstReadByUser": "2003-02-09T02:49:45.4528435+01:00",
  "Activate": "1996-02-15T02:49:45.4528435+01:00",
  "ClosedAt": "2017-05-18T02:49:45.4528435+02:00",
  "RepliedAt": "2016-09-24T02:49:45.4528435+02:00",
  "AlertTimeout": "2016-06-11T02:49:45.4528435+02:00",
  "Deadline": "2005-01-10T02:49:45.4528435+01:00",
  "CreatedBy": null,
  "Author": "atque",
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
      "Position": "non",
      "PersonId": 726,
      "Mrmrs": "in",
      "Firstname": "Berenice",
      "Lastname": "Klocko",
      "MiddleName": "Morissette, Altenwerth and Aufderhar",
      "Title": "recusandae",
      "Description": "Reverse-engineered next generation flexibility",
      "Email": "wyatt@schumm.biz",
      "FullName": "Mr. Eulah Koss",
      "DirectPhone": "512.245.0474 x97145",
      "FormalName": "Jacobs Inc and Sons",
      "CountryId": 797,
      "ContactId": 634,
      "ContactName": "O'Connell, Rolfson and Gaylord",
      "Retired": 90,
      "Rank": 357,
      "ActiveInterests": 466,
      "ContactDepartment": "",
      "ContactCountryId": 804,
      "ContactOrgNr": "883947",
      "FaxPhone": "(984)788-8310 x80249",
      "MobilePhone": "647-758-8564 x864",
      "ContactPhone": "594.219.9366 x222",
      "AssociateName": "Abernathy LLC",
      "AssociateId": 24,
      "UsePersonAddress": true,
      "ContactFax": "a",
      "Kanafname": "culpa",
      "Kanalname": "illo",
      "Post1": "nihil",
      "Post2": "blanditiis",
      "Post3": "minus",
      "EmailName": "dora_considine@oberbrunner.uk",
      "ContactFullName": "Tania Baumbach",
      "ActiveErpLinks": 931,
      "TicketPriorityId": 341,
      "SupportLanguageId": 323,
      "SupportAssociateId": 756,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 535
        }
      }
    }
  ],
  "AlertLevel": 553,
  "ConnectId": 4,
  "ReadStatus": "Green",
  "TimeToReply": 76,
  "RealTimeToReply": 746,
  "TimeToClose": 14,
  "RealTimeToClose": 70,
  "TimeSpentInternally": 658,
  "TimeSpentExternally": 912,
  "TimeSpentQueue": 911,
  "RealTimeSpentInternally": 754,
  "RealTimeSpentExternally": 249,
  "RealTimeSpentQueue": 28,
  "HasAttachment": false,
  "NumReplies": 647,
  "NumMessages": 951,
  "FromAddress": "autem",
  "Messages": [
    {
      "TicketMessageId": 404,
      "CreatedAt": "2013-01-28T02:49:45.4684728+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "sed",
      "PersonId": 612,
      "PersonFullName": "Mrs. Meda Ericka Lueilwitz",
      "ContactId": 872,
      "ContactName": "Beier, O'Connell and Morar",
      "ContactDepartment": "",
      "NumAttachments": 251,
      "EmailHeader": "torrance@von.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "totam",
      "Sentiment": 522,
      "SentimentConfidence": 198,
      "CreatedBy": 225,
      "ChangedAt": "2008-12-13T02:49:45.4684728+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 235
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 707,
      "Name": "Pagac Group",
      "ToolTip": "Aut aut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 155
        }
      }
    },
    {
      "Id": 707,
      "Name": "Pagac Group",
      "ToolTip": "Aut aut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 155
        }
      }
    }
  ],
  "Language": "officia",
  "Sentiment": 373,
  "SentimentConfidence": 506,
  "SuggestedCategoryId": 230,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 368,
  "IconHint": "expedita",
  "ExtraFields": {
    "ExtraFields1": "quod",
    "ExtraFields2": "dolorem"
  },
  "CustomFields": {
    "CustomFields1": "quod",
    "CustomFields2": "quasi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 619
    }
  }
}
```