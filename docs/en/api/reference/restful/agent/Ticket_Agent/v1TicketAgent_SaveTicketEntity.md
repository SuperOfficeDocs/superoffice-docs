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
  "TicketId": 347,
  "Title": "ea",
  "CreatedAt": "2000-03-30T16:32:40.1957679+02:00",
  "LastChanged": "2007-02-08T16:32:40.1957679+01:00",
  "ReadByOwner": "2005-08-08T16:32:40.1957679+02:00",
  "ReadByCustomer": "2018-02-24T16:32:40.1957679+01:00",
  "FirstReadByOwner": "2002-10-31T16:32:40.1957679+01:00",
  "FirstReadByUser": "2020-12-02T16:32:40.1957679+01:00",
  "Activate": "2008-03-28T16:32:40.1957679+01:00",
  "ClosedAt": "2013-01-21T16:32:40.1957679+01:00",
  "RepliedAt": "2012-04-20T16:32:40.1957679+02:00",
  "AlertTimeout": "2023-01-16T16:32:40.1957679+01:00",
  "Deadline": "2020-08-12T16:32:40.1957679+02:00",
  "CreatedBy": null,
  "Author": "alias",
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
      "Position": "est",
      "PersonId": 740,
      "Mrmrs": "fugit",
      "Firstname": "Pearl",
      "Lastname": "O'Reilly",
      "MiddleName": "Hermann Group",
      "Title": "aut",
      "Description": "Organic high-level conglomeration",
      "Email": "grant@mclaughlintromp.co.uk",
      "FullName": "Mrs. Johan Duncan Ratke Sr.",
      "DirectPhone": "946.666.5845 x656",
      "FormalName": "Barton, Quitzon and Cremin",
      "CountryId": 338,
      "ContactId": 851,
      "ContactName": "Roob-Wehner",
      "Retired": 715,
      "Rank": 194,
      "ActiveInterests": 269,
      "ContactDepartment": "incubate open-source deliverables",
      "ContactCountryId": 230,
      "ContactOrgNr": "1388791",
      "FaxPhone": "(821)117-4602",
      "MobilePhone": "1-792-755-5856",
      "ContactPhone": "(826)999-7546 x06160",
      "AssociateName": "Buckridge-Goyette",
      "AssociateId": 229,
      "UsePersonAddress": false,
      "ContactFax": "dolorum",
      "Kanafname": "nesciunt",
      "Kanalname": "nisi",
      "Post1": "sit",
      "Post2": "et",
      "Post3": "eum",
      "EmailName": "brittany.keebler@lednerkirlin.info",
      "ContactFullName": "Dr. Teagan Hudson",
      "ActiveErpLinks": 503,
      "TicketPriorityId": 60,
      "SupportLanguageId": 356,
      "SupportAssociateId": 63,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1335823"
    }
  ],
  "AlertLevel": 897,
  "ConnectId": 233,
  "ReadStatus": "Green",
  "TimeToReply": 334,
  "RealTimeToReply": 777,
  "TimeToClose": 159,
  "RealTimeToClose": 83,
  "TimeSpentInternally": 887,
  "TimeSpentExternally": 582,
  "TimeSpentQueue": 3,
  "RealTimeSpentInternally": 429,
  "RealTimeSpentExternally": 90,
  "RealTimeSpentQueue": 470,
  "TimeSpent": 652,
  "HasAttachment": true,
  "NumReplies": 398,
  "NumMessages": 440,
  "FromAddress": "labore",
  "Messages": [
    {
      "TicketMessageId": 309,
      "CreatedAt": "2011-10-26T16:32:40.1957679+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "quis",
      "PersonId": 106,
      "PersonFullName": "Ms. Devin Jerde MD",
      "ContactId": 875,
      "ContactName": "Murphy, Nitzsche and Kirlin",
      "ContactDepartment": "integrate e-business architectures",
      "NumAttachments": 278,
      "EmailHeader": "lorenzo_emard@wehner.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "repellendus",
      "Sentiment": 508,
      "SentimentConfidence": 870,
      "CreatedBy": 709,
      "ChangedAt": "2014-12-21T16:32:40.1957679+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 552,
      "Name": "Hand-Cronin",
      "ToolTip": "Sit est."
    },
    {
      "Id": 552,
      "Name": "Hand-Cronin",
      "ToolTip": "Sit est."
    }
  ],
  "Language": "quae",
  "Sentiment": 876,
  "SentimentConfidence": 805,
  "SuggestedCategoryId": 442,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 344,
  "IconHint": "quis",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 971,
  "ExtraFields": {
    "ExtraFields1": "repellendus",
    "ExtraFields2": "vitae"
  },
  "CustomFields": {
    "CustomFields1": "possimus",
    "CustomFields2": "mollitia"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 545,
  "Title": "ut",
  "CreatedAt": "2021-05-05T16:32:40.1957679+02:00",
  "LastChanged": "2009-07-06T16:32:40.1957679+02:00",
  "ReadByOwner": "2007-12-08T16:32:40.1957679+01:00",
  "ReadByCustomer": "2000-01-21T16:32:40.1957679+01:00",
  "FirstReadByOwner": "2017-03-17T16:32:40.1957679+01:00",
  "FirstReadByUser": "2004-10-30T16:32:40.1957679+02:00",
  "Activate": "2011-06-25T16:32:40.1957679+02:00",
  "ClosedAt": "2000-08-18T16:32:40.1957679+02:00",
  "RepliedAt": "1998-06-10T16:32:40.1957679+02:00",
  "AlertTimeout": "2019-06-21T16:32:40.1957679+02:00",
  "Deadline": "2005-02-24T16:32:40.1957679+01:00",
  "CreatedBy": null,
  "Author": "quas",
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
      "Position": "commodi",
      "PersonId": 548,
      "Mrmrs": "rerum",
      "Firstname": "Candelario",
      "Lastname": "McCullough",
      "MiddleName": "Marks, Heathcote and Hansen",
      "Title": "dolorum",
      "Description": "Synergistic 5th generation alliance",
      "Email": "grayce@kossmcglynn.co.uk",
      "FullName": "Tyshawn Daniel",
      "DirectPhone": "381.831.1768 x018",
      "FormalName": "Howell, Daugherty and Johnson",
      "CountryId": 414,
      "ContactId": 115,
      "ContactName": "Kulas-Weimann",
      "Retired": 663,
      "Rank": 849,
      "ActiveInterests": 195,
      "ContactDepartment": "",
      "ContactCountryId": 22,
      "ContactOrgNr": "359346",
      "FaxPhone": "(024)132-1564",
      "MobilePhone": "1-462-759-1605",
      "ContactPhone": "722.114.9504 x586",
      "AssociateName": "Russel Inc and Sons",
      "AssociateId": 798,
      "UsePersonAddress": false,
      "ContactFax": "dolores",
      "Kanafname": "dolorem",
      "Kanalname": "et",
      "Post1": "molestias",
      "Post2": "aut",
      "Post3": "voluptatem",
      "EmailName": "colton_zemlak@baileyspinka.info",
      "ContactFullName": "Prof. Aaliyah Turner",
      "ActiveErpLinks": 28,
      "TicketPriorityId": 716,
      "SupportLanguageId": 527,
      "SupportAssociateId": 293,
      "CategoryName": "VIP Customer",
      "PersonNumber": "176590",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 958
        }
      }
    }
  ],
  "AlertLevel": 874,
  "ConnectId": 300,
  "ReadStatus": "Green",
  "TimeToReply": 109,
  "RealTimeToReply": 712,
  "TimeToClose": 922,
  "RealTimeToClose": 165,
  "TimeSpentInternally": 803,
  "TimeSpentExternally": 825,
  "TimeSpentQueue": 918,
  "RealTimeSpentInternally": 777,
  "RealTimeSpentExternally": 415,
  "RealTimeSpentQueue": 906,
  "TimeSpent": 690,
  "HasAttachment": false,
  "NumReplies": 277,
  "NumMessages": 81,
  "FromAddress": "ad",
  "Messages": [
    {
      "TicketMessageId": 535,
      "CreatedAt": "2012-02-26T16:32:40.2113903+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "sit",
      "PersonId": 92,
      "PersonFullName": "Mrs. Clarabelle Hegmann PhD",
      "ContactId": 907,
      "ContactName": "Fay LLC",
      "ContactDepartment": "",
      "NumAttachments": 839,
      "EmailHeader": "kiana@ratkehalvorson.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "excepturi",
      "Sentiment": 896,
      "SentimentConfidence": 209,
      "CreatedBy": 844,
      "ChangedAt": "2015-08-01T16:32:40.2113903+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 55
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 743,
      "Name": "Koelpin-Maggio",
      "ToolTip": "Et ut eum consequuntur molestias.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 440
        }
      }
    },
    {
      "Id": 743,
      "Name": "Koelpin-Maggio",
      "ToolTip": "Et ut eum consequuntur molestias.",
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
  "Language": "eos",
  "Sentiment": 788,
  "SentimentConfidence": 750,
  "SuggestedCategoryId": 516,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 63,
  "IconHint": "ea",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 864,
  "ExtraFields": {
    "ExtraFields1": "occaecati",
    "ExtraFields2": "deleniti"
  },
  "CustomFields": {
    "CustomFields1": "at",
    "CustomFields2": "consequuntur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 251
    }
  }
}
```