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
| TicketType | TicketType | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
| ActiveStatusMonitorId | int32 | Active status monitor identity for related contact. This is a read-only property and is ignored on Save |
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
  "TicketId": 571,
  "Title": "voluptatum",
  "CreatedAt": "2009-08-05T23:03:57.2291114+02:00",
  "LastChanged": "2006-12-02T23:03:57.2291114+01:00",
  "ReadByOwner": "2004-11-19T23:03:57.2291114+01:00",
  "ReadByCustomer": "2019-12-20T23:03:57.2291114+01:00",
  "FirstReadByOwner": "2009-12-11T23:03:57.2291114+01:00",
  "FirstReadByUser": "2003-03-06T23:03:57.2291114+01:00",
  "Activate": "2017-08-24T23:03:57.2291114+02:00",
  "ClosedAt": "2001-01-23T23:03:57.2291114+01:00",
  "RepliedAt": "2011-12-18T23:03:57.2291114+01:00",
  "AlertTimeout": "2005-01-24T23:03:57.2291114+01:00",
  "Deadline": "2017-07-01T23:03:57.2291114+02:00",
  "CreatedBy": null,
  "Author": "velit",
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
      "Position": "pariatur",
      "PersonId": 891,
      "Mrmrs": "nesciunt",
      "Firstname": "Kurtis",
      "Lastname": "Medhurst",
      "MiddleName": "Schiller-Mitchell",
      "Title": "alias",
      "Description": "Implemented bandwidth-monitored algorithm",
      "Email": "kiarra.daugherty@carterdavis.info",
      "FullName": "Braeden Bahringer",
      "DirectPhone": "505.669.9463 x93310",
      "FormalName": "Wilkinson Inc and Sons",
      "CountryId": 709,
      "ContactId": 363,
      "ContactName": "Veum-Gutkowski",
      "Retired": 260,
      "Rank": 12,
      "ActiveInterests": 72,
      "ContactDepartment": "",
      "ContactCountryId": 832,
      "ContactOrgNr": "667239",
      "FaxPhone": "1-260-474-6820 x483",
      "MobilePhone": "(512)197-2472 x91211",
      "ContactPhone": "(141)224-4542 x2958",
      "AssociateName": "Gerlach-Schaden",
      "AssociateId": 246,
      "UsePersonAddress": false,
      "ContactFax": "molestiae",
      "Kanafname": "consequatur",
      "Kanalname": "cum",
      "Post1": "et",
      "Post2": "ex",
      "Post3": "et",
      "EmailName": "alva@kshlerin.info",
      "ContactFullName": "Priscilla Purdy",
      "ActiveErpLinks": 77,
      "TicketPriorityId": 668,
      "SupportLanguageId": 640,
      "SupportAssociateId": 749,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 897
        }
      }
    }
  ],
  "AlertLevel": 591,
  "ConnectId": 278,
  "ReadStatus": "Green",
  "TimeToReply": 433,
  "RealTimeToReply": 819,
  "TimeToClose": 409,
  "RealTimeToClose": 692,
  "TimeSpentInternally": 792,
  "TimeSpentExternally": 724,
  "TimeSpentQueue": 468,
  "RealTimeSpentInternally": 931,
  "RealTimeSpentExternally": 494,
  "RealTimeSpentQueue": 965,
  "TimeSpent": 685,
  "HasAttachment": true,
  "NumReplies": 131,
  "NumMessages": 129,
  "FromAddress": "et",
  "Messages": [
    {
      "TicketMessageId": 528,
      "CreatedAt": "2022-06-10T23:03:57.2341117+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "ab",
      "PersonId": 832,
      "PersonFullName": "Miss Jessie Tommie Ledner",
      "ContactId": 653,
      "ContactName": "Dietrich, Feest and Labadie",
      "ContactDepartment": "",
      "NumAttachments": 10,
      "EmailHeader": "quinn_ankunding@kuvalis.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "amet",
      "Sentiment": 904,
      "SentimentConfidence": 428,
      "CreatedBy": 647,
      "ChangedAt": "2018-09-10T23:03:57.2346121+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 596
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 423,
      "Name": "Gaylord LLC",
      "ToolTip": "Consequatur odit dolorum voluptas est.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 377
        }
      }
    },
    {
      "Id": 423,
      "Name": "Gaylord LLC",
      "ToolTip": "Consequatur odit dolorum voluptas est.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 377
        }
      }
    }
  ],
  "Language": "rem",
  "Sentiment": 515,
  "SentimentConfidence": 613,
  "SuggestedCategoryId": 771,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 571,
  "IconHint": "natus",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 307,
  "ExtraFields": {
    "ExtraFields1": "provident",
    "ExtraFields2": "maiores"
  },
  "CustomFields": {
    "CustomFields1": "reiciendis",
    "CustomFields2": "delectus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 897
    }
  }
}
```