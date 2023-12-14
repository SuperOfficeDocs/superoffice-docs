---
title: POST Agents/Ticket/MergeTickets
uid: v1TicketAgent_MergeTickets
generated: true
---

# POST Agents/Ticket/MergeTickets

```http
POST /api/v1/Agents/Ticket/MergeTickets
```

Merge one or more tickets into one primary ticket







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/MergeTickets?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

MergedTicketEntity, SecondaryTicketIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MergedTicketEntity | TicketEntity | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| SecondaryTicketIds | Array |  |

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
POST /api/v1/Agents/Ticket/MergeTickets
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "MergedTicketEntity": null,
  "SecondaryTicketIds": [
    316,
    697
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 278,
  "Title": "consectetur",
  "CreatedAt": "2013-01-06T13:57:13.442717+01:00",
  "LastChanged": "2014-02-24T13:57:13.442717+01:00",
  "ReadByOwner": "2002-07-27T13:57:13.442717+02:00",
  "ReadByCustomer": "2011-05-17T13:57:13.442717+02:00",
  "FirstReadByOwner": "2012-10-30T13:57:13.442717+01:00",
  "FirstReadByUser": "2015-04-29T13:57:13.442717+02:00",
  "Activate": "2008-07-02T13:57:13.442717+02:00",
  "ClosedAt": "2014-12-22T13:57:13.442717+01:00",
  "RepliedAt": "2017-02-27T13:57:13.442717+01:00",
  "AlertTimeout": "1999-07-21T13:57:13.442717+02:00",
  "Deadline": "1998-06-02T13:57:13.442717+02:00",
  "CreatedBy": null,
  "Author": "saepe",
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
      "Position": "enim",
      "PersonId": 346,
      "Mrmrs": "neque",
      "Firstname": "Pedro",
      "Lastname": "Heaney",
      "MiddleName": "Gerhold Group",
      "Title": "illum",
      "Description": "Robust client-server encryption",
      "Email": "moriah_cruickshank@cronaemmerich.ca",
      "FullName": "Willy Marvin",
      "DirectPhone": "(202)817-5373",
      "FormalName": "Grant-Christiansen",
      "CountryId": 375,
      "ContactId": 543,
      "ContactName": "Bogan, Price and Sanford",
      "Retired": 934,
      "Rank": 245,
      "ActiveInterests": 167,
      "ContactDepartment": "",
      "ContactCountryId": 700,
      "ContactOrgNr": "603482",
      "FaxPhone": "380-166-4586 x814",
      "MobilePhone": "1-995-663-8304 x982",
      "ContactPhone": "774-837-9551",
      "AssociateName": "Rutherford, Harris and Champlin",
      "AssociateId": 500,
      "UsePersonAddress": true,
      "ContactFax": "et",
      "Kanafname": "voluptas",
      "Kanalname": "eius",
      "Post1": "in",
      "Post2": "odit",
      "Post3": "rerum",
      "EmailName": "elroy.dach@pricefranecki.name",
      "ContactFullName": "Mrs. Evert Renner",
      "ActiveErpLinks": 216,
      "TicketPriorityId": 942,
      "SupportLanguageId": 172,
      "SupportAssociateId": 924,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 232
        }
      }
    }
  ],
  "AlertLevel": 796,
  "ConnectId": 693,
  "ReadStatus": "Green",
  "TimeToReply": 87,
  "RealTimeToReply": 278,
  "TimeToClose": 100,
  "RealTimeToClose": 861,
  "TimeSpentInternally": 20,
  "TimeSpentExternally": 50,
  "TimeSpentQueue": 749,
  "RealTimeSpentInternally": 37,
  "RealTimeSpentExternally": 387,
  "RealTimeSpentQueue": 693,
  "TimeSpent": 14,
  "HasAttachment": false,
  "NumReplies": 136,
  "NumMessages": 653,
  "FromAddress": "repellendus",
  "Messages": [
    {
      "TicketMessageId": 826,
      "CreatedAt": "2020-08-17T13:57:13.442717+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "consectetur",
      "PersonId": 752,
      "PersonFullName": "Summer Powlowski",
      "ContactId": 296,
      "ContactName": "Breitenberg Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 931,
      "EmailHeader": "miles.glover@emmerich.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "temporibus",
      "Sentiment": 146,
      "SentimentConfidence": 684,
      "CreatedBy": 152,
      "ChangedAt": "2001-08-09T13:57:13.442717+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 896
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 582,
      "Name": "Cruickshank, Denesik and Kovacek",
      "ToolTip": "Vel ut facilis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 508
        }
      }
    },
    {
      "Id": 582,
      "Name": "Cruickshank, Denesik and Kovacek",
      "ToolTip": "Vel ut facilis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 508
        }
      }
    }
  ],
  "Language": "ullam",
  "Sentiment": 764,
  "SentimentConfidence": 191,
  "SuggestedCategoryId": 170,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 516,
  "IconHint": "sit",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "laboriosam",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "debitis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 247
    }
  }
}
```