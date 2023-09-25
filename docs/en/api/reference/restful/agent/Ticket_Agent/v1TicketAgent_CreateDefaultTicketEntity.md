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
  "TicketId": 202,
  "Title": "nulla",
  "CreatedAt": "2015-02-25T03:24:48.3159514+01:00",
  "LastChanged": "2016-02-06T03:24:48.3159514+01:00",
  "ReadByOwner": "1999-05-10T03:24:48.3159514+02:00",
  "ReadByCustomer": "2011-12-07T03:24:48.3159514+01:00",
  "FirstReadByOwner": "2023-04-06T03:24:48.3159514+02:00",
  "FirstReadByUser": "2018-05-10T03:24:48.3159514+02:00",
  "Activate": "2017-04-24T03:24:48.3159514+02:00",
  "ClosedAt": "2015-09-14T03:24:48.3159514+02:00",
  "RepliedAt": "2023-06-10T03:24:48.3159514+02:00",
  "AlertTimeout": "2015-01-13T03:24:48.3159514+01:00",
  "Deadline": "2003-07-25T03:24:48.3159514+02:00",
  "CreatedBy": null,
  "Author": "doloremque",
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
      "Position": "quisquam",
      "PersonId": 343,
      "Mrmrs": "quia",
      "Firstname": "Polly",
      "Lastname": "Leffler",
      "MiddleName": "Schaefer Inc and Sons",
      "Title": "quia",
      "Description": "Switchable zero defect function",
      "Email": "valentina@dibbertbarton.com",
      "FullName": "Prof. Daniela Sibyl Kuvalis",
      "DirectPhone": "(340)978-6277 x21519",
      "FormalName": "Friesen Group",
      "CountryId": 969,
      "ContactId": 817,
      "ContactName": "Kautzer, Windler and Funk",
      "Retired": 513,
      "Rank": 13,
      "ActiveInterests": 467,
      "ContactDepartment": "",
      "ContactCountryId": 150,
      "ContactOrgNr": "1080627",
      "FaxPhone": "(202)784-6943",
      "MobilePhone": "1-301-600-3014 x973",
      "ContactPhone": "018-835-1040",
      "AssociateName": "Braun-Ferry",
      "AssociateId": 592,
      "UsePersonAddress": false,
      "ContactFax": "aut",
      "Kanafname": "eveniet",
      "Kanalname": "asperiores",
      "Post1": "vel",
      "Post2": "molestias",
      "Post3": "commodi",
      "EmailName": "gerda.hirthe@romaguerawalsh.co.uk",
      "ContactFullName": "Toni Macejkovic",
      "ActiveErpLinks": 833,
      "TicketPriorityId": 585,
      "SupportLanguageId": 7,
      "SupportAssociateId": 686,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 1001
        }
      }
    }
  ],
  "AlertLevel": 7,
  "ConnectId": 965,
  "ReadStatus": "Green",
  "TimeToReply": 308,
  "RealTimeToReply": 736,
  "TimeToClose": 171,
  "RealTimeToClose": 427,
  "TimeSpentInternally": 715,
  "TimeSpentExternally": 788,
  "TimeSpentQueue": 477,
  "RealTimeSpentInternally": 189,
  "RealTimeSpentExternally": 955,
  "RealTimeSpentQueue": 260,
  "TimeSpent": 783,
  "HasAttachment": true,
  "NumReplies": 447,
  "NumMessages": 927,
  "FromAddress": "vero",
  "Messages": [
    {
      "TicketMessageId": 979,
      "CreatedAt": "2007-04-01T03:24:48.3159514+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "occaecati",
      "PersonId": 941,
      "PersonFullName": "Mitchell Williamson",
      "ContactId": 372,
      "ContactName": "Kautzer, Williamson and Keebler",
      "ContactDepartment": "recontextualize plug-and-play e-markets",
      "NumAttachments": 248,
      "EmailHeader": "miracle@willms.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "rem",
      "Sentiment": 199,
      "SentimentConfidence": 800,
      "CreatedBy": 192,
      "ChangedAt": "1998-09-07T03:24:48.3159514+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 787
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 209,
      "Name": "Osinski-Langosh",
      "ToolTip": "Quo maiores.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 970
        }
      }
    },
    {
      "Id": 209,
      "Name": "Osinski-Langosh",
      "ToolTip": "Quo maiores.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 970
        }
      }
    }
  ],
  "Language": "reiciendis",
  "Sentiment": 314,
  "SentimentConfidence": 523,
  "SuggestedCategoryId": 61,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 298,
  "IconHint": "nam",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "quis",
    "ExtraFields2": "nulla"
  },
  "CustomFields": {
    "CustomFields1": "sunt",
    "CustomFields2": "vitae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 653
    }
  }
}
```