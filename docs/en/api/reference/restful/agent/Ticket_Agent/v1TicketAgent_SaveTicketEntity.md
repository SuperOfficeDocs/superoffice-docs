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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Ticket/SaveTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 415,
  "Title": "sunt",
  "CreatedAt": "2020-08-11T17:37:19.2792409+02:00",
  "LastChanged": "2010-07-15T17:37:19.2792409+02:00",
  "ReadByOwner": "2000-01-05T17:37:19.2792409+01:00",
  "ReadByCustomer": "2010-02-01T17:37:19.2792409+01:00",
  "FirstReadByOwner": "2003-02-18T17:37:19.2792409+01:00",
  "FirstReadByUser": "1999-01-17T17:37:19.2792409+01:00",
  "Activate": "2000-06-06T17:37:19.2792409+02:00",
  "ClosedAt": "2014-04-24T17:37:19.2792409+02:00",
  "RepliedAt": "1999-07-13T17:37:19.2792409+02:00",
  "AlertTimeout": "2017-03-14T17:37:19.2792409+01:00",
  "Deadline": "2021-03-13T17:37:19.2792409+01:00",
  "CreatedBy": null,
  "Author": "libero",
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
      "Position": "id",
      "PersonId": 755,
      "Mrmrs": "modi",
      "Firstname": "Axel",
      "Lastname": "Gorczany",
      "MiddleName": "Parisian, Raynor and Koch",
      "Title": "sit",
      "Description": "Operative next generation flexibility",
      "Email": "destinee.schmitt@macejkovic.biz",
      "FullName": "Bernardo Aufderhar",
      "DirectPhone": "(303)471-6489",
      "FormalName": "Feest, Gulgowski and Batz",
      "CountryId": 235,
      "ContactId": 922,
      "ContactName": "Corwin, Hessel and Jacobson",
      "Retired": 846,
      "Rank": 187,
      "ActiveInterests": 586,
      "ContactDepartment": "",
      "ContactCountryId": 337,
      "ContactOrgNr": "772534",
      "FaxPhone": "1-499-718-8465 x602",
      "MobilePhone": "362-761-9910 x98655",
      "ContactPhone": "1-057-007-5186 x205",
      "AssociateName": "Bernier LLC",
      "AssociateId": 944,
      "UsePersonAddress": true,
      "ContactFax": "deserunt",
      "Kanafname": "voluptatibus",
      "Kanalname": "animi",
      "Post1": "quisquam",
      "Post2": "ut",
      "Post3": "temporibus",
      "EmailName": "josefa@daughertymann.ca",
      "ContactFullName": "Miss Edison Thompson Sr.",
      "ActiveErpLinks": 690,
      "TicketPriorityId": 628,
      "SupportLanguageId": 548,
      "SupportAssociateId": 198,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 750,
  "ConnectId": 873,
  "ReadStatus": "Green",
  "TimeToReply": 629,
  "RealTimeToReply": 389,
  "TimeToClose": 494,
  "RealTimeToClose": 637,
  "TimeSpentInternally": 201,
  "TimeSpentExternally": 211,
  "TimeSpentQueue": 531,
  "RealTimeSpentInternally": 250,
  "RealTimeSpentExternally": 658,
  "RealTimeSpentQueue": 239,
  "HasAttachment": false,
  "NumReplies": 188,
  "NumMessages": 446,
  "FromAddress": "et",
  "Messages": [
    {
      "TicketMessageId": 235,
      "CreatedAt": "2003-03-27T17:37:19.2832421+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "fugit",
      "PersonId": 233,
      "PersonFullName": "Izaiah Bernadette Bauch PhD",
      "ContactId": 870,
      "ContactName": "Murphy, Keeling and Heidenreich",
      "ContactDepartment": "",
      "NumAttachments": 848,
      "EmailHeader": "keyshawn_gorczany@watersoconnell.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ut",
      "Sentiment": 191,
      "SentimentConfidence": 309,
      "CreatedBy": 592,
      "ChangedAt": "2017-10-01T17:37:19.2842417+02:00"
    }
  ],
  "Tags": [
    {
      "Id": 221,
      "Name": "Senger, Kessler and Bartell",
      "ToolTip": "Velit exercitationem tempore vero."
    },
    {
      "Id": 221,
      "Name": "Senger, Kessler and Bartell",
      "ToolTip": "Velit exercitationem tempore vero."
    }
  ],
  "Language": "modi",
  "Sentiment": 659,
  "SentimentConfidence": 566,
  "SuggestedCategoryId": 889,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 97,
  "IconHint": "cupiditate",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "velit",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "similique",
    "CustomFields2": "quibusdam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 734,
  "Title": "qui",
  "CreatedAt": "2013-09-23T17:37:19.2932406+02:00",
  "LastChanged": "1996-06-24T17:37:19.2932406+02:00",
  "ReadByOwner": "2004-01-02T17:37:19.2932406+01:00",
  "ReadByCustomer": "2019-02-01T17:37:19.2932406+01:00",
  "FirstReadByOwner": "2003-01-13T17:37:19.2932406+01:00",
  "FirstReadByUser": "1997-01-22T17:37:19.2932406+01:00",
  "Activate": "2004-01-20T17:37:19.2932406+01:00",
  "ClosedAt": "1997-04-30T17:37:19.2932406+02:00",
  "RepliedAt": "2019-03-08T17:37:19.2932406+01:00",
  "AlertTimeout": "2009-12-09T17:37:19.2932406+01:00",
  "Deadline": "2021-07-25T17:37:19.2932406+02:00",
  "CreatedBy": null,
  "Author": "ducimus",
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
      "Position": "a",
      "PersonId": 521,
      "Mrmrs": "ea",
      "Firstname": "Steve",
      "Lastname": "Jaskolski",
      "MiddleName": "Durgan-Sawayn",
      "Title": "quam",
      "Description": "Enhanced composite application",
      "Email": "talia.gottlieb@gaylord.biz",
      "FullName": "Mr. Neoma Johnston",
      "DirectPhone": "(953)142-2755",
      "FormalName": "Sanford LLC",
      "CountryId": 657,
      "ContactId": 229,
      "ContactName": "Jaskolski LLC",
      "Retired": 316,
      "Rank": 994,
      "ActiveInterests": 231,
      "ContactDepartment": "",
      "ContactCountryId": 253,
      "ContactOrgNr": "1888188",
      "FaxPhone": "940-847-5569 x456",
      "MobilePhone": "(793)581-6118",
      "ContactPhone": "1-940-860-9206",
      "AssociateName": "O'Reilly-O'Conner",
      "AssociateId": 234,
      "UsePersonAddress": true,
      "ContactFax": "eos",
      "Kanafname": "omnis",
      "Kanalname": "nostrum",
      "Post1": "nam",
      "Post2": "in",
      "Post3": "aspernatur",
      "EmailName": "deshaun_green@mcglynnharris.biz",
      "ContactFullName": "Giovanni Mueller",
      "ActiveErpLinks": 484,
      "TicketPriorityId": 696,
      "SupportLanguageId": 68,
      "SupportAssociateId": 988,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 220
        }
      }
    }
  ],
  "AlertLevel": 49,
  "ConnectId": 369,
  "ReadStatus": "Green",
  "TimeToReply": 212,
  "RealTimeToReply": 246,
  "TimeToClose": 930,
  "RealTimeToClose": 639,
  "TimeSpentInternally": 93,
  "TimeSpentExternally": 611,
  "TimeSpentQueue": 371,
  "RealTimeSpentInternally": 939,
  "RealTimeSpentExternally": 650,
  "RealTimeSpentQueue": 886,
  "HasAttachment": true,
  "NumReplies": 172,
  "NumMessages": 827,
  "FromAddress": "porro",
  "Messages": [
    {
      "TicketMessageId": 619,
      "CreatedAt": "2000-02-10T17:37:19.2982427+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "ea",
      "PersonId": 754,
      "PersonFullName": "Vida Jennifer Donnelly IV",
      "ContactId": 214,
      "ContactName": "Kuphal Group",
      "ContactDepartment": "",
      "NumAttachments": 603,
      "EmailHeader": "mabel.kshlerin@bayer.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "asperiores",
      "Sentiment": 267,
      "SentimentConfidence": 724,
      "CreatedBy": 876,
      "ChangedAt": "2003-01-31T17:37:19.2992578+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 135
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 161,
      "Name": "Luettgen-Cassin",
      "ToolTip": "Eaque dolore ipsam rem repudiandae accusamus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 111
        }
      }
    },
    {
      "Id": 161,
      "Name": "Luettgen-Cassin",
      "ToolTip": "Eaque dolore ipsam rem repudiandae accusamus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 111
        }
      }
    }
  ],
  "Language": "enim",
  "Sentiment": 236,
  "SentimentConfidence": 954,
  "SuggestedCategoryId": 989,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 364,
  "IconHint": "eos",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "beatae",
    "ExtraFields2": "tempora"
  },
  "CustomFields": {
    "CustomFields1": "laboriosam",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 951
    }
  }
}
```