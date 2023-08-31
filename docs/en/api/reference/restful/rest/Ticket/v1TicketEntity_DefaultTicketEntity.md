---
title: GET Ticket/default
uid: v1TicketEntity_DefaultTicketEntity
generated: true
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
  "TicketId": 996,
  "Title": "id",
  "CreatedAt": "1999-11-02T03:31:32.9594383+01:00",
  "LastChanged": "2016-04-03T03:31:32.9594383+02:00",
  "ReadByOwner": "2007-11-18T03:31:32.9594383+01:00",
  "ReadByCustomer": "2012-10-26T03:31:32.9594383+02:00",
  "FirstReadByOwner": "2007-05-11T03:31:32.9594383+02:00",
  "FirstReadByUser": "2004-11-12T03:31:32.9594383+01:00",
  "Activate": "1998-08-21T03:31:32.9594383+02:00",
  "ClosedAt": "2006-06-21T03:31:32.9594383+02:00",
  "RepliedAt": "2009-12-27T03:31:32.9594383+01:00",
  "AlertTimeout": "2019-05-20T03:31:32.9594383+02:00",
  "Deadline": "2009-12-14T03:31:32.9594383+01:00",
  "CreatedBy": null,
  "Author": "error",
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
      "Position": "sed",
      "PersonId": 338,
      "Mrmrs": "ut",
      "Firstname": "Lorenz",
      "Lastname": "Cartwright",
      "MiddleName": "Kirlin, Howe and Lebsack",
      "Title": "sit",
      "Description": "Switchable analyzing capacity",
      "Email": "rae_jaskolski@bashirian.com",
      "FullName": "Juliana Hillard West DVM",
      "DirectPhone": "(580)944-5166",
      "FormalName": "Ruecker Group",
      "CountryId": 586,
      "ContactId": 152,
      "ContactName": "Morar Group",
      "Retired": 339,
      "Rank": 930,
      "ActiveInterests": 186,
      "ContactDepartment": "",
      "ContactCountryId": 849,
      "ContactOrgNr": "1208131",
      "FaxPhone": "479-256-2792 x3723",
      "MobilePhone": "(841)616-2316 x6588",
      "ContactPhone": "1-553-772-0329 x3580",
      "AssociateName": "Waters-Daniel",
      "AssociateId": 828,
      "UsePersonAddress": false,
      "ContactFax": "voluptas",
      "Kanafname": "ab",
      "Kanalname": "est",
      "Post1": "sequi",
      "Post2": "quis",
      "Post3": "qui",
      "EmailName": "macie.hansen@vandervort.biz",
      "ContactFullName": "Prof. Ima Judah Herman",
      "ActiveErpLinks": 17,
      "TicketPriorityId": 809,
      "SupportLanguageId": 673,
      "SupportAssociateId": 258,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 841
        }
      }
    }
  ],
  "AlertLevel": 896,
  "ConnectId": 52,
  "ReadStatus": "Green",
  "TimeToReply": 303,
  "RealTimeToReply": 330,
  "TimeToClose": 628,
  "RealTimeToClose": 574,
  "TimeSpentInternally": 91,
  "TimeSpentExternally": 47,
  "TimeSpentQueue": 536,
  "RealTimeSpentInternally": 49,
  "RealTimeSpentExternally": 113,
  "RealTimeSpentQueue": 47,
  "HasAttachment": true,
  "NumReplies": 674,
  "NumMessages": 151,
  "FromAddress": "dicta",
  "Messages": [
    {
      "TicketMessageId": 915,
      "CreatedAt": "1999-08-29T03:31:32.9750561+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "veniam",
      "PersonId": 319,
      "PersonFullName": "Miss Glen Kautzer",
      "ContactId": 682,
      "ContactName": "Konopelski-Rau",
      "ContactDepartment": "",
      "NumAttachments": 780,
      "EmailHeader": "elmore_mertz@mccullough.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "qui",
      "Sentiment": 494,
      "SentimentConfidence": 99,
      "CreatedBy": 803,
      "ChangedAt": "2003-04-08T03:31:32.9750561+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 507
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 272,
      "Name": "Schinner Group",
      "ToolTip": "Ea fuga.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 186
        }
      }
    },
    {
      "Id": 272,
      "Name": "Schinner Group",
      "ToolTip": "Ea fuga.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 186
        }
      }
    }
  ],
  "Language": "sit",
  "Sentiment": 141,
  "SentimentConfidence": 785,
  "SuggestedCategoryId": 937,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 350,
  "IconHint": "libero",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "consequuntur",
    "ExtraFields2": "quis"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "quo"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 927
    }
  }
}
```