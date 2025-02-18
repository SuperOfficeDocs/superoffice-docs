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
  "TicketId": 176,
  "Title": "explicabo",
  "CreatedAt": "2013-10-06T14:32:12.0990623+02:00",
  "LastChanged": "2006-08-30T14:32:12.0990623+02:00",
  "ReadByOwner": "2005-07-13T14:32:12.0990623+02:00",
  "ReadByCustomer": "2003-08-11T14:32:12.0990623+02:00",
  "FirstReadByOwner": "2008-12-05T14:32:12.0990623+01:00",
  "FirstReadByUser": "2024-08-06T14:32:12.0990623+02:00",
  "Activate": "2016-05-13T14:32:12.0990623+02:00",
  "ClosedAt": "2023-03-22T14:32:12.0990623+01:00",
  "RepliedAt": "2021-05-18T14:32:12.0990623+02:00",
  "AlertTimeout": "2019-07-23T14:32:12.0990623+02:00",
  "Deadline": "1999-07-14T14:32:12.0990623+02:00",
  "CreatedBy": null,
  "Author": "commodi",
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
      "Position": "amet",
      "PersonId": 309,
      "Mrmrs": "pariatur",
      "Firstname": "Adolphus",
      "Lastname": "Blick",
      "MiddleName": "Schiller Inc and Sons",
      "Title": "et",
      "Description": "Virtual secondary interface",
      "Email": "lesley_cartwright@schulisthintz.co.uk",
      "FullName": "Miss Kacie Octavia Davis",
      "DirectPhone": "801.322.2533",
      "FormalName": "Purdy, Lakin and Morar",
      "CountryId": 679,
      "ContactId": 134,
      "ContactName": "Zulauf, Will and Bernhard",
      "Retired": 724,
      "Rank": 24,
      "ActiveInterests": 471,
      "ContactDepartment": "",
      "ContactCountryId": 43,
      "ContactOrgNr": "318619",
      "FaxPhone": "(666)591-1782",
      "MobilePhone": "685.599.4703",
      "ContactPhone": "(820)624-5038",
      "AssociateName": "Skiles LLC",
      "AssociateId": 661,
      "UsePersonAddress": true,
      "ContactFax": "facilis",
      "Kanafname": "laudantium",
      "Kanalname": "expedita",
      "Post1": "deleniti",
      "Post2": "eaque",
      "Post3": "et",
      "EmailName": "adrain.ritchie@kunde.info",
      "ContactFullName": "Winfield Crist",
      "ActiveErpLinks": 969,
      "TicketPriorityId": 521,
      "SupportLanguageId": 966,
      "SupportAssociateId": 285,
      "CategoryName": "VIP Customer",
      "PersonNumber": "879887"
    }
  ],
  "AlertLevel": 499,
  "ConnectId": 529,
  "ReadStatus": "Green",
  "TimeToReply": 623,
  "RealTimeToReply": 105,
  "TimeToClose": 440,
  "RealTimeToClose": 748,
  "TimeSpentInternally": 337,
  "TimeSpentExternally": 851,
  "TimeSpentQueue": 690,
  "RealTimeSpentInternally": 439,
  "RealTimeSpentExternally": 88,
  "RealTimeSpentQueue": 163,
  "TimeSpent": 782,
  "HasAttachment": true,
  "NumReplies": 578,
  "NumMessages": 314,
  "FromAddress": "enim",
  "Messages": [
    {
      "TicketMessageId": 487,
      "CreatedAt": "2019-02-07T14:32:12.0990623+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "nobis",
      "PersonId": 28,
      "PersonFullName": "Ryley Volkman",
      "ContactId": 761,
      "ContactName": "Orn, Hand and Gutkowski",
      "ContactDepartment": "engineer virtual eyeballs",
      "NumAttachments": 33,
      "EmailHeader": "jimmy_wuckert@muellerconnelly.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "sunt",
      "Sentiment": 108,
      "SentimentConfidence": 3,
      "CreatedBy": 892,
      "ChangedAt": "2000-04-21T14:32:12.0990623+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 945,
      "Name": "Wiza Inc and Sons",
      "ToolTip": "Provident placeat."
    },
    {
      "Id": 945,
      "Name": "Wiza Inc and Sons",
      "ToolTip": "Provident placeat."
    }
  ],
  "Language": "veritatis",
  "Sentiment": 369,
  "SentimentConfidence": 741,
  "SuggestedCategoryId": 372,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 617,
  "IconHint": "sed",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 256,
  "ExtraFields": {
    "ExtraFields1": "fuga",
    "ExtraFields2": "eveniet"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "exercitationem"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 347,
  "Title": "maxime",
  "CreatedAt": "1997-11-12T14:32:12.0990623+01:00",
  "LastChanged": "2007-05-31T14:32:12.0990623+02:00",
  "ReadByOwner": "2002-02-10T14:32:12.0990623+01:00",
  "ReadByCustomer": "2023-01-15T14:32:12.0990623+01:00",
  "FirstReadByOwner": "2002-01-17T14:32:12.0990623+01:00",
  "FirstReadByUser": "2012-01-11T14:32:12.0990623+01:00",
  "Activate": "2017-02-14T14:32:12.0990623+01:00",
  "ClosedAt": "2008-03-21T14:32:12.0990623+01:00",
  "RepliedAt": "2005-06-06T14:32:12.0990623+02:00",
  "AlertTimeout": "2011-02-23T14:32:12.0990623+01:00",
  "Deadline": "2006-02-28T14:32:12.0990623+01:00",
  "CreatedBy": null,
  "Author": "nesciunt",
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
      "Position": "placeat",
      "PersonId": 639,
      "Mrmrs": "cupiditate",
      "Firstname": "Giovani",
      "Lastname": "Beatty",
      "MiddleName": "Moore Group",
      "Title": "expedita",
      "Description": "Optimized reciprocal customer loyalty",
      "Email": "sid@trantowankunding.com",
      "FullName": "Julien Greenholt",
      "DirectPhone": "1-631-199-4303 x65454",
      "FormalName": "Marquardt LLC",
      "CountryId": 611,
      "ContactId": 213,
      "ContactName": "Baumbach-Christiansen",
      "Retired": 29,
      "Rank": 355,
      "ActiveInterests": 388,
      "ContactDepartment": "incentivize ubiquitous synergies",
      "ContactCountryId": 732,
      "ContactOrgNr": "912546",
      "FaxPhone": "1-270-764-9309 x9543",
      "MobilePhone": "(038)157-7848 x4193",
      "ContactPhone": "1-195-324-0582",
      "AssociateName": "Herzog-Emmerich",
      "AssociateId": 280,
      "UsePersonAddress": true,
      "ContactFax": "ut",
      "Kanafname": "rerum",
      "Kanalname": "nulla",
      "Post1": "beatae",
      "Post2": "commodi",
      "Post3": "perferendis",
      "EmailName": "shakira_jewess@terrypowlowski.us",
      "ContactFullName": "Mr. Crystel Felicity Nicolas",
      "ActiveErpLinks": 363,
      "TicketPriorityId": 607,
      "SupportLanguageId": 446,
      "SupportAssociateId": 378,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1244769",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 970
        }
      }
    }
  ],
  "AlertLevel": 200,
  "ConnectId": 172,
  "ReadStatus": "Green",
  "TimeToReply": 875,
  "RealTimeToReply": 14,
  "TimeToClose": 885,
  "RealTimeToClose": 956,
  "TimeSpentInternally": 845,
  "TimeSpentExternally": 1001,
  "TimeSpentQueue": 709,
  "RealTimeSpentInternally": 488,
  "RealTimeSpentExternally": 957,
  "RealTimeSpentQueue": 36,
  "TimeSpent": 394,
  "HasAttachment": false,
  "NumReplies": 787,
  "NumMessages": 633,
  "FromAddress": "aliquam",
  "Messages": [
    {
      "TicketMessageId": 97,
      "CreatedAt": "1997-12-31T14:32:12.1146845+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "aut",
      "PersonId": 144,
      "PersonFullName": "Miss Joel Miller",
      "ContactId": 809,
      "ContactName": "McGlynn-Hammes",
      "ContactDepartment": "drive scalable mindshare",
      "NumAttachments": 64,
      "EmailHeader": "abagail@bogankohler.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "autem",
      "Sentiment": 485,
      "SentimentConfidence": 250,
      "CreatedBy": 151,
      "ChangedAt": "2016-03-20T14:32:12.1146845+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 308
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 774,
      "Name": "Larson-Tremblay",
      "ToolTip": "Molestiae rerum nihil necessitatibus molestiae vel voluptate qui.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 563
        }
      }
    },
    {
      "Id": 774,
      "Name": "Larson-Tremblay",
      "ToolTip": "Molestiae rerum nihil necessitatibus molestiae vel voluptate qui.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 563
        }
      }
    }
  ],
  "Language": "a",
  "Sentiment": 302,
  "SentimentConfidence": 195,
  "SuggestedCategoryId": 660,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 954,
  "IconHint": "dolor",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 760,
  "ExtraFields": {
    "ExtraFields1": "expedita",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "officia",
    "CustomFields2": "eum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 741
    }
  }
}
```