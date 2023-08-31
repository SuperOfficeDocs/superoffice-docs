---
title: POST Agents/Ticket/CreateDefaultTicketEntity
uid: v1TicketAgent_CreateDefaultTicketEntity
generated: true
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
  "TicketId": 89,
  "Title": "neque",
  "CreatedAt": "2019-01-08T03:31:27.3405474+01:00",
  "LastChanged": "2009-02-20T03:31:27.3405474+01:00",
  "ReadByOwner": "2013-09-21T03:31:27.3405474+02:00",
  "ReadByCustomer": "2012-03-22T03:31:27.3405474+01:00",
  "FirstReadByOwner": "2018-11-20T03:31:27.3405474+01:00",
  "FirstReadByUser": "2002-10-10T03:31:27.3405474+02:00",
  "Activate": "2002-03-27T03:31:27.3405474+01:00",
  "ClosedAt": "1998-08-19T03:31:27.3405474+02:00",
  "RepliedAt": "2022-12-08T03:31:27.3405474+01:00",
  "AlertTimeout": "1999-02-16T03:31:27.3405474+01:00",
  "Deadline": "2018-09-07T03:31:27.3405474+02:00",
  "CreatedBy": null,
  "Author": "quasi",
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
      "Position": "fuga",
      "PersonId": 941,
      "Mrmrs": "et",
      "Firstname": "Candida",
      "Lastname": "Hintz",
      "MiddleName": "Bailey-Haag",
      "Title": "non",
      "Description": "Reduced empowering matrix",
      "Email": "jairo_auer@hudsonkovacek.info",
      "FullName": "Issac Ratke",
      "DirectPhone": "1-302-558-7466",
      "FormalName": "Padberg, Wintheiser and Kessler",
      "CountryId": 962,
      "ContactId": 633,
      "ContactName": "Lakin, White and Christiansen",
      "Retired": 281,
      "Rank": 168,
      "ActiveInterests": 571,
      "ContactDepartment": "",
      "ContactCountryId": 657,
      "ContactOrgNr": "1869591",
      "FaxPhone": "524-183-7971",
      "MobilePhone": "(095)692-5178 x38484",
      "ContactPhone": "(299)999-0989",
      "AssociateName": "Schowalter-Wiza",
      "AssociateId": 855,
      "UsePersonAddress": false,
      "ContactFax": "ut",
      "Kanafname": "velit",
      "Kanalname": "nesciunt",
      "Post1": "magnam",
      "Post2": "earum",
      "Post3": "inventore",
      "EmailName": "henry@macejkovichowell.biz",
      "ContactFullName": "Forrest McLaughlin",
      "ActiveErpLinks": 230,
      "TicketPriorityId": 297,
      "SupportLanguageId": 375,
      "SupportAssociateId": 312,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 861
        }
      }
    }
  ],
  "AlertLevel": 100,
  "ConnectId": 945,
  "ReadStatus": "Green",
  "TimeToReply": 594,
  "RealTimeToReply": 734,
  "TimeToClose": 355,
  "RealTimeToClose": 660,
  "TimeSpentInternally": 954,
  "TimeSpentExternally": 176,
  "TimeSpentQueue": 191,
  "RealTimeSpentInternally": 574,
  "RealTimeSpentExternally": 697,
  "RealTimeSpentQueue": 665,
  "HasAttachment": true,
  "NumReplies": 86,
  "NumMessages": 21,
  "FromAddress": "est",
  "Messages": [
    {
      "TicketMessageId": 258,
      "CreatedAt": "2022-07-22T03:31:27.3405474+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "animi",
      "PersonId": 875,
      "PersonFullName": "Deanna Grimes",
      "ContactId": 428,
      "ContactName": "Casper-Vandervort",
      "ContactDepartment": "",
      "NumAttachments": 300,
      "EmailHeader": "tevin@dooleylindgren.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "nihil",
      "Sentiment": 114,
      "SentimentConfidence": 257,
      "CreatedBy": 741,
      "ChangedAt": "1998-03-31T03:31:27.3405474+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 362
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 747,
      "Name": "Wilderman-Rogahn",
      "ToolTip": "Delectus esse.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 567
        }
      }
    },
    {
      "Id": 747,
      "Name": "Wilderman-Rogahn",
      "ToolTip": "Delectus esse.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 567
        }
      }
    }
  ],
  "Language": "ex",
  "Sentiment": 521,
  "SentimentConfidence": 979,
  "SuggestedCategoryId": 249,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 352,
  "IconHint": "rerum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "eligendi",
    "ExtraFields2": "accusantium"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "eum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 139
    }
  }
}
```