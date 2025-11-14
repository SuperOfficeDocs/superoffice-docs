---
title: POST Agents/Ticket/SaveTicketEntity
uid: v1TicketAgent_SaveTicketEntity
generated: true
content_type: reference
---

# POST Agents/Ticket/SaveTicketEntity

```http
POST /api/v1/Agents/Ticket/SaveTicketEntity
```

Updates the existing TicketEntity or creates a new TicketEntity if the id parameter is 0.


Does not notify users of save.
NsApiSlow threshold: 2000 ms.







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

## Request Body: ticketEntity 

The TicketEntity that is saved 

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
  "TicketId": 767,
  "Title": "nihil",
  "CreatedAt": "2017-11-28T02:30:47.8819394+01:00",
  "LastChanged": "2016-01-18T02:30:47.8819394+01:00",
  "ReadByOwner": "2017-09-28T02:30:47.8819394+02:00",
  "ReadByCustomer": "2020-05-18T02:30:47.8819394+02:00",
  "FirstReadByOwner": "2022-01-24T02:30:47.8819394+01:00",
  "FirstReadByUser": "2008-01-21T02:30:47.8819394+01:00",
  "Activate": "1999-11-14T02:30:47.8819394+01:00",
  "ClosedAt": "2019-07-04T02:30:47.8819394+02:00",
  "RepliedAt": "2024-02-28T02:30:47.8819394+01:00",
  "AlertTimeout": "2016-07-02T02:30:47.8819394+02:00",
  "Deadline": "2007-12-30T02:30:47.8819394+01:00",
  "CreatedBy": null,
  "Author": "architecto",
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
      "Position": "laboriosam",
      "PersonId": 994,
      "Mrmrs": "quo",
      "Firstname": "Trevor",
      "Lastname": "Glover",
      "MiddleName": "Kozey-D'Amore",
      "Title": "beatae",
      "Description": "Open-source attitude-oriented product",
      "Email": "jordy.senger@metz.name",
      "FullName": "Mr. Kyla Naomie Hegmann IV",
      "DirectPhone": "963.690.9024",
      "FormalName": "Tromp LLC",
      "CountryId": 296,
      "ContactId": 475,
      "ContactName": "Dare-Durgan",
      "Retired": 580,
      "Rank": 159,
      "ActiveInterests": 980,
      "ContactDepartment": "",
      "ContactCountryId": 734,
      "ContactOrgNr": "1224126",
      "FaxPhone": "1-578-962-6406",
      "MobilePhone": "1-098-368-6868",
      "ContactPhone": "850.187.3212",
      "AssociateName": "Labadie-O'Keefe",
      "AssociateId": 13,
      "UsePersonAddress": true,
      "ContactFax": "ut",
      "Kanafname": "quas",
      "Kanalname": "in",
      "Post1": "quasi",
      "Post2": "commodi",
      "Post3": "enim",
      "EmailName": "elaina.pacocha@hoeger.name",
      "ContactFullName": "Vivianne Skiles",
      "ActiveErpLinks": 792,
      "TicketPriorityId": 699,
      "SupportLanguageId": 570,
      "SupportAssociateId": 769,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1217886"
    }
  ],
  "AlertLevel": 769,
  "ConnectId": 382,
  "ReadStatus": "Green",
  "TimeToReply": 865,
  "RealTimeToReply": 866,
  "TimeToClose": 635,
  "RealTimeToClose": 492,
  "TimeSpentInternally": 467,
  "TimeSpentExternally": 78,
  "TimeSpentQueue": 68,
  "RealTimeSpentInternally": 478,
  "RealTimeSpentExternally": 968,
  "RealTimeSpentQueue": 481,
  "TimeSpent": 149,
  "HasAttachment": false,
  "NumReplies": 896,
  "NumMessages": 713,
  "FromAddress": "aut",
  "Messages": [
    {
      "TicketMessageId": 554,
      "CreatedAt": "2022-11-27T02:30:47.8975637+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "voluptas",
      "PersonId": 628,
      "PersonFullName": "Ms. Houston Konopelski PhD",
      "ContactId": 641,
      "ContactName": "Reynolds-Murazik",
      "ContactDepartment": "",
      "NumAttachments": 565,
      "EmailHeader": "guy.lakin@mills.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "tempore",
      "Sentiment": 712,
      "SentimentConfidence": 508,
      "CreatedBy": 418,
      "ChangedAt": "2004-04-05T02:30:47.8975637+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 127,
      "Name": "Hickle-Parker",
      "ToolTip": "Facilis eum id sequi sed ut unde illo."
    },
    {
      "Id": 127,
      "Name": "Hickle-Parker",
      "ToolTip": "Facilis eum id sequi sed ut unde illo."
    }
  ],
  "Language": "nemo",
  "Sentiment": 636,
  "SentimentConfidence": 380,
  "SuggestedCategoryId": 58,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 622,
  "IconHint": "qui",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 420,
  "ExtraFields": {
    "ExtraFields1": "a",
    "ExtraFields2": "odio"
  },
  "CustomFields": {
    "CustomFields1": "quis",
    "CustomFields2": "ut"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 972,
  "Title": "aut",
  "CreatedAt": "2014-07-15T02:30:47.8975637+02:00",
  "LastChanged": "2011-07-13T02:30:47.8975637+02:00",
  "ReadByOwner": "2000-07-20T02:30:47.8975637+02:00",
  "ReadByCustomer": "2009-09-09T02:30:47.8975637+02:00",
  "FirstReadByOwner": "2000-05-05T02:30:47.8975637+02:00",
  "FirstReadByUser": "2020-01-09T02:30:47.8975637+01:00",
  "Activate": "2011-08-03T02:30:47.8975637+02:00",
  "ClosedAt": "2000-02-21T02:30:47.8975637+01:00",
  "RepliedAt": "2016-05-15T02:30:47.8975637+02:00",
  "AlertTimeout": "2023-10-08T02:30:47.8975637+02:00",
  "Deadline": "2014-09-22T02:30:47.8975637+02:00",
  "CreatedBy": null,
  "Author": "repellat",
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
      "Position": "qui",
      "PersonId": 976,
      "Mrmrs": "veniam",
      "Firstname": "Deshawn",
      "Lastname": "Conroy",
      "MiddleName": "Rosenbaum, Braun and Legros",
      "Title": "at",
      "Description": "Team-oriented multi-state orchestration",
      "Email": "carmella_wolff@medhurst.com",
      "FullName": "Mohammed Kutch",
      "DirectPhone": "487-406-6994",
      "FormalName": "Swift Inc and Sons",
      "CountryId": 825,
      "ContactId": 506,
      "ContactName": "Volkman, Rau and Marquardt",
      "Retired": 460,
      "Rank": 334,
      "ActiveInterests": 24,
      "ContactDepartment": "",
      "ContactCountryId": 287,
      "ContactOrgNr": "1078925",
      "FaxPhone": "663-446-5185 x795",
      "MobilePhone": "161.841.4044 x64758",
      "ContactPhone": "(912)255-1300 x9098",
      "AssociateName": "Koelpin LLC",
      "AssociateId": 743,
      "UsePersonAddress": false,
      "ContactFax": "ducimus",
      "Kanafname": "dolore",
      "Kanalname": "voluptate",
      "Post1": "sint",
      "Post2": "dolor",
      "Post3": "aut",
      "EmailName": "ted.kub@altenwerth.co.uk",
      "ContactFullName": "Idella Gerlach",
      "ActiveErpLinks": 416,
      "TicketPriorityId": 911,
      "SupportLanguageId": 614,
      "SupportAssociateId": 651,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1595765",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 105
        }
      }
    }
  ],
  "AlertLevel": 759,
  "ConnectId": 351,
  "ReadStatus": "Green",
  "TimeToReply": 368,
  "RealTimeToReply": 375,
  "TimeToClose": 215,
  "RealTimeToClose": 850,
  "TimeSpentInternally": 784,
  "TimeSpentExternally": 706,
  "TimeSpentQueue": 720,
  "RealTimeSpentInternally": 142,
  "RealTimeSpentExternally": 268,
  "RealTimeSpentQueue": 100,
  "TimeSpent": 953,
  "HasAttachment": false,
  "NumReplies": 830,
  "NumMessages": 751,
  "FromAddress": "fugiat",
  "Messages": [
    {
      "TicketMessageId": 192,
      "CreatedAt": "2025-10-04T02:30:47.8975637+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "tenetur",
      "PersonId": 89,
      "PersonFullName": "Garry Rempel DDS",
      "ContactId": 788,
      "ContactName": "Goldner-Conn",
      "ContactDepartment": "",
      "NumAttachments": 319,
      "EmailHeader": "rex@schneider.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "dolores",
      "Sentiment": 416,
      "SentimentConfidence": 120,
      "CreatedBy": 780,
      "ChangedAt": "2019-07-08T02:30:47.8975637+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 1002
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 558,
      "Name": "Torphy, Kunze and Reichert",
      "ToolTip": "Aut sit quo perspiciatis unde nostrum sed.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 157
        }
      }
    },
    {
      "Id": 558,
      "Name": "Torphy, Kunze and Reichert",
      "ToolTip": "Aut sit quo perspiciatis unde nostrum sed.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 157
        }
      }
    }
  ],
  "Language": "corporis",
  "Sentiment": 676,
  "SentimentConfidence": 569,
  "SuggestedCategoryId": 377,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 458,
  "IconHint": "quia",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 394,
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "officiis",
    "CustomFields2": "voluptatum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 637
    }
  }
}
```