---
title: PUT Ticket/{id}
uid: v1TicketEntity_HttpPutSaveTicketEntityWithNotify
generated: true
---

# PUT Ticket/{id}

```http
PUT /api/v1/Ticket/{id}
```

Saves a ticket and performs any user notifications






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The TicketEntity id to update **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| notify | bool |  If true, then the notifications will be sent |

```http
PUT /api/v1/Ticket/{id}?notify=False
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

## Request Body: entity 

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
| TicketType | TicketType | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
| ActiveStatusMonitorId | Integer | Active status monitor identity for related contact. This is a read-only property and is ignored on Save |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketId": 257,
  "Title": "animi",
  "CreatedAt": "2018-11-03T04:22:35.5022347+01:00",
  "LastChanged": "2001-11-08T04:22:35.5022347+01:00",
  "ReadByOwner": "1999-11-05T04:22:35.5022347+01:00",
  "ReadByCustomer": "2023-01-29T04:22:35.5022347+01:00",
  "FirstReadByOwner": "2013-09-05T04:22:35.5022347+02:00",
  "FirstReadByUser": "2014-08-27T04:22:35.5022347+02:00",
  "Activate": "2001-05-08T04:22:35.5022347+02:00",
  "ClosedAt": "2024-03-31T04:22:35.5022347+02:00",
  "RepliedAt": "2000-11-11T04:22:35.5022347+01:00",
  "AlertTimeout": "2013-02-07T04:22:35.5022347+01:00",
  "Deadline": "2010-11-25T04:22:35.5022347+01:00",
  "CreatedBy": null,
  "Author": "consequatur",
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
      "Position": "nemo",
      "PersonId": 409,
      "Mrmrs": "id",
      "Firstname": "Jon",
      "Lastname": "Larkin",
      "MiddleName": "Haag, Monahan and Becker",
      "Title": "sequi",
      "Description": "Persistent eco-centric website",
      "Email": "kiel_schamberger@fisher.biz",
      "FullName": "Kaci Harvey",
      "DirectPhone": "651.707.4957 x24778",
      "FormalName": "McGlynn-Brown",
      "CountryId": 784,
      "ContactId": 580,
      "ContactName": "Cartwright, Johns and Wunsch",
      "Retired": 399,
      "Rank": 539,
      "ActiveInterests": 902,
      "ContactDepartment": "",
      "ContactCountryId": 429,
      "ContactOrgNr": "1482980",
      "FaxPhone": "1-881-149-8901",
      "MobilePhone": "(743)684-7406 x604",
      "ContactPhone": "(387)269-5388",
      "AssociateName": "Schulist, Rau and Schiller",
      "AssociateId": 725,
      "UsePersonAddress": false,
      "ContactFax": "libero",
      "Kanafname": "ullam",
      "Kanalname": "natus",
      "Post1": "voluptatibus",
      "Post2": "ut",
      "Post3": "fugiat",
      "EmailName": "jeanie.gutmann@rogahn.co.uk",
      "ContactFullName": "Mr. Ian Pfannerstill V",
      "ActiveErpLinks": 769,
      "TicketPriorityId": 41,
      "SupportLanguageId": 556,
      "SupportAssociateId": 538,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 812,
  "ConnectId": 303,
  "ReadStatus": "Green",
  "TimeToReply": 741,
  "RealTimeToReply": 136,
  "TimeToClose": 597,
  "RealTimeToClose": 970,
  "TimeSpentInternally": 58,
  "TimeSpentExternally": 658,
  "TimeSpentQueue": 359,
  "RealTimeSpentInternally": 152,
  "RealTimeSpentExternally": 918,
  "RealTimeSpentQueue": 67,
  "TimeSpent": 964,
  "HasAttachment": true,
  "NumReplies": 799,
  "NumMessages": 907,
  "FromAddress": "numquam",
  "Messages": [
    {
      "TicketMessageId": 109,
      "CreatedAt": "2012-11-10T04:22:35.5022347+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "autem",
      "PersonId": 281,
      "PersonFullName": "Abbey Fahey",
      "ContactId": 100,
      "ContactName": "Ortiz-Ledner",
      "ContactDepartment": "",
      "NumAttachments": 31,
      "EmailHeader": "sidney.fay@kovaceklowe.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ad",
      "Sentiment": 622,
      "SentimentConfidence": 513,
      "CreatedBy": 98,
      "ChangedAt": "2014-03-29T04:22:35.5022347+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 689,
      "Name": "Swift-Crooks",
      "ToolTip": "Expedita qui commodi aut."
    },
    {
      "Id": 689,
      "Name": "Swift-Crooks",
      "ToolTip": "Expedita qui commodi aut."
    }
  ],
  "Language": "enim",
  "Sentiment": 923,
  "SentimentConfidence": 284,
  "SuggestedCategoryId": 427,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 351,
  "IconHint": "cumque",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 955,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "laboriosam",
    "CustomFields2": "velit"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 430,
  "Title": "officia",
  "CreatedAt": "1999-06-19T04:22:35.5178561+02:00",
  "LastChanged": "2022-12-10T04:22:35.5178561+01:00",
  "ReadByOwner": "2009-08-29T04:22:35.5178561+02:00",
  "ReadByCustomer": "1998-05-07T04:22:35.5178561+02:00",
  "FirstReadByOwner": "2023-03-18T04:22:35.5178561+01:00",
  "FirstReadByUser": "1998-06-24T04:22:35.5178561+02:00",
  "Activate": "2014-01-29T04:22:35.5178561+01:00",
  "ClosedAt": "2022-02-20T04:22:35.5178561+01:00",
  "RepliedAt": "2015-01-26T04:22:35.5178561+01:00",
  "AlertTimeout": "2021-08-07T04:22:35.5178561+02:00",
  "Deadline": "2022-02-22T04:22:35.5178561+01:00",
  "CreatedBy": null,
  "Author": "fugit",
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
      "Position": "pariatur",
      "PersonId": 213,
      "Mrmrs": "enim",
      "Firstname": "Grayson",
      "Lastname": "Kilback",
      "MiddleName": "Dooley Inc and Sons",
      "Title": "qui",
      "Description": "Proactive web-enabled database",
      "Email": "delphine@kovacek.info",
      "FullName": "Mrs. Benton Brakus",
      "DirectPhone": "(157)637-0745",
      "FormalName": "Schmitt, Bergstrom and Ritchie",
      "CountryId": 561,
      "ContactId": 708,
      "ContactName": "Kozey, Strosin and Wyman",
      "Retired": 191,
      "Rank": 907,
      "ActiveInterests": 260,
      "ContactDepartment": "",
      "ContactCountryId": 407,
      "ContactOrgNr": "1507887",
      "FaxPhone": "1-758-138-1063",
      "MobilePhone": "1-357-726-6199 x215",
      "ContactPhone": "054.561.2082 x25703",
      "AssociateName": "Conroy, Padberg and Hane",
      "AssociateId": 505,
      "UsePersonAddress": false,
      "ContactFax": "fugiat",
      "Kanafname": "non",
      "Kanalname": "maiores",
      "Post1": "ipsam",
      "Post2": "illo",
      "Post3": "velit",
      "EmailName": "trever@kirlin.us",
      "ContactFullName": "Ms. Angel Hillary Funk",
      "ActiveErpLinks": 121,
      "TicketPriorityId": 431,
      "SupportLanguageId": 926,
      "SupportAssociateId": 1000,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 303
        }
      }
    }
  ],
  "AlertLevel": 142,
  "ConnectId": 807,
  "ReadStatus": "Green",
  "TimeToReply": 310,
  "RealTimeToReply": 412,
  "TimeToClose": 384,
  "RealTimeToClose": 687,
  "TimeSpentInternally": 421,
  "TimeSpentExternally": 752,
  "TimeSpentQueue": 534,
  "RealTimeSpentInternally": 853,
  "RealTimeSpentExternally": 625,
  "RealTimeSpentQueue": 547,
  "TimeSpent": 910,
  "HasAttachment": false,
  "NumReplies": 515,
  "NumMessages": 242,
  "FromAddress": "nisi",
  "Messages": [
    {
      "TicketMessageId": 73,
      "CreatedAt": "1999-08-09T04:22:35.5178561+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "rerum",
      "PersonId": 205,
      "PersonFullName": "Annamae Kilback",
      "ContactId": 29,
      "ContactName": "Kunze, Langworth and Champlin",
      "ContactDepartment": "",
      "NumAttachments": 377,
      "EmailHeader": "duane@oreilly.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "expedita",
      "Sentiment": 320,
      "SentimentConfidence": 620,
      "CreatedBy": 218,
      "ChangedAt": "2008-12-16T04:22:35.5178561+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 859
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 441,
      "Name": "Runolfsdottir, Towne and McCullough",
      "ToolTip": "Mollitia sed doloremque ratione quis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 317
        }
      }
    },
    {
      "Id": 441,
      "Name": "Runolfsdottir, Towne and McCullough",
      "ToolTip": "Mollitia sed doloremque ratione quis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 317
        }
      }
    }
  ],
  "Language": "sed",
  "Sentiment": 700,
  "SentimentConfidence": 166,
  "SuggestedCategoryId": 724,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 459,
  "IconHint": "ad",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 622,
  "ExtraFields": {
    "ExtraFields1": "explicabo",
    "ExtraFields2": "eligendi"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 414
    }
  }
}
```