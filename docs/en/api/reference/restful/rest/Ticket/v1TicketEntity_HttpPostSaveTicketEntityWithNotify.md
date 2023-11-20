---
title: POST Ticket
uid: v1TicketEntity_HttpPostSaveTicketEntityWithNotify
generated: true
---

# POST Ticket

```http
POST /api/v1/Ticket
```

Saves a ticket and performs any user notifications







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| notify | bool |  If true, then the notifications will be sent |

```http
POST /api/v1/Ticket?notify=False
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

## Request Body: newEntity 

The ticket to save 

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
POST /api/v1/Ticket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 918,
  "Title": "quia",
  "CreatedAt": "2008-09-01T13:38:17.6867978+02:00",
  "LastChanged": "2014-02-02T13:38:17.6867978+01:00",
  "ReadByOwner": "2004-04-28T13:38:17.6867978+02:00",
  "ReadByCustomer": "2018-03-09T13:38:17.6867978+01:00",
  "FirstReadByOwner": "2008-05-04T13:38:17.6867978+02:00",
  "FirstReadByUser": "2010-02-12T13:38:17.6867978+01:00",
  "Activate": "2017-10-01T13:38:17.6867978+02:00",
  "ClosedAt": "2005-01-24T13:38:17.6867978+01:00",
  "RepliedAt": "2011-07-18T13:38:17.6867978+02:00",
  "AlertTimeout": "2000-12-25T13:38:17.6867978+01:00",
  "Deadline": "1999-01-16T13:38:17.6867978+01:00",
  "CreatedBy": null,
  "Author": "nihil",
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
      "Position": "non",
      "PersonId": 912,
      "Mrmrs": "dolorem",
      "Firstname": "Jammie",
      "Lastname": "Blick",
      "MiddleName": "Jaskolski Group",
      "Title": "error",
      "Description": "Profound holistic leverage",
      "Email": "letha_cartwright@hayes.us",
      "FullName": "Jayme Swift",
      "DirectPhone": "333-409-2185 x6894",
      "FormalName": "Ernser Group",
      "CountryId": 925,
      "ContactId": 605,
      "ContactName": "Satterfield LLC",
      "Retired": 72,
      "Rank": 949,
      "ActiveInterests": 365,
      "ContactDepartment": "",
      "ContactCountryId": 669,
      "ContactOrgNr": "1398564",
      "FaxPhone": "632.225.1645 x194",
      "MobilePhone": "822.998.5067 x07290",
      "ContactPhone": "972-282-4950 x12419",
      "AssociateName": "Swift-Schimmel",
      "AssociateId": 876,
      "UsePersonAddress": false,
      "ContactFax": "labore",
      "Kanafname": "eius",
      "Kanalname": "unde",
      "Post1": "aut",
      "Post2": "consequuntur",
      "Post3": "velit",
      "EmailName": "felicity_barrows@barton.com",
      "ContactFullName": "Lurline McKenzie I",
      "ActiveErpLinks": 114,
      "TicketPriorityId": 552,
      "SupportLanguageId": 648,
      "SupportAssociateId": 706,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 706,
  "ConnectId": 571,
  "ReadStatus": "Green",
  "TimeToReply": 541,
  "RealTimeToReply": 95,
  "TimeToClose": 853,
  "RealTimeToClose": 492,
  "TimeSpentInternally": 587,
  "TimeSpentExternally": 674,
  "TimeSpentQueue": 754,
  "RealTimeSpentInternally": 98,
  "RealTimeSpentExternally": 552,
  "RealTimeSpentQueue": 483,
  "TimeSpent": 253,
  "HasAttachment": true,
  "NumReplies": 697,
  "NumMessages": 137,
  "FromAddress": "itaque",
  "Messages": [
    {
      "TicketMessageId": 331,
      "CreatedAt": "1998-07-16T13:38:17.6867978+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "enim",
      "PersonId": 114,
      "PersonFullName": "Shany Collins",
      "ContactId": 289,
      "ContactName": "Heller Group",
      "ContactDepartment": "",
      "NumAttachments": 13,
      "EmailHeader": "dwight_fadel@ledner.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "aut",
      "Sentiment": 319,
      "SentimentConfidence": 424,
      "CreatedBy": 886,
      "ChangedAt": "2002-07-18T13:38:17.6867978+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 360,
      "Name": "Schroeder LLC",
      "ToolTip": "Aut placeat perspiciatis iste et sint."
    },
    {
      "Id": 360,
      "Name": "Schroeder LLC",
      "ToolTip": "Aut placeat perspiciatis iste et sint."
    }
  ],
  "Language": "nam",
  "Sentiment": 609,
  "SentimentConfidence": 160,
  "SuggestedCategoryId": 947,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 538,
  "IconHint": "explicabo",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "quam",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "occaecati",
    "CustomFields2": "accusantium"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 446,
  "Title": "velit",
  "CreatedAt": "2002-05-11T13:38:17.6867978+02:00",
  "LastChanged": "2002-06-13T13:38:17.6867978+02:00",
  "ReadByOwner": "2022-12-18T13:38:17.6867978+01:00",
  "ReadByCustomer": "2010-07-25T13:38:17.6867978+02:00",
  "FirstReadByOwner": "2002-09-22T13:38:17.6867978+02:00",
  "FirstReadByUser": "2008-10-13T13:38:17.6867978+02:00",
  "Activate": "2001-06-26T13:38:17.6867978+02:00",
  "ClosedAt": "2008-01-17T13:38:17.6867978+01:00",
  "RepliedAt": "2022-06-30T13:38:17.6867978+02:00",
  "AlertTimeout": "2007-01-20T13:38:17.6867978+01:00",
  "Deadline": "2022-09-22T13:38:17.6867978+02:00",
  "CreatedBy": null,
  "Author": "ratione",
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
      "Position": "voluptas",
      "PersonId": 629,
      "Mrmrs": "mollitia",
      "Firstname": "Sherman",
      "Lastname": "Leannon",
      "MiddleName": "Lynch-Hilll",
      "Title": "in",
      "Description": "Integrated actuating process improvement",
      "Email": "doug@heaneyschaefer.uk",
      "FullName": "Prof. Mohammed Abernathy",
      "DirectPhone": "144.380.7476",
      "FormalName": "Renner, Mayert and Pfeffer",
      "CountryId": 164,
      "ContactId": 595,
      "ContactName": "Ankunding-Graham",
      "Retired": 285,
      "Rank": 132,
      "ActiveInterests": 908,
      "ContactDepartment": "",
      "ContactCountryId": 104,
      "ContactOrgNr": "1462314",
      "FaxPhone": "(870)317-5532 x81106",
      "MobilePhone": "1-538-733-1291 x0454",
      "ContactPhone": "1-423-916-7081",
      "AssociateName": "Nicolas, Kuhlman and Blanda",
      "AssociateId": 667,
      "UsePersonAddress": false,
      "ContactFax": "velit",
      "Kanafname": "velit",
      "Kanalname": "et",
      "Post1": "molestiae",
      "Post2": "eos",
      "Post3": "illo",
      "EmailName": "esperanza@wintheiser.com",
      "ContactFullName": "Kody McCullough",
      "ActiveErpLinks": 126,
      "TicketPriorityId": 964,
      "SupportLanguageId": 799,
      "SupportAssociateId": 683,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 698
        }
      }
    }
  ],
  "AlertLevel": 74,
  "ConnectId": 360,
  "ReadStatus": "Green",
  "TimeToReply": 38,
  "RealTimeToReply": 510,
  "TimeToClose": 16,
  "RealTimeToClose": 44,
  "TimeSpentInternally": 824,
  "TimeSpentExternally": 432,
  "TimeSpentQueue": 528,
  "RealTimeSpentInternally": 376,
  "RealTimeSpentExternally": 68,
  "RealTimeSpentQueue": 803,
  "TimeSpent": 400,
  "HasAttachment": false,
  "NumReplies": 73,
  "NumMessages": 433,
  "FromAddress": "sunt",
  "Messages": [
    {
      "TicketMessageId": 711,
      "CreatedAt": "2007-09-18T13:38:17.6867978+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "minus",
      "PersonId": 790,
      "PersonFullName": "Destin Turner",
      "ContactId": 946,
      "ContactName": "Johnston, Considine and Feest",
      "ContactDepartment": "",
      "NumAttachments": 706,
      "EmailHeader": "federico@hand.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "odio",
      "Sentiment": 668,
      "SentimentConfidence": 262,
      "CreatedBy": 637,
      "ChangedAt": "1997-08-23T13:38:17.6867978+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 544
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 870,
      "Name": "Batz Inc and Sons",
      "ToolTip": "Et deleniti.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 683
        }
      }
    },
    {
      "Id": 870,
      "Name": "Batz Inc and Sons",
      "ToolTip": "Et deleniti.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 683
        }
      }
    }
  ],
  "Language": "ut",
  "Sentiment": 478,
  "SentimentConfidence": 586,
  "SuggestedCategoryId": 236,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 280,
  "IconHint": "et",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "nobis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 430
    }
  }
}
```