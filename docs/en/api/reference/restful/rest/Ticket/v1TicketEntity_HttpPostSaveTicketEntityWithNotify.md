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
  "TicketId": 547,
  "Title": "consequuntur",
  "CreatedAt": "2017-04-17T13:14:09.2278972+02:00",
  "LastChanged": "2017-06-25T13:14:09.2278972+02:00",
  "ReadByOwner": "2018-09-10T13:14:09.2278972+02:00",
  "ReadByCustomer": "2005-09-07T13:14:09.2278972+02:00",
  "FirstReadByOwner": "2009-02-01T13:14:09.2278972+01:00",
  "FirstReadByUser": "2024-07-10T13:14:09.2278972+02:00",
  "Activate": "2022-07-29T13:14:09.2278972+02:00",
  "ClosedAt": "2015-06-17T13:14:09.2278972+02:00",
  "RepliedAt": "2018-12-22T13:14:09.2278972+01:00",
  "AlertTimeout": "2021-10-20T13:14:09.2278972+02:00",
  "Deadline": "2020-07-13T13:14:09.2278972+02:00",
  "CreatedBy": null,
  "Author": "tempore",
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
      "Position": "dicta",
      "PersonId": 973,
      "Mrmrs": "amet",
      "Firstname": "Rickey",
      "Lastname": "Kuphal",
      "MiddleName": "Emmerich, Shields and Bruen",
      "Title": "corporis",
      "Description": "Digitized optimal projection",
      "Email": "wilton@schmittreynolds.name",
      "FullName": "Abbigail Wiegand",
      "DirectPhone": "243.029.6518 x1015",
      "FormalName": "Cormier, Marks and Mitchell",
      "CountryId": 651,
      "ContactId": 518,
      "ContactName": "VonRueden, Marquardt and Barrows",
      "Retired": 210,
      "Rank": 4,
      "ActiveInterests": 71,
      "ContactDepartment": "",
      "ContactCountryId": 155,
      "ContactOrgNr": "965077",
      "FaxPhone": "1-022-645-7071 x42411",
      "MobilePhone": "985.966.3879",
      "ContactPhone": "208-571-2296",
      "AssociateName": "Waters Group",
      "AssociateId": 718,
      "UsePersonAddress": false,
      "ContactFax": "voluptatem",
      "Kanafname": "at",
      "Kanalname": "ipsum",
      "Post1": "odit",
      "Post2": "eveniet",
      "Post3": "eos",
      "EmailName": "vivien@runolfsson.name",
      "ContactFullName": "Della Auer Sr.",
      "ActiveErpLinks": 767,
      "TicketPriorityId": 502,
      "SupportLanguageId": 345,
      "SupportAssociateId": 108,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1410513"
    }
  ],
  "AlertLevel": 190,
  "ConnectId": 833,
  "ReadStatus": "Green",
  "TimeToReply": 316,
  "RealTimeToReply": 786,
  "TimeToClose": 859,
  "RealTimeToClose": 41,
  "TimeSpentInternally": 424,
  "TimeSpentExternally": 674,
  "TimeSpentQueue": 704,
  "RealTimeSpentInternally": 22,
  "RealTimeSpentExternally": 932,
  "RealTimeSpentQueue": 51,
  "TimeSpent": 200,
  "HasAttachment": true,
  "NumReplies": 143,
  "NumMessages": 288,
  "FromAddress": "ea",
  "Messages": [
    {
      "TicketMessageId": 503,
      "CreatedAt": "2012-03-13T13:14:09.2278972+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "qui",
      "PersonId": 27,
      "PersonFullName": "Virgie Jonathan Thiel Sr.",
      "ContactId": 831,
      "ContactName": "Brekke LLC",
      "ContactDepartment": "",
      "NumAttachments": 870,
      "EmailHeader": "caleigh@watsica.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "sit",
      "Sentiment": 348,
      "SentimentConfidence": 618,
      "CreatedBy": 375,
      "ChangedAt": "2006-01-12T13:14:09.2278972+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 924,
      "Name": "Monahan-Bode",
      "ToolTip": "Vel et sed hic facere."
    },
    {
      "Id": 924,
      "Name": "Monahan-Bode",
      "ToolTip": "Vel et sed hic facere."
    }
  ],
  "Language": "sint",
  "Sentiment": 709,
  "SentimentConfidence": 999,
  "SuggestedCategoryId": 460,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 875,
  "IconHint": "repellendus",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 239,
  "ExtraFields": {
    "ExtraFields1": "facere",
    "ExtraFields2": "in"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "voluptate"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 584,
  "Title": "aut",
  "CreatedAt": "1999-02-09T13:14:09.2435229+01:00",
  "LastChanged": "2005-02-16T13:14:09.2435229+01:00",
  "ReadByOwner": "2011-10-27T13:14:09.2435229+02:00",
  "ReadByCustomer": "2022-07-06T13:14:09.2435229+02:00",
  "FirstReadByOwner": "2003-12-14T13:14:09.2435229+01:00",
  "FirstReadByUser": "2010-04-24T13:14:09.2435229+02:00",
  "Activate": "2017-04-09T13:14:09.2435229+02:00",
  "ClosedAt": "1999-04-28T13:14:09.2435229+02:00",
  "RepliedAt": "2013-04-29T13:14:09.2435229+02:00",
  "AlertTimeout": "2015-05-08T13:14:09.2435229+02:00",
  "Deadline": "2012-05-20T13:14:09.2435229+02:00",
  "CreatedBy": null,
  "Author": "blanditiis",
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
      "Position": "eaque",
      "PersonId": 197,
      "Mrmrs": "earum",
      "Firstname": "Daphne",
      "Lastname": "Paucek",
      "MiddleName": "Padberg Group",
      "Title": "fuga",
      "Description": "Assimilated incremental framework",
      "Email": "osborne@mueller.com",
      "FullName": "Emilie Hoppe",
      "DirectPhone": "512.999.0813 x145",
      "FormalName": "Krajcik-Kuhlman",
      "CountryId": 453,
      "ContactId": 825,
      "ContactName": "Kshlerin-Botsford",
      "Retired": 174,
      "Rank": 764,
      "ActiveInterests": 257,
      "ContactDepartment": "",
      "ContactCountryId": 329,
      "ContactOrgNr": "897732",
      "FaxPhone": "(774)911-7469 x3902",
      "MobilePhone": "787-840-6127",
      "ContactPhone": "721.350.5895 x024",
      "AssociateName": "Langworth LLC",
      "AssociateId": 628,
      "UsePersonAddress": false,
      "ContactFax": "amet",
      "Kanafname": "et",
      "Kanalname": "nemo",
      "Post1": "corporis",
      "Post2": "rerum",
      "Post3": "praesentium",
      "EmailName": "quinn@altenwerthhagenes.info",
      "ContactFullName": "Miss Alexis Mertz",
      "ActiveErpLinks": 547,
      "TicketPriorityId": 133,
      "SupportLanguageId": 945,
      "SupportAssociateId": 111,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1639921",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 914
        }
      }
    }
  ],
  "AlertLevel": 440,
  "ConnectId": 240,
  "ReadStatus": "Green",
  "TimeToReply": 937,
  "RealTimeToReply": 563,
  "TimeToClose": 115,
  "RealTimeToClose": 929,
  "TimeSpentInternally": 579,
  "TimeSpentExternally": 701,
  "TimeSpentQueue": 151,
  "RealTimeSpentInternally": 682,
  "RealTimeSpentExternally": 886,
  "RealTimeSpentQueue": 815,
  "TimeSpent": 760,
  "HasAttachment": true,
  "NumReplies": 726,
  "NumMessages": 80,
  "FromAddress": "est",
  "Messages": [
    {
      "TicketMessageId": 122,
      "CreatedAt": "2001-06-10T13:14:09.2435229+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "est",
      "PersonId": 437,
      "PersonFullName": "Gerhard Stokes",
      "ContactId": 409,
      "ContactName": "Grady-Hessel",
      "ContactDepartment": "",
      "NumAttachments": 730,
      "EmailHeader": "penelope_rohan@mertzsenger.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "pariatur",
      "Sentiment": 348,
      "SentimentConfidence": 234,
      "CreatedBy": 429,
      "ChangedAt": "2024-02-07T13:14:09.2435229+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 378
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 186,
      "Name": "Toy Group",
      "ToolTip": "Nostrum rerum placeat maiores.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 584
        }
      }
    },
    {
      "Id": 186,
      "Name": "Toy Group",
      "ToolTip": "Nostrum rerum placeat maiores.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 584
        }
      }
    }
  ],
  "Language": "maiores",
  "Sentiment": 884,
  "SentimentConfidence": 858,
  "SuggestedCategoryId": 191,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 38,
  "IconHint": "accusamus",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 149,
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "unde"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 86
    }
  }
}
```