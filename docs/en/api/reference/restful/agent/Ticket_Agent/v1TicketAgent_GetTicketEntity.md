---
title: POST Agents/Ticket/GetTicketEntity
uid: v1TicketAgent_GetTicketEntity
generated: true
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
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=118
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
POST /api/v1/Agents/Ticket/GetTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 600,
  "Title": "consequatur",
  "CreatedAt": "2011-05-08T13:57:13.3489691+02:00",
  "LastChanged": "2015-10-15T13:57:13.3489691+02:00",
  "ReadByOwner": "2013-07-27T13:57:13.3489691+02:00",
  "ReadByCustomer": "1998-05-30T13:57:13.3489691+02:00",
  "FirstReadByOwner": "2015-11-12T13:57:13.3489691+01:00",
  "FirstReadByUser": "2005-03-06T13:57:13.3489691+01:00",
  "Activate": "2021-04-27T13:57:13.3489691+02:00",
  "ClosedAt": "2006-09-20T13:57:13.3489691+02:00",
  "RepliedAt": "2012-03-10T13:57:13.3489691+01:00",
  "AlertTimeout": "2011-02-19T13:57:13.3489691+01:00",
  "Deadline": "2017-08-07T13:57:13.3489691+02:00",
  "CreatedBy": null,
  "Author": "ullam",
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
      "PersonId": 513,
      "Mrmrs": "neque",
      "Firstname": "Lucio",
      "Lastname": "Williamson",
      "MiddleName": "Weber LLC",
      "Title": "esse",
      "Description": "Self-enabling object-oriented hardware",
      "Email": "dariana_wintheiser@marvin.com",
      "FullName": "Jana Littel",
      "DirectPhone": "787.547.9282 x511",
      "FormalName": "Rolfson, Waelchi and Bernhard",
      "CountryId": 219,
      "ContactId": 785,
      "ContactName": "Beer, Ernser and Hane",
      "Retired": 649,
      "Rank": 77,
      "ActiveInterests": 737,
      "ContactDepartment": "",
      "ContactCountryId": 239,
      "ContactOrgNr": "1180815",
      "FaxPhone": "(934)073-6696",
      "MobilePhone": "1-420-713-3812 x4415",
      "ContactPhone": "(290)659-3658",
      "AssociateName": "Kiehn, Rice and Herman",
      "AssociateId": 536,
      "UsePersonAddress": false,
      "ContactFax": "minus",
      "Kanafname": "sunt",
      "Kanalname": "vel",
      "Post1": "tempora",
      "Post2": "alias",
      "Post3": "sint",
      "EmailName": "jadon@kerluke.name",
      "ContactFullName": "Hosea Barney Schmitt V",
      "ActiveErpLinks": 830,
      "TicketPriorityId": 350,
      "SupportLanguageId": 192,
      "SupportAssociateId": 634,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 588
        }
      }
    }
  ],
  "AlertLevel": 321,
  "ConnectId": 61,
  "ReadStatus": "Green",
  "TimeToReply": 568,
  "RealTimeToReply": 968,
  "TimeToClose": 555,
  "RealTimeToClose": 736,
  "TimeSpentInternally": 26,
  "TimeSpentExternally": 543,
  "TimeSpentQueue": 961,
  "RealTimeSpentInternally": 455,
  "RealTimeSpentExternally": 515,
  "RealTimeSpentQueue": 306,
  "TimeSpent": 993,
  "HasAttachment": false,
  "NumReplies": 719,
  "NumMessages": 90,
  "FromAddress": "et",
  "Messages": [
    {
      "TicketMessageId": 517,
      "CreatedAt": "2004-05-27T13:57:13.3489691+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "in",
      "PersonId": 369,
      "PersonFullName": "Darron Klein",
      "ContactId": 233,
      "ContactName": "Rath, Goldner and Schmeler",
      "ContactDepartment": "",
      "NumAttachments": 681,
      "EmailHeader": "eli@lockman.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ipsum",
      "Sentiment": 906,
      "SentimentConfidence": 108,
      "CreatedBy": 838,
      "ChangedAt": "2019-10-27T13:57:13.3489691+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 250
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 189,
      "Name": "Tillman, Gleichner and Rowe",
      "ToolTip": "Aliquam velit aut fuga quo.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 221
        }
      }
    },
    {
      "Id": 189,
      "Name": "Tillman, Gleichner and Rowe",
      "ToolTip": "Aliquam velit aut fuga quo.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 221
        }
      }
    }
  ],
  "Language": "velit",
  "Sentiment": 152,
  "SentimentConfidence": 530,
  "SuggestedCategoryId": 287,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 580,
  "IconHint": "similique",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "temporibus",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "fugiat",
    "CustomFields2": "consequatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 54
    }
  }
}
```