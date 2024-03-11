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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 31,
  "Title": "ad",
  "CreatedAt": "2010-09-16T14:23:55.5408333+02:00",
  "LastChanged": "2022-02-14T14:23:55.5408333+01:00",
  "ReadByOwner": "2007-09-13T14:23:55.5408333+02:00",
  "ReadByCustomer": "2021-06-05T14:23:55.5408333+02:00",
  "FirstReadByOwner": "2010-02-18T14:23:55.5408333+01:00",
  "FirstReadByUser": "2016-12-02T14:23:55.5408333+01:00",
  "Activate": "2023-10-07T14:23:55.5408333+02:00",
  "ClosedAt": "1997-12-15T14:23:55.5408333+01:00",
  "RepliedAt": "2008-03-23T14:23:55.5408333+01:00",
  "AlertTimeout": "2016-05-26T14:23:55.5408333+02:00",
  "Deadline": "1997-12-05T14:23:55.5408333+01:00",
  "CreatedBy": null,
  "Author": "suscipit",
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
      "Position": "rerum",
      "PersonId": 924,
      "Mrmrs": "delectus",
      "Firstname": "Adolf",
      "Lastname": "Kassulke",
      "MiddleName": "Aufderhar, Schuppe and Miller",
      "Title": "aliquid",
      "Description": "Implemented fault-tolerant alliance",
      "Email": "coleman@langworth.co.uk",
      "FullName": "Anais Bruen",
      "DirectPhone": "(107)862-0856",
      "FormalName": "Dickens Inc and Sons",
      "CountryId": 198,
      "ContactId": 419,
      "ContactName": "Cremin, Hermann and Pacocha",
      "Retired": 392,
      "Rank": 663,
      "ActiveInterests": 88,
      "ContactDepartment": "",
      "ContactCountryId": 559,
      "ContactOrgNr": "1250531",
      "FaxPhone": "(376)964-7600 x56440",
      "MobilePhone": "748-676-6686",
      "ContactPhone": "(208)233-3042 x536",
      "AssociateName": "Schultz, Stamm and Gutmann",
      "AssociateId": 408,
      "UsePersonAddress": true,
      "ContactFax": "sunt",
      "Kanafname": "quas",
      "Kanalname": "repellendus",
      "Post1": "et",
      "Post2": "maxime",
      "Post3": "a",
      "EmailName": "flavie_greenfelder@beier.com",
      "ContactFullName": "Candelario Purdy",
      "ActiveErpLinks": 875,
      "TicketPriorityId": 173,
      "SupportLanguageId": 252,
      "SupportAssociateId": 52,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 844,
  "ConnectId": 257,
  "ReadStatus": "Green",
  "TimeToReply": 515,
  "RealTimeToReply": 895,
  "TimeToClose": 744,
  "RealTimeToClose": 977,
  "TimeSpentInternally": 521,
  "TimeSpentExternally": 277,
  "TimeSpentQueue": 332,
  "RealTimeSpentInternally": 754,
  "RealTimeSpentExternally": 573,
  "RealTimeSpentQueue": 489,
  "TimeSpent": 244,
  "HasAttachment": false,
  "NumReplies": 877,
  "NumMessages": 241,
  "FromAddress": "aliquid",
  "Messages": [
    {
      "TicketMessageId": 697,
      "CreatedAt": "2022-11-14T14:23:55.5408333+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "vitae",
      "PersonId": 61,
      "PersonFullName": "Miss Chandler Darrick Hamill",
      "ContactId": 560,
      "ContactName": "Zemlak, Kessler and Raynor",
      "ContactDepartment": "",
      "NumAttachments": 25,
      "EmailHeader": "cecile@huels.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "non",
      "Sentiment": 827,
      "SentimentConfidence": 180,
      "CreatedBy": 464,
      "ChangedAt": "1998-04-11T14:23:55.5408333+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 924,
      "Name": "Hodkiewicz-Ritchie",
      "ToolTip": "Nulla eaque sint sequi."
    },
    {
      "Id": 924,
      "Name": "Hodkiewicz-Ritchie",
      "ToolTip": "Nulla eaque sint sequi."
    }
  ],
  "Language": "facere",
  "Sentiment": 483,
  "SentimentConfidence": 384,
  "SuggestedCategoryId": 355,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 628,
  "IconHint": "ad",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 66,
  "ExtraFields": {
    "ExtraFields1": "quis",
    "ExtraFields2": "iste"
  },
  "CustomFields": {
    "CustomFields1": "corporis",
    "CustomFields2": "eius"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 852,
  "Title": "in",
  "CreatedAt": "2019-09-25T14:23:55.5564573+02:00",
  "LastChanged": "2010-02-02T14:23:55.5564573+01:00",
  "ReadByOwner": "2024-01-14T14:23:55.5564573+01:00",
  "ReadByCustomer": "2002-05-29T14:23:55.5564573+02:00",
  "FirstReadByOwner": "1997-03-20T14:23:55.5564573+01:00",
  "FirstReadByUser": "2004-04-26T14:23:55.5564573+02:00",
  "Activate": "2009-07-17T14:23:55.5564573+02:00",
  "ClosedAt": "1997-06-29T14:23:55.5564573+02:00",
  "RepliedAt": "2016-02-18T14:23:55.5564573+01:00",
  "AlertTimeout": "2011-08-14T14:23:55.5564573+02:00",
  "Deadline": "2017-09-22T14:23:55.5564573+02:00",
  "CreatedBy": null,
  "Author": "et",
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
      "Position": "omnis",
      "PersonId": 676,
      "Mrmrs": "nisi",
      "Firstname": "Tessie",
      "Lastname": "Weimann",
      "MiddleName": "Kshlerin-Wintheiser",
      "Title": "dolor",
      "Description": "Proactive incremental functionalities",
      "Email": "jessy.runte@kuhic.uk",
      "FullName": "Mrs. Irwin Thomas Nader",
      "DirectPhone": "602-720-0753 x2116",
      "FormalName": "Zemlak Group",
      "CountryId": 7,
      "ContactId": 195,
      "ContactName": "Rath-Kris",
      "Retired": 619,
      "Rank": 951,
      "ActiveInterests": 994,
      "ContactDepartment": "",
      "ContactCountryId": 726,
      "ContactOrgNr": "1107539",
      "FaxPhone": "(067)326-8615",
      "MobilePhone": "(114)162-7009",
      "ContactPhone": "(649)036-4514",
      "AssociateName": "Brekke Inc and Sons",
      "AssociateId": 121,
      "UsePersonAddress": false,
      "ContactFax": "ab",
      "Kanafname": "qui",
      "Kanalname": "facere",
      "Post1": "magnam",
      "Post2": "aut",
      "Post3": "non",
      "EmailName": "scottie_mcglynn@bins.ca",
      "ContactFullName": "Mrs. Noe Lubowitz II",
      "ActiveErpLinks": 224,
      "TicketPriorityId": 427,
      "SupportLanguageId": 629,
      "SupportAssociateId": 876,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 982
        }
      }
    }
  ],
  "AlertLevel": 210,
  "ConnectId": 93,
  "ReadStatus": "Green",
  "TimeToReply": 810,
  "RealTimeToReply": 204,
  "TimeToClose": 936,
  "RealTimeToClose": 429,
  "TimeSpentInternally": 49,
  "TimeSpentExternally": 637,
  "TimeSpentQueue": 716,
  "RealTimeSpentInternally": 74,
  "RealTimeSpentExternally": 862,
  "RealTimeSpentQueue": 904,
  "TimeSpent": 860,
  "HasAttachment": true,
  "NumReplies": 295,
  "NumMessages": 281,
  "FromAddress": "vitae",
  "Messages": [
    {
      "TicketMessageId": 638,
      "CreatedAt": "2010-06-24T14:23:55.5564573+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "debitis",
      "PersonId": 816,
      "PersonFullName": "Amanda Effertz",
      "ContactId": 443,
      "ContactName": "Klein-Block",
      "ContactDepartment": "",
      "NumAttachments": 578,
      "EmailHeader": "jayda@kub.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "delectus",
      "Sentiment": 30,
      "SentimentConfidence": 49,
      "CreatedBy": 205,
      "ChangedAt": "2005-10-14T14:23:55.5564573+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 952
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 59,
      "Name": "Gottlieb-Daugherty",
      "ToolTip": "Praesentium impedit maiores cupiditate cupiditate.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 923
        }
      }
    },
    {
      "Id": 59,
      "Name": "Gottlieb-Daugherty",
      "ToolTip": "Praesentium impedit maiores cupiditate cupiditate.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 923
        }
      }
    }
  ],
  "Language": "soluta",
  "Sentiment": 924,
  "SentimentConfidence": 865,
  "SuggestedCategoryId": 724,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 160,
  "IconHint": "unde",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 436,
  "ExtraFields": {
    "ExtraFields1": "autem",
    "ExtraFields2": "ullam"
  },
  "CustomFields": {
    "CustomFields1": "ab",
    "CustomFields2": "beatae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 525
    }
  }
}
```