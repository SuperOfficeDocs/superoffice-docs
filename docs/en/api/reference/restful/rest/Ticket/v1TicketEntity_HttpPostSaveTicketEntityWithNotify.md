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
POST /api/v1/Ticket?notify=True
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
POST /api/v1/Ticket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketId": 174,
  "Title": "cum",
  "CreatedAt": "2002-12-13T03:44:57.6093769+01:00",
  "LastChanged": "2011-04-12T03:44:57.6093769+02:00",
  "ReadByOwner": "2005-05-08T03:44:57.6093769+02:00",
  "ReadByCustomer": "2000-04-15T03:44:57.6093769+02:00",
  "FirstReadByOwner": "2022-12-05T03:44:57.6093769+01:00",
  "FirstReadByUser": "2010-02-16T03:44:57.6093769+01:00",
  "Activate": "2014-08-14T03:44:57.6093769+02:00",
  "ClosedAt": "2022-12-29T03:44:57.6093769+01:00",
  "RepliedAt": "2023-08-14T03:44:57.6093769+02:00",
  "AlertTimeout": "2004-04-24T03:44:57.6093769+02:00",
  "Deadline": "2006-08-18T03:44:57.6093769+02:00",
  "CreatedBy": null,
  "Author": "explicabo",
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
      "PersonId": 607,
      "Mrmrs": "doloremque",
      "Firstname": "Maurine",
      "Lastname": "Wintheiser",
      "MiddleName": "Walter-Berge",
      "Title": "voluptas",
      "Description": "Phased mobile orchestration",
      "Email": "athena@cummings.ca",
      "FullName": "Alberta Ziemann",
      "DirectPhone": "517.382.1461 x0012",
      "FormalName": "Murazik-Breitenberg",
      "CountryId": 585,
      "ContactId": 190,
      "ContactName": "Fadel Inc and Sons",
      "Retired": 18,
      "Rank": 633,
      "ActiveInterests": 591,
      "ContactDepartment": "",
      "ContactCountryId": 819,
      "ContactOrgNr": "948395",
      "FaxPhone": "638.610.6959",
      "MobilePhone": "1-365-582-0661",
      "ContactPhone": "857.127.3901",
      "AssociateName": "Altenwerth Inc and Sons",
      "AssociateId": 227,
      "UsePersonAddress": false,
      "ContactFax": "pariatur",
      "Kanafname": "deleniti",
      "Kanalname": "facilis",
      "Post1": "qui",
      "Post2": "cumque",
      "Post3": "dolorem",
      "EmailName": "gino_dare@hermannmertz.name",
      "ContactFullName": "Ali Evie Goyette Jr.",
      "ActiveErpLinks": 946,
      "TicketPriorityId": 418,
      "SupportLanguageId": 118,
      "SupportAssociateId": 461,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 882,
  "ConnectId": 829,
  "ReadStatus": "Green",
  "TimeToReply": 551,
  "RealTimeToReply": 43,
  "TimeToClose": 480,
  "RealTimeToClose": 616,
  "TimeSpentInternally": 855,
  "TimeSpentExternally": 901,
  "TimeSpentQueue": 7,
  "RealTimeSpentInternally": 702,
  "RealTimeSpentExternally": 896,
  "RealTimeSpentQueue": 329,
  "TimeSpent": 693,
  "HasAttachment": false,
  "NumReplies": 775,
  "NumMessages": 661,
  "FromAddress": "tempore",
  "Messages": [
    {
      "TicketMessageId": 147,
      "CreatedAt": "2006-07-12T03:44:57.6093769+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "voluptas",
      "PersonId": 268,
      "PersonFullName": "Prof. Wyatt Florine Reichert DVM",
      "ContactId": 837,
      "ContactName": "Tremblay-Carter",
      "ContactDepartment": "",
      "NumAttachments": 223,
      "EmailHeader": "michaela_dicki@rathboehm.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "nam",
      "Sentiment": 33,
      "SentimentConfidence": 850,
      "CreatedBy": 838,
      "ChangedAt": "2003-06-07T03:44:57.6093769+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 989,
      "Name": "Swift Inc and Sons",
      "ToolTip": "Quos animi repellendus qui maxime quia reprehenderit dolores."
    },
    {
      "Id": 989,
      "Name": "Swift Inc and Sons",
      "ToolTip": "Quos animi repellendus qui maxime quia reprehenderit dolores."
    }
  ],
  "Language": "sed",
  "Sentiment": 651,
  "SentimentConfidence": 810,
  "SuggestedCategoryId": 815,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 243,
  "IconHint": "sunt",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 156,
  "ExtraFields": {
    "ExtraFields1": "pariatur",
    "ExtraFields2": "aperiam"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "distinctio"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 701,
  "Title": "cum",
  "CreatedAt": "2002-05-29T03:44:57.6093769+02:00",
  "LastChanged": "2005-04-20T03:44:57.6093769+02:00",
  "ReadByOwner": "2019-02-20T03:44:57.6093769+01:00",
  "ReadByCustomer": "1998-05-02T03:44:57.6093769+02:00",
  "FirstReadByOwner": "2004-08-05T03:44:57.6093769+02:00",
  "FirstReadByUser": "2014-05-23T03:44:57.6093769+02:00",
  "Activate": "2010-02-28T03:44:57.6093769+01:00",
  "ClosedAt": "2009-07-04T03:44:57.6093769+02:00",
  "RepliedAt": "2002-08-13T03:44:57.6093769+02:00",
  "AlertTimeout": "2010-02-12T03:44:57.6093769+01:00",
  "Deadline": "1997-09-25T03:44:57.6093769+02:00",
  "CreatedBy": null,
  "Author": "pariatur",
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
      "Position": "autem",
      "PersonId": 531,
      "Mrmrs": "quas",
      "Firstname": "Abner",
      "Lastname": "Shanahan",
      "MiddleName": "Ryan Inc and Sons",
      "Title": "amet",
      "Description": "Advanced contextually-based service-desk",
      "Email": "don@parisian.ca",
      "FullName": "Sherwood Ankunding",
      "DirectPhone": "818.327.1598",
      "FormalName": "Wilderman, Dibbert and Steuber",
      "CountryId": 165,
      "ContactId": 187,
      "ContactName": "Mann, Mohr and Roob",
      "Retired": 456,
      "Rank": 558,
      "ActiveInterests": 328,
      "ContactDepartment": "",
      "ContactCountryId": 957,
      "ContactOrgNr": "1971048",
      "FaxPhone": "(312)088-2503 x83533",
      "MobilePhone": "1-613-205-9385 x49563",
      "ContactPhone": "(910)341-8857 x497",
      "AssociateName": "Jones LLC",
      "AssociateId": 378,
      "UsePersonAddress": false,
      "ContactFax": "esse",
      "Kanafname": "recusandae",
      "Kanalname": "nulla",
      "Post1": "enim",
      "Post2": "molestias",
      "Post3": "a",
      "EmailName": "nya_gulgowski@russel.us",
      "ContactFullName": "Lexus Lorine Bergstrom I",
      "ActiveErpLinks": 212,
      "TicketPriorityId": 193,
      "SupportLanguageId": 59,
      "SupportAssociateId": 296,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 301
        }
      }
    }
  ],
  "AlertLevel": 687,
  "ConnectId": 597,
  "ReadStatus": "Green",
  "TimeToReply": 134,
  "RealTimeToReply": 877,
  "TimeToClose": 190,
  "RealTimeToClose": 444,
  "TimeSpentInternally": 32,
  "TimeSpentExternally": 53,
  "TimeSpentQueue": 544,
  "RealTimeSpentInternally": 900,
  "RealTimeSpentExternally": 570,
  "RealTimeSpentQueue": 646,
  "TimeSpent": 78,
  "HasAttachment": false,
  "NumReplies": 277,
  "NumMessages": 153,
  "FromAddress": "consequatur",
  "Messages": [
    {
      "TicketMessageId": 29,
      "CreatedAt": "2019-02-26T03:44:57.6093769+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "alias",
      "PersonId": 810,
      "PersonFullName": "Alda Langosh",
      "ContactId": 234,
      "ContactName": "Hoppe Group",
      "ContactDepartment": "",
      "NumAttachments": 881,
      "EmailHeader": "georgiana.conn@bartolettimann.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "earum",
      "Sentiment": 991,
      "SentimentConfidence": 749,
      "CreatedBy": 964,
      "ChangedAt": "2010-04-03T03:44:57.6093769+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 961
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 685,
      "Name": "Mertz, Herman and Feil",
      "ToolTip": "Itaque similique.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 825
        }
      }
    },
    {
      "Id": 685,
      "Name": "Mertz, Herman and Feil",
      "ToolTip": "Itaque similique.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 825
        }
      }
    }
  ],
  "Language": "repellat",
  "Sentiment": 499,
  "SentimentConfidence": 595,
  "SuggestedCategoryId": 887,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 862,
  "IconHint": "dolore",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 529,
  "ExtraFields": {
    "ExtraFields1": "asperiores",
    "ExtraFields2": "dolore"
  },
  "CustomFields": {
    "CustomFields1": "fugiat",
    "CustomFields2": "perferendis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 476
    }
  }
}
```