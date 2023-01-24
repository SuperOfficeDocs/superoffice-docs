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
| TableRight | RecurrenceInfo |  |
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
  "TicketId": 951,
  "Title": "quasi",
  "CreatedAt": "2015-09-29T11:22:45.2412009+02:00",
  "LastChanged": "2001-02-02T11:22:45.2412009+01:00",
  "ReadByOwner": "2015-10-01T11:22:45.2412009+02:00",
  "ReadByCustomer": "2019-04-29T11:22:45.2412009+02:00",
  "FirstReadByOwner": "2006-04-11T11:22:45.2412009+02:00",
  "FirstReadByUser": "2004-04-05T11:22:45.2412009+02:00",
  "Activate": "1996-06-28T11:22:45.2412009+02:00",
  "ClosedAt": "2003-07-12T11:22:45.2412009+02:00",
  "RepliedAt": "2014-01-22T11:22:45.2412009+01:00",
  "AlertTimeout": "2013-10-28T11:22:45.2412009+01:00",
  "Deadline": "2020-01-15T11:22:45.2412009+01:00",
  "CreatedBy": null,
  "Author": "architecto",
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
      "Position": "eos",
      "PersonId": 638,
      "Mrmrs": "odit",
      "Firstname": "Neha",
      "Lastname": "Ledner",
      "MiddleName": "Hayes Group",
      "Title": "incidunt",
      "Description": "Stand-alone zero defect standardization",
      "Email": "jaron@hermistondenesik.com",
      "FullName": "Edna Raymond Bergnaum I",
      "DirectPhone": "774.121.8361",
      "FormalName": "Reilly, Larson and Jewess",
      "CountryId": 863,
      "ContactId": 750,
      "ContactName": "Rolfson Group",
      "Retired": 104,
      "Rank": 381,
      "ActiveInterests": 598,
      "ContactDepartment": "",
      "ContactCountryId": 946,
      "ContactOrgNr": "1115747",
      "FaxPhone": "(060)426-5304",
      "MobilePhone": "(285)913-2684 x765",
      "ContactPhone": "1-688-938-2739",
      "AssociateName": "Kerluke Inc and Sons",
      "AssociateId": 657,
      "UsePersonAddress": false,
      "ContactFax": "iste",
      "Kanafname": "odit",
      "Kanalname": "aperiam",
      "Post1": "labore",
      "Post2": "in",
      "Post3": "quia",
      "EmailName": "chasity@gottlieb.ca",
      "ContactFullName": "D'angelo Johnston",
      "ActiveErpLinks": 318,
      "TicketPriorityId": 728,
      "SupportLanguageId": 233,
      "SupportAssociateId": 375,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 334
        }
      }
    }
  ],
  "AlertLevel": 435,
  "ConnectId": 235,
  "ReadStatus": "Green",
  "TimeToReply": 241,
  "RealTimeToReply": 176,
  "TimeToClose": 946,
  "RealTimeToClose": 3,
  "TimeSpentInternally": 92,
  "TimeSpentExternally": 859,
  "TimeSpentQueue": 226,
  "RealTimeSpentInternally": 709,
  "RealTimeSpentExternally": 456,
  "RealTimeSpentQueue": 679,
  "HasAttachment": true,
  "NumReplies": 627,
  "NumMessages": 35,
  "FromAddress": "vel",
  "Messages": [
    {
      "TicketMessageId": 322,
      "CreatedAt": "2007-10-07T11:22:45.2412009+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "voluptatem",
      "PersonId": 12,
      "PersonFullName": "Brain Halvorson",
      "ContactId": 995,
      "ContactName": "Larkin-Bednar",
      "ContactDepartment": "",
      "NumAttachments": 461,
      "EmailHeader": "devin@ebert.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quasi",
      "Sentiment": 594,
      "SentimentConfidence": 166,
      "CreatedBy": 433,
      "ChangedAt": "2019-05-03T11:22:45.2412009+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 787
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 710,
      "Name": "McGlynn Group",
      "ToolTip": "Asperiores non et id nostrum itaque quia quidem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 407
        }
      }
    },
    {
      "Id": 710,
      "Name": "McGlynn Group",
      "ToolTip": "Asperiores non et id nostrum itaque quia quidem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 407
        }
      }
    }
  ],
  "Language": "ut",
  "Sentiment": 66,
  "SentimentConfidence": 805,
  "SuggestedCategoryId": 603,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 239,
  "IconHint": "nam",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "doloribus",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "omnis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 885
    }
  }
}
```