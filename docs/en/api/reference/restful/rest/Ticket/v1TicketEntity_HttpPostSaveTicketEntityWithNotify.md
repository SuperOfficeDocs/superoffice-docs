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
  "TicketId": 848,
  "Title": "culpa",
  "CreatedAt": "2006-05-23T11:22:45.2412009+02:00",
  "LastChanged": "2015-05-01T11:22:45.2412009+02:00",
  "ReadByOwner": "2020-05-14T11:22:45.2412009+02:00",
  "ReadByCustomer": "2006-05-26T11:22:45.2412009+02:00",
  "FirstReadByOwner": "2006-05-18T11:22:45.2412009+02:00",
  "FirstReadByUser": "2007-05-11T11:22:45.2412009+02:00",
  "Activate": "2010-03-24T11:22:45.2412009+01:00",
  "ClosedAt": "2019-01-16T11:22:45.2412009+01:00",
  "RepliedAt": "2005-04-12T11:22:45.2412009+02:00",
  "AlertTimeout": "1998-11-15T11:22:45.2412009+01:00",
  "Deadline": "2010-07-25T11:22:45.2412009+02:00",
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
      "Position": "explicabo",
      "PersonId": 120,
      "Mrmrs": "quasi",
      "Firstname": "Rogers",
      "Lastname": "Will",
      "MiddleName": "Satterfield LLC",
      "Title": "cum",
      "Description": "Optimized explicit project",
      "Email": "lavinia@bogan.biz",
      "FullName": "Prof. Arlo Runolfsson",
      "DirectPhone": "(471)574-3660",
      "FormalName": "Larkin, Swaniawski and Renner",
      "CountryId": 852,
      "ContactId": 656,
      "ContactName": "Nader-Nader",
      "Retired": 770,
      "Rank": 880,
      "ActiveInterests": 650,
      "ContactDepartment": "",
      "ContactCountryId": 120,
      "ContactOrgNr": "1218384",
      "FaxPhone": "1-881-520-5408 x333",
      "MobilePhone": "1-053-708-4217 x0987",
      "ContactPhone": "1-419-060-5680",
      "AssociateName": "Abernathy Inc and Sons",
      "AssociateId": 713,
      "UsePersonAddress": false,
      "ContactFax": "eveniet",
      "Kanafname": "explicabo",
      "Kanalname": "et",
      "Post1": "accusantium",
      "Post2": "nisi",
      "Post3": "qui",
      "EmailName": "roman.bogan@schmitt.ca",
      "ContactFullName": "Ana Willms",
      "ActiveErpLinks": 339,
      "TicketPriorityId": 832,
      "SupportLanguageId": 457,
      "SupportAssociateId": 776,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 663,
  "ConnectId": 978,
  "ReadStatus": "Green",
  "TimeToReply": 491,
  "RealTimeToReply": 6,
  "TimeToClose": 388,
  "RealTimeToClose": 510,
  "TimeSpentInternally": 414,
  "TimeSpentExternally": 377,
  "TimeSpentQueue": 755,
  "RealTimeSpentInternally": 85,
  "RealTimeSpentExternally": 901,
  "RealTimeSpentQueue": 66,
  "HasAttachment": false,
  "NumReplies": 907,
  "NumMessages": 593,
  "FromAddress": "delectus",
  "Messages": [
    {
      "TicketMessageId": 201,
      "CreatedAt": "2007-06-03T11:22:45.2568241+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "consequatur",
      "PersonId": 422,
      "PersonFullName": "Valentin Ryan I",
      "ContactId": 720,
      "ContactName": "Anderson-Rowe",
      "ContactDepartment": "",
      "NumAttachments": 119,
      "EmailHeader": "emmalee@dietrich.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "doloremque",
      "Sentiment": 101,
      "SentimentConfidence": 183,
      "CreatedBy": 374,
      "ChangedAt": "2014-03-30T11:22:45.2568241+02:00"
    }
  ],
  "Tags": [
    {
      "Id": 735,
      "Name": "Parisian Group",
      "ToolTip": "Ut error dolore."
    },
    {
      "Id": 735,
      "Name": "Parisian Group",
      "ToolTip": "Ut error dolore."
    }
  ],
  "Language": "hic",
  "Sentiment": 754,
  "SentimentConfidence": 641,
  "SuggestedCategoryId": 116,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 178,
  "IconHint": "iste",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "quae",
    "ExtraFields2": "quis"
  },
  "CustomFields": {
    "CustomFields1": "quisquam",
    "CustomFields2": "porro"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 113,
  "Title": "aut",
  "CreatedAt": "2005-11-03T11:22:45.2568241+01:00",
  "LastChanged": "2003-12-31T11:22:45.2568241+01:00",
  "ReadByOwner": "2000-04-30T11:22:45.2568241+02:00",
  "ReadByCustomer": "2016-02-02T11:22:45.2568241+01:00",
  "FirstReadByOwner": "2021-12-28T11:22:45.2568241+01:00",
  "FirstReadByUser": "2009-09-03T11:22:45.2568241+02:00",
  "Activate": "1999-01-25T11:22:45.2568241+01:00",
  "ClosedAt": "2009-04-24T11:22:45.2568241+02:00",
  "RepliedAt": "2003-11-19T11:22:45.2568241+01:00",
  "AlertTimeout": "2006-04-08T11:22:45.2568241+02:00",
  "Deadline": "2001-11-21T11:22:45.2568241+01:00",
  "CreatedBy": null,
  "Author": "asperiores",
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
      "PersonId": 535,
      "Mrmrs": "ex",
      "Firstname": "Jennyfer",
      "Lastname": "Crist",
      "MiddleName": "Grimes LLC",
      "Title": "facere",
      "Description": "Multi-tiered foreground methodology",
      "Email": "christina@oreillyrippin.biz",
      "FullName": "Heaven Deckow",
      "DirectPhone": "233.476.6716 x4836",
      "FormalName": "Jacobson LLC",
      "CountryId": 43,
      "ContactId": 410,
      "ContactName": "Considine, Lynch and Oberbrunner",
      "Retired": 4,
      "Rank": 99,
      "ActiveInterests": 417,
      "ContactDepartment": "",
      "ContactCountryId": 102,
      "ContactOrgNr": "752722",
      "FaxPhone": "347-490-4658 x454",
      "MobilePhone": "834-738-0747 x8566",
      "ContactPhone": "608.030.2025",
      "AssociateName": "Von-Moen",
      "AssociateId": 858,
      "UsePersonAddress": true,
      "ContactFax": "quia",
      "Kanafname": "quae",
      "Kanalname": "dolor",
      "Post1": "sint",
      "Post2": "sint",
      "Post3": "veritatis",
      "EmailName": "roberto_beahan@jast.us",
      "ContactFullName": "Zena Julien Hammes DVM",
      "ActiveErpLinks": 446,
      "TicketPriorityId": 127,
      "SupportLanguageId": 144,
      "SupportAssociateId": 612,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 601
        }
      }
    }
  ],
  "AlertLevel": 5,
  "ConnectId": 195,
  "ReadStatus": "Green",
  "TimeToReply": 313,
  "RealTimeToReply": 641,
  "TimeToClose": 236,
  "RealTimeToClose": 272,
  "TimeSpentInternally": 144,
  "TimeSpentExternally": 12,
  "TimeSpentQueue": 149,
  "RealTimeSpentInternally": 856,
  "RealTimeSpentExternally": 66,
  "RealTimeSpentQueue": 669,
  "HasAttachment": false,
  "NumReplies": 798,
  "NumMessages": 479,
  "FromAddress": "sed",
  "Messages": [
    {
      "TicketMessageId": 786,
      "CreatedAt": "2020-08-02T11:22:45.2568241+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "eligendi",
      "PersonId": 928,
      "PersonFullName": "Evalyn Fahey",
      "ContactId": 998,
      "ContactName": "Williamson Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 698,
      "EmailHeader": "laurel@heller.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "voluptas",
      "Sentiment": 72,
      "SentimentConfidence": 431,
      "CreatedBy": 44,
      "ChangedAt": "2016-05-08T11:22:45.2568241+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 790
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 811,
      "Name": "Glover Inc and Sons",
      "ToolTip": "Rerum ducimus quia maiores doloribus est at.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 187
        }
      }
    },
    {
      "Id": 811,
      "Name": "Glover Inc and Sons",
      "ToolTip": "Rerum ducimus quia maiores doloribus est at.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 187
        }
      }
    }
  ],
  "Language": "et",
  "Sentiment": 509,
  "SentimentConfidence": 299,
  "SuggestedCategoryId": 419,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 716,
  "IconHint": "officiis",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "placeat",
    "ExtraFields2": "quos"
  },
  "CustomFields": {
    "CustomFields1": "quas",
    "CustomFields2": "minima"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 880
    }
  }
}
```