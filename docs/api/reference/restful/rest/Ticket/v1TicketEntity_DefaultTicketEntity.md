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
GET /api/v1/Ticket/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 131,
  "Title": "maiores",
  "CreatedAt": "2022-06-09T02:49:51.551935+02:00",
  "LastChanged": "2003-01-03T02:49:51.551935+01:00",
  "ReadByOwner": "2017-06-05T02:49:51.551935+02:00",
  "ReadByCustomer": "2008-01-15T02:49:51.551935+01:00",
  "FirstReadByOwner": "2008-04-24T02:49:51.551935+02:00",
  "FirstReadByUser": "2011-08-04T02:49:51.551935+02:00",
  "Activate": "1998-11-28T02:49:51.551935+01:00",
  "ClosedAt": "2016-04-02T02:49:51.551935+02:00",
  "RepliedAt": "2022-07-14T02:49:51.551935+02:00",
  "AlertTimeout": "1995-12-07T02:49:51.551935+01:00",
  "Deadline": "1997-07-30T02:49:51.551935+02:00",
  "CreatedBy": null,
  "Author": "voluptas",
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
      "Position": "quam",
      "PersonId": 369,
      "Mrmrs": "sed",
      "Firstname": "Darrion",
      "Lastname": "Rath",
      "MiddleName": "Osinski, Jacobson and Hudson",
      "Title": "harum",
      "Description": "Phased regional local area network",
      "Email": "lila.kunze@terry.biz",
      "FullName": "Garrett Smith IV",
      "DirectPhone": "166-331-0918",
      "FormalName": "Turner Group",
      "CountryId": 331,
      "ContactId": 509,
      "ContactName": "Sawayn, Schumm and Halvorson",
      "Retired": 709,
      "Rank": 425,
      "ActiveInterests": 448,
      "ContactDepartment": "",
      "ContactCountryId": 547,
      "ContactOrgNr": "806640",
      "FaxPhone": "709-437-4430 x271",
      "MobilePhone": "(539)357-8027",
      "ContactPhone": "(024)448-2793 x73429",
      "AssociateName": "Steuber-Schmidt",
      "AssociateId": 373,
      "UsePersonAddress": false,
      "ContactFax": "maxime",
      "Kanafname": "in",
      "Kanalname": "aut",
      "Post1": "porro",
      "Post2": "voluptas",
      "Post3": "provident",
      "EmailName": "irving_auer@cruickshankmante.info",
      "ContactFullName": "Miss Robin Thompson",
      "ActiveErpLinks": 734,
      "TicketPriorityId": 276,
      "SupportLanguageId": 262,
      "SupportAssociateId": 245,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 718
        }
      }
    }
  ],
  "AlertLevel": 611,
  "ConnectId": 414,
  "ReadStatus": "Green",
  "TimeToReply": 291,
  "RealTimeToReply": 789,
  "TimeToClose": 308,
  "RealTimeToClose": 452,
  "TimeSpentInternally": 631,
  "TimeSpentExternally": 396,
  "TimeSpentQueue": 720,
  "RealTimeSpentInternally": 519,
  "RealTimeSpentExternally": 120,
  "RealTimeSpentQueue": 838,
  "HasAttachment": false,
  "NumReplies": 115,
  "NumMessages": 729,
  "FromAddress": "officia",
  "Messages": [
    {
      "TicketMessageId": 451,
      "CreatedAt": "2022-04-22T02:49:51.551935+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "et",
      "PersonId": 294,
      "PersonFullName": "Eulah Kunde",
      "ContactId": 538,
      "ContactName": "Ryan, Hoppe and Schinner",
      "ContactDepartment": "",
      "NumAttachments": 573,
      "EmailHeader": "kyle_cremin@aufderhar.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "fugiat",
      "Sentiment": 76,
      "SentimentConfidence": 143,
      "CreatedBy": 16,
      "ChangedAt": "2007-05-23T02:49:51.5675591+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 680
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 274,
      "Name": "Yundt-Kohler",
      "ToolTip": "Animi consequatur dolore voluptas minima illo.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 379
        }
      }
    },
    {
      "Id": 274,
      "Name": "Yundt-Kohler",
      "ToolTip": "Animi consequatur dolore voluptas minima illo.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 379
        }
      }
    }
  ],
  "Language": "vitae",
  "Sentiment": 378,
  "SentimentConfidence": 757,
  "SuggestedCategoryId": 570,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 537,
  "IconHint": "cumque",
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "libero"
  },
  "CustomFields": {
    "CustomFields1": "in",
    "CustomFields2": "assumenda"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 207
    }
  }
}
```