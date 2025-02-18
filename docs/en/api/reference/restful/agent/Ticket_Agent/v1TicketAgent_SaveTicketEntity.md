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
| TicketType | TicketType | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
| ActiveStatusMonitorId | Integer | Active status monitor identity for related contact. This is a read-only property and is ignored on Save |
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
| OwnedBy | Associate | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  Use MDO List name "associate" to get list items. |
| Category | TicketCategoryEntity | The ticket category entity which this ticket is connected to  Use MDO List name "ejcategory" to get list items. |
| Slevel | string | The securitylevel of the ticket. |
| Priority | TicketPriorityEntity | The ticket priority entity which this ticket is connected to  Use MDO List name "ticketpriority" to get list items. |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  Use MDO List name "ticketstatus" to get list items. |
| Status | TicketStatusEntity | The ticket status entity which this ticket is connected to  Use MDO List name "ticketstatus" to get list items. |
| Origin | string | What is the origin of this ticket |
| Person | Person | The primary person that this ticket is connected to  Use MDO List name "person_new" to get list items. |
| SecondaryPersons | array | The secondary persons this ticket is connected to  Use MDO List name "person_new" to get list items. |
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
| Sale | Sale | The sale that this ticket is connected to  Use MDO List name "sale" to get list items. |
| Project | Project | The project that this ticket is connected to  Use MDO List name "project" to get list items. |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| TicketType | TicketType | Type of the Request  Use MDO List name "TicketType" to get list items. |
| ActiveStatusMonitorId | int32 | Active status monitor identity for related contact. This is a read-only property and is ignored on Save |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
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
  "TicketId": 573,
  "Title": "blanditiis",
  "CreatedAt": "1999-04-07T14:32:03.9991039+02:00",
  "LastChanged": "2003-10-10T14:32:03.9991039+02:00",
  "ReadByOwner": "2014-05-16T14:32:03.9991039+02:00",
  "ReadByCustomer": "1999-03-31T14:32:03.9991039+02:00",
  "FirstReadByOwner": "2003-10-16T14:32:03.9991039+02:00",
  "FirstReadByUser": "2019-05-29T14:32:03.9991039+02:00",
  "Activate": "2014-04-04T14:32:03.9991039+02:00",
  "ClosedAt": "2001-07-05T14:32:03.9991039+02:00",
  "RepliedAt": "2001-06-27T14:32:03.9991039+02:00",
  "AlertTimeout": "2016-04-15T14:32:03.9991039+02:00",
  "Deadline": "2016-12-24T14:32:03.9991039+01:00",
  "CreatedBy": null,
  "Author": "voluptatem",
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
      "Position": "ad",
      "PersonId": 214,
      "Mrmrs": "est",
      "Firstname": "Axel",
      "Lastname": "Feil",
      "MiddleName": "Daniel LLC",
      "Title": "eum",
      "Description": "Re-contextualized dedicated synergy",
      "Email": "stephanie@trantowjacobson.name",
      "FullName": "Connor Strosin",
      "DirectPhone": "553-491-4863 x79044",
      "FormalName": "Hintz LLC",
      "CountryId": 877,
      "ContactId": 98,
      "ContactName": "Collier Inc and Sons",
      "Retired": 592,
      "Rank": 756,
      "ActiveInterests": 492,
      "ContactDepartment": "",
      "ContactCountryId": 221,
      "ContactOrgNr": "782134",
      "FaxPhone": "1-281-382-8513",
      "MobilePhone": "1-648-046-9384",
      "ContactPhone": "1-598-136-8375 x04999",
      "AssociateName": "Jewess LLC",
      "AssociateId": 157,
      "UsePersonAddress": false,
      "ContactFax": "temporibus",
      "Kanafname": "aliquam",
      "Kanalname": "voluptatum",
      "Post1": "architecto",
      "Post2": "id",
      "Post3": "quo",
      "EmailName": "eileen.purdy@leannon.info",
      "ContactFullName": "Mr. Verlie Ottilie Stiedemann Sr.",
      "ActiveErpLinks": 982,
      "TicketPriorityId": 358,
      "SupportLanguageId": 511,
      "SupportAssociateId": 455,
      "CategoryName": "VIP Customer",
      "PersonNumber": "931631"
    }
  ],
  "AlertLevel": 600,
  "ConnectId": 190,
  "ReadStatus": "Green",
  "TimeToReply": 133,
  "RealTimeToReply": 358,
  "TimeToClose": 801,
  "RealTimeToClose": 499,
  "TimeSpentInternally": 491,
  "TimeSpentExternally": 159,
  "TimeSpentQueue": 427,
  "RealTimeSpentInternally": 773,
  "RealTimeSpentExternally": 870,
  "RealTimeSpentQueue": 584,
  "TimeSpent": 346,
  "HasAttachment": true,
  "NumReplies": 206,
  "NumMessages": 126,
  "FromAddress": "dolorum",
  "Messages": [
    {
      "TicketMessageId": 438,
      "CreatedAt": "1999-01-01T14:32:04.0147233+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "doloremque",
      "PersonId": 868,
      "PersonFullName": "Jacky Klein",
      "ContactId": 38,
      "ContactName": "Larkin LLC",
      "ContactDepartment": "",
      "NumAttachments": 804,
      "EmailHeader": "tyshawn.sporer@stammtorphy.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "eum",
      "Sentiment": 631,
      "SentimentConfidence": 943,
      "CreatedBy": 660,
      "ChangedAt": "1999-09-24T14:32:04.0147233+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 282,
      "Name": "Koss LLC",
      "ToolTip": "Et quis aut."
    },
    {
      "Id": 282,
      "Name": "Koss LLC",
      "ToolTip": "Et quis aut."
    }
  ],
  "Language": "deserunt",
  "Sentiment": 691,
  "SentimentConfidence": 423,
  "SuggestedCategoryId": 123,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 959,
  "IconHint": "qui",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 473,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "ducimus"
  },
  "CustomFields": {
    "CustomFields1": "iste",
    "CustomFields2": "magnam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 803,
  "Title": "perferendis",
  "CreatedAt": "2017-12-03T14:32:04.0147233+01:00",
  "LastChanged": "2001-09-29T14:32:04.0147233+02:00",
  "ReadByOwner": "2019-09-16T14:32:04.0147233+02:00",
  "ReadByCustomer": "2022-08-06T14:32:04.0147233+02:00",
  "FirstReadByOwner": "2022-08-01T14:32:04.0147233+02:00",
  "FirstReadByUser": "2018-12-24T14:32:04.0147233+01:00",
  "Activate": "1997-10-21T14:32:04.0147233+02:00",
  "ClosedAt": "2009-10-04T14:32:04.0147233+02:00",
  "RepliedAt": "2010-11-14T14:32:04.0147233+01:00",
  "AlertTimeout": "2011-09-05T14:32:04.0147233+02:00",
  "Deadline": "2013-10-11T14:32:04.0147233+02:00",
  "CreatedBy": null,
  "Author": "quia",
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
      "Position": "tempora",
      "PersonId": 720,
      "Mrmrs": "sed",
      "Firstname": "Werner",
      "Lastname": "Kohler",
      "MiddleName": "Boyle, Gorczany and Terry",
      "Title": "quis",
      "Description": "Cross-group multimedia application",
      "Email": "sonya_osinski@marvin.biz",
      "FullName": "Gino Reinger Sr.",
      "DirectPhone": "(460)133-0752",
      "FormalName": "McKenzie, Stroman and McGlynn",
      "CountryId": 285,
      "ContactId": 893,
      "ContactName": "Runolfsson-Hackett",
      "Retired": 433,
      "Rank": 986,
      "ActiveInterests": 941,
      "ContactDepartment": "",
      "ContactCountryId": 141,
      "ContactOrgNr": "1368098",
      "FaxPhone": "(189)242-7258 x9818",
      "MobilePhone": "397-572-9821",
      "ContactPhone": "586.556.4605 x15729",
      "AssociateName": "Waelchi-Lehner",
      "AssociateId": 761,
      "UsePersonAddress": true,
      "ContactFax": "beatae",
      "Kanafname": "excepturi",
      "Kanalname": "rerum",
      "Post1": "libero",
      "Post2": "qui",
      "Post3": "qui",
      "EmailName": "vidal@brown.ca",
      "ContactFullName": "Bart Lehner",
      "ActiveErpLinks": 449,
      "TicketPriorityId": 392,
      "SupportLanguageId": 726,
      "SupportAssociateId": 37,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1194061",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 440
        }
      }
    }
  ],
  "AlertLevel": 631,
  "ConnectId": 323,
  "ReadStatus": "Green",
  "TimeToReply": 797,
  "RealTimeToReply": 533,
  "TimeToClose": 837,
  "RealTimeToClose": 528,
  "TimeSpentInternally": 804,
  "TimeSpentExternally": 200,
  "TimeSpentQueue": 552,
  "RealTimeSpentInternally": 919,
  "RealTimeSpentExternally": 421,
  "RealTimeSpentQueue": 5,
  "TimeSpent": 864,
  "HasAttachment": false,
  "NumReplies": 167,
  "NumMessages": 626,
  "FromAddress": "optio",
  "Messages": [
    {
      "TicketMessageId": 590,
      "CreatedAt": "2024-06-10T14:32:04.0147233+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "enim",
      "PersonId": 510,
      "PersonFullName": "Marianne Jacobs",
      "ContactId": 581,
      "ContactName": "Stark Group",
      "ContactDepartment": "enhance frictionless supply-chains",
      "NumAttachments": 814,
      "EmailHeader": "jazlyn_ullrich@danielharber.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ullam",
      "Sentiment": 591,
      "SentimentConfidence": 659,
      "CreatedBy": 954,
      "ChangedAt": "2003-07-01T14:32:04.0147233+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 227
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 314,
      "Name": "Lindgren LLC",
      "ToolTip": "Libero porro vel sunt dignissimos.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 169
        }
      }
    },
    {
      "Id": 314,
      "Name": "Lindgren LLC",
      "ToolTip": "Libero porro vel sunt dignissimos.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 169
        }
      }
    }
  ],
  "Language": "est",
  "Sentiment": 444,
  "SentimentConfidence": 826,
  "SuggestedCategoryId": 858,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 589,
  "IconHint": "est",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 303,
  "ExtraFields": {
    "ExtraFields1": "pariatur",
    "ExtraFields2": "voluptatum"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "est"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 760
    }
  }
}
```