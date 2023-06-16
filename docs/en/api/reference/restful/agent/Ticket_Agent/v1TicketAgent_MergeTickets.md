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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Ticket/MergeTickets
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "MergedTicketEntity": null,
  "SecondaryTicketIds": [
    218,
    871
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 698,
  "Title": "tempore",
  "CreatedAt": "2015-05-05T16:00:42.2112587+02:00",
  "LastChanged": "2011-03-29T16:00:42.2112587+02:00",
  "ReadByOwner": "1999-07-07T16:00:42.2112587+02:00",
  "ReadByCustomer": "1996-06-05T16:00:42.2112587+02:00",
  "FirstReadByOwner": "2019-08-16T16:00:42.2112587+02:00",
  "FirstReadByUser": "2010-04-21T16:00:42.2112587+02:00",
  "Activate": "2020-02-03T16:00:42.2112587+01:00",
  "ClosedAt": "2013-09-17T16:00:42.2112587+02:00",
  "RepliedAt": "2012-11-02T16:00:42.2112587+01:00",
  "AlertTimeout": "2018-05-21T16:00:42.2112587+02:00",
  "Deadline": "2023-02-18T16:00:42.2112587+01:00",
  "CreatedBy": null,
  "Author": "et",
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
      "Position": "cupiditate",
      "PersonId": 347,
      "Mrmrs": "perspiciatis",
      "Firstname": "Sean",
      "Lastname": "Grady",
      "MiddleName": "Rosenbaum LLC",
      "Title": "qui",
      "Description": "Face to face modular process improvement",
      "Email": "nikolas_heidenreich@heidenreich.info",
      "FullName": "Antonina Hodkiewicz DVM",
      "DirectPhone": "1-615-236-3374 x47104",
      "FormalName": "Kertzmann LLC",
      "CountryId": 777,
      "ContactId": 606,
      "ContactName": "Gorczany, Towne and Hartmann",
      "Retired": 177,
      "Rank": 609,
      "ActiveInterests": 705,
      "ContactDepartment": "",
      "ContactCountryId": 959,
      "ContactOrgNr": "950472",
      "FaxPhone": "1-509-038-2781 x9999",
      "MobilePhone": "(623)835-9720",
      "ContactPhone": "1-700-833-3049",
      "AssociateName": "Gerlach-Crist",
      "AssociateId": 5,
      "UsePersonAddress": false,
      "ContactFax": "id",
      "Kanafname": "non",
      "Kanalname": "repellat",
      "Post1": "et",
      "Post2": "sed",
      "Post3": "quas",
      "EmailName": "darlene.windler@ortiz.com",
      "ContactFullName": "Riley Dooley",
      "ActiveErpLinks": 856,
      "TicketPriorityId": 306,
      "SupportLanguageId": 687,
      "SupportAssociateId": 346,
      "CategoryName": "VIP Customer",
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
  "AlertLevel": 835,
  "ConnectId": 129,
  "ReadStatus": "Green",
  "TimeToReply": 70,
  "RealTimeToReply": 888,
  "TimeToClose": 302,
  "RealTimeToClose": 671,
  "TimeSpentInternally": 679,
  "TimeSpentExternally": 399,
  "TimeSpentQueue": 977,
  "RealTimeSpentInternally": 278,
  "RealTimeSpentExternally": 128,
  "RealTimeSpentQueue": 998,
  "HasAttachment": false,
  "NumReplies": 482,
  "NumMessages": 82,
  "FromAddress": "facilis",
  "Messages": [
    {
      "TicketMessageId": 377,
      "CreatedAt": "2005-04-22T16:00:42.2112587+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "quia",
      "PersonId": 537,
      "PersonFullName": "Hosea Sporer DDS",
      "ContactId": 507,
      "ContactName": "Aufderhar Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 975,
      "EmailHeader": "lavinia@mertz.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quis",
      "Sentiment": 857,
      "SentimentConfidence": 984,
      "CreatedBy": 302,
      "ChangedAt": "2019-01-22T16:00:42.2112587+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 814
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 861,
      "Name": "Wisoky LLC",
      "ToolTip": "Sunt reprehenderit explicabo voluptatem dolorem maxime aut consequatur.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 155
        }
      }
    },
    {
      "Id": 861,
      "Name": "Wisoky LLC",
      "ToolTip": "Sunt reprehenderit explicabo voluptatem dolorem maxime aut consequatur.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 155
        }
      }
    }
  ],
  "Language": "ea",
  "Sentiment": 492,
  "SentimentConfidence": 919,
  "SuggestedCategoryId": 98,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 289,
  "IconHint": "quam",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "sunt"
  },
  "CustomFields": {
    "CustomFields1": "dicta",
    "CustomFields2": "tenetur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 393
    }
  }
}
```