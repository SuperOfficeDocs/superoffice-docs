---
title: POST Agents/Ticket/SaveTicketEntity
uid: v1TicketAgent_SaveTicketEntity
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
POST /api/v1/Agents/Ticket/SaveTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 705,
  "Title": "autem",
  "CreatedAt": "2003-03-01T03:51:28.2558597+01:00",
  "LastChanged": "1997-01-24T03:51:28.2558597+01:00",
  "ReadByOwner": "2007-03-15T03:51:28.2558597+01:00",
  "ReadByCustomer": "2008-05-08T03:51:28.2558597+02:00",
  "FirstReadByOwner": "2018-12-08T03:51:28.2558597+01:00",
  "FirstReadByUser": "1996-11-28T03:51:28.2558597+01:00",
  "Activate": "2010-02-05T03:51:28.2558597+01:00",
  "ClosedAt": "2006-02-04T03:51:28.2558597+01:00",
  "RepliedAt": "1996-02-11T03:51:28.2558597+01:00",
  "AlertTimeout": "2009-09-04T03:51:28.2558597+02:00",
  "Deadline": "1997-06-02T03:51:28.2558597+02:00",
  "CreatedBy": null,
  "Author": "id",
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
      "Position": "accusantium",
      "PersonId": 27,
      "Mrmrs": "quisquam",
      "Firstname": "Lois",
      "Lastname": "Bailey",
      "MiddleName": "Kiehn-Grady",
      "Title": "tempora",
      "Description": "Polarised logistical emulation",
      "Email": "joe_spinka@erdman.com",
      "FullName": "Cleo Reichel",
      "DirectPhone": "591-240-7728",
      "FormalName": "Larson-Crona",
      "CountryId": 435,
      "ContactId": 560,
      "ContactName": "Schaefer-Koelpin",
      "Retired": 948,
      "Rank": 13,
      "ActiveInterests": 280,
      "ContactDepartment": "",
      "ContactCountryId": 96,
      "ContactOrgNr": "890411",
      "FaxPhone": "1-264-715-1586",
      "MobilePhone": "812.653.7739 x29487",
      "ContactPhone": "752.415.1482",
      "AssociateName": "Mills, Beier and Bosco",
      "AssociateId": 118,
      "UsePersonAddress": false,
      "ContactFax": "quis",
      "Kanafname": "ad",
      "Kanalname": "deleniti",
      "Post1": "soluta",
      "Post2": "occaecati",
      "Post3": "ab",
      "EmailName": "ulices@pagac.uk",
      "ContactFullName": "Mrs. Dusty Angelo Doyle DVM",
      "ActiveErpLinks": 371,
      "TicketPriorityId": 755,
      "SupportLanguageId": 539,
      "SupportAssociateId": 351,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 379,
  "ConnectId": 565,
  "ReadStatus": "Green",
  "TimeToReply": 753,
  "RealTimeToReply": 184,
  "TimeToClose": 456,
  "RealTimeToClose": 53,
  "TimeSpentInternally": 266,
  "TimeSpentExternally": 498,
  "TimeSpentQueue": 909,
  "RealTimeSpentInternally": 82,
  "RealTimeSpentExternally": 44,
  "RealTimeSpentQueue": 196,
  "HasAttachment": true,
  "NumReplies": 657,
  "NumMessages": 850,
  "FromAddress": "veritatis",
  "Messages": [
    {
      "TicketMessageId": 446,
      "CreatedAt": "2011-05-09T03:51:28.2714725+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "sint",
      "PersonId": 82,
      "PersonFullName": "Dr. Freida Kessler MD",
      "ContactId": 720,
      "ContactName": "Bergstrom, D'Amore and Stamm",
      "ContactDepartment": "",
      "NumAttachments": 555,
      "EmailHeader": "bonita@gorczanyabbott.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "voluptas",
      "Sentiment": 963,
      "SentimentConfidence": 879,
      "CreatedBy": 977,
      "ChangedAt": "2022-05-16T03:51:28.2714725+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 577,
      "Name": "Bartoletti-Wyman",
      "ToolTip": "Et soluta et aut sed ut omnis sunt."
    },
    {
      "Id": 577,
      "Name": "Bartoletti-Wyman",
      "ToolTip": "Et soluta et aut sed ut omnis sunt."
    }
  ],
  "Language": "reprehenderit",
  "Sentiment": 705,
  "SentimentConfidence": 961,
  "SuggestedCategoryId": 806,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 737,
  "IconHint": "voluptas",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "eveniet",
    "ExtraFields2": "molestias"
  },
  "CustomFields": {
    "CustomFields1": "doloremque",
    "CustomFields2": "aut"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 419,
  "Title": "itaque",
  "CreatedAt": "1998-03-03T03:51:28.2714725+01:00",
  "LastChanged": "2009-05-09T03:51:28.2714725+02:00",
  "ReadByOwner": "2012-05-05T03:51:28.2714725+02:00",
  "ReadByCustomer": "2005-01-26T03:51:28.2714725+01:00",
  "FirstReadByOwner": "2001-05-01T03:51:28.2714725+02:00",
  "FirstReadByUser": "2001-03-19T03:51:28.2714725+01:00",
  "Activate": "2018-06-02T03:51:28.2714725+02:00",
  "ClosedAt": "2019-06-04T03:51:28.2714725+02:00",
  "RepliedAt": "2018-04-14T03:51:28.2714725+02:00",
  "AlertTimeout": "2004-05-13T03:51:28.2714725+02:00",
  "Deadline": "2017-12-02T03:51:28.2714725+01:00",
  "CreatedBy": null,
  "Author": "sunt",
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
      "Position": "et",
      "PersonId": 944,
      "Mrmrs": "aut",
      "Firstname": "Elton",
      "Lastname": "Sawayn",
      "MiddleName": "Weber-Schmitt",
      "Title": "magni",
      "Description": "Ameliorated uniform leverage",
      "Email": "alf.towne@ricepredovic.us",
      "FullName": "Donavon Ruecker IV",
      "DirectPhone": "994-063-6048 x071",
      "FormalName": "Batz LLC",
      "CountryId": 383,
      "ContactId": 75,
      "ContactName": "Gerhold-Cruickshank",
      "Retired": 968,
      "Rank": 758,
      "ActiveInterests": 112,
      "ContactDepartment": "",
      "ContactCountryId": 880,
      "ContactOrgNr": "1564443",
      "FaxPhone": "295.579.8829 x464",
      "MobilePhone": "(165)968-0390",
      "ContactPhone": "895.651.6316 x50868",
      "AssociateName": "Doyle LLC",
      "AssociateId": 789,
      "UsePersonAddress": true,
      "ContactFax": "officia",
      "Kanafname": "et",
      "Kanalname": "dicta",
      "Post1": "et",
      "Post2": "enim",
      "Post3": "error",
      "EmailName": "murl@reilly.co.uk",
      "ContactFullName": "Kaelyn Kenyon Cremin III",
      "ActiveErpLinks": 529,
      "TicketPriorityId": 144,
      "SupportLanguageId": 520,
      "SupportAssociateId": 498,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 972
        }
      }
    }
  ],
  "AlertLevel": 679,
  "ConnectId": 767,
  "ReadStatus": "Green",
  "TimeToReply": 5,
  "RealTimeToReply": 552,
  "TimeToClose": 211,
  "RealTimeToClose": 781,
  "TimeSpentInternally": 8,
  "TimeSpentExternally": 143,
  "TimeSpentQueue": 750,
  "RealTimeSpentInternally": 565,
  "RealTimeSpentExternally": 518,
  "RealTimeSpentQueue": 75,
  "HasAttachment": true,
  "NumReplies": 934,
  "NumMessages": 905,
  "FromAddress": "velit",
  "Messages": [
    {
      "TicketMessageId": 891,
      "CreatedAt": "2004-09-13T03:51:28.2714725+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "a",
      "PersonId": 469,
      "PersonFullName": "Cameron Ethan Emard III",
      "ContactId": 884,
      "ContactName": "Hammes, Wiza and Nienow",
      "ContactDepartment": "cultivate web-enabled relationships",
      "NumAttachments": 899,
      "EmailHeader": "lyla.mayer@dietrich.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "voluptas",
      "Sentiment": 44,
      "SentimentConfidence": 327,
      "CreatedBy": 186,
      "ChangedAt": "1999-10-12T03:51:28.2714725+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 855
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 792,
      "Name": "Green Inc and Sons",
      "ToolTip": "Id consequatur sed quos aut dignissimos.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 694
        }
      }
    },
    {
      "Id": 792,
      "Name": "Green Inc and Sons",
      "ToolTip": "Id consequatur sed quos aut dignissimos.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 694
        }
      }
    }
  ],
  "Language": "tempore",
  "Sentiment": 407,
  "SentimentConfidence": 268,
  "SuggestedCategoryId": 515,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 480,
  "IconHint": "recusandae",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "autem",
    "ExtraFields2": "maiores"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "id"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 282
    }
  }
}
```