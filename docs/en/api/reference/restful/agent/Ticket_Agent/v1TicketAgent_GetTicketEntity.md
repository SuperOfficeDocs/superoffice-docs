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
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=146
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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 998,
  "Title": "laborum",
  "CreatedAt": "2018-06-05T11:06:35.5051904+02:00",
  "LastChanged": "2019-04-15T11:06:35.5051904+02:00",
  "ReadByOwner": "2005-05-11T11:06:35.5051904+02:00",
  "ReadByCustomer": "2003-04-15T11:06:35.5051904+02:00",
  "FirstReadByOwner": "2014-03-29T11:06:35.5051904+01:00",
  "FirstReadByUser": "2004-06-09T11:06:35.5051904+02:00",
  "Activate": "2014-12-14T11:06:35.5051904+01:00",
  "ClosedAt": "1998-08-11T11:06:35.5051904+02:00",
  "RepliedAt": "2019-02-12T11:06:35.5051904+01:00",
  "AlertTimeout": "2012-11-05T11:06:35.5051904+01:00",
  "Deadline": "2018-01-14T11:06:35.5051904+01:00",
  "CreatedBy": null,
  "Author": "culpa",
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
      "Position": "sequi",
      "PersonId": 260,
      "Mrmrs": "natus",
      "Firstname": "Frederik",
      "Lastname": "D'Amore",
      "MiddleName": "Jaskolski LLC",
      "Title": "qui",
      "Description": "Synergized radical concept",
      "Email": "aylin_bosco@carroll.ca",
      "FullName": "Dr. Wendy Harber",
      "DirectPhone": "020-375-7943 x84092",
      "FormalName": "Veum-Hodkiewicz",
      "CountryId": 97,
      "ContactId": 152,
      "ContactName": "Beatty, Crist and Kuvalis",
      "Retired": 517,
      "Rank": 573,
      "ActiveInterests": 824,
      "ContactDepartment": "",
      "ContactCountryId": 662,
      "ContactOrgNr": "1876298",
      "FaxPhone": "320.181.5520 x173",
      "MobilePhone": "706-486-2760",
      "ContactPhone": "1-399-234-5074 x94401",
      "AssociateName": "Koepp-Howell",
      "AssociateId": 50,
      "UsePersonAddress": true,
      "ContactFax": "nesciunt",
      "Kanafname": "ut",
      "Kanalname": "culpa",
      "Post1": "sit",
      "Post2": "officia",
      "Post3": "sequi",
      "EmailName": "dallas@gleason.us",
      "ContactFullName": "Caroline Graham DDS",
      "ActiveErpLinks": 743,
      "TicketPriorityId": 321,
      "SupportLanguageId": 353,
      "SupportAssociateId": 888,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 644
        }
      }
    }
  ],
  "AlertLevel": 389,
  "ConnectId": 578,
  "ReadStatus": "Green",
  "TimeToReply": 631,
  "RealTimeToReply": 737,
  "TimeToClose": 564,
  "RealTimeToClose": 724,
  "TimeSpentInternally": 132,
  "TimeSpentExternally": 892,
  "TimeSpentQueue": 365,
  "RealTimeSpentInternally": 143,
  "RealTimeSpentExternally": 330,
  "RealTimeSpentQueue": 718,
  "TimeSpent": 163,
  "HasAttachment": true,
  "NumReplies": 508,
  "NumMessages": 759,
  "FromAddress": "commodi",
  "Messages": [
    {
      "TicketMessageId": 868,
      "CreatedAt": "2007-11-08T11:06:35.5051904+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "maiores",
      "PersonId": 714,
      "PersonFullName": "Mr. Rahsaan Upton",
      "ContactId": 229,
      "ContactName": "Bosco, Kreiger and Hoppe",
      "ContactDepartment": "",
      "NumAttachments": 253,
      "EmailHeader": "russel@littel.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "deserunt",
      "Sentiment": 143,
      "SentimentConfidence": 758,
      "CreatedBy": 921,
      "ChangedAt": "2001-04-07T11:06:35.5051904+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 130
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 495,
      "Name": "Gibson Group",
      "ToolTip": "Et qui facilis quasi ducimus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 113
        }
      }
    },
    {
      "Id": 495,
      "Name": "Gibson Group",
      "ToolTip": "Et qui facilis quasi ducimus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 113
        }
      }
    }
  ],
  "Language": "aut",
  "Sentiment": 594,
  "SentimentConfidence": 130,
  "SuggestedCategoryId": 410,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 252,
  "IconHint": "iure",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "praesentium"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "facere"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 760
    }
  }
}
```