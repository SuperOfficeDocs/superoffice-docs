---
title: POST Agents/Ticket/GetNextInQueue
uid: v1TicketAgent_GetNextInQueue
generated: true
---

# POST Agents/Ticket/GetNextInQueue

```http
POST /api/v1/Agents/Ticket/GetNextInQueue
```

Assign a ticket to the caller based on intelligent queue system







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetNextInQueue?$select=name,department,category/id
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
| TimeSpent | int32 | The total time (minutes). Aggregated time spent from ticket&amp;apos;s messages. Read-only for external use. |
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
| Sale | Sale | The sale that this ticket is connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket is connected to  <para>Use MDO List name "project" to get list items.</para> |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| TicketType | TicketTypeEntity | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Ticket/GetNextInQueue
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 279,
  "Title": "et",
  "CreatedAt": "1998-12-23T13:38:14.2646807+01:00",
  "LastChanged": "2008-03-13T13:38:14.2646807+01:00",
  "ReadByOwner": "2006-10-01T13:38:14.2646807+02:00",
  "ReadByCustomer": "2018-09-28T13:38:14.2646807+02:00",
  "FirstReadByOwner": "1999-02-27T13:38:14.2646807+01:00",
  "FirstReadByUser": "2014-07-04T13:38:14.2646807+02:00",
  "Activate": "2016-04-24T13:38:14.2646807+02:00",
  "ClosedAt": "2008-12-17T13:38:14.2646807+01:00",
  "RepliedAt": "1999-07-21T13:38:14.2646807+02:00",
  "AlertTimeout": "2012-08-11T13:38:14.2646807+02:00",
  "Deadline": "1997-11-26T13:38:14.2646807+01:00",
  "CreatedBy": null,
  "Author": "veniam",
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
      "Position": "at",
      "PersonId": 406,
      "Mrmrs": "et",
      "Firstname": "Elisabeth",
      "Lastname": "Schuppe",
      "MiddleName": "Considine-Heidenreich",
      "Title": "earum",
      "Description": "Innovative bi-directional contingency",
      "Email": "gregoria@bins.us",
      "FullName": "Mrs. Selina Elenora Rau",
      "DirectPhone": "1-291-345-3687",
      "FormalName": "Herzog-Dach",
      "CountryId": 314,
      "ContactId": 112,
      "ContactName": "Block-Jacobi",
      "Retired": 143,
      "Rank": 233,
      "ActiveInterests": 774,
      "ContactDepartment": "",
      "ContactCountryId": 556,
      "ContactOrgNr": "1825949",
      "FaxPhone": "1-172-034-9980 x602",
      "MobilePhone": "(801)568-8686 x9372",
      "ContactPhone": "604.173.3466 x498",
      "AssociateName": "O'Connell-Moore",
      "AssociateId": 866,
      "UsePersonAddress": false,
      "ContactFax": "ut",
      "Kanafname": "adipisci",
      "Kanalname": "sunt",
      "Post1": "alias",
      "Post2": "suscipit",
      "Post3": "aut",
      "EmailName": "pasquale@lang.biz",
      "ContactFullName": "Ethan Doyle",
      "ActiveErpLinks": 596,
      "TicketPriorityId": 349,
      "SupportLanguageId": 904,
      "SupportAssociateId": 629,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 202
        }
      }
    }
  ],
  "AlertLevel": 553,
  "ConnectId": 179,
  "ReadStatus": "Green",
  "TimeToReply": 118,
  "RealTimeToReply": 273,
  "TimeToClose": 976,
  "RealTimeToClose": 45,
  "TimeSpentInternally": 465,
  "TimeSpentExternally": 183,
  "TimeSpentQueue": 207,
  "RealTimeSpentInternally": 683,
  "RealTimeSpentExternally": 337,
  "RealTimeSpentQueue": 289,
  "TimeSpent": 909,
  "HasAttachment": false,
  "NumReplies": 19,
  "NumMessages": 109,
  "FromAddress": "velit",
  "Messages": [
    {
      "TicketMessageId": 331,
      "CreatedAt": "1997-08-26T13:38:14.2646807+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "voluptas",
      "PersonId": 7,
      "PersonFullName": "Enola Kutch",
      "ContactId": 711,
      "ContactName": "Olson-Rutherford",
      "ContactDepartment": "",
      "NumAttachments": 996,
      "EmailHeader": "camron.klein@luettgen.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "magni",
      "Sentiment": 265,
      "SentimentConfidence": 175,
      "CreatedBy": 724,
      "ChangedAt": "2020-12-12T13:38:14.2646807+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 714
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 861,
      "Name": "Kertzmann LLC",
      "ToolTip": "Autem qui et vero quas qui.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 537
        }
      }
    },
    {
      "Id": 861,
      "Name": "Kertzmann LLC",
      "ToolTip": "Autem qui et vero quas qui.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 537
        }
      }
    }
  ],
  "Language": "ducimus",
  "Sentiment": 728,
  "SentimentConfidence": 825,
  "SuggestedCategoryId": 663,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 972,
  "IconHint": "quas",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "hic",
    "ExtraFields2": "nemo"
  },
  "CustomFields": {
    "CustomFields1": "nemo",
    "CustomFields2": "consequatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 197
    }
  }
}
```