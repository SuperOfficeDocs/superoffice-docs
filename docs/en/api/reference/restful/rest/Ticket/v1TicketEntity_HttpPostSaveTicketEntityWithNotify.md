---
title: POST Ticket
uid: v1TicketEntity_HttpPostSaveTicketEntityWithNotify
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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Ticket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 283,
  "Title": "consectetur",
  "CreatedAt": "1999-03-03T17:37:39.2513093+01:00",
  "LastChanged": "2021-07-07T17:37:39.2513093+02:00",
  "ReadByOwner": "2010-06-26T17:37:39.2513093+02:00",
  "ReadByCustomer": "2008-10-19T17:37:39.2513093+02:00",
  "FirstReadByOwner": "2022-04-02T17:37:39.2513093+02:00",
  "FirstReadByUser": "2008-12-05T17:37:39.2513093+01:00",
  "Activate": "2010-07-23T17:37:39.2513093+02:00",
  "ClosedAt": "2004-12-31T17:37:39.2513093+01:00",
  "RepliedAt": "2017-09-07T17:37:39.2513093+02:00",
  "AlertTimeout": "2002-01-13T17:37:39.2513093+01:00",
  "Deadline": "2020-04-28T17:37:39.2513093+02:00",
  "CreatedBy": null,
  "Author": "aliquam",
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
      "Position": "cupiditate",
      "PersonId": 745,
      "Mrmrs": "nisi",
      "Firstname": "Bobbie",
      "Lastname": "Blanda",
      "MiddleName": "Hoppe-Goldner",
      "Title": "repellat",
      "Description": "Self-enabling responsive strategy",
      "Email": "gaylord.beer@sporerraynor.uk",
      "FullName": "Melany Lowe",
      "DirectPhone": "1-834-233-1833",
      "FormalName": "Pollich, Hagenes and Cronin",
      "CountryId": 927,
      "ContactId": 796,
      "ContactName": "Pfeffer-Skiles",
      "Retired": 939,
      "Rank": 869,
      "ActiveInterests": 218,
      "ContactDepartment": "",
      "ContactCountryId": 233,
      "ContactOrgNr": "899397",
      "FaxPhone": "(187)646-8791 x1978",
      "MobilePhone": "568-790-4429 x68003",
      "ContactPhone": "(653)263-0678",
      "AssociateName": "Pfannerstill-McCullough",
      "AssociateId": 717,
      "UsePersonAddress": true,
      "ContactFax": "odit",
      "Kanafname": "temporibus",
      "Kanalname": "voluptas",
      "Post1": "dolor",
      "Post2": "voluptas",
      "Post3": "natus",
      "EmailName": "christine@hermannwuckert.co.uk",
      "ContactFullName": "Mrs. Adonis Langworth",
      "ActiveErpLinks": 601,
      "TicketPriorityId": 65,
      "SupportLanguageId": 912,
      "SupportAssociateId": 444,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 435,
  "ConnectId": 786,
  "ReadStatus": "Green",
  "TimeToReply": 471,
  "RealTimeToReply": 376,
  "TimeToClose": 835,
  "RealTimeToClose": 545,
  "TimeSpentInternally": 435,
  "TimeSpentExternally": 272,
  "TimeSpentQueue": 967,
  "RealTimeSpentInternally": 632,
  "RealTimeSpentExternally": 17,
  "RealTimeSpentQueue": 72,
  "HasAttachment": false,
  "NumReplies": 179,
  "NumMessages": 807,
  "FromAddress": "delectus",
  "Messages": [
    {
      "TicketMessageId": 798,
      "CreatedAt": "2016-03-27T17:37:39.2562732+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "voluptate",
      "PersonId": 329,
      "PersonFullName": "Frieda Von",
      "ContactId": 231,
      "ContactName": "Zemlak Group",
      "ContactDepartment": "",
      "NumAttachments": 632,
      "EmailHeader": "casimer@lebsack.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "officia",
      "Sentiment": 48,
      "SentimentConfidence": 451,
      "CreatedBy": 667,
      "ChangedAt": "2005-12-07T17:37:39.2562732+01:00"
    }
  ],
  "Tags": [
    {
      "Id": 112,
      "Name": "Schaden Inc and Sons",
      "ToolTip": "Iure provident."
    },
    {
      "Id": 112,
      "Name": "Schaden Inc and Sons",
      "ToolTip": "Iure provident."
    }
  ],
  "Language": "illo",
  "Sentiment": 556,
  "SentimentConfidence": 129,
  "SuggestedCategoryId": 520,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 518,
  "IconHint": "occaecati",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "cumque",
    "ExtraFields2": "ea"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "pariatur"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 224,
  "Title": "et",
  "CreatedAt": "2021-09-17T17:37:39.2633034+02:00",
  "LastChanged": "2002-08-10T17:37:39.2633034+02:00",
  "ReadByOwner": "2002-12-04T17:37:39.2633034+01:00",
  "ReadByCustomer": "2009-01-29T17:37:39.2633034+01:00",
  "FirstReadByOwner": "2016-06-21T17:37:39.2633034+02:00",
  "FirstReadByUser": "1999-10-20T17:37:39.2633034+02:00",
  "Activate": "2017-05-17T17:37:39.2633034+02:00",
  "ClosedAt": "2006-06-08T17:37:39.2633034+02:00",
  "RepliedAt": "2009-11-04T17:37:39.2633034+01:00",
  "AlertTimeout": "2016-11-08T17:37:39.2633034+01:00",
  "Deadline": "1999-08-26T17:37:39.2633034+02:00",
  "CreatedBy": null,
  "Author": "voluptates",
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
      "Position": "neque",
      "PersonId": 371,
      "Mrmrs": "alias",
      "Firstname": "Genevieve",
      "Lastname": "Adams",
      "MiddleName": "Cummings, Langosh and Kuphal",
      "Title": "quis",
      "Description": "Vision-oriented context-sensitive archive",
      "Email": "georgiana@larsonschulist.co.uk",
      "FullName": "Mr. Adelle Rosalee Brakus I",
      "DirectPhone": "285-357-4562 x49577",
      "FormalName": "Keeling-Kautzer",
      "CountryId": 223,
      "ContactId": 43,
      "ContactName": "Blick, Hirthe and Ruecker",
      "Retired": 824,
      "Rank": 279,
      "ActiveInterests": 180,
      "ContactDepartment": "",
      "ContactCountryId": 515,
      "ContactOrgNr": "1623395",
      "FaxPhone": "115.869.4564 x471",
      "MobilePhone": "(090)775-9517 x62417",
      "ContactPhone": "1-912-359-5603 x138",
      "AssociateName": "Dickens LLC",
      "AssociateId": 504,
      "UsePersonAddress": false,
      "ContactFax": "eum",
      "Kanafname": "magni",
      "Kanalname": "laborum",
      "Post1": "nesciunt",
      "Post2": "repellat",
      "Post3": "repellat",
      "EmailName": "darron_satterfield@bednar.us",
      "ContactFullName": "Althea Rau",
      "ActiveErpLinks": 787,
      "TicketPriorityId": 240,
      "SupportLanguageId": 472,
      "SupportAssociateId": 536,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 740
        }
      }
    }
  ],
  "AlertLevel": 781,
  "ConnectId": 915,
  "ReadStatus": "Green",
  "TimeToReply": 138,
  "RealTimeToReply": 168,
  "TimeToClose": 818,
  "RealTimeToClose": 280,
  "TimeSpentInternally": 450,
  "TimeSpentExternally": 819,
  "TimeSpentQueue": 991,
  "RealTimeSpentInternally": 970,
  "RealTimeSpentExternally": 170,
  "RealTimeSpentQueue": 969,
  "HasAttachment": false,
  "NumReplies": 356,
  "NumMessages": 871,
  "FromAddress": "qui",
  "Messages": [
    {
      "TicketMessageId": 142,
      "CreatedAt": "2000-05-23T17:37:39.2673057+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "vero",
      "PersonId": 480,
      "PersonFullName": "Alba Weissnat",
      "ContactId": 443,
      "ContactName": "Heller-Hegmann",
      "ContactDepartment": "",
      "NumAttachments": 147,
      "EmailHeader": "rafael.pfeffer@kuhlmanblick.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quas",
      "Sentiment": 933,
      "SentimentConfidence": 99,
      "CreatedBy": 25,
      "ChangedAt": "2013-11-23T17:37:39.2673057+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 938
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 153,
      "Name": "Weissnat, Romaguera and Walter",
      "ToolTip": "Et omnis illo numquam temporibus quibusdam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 479
        }
      }
    },
    {
      "Id": 153,
      "Name": "Weissnat, Romaguera and Walter",
      "ToolTip": "Et omnis illo numquam temporibus quibusdam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 479
        }
      }
    }
  ],
  "Language": "repellat",
  "Sentiment": 537,
  "SentimentConfidence": 50,
  "SuggestedCategoryId": 793,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 145,
  "IconHint": "aut",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "quod"
  },
  "CustomFields": {
    "CustomFields1": "sequi",
    "CustomFields2": "illum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 236
    }
  }
}
```