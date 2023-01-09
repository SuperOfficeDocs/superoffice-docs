---
title: POST Agents/Ticket/MergeTickets
uid: v1TicketAgent_MergeTickets
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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Ticket/MergeTickets
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "MergedTicketEntity": null,
  "SecondaryTicketIds": [
    323,
    230
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 790,
  "Title": "ratione",
  "CreatedAt": "1999-05-16T17:37:19.4349762+02:00",
  "LastChanged": "2016-09-11T17:37:19.4349762+02:00",
  "ReadByOwner": "2008-07-09T17:37:19.4349762+02:00",
  "ReadByCustomer": "2009-11-10T17:37:19.4349762+01:00",
  "FirstReadByOwner": "2006-05-22T17:37:19.4349762+02:00",
  "FirstReadByUser": "2009-07-01T17:37:19.4349762+02:00",
  "Activate": "2021-02-04T17:37:19.4349762+01:00",
  "ClosedAt": "1996-10-14T17:37:19.4349762+02:00",
  "RepliedAt": "1997-09-19T17:37:19.4349762+02:00",
  "AlertTimeout": "2009-09-13T17:37:19.4349762+02:00",
  "Deadline": "2019-02-14T17:37:19.4349762+01:00",
  "CreatedBy": null,
  "Author": "ut",
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
      "Position": "vitae",
      "PersonId": 756,
      "Mrmrs": "ipsam",
      "Firstname": "Mellie",
      "Lastname": "Kunde",
      "MiddleName": "Ebert-Kessler",
      "Title": "minus",
      "Description": "Fundamental web-enabled strategy",
      "Email": "maiya_crooks@nader.biz",
      "FullName": "Prof. Neoma Ullrich I",
      "DirectPhone": "361-867-1835",
      "FormalName": "Haley, Crona and Ernser",
      "CountryId": 504,
      "ContactId": 547,
      "ContactName": "Kessler Group",
      "Retired": 322,
      "Rank": 585,
      "ActiveInterests": 177,
      "ContactDepartment": "",
      "ContactCountryId": 148,
      "ContactOrgNr": "1154112",
      "FaxPhone": "(312)970-6314",
      "MobilePhone": "1-246-633-4702 x564",
      "ContactPhone": "1-916-256-9417 x909",
      "AssociateName": "Crist-Mertz",
      "AssociateId": 972,
      "UsePersonAddress": true,
      "ContactFax": "corporis",
      "Kanafname": "eum",
      "Kanalname": "culpa",
      "Post1": "voluptas",
      "Post2": "ratione",
      "Post3": "aliquam",
      "EmailName": "hettie@ziemanndietrich.ca",
      "ContactFullName": "Eldora O'Conner",
      "ActiveErpLinks": 339,
      "TicketPriorityId": 735,
      "SupportLanguageId": 360,
      "SupportAssociateId": 358,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 847
        }
      }
    }
  ],
  "AlertLevel": 140,
  "ConnectId": 706,
  "ReadStatus": "Green",
  "TimeToReply": 235,
  "RealTimeToReply": 886,
  "TimeToClose": 163,
  "RealTimeToClose": 285,
  "TimeSpentInternally": 666,
  "TimeSpentExternally": 200,
  "TimeSpentQueue": 101,
  "RealTimeSpentInternally": 266,
  "RealTimeSpentExternally": 57,
  "RealTimeSpentQueue": 263,
  "HasAttachment": true,
  "NumReplies": 353,
  "NumMessages": 916,
  "FromAddress": "suscipit",
  "Messages": [
    {
      "TicketMessageId": 671,
      "CreatedAt": "2011-11-05T17:37:19.4389763+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "aliquam",
      "PersonId": 728,
      "PersonFullName": "Salvador Rath",
      "ContactId": 182,
      "ContactName": "Purdy LLC",
      "ContactDepartment": "",
      "NumAttachments": 726,
      "EmailHeader": "wendell@feil.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "omnis",
      "Sentiment": 600,
      "SentimentConfidence": 423,
      "CreatedBy": 635,
      "ChangedAt": "1995-11-15T17:37:19.4389763+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 939
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 587,
      "Name": "Miller-Weber",
      "ToolTip": "Et et aut repellendus vitae quae voluptas.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 619
        }
      }
    },
    {
      "Id": 587,
      "Name": "Miller-Weber",
      "ToolTip": "Et et aut repellendus vitae quae voluptas.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 619
        }
      }
    }
  ],
  "Language": "ut",
  "Sentiment": 961,
  "SentimentConfidence": 817,
  "SuggestedCategoryId": 958,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 582,
  "IconHint": "soluta",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "repellendus",
    "CustomFields2": "nulla"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 716
    }
  }
}
```