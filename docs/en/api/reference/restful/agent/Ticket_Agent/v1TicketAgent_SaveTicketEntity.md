---
title: POST Agents/Ticket/SaveTicketEntity
uid: v1TicketAgent_SaveTicketEntity
generated: true
---

# POST Agents/Ticket/SaveTicketEntity

```http
POST /api/v1/Agents/Ticket/SaveTicketEntity
```

Updates the existing TicketEntity or creates a new TicketEntity if the id parameter is empty








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

## Request Body: entity 

The TicketEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | Integer | The primary key (auto-incremented) |
| Title | String | The title of the ticket. |
| CreatedAt | String | When the ticket was created. |
| LastChanged | String | The last time the ticket was modified. |
| ReadByOwner | String | The datetime for when the ticket last was read by the owner. |
| ReadByCustomer | String | The datetime for when the ticket was read by the customer. |
| FirstReadByOwner | String | The datetime for when the ticket first was read by the current owner. |
| FirstReadByUser | String | The datetime for when the ticket first was read by a user. |
| Activate | String | When the ticket should be activated, if it is postponed. |
| ClosedAt | String | When the ticket was closed. |
| RepliedAt | String | The datetime for when the ticket was replied to. I.e. the first external message added to the ticket. |
| AlertTimeout | String | The datetime for when the ticket should jump to the next alert_level. |
| Deadline | String | Deadline for ticket. |
| CreatedBy | Associate | The associate who created this ticket |
| Author | String | A string representing the author of the ticket (same as author of first message). |
| OwnedBy | Associate | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category | TicketCategoryEntity | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | String | The securitylevel of the ticket. |
| Priority | TicketPriorityEntity | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | String | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status | TicketStatusEntity | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | String | What is the origin of this ticket |
| Person | Person | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
| SecondaryPersons | Array | The secondary persons this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
| AlertLevel | Integer | The alert level for the ticket. Matches the level value of the ticket_alert table. |
| ConnectId | Integer | If a ticket is connected to another ticket, this field is set to the id of the &amp;apos;master&amp;apos; ticket. |
| ReadStatus | String | Whether the owner has read the ticket or not (red, yellow, green). |
| TimeToReply | Integer | The time (minutes) between when the ticket was created and when it was replied to. Calculated based on priority&amp;apos;s timeframe. |
| RealTimeToReply | Integer | Same as time_to_reply, but not calculated based on priority. |
| TimeToClose | Integer | The time (minutes) between when the ticket was created and when it was closed. Calculated based on priority&amp;apos;s timeframe. |
| RealTimeToClose | Integer | Same as time_to_close, but not calculated based on priority. |
| TimeSpentInternally | Integer | The total time (seconds) within the priority's office hours the ticket has been in an open status (configurable), not including current state |
| TimeSpentExternally | Integer | The total time (seconds) within the priority's office hours the ticket has been in a external waiting status (configurable), not including current state |
| TimeSpentQueue | Integer | The total time (seconds) within the priority's office hours the ticket has been in a queue status, not including current state |
| RealTimeSpentInternally | Integer | The total time (seconds) within 24x7 the ticket has been in an open status (configurable), not including current state |
| RealTimeSpentExternally | Integer | The total time (seconds) within 24x7 the ticket has been in a external waiting status (configurable), not including current state |
| RealTimeSpentQueue | Integer | The total time (seconds) within 24x7 hours the ticket has been in a queue status, not including current state |
| TimeSpent | Integer | The total time (minutes). Aggregated time spent from ticket&amp;apos;s messages. Read-only for external use. |
| HasAttachment | Boolean | Boolean indicating if this ticket has one or more attachments. |
| NumReplies | Integer | The number of replies (messages) to the customer for this request. |
| NumMessages | Integer | The total number of messages for this request. |
| FromAddress | String | The from-address used when this ticket got created, e.g. by email |
| Messages | Array | TicketMessageId,CreatedAt,SLevel and Important for all the messages connected to this ticket. For message body see the TicketMessageEntity or the TicketMessage archive. |
| Tags | Array | An array containing the tags assigned to this request |
| Language | String | The language of the first external message |
| Sentiment | Integer | The sentiment index of the last external message |
| SentimentConfidence | Integer | The sentiment confidence of the last external message |
| SuggestedCategoryId | Integer | Suggestion for categorization, based on the text of the message (AI) |
| SuggestedCategoryName | String | Suggested category from AI |
| OrigHumanCategoryId | Integer | Will contain the category id selected by the user, when having the choice of using the suggested category or manually selecting a category |
| IconHint | String | Icon representing ticket's state |
| Sale | Sale | The sale that this ticket is connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket is connected to  <para>Use MDO List name "project" to get list items.</para> |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| TicketType | TicketTypeEntity | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

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
POST /api/v1/Agents/Ticket/SaveTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 321,
  "Title": "eum",
  "CreatedAt": "2003-05-03T03:24:48.3159514+02:00",
  "LastChanged": "2017-01-25T03:24:48.3159514+01:00",
  "ReadByOwner": "2015-08-29T03:24:48.3159514+02:00",
  "ReadByCustomer": "2022-12-02T03:24:48.3159514+01:00",
  "FirstReadByOwner": "2022-12-08T03:24:48.3159514+01:00",
  "FirstReadByUser": "2012-11-27T03:24:48.3159514+01:00",
  "Activate": "2004-02-26T03:24:48.3159514+01:00",
  "ClosedAt": "1998-05-23T03:24:48.3159514+02:00",
  "RepliedAt": "2014-02-19T03:24:48.3159514+01:00",
  "AlertTimeout": "2001-04-15T03:24:48.3159514+02:00",
  "Deadline": "2017-03-20T03:24:48.3159514+01:00",
  "CreatedBy": null,
  "Author": "voluptates",
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
      "Position": "aut",
      "PersonId": 931,
      "Mrmrs": "culpa",
      "Firstname": "Selena",
      "Lastname": "Deckow",
      "MiddleName": "Kuphal Group",
      "Title": "autem",
      "Description": "Quality-focused stable frame",
      "Email": "sonny_schulist@weberharris.ca",
      "FullName": "Lonnie Waters",
      "DirectPhone": "291.806.3366 x4126",
      "FormalName": "Hilpert LLC",
      "CountryId": 412,
      "ContactId": 525,
      "ContactName": "Bins Group",
      "Retired": 749,
      "Rank": 667,
      "ActiveInterests": 456,
      "ContactDepartment": "",
      "ContactCountryId": 628,
      "ContactOrgNr": "912550",
      "FaxPhone": "259-674-1334",
      "MobilePhone": "(595)689-5052 x54563",
      "ContactPhone": "(607)181-3336 x40104",
      "AssociateName": "Runolfsson-Hintz",
      "AssociateId": 686,
      "UsePersonAddress": true,
      "ContactFax": "qui",
      "Kanafname": "optio",
      "Kanalname": "modi",
      "Post1": "maxime",
      "Post2": "fugit",
      "Post3": "recusandae",
      "EmailName": "ara.dare@gorczany.info",
      "ContactFullName": "Miss Kali June Borer DVM",
      "ActiveErpLinks": 33,
      "TicketPriorityId": 801,
      "SupportLanguageId": 690,
      "SupportAssociateId": 938,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 965,
  "ConnectId": 782,
  "ReadStatus": "Green",
  "TimeToReply": 788,
  "RealTimeToReply": 129,
  "TimeToClose": 799,
  "RealTimeToClose": 482,
  "TimeSpentInternally": 743,
  "TimeSpentExternally": 853,
  "TimeSpentQueue": 75,
  "RealTimeSpentInternally": 280,
  "RealTimeSpentExternally": 797,
  "RealTimeSpentQueue": 838,
  "TimeSpent": 685,
  "HasAttachment": false,
  "NumReplies": 322,
  "NumMessages": 407,
  "FromAddress": "saepe",
  "Messages": [
    {
      "TicketMessageId": 890,
      "CreatedAt": "2012-11-21T03:24:48.3159514+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "quam",
      "PersonId": 37,
      "PersonFullName": "Aric Tremblay",
      "ContactId": 615,
      "ContactName": "Effertz-Swift",
      "ContactDepartment": "",
      "NumAttachments": 586,
      "EmailHeader": "dexter_ebert@howell.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "maiores",
      "Sentiment": 841,
      "SentimentConfidence": 702,
      "CreatedBy": 707,
      "ChangedAt": "2011-08-06T03:24:48.3159514+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 919,
      "Name": "Greenfelder, Leffler and Windler",
      "ToolTip": "Consequuntur ipsam sit."
    },
    {
      "Id": 919,
      "Name": "Greenfelder, Leffler and Windler",
      "ToolTip": "Consequuntur ipsam sit."
    }
  ],
  "Language": "repellat",
  "Sentiment": 647,
  "SentimentConfidence": 307,
  "SuggestedCategoryId": 624,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 182,
  "IconHint": "est",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "culpa"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "ullam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 527,
  "Title": "non",
  "CreatedAt": "2003-12-25T03:24:48.3159514+01:00",
  "LastChanged": "2003-02-01T03:24:48.3159514+01:00",
  "ReadByOwner": "1998-05-25T03:24:48.3159514+02:00",
  "ReadByCustomer": "2023-05-19T03:24:48.3159514+02:00",
  "FirstReadByOwner": "2022-10-01T03:24:48.3159514+02:00",
  "FirstReadByUser": "2006-03-03T03:24:48.3159514+01:00",
  "Activate": "2013-01-18T03:24:48.3159514+01:00",
  "ClosedAt": "2018-01-17T03:24:48.3159514+01:00",
  "RepliedAt": "2014-04-30T03:24:48.3159514+02:00",
  "AlertTimeout": "2010-05-29T03:24:48.3159514+02:00",
  "Deadline": "2020-03-13T03:24:48.3159514+01:00",
  "CreatedBy": null,
  "Author": "quidem",
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
      "Position": "veritatis",
      "PersonId": 787,
      "Mrmrs": "iste",
      "Firstname": "Adela",
      "Lastname": "Brakus",
      "MiddleName": "Morissette-Murphy",
      "Title": "soluta",
      "Description": "Sharable empowering task-force",
      "Email": "frederik@strosinratke.ca",
      "FullName": "Mr. Alyson Darion Hoppe III",
      "DirectPhone": "039-050-7565",
      "FormalName": "Langosh-Powlowski",
      "CountryId": 298,
      "ContactId": 857,
      "ContactName": "Daugherty-Conn",
      "Retired": 877,
      "Rank": 921,
      "ActiveInterests": 124,
      "ContactDepartment": "utilize cutting-edge e-business",
      "ContactCountryId": 974,
      "ContactOrgNr": "940447",
      "FaxPhone": "702-092-5518",
      "MobilePhone": "958.718.8305",
      "ContactPhone": "1-553-379-8182",
      "AssociateName": "Daugherty, Cremin and Conroy",
      "AssociateId": 316,
      "UsePersonAddress": false,
      "ContactFax": "iure",
      "Kanafname": "rerum",
      "Kanalname": "omnis",
      "Post1": "voluptas",
      "Post2": "corporis",
      "Post3": "labore",
      "EmailName": "clint@bednar.ca",
      "ContactFullName": "Elaina Quigley",
      "ActiveErpLinks": 440,
      "TicketPriorityId": 245,
      "SupportLanguageId": 397,
      "SupportAssociateId": 487,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 919
        }
      }
    }
  ],
  "AlertLevel": 516,
  "ConnectId": 613,
  "ReadStatus": "Green",
  "TimeToReply": 518,
  "RealTimeToReply": 849,
  "TimeToClose": 770,
  "RealTimeToClose": 911,
  "TimeSpentInternally": 689,
  "TimeSpentExternally": 151,
  "TimeSpentQueue": 238,
  "RealTimeSpentInternally": 804,
  "RealTimeSpentExternally": 635,
  "RealTimeSpentQueue": 395,
  "TimeSpent": 466,
  "HasAttachment": false,
  "NumReplies": 207,
  "NumMessages": 545,
  "FromAddress": "quaerat",
  "Messages": [
    {
      "TicketMessageId": 674,
      "CreatedAt": "2010-11-22T03:24:48.3466522+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "exercitationem",
      "PersonId": 574,
      "PersonFullName": "Ramon Monahan",
      "ContactId": 905,
      "ContactName": "Abshire, Carroll and Beahan",
      "ContactDepartment": "",
      "NumAttachments": 541,
      "EmailHeader": "katherine.pollich@torphywindler.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "sed",
      "Sentiment": 891,
      "SentimentConfidence": 901,
      "CreatedBy": 869,
      "ChangedAt": "2002-11-22T03:24:48.3622749+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 73
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 475,
      "Name": "Goyette Group",
      "ToolTip": "Voluptas sed repellendus dolore quaerat aut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 603
        }
      }
    },
    {
      "Id": 475,
      "Name": "Goyette Group",
      "ToolTip": "Voluptas sed repellendus dolore quaerat aut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 603
        }
      }
    }
  ],
  "Language": "iure",
  "Sentiment": 316,
  "SentimentConfidence": 793,
  "SuggestedCategoryId": 378,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 779,
  "IconHint": "iusto",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "optio",
    "ExtraFields2": "architecto"
  },
  "CustomFields": {
    "CustomFields1": "nesciunt",
    "CustomFields2": "quidem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 190
    }
  }
}
```