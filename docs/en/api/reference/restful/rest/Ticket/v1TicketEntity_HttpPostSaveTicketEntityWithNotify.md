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
  "TicketId": 717,
  "Title": "qui",
  "CreatedAt": "2005-04-19T13:14:11.1173007+02:00",
  "LastChanged": "2017-08-12T13:14:11.1173007+02:00",
  "ReadByOwner": "2003-04-11T13:14:11.1173007+02:00",
  "ReadByCustomer": "2024-08-08T13:14:11.1173007+02:00",
  "FirstReadByOwner": "2011-04-25T13:14:11.1173007+02:00",
  "FirstReadByUser": "2003-07-27T13:14:11.1173007+02:00",
  "Activate": "2003-09-17T13:14:11.1173007+02:00",
  "ClosedAt": "2019-12-09T13:14:11.1173007+01:00",
  "RepliedAt": "2013-10-15T13:14:11.1173007+02:00",
  "AlertTimeout": "2006-01-08T13:14:11.1173007+01:00",
  "Deadline": "2018-12-24T13:14:11.1173007+01:00",
  "CreatedBy": null,
  "Author": "tenetur",
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
      "Position": "quia",
      "PersonId": 576,
      "Mrmrs": "enim",
      "Firstname": "Thea",
      "Lastname": "Torp",
      "MiddleName": "Wintheiser LLC",
      "Title": "fugit",
      "Description": "Persevering methodical ability",
      "Email": "tessie@dibbert.com",
      "FullName": "Vida Yost Jr.",
      "DirectPhone": "849.178.6028 x5433",
      "FormalName": "Hills-Veum",
      "CountryId": 347,
      "ContactId": 896,
      "ContactName": "Sipes-Graham",
      "Retired": 301,
      "Rank": 650,
      "ActiveInterests": 838,
      "ContactDepartment": "",
      "ContactCountryId": 788,
      "ContactOrgNr": "988540",
      "FaxPhone": "184-497-6885 x0123",
      "MobilePhone": "1-249-227-0112 x695",
      "ContactPhone": "443-138-1648 x4002",
      "AssociateName": "Veum-Sauer",
      "AssociateId": 115,
      "UsePersonAddress": true,
      "ContactFax": "velit",
      "Kanafname": "autem",
      "Kanalname": "corporis",
      "Post1": "modi",
      "Post2": "et",
      "Post3": "aspernatur",
      "EmailName": "chet_rogahn@bodesmith.biz",
      "ContactFullName": "Anya Pouros",
      "ActiveErpLinks": 563,
      "TicketPriorityId": 238,
      "SupportLanguageId": 492,
      "SupportAssociateId": 858,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 975,
  "ConnectId": 335,
  "ReadStatus": "Green",
  "TimeToReply": 36,
  "RealTimeToReply": 797,
  "TimeToClose": 896,
  "RealTimeToClose": 557,
  "TimeSpentInternally": 85,
  "TimeSpentExternally": 284,
  "TimeSpentQueue": 521,
  "RealTimeSpentInternally": 88,
  "RealTimeSpentExternally": 494,
  "RealTimeSpentQueue": 884,
  "TimeSpent": 630,
  "HasAttachment": false,
  "NumReplies": 17,
  "NumMessages": 948,
  "FromAddress": "ipsa",
  "Messages": [
    {
      "TicketMessageId": 965,
      "CreatedAt": "2022-08-09T13:14:11.1173007+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "ea",
      "PersonId": 180,
      "PersonFullName": "Liliane Toy",
      "ContactId": 731,
      "ContactName": "VonRueden LLC",
      "ContactDepartment": "",
      "NumAttachments": 513,
      "EmailHeader": "tressa_swaniawski@kerlukecronin.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "dolores",
      "Sentiment": 203,
      "SentimentConfidence": 858,
      "CreatedBy": 754,
      "ChangedAt": "2011-07-16T13:14:11.1329328+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 927,
      "Name": "Kessler, VonRueden and Willms",
      "ToolTip": "Repellendus qui et in in at beatae autem."
    },
    {
      "Id": 927,
      "Name": "Kessler, VonRueden and Willms",
      "ToolTip": "Repellendus qui et in in at beatae autem."
    }
  ],
  "Language": "qui",
  "Sentiment": 948,
  "SentimentConfidence": 802,
  "SuggestedCategoryId": 514,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 881,
  "IconHint": "ea",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 932,
  "ExtraFields": {
    "ExtraFields1": "tempore",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "ipsam",
    "CustomFields2": "iure"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 108,
  "Title": "laboriosam",
  "CreatedAt": "2012-09-01T13:14:11.1329328+02:00",
  "LastChanged": "2002-09-05T13:14:11.1329328+02:00",
  "ReadByOwner": "2000-10-24T13:14:11.1329328+02:00",
  "ReadByCustomer": "2006-04-17T13:14:11.1329328+02:00",
  "FirstReadByOwner": "2001-09-21T13:14:11.1329328+02:00",
  "FirstReadByUser": "2022-12-26T13:14:11.1329328+01:00",
  "Activate": "2005-03-29T13:14:11.1329328+02:00",
  "ClosedAt": "2011-06-02T13:14:11.1329328+02:00",
  "RepliedAt": "2014-11-14T13:14:11.1329328+01:00",
  "AlertTimeout": "2014-09-28T13:14:11.1329328+02:00",
  "Deadline": "2013-10-04T13:14:11.1329328+02:00",
  "CreatedBy": null,
  "Author": "occaecati",
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
      "Position": "mollitia",
      "PersonId": 854,
      "Mrmrs": "alias",
      "Firstname": "Crawford",
      "Lastname": "Okuneva",
      "MiddleName": "Champlin-Sawayn",
      "Title": "quas",
      "Description": "Self-enabling web-enabled function",
      "Email": "angela.flatley@grady.ca",
      "FullName": "Isaiah Jaylon Witting I",
      "DirectPhone": "(635)245-6149 x40420",
      "FormalName": "Smitham, Schulist and Rogahn",
      "CountryId": 122,
      "ContactId": 449,
      "ContactName": "Powlowski, Rempel and Wintheiser",
      "Retired": 670,
      "Rank": 538,
      "ActiveInterests": 406,
      "ContactDepartment": "",
      "ContactCountryId": 269,
      "ContactOrgNr": "1429153",
      "FaxPhone": "1-999-423-9038 x895",
      "MobilePhone": "525-794-1778",
      "ContactPhone": "599.731.0992 x9157",
      "AssociateName": "Considine-Erdman",
      "AssociateId": 153,
      "UsePersonAddress": false,
      "ContactFax": "consequatur",
      "Kanafname": "et",
      "Kanalname": "id",
      "Post1": "et",
      "Post2": "atque",
      "Post3": "architecto",
      "EmailName": "newell.marks@wuckert.ca",
      "ContactFullName": "Jameson Aufderhar",
      "ActiveErpLinks": 877,
      "TicketPriorityId": 381,
      "SupportLanguageId": 243,
      "SupportAssociateId": 49,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 228
        }
      }
    }
  ],
  "AlertLevel": 222,
  "ConnectId": 43,
  "ReadStatus": "Green",
  "TimeToReply": 607,
  "RealTimeToReply": 764,
  "TimeToClose": 718,
  "RealTimeToClose": 446,
  "TimeSpentInternally": 209,
  "TimeSpentExternally": 969,
  "TimeSpentQueue": 889,
  "RealTimeSpentInternally": 536,
  "RealTimeSpentExternally": 252,
  "RealTimeSpentQueue": 445,
  "TimeSpent": 456,
  "HasAttachment": true,
  "NumReplies": 643,
  "NumMessages": 761,
  "FromAddress": "voluptatibus",
  "Messages": [
    {
      "TicketMessageId": 436,
      "CreatedAt": "2012-04-30T13:14:11.1329328+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "ut",
      "PersonId": 818,
      "PersonFullName": "Clifford Barrows",
      "ContactId": 544,
      "ContactName": "Brown, White and Osinski",
      "ContactDepartment": "",
      "NumAttachments": 861,
      "EmailHeader": "elisa.lind@braun.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "veritatis",
      "Sentiment": 488,
      "SentimentConfidence": 771,
      "CreatedBy": 760,
      "ChangedAt": "2011-09-19T13:14:11.1329328+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 277
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 524,
      "Name": "Schimmel, Ebert and Mann",
      "ToolTip": "Culpa qui aut mollitia exercitationem dicta.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 515
        }
      }
    },
    {
      "Id": 524,
      "Name": "Schimmel, Ebert and Mann",
      "ToolTip": "Culpa qui aut mollitia exercitationem dicta.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 515
        }
      }
    }
  ],
  "Language": "id",
  "Sentiment": 12,
  "SentimentConfidence": 19,
  "SuggestedCategoryId": 423,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 875,
  "IconHint": "voluptas",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 294,
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "maiores"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 952
    }
  }
}
```