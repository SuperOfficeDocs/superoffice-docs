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
  "TicketId": 552,
  "Title": "eum",
  "CreatedAt": "2013-02-08T02:38:26.4329026+01:00",
  "LastChanged": "2009-04-26T02:38:26.4329026+02:00",
  "ReadByOwner": "2015-02-15T02:38:26.4329026+01:00",
  "ReadByCustomer": "2020-03-18T02:38:26.4329026+01:00",
  "FirstReadByOwner": "2019-07-04T02:38:26.4329026+02:00",
  "FirstReadByUser": "2014-12-26T02:38:26.4329026+01:00",
  "Activate": "2020-12-10T02:38:26.4329026+01:00",
  "ClosedAt": "2017-11-17T02:38:26.4329026+01:00",
  "RepliedAt": "2002-01-14T02:38:26.4329026+01:00",
  "AlertTimeout": "2003-08-13T02:38:26.4329026+02:00",
  "Deadline": "2020-10-22T02:38:26.4329026+02:00",
  "CreatedBy": null,
  "Author": "in",
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
      "Position": "rem",
      "PersonId": 766,
      "Mrmrs": "placeat",
      "Firstname": "Isai",
      "Lastname": "Conn",
      "MiddleName": "Schmidt, Wolff and Beer",
      "Title": "aut",
      "Description": "Diverse systemic website",
      "Email": "lempi.kub@rempellittel.name",
      "FullName": "Cecelia Ryan",
      "DirectPhone": "1-706-656-6452",
      "FormalName": "Conn-Miller",
      "CountryId": 762,
      "ContactId": 70,
      "ContactName": "Farrell, Johnston and Casper",
      "Retired": 358,
      "Rank": 96,
      "ActiveInterests": 882,
      "ContactDepartment": "",
      "ContactCountryId": 995,
      "ContactOrgNr": "1109716",
      "FaxPhone": "998-467-0063 x787",
      "MobilePhone": "593-785-9063",
      "ContactPhone": "623.852.8285 x109",
      "AssociateName": "Hettinger, Bailey and Cronin",
      "AssociateId": 535,
      "UsePersonAddress": false,
      "ContactFax": "molestiae",
      "Kanafname": "dolores",
      "Kanalname": "expedita",
      "Post1": "cupiditate",
      "Post2": "hic",
      "Post3": "in",
      "EmailName": "alisha@grant.us",
      "ContactFullName": "Elvera Effertz",
      "ActiveErpLinks": 798,
      "TicketPriorityId": 247,
      "SupportLanguageId": 40,
      "SupportAssociateId": 785,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1189520"
    }
  ],
  "AlertLevel": 286,
  "ConnectId": 465,
  "ReadStatus": "Green",
  "TimeToReply": 820,
  "RealTimeToReply": 380,
  "TimeToClose": 563,
  "RealTimeToClose": 474,
  "TimeSpentInternally": 428,
  "TimeSpentExternally": 696,
  "TimeSpentQueue": 804,
  "RealTimeSpentInternally": 893,
  "RealTimeSpentExternally": 391,
  "RealTimeSpentQueue": 137,
  "TimeSpent": 459,
  "HasAttachment": false,
  "NumReplies": 162,
  "NumMessages": 732,
  "FromAddress": "suscipit",
  "Messages": [
    {
      "TicketMessageId": 277,
      "CreatedAt": "2017-07-04T02:38:26.4485305+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "adipisci",
      "PersonId": 84,
      "PersonFullName": "Jed Hilll Jr.",
      "ContactId": 101,
      "ContactName": "O'Conner, Kiehn and Donnelly",
      "ContactDepartment": "",
      "NumAttachments": 794,
      "EmailHeader": "savannah.harris@bartoletti.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "labore",
      "Sentiment": 77,
      "SentimentConfidence": 462,
      "CreatedBy": 895,
      "ChangedAt": "1998-12-05T02:38:26.4485305+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 847,
      "Name": "Towne-King",
      "ToolTip": "Error rerum quibusdam aut."
    },
    {
      "Id": 847,
      "Name": "Towne-King",
      "ToolTip": "Error rerum quibusdam aut."
    }
  ],
  "Language": "quisquam",
  "Sentiment": 64,
  "SentimentConfidence": 43,
  "SuggestedCategoryId": 355,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 770,
  "IconHint": "sed",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 249,
  "ExtraFields": {
    "ExtraFields1": "quisquam",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "rem",
    "CustomFields2": "dolores"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 719,
  "Title": "sed",
  "CreatedAt": "2012-09-15T02:38:26.4485305+02:00",
  "LastChanged": "2005-08-13T02:38:26.4485305+02:00",
  "ReadByOwner": "2000-10-08T02:38:26.4485305+02:00",
  "ReadByCustomer": "2012-08-07T02:38:26.4485305+02:00",
  "FirstReadByOwner": "2005-02-23T02:38:26.4485305+01:00",
  "FirstReadByUser": "2010-01-21T02:38:26.4485305+01:00",
  "Activate": "2005-05-31T02:38:26.4485305+02:00",
  "ClosedAt": "2022-04-29T02:38:26.4485305+02:00",
  "RepliedAt": "2018-08-11T02:38:26.4485305+02:00",
  "AlertTimeout": "2007-01-17T02:38:26.4485305+01:00",
  "Deadline": "2007-10-01T02:38:26.4485305+02:00",
  "CreatedBy": null,
  "Author": "quisquam",
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
      "Position": "voluptatibus",
      "PersonId": 510,
      "Mrmrs": "reprehenderit",
      "Firstname": "Houston",
      "Lastname": "Stokes",
      "MiddleName": "Schultz-D'Amore",
      "Title": "veritatis",
      "Description": "Operative non-volatile access",
      "Email": "jeramie.bogan@crooksohara.com",
      "FullName": "Jackeline Raynor MD",
      "DirectPhone": "296.195.5850",
      "FormalName": "King LLC",
      "CountryId": 265,
      "ContactId": 515,
      "ContactName": "O'Conner, Hand and Carroll",
      "Retired": 832,
      "Rank": 435,
      "ActiveInterests": 461,
      "ContactDepartment": "",
      "ContactCountryId": 620,
      "ContactOrgNr": "894319",
      "FaxPhone": "302-391-9085 x27080",
      "MobilePhone": "126.681.3624",
      "ContactPhone": "1-316-850-2801 x375",
      "AssociateName": "Harris, Blanda and Hyatt",
      "AssociateId": 294,
      "UsePersonAddress": false,
      "ContactFax": "itaque",
      "Kanafname": "incidunt",
      "Kanalname": "itaque",
      "Post1": "in",
      "Post2": "dolore",
      "Post3": "atque",
      "EmailName": "selena@koelpinmayer.co.uk",
      "ContactFullName": "Dolly Pouros MD",
      "ActiveErpLinks": 960,
      "TicketPriorityId": 962,
      "SupportLanguageId": 471,
      "SupportAssociateId": 492,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1198954",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 355
        }
      }
    }
  ],
  "AlertLevel": 707,
  "ConnectId": 933,
  "ReadStatus": "Green",
  "TimeToReply": 724,
  "RealTimeToReply": 432,
  "TimeToClose": 675,
  "RealTimeToClose": 768,
  "TimeSpentInternally": 4,
  "TimeSpentExternally": 384,
  "TimeSpentQueue": 946,
  "RealTimeSpentInternally": 950,
  "RealTimeSpentExternally": 460,
  "RealTimeSpentQueue": 359,
  "TimeSpent": 461,
  "HasAttachment": false,
  "NumReplies": 888,
  "NumMessages": 680,
  "FromAddress": "blanditiis",
  "Messages": [
    {
      "TicketMessageId": 60,
      "CreatedAt": "2016-08-09T02:38:26.4485305+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "vel",
      "PersonId": 852,
      "PersonFullName": "Edgar Runolfsson",
      "ContactId": 156,
      "ContactName": "Hamill-Shanahan",
      "ContactDepartment": "",
      "NumAttachments": 811,
      "EmailHeader": "nelson@boehm.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "dolore",
      "Sentiment": 350,
      "SentimentConfidence": 466,
      "CreatedBy": 964,
      "ChangedAt": "2007-03-12T02:38:26.4485305+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 723
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 897,
      "Name": "Veum, Huels and Durgan",
      "ToolTip": "Aut quam ut aut assumenda aut harum perferendis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 688
        }
      }
    },
    {
      "Id": 897,
      "Name": "Veum, Huels and Durgan",
      "ToolTip": "Aut quam ut aut assumenda aut harum perferendis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 688
        }
      }
    }
  ],
  "Language": "sit",
  "Sentiment": 657,
  "SentimentConfidence": 102,
  "SuggestedCategoryId": 595,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 807,
  "IconHint": "tenetur",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 960,
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "laboriosam"
  },
  "CustomFields": {
    "CustomFields1": "sequi",
    "CustomFields2": "praesentium"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 403
    }
  }
}
```