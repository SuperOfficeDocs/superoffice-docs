---
title: POST Ticket
uid: v1TicketEntity_HttpPostSaveTicketEntityWithNotify
generated: true
content_type: reference
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 113,
  "Title": "aut",
  "CreatedAt": "2007-12-30T02:30:52.9442767+01:00",
  "LastChanged": "2010-11-06T02:30:52.9442767+01:00",
  "ReadByOwner": "2017-08-09T02:30:52.9442767+02:00",
  "ReadByCustomer": "2024-02-04T02:30:52.9442767+01:00",
  "FirstReadByOwner": "2009-04-03T02:30:52.9442767+02:00",
  "FirstReadByUser": "2003-02-05T02:30:52.9442767+01:00",
  "Activate": "2024-06-09T02:30:52.9442767+02:00",
  "ClosedAt": "2020-06-18T02:30:52.9442767+02:00",
  "RepliedAt": "2010-11-26T02:30:52.9442767+01:00",
  "AlertTimeout": "2017-04-13T02:30:52.9442767+02:00",
  "Deadline": "2010-01-05T02:30:52.9442767+01:00",
  "CreatedBy": null,
  "Author": "repudiandae",
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
      "Position": "architecto",
      "PersonId": 913,
      "Mrmrs": "hic",
      "Firstname": "Ludie",
      "Lastname": "Bruen",
      "MiddleName": "McDermott-Becker",
      "Title": "dolore",
      "Description": "User-centric fresh-thinking emulation",
      "Email": "aileen@runolfsson.ca",
      "FullName": "Gia Schaden",
      "DirectPhone": "1-880-248-3429 x1194",
      "FormalName": "Effertz-Ward",
      "CountryId": 391,
      "ContactId": 482,
      "ContactName": "Price-Kertzmann",
      "Retired": 741,
      "Rank": 726,
      "ActiveInterests": 484,
      "ContactDepartment": "",
      "ContactCountryId": 231,
      "ContactOrgNr": "1217598",
      "FaxPhone": "(686)058-5670",
      "MobilePhone": "187-593-7136 x55895",
      "ContactPhone": "(731)667-4471",
      "AssociateName": "Pollich Group",
      "AssociateId": 875,
      "UsePersonAddress": true,
      "ContactFax": "distinctio",
      "Kanafname": "veritatis",
      "Kanalname": "assumenda",
      "Post1": "dolorem",
      "Post2": "ea",
      "Post3": "doloribus",
      "EmailName": "quincy_ankunding@jones.us",
      "ContactFullName": "Izaiah Gutmann Sr.",
      "ActiveErpLinks": 420,
      "TicketPriorityId": 624,
      "SupportLanguageId": 58,
      "SupportAssociateId": 252,
      "CategoryName": "VIP Customer",
      "PersonNumber": "446706"
    }
  ],
  "AlertLevel": 406,
  "ConnectId": 670,
  "ReadStatus": "Green",
  "TimeToReply": 650,
  "RealTimeToReply": 804,
  "TimeToClose": 41,
  "RealTimeToClose": 939,
  "TimeSpentInternally": 255,
  "TimeSpentExternally": 938,
  "TimeSpentQueue": 327,
  "RealTimeSpentInternally": 542,
  "RealTimeSpentExternally": 838,
  "RealTimeSpentQueue": 878,
  "TimeSpent": 369,
  "HasAttachment": false,
  "NumReplies": 455,
  "NumMessages": 11,
  "FromAddress": "libero",
  "Messages": [
    {
      "TicketMessageId": 880,
      "CreatedAt": "2003-10-17T02:30:52.9599012+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "perspiciatis",
      "PersonId": 995,
      "PersonFullName": "Keven Keeling",
      "ContactId": 10,
      "ContactName": "Lindgren LLC",
      "ContactDepartment": "mesh synergistic vortals",
      "NumAttachments": 75,
      "EmailHeader": "ebba_brown@marvin.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "consequuntur",
      "Sentiment": 496,
      "SentimentConfidence": 682,
      "CreatedBy": 732,
      "ChangedAt": "2017-03-12T02:30:52.9599012+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 782,
      "Name": "Glover, Schultz and Crona",
      "ToolTip": "Aperiam qui omnis rerum porro est voluptates."
    },
    {
      "Id": 782,
      "Name": "Glover, Schultz and Crona",
      "ToolTip": "Aperiam qui omnis rerum porro est voluptates."
    }
  ],
  "Language": "est",
  "Sentiment": 191,
  "SentimentConfidence": 977,
  "SuggestedCategoryId": 488,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 525,
  "IconHint": "optio",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 537,
  "ExtraFields": {
    "ExtraFields1": "nihil",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "saepe",
    "CustomFields2": "ut"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 373,
  "Title": "et",
  "CreatedAt": "2020-05-01T02:30:52.9599012+02:00",
  "LastChanged": "2002-05-23T02:30:52.9599012+02:00",
  "ReadByOwner": "2012-12-05T02:30:52.9599012+01:00",
  "ReadByCustomer": "2000-12-31T02:30:52.9599012+01:00",
  "FirstReadByOwner": "2007-11-03T02:30:52.9599012+01:00",
  "FirstReadByUser": "2019-12-18T02:30:52.9599012+01:00",
  "Activate": "2002-04-29T02:30:52.9599012+02:00",
  "ClosedAt": "2010-08-31T02:30:52.9599012+02:00",
  "RepliedAt": "2019-04-20T02:30:52.9599012+02:00",
  "AlertTimeout": "2008-01-22T02:30:52.9599012+01:00",
  "Deadline": "2013-11-26T02:30:52.9599012+01:00",
  "CreatedBy": null,
  "Author": "vero",
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
      "Position": "nobis",
      "PersonId": 10,
      "Mrmrs": "nulla",
      "Firstname": "Mallie",
      "Lastname": "McKenzie",
      "MiddleName": "Wisozk-Goyette",
      "Title": "sed",
      "Description": "Exclusive executive firmware",
      "Email": "joelle_ortiz@stoltenbergbotsford.biz",
      "FullName": "Darwin Blanda",
      "DirectPhone": "(134)194-3666",
      "FormalName": "Leffler, Langosh and Wiegand",
      "CountryId": 494,
      "ContactId": 416,
      "ContactName": "Haag Group",
      "Retired": 758,
      "Rank": 354,
      "ActiveInterests": 671,
      "ContactDepartment": "",
      "ContactCountryId": 347,
      "ContactOrgNr": "1866469",
      "FaxPhone": "(780)783-6449",
      "MobilePhone": "(159)723-1159",
      "ContactPhone": "(776)626-4938 x358",
      "AssociateName": "Stokes, Harber and Treutel",
      "AssociateId": 603,
      "UsePersonAddress": false,
      "ContactFax": "voluptas",
      "Kanafname": "voluptatum",
      "Kanalname": "aut",
      "Post1": "adipisci",
      "Post2": "in",
      "Post3": "beatae",
      "EmailName": "tomas_oreilly@reillyondricka.com",
      "ContactFullName": "Lulu Crona",
      "ActiveErpLinks": 797,
      "TicketPriorityId": 596,
      "SupportLanguageId": 897,
      "SupportAssociateId": 927,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1124471",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 444
        }
      }
    }
  ],
  "AlertLevel": 637,
  "ConnectId": 778,
  "ReadStatus": "Green",
  "TimeToReply": 117,
  "RealTimeToReply": 907,
  "TimeToClose": 309,
  "RealTimeToClose": 710,
  "TimeSpentInternally": 484,
  "TimeSpentExternally": 191,
  "TimeSpentQueue": 14,
  "RealTimeSpentInternally": 908,
  "RealTimeSpentExternally": 612,
  "RealTimeSpentQueue": 714,
  "TimeSpent": 323,
  "HasAttachment": true,
  "NumReplies": 973,
  "NumMessages": 687,
  "FromAddress": "quos",
  "Messages": [
    {
      "TicketMessageId": 399,
      "CreatedAt": "2010-06-02T02:30:52.9599012+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "molestias",
      "PersonId": 271,
      "PersonFullName": "Brain Bartoletti",
      "ContactId": 540,
      "ContactName": "Rippin-Nicolas",
      "ContactDepartment": "",
      "NumAttachments": 932,
      "EmailHeader": "gerda_miller@bergesenger.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "amet",
      "Sentiment": 196,
      "SentimentConfidence": 95,
      "CreatedBy": 516,
      "ChangedAt": "2007-03-22T02:30:52.9599012+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 900
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 814,
      "Name": "Carroll LLC",
      "ToolTip": "Ut tempora ipsam eum ipsum qui laboriosam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 452
        }
      }
    },
    {
      "Id": 814,
      "Name": "Carroll LLC",
      "ToolTip": "Ut tempora ipsam eum ipsum qui laboriosam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 452
        }
      }
    }
  ],
  "Language": "eos",
  "Sentiment": 874,
  "SentimentConfidence": 619,
  "SuggestedCategoryId": 862,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 594,
  "IconHint": "impedit",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 912,
  "ExtraFields": {
    "ExtraFields1": "ex",
    "ExtraFields2": "laboriosam"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "quibusdam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 588
    }
  }
}
```