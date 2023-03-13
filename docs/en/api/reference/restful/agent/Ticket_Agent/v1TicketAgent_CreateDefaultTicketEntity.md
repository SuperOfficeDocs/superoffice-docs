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
| TableRight | TableRight |  |
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
  "TicketId": 740,
  "Title": "ullam",
  "CreatedAt": "2014-09-15T14:19:04.3609502+02:00",
  "LastChanged": "2010-04-02T14:19:04.3609502+02:00",
  "ReadByOwner": "2017-10-24T14:19:04.3609502+02:00",
  "ReadByCustomer": "2014-12-06T14:19:04.3609502+01:00",
  "FirstReadByOwner": "2011-02-23T14:19:04.3609502+01:00",
  "FirstReadByUser": "2015-01-08T14:19:04.3609502+01:00",
  "Activate": "2013-07-31T14:19:04.3609502+02:00",
  "ClosedAt": "2005-02-05T14:19:04.3609502+01:00",
  "RepliedAt": "2000-07-12T14:19:04.3609502+02:00",
  "AlertTimeout": "2005-03-17T14:19:04.3609502+01:00",
  "Deadline": "2002-05-05T14:19:04.3609502+02:00",
  "CreatedBy": null,
  "Author": "necessitatibus",
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
      "Position": "ratione",
      "PersonId": 577,
      "Mrmrs": "ut",
      "Firstname": "Bennie",
      "Lastname": "Shanahan",
      "MiddleName": "Raynor, Hodkiewicz and Gulgowski",
      "Title": "delectus",
      "Description": "Distributed dynamic process improvement",
      "Email": "eveline@ondrickafarrell.us",
      "FullName": "Aileen Hintz DDS",
      "DirectPhone": "878.924.4557 x8662",
      "FormalName": "Farrell Inc and Sons",
      "CountryId": 711,
      "ContactId": 284,
      "ContactName": "West Group",
      "Retired": 247,
      "Rank": 108,
      "ActiveInterests": 770,
      "ContactDepartment": "",
      "ContactCountryId": 212,
      "ContactOrgNr": "503784",
      "FaxPhone": "(596)533-1719 x2460",
      "MobilePhone": "(943)015-3053 x70413",
      "ContactPhone": "1-191-314-1277 x5967",
      "AssociateName": "Kovacek, Fritsch and Stamm",
      "AssociateId": 862,
      "UsePersonAddress": false,
      "ContactFax": "officia",
      "Kanafname": "nisi",
      "Kanalname": "illo",
      "Post1": "debitis",
      "Post2": "magni",
      "Post3": "dicta",
      "EmailName": "trinity.jacobs@abbott.uk",
      "ContactFullName": "Baby Koch",
      "ActiveErpLinks": 328,
      "TicketPriorityId": 774,
      "SupportLanguageId": 271,
      "SupportAssociateId": 216,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 448
        }
      }
    }
  ],
  "AlertLevel": 698,
  "ConnectId": 422,
  "ReadStatus": "Green",
  "TimeToReply": 758,
  "RealTimeToReply": 845,
  "TimeToClose": 212,
  "RealTimeToClose": 739,
  "TimeSpentInternally": 323,
  "TimeSpentExternally": 789,
  "TimeSpentQueue": 251,
  "RealTimeSpentInternally": 559,
  "RealTimeSpentExternally": 733,
  "RealTimeSpentQueue": 285,
  "HasAttachment": true,
  "NumReplies": 125,
  "NumMessages": 824,
  "FromAddress": "possimus",
  "Messages": [
    {
      "TicketMessageId": 996,
      "CreatedAt": "2016-05-05T14:19:04.3765753+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "ea",
      "PersonId": 810,
      "PersonFullName": "Mr. Anita Vandervort III",
      "ContactId": 353,
      "ContactName": "Anderson-Carter",
      "ContactDepartment": "",
      "NumAttachments": 630,
      "EmailHeader": "floyd_ernser@thompsonabernathy.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "velit",
      "Sentiment": 260,
      "SentimentConfidence": 238,
      "CreatedBy": 249,
      "ChangedAt": "2004-01-22T14:19:04.3765753+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 780
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 971,
      "Name": "Auer Group",
      "ToolTip": "Saepe nesciunt aut enim harum ut repellat temporibus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 867
        }
      }
    },
    {
      "Id": 971,
      "Name": "Auer Group",
      "ToolTip": "Saepe nesciunt aut enim harum ut repellat temporibus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 867
        }
      }
    }
  ],
  "Language": "dignissimos",
  "Sentiment": 346,
  "SentimentConfidence": 562,
  "SuggestedCategoryId": 526,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 18,
  "IconHint": "ab",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "ipsum",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "non"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 973
    }
  }
}
```